Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class ThemChiTietPhieuXuat
    Private ctPhieuXuatBUS As ChiTietPhieuXuatBUS
    Private matHangBUS As MatHangBUS
    Private dvtBUS As DonViTinhBUS
    Private phieuXuatBUS As PhieuXuatBUS

    Private Sub ThemChiTietPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctPhieuXuatBUS = New ChiTietPhieuXuatBUS
        matHangBUS = New MatHangBUS
        dvtBUS = New DonViTinhBUS
        phieuXuatBUS = New PhieuXuatBUS

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

    Private Sub BtnNhap_Click(sender As Object, e As EventArgs) Handles BtnNhap.Click
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
        result = ctPhieuXuatBUS.insert(ctPhieuXuat)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Chi Tiết Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxbMaCTPX.Text = String.Empty

        Else
            MessageBox.Show("Thêm Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
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

    Private Sub TxbDonGiaXuat_TextChanged(sender As Object, e As EventArgs) Handles TxbDonGiaXuat.TextChanged
        Dim tongTien As Integer
        tongTien = Convert.ToInt32(TxbDonGiaXuat.Text) * Convert.ToInt32(TxbSoLuongXuat.Text)
        TxbThanhTien.Text = tongTien.ToString()
    End Sub

    Private Sub TxbSoLuongXuat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbSoLuongXuat.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class