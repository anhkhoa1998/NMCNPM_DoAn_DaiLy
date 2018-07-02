Imports QLDLDAL
Imports QLDLDTO
Imports Ultility

Public Class DonViTinhBUS
    Private donViTinhDAL As DonViTinhDAL

    Public Sub New()
        donViTinhDAL = New DonViTinhDAL()
    End Sub

    Public Sub New(connectionString As String)
        donViTinhDAL = New DonViTinhDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef listDonViTinh As List(Of DonViTinhDTO)) As Result
        Return donViTinhDAL.selectAll(listDonViTinh)
    End Function

    Public Function isValidName(dvt As DonViTinhDTO) As Boolean
        If (dvt.TenDonViTinh.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function delete(maDonViTinh As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return donViTinhDAL.delete(maDonViTinh)
    End Function

    Public Function insert(donViTinh As DonViTinhDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return donViTinhDAL.insert(donViTinh)
    End Function

    Public Function update(donViTinh As DonViTinhDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return donViTinhDAL.update(donViTinh)
    End Function
End Class
