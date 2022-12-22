<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CH1game_2
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnG2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnG2
        '
        Me.btnG2.Location = New System.Drawing.Point(223, 131)
        Me.btnG2.Name = "btnG2"
        Me.btnG2.Size = New System.Drawing.Size(129, 62)
        Me.btnG2.TabIndex = 0
        Me.btnG2.Text = "go to ch2"
        Me.btnG2.UseVisualStyleBackColor = True
        '
        'CH1game_2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1136, 632)
        Me.Controls.Add(Me.btnG2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "CH1game_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CH1game_2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnG2 As Button
End Class
