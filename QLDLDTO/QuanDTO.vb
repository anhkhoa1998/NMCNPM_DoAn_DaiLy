Public Class QuanDTO
    Private strMaQuan As Integer
    Private strTenQuan As String

    Public Sub New()
    End Sub
    Public Sub New(MaQuan As Integer, TenQuan As String)
        Me.strMaQuan = MaQuan
        Me.strTenQuan = TenQuan
    End Sub

    Public Property MaQuan() As Integer
        Get
            Return strMaQuan
        End Get
        Set(value As Integer)
            strMaQuan = value
        End Set
    End Property

    Public Property TenQuan() As String
        Get
            Return strTenQuan
        End Get
        Set(value As String)
            strTenQuan = value
        End Set
    End Property
End Class
