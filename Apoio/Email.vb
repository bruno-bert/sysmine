Imports Microsoft.VisualBasic
Imports System.Data

Public Class EmailAlertaDOE

    Private base As New Apoio.Base
    Private chrPula As String = base._chrPulaLinhaWeb

    Public Function MontaAssuntoEmail(ByVal Alerta As String, ByVal Empresa As String) As String


        Dim sistema As String = "Sysmine"
        Dim texto As String = ""
        Dim assunto As String = ""

        texto += sistema & " - " & Empresa & " - " & Alerta

        Return texto

    End Function
    Public Function CabecalhoTextoEmail(ByVal Empresa As String, ByVal Documento As String) As String
        Dim texto As String = ""
        texto = "Você está recebendo este email pois foi constatada a ocorrência da empresa " & Empresa & " no " & converteNomeDocumento(Documento) & " em uma ou mais páginas. "
        texto += chrPula
        texto += "Veja página(s) em anexo"
        texto += chrPula
        Return texto
    End Function
    Private Function drCollectionToDatatable(ByVal dr As DataRowCollection) As DataTable

        Dim linha As DataRow
        Dim dt As New DataTable

        dt.Columns.Add("Descricao")
        dt.Columns.Add("Valor")

        For Each r As DataRow In dr

            linha = dt.NewRow

            linha("descricao") = r("descricao")
            linha("valor") = r("valor")

            dt.Rows.Add(linha)

        Next

        Return dt

    End Function
    Private Function converteNomeDocumento(ByVal doc As String) As String
        Select Case doc
            Case "DOU" : Return "Diário Oficial da União"
            Case "DOE" : Return "Diário Oficial do Estado de SP"
        End Select
    End Function
    Public Function HtmlTabela(ByVal dr As DataRowCollection) As String


        Dim strTemp As String = ""
        Dim chrPulaLinha1 As String = "<br />"

        strTemp += HtmlCabecalhoGenerico()

        For Each r As DataRow In dr

            If _
            r("descricao") <> "Operador" And _
            r("descricao") <> "Arquivos" Then

                If r("descricao") = "Documento" Then
                    r("Valor") = converteNomeDocumento(r("Valor"))
                End If

                strTemp += Replace("<tr style='background-color:#F7F7DE;'>", "'", Chr(34))

                strTemp += Replace("<td>#Campo#</td>", "#Campo#", r("descricao"))

                'If r("descricao") = "Processo" Then
                '    Dim link As String = drCollectionToDatatable(dr).Select("descricao = 'link'")(0)("valor")
                '    strTemp += Replace(Replace("<td><a href='#link#' >'#Valor#'</a></td>", "#Valor#", r("valor")), "#link#", link)
                'Else
                strTemp += Replace("<td>#Valor#</td>", "#Valor#", r("valor"))
                'End If




                strTemp += "</tr>"
            End If
        Next

        strTemp += "</table>"
        strTemp += "</div>"

        Return strTemp

    End Function
    Private Function HtmlCabecalhoGenerico() As String



        Dim strTemp As String = ""
        strTemp += "<div>"

        'Tabela
        strTemp += Replace("<table cellspacing='0' cellpadding='4' rules='cols' border='1' id='grdTeste' style='color:Black;background-color:White;border-color:#DEDFDE;border-width:1px;border-style:None;border-collapse:collapse;'>", "'", Chr(34))

        'Linha
        strTemp += Replace("<tr style='color:White;background-color:#6B696B;font-weight:bold;'>", "'", Chr(34))

        'Colunas
        strTemp += Replace("<th scope='col'></th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'></th>", "'", Chr(34))

        'Fim Linha
        strTemp += "</tr>"

        Return strTemp
    End Function
    Public Function MontaTextoEmail(ByVal dr As DataRowCollection, _
                                    ByVal Empresa As String, _
                                    ByVal Documento As String) As String
        Dim texto As String = ""
        Dim mail As New EmailGeral

        texto += CabecalhoTextoEmail(Empresa, Documento)
        texto += chrPula
        texto += mail.RodapeTextoEmail()
        texto += chrPula
        texto = mail.FormataTextoEmail(texto)
        texto += chrPula
        texto += HtmlTabela(dr)

        Return texto
    End Function

    'Public Function HtmlTabela(ByVal dr As DataRowCollection) As String
    '    Dim strTemp As String = ""
    '    Dim processo As String = ""
    '    Dim titular As String = ""
    '    Dim orgao As String = ""
    '    Dim tipo_documento As String = ""
    '    Dim data_vencimento As String = ""
    '    Dim data_publicacao As String = ""
    '    Dim dias_para_vencer As String = ""
    '    Dim link As String = ""
    '    Dim tipo_envio As String = ""
    '    Dim id_documento As String = ""

    '    If dr.Count = 0 Then Return ""

    '    strTemp += HtmlCabecalhoTextoEmail()

    '    For Each r As DataRow In dr

    '        processo = r("processo").ToString.Trim
    '        titular = r("titular").ToString.Trim
    '        orgao = r("orgao").ToString.Trim
    '        tipo_documento = r("tipo_documento").ToString.Trim
    '        data_vencimento = r("data_vencimento").ToString.Trim
    '        data_publicacao = r("data_publicacao").ToString.Trim
    '        dias_para_vencer = r("dias_para_vencer").ToString.Trim
    '        link = r("link").ToString.Trim
    '        id_documento = r("id_documento").ToString.Trim
    '        tipo_envio = r("tipo_envio").ToString.Trim

    '        strTemp += Replace("<tr style='background-color:#F7F7DE;'>", "'", Chr(34))
    '        strTemp += Replace(Replace("<td><a href='#link#' >'#processo#'</a></td>", "#processo#", processo), "#link#", link)
    '        strTemp += Replace("<td>#titular#</td>", "#titular#", titular)
    '        strTemp += Replace("<td>#orgao#</td>", "#orgao#", orgao)
    '        strTemp += Replace("<td>#tipo_documento#</td>", "#tipo_documento#", tipo_documento)
    '        strTemp += Replace("<td>#id_documento#</td>", "#id_documento#", id_documento)
    '        strTemp += Replace("<td>#data_publicacao#</td>", "#data_publicacao#", data_publicacao)
    '        strTemp += Replace("<td>#data_vencimento#</td>", "#data_vencimento#", data_vencimento)
    '        strTemp += Replace("<td>#dias_para_vencer#</td>", "#dias_para_vencer#", dias_para_vencer)
    '        strTemp += Replace("<td>#tipo_envio#</td>", "#tipo_envio#", tipo_envio)

    '        strTemp += "</tr>"

    '    Next

    '    strTemp += "</table>"
    '    strTemp += "</div>"

    '    Return strTemp
    'End Function
    'Private Function HtmlCabecalhoTextoEmail() As String

    '    Dim strTemp As String = ""
    '    strTemp += "<div>"

    '    'Tabela
    '    strTemp += Replace("<table cellspacing='0' cellpadding='4' rules='cols' border='1' id='grdTeste' style='color:Black;background-color:White;border-color:#DEDFDE;border-width:1px;border-style:None;border-collapse:collapse;'>", "'", Chr(34))

    '    'Linha
    '    strTemp += Replace("<tr style='color:White;background-color:#6B696B;font-weight:bold;'>", "'", Chr(34))

    '    'Colunas
    '    strTemp += Replace("<th scope='col'>Processo</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Titular</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Orgão</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Tipo Documento</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Número</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Data Publicação</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Data Vencimento</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Dias Para Vencer</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Tipo Envio</th>", "'", Chr(34))



    '    'Fim Linha
    '    strTemp += "</tr>"

    '    Return strTemp
    'End Function

