Imports QLDLDTO
Imports Ultility
Imports System.Configuration
Imports System.Data.SqlClient

Public Class DonViTinhDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(dvt As DonViTinhDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [DONVITINH] ( [MaDonViTinh] , [TenDonViTinh])"
        query &= " VALUES ( @MaDonViTinh , @TenDonViTinh )"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDonViTinh", dvt.MaDonViTinh)
                    .Parameters.AddWithValue("@TenDonViTinh", dvt.TenDonViTinh)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm Đơn Vị Tính không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef ListDonViTinh As List(Of DonViTinhDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaDonViTinh], [TenDonViTinh] "
        query &= " FROM [DONVITINH] "

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
                        ListDonViTinh.Clear()
                        While reader.Read()
                            ListDonViTinh.Add(New DonViTinhDTO(reader("MaDonViTinh"), reader("TenDonViTinh")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy danh sách Đơn Vị Tính thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(maDVT As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [DONVITINH] "
        query &= " WHERE "
        query &= " [MaDonViTinh] = @MaDonViTinh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDonViTinh", maDVT)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Đơn Vị Tính không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(donViTinh As DonViTinhDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [DONVITINH] SET"
        query &= " [TenDonViTinh] = @TenDonViTinh"
        query &= " WHERE "
        query &= " [MaDonViTinh] = @MaDonViTinh"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenDonViTinh", donViTinh.TenDonViTinh)
                    .Parameters.AddWithValue("@MaDonViTinh", donViTinh.MaDonViTinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Đơn Vị Tính không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
