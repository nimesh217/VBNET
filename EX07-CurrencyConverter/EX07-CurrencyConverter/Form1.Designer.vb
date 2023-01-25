<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrencyConverter
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BCom")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MCom")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Commerce", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BSc")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MSc")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Science", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BCA")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Both", New System.Windows.Forms.TreeNode() {TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("KBS Collge Courses", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode8})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCurrencyConverter))
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.txtrupee = New System.Windows.Forms.TextBox()
        Me.rdodollar = New System.Windows.Forms.RadioButton()
        Me.rdoeuro = New System.Windows.Forms.RadioButton()
        Me.rdoyen = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(80, 54)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(163, 38)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Enter Rs. "
        '
        'txtrupee
        '
        Me.txtrupee.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrupee.Location = New System.Drawing.Point(253, 54)
        Me.txtrupee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtrupee.Name = "txtrupee"
        Me.txtrupee.Size = New System.Drawing.Size(276, 44)
        Me.txtrupee.TabIndex = 1
        '
        'rdodollar
        '
        Me.rdodollar.AutoSize = True
        Me.rdodollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdodollar.Location = New System.Drawing.Point(102, 156)
        Me.rdodollar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdodollar.Name = "rdodollar"
        Me.rdodollar.Size = New System.Drawing.Size(133, 42)
        Me.rdodollar.TabIndex = 2
        Me.rdodollar.TabStop = True
        Me.rdodollar.Text = "Dollar"
        Me.rdodollar.UseVisualStyleBackColor = True
        '
        'rdoeuro
        '
        Me.rdoeuro.AutoSize = True
        Me.rdoeuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoeuro.Location = New System.Drawing.Point(253, 156)
        Me.rdoeuro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoeuro.Name = "rdoeuro"
        Me.rdoeuro.Size = New System.Drawing.Size(115, 42)
        Me.rdoeuro.TabIndex = 3
        Me.rdoeuro.TabStop = True
        Me.rdoeuro.Text = "Euro"
        Me.rdoeuro.UseVisualStyleBackColor = True
        '
        'rdoyen
        '
        Me.rdoyen.AutoSize = True
        Me.rdoyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoyen.Location = New System.Drawing.Point(392, 156)
        Me.rdoyen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoyen.Name = "rdoyen"
        Me.rdoyen.Size = New System.Drawing.Size(103, 42)
        Me.rdoyen.TabIndex = 4
        Me.rdoyen.TabStop = True
        Me.rdoyen.Text = "Yen"
        Me.rdoyen.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(145, 261)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(156, 54)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(336, 261)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(156, 54)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblresult.Location = New System.Drawing.Point(220, 352)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 38)
        Me.lblresult.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(392, 450)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 98)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(152, 432)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 62)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(277, 352)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 98)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "InputBox"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(541, 218)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(156, 98)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "MessageBox"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(906, 72)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 39)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(906, 156)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(165, 39)
        Me.TextBox2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(759, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 32)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "First No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(759, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 32)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "First No"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(885, 250)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 65)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Call Module "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Location = New System.Drawing.Point(597, 352)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 236)
        Me.Panel1.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(553, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 107)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(26, 27)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node5"
        TreeNode1.Text = "BCom"
        TreeNode2.Name = "Node6"
        TreeNode2.Text = "MCom"
        TreeNode3.Name = "Node1"
        TreeNode3.Text = "Commerce"
        TreeNode4.Name = "Node7"
        TreeNode4.Text = "BSc"
        TreeNode5.Name = "Node8"
        TreeNode5.Text = "MSc"
        TreeNode6.Name = "Node3"
        TreeNode6.Text = "Science"
        TreeNode7.Name = "Node9"
        TreeNode7.Text = "BCA"
        TreeNode8.Name = "Node4"
        TreeNode8.Text = "Both"
        TreeNode9.Name = "Node0"
        TreeNode9.Text = "KBS Collge Courses"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode9})
        Me.TreeView1.Size = New System.Drawing.Size(249, 193)
        Me.TreeView1.TabIndex = 19
        '
        'frmCurrencyConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 630)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.rdoyen)
        Me.Controls.Add(Me.rdoeuro)
        Me.Controls.Add(Me.rdodollar)
        Me.Controls.Add(Me.txtrupee)
        Me.Controls.Add(Me.lbltitle)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCurrencyConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currenty Converter"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents txtrupee As TextBox
    Friend WithEvents rdodollar As RadioButton
    Friend WithEvents rdoeuro As RadioButton
    Friend WithEvents rdoyen As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblresult As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TreeView1 As TreeView
End Class
