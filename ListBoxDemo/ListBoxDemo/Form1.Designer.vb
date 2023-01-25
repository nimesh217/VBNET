<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBarRed = New System.Windows.Forms.HScrollBar()
        Me.HScrollBarGreen = New System.Windows.Forms.HScrollBar()
        Me.HScrollBarBlue = New System.Windows.Forms.HScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"India", "USA", "China", "UK", "Australia"})
        Me.ListBox1.Location = New System.Drawing.Point(152, 190)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(222, 260)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(192, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(427, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(427, 341)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(320, 142)
        Me.HScrollBar1.Maximum = 72
        Me.HScrollBar1.Minimum = 7
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(397, 21)
        Me.HScrollBar1.TabIndex = 6
        Me.HScrollBar1.Value = 15
        '
        'HScrollBarRed
        '
        Me.HScrollBarRed.Location = New System.Drawing.Point(139, 487)
        Me.HScrollBarRed.Maximum = 255
        Me.HScrollBarRed.Name = "HScrollBarRed"
        Me.HScrollBarRed.Size = New System.Drawing.Size(547, 35)
        Me.HScrollBarRed.TabIndex = 7
        '
        'HScrollBarGreen
        '
        Me.HScrollBarGreen.Location = New System.Drawing.Point(139, 543)
        Me.HScrollBarGreen.Maximum = 255
        Me.HScrollBarGreen.Name = "HScrollBarGreen"
        Me.HScrollBarGreen.Size = New System.Drawing.Size(554, 43)
        Me.HScrollBarGreen.TabIndex = 8
        '
        'HScrollBarBlue
        '
        Me.HScrollBarBlue.Location = New System.Drawing.Point(139, 605)
        Me.HScrollBarBlue.Maximum = 255
        Me.HScrollBarBlue.Name = "HScrollBarBlue"
        Me.HScrollBarBlue.Size = New System.Drawing.Size(554, 41)
        Me.HScrollBarBlue.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 487)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Red:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 553)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Green:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 617)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Blue:"
        '
        'ToolTip1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(904, 112)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 59)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Start"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1001, 112)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 59)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Stop"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(966, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 699)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HScrollBarBlue)
        Me.Controls.Add(Me.HScrollBarGreen)
        Me.Controls.Add(Me.HScrollBarRed)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents HScrollBarRed As HScrollBar
    Friend WithEvents HScrollBarGreen As HScrollBar
    Friend WithEvents HScrollBarBlue As HScrollBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
End Class
