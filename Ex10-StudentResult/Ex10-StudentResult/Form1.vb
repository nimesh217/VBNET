Public Class Form1
    Dim m401, m402, m403, m404, m405 As Integer



    Dim total As Integer
    Dim per As Double
    Dim grade As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        m401 = Val(TextBox1.Text)
        m402 = Integer.Parse(TextBox2.Text)
        m403 = Integer.Parse(TextBox3.Text)
        m404 = Int32.Parse(TextBox4.Text)
        m405 = Int64.Parse(TextBox5.Text)
        total = m401 + m402 + m403 + m404 + m405
        per = total / 5
        Dim ktCounter As Integer = 0
        If (m401 < 35) Then
            ktCounter += 1
        End If
        If (m402 < 35) Then
            ktCounter += 1
        End If

        If (m403 < 35) Then
            ktCounter += 1
        End If

        If (m404 < 35) Then
            ktCounter += 1
        End If

        If (m405 < 35) Then
            ktCounter += 1
        End If

        If (ktCounter = 0) Then
            If (per >= 70) Then
                grade = "Distinction"
            ElseIf (per >= 60) Then
                grade = "FIRST"
            ElseIf (per >= 50) Then
                grade = "SECOND"
            ElseIf (per >= 35) Then
                grade = "PASS"
            Else
                grade = "----FAIL"

            End If
        ElseIf (ktCounter <= 2) Then
            grade = "A.T.K.T. - F -" & ktCounter
        Else
            grade = "FAIL"
        End If

        lblTotal.Text = total.ToString
        If (ktCounter = 0) Then
            lblPer.Text = per.ToString
        End If
        lblGrade.Text = grade



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        Dim a As Integer
        a = Val(TextBox1.Text)
        If (Not validMark(a)) Then
            MsgBox("Marks should be between 0 and 100 only.")
            TextBox1.Focus()
            TextBox1.SelectAll()
        End If
    End Sub
    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        Dim a As Integer
        a = Val(TextBox2.Text)
        If (Not validMark(a)) Then
            MsgBox("Marks should be between 0 and 100 only.")
            TextBox2.Focus()
            TextBox2.SelectAll()
        End If
    End Sub

    Function validMark(ByVal a As Integer) As Boolean
        If (a < 0 Or a > 100) Then
            Return False
        End If
        Return True
    End Function


End Class
