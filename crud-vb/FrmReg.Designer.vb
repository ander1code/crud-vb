<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReg
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblDateBirth = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dpDateBirth = New System.Windows.Forms.DateTimePicker()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(65, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(65, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(70, 82)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(520, 29)
        Me.txtName.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(69, 141)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(520, 29)
        Me.txtEmail.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(65, 114)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(62, 24)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(69, 200)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(520, 29)
        Me.txtSalary.TabIndex = 2
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(65, 173)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(67, 24)
        Me.lblSalary.TabIndex = 4
        Me.lblSalary.Text = "Salary"
        '
        'lblDateBirth
        '
        Me.lblDateBirth.AutoSize = True
        Me.lblDateBirth.Location = New System.Drawing.Point(65, 232)
        Me.lblDateBirth.Name = "lblDateBirth"
        Me.lblDateBirth.Size = New System.Drawing.Size(127, 24)
        Me.lblDateBirth.TabIndex = 6
        Me.lblDateBirth.Text = "Date Of Birth"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(65, 291)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(80, 24)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Gender"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'dpDateBirth
        '
        Me.dpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDateBirth.Location = New System.Drawing.Point(69, 259)
        Me.dpDateBirth.Name = "dpDateBirth"
        Me.dpDateBirth.Size = New System.Drawing.Size(520, 29)
        Me.dpDateBirth.TabIndex = 3
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(69, 318)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(520, 32)
        Me.cmbGender.TabIndex = 4
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbStatus.Location = New System.Drawing.Point(70, 380)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(520, 32)
        Me.cmbStatus.TabIndex = 5
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(66, 353)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(66, 24)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Status"
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.Location = New System.Drawing.Point(55, 24)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(172, 31)
        Me.lblRegistration.TabIndex = 15
        Me.lblRegistration.Text = "Registration"
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.SeaGreen
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnInsert.Location = New System.Drawing.Point(470, 450)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(120, 40)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Gray
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.Location = New System.Drawing.Point(344, 450)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 40)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.CadetBlue
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEdit.Location = New System.Drawing.Point(195, 450)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 40)
        Me.btnEdit.TabIndex = 16
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.Location = New System.Drawing.Point(69, 450)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 40)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnClear.Location = New System.Drawing.Point(470, 28)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 30)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'FrmReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(684, 516)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.lblRegistration)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.dpDateBirth)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDateBirth)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.MaximumSize = New System.Drawing.Size(700, 550)
        Me.MinimumSize = New System.Drawing.Size(700, 550)
        Me.Name = "FrmReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents lblDateBirth As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dpDateBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblRegistration As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
