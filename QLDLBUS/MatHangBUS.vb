Imports QLDLDAL
Imports QLDLDTO
Imports Ultility

Public Class MatHangBUS
    Private matHangDAL As MatHangDAL

    Public Sub New()
        matHangDAL = New MatHangDAL()
    End Sub

    Public Sub New(connectionString As String)
        matHangDAL = New MatHangDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef ListMatHang As List(Of MatHangDTO)) As Result
        Return matHangDAL.selectAll(ListMatHang)
    End Function

    Public Function delete(maMatHang As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return matHangDAL.delete(maMatHang)
    End Function

    Public Function insert(matHang As MatHangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return matHangDAL.insert(matHang)
    End Function

    Public Function isValidName(mathang As MatHangDTO) As Boolean
        If (mathang.TenMatHang.Length < 1) Then
            Return False
        End If
        Return True
    End Function


    Public Function update(matHang As MatHangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return matHangDAL.update(matHang)
    End Function

End Class