End Class

Public Class EmailAlertaDOU

    Private base As New Apoio.Base
    Private chrPula As String = base._chrPulaLinhaWeb

    Public Function MontaAssuntoEmail(ByVal Alerta As String, ByVal Processo As String) As String


        Dim sistema As String = "Sysmine"
        Dim texto As String = ""
        Dim assunto As String = ""

        texto += sistema & " - Processo " & Processo & " - " & Alerta

        Return texto

    End Function
    Public Function CabecalhoTextoEmail(ByVal processo As String, ByVal Documento As String) As String
        Dim texto As String = ""
        texto = "Você está recebendo este email pois foi constatada a ocorrência do processo minerário " & processo & " no " & converteNomeDocumento(Documento) & " em uma ou mais páginas. "
        texto += chrPula
        texto += "Veja página(s) em anexo"
        texto += chrPula
        Return texto
    End Function
    Private Function drCollectionToDatatable(ByVal dr As DataRowCollection) As DataTable

        Dim linha As DataRow
        Dim dt As New DataTable

        dt.Columns.Add("Descricao")
        dt.Columns.Add("Valor")

        For Each r As DataRow In dr

            linha = dt.NewRow

            linha("descricao") = r("descricao")
            linha("valor") = r("valor")

            dt.Rows.Add(linha)

        Next

        Return dt

    End Function
    Private Function converteNomeDocumento(ByVal doc As String) As String
        Select Case doc
            Case "DOU" : Return "Diário Oficial da União"
            Case "DOE" : Return "SP Executivo - Caderno 1"
        End Select
    End Function
    Public Function HtmlTabela(ByVal dr As DataRowCollection) As String


        Dim strTemp As String = ""
        Dim chrPulaLinha1 As String = "<br />"

        strTemp += HtmlCabecalhoGenerico()

        For Each r As DataRow In dr

            If _
            r("descricao") <> "Operador" And _
            r("descricao") <> "Arquivos" And _
            r("descricao") <> "Link" Then

                If r("descricao") = "Documento" Then
                    r("Valor") = converteNomeDocumento(r("Valor"))
                End If

                strTemp += Replace("<tr style='background-color:#F7F7DE;'>", "'", Chr(34))

                strTemp += Replace("<td>#Campo#</td>", "#Campo#", r("descricao"))

                If r("descricao") = "Processo" Then
                    Dim link As String = drCollectionToDatatable(dr).Select("descricao = 'link'")(0)("valor")
                    strTemp += Replace(Replace("<td><a href='#link#' >'#Valor#'</a></td>", "#Valor#", r("valor")), "#link#", link)
                Else
                    strTemp += Replace("<td>#Valor#</td>", "#Valor#", r("valor"))
                End If




                strTemp += "</tr>"
            End If
        Next

        strTemp += "</table>"
        strTemp += "</div>"

        Return strTemp

    End Function
    Private Function HtmlCabecalhoGenerico() As String



        Dim strTemp As String = ""
        strTemp += "<div>"

        'Tabela
        strTemp += Replace("<table cellspacing='0' cellpadding='4' rules='cols' border='1' id='grdTeste' style='color:Black;background-color:White;border-color:#DEDFDE;border-width:1px;border-style:None;border-collapse:collapse;'>", "'", Chr(34))

        'Linha
        strTemp += Replace("<tr style='color:White;background-color:#6B696B;font-weight:bold;'>", "'", Chr(34))

        'Colunas
        strTemp += Replace("<th scope='col'></th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'></th>", "'", Chr(34))

        'Fim Linha
        strTemp += "</tr>"

        Return strTemp
    End Function
    Public Function MontaTextoEmail(ByVal dr As DataRowCollection, _
                                    ByVal Processo As String, _
                                    ByVal Documento As String) As String
        Dim texto As String = ""
        Dim mail As New EmailGeral

        texto += CabecalhoTextoEmail(Processo, Documento)
        texto += chrPula
        texto += mail.RodapeTextoEmail()
        texto += chrPula
        texto = mail.FormataTextoEmail(texto)
        texto += chrPula
        texto += HtmlTabela(dr)

        Return texto
    End Function

    'Public Function HtmlTabela(ByVal dr As DataRowCollection) As String
    '    Dim strTemp As String = ""
    '    Dim processo As String = ""
    '    Dim titular As String = ""
    '    Dim orgao As String = ""
    '    Dim tipo_documento As String = ""
    '    Dim data_vencimento As String = ""
    '    Dim data_publicacao As String = ""
    '    Dim dias_para_vencer As String = ""
    '    Dim link As String = ""
    '    Dim tipo_envio As String = ""
    '    Dim id_documento As String = ""

    '    If dr.Count = 0 Then Return ""

    '    strTemp += HtmlCabecalhoTextoEmail()

    '    For Each r As DataRow In dr

    '        processo = r("processo").ToString.Trim
    '        titular = r("titular").ToString.Trim
    '        orgao = r("orgao").ToString.Trim
    '        tipo_documento = r("tipo_documento").ToString.Trim
    '        data_vencimento = r("data_vencimento").ToString.Trim
    '        data_publicacao = r("data_publicacao").ToString.Trim
    '        dias_para_vencer = r("dias_para_vencer").ToString.Trim
    '        link = r("link").ToString.Trim
    '        id_documento = r("id_documento").ToString.Trim
    '        tipo_envio = r("tipo_envio").ToString.Trim

    '        strTemp += Replace("<tr style='background-color:#F7F7DE;'>", "'", Chr(34))
    '        strTemp += Replace(Replace("<td><a href='#link#' >'#processo#'</a></td>", "#processo#", processo), "#link#", link)
    '        strTemp += Replace("<td>#titular#</td>", "#titular#", titular)
    '        strTemp += Replace("<td>#orgao#</td>", "#orgao#", orgao)
    '        strTemp += Replace("<td>#tipo_documento#</td>", "#tipo_documento#", tipo_documento)
    '        strTemp += Replace("<td>#id_documento#</td>", "#id_documento#", id_documento)
    '        strTemp += Replace("<td>#data_publicacao#</td>", "#data_publicacao#", data_publicacao)
    '        strTemp += Replace("<td>#data_vencimento#</td>", "#data_vencimento#", data_vencimento)
    '        strTemp += Replace("<td>#dias_para_vencer#</td>", "#dias_para_vencer#", dias_para_vencer)
    '        strTemp += Replace("<td>#tipo_envio#</td>", "#tipo_envio#", tipo_envio)

    '        strTemp += "</tr>"

    '    Next

    '    strTemp += "</table>"
    '    strTemp += "</div>"

    '    Return strTemp
    'End Function
    'Private Function HtmlCabecalhoTextoEmail() As String

    '    Dim strTemp As String = ""
    '    strTemp += "<div>"

    '    'Tabela
    '    strTemp += Replace("<table cellspacing='0' cellpadding='4' rules='cols' border='1' id='grdTeste' style='color:Black;background-color:White;border-color:#DEDFDE;border-width:1px;border-style:None;border-collapse:collapse;'>", "'", Chr(34))

    '    'Linha
    '    strTemp += Replace("<tr style='color:White;background-color:#6B696B;font-weight:bold;'>", "'", Chr(34))

    '    'Colunas
    '    strTemp += Replace("<th scope='col'>Processo</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Titular</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Orgão</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Tipo Documento</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Número</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Data Publicação</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Data Vencimento</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Dias Para Vencer</th>", "'", Chr(34))
    '    strTemp += Replace("<th scope='col'>Tipo Envio</th>", "'", Chr(34))



    '    'Fim Linha
    '    strTemp += "</tr>"

    '    Return strTemp
    'End Function

