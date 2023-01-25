Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnMyButton.Click
        'MsgBox("Hello from btn click event")
        MsgBox(TextBox1.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("From form's load event")
    End Sub

End Class
