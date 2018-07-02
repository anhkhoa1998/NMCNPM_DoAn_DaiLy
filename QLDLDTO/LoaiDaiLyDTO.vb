Public Class LoaiDaiLyDTO
    Private strTenLoaiDaiLy As String
    Private strMaLoaiDaiLy As Integer
    Private strNoToiDa As String
    Public Sub New()
    End Sub

    Public Sub New(TenLoaiDaiLy As String, MaLoaiDaiLy As Integer, NoToiDa As String)
        Me.strTenLoaiDaiLy = TenLoaiDaiLy
        Me.strMaLoaiDaiLy = MaLoaiDaiLy
        Me.strNoToiDa = NoToiDa

    End Sub

    Public Property TenLoaiDaiLy() As String
        Get
            Return strTenLoaiDaiLy
        End Get
        Set(value As String)
            strTenLoaiDaiLy = value
        End Set
    End Property

    Public Property MaLoaiDaiLy() As Integer
        Get
            Return strMaLoaiDaiLy
        End Get
        Set(value As Integer)
            strMaLoaiDaiLy = value
        End Set
    End Property

    Public Property NoToiDa() As String
        Get
            Return strNoToiDa
        End Get
        Set(value As String)
            strNoToiDa = value
        End Set
    End Property
End Class