End Class
Public Class EmailAlertaVencimento

    Private base As New Apoio.Base
    Private chrPula As String = base._chrPulaLinhaWeb

    Public Function MontaAssuntoEmail(ByVal Alerta As String) As String


        Dim sistema As String = "Sysmine"
        Dim texto As String = ""
        Dim assunto As String = ""

        texto += sistema & " - Alerta: " & Alerta

        Return texto

    End Function
    Public Function CabecalhoTextoEmail() As String
        Dim texto As String = ""
        texto = "Você está recebendo este email pois a data de vencimento de alguns documentos deve ser verificada."
        texto += chrPula
        texto += "Veja na tabela a seguir a lista de processos minerários e as datas de vencimento de cada documento."
        texto += chrPula
        Return texto
    End Function
    Public Function MontaTextoEmail(ByVal dr As DataRowCollection) As String
        Dim texto As String = ""
        Dim mail As New EmailGeral

        texto += CabecalhoTextoEmail()
        texto += chrPula
        texto += mail.RodapeTextoEmail()
        texto += chrPula
        texto = mail.FormataTextoEmail(texto)
        texto += chrPula
        texto += HtmlTabela(dr)

        Return texto
    End Function

    Public Function HtmlTabela(ByVal dr As DataRowCollection) As String
        Dim strTemp As String = ""
        Dim processo As String = ""
        Dim titular As String = ""
        Dim orgao As String = ""
        Dim tipo_documento As String = ""
        Dim data_vencimento As String = ""
        Dim data_publicacao As String = ""
        Dim dias_para_vencer As String = ""
        Dim link As String = ""
        Dim tipo_envio As String = ""
        Dim id_documento As String = ""

        If dr.Count = 0 Then Return ""

        strTemp += HtmlCabecalhoTextoEmail()

        For Each r As DataRow In dr

            processo = r("processo").ToString.Trim
            titular = r("titular").ToString.Trim
            orgao = r("orgao").ToString.Trim
            tipo_documento = r("tipo_documento").ToString.Trim
            data_vencimento = r("data_vencimento").ToString.Trim
            data_publicacao = r("data_publicacao").ToString.Trim
            dias_para_vencer = r("dias_para_vencer").ToString.Trim
            link = r("link").ToString.Trim
            id_documento = r("id_documento").ToString.Trim
            tipo_envio = r("tipo_envio").ToString.Trim

            strTemp += Replace("<tr style='background-color:#F7F7DE;'>", "'", Chr(34))
            strTemp += Replace(Replace("<td><a href='#link#' >'#processo#'</a></td>", "#processo#", processo), "#link#", link)
            strTemp += Replace("<td>#titular#</td>", "#titular#", titular)
            strTemp += Replace("<td>#orgao#</td>", "#orgao#", orgao)
            strTemp += Replace("<td>#tipo_documento#</td>", "#tipo_documento#", tipo_documento)
            strTemp += Replace("<td>#id_documento#</td>", "#id_documento#", id_documento)
            strTemp += Replace("<td>#data_publicacao#</td>", "#data_publicacao#", data_publicacao)
            strTemp += Replace("<td>#data_vencimento#</td>", "#data_vencimento#", data_vencimento)
            strTemp += Replace("<td>#dias_para_vencer#</td>", "#dias_para_vencer#", dias_para_vencer)
            strTemp += Replace("<td>#tipo_envio#</td>", "#tipo_envio#", tipo_envio)

            strTemp += "</tr>"

        Next

        strTemp += "</table>"
        strTemp += "</div>"

        Return strTemp
    End Function
    Private Function HtmlCabecalhoTextoEmail() As String

        Dim strTemp As String = ""
        strTemp += "<div>"

        'Tabela
        strTemp += Replace("<table cellspacing='0' cellpadding='4' rules='cols' border='1' id='grdTeste' style='color:Black;background-color:White;border-color:#DEDFDE;border-width:1px;border-style:None;border-collapse:collapse;'>", "'", Chr(34))

        'Linha
        strTemp += Replace("<tr style='color:White;background-color:#6B696B;font-weight:bold;'>", "'", Chr(34))

        'Colunas
        strTemp += Replace("<th scope='col'>Processo</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Titular</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Orgão</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Tipo Documento</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Número</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Data Publicação</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Data Vencimento</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Dias Para Vencer</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Tipo Envio</th>", "'", Chr(34))



        'Fim Linha
        strTemp += "</tr>"

        Return strTemp
    End Function

