Imports Ionic.Zip
Imports HtmlAgilityPack
Public Class form_down
    Private kmzFile As String = ""
    Public xmlFile As String = ""
    Private kmlFile As String = ""
    Private myWebClient As System.Net.WebClient
    Private cancelar As Boolean = False
    Public Sub DownloadProgress(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        Try

            If myWebClient.IsBusy And button_cancel.Visible = False Then
                button_cancel.Visible = True
            End If

            label_progresso.Text = String.Format(gettext("custom", 18), e.ProgressPercentage)
            pbar_down.Value = e.ProgressPercentage
        Catch ex As Exception

        End Try
    End Sub

    Private Function criaTabelaDados() As DataTable
        Dim dt As New DataTable

        dt.Columns.Add("processo")
        dt.Columns.Add("id")
        dt.Columns.Add("numero")
        dt.Columns.Add("ano")
        dt.Columns.Add("area")
        dt.Columns.Add("fase")
        dt.Columns.Add("evento")
        dt.Columns.Add("titular")
        dt.Columns.Add("substancia")
        dt.Columns.Add("uso")
        dt.Columns.Add("uf")
        dt.Columns.Add("link")
        dt.Columns.Add("codigo_fase")

        Return dt
    End Function
    Private Function converteHTMLParaDatarow(ByVal dt As DataTable, ByVal dtFase As DataTable, ByVal html As String) As DataRow


        Dim doc As HtmlDocument = New HtmlDocument
        doc.LoadHtml(html)

        Dim processo As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[3]/td[2]")(0).InnerText
        Dim id As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[4]/td[2]")(0).InnerText
        Dim numero As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[5]/td[2]")(0).InnerText
        Dim ano As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[6]/td[2]")(0).InnerText
        Dim area As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[7]/td[2]")(0).InnerText
        Dim fase As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[8]/td[2]")(0).InnerText
        Dim evento As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[9]/td[2]")(0).InnerText
        Dim titular As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[10]/td[2]")(0).InnerText
        Dim substancia As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[11]/td[2]")(0).InnerText
        Dim uso As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[12]/td[2]")(0).InnerText
        Dim uf As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[13]/td[2]")(0).InnerText
        Dim link As String = Replace(doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[3]/td[2]/a[1]/@href[1]")(0).Attributes(1).Value.ToString.Trim, "&#38;amp;", "&")

        Dim dr As DataRow = dt.NewRow

        dr("processo") = processo
        dr("id") = id
        dr("numero") = numero
        dr("ano") = ano
        dr("area") = area
        dr("fase") = fase
        dr("evento") = evento
        dr("titular") = titular
        dr("substancia") = substancia
        dr("uso") = uso
        dr("uf") = uf
        dr("link") = link
        dr("codigo_fase") = pega_codigo_fase(dtFase, fase)

        Return dr

    End Function
    Private Function pega_codigo_fase(ByVal dt As DataTable, ByVal descricao As String) As String

        If dt.Rows.Count > 0 Then

            If dt.Select("value like '%" & descricao & "%'").Length > 0 Then
                Return dt.Select("value like '%" & descricao & "%'")(0)("name")
            Else
                Return "0"
            End If

        Else
            Return "0"
        End If


    End Function
    Public Sub DownloadComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)


        Try


            If e.Error IsNot Nothing And Not e.Cancelled Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel

                'exclui arquivo kmz baixado
                If System.IO.File.Exists(kmlDir & "\" & kmzFile) Then
                    System.IO.File.Delete(kmlDir & "\" & kmzFile)
                End If

                ShowMessage(e.Error, 0)
                Me.Close()
                Exit Sub
            End If

            If e.Cancelled Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel

                'exclui arquivo kmz baixado
                If System.IO.File.Exists(kmlDir & "\" & kmzFile) Then
                    System.IO.File.Delete(kmlDir & "\" & kmzFile)
                End If


                Me.Close()
                Exit Sub
            End If


            'converte arquivo kmz em kml 
            Dim zipfile As Ionic.Zip.ZipFile = zipfile.Read(kmlDir & "\" & kmzFile)
            kmlFile = Replace(kmzFile, ".kmz", ".kml")
            zipfile.ExtractSelectedEntries("name = *.kml", "", kmlDir, ExtractExistingFileAction.OverwriteSilently)
            zipfile.Dispose()


            'renomeia arquivo kml (doc.kml) extraído para UF.kml
            If System.IO.File.Exists(kmlDir & "\" & kmlFile) Then System.IO.File.Delete(kmlDir & "\" & kmlFile)
            FileSystem.Rename(kmlDir & "\doc.kml", kmlDir & "\" & kmlFile)


            'exclui arquivo kmz baixado
            System.IO.File.Delete(kmlDir & "\" & kmzFile)


            'converte arquivo kml para arquivo xml no formato esperado
            Dim obj As New BLL.Rotina(xmlpath)
            Dim dt As DataTable = obj.KMLToDatatable(kmlDir & "\" & kmlFile, True)
            Dim dtNew As DataTable = criaTabelaDados()
            Dim drNew As DataRow
            Dim objFase As New Apoio.Globalization
            Dim dtFase As DataTable = objFase.getListData(xmlpath, "fase")
            Dim ds As New DataSet
            xmlFile = Replace(kmlFile, ".kml", ".xml")


            label_progresso.Text = gettext("custom", 17)
            pbar_down.Value = 0
            pbar_down.Minimum = 0
            pbar_down.Maximum = dt.Rows.Count - 1
            Application.DoEvents()
            Me.Refresh()


            For Each dr As DataRow In dt.Rows

                Application.DoEvents()

                If cancelar Then
                    pbar_down.Value = 0
                    pbar_down.Minimum = 0
                    pbar_down.Maximum = 0
                    cancelar = False
                    button_cancel.Visible = False
                    Me.Close()
                    Exit Sub
                End If

                If dr("description") IsNot DBNull.Value And dr("name").ToString.Trim <> "None" Then
                    drNew = converteHTMLParaDatarow(dtNew, dtFase, dr("description"))
                    dtNew.Rows.Add(drNew)
                End If

                Try
                    pbar_down.Value += 1
                Catch ex As Exception
                End Try


            Next

            dtNew.TableName = "DADOSDNPM"
            dtNew.WriteXml(kmlDir & "\" & xmlFile)


            'exclui arquivo kml baixado
            System.IO.File.Delete(kmlDir & "\" & kmlFile)

            Me.DialogResult = Windows.Forms.DialogResult.OK

            button_cancel.Visible = False

            Me.Close()

        Catch ex As Exception
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            ShowMessage(ex, 0)
            Me.Close()
        End Try


    End Sub
    'Private Sub CenterControlInParent(ByVal ctrlToCenter As Control)
    '    ctrlToCenter.Left = (Me.Width - ctrlToCenter.Width) / 2
    '    ctrlToCenter.Top = (Me.Height - ctrlToCenter.Height) / 2
    'End Sub
    Private Sub form_down_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            'CenterControlInParent(panel_main)

            Dim obj As New BLL.Rotina(xmlpath)
            Dim myKMLFile As String = ""
            Dim retDown As Boolean = False
            Dim dt As DataTable
            Dim dto As New DTO.tb_PGER_parametro_geral
            Dim bll As New BLL.tb_PGER_parametro_geral
            Dim url As String = ""
            Dim objglob As New Apoio.Globalization
            Dim dtUF As DataTable
            Dim uf As String = ""
            Dim uri As System.Uri

            cancelar = False

            myWebClient = New System.Net.WebClient
            AddHandler myWebClient.DownloadProgressChanged, AddressOf DownloadProgress
            AddHandler myWebClient.DownloadFileCompleted, AddressOf DownloadComplete

            pbar_down.Value = 0
            pbar_down.Minimum = 0
            pbar_down.Maximum = 100
            label_progresso.Text = gettext("custom", 16)

            'pega uf
            dtUF = objglob.getListData(xmlpath, "uf").Select("name <> '00'").CopyToDataTable
            If dtUF.Rows.Count > 0 Then
                uf = dtUF.Rows(0)("name")
            Else
                uf = "SP"
            End If



            'pega url nos parametros gerais
            bll.ConnectionString = connection
            bll.XMLPath = xmlpath
            dt = bll.GetData(dto)
            url = gettext("parm", 0)
            If dt.Rows.Count > 0 Then url = getParmValue(dt, "URL", url)




            'baixa arquivo
            Try
                kmzFile = uf & ".kmz"
                url = String.Format(url, uf)
                uri = New System.Uri(url)
                myWebClient.DownloadFileAsync(uri, kmlDir & "\" & kmzFile)
            Catch ex As Exception
                ShowMessage(ex, 0)
            End Try



        Catch ex As Exception
            label_progresso.Text = ""
            ShowMessage(ex, 0)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            button_cancel.Visible = False
            Me.Close()
        End Try
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
        Using brush As Brush = New SolidBrush(Color.FromArgb(65, Color.Black))
            e.Graphics.FillRectangle(brush, e.ClipRectangle)
        End Using
    End Sub
    Private Function getParmValue(ByVal dt As DataTable, ByVal id As String, ByVal default_value As String) As String
        Dim value As String = ""

        If dt.Rows.Count > 0 Then
            If dt.Select("PGER_cd_parametro = '" & id & "'").Length > 0 Then
                Return base.AjustaNulo(dt.Select("PGER_cd_parametro = '" & id & "'")(0)("PGER_vl_parametro"))
            Else
                Return default_value
            End If
        Else
            Return default_value
        End If

        Return value
    End Function


    Private Sub button_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_cancel.Click
        Try



            If myWebClient.IsBusy Then
                ' If MsgBox(gettext("custom", 10), MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then

                myWebClient.CancelAsync()
                'End If
            End If

            cancelar = True

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub


End Class