Imports System.Web
Imports System.Web.UI
Imports System.Xml
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Web.Script.Serialization
Public Class Web
    Inherits Base
    Public Function setting(ByVal name As String) As String
        Dim value As String = ""
        value = System.Configuration.ConfigurationSettings.AppSettings(name)
        If value Is Nothing Then value = ""
        Return value
    End Function
    Public Function GetJson(ByVal dt As System.Data.DataTable) As String

        Dim serializer As JavaScriptSerializer = New JavaScriptSerializer()
        Dim rows As New List(Of Dictionary(Of String, Object))
        Dim row As Dictionary(Of String, Object)

        For Each dr As System.Data.DataRow In dt.Rows

            row = New Dictionary(Of String, Object)

            For Each col As System.Data.DataColumn In dt.Columns
                Select Case col.DataType.Name
                    Case "DateTime"
                        row.Add(col.ColumnName, CStr(Format(dr(col), "dd/MM/yyyy")))
                    Case Else
                        row.Add(col.ColumnName, dr(col))
                End Select

            Next

            rows.Add(row)

        Next

        Return serializer.Serialize(rows)

    End Function
    Public Function getJSONComboBoxData(ByVal dt As DataTable, ByVal context As HttpContext) As String

        Dim datatextfield As String = context.Request.Form("datatextfield")
        Dim datavaluefield As String = context.Request.Form("datavaluefield")
        Dim drNew As DataRow
        Dim dtFinal As DataTable

        dtFinal = New DataTable
        dtFinal.Columns.Add(datatextfield)
        dtFinal.Columns.Add(datavaluefield)

        For Each dr As DataRow In dt.Rows
            drNew = dtFinal.NewRow
            drNew(datavaluefield) = dr(datavaluefield)
            drNew(datatextfield) = dr(datatextfield)
            dtFinal.Rows.Add(drNew)
        Next

        Return GetJson(dtFinal)

    End Function
    Public Function JsonToDatatable(ByVal jsonString As String) As DataTable
        Dim resultXmlNode As System.Xml.XmlNode = JsonConvert.DeserializeXmlNode("{""root"":" & jsonString & "}", "root")
        Dim ds As DataSet = New DataSet()
        ds.ReadXml(New XmlNodeReader(resultXmlNode))
        Return ds.Tables(0)
    End Function
    Public Sub DownloadTextFile(ByVal Pagina As UI.Page, ByVal text As String, ByVal FileName As String)

        Pagina.Response.Clear()
        Pagina.Response.ClearContent()
        Pagina.Response.AddHeader("content-disposition", "attachment; filename=" & FileName)
        Pagina.Response.ContentType = "text/plain"
        Dim encoding As System.Text.UTF8Encoding = New System.Text.UTF8Encoding()
        Dim bytes() As Byte = encoding.GetBytes(text)
        Pagina.Response.BinaryWrite(bytes)
        Pagina.Response.End()


    End Sub
    Public Function FindControlRecursive(ByVal root As UI.Control, ByVal id As String) As UI.Control
        If root.ID = id Then
            Return root
        End If

        For Each c As UI.Control In root.Controls
            Dim t As UI.Control = FindControlRecursive(c, id)
            If t IsNot Nothing Then
                Return t
            End If
        Next

        Return Nothing
    End Function
    Public Function GetPostBackControl(ByVal page As Object) As UI.Control
        Dim control As UI.Control = Nothing

        Dim ctrlname As String = page.Request.Params.[Get]("__EVENTTARGET")
        If ctrlname IsNot Nothing AndAlso ctrlname <> String.Empty Then
            control = page.FindControl(ctrlname)
        Else
            For Each ctl As String In page.Request.Form
                ctl = Replace(ctl, ".y", "")
                Dim c As UI.Control = page.FindControl(ctl)
                If TypeOf c Is System.Web.UI.WebControls.Button Or _
                TypeOf c Is System.Web.UI.WebControls.ImageButton Then
                    control = c
                    Exit For
                End If
            Next
        End If
        Return control
    End Function

  
    Public Function getMenu(ByVal context As HttpContext, ByVal menufile As String) As String
        Dim menuID As String = context.Request.Form("source")
        Dim maxLevel As Integer = context.Request.Form("maxlevel")
        Return buildMenu(menufile, menuID, maxLevel)
    End Function
    Public Function buildMenu(ByVal _xmlPath As String, ByVal menuID As String, ByVal maxLevel As Integer) As String


        Dim html As String = ""
        Dim dt As DataTable = getMenuData(_xmlPath, menuID)

        If _xmlPath Is Nothing Then
            Dim ex As New Exception("Menu [" & menuID & "] - caminho do arquivo de linguagem não foi informado")
            Throw ex
        End If

        If _xmlPath.ToString.Trim.Length = 0 Then
            Dim ex As New Exception("Menu [" & menuID & "] - caminho do arquivo de linguagem não foi informado")
            Throw ex
        End If

        If Not System.IO.File.Exists(_xmlPath) Then
            Dim ex As New Exception("Menu [" & menuID & "] - Arquivo de linguagem não foi encontrado [" & _xmlPath & "]")
            Throw ex
        End If

        If dt Is Nothing Then
            Dim ex As New Exception("Menu [" & menuID & "] não encontrado no arquivo de linguagem")
            Throw ex
        End If

        If dt.Rows.Count = 0 Then
            Dim ex As New Exception("Menu [" & menuID & "] - não há itens no menu")
            Throw ex
        End If

       
        Dim level As Integer = 0
        Dim dr() As DataRow
        Dim filtro As String = ""
        Dim url As String = ""
        Dim text As String = ""
        Dim id As String = ""
        Dim item As String = ""
        Dim parentid As String = ""
        Dim it As Integer = 0
        Dim maxid As Integer = 0

        'retira nulos do datatable
        dt = replaceDbNullToValueInDatatable(dt)

        Do

            filtro = "level = " & level
            dr = dt.Select(filtro)
            it = 0

            For Each r As DataRow In dr


                url = IIf(r("url").ToString.Trim.Length > 0, r("url"), "#")
                text = r("text").ToString.Trim
                id = r("id").ToString.Trim
                parentid = r("parentid").ToString.Trim

                If maxid < id Then maxid = id



                item = ""
                item += "<li><a href='" & url & "'>" & text & "</a>" & vbCrLf
                item += "#" & id & "#" & vbCrLf
                item += "</li>" & vbCrLf

                Select Case level
                    Case 0
                        html += item
                    Case 1

                        If it = 0 Then item = "<ul class='sub_menu'>" & vbCrLf & item & vbCrLf & "#" & parentid & "#" & vbCrLf & "</ul>"
                        html = Replace(html, "#" & parentid & "#" & vbCrLf & "</ul>", item & vbCrLf & "#" & parentid & "#" & vbCrLf & "</ul>")

                    Case Else
                        If it = 0 Then item = "<ul>" & vbCrLf & item & vbCrLf & "#" & parentid & "#" & vbCrLf & "</ul>"
                        html = Replace(html, "#" & parentid & "#" & vbCrLf & "</ul>", item & vbCrLf & "#" & parentid & "#" & vbCrLf & "</ul>")


                End Select


                it += 1
            Next

           

            level += 1
        Loop While level <= maxLevel


        html = "<ul class='dropdown'>" & vbCrLf & html & vbCrLf & "</ul>"

        For i As Integer = 0 To maxid
            html = Replace(html, "#" & i & "#", "")
        Next

        Return html

    End Function

    Private Function getMenuData(ByVal xmlPath As String, ByVal menuID As String) As DataTable

        ' Load up the XML file
        Dim dr As DataRow
        Dim dt As DataTable
        Dim xmlDoc As XmlDocument
        Dim node As XmlNode


        xmlDoc = New XmlDocument
        xmlDoc.Load(xmlPath)

        dt = New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("text")
        dt.Columns.Add("tooltip")
        dt.Columns.Add("image")
        dt.Columns.Add("url")
        dt.Columns.Add("level")
        dt.Columns.Add("parentid")
        dt.Columns.Add("roles")

        If xmlDoc.DocumentElement.SelectNodes(".//menu[@name='" & menuID & "']").Count = 0 Then
            Dim ex As New Exception("Menu [" & menuID & "] não encontrado no arquivo de linguagem")
            Throw ex
        End If

        ' Scroll through the nodes
        For Each node In xmlDoc.DocumentElement.SelectNodes(".//menu[@name='" & menuID & "']")(0).ChildNodes
            If node.NodeType = XmlNodeType.Element Then
                dr = dt.NewRow

                'validação dos dados informados no xml para o menu
                'todo - faltam mais validações

                If node.Attributes("id") Is Nothing Then
                    Dim ex As New Exception("[" & menuID & "] - ID do item deve ser informado")
                    Throw ex
                End If

                If node.Attributes("text") Is Nothing Then
                    Dim ex As New Exception("[" & menuID & "] - Texto do item deve ser informado")
                    Throw ex
                End If


                If node.Attributes("level") IsNot Nothing Then
                    dr("level") = node.Attributes("level").Value()
                Else
                    dr("level") = "0"
                End If


                If Not IsNumeric(node.Attributes("id").Value()) Then
                    Dim ex As New Exception("[" & menuID & "] - [id] deve ser numérico")
                    Throw ex
                End If

                If Not IsNumeric(node.Attributes("level").Value()) Then
                    Dim ex As New Exception("[" & menuID & "] - [level] deve ser numérico")
                    Throw ex
                End If

                If CInt(dr("level")) > 0 Then
                    If node.Attributes("parentid") Is Nothing Then
                        Dim ex As New Exception("[" & menuID & "] - [parentid] deve ser informado quando [level] maior que 0")
                        Throw ex
                    End If
                End If
                'fim validações



                If node.Attributes("id") IsNot Nothing Then dr("id") = node.Attributes("id").Value()
                If node.Attributes("text") IsNot Nothing Then dr("text") = node.Attributes("text").Value()
                If node.Attributes("tooltip") IsNot Nothing Then dr("tooltip") = node.Attributes("tooltip").Value()
                If node.Attributes("url") IsNot Nothing Then dr("url") = node.Attributes("url").Value()
                If node.Attributes("image") IsNot Nothing Then dr("image") = node.Attributes("image").Value()
                If node.Attributes("parentid") IsNot Nothing Then dr("parentid") = node.Attributes("parentid").Value()
                If node.Attributes("roles") IsNot Nothing Then dr("roles") = node.Attributes("roles").Value()


                dt.Rows.Add(dr)
            End If
        Next

        Return dt

    End Function

End Class
