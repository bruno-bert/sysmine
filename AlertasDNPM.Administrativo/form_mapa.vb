Imports System.Reflection
Imports System.Xml
Imports GMap.NET
Imports System.Globalization
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports System.Drawing.Imaging
Imports HtmlAgilityPack
Imports Ionic.Zip

Public Class form_mapa

    Private kmzFile As String = ""
    Public xmlFile As String = ""
    Private kmlFile As String = ""
    Private myWebClient As System.Net.WebClient
    Private cancelar As Boolean = False


    Private initialZoom As Integer = 15
    Public processo As String = ""
    Private thr As Threading.Thread
    Private Delegate Sub loadingDelegate(ByVal flag As Boolean)
    Private Delegate Sub posDelegate(ByVal lpo As PointLatLng)
    Private Delegate Sub posDelegate2(ByVal lpo As List(Of PointLatLng))
    Private Delegate Sub providerDelegate(ByVal provider As GMapProvider)
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

    Public Sub DownloadComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)


        Try


            If e.Error IsNot Nothing And Not e.Cancelled Then
                'Me.DialogResult = Windows.Forms.DialogResult.Cancel

                'exclui arquivo kmz baixado
                If System.IO.File.Exists(kmlDirToMap & "\" & kmzFile) Then
                    System.IO.File.Delete(kmlDirToMap & "\" & kmzFile)
                End If

                panel_main.Visible = False
                ShowMessage(e.Error, 0)

                'Me.Close()
                Exit Sub
            End If

            If e.Cancelled Then
                'Me.DialogResult = Windows.Forms.DialogResult.Cancel

                'exclui arquivo kmz baixado
                If System.IO.File.Exists(kmlDirToMap & "\" & kmzFile) Then
                    System.IO.File.Delete(kmlDirToMap & "\" & kmzFile)
                End If

                panel_main.Visible = False
                ' Me.Close()
                Exit Sub
            End If


            'converte arquivo kmz em kml 
            Dim zipfile As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(kmlDirToMap & "\" & kmzFile)
            kmlFile = Replace(kmzFile, ".kmz", ".kml")
            zipfile.ExtractSelectedEntries("name = *.kml", "", kmlDirToMap, ExtractExistingFileAction.OverwriteSilently)
            zipfile.Dispose()


            'renomeia arquivo kml (doc.kml) extraído para UF.kml
            If System.IO.File.Exists(kmlDirToMap & "\" & kmlFile) Then System.IO.File.Delete(kmlDirToMap & "\" & kmlFile)
            FileSystem.Rename(kmlDirToMap & "\" & kmlFileToMap, kmlDirToMap & "\" & kmlFile)


            'exclui arquivo kmz baixado
            System.IO.File.Delete(kmlDirToMap & "\" & kmzFile)

            button_cancel.Visible = False
            panel_main.Visible = False

            If MessageBox.Show(gettext("custom", 42), gettext("title", 3), MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Timer2.Enabled = True
                Timer2.Start()
                loading(True)
            End If


        Catch ex As Exception
            panel_main.Visible = False
            ShowMessage(ex, 0)
        End Try


    End Sub
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

    Private Function PegaPontos(ByVal node As XmlNode, _
                                ByVal nsmgr As XmlNamespaceManager) As List(Of PointLatLng)


        'encontra placemark do processo
        Dim nodeCoord As XmlNode = node.SelectSingleNode(".//p:Polygon//p:outerBoundaryIs//p:LinearRing//p:coordinates", nsmgr)
        If nodeCoord Is Nothing Then Return Nothing
        Dim strCoordinates As String = nodeCoord.InnerText

        Dim delim As String = " "
        Dim vetCoord As String() = strCoordinates.Split(delim)
        Dim strLat As String = ""
        Dim strLon As String = ""
        Dim gpoints = New List(Of PointLatLng)()

        Dim j As Integer = 0
        For i As Integer = 0 To vetCoord.Count - 1
            If vetCoord(i).Contains(",") Then
                strLon = Split(vetCoord(i), ",")(0) 'strLon.ToString().Replace(",", ".")
                strLat = Split(vetCoord(i), ",")(1) 'strLat.ToString().Replace(",", ".")
                Dim lat = Double.Parse(strLat, CultureInfo.InvariantCulture)
                Dim lng = Double.Parse(strLon, CultureInfo.InvariantCulture)
                gpoints.Add(New PointLatLng(lat, lng))
            End If
        Next

        Return gpoints

    End Function
    Private Function centroid(ByVal points As List(Of PointLatLng)) As PointLatLng

        Dim count As Integer = points.Count
        Dim center As PointLatLng
        Dim sumLat As Double = 0
        Dim sumLng As Double = 0
        Dim lat As Double = 0
        Dim lng As Double = 0

        If count = 0 Then Return Nothing

        For Each Point As PointLatLng In points
            sumLat += Point.Lat
            sumLng += Point.Lng
        Next

        lat = sumLat / count
        lng = sumLng / count

        center = New PointLatLng(lat, lng)

        Return center
    End Function
    Public Function converteHTMLParaDatarow(ByVal html As String) As DataRow


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


        Dim dt As New DataTable

        dt.Columns.Add("Processo")
        dt.Columns.Add("ID")
        dt.Columns.Add("Número")
        dt.Columns.Add("Ano")
        dt.Columns.Add("Área")
        dt.Columns.Add("Fase")
        dt.Columns.Add("Último Evento")
        dt.Columns.Add("Titular")
        dt.Columns.Add("Substância")
        dt.Columns.Add("Uso")
        dt.Columns.Add("UF")
        ' dt.Columns.Add("Link")

        Dim dr As DataRow = dt.NewRow

        dr("processo") = processo
        dr("id") = id
        dr("Número") = numero
        dr("ano") = ano
        dr("área") = area
        dr("fase") = fase
        dr("último evento") = evento
        dr("titular") = titular
        dr("substância") = substancia
        dr("uso") = uso
        dr("uf") = uf
        ' dr("link") = link

        Return dr

    End Function
    Private Function getInfoFromHtml(ByVal html As String) As String

        Dim texto As String = ""
        Dim dr As DataRow = converteHTMLParaDatarow(html)

        For Each dc As DataColumn In dr.Table.Columns
            texto += dc.ColumnName & ": " & dr(dc) & vbCrLf & vbCrLf
        Next

        Return texto

    End Function
    Private Sub iniciaMapa()

        Try

            Dim i As Integer = 0
            Dim achou As Boolean = False

            'abre kml como xml
            Dim path As String = System.Configuration.ConfigurationManager.AppSettings("kmlDirToMap")
            Dim doc As XmlDocument = New XmlDocument
            doc.Load(path & "\SP.kml")
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("p", "http://www.opengis.net/kml/2.2")


            'encontra placemarks 
            Dim xpath As String = "//p:kml//p:Document//p:Placemark" '[p:name='" + processo + "']"
            Dim placeMarks As XmlNodeList = doc.SelectNodes(xpath, nsmgr)



            Dim overlay As GMapOverlay
            Dim lpo As List(Of PointLatLng)
            Dim curLpo As List(Of PointLatLng)
            Dim P As GMapPolygon
            Dim curProcesso As String = ""
            Dim html As String = ""
            Dim info As String = ""

            overlay = New GMapOverlay("Dados DNPM")

            SetProvider(GMapProviders.GoogleHybridMap)


            For Each placeMarkNode As XmlNode In placeMarks

                If i = 0 Then GoTo prox

                curProcesso = placeMarkNode.FirstChild.FirstChild.Value.ToString.Trim

                lpo = PegaPontos(placeMarkNode, nsmgr)


                If curProcesso = processo And Not achou Then


                    achou = True
                    curLpo = lpo

                    Dim nodeHtml As XmlNode = placeMarkNode.SelectSingleNode(".//p:description", nsmgr)
                    If nodeHtml IsNot Nothing Then html = nodeHtml.InnerText

                    Dim mark As GMapMarker = New GMap.NET.WindowsForms.Markers.GMarkerGoogle(centroid(lpo), Markers.GMarkerGoogleType.red_dot)
                    mark.ToolTipMode = MarkerTooltipMode.OnMouseOver
                    'Dim tooltip As New GMapToolTip()
                    'Dim tooltipFont As Font = New Font("tahoma", 8, FontStyle.Bold, GraphicsUnit.Point)
                    'tooltip.Foreground = Brushes.Black
                    'tooltip.Fill = Brushes.Beige
                    'tooltip.Font = tooltipFont
                    'tooltip.Stroke = Pens.Black
                    mark.ToolTip = New GMapToolTip(mark)
                    mark.IsVisible = True
                    mark.ToolTipText = getInfoFromHtml(html)
                    overlay.Markers.Add(mark)


                    If lpo IsNot Nothing Then
                        P = New GMapPolygon(lpo, curProcesso)
                        P.Stroke = New Pen(Color.FromArgb(50, Color.LightSkyBlue), 1)
                        P.Fill = New SolidBrush(Color.FromArgb(80, Color.Blue))
                        P.IsVisible = True
                        overlay.Polygons.Add(P)
                    End If


                Else
                    If lpo IsNot Nothing Then
                        P = New GMapPolygon(lpo, curProcesso)
                        P.Stroke = New Pen(Color.FromArgb(50, Color.Black), 1)
                        P.Fill = New SolidBrush(Color.FromArgb(90, Color.LightSkyBlue))
                        P.IsVisible = True
                        overlay.Polygons.Add(P)
                    End If
                End If



prox:
                i += 1
            Next

            overlay.IsVisibile = True

            mapa.Overlays.Add(overlay)

            mapa.PolygonsEnabled = True

            'If curLpo IsNot Nothing Then pos(curLpo(0))
            If curLpo IsNot Nothing Then pos2(curLpo)

            loading(False)

        Catch ex As Exception
            ShowMessage(ex, 0)
            loading(False)

        End Try

    End Sub
    Private Sub pos(ByVal lpo As PointLatLng)

        If Me.InvokeRequired Then
            Dim del As New posDelegate(AddressOf pos)
            Me.Invoke(del, lpo)
        Else
            Me.mapa.Position = lpo
        End If
    End Sub
    Private Sub pos2(ByVal lpo As List(Of PointLatLng))

        If Me.InvokeRequired Then
            Dim del As New posDelegate2(AddressOf pos2)
            Me.Invoke(del, lpo)
        Else
            Dim route As New GMapRoute(lpo, "placemark")
            mapa.ZoomAndCenterRoute(route)
            mapa.Zoom = initialZoom
            mapa.Visible = True
        End If
    End Sub
    Private Sub SetProvider(ByVal provider As GMapProvider)

        If Me.InvokeRequired Then
            Dim del As New providerDelegate(AddressOf SetProvider)
            Me.Invoke(del, provider)
        Else
            Me.mapa.MapProvider = provider
        End If
    End Sub
    Private Sub loading(ByVal flag As Boolean)

        If Me.InvokeRequired Then
            Dim del As New loadingDelegate(AddressOf loading)
            Me.Invoke(del, flag)
        Else
            ' mapa.MapProvider = GMap.NET.MapProviders.GMapProviders.EmptyProvider
            ' mapa.ReloadMap()
            panel_mapa.Visible = flag
        End If
    End Sub
    Private Sub cmdCarregarMapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If thr IsNot Nothing Then
                Try
                    thr.Abort()
                Catch ex As Exception

                End Try
            End If
            loading(True)
            thr = New System.Threading.Thread(AddressOf iniciaMapa)
            thr.Start()
        Catch ex As Exception
            ShowMessage(ex.Message, 0)
        End Try
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

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Timer2.Enabled = False
        Timer2.Stop()
        Me.Refresh()

        thr = New System.Threading.Thread(AddressOf iniciaMapa)
        thr.Start()

    End Sub

   

    'Private Sub form_mapa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    Try
    '        thr.Abort()
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub form_mapa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Me.Text = "Mapa - " & processo

            With mapa
                .Visible = False
                .MinZoom = 2
                .MaxZoom = 20
                .Zoom = initialZoom
                .Manager.Mode = AccessMode.ServerAndCache
                .DragButton = Windows.Forms.MouseButtons.Left
            End With

           
            panel_main.Visible = False



            Dim data As String = base.getFileDate(kmlDirToMap & "\SP.kml")

            If data.Trim.Length > 0 Then
                lblKML.Text = String.Format(gettext("custom", 22), data)
                Timer2.Enabled = True
                Timer2.Start()
                loading(True)
            Else
                lblKML.Text = gettext("custom", 20)
                If MessageBox.Show(gettext("custom", 41), gettext("title", 3), MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cmdKML_Click(New Object, Nothing)
                End If
            End If


        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub



    Private Sub cmdHibrido_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdHibrido.Click
        Try
            loading(True)
            SetProvider(GMapProviders.GoogleHybridMap)
            loading(False)
        Catch ex As Exception
            loading(False)
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub cmdMapa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdMapa.Click
        Try
            loading(True)
            SetProvider(GMapProviders.GoogleMap)
            loading(False)
        Catch ex As Exception
            loading(False)
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub cmdSatelite_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSatelite.Click
        Try
            loading(True)
            SetProvider(GMapProviders.GoogleSatelliteMap)
            loading(False)
        Catch ex As Exception
            loading(False)
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub cmdCopiarImagemMapa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCopiarImagemMapa.Click
        Try
            Const filter As String = "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|All files (*.*)|*.*"


            Using image As Bitmap = Me.mapa.ToImage
                Dim dialog As New SaveFileDialog()
                dialog.Filter = filter
                If dialog.ShowDialog() = DialogResult.OK Then
                    image.Save(dialog.FileName, ImageFormat.Jpeg)
                End If
            End Using


        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub



    Private Sub cmdKML_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdKML.Click
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

            panel_main.Visible = True
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
                myWebClient.DownloadFileAsync(uri, kmlDirToMap & "\" & kmzFile)
            Catch ex As Exception
                ShowMessage(ex, 0)
            End Try



        Catch ex As Exception
            panel_main.Visible = False
            label_progresso.Text = ""
            ShowMessage(ex, 0)
            'Me.DialogResult = Windows.Forms.DialogResult.Cancel
            button_cancel.Visible = False
            'Me.Close()
        End Try
    End Sub

   
End Class