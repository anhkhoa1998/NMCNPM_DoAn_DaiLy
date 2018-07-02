Public Class DonViTinhDTO
    Private strMaDonViTinh As String
    Private strTenDonViTinh As String


    Public Sub New()

    End Sub

    Public Sub New(MaDonViTinh As String, TenDonViTinh As String)
        Me.strMaDonViTinh = MaDonViTinh
        Me.strTenDonViTinh = TenDonViTinh
    End Sub

    Public Property MaDonViTinh As String
        Get
            Return strMaDonViTinh
        End Get
        Set(value As String)
            strMaDonViTinh = value
        End Set
    End Property

    Public Property TenDonViTinh As String
        Get
            Return strTenDonViTinh
        End Get
        Set(value As String)
            strTenDonViTinh = value
        End Set
    End Property
End Class
