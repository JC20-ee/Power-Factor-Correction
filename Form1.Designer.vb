<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblV = New System.Windows.Forms.Label()
        Me.lblNpf = New System.Windows.Forms.Label()
        Me.lblOpf = New System.Windows.Forms.Label()
        Me.lblP = New System.Windows.Forms.Label()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtV = New System.Windows.Forms.TextBox()
        Me.txtNpf = New System.Windows.Forms.TextBox()
        Me.txtOpf = New System.Windows.Forms.TextBox()
        Me.txtP = New System.Windows.Forms.TextBox()
        Me.btnShowImage = New System.Windows.Forms.GroupBox()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.cmbPrefix = New System.Windows.Forms.ComboBox()
        Me.lblC = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpInput.SuspendLayout()
        Me.btnShowImage.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.lblF)
        Me.grpInput.Controls.Add(Me.lblV)
        Me.grpInput.Controls.Add(Me.lblNpf)
        Me.grpInput.Controls.Add(Me.lblOpf)
        Me.grpInput.Controls.Add(Me.lblP)
        Me.grpInput.Controls.Add(Me.txtF)
        Me.grpInput.Controls.Add(Me.txtV)
        Me.grpInput.Controls.Add(Me.txtNpf)
        Me.grpInput.Controls.Add(Me.txtOpf)
        Me.grpInput.Controls.Add(Me.txtP)
        Me.grpInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInput.Location = New System.Drawing.Point(12, 45)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(478, 242)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input"
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Location = New System.Drawing.Point(6, 195)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(148, 25)
        Me.lblF.TabIndex = 9
        Me.lblF.Text = "Frequency (Hz)"
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Location = New System.Drawing.Point(6, 152)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(172, 25)
        Me.lblV.TabIndex = 8
        Me.lblV.Text = "Line voltage Vₗ (V)"
        '
        'lblNpf
        '
        Me.lblNpf.AutoSize = True
        Me.lblNpf.Location = New System.Drawing.Point(6, 111)
        Me.lblNpf.Name = "lblNpf"
        Me.lblNpf.Size = New System.Drawing.Size(227, 25)
        Me.lblNpf.TabIndex = 7
        Me.lblNpf.Text = "Target power factor (< 1)"
        '
        'lblOpf
        '
        Me.lblOpf.AutoSize = True
        Me.lblOpf.Location = New System.Drawing.Point(6, 69)
        Me.lblOpf.Name = "lblOpf"
        Me.lblOpf.Size = New System.Drawing.Size(214, 25)
        Me.lblOpf.TabIndex = 6
        Me.lblOpf.Text = "Initial power factor (< 1)"
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Location = New System.Drawing.Point(6, 27)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(231, 25)
        Me.lblP.TabIndex = 5
        Me.lblP.Text = "Total Real Power Pₜ (kW)"
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(266, 195)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(178, 30)
        Me.txtF.TabIndex = 4
        '
        'txtV
        '
        Me.txtV.Location = New System.Drawing.Point(266, 152)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(178, 30)
        Me.txtV.TabIndex = 3
        '
        'txtNpf
        '
        Me.txtNpf.Location = New System.Drawing.Point(266, 111)
        Me.txtNpf.Name = "txtNpf"
        Me.txtNpf.Size = New System.Drawing.Size(178, 30)
        Me.txtNpf.TabIndex = 2
        '
        'txtOpf
        '
        Me.txtOpf.Location = New System.Drawing.Point(266, 66)
        Me.txtOpf.Name = "txtOpf"
        Me.txtOpf.Size = New System.Drawing.Size(178, 30)
        Me.txtOpf.TabIndex = 1
        '
        'txtP
        '
        Me.txtP.Location = New System.Drawing.Point(266, 27)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(178, 30)
        Me.txtP.TabIndex = 0
        '
        'btnShowImage
        '
        Me.btnShowImage.Controls.Add(Me.btnImage)
        Me.btnShowImage.Controls.Add(Me.txtData)
        Me.btnShowImage.Controls.Add(Me.cmbPrefix)
        Me.btnShowImage.Controls.Add(Me.lblC)
        Me.btnShowImage.Controls.Add(Me.txtC)
        Me.btnShowImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowImage.Location = New System.Drawing.Point(496, 45)
        Me.btnShowImage.Name = "btnShowImage"
        Me.btnShowImage.Size = New System.Drawing.Size(552, 309)
        Me.btnShowImage.TabIndex = 1
        Me.btnShowImage.TabStop = False
        Me.btnShowImage.Text = "Output"
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(451, 218)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(89, 85)
        Me.btnImage.TabIndex = 4
        Me.btnImage.Text = "&Show Image"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(110, 85)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.ReadOnly = True
        Me.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtData.Size = New System.Drawing.Size(335, 218)
        Me.txtData.TabIndex = 3
        '
        'cmbPrefix
        '
        Me.cmbPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrefix.FormattingEnabled = True
        Me.cmbPrefix.Items.AddRange(New Object() {"MF", "kF", "F", "mF", "μF", "nF", "pF"})
        Me.cmbPrefix.Location = New System.Drawing.Point(425, 29)
        Me.cmbPrefix.Name = "cmbPrefix"
        Me.cmbPrefix.Size = New System.Drawing.Size(121, 33)
        Me.cmbPrefix.TabIndex = 1
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(6, 32)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(164, 25)
        Me.lblC.TabIndex = 2
        Me.lblC.Text = "Final capacitance"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(185, 32)
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtC.Size = New System.Drawing.Size(224, 30)
        Me.txtC.TabIndex = 0
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(55, 304)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(130, 50)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(247, 304)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(130, 50)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1077, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(1077, 368)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnShowImage)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Three-Phase Delta System Balanced Load: Power Factor Correction"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.btnShowImage.ResumeLayout(False)
        Me.btnShowImage.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents btnShowImage As GroupBox
    Friend WithEvents lblF As Label
    Friend WithEvents lblV As Label
    Friend WithEvents lblNpf As Label
    Friend WithEvents lblOpf As Label
    Friend WithEvents lblP As Label
    Friend WithEvents txtF As TextBox
    Friend WithEvents txtV As TextBox
    Friend WithEvents txtNpf As TextBox
    Friend WithEvents txtOpf As TextBox
    Friend WithEvents txtP As TextBox
    Friend WithEvents cmbPrefix As ComboBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblC As Label
    Friend WithEvents txtData As TextBox
    Friend WithEvents btnImage As Button
End Class
