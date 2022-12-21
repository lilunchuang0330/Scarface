Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        Me.BackgroundImage = My.Resources._1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Label1.Text - 1
        If Label1.Text = 0 Then
            Timer1.Enabled = False
            PictureBox1.Visible = False

            Me.BackgroundImage = My.Resources.bg

        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        PictureBox1.Visible = True
        Button1.Text += 1

        If Button1.Text = 2 Then
            PictureBox1.Visible = False
            Me.BackgroundImage = My.Resources.維托
        End If

        If Button1.Text = 3 Then
            PictureBox1.Visible = False
            Me.BackgroundImage = My.Resources.background
            Button1.Enabled = False
        End If
    End Sub
End Class
