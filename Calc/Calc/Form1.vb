Public Class Form1
#Region "variables"
    Dim start As Boolean = False
    Dim no1 As Double
    Dim no2 As Double
    Dim opr As Char

#End Region

#Region "Procedures"
    Public Sub clear()
        txtResult.Text = ""
    End Sub
    Public Sub resetall()
        'MsgBox("reset")
        no1 = no2 = 0
        txtResult.Text = 0
        opr = ""
        start = False
    End Sub

    Public Sub calc()
        If (opr = "+") Then
            no1 = no1 + no2
        ElseIf (opr = "-") Then
            no1 = no1 - no2

        ElseIf (opr = "*") Then
            no1 = no1 * no2
        ElseIf (opr = "/") Then
            no1 = no1 / no2
        End If
        txtResult.Text = no1
    End Sub
#End Region
#Region "EVENTS"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtResult.Text = 0
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        If (start = False) Then
            clear()
            start = True
        End If
        txtResult.Text = txtResult.Text & sender.Text

    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        If (no2 = 0 And no1 = 0) Then
            no1 = Val(txtResult.Text)
            txtResult.Text = ""

        ElseIf (no2 = 0 And start = True) Then
            no2 = Val(txtResult.Text)
            calc()

            no2 = 0
            start = False

        End If
        opr = "+"
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        If (no2 = 0 And no1 = 0) Then
            no1 = Val(txtResult.Text)
            txtResult.Text = ""

        ElseIf (no2 = 0 And start = True) Then
            no2 = Val(txtResult.Text)
            calc()

            no2 = 0
            start = False

        End If
        opr = "-"
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        If (no2 = 0 And no1 = 0) Then
            no1 = Val(txtResult.Text)
            txtResult.Text = ""

        ElseIf (no2 = 0 And start = True) Then
            no2 = Val(txtResult.Text)
            calc()

            no2 = 0
            start = False
        End If
        opr = "*"
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        If (no2 = 0 And no1 = 0) Then
            no1 = Val(txtResult.Text)
            txtResult.Text = ""

        ElseIf (no2 = 0 And start = True) Then
            no2 = Val(txtResult.Text)
            calc()

            no2 = 0
            start = False
        End If
        opr = "/"
    End Sub

    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        no2 = Val(txtResult.Text)
        calc()
        no2 = 0
        start = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        resetall()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.BackColor = Color.Red
        Me.ForeColor = Color.FromArgb(RGB(255, 255, 0))

    End Sub

#End Region



End Class
