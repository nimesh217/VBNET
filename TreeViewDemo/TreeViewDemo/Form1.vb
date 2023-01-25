Public Class Form1
    Dim txt As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt = TextBox1.Text

        Try
            If (TreeView1.SelectedNode Is Nothing) Then
                TreeView1.Nodes.Add(txt, txt)

            Else
                TreeView1.SelectedNode.Nodes.Add(txt, txt)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        TextBox1.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TreeView1.SelectedNode.GetNodeCount(True) = 0 Then
            TreeView1.SelectedNode.Remove()
        Else
            MsgBox("YOu cannot remove node with child")
        End If

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Label2.Text = TreeView1.SelectedNode.GetNodeCount(False)
    End Sub
End Class
