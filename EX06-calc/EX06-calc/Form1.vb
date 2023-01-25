Public Class Form1
#Region "Varibales"
    Dim no1, no2 As Integer
    Dim ans As Integer



#End Region

#Region "EVENTS"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        no1 = TextBox1.Text
        no2 = TextBox2.Text

        If (rdoplus.Checked) Then
            ans = no1 + no2
        End If
        If (rdominus.Checked) Then
            ans = no1 - no2
        End If

        If (rdomul.Checked) Then
            ans = no1 * no2
        End If
        If (rdodiv.Checked) Then
            If no2 <> 0 Then
                ans = no1 / no2
            End If


        End If
        MsgBox(ans)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = vbNullString
        TextBox2.Text = vbNullString

    End Sub
#End Region


End Class