End Class

Public Class EmailAlertaGeral

    Private base As New Apoio.Base
    Private chrPula As String = base._chrPulaLinhaWeb

    Public Function MontaAssuntoEmail(ByVal Alerta As String) As String


        Dim sistema As String = "Alertas DNPM"
        Dim texto As String = ""
        Dim assunto As String = ""

        texto += sistema & " - Alerta: " & Alerta

        Return texto

    End Function
    Public Function CabecalhoTextoEmail() As String
        Dim texto As String = ""
        texto = "Você está recebendo este email pois um ou mais processos minerários não cadastrados no sistema sofreram alterações na fase e/ou último evento."
        texto += chrPula
        texto += chrPula
        texto += "Veja na tabela a seguir a lista de processos minerários e as alterações identificadas em cada processo."
        texto += chrPula
        texto += "*A coluna NOVO indica se esta é a primeira vez que o processo foi verificado. Se for a primeira vez, o sistema considera que a fase mudou, já que não há referência anterior."
        texto += chrPula
        Return texto
    End Function
    Public Function MontaTextoEmail(ByVal dr As DataRowCollection) As String
        Dim texto As String = ""
        Dim mail As New EmailGeral

        texto += CabecalhoTextoEmail()
        texto += chrPula
        texto += mail.RodapeTextoEmail()
        texto += chrPula
        texto = mail.FormataTextoEmail(texto)
        texto += chrPula
        texto += HtmlTabela(dr)

        Return texto
    End Function

    Public Function HtmlTabela(ByVal dr As DataRowCollection) As String
        Dim strTemp As String = ""
        Dim processo As String = ""
        Dim titular As String = ""
        Dim fase_anterior As String = ""
        Dim fase_atual As String = ""
        Dim evento_anterior As String = ""
        Dim ultimo_evento As String = ""
        Dim mudou_fase As String = ""
        Dim mudou_evento As String = ""
        Dim link As String = ""
        Dim novo As String = ""

        If dr.Count = 0 Then Return ""

        strTemp += HtmlCabecalhoTextoEmail()

        For Each r As DataRow In dr

            processo = r("processo").ToString.Trim
            titular = r("titular").ToString.Trim
            mudou_fase = r("mudou_fase").ToString.Trim
            mudou_evento = r("mudou_evento").ToString.Trim
            fase_anterior = r("fase_anterior").ToString.Trim
            fase_atual = r("fase_atual").ToString.Trim
            evento_anterior = r("evento_anterior").ToString.Trim
            ultimo_evento = r("ultimo_evento").ToString.Trim
            novo = r("novo").ToString.Trim
            link = r("link").ToString.Trim

            strTemp += Replace("<tr style='background-color:#F7F7DE;'>", "'", Chr(34))
            strTemp += Replace(Replace("<td><a href='#link#' >'#processo#'</a></td>", "#processo#", processo), "#link#", link)
            strTemp += Replace("<td>#titular#</td>", "#titular#", titular)

            strTemp += Replace("<td>#mudou_fase#</td>", "#mudou_fase#", mudou_fase)
            strTemp += Replace("<td>#fase_anterior#</td>", "#fase_anterior#", fase_anterior)
            strTemp += Replace("<td>#fase_atual#</td>", "#fase_atual#", fase_atual)

            strTemp += Replace("<td>#mudou_evento#</td>", "#mudou_evento#", mudou_evento)
            strTemp += Replace("<td>#evento_anterior#</td>", "#evento_anterior#", evento_anterior)
            strTemp += Replace("<td>#ultimo_evento#</td>", "#ultimo_evento#", ultimo_evento)

            strTemp += Replace("<td>#novo#</td>", "#novo#", novo)

            strTemp += "</tr>"

        Next

        strTemp += "</table>"
        strTemp += "</div>"

        Return strTemp
    End Function
    Private Function HtmlCabecalhoTextoEmail() As String

        Dim strTemp As String = ""
        strTemp += "<div>"

        'Tabela
        strTemp += Replace("<table cellspacing='0' cellpadding='4' rules='cols' border='1' id='grdTeste' style='color:Black;background-color:White;border-color:#DEDFDE;border-width:1px;border-style:None;border-collapse:collapse;'>", "'", Chr(34))

        'Linha
        strTemp += Replace("<tr style='color:White;background-color:#6B696B;font-weight:bold;'>", "'", Chr(34))

        'Colunas
        strTemp += Replace("<th scope='col'>Processo</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Titular</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Mudou Fase?</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Fase Anterior</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Fase Atual</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Mudou Evento?</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Evento Anterior</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Último Evento</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Novo*</th>", "'", Chr(34))



        'Fim Linha
        strTemp += "</tr>"

        Return strTemp
    End Function

