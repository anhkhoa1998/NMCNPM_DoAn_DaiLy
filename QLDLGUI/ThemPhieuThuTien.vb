
Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility
Public Class ThemPhieuThuTien
    Private phieuThuBUS As PhieuThuBUS
    Private dlBUS As DaiLyBUS
    Private Sub ThemPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuThuBUS = New PhieuThuBUS
        dlBUS = New DaiLyBUS
        LoadCb()
    End Sub

    Private Sub LoadCb()
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBUS.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đại lý thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        CbMaDaiLy.DataSource = New BindingSource(listDaiLy, String.Empty)
        CbMaDaiLy.DisplayMember = "MaDaiLy"
        CbMaDaiLy.ValueMember = "TenDaiLy"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Result
        Dim listDaiLy = New List(Of DaiLyDTO)
        result = dlBUS.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đại lý thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Dim conti As Boolean
        Dim pt As DaiLyDTO
        conti = False
        For Each pt In listDaiLy
            If (pt.MaDaiLy = Convert.ToInt32(CbMaDaiLy.Text)) Then
                If (Convert.ToInt32(pt.NoCuaDaiLy) >= Convert.ToInt32(TxbSoTienThu.Text)) Then
                    conti = True
                End If
            End If
        Next

        If (conti = True) Then
            Dim phieuThu As PhieuThuDTO
            phieuThu = New PhieuThuDTO()


            phieuThu.MaPhieuThu = TxbMaPhieuThu.Text
            phieuThu.MaDaiLy = CbMaDaiLy.Text
            phieuThu.NgayThuTien = DtpNgayThuTien.Value
            phieuThu.SoTienThu = TxbSoTienThu.Text




            result = phieuThuBUS.insert(phieuThu)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm Phiếu Thu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxbMaPhieuThu.Text = String.Empty

            Else
                MessageBox.Show("Thêm Phiếu Thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Số Tiền Thu Không được vượt quá số tiền đại lý đang nợ .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub TxbSoTienThu_TextChanged(sender As Object, e As EventArgs) Handles TxbSoTienThu.TextChanged

    End Sub

    Private Sub TxbSoTienThu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbSoTienThu.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class