<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuanLyPhieuXuatFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnNhap = New System.Windows.Forms.Button()
        Me.DtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.CbMaDL = New System.Windows.Forms.ComboBox()
        Me.TxbTongTriGia = New System.Windows.Forms.TextBox()
        Me.TxbMaPhieuXuat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.DgvDanhSachPhieuXuat = New System.Windows.Forms.DataGridView()
        CType(Me.DgvDanhSachPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNhap
        '
        Me.BtnNhap.Location = New System.Drawing.Point(151, 383)
        Me.BtnNhap.Name = "BtnNhap"
        Me.BtnNhap.Size = New System.Drawing.Size(145, 55)
        Me.BtnNhap.TabIndex = 15
        Me.BtnNhap.Text = "Cập Nhập"
        Me.BtnNhap.UseVisualStyleBackColor = True
        '
        'DtpNgayTiepNhan
        '
        Me.DtpNgayTiepNhan.Location = New System.Drawing.Point(253, 297)
        Me.DtpNgayTiepNhan.Name = "DtpNgayTiepNhan"
        Me.DtpNgayTiepNhan.Size = New System.Drawing.Size(200, 20)
        Me.DtpNgayTiepNhan.TabIndex = 14
        '
        'CbMaDL
        '
        Me.CbMaDL.FormattingEnabled = True
        Me.CbMaDL.Location = New System.Drawing.Point(253, 257)
        Me.CbMaDL.Name = "CbMaDL"
        Me.CbMaDL.Size = New System.Drawing.Size(121, 21)
        Me.CbMaDL.TabIndex = 13
        '
        'TxbTongTriGia
        '
        Me.TxbTongTriGia.Location = New System.Drawing.Point(253, 329)
        Me.TxbTongTriGia.Name = "TxbTongTriGia"
        Me.TxbTongTriGia.Size = New System.Drawing.Size(233, 20)
        Me.TxbTongTriGia.TabIndex = 11
        '
        'TxbMaPhieuXuat
        '
        Me.TxbMaPhieuXuat.Location = New System.Drawing.Point(251, 65)
        Me.TxbMaPhieuXuat.Name = "TxbMaPhieuXuat"
        Me.TxbMaPhieuXuat.Size = New System.Drawing.Size(233, 20)
        Me.TxbMaPhieuXuat.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(126, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ngày Lập Phiếu :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(126, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tổng Trị Giá :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mã Đại Lý :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Mã Phiếu Xuất :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Quản Lý Phiếu Xuât"
        '
        'BtnXoa
        '
        Me.BtnXoa.Location = New System.Drawing.Point(360, 383)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(145, 55)
        Me.BtnXoa.TabIndex = 15
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'DgvDanhSachPhieuXuat
        '
        Me.DgvDanhSachPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDanhSachPhieuXuat.Location = New System.Drawing.Point(130, 91)
        Me.DgvDanhSachPhieuXuat.Name = "DgvDanhSachPhieuXuat"
        Me.DgvDanhSachPhieuXuat.Size = New System.Drawing.Size(354, 150)
        Me.DgvDanhSachPhieuXuat.TabIndex = 16
        '
        'QuanLyPhieuXuatFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 450)
        Me.Controls.Add(Me.DgvDanhSachPhieuXuat)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.BtnNhap)
        Me.Controls.Add(Me.DtpNgayTiepNhan)
        Me.Controls.Add(Me.CbMaDL)
        Me.Controls.Add(Me.TxbTongTriGia)
        Me.Controls.Add(Me.TxbMaPhieuXuat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QuanLyPhieuXuatFrm"
        Me.Text = "QuanLyPhieuXuatFrm"
        CType(Me.DgvDanhSachPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNhap As Button
    Friend WithEvents DtpNgayTiepNhan As DateTimePicker
    Friend WithEvents CbMaDL As ComboBox
    Friend WithEvents TxbTongTriGia As TextBox
    Friend WithEvents TxbMaPhieuXuat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnXoa As Button
    Friend WithEvents DgvDanhSachPhieuXuat As DataGridView
End Class