End Class

Public Class EmailOutroProcesso

    Private base As New Apoio.Base
    Private chrPula As String = base._chrPulaLinhaWeb

    Public Function MontaAssuntoEmail(ByVal Alerta As String) As String


        Dim sistema As String = "Alertas DNPM"
        Dim texto As String = ""
        Dim assunto As String = ""

        texto += sistema & " - Alerta: " & Alerta

        Return texto

    End Function
    Public Function CabecalhoTextoEmail() As String
        Dim texto As String = ""
        texto = "Você está recebendo este email pois um ou mais processos minerários de outros titulares sofreram alterações na fase e/ou último evento."
        texto += chrPula
        texto += chrPula
        texto += "Veja na tabela a seguir a lista de processos minerários e as alterações identificadas em cada processo."
        texto += chrPula
        texto += chrPula
        Return texto
    End Function
    Public Function MontaTextoEmail(ByVal dr As DataRowCollection) As String
        Dim texto As String = ""
        Dim mail As New EmailGeral

        texto += CabecalhoTextoEmail()
        texto += chrPula
        texto += mail.RodapeTextoEmail()
        texto += chrPula
        texto = mail.FormataTextoEmail(texto)
        texto += chrPula
        texto += HtmlTabela(dr)

        Return texto
    End Function

    Public Function HtmlTabela(ByVal dr As DataRowCollection) As String
        Dim strTemp As String = ""
        Dim processo As String = ""
        Dim titular As String = ""
        Dim fase_anterior As String = ""
        Dim fase_atual As String = ""
        Dim evento_anterior As String = ""
        Dim ultimo_evento As String = ""
        Dim mudou_fase As String = ""
        Dim mudou_evento As String = ""
        Dim link As String = ""

        If dr.Count = 0 Then Return ""

        strTemp += HtmlCabecalhoTextoEmail()

        For Each r As DataRow In dr

            processo = r("processo").ToString.Trim
            titular = r("titular").ToString.Trim
            mudou_fase = r("mudou_fase").ToString.Trim
            mudou_evento = r("mudou_evento").ToString.Trim
            fase_anterior = r("fase_anterior").ToString.Trim
            fase_atual = r("fase_atual").ToString.Trim
            evento_anterior = r("evento_anterior").ToString.Trim
            ultimo_evento = r("ultimo_evento").ToString.Trim
            link = r("link").ToString.Trim

            strTemp += Replace("<tr style='background-color:#F7F7DE;'>", "'", Chr(34))
            strTemp += Replace(Replace("<td><a href='#link#' >'#processo#'</a></td>", "#processo#", processo), "#link#", link)
            strTemp += Replace("<td>#titular#</td>", "#titular#", titular)

            strTemp += Replace("<td>#mudou_fase#</td>", "#mudou_fase#", mudou_fase)
            strTemp += Replace("<td>#fase_anterior#</td>", "#fase_anterior#", fase_anterior)
            strTemp += Replace("<td>#fase_atual#</td>", "#fase_atual#", fase_atual)

            strTemp += Replace("<td>#mudou_evento#</td>", "#mudou_evento#", mudou_evento)
            strTemp += Replace("<td>#evento_anterior#</td>", "#evento_anterior#", evento_anterior)
            strTemp += Replace("<td>#ultimo_evento#</td>", "#ultimo_evento#", ultimo_evento)

            strTemp += "</tr>"

        Next

        strTemp += "</table>"
        strTemp += "</div>"

        Return strTemp
    End Function
    Private Function HtmlCabecalhoTextoEmail() As String

        Dim strTemp As String = ""
        strTemp += "<div>"

        'Tabela
        strTemp += Replace("<table cellspacing='0' cellpadding='4' rules='cols' border='1' id='grdTeste' style='color:Black;background-color:White;border-color:#DEDFDE;border-width:1px;border-style:None;border-collapse:collapse;'>", "'", Chr(34))

        'Linha
        strTemp += Replace("<tr style='color:White;background-color:#6B696B;font-weight:bold;'>", "'", Chr(34))

        'Colunas
        strTemp += Replace("<th scope='col'>Processo</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Titular</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Mudou Fase?</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Fase Anterior</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Fase Atual</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Mudou Evento?</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Evento Anterior</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Último Evento</th>", "'", Chr(34))



        'Fim Linha
        strTemp += "</tr>"

        Return strTemp
    End Function

