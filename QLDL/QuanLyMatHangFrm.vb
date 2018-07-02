Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class QuanLyMatHangFrm
    Private matHangBUS As MatHangBUS

    Private Sub QuanLyMatHangFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        matHangBUS = New MatHangBUS
        LoadListMatHang()
    End Sub

    Private Sub LoadListMatHang()
        Dim listMatHang = New List(Of MatHangDTO)
        Dim result As Result
        result = matHangBUS.selectAll(listMatHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        DgvMatHang.Columns.Clear()
        DgvMatHang.DataSource = Nothing

        DgvMatHang.AutoGenerateColumns = False
        DgvMatHang.AllowUserToAddRows = False
        DgvMatHang.DataSource = listMatHang
        Dim clmaMatHang = New DataGridViewTextBoxColumn()
        clmaMatHang.Name = "MaMatHang"
        clmaMatHang.HeaderText = "Mã Mặt Hàng"
        clmaMatHang.DataPropertyName = "MaMatHang"
        DgvMatHang.Columns.Add(clmaMatHang)

        Dim clTenMatHang = New DataGridViewTextBoxColumn()
        clTenMatHang.Name = "TenMatHang"
        clTenMatHang.HeaderText = "Tên Mặt Hàng"
        clTenMatHang.DataPropertyName = "TenMatHang"
        DgvMatHang.Columns.Add(clTenMatHang)

        Dim clSoLuongTon = New DataGridViewTextBoxColumn()
        clSoLuongTon.Name = "SoLuongTon"
        clSoLuongTon.HeaderText = "Số Lượng Tồn"
        clSoLuongTon.DataPropertyName = "SoLuongTon"
        DgvMatHang.Columns.Add(clSoLuongTon)

        Dim clDonGiaBan = New DataGridViewTextBoxColumn()
        clDonGiaBan.Name = "DonGiaBan"
        clDonGiaBan.HeaderText = "Đơn Giá Bán"
        clDonGiaBan.DataPropertyName = "DonGiaBan"
        DgvMatHang.Columns.Add(clDonGiaBan)
    End Sub

    Private Sub DgvMatHang_SelectionChanged(sender As Object, e As EventArgs) Handles DgvMatHang.SelectionChanged
        Dim currentRowIndex As Integer = DgvMatHang.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < DgvMatHang.RowCount) Then
            Try
                Dim mathang = CType(DgvMatHang.Rows(currentRowIndex).DataBoundItem, MatHangDTO)
                TxbMaMatHang.Text = mathang.MaMatHang
                TxbTenMatHang.Text = mathang.TenMatHang
                TxbSoLuongTon.Text = mathang.SoLuongTon
                TxbDonGiaBan.Text = mathang.DonGiaBan
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub BtnCapNhap_Click(sender As Object, e As EventArgs) Handles BtnCapNhap.Click
        Dim currentRowIndex As Integer = DgvMatHang.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < DgvMatHang.RowCount) Then
            Try

                Dim mathang As MatHangDTO
                mathang = New MatHangDTO()

                '1. Mapping data from GUI control
                mathang.MaMatHang = TxbMaMatHang.Text
                mathang.TenMatHang = TxbTenMatHang.Text
                mathang.SoLuongTon = Convert.ToInt32(TxbSoLuongTon.Text)
                mathang.DonGiaBan = Convert.ToInt32(TxbDonGiaBan.Text)

                '2. Business .....
                If (matHangBUS.isValidName(mathang) = False) Then
                    MessageBox.Show("Tên Mặt Hàng không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxbTenMatHang.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = matHangBUS.update(mathang)
                If (result.FlagResult = True) Then

                    LoadListMatHang()

                    DgvMatHang.Rows(currentRowIndex).Selected = True
                    Try
                        mathang = CType(DgvMatHang.Rows(currentRowIndex).DataBoundItem, MatHangDTO)
                        TxbMaMatHang.Text = mathang.MaMatHang
                        TxbTenMatHang.Text = mathang.TenMatHang
                        TxbSoLuongTon.Text = mathang.SoLuongTon
                        TxbDonGiaBan.Text = mathang.DonGiaBan
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Mặt Hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim currentRowIndex As Integer = DgvMatHang.CurrentCellAddress.Y


        If (-1 < currentRowIndex And currentRowIndex < DgvMatHang.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Mặt Hàng có mã: " + TxbMaMatHang.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = matHangBUS.delete(TxbMaMatHang.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadListMatHang()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= DgvMatHang.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                DgvMatHang.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim matHang = CType(DgvMatHang.Rows(currentRowIndex).DataBoundItem, MatHangDTO)
                                    TxbMaMatHang.Text = matHang.MaMatHang
                                    TxbTenMatHang.Text = matHang.TenMatHang
                                    TxbSoLuongTon.Text = matHang.SoLuongTon
                                    TxbDonGiaBan.Text = matHang.DonGiaBan
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Mặt Hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class