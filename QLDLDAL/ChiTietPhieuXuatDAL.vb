Imports QLDLDTO
Imports Ultility
Imports System.Configuration
Imports System.Data.SqlClient
Public Class ChiTietPhieuXuatDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaPhieuXuat(ByRef nextMaDL As Integer) As Result


        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaChiTietPhieuXuat] "
        query &= "FROM [PHIEUXUAT] "
        query &= "ORDER BY [MaChiTietPhieuXuat] DESC "

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
                            msOnDB = reader("MaChiTietPhieuXuat")
                        End While
                    End If
                    nextMaDL = Convert.ToInt32(msOnDB) + 1

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Phiếu Xuất kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(phieuXuat As ChiTietPhieuXuatDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [CHITIETPHIEUXUAT] ([MaChiTietPhieuXuat] , [MaPhieuXuat] , [MaMatHang] , [MaDonViTinh] , [SoLuongXuat] , [DonGiaXuat] ,[ThanhTien] ) "
        query &= " VALUES (@MaChiTietPhieuXuat,@MaPhieuXuat,@MaMatHang,@MaDonViTinh,@SoLuongXuat,@DonGiaXuat,@ThanhTien)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaChiTietPhieuXuat", phieuXuat.MaChiTietPhieuXuat)
                    .Parameters.AddWithValue("@MaPhieuXuat", phieuXuat.MaPhieuXuat)
                    .Parameters.AddWithValue("@MaMatHang", phieuXuat.MaMatHang)
                    .Parameters.AddWithValue("@MaDonViTinh", phieuXuat.MaDonViTinh)
                    .Parameters.AddWithValue("@SoLuongXuat", phieuXuat.SoLuongXuat)
                    .Parameters.AddWithValue("@DonGiaXuat", phieuXuat.DonGiaXuat)
                    .Parameters.AddWithValue("@ThanhTien", phieuXuat.ThanhTien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, " Thêm Chi Tiết Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef ListChiTietPhieuXuat As List(Of ChiTietPhieuXuatDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaChiTietPhieuXuat] , [MaPhieuXuat] , [MaMatHang] , [MaDonViTinh] , [SoLuongXuat] , [DonGiaXuat] ,[ThanhTien] "
        query &= " FROM [CHITIETPHIEUXUAT]"

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
                        ListChiTietPhieuXuat.Clear()
                        While reader.Read()
                            ListChiTietPhieuXuat.Add(New ChiTietPhieuXuatDTO(reader("MaChiTietPhieuXuat"), reader("MaPhieuXuat"), reader("MaMatHang"), reader("MaDonViTinh"), reader("SoLuongXuat"), reader("DonGiaXuat"), reader("ThanhTien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy danh sách Chi Tiết Phiếu Xuất thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function update(phieuXuat As ChiTietPhieuXuatDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [CHITIETPHIEUXUAT] SET"
        query &= " [MaPhieuXuat] = @MaPhieuXuat "
        query &= " ,[MaMatHang] = @MaMatHang "
        query &= " ,[MaDonViTinh] = @MaDonViTinh "
        query &= " ,[SoLuongXuat] = @SoLuongXuat "
        query &= ",[DonGiaXuat] = @DonGiaXuat"
        query &= ",[ThanhTien] = @ThanhTien"
        query &= " WHERE "
        query &= " [MaChiTietPhieuXuat] = @MaChiTietPhieuXuat"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaChiTietPhieuXuat", phieuXuat.MaChiTietPhieuXuat)
                    .Parameters.AddWithValue("@MaPhieuXuat", phieuXuat.MaPhieuXuat)
                    .Parameters.AddWithValue("@MaMatHang", phieuXuat.MaMatHang)
                    .Parameters.AddWithValue("@MaDonViTinh", phieuXuat.MaDonViTinh)
                    .Parameters.AddWithValue("@SoLuongXuat", phieuXuat.SoLuongXuat)
                    .Parameters.AddWithValue("@DonGiaXuat", phieuXuat.DonGiaXuat)
                    .Parameters.AddWithValue("@ThanhTien", phieuXuat.ThanhTien)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Chi Tiết Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maChiTiet As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [CHITIETPHIEUXUAT] "
        query &= " WHERE "
        query &= " [MaChiTietPhieuXuat] = @MaChiTietPhieuXuat "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaChiTietPhieuXuat", maChiTiet)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Chi Tiết Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
