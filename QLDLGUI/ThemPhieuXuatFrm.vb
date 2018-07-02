Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class ThemPhieuXuatFrm
    Private phieuXuatBUS As PhieuXuatBUS
    Private dlBUS As DaiLyBUS

    Private Sub BtnNhap_Click(sender As Object, e As EventArgs) Handles BtnNhap.Click
        Dim phieuXuat As PhieuXuatDTO
        phieuXuat = New PhieuXuatDTO()


        phieuXuat.MaPhieuXuat = TxbMaPhieuXuat.Text
        phieuXuat.MaDaiLy = CbMaDL.Text
        phieuXuat.NgayLapPhieu = DtpNgayTiepNhan.Value
        phieuXuat.TongTriGia = TxbTongTriGia.Text



        Dim result As Result
        result = phieuXuatBUS.insert(phieuXuat)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxbMaPhieuXuat.Text = String.Empty

        Else
            MessageBox.Show("Thêm Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub ThemPhieuXuatFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuXuatBUS = New PhieuXuatBUS
        dlBUS = New DaiLyBUS
        loadCb()
        Dim result As Result
        Dim nextMaPhieuXuat = "1"
        result = phieuXuatBUS.buildmaPhieuXuat(nextMaPhieuXuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        TxbMaPhieuXuat.Text = nextMaPhieuXuat
    End Sub

    Private Sub loadCb()
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBUS.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đại lý thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        CbMaDL.DataSource = New BindingSource(listDaiLy, String.Empty)
        CbMaDL.DisplayMember = "MaDaiLy"
        CbMaDL.ValueMember = "TenDaiLy"
    End Sub

    Private Sub TxbTongTriGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbTongTriGia.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class