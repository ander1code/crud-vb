Imports dbCrud

Public Class FrmReport

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list As List(Of ClientPhysicalPerson)
        list = dbCrud.Crud.Get_ClientPhysicalPersonByName("")

        If list.Count > 0 Then
            Me.ClientPhysicalPersonBindingSource.DataSource = list
            Me.ReportViewer1.RefreshReport()
        Else
            MessageBox.Show("No records.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class