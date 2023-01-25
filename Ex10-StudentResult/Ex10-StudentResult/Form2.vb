Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Blue
        Label1.Font = New System.Drawing.Font("Times New Roman", 30, FontStyle.Italic)
        Label1.Text = "My Custom Text From onLoad Event"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If (Label1.Visible) Then
        '    Label1.Visible = False
        'Else
        '    Label1.Visible = True
        'End If
        Button1.Text = "New Button Text"
        Button1.AutoSize = True
        Button1.Left = Button1.Left - 10
        Button1.Top = Button1.Top - 20
        Button1.Font = New System.Drawing.Font("Comic Sans MS", 22, FontStyle.Italic)

    End Sub
End Class