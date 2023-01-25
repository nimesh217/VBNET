Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Sub mymethod(s As Object, e As EventArgs) Handles Button1.Click
        Dim c As Integer = 5
        Dim d As Integer = 20
        MsgBox(c And d)
        If c And d Then
            MsgBox("Condition is True")
        Else
            MsgBox("Else")
        End If
    End Sub
End Class
