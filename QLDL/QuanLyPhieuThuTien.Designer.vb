<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLyPhieuThuTien
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
        Me.DtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.CbMaDaiLy = New System.Windows.Forms.ComboBox()
        Me.TxbSoTienThu = New System.Windows.Forms.TextBox()
        Me.TxbMaPhieuThu = New System.Windows.Forms.TextBox()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCapNhap = New System.Windows.Forms.Button()
        Me.DgvPhieuThu = New System.Windows.Forms.DataGridView()
        CType(Me.DgvPhieuThu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpNgayThuTien
        '
        Me.DtpNgayThuTien.Location = New System.Drawing.Point(290, 348)
        Me.DtpNgayThuTien.Name = "DtpNgayThuTien"
        Me.DtpNgayThuTien.Size = New System.Drawing.Size(200, 20)
        Me.DtpNgayThuTien.TabIndex = 15
        '
        'CbMaDaiLy
        '
        Me.CbMaDaiLy.FormattingEnabled = True
        Me.CbMaDaiLy.Location = New System.Drawing.Point(290, 309)
        Me.CbMaDaiLy.Name = "CbMaDaiLy"
        Me.CbMaDaiLy.Size = New System.Drawing.Size(121, 21)
        Me.CbMaDaiLy.TabIndex = 14
        '
        'TxbSoTienThu
        '
        Me.TxbSoTienThu.Location = New System.Drawing.Point(290, 391)
        Me.TxbSoTienThu.Name = "TxbSoTienThu"
        Me.TxbSoTienThu.Size = New System.Drawing.Size(258, 20)
        Me.TxbSoTienThu.TabIndex = 12
        '
        'TxbMaPhieuThu
        '
        Me.TxbMaPhieuThu.Location = New System.Drawing.Point(290, 82)
        Me.TxbMaPhieuThu.Name = "TxbMaPhieuThu"
        Me.TxbMaPhieuThu.Size = New System.Drawing.Size(258, 20)
        Me.TxbMaPhieuThu.TabIndex = 13
        '
        'BtnXoa
        '
        Me.BtnXoa.Location = New System.Drawing.Point(433, 445)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(115, 55)
        Me.BtnXoa.TabIndex = 11
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(138, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Số Tiền Thu :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(138, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ngày Thu Tiền :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mã Đại Lý :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Mã Phiếu Thu :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Quản Lý Phiếu Thu Tiền"
        '
        'BtnCapNhap
        '
        Me.BtnCapNhap.Location = New System.Drawing.Point(147, 445)
        Me.BtnCapNhap.Name = "BtnCapNhap"
        Me.BtnCapNhap.Size = New System.Drawing.Size(115, 55)
        Me.BtnCapNhap.TabIndex = 11
        Me.BtnCapNhap.Text = "Cập Nhập"
        Me.BtnCapNhap.UseVisualStyleBackColor = True
        '
        'DgvPhieuThu
        '
        Me.DgvPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPhieuThu.Location = New System.Drawing.Point(142, 119)
        Me.DgvPhieuThu.Name = "DgvPhieuThu"
        Me.DgvPhieuThu.Size = New System.Drawing.Size(406, 150)
        Me.DgvPhieuThu.TabIndex = 16
        '
        'QuanLyPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 525)
        Me.Controls.Add(Me.DgvPhieuThu)
        Me.Controls.Add(Me.DtpNgayThuTien)
        Me.Controls.Add(Me.CbMaDaiLy)
        Me.Controls.Add(Me.TxbSoTienThu)
        Me.Controls.Add(Me.TxbMaPhieuThu)
        Me.Controls.Add(Me.BtnCapNhap)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QuanLyPhieuThuTien"
        Me.Text = "QuanLyPhieuThuTien"
        CType(Me.DgvPhieuThu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpNgayThuTien As DateTimePicker
    Friend WithEvents CbMaDaiLy As ComboBox
    Friend WithEvents TxbSoTienThu As TextBox
    Friend WithEvents TxbMaPhieuThu As TextBox
    Friend WithEvents BtnXoa As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCapNhap As Button
    Friend WithEvents DgvPhieuThu As DataGridView
End Class
