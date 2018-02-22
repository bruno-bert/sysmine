Imports BrightIdeasSoftware
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Xml
Imports GMap.NET
Imports System.Globalization

Public Class form_lista_evento

    Private mode As Integer = 0
    Private loaded As Boolean = False
  
    Private Sub ChangeFilterMenuLanguage()
        Dim obj As New Apoio.Globalization
        FilterMenuBuilder.CLEAR_ALL_FILTERS_LABEL = obj.getListValue(dtMensagem, "CLEAR_ALL_FILTERS_LABEL", "filter")
        FilterMenuBuilder.APPLY_LABEL = obj.getListValue(dtMensagem, "APPLY_LABEL", "filter")
        FilterMenuBuilder.FILTERING_LABEL = obj.getListValue(dtMensagem, "FILTERING_LABEL", "filter")
    End Sub


    Public Sub ListaEventos()

        'Dim dto As New DTO.tb_PROC_processo
        'Dim bll As New BLL.tb_PROC_processo
        Dim dt As DataTable

        'bll.ConnectionString = connection
        'bll.XMLPath = xmlpath

        'dt = bll.getEventos(dto)

        Dim ds As New DataSet
        Try


            ds.ReadXml(kmlDir & "\SP.xml")
            If ds.Tables.Count > 0 Then
                dt = ds.Tables(0)
                'dt.TableName = ""
                list_evento.DataSource = New BindingSource(dt, "")
            Else
                ShowMessage("Ocorreu um problema ao tentar ler arquivo KML", "", enErrorType.Warning)
            End If

        Catch ex As Exception
            ShowMessage(ex.Message, 0)
        End Try




    End Sub


    Private Sub form_grid_processo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MakeFormGlobal(Me)

            ChangeFilterMenuLanguage()


            ListaEventos()

            If list_evento.Items.Count > 0 Then
                list_evento.SelectedIndex = 0
            End If

            'panel_height = expanel_lista.Height
            loaded = True

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
   

    Private Sub text_filter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_filter.TextChanged
        Me.TimedFilter(Me.list_evento, text_filter.Text.Trim)
    End Sub

    Private Sub TimedFilter(ByVal olv As DataListView, ByVal txt As String)
        Me.TimedFilter(olv, txt, 0)
    End Sub
    Private Sub TimedFilter(ByVal olv As ObjectListView, ByVal txt As String, ByVal matchKind As Integer)
        Dim filter As TextMatchFilter = Nothing

        If Not [String].IsNullOrEmpty(txt) Then

            If matchKind < 0 Or matchKind > 2 Then matchKind = 0

            Select Case matchKind
                Case 0
                    filter = TextMatchFilter.Contains(olv, txt)
                    Exit Select
                Case 1
                    filter = TextMatchFilter.Prefix(olv, txt)
                    Exit Select
                Case 2
                    filter = TextMatchFilter.Regex(olv, txt)
                    Exit Select
            End Select
        End If


        ' Setup a default renderer to draw the filter matches
        If filter Is Nothing Then
            olv.DefaultRenderer = Nothing
        Else

            ' Uncomment this line to see how the GDI+ rendering looks
            'olv.DefaultRenderer = new HighlightTextRenderer { Filter = filter, UseGdiTextRendering = false };
            olv.DefaultRenderer = New HighlightTextRenderer(filter)
        End If

        ' Some lists have renderers already installed
        Dim highlightingRenderer As HighlightTextRenderer = TryCast(olv.GetColumn(0).Renderer, HighlightTextRenderer)
        If highlightingRenderer IsNot Nothing Then
            highlightingRenderer.Filter = filter
        End If

        Dim stopWatch As New Stopwatch()
        stopWatch.Start()
        olv.AdditionalFilter = filter
        'olv.Invalidate();
        stopWatch.[Stop]()

        'Dim objects As IList = TryCast(olv.Objects, IList)
        'If objects Is Nothing Then
        '    Me.toolStripStatusLabel1.Text = [String].Format("Filtered in {0}ms", stopWatch.ElapsedMilliseconds)
        'Else
        '    Me.toolStripStatusLabel1.Text = [String].Format("Filtered {0} items down to {1} items in {2}ms", objects.Count, olv.Items.Count, stopWatch.ElapsedMilliseconds)
        'End If
    End Sub




    Private Sub button_clear_filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_clear_filter.Click
        Try

            text_filter.Text = ""

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub center_form(ByVal frm As Form)
        Application.DoEvents()
        frm.Location = New Point(Me.Width / 2 - frm.Width / 2, (Me.Height) / 2 - frm.Height / 2)
    End Sub

    
    


    







End Class