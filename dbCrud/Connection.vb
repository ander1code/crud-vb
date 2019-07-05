Public Class Connection

    Private Shared conn As SqlClient.SqlConnection

    Public Shared Function Connect() As SqlClient.SqlConnection
        Try
            conn = New SqlClient.SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFileName=|DataDirectory|\dbCrud.mdf;Integrated Security=True;MultipleActiveResultSets=True"
            conn.Open()
            Connect = conn
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
