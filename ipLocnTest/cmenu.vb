Public Class cmenu
    Private Sub Cmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.StaticMapFasterToolStripMenuItem.Checked = True Then
            Button4.Text = chk
        Else
            Button4.Text = uchk
        End If
        If Form1.msty = "r" Or Form1.msty = "h" Then
            Button3.Text = chk
        Else
            Button3.Text = uchk
        End If
        If Form1.msty = "r" Then
            Button1.BackColor = Color.FromArgb(255, 80, 80, 80)
        Else
            Button2.BackColor = Color.FromArgb(255, 64, 64, 64)
        End If
        If Form1.msty = "a" Or Form1.msty = "h" Then
            Button2.BackColor = Color.FromArgb(255, 80, 80, 80)
        Else
            Button1.BackColor = Color.FromArgb(255, 64, 64, 64)
        End If
    End Sub


    Dim chk As String = "", uchk As String = ""

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Label2.Click, Button3.Click
        Form1.TrafficToolStripMenuItem.PerformClick()
        Try
            Form1.Controls.Remove(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If sender.backcolor <> Color.FromArgb(255, 80, 80, 80) Then
            sender.backcolor = Color.FromArgb(255, 80, 80, 80)
            Form1.SatelliteToolStripMenuItem.PerformClick()
            Button1.BackColor = BackColor
        End If
        Try
            Form1.Controls.Remove(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sender.backcolor <> Color.FromArgb(255, 80, 80, 80) Then
            sender.backcolor = Color.FromArgb(255, 80, 80, 80)
            Form1.RoadToolStripMenuItem.PerformClick()
            Button2.BackColor = BackColor
        End If
        Try
            Form1.Controls.Remove(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Label3.Click, Button4.Click
        If Button4.Text = uchk Then
            Button4.Text = chk
            Form1.StaticMapFasterToolStripMenuItem.PerformClick()
        Else
            Button4.Text = uchk
            Form1.StaticMapFasterToolStripMenuItem.PerformClick()
        End If
        Try
            Form1.Controls.Remove(Me)
        Catch ex As Exception

        End Try
    End Sub
End Class
