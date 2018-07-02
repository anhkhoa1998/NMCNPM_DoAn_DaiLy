Public Class ChiTietPhieuXuatDTO
    Private strMaChiTietPhieuXuat As String
    Private iMaPhieuXuat As Integer
    Private strMaMatHang As String
    Private strMaDonViTinh As String
    Private iSoLuongXuat As Integer
    Private strDonGiaXuat As String
    Private strThanhTien As String

    Public Sub New()

    End Sub
    Public Sub New(MaChiTietPhieuXuat As String, MaPhieuXuat As Integer, MaMatHang As String, MaDonViTinh As String, SoLuongXuat As Integer, DonGiaXuat As String, ThanhTien As String)
        Me.strMaChiTietPhieuXuat = MaChiTietPhieuXuat
        Me.iMaPhieuXuat = MaPhieuXuat
        Me.strMaMatHang = MaMatHang
        Me.strMaDonViTinh = MaDonViTinh
        Me.iSoLuongXuat = SoLuongXuat
        Me.strDonGiaXuat = DonGiaXuat
        Me.strThanhTien = ThanhTien
    End Sub

    Public Property MaChiTietPhieuXuat As String
        Get
            Return strMaChiTietPhieuXuat
        End Get
        Set(value As String)
            strMaChiTietPhieuXuat = value
        End Set
    End Property

    Public Property MaPhieuXuat As Integer
        Get
            Return iMaPhieuXuat
        End Get
        Set(value As Integer)
            iMaPhieuXuat = value
        End Set
    End Property

    Public Property MaMatHang As String
        Get
            Return strMaMatHang
        End Get
        Set(value As String)
            strMaMatHang = value
        End Set
    End Property

    Public Property MaDonViTinh As String
        Get
            Return strMaDonViTinh
        End Get
        Set(value As String)
            strMaDonViTinh = value
        End Set
    End Property

    Public Property SoLuongXuat As Integer
        Get
            Return iSoLuongXuat
        End Get
        Set(value As Integer)
            iSoLuongXuat = value
        End Set
    End Property

    Public Property DonGiaXuat As String
        Get
            Return strDonGiaXuat
        End Get
        Set(value As String)
            strDonGiaXuat = value
        End Set
    End Property

    Public Property ThanhTien As String
        Get
            Return strThanhTien
        End Get
        Set(value As String)
            strThanhTien = value
        End Set
    End Property
End Class
