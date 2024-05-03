Imports System.Drawing.Drawing2D
Public Class Form1
    Dim drag As Boolean = False
    Dim start As New Point(0, 0)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        drag = True
        start = New Point(e.X, e.Y)
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag Then
            Dim p As Point = PointToScreen(e.Location)
            Me.Location = New Point(p.X - start.X, p.Y - start.Y)
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub





    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        side.Height = dashboard.Height
        side.Top = dashboard.Top
    End Sub

    Private Sub master_Click(sender As Object, e As EventArgs) Handles master.Click
        side.Height = master.Height
        side.Top = master.Top
    End Sub

    Private Sub billing_Click(sender As Object, e As EventArgs) Handles billing.Click
        side.Height = billing.Height
        side.Top = billing.Top
    End Sub

    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        side.Height = admin.Height
        side.Top = admin.Top
    End Sub

    Private Sub reports_Click(sender As Object, e As EventArgs) Handles reports.Click
        side.Height = reports.Height
        side.Top = reports.Top
    End Sub

    Private Sub records_Click(sender As Object, e As EventArgs) Handles records.Click
        side.Height = records.Height
        side.Top = records.Top
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        side.Height = logout.Height
        side.Top = logout.Top
        'Me.Hide()
        loginpage.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Timer1.Enabled = True
        username.Text = loginpage.login.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginpage.Show()
    End Sub
End Class

