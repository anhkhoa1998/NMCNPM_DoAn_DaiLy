Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class BaoCaoDoanhSo
    Private phieuXuatBUS As PhieuXuatBUS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ListBaoCao = New List(Of DoanhSoDTO)
        Dim result As Result
        result = phieuXuatBUS.Sum(ListBaoCao, TxbThang.Text)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy Báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        DgvBaoCao.Columns.Clear()
        DgvBaoCao.DataSource = Nothing

        DgvBaoCao.AutoGenerateColumns = False
        DgvBaoCao.AllowUserToAddRows = False
        DgvBaoCao.DataSource = ListBaoCao
        Dim clMaDaiLy = New DataGridViewTextBoxColumn()
        clMaDaiLy.Name = "MaDaiLy"
        clMaDaiLy.HeaderText = "Mã Đại Lý"
        clMaDaiLy.DataPropertyName = "MaDaiLy"
        DgvBaoCao.Columns.Add(clMaDaiLy)

        Dim ClTongPhieuXuat = New DataGridViewTextBoxColumn()
        ClTongPhieuXuat.Name = "TongSoPhieuXuat"
        ClTongPhieuXuat.HeaderText = "Tổng Số Phiếu Xuất"
        ClTongPhieuXuat.DataPropertyName = "TongSoPhieuXuat"
        DgvBaoCao.Columns.Add(ClTongPhieuXuat)

        Dim ClTongTriGia = New DataGridViewTextBoxColumn()
        ClTongTriGia.Name = "TongTriGia"
        ClTongTriGia.HeaderText = "Tổng Trị Giá"
        ClTongTriGia.DataPropertyName = "TongTriGia"
        DgvBaoCao.Columns.Add(ClTongTriGia)
    End Sub

    Private Sub BaoCaoDoanhSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuXuatBUS = New PhieuXuatBUS
    End Sub
End Class