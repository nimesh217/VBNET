Public Class Form1
    Dim icounter As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'next
        If (icounter < ImageList1.Images.Count - 1) Then
            icounter += 1
        Else
            MsgBox("last image")
        End If
        PictureBox1.BackgroundImage = ImageList1.Images(icounter)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ImageList1.Images(icounter)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        'PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY)
        'HelpProvider
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (icounter > 0) Then
            icounter -= 1
        Else
            MsgBox("first image")
        End If
        PictureBox1.BackgroundImage = ImageList1.Images(icounter)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub
End Class
