Public Class ClientPhysicalPerson
    Implements IPerson, IPhysicalPerson, IClient

    Private Property mID As Integer Implements IPerson.Id
    Public Property Id() As Integer
        Get
            Return mID
        End Get
        Set(ByVal value As Integer)
            mID = value
        End Set
    End Property

    Private Property mName As String Implements IPerson.Name
    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property

    Private Property mEmail As String Implements IPerson.Email
    Public Property Email() As String
        Get
            Return mEmail
        End Get
        Set(ByVal value As String)
            mEmail = value
        End Set
    End Property

    Private Property mDateBirth As Date Implements IPhysicalPerson.DateBirth
    Public Property DateBirth() As Date
        Get
            Return mDateBirth
        End Get
        Set(ByVal value As Date)
            mDateBirth = value
        End Set
    End Property

    Private Property mGender As Char Implements IPhysicalPerson.Gender
    Public Property Gender() As Char
        Get
            Return mGender
        End Get
        Set(ByVal value As Char)
            mGender = value
        End Set
    End Property

    Private Property mSalary As Decimal Implements IPhysicalPerson.Salary
    Public Property Salary() As Decimal
        Get
            Return mSalary
        End Get
        Set(ByVal value As Decimal)
            mSalary = value
        End Set
    End Property

    Private Property mStatus As Char Implements IClient.Status
    Public Property Status() As Char
        Get
            Return mStatus
        End Get
        Set(ByVal value As Char)
            mStatus = value
        End Set
    End Property

End Class
