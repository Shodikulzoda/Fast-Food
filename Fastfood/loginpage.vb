Imports System.Runtime.CompilerServices

Public Class loginpage
    Dim drag As Boolean = False
    Dim start As New Point(0, 0)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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


End Class

