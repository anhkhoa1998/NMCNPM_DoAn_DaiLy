Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class ThemQuanFrm
    Private quanBUS As QuanBUS

    Private Sub ThemQuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        quanBUS = New QuanBUS()
        Dim result As Result
        Dim nextMaQuan = "1"
        result = quanBUS.BuildMaQuan(nextMaQuan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        TxbMaQuan.Text = nextMaQuan

    End Sub

    Private Sub BtnNhap_Click(sender As Object, e As EventArgs) Handles BtnNhap.Click
        Dim quan As QuanDTO
        quan = New QuanDTO()

        quan.MaQuan = TxbMaQuan.Text
        quan.TenQuan = TxbTenQuan.Text

        Dim result As Result
        result = quanBUS.insert(quan)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Quận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxbMaQuan.Text = String.Empty
            Me.Close()

        Else
            MessageBox.Show("Thêm Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class