Imports System.Configuration
Imports QLDLBUS
Imports QLDLDTO
Imports Ultility

Public Class QuanLyDonViTinh
    Private DvtBUS As DonViTinhBUS
    Private Sub BtnCapNhap_Click(sender As Object, e As EventArgs) Handles BtnCapNhap.Click
        Dim currentRowIndex As Integer = DgvDvt.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < DgvDvt.RowCount) Then
            Try

                Dim dvt As DonViTinhDTO
                dvt = New DonViTinhDTO()

                '1. Mapping data from GUI control
                dvt.MaDonViTinh = TxbMaDVT.Text
                dvt.TenDonViTinh = TxbTenDVT.Text

                '2. Business .....
                If (DvtBUS.isValidName(dvt) = False) Then
                    MessageBox.Show("Tên Đơn Vị Tính không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxbTenDVT.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = DvtBUS.update(dvt)
                If (result.FlagResult = True) Then

                    LoadListDVT()

                    DgvDvt.Rows(currentRowIndex).Selected = True
                    Try
                        dvt = CType(DgvDvt.Rows(currentRowIndex).DataBoundItem, DonViTinhDTO)
                        TxbMaDVT.Text = dvt.MaDonViTinh
                        TxbTenDVT.Text = dvt.TenDonViTinh
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Đơn Vị Tính thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim currentRowIndex As Integer = DgvDvt.CurrentCellAddress.Y


        If (-1 < currentRowIndex And currentRowIndex < DgvDvt.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Đơn Vị Tính có mã: " + TxbMaDVT.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = DvtBUS.delete(TxbMaDVT.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadListDVT()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= DgvDvt.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                DgvDvt.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim dvt = CType(DgvDvt.Rows(currentRowIndex).DataBoundItem, DonViTinhDTO)
                                    TxbMaDVT.Text = dvt.MaDonViTinh
                                    TxbTenDVT.Text = dvt.TenDonViTinh
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Loại Đơn Vị Tính thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub QuanLyDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DvtBUS = New DonViTinhBUS
        LoadListDVT()

    End Sub

    Private Sub LoadListDVT()
        Dim listDVT = New List(Of DonViTinhDTO)
        Dim result As Result
        result = DvtBUS.selectAll(listDVT)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        DgvDvt.Columns.Clear()
        DgvDvt.DataSource = Nothing

        DgvDvt.AutoGenerateColumns = False
        DgvDvt.AllowUserToAddRows = False
        DgvDvt.DataSource = listDVT
        Dim clMaDVT = New DataGridViewTextBoxColumn()
        clMaDVT.Name = "MaDonViTinh"
        clMaDVT.HeaderText = "Mã Đơn Vị Tính"
        clMaDVT.DataPropertyName = "MaDonViTinh"
        DgvDvt.Columns.Add(clMaDVT)

        Dim clTenDVT = New DataGridViewTextBoxColumn()
        clTenDVT.Name = "TenDonViTinh"
        clTenDVT.HeaderText = "Tên Đơn Vị Tính"
        clTenDVT.DataPropertyName = "TenDonViTinh"
        DgvDvt.Columns.Add(clTenDVT)

    End Sub

    Private Sub DgvDvt_SelectionChanged(sender As Object, e As EventArgs) Handles DgvDvt.SelectionChanged
        Dim currentRowIndex As Integer = DgvDvt.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < DgvDvt.RowCount) Then
            Try
                Dim dvt = CType(DgvDvt.Rows(currentRowIndex).DataBoundItem, DonViTinhDTO)
                TxbMaDVT.Text = dvt.MaDonViTinh
                TxbTenDVT.Text = dvt.TenDonViTinh
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub


End Class