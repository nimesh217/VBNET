Imports System.ComponentModel

Public Class frmCurrencyConverter

    Dim no As Decimal
    Dim ans As Decimal
    Const cdollar As Decimal = 83.456
    Const ceuro As Decimal = 98.237
    Const cyen As Decimal = 45.987

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        no = txtrupee.Text
        'no = Integer.Parse(txtrupee.Text)
        If (rdodollar.Checked) Then
            ans = no / cdollar
        ElseIf (rdoeuro.Checked) Then
            ans = no / ceuro
        ElseIf (rdoyen.Checked) Then
            ans = no / cyen
        End If

        lblresult.Text = ans
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim no As Integer

        no = txtrupee.Text

        lblresult.Text = CChar(CStr(no))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("this is message")
        MsgBox("MESSAGE", 3, "TITLE")
        Me.Dispose()

    End Sub

    Private Sub frmCurrencyConverter_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim val As Integer
        Dim v As Integer
        v = MsgBox("MSG", vbRetryCancel, "TITLE")
        If (v = vbRetry) Then

        End If

        val = MsgBox("Do you want to close this form?", vbYesNo + vbCritical, "Form Close")
        MsgBox(val)
        If (val = vbYes) Then
            MsgBox("Form will be closed")
            Me.Dispose()
        Else
            MsgBox("Form will not be closed")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim K As Integer
        K = InputBox("Enter value", "TITLE", "0", 10, 10)
        MsgBox(K)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim temp As Integer
        temp = MessageBox.Show("My new msg", "TITLE", MessageBoxButtons.OKCancel)
        MessageBox.Show(temp)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim x, y As Integer
        x = TextBox1.Text
        y = TextBox2.Text
        MsgBox(x & " " & y)
        'MyModule.sum(x, y)
        MyModule.exchange(x, y)
        MsgBox(x & " " & y)
    End Sub

End Class
