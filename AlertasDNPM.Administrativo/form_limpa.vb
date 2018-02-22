Imports BrightIdeasSoftware
Public Class form_limpa

    Private mode As Integer = 0
    Private Sub ChangeFilterMenuLanguage()
        Dim obj As New Apoio.Globalization
        FilterMenuBuilder.CLEAR_ALL_FILTERS_LABEL = obj.getListValue(dtMensagem, "CLEAR_ALL_FILTERS_LABEL", "filter")
        FilterMenuBuilder.APPLY_LABEL = obj.getListValue(dtMensagem, "APPLY_LABEL", "filter")
        FilterMenuBuilder.FILTERING_LABEL = obj.getListValue(dtMensagem, "FILTERING_LABEL", "filter")
    End Sub
    Private Sub list_dados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_dados.KeyDown
        modoDelDado(sender, e)
    End Sub
    Private Sub ListaDados()

        Dim dal As New Apoio.DALBase(connection)
        Dim sql As String = ""
        Dim dto As New DTO.tb_TABE_tabela
        Dim bll As New BLL.tb_TABE_tabela
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath


        If combo_tabela.Text.Trim.Length > 0 And combo_tabela.SelectedIndex <> -1 Then

            dto.TABE_ds_tabela = combo_tabela.Text.Trim
            dt = bll.GetData(dto)

            sql = dt.Rows(0)("TABE_ds_selectall").ToString.Trim

            If sql.Trim.Length > 0 Then
                dt = dal.SelectDataTable(sql)
                list_dados.DataSource = New BindingSource(dt, dt.TableName)
            Else
                list_dados.Items.Clear()
            End If


        Else
            list_dados.Items.Clear()
        End If




    End Sub
    Private Sub modoDelDado(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirDadosSelecionados(log, sender)
                    ListaDados()

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub
    Private Function ExcluirDado(ByVal sql As String) As Boolean
        Try
            Dim dal As New Apoio.DALBase(connection)
            Dim ret As Integer = 0
            ret = dal.ExecuteSql(sql)
            Return ret > 0
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub ExcluirDadosSelecionados(ByRef log As String, ByVal sender As Object)
        Dim count As Integer = 0
        Dim erro As Boolean = False
        Dim sql As String = ""
        Dim sqlCheck As String = ""
        Dim vsqlCheck() As String
        Dim dt As DataTable
        Dim dal As New Apoio.DALBase(connection)
        Dim ref As Boolean = False

        Dim dto As New DTO.tb_TABE_tabela
        Dim bll As New BLL.tb_TABE_tabela
        Dim dt1 As DataTable
        Dim sqlDin As String = ""
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.TABE_ds_tabela = combo_tabela.Text.Trim
        dt1 = bll.GetData(dto)
        sql = dt1.Rows(0)("TABE_ds_deleleone").ToString.Trim
        vsqlCheck = Split(dt1.Rows(0)("TABE_ds_selectcheck").ToString.Trim, "|")

        For Each item As OLVListItem In sender.SelectedItems

            Dim myItem As String = item.Text.Trim
            sqlDin = sql
            sqlDin = String.Format(sqlDin, "'" & myItem & "'")
            ref = False

        
            For Each sqlCheck In vsqlCheck
                If sqlCheck.Trim.Length > 0 Then

                    sqlCheck = String.Format(sqlCheck, "'" & myItem & "'")

                    dt = dal.SelectDataTable(sqlCheck)
                    If dt.Rows.Count > 0 Then

                        ref = True
                        If Not log.Contains(myItem) Then
                            If log.Trim.Length = 0 Then log += vbCrLf
                            log += myItem
                            count += 1
                        End If

                    End If
                End If
            Next



            If Not ref Then
                If Not ExcluirDado(sqlDin) Then
                    If log.Trim.Length = 0 Then log += vbCrLf
                    log += myItem
                    count += 1
                End If
            End If

        Next


        If log.Trim.Length > 0 Then
            log = gettext("custom", 38) & vbCrLf & log
        End If


    End Sub
    Private Sub CarregaCombos()

        Dim dt As DataTable
        Dim bll As New BLL.tb_TABE_tabela
        Dim dto As New DTO.tb_TABE_tabela

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)

        dt = dt.Select("", "TABE_ds_tabela ASC").CopyToDataTable

        combo_tabela.Items.Clear()

        For Each dr As DataRow In dt.Rows
            combo_tabela.Items.Add(base.AjustaNulo(dr("TABE_ds_tabela")))
        Next

        combo_tabela.SelectedIndex = 0

    End Sub
    Private Sub form_limpa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Try
                MakeFormGlobal(Me)
            Catch ex As Exception
                ShowMessage(ex, 0)
            End Try


            ChangeFilterMenuLanguage()


            CarregaCombos()
         
            If list_dados.Items.Count > 0 Then
                list_dados.SelectedIndex = 0
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub


    


    


   

    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
   
   

    Private Sub combo_tabela_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_tabela.SelectedIndexChanged
        Try

            ListaDados()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
End Class