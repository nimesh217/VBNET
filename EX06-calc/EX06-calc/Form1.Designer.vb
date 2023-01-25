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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdoplus = New System.Windows.Forms.RadioButton()
        Me.rdominus = New System.Windows.Forms.RadioButton()
        Me.rdomul = New System.Windows.Forms.RadioButton()
        Me.rdodiv = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Number:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(404, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 27)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(404, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(191, 27)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Second Number:"
        '
        'rdoplus
        '
        Me.rdoplus.AutoSize = True
        Me.rdoplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoplus.Location = New System.Drawing.Point(331, 161)
        Me.rdoplus.Name = "rdoplus"
        Me.rdoplus.Size = New System.Drawing.Size(40, 24)
        Me.rdoplus.TabIndex = 4
        Me.rdoplus.TabStop = True
        Me.rdoplus.Text = "+"
        Me.rdoplus.UseVisualStyleBackColor = True
        '
        'rdominus
        '
        Me.rdominus.AutoSize = True
        Me.rdominus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdominus.Location = New System.Drawing.Point(393, 161)
        Me.rdominus.Name = "rdominus"
        Me.rdominus.Size = New System.Drawing.Size(36, 24)
        Me.rdominus.TabIndex = 5
        Me.rdominus.TabStop = True
        Me.rdominus.Text = "-"
        Me.rdominus.UseVisualStyleBackColor = True
        '
        'rdomul
        '
        Me.rdomul.AutoSize = True
        Me.rdomul.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdomul.Location = New System.Drawing.Point(446, 161)
        Me.rdomul.Name = "rdomul"
        Me.rdomul.Size = New System.Drawing.Size(36, 24)
        Me.rdomul.TabIndex = 6
        Me.rdomul.TabStop = True
        Me.rdomul.Text = "*"
        Me.rdomul.UseVisualStyleBackColor = True
        '
        'rdodiv
        '
        Me.rdodiv.AutoSize = True
        Me.rdodiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdodiv.Location = New System.Drawing.Point(500, 161)
        Me.rdodiv.Name = "rdodiv"
        Me.rdodiv.Size = New System.Drawing.Size(35, 24)
        Me.rdodiv.TabIndex = 7
        Me.rdodiv.TabStop = True
        Me.rdodiv.Text = "/"
        Me.rdodiv.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(297, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 49)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(426, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 49)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 512)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rdodiv)
        Me.Controls.Add(Me.rdomul)
        Me.Controls.Add(Me.rdominus)
        Me.Controls.Add(Me.rdoplus)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rdoplus As RadioButton
    Friend WithEvents rdominus As RadioButton
    Friend WithEvents rdomul As RadioButton
    Friend WithEvents rdodiv As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
