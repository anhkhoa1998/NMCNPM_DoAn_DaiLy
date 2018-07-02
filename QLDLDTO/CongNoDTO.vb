Public Class CongNoDTO
    Private iMaDaiLy As Integer
    Private strNoDau As String
    Private strNoPhatSinh As String
    Private strNoCuoi As String


    Public Sub New()

    End Sub

    Public Sub New(MaDaiLy As String, NoDau As String, NoPhatSinh As String)
        Me.iMaDaiLy = MaDaiLy
        Me.strNoDau = NoDau
        Me.strNoPhatSinh = NoPhatSinh
        Me.strNoCuoi = Convert.ToInt32(strNoDau) + Convert.ToInt32(strNoPhatSinh)

    End Sub


    Public Property MaDaiLy As Integer
        Get
            Return iMaDaiLy
        End Get
        Set(value As Integer)
            iMaDaiLy = value
        End Set
    End Property

    Public Property NoDau As String
        Get
            Return strNoDau
        End Get
        Set(value As String)
            strNoDau = value
        End Set
    End Property

    Public Property NoPhatSinh As String
        Get
            Return strNoPhatSinh
        End Get
        Set(value As String)
            strNoPhatSinh = value
        End Set
    End Property

    Public Property NoCuoi As String
        Get
            Return strNoCuoi
        End Get
        Set(value As String)
            strNoCuoi = value
        End Set
    End Property
End Class
