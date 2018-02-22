Imports System.Data
Imports System.IO
Imports System.Collections.Generic
Imports System.Web

Public Class Base


    

    Public ReadOnly Property _intPadrao()
        Get
            Return intPadrao
        End Get
    End Property
    Public ReadOnly Property _strPadrao()
        Get
            Return strPadrao
        End Get
    End Property
    Public ReadOnly Property _datPadrao()
        Get
            Return datPadrao
        End Get
    End Property
    Public ReadOnly Property _datNull()
        Get
            Return datNull
        End Get
    End Property
    Public ReadOnly Property _chrPulaLinhaWeb()
        Get
            Return chrPulaLinhaWeb
        End Get
    End Property
    Public ReadOnly Property _chrPulaLinhaApp()
        Get
            Return chrPulaLinhaApp
        End Get
    End Property
    Public ReadOnly Property _chrPulaLinhaGen()
        Get
            Return chrPulaLinhaGen
        End Get
    End Property
    Public Enum enAppType
        Windowsapplication = 0
        WebApplication = 1
    End Enum
    Public Function getFileDate(ByVal file As String) As String
        Dim filedate As Date

        If System.IO.File.Exists(file) Then
            filedate = FileSystem.FileDateTime(file)
            Return Format(filedate, "dd/MM/yyyy HH:mm:ss")
        Else
            Return ""
        End If

    End Function
    Public Function Setting(ByVal name As String, ByVal appType As enAppType) As String
        Dim value As String = ""
        Select Case appType
            Case enAppType.Windowsapplication : If System.Configuration.ConfigurationSettings.AppSettings.Get(name) IsNot Nothing Then value = System.Configuration.ConfigurationSettings.AppSettings.Get(name).ToString.Trim
            Case enAppType.WebApplication : If System.Configuration.ConfigurationManager.AppSettings(name) IsNot Nothing Then value = System.Configuration.ConfigurationManager.AppSettings.Get(name).ToString.Trim
        End Select
        Return value
    End Function
    Private Function isDuplicationError(ByVal errorMessage As String) As Boolean
        Dim ret As Boolean = False

        errorMessage = errorMessage.ToUpper.Trim

        If errorMessage.Contains("PRIMARY KEY") Or errorMessage.Contains("UNIQUE") Then
            ret = True
        End If

        Return ret
    End Function

    Public Function TreatDuplicatedDataException(ByVal xmlpath As String, ByVal ex As Exception) As Exception

        Dim newEx As Exception
        Dim obj As New Globalization
        Dim dt As DataTable = obj.getData(xmlpath, "validate")


        'essa função verifica se o erro é de registro duplicado
        'se for, transforma sua descrição tornando-a mais compreensível ao usuário

        If Not isDuplicationError(ex.Message) Then
            newEx = ex
        Else
            newEx = New Exception(obj.getValue(dt, "duplicate"))
        End If


        Return newEx


    End Function
    Public Function replaceDbNullToValueInDatatable(ByVal myTable As DataTable, _
                                                    Optional ByVal StringValue As String = "", _
                                                    Optional ByVal numericValue As Double = 0) As DataTable

      
        For Each column As DataColumn In myTable.Columns

            If Not column.AllowDBNull Then Continue For

            For Each row As DataRow In myTable.Rows

                If Not row(column.ColumnName) Is DBNull.Value Then Continue For

                Select Case Type.GetTypeCode(column.DataType)

                    Case TypeCode.String, TypeCode.Char
                        row(column.ColumnName) = StringValue
                    Case TypeCode.Double, TypeCode.Decimal, TypeCode.Int16, TypeCode.Int32, TypeCode.Int64, TypeCode.UInt16, TypeCode.UInt32, TypeCode.UInt64, TypeCode.Single
                        row(column.ColumnName) = numericValue

                End Select

            Next

        Next

        Return myTable
    End Function
    Public Function ConverteMes(ByVal Mes As Integer) As String
        Select Case Mes
            Case 1 : Return "jan"
            Case 2 : Return "fev"
            Case 3 : Return "mar"
            Case 4 : Return "abr"
            Case 5 : Return "mai"
            Case 6 : Return "jun"
            Case 7 : Return "jul"
            Case 8 : Return "ago"
            Case 9 : Return "set"
            Case 10 : Return "out"
            Case 11 : Return "nov"
            Case 12 : Return "dez"
        End Select
        Return ""
    End Function
    Public Function ConverteMes2(ByVal Mes As Integer) As String
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


    Public Function InsereAspasLista(ByVal lista As String, ByVal delimitador As String) As String
        Dim lista1 As String = ""

        If lista Is Nothing Then Return ""
        If lista.Trim.Length = 0 Then Return ""

        Dim vLista() As String = Split(lista, delimitador)


        For Each item As String In vLista
            If item.Trim.Length > 0 Then lista1 += "'" & item & "',"
        Next

        If lista1.Trim.Length > 0 Then lista1 = lista1.Substring(0, lista1.Length - 1)

        Return lista1
    End Function

    Public Function PulaLinhaACadaNCaracteres(ByVal Texto As String, _
                                              Optional ByVal NCaracteres As Integer = 20, _
                                              Optional ByVal ChrPula As String = "<br />") As String

        Dim retTexto As String = ""
        Dim vStr As New ArrayList
        Dim chr() As Char
        Dim i As Integer = 0
        Dim tempText As String = ""
        Dim inicio As Integer = 0
        Dim tam As Integer = NCaracteres - 1

        Texto = Texto.Trim

        chr = Texto.ToCharArray

        For Each c As Char In chr

            tempText += c

            If (i = NCaracteres - 1) Then
                vStr.Add(tempText)
                i = 0
                tempText = ""
            End If

            i += 1

        Next

        For Each s As String In vStr
            retTexto += s
        Next

        If retTexto.Length < Texto.Length Then
            tempText = Texto.Substring(retTexto.Length, Texto.Length - retTexto.Length)
            vStr.Add(tempText)
        End If


        retTexto = ""
        For Each s As String In vStr
            retTexto += s & ChrPula
        Next

        Return retTexto
    End Function





    Public Function MontaData(ByVal Ano As Integer, ByVal Mes As Integer, ByVal Inc As Integer) As DateTime
        Dim Data As DateTime = DateSerial(Ano, Mes, 1)
        Return DateAdd(DateInterval.Month, Inc, Data)
    End Function




    Public Function ConverteDataParaInteiro(ByVal Data As Date) As Integer
        Dim str As String = Format(Data, "yyyyMMdd")
        Return CInt(str)
    End Function




    Public Function ValidaNomeDiretorio(ByVal NomeDiretorio As String) As String

        If NomeDiretorio.Contains(":") Or _
        NomeDiretorio.Contains("<") Or _
        NomeDiretorio.Contains(">") Or _
        NomeDiretorio.Contains("|") Or _
        NomeDiretorio.Contains("?") Or _
        NomeDiretorio.Contains("*") Or _
        NomeDiretorio.Contains(Chr(34)) Then
            Return "O Nome do diretório não pode conter os caracteres : < > | ? * " & Chr(34)
        End If

        Return ""
    End Function
    Public Function ConverteFlag(ByVal Flag As String) As String

        Select Case Flag

            Case "S", "Y", "1"
                Return "Sim"

            Case "N", "0"
                Return "Não"

        End Select

        Return ""
    End Function
    Public Function NullToEmpty(ByVal value As Object) As String
        'convert null to empty
        If value IsNot Nothing Then
            Return value.ToString.Trim
        Else
            Return ""
        End If
    End Function
    Public Function NuloParaZero(ByVal valor As Object) As String
        If valor IsNot DBNull.Value Then
            Return valor
        Else
            Return 0
        End If
    End Function

    Public Function AjustaNulo(ByVal valor As Object) As String
        If valor IsNot Nothing Then
            Return valor.ToString.Trim
        Else
            Return ""
        End If
    End Function






    
    Public Function value_to_null2(ByVal value As String, ByVal type As Integer) As Object

        If value = "[NULL]" Or value = "null" Then

            Select Case type
                Case 1 'string 
                    Return _strPadrao
                Case 2 'numeric
                    Return _intPadrao
                Case 3
                    Return _datPadrao
            End Select

            Return _strPadrao

        Else
            Return value
        End If

    End Function



    Public Function ArquivoTextoParaString(ByVal Arquivo As String) As String
        Dim fs As New FileStream(Arquivo, FileMode.Open, FileAccess.Read)
        Dim reader As New StreamReader(fs)
        Dim texto As String = ""

        While reader.Peek <> -1
            texto += reader.ReadLine & chrPulaLinhaGen
        End While

        If reader IsNot Nothing Then
            reader.Close()
            reader.Dispose()
        End If

        If fs IsNot Nothing Then
            fs.Close()
            fs.Dispose()
        End If


        Return texto
    End Function











    Public Function PegaTipo(ByVal TypeName As String) As String

        TypeName = TypeName.ToUpper

        If TypeName.Contains("CHAR") Or TypeName.Contains("TEXT") Then Return "String"

        If TypeName.Contains("INT") Then Return "Integer"

        If TypeName.Contains("DECIMAL") Or TypeName.Contains("DOUBLE") Or TypeName.Contains("REAL") Then Return "Double"

        If TypeName.Contains("DATETIME") Then Return "DateTime"

        If TypeName.Contains("DATE") Then Return "Date"

        Return ""
    End Function

    Public Function ArrayToList(ByVal lista As List(Of String), Optional ByVal Delimiter As String = ",", Optional ByVal Quotes As String = "'") As String
        Dim strLista As String = ""

        For Each item As String In lista
            strLista += Quotes & item & Quotes & Delimiter
        Next

        If strLista.Trim.Length > 0 Then strLista = strLista.Substring(0, strLista.Length - Delimiter.Length)

        Return strLista
    End Function
    




    Public Function ItemSelecionado(ByVal item As String) As Boolean
        Return item.Trim <> "" And item.Trim <> "-1"
    End Function
    Public Function HMS(ByVal Temp As Object) As String
        '
        ' Converte tempo em uma string hh:mm:ss
        '
        Dim hora As Long
        Dim minuto As Long
        Dim segundo As Long
        Dim inter As Long
        Dim tempo As Object

        tempo = Temp

        inter = Int(tempo / 60)
        segundo = tempo - inter * 60
        tempo = inter

        inter = Int(tempo / 60)
        minuto = tempo - inter * 60
        tempo = inter

        inter = Int(tempo / 60)
        hora = tempo - inter * 60

        HMS = Format$(hora, "00") & ":" & Format$(minuto, "00") & ":" & Format$(segundo, "00")


    End Function
    Public Function IsInArray(ByVal FindValue As Object, _
      ByVal arrSearch As Object) As Boolean
        Try

            For Each o As Object In arrSearch
                If o Is FindValue Then
                    Return True
                End If
            Next

            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function







   

   


    Public Function TiraCaracteres(ByVal sTexto As String) As String

        Dim Caracteres(26) As String
        Caracteres(0) = "-"
        Caracteres(1) = "-"
        Caracteres(2) = "&"
        Caracteres(3) = "+"
        Caracteres(4) = "="
        Caracteres(5) = "("
        Caracteres(6) = ")"
        Caracteres(7) = "["
        Caracteres(8) = "]"
        Caracteres(9) = "{"
        Caracteres(10) = "}"
        Caracteres(11) = "$"
        Caracteres(12) = "#"
        Caracteres(13) = "@"
        Caracteres(14) = "%"
        Caracteres(15) = "!"
        Caracteres(16) = "?"
        Caracteres(17) = ":"
        Caracteres(18) = ","
        Caracteres(19) = ";"
        Caracteres(20) = "."
        Caracteres(21) = "/"
        Caracteres(22) = "\"
        Caracteres(23) = "|"
        Caracteres(24) = Chr(9)
        Caracteres(25) = Chr(34)


        For Each s As String In Caracteres
            sTexto = Replace(sTexto, s, "")
        Next

        Return sTexto

    End Function
    Public Function TiraEspacos(ByVal sTexto As String) As String

        While sTexto.Contains(" ")
            sTexto = Replace(sTexto, " ", "_")
        End While

        Return sTexto

    End Function
    Public Function TiraAcentos(ByVal sTexto As String) As String
        Dim sAcentos(2, 11) As String
        Dim sCaracter As String
        Dim bAcentos As Boolean
        Dim i As Integer, j As Integer

        sAcentos(1, 1) = "á"
        sAcentos(2, 1) = "a"
        sAcentos(1, 2) = "é"
        sAcentos(2, 2) = "e"
        sAcentos(1, 3) = "í"
        sAcentos(2, 3) = "i"
        sAcentos(1, 4) = "ó"
        sAcentos(2, 4) = "o"
        sAcentos(1, 5) = "ú"
        sAcentos(2, 5) = "u"
        sAcentos(1, 6) = "ê"
        sAcentos(2, 6) = "e"
        sAcentos(1, 7) = "ô"
        sAcentos(2, 7) = "o"
        sAcentos(1, 8) = "ã"
        sAcentos(2, 8) = "a"
        sAcentos(1, 9) = "º"
        sAcentos(2, 9) = "o"
        sAcentos(1, 10) = "ç"
        sAcentos(2, 10) = "c"
        sAcentos(1, 11) = "Ã"
        sAcentos(2, 11) = "A"



        TiraAcentos = sTexto 'Coloca o texto original como retorno

        For i = 1 To Len(sTexto)
            sCaracter = Mid$(sTexto, i, 1) 'Testa cada caracter
            If Asc(sCaracter) = 39 Or Asc(sCaracter) >= 192 And Asc(sCaracter) <= 255 Then
                bAcentos = True 'Indica a presença de acentos
                Exit For
            End If
        Next

        If bAcentos = True Then
            'Comparamos cada caracter com os elementos da matriz
            For i = 1 To Len(sTexto)
                For j = 1 To 11
                    sCaracter = Mid$(sTexto, i, 1)
                    If Asc(sCaracter) >= 192 And Asc(sCaracter) <= 255 Then
                        If sCaracter = sAcentos(1, j) Then
                            Mid$(sTexto, i, 1) = sAcentos(2, j)
                            TiraAcentos = sTexto
                        End If
                    End If
                Next
            Next
        End If
    End Function

    Public Function Formata(ByVal sTexto As String) As String
        sTexto = TiraAcentos(sTexto)
        sTexto = TiraEspacos(sTexto)
        sTexto = TiraCaracteres(sTexto)
        sTexto = Replace(sTexto, "__", "_")
        sTexto = UCase(sTexto)
        Return sTexto
    End Function


   
    Private Function ColumnEqual(ByVal A As Object, ByVal B As Object) As Boolean

        If A Is DBNull.Value AndAlso B Is DBNull.Value Then
            Return True
        End If
        If A Is DBNull.Value OrElse B Is DBNull.Value Then
            Return False
        End If

        Return (A.Equals(B))
    End Function

    Public Function SelectDistinct(ByVal TableName As String, ByVal SourceTable As DataTable, ByVal FieldName As String) As DataTable
        Dim dt As New DataTable(TableName)
        dt.Columns.Add(FieldName, SourceTable.Columns(FieldName).DataType)

        Dim LastValue As Object = Nothing
        For Each dr As DataRow In SourceTable.[Select]("", FieldName)
            If LastValue Is Nothing OrElse Not (ColumnEqual(LastValue, dr(FieldName))) Then
                LastValue = dr(FieldName)
                dt.Rows.Add(New Object() {LastValue})
            End If
        Next

        Return dt
    End Function
    Public Function InsereDataFiltro(ByVal arrayNome() As String, _
                               ByVal arrayValor() As String) As DataTable

        Dim dt As DataTable = CriatabelaFiltroReport()
        Dim i As Integer = 0
        Dim dr As DataRow



        For Each item As String In arrayNome

            dr = dt.NewRow

            If arrayValor(i) IsNot Nothing Then
                dr("Nome") = item
                dr("Valor") = TrataFiltro(arrayValor(i))
                i += 1
            Else
                dr("Nome") = item
                dr("Valor") = TrataFiltro(Space(0))
                i += 1
            End If

            dt.Rows.Add(dr)
        Next

        dt.TableName = "Report_TabelaFiltro"
        Return dt
    End Function
    Private Function CriatabelaFiltroReport() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("Nome"))
        dt.Columns.Add(New DataColumn("Valor"))
        Return dt
    End Function
    Private Function TrataFiltro(ByVal valor As String) As String

        If valor.Trim.Length = 0 Then
            Return "Não especificado"
        Else
            Return valor
        End If

    End Function
    Public Sub New()

    End Sub
End Class
