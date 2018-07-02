Imports QLDLDAL
Imports QLDLDTO
Imports Ultility

Public Class PhieuThuBUS
    Private phieuThuDAL As PhieuThuDAL

    Public Sub New()
        phieuThuDAL = New PhieuThuDAL()
    End Sub

    Public Sub New(connectionString As String)
        phieuThuDAL = New PhieuThuDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef listPhieuThu As List(Of PhieuThuDTO)) As Result
        Return phieuThuDAL.selectAll(listPhieuThu)
    End Function

    Public Function delete(maPhieuThu As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuThuDAL.delete(maPhieuThu)
    End Function

    Public Function insert(phieuThu As PhieuThuDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuThuDAL.insert(phieuThu)
    End Function

    Public Function update(phieuThu As PhieuThuDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuThuDAL.update(phieuThu)
    End Function

    Public Function buildMaPhieuThu(ByRef nextphieuThu As String) As Result
        Return phieuThuDAL.buildMaPhieuThu(nextphieuThu)
    End Function
End Class
