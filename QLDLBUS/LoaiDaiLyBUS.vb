Imports QLDLDAL
Imports QLDLDTO
Imports Ultility

Public Class LoaiDaiLyBUS
    Private ldlDAL As LoaiDaiLyDAL

    Public Sub New()
        ldlDAL = New LoaiDaiLyDAL()
    End Sub

    Public Sub New(connectionString As String)
        ldlDAL = New LoaiDaiLyDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef listLoaiDaiLy As List(Of LoaiDaiLyDTO)) As Result
        Return ldlDAL.selectAll(listLoaiDaiLy)
    End Function

    Public Function delete(Maldl As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldlDAL.delete(Maldl)
    End Function

    Public Function insert(ldl As LoaiDaiLyDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldlDAL.insert(ldl)
    End Function

    Public Function isValidName(ldl As LoaiDaiLyDTO) As Boolean

        If (ldl.TenLoaiDaiLy.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function update(ldl As LoaiDaiLyDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldlDAL.update(ldl)
    End Function

    Public Function buildMaldl(ByRef nextMaldl As String) As Result
        Return ldlDAL.buildMaldl(nextMaldl)
    End Function


End Class
