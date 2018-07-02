Imports QLDLDTO
Imports Ultility
Imports System.Configuration
Imports System.Data.SqlClient
Public Class DaiLyDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaDL(ByRef nextMaDL As Integer) As Result


        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaDaiLy] "
        query &= "FROM [DAILY] "
        query &= "ORDER BY [MaDaiLy] DESC "

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
                            msOnDB = reader("MaDaiLy")
                        End While
                    End If
                    nextMaDL = Convert.ToInt32(msOnDB) + 1

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Đại Lý kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(DaiLy As DaiLyDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [DAILY] ([MaDaiLy],[TenDaiLy],[MaLoaiDaiLy],[DienThoai],[DiaChi],[MaQuan],[NgayTiepNhan],[Email],[NoCuaDaiLy]) "
        query &= " VALUES (@MaDaiLy,@TenDaiLy,@MaLoaiDaiLy,@DienThoai,@DiaChi,@MaQuan,@NgayTiepNhan,@Email,@NoCuaDaiLy)"

        Dim nextMadl = "1"
        buildMaDL(nextMadl)
        DaiLy.MaDaiLy = nextMadl

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", DaiLy.MaDaiLy)
                    .Parameters.AddWithValue("@TenDaiLy", DaiLy.TenDaiLy)
                    .Parameters.AddWithValue("@MaLoaiDaiLy", DaiLy.MaLoaiDaiLy)
                    .Parameters.AddWithValue("@DienThoai", DaiLy.DienThoai)
                    .Parameters.AddWithValue("@DiaChi", DaiLy.DiaChi)
                    .Parameters.AddWithValue("@MaQuan", DaiLy.Quan)
                    .Parameters.AddWithValue("@NgayTiepNhan", DaiLy.NgayTiepNhan)
                    .Parameters.AddWithValue("@Email", DaiLy.Email)
                    .Parameters.AddWithValue("@NoCuaDaiLy", DaiLy.NoCuaDaiLy)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, " Thêm Đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef ListDaiLy As List(Of DaiLyDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaDaiLy],[TenDaiLy],[MaLoaiDaiLy],[DienThoai],[DiaChi],[MaQuan],[NgayTiepNhan],[Email],[NoCuaDaiLy] "
        query &= " FROM [DAILY]"

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
                        ListDaiLy.Clear()
                        While reader.Read()
                            ListDaiLy.Add(New DaiLyDTO(reader("MaDaiLy"), reader("TenDaiLy"), reader("MaLoaiDaiLy"), reader("DienThoai"), reader("DiaChi"), reader("MaQuan"), reader("NgayTiepNhan"), reader("Email"), reader("NoCuaDaiLy")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy danh sách Đại lý thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function update(dl As DaiLyDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [DAILY] SET"
        query &= " [MaLoaiDaiLy] = @MaLoaiDaiLy "
        query &= " ,[TenDaiLy] = @TenDaiLy "
        query &= " ,[DiaChi] = @DiaChi "
        query &= " ,[DienThoai] = @DienThoai "
        query &= ",[MaQuan] = @MaQuan"
        query &= ",[Email] = @Email"
        query &= ",[NoCuaDaiLy] = @NoCuaDaiLy"
        query &= " WHERE "
        query &= " [MaDaiLy] = @MaDaiLy"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", dl.MaDaiLy)
                    .Parameters.AddWithValue("@MaLoaiDaiLy", dl.MaLoaiDaiLy)
                    .Parameters.AddWithValue("@TenDaiLy", dl.TenDaiLy)
                    .Parameters.AddWithValue("@DiaChi", dl.DiaChi)
                    .Parameters.AddWithValue("@DienThoai", dl.DienThoai)
                    .Parameters.AddWithValue("@Email", dl.Email)
                    .Parameters.AddWithValue("@NoCuaDaiLy", dl.NoCuaDaiLy)
                    .Parameters.AddWithValue("@MaQuan", dl.Quan)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maDaiLy As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [DAILY] "
        query &= " WHERE "
        query &= " [MaDaiLy] = @MaDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", maDaiLy)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function


    Public Function CountQuan(ByRef soluong As String, maquan As String) As Result
        Dim query As String = String.Empty
        query &= " SELECT COUNT(MaDaiLy) AS SoDaiLy "
        query &= " FROM [DAILY] "
        query &= " WHERE [MaQuan] = @MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaQuan", maquan)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            soluong = reader("SoDaiLy")
                        End While

                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy Số Lượng đại lý trong quận thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

End Class
