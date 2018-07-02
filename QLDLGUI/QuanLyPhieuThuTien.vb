Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class QuanLyPhieuThuTien
    Private phieuThuBUS As PhieuThuBUS
    Private dlBUS As DaiLyBUS
    Private Sub QuanLyPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuThuBUS = New PhieuThuBUS
        dlBUS = New DaiLyBUS
        LoadCb()
        LoadListPhieuThu()
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

    Private Sub DgvPhieuThu_SelectionChanged(sender As Object, e As EventArgs) Handles DgvPhieuThu.SelectionChanged
        Dim currentRowIndex As Integer = DgvPhieuThu.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < DgvPhieuThu.RowCount) Then
            Try
                Dim phieuThu = CType(DgvPhieuThu.Rows(currentRowIndex).DataBoundItem, PhieuThuDTO)
                TxbMaPhieuThu.Text = phieuThu.MaPhieuThu
                CbMaDaiLy.Text = phieuThu.MaDaiLy
                DtpNgayThuTien.Value = phieuThu.NgayThuTien
                TxbSoTienThu.Text = phieuThu.SoTienThu
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub LoadListPhieuThu()
        Dim listPhieuThu = New List(Of PhieuThuDTO)
        Dim result As Result
        result = phieuThuBUS.selectAll(listPhieuThu)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        DgvPhieuThu.Columns.Clear()
        DgvPhieuThu.DataSource = Nothing

        DgvPhieuThu.AutoGenerateColumns = False
        DgvPhieuThu.AllowUserToAddRows = False
        DgvPhieuThu.DataSource = listPhieuThu

        Dim clMaPhieuThu = New DataGridViewTextBoxColumn()
        clMaPhieuThu.Name = "MaPhieuThu"
        clMaPhieuThu.HeaderText = "Mã Phiếu Thu"
        clMaPhieuThu.DataPropertyName = "MaPhieuThu"
        DgvPhieuThu.Columns.Add(clMaPhieuThu)

        Dim clMaDaiLy = New DataGridViewTextBoxColumn()
        clMaDaiLy.Name = "MaDaiLy"
        clMaDaiLy.HeaderText = "Mã Đại Lý"
        clMaDaiLy.DataPropertyName = "MaDaiLy"
        DgvPhieuThu.Columns.Add(clMaDaiLy)

        Dim clNgayThuTien = New DataGridViewTextBoxColumn()
        clNgayThuTien.Name = "NgayThuTien"
        clNgayThuTien.HeaderText = "Ngày Thu Tiền"
        clNgayThuTien.DataPropertyName = "NgayThuTien"
        DgvPhieuThu.Columns.Add(clNgayThuTien)

        Dim clSoTienThu = New DataGridViewTextBoxColumn()
        clSoTienThu.Name = "SoTienThu"
        clSoTienThu.HeaderText = "Số Tiền Thu"
        clSoTienThu.DataPropertyName = "SoTienThu"
        DgvPhieuThu.Columns.Add(clSoTienThu)
    End Sub

    Private Sub BtnCapNhap_Click(sender As Object, e As EventArgs) Handles BtnCapNhap.Click
        Dim result As Result
        Dim listDaiLy = New List(Of DaiLyDTO)
        result = dlBUS.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đại lý thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        Dim currentRowIndex As Integer = DgvPhieuThu.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < DgvPhieuThu.RowCount) Then
            Try
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


                    '3. Insert to DB


                    result = phieuThuBUS.update(phieuThu)
                    If (result.FlagResult = True) Then

                        LoadListPhieuThu()

                        DgvPhieuThu.Rows(currentRowIndex).Selected = True
                        Try
                            phieuThu = CType(DgvPhieuThu.Rows(currentRowIndex).DataBoundItem, PhieuThuDTO)
                            TxbMaPhieuThu.Text = phieuThu.MaPhieuThu
                            CbMaDaiLy.Text = phieuThu.MaDaiLy
                            DtpNgayThuTien.Value = phieuThu.NgayThuTien
                            TxbSoTienThu.Text = phieuThu.SoTienThu

                        Catch ex As Exception
                            Console.WriteLine(ex.StackTrace)
                        End Try
                        MessageBox.Show("Cập nhật Phiếu Thu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Cập nhật Phiếu Thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        System.Console.WriteLine(result.SystemMessage)
                    End If
                Else
                    MessageBox.Show("Số Tiền Thu Không được vượt quá số tiền đại lý đang nợ .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click

    End Sub

    Private Sub TxbSoTienThu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbSoTienThu.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class