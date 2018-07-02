Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class ThemMatHangFrm
    Private matHangBUS As MatHangBUS

    Private Sub ThemMatHangFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        matHangBUS = New MatHangBUS
    End Sub

    Private Sub BtnNhap_Click(sender As Object, e As EventArgs) Handles BtnNhap.Click
        Dim matHang As MatHangDTO
        matHang = New MatHangDTO()

        matHang.MaMatHang = TxbMaMatHang.Text
        matHang.TenMatHang = TxbTenMatHang.Text
        matHang.SoLuongTon = TxbSoLuongTon.Text
        matHang.DonGiaBan = TxbDonGiaBan.Text

        Dim result As Result
        result = matHangBUS.insert(matHang)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Mặt hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxbTenMatHang.Text = String.Empty

        Else
            MessageBox.Show("Thêm Mặt hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub TxbDonGiaBan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbDonGiaBan.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxbSoLuongTon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbSoLuongTon.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class