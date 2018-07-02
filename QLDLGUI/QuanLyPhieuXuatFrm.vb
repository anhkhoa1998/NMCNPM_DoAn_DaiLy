Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class QuanLyPhieuXuatFrm
    Private phieuXuatBUS As PhieuXuatBUS
    Private dlBUS As DaiLyBUS
    Private Sub QuanLyPhieuXuatFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuXuatBUS = New PhieuXuatBUS
        dlBUS = New DaiLyBUS
        loadCb()
        LoadListPhieuXuat()
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

    Private Sub DgvDanhSachPhieuXuat_SelectionChanged(sender As Object, e As EventArgs) Handles DgvDanhSachPhieuXuat.SelectionChanged
        Dim currentRowIndex As Integer = DgvDanhSachPhieuXuat.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < DgvDanhSachPhieuXuat.RowCount) Then
            Try
                Dim phieuXuat = CType(DgvDanhSachPhieuXuat.Rows(currentRowIndex).DataBoundItem, PhieuXuatDTO)
                TxbMaPhieuXuat.Text = phieuXuat.MaPhieuXuat
                TxbTongTriGia.Text = phieuXuat.TongTriGia
                CbMaDL.Text = phieuXuat.MaDaiLy
                DtpNgayTiepNhan.Value = phieuXuat.NgayLapPhieu

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub LoadListPhieuXuat()
        Dim listPhieuXuat = New List(Of PhieuXuatDTO)
        Dim result As Result
        result = phieuXuatBUS.selectAll(listPhieuXuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        DgvDanhSachPhieuXuat.Columns.Clear()
        DgvDanhSachPhieuXuat.DataSource = Nothing

        DgvDanhSachPhieuXuat.AutoGenerateColumns = False
        DgvDanhSachPhieuXuat.AllowUserToAddRows = False
        DgvDanhSachPhieuXuat.DataSource = listPhieuXuat

        Dim clMaPhieuXuat = New DataGridViewTextBoxColumn()
        clMaPhieuXuat.Name = "MaPhieuXuat"
        clMaPhieuXuat.HeaderText = "Mã Phiếu Xuất"
        clMaPhieuXuat.DataPropertyName = "MaPhieuXuat"
        DgvDanhSachPhieuXuat.Columns.Add(clMaPhieuXuat)

        Dim clMaDaiLy = New DataGridViewTextBoxColumn()
        clMaDaiLy.Name = "MaDaiLy"
        clMaDaiLy.HeaderText = "Mã Đại Lý"
        clMaDaiLy.DataPropertyName = "MaDaiLy"
        DgvDanhSachPhieuXuat.Columns.Add(clMaDaiLy)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayLapPhieu"
        clNgayTiepNhan.HeaderText = "Ngày Lập Phiếu"
        clNgayTiepNhan.DataPropertyName = "NgayLapPhieu"
        DgvDanhSachPhieuXuat.Columns.Add(clNgayTiepNhan)

        Dim clTongTriGia = New DataGridViewTextBoxColumn()
        clTongTriGia.Name = "TongTriGia"
        clTongTriGia.HeaderText = "Tổng Trị Giá"
        clTongTriGia.DataPropertyName = "TongTriGia"
        DgvDanhSachPhieuXuat.Columns.Add(clTongTriGia)
    End Sub

    Private Sub BtnNhap_Click(sender As Object, e As EventArgs) Handles BtnNhap.Click
        Dim currentRowIndex As Integer = DgvDanhSachPhieuXuat.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < DgvDanhSachPhieuXuat.RowCount) Then
            Try

                Dim phieuXuat As PhieuXuatDTO
                phieuXuat = New PhieuXuatDTO

                phieuXuat.MaPhieuXuat = TxbMaPhieuXuat.Text
                phieuXuat.TongTriGia = TxbTongTriGia.Text
                phieuXuat.MaDaiLy = CbMaDL.Text
                phieuXuat.NgayLapPhieu = DtpNgayTiepNhan.Value


                '3. Insert to DB

                Dim result As Result
                result = phieuXuatBUS.update(phieuXuat)
                If (result.FlagResult = True) Then

                    LoadListPhieuXuat()

                    DgvDanhSachPhieuXuat.Rows(currentRowIndex).Selected = True
                    Try
                        phieuXuat = CType(DgvDanhSachPhieuXuat.Rows(currentRowIndex).DataBoundItem, PhieuXuatDTO)
                        TxbMaPhieuXuat.Text = phieuXuat.MaPhieuXuat
                        TxbTongTriGia.Text = phieuXuat.TongTriGia
                        CbMaDL.Text = phieuXuat.MaDaiLy
                        DtpNgayTiepNhan.Value = phieuXuat.NgayLapPhieu

                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim currentRowIndex As Integer = DgvDanhSachPhieuXuat.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < DgvDanhSachPhieuXuat.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Phiếu Xuất có mã: " + TxbMaPhieuXuat.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = phieuXuatBUS.delete(TxbMaPhieuXuat.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadListPhieuXuat()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= DgvDanhSachPhieuXuat.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                DgvDanhSachPhieuXuat.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim phieuXuat = CType(DgvDanhSachPhieuXuat.Rows(currentRowIndex).DataBoundItem, PhieuXuatDTO)
                                    TxbMaPhieuXuat.Text = phieuXuat.MaPhieuXuat
                                    TxbTongTriGia.Text = phieuXuat.TongTriGia
                                    CbMaDL.Text = phieuXuat.MaDaiLy
                                    DtpNgayTiepNhan.Value = phieuXuat.NgayLapPhieu
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select

        End If
    End Sub

    Private Sub TxbTongTriGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbTongTriGia.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class