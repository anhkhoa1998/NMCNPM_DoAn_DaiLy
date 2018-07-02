<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemChiTietPhieuXuat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxbMaCTPX = New System.Windows.Forms.TextBox()
        Me.TxbSoLuongXuat = New System.Windows.Forms.TextBox()
        Me.TxbDonGiaXuat = New System.Windows.Forms.TextBox()
        Me.TxbThanhTien = New System.Windows.Forms.TextBox()
        Me.CbMaPhieuXuat = New System.Windows.Forms.ComboBox()
        Me.CbMaMatHang = New System.Windows.Forms.ComboBox()
        Me.CbMaDonViTinh = New System.Windows.Forms.ComboBox()
        Me.BtnNhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thêm Chi Tiết Phiếu Xuất "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Chi Tiết Phiếu Xuất :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mã Phiếu Xuất :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mã Mặt Hàng :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(89, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Mã Đơn Vị Tính :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(89, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Số Lượng Xuất :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(89, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Đơn Giá Xuất :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(89, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Thành Tiền :"
        '
        'TxbMaCTPX
        '
        Me.TxbMaCTPX.Location = New System.Drawing.Point(254, 79)
        Me.TxbMaCTPX.Name = "TxbMaCTPX"
        Me.TxbMaCTPX.Size = New System.Drawing.Size(291, 20)
        Me.TxbMaCTPX.TabIndex = 2
        '
        'TxbSoLuongXuat
        '
        Me.TxbSoLuongXuat.Location = New System.Drawing.Point(254, 191)
        Me.TxbSoLuongXuat.Name = "TxbSoLuongXuat"
        Me.TxbSoLuongXuat.Size = New System.Drawing.Size(291, 20)
        Me.TxbSoLuongXuat.TabIndex = 2
        '
        'TxbDonGiaXuat
        '
        Me.TxbDonGiaXuat.Location = New System.Drawing.Point(254, 220)
        Me.TxbDonGiaXuat.Name = "TxbDonGiaXuat"
        Me.TxbDonGiaXuat.Size = New System.Drawing.Size(291, 20)
        Me.TxbDonGiaXuat.TabIndex = 2
        '
        'TxbThanhTien
        '
        Me.TxbThanhTien.Location = New System.Drawing.Point(254, 252)
        Me.TxbThanhTien.Name = "TxbThanhTien"
        Me.TxbThanhTien.Size = New System.Drawing.Size(291, 20)
        Me.TxbThanhTien.TabIndex = 2
        '
        'CbMaPhieuXuat
        '
        Me.CbMaPhieuXuat.FormattingEnabled = True
        Me.CbMaPhieuXuat.Location = New System.Drawing.Point(254, 102)
        Me.CbMaPhieuXuat.Name = "CbMaPhieuXuat"
        Me.CbMaPhieuXuat.Size = New System.Drawing.Size(121, 21)
        Me.CbMaPhieuXuat.TabIndex = 3
        '
        'CbMaMatHang
        '
        Me.CbMaMatHang.FormattingEnabled = True
        Me.CbMaMatHang.Location = New System.Drawing.Point(254, 129)
        Me.CbMaMatHang.Name = "CbMaMatHang"
        Me.CbMaMatHang.Size = New System.Drawing.Size(121, 21)
        Me.CbMaMatHang.TabIndex = 3
        '
        'CbMaDonViTinh
        '
        Me.CbMaDonViTinh.FormattingEnabled = True
        Me.CbMaDonViTinh.Location = New System.Drawing.Point(254, 161)
        Me.CbMaDonViTinh.Name = "CbMaDonViTinh"
        Me.CbMaDonViTinh.Size = New System.Drawing.Size(121, 21)
        Me.CbMaDonViTinh.TabIndex = 3
        '
        'BtnNhap
        '
        Me.BtnNhap.Location = New System.Drawing.Point(254, 303)
        Me.BtnNhap.Name = "BtnNhap"
        Me.BtnNhap.Size = New System.Drawing.Size(160, 51)
        Me.BtnNhap.TabIndex = 4
        Me.BtnNhap.Text = "Nhập"
        Me.BtnNhap.UseVisualStyleBackColor = True
        '
        'ThemChiTietPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnNhap)
        Me.Controls.Add(Me.CbMaDonViTinh)
        Me.Controls.Add(Me.CbMaMatHang)
        Me.Controls.Add(Me.CbMaPhieuXuat)
        Me.Controls.Add(Me.TxbThanhTien)
        Me.Controls.Add(Me.TxbDonGiaXuat)
        Me.Controls.Add(Me.TxbSoLuongXuat)
        Me.Controls.Add(Me.TxbMaCTPX)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ThemChiTietPhieuXuat"
        Me.Text = "ThemChiTietPhieuXuat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxbMaCTPX As TextBox
    Friend WithEvents TxbSoLuongXuat As TextBox
    Friend WithEvents TxbDonGiaXuat As TextBox
    Friend WithEvents TxbThanhTien As TextBox
    Friend WithEvents CbMaPhieuXuat As ComboBox
    Friend WithEvents CbMaMatHang As ComboBox
    Friend WithEvents CbMaDonViTinh As ComboBox
    Friend WithEvents BtnNhap As Button
End Class