End Class
Public Class EmailMeuProcesso

    Private base As New Apoio.Base
    Private chrPula As String = base._chrPulaLinhaWeb

    Public Function MontaAssuntoEmail(ByVal Processo As String, ByVal Alerta As String, ByVal Titular As String) As String


        Dim sistema As String = "Sysmine"
        Dim texto As String = ""
        Dim assunto As String = ""

        texto += sistema & " - Processo Minerário " & Processo & " - Alerta: " & Alerta & " - " & Titular

        Return texto

    End Function
    Public Function CabecalhoTextoEmail(ByVal processo As String, ByVal link As String, _
                                        ByVal Titular As String) As String
        Dim texto As String = ""
        texto = "Você está recebendo este email pois o processo minerário " & processo & ", titular " & Titular & ", sofreu alterações na fase e/ou último evento."
        texto += chrPula
        texto += "Clique <a href=" & link & ">aqui</a> para acessar os dados do processo no site do DNPM."
        texto += chrPula
        texto += "Veja na tabela a seguir as alterações identificadas no processo."
        texto += chrPula
        Return texto
    End Function
    Public Function MontaTextoEmail(ByVal processo As String, ByVal link As String, _
                                    ByVal TItular As String, _
                                    ByVal dr As DataRowCollection) As String
        Dim texto As String = ""
        Dim mail As New EmailGeral

        texto += CabecalhoTextoEmail(processo, link, TItular)
        texto += chrPula
        texto += mail.RodapeTextoEmail()
        texto += chrPula
        texto = mail.FormataTextoEmail(texto)
        texto += chrPula
        texto += mail.HTMLTabelaGenerico(dr)

        Return texto
    End Function

    Public Function HtmlTabela(ByVal dr As DataRowCollection) As String
        Dim strTemp As String = ""
        Dim processo As String = ""
        Dim titular As String = ""
        Dim fase As String = ""
        Dim link As String = ""

        If dr.Count = 0 Then Return ""

        strTemp += HtmlCabecalhoTextoEmail()

        For Each r As DataRow In dr

            processo = r("processo").ToString.Trim
            titular = r("titular").ToString.Trim
            fase = r("fase").ToString.Trim
            link = r("link").ToString.Trim

            strTemp += Replace("<tr style='background-color:#F7F7DE;'>", "'", Chr(34))
            strTemp += Replace(Replace("<td><a href='#link#' >'#processo#'</a></td>", "#processo#", processo), "#link#", link)
            strTemp += Replace("<td>#titular#</td>", "#titular#", titular)
            strTemp += Replace("<td>#fase#</td>", "#fase#", fase)

            strTemp += "</tr>"

        Next

        strTemp += "</table>"
        strTemp += "</div>"

        Return strTemp
    End Function
    Private Function HtmlCabecalhoTextoEmail() As String

        Dim strTemp As String = ""
        strTemp += "<div>"

        'Tabela
        strTemp += Replace("<table cellspacing='0' cellpadding='4' rules='cols' border='1' id='grdTeste' style='color:Black;background-color:White;border-color:#DEDFDE;border-width:1px;border-style:None;border-collapse:collapse;'>", "'", Chr(34))

        'Linha
        strTemp += Replace("<tr style='color:White;background-color:#6B696B;font-weight:bold;'>", "'", Chr(34))

        'Colunas
        strTemp += Replace("<th scope='col'>Processo</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Titular</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Fase</th>", "'", Chr(34))



        'Fim Linha
        strTemp += "</tr>"

        Return strTemp
    End Function

