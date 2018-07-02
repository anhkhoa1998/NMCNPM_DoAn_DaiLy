Public Class MatHangDTO
    Private strMaMatHang As String
    Private strTenMatHang As String
    Private iSoLuongTon As Integer
    Private iDonGiaBan As Integer

    Public Sub New()

    End Sub

    Public Sub New(MaMatHang As String, TenMatHang As String, SoLuongTon As Integer, DonGiaBan As Integer)
        Me.strMaMatHang = MaMatHang
        Me.strTenMatHang = TenMatHang
        Me.iSoLuongTon = SoLuongTon
        Me.iDonGiaBan = DonGiaBan
    End Sub
    Public Property MaMatHang As String
        Get
            Return strMaMatHang
        End Get
        Set(value As String)
            strMaMatHang = value
        End Set
    End Property

    Public Property TenMatHang As String
        Get
            Return strTenMatHang
        End Get
        Set(value As String)
            strTenMatHang = value
        End Set
    End Property

    Public Property SoLuongTon As Integer
        Get
            Return iSoLuongTon
        End Get
        Set(value As Integer)
            iSoLuongTon = value
        End Set
    End Property

    Public Property DonGiaBan As Integer
        Get
            Return iDonGiaBan
        End Get
        Set(value As Integer)
            iDonGiaBan = value
        End Set
    End Property
End Class
