Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class BaoCaoCongNo
    Private phieuXuatBUS As PhieuXuatBUS
    Private Sub BaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuXuatBUS = New PhieuXuatBUS

    End Sub

    Private Sub BtnCongNo_Click(sender As Object, e As EventArgs) Handles BtnCongNo.Click
        Dim ListBaoCao = New List(Of CongNoDTO)
        Dim result As Result
        result = phieuXuatBUS.CongNo(ListBaoCao, TxbThang.Text)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy Báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Return
        'End If

        DgvCongNo.Columns.Clear()
        DgvCongNo.DataSource = Nothing

        DgvCongNo.AutoGenerateColumns = False
        DgvCongNo.AllowUserToAddRows = False
        DgvCongNo.DataSource = ListBaoCao
        Dim clMaDaiLy = New DataGridViewTextBoxColumn()
        clMaDaiLy.Name = "MaDaiLy"
        clMaDaiLy.HeaderText = "Mã Đại Lý"
        clMaDaiLy.DataPropertyName = "MaDaiLy"
        DgvCongNo.Columns.Add(clMaDaiLy)

        Dim ClNoCuaDaiLy = New DataGridViewTextBoxColumn()
        ClNoCuaDaiLy.Name = "NoDau"
        ClNoCuaDaiLy.HeaderText = "Nợ Đầu"
        ClNoCuaDaiLy.DataPropertyName = "NoDau"
        DgvCongNo.Columns.Add(ClNoCuaDaiLy)

        Dim ClNoPhatSinh = New DataGridViewTextBoxColumn()
        ClNoPhatSinh.Name = "NoPhatSinh"
        ClNoPhatSinh.HeaderText = "Nợ Phát Sinh"
        ClNoPhatSinh.DataPropertyName = "NoPhatSinh"
        DgvCongNo.Columns.Add(ClNoPhatSinh)

        Dim ClNoCuoi = New DataGridViewTextBoxColumn()
        ClNoCuoi.Name = "NoCuoi"
        ClNoCuoi.HeaderText = "Nợ Cuối"
        ClNoCuoi.DataPropertyName = "NoCuoi"
        DgvCongNo.Columns.Add(ClNoCuoi)
    End Sub
End Class