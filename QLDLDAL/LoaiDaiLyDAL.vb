Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDLDTO
Imports Ultility
Public Class LoaiDaiLyDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaldl(ByRef nextMaldl As String) As Result

        nextMaldl = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaLoaiDaiLy] "
        query &= "FROM [LOAIDAILY] "
        query &= "ORDER BY [MaLoaiDaiLy] DESC "

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
                            msOnDB = reader("MaLoaiDaiLy")
                        End While
                    End If
                    Dim now As Integer
                    now = Convert.ToInt16(msOnDB) + 1
                    nextMaldl = Convert.ToString(now)

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số loại Lý kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(ldl As LoaiDaiLyDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [LOAIDAILY] ( [MaLoaiDaiLy] , [TenLoaiDaiLy] , [NoToiDa])"
        query &= " VALUES (@MaLoaiDaiLy,@TenLoaiDaiLy,@NoToiDa)"

        Dim nextMaldl = "1"
        buildMaldl(nextMaldl)
        ldl.MaLoaiDaiLy = nextMaldl

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDaiLy", ldl.MaLoaiDaiLy)
                    .Parameters.AddWithValue("@TenLoaiDaiLy", ldl.TenLoaiDaiLy)
                    .Parameters.AddWithValue("@NoToiDa", ldl.NoToiDa)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm Loại đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef listLoaiDaiLy As List(Of LoaiDaiLyDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [TenLoaiDaiLy], [MaLoaiDaiLy],[NoToiDa]"
        query &= " FROM [LOAIDAILY]"

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
                        listLoaiDaiLy.Clear()
                        While reader.Read()
                            listLoaiDaiLy.Add(New LoaiDaiLyDTO(reader("TenLoaiDaiLy"), reader("MaLoaiDaiLy"), reader("NoToiDa")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy danh sách loại Đại lý thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaLoaiDaiLy] "
        query &= "FROM [LOAIDAILY] "
        query &= "ORDER BY [MaLoaiDaiLy] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaLoaiDaiLy")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Loại đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(ldl As LoaiDaiLyDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [LOAIDAILY] SET"
        query &= " [TenLoaiDaiLy] = @TenLoaiDaiLy ,"
        query &= " [NoToiDa] = @NoToiDa "
        query &= " WHERE "
        query &= " [MaLoaiDaiLy] = @MaLoaiDaiLy"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDaiLy", ldl.MaLoaiDaiLy)
                    .Parameters.AddWithValue("@TenLoaiDaiLy", ldl.TenLoaiDaiLy)
                    .Parameters.AddWithValue("@NoToiDa", ldl.NoToiDa)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(LoaiDaiLy As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [LOAIDAILY] "
        query &= " WHERE "
        query &= " [MaLoaiDaiLy] = @MaLoaiDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDaiLy", LoaiDaiLy)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class

