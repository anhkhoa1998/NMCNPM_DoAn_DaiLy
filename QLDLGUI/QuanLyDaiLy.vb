Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility
Public Class QuanLyDaiLy
    Private dailyBus As DaiLyBUS
    Private ldlBUS As LoaiDaiLyBUS
    Private QuanBUS As QuanBUS


    Private Sub QuanLyDaiLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dailyBus = New DaiLyBUS()
        loadListDaiLy()
        loadCb()
    End Sub

    Private Sub loadListDaiLy()
        Dim ListDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dailyBus.selectAll(ListDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        DgvDanhSachDaiLy.Columns.Clear()
        DgvDanhSachDaiLy.DataSource = Nothing

        DgvDanhSachDaiLy.AutoGenerateColumns = False
        DgvDanhSachDaiLy.AllowUserToAddRows = False
        DgvDanhSachDaiLy.DataSource = ListDaiLy

        Dim clMaDaiLy = New DataGridViewTextBoxColumn()
        clMaDaiLy.Name = "MaDaiLy"
        clMaDaiLy.HeaderText = "Mã Đại Lý"
        clMaDaiLy.DataPropertyName = "MaDaiLy"
        DgvDanhSachDaiLy.Columns.Add(clMaDaiLy)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "TenDaiLy"
        clTenDaiLy.HeaderText = "Tên Đại Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        DgvDanhSachDaiLy.Columns.Add(clTenDaiLy)

        Dim clMaLoaiDaiLy = New DataGridViewTextBoxColumn()
        clMaLoaiDaiLy.Name = "MaLoaiDaiLy"
        clMaLoaiDaiLy.HeaderText = "Mã Loại Đại Lý"
        clMaLoaiDaiLy.DataPropertyName = "MaLoaiDaiLy"
        DgvDanhSachDaiLy.Columns.Add(clMaLoaiDaiLy)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        DgvDanhSachDaiLy.Columns.Add(clDienThoai)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        DgvDanhSachDaiLy.Columns.Add(clDiaChi)

        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Mã Quận"
        clMaQuan.DataPropertyName = "Quan"
        DgvDanhSachDaiLy.Columns.Add(clMaQuan)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayTiepNhan"
        clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgayTiepNhan.DataPropertyName = "NgayTiepNhan"
        DgvDanhSachDaiLy.Columns.Add(clNgayTiepNhan)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        DgvDanhSachDaiLy.Columns.Add(clEmail)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        DgvDanhSachDaiLy.Columns.Add(clNoCuaDaiLy)
    End Sub

    Private Sub loadCb()

        ldlBUS = New LoaiDaiLyBUS()
        QuanBUS = New QuanBUS()

        Dim listLoaiDaiLy = New List(Of LoaiDaiLyDTO)
        Dim result As Result
        result = ldlBUS.selectAll(listLoaiDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại đại lý thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        CbMaLoaiDaiLy.DataSource = New BindingSource(listLoaiDaiLy, String.Empty)
        CbMaLoaiDaiLy.DisplayMember = "MaLoaiDaiLy"
        CbMaLoaiDaiLy.ValueMember = "TenLoaiDaiLy"

        Dim listQuan = New List(Of QuanDTO)
        result = QuanBUS.selectAll(listQuan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Quận thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        CbMaQuan.DataSource = New BindingSource(listQuan, String.Empty)
        CbMaQuan.DisplayMember = "MaQuan"
        CbMaQuan.ValueMember = "TenQuan"
    End Sub
    Private Sub DgvDanhSachDaiLy_SelectionChanged(sender As Object, e As EventArgs) Handles DgvDanhSachDaiLy.SelectionChanged
        Dim currentRowIndex As Integer = DgvDanhSachDaiLy.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < DgvDanhSachDaiLy.RowCount) Then
            Try
                Dim dl = CType(DgvDanhSachDaiLy.Rows(currentRowIndex).DataBoundItem, DaiLyDTO)
                txbMaDL.Text = dl.MaDaiLy
                TxbTenDL.Text = dl.TenDaiLy
                CbMaLoaiDaiLy.Text = dl.MaLoaiDaiLy
                CbMaQuan.Text = dl.Quan
                TxbDienThoai.Text = dl.DienThoai
                TxbDiaChi.Text = dl.DiaChi
                TxbEmail.Text = dl.Email
                dtpNgayTiepNhan.Value = dl.NgayTiepNhan
                TxbNoCuaDaiLy.Text = dl.NoCuaDaiLy
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub BtnCapNhap_Click(sender As Object, e As EventArgs) Handles BtnCapNhap.Click
        Dim currentRowIndex As Integer = DgvDanhSachDaiLy.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < DgvDanhSachDaiLy.RowCount) Then
            Try

                Dim dl As DaiLyDTO
                dl = New DaiLyDTO()

                dl.MaDaiLy = Convert.ToInt32(txbMaDL.Text)
                dl.TenDaiLy = TxbTenDL.Text
                dl.MaLoaiDaiLy = Convert.ToInt32(CbMaLoaiDaiLy.Text)
                dl.Quan = Convert.ToInt32(CbMaQuan.Text)
                dl.DienThoai = TxbDienThoai.Text
                dl.DiaChi = TxbDiaChi.Text
                dl.Email = TxbEmail.Text
                dl.NgayTiepNhan = dtpNgayTiepNhan.Value
                dl.NoCuaDaiLy = TxbNoCuaDaiLy.Text

                '2. Business .....
                If (dailyBus.isValidName(dl) = False) Then
                    MessageBox.Show("Tên đại lý không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxbTenDL.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = dailyBus.update(dl)
                If (result.FlagResult = True) Then

                    loadListDaiLy()
                    ' Hightlight the row has been updated on table
                    DgvDanhSachDaiLy.Rows(currentRowIndex).Selected = True
                    Try
                        dl = CType(DgvDanhSachDaiLy.Rows(currentRowIndex).DataBoundItem, DaiLyDTO)
                        txbMaDL.Text = dl.MaDaiLy
                        TxbTenDL.Text = dl.TenDaiLy
                        CbMaLoaiDaiLy.Text = dl.MaLoaiDaiLy
                        CbMaQuan.Text = dl.Quan
                        TxbDienThoai.Text = dl.DienThoai
                        TxbDiaChi.Text = dl.DiaChi
                        TxbEmail.Text = dl.Email
                        dtpNgayTiepNhan.Value = dl.NgayTiepNhan
                        TxbNoCuaDaiLy.Text = dl.NoCuaDaiLy
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật đại lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim currentRowIndex As Integer = DgvDanhSachDaiLy.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < DgvDanhSachDaiLy.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa đại lý có mã: " + txbMaDL.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = dailyBus.delete(txbMaDL.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListDaiLy()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= DgvDanhSachDaiLy.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                DgvDanhSachDaiLy.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim dl = CType(DgvDanhSachDaiLy.Rows(currentRowIndex).DataBoundItem, DaiLyDTO)
                                    txbMaDL.Text = dl.MaDaiLy
                                    TxbTenDL.Text = dl.TenDaiLy
                                    CbMaLoaiDaiLy.Text = dl.MaLoaiDaiLy
                                    CbMaQuan.Text = dl.Quan
                                    TxbDienThoai.Text = dl.DienThoai
                                    TxbDiaChi.Text = dl.DiaChi
                                    TxbEmail.Text = dl.Email
                                    dtpNgayTiepNhan.Value = dl.NgayTiepNhan
                                    TxbNoCuaDaiLy.Text = dl.NoCuaDaiLy
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa đại lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub TxbNoCuaDaiLy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbNoCuaDaiLy.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxbDienThoai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbDienThoai.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class