End Class



Public Class EmailNovoProcesso

    Private base As New Apoio.Base
    Private chrPula As String = base._chrPulaLinhaWeb

    Public Function MontaAssuntoEmail() As String


        Dim sistema As String = "Sysmine"
        Dim texto As String = ""
        Dim assunto As String = ""

        texto += sistema & " - Alerta de Novo Processo Minerário"

        Return texto

    End Function
    Public Function CabecalhoTextoEmail() As String
        Dim texto As String = ""
        texto = "Você está recebendo este email pois um ou mais processos minerários foram inseridos na base de dados do sistema Sysmine"
        texto += chrPula
        texto += "Veja a seguir a tabela de processos minerários inseridos no sistema"
        texto += chrPula
        Return texto
    End Function
    Public Function MontaTextoEmail(ByVal dr As DataRowCollection) As String
        Dim texto As String = ""
        Dim mail As New EmailGeral

        texto += CabecalhoTextoEmail()
        texto += chrPula
        texto += mail.RodapeTextoEmail()
        texto += chrPula
        texto = mail.FormataTextoEmail(texto)
        texto += chrPula
        texto += HtmlTabela(dr)

        Return texto
    End Function
  
    Public Function HtmlTabela(ByVal dr As DataRowCollection) As String
        Dim strTemp As String = ""
        Dim processo As String = ""
        Dim titular As String = ""
        Dim fase As String = ""
        Dim link As String = ""

        If dr.Count = 0 Then Return ""

        strTemp += HtmlCabecalhoTextoEmail()

        For Each r As DataRow In dr

            processo = r("processo").ToString.Trim
            titular = r("titular").ToString.Trim
            fase = r("fase").ToString.Trim
            link = r("link").ToString.Trim
           
            strTemp += Replace("<tr style='background-color:#F7F7DE;'>", "'", Chr(34))
            strTemp += Replace(Replace("<td><a href='#link#' >'#processo#'</a></td>", "#processo#", processo), "#link#", link)
            strTemp += Replace("<td>#titular#</td>", "#titular#", titular)
            strTemp += Replace("<td>#fase#</td>", "#fase#", fase)
           
            strTemp += "</tr>"

        Next

        strTemp += "</table>"
        strTemp += "</div>"

        Return strTemp
    End Function
    Private Function HtmlCabecalhoTextoEmail() As String

        Dim strTemp As String = ""
        strTemp += "<div>"

        'Tabela
        strTemp += Replace("<table cellspacing='0' cellpadding='4' rules='cols' border='1' id='grdTeste' style='color:Black;background-color:White;border-color:#DEDFDE;border-width:1px;border-style:None;border-collapse:collapse;'>", "'", Chr(34))

        'Linha
        strTemp += Replace("<tr style='color:White;background-color:#6B696B;font-weight:bold;'>", "'", Chr(34))

        'Colunas
        strTemp += Replace("<th scope='col'>Processo</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Titular</th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'>Fase</th>", "'", Chr(34))
     


        'Fim Linha
        strTemp += "</tr>"

        Return strTemp
    End Function
    
