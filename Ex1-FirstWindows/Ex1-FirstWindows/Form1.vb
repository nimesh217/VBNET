Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim no As Integer
        Dim cnt As Integer
        no = 50
        Dim answer As String
        answer = vbNullString

        For cnt = 1 To no Step 2
            answer = answer & cnt & ","
        Next
        Label1.Text = answer
    End Sub
End Class
