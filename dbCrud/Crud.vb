Public Class Crud

    Public Shared Function Insert_PhysicalPerson(name As String, email As String, salary As Decimal, dateBirth As Date, gender As Char, status As Char) As Integer
        Dim cpp As New ClientPhysicalPerson
        Dim ctr As Controller
        cpp.Name = name
        cpp.Email = email
        cpp.Salary = salary
        cpp.DateBirth = dateBirth
        cpp.Gender = gender
        cpp.Status = status
        ctr = New Controller(cpp)
        Insert_PhysicalPerson = ctr.Insert_ClientPhysicalPerson()
    End Function

    Public Shared Function Edit_PhysicalPerson(id As Integer, name As String, email As String, salary As Decimal, dateBirth As Date, gender As Char, status As Char) As Integer
        Dim cpp As New ClientPhysicalPerson
        Dim ctr As Controller
        cpp.Id = id
        cpp.Name = name
        cpp.Email = email
        cpp.Salary = salary
        cpp.DateBirth = dateBirth
        cpp.Gender = gender
        cpp.Status = status
        ctr = New Controller(cpp)
        Edit_PhysicalPerson = ctr.Edit_ClientPhysicalPerson()
    End Function

    Public Shared Function Delete_ClientPhysicalPerson(id As Integer) As Integer
        Dim cpp As New ClientPhysicalPerson
        Dim ctr As Controller
        cpp.Id = id
        ctr = New Controller(cpp)
        Delete_ClientPhysicalPerson = ctr.Delete_ClientPhysicalPerson
    End Function

    Public Shared Function Get_ClientPhysicalPersonByName(name As String) As List(Of ClientPhysicalPerson)
        Dim cpp As New ClientPhysicalPerson
        Dim ctr As Controller
        cpp.Name = name
        ctr = New Controller(cpp)
        Get_ClientPhysicalPersonByName = ctr.GetClientPhysicalPersonByName
    End Function

    Public Shared Function Get_ClientPhysicalPersonByID(id As Integer) As List(Of ClientPhysicalPerson)
        Dim cpp As New ClientPhysicalPerson
        Dim ctr As Controller
        cpp.Id = id
        ctr = New Controller(cpp)
        Get_ClientPhysicalPersonByID = ctr.GetClientPhysicalPersonByID
    End Function
End Class
