Public Class DoanhSoDTO


    Private iMaDaiLy As String
    Private iTongSoPhieuXuat As String
    Private iTongTriGia As String


    Public Sub New()

    End Sub

    Public Sub New(MaDaiLy As String, TongSoPhieuXuat As String, TongTriGia As String)


        Me.iMaDaiLy = MaDaiLy
        Me.iTongSoPhieuXuat = TongSoPhieuXuat
        Me.iTongTriGia = TongTriGia

    End Sub





    Public Property MaDaiLy As String
        Get
            Return iMaDaiLy
        End Get
        Set(value As String)
            iMaDaiLy = value
        End Set
    End Property

    Public Property TongSoPhieuXuat As String
        Get
            Return iTongSoPhieuXuat
        End Get
        Set(value As String)
            iTongSoPhieuXuat = value
        End Set
    End Property

    Public Property TongTriGia As String
        Get
            Return iTongTriGia
        End Get
        Set(value As String)
            iTongTriGia = value
        End Set
    End Property
End Class
