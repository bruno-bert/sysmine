Imports System.Net
Imports iTextSharp.text.pdf
Imports HtmlAgilityPack


Public Class DiarioOficialSP

    Public Enum enMessageType
        _Error = 0
        Warning = 1
        Info = 2
    End Enum
    Public Structure strPaginaSecao
        Dim Secao As Integer
        Dim Paginas() As Integer
    End Structure


    Public Event sendMessage(ByVal message As String, ByVal type As Integer)

    Public Function PDFToText(ByVal file As String, ByVal page As Integer) As String
        Dim reader As PdfReader = New PdfReader(file)
        Dim text As String = ""
        Dim its As New iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy
        text = iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(reader, page, its)
        Return text
    End Function
    
    Public Function PegaRangePaginas(ByVal file As String, _
                                     ByVal Secao As Integer, _
                                     ByVal SubSecao As String) As Integer()



        Dim pageStart As Integer = 0
        Dim pageEnd As Integer = 0
        Dim pages() As Integer
        Dim j As Integer = 0
        Dim html As String = ""

        Dim doc As HtmlDocument

      
        html = IO.File.ReadAllText(file, Text.Encoding.Default)
        doc = New HtmlDocument
        doc.LoadHtml(html)


       
        Dim box As HtmlNode = doc.GetElementbyId("pg")
        Dim options As HtmlNodeCollection = box.SelectNodes("//option")
        Dim texto As String = ""
        Dim achouInicio As Boolean = False

        For Each opt As HtmlNode In options
            texto = opt.NextSibling.InnerText.ToString.Trim

            If texto.ToUpper.Contains(SubSecao.ToUpper) Then
                If pageStart = 0 Then pageStart = CInt(opt.Attributes("value").Value)
                achouInicio = True
            Else

                If achouInicio Then

                    If Not opt.NextSibling.InnerText.Contains("__") Then
                        pageEnd = CInt(opt.Attributes("value").Value)
                        Exit For
                    End If

                End If

            End If

        Next


      

        If pageStart <= pageEnd Then



            For i As Integer = pageStart To pageEnd
                ReDim Preserve pages(j)
                pages(j) = i
                j += 1
            Next



        End If

        Return pages

    End Function

    Public Function DownloadArquivoPrincipal(ByVal myDir As String, _
                                        ByVal keepFile As Boolean, _
                                        ByRef myFile As String, _
                                        ByVal url As String, _
                                        ByVal Secao As String) As Boolean
        Dim remoteUri As String = ""
        Dim stdFileName As String = "{0}.html"
        Dim fileName As String = ""
        Dim myStringWebResource As String = Nothing
        Dim myWebClient As New WebClient()

        Try

            RaiseEvent sendMessage("Iniciando download do arquivo principal do diário oficial do estado", enMessageType.Info)
            remoteUri = String.Format(url, Format(Now, "dd/MM/yyyy"), Secao, Format(Now, "yyyyMMdd"), "1")
            fileName = String.Format(stdFileName, Secao)
            myWebClient.DownloadFile(remoteUri, myDir & "\" & fileName)
            myFile = myDir & "\" & fileName
            RaiseEvent sendMessage("Arquivo principal do diário oficial do estado baixado com sucesso " & remoteUri, enMessageType.Info)

        Catch ex As Exception


            If ex.InnerException IsNot Nothing Then
                RaiseEvent sendMessage("Erro ao tentar fazer download do arquivo principal " & fileName & " em " & remoteUri & ": " & ex.InnerException.Message, enMessageType._Error)
            Else
                RaiseEvent sendMessage("Erro ao tentar fazer download do arquivo principal " & fileName & " em " & remoteUri & ":" & ex.Message, enMessageType._Error)
            End If

        End Try


    End Function
    Public Function PegaTotalPaginas(ByVal file As String) As Integer


        Dim texto As String = IO.File.ReadAllText(file)
        Dim termo As String = "I de "
        Dim index As Integer = texto.IndexOf(termo)
        Dim iniNum As Boolean = False
        Dim strPag As String = ""
        Dim page As Integer = -1
        Dim i As Integer = 0

        If index = -1 Then
            termo = "1 de "
            index = texto.IndexOf(termo)
        End If


        If index <> -1 Then
            texto = texto.Substring(index, texto.Length - index)
            For Each c As Char In texto
                If IsNumeric(c) And i <> 0 Then
                    iniNum = True
                    strPag += c
                Else
                    If iniNum Then Exit For
                End If
                i += 1
            Next
        Else
            Return -1
        End If

        If IsNumeric(strPag) Then page = CInt(strPag)

        Return page

    End Function
    Private Function ConverteMes(ByVal Mes As Integer) As String
        Select Case Mes
            Case 1 : Return "Janeiro"
            Case 2 : Return "Fevereiro"
            Case 3 : Return "Março"
            Case 4 : Return "Abril"
            Case 5 : Return "Maio"
            Case 6 : Return "Junho"
            Case 7 : Return "Julho"
            Case 8 : Return "Agosto"
            Case 9 : Return "Setembro"
            Case 10 : Return "Outubro"
            Case 11 : Return "Novembro"
            Case 12 : Return "Dezembro"
        End Select
        Return ""
    End Function
    Private Function converteCaderno(ByVal indexCaderno As Integer) As String
        Select Case indexCaderno
            Case 3 : Return "empresarial"
            Case 4 : Return "exec1"
        End Select
        Return ""
    End Function
    Public Function DownloadPaginas(ByVal myDir As String, _
                                        ByVal url_main As String, _
                                        ByVal url As String, _
                                        ByVal keepFile As Boolean, _
                                        ByRef myFiles() As String, _
                                        ByRef it As Integer, _
                                        ByVal secao As Integer, _
                                        ByVal subSec As String, _
                                        ByVal totalPagSec As Integer) As Boolean

        Dim remoteUri As String = ""
        Dim stdMainFile As String = "{0}.html"
        Dim stdFileName As String = Format(Now.Date, "ddMMyyyy") & "_DOE_{0}_{1}.pdf"
        Dim fileName As String = ""
        Dim myStringWebResource As String = Nothing
        Dim myWebClient As New WebClient()
        Dim Paginas() As Integer
        Dim PaginaSecao() As strPaginaSecao
        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim strTempSubSec As String = IIf(subSec.Trim.Length > 0, subSec, "Todas")

    

        Try
            RaiseEvent sendMessage("Iniciando download do diário oficial do estado - SubSeção: " & strTempSubSec, enMessageType.Info)

            RaiseEvent sendMessage("Identificando range de páginas para DOE - Caderno " & secao & " - Subseção: " & strTempSubSec, enMessageType.Info)



            remoteUri = String.Format(url_main, Format(Now, "dd/MM/yyyy"), secao, Format(Now, "yyyyMMdd"), "1")
            fileName = String.Format(stdMainFile, secao, "1")
            myWebClient.DownloadFile(remoteUri, myDir & "\" & fileName)

            If subSec.Trim.Length = 0 Then
                For i As Integer = 1 To totalPagSec
                    ReDim Preserve Paginas(k)
                    Paginas(k) = i
                    k += 1
                Next
            Else
                Paginas = PegaRangePaginas(myDir & "\" & fileName, secao, subSec)
            End If


            ReDim Preserve PaginaSecao(j)
            PaginaSecao(j).Secao = secao
            PaginaSecao(j).Paginas = Paginas

            j += 1

            'exclui html com sumario
            IO.File.Delete(myDir & "\" & fileName)



            'baixa paginas das subsecoes
            Dim fData As String = ""
            Dim fCaderno As String = ""
            Dim fPagina As String = ""

            If PaginaSecao IsNot Nothing Then
                For Each item As strPaginaSecao In PaginaSecao
                    For Each itemPage As Integer In item.Paginas
                        Try


                            fData = Format(Now.Year, "0000") & "/" & ConverteMes(Now.Month) & "/" & Format(Now.Day, "00")
                            fPagina = Format(itemPage, "0000")
                            If fPagina <> "0000" Then

                                fCaderno = converteCaderno(item.Secao)
                                remoteUri = String.Format(url, fData, fCaderno, fPagina)
                                fileName = String.Format(stdFileName, item.Secao, itemPage)

                                RaiseEvent sendMessage("Baixando arquivo DOE - Caderno " & item.Secao & " Subseção " & strTempSubSec & " Página " & itemPage, enMessageType.Info)
                                myWebClient.DownloadFile(remoteUri, myDir & "\" & fileName)
                                ReDim Preserve myFiles(it)
                                myFiles(it) = myDir & "\" & fileName
                                it += 1

                            End If
                        Catch ex As Exception
                            ExcluiTudoDirTemp(myDir, "")
                        End Try
                    Next
                Next
            End If



            RaiseEvent sendMessage("Arquivo(s) do diário oficial do estado baixado(s) com sucesso ", enMessageType.Info)

            Return True

        Catch ex As Exception

            If ex.InnerException IsNot Nothing Then
                RaiseEvent sendMessage("Erro ao tentar fazer download do arquivo principal " & fileName & " em " & remoteUri & ": " & ex.InnerException.Message, enMessageType._Error)
            Else
                RaiseEvent sendMessage("Erro ao tentar fazer download do arquivo principal " & fileName & " em " & remoteUri & ":" & ex.Message, enMessageType._Error)
            End If

            Return False
        End Try


    End Function
    Public Sub ExcluiTudoDirTemp(ByVal myDir As String, ByVal ext As String)
        Try

            Dim extension As String = ""
            Dim dir() As String

            If ext.Trim.Length = 0 Then
                dir = IO.Directory.GetFiles(myDir)
            Else
                dir = IO.Directory.GetFiles(myDir, ext)
            End If

            'exclui todos os arquivos
            For Each f As String In dir
                Try
                    IO.File.Delete(f)
                Catch ex2 As Exception
                End Try
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class


Public Class DiarioOficial

    Public Enum enMessageType
        _Error = 0
        Warning = 1
        Info = 2
    End Enum
    Public Structure strPaginaSecao
        Dim Secao As Integer
        Dim Paginas() As Integer
    End Structure


    Public Event sendMessage(ByVal message As String, ByVal type As Integer)

    Public Function PDFToText(ByVal file As String, ByVal page As Integer) As String
        Dim reader As PdfReader = New PdfReader(file)
        Dim text As String = ""
        Dim its As New iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy
        text = iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(reader, page, its)
        Return text
    End Function
    Public Function PegaRangePaginas(ByVal file As String, _
                                     ByVal Secao As Integer, _
                                     ByVal SubSecao As String) As Integer()

        Dim strText As String = PDFToText(file, 1)
        Dim index As Integer = strText.IndexOf(SubSecao, StringComparison.OrdinalIgnoreCase)
        Dim ini As Integer = 0
        Dim pageStart As Integer = 0
        Dim pageEnd As Integer = 0
        Dim strPag As String = ""
        Dim iniNum As Boolean = False
        Dim c As Char
        Dim j As Integer = 0
        Dim pages() As Integer


        If SubSecao.Trim.Length > 0 Then

            If index <> -1 Then

                ini = SubSecao.Length + strText.IndexOf(SubSecao, StringComparison.OrdinalIgnoreCase)
                strText = strText.Substring(ini, strText.Length - ini)
                ini = 0

                For Each c In strText

                    ini += 1

                    If IsNumeric(c) Then
                        iniNum = True
                        strPag += c
                    Else
                        If iniNum Then

                            'achou pagina inicial da sub secao
                            If IsNumeric(strPag) Then pageStart = CInt(strPag)

                            'pega pagina final da sub secao
                            iniNum = False
                            strPag = ""
                            strText = strText.Substring(ini, strText.Length - ini)

                            For Each c1 In strText
                                If IsNumeric(c1) Then
                                    iniNum = True
                                    strPag += c1
                                Else
                                    If iniNum Then
                                        If IsNumeric(strPag) Then pageEnd = CInt(strPag)
                                        Exit For
                                    End If
                                End If
                            Next

                            Exit For


                        End If
                    End If
                Next



            End If

        End If


        If pageStart <= pageEnd Then



            For i As Integer = pageStart To pageEnd
                ReDim Preserve pages(j)
                pages(j) = i
                j += 1
            Next



        End If

        Return pages

    End Function


    Public Function DownloadArquivoPrincipal(ByVal myDir As String, _
                                        ByVal keepFile As Boolean, _
                                        ByRef myFile As String, _
                                        ByVal url As String, _
                                        ByVal Secao As String) As Boolean
        Dim remoteUri As String = ""
        Dim stdFileName As String = "{0}_{1}.html"
        Dim fileName As String = ""
        Dim myStringWebResource As String = Nothing
        Dim myWebClient As New WebClient()

        Try

            RaiseEvent sendMessage("Iniciando download do arquivo principal do diário oficial da união", enMessageType.Info)

            remoteUri = String.Format(url, Secao, "1", Format(Now, "dd/MM/yyyy"))
            fileName = String.Format(stdFileName, Secao, "1")
            myWebClient.DownloadFile(remoteUri, myDir & "\" & fileName)
            myFile = myDir & "\" & fileName
            RaiseEvent sendMessage("Arquivo principal do diário oficial baixado com sucesso " & remoteUri, enMessageType.Info)

        Catch ex As Exception
            If ex.InnerException IsNot Nothing Then
                RaiseEvent sendMessage("Erro ao tentar fazer download do arquivo principal " & fileName & " em " & remoteUri & ": " & ex.InnerException.Message, enMessageType._Error)
            Else
                RaiseEvent sendMessage("Erro ao tentar fazer download do arquivo principal " & fileName & " em " & remoteUri & ":" & ex.Message, enMessageType._Error)
            End If

        End Try


    End Function
    Public Function PegaTotalPaginas(ByVal file As String) As Integer

        Dim texto As String = IO.File.ReadAllText(file)
        Dim termo As String = "totalArquivos"
        Dim index As Integer = texto.IndexOf(termo)
        Dim iniNum As Boolean = False
        Dim strPag As String = ""
        Dim page As Integer = -1

        If index <> -1 Then
            texto = texto.Substring(index, texto.Length - index)
            For Each c As Char In texto
                If IsNumeric(c) Then
                    iniNum = True
                    strPag += c
                Else
                    If iniNum Then Exit For
                End If
            Next
        Else
            Return -1
        End If

        If IsNumeric(strPag) Then page = CInt(strPag)

        Return page

    End Function

    Public Function DownloadPaginas(ByVal myDir As String, _
                                        ByVal url As String, _
                                        ByVal keepFile As Boolean, _
                                        ByRef myFiles() As String, _
                                        ByVal Secoes() As Integer, _
                                        ByVal subSec As String, _
                                        ByVal totalPagSec() As Integer) As Boolean

        Dim remoteUri As String = ""
        Dim stdFileName As String = Format(Now.Date, "ddMMyyyy") & "_DOU_{0}_{1}.pdf"
        Dim fileName As String = ""
        Dim myStringWebResource As String = Nothing
        Dim myWebClient As New WebClient()
        Dim Paginas() As Integer
        Dim PaginaSecao() As strPaginaSecao
        Dim j As Integer = 0
        Dim k As Integer = 0


        Try
            RaiseEvent sendMessage("Iniciando download do diário oficial da união - SubSeção: " & IIf(subSec.Trim.Length > 0, subSec, "Todas"), enMessageType.Info)

            For Each secao As Integer In Secoes

                RaiseEvent sendMessage("Identificando range de páginas para DOU - Seção " & secao & " - Subseção: " & subSec, enMessageType.Info)

                remoteUri = String.Format(url, secao, "1", Format(Now, "dd/MM/yyyy"))
                fileName = String.Format(stdFileName, secao, "1")
                myWebClient.DownloadFile(remoteUri, myDir & "\" & fileName)

                If subSec.Trim.Length = 0 Then
                    For i As Integer = 1 To totalPagSec(secao - 1)
                        ReDim Preserve Paginas(k)
                        Paginas(k) = i
                        k += 1
                    Next
                Else
                    Paginas = PegaRangePaginas(myDir & "\" & fileName, secao, subSec)
                End If


                ReDim Preserve PaginaSecao(j)
                PaginaSecao(j).Secao = secao
                PaginaSecao(j).Paginas = Paginas

                j += 1

                'exclui pdf da prrimeira página
                IO.File.Delete(myDir & "\" & fileName)

            Next


            'baixa paginas das subsecoes
            j = 0
            If PaginaSecao IsNot Nothing Then
                For Each item As strPaginaSecao In PaginaSecao
                    For Each itemPage As Integer In item.Paginas
                        Try
                            remoteUri = String.Format(url, item.Secao, itemPage, Format(Now, "dd/MM/yyyy"))
                            fileName = String.Format(stdFileName, item.Secao, itemPage)
                            RaiseEvent sendMessage("Baixando arquivo DOU - Seção " & item.Secao & " Subseção " & subSec & " Página " & itemPage, enMessageType.Info)
                            myWebClient.DownloadFile(remoteUri, myDir & "\" & fileName)
                            ReDim Preserve myFiles(j)
                            myFiles(j) = myDir & "\" & fileName
                            j += 1
                        Catch ex As Exception
                            ExcluiTudoDirTemp(myDir, "")
                        End Try
                    Next
                Next
            End If



            RaiseEvent sendMessage("Arquivo(s) do diário oficial da união baixado(s) com sucesso", enMessageType.Info)

            Return True

        Catch ex As Exception

            If ex.InnerException IsNot Nothing Then
                RaiseEvent sendMessage("Erro ao tentar fazer download do arquivo principal " & fileName & " em " & remoteUri & ": " & ex.InnerException.Message, enMessageType._Error)
            Else
                RaiseEvent sendMessage("Erro ao tentar fazer download do arquivo principal " & fileName & " em " & remoteUri & ":" & ex.Message, enMessageType._Error)
            End If

            Return False
        End Try


    End Function
    Public Sub ExcluiTudoDirTemp(ByVal myDir As String, ByVal ext As String)
        Try

            Dim extension As String = ""
            Dim dir() As String

            If ext.Trim.Length = 0 Then
                dir = IO.Directory.GetFiles(myDir)
            Else
                dir = IO.Directory.GetFiles(myDir, ext)
            End If

            'exclui todos os arquivos
            For Each f As String In dir
                Try
                    IO.File.Delete(f)
                Catch ex2 As Exception
                End Try
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class
