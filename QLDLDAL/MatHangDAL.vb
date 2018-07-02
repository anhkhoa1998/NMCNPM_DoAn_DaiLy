Imports QLDLDTO
Imports Ultility
Imports System.Configuration
Imports System.Data.SqlClient

Public Class MatHangDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(mathang As MatHangDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [MATHANG] ( [MaMatHang] , [TenMatHang], [SoLuongTon], [DonGiaBan] )"
        query &= " VALUES ( @MaMatHang , @TenMatHang , @SoLuongTon , @DonGiaBan )"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaMatHang", mathang.MaMatHang)
                    .Parameters.AddWithValue("@TenMatHang", mathang.TenMatHang)
                    .Parameters.AddWithValue("@SoLuongTon", mathang.SoLuongTon)
                    .Parameters.AddWithValue("@DonGiaBan", mathang.DonGiaBan)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm Mặt Hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef listMatHang As List(Of MatHangDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaMatHang] , [TenMatHang], [SoLuongTon], [DonGiaBan] "
        query &= " FROM [MATHANG] "

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
                        listMatHang.Clear()
                        While reader.Read()
                            listMatHang.Add(New MatHangDTO(reader("MaMatHang"), reader("TenMatHang"), reader("SoLuongTon"), reader("DonGiaBan")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy danh sách Mặt Hàng thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function update(matHang As MatHangDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [MATHANG] SET"
        query &= " [TenMatHang] = @TenMatHang "
        query &= " ,[SoLuongTon] = @SoLuongTon "
        query &= ", [DonGiaBan] = @DonGiaBan "
        query &= " WHERE "
        query &= " [MaMatHang] = @MaMatHang"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenMatHang", matHang.TenMatHang)
                    .Parameters.AddWithValue("@SoLuongTon", matHang.SoLuongTon)
                    .Parameters.AddWithValue("@DonGiaBan", matHang.DonGiaBan)
                    .Parameters.AddWithValue("@MaMatHang", matHang.MaMatHang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Mặt hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(MaMatHang As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [MATHANG] "
        query &= " WHERE "
        query &= " [MaMatHang] = @MaMatHang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaMatHang", MaMatHang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Mặt Hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
