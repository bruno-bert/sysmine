Imports System.Data
Imports System.IO
Imports System.Collections.Generic
Imports System.IO.Compression
Imports Microsoft
Imports System.Text
Imports Microsoft.Reporting.WinForms

Public Class clsReport
    Private ReportViewer1 As ReportViewer

    Private intPadrao As Integer = -1111111111
    Private strPadrao As String = Nothing
    Private datPadrao As DateTime = CDate("00:00:00")
    Private datNull As DateTime = CDate("00:00:01")
    Private chrPulaInha As String = "<br />"




    Public Enum ReportFormat
        PDF = 0
        Excel = 1
        Word = 2
    End Enum

    Public Enum ReportMode
        Preview = 0
        File = 1
    End Enum

    Public Enum ePageLayout
        Portrait = 0
        Landscape = 1
    End Enum

    Private pExportList() As String
    Private localparameters() As ReportParameter

    Private pOutputFormat As ReportFormat = 0
    Private pPrintMode As ReportMode = 0
    Private pPageLayout As ePageLayout = 0
    Private pIncludeDateTimeOnReportFileName As Boolean = True

    'Private pControlID As String = "btnReport"


    Private pTemporaryDirectory As String = "report/tmp"
    Private pReportID As String = "GenericReport"

    Public Event ReportError(ByVal message As String)
    Public Event ReportSucess()

    Public Property IncludeDateTimeOnReportFileName() As Boolean
        Get
            Return pIncludeDateTimeOnReportFileName
        End Get
        Set(ByVal value As Boolean)
            pIncludeDateTimeOnReportFileName = value
        End Set
    End Property

    Public Property ReportID() As String
        Get
            Return pReportID
        End Get
        Set(ByVal value As String)
            pReportID = value
        End Set
    End Property
    Public Property TemporaryDirectory() As String
        Get
            Return pTemporaryDirectory
        End Get
        Set(ByVal value As String)
            pTemporaryDirectory = value
        End Set
    End Property
    'Public Property ControlID() As String
    '    Get
    '        Return pControlID
    '    End Get
    '    Set(ByVal value As String)
    '        pControlID = value
    '        SavePropertyState("ControlID", pControlID)
    '    End Set
    'End Property
    Public Property OutputFormat() As ReportFormat
        Get
            Return pOutputFormat
        End Get
        Set(ByVal value As ReportFormat)
            pOutputFormat = value
        End Set
    End Property
    Public Property PrintMode() As ReportMode
        Get
            Return pOutputFormat
        End Get
        Set(ByVal value As ReportMode)
            pPrintMode = value
        End Set
    End Property
    Public Property PageLayout() As ePageLayout
        Get
            Return pPageLayout
        End Get
        Set(ByVal value As ePageLayout)
            pPageLayout = value
        End Set
    End Property

    Public Structure parameter
        Dim name As String
        Dim value As Object
    End Structure

    Public Sub AddParameters(ByVal parameters() As parameter)

        Dim i As Integer = 0

        For Each p As parameter In parameters
            ReDim Preserve localparameters(i)
            localparameters(i) = New ReportParameter
            localparameters(i).Name = p.name
            localparameters(i).Values.Add(p.value)
            i += 1
        Next

    End Sub
    Private Function CheckParameters() As String
        Dim Achou As Boolean = False
        Dim info As ReportParameterInfoCollection = ReportViewer1.LocalReport.GetParameters

        For Each myParm As ReportParameter In localparameters

            Achou = False

            For Each p As ReportParameterInfo In info
                If p.Name = myParm.Name Then
                    Achou = True
                    Exit For
                End If
            Next

            If Not Achou Then
                Return "Parâmetro " & Chr(34) & myParm.Name & Chr(34) & " não foi encontrado no relatório " & ReportViewer1.LocalReport.ReportPath
            End If

        Next

        Return ""
    End Function
    Public Function GenerateReport(ByVal Path As String, _
                                   ByVal ds As DataSet, _
                                   ByVal PrincipalTableName As String, _
                                   Optional ByVal SaveToFile As Boolean = False, _
                                   Optional ByRef CaminhoArquivo As String = "") As String

        Try
            Dim retStr As String = ""

            If PrincipalTableName.Trim.Length = 0 Then
                retStr = "informe o nome da Tabela Principal"
                ReportViewer1.Visible = False
                'pnlReport.Visible = False
                RaiseEvent ReportError(retStr)
                Return retStr
            End If

            If Not ds.Tables.Contains(PrincipalTableName) Then
                retStr = "Tabela " & PrincipalTableName & " não encontrada no dataset"
                ReportViewer1.Visible = False
                'pnlReport.Visible = False
                RaiseEvent ReportError(retStr)
                Return retStr
            End If

            Dim dtPrincipal As DataTable = ds.Tables(PrincipalTableName)

            If dtPrincipal.Rows.Count > 0 Then

                ReportViewer1.Reset()
                ReportViewer1.LocalReport.ReportPath = Path
                ReportViewer1.LocalReport.Refresh()
                ReportViewer1.LocalReport.EnableHyperlinks = True
                ReportViewer1.LocalReport.EnableExternalImages = True

                retStr = CheckParameters()
                If retStr <> "" Then
                    ReportViewer1.Visible = False
                    'pnlReport.Visible = False
                    RaiseEvent ReportError(retStr)
                    Return retStr
                End If


                ReportViewer1.LocalReport.SetParameters(localparameters)
                ReportViewer1.LocalReport.DataSources.Clear()

                For Each dt As DataTable In ds.Tables
                    ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Report_" & dt.TableName, dt))
                Next

                retStr = ShowReport(ReportViewer1, SaveToFile, CaminhoArquivo)

                If retStr = "" Then
                    retStr = "OK"
                    RaiseEvent ReportSucess()
                    Return retStr
                Else
                    'pnlReport.Visible = False
                    ReportViewer1.Visible = False
                    RaiseEvent ReportError(retStr)
                    Return retStr
                End If

            Else
                'pnlReport.Visible = False
                ReportViewer1.Visible = False
                retStr = "Não há dados para gerar o relatório"
                RaiseEvent ReportError(retStr)
                Return retStr

            End If

            Return ""

        Catch ex As Exception

            If ex.InnerException IsNot Nothing Then
                Return ex.InnerException.Message
            Else
                Return ex.Message
            End If

        End Try




    End Function
    Private Function ShowReport(ByVal rpt As ReportViewer, _
                                Optional ByVal SaveToFile As Boolean = False, _
                                Optional ByRef CaminhoArquivo As String = "") As String


        Try

            Dim retStr As String = ""

            Select Case pPrintMode
                Case ReportMode.Preview
                    'pnlReport.Visible = True
                    ReportViewer1.Visible = True
                    Return ""

                Case ReportMode.File
                    '  pnlReport.Visible = False
                    ReportViewer1.Visible = False

                    Dim FileName As String = CreateFileName()

                    Select Case SaveToFile
                        Case False
                            'retStr = ExportToFile(rpt, pOutputFormat, FileName)
                        Case True
                            'FileName = Server.MapPath(pTemporaryDirectory) & "\" & FileName
                            FileName = pTemporaryDirectory & "\" & FileName
                            CaminhoArquivo = FileName
                            retStr = SaveFile(rpt, pOutputFormat, FileName)
                    End Select


                    If retStr <> "" Then Return retStr

                    Return retStr



                    Return ""

            End Select
        Catch ex As Exception

        End Try


        Return ""
    End Function



    Private Function CreateFileName() As String
        Dim extension As String = ConvertExtension(pOutputFormat)
        Dim fileName As String = ""

        pReportID = Replace(pReportID, "\", "_")
        pReportID = Replace(pReportID, "/", "_")


        Select Case pIncludeDateTimeOnReportFileName
            Case True
                fileName = pReportID & "_" & Format(Now, "ddMMyyyy_HHmmss")
            Case False
                fileName = pReportID
        End Select

        Return fileName & "." & extension
    End Function
    Private Sub DeleteOldTempReportFiles(ByVal Dir As String)
        If Directory.Exists(Dir) Then
            For Each f As String In Directory.GetFiles(Dir)
                Try
                    File.Delete(f)
                Catch ex As Exception
                    'nao trata erro
                End Try
            Next

            Try
                'Directory.Delete(Dir)
            Catch ex As Exception
                'nao trata erro
            End Try

        End If



    End Sub






    Protected Sub Load()
        CustomizeControl()
    End Sub


    Private Sub CustomizeControl()
        '    pnlReport.Visible = False
    End Sub


    Private Function ConvertMimeType(ByVal FileFormat As ReportFormat) As String

        Select Case FileFormat
            Case ReportFormat.PDF
                Return "application/pdf"
            Case ReportFormat.Excel
                Return "application/excel"
            Case ReportFormat.Word
                Return "application/word"
        End Select

        Return "application/pdf"
    End Function
    Private Function ConvertFormat(ByVal FileFormat As ReportFormat) As String

        Select Case FileFormat
            Case ReportFormat.PDF
                Return "pdf"
            Case ReportFormat.Excel
                Return "excel"
            Case ReportFormat.Word
                Return "word"
        End Select

        Return "pdf"
    End Function





    Private Function ConvertExtension(ByVal FileFormat As ReportFormat) As String

        Select Case FileFormat
            Case ReportFormat.PDF
                Return "pdf"
            Case ReportFormat.Excel
                Return "xls"
            Case ReportFormat.Word
                Return "doc"
        End Select

        Return "pdf"
    End Function
    Private Function getDeviceInfo(ByVal format As String) As String
        Return Nothing


        'If pPageLayout = ePageLayout.Portrait Then
        'Return Nothing
        'Else
        Dim deviceInfo As New StringBuilder
        deviceInfo.Append("<DeviceInfo>")
        deviceInfo.Append(" <OutputFormat>" & format & "</OutputFormat>")
        deviceInfo.Append(" <PageWidth>22cm</PageWidth>")
        deviceInfo.Append(" <PageHeight>29.7cm</PageHeight>")
        deviceInfo.Append(" <MarginTop>0.5cm</MarginTop>")
        deviceInfo.Append(" <MarginLeft>0.5cm</MarginLeft>")
        deviceInfo.Append(" <MarginRight>0.5cm</MarginRight>")
        deviceInfo.Append(" <MarginBottom>0.5cm</MarginBottom>")
        deviceInfo.Append("</DeviceInfo>")
        Return deviceInfo.ToString
        ' End If


    End Function
    'Private Function ExportToFile(ByVal rpt As ReportViewer, _
    '                         ByVal FileFormat As ReportFormat, _
    '                         ByVal FileName As String) As String

    '    Try


    '        Dim warn() As Warning = Nothing
    '        Dim streamids() As String = Nothing
    '        Dim mimeType As String = ConvertMimeType(FileFormat)
    '        Dim format As String = ConvertFormat(FileFormat)
    '        Dim encoding As String = String.Empty
    '        Dim extension As String = String.Empty
    '        Dim byteViewer() As Byte
    '        Dim fs As FileStream
    '        Dim deviceinfo As String = getDeviceInfo(format)



    '        byteViewer = rpt.LocalReport.Render(format, deviceinfo, mimeType, encoding, extension, streamids, warn)
    '        HttpContext.Current.Response.Buffer = True
    '        HttpContext.Current.Response.Clear()
    '        HttpContext.Current.Response.ClearHeaders()

    '        HttpContext.Current.Response.ContentType = mimeType
    '        HttpContext.Current.Response.AddHeader("content-disposition", ("attachment; filename=" & FileName))
    '        HttpContext.Current.Response.BinaryWrite(byteViewer)
    '        HttpContext.Current.Response.Flush()
    '        HttpContext.Current.Response.End()

    '        Return ""
    '    Catch ex As Exception
    '        Return ex.Message
    '    End Try

    'End Function

   

    Private Function SaveFile(ByVal rpt As ReportViewer, _
ByVal FileFormat As ReportFormat, _
ByVal FileName As String) As String
        Try

            Dim warn() As Warning = Nothing
            Dim streamids() As String = Nothing
            Dim mimeType As String = ConvertMimeType(FileFormat)
            Dim format As String = ConvertFormat(FileFormat)
            Dim encoding As String = String.Empty
            Dim extension As String = String.Empty
            Dim byteViewer() As Byte
            Dim fs As FileStream
            Dim deviceinfo As String = getDeviceInfo(format)



            byteViewer = rpt.LocalReport.Render(format, deviceinfo, mimeType, encoding, extension, streamids, warn)
            fs = New FileStream(FileName, FileMode.Create)
            fs.Write(byteViewer, 0, byteViewer.Length)
            fs.Close()
            fs = Nothing
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function





    Public Sub New()
        ReportViewer1 = New ReportViewer
        ReportViewer1.ShowCredentialPrompts = False
        ReportViewer1.ShowDocumentMapButton = False
        ReportViewer1.ShowFindControls = False
        ReportViewer1.ShowParameterPrompts = False
        ReportViewer1.ShowPromptAreaButton = False
        ReportViewer1.ShowRefreshButton = False
        ReportViewer1.ShowZoomControl = False
        ReportViewer1.ShowPageNavigationControls = True
        ReportViewer1.ShowPrintButton = False
        ReportViewer1.Visible = False
        ReportViewer1.ShowExportButton  = True
        'ReportViewer1.SizeToReportContent = True
        'ReportViewer1.AsyncRendering = False
    End Sub
End Class
