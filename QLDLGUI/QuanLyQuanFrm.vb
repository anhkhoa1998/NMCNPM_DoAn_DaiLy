Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility
Public Class QuanLyQuanFrm

    Dim quanBUS As QuanBUS

    Private Sub QuanLyQuanFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        quanBUS = New QuanBUS
        loadListQuan()
    End Sub
    Private Sub loadListQuan()
        Dim ListQuan = New List(Of QuanDTO)
        Dim result As Result
        result = quanBUS.selectAll(ListQuan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        DgvQuan.Columns.Clear()
        DgvQuan.DataSource = Nothing

        DgvQuan.AutoGenerateColumns = False
        DgvQuan.AllowUserToAddRows = False
        DgvQuan.DataSource = ListQuan
        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Mã Quận"
        clMaQuan.DataPropertyName = "MaQuan"
        DgvQuan.Columns.Add(clMaQuan)

        Dim clTenQuan = New DataGridViewTextBoxColumn()
        clTenQuan.Name = "TenQuan"
        clTenQuan.HeaderText = "Tên Quận"
        clTenQuan.DataPropertyName = "TenQuan"
        DgvQuan.Columns.Add(clTenQuan)

    End Sub

    Private Sub DgvQuan_SelectionChanged(sender As Object, e As EventArgs) Handles DgvQuan.SelectionChanged

        Dim currentRowIndex As Integer = DgvQuan.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < DgvQuan.RowCount) Then
            Try
                Dim quan = CType(DgvQuan.Rows(currentRowIndex).DataBoundItem, QuanDTO)
                TxbMaQuan.Text = quan.MaQuan
                TxbTenQuan.Text = quan.TenQuan

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub BtnCapNhap_Click(sender As Object, e As EventArgs) Handles BtnCapNhap.Click
        Dim currentRowIndex As Integer = DgvQuan.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < DgvQuan.RowCount) Then
            Try

                Dim quan As QuanDTO
                quan = New QuanDTO()

                '1. Mapping data from GUI control
                quan.MaQuan = TxbMaQuan.Text
                quan.TenQuan = TxbTenQuan.Text


                '2. Business .....
                If (quanBUS.isValidName(quan) = False) Then
                    MessageBox.Show("Tên Quận không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxbTenQuan.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = quanBUS.update(quan)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListQuan()
                    ' Hightlight the row has been updated on table
                    DgvQuan.Rows(currentRowIndex).Selected = True
                    Try
                        quan = CType(DgvQuan.Rows(currentRowIndex).DataBoundItem, QuanDTO)
                        TxbMaQuan.Text = quan.MaQuan
                        TxbTenQuan.Text = quan.TenQuan
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Quận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim currentRowIndex As Integer = DgvQuan.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < DgvQuan.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa quận có mã: " + TxbMaQuan.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = quanBUS.delete(TxbMaQuan.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListQuan()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= DgvQuan.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                DgvQuan.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim quan = CType(DgvQuan.Rows(currentRowIndex).DataBoundItem, QuanDTO)
                                    TxbMaQuan.Text = quan.MaQuan
                                    TxbTenQuan.Text = quan.TenQuan

                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa quận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select

        End If
    End Sub
End Class