End Class



Public Class EmailGeral
    Private chrPulaLinha As String = "<br />"
    Public Function HTMLTabelaGenerico(ByVal dr As DataRowCollection) As String


        Dim strTemp As String = ""
        Dim chrPulaLinha1 As String = "<br />"

        strTemp += HtmlCabecalhoGenerico()

        For Each r As DataRow In dr
            strTemp += Replace("<tr style='background-color:#F7F7DE;'>", "'", Chr(34))
            strTemp += Replace("<td>#Campo#</td>", "#Campo#", r("descricao"))
            strTemp += Replace("<td>#Valor#</td>", "#Valor#", r("valor"))
            strTemp += "</tr>"
        Next

        strTemp += "</table>"
        strTemp += "</div>"

        Return strTemp

    End Function
    Private Function HtmlCabecalhoGenerico() As String



        Dim strTemp As String = ""
        strTemp += "<div>"

        'Tabela
        strTemp += Replace("<table cellspacing='0' cellpadding='4' rules='cols' border='1' id='grdTeste' style='color:Black;background-color:White;border-color:#DEDFDE;border-width:1px;border-style:None;border-collapse:collapse;'>", "'", Chr(34))

        'Linha
        strTemp += Replace("<tr style='color:White;background-color:#6B696B;font-weight:bold;'>", "'", Chr(34))

        'Colunas
        strTemp += Replace("<th scope='col'></th>", "'", Chr(34))
        strTemp += Replace("<th scope='col'></th>", "'", Chr(34))

        'Fim Linha
        strTemp += "</tr>"

        Return strTemp
    End Function
    


    

    Public Function FormataTextoEmail(ByVal TextoPadrao As String) As String
        Dim strTemp As String = ""


        strTemp += "<div>"
        strTemp += HtmlTextoPadraoEmail(TextoPadrao)
        strTemp += "</div>"
        strTemp += chrPulaLinha


        Return strTemp

    End Function


    Private Function HtmlTextoPadraoEmail(ByVal TextoPadrao As String) As String
        Dim strTemp As String = ""
        strTemp += Replace("<span  style='font-family: Arial, Helvetica, sans-serif;font-size: small;'>", "'", Chr(34))
        strTemp += TextoPadrao
        strTemp += "</span>"
        Return strTemp
    End Function
    

    Public Function RodapeTextoEmail() As String
        Dim texto As String = ""
        texto = "Este é um email automático do sistema Sysmine e não deve ser respondido"
        Return texto
    End Function
    Public Sub EnviaEmail(ByVal Host As String, ByVal Port As Integer, _
                              ByVal AddressFrom As String, ByVal AddressTo As String, _
                              ByVal UserName As String, ByVal Password As String, _
                              ByVal Subject As String, ByVal Body As String, _
                              ByVal Attachment() As String, ByVal IsHtml As Boolean, _
                              ByVal View As System.Net.Mail.AlternateView)

  
        Try

          
            Dim item As Net.Mail.Attachment
            Dim email As New System.Net.Mail.SmtpClient(Host, Port)

            Dim msgMail As New System.Net.Mail.MailMessage()
            Dim fromAddress As New System.Net.Mail.MailAddress(AddressFrom)


            msgMail.To.Add(AddressTo)
            msgMail.From = fromAddress
            msgMail.Subject = Subject.ToString.Trim

            If View Is Nothing Then
                msgMail.Body = Body
            Else
                msgMail.AlternateViews.Add(View)
            End If


            If Attachment IsNot Nothing Then
                For Each f As String In Attachment
                    If f <> "" Then
                        item = New Net.Mail.Attachment(f)
                        msgMail.Attachments.Add(item)
                    End If
                Next
            End If

            Dim SMTPUserInfo As System.Net.NetworkCredential = _
            New System.Net.NetworkCredential(UserName, Password)

            msgMail.IsBodyHtml = IsHtml


            email.UseDefaultCredentials = False
            email.Credentials = SMTPUserInfo
            email.EnableSsl = True


            email.Send(msgMail)


            If item IsNot Nothing Then item.Dispose()



        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    

End Class




