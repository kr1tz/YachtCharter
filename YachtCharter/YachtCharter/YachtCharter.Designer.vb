<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearForNextCharterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCountOfYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartyLabel = New System.Windows.Forms.Label()
        Me.HoursLabel = New System.Windows.Forms.Label()
        Me.PartyTextBox = New System.Windows.Forms.TextBox()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LengthComboBox = New System.Windows.Forms.ComboBox()
        Me.YachtLengthLabel = New System.Windows.Forms.Label()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.YachtTypeLabel = New System.Windows.Forms.Label()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocumentOne = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentTwo = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(552, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSummaryToolStripMenuItem, Me.PrintYachtTypesToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PrintSummaryToolStripMenuItem.Text = "&Print Summary"
        '
        'PrintYachtTypesToolStripMenuItem
        '
        Me.PrintYachtTypesToolStripMenuItem.Name = "PrintYachtTypesToolStripMenuItem"
        Me.PrintYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PrintYachtTypesToolStripMenuItem.Text = "Print &Yacht Types"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearForNextCharterToolStripMenuItem, Me.ToolStripSeparator2, Me.AddYachtTypeToolStripMenuItem, Me.RemoveYachtTypeToolStripMenuItem, Me.DisplayCountOfYachtTypeToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearForNextCharterToolStripMenuItem
        '
        Me.ClearForNextCharterToolStripMenuItem.Name = "ClearForNextCharterToolStripMenuItem"
        Me.ClearForNextCharterToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ClearForNextCharterToolStripMenuItem.Text = "Clear for &Next Charter"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(219, 6)
        '
        'AddYachtTypeToolStripMenuItem
        '
        Me.AddYachtTypeToolStripMenuItem.Name = "AddYachtTypeToolStripMenuItem"
        Me.AddYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AddYachtTypeToolStripMenuItem.Text = "&Add Yacht Type"
        '
        'RemoveYachtTypeToolStripMenuItem
        '
        Me.RemoveYachtTypeToolStripMenuItem.Name = "RemoveYachtTypeToolStripMenuItem"
        Me.RemoveYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.RemoveYachtTypeToolStripMenuItem.Text = "&Remove Yacht Type"
        '
        'DisplayCountOfYachtTypeToolStripMenuItem
        '
        Me.DisplayCountOfYachtTypeToolStripMenuItem.Name = "DisplayCountOfYachtTypeToolStripMenuItem"
        Me.DisplayCountOfYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.DisplayCountOfYachtTypeToolStripMenuItem.Text = "&Display Count of Yacht Type"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'PartyLabel
        '
        Me.PartyLabel.AutoSize = True
        Me.PartyLabel.Location = New System.Drawing.Point(28, 45)
        Me.PartyLabel.Name = "PartyLabel"
        Me.PartyLabel.Size = New System.Drawing.Size(95, 13)
        Me.PartyLabel.TabIndex = 1
        Me.PartyLabel.Text = "Responsible &Party:"
        '
        'HoursLabel
        '
        Me.HoursLabel.AutoSize = True
        Me.HoursLabel.Location = New System.Drawing.Point(31, 72)
        Me.HoursLabel.Name = "HoursLabel"
        Me.HoursLabel.Size = New System.Drawing.Size(87, 13)
        Me.HoursLabel.TabIndex = 2
        Me.HoursLabel.Text = "Hours Chartered:"
        '
        'PartyTextBox
        '
        Me.PartyTextBox.Location = New System.Drawing.Point(129, 42)
        Me.PartyTextBox.Name = "PartyTextBox"
        Me.PartyTextBox.Size = New System.Drawing.Size(198, 20)
        Me.PartyTextBox.TabIndex = 3
        '
        'HoursTextBox
        '
        Me.HoursTextBox.Location = New System.Drawing.Point(130, 69)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(57, 20)
        Me.HoursTextBox.TabIndex = 4
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(31, 188)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(76, 13)
        Me.TotalLabel.TabIndex = 5
        Me.TotalLabel.Text = "Total Charges:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(130, 185)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LengthComboBox)
        Me.GroupBox1.Controls.Add(Me.YachtLengthLabel)
        Me.GroupBox1.Controls.Add(Me.TypeComboBox)
        Me.GroupBox1.Controls.Add(Me.YachtTypeLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(340, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 156)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type && Length"
        '
        'LengthComboBox
        '
        Me.LengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LengthComboBox.FormattingEnabled = True
        Me.LengthComboBox.Items.AddRange(New Object() {"22", "24", "30", "32", "36", "38", "45"})
        Me.LengthComboBox.Location = New System.Drawing.Point(24, 100)
        Me.LengthComboBox.Name = "LengthComboBox"
        Me.LengthComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LengthComboBox.TabIndex = 3
        '
        'YachtLengthLabel
        '
        Me.YachtLengthLabel.AutoSize = True
        Me.YachtLengthLabel.Location = New System.Drawing.Point(24, 84)
        Me.YachtLengthLabel.Name = "YachtLengthLabel"
        Me.YachtLengthLabel.Size = New System.Drawing.Size(74, 13)
        Me.YachtLengthLabel.TabIndex = 2
        Me.YachtLengthLabel.Text = "Yacht Length:"
        '
        'TypeComboBox
        '
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"Ranger", "Wavelength", "Catalina", "Coronado", "Hobie", "C & C", "Hans Christian", "Excalibur", ""})
        Me.TypeComboBox.Location = New System.Drawing.Point(24, 43)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TypeComboBox.TabIndex = 1
        '
        'YachtTypeLabel
        '
        Me.YachtTypeLabel.AutoSize = True
        Me.YachtTypeLabel.Location = New System.Drawing.Point(21, 27)
        Me.YachtTypeLabel.Name = "YachtTypeLabel"
        Me.YachtTypeLabel.Size = New System.Drawing.Size(65, 13)
        Me.YachtTypeLabel.TabIndex = 0
        Me.YachtTypeLabel.Text = "Yacht &Type:"
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(368, 226)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 8
        Me.OkButton.Text = "&OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(449, 226)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDocumentOne
        '
        '
        'PrintDocumentTwo
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 261)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.HoursTextBox)
        Me.Controls.Add(Me.PartyTextBox)
        Me.Controls.Add(Me.HoursLabel)
        Me.Controls.Add(Me.PartyLabel)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.Text = "Yacht Charter"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintYachtTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearForNextCharterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayCountOfYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartyLabel As System.Windows.Forms.Label
    Friend WithEvents HoursLabel As System.Windows.Forms.Label
    Friend WithEvents PartyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LengthComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents YachtLengthLabel As System.Windows.Forms.Label
    Friend WithEvents TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents YachtTypeLabel As System.Windows.Forms.Label
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocumentOne As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocumentTwo As System.Drawing.Printing.PrintDocument

End Class
