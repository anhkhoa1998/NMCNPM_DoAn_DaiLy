
Imports QLDLBUS
    Imports QLDLDTO
    Imports Ultility

    Public Class ThemDaiLyFrm

        Private dlBUS As DaiLyBUS
        Private ldlBUS As LoaiDaiLyBUS
        Private quanBUS As QuanBUS

        Private Sub ThemDaiLyFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            dlBUS = New DaiLyBUS()
            ldlBUS = New LoaiDaiLyBUS()
            quanBUS = New QuanBUS()

            Dim listLoaiDaiLy = New List(Of LoaiDaiLyDTO)
            Dim result As Result
            result = ldlBUS.selectAll(listLoaiDaiLy)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách loại đại lý thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Me.Close()
                Return
            End If
            CbMaLoaiDaiLy.DataSource = New BindingSource(listLoaiDaiLy, String.Empty)
            CbMaLoaiDaiLy.DisplayMember = "MaLoaiDaiLy"
            CbMaLoaiDaiLy.ValueMember = "TenLoaiDaiLy"

            Dim listQuan = New List(Of QuanDTO)
            result = quanBUS.selectAll(listQuan)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách Quận thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Me.Close()
                Return
            End If
            CbMaQuan.DataSource = New BindingSource(listQuan, String.Empty)
            CbMaQuan.DisplayMember = "MaQuan"
            CbMaQuan.ValueMember = "TenQuan"


            Dim nextMaDl = "1"
            result = dlBUS.buildMadl(nextMaDl)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Me.Close()
                Return
            End If
            txbMaDL.Text = nextMaDl
        End Sub

        Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click, Label9.Click, Label8.Click, Label10.Click

        End Sub

    Private Sub BtnNhap_Click(sender As Object, e As EventArgs) Handles BtnNhap.Click


        Dim soluong As String
        soluong = 0
        Dim result As Result
        result = dlBUS.count(soluong, CbMaQuan.Text)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy số lượng đại lý thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        If (Convert.ToInt32(soluong) <= 4) Then
            Dim daily As DaiLyDTO
            daily = New DaiLyDTO()


            daily.MaDaiLy = txbMaDL.Text
            daily.TenDaiLy = TxbTenDL.Text
            daily.MaLoaiDaiLy = CbMaLoaiDaiLy.Text
            daily.Quan = CbMaQuan.Text
            daily.DienThoai = TxbDienThoai.Text
            daily.DiaChi = TxbDiaChi.Text
            daily.NgayTiepNhan = dtpNgayTiepNhan.Value
            daily.Email = TxbEmail.Text
            daily.NoCuaDaiLy = TxbNoCuaDaiLy.Text



            result = dlBUS.insert(daily)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm đại lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxbTenDL.Text = String.Empty

            Else
                MessageBox.Show("Thêm đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Mã Quận này đã đủ 4 đại lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub TxbNoCuaDaiLy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbNoCuaDaiLy.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxbDienThoai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbDienThoai.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
