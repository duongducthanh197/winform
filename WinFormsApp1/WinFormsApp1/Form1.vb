Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Location.X < Form1.ActiveForm.Size.Width - 30 Then
            Label1.Location = New Point(Label1.Location.X + 10, Label1.Location.Y)
        Else
            Label1.Location = New Point(20, Label1.Location.Y)
        End If
    End Sub

End Class
