Public Class Form1
    Dim d As DateTime
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(DateTimePicker1.Text)
        MsgBox(DateTimePicker1.Value)

        'MonthCalendar1.

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'DateTimePicker1.Value = Now().AddMonths(1)
        Dim year, month, day As Integer
        year = cmbYear.SelectedItem
        month = cmbmonth.Text
        day = cmbDate.Text
        d = New DateTime(year, month, day)
        DateTimePicker1.Value = d




    End Sub

    Private Sub cmbDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDate.SelectedIndexChanged
        MsgBox(cmbDate.SelectedItem)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
