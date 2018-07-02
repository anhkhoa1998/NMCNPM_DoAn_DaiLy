Public Class PhieuXuatDTO
    Private iMaPhieuXuat As Integer
    Private iMaDaiLy As Integer
    Private dateNgayLapPhieu As DateTime
    Private strTongTriGia As String

    Public Sub New()

    End Sub

    Public Sub New(mpx As Integer, madl As Integer, nlp As DateTime, ttg As String)
        Me.iMaPhieuXuat = mpx
        Me.iMaDaiLy = madl
        Me.dateNgayLapPhieu = nlp
        Me.strTongTriGia = ttg
    End Sub

    Public Property MaPhieuXuat As Integer
        Get
            Return iMaPhieuXuat
        End Get
        Set(value As Integer)
            iMaPhieuXuat = value
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

    Public Property NgayLapPhieu As Date
        Get
            Return dateNgayLapPhieu
        End Get
        Set(value As Date)
            dateNgayLapPhieu = value
        End Set
    End Property

    Public Property TongTriGia As String
        Get
            Return strTongTriGia
        End Get
        Set(value As String)
            strTongTriGia = value
        End Set
    End Property
End Class
