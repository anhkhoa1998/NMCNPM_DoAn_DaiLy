Imports QLDLDAL
Imports QLDLDTO
Imports Ultility

Public Class QuanBUS
    Private QuanDAL As QuanDAL

    Public Sub New()
        QuanDAL = New QuanDAL()
    End Sub

    Public Sub New(connectionString As String)
        QuanDAL = New QuanDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef listQuan As List(Of QuanDTO)) As Result
        Return QuanDAL.selectAll(listQuan)
    End Function

    Public Function delete(MaQuan As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return QuanDAL.delete(MaQuan)
    End Function

    Public Function insert(quan As QuanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return QuanDAL.insert(quan)
    End Function

    Public Function isValidName(quan As QuanDTO) As Boolean

        If (quan.TenQuan.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function update(quan As QuanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return QuanDAL.update(quan)
    End Function

    Public Function BuildMaQuan(ByRef nextMaQuan As String) As Result
        Return QuanDAL.BuildMaQuan(nextMaQuan)
    End Function
End Class
