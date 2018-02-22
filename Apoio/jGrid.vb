Imports System.Web
Imports System.Xml
Imports System.Text

Public Class jGrid

    Private base As New Apoio.Base
    Private web As New Apoio.Web


    Private filterInfoText As String = ""
    Private allowEdit As Boolean = True
    Private allowInsert As Boolean = True
    Private allowUpdate As Boolean = True
    Private allowDelete As Boolean = True
    Private allowFiltering As Boolean = True
    Private allowCustom As Boolean = False
    Private allowPaging As Boolean = True
    Private allowCheck As Boolean = False
    Private allowView As Boolean = True
    Private allowSort As Boolean = True
    Private checkMode As String = "multiple"
    Public Function headerHtml(ByVal dt As DataTable) As String
        Dim html As String = ""
        Dim std As String = ""
        Dim width As String = ""
        Dim text As String = ""
        Dim name As String = ""
        Dim id As String = ""
        Dim allowsort As String = ""
        Dim classname As String = ""
        Dim stdBegin As String = "<th id='#id#' #class# name='#name#'>#text#</th>"
        Dim stdCheck As String = "<th id='#id#' #class# name='#name#'><input id='chk#id#' type='checkbox' #visible# onclick='javascript:SelectAllCheckboxes(this);'></input></th>"
        Dim command As String = ""
        Dim visible As String = ""
        Dim columnVisible As String = ""


        html += "<thead><tr>" & vbCrLf

        For Each dr As DataRow In dt.Rows


            If dr.Table.Columns.Contains("AllowSort") Then allowsort = base.NullToEmpty(dr("AllowSort")).ToUpper
            If dr.Table.Columns.Contains("ID") Then id = base.NullToEmpty(dr("ID"))
            If dr.Table.Columns.Contains("CommandName") Then command = base.NullToEmpty(dr("CommandName")).ToUpper
            If dr.Table.Columns.Contains("Text") Then text = base.NullToEmpty(dr("Text"))
            If dr.Table.Columns.Contains("CommandArgument") Then name = base.NullToEmpty(dr("CommandArgument"))
            If dr.Table.Columns.Contains("Visible") Then visible = base.NullToEmpty(dr("Visible")).ToUpper
            If dr.Table.Columns.Contains("ColumnVisible") Then columnVisible = base.NullToEmpty(dr("ColumnVisible")).ToUpper

            If command <> "CHECK" Or (command = "CHECK" And (visible = "FALSE" Or (visible = "TRUE" And checkMode = "one"))) Then
                std = stdBegin
            Else
                std = stdCheck
                If visible = "FALSE" Or checkMode.ToUpper = "ONE" Then
                    std = Replace(std, "#visible#", "style='visibility:hidden;'")
                Else
                    std = Replace(std, "#visible#", "")
                End If
            End If


            If visible = "FALSE" Then
                text = ""
                visible = "style='visibility:hidden;'"
            End If


            If columnVisible = "FALSE" Then
                classname = "hidden"
            Else
                If command <> "SORT" Or allowsort = "FALSE" Then
                    classname = "nonsort"
                Else
                    classname = ""
                End If
            End If

            std = Replace(std, "#id#", id)
            std = Replace(std, "#text#", text)
            std = Replace(std, "#name#", name)


            If classname.Trim.Length > 0 Then
                If classname <> "hidden" Then
                    std = Replace(std, "#class#", "class='" & classname & "'")
                Else
                    std = Replace(std, "#class#", "style='visibility:hidden;display:none;'")
                End If

            Else
                std = Replace(std, "#class#", classname)
            End If


            'std = Replace(std, "#width#", width)

            html += std & vbCrLf
        Next

        html += "</tr></thead>"

        Return html
    End Function
    Public Function htmlDetailsTable(ByVal dt As DataTable) As String
        Dim html As String = ""
        Dim className As String = ""
        Dim count As Integer = 0

        html += "<table class='table_line_details'>" & vbCrLf

        html += "<thead><tr class='table_line_details_header'>" & vbCrLf
        html += "#HEADER#"
        html += "</thead>" & vbCrLf

        html += "<tbody>"


        For Each dr As DataRow In dt.Rows

            If count Mod 2 = 0 Then
                className = "table_line_details_row_even"
            Else
                className = "table_line_details_row_odd"
            End If


            html += "<tr class='" & className & "'>" & vbCrLf
            html += "#ROW" & CStr(count) + 1 & "#"
            html += "</tr>" & vbCrLf

            count += 1

        Next

        html += "</tbody>"

        html += "</ table>" & vbCrLf

        Return html
    End Function



    Public Function htmlData(ByVal dtDados As DataTable, ByVal data_config As String) As String

        Dim html As String = ""
        Dim xmlDoc As New XmlDocument
        Dim xmlReader As XmlReader
        Dim ds As New DataSet
        Dim item_config As DataTable

        xmlDoc.LoadXml(data_config)
        xmlReader = New XmlNodeReader(xmlDoc)

        ds.ReadXml(xmlReader)
        item_config = ds.Tables(0)

        For Each dr As DataRow In dtDados.Rows
            html += Me.GetRow(dr, item_config)
        Next

        Return html

    End Function
    Public Function vars_filtro(ByVal context As HttpContext, _
                                    ByRef val_filter_field As String, _
                                    ByRef val_filter_value As String) _
                                    As String

        val_filter_field = base.value_to_null2(context.Request.Form("val_filter_field"), 1)
        val_filter_value = base.value_to_null2(context.Request.Form("val_filter_value"), 1)

        If val_filter_value IsNot Nothing Then
            If val_filter_value.Trim.Length > 0 Then
                val_filter_value = Replace(val_filter_value, "%", "")
                val_filter_value = "%" & val_filter_value & "%"
            End If
        End If


        Return ""


    End Function

    Public Function GetRow(ByVal dr As DataRow, _
                          ByVal item_config As DataTable) As String

        Dim html As New StringBuilder()
        Dim field As String = ""
        Dim controltype As String = ""
        Dim command As String = ""
        Dim image As String = ""
        Dim order As String = ""
        Dim tooltip As String = ""
        Dim value As String = ""
        Dim maxlength As String = ""
        Dim _control As String = ""
        Dim _readonly As String = ""
        Dim fieldwidth As String = ""
        Dim cellwidth As String = ""
        Dim line As String = ""
        Dim align As String = ""
        Dim visible As String = ""
        Dim columnvisible As String = ""
        Dim disablefield As String = ""
        Dim checkmode As String = ""
        Dim id As String = ""

        Dim imagesPath As String = "scripts\plugins\grid"

        Dim selectionmode As String = ""
        Dim datatextfield As String = ""
        Dim datavaluefield As String = ""
        Dim servermethodname As String = ""

        Dim type As String = ""
        Dim dateformat As String = ""

        Dim text As String = ""

        html.AppendLine("<tr>")
        Dim incCheck As Integer = 1

        For Each cfg As DataRow In item_config.Rows

            id = cfg("id").ToString.Trim
            fieldwidth = cfg("fieldwidth").ToString.Trim
            cellwidth = cfg("cellwidth").ToString.Trim
            maxlength = cfg("MaxLength").ToString.Trim
            controltype = cfg("ControlType").ToString.Trim.ToUpper
            field = cfg("Field").ToString.Trim
            command = cfg("CommandName").ToString.Trim.ToUpper
            image = imagesPath & "\" & cfg("ImageUrl").ToString.Trim
            order = cfg("Order").ToString.Trim.ToUpper
            tooltip = cfg("Tooltip").ToString.Trim
            _readonly = cfg("ReadOnly").ToString.Trim.ToUpper
            align = cfg("CellAlign").ToString.Trim
            visible = cfg("visible").ToString.Trim.ToUpper
            columnvisible = cfg("columnvisible").ToString.Trim.ToUpper
            disablefield = cfg("disablefield").ToString.Trim
            checkmode = cfg("checkMode").ToString.Trim.ToUpper

            selectionmode = cfg("selectionmode").ToString.Trim.ToUpper
            datatextfield = cfg("datatextfield").ToString.Trim
            datavaluefield = cfg("datavaluefield").ToString.Trim
            servermethodname = cfg("servermethodname").ToString.Trim

            type = cfg("type").ToString.Trim
            dateformat = cfg("dateformat").ToString.Trim

            text = cfg("text").ToString.Trim



            If align.Trim.Length = 0 Then align = "center"


            Dim resvalue As String = ""

            Select Case command

                Case "", "EXPANDCOLLAPSE" 'datafield

                    If field.Trim.Length > 0 Then

                        If dr.Table.Columns.Contains(field) Then
                            value = dr(field).ToString.Trim
                            resvalue = value


                            If IsNumeric(maxlength) Then
                                If value.Length > CInt(maxlength) Then
                                    resvalue = value.Substring(0, maxlength) & "..."
                                End If
                            End If
                        Else
                            value = ""
                            resvalue = ""
                        End If
                    Else
                        value = ""
                        resvalue = ""
                    End If


                    If selectionmode <> "MULTIPLE" Then

                        Select Case _readonly

                            Case "TRUE", ""


                                If maxlength.Trim.Length = 0 Then
                                    If resvalue.Trim.Length > 50 Then
                                        resvalue = base.PulaLinhaACadaNCaracteres(resvalue, 50)
                                    End If
                                End If

                                If type = "Date" Then
                                    If dateformat.Trim.Length > 0 Then
                                        If IsDate(resvalue) Then
                                            resvalue = Format(CDate(resvalue), dateformat)
                                        End If
                                    End If
                                End If

                                If text.Trim.Length > 0 Then
                                    resvalue = text.Trim & "</br >" & resvalue
                                End If

                                _control = "<a #visible#>" & resvalue & "</a>"
                                line = "<td type='data' #columnvisible# #align# #width# title='" & tooltip & "' class='" & field & "'>" & _control & "#expand#</td>"





                            Case "FALSE"

                                'Select Case type
                                '    Case "Date"
                                '        _control = "<input style='width:" & CStr(fieldwidth) & ";#visible#' class='editable' type='text' title='" & tooltip & "' value='" & resvalue & "' maxlength='" & maxlength & "'></input>"
                                '        line = "<td type='text' #columnvisible# #align# #width# class='" & field & "'>" & _control & "#expand#</td>"


                                '        If visible.Trim.Length > 0 Then
                                '            Select Case visible
                                '                Case "TRUE" : line = Replace(line, "#visible#", "")
                                '                Case "FALSE" : line = Replace(line, "#visible#", "visibility:hidden;")
                                '            End Select
                                '        Else
                                '            line = Replace(line, "#visible#", "")
                                '        End If


                                '    Case Else
                                If Not IsNumeric(maxlength) Then maxlength = "15"

                                If type = "Date" Then
                                    If dateformat.Trim.Length > 0 Then
                                        If IsDate(resvalue) Then
                                            resvalue = Format(CDate(resvalue), dateformat)
                                        End If
                                    End If
                                End If

                                _control = "<input style='width:" & CStr(fieldwidth) & ";#visible#' class='editable' type='text' title='" & tooltip & "' value='" & resvalue & "' maxlength='" & maxlength & "' #dateattr#></input>"
                                line = "<td type='text' #columnvisible# #align# #width# class='" & field & "'>" & _control & "#expand#</td>"

                                line = Replace(line, "#dateattr#", IIf(type <> "Date", "", "isDate='true' dateFormat='" & dateformat & "'"))



                                If visible.Trim.Length > 0 Then
                                    Select Case visible
                                        Case "TRUE" : line = Replace(line, "#visible#", "")
                                        Case "FALSE" : line = Replace(line, "#visible#", "visibility:hidden;")
                                    End Select
                                Else
                                    line = Replace(line, "#visible#", "")
                                End If

                                'End Select


                        End Select
                    Else

                        'combo box
                        _control = "<select datatextfield='" & datatextfield & "' datavaluefield = '" & datavaluefield & "' servermethodname='" & servermethodname & "' style='width:" & CStr(fieldwidth) & ";#visible#' class='comboboxgrid' title='" & tooltip & "'></select>"
                        _control += "<input type='hidden' value = '" & value & "'></input>"
                        '_control += "<input type='text' value = '" & value & "'></input>"
                        line = "<td type='select' #columnvisible# #align# #width# class='" & field & "'>" & _control & "#expand#</td>"


                        If visible.Trim.Length > 0 Then
                            Select Case visible
                                Case "TRUE"
                                    line = Replace(line, "#visible#", "")
                                Case "FALSE"
                                    line = Replace(line, "#visible#", "visibility:hidden;")
                            End Select
                        Else
                            line = Replace(line, "#visible#", "")
                        End If

                    End If


                Case Else

                    'commands
                    Dim showCmd As Boolean = True


                    Select Case command
                        Case "EDIT"
                            showCmd = allowEdit
                            line = "<td type='command' #columnvisible# #align# #width# class='edit'><span class='fnc'><img src='" & image & "' alt='' title='" & tooltip & "' #visible#/></span></td>"
                        Case "DELETE"
                            showCmd = allowDelete
                            line = "<td type='command' #columnvisible# #align# #width# class='delete'><span class='fnc'><img src='" & image & "' alt='' title='" & tooltip & "' #visible# /></span></td>"

                        Case "SELECT"
                            showCmd = allowView
                            line = "<td type='command' #columnvisible# #align# #width# class='select'><span class='fnc'><img src='" & image & "' alt='' title='" & tooltip & "' #visible# /></span></td>"

                        Case "CHECK"
                            showCmd = allowCheck
                            line = "<td type='check' #columnvisible# #align# #width# class='check" & IIf(incCheck <> 1, incCheck, "") & "'><span class='fnc'><input type='checkbox' title='" & tooltip & "' #visible# #click# /></span></td>"
                            incCheck += 1

                            Select Case checkmode
                                Case "ONE"
                                    line = Replace(line, "#click#", "onclick='javascript:UnSelectOtherCheckboxes(this);'")
                                Case "MULTIPLE"
                                    line = Replace(line, "#click#", "")
                            End Select

                    End Select


                    If showCmd And disablefield.Trim.Length > 0 Then
                        showCmd = CheckDisableValue(dr(disablefield))
                        visible = CStr(showCmd).ToUpper
                    End If


            End Select


            If cellwidth.Trim.Length > 0 Then
                line = Replace(line, "#width#", "style='width:" & cellwidth & ";'")
            Else
                line = Replace(line, "#width#", "")
            End If

            If align.Trim.Length > 0 Then
                line = Replace(line, "#align#", "align='" & align & "'")
            Else
                line = Replace(line, "#align#", "")
            End If


            If visible.Trim.Length > 0 Then
                Select Case visible
                    Case "TRUE"
                        line = Replace(line, "#visible#", "")
                    Case "FALSE"
                        line = Replace(line, "#visible#", "style='visibility:hidden;'")
                End Select
            Else
                line = Replace(line, "#visible#", "")
            End If


            If columnvisible.Trim.Length > 0 Then
                Select Case columnvisible
                    Case "TRUE"
                        line = Replace(line, "#columnvisible#", "")
                    Case "FALSE"
                        line = Replace(line, "#columnvisible#", "style='visibility:hidden;display:none;'")
                End Select
            Else
                line = Replace(line, "#columnvisible#", "")
            End If

            Dim expand As String = ""
            Dim expand_tooltip As String = "Clique aqui para visualizar mais detalhes"
            If command = "EXPANDCOLLAPSE" Then
                expand = "<img align='center' style='cursor:pointer;margin:5px;' id='expand' status='collapsed' src='scripts\plugins\grid\plus.png' alt='' title='" & expand_tooltip & "' />"
            End If

            line = line.Replace("#expand#", expand)

            line = line.Replace("#id#", id)

            html.AppendLine(line)

        Next


        html.AppendLine("</tr>")

        Return html.ToString()

    End Function

    Public Function ReturnCommandValidation(ByVal message As String) As String
        Dim ret As String = message
        Return ret
    End Function

    Public Function ReturnCommandResults(ByVal ret As Boolean, ByVal Mode As Integer, ByVal err As String) As String

        Dim errMsg As String = ""

        If err.ToString.Trim.Length > 0 Then
            If err.ToUpper.Contains("DUPLICATE KEY") Then
                errMsg = "Registro já existe"
            Else
                Select Case Mode
                    Case 1
                        errMsg = "Ocorreu um erro ao tentar inserir registro: " & err
                    Case 2
                        errMsg = "Ocorreu um erro ao tentar atualizar registro: " & err
                    Case 3
                        errMsg = "Ocorreu um erro ao tentar excluir registro: " & err
                End Select

            End If

            Dim ex As New Exception(errMsg)
            Throw ex


        Else

            If ret Then
                Select Case Mode
                    Case 1
                        Return "Registro inserido com sucesso"
                    Case 2
                        Return "Registro atualizado com sucesso"
                    Case 3
                        Return "Registro excluído com sucesso"
                End Select

            Else
                Select Case Mode
                    Case 1
                        Return "Ocorreu um problema ao tentar inserir registro: nenhum registro afetado"
                    Case 2
                        Return "Ocorreu um problema ao tentar atualizar registro: nenhum registro afetado"
                    Case 3
                        Return "Ocorreu um problema ao tentar excluir registro: nenhum registro afetado"
                End Select


            End If


        End If

        Return ""
    End Function
    Private Function filterHtml(ByVal dt As DataTable) As String
        Dim html As String = ""
        Dim std As String = ""
        Dim text As String = ""
        Dim value As String = ""
        Dim id As String = ""
        Dim imagesPath As String = "scripts\plugins\grid"

        If filterInfoText.Trim.Length > 0 Then
            html += "<span id='info'>" & filterInfoText.Trim & "</span>"
        End If

        html += "<select id='cboFiltro'>" & vbCrLf

        For Each dr As DataRow In dt.Rows

            std = "<option id='{0}' value='{1}'>{2}</option>"

            text = dr("Text").ToString.Trim
            value = dr("Value").ToString.Trim
            id = dr("ID").ToString.Trim

            std = String.Format(std, id, value, text)

            html += std & vbCrLf

        Next

        html += "</ select>" & vbCrLf


        html += "<input style='margin-left:10px;' id='txtFiltro' type='text'></input>"
        html += "&nbsp;&nbsp;"
        html += "<img id='imgFilter' src='" & imagesPath & "\lupa.gif' alt='' />"
        html += "&nbsp;"
        html += "<img id='imgClear' src='" & imagesPath & "\vassoura.gif' alt='' />"

        Return html
    End Function




    Private Function CheckDisableValue(ByVal Flag As String) As Boolean
        Dim ret As Boolean = True

        Select Case UCase(Flag)
            Case "0", "N", "FALSE", "F" : ret = False
            Case "1", "S", "TRUE", "T" : ret = True
        End Select


        Return ret
    End Function
    Public Function createReturnTable(ByVal retText As String, _
                                      ByVal retType As String, _
                                      ByVal logText As String) As DataTable

        Dim dt As New DataTable

        dt.Columns.Add("retText")
        dt.Columns.Add("retType")
        dt.Columns.Add("logText")

        Dim dr As DataRow = dt.NewRow
        dr("retText") = retText
        dr("retType") = retType
        dr("logText") = logText
        dt.Rows.Add(dr)

        Return dt

    End Function


    'implements get header fields
    Public Overridable Function getHeaderFields(ByVal context As HttpContext) As String
        Dim dt As DataTable
        Dim html As String = ""
        Dim ds As New DataSet

        Dim idGrid As String = context.Request.Form("idGrid")
        Dim headerPath As String = context.Request.Form("headerPath")

        allowView = context.Request.Form("allowView") = "true"
        allowDelete = context.Request.Form("allowDelete") = "true"
        allowCustom = context.Request.Form("allowCustom") = "true"
        allowCheck = context.Request.Form("allowCheck") = "true"
        allowEdit = context.Request.Form("allowEdit") = "true"
        allowSort = context.Request.Form("allowSort") = "true"
        checkMode = context.Request.Form("checkMode")



        ds.ReadXml(context.Server.MapPath(headerPath))


        Dim dr1() As DataRow = ds.Tables(0).Select("ID = '" & idGrid & "'")
        If dr1.Length = 0 Then Return Nothing


        Dim dr() As DataRow = ds.Tables(1).Select("grid_Id = '" & dr1(0)(0) & "'")
        Dim dtFinal As DataTable
        Dim drFiltro() As DataRow
        Dim Filtro As String = ""

        dt = dr(0).Table.Clone
        dt.TableName = "tblGridFields"
        If dt.Columns.Contains("Order") Then
            dt.Columns("Order").DataType = System.Type.GetType("System.Int32")
        End If



        For Each l As DataRow In dr
            dt.Rows.Add(l.ItemArray)
        Next


        'Se não permitir edição, exclui linhas com CommandName="Edit"
        'Se não permitir exclusão, exclui linhas com CommandName="Delete"
        'Se não permitir seleção, exclui linhas com CommandName="Select"
        'Se não permitir custom, exclui linhas com CommandName="Custom"
        'Se não permitir check, exclui linhas com CommandName="Check"

        If Not allowEdit Then
            If Filtro.Length > 0 Then Filtro += " and "
            Filtro += " CommandName <> 'Edit' "
        End If

        If Not allowDelete Then
            If Filtro.Length > 0 Then Filtro += " and "
            Filtro += " CommandName <> 'Delete' "
        End If

        If Not allowView Then
            If Filtro.Length > 0 Then Filtro += " and "
            Filtro += " CommandName <> 'Select' "
        End If

        If Not allowCustom Then
            If Filtro.Length > 0 Then Filtro += " and "
            Filtro += " CommandName <> 'Custom' "
        End If

        If Not allowCheck Then
            If Filtro.Length > 0 Then Filtro += " and "
            Filtro += " CommandName <> 'Check' "
        End If

        If Filtro.Length > 0 Then
            Filtro += " OR CommandName is null"
        End If


        dtFinal = dt.Clone

        drFiltro = dt.Select(Filtro, "Order ASC")

        For Each linhaFiltro As DataRow In drFiltro
            dtFinal.Rows.Add(linhaFiltro.ItemArray)
        Next


        'Adiciona coluna que indica se permitirá "Sort" ou não
        dtFinal.Columns.Add("AllowSort")
        For Each linhaFiltro As DataRow In dtFinal.Rows
            linhaFiltro("AllowSort") = allowSort
        Next

        html = headerHtml(dtFinal)

        Return html


    End Function

    'implement getFilterFields
    Public Overridable Function getFilterFields(ByVal context As HttpContext) As String
        Dim dt As DataTable
        Dim html As String = ""
        Dim ds As New DataSet

        Dim idGrid As String = context.Request.Form("idGrid")
        Dim filterPath As String = context.Request.Form("filterPath")

        filterInfoText = context.Request.Form("filterInfoText")


        ds.ReadXml(context.Server.MapPath(filterPath))
        Dim dr1() As DataRow = ds.Tables(0).Select("ID = '" & idGrid & "'")
        If dr1.Length = 0 Then Return Nothing


        Dim dr() As DataRow = ds.Tables(1).Select("Filter_Id = '" & dr1(0)(0) & "'")

        dt = dr(0).Table.Clone
        dt.TableName = "tblFilterFields"

        For Each l As DataRow In dr
            dt.Rows.Add(l.ItemArray)
        Next

        html = filterHtml(dt)

        Return html

    End Function


    'implement getFullLayout
    Public Overridable Function getFullLayout(ByVal context As HttpContext) As String
        Dim dt As New DataTable
        dt.Columns.Add("data")
        Dim dr As DataRow

        dr = dt.NewRow
        dr(0) = getHeaderFields(context)
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr(0) = getFilterFields(context)
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr(0) = getGridDataConfig(context)
        dt.Rows.Add(dr)

        Return web.GetJson(dt)
    End Function
    'implement getGridDataConfig
    Public Overridable Function getGridDataConfig(ByVal context As HttpContext) As String
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim html As String = ""

        Dim idGrid As String = context.Request.Form("idGrid")
        Dim dataPath As String = context.Request.Form("dataPath")
        allowView = context.Request.Form("allowView") = "true"
        allowDelete = context.Request.Form("allowDelete") = "true"
        allowCustom = context.Request.Form("allowCustom") = "true"
        allowCheck = context.Request.Form("allowCheck") = "true"
        allowEdit = context.Request.Form("allowEdit") = "true"
        allowSort = context.Request.Form("allowSort") = "true"
        checkMode = context.Request.Form("checkMode")

        ds.ReadXml(context.Server.MapPath(dataPath))

        Dim dr1() As DataRow = ds.Tables(0).Select("ID = '" & idGrid & "'")
        If dr1.Length = 0 Then Return Nothing

        Dim dr() As DataRow = ds.Tables(1).Select("grid_Id = '" & dr1(0)(0) & "'")
        Dim dtFinal As DataTable
        Dim drFiltro() As DataRow
        Dim Filtro As String = ""
        Dim newRow As DataRow

        dt = AddDataColumns()
        dt.TableName = "tblGridDataFields"


        For Each l As DataRow In dr
            newRow = dt.NewRow
            For Each c As DataColumn In dt.Columns
                If l.Table.Columns.Contains(c.ColumnName) Then
                    newRow(c.ColumnName) = l(c.ColumnName).ToString.Trim
                Else
                    newRow(c.ColumnName) = ""
                End If
            Next
            dt.Rows.Add(newRow)
        Next


        'Se não permitir edição, exclui linhas com CommandName="Edit"
        'Se não permitir exclusão, exclui linhas com CommandName="Delete"
        'Se não permitir seleção, exclui linhas com CommandName="Select"
        'Se não permitir custom, exclui linhas com CommandName="Custom"
        'Se não permitir check, exclui linhas com CommandName="Check"

        If Not allowEdit Then
            If Filtro.Length > 0 Then Filtro += " and "
            Filtro += " CommandName <> 'Edit' "
        End If

        If Not allowDelete Then
            If Filtro.Length > 0 Then Filtro += " and "
            Filtro += " CommandName <> 'Delete' "
        End If

        If Not allowView Then
            If Filtro.Length > 0 Then Filtro += " and "
            Filtro += " CommandName <> 'Select' "
        End If

        If Not allowCustom Then
            If Filtro.Length > 0 Then Filtro += " and "
            Filtro += " CommandName <> 'Custom' "
        End If

        If Not allowCheck Then
            If Filtro.Length > 0 Then Filtro += " and "
            Filtro += " CommandName <> 'Check' "
        End If

        If Filtro.Length > 0 Then
            Filtro += " OR CommandName is null"
        End If

        dtFinal = dt.Clone
        drFiltro = dt.Select(Filtro, "Order ASC")

        For Each linhaFiltro As DataRow In drFiltro
            dtFinal.Rows.Add(linhaFiltro.ItemArray)
        Next


        'Adiciona coluna que indica se permitirá "Multiples Checks" ou não
        dtFinal.Columns.Add("CheckMode")
        For Each linhaFiltro As DataRow In dtFinal.Rows
            linhaFiltro("CheckMode") = checkMode
        Next

        Dim writer As New System.IO.StringWriter()
        dtFinal.WriteXml(writer, True)

        Return writer.ToString

    End Function
    Private Function AddDataColumns() As DataTable
        Dim dtTemp As New DataTable

        dtTemp.Columns.Add("ID")
        dtTemp.Columns.Add("ControlType")
        dtTemp.Columns.Add("Field")
        dtTemp.Columns.Add("Order", System.Type.GetType("System.Int32"))
        dtTemp.Columns.Add("ReadOnly")
        dtTemp.Columns.Add("CellWidth")
        dtTemp.Columns.Add("CellAlign")
        dtTemp.Columns.Add("FieldWidth")
        dtTemp.Columns.Add("MaxLength")
        dtTemp.Columns.Add("CommandName")
        dtTemp.Columns.Add("ImageURL")
        dtTemp.Columns.Add("CommandArgument")
        dtTemp.Columns.Add("Tooltip")
        dtTemp.Columns.Add("OnClientClick")
        dtTemp.Columns.Add("DisableProperty")
        dtTemp.Columns.Add("DisableField")
        dtTemp.Columns.Add("Text")
        dtTemp.Columns.Add("AutoPostBack")
        dtTemp.Columns.Add("ColumnVisible")
        dtTemp.Columns.Add("Visible")
        dtTemp.Columns.Add("SelectionMode")
        dtTemp.Columns.Add("DataTextField")
        dtTemp.Columns.Add("DataValueField")
        dtTemp.Columns.Add("ServerMethodName")
        dtTemp.Columns.Add("Type")
        dtTemp.Columns.Add("DateFormat")
        Return dtTemp
    End Function
End Class
