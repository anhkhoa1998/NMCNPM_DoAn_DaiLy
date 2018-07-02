Imports QLDLDTO
Imports Ultility
Imports System.Configuration
Imports System.Data.SqlClient

Public Class PhieuThuDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaPhieuThu(ByRef MaPhieuThu As Integer) As Result


        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaPhieuThu] "
        query &= "FROM [PHIEUTHU] "
        query &= "ORDER BY [MaPhieuThu] DESC "

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
                            msOnDB = reader("MaPhieuThu")
                        End While
                    End If
                    MaPhieuThu = Convert.ToInt32(msOnDB) + 1

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Phiếu Thu kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(phieuThu As PhieuThuDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [PHIEUTHU] ( [MaPhieuThu] , [MaDaiLy], [NgayThuTien], [SoTienThu] )"
        query &= " VALUES ( @MaPhieuThu , @MaDaiLy , @NgayThuTien , @SoTienThu )"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuThu", phieuThu.MaPhieuThu)
                    .Parameters.AddWithValue("@MaDaiLy", phieuThu.MaDaiLy)
                    .Parameters.AddWithValue("@NgayThuTien", phieuThu.NgayThuTien)
                    .Parameters.AddWithValue("@SoTienThu", phieuThu.SoTienThu)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm Phiếu Thu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef ListPhieuThu As List(Of PhieuThuDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaPhieuThu] , [MaDaiLy], [NgayThuTien], [SoTienThu] "
        query &= " FROM [PHIEUTHU] "

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
                        ListPhieuThu.Clear()
                        While reader.Read()
                            ListPhieuThu.Add(New PhieuThuDTO(reader("MaPhieuThu"), reader("MaDaiLy"), reader("NgayThuTien"), reader("SoTienThu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy danh sách Phiếu Thu thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(MaPhieuThu As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [PHIEUTHU] "
        query &= " WHERE "
        query &= " [MaPhieuThu] = @MaPhieuThu "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuThu", MaPhieuThu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Phiếu Thu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(phieuThu As PhieuThuDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [PHIEUTHU] SET"
        query &= " [MaDaiLy] = @MaDaiLy"
        query &= " ,[NgayThuTien] = @NgayThuTien "
        query &= " ,[SoTienThu] = @SoTienThu "
        query &= " WHERE "
        query &= " [MaPhieuThu] = @MaPhieuThu"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", phieuThu.MaDaiLy)
                    .Parameters.AddWithValue("@NgayThuTien", phieuThu.NgayThuTien)
                    .Parameters.AddWithValue("@SoTienThu", phieuThu.SoTienThu)
                    .Parameters.AddWithValue("@MaPhieuThu", phieuThu.MaPhieuThu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Phiếu Thu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
