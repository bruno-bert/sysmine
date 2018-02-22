Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports GMap.NET
Imports GMap.NET.Projections
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports System.Drawing.Drawing2D


Public Class ImageMap
    'bearing is 0 = north, 180 = south, 90 = east, 270 = west
    Public Function bpot_getDueCoords(ByVal latitude As Double, _
                                      ByVal longitude As Double, _
                                      ByVal bearing As Integer, _
                                      ByVal distance As Double, _
                                      Optional ByVal distance_unit As String = "km") As PointLatLng


        Dim coord As PointLatLng
        Dim radius As Double = 0
        Dim new_latitude As Double = 0
        Dim new_longitude As Double = 0

        If distance_unit = "m" Then
            'Distance is in miles.
            radius = 3963.1676
        Else
            ' distance is in km.
            radius = 6378.1
        End If


        '	New latitude in degrees.
        new_latitude = rad2deg(Math.Asin(Math.Sin(deg2rad(latitude)) * Math.Cos(distance / radius) + Math.Cos(deg2rad(latitude)) * Math.Sin(distance / radius) * Math.Cos(deg2rad(bearing))))

        '	New longitude in degrees.
        new_longitude = rad2deg(deg2rad(longitude) + Math.Atan2(Math.Sin(deg2rad(bearing)) * Math.Sin(distance / radius) * Math.Cos(deg2rad(latitude)), Math.Cos(distance / radius) - Math.Sin(deg2rad(latitude)) * Math.Sin(deg2rad(new_latitude))))

        coord = New PointLatLng(new_latitude, new_longitude)
       
        Return coord

    End Function
    Private Function deg2rad(ByVal deg As Double) As Double
        Return (deg * Math.PI / 180.0)
    End Function
    Private Function rad2deg(ByVal rad As Double) As Double
        Return rad / Math.PI * 180.0
    End Function

    Public Function GetRectOfPolygon(ByVal poly As GMapPolygon) As System.Nullable(Of RectLatLng)
        Dim ret As System.Nullable(Of RectLatLng) = Nothing

        Dim left As Double = Double.MaxValue
        Dim top As Double = Double.MinValue
        Dim right As Double = Double.MinValue
        Dim bottom As Double = Double.MaxValue

        If poly.IsVisible AndAlso poly.From.HasValue AndAlso poly.[To].HasValue Then 'AndAlso poly.Name.Equals(polygonName) Then

            For Each p As PointLatLng In poly.Points
                ' left
                If p.Lng < left Then
                    left = p.Lng
                End If

                ' top
                If p.Lat > top Then
                    top = p.Lat
                End If

                ' right
                If p.Lng > right Then
                    right = p.Lng
                End If

                ' bottom
                If p.Lat < bottom Then
                    bottom = p.Lat
                End If
            Next
        End If


        If left <> Double.MaxValue AndAlso right <> Double.MinValue AndAlso top <> Double.MinValue AndAlso bottom <> Double.MaxValue Then
            ret = RectLatLng.FromLTRB(left, top, right, bottom)
        End If

        Return ret
    End Function

    Public Function GetRectOfPPoints(ByVal lPoints As List(Of PointLatLng)) As System.Nullable(Of RectLatLng)
        Dim ret As System.Nullable(Of RectLatLng) = Nothing

        Dim left As Double = Double.MaxValue
        Dim top As Double = Double.MinValue
        Dim right As Double = Double.MinValue
        Dim bottom As Double = Double.MaxValue


        For Each p As PointLatLng In lPoints
            ' left
            If p.Lng < left Then
                left = p.Lng
            End If

            ' top
            If p.Lat > top Then
                top = p.Lat
            End If

            ' right
            If p.Lng > right Then
                right = p.Lng
            End If

            ' bottom
            If p.Lat < bottom Then
                bottom = p.Lat
            End If
        Next
      

        If left <> Double.MaxValue AndAlso right <> Double.MinValue AndAlso top <> Double.MinValue AndAlso bottom <> Double.MaxValue Then
            ret = RectLatLng.FromLTRB(left, top, right, bottom)
        End If

        Return ret
    End Function

    Private Function FindCentroid(ByVal points As List(Of PointLatLng)) As PointLatLng

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
    Private Function CalculaDistancia(ByVal ponto1 As PointLatLng, ByVal ponto2 As PointLatLng) As Double

        Dim x1 As Double = ponto1.Lat
        Dim x2 As Double = ponto2.Lat
        Dim y1 As Double = ponto1.Lng
        Dim y2 As Double = ponto2.Lng
        Dim s1 As Double = (x2 - x1)
        Dim s2 As Double = (y2 - y1)
        Dim p1 As Double = s1 * s1
        Dim p2 As Double = s2 * s2
        Dim r1 As Double = p1 + p2
        Dim r2 As Double = Math.Sqrt(r1)
        Dim a1 As Double = 40030000 * r2
        Dim a2 As Double = a1 / 360

        Return a2
    End Function
    Public Function CreateImage(ByVal fileName As String, _
                                ByVal lpo As List(Of PointLatLng)) As String

        GMaps.Instance.UseMemoryCache = False
        GMaps.Instance.Mode = AccessMode.ServerAndCache
        GMapProvider.TileImageProxy = WindowsFormsImageProxy.Instance
        Dim provider As GMapProvider = GMapProviders.GoogleHybridMap
        provider.OnInitialized()


        Dim zoom As Integer = 15


        Dim centroid As PointLatLng = FindCentroid(lpo)
        Dim lat = centroid.Lat
        Dim lng = centroid.Lng
        Dim d As Double = 2

        Dim path_top_right As PointLatLng = bpot_getDueCoords(lat, lng, 45, d) 'norte lat
        Dim path_bottom_right As PointLatLng = bpot_getDueCoords(lat, lng, 135, d) 'leste lng
        Dim path_bottom_left As PointLatLng = bpot_getDueCoords(lat, lng, 225, d) 'sul lat
        Dim path_top_left As PointLatLng = bpot_getDueCoords(lat, lng, 315, d) 'oeste lng

        Dim d1 As Double = CalculaDistancia(path_top_right, path_bottom_left)

        If d1 <= 4170 Then
            d = 5
            path_top_right = bpot_getDueCoords(lat, lng, 45, d) 'norte lat
            path_bottom_right = bpot_getDueCoords(lat, lng, 135, d) 'leste lng
            path_bottom_left = bpot_getDueCoords(lat, lng, 225, d) 'sul lat
            path_top_left = bpot_getDueCoords(lat, lng, 315, d) 'oeste lng
        End If

        Dim listPoints As New List(Of PointLatLng)
        listPoints.Add(path_top_right)
        listPoints.Add(path_bottom_right)
        listPoints.Add(path_bottom_left)
        listPoints.Add(path_top_left)

        Dim area As RectLatLng = GetRectOfPPoints(listPoints)

        If Not area.IsEmpty Then
            Try
                Dim tileArea As List(Of GPoint) = provider.Projection.GetAreaTileList(area, zoom, 0)
                Dim bigImage As String = fileName


                ' current area
                Dim topLeftPx As GPoint = provider.Projection.FromLatLngToPixel(area.LocationTopLeft, zoom)
                Dim rightButtomPx As GPoint = provider.Projection.FromLatLngToPixel(area.Bottom, area.Right, zoom)
                Dim pxDelta As New GPoint(rightButtomPx.X - topLeftPx.X, rightButtomPx.Y - topLeftPx.Y)

                Dim padding As Integer = 22
                If True Then
                    Using bmpDestination As New Bitmap(CInt(pxDelta.X + padding * 2), CInt(pxDelta.Y + padding * 2))
                        Using gfx As Graphics = Graphics.FromImage(bmpDestination)
                            gfx.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver
                            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic
                            gfx.SmoothingMode = SmoothingMode.HighQuality

                            ' get tiles & combine into one
                            For Each p As GPoint In tileArea  'tileArea

                                For Each tp As GMapProvider In provider.Overlays
                                    Dim ex As Exception
                                    Dim tile As WindowsFormsImage = TryCast(GMaps.Instance.GetImageFrom(tp, p, zoom, ex), WindowsFormsImage)
                                    If tile IsNot Nothing Then
                                        Using tile
                                            Dim x As Long = p.X * provider.Projection.TileSize.Width - topLeftPx.X + padding
                                            Dim y As Long = p.Y * provider.Projection.TileSize.Width - topLeftPx.Y + padding
                                            If True Then
                                                gfx.DrawImage(tile.Img, x, y, provider.Projection.TileSize.Width, provider.Projection.TileSize.Height)
                                            End If
                                        End Using
                                    End If
                                Next


                            Next



                            'desenha polígono
                            Using rp As New GraphicsPath()
                                For i As Integer = 0 To lpo.Count - 1
                                    Dim pr As PointLatLng = lpo(i)
                                    Dim px As GPoint = provider.Projection.FromLatLngToPixel(pr.Lat, pr.Lng, zoom)
                                    px.Offset(padding, padding)
                                    px.Offset(-topLeftPx.X, -topLeftPx.Y)
                                    Dim p2 As GPoint = px

                                    If i = 0 Then
                                        rp.AddLine(p2.X, p2.Y, p2.X, p2.Y)
                                    Else
                                        Dim p As System.Drawing.PointF = rp.GetLastPoint()
                                        rp.AddLine(p.X, p.Y, p2.X, p2.Y)
                                    End If
                                Next

                                If rp.PointCount > 0 Then
                                    rp.CloseFigure()
                                    gfx.FillPath(New SolidBrush(Color.FromArgb(80, Color.Blue)), rp)
                                    gfx.DrawPath(New Pen(Color.FromArgb(50, Color.LightSkyBlue), 1), rp)
                                End If

                            End Using

                            'desenha marker
                            'Dim mark As GMapMarker = New GMap.NET.WindowsForms.Markers.GMarkerGoogle(centroid, Markers.GMarkerGoogleType.red_dot)
                            'Dim pr1 = mark.Position
                            'Dim px1 As GPoint = provider.Projection.FromLatLngToPixel(pr1.Lat, pr1.Lng, zoom)
                            'px1.Offset(padding, padding)
                            'px1.Offset(-topLeftPx.X, -topLeftPx.Y)
                            'px1.Offset(mark.Offset.X, mark.Offset.Y)
                            'mark.LocalPosition = New System.Drawing.Point(CInt(px1.X), CInt(px1.Y))
                            'mark.OnRender(gfx)

                            bmpDestination.Save(bigImage, System.Drawing.Imaging.ImageFormat.Png)
                        End Using
                    End Using
                End If

                ' ok, lets see what we get
                If True Then Return ""

            Catch ex As Exception
                Return ex.Message
            End Try
        End If

        Return ""
    End Function
End Class
