Public Class PhieuThuDTO
    Private iMaPhieuThu As String
    Private iMaDaiLy As Integer
    Private dateNgayThuTien As DateTime
    Private strSoTienThu As String

    Public Sub New()

    End Sub

    Public Sub New(MaPhieuThu As String, MaDaiLy As Integer, NgayThuTien As DateTime, SoTienThu As String)
        Me.iMaPhieuThu = MaPhieuThu
        Me.iMaDaiLy = MaDaiLy
        Me.dateNgayThuTien = NgayThuTien
        Me.strSoTienThu = SoTienThu
    End Sub
    Public Property MaPhieuThu As String
        Get
            Return iMaPhieuThu
        End Get
        Set(value As String)
            iMaPhieuThu = value
        End Set
    End Property

    Public Property MaDaiLy As Integer
        Get
            Return iMaDaiLy
        End Get
        Set(value As Integer)
            iMaDaiLy = value
        End Set
    End Property

    Public Property NgayThuTien As Date
        Get
            Return dateNgayThuTien
        End Get
        Set(value As Date)
            dateNgayThuTien = value
        End Set
    End Property

    Public Property SoTienThu As String
        Get
            Return strSoTienThu
        End Get
        Set(value As String)
            strSoTienThu = value
        End Set
    End Property
End Class
