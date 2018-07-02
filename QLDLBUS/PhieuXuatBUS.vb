Imports QLDLDAL
Imports QLDLDTO
Imports Ultility

Public Class PhieuXuatBUS
    Private phieuXuatDAL As PhieuXuatDAL
    Public Sub New()
        phieuXuatDAL = New PhieuXuatDAL()
    End Sub

    Public Sub New(connectionString As String)
        phieuXuatDAL = New PhieuXuatDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef ListPhieuXuat As List(Of PhieuXuatDTO)) As Result
        Return phieuXuatDAL.selectAll(ListPhieuXuat)
    End Function

    Public Function delete(maPhieuXuat As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuXuatDAL.delete(maPhieuXuat)
    End Function

    Public Function insert(phieuXuat As PhieuXuatDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuXuatDAL.insert(phieuXuat)
    End Function


    Public Function update(phieuXuat As PhieuXuatDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuXuatDAL.update(phieuXuat)
    End Function

    Public Function buildmaPhieuXuat(ByRef nextmaPhieuXuat As String) As Result
        Return phieuXuatDAL.BuildMaPhieuXuat(nextmaPhieuXuat)
    End Function

    Public Function Sum(ByRef ListPhieuXuat As List(Of DoanhSoDTO), thang As String) As Result
        Return phieuXuatDAL.SumTongTriGia(ListPhieuXuat, thang)
    End Function

    Public Function CongNo(ByRef ListCongNo As List(Of CongNoDTO), thang As String) As Result
        Return phieuXuatDAL.CongNo(ListCongNo, thang)
    End Function

End Class
