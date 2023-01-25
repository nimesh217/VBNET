Public Class Form1

    Dim currentFileName As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (currentFileName <> "") Then
            OpenFileDialog1.ShowDialog()
            currentFileName = OpenFileDialog1.FileName
            If (currentFileName <> "") Then
                RichTextBox1.LoadFile(currentFileName)
            End If
        Else
            MsgBox("FIle ALready Open")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If currentFileName = "" Then
            SaveFileDialog1.ShowDialog()
            currentFileName = SaveFileDialog1.FileName
            If currentFileName <> "" Then
                RichTextBox1.SaveFile(currentFileName)
                MsgBox("File saved")
            Else
                MsgBox("File Not Saved")
            End If
        Else
            If currentFileName <> "" Then
                RichTextBox1.SaveFile(currentFileName)
                MsgBox("File saved")
            Else
                MsgBox("File Not Saved")
            End If
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If (currentFileName = "") Then
            OpenFileDialog1.ShowDialog()
            currentFileName = OpenFileDialog1.FileName
            If (currentFileName <> "") Then
                RichTextBox1.LoadFile(currentFileName)
            End If
        Else
            MsgBox("FIle ALready Open")
        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If currentFileName = "" Then
            SaveFileDialog1.ShowDialog()
            currentFileName = SaveFileDialog1.FileName
            If currentFileName <> "" Then
                RichTextBox1.SaveFile(currentFileName)
                MsgBox("File saved")
            Else
                MsgBox("File Not Saved")
            End If
        Else
            If currentFileName <> "" Then
                RichTextBox1.SaveFile(currentFileName)
                MsgBox("File saved")
            Else
                MsgBox("File Not Saved")
            End If
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentFileName = ""
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        ' RichTextBox1.Font = FontDialog1.Font
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
        'RichTextBox1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub
End Class
