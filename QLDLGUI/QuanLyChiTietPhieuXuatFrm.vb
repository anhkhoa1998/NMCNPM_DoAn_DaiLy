Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class QuanLyChiTietPhieuXuatFrm

    Private ctPhieuXuatBUS As ChiTietPhieuXuatBUS
    Private matHangBUS As MatHangBUS
    Private dvtBUS As DonViTinhBUS
    Private phieuXuatBUS As PhieuXuatBUS
    Private Sub QuanLyChiTietPhieuXuatFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctPhieuXuatBUS = New ChiTietPhieuXuatBUS
        matHangBUS = New MatHangBUS
        dvtBUS = New DonViTinhBUS
        phieuXuatBUS = New PhieuXuatBUS

        LoadListChiTiet()

        Dim listPhieuXuat = New List(Of PhieuXuatDTO)
        Dim result As Result
        result = phieuXuatBUS.selectAll(listPhieuXuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Xuất thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        CbMaPhieuXuat.DataSource = New BindingSource(listPhieuXuat, String.Empty)
        CbMaPhieuXuat.DisplayMember = "MaPhieuXuat"
        CbMaPhieuXuat.ValueMember = "MaPhieuXuat"

        Dim ListMatHang = New List(Of MatHangDTO)
        result = matHangBUS.selectAll(ListMatHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Mặt Hàng thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        CbMaMatHang.DataSource = New BindingSource(ListMatHang, String.Empty)
        CbMaMatHang.DisplayMember = "MaMatHang"
        CbMaMatHang.ValueMember = "TenMatHang"

        Dim ListDvt = New List(Of DonViTinhDTO)
        result = dvtBUS.selectAll(ListDvt)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đơn vị tính thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        CbMaDonViTinh.DataSource = New BindingSource(ListDvt, String.Empty)
        CbMaDonViTinh.DisplayMember = "MaDonViTinh"
        CbMaDonViTinh.ValueMember = "MaDonViTinh"
    End Sub


    Private Sub LoadListChiTiet()
        Dim listChiTiet = New List(Of ChiTietPhieuXuatDTO)
        Dim result As Result
        result = ctPhieuXuatBUS.selectAll(listChiTiet)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        DgvChiTietPhieu.Columns.Clear()
        DgvChiTietPhieu.DataSource = Nothing

        DgvChiTietPhieu.AutoGenerateColumns = False
        DgvChiTietPhieu.AllowUserToAddRows = False
        DgvChiTietPhieu.DataSource = listChiTiet

        Dim clMaChiTietPhieuThu = New DataGridViewTextBoxColumn()
        clMaChiTietPhieuThu.Name = "MaChiTietPhieuXuat"
        clMaChiTietPhieuThu.HeaderText = "Mã Chi Tiết Phiếu Xuất"
        clMaChiTietPhieuThu.DataPropertyName = "MaChiTietPhieuXuat"
        DgvChiTietPhieu.Columns.Add(clMaChiTietPhieuThu)

        Dim clMaPhieuXuat = New DataGridViewTextBoxColumn()
        clMaPhieuXuat.Name = "MaPhieuXuat"
        clMaPhieuXuat.HeaderText = "Mã Phiếu Xuất"
        clMaPhieuXuat.DataPropertyName = "MaPhieuXuat"
        DgvChiTietPhieu.Columns.Add(clMaPhieuXuat)

        Dim clMaMatHang = New DataGridViewTextBoxColumn()
        clMaMatHang.Name = "MaMatHang"
        clMaMatHang.HeaderText = "Mã Mặt Hàng"
        clMaMatHang.DataPropertyName = "MaMatHang"
        DgvChiTietPhieu.Columns.Add(clMaMatHang)

        Dim clMaDonViTinh = New DataGridViewTextBoxColumn()
        clMaDonViTinh.Name = "MaDonViTinh"
        clMaDonViTinh.HeaderText = "Mã Đơn Vị Tính"
        clMaDonViTinh.DataPropertyName = "MaDonViTinh"
        DgvChiTietPhieu.Columns.Add(clMaDonViTinh)

        Dim clSoLuongSanXuat = New DataGridViewTextBoxColumn()
        clSoLuongSanXuat.Name = "SoLuongXuat"
        clSoLuongSanXuat.HeaderText = "Số Lượng Xuất"
        clSoLuongSanXuat.DataPropertyName = "SoLuongXuat"
        DgvChiTietPhieu.Columns.Add(clSoLuongSanXuat)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DonGiaXuat"
        clDonGia.HeaderText = "Đơn Giá Xuất"
        clDonGia.DataPropertyName = "DonGiaXuat"
        DgvChiTietPhieu.Columns.Add(clDonGia)

        Dim clThanhTien = New DataGridViewTextBoxColumn()
        clThanhTien.Name = "ThanhTien"
        clThanhTien.HeaderText = "Thành Tiền"
        clThanhTien.DataPropertyName = "ThanhTien"
        DgvChiTietPhieu.Columns.Add(clThanhTien)


    End Sub
    Private Sub TxbThanhTien_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbThanhTien.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxbDonGiaXuat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbDonGiaXuat.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxbSoLuongXuat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbSoLuongXuat.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxbDonGiaXuat_TextChanged(sender As Object, e As EventArgs) Handles TxbDonGiaXuat.TextChanged
        Dim tongTien As Integer
        tongTien = Convert.ToInt32(TxbDonGiaXuat.Text) * Convert.ToInt32(TxbSoLuongXuat.Text)
        TxbThanhTien.Text = tongTien.ToString()
    End Sub

    Private Sub DgvChiTietPhieu_SelectionChanged(sender As Object, e As EventArgs) Handles DgvChiTietPhieu.SelectionChanged
        Dim currentRowIndex As Integer = DgvChiTietPhieu.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < DgvChiTietPhieu.RowCount) Then
            Try
                Dim ctPhieuXuat = CType(DgvChiTietPhieu.Rows(currentRowIndex).DataBoundItem, ChiTietPhieuXuatDTO)
                TxbMaCTPX.Text = ctPhieuXuat.MaChiTietPhieuXuat
                CbMaPhieuXuat.Text = ctPhieuXuat.MaPhieuXuat
                CbMaMatHang.Text = ctPhieuXuat.MaMatHang
                CbMaDonViTinh.Text = ctPhieuXuat.MaDonViTinh
                TxbSoLuongXuat.Text = ctPhieuXuat.SoLuongXuat
                TxbDonGiaXuat.Text = ctPhieuXuat.DonGiaXuat
                TxbThanhTien.Text = ctPhieuXuat.ThanhTien
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub BtnNhap_Click(sender As Object, e As EventArgs) Handles BtnNhap.Click
        Dim currentRowIndex As Integer = DgvChiTietPhieu.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < DgvChiTietPhieu.RowCount) Then
            Try

                Dim ctPhieuXuat As ChiTietPhieuXuatDTO
                ctPhieuXuat = New ChiTietPhieuXuatDTO()

                ctPhieuXuat.MaChiTietPhieuXuat = TxbMaCTPX.Text
                ctPhieuXuat.MaPhieuXuat = Convert.ToInt32(CbMaPhieuXuat.Text)
                ctPhieuXuat.MaMatHang = CbMaMatHang.Text
                ctPhieuXuat.MaDonViTinh = CbMaDonViTinh.Text
                ctPhieuXuat.SoLuongXuat = Convert.ToInt32(TxbSoLuongXuat.Text)
                ctPhieuXuat.DonGiaXuat = TxbDonGiaXuat.Text
                ctPhieuXuat.ThanhTien = TxbThanhTien.Text

                Dim result As Result
                result = ctPhieuXuatBUS.update(ctPhieuXuat)
                If (result.FlagResult = True) Then

                    LoadListChiTiet()
                    ' Hightlight the row has been updated on table
                    DgvChiTietPhieu.Rows(currentRowIndex).Selected = True
                    Try
                        ctPhieuXuat = CType(DgvChiTietPhieu.Rows(currentRowIndex).DataBoundItem, ChiTietPhieuXuatDTO)
                        TxbMaCTPX.Text = ctPhieuXuat.MaChiTietPhieuXuat
                        CbMaPhieuXuat.Text = ctPhieuXuat.MaPhieuXuat
                        CbMaMatHang.Text = ctPhieuXuat.MaMatHang
                        CbMaDonViTinh.Text = ctPhieuXuat.MaDonViTinh
                        TxbSoLuongXuat.Text = ctPhieuXuat.SoLuongXuat
                        TxbDonGiaXuat.Text = ctPhieuXuat.DonGiaXuat
                        TxbThanhTien.Text = ctPhieuXuat.ThanhTien
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Chi Tiết Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim currentRowIndex As Integer = DgvChiTietPhieu.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < DgvChiTietPhieu.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Chi Tiết Phiếu Xuất có mã: " + TxbMaCTPX.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = ctPhieuXuatBUS.delete(TxbMaCTPX.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadListChiTiet()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= DgvChiTietPhieu.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                DgvChiTietPhieu.Rows(currentRowIndex).Selected = True
                                Try

                                    Dim ctPhieuXuat = CType(DgvChiTietPhieu.Rows(currentRowIndex).DataBoundItem, ChiTietPhieuXuatDTO)
                                    TxbMaCTPX.Text = ctPhieuXuat.MaChiTietPhieuXuat
                                    CbMaPhieuXuat.Text = ctPhieuXuat.MaPhieuXuat
                                    CbMaMatHang.Text = ctPhieuXuat.MaMatHang
                                    CbMaDonViTinh.Text = ctPhieuXuat.MaDonViTinh
                                    TxbSoLuongXuat.Text = ctPhieuXuat.SoLuongXuat
                                    TxbDonGiaXuat.Text = ctPhieuXuat.DonGiaXuat
                                    TxbThanhTien.Text = ctPhieuXuat.ThanhTien
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Chi Tiết Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class