Imports System.Net.Mail
Imports dbCrud

Public Class FrmReg

    Public mId As Integer

    Private Sub FrmRegCpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BeginForm()
    End Sub

    Private Sub BeginForm()
        If mId = 0 Then
            txtName.Clear()
            txtEmail.Clear()
            txtSalary.Clear()
            dpDateBirth.Value = Date.Now.AddYears(-18)
            cmbGender.SelectedIndex = 0
            cmbStatus.SelectedIndex = 0
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnInsert.Enabled = True
            txtName.Focus()
        Else
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnInsert.Enabled = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim opc As MsgBoxResult
        opc = MessageBox.Show("Do you close the application?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If opc = vbOK Then
            Close()
        End If
    End Sub

    Private Sub txtEmail_Validated(sender As Object, e As EventArgs) Handles txtEmail.Validated
        If txtEmail.Text <> String.Empty Then
            If Not (ValidEmail(txtEmail.Text)) Then
                MessageBox.Show("Invalid Email.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtEmail.Focus()
            End If
        End If
    End Sub

    Public Sub SetRecordsForEdit(id As Integer, name As String, email As String, salary As Decimal, dateBirth As Date, gender As Char, status As Char)
        mId = id
        txtName.Text = name
        txtEmail.Text = email
        txtSalary.Text = salary
        dpDateBirth.Value = dateBirth

        If gender = "M" Then
            cmbGender.SelectedIndex = 0
        Else
            cmbGender.SelectedIndex = 1
        End If

        If status = "A" Then
            cmbGender.SelectedIndex = 0
        Else
            cmbGender.SelectedIndex = 1
        End If

        btnInsert.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        txtName.Focus()
    End Sub

    Private Function ValidEmail(email As String) As Boolean
        Try
            Dim mail As New MailAddress(email)
            ValidEmail = True
        Catch ex As Exception
            ValidEmail = False
        End Try
    End Function

    Private Sub dpDateBirth_Validated(sender As Object, e As EventArgs) Handles dpDateBirth.Validated
        If dpDateBirth.Value > Date.Now.AddYears(-18) Then
            MessageBox.Show("Invalid Date Of Birth.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dpDateBirth.Value = Date.Now.AddYears(-18)
            dpDateBirth.Focus()
        End If
    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged
        If txtSalary.Text <> String.Empty Then
            Try
                Convert.ToDecimal(txtSalary.Text)
            Catch ex As Exception
                txtSalary.Clear()
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim frm As New FrmSearch(Me)
        frm.ShowDialog(Me)
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Dim frm As New FrmReport
        frm.ShowDialog(Me)
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim gender As String
        Dim status As String

        If TestEmptyField() Then
            If cmbGender.Text = "Male" Then
                gender = "M"
            Else
                gender = "F"
            End If

            If cmbStatus.Text = "Active" Then
                status = "A"
            Else
                status = "I"
            End If

            If Crud.Insert_PhysicalPerson(txtName.Text, txtEmail.Text, txtSalary.Text, dpDateBirth.Value, gender, status) = 1 Then
                MessageBox.Show("Registered successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BeginForm()
            Else
                MessageBox.Show("Error registering.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("One or more fields are empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function TestEmptyField() As Boolean
        Dim res As Boolean
        If txtName.Text <> String.Empty Then
            If txtEmail.Text <> String.Empty Then
                If txtSalary.Text <> String.Empty Then
                    res = True
                Else
                    res = False
                End If
            Else
                res = False
            End If
        Else
            res = False
        End If
        TestEmptyField = res
    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim opc As MsgBoxResult
        opc = MessageBox.Show("Do you want to edit this record?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If opc = vbOK Then
            Dim gender As String
            Dim status As String

            If TestEmptyField() Then
                If cmbGender.Text = "Male" Then
                    gender = "M"
                Else
                    gender = "F"
                End If

                If cmbStatus.Text = "Active" Then
                    status = "A"
                Else
                    status = "I"
                End If

                If Crud.Edit_PhysicalPerson(mId, txtName.Text, txtEmail.Text, txtSalary.Text, dpDateBirth.Value, gender, status) = 1 Then
                    MessageBox.Show("Edited successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BeginForm()
                Else
                    MessageBox.Show("Error while editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("One or more fields are empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim opc As MsgBoxResult
        opc = MessageBox.Show("Do you want to delete this record?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If opc = vbOK Then
            Dim ret As Integer
            ret = Crud.Delete_ClientPhysicalPerson(mId)

            If ret = 1 Then
                MessageBox.Show("Excluded successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mId = 0
                BeginForm()
            ElseIf ret = 0 Then
                MessageBox.Show("Exclusion aborted." & vbCrLf & "This client has registered cars.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Error while editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        mId = 0
        BeginForm()
    End Sub

End Class