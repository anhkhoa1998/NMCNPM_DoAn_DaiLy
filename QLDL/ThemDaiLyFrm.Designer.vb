<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemDaiLyFrm
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txbMaDL = New System.Windows.Forms.TextBox()
        Me.TxbTenDL = New System.Windows.Forms.TextBox()
        Me.TxbDienThoai = New System.Windows.Forms.TextBox()
        Me.TxbDiaChi = New System.Windows.Forms.TextBox()
        Me.TxbEmail = New System.Windows.Forms.TextBox()
        Me.TxbNoCuaDaiLy = New System.Windows.Forms.TextBox()
        Me.CbMaLoaiDaiLy = New System.Windows.Forms.ComboBox()
        Me.CbMaQuan = New System.Windows.Forms.ComboBox()
        Me.dtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.BtnNhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thêm Đại Lý"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Đại Lý :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên Đại Lý :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mã Loại Đại Lý :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(116, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Điện Thoại :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(116, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Địa Chỉ :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(116, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Mã Quận :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Ngày Tiếp Nhận :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(116, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Email :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(116, 405)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Nợ Của Đại Lý :"
        '
        'txbMaDL
        '
        Me.txbMaDL.Location = New System.Drawing.Point(235, 79)
        Me.txbMaDL.Name = "txbMaDL"
        Me.txbMaDL.Size = New System.Drawing.Size(335, 20)
        Me.txbMaDL.TabIndex = 2
        '
        'TxbTenDL
        '
        Me.TxbTenDL.Location = New System.Drawing.Point(235, 123)
        Me.TxbTenDL.Name = "TxbTenDL"
        Me.TxbTenDL.Size = New System.Drawing.Size(335, 20)
        Me.TxbTenDL.TabIndex = 2
        '
        'TxbDienThoai
        '
        Me.TxbDienThoai.Location = New System.Drawing.Point(235, 207)
        Me.TxbDienThoai.Name = "TxbDienThoai"
        Me.TxbDienThoai.Size = New System.Drawing.Size(335, 20)
        Me.TxbDienThoai.TabIndex = 2
        '
        'TxbDiaChi
        '
        Me.TxbDiaChi.Location = New System.Drawing.Point(235, 246)
        Me.TxbDiaChi.Name = "TxbDiaChi"
        Me.TxbDiaChi.Size = New System.Drawing.Size(335, 20)
        Me.TxbDiaChi.TabIndex = 2
        '
        'TxbEmail
        '
        Me.TxbEmail.Location = New System.Drawing.Point(235, 367)
        Me.TxbEmail.Name = "TxbEmail"
        Me.TxbEmail.Size = New System.Drawing.Size(335, 20)
        Me.TxbEmail.TabIndex = 2
        '
        'TxbNoCuaDaiLy
        '
        Me.TxbNoCuaDaiLy.Location = New System.Drawing.Point(235, 404)
        Me.TxbNoCuaDaiLy.Name = "TxbNoCuaDaiLy"
        Me.TxbNoCuaDaiLy.Size = New System.Drawing.Size(335, 20)
        Me.TxbNoCuaDaiLy.TabIndex = 2
        '
        'CbMaLoaiDaiLy
        '
        Me.CbMaLoaiDaiLy.FormattingEnabled = True
        Me.CbMaLoaiDaiLy.Location = New System.Drawing.Point(236, 167)
        Me.CbMaLoaiDaiLy.Name = "CbMaLoaiDaiLy"
        Me.CbMaLoaiDaiLy.Size = New System.Drawing.Size(127, 21)
        Me.CbMaLoaiDaiLy.TabIndex = 3
        '
        'CbMaQuan
        '
        Me.CbMaQuan.FormattingEnabled = True
        Me.CbMaQuan.Location = New System.Drawing.Point(236, 286)
        Me.CbMaQuan.Name = "CbMaQuan"
        Me.CbMaQuan.Size = New System.Drawing.Size(121, 21)
        Me.CbMaQuan.TabIndex = 4
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(236, 327)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayTiepNhan.TabIndex = 5
        '
        'BtnNhap
        '
        Me.BtnNhap.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNhap.Location = New System.Drawing.Point(300, 469)
        Me.BtnNhap.Name = "BtnNhap"
        Me.BtnNhap.Size = New System.Drawing.Size(149, 41)
        Me.BtnNhap.TabIndex = 6
        Me.BtnNhap.Text = "Nhập"
        Me.BtnNhap.UseVisualStyleBackColor = True
        '
        'ThemDaiLyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 522)
        Me.Controls.Add(Me.BtnNhap)
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "ThemDaiLyFrm"
        Me.Text = "ThemDaiLyFrm"
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
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txbMaDL As TextBox
    Friend WithEvents TxbTenDL As TextBox
    Friend WithEvents TxbDienThoai As TextBox
    Friend WithEvents TxbDiaChi As TextBox
    Friend WithEvents TxbEmail As TextBox
    Friend WithEvents TxbNoCuaDaiLy As TextBox
    Friend WithEvents CbMaLoaiDaiLy As ComboBox
    Friend WithEvents CbMaQuan As ComboBox
    Friend WithEvents dtpNgayTiepNhan As DateTimePicker
    Friend WithEvents BtnNhap As Button
End Class
