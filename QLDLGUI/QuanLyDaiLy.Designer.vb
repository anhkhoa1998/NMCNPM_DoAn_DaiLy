<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuanLyDaiLy
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
        Me.dtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.CbMaQuan = New System.Windows.Forms.ComboBox()
        Me.CbMaLoaiDaiLy = New System.Windows.Forms.ComboBox()
        Me.TxbNoCuaDaiLy = New System.Windows.Forms.TextBox()
        Me.TxbEmail = New System.Windows.Forms.TextBox()
        Me.TxbDiaChi = New System.Windows.Forms.TextBox()
        Me.TxbDienThoai = New System.Windows.Forms.TextBox()
        Me.TxbTenDL = New System.Windows.Forms.TextBox()
        Me.txbMaDL = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvDanhSachDaiLy = New System.Windows.Forms.DataGridView()
        Me.BtnCapNhap = New System.Windows.Forms.Button()
        Me.BtnXoa = New System.Windows.Forms.Button()
        CType(Me.DgvDanhSachDaiLy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(279, 533)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayTiepNhan.TabIndex = 23
        '
        'CbMaQuan
        '
        Me.CbMaQuan.FormattingEnabled = True
        Me.CbMaQuan.Location = New System.Drawing.Point(279, 492)
        Me.CbMaQuan.Name = "CbMaQuan"
        Me.CbMaQuan.Size = New System.Drawing.Size(121, 21)
        Me.CbMaQuan.TabIndex = 22
        '
        'CbMaLoaiDaiLy
        '
        Me.CbMaLoaiDaiLy.FormattingEnabled = True
        Me.CbMaLoaiDaiLy.Location = New System.Drawing.Point(279, 373)
        Me.CbMaLoaiDaiLy.Name = "CbMaLoaiDaiLy"
        Me.CbMaLoaiDaiLy.Size = New System.Drawing.Size(127, 21)
        Me.CbMaLoaiDaiLy.TabIndex = 21
        '
        'TxbNoCuaDaiLy
        '
        Me.TxbNoCuaDaiLy.Location = New System.Drawing.Point(278, 610)
        Me.TxbNoCuaDaiLy.Name = "TxbNoCuaDaiLy"
        Me.TxbNoCuaDaiLy.Size = New System.Drawing.Size(335, 20)
        Me.TxbNoCuaDaiLy.TabIndex = 19
        '
        'TxbEmail
        '
        Me.TxbEmail.Location = New System.Drawing.Point(278, 573)
        Me.TxbEmail.Name = "TxbEmail"
        Me.TxbEmail.Size = New System.Drawing.Size(335, 20)
        Me.TxbEmail.TabIndex = 18
        '
        'TxbDiaChi
        '
        Me.TxbDiaChi.Location = New System.Drawing.Point(278, 452)
        Me.TxbDiaChi.Name = "TxbDiaChi"
        Me.TxbDiaChi.Size = New System.Drawing.Size(335, 20)
        Me.TxbDiaChi.TabIndex = 17
        '
        'TxbDienThoai
        '
        Me.TxbDienThoai.Location = New System.Drawing.Point(278, 413)
        Me.TxbDienThoai.Name = "TxbDienThoai"
        Me.TxbDienThoai.Size = New System.Drawing.Size(335, 20)
        Me.TxbDienThoai.TabIndex = 16
        '
        'TxbTenDL
        '
        Me.TxbTenDL.Location = New System.Drawing.Point(278, 329)
        Me.TxbTenDL.Name = "TxbTenDL"
        Me.TxbTenDL.Size = New System.Drawing.Size(335, 20)
        Me.TxbTenDL.TabIndex = 20
        '
        'txbMaDL
        '
        Me.txbMaDL.Location = New System.Drawing.Point(278, 60)
        Me.txbMaDL.Name = "txbMaDL"
        Me.txbMaDL.Size = New System.Drawing.Size(335, 20)
        Me.txbMaDL.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(159, 611)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 19)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Nợ Của Đại Lý :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(159, 574)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Email :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(159, 535)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Ngày Tiếp Nhận :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(159, 495)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Mã Quận :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(159, 453)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Địa Chỉ :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Điện Thoại :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mã Loại Đại Lý :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tên Đại Lý :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mã Đại Lý :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "QUẢN LÝ ĐẠI LÝ"
        '
        'DgvDanhSachDaiLy
        '
        Me.DgvDanhSachDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDanhSachDaiLy.Location = New System.Drawing.Point(12, 104)
        Me.DgvDanhSachDaiLy.Name = "DgvDanhSachDaiLy"
        Me.DgvDanhSachDaiLy.Size = New System.Drawing.Size(768, 219)
        Me.DgvDanhSachDaiLy.TabIndex = 25
        '
        'BtnCapNhap
        '
        Me.BtnCapNhap.Location = New System.Drawing.Point(238, 651)
        Me.BtnCapNhap.Name = "BtnCapNhap"
        Me.BtnCapNhap.Size = New System.Drawing.Size(128, 42)
        Me.BtnCapNhap.TabIndex = 26
        Me.BtnCapNhap.Text = "Cập Nhập"
        Me.BtnCapNhap.UseVisualStyleBackColor = True
        '
        'BtnXoa
        '
        Me.BtnXoa.Location = New System.Drawing.Point(451, 651)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(128, 42)
        Me.BtnXoa.TabIndex = 26
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'QuanLyDaiLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 733)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.BtnCapNhap)
        Me.Controls.Add(Me.DgvDanhSachDaiLy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpNgayTiepNhan)
        Me.Controls.Add(Me.CbMaQuan)
        Me.Controls.Add(Me.CbMaLoaiDaiLy)
        Me.Controls.Add(Me.TxbNoCuaDaiLy)
        Me.Controls.Add(Me.TxbEmail)
        Me.Controls.Add(Me.TxbDiaChi)
        Me.Controls.Add(Me.TxbDienThoai)
        Me.Controls.Add(Me.TxbTenDL)
        Me.Controls.Add(Me.txbMaDL)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "QuanLyDaiLy"
        Me.Text = "QuanLyDaiLy"
        CType(Me.DgvDanhSachDaiLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpNgayTiepNhan As DateTimePicker
    Friend WithEvents CbMaQuan As ComboBox
    Friend WithEvents CbMaLoaiDaiLy As ComboBox
    Friend WithEvents TxbNoCuaDaiLy As TextBox
    Friend WithEvents TxbEmail As TextBox
    Friend WithEvents TxbDiaChi As TextBox
    Friend WithEvents TxbDienThoai As TextBox
    Friend WithEvents TxbTenDL As TextBox
    Friend WithEvents txbMaDL As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvDanhSachDaiLy As DataGridView
    Friend WithEvents BtnCapNhap As Button
    Friend WithEvents BtnXoa As Button
End Class
