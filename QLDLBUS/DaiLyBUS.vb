Imports QLDLDAL
Imports QLDLDTO
Imports Ultility
Public Class DaiLyBUS
    Private dailyDAL As DaiLyDAL

    Public Sub New()
        dailyDAL = New DaiLyDAL()
    End Sub

    Public Sub New(connectionString As String)
        dailyDAL = New DaiLyDAL(connectionString)
    End Sub

    Public Function isValidName(daily As DaiLyDTO) As Boolean
        If (daily.TenDaiLy.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function insert(daily As DaiLyDTO) As Result

        Return dailyDAL.insert(daily)
    End Function

    Public Function selectAll(ByRef ListDaiLy As List(Of DaiLyDTO)) As Result
        Return dailyDAL.selectAll(ListDaiLy)
    End Function

    Public Function buildMadl(ByRef nextMaDL As String) As Result
        Return dailyDAL.buildMaDL(nextMaDL)
    End Function
    Public Function update(daily As DaiLyDTO) As Result

        Return dailyDAL.update(daily)
    End Function

    Public Function delete(madl As String) As Result

        Return dailyDAL.delete(madl)
    End Function



    Public Function count(ByRef soluong As String, maquan As String) As Result
        Return dailyDAL.CountQuan(soluong, maquan)
    End Function


End Class
