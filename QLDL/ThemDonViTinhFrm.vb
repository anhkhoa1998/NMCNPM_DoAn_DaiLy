Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class ThemDonViTinhFrm
    Private donViTinhBUS As DonViTinhBUS

    Private Sub ThemDonViTinhFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        donViTinhBUS = New DonViTinhBUS
    End Sub

    Private Sub BtnNhap_Click(sender As Object, e As EventArgs) Handles BtnNhap.Click
        Dim dvt As DonViTinhDTO
        dvt = New DonViTinhDTO()

        dvt.MaDonViTinh = TxbMaDVT.Text
        dvt.TenDonViTinh = TxbTenDVT.Text

        Dim result As Result
        result = donViTinhBUS.insert(dvt)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Đơn Vị Tính thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxbTenDVT.Text = String.Empty

        Else
            MessageBox.Show("Thêm Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class