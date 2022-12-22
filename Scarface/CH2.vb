Public Class CH2
    Private Sub CH2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Label1.Text - 1
        If Label1.Text = 0 Then
            Timer1.Enabled = False
            picRebenga.Visible = False
        End If
    End Sub
End Class