Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility
Public Class QuanLyLoaiDaiLyFrm
    Dim ldlBUS As LoaiDaiLyBUS
    Private Sub QuanLyLoaiDaiLyFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldlBUS = New LoaiDaiLyBUS
        loadlistDaiLy()
    End Sub

    Private Sub loadlistDaiLy()
        Dim listLoaiDaiLy = New List(Of LoaiDaiLyDTO)
        Dim result As Result
        result = ldlBUS.selectAll(listLoaiDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        DgvListLoaiDaiLy.Columns.Clear()
        DgvListLoaiDaiLy.DataSource = Nothing

        DgvListLoaiDaiLy.AutoGenerateColumns = False
        DgvListLoaiDaiLy.AllowUserToAddRows = False
        DgvListLoaiDaiLy.DataSource = listLoaiDaiLy
        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "MaLoaiDL"
        clMaLoai.HeaderText = "Mã Loại"
        clMaLoai.DataPropertyName = "MaLoaiDaiLy"
        DgvListLoaiDaiLy.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TenLoaiDL"
        clTenLoai.HeaderText = "Tên Loại"
        clTenLoai.DataPropertyName = "TenLoaiDaiLy"
        DgvListLoaiDaiLy.Columns.Add(clTenLoai)

        Dim clNoToiDa = New DataGridViewTextBoxColumn()
        clNoToiDa.Name = "NoToiDa"
        clNoToiDa.HeaderText = "Nợ tối đa"
        clNoToiDa.DataPropertyName = "NoToiDa"
        DgvListLoaiDaiLy.Columns.Add(clNoToiDa)
    End Sub

    Private Sub DgvListLoaiDaiLy_SelectionChanged(sender As Object, e As EventArgs) Handles DgvListLoaiDaiLy.SelectionChanged

        Dim currentRowIndex As Integer = DgvListLoaiDaiLy.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < DgvListLoaiDaiLy.RowCount) Then
            Try
                Dim ldl = CType(DgvListLoaiDaiLy.Rows(currentRowIndex).DataBoundItem, LoaiDaiLyDTO)
                TxbMaldl.Text = ldl.MaLoaiDaiLy
                TxbTenldl.Text = ldl.TenLoaiDaiLy
                TxbNoToiDa.Text = ldl.NoToiDa
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub BtnCapNhap_Click(sender As Object, e As EventArgs) Handles BtnCapNhap.Click
        Dim currentRowIndex As Integer = DgvListLoaiDaiLy.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < DgvListLoaiDaiLy.RowCount) Then
            Try

                Dim ldl As LoaiDaiLyDTO
                ldl = New LoaiDaiLyDTO()

                '1. Mapping data from GUI control
                ldl.MaLoaiDaiLy = TxbMaldl.Text
                ldl.TenLoaiDaiLy = TxbTenldl.Text
                ldl.NoToiDa = TxbNoToiDa.Text

                '2. Business .....
                If (ldlBUS.isValidName(ldl) = False) Then
                    MessageBox.Show("Tên Loại đại lý không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxbTenldl.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = ldlBUS.update(ldl)
                If (result.FlagResult = True) Then

                    loadlistDaiLy()

                    DgvListLoaiDaiLy.Rows(currentRowIndex).Selected = True
                    Try
                        ldl = CType(DgvListLoaiDaiLy.Rows(currentRowIndex).DataBoundItem, LoaiDaiLyDTO)
                        TxbMaldl.Text = ldl.MaLoaiDaiLy
                        TxbTenldl.Text = ldl.TenLoaiDaiLy
                        TxbNoToiDa.Text = ldl.NoToiDa
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Loại đại lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật loại đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim currentRowIndex As Integer = DgvListLoaiDaiLy.CurrentCellAddress.Y


        If (-1 < currentRowIndex And currentRowIndex < DgvListLoaiDaiLy.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa loại đại lý có mã: " + TxbMaldl.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = ldlBUS.delete(TxbMaldl.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadlistDaiLy()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= DgvListLoaiDaiLy.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                DgvListLoaiDaiLy.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ldl = CType(DgvListLoaiDaiLy.Rows(currentRowIndex).DataBoundItem, LoaiDaiLyDTO)
                                    TxbMaldl.Text = ldl.MaLoaiDaiLy
                                    TxbTenldl.Text = ldl.TenLoaiDaiLy
                                    TxbNoToiDa.Text = ldl.NoToiDa
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Loại đại lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub TxbNoToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbNoToiDa.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class