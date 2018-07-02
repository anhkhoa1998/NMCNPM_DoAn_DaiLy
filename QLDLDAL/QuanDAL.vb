
Imports QLDLDTO
Imports Ultility
Imports System.Configuration
Imports System.Data.SqlClient
Public Class QuanDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaQuan(ByRef nextMaQuan As String) As Result

        nextMaQuan = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaQuan] "
        query &= "FROM [QUAN] "
        query &= "ORDER BY [MaQuan] DESC "

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
                            msOnDB = reader("MaQuan")
                        End While
                    End If
                    Dim now As Integer
                    now = Convert.ToInt16(msOnDB) + 1
                    nextMaQuan = Convert.ToString(now)

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Quận kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(quan As QuanDTO) As Result
        Dim query As String = String.Empty
        query &= " INSERT INTO [QUAN] ( [MaQuan] , [TenQuan])"
        query &= " VALUES ( @MaQuan , @TenQuan )"



        Dim nextMaQuan = "1"
        BuildMaQuan(nextMaQuan)
        quan.MaQuan = nextMaQuan

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaQuan", quan.MaQuan)
                    .Parameters.AddWithValue("@TenQuan", quan.TenQuan)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm Quận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function


    Public Function selectAll(ByRef listQuan As List(Of QuanDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaQuan], [TenQuan] "
        query &= " FROM [QUAN] "

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
                        listQuan.Clear()
                        While reader.Read()
                            listQuan.Add(New QuanDTO(reader("MaQuan"), reader("TenQuan")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy danh sách Quận thất bại ", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(MaQuan As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [QUAN] "
        query &= " WHERE "
        query &= " [MaQuan] = @MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaQuan", MaQuan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Quận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(quan As QuanDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [QUAN] SET"
        query &= " [TenQuan] = @TenQuan "
        query &= " WHERE "
        query &= " [MaQuan] = @MaQuan"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaQuan", quan.MaQuan)
                    .Parameters.AddWithValue("@TenQuan", quan.TenQuan)
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
End Class


