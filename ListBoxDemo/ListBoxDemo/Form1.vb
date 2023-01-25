Public Class Form1
    Dim cnt As Integer = 0
    Dim seconds As Integer = 0
    Dim mintues As Integer = 0
    Dim hour As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Argentina")
        ListBox1.Items.Add("Ukrain")
        ListBox1.Items.Add("Uganda")
        ListBox1.Items.Insert(2, "Sri Lanka")
        Label1.Text = "Total Country : " & ListBox1.Items.Count


        ToolTip1.SetToolTip(Button1, "Click me to add value in listbox")
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Error


        ToolTip1.SetToolTip(Button2, "New Tooltip")
        ToolTip1.IsBalloon = False
        ToolTip1.ToolTipIcon = ToolTipIcon.Warning
        ToolTip1.AutomaticDelay = 1500


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()
        Label1.Text = "Total Country : " & ListBox1.Items.Count
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MsgBox(ListBox1.SelectedIndex & " : " & ListBox1.SelectedItem)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim v As Integer
        v = HScrollBar1.Value
        Label1.Font = New Font(Label1.Font.Name, v, Label1.Font.Style)
    End Sub

    Private Sub HScrollBarRed_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarRed.Scroll
        Label1.BackColor = Color.FromArgb(HScrollBarRed.Value, HScrollBarGreen.Value, HScrollBarBlue.Value)

    End Sub

    Private Sub HScrollBarGreen_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarGreen.Scroll
        Label1.BackColor = Color.FromArgb(HScrollBarRed.Value, HScrollBarGreen.Value, HScrollBarBlue.Value)

    End Sub

    Private Sub HScrollBarBlue_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarBlue.Scroll
        Label1.BackColor = Color.FromArgb(HScrollBarRed.Value, HScrollBarGreen.Value, HScrollBarBlue.Value)

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Start()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = hour & ":" & mintues & ":" & seconds
        seconds = seconds + 1
        If (seconds = 60) Then
            seconds = 0
            mintues = mintues + 1

        End If
        If (mintues = 60) Then
            hour = hour + 1
            mintues = 0
        End If
        If (hour = 24) Then
            hour = 0
        End If
    End Sub
End Class
