Public Class Form1
    Dim player1 As Char = "0"
    Dim player2 As Char = "X"
    Dim currentPlayer As Integer = 0
    Dim cnt As Integer = 0
    Dim isFinished As Boolean = False

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'start a game
        resetgame()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click

        If (currentPlayer = 1) Then
            sender.Text = player1

        Else
            sender.Text = player2
        End If
        sender.Enabled = False
        If (currentPlayer = 1) Then
            currentPlayer = 2
        Else
            currentPlayer = 1
        End If
        cnt += 1
        checkwin()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'resetgame()

        disablebutton()
    End Sub
    Public Sub resetgame()
        currentPlayer = 1
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Label1.Text = ""

        enablebutton()
        isFinished = False
    End Sub

    Public Sub disablebutton()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub
    Public Sub enablebutton()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
    End Sub
    Public Sub checkwin()
        If (Not isFinished) Then
            If (Button1.Text = player1 And Button2.Text = player1 And Button3.Text = player1) Or
           (Button1.Text = player1 And Button4.Text = player1 And Button7.Text = player1) Or
           (Button1.Text = player1 And Button5.Text = player1 And Button9.Text = player1) Or
           (Button2.Text = player1 And Button5.Text = player1 And Button8.Text = player1) Or
           (Button3.Text = player1 And Button6.Text = player1 And Button9.Text = player1) Or
           (Button3.Text = player1 And Button5.Text = player1 And Button7.Text = player1) Or
           (Button4.Text = player1 And Button5.Text = player1 And Button6.Text = player1) Or
           (Button7.Text = player1 And Button8.Text = player1 And Button9.Text = player1) Then
                Label1.Text = "Player  1 wins"
                isFinished = True
                disablebutton()
            ElseIf (Button1.Text = player2 And Button2.Text = player2 And Button3.Text = player2) Or
               (Button1.Text = player2 And Button4.Text = player2 And Button7.Text = player2) Or
               (Button1.Text = player2 And Button5.Text = player2 And Button9.Text = player2) Or
               (Button2.Text = player2 And Button5.Text = player2 And Button8.Text = player2) Or
               (Button3.Text = player2 And Button6.Text = player2 And Button9.Text = player2) Or
               (Button3.Text = player2 And Button5.Text = player2 And Button7.Text = player2) Or
               (Button4.Text = player2 And Button5.Text = player2 And Button6.Text = player2) Or
               (Button7.Text = player2 And Button8.Text = player2 And Button9.Text = player2) Then
                Label1.Text = "Player  2 wins"
                isFinished = True
                disablebutton()
            Else
                If (cnt = 9) Then
                    Label1.Text = "Draw"
                    isFinished = True
                End If
            End If
        Else
            resetgame()

        End If

    End Sub
End Class
