Imports System.Reflection.Emit

Public Class CH1
    Private Sub CH1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Label1.Text - 1
        If Label1.Text = 0 Then
            Timer1.Enabled = False
            PictureBox1.Visible = False

            Me.BackgroundImage = My.Resources._1
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch

        End If
    End Sub
End Class