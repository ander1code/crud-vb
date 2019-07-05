Public Class FrmSearch

    Private mFrmReg As FrmReg

    Public Sub New(frmReg As FrmReg)
        InitializeComponent()
        mFrmReg = frmReg
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub txtData_TextChanged(sender As Object, e As EventArgs) Handles txtData.TextChanged
        If rdByID.Checked Then
            If txtData.Text <> "" Then
                Try
                    Convert.ToInt32(txtData.Text)
                Catch ex As Exception
                    txtData.Clear()
                End Try
            End If
        End If
    End Sub

    Private Sub rdByName_CheckedChanged(sender As Object, e As EventArgs) Handles rdByName.CheckedChanged
        txtData.Clear()
        txtData.Focus()
        DataGridView1.Visible = False
    End Sub

    Private Sub rdByID_CheckedChanged(sender As Object, e As EventArgs) Handles rdByID.CheckedChanged
        txtData.Clear()
        txtData.Focus()
        DataGridView1.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If rdByID.Checked Then
            If txtData.Text <> String.Empty Then
                DataGridView1.DataSource = dbCrud.Crud.Get_ClientPhysicalPersonByID(Convert.ToInt32(txtData.Text))
                If DataGridView1.RowCount > 0 Then
                    DataGridView1.Visible = True
                Else
                    MessageBox.Show("No records found with this search criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtData.Clear()
                    txtData.Focus()
                    DataGridView1.Visible = False
                End If
            Else
                MessageBox.Show("Enter an ID to search.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtData.Focus()
            End If
        Else
            DataGridView1.DataSource = dbCrud.Crud.Get_ClientPhysicalPersonByName(txtData.Text)
            If DataGridView1.RowCount > 0 Then
                DataGridView1.Visible = True
            Else
                MessageBox.Show("No records found with this search criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.Visible = False
                txtData.Clear()
                txtData.Focus()
                DataGridView1.Visible = False
            End If
        End If
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim name As String
        Dim email As String
        Dim id As Integer
        Dim dateBirth As Date
        Dim gender As Char
        Dim status As Char
        Dim salary As Decimal

        id = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value)
        name = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        email = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        dateBirth = Convert.ToDateTime(DataGridView1.SelectedRows(0).Cells(3).Value)
        gender = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()(0)
        salary = Convert.ToDecimal(DataGridView1.SelectedRows(0).Cells(5).Value)
        status = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()(0)
        mFrmReg.SetRecordsForEdit(id, name, email, salary, dateBirth, gender, status)
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class