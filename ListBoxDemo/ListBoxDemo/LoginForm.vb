Public Class LoginForm
    'Dim m As New MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'admin admin@123

        If (TextBox1.Text = "admin" And TextBox2.Text = "admin@123") Then
            'sucess
            MsgBox("Success")
            ' m.Show()
            MainForm.ShowDialog()
            'MainForm.ActiveForm.Show()
        Else
            'failure
            MsgBox("Login Failed")
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFontSize.Items.Add(20)
        cmbFontSize.Items.Add(22)

    End Sub

    Private Sub cmbFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFontSize.SelectedIndexChanged
        MsgBox(cmbFontSize.SelectedItem)

        Dim sz As Single
        sz = cmbFontSize.SelectedItem
        Button1.Font = New Font("Comic Sans MS", sz, FontStyle.Bold)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Font = New Font(Button2.Font, FontStyle.Bold)
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.FromArgb(0, 255, 0)


        PictureBox1.Image = Image.FromFile("C:\Users\Nimesh\Desktop\b.jpg")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class