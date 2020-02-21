Imports System.Collections.Generic
Imports System.Device.Location
Imports System.IO
Imports System.Runtime.InteropServices
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Globalization


Public Class Form1
    Dim n = 0
    Dim objShell = CreateObject("Shell.Application")
    Dim mtyp As String = "d"
    Public msty As String = "h"
    Dim zm As Integer = 1
    Dim IsMouseDown As Boolean
    Dim startPoint
    Dim delta As Double = 75
    Dim colorSystemAccent As UInteger = GetImmersiveColorFromColorSetEx(GetImmersiveUserColorSetPreference(False, False), GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveSystemAccent")), False, 0)
    Public colorAccent As System.Drawing.Color = System.Drawing.Color.FromArgb((&HFF000000 And colorSystemAccent) >> 24, &HFF And colorSystemAccent, (&HFF00 And colorSystemAccent) >> 8, (&HFF0000 And colorSystemAccent) >> 16)
    Dim strPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#95")>
    Public Shared Function GetImmersiveColorFromColorSetEx(ByVal dwImmersiveColorSet As UInteger, ByVal dwImmersiveColorType As UInteger, ByVal bIgnoreHighContrast As Boolean, ByVal dwHighContrastCacheMode As UInteger) As UInteger
    End Function
    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#96")>
    Public Shared Function GetImmersiveColorTypeFromName(ByVal pName As IntPtr) As UInteger
    End Function
    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#98")>
    Public Shared Function GetImmersiveUserColorSetPreference(ByVal bForceCheckRegistry As Boolean, ByVal bSkipCheckOnFail As Boolean) As UInteger
    End Function

    Dim txtlat As String = "0"
    Dim txtlong As String = "0"
    Private Watcher As GeoCoordinateWatcher = Nothing
    Dim inactivecolor As Color
    Public darkness As Double = 1 - ((0.299 * Int(colorAccent.R)) + (0.587 * Int(colorAccent.G)) + (0.114 * Int(colorAccent.B)))
    Dim d2 As Double = 0
    Private Sub TitleBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Titlebar.MouseUp
        IsMouseDown = False
    End Sub

    Private Sub TitleBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Titlebar.MouseMove
        If IsMouseDown Then
            Dim p1 = New Point(e.X, e.Y)
            Dim p2 = PointToScreen(p1)
            Dim p3 = New Point(p2.X - startPoint.X, p2.Y - startPoint.Y)
            Location = p3
            Opacity = 0.95
        End If
    End Sub

    Private Sub TitleBar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Titlebar.MouseDown
        If e.Button = MouseButtons.Left Then
            Titlebar.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navigate(0, 0, mtyp, msty, zm)
        ToolStripTextBox1.BackColor = colorAccent
        ' N2Loc("new delhi", mtyp, msty, 17)
        If darkness <= 0.5 Then
            Titlebar.ForeColor = Color.White
            ToolStripTextBox1.ForeColor = Color.White
        End If
        Titlebar.BackColor = colorAccent
        Dim readValue = "#" + Hex(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM", "AccentColorInactive", Nothing)).ToString
        inactivecolor = ColorTranslator.FromHtml(readValue)
        d2 = 1 - ((0.299 * Int(inactivecolor.R)) + (0.587 * Int(inactivecolor.G)) + (0.114 * Int(inactivecolor.B)))
        roundthethingy(Nav)
        For Each c As Control In Nav.Controls
            roundthethingy(c)
        Next
    End Sub

    Public Sub roundthethingy(oj As Object)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddEllipse(0, 0, oj.width, oj.width)
        p.CloseFigure()
        oj.Region = New Region(p)
    End Sub

    Private Sub Watcher_StatusChanged(ByVal sender As Object, ByVal e As GeoPositionStatusChangedEventArgs)
        n += 1
        If e.Status = GeoPositionStatus.Ready Then
            If Watcher.Position.Location.IsUnknown Then
                txtlat = "Cannot find location data"
            Else
                txtlat = Watcher.Position.Location.Latitude.ToString() '.Substring(0, 7)
                txtlong = Watcher.Position.Location.Longitude.ToString() '.Substring(0, 7)
            End If
        End If
        If n < 10 Then
            If txtlat <> "Cannot find location data" And Math.Abs(Val(txtlat)) > 0.0000001 Then
                Watcher.Stop()
                zm = 17
                Navigate(txtlat, txtlong, mtyp, msty, zm)
            End If
        Else
            Watcher.Stop()
            MessageBox.Show("Cannot find location data. Please check if location is on and the app ahs permission to access it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub LocateMe()
        n = 0
        Watcher = New GeoCoordinateWatcher()
        AddHandler Watcher.StatusChanged, AddressOf Watcher_StatusChanged
        Watcher.Start()
    End Sub

    Private Sub Navigate(lati As String, longi As String, maptype As String, mapstyle As String, zoom As Integer)
        wb.Navigate("https://www.bing.com/maps/embed?h=" & (wb.Height + 28).ToString & "&w=" & (wb.Width + 300).ToString & "&cp=" & lati & "~" & longi & "&lvl=" & zoom.ToString & "&typ=" & maptype & "&sty=" & mapstyle & "&src=SHELL&FORM=MBEDV8")

    End Sub

    ' Private Sub N2Loc(locn As String, maptype As String, mapstyle As String, zoom As Integer)
    '     'locn = locn.Replace(" ", "%20")
    '     wb.Navigate("https://www.bing.com/maps?v=2&where1=" & locn & "&h=" & (wb.Height + 28).ToString & "&w=" & (wb.Width + 300).ToString & "&lvl=" & zoom.ToString & "&typ=" & maptype & "&sty=" & mapstyle & "&src=SHELL&FORM=MBEDV8")
    ' End Sub

    Private Sub wb_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        ' MsgBox(wb.Document.Body.Children.GetElementsByName("container").Item(1).GetElementsByTagName("<div>").GetElementsByName("mapContainer").GetElementsByName("MicrosoftMap").Item(1).InnerHtml)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Watcher = New GeoCoordinateWatcher()
        AddHandler Watcher.StatusChanged, AddressOf Watcher_StatusChanged
        Watcher.Start()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Controls.Contains(h) Then
            Controls.Remove(h)
        End If
        If mtyp <> "d" Then
            Using bitmap As Bitmap = New Bitmap(wb.Width, wb.Height)
                Dim bounds As Rectangle = New Rectangle(New Point(0, 0), wb.Size)
                wb.DrawToBitmap(bitmap, bounds)
                bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\IMG_" + Now.Day.ToString + Now.Hour.ToString + Now.Minute.ToString + Now.Date.Day.ToString + Now.Millisecond.ToString + ".png")
            End Using
        Else

            TakeScreenShot().Save(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\IMG_" + Now.Day.ToString + Now.Hour.ToString + Now.Minute.ToString + Now.Date.Day.ToString + Now.Millisecond.ToString + ".png")
        End If
    End Sub
    Private Function TakeScreenShot() As Bitmap
        Dim tmpImg As New Bitmap(Width, Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(PointToScreen(New Point(0, 43)), New Point(0, 43), New Size(Width - 20, Height - 83))
        End Using
        Return tmpImg
    End Function
    Private Sub StaticMapFasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaticMapFasterToolStripMenuItem.Click
        If sender.checked = True Then
            mtyp = "s"
            Navigate(txtlat, txtlong, mtyp, msty, zm)
            ZmIn.Visible = True
            ZmOu.Visible = True
            lbe.Text = "Use provided navigation buttons to move map and to zoom"
            Nav.Visible = True
        Else
            mtyp = "d"
            Navigate(txtlat, txtlong, mtyp, msty, zm)
            ZmIn.Visible = False
            ZmOu.Visible = False
            lbe.Text = "Drag to move map, Scroll to zoom"
            Nav.Visible = False
        End If
    End Sub

    Private Sub SatelliteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatelliteToolStripMenuItem.Click
        If sender.checked = False Then
            If h.Button3.Text = chk Then
                msty = "h"
                Navigate(txtlat, txtlong, mtyp, msty, zm)
            Else
                msty = "a"
                Navigate(txtlat, txtlong, mtyp, msty, zm)
            End If
        End If
    End Sub

    Private Sub RoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoadToolStripMenuItem.Click
        If sender.checked = False Then
            msty = "r"
            h.Button3.Text = chk
            Navigate(txtlat, txtlong, mtyp, msty, zm)
        End If
    End Sub
    Dim chk As String = "", uchk As String = ""

    'maptype = d - draggable    mapstyle = r - road with labels    mapstyle = a - aerial no labels
    'maptype = s - static       mapstyle = h - aerial with labels

    Private Sub TrafficToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrafficToolStripMenuItem.Click
        If msty = "h" Then
            h.Button3.Text = uchk
            msty = "a"
            Navigate(txtlat, txtlong, mtyp, msty, zm)
        ElseIf msty = "r" Then
            h.Button3.Text = chk
        ElseIf msty = "a" Then
            h.Button3.Text = chk
            msty = "h"
            Navigate(txtlat, txtlong, mtyp, msty, zm)
        End If
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        If sender.text = "Search" Then
            sender.text = ""
        End If
    End Sub
    Private Sub GoToCoordinatesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ZmIn_Click(sender As Object, e As EventArgs) Handles ZmIn.Click
        If zm < 20 Then
            zm += 1
            Navigate(txtlat, txtlong, mtyp, msty, zm)
            CalculateDelta()
        End If
    End Sub

    Private Sub ZmOu_Click(sender As Object, e As EventArgs) Handles ZmOu.Click
        If zm > 1 Then
            zm -= 1
            Navigate(txtlat, txtlong, mtyp, msty, zm)
            CalculateDelta()
        End If
    End Sub

    Private Sub CalculateDelta()
        delta = 75
        For i = 1 To zm - 1
            delta = delta / 2
        Next
    End Sub

    Private Sub KUP_Click(sender As Object, e As EventArgs) Handles KUP.Click
        txtlat = (Val(txtlat) + delta).ToString
        Navigate(txtlat, txtlong, mtyp, msty, zm)
    End Sub

    Private Sub KRT_Click(sender As Object, e As EventArgs) Handles KRT.Click
        txtlong = (Val(txtlong) + delta).ToString
        Navigate(txtlat, txtlong, mtyp, msty, zm)
    End Sub

    Private Sub KDN_Click(sender As Object, e As EventArgs) Handles KDN.Click
        txtlat = (Val(txtlat) - delta).ToString
        Navigate(txtlat, txtlong, mtyp, msty, zm)
    End Sub

    Private Sub KLT_Click(sender As Object, e As EventArgs) Handles KLT.Click
        txtlong = (Val(txtlong) - delta).ToString
        Navigate(txtlat, txtlong, mtyp, msty, zm)
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Titlebar.BackColor = inactivecolor
        ToolStripTextBox1.BackColor = inactivecolor
        If d2 >= 0.5 Then
            Titlebar.ForeColor = Color.Black
            ToolStripTextBox1.ForeColor = Color.Black
        Else
            Titlebar.ForeColor = Color.White
            ToolStripTextBox1.ForeColor = Color.White
        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Titlebar.BackColor = colorAccent
        ToolStripTextBox1.BackColor = colorAccent
        If darkness <= 0.5 Then
            Titlebar.ForeColor = Color.White
            ToolStripTextBox1.ForeColor = Color.White
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Navigate(txtlat, txtlong, mtyp, msty, zm)
    End Sub

    Private Function SearchCountry(cname As String) As String
        Dim latlong As String = ""
        cname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cname)
        Dim json As String = File.ReadAllLines(strPath.Replace("file:\", "") & "\countries.json").FirstOrDefault(Function(x) x.Contains(My.Resources.st1 + cname + My.Resources.st1)).TrimEnd(",")
        Dim read = JObject.Parse(json)
        latlong = read.Item("latlng").ToString.Replace(vbNewLine, "").Replace("[", "").Replace("]", "").Replace(" ", "")
        Return latlong
    End Function

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim cords As String = ToolStripTextBox1.Text
        Try
            txtlat = cords.Substring(0, cords.LastIndexOf(","))
            txtlong = (Val(cords.Substring(cords.LastIndexOf(",") + 1)) + 5).ToString
            zm = 15
            Navigate(txtlat, txtlong, mtyp, msty, zm)
        Catch ex As Exception
            Try
                Dim latlong = SearchCountry(cords)
                txtlat = latlong.Substring(0, latlong.LastIndexOf(","))
                txtlong = (Val(latlong.Substring(latlong.LastIndexOf(",") + 1)) + 5).ToString
                zm = 5
                Navigate(txtlat, txtlong, mtyp, msty, zm)
            Catch ey As Exception
                MessageBox.Show("Could not find input country or coordinates." & vbNewLine & vbNewLine & "To search for a country, consider trying an alternate or more precise name." & vbNewLine & "To search for coordinates, they need to be comma separated without spaces.", "Search failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Try
        ToolStripTextBox1.Text = "Search"
    End Sub

    Private Sub ToolStripTextBox1_GotFocus(sender As Object, e As EventArgs) Handles ToolStripTextBox1.GotFocus
        sender.Forecolor = Color.Black
        sender.backcolor = Color.White
    End Sub



    Private Sub ToolStripTextBox1_LostFocus(sender As Object, e As EventArgs) Handles ToolStripTextBox1.LostFocus
        sender.forecolor = Titlebar.ForeColor
        sender.backcolor = Titlebar.BackColor
        If sender.text = "" Then
            sender.text = "Search"
        End If
    End Sub

    Private Sub ToolStripTextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            ToolStripButton4.PerformClick()
            sender.forecolor = Titlebar.ForeColor
            sender.backcolor = Titlebar.BackColor
        End If
    End Sub
    Dim h As New cmenu

    Private Sub Titlebar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Titlebar.ItemClicked

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If Controls.Contains(h) = False Then
            Controls.Add(h)
            h.BringToFront()

            h.Location = New Point(Width - h.Width - 10, sender.height)
        Else
            Controls.Remove(h)
        End If
    End Sub


End Class

