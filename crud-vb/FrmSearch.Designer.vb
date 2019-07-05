<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.rdByID = New System.Windows.Forms.RadioButton()
        Me.rdByName = New System.Windows.Forms.RadioButton()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblCriteria = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fieldName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateBirth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(106, 31)
        Me.lblTitle.TabIndex = 39
        Me.lblTitle.Text = "Search"
        '
        'txtData
        '
        Me.txtData.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtData.Location = New System.Drawing.Point(18, 112)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(450, 29)
        Me.txtData.TabIndex = 35
        '
        'rdByID
        '
        Me.rdByID.AutoSize = True
        Me.rdByID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdByID.Location = New System.Drawing.Point(587, 58)
        Me.rdByID.Name = "rdByID"
        Me.rdByID.Size = New System.Drawing.Size(76, 28)
        Me.rdByID.TabIndex = 42
        Me.rdByID.Text = "By ID"
        Me.rdByID.UseVisualStyleBackColor = True
        '
        'rdByName
        '
        Me.rdByName.AutoSize = True
        Me.rdByName.Checked = True
        Me.rdByName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdByName.Location = New System.Drawing.Point(469, 58)
        Me.rdByName.Name = "rdByName"
        Me.rdByName.Size = New System.Drawing.Size(112, 28)
        Me.rdByName.TabIndex = 43
        Me.rdByName.TabStop = True
        Me.rdByName.Text = "By Name"
        Me.rdByName.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(12, 78)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(76, 31)
        Me.lblData.TabIndex = 44
        Me.lblData.Text = "Data"
        '
        'lblCriteria
        '
        Me.lblCriteria.AutoSize = True
        Me.lblCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriteria.Location = New System.Drawing.Point(463, 24)
        Me.lblCriteria.Name = "lblCriteria"
        Me.lblCriteria.Size = New System.Drawing.Size(110, 31)
        Me.lblCriteria.TabIndex = 45
        Me.lblCriteria.Text = "Criteria"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSearch.Location = New System.Drawing.Point(484, 111)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(180, 30)
        Me.btnSearch.TabIndex = 46
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.fieldName, Me.dateBirth, Me.salary, Me.gender, Me.email, Me.Status})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(645, 353)
        Me.DataGridView1.TabIndex = 47
        Me.DataGridView1.Visible = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ID.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID.HeaderText = "Id"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'fieldName
        '
        Me.fieldName.DataPropertyName = "name"
        Me.fieldName.HeaderText = "Name"
        Me.fieldName.Name = "fieldName"
        Me.fieldName.ReadOnly = True
        Me.fieldName.Width = 320
        '
        'dateBirth
        '
        Me.dateBirth.DataPropertyName = "dateBirth"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dateBirth.DefaultCellStyle = DataGridViewCellStyle4
        Me.dateBirth.HeaderText = "Date Of Birth"
        Me.dateBirth.Name = "dateBirth"
        Me.dateBirth.ReadOnly = True
        Me.dateBirth.Width = 220
        '
        'salary
        '
        Me.salary.DataPropertyName = "salary"
        Me.salary.HeaderText = "Salary"
        Me.salary.Name = "salary"
        Me.salary.ReadOnly = True
        Me.salary.Visible = False
        '
        'gender
        '
        Me.gender.DataPropertyName = "gender"
        Me.gender.HeaderText = "Gender"
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        Me.gender.Visible = False
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Visible = False
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Visible = False
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(684, 512)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblCriteria)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.rdByName)
        Me.Controls.Add(Me.rdByID)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtData)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents rdByID As System.Windows.Forms.RadioButton
    Friend WithEvents rdByName As System.Windows.Forms.RadioButton
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblCriteria As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fieldName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateBirth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
