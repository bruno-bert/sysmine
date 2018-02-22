Imports System.Text.RegularExpressions
Imports IconToolStrip

Module modGeral

    Public dtMensagem As DataTable
    Public default_user As String = ""
    Public base As New Apoio.Base
    Public xmlpath As String = ""
    Public connection As String = ""
    Public tempdir As String = ""
    Public logpath As String = ""
    Public boolExecute As Boolean = False
    Public kmlDir As String = ""
    Public kmlDirToMap As String = ""
    Public backupFile As String = ""
    Public kmlFileToMap As String = ""

    Public dirBackup As String = ""
    Public fileBackup As String = ""

    Public tempDocsDir As String = ""

    Public Enum enErrorType
        _Error = 0
        Warning = 1
        Info = 2
    End Enum

    Public Enum enOrgao
        DNPM = 0
        CETESB = 1
        DAEE = 2
        ICMBIO = 3
        PETROBRAS = 4
        PREFEITURA = 5
        PROJETOS = 6
    End Enum

    Private Function ConvertType(ByVal type As enErrorType) As MsgBoxStyle
        Select Case type
            Case enErrorType._Error
                Return MsgBoxStyle.Critical
            Case enErrorType.Info
                Return MsgBoxStyle.Information
            Case enErrorType.Warning
                Return MsgBoxStyle.Exclamation
        End Select
    End Function
    Private Function getTitleMessage(ByVal type As enErrorType) As String
        Select Case type
            Case enErrorType._Error
                Return gettext("title", 0)
            Case enErrorType.Warning
                Return gettext("title", 1)
            Case enErrorType.Info
                Return gettext("title", 2)
        End Select
        Return ""
    End Function
    Public Sub ShowMessage(ByVal message As String, ByVal innermessage As String, ByVal type As enErrorType)
        MsgBox(message, ConvertType(type), getTitleMessage(type))
        If type = enErrorType._Error Then SaveError("", message, innermessage)
    End Sub
    Public Sub ShowMessage(ByVal ex As Exception, ByVal type As enErrorType)
        Dim source As String = ex.Source & vbCrLf & ex.TargetSite.Name
        Dim innermessage As String = ""
        Dim message As String = ex.Message.ToString.Trim
        If ex.InnerException IsNot Nothing Then ex.InnerException.Message.ToString.Trim()
        message = message & vbCrLf & innermessage
        MsgBox(source & vbCrLf & message, ConvertType(type), getTitleMessage(type))
        If type = enErrorType._Error Then SaveError(source, ex.Message, innermessage)
    End Sub
    Public Sub ShowMessage(ByVal message As String, ByVal type As enErrorType)
        MsgBox(message, ConvertType(type), getTitleMessage(type))
        If type = enErrorType._Error Then
            SaveError("", message, "")
        End If
    End Sub
    Public Sub SaveError(ByVal source As String, ByVal message As String, ByVal innermessage As String)
        Dim dto As New DTO.tb_LESI_log_erro_sistema
        Dim bll As New BLL.tb_LESI_log_erro_sistema
        Dim ret As String = ""

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        'dto.LESI_cd_ocorrencia = 0
        dto.LESI_ds_exception = message
        dto.LESI_ds_inexception = innermessage
        dto.LESI_dt_ocorrencia = Now
        dto.LESI_nm_source = IIf(source.Trim.Length > 0, source, gettext("other", 0))
        dto.AUDT_dt_inclusao = Now
        dto.AUDT_nm_usuario_inclusao = default_user
        bll.SaveData(dto, ret, 0, Global.BLL.tb_LESI_log_erro_sistema.Mode.Insert)

        If ret.Trim.Length > 0 Then ShowMessage(gettext("message", 0) & ":" & ret, "", enErrorType.Warning)

    End Sub
    Public Function gettext(ByVal type As String, ByVal id As Integer) As String
        Dim value As String = ""
        Dim obj As New Apoio.Globalization
        value = obj.getListValue(dtMensagem, id, type)
        Return value
    End Function

    Public Function getInner(ByVal inner As Exception)
        If inner.InnerException Is Nothing Then
            Return ""
        Else
            Return inner.InnerException.Message.ToString.Trim
        End If
    End Function
    Public Sub Inicializacao()

        xmlpath = base.Setting("xmlpath", 0)
        connection = base.Setting("connection", 0)

        tempdir = base.Setting("temppath", 0)
        logpath = base.Setting("logpath", 0)
        kmlDir = base.Setting("kmlDir", 0)
        kmlDirToMap = base.Setting("kmlDirToMap", 0)
        kmlFileToMap = base.Setting("kmlFileToMap", 0)
        backupFile = base.Setting("backupFile", 0)
        tempDocsDir = base.Setting("tempdoc", 0)

        dirBackup = base.Setting("dirBackup", 0)
        fileBackup = base.Setting("fileBackup", 0)


        getMessages()

        default_user = gettext("other", 1)

    End Sub
    Public Sub MakeFormGlobal(ByVal Form As Object)
        ChangeControls(Form, True)
    End Sub
    Public Sub getMessages()
        Dim obj As New Apoio.Globalization
        dtMensagem = obj.getData(xmlpath, "list")
    End Sub
    Private Sub ChangeControls(ByVal frm As Object, Optional ByVal newForm As Boolean = False)

        Static dt As DataTable
        Static FormName As String
        Dim lst As BrightIdeasSoftware.DataListView
        Dim dg As DataGridView
        Dim obj As New Apoio.Globalization

        If newForm Then dt = Nothing

        If dt Is Nothing Then dt = obj.getFormData(xmlpath, frm.name)

        If frm.GetType.BaseType.Name = "Form" Then

            FormName = frm.Name


            If dt.Rows.Count > 0 Then

                'Select Case dt.Rows(0)("property").ToString.Trim
                '    Case "Text" 
                frm.text = obj.getValue(dt, FormName, frm.text)
                'End Select

            End If
        End If



        For Each c As Control In frm.Controls

            If c.HasChildren Then ChangeControls(c, False)

            'dt = SelectGlobalization(Language, Project, FormName, c.Name)


            Select Case c.GetType.Name


                Case "GroupBox", "TextBox", "Label", "RadioButton", "Button", "LinkLabel"


                    If dt.Rows.Count > 0 Then
                        c.Text = obj.getValue(dt, c.Name, c.Text) 'dt.Rows(0)("value").ToString.Trim
                    End If

                Case "mkc_ExpandingPanel"
                    If dt.Rows.Count > 0 Then
                        DirectCast(c, mkccontrols.windows.forms.control.mkc_ExpandingPanel).TextCaption = obj.getValue(dt, c.Name, c.Text) 'dt.Rows(0)("value").ToString.Trim
                    End If

                Case "MenuStrip"
                    Dim allDR() As DataRow = obj.getValues(dt, c.Name)
                    If allDR.Length > 0 Then
                        For Each dr As DataRow In allDR
                            If IsNumeric(dr("index")) Then
                                If DirectCast(c, MenuStrip).Items.Count > CInt(dr("index").ToString.Trim) Then
                                    DirectCast(c, MenuStrip).Items(CInt(dr("index").ToString.Trim)).Text = dr("value").ToString.Trim
                                End If
                            End If
                        Next
                    End If


                Case "MultipleImageToolStrip"
                    Dim allDR() As DataRow = obj.getValues(dt, c.Name)
                    If allDR.Length > 0 Then
                        For Each dr As DataRow In allDR
                            Select Case dr("property")
                                Case "text"
                                    ' If DirectCast(c, MultipleImageToolStrip).Items.Count > CInt(dr("index").ToString.Trim) Then
                                    DirectCast(c, MultipleImageToolStrip).Items(dr("index").ToString.Trim).Text = dr("value").ToString.Trim
                                    'End If
                                Case "image"

                            End Select

                        Next
                    End If

                Case "TabControlEx", "TabControl"

                    Dim allDR() As DataRow = obj.getValues(dt, c.Name)
                    If allDR.Length > 0 Then
                        For Each dr As DataRow In allDR
                            If IsNumeric(dr("index")) Then
                                If DirectCast(c, Object).TabPages.Count > CInt(dr("index").ToString.Trim) Then
                                    DirectCast(c, Object).TabPages(CInt(dr("index").ToString.Trim)).Text = dr("value").ToString.Trim
                                End If
                            End If
                        Next
                    End If

                Case "ListView"

                    lst = c
                    Dim allDR() As DataRow = obj.getValues(dt, c.Name)
                    If allDR.Length > 0 Then
                        'Select Case dt.Rows(0)("property").ToString.Trim
                        '   Case "Text"
                        For Each dr As DataRow In allDR
                            lst.Columns(CInt(dr("index").ToString.Trim)).Text = dr("value").ToString.Trim
                        Next
                        'End Select
                    End If

                Case "DataListView"

                    lst = c
                    Dim allDR() As DataRow = obj.getValues(dt, c.Name)
                    If allDR.Length > 0 Then
                        For Each dr As DataRow In allDR
                            Select Case dr("property")
                                Case "text"
                                    If IsNumeric(dr("index")) Then
                                        lst.Columns(CInt(dr("index").ToString.Trim)).Text = dr("value").ToString.Trim
                                    End If
                                Case "empty"
                                    lst.EmptyListMsg = dr("value").ToString.Trim
                            End Select

                        Next
                    End If


                Case "DataGridView"

                    dg = c

                    Dim allDR() As DataRow = obj.getValues(dt, c.Name)
                    If allDR.Length > 0 Then
                        'Select Case dt.Rows(0)("property").ToString.Trim
                        '  Case "Text"
                        For Each dr As DataRow In allDR
                            dg.Columns(dr("auxiliar").ToString.Trim).HeaderText = obj.getValue(dt, c.Name)  'dr("value").ToString.Trim
                        Next
                        'End Select
                    End If





            End Select



        Next



    End Sub

End Module
