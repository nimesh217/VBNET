Imports System.ComponentModel

Public Class Form1

    Dim fname As String
    Dim lname As String
    Dim answer As String
    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        fname = TextBoxFirstName.Text
        lname = TextBoxLastName.Text
        answer = fname + " " + lname
        MsgBox(answer)
        'MsgBox(TextBoxFirstName.Text+ " "+ TextBoxLastName.Text)


    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxFirstName.Text = ""
        TextBoxLastName.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MsgBox("Form CLosing")

    End Sub
End Class
