Imports QLDLDTO
Imports Ultility
Imports System.Configuration
Imports System.Data.SqlClient
Public Class PhieuXuatDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaPhieuXuat(ByRef nextMaPhieuXuat As String) As Result

        nextMaPhieuXuat = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaPhieuXuat] "
        query &= "FROM [PHIEUXUAT] "
        query &= "ORDER BY [MaPhieuXuat] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("MaPhieuXuat")
                        End While
                    End If
                    Dim now As Integer
                    now = Convert.ToInt16(msOnDB) + 1
                    nextMaPhieuXuat = Convert.ToString(now)

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã Phiếu Xuất kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(phieuXuat As PhieuXuatDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [PHIEUXUAT] ( [MaPhieuXuat] , [MaDaiLy] , [NgayLapPhieu] , [TongTriGia])"
        query &= " VALUES ( @MaPhieuXuat , @MaDaiLy ,@NgayLapPhieu ,@TongTriGia )"



        Dim nextMaPhieuXuat = "1"
        BuildMaPhieuXuat(nextMaPhieuXuat)
        phieuXuat.MaPhieuXuat = nextMaPhieuXuat

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuXuat", phieuXuat.MaPhieuXuat)
                    .Parameters.AddWithValue("@MaDaiLy", phieuXuat.MaDaiLy)
                    .Parameters.AddWithValue("@NgayLapPhieu", phieuXuat.NgayLapPhieu)
                    .Parameters.AddWithValue("@TongTriGia", phieuXuat.TongTriGia)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm phiếu xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef listPhieuXuat As List(Of PhieuXuatDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaPhieuXuat] , [MaDaiLy] , [NgayLapPhieu] , [TongTriGia] "
        query &= " FROM [PHIEUXUAT] "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPhieuXuat.Clear()
                        While reader.Read()
                            listPhieuXuat.Add(New PhieuXuatDTO(reader("MaPhieuXuat"), reader("MaDaiLy"), reader("NgayLapPhieu"), reader("TongTriGia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy danh sách Phiếu Xuất thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(MaPhieuXuat As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [PHIEUXUAT] "
        query &= " WHERE "
        query &= " [MaPhieuXuat] = @MaPhieuXuat "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuXuat", MaPhieuXuat)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(phieuXuat As PhieuXuatDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [PHIEUXUAT] SET"
        query &= " [MaDaiLy] = @MaDaiLy "
        query &= " ,[NgayLapPhieu] = @NgayLapPhieu "
        query &= " ,[TongTrigia] = @TongTrigia "
        query &= " WHERE "
        query &= " [MaPhieuXuat] = @MaPhieuXuat"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", phieuXuat.MaDaiLy)
                    .Parameters.AddWithValue("@NgayLapPhieu", phieuXuat.NgayLapPhieu)
                    .Parameters.AddWithValue("@TongTrigia", phieuXuat.TongTriGia)
                    .Parameters.AddWithValue("@MaPhieuXuat", phieuXuat.MaPhieuXuat)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Quận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function SumTongTriGia(ByRef listBaoCaoDoanhSo As List(Of DoanhSoDTO), thang As String) As Result
        Dim query As String = String.Empty
        query &= " SELECT MaDaiLy,COUNT(MaPhieuXuat) AS TongSoPhieuXuat,SUM(TongTriGia) AS TongTriGia"
        query &= " FROM PHIEUXUAT "
        query &= " WHERE month(NgayLapPhieu) = @Thang"
        query &= " GROUP BY MaDaiLy"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Thang", thang)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBaoCaoDoanhSo.Clear()
                        While reader.Read()
                            listBaoCaoDoanhSo.Add(New DoanhSoDTO(reader("MaDaiLy"), reader("TongSoPhieuXuat"), reader("TongTriGia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy Báo cáo thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function CongNo(ByRef ListBaoCaoCongNo As List(Of CongNoDTO), thang As String) As Result
        Dim query As String = String.Empty
        query &= " Select [DAILY].MaDaiLy,[DAILY].NoCuaDaiLy AS NoDau, TongTriGia AS NoPhatSinh"
        query &= " FROM(SELECT MaDaiLy, COUNT(MaPhieuXuat) As TongSoPhieuXuat, SUM(TongTriGia) AS TongTriGia"
        query &= " From [PHIEUXUAT]"
        query &= " Where Month(NgayLapPhieu) = @Thang"
        query &= " Group By MaDaiLy) As [DOANHSO] inner Join [DAILY] On [DOANHSO].MaDaiLy = [DAILY].MaDaiLy"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Thang", thang)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        ListBaoCaoCongNo.Clear()
                        While reader.Read()
                            ListBaoCaoCongNo.Add(New CongNoDTO(reader("MaDaiLy"), reader("NoDau"), reader("NoPhatSinh")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy Báo cáo thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
    End Function
End Class
