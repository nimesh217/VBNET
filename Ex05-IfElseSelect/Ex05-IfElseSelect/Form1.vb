Public Class Form1
#Region "globalvariable"
    Dim temp As Integer
#End Region


#Region "myown subprocedure"
    Public Sub mysub1()
        MsgBox("subroutine called")
    End Sub

    Public Function myfun1()
        MsgBox("My function called")
    End Function
#End Region

#Region "EVENTS"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no As Integer
        no = -4
        If no > 0 Then
            MsgBox(Math.Sqrt(no))
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim no As Integer
        no = -87
        If no >= 0 Then
            MsgBox("Given number is positive")
        Else
            MsgBox("Given number is negative")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'nested if
        Dim age As Integer
        Dim country As String
        age = 15
        country = "US"

        If country = "India" Then
            If age >= 18 Then
                MsgBox("You can vote")
            Else
                MsgBox("you can't vote")
            End If
        Else
            MsgBox("Only indian can vote")
        End If



    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnifelseif.Click
        Dim per As Single
        per = 54
        If per >= 70 Then
            MsgBox("Distiction")
        ElseIf per >= 60 Then
            MsgBox("First Class")
        ElseIf per >= 50 Then
            MsgBox("Second Class")
        ElseIf per >= 35 Then
            MsgBox("Pass Class")
        Else
            MsgBox("Fail")
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim ch As Char
        ch = "h"
        Select Case ch
            Case "a"
                MsgBox("Vowel")
            Case "e"
                MsgBox("Vowel")
            Case "i"
                MsgBox("Vowel")
            Case "o"
                MsgBox("Vowel")
            Case "u"
                MsgBox("Vowel")
            Case Else
                MsgBox("consonant")

        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
#End Region



End Class
