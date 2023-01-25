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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbDate = New System.Windows.Forms.ComboBox()
        Me.cmbmonth = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-M-d"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(328, 54)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(178, 22)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2023, 1, 11, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Date"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 114)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Click"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(275, 342)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "SetDate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbDate
        '
        Me.cmbDate.FormattingEnabled = True
        Me.cmbDate.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDate.Location = New System.Drawing.Point(275, 252)
        Me.cmbDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.Size = New System.Drawing.Size(54, 24)
        Me.cmbDate.TabIndex = 4
        '
        'cmbmonth
        '
        Me.cmbmonth.FormattingEnabled = True
        Me.cmbmonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbmonth.Location = New System.Drawing.Point(337, 252)
        Me.cmbmonth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbmonth.Name = "cmbmonth"
        Me.cmbmonth.Size = New System.Drawing.Size(54, 24)
        Me.cmbmonth.TabIndex = 5
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cmbYear.Location = New System.Drawing.Point(396, 252)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(54, 24)
        Me.cmbYear.TabIndex = 6
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.ForeColor = System.Drawing.Color.Red
        Me.MonthCalendar1.Location = New System.Drawing.Point(460, 73)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.SelectionRange = New System.Windows.Forms.SelectionRange(New Date(2023, 1, 14, 0, 0, 0, 0), New Date(2023, 1, 20, 0, 0, 0, 0))
        Me.MonthCalendar1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 466)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbmonth)
        Me.Controls.Add(Me.cmbDate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbDate As ComboBox
    Friend WithEvents cmbmonth As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
