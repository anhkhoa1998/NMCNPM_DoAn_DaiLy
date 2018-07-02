Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility
Public Class ThemLoaiDaiLyFrm
    Private ldlBUS As LoaiDaiLyBUS
    Private Sub ThemLoaiDaiLyFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldlBUS = New LoaiDaiLyBUS()
        Dim result As Result
        Dim nextMaldl = "1"
        result = ldlBUS.buildMaldl(nextMaldl)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        TxbMaldl.Text = nextMaldl
    End Sub

    Private Sub BtnNhap_Click(sender As Object, e As EventArgs) Handles BtnNhap.Click
        Dim ldl As LoaiDaiLyDTO
        ldl = New LoaiDaiLyDTO()

        ldl.MaLoaiDaiLy = TxbMaldl.Text
        ldl.TenLoaiDaiLy = TxbTenldl.Text
        ldl.NoToiDa = TxbNoToiDa.Text

        Dim result As Result
        result = ldlBUS.insert(ldl)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại đại lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxbTenldl.Text = String.Empty

        Else
            MessageBox.Show("Thêm loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class