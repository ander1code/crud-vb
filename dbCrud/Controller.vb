Public Class Controller

    Private mCpf As ClientPhysicalPerson
    Private mConn As SqlClient.SqlConnection
    Private mCmd As SqlClient.SqlCommand

    Sub New()
        mConn = Connection.Connect
    End Sub

    Sub New(cpf As ClientPhysicalPerson)
        mCpf = cpf
        mConn = Connection.Connect
    End Sub

#Region "Insert ClientPhysicalPerson"

    Private Function InsertPerson(id As Integer, name As String, email As String) As Integer
        Try
            Dim sql As String
            sql = "INSERT INTO PERSON VALUES(@ID, @NAME, @EMAIL)"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = id
            mCmd.Parameters.Add("@NAME", SqlDbType.VarChar)
            mCmd.Parameters("@NAME").Value = name
            mCmd.Parameters.Add("@EMAIL", SqlDbType.VarChar)
            mCmd.Parameters("@EMAIL").Value = email
            mCmd.ExecuteNonQuery()
            InsertPerson = 1
        Catch ex As Exception
            InsertPerson = -1
        End Try
    End Function

    Private Function InsertPhysicalPerson(id As Integer, salary As Decimal, dateOfBirth As Date, gender As Char) As Integer
        Try
            Dim sql As String
            sql = "INSERT INTO PHYSICALPERSON VALUES(@ID, @ID, @SALARY, @DATEOFBIRTH, @GENDER)"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = id
            mCmd.Parameters.Add("@SALARY", SqlDbType.Decimal)
            mCmd.Parameters("@SALARY").Value = salary
            mCmd.Parameters.Add("@DATEOFBIRTH", SqlDbType.Date)
            mCmd.Parameters("@DATEOFBIRTH").Value = dateOfBirth
            mCmd.Parameters.Add("@GENDER", SqlDbType.Char)
            mCmd.Parameters("@GENDER").Value = gender
            mCmd.ExecuteNonQuery()
            InsertPhysicalPerson = 1
        Catch ex As Exception
            InsertPhysicalPerson = -1
        End Try


    End Function

    Private Function InsertClient(id As Integer, status As Char) As Integer
        Try
            Dim sql As String
            sql = "INSERT INTO CLIENT VALUES(@ID, @STATUSCLI)"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = id
            mCmd.Parameters.Add("@STATUSCLI", SqlDbType.Char)
            mCmd.Parameters("@STATUSCLI").Value = status
            mCmd.ExecuteNonQuery()
            InsertClient = 1
        Catch ex As Exception
            InsertClient = -1
        End Try


    End Function

    Private Function InsertClientPhysicalPerson() As Integer
        Try
            Dim sql As String
            sql = "INSERT INTO CLIENTPHYSICALPERSON VALUES(@ID, @ID, @ID)"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = mCpf.Id
            mCmd.ExecuteNonQuery()
            InsertClientPhysicalPerson = 1
        Catch ex As Exception
            InsertClientPhysicalPerson = -1
        End Try
    End Function

    Private Function GetIdForInsert() As Integer
        Try
            Dim sql As String
            sql = "SELECT ISNULL(MAX(ID) + 1, 1) FROM PERSON"
            mCmd.CommandText = sql
            GetIdForInsert = (CType(mCmd.ExecuteScalar, Integer))
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Insert_ClientPhysicalPerson() As Integer
        Try
            Dim trans As SqlClient.SqlTransaction
            mCmd = New SqlClient.SqlCommand
            mCmd.Connection = mConn
            mCmd.Transaction = mConn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted)
            trans = mCmd.Transaction
            mCpf.Id = GetIdForInsert()

            If (mCpf.Id > 0) Then
                If (InsertPerson(mCpf.Id, mCpf.Name, mCpf.Email) = 1) Then
                    If (InsertPhysicalPerson(mCpf.Id, mCpf.Salary, mCpf.DateBirth, mCpf.Gender) = 1) Then
                        If (InsertClient(mCpf.Id, mCpf.Status) = 1) Then
                            If (InsertClientPhysicalPerson() = 1) Then
                                trans.Commit()
                                Insert_ClientPhysicalPerson = 1
                            Else
                                trans.Rollback()
                                Insert_ClientPhysicalPerson = -1
                            End If
                        Else
                            trans.Rollback()
                            Insert_ClientPhysicalPerson = -1
                        End If
                    Else
                        trans.Rollback()
                        Insert_ClientPhysicalPerson = -1
                    End If
                Else
                    trans.Rollback()
                    Insert_ClientPhysicalPerson = -1
                End If
            Else
                Insert_ClientPhysicalPerson = -1
            End If
        Catch ex As Exception
            Insert_ClientPhysicalPerson = -1
        End Try
    End Function

#End Region


#Region "Edit ClientPhysicalPerson"

    Private Function EditPerson(id As Integer, name As String, email As String) As Integer
        Try
            Dim sql As String
            sql = "UPDATE PERSON SET NAME = @NAME, EMAIL = @EMAIL WHERE ID = @ID"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = id
            mCmd.Parameters.Add("@NAME", SqlDbType.VarChar)
            mCmd.Parameters("@NAME").Value = name
            mCmd.Parameters.Add("@EMAIL", SqlDbType.VarChar)
            mCmd.Parameters("@EMAIL").Value = email
            mCmd.ExecuteNonQuery()
            EditPerson = 1
        Catch ex As Exception
            EditPerson = -1
        End Try
    End Function

    Private Function EditPhysicalPerson(id As Integer, salary As Decimal, dateOfBirth As Date, gender As Char) As Integer
        Try
            Dim sql As String
            sql = "UPDATE PHYSICALPERSON SET SALARY = @SALARY, DATEBIRTH = @DATEBIRTH, GENDER = @GENDER WHERE ID = @ID"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = id
            mCmd.Parameters.Add("@SALARY", SqlDbType.Decimal)
            mCmd.Parameters("@SALARY").Value = salary
            mCmd.Parameters.Add("@DATEBIRTH", SqlDbType.Date)
            mCmd.Parameters("@DATEBIRTH").Value = dateOfBirth
            mCmd.Parameters.Add("@GENDER", SqlDbType.Char)
            mCmd.Parameters("@GENDER").Value = gender
            mCmd.ExecuteNonQuery()
            EditPhysicalPerson = 1
        Catch ex As Exception
            EditPhysicalPerson = -1
        End Try


    End Function

    Private Function EditClient(id As Integer, status As Char) As Integer
        Try
            Dim sql As String
            sql = "UPDATE CLIENT SET STATUSCLI = @STATUSCLI WHERE ID = @ID"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = id
            mCmd.Parameters.Add("@STATUSCLI", SqlDbType.Char)
            mCmd.Parameters("@STATUSCLI").Value = status
            mCmd.ExecuteNonQuery()
            EditClient = 1
        Catch ex As Exception
            EditClient = -1
        End Try


    End Function

    Private Function EditClientPhysicalPerson() As Integer
        Try
            EditClientPhysicalPerson = 1
        Catch ex As Exception
            EditClientPhysicalPerson = -1
        End Try
    End Function

    Public Function Edit_ClientPhysicalPerson() As Integer
        Try
            Dim trans As SqlClient.SqlTransaction
            mCmd = New SqlClient.SqlCommand
            mCmd.Connection = mConn
            mCmd.Transaction = mConn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted)
            trans = mCmd.Transaction

            If (EditPerson(mCpf.Id, mCpf.Name, mCpf.Email) = 1) Then
                If (EditPhysicalPerson(mCpf.Id, mCpf.Salary, mCpf.DateBirth, mCpf.Gender) = 1) Then
                    If (EditClient(mCpf.Id, mCpf.Status) = 1) Then
                        If (EditClientPhysicalPerson() = 1) Then
                            trans.Commit()
                            Edit_ClientPhysicalPerson = 1
                        Else
                            trans.Rollback()
                            Edit_ClientPhysicalPerson = -1
                        End If
                    Else
                        trans.Rollback()
                        Edit_ClientPhysicalPerson = -1
                    End If
                Else
                    trans.Rollback()
                    Edit_ClientPhysicalPerson = -1
                End If
            Else
                trans.Rollback()
                Edit_ClientPhysicalPerson = -1
            End If
        Catch ex As Exception
            Edit_ClientPhysicalPerson = -1
        End Try
    End Function

#End Region



#Region "Delete ClientPhysicalPerson"

    Private Function DeletePerson(id As Integer) As Integer
        Try
            Dim sql As String
            sql = "DELETE FROM PERSON WHERE ID = @ID"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = id
            mCmd.ExecuteNonQuery()
            DeletePerson = 1
        Catch ex As Exception
            DeletePerson = -1
        End Try
    End Function

    Private Function DeletePhysicalPerson(id As Integer) As Integer
        Try
            Dim sql As String
            sql = "DELETE FROM PHYSICALPERSON WHERE ID = @ID"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = id
            mCmd.ExecuteNonQuery()
            DeletePhysicalPerson = 1
        Catch ex As Exception
            DeletePhysicalPerson = -1
        End Try


    End Function

    Private Function DeleteClient(id As Integer) As Integer
        Try
            Dim sql As String
            sql = "DELETE FROM CLIENT WHERE ID = @ID"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = id
            mCmd.ExecuteNonQuery()
            DeleteClient = 1
        Catch ex As Exception
            DeleteClient = -1
        End Try


    End Function

    Private Function DeleteClientPhysicalPerson() As Integer
        Try
            Dim sql As String
            sql = "DELETE FROM CLIENTPHYSICALPERSON WHERE ID = @ID"
            mCmd.Parameters.Clear()
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = mCpf.Id
            mCmd.ExecuteNonQuery()
            DeleteClientPhysicalPerson = 1
        Catch ex As Exception
            DeleteClientPhysicalPerson = -1
        End Try
    End Function

    Public Function Delete_ClientPhysicalPerson() As Integer
        Try
            Dim trans As SqlClient.SqlTransaction
            mCmd = New SqlClient.SqlCommand
            mCmd.Connection = mConn
            mCmd.Transaction = mConn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted)
            trans = mCmd.Transaction

            If (DeleteClientPhysicalPerson() = 1) Then
                If (DeleteClient(mCpf.Id) = 1) Then
                    If (DeletePhysicalPerson(mCpf.Id) = 1) Then
                        If (DeletePerson(mCpf.Id) = 1) Then
                            trans.Commit()
                            Delete_ClientPhysicalPerson = 1
                        Else
                            trans.Rollback()
                            Delete_ClientPhysicalPerson = -1
                        End If
                    Else
                        trans.Rollback()
                        Delete_ClientPhysicalPerson = -1
                    End If
                Else
                    trans.Rollback()
                    Delete_ClientPhysicalPerson = -1
                End If
            Else
                trans.Rollback()
                Delete_ClientPhysicalPerson = -1
            End If

        Catch ex As Exception
            Delete_ClientPhysicalPerson = -1
        End Try
    End Function

#End Region


    Public Function GetClientPhysicalPersonByName() As List(Of ClientPhysicalPerson)
        Try
            Dim cpp As ClientPhysicalPerson
            Dim listCPP As List(Of ClientPhysicalPerson)
            Dim sql As String
            Dim sqr As SqlClient.SqlDataReader

            sql = "SELECT * FROM PERSON INNER JOIN PHYSICALPERSON " &
                  "ON PERSON.ID = PHYSICALPERSON.PERSON_ID INNER JOIN CLIENTPHYSICALPERSON " &
                  "ON CLIENTPHYSICALPERSON.PHYSICALPERSON_ID = PHYSICALPERSON.ID INNER JOIN CLIENT " &
                  "ON CLIENT.ID = CLIENTPHYSICALPERSON.CLIENT_ID " &
                  "WHERE PERSON.NAME LIKE @NAME"

            mCmd = New SqlClient.SqlCommand
            mCmd.Parameters.Clear()
            mCmd.Connection = mConn
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@NAME", SqlDbType.VarChar)
            mCmd.Parameters("@NAME").Value = mCpf.Name + "%"
            sqr = mCmd.ExecuteReader()

            listCPP = New List(Of ClientPhysicalPerson)

            If sqr.HasRows Then
                While sqr.Read()
                    cpp = New ClientPhysicalPerson
                    cpp.Id = sqr.GetInt32(0)
                    cpp.Name = sqr.GetString(1)
                    cpp.Email = sqr.GetString(2)
                    cpp.Salary = sqr.GetDecimal(5)
                    cpp.DateBirth = sqr.GetDateTime(6)
                    cpp.Gender = sqr.GetString(7)(0)
                    cpp.Status = sqr.GetString(12)(0)
                    listCPP.Add(cpp)
                End While
            End If

            sqr.Close()
            GetClientPhysicalPersonByName = listCPP

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetClientPhysicalPersonByID() As List(Of ClientPhysicalPerson)
        Try
            Dim cpp As ClientPhysicalPerson
            Dim listCPP As List(Of ClientPhysicalPerson)
            Dim sql As String
            Dim sqr As SqlClient.SqlDataReader

            sql = "SELECT * FROM PERSON INNER JOIN PHYSICALPERSON " &
                  "ON PERSON.ID = PHYSICALPERSON.PERSON_ID INNER JOIN CLIENTPHYSICALPERSON " &
                  "ON CLIENTPHYSICALPERSON.PHYSICALPERSON_ID = PHYSICALPERSON.ID INNER JOIN CLIENT " &
                  "ON CLIENT.ID = CLIENTPHYSICALPERSON.CLIENT_ID " &
                  "WHERE PERSON.ID = @ID"

            mCmd = New SqlClient.SqlCommand
            mCmd.Parameters.Clear()
            mCmd.Connection = mConn
            mCmd.CommandText = sql
            mCmd.Parameters.Add("@ID", SqlDbType.Int)
            mCmd.Parameters("@ID").Value = mCpf.Id
            sqr = mCmd.ExecuteReader()

            listCPP = New List(Of ClientPhysicalPerson)

            If sqr.HasRows Then
                While sqr.Read()
                    cpp = New ClientPhysicalPerson
                    cpp.Id = sqr.GetInt32(0)
                    cpp.Name = sqr.GetString(1)
                    cpp.Email = sqr.GetString(2)
                    cpp.Salary = sqr.GetDecimal(5)
                    cpp.DateBirth = sqr.GetDateTime(6)
                    cpp.Gender = sqr.GetString(7)(0)
                    cpp.Status = sqr.GetString(12)(0)
                    listCPP.Add(cpp)
                End While
            End If

            sqr.Close()
            GetClientPhysicalPersonByID = listCPP

        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
