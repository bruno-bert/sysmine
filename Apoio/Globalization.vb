Imports System.Xml

Public Class Globalization
    Public Sub New()

    End Sub
    Public Function getValue(ByVal dt As DataTable, ByVal fieldID As String) As String
        Dim value As String = ""
        Dim dr() As DataRow

        dr = dt.Select("name = '" & fieldID & "' ")

        If dr.Length > 0 Then
            value = dr(0)("value").ToString.Trim
        Else
            value = fieldID
        End If

        Return value
    End Function
    Public Function getValue(ByVal dt As DataTable, ByVal fieldID As String, ByVal defaultvalue As String) As String
        Dim value As String = ""
        Dim dr() As DataRow

        dr = dt.Select("name = '" & fieldID & "' ")

        If dr.Length > 0 Then
            value = Replace(dr(0)("value").ToString.Trim, "[PULA]", vbCrLf)
        Else
            value = defaultvalue
        End If

        Return value
    End Function
    Public Function getValue(ByVal dt As DataTable, ByVal fieldID As String, ByVal index As String, ByVal defaultvalue As String) As String
        Dim value As String = ""
        Dim dr() As DataRow

        dr = dt.Select("name = '" & fieldID & "' and index = '" & index & "' ")

        If dr.Length > 0 Then
            value = dr(0)("value").ToString.Trim
        Else
            value = defaultvalue
        End If

        Return value
    End Function

    Public Function getListValue(ByVal dt As DataTable, ByVal fieldID As String, ByVal type As String) As String
        Dim value As String = ""
        Dim dr() As DataRow

        dr = dt.Select("name = '" & fieldID & "' and type = '" & type & "' ")

        If dr.Length > 0 Then
            value = dr(0)("value").ToString.Trim
        Else
            value = "#indefinido#"
        End If

        Return value
    End Function
    Public Function getValue(ByVal dt As DataTable, ByVal fieldID As String, _
                             ByVal index As String, ByVal _property As String, _
                             ByVal defaultvalue As String) As String
        Dim value As String = ""
        Dim dr() As DataRow

        dr = dt.Select("name = '" & fieldID & "' and index = '" & index & "' and property = '" & _property & "' ")

        If dr.Length > 0 Then
            value = dr(0)("value").ToString.Trim
        Else
            value = defaultvalue
        End If

        Return value
    End Function

    Public Function getValues(ByVal dt As DataTable, ByVal fieldID As String) As DataRow()
        Dim dr() As DataRow
        dr = dt.Select("name = '" & fieldID & "' ")
        Return dr
    End Function

    Public Function getAttr(ByVal dt As DataTable, ByVal fieldID As String, ByVal attr As String) As String
        Dim value As String = ""
        Dim dr() As DataRow

        dr = dt.Select("name = '" & fieldID & "' ")

        If dr.Length > 0 Then
            If dr(0).Table.Columns.Contains(attr) Then
                value = dr(0)(attr).ToString.Trim
            Else
                value = "Atributo Inválido: " & attr
            End If
        Else
            value = ""
        End If

            Return value
    End Function
    Public Function getData(ByVal xmlPath As String, ByVal formID As String) As DataTable

        ' Load up the XML file
        Dim dr As DataRow
        Dim dt As DataTable
        Dim xmlDoc As XmlDocument
        Dim node As XmlNode


        xmlDoc = New XmlDocument
        xmlDoc.Load(xmlPath)

        dt = New DataTable
        dt.Columns.Add("name")
        dt.Columns.Add("value")
        dt.Columns.Add("type")



        ' Scroll through the nodes
        For Each node In xmldoc.documentelement.selectNodes(formID)(0).ChildNodes
            dr = dt.NewRow
            dr("name") = node.Attributes("name").value()
            dr("value") = node.Attributes("value").Value()

            Try
                dr("type") = node.Attributes("type").Value()
            Catch ex As Exception

            End Try


            dt.Rows.Add(dr)
        Next

        Return dt

    End Function

    Public Function getFormData(ByVal xmlPath As String, ByVal formID As String) As DataTable

        ' Load up the XML file
        Dim dr As DataRow
        Dim dt As DataTable
        Dim xmlDoc As XmlDocument
        Dim node As XmlNode


        xmlDoc = New XmlDocument
        xmlDoc.Load(xmlPath)

        dt = New DataTable
        dt.Columns.Add("name")
        dt.Columns.Add("value")
        dt.Columns.Add("description")
        dt.Columns.Add("index")
        dt.Columns.Add("property")


        If xmlDoc.DocumentElement.SelectNodes(".//form[@name='" & formID & "']").Count = 0 Then
            Dim ex As New Exception("Form [" & formID & "] não encontrado no arquivo de linguagem")
            Throw ex
        End If

        ' Scroll through the nodes
        For Each node In xmlDoc.DocumentElement.SelectNodes(".//form[@name='" & formID & "']")(0).ChildNodes
            If node.NodeType = XmlNodeType.Element Then
                dr = dt.NewRow
                dr("name") = node.Attributes("name").Value()
                dr("value") = node.Attributes("value").Value()

                Try
                    dr("description") = node.Attributes("description").Value()
                Catch ex As Exception
                End Try

                Try
                    dr("index") = node.Attributes("index").Value()
                Catch ex As Exception
                End Try

                Try
                    dr("property") = node.Attributes("property").Value()
                Catch ex As Exception
                End Try

                dt.Rows.Add(dr)
            End If
        Next

        Return dt

    End Function

    Public Function getListData(ByVal xmlPath As String, ByVal dictId As String) As DataTable

        ' Load up the XML file
        Dim dr As DataRow
        Dim dt As DataTable
        Dim xmlDoc As XmlDocument
        Dim node As XmlNode


        xmlDoc = New XmlDocument
        xmlDoc.Load(xmlPath)

        dt = New DataTable
        dt.Columns.Add("name")
        dt.Columns.Add("value")
     

        If xmlDoc.DocumentElement.SelectNodes(".//dict[@name='" & dictId & "']").Count = 0 Then
            Dim ex As New Exception("Lista [" & dictId & "] não encontrada no arquivo de linguagem")
            Throw ex
        End If

        ' Scroll through the nodes
        For Each node In xmlDoc.DocumentElement.SelectNodes(".//dict[@name='" & dictId & "']")(0).ChildNodes
            If node.NodeType = XmlNodeType.Element Then
                dr = dt.NewRow
                dr("name") = node.Attributes("name").Value()
                dr("value") = node.Attributes("value").Value()
                dt.Rows.Add(dr)
            End If
        Next

        Return dt

    End Function

    

  
End Class
