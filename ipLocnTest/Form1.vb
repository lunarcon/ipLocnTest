Imports System.Collections.Generic
Imports System.Device.Location
Imports System.Runtime.InteropServices

Public Class Form1
    Dim objShell = CreateObject("Shell.Application")
    Dim mtyp As String = "d"
    Dim msty As String = "h"
    Dim zm As Integer = 1
    Dim colorSystemAccent As UInteger = GetImmersiveColorFromColorSetEx(GetImmersiveUserColorSetPreference(False, False), GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveSystemAccent")), False, 0)
    Dim colorAccent As System.Drawing.Color = System.Drawing.Color.FromArgb((&HFF000000 And colorSystemAccent) >> 24, &HFF And colorSystemAccent, (&HFF00 And colorSystemAccent) >> 8, (&HFF0000 And colorSystemAccent) >> 16)

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
    Dim darkness As Double = 1 - ((0.299 * Int(colorAccent.R)) + (0.587 * Int(colorAccent.G)) + (0.114 * Int(colorAccent.B)))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrafficToolStripMenuItem.Checked = True
        Navigate(0, 0, mtyp, msty, zm)
        If darkness <= 0.5 Then
            ToolStrip1.ForeColor = Color.White
        End If
        ToolStrip1.BackColor = colorAccent

    End Sub
    Private Sub Watcher_StatusChanged(ByVal sender As Object, ByVal e As GeoPositionStatusChangedEventArgs)
        If e.Status = GeoPositionStatus.Ready Then

            If Watcher.Position.Location.IsUnknown Then
                txtlat = "Cannot find location data"
            Else
                txtlat = Watcher.Position.Location.Latitude.ToString() '.Substring(0, 7)
                txtlong = Watcher.Position.Location.Longitude.ToString() '.Substring(0, 7)
            End If
        End If
        Navigate(txtlat, txtlong, mtyp, msty, 17)
        If Val(txtlat) > 0 Then
            Watcher.Stop()
            Clipboard.SetText(wb.Url.ToString)
        End If
    End Sub
    Private Sub LocateMe()
        Watcher = New GeoCoordinateWatcher()
        AddHandler Watcher.StatusChanged, AddressOf Watcher_StatusChanged
        Watcher.Start()
    End Sub

    Private Sub Navigate(lati As String, longi As String, maptype As String, mapstyle As String, zoom As Integer)
        wb.Navigate("https://www.bing.com/maps/embed?h=" & (wb.Height + 28).ToString & "&w=" & (wb.Width + 300).ToString & "&cp=" & lati & "~" & longi & "&lvl=" & zoom.ToString & "&typ=" & maptype & "&sty=" & mapstyle & "&src=SHELL&FORM=MBEDV8")
    End Sub

    Private Sub wb_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Watcher = New GeoCoordinateWatcher()
        AddHandler Watcher.StatusChanged, AddressOf Watcher_StatusChanged
        Watcher.Start()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
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
            g.CopyFromScreen(PointToScreen(New Point(0, 25)), New Point(0, 25), New Size(Width - 20, Height - 63))
        End Using
        Return tmpImg
    End Function
    Private Sub StaticMapFasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaticMapFasterToolStripMenuItem.Click
        If sender.checked = True Then
            mtyp = "s"
            Navigate(0, 0, mtyp, msty, zm)
            ZmIn.Visible = True
            ZmOu.Visible = True
            Sept.Visible = True
        Else
            mtyp = "d"
            Navigate(0, 0, mtyp, msty, zm)
            ZmIn.Visible = False
            ZmOu.Visible = False
            Sept.Visible = False
        End If
    End Sub

    Private Sub SatelliteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatelliteToolStripMenuItem.Click
        If sender.checked = False Then
            If TrafficToolStripMenuItem.Checked = True Then
                msty = "h"
                Navigate(0, 0, mtyp, msty, zm)
            Else
                msty = "a"
                Navigate(0, 0, mtyp, msty, zm)
            End If
        Else
            RoadToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub RoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoadToolStripMenuItem.Click
        If sender.checked = False Then
            msty = "r"
            TrafficToolStripMenuItem.Checked = True
            Navigate(0, 0, mtyp, msty, zm)
        Else
            SatelliteToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub TrafficToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrafficToolStripMenuItem.Click
        If sender.checked = False And msty = "h" Then
            msty = "a"
            Navigate(0, 0, mtyp, msty, zm)
        ElseIf msty = "r" Then
            sender.checked = True
        Else
            sender.checked = False
        End If
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        sender.text = ""
    End Sub
    Private Sub GoToCoordinatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToCoordinatesToolStripMenuItem.Click
        Dim cords As String = ToolStripTextBox1.Text
        Try
            txtlat = cords.Substring(0, cords.LastIndexOf(","))
            txtlong = cords.Substring(cords.LastIndexOf(",") + 1)
            Navigate(txtlat, txtlong, mtyp, msty, 15)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ZmIn_Click(sender As Object, e As EventArgs) Handles ZmIn.Click
        zm += 1
        Navigate(txtlat, txtlong, mtyp, msty, zm)
    End Sub

    Private Sub ZmOu_Click(sender As Object, e As EventArgs) Handles ZmOu.Click
        zm -= 1
        Navigate(txtlat, txtlong, mtyp, msty, zm)
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Form1_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

    End Sub
End Class

'maptype = d - draggable    mapstyle = r - road     mapstyle = a - aerial no labels
'maptype = s - static       mapstyle = h - aerial
