Imports QLDLDAL
Imports QLDLDTO
Imports Ultility

Public Class ChiTietPhieuXuatBUS
    Private chitietPhieuDAL As ChiTietPhieuXuatDAL

    Public Sub New()
        chitietPhieuDAL = New ChiTietPhieuXuatDAL()
    End Sub

    Public Sub New(connectionString As String)
        chitietPhieuDAL = New ChiTietPhieuXuatDAL(connectionString)
    End Sub

    Public Function insert(phieuXuat As ChiTietPhieuXuatDTO) As Result

        Return chitietPhieuDAL.insert(phieuXuat)
    End Function

    Public Function selectAll(ByRef ListChiTiet As List(Of ChiTietPhieuXuatDTO)) As Result
        Return chitietPhieuDAL.selectAll(ListChiTiet)
    End Function

    Public Function buildMaChiTiet(ByRef nextMaChiTiet As String) As Result
        Return chitietPhieuDAL.buildMaPhieuXuat(nextMaChiTiet)
    End Function
    Public Function update(phieuXuat As ChiTietPhieuXuatDTO) As Result

        Return chitietPhieuDAL.update(phieuXuat)
    End Function

    Public Function delete(maChiIet As String) As Result

        Return chitietPhieuDAL.delete(maChiIet)
    End Function

End Class
