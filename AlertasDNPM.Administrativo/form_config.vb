Public Class form_config
    Private default_url As String = gettext("parm", 0)
    Private default_intervalo As String = gettext("parm", 1)

    Private default_email As String = gettext("parm", 2)
    Private default_smtp As String = gettext("parm", 3)
    Private default_porta As String = gettext("parm", 4)
    Private default_usuario As String = gettext("parm", 5)
    Private default_senha As String = gettext("parm", 6)

    Private default_ini_vencto As String = gettext("parm", 7)
    Private default_int_vencto As String = gettext("parm", 8)

    Private Sub txtintervalo_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Try


            Dim isKey As Boolean = Char.IsDigit(e.KeyChar)
            Dim isDecimal As Boolean = e.KeyChar.ToString = "."
            If Not isKey And Not isDecimal Then
                e.Handled = True
            End If

        Catch ex As Exception
            'ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub text_inicio_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles text_inicio.KeyPress

        Try


            Dim isKey As Boolean = Char.IsDigit(e.KeyChar)
            Dim isDecimal As Boolean = e.KeyChar.ToString = "."
            If Not isKey And Not isDecimal Then
                e.Handled = True
            End If

        Catch ex As Exception
            'ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub text_intervalo_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles text_intervalo.KeyPress

        Try


            Dim isKey As Boolean = Char.IsDigit(e.KeyChar)
            Dim isDecimal As Boolean = e.KeyChar.ToString = "."
            If Not isKey And Not isDecimal Then
                e.Handled = True
            End If

        Catch ex As Exception
            'ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub CarregaConfiguracao()
        Dim dto As New DTO.tb_PGER_parametro_geral
        Dim bll As New BLL.tb_PGER_parametro_geral
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then

            txturl.Text = dt.Select("PGER_cd_parametro = 'URL'")(0)("PGER_vl_parametro")
            txtintervalo.Text = dt.Select("PGER_cd_parametro = 'INTERVALO'")(0)("PGER_vl_parametro")

            text_email.Text = dt.Select("PGER_cd_parametro = 'MAIL'")(0)("PGER_vl_parametro")
            text_smtp.Text = dt.Select("PGER_cd_parametro = 'SMTP'")(0)("PGER_vl_parametro")
            text_porta.Text = dt.Select("PGER_cd_parametro = 'PORT'")(0)("PGER_vl_parametro")
            text_usuario.Text = dt.Select("PGER_cd_parametro = 'USER'")(0)("PGER_vl_parametro")
            text_senha.Text = dt.Select("PGER_cd_parametro = 'PASS'")(0)("PGER_vl_parametro")

            'text_inicio.Text = dt.Select("PGER_cd_parametro = 'INI'")(0)("PGER_vl_parametro")
            'text_intervalo.Text = dt.Select("PGER_cd_parametro = 'INT'")(0)("PGER_vl_parametro")


        Else
            'txtintervalo.Text = default_intervalo
            'txturl.Text = default_url

            text_email.Text = default_email
            text_smtp.Text = default_smtp
            text_porta.Text = default_porta
            text_usuario.Text = default_usuario
            text_senha.Text = default_senha


            text_inicio.Text = default_ini_vencto
            text_intervalo.Text = default_int_vencto

        End If

    End Sub
    Private Sub frmConfig_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            MakeFormGlobal(Me)
            CarregaConfiguracao()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function SaveParm(ByVal name As String, ByVal value As String) As String

        Dim dto As New DTO.tb_PGER_parametro_geral
        Dim bll As New BLL.tb_PGER_parametro_geral
        Dim message As String = ""
        Dim ret As Boolean = False


        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PGER_cd_parametro = name
        dto.PGER_vl_parametro = value
        dto.AUDT_dt_alteracao = Now
        dto.AUDT_nm_usuario_alteracao = default_user
        ret = bll.SaveData(dto, message, 0, Global.BLL.tb_PGER_parametro_geral.Mode.Update)

        Return message

    End Function
    Private Function SalvarDados() As Boolean

     
        Dim message As String = ""
        Dim ret As Boolean = False


        message = SaveParm("INTERVALO", txtintervalo.Text)
        If message.Trim.Length > 0 Then
            ShowMessage(message, "", 1)
            Return False
        End If

        message = SaveParm("URL", txturl.Text)
        If message.Trim.Length > 0 Then
            ShowMessage(message, "", 1)
            Return False
        End If

        message = SaveParm("MAIL", text_email.Text)
        If message.Trim.Length > 0 Then
            ShowMessage(message, "", 1)
            Return False
        End If

        message = SaveParm("SMTP", text_smtp.Text)
        If message.Trim.Length > 0 Then
            ShowMessage(message, "", 1)
            Return False
        End If

        message = SaveParm("PORT", text_porta.Text)
        If message.Trim.Length > 0 Then
            ShowMessage(message, "", 1)
            Return False
        End If

        message = SaveParm("USER", text_usuario.Text)
        If message.Trim.Length > 0 Then
            ShowMessage(message, "", 1)
            Return False
        End If

        message = SaveParm("PASS", text_senha.Text)
        If message.Trim.Length > 0 Then
            ShowMessage(message, "", 1)
            Return False
        End If

        'message = SaveParm("INI", text_inicio.Text)
        'If message.Trim.Length > 0 Then
        '    ShowMessage(message, "", 1)
        '    Return False
        'End If

        'message = SaveParm("INT", text_intervalo.Text)
        'If message.Trim.Length > 0 Then
        '    ShowMessage(message, "", 1)
        '    Return False
        'End If



        Return True

    End Function
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_ok.Click
        Try

            Me.Cursor = Cursors.WaitCursor

            If SalvarDados() Then
                Me.Cursor = Cursors.Arrow
                Me.Close()
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_apply.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            SalvarDados()

            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

End Class