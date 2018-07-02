Public Class DaiLyDTO
    Private iMaDaiLy As Integer
    Private strTenDaiLy As String
    Private strMaLoaiDaiLy As Integer
    Private strDienThoai As String
    Private strDiaChi As String
    Private strQuan As Integer
    Private dateNgayTiepNhan As DateTime
    Private strEmail As String
    Private strNoCuaDaiLy As String

    Public Sub New()

    End Sub

    Public Sub New(mdl As Integer, tdl As String, mldl As Integer, dt As String, dc As String, qa As Integer, ntn As String, em As String, no As String)
        Me.iMaDaiLy = mdl
        Me.strTenDaiLy = tdl
        Me.strMaLoaiDaiLy = mldl
        Me.strDienThoai = dt
        Me.strDiaChi = dc
        Me.strQuan = qa
        Me.dateNgayTiepNhan = ntn
        Me.strEmail = em
        Me.strNoCuaDaiLy = no
    End Sub

    Public Property MaDaiLy As Integer
        Get
            Return iMaDaiLy
        End Get
        Set(value As Integer)
            iMaDaiLy = value
        End Set
    End Property

    Public Property MaLoaiDaiLy As Integer
        Get
            Return strMaLoaiDaiLy
        End Get
        Set(value As Integer)
            strMaLoaiDaiLy = value
        End Set
    End Property

    Public Property DienThoai As String
        Get
            Return strDienThoai
        End Get
        Set(value As String)
            strDienThoai = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property Quan As Integer
        Get
            Return strQuan
        End Get
        Set(value As Integer)
            strQuan = value
        End Set
    End Property

    Public Property NgayTiepNhan As Date
        Get
            Return dateNgayTiepNhan
        End Get
        Set(value As Date)
            dateNgayTiepNhan = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Public Property NoCuaDaiLy As String
        Get
            Return strNoCuaDaiLy
        End Get
        Set(value As String)
            strNoCuaDaiLy = value
        End Set
    End Property

    Public Property TenDaiLy As String
        Get
            Return strTenDaiLy
        End Get
        Set(value As String)
            strTenDaiLy = value
        End Set
    End Property
End Class
