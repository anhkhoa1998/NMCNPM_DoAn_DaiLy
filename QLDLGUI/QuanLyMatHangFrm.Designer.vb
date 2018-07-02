<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuanLyMatHangFrm
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
        Me.TxbDonGiaBan = New System.Windows.Forms.TextBox()
        Me.BtnCapNhap = New System.Windows.Forms.Button()
        Me.TxbSoLuongTon = New System.Windows.Forms.TextBox()
        Me.TxbTenMatHang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbMaMatHang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvMatHang = New System.Windows.Forms.DataGridView()
        Me.BtnXoa = New System.Windows.Forms.Button()
        CType(Me.DgvMatHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxbDonGiaBan
        '
        Me.TxbDonGiaBan.Location = New System.Drawing.Point(257, 409)
        Me.TxbDonGiaBan.Name = "TxbDonGiaBan"
        Me.TxbDonGiaBan.Size = New System.Drawing.Size(301, 20)
        Me.TxbDonGiaBan.TabIndex = 9
        '
        'BtnCapNhap
        '
        Me.BtnCapNhap.Location = New System.Drawing.Point(120, 465)
        Me.BtnCapNhap.Name = "BtnCapNhap"
        Me.BtnCapNhap.Size = New System.Drawing.Size(185, 56)
        Me.BtnCapNhap.TabIndex = 13
        Me.BtnCapNhap.Text = "Cập Nhập"
        Me.BtnCapNhap.UseVisualStyleBackColor = True
        '
        'TxbSoLuongTon
        '
        Me.TxbSoLuongTon.Location = New System.Drawing.Point(257, 358)
        Me.TxbSoLuongTon.Name = "TxbSoLuongTon"
        Me.TxbSoLuongTon.Size = New System.Drawing.Size(301, 20)
        Me.TxbSoLuongTon.TabIndex = 10
        '
        'TxbTenMatHang
        '
        Me.TxbTenMatHang.Location = New System.Drawing.Point(257, 304)
        Me.TxbTenMatHang.Name = "TxbTenMatHang"
        Me.TxbTenMatHang.Size = New System.Drawing.Size(301, 20)
        Me.TxbTenMatHang.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(116, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Đơn Giá Bán :"
        '
        'TxbMaMatHang
        '
        Me.TxbMaMatHang.Location = New System.Drawing.Point(257, 66)
        Me.TxbMaMatHang.Name = "TxbMaMatHang"
        Me.TxbMaMatHang.Size = New System.Drawing.Size(301, 20)
        Me.TxbMaMatHang.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Số Lượng Tồn :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tên Mặt Hàng :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mã Mặt Hàng :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Quản Lý Mặt Hàng"
        '
        'DgvMatHang
        '
        Me.DgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMatHang.Location = New System.Drawing.Point(120, 124)
        Me.DgvMatHang.Name = "DgvMatHang"
        Me.DgvMatHang.Size = New System.Drawing.Size(459, 150)
        Me.DgvMatHang.TabIndex = 14
        '
        'BtnXoa
        '
        Me.BtnXoa.Location = New System.Drawing.Point(394, 465)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(185, 56)
        Me.BtnXoa.TabIndex = 13
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'QuanLyMatHangFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 533)
        Me.Controls.Add(Me.DgvMatHang)
        Me.Controls.Add(Me.TxbDonGiaBan)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.BtnCapNhap)
        Me.Controls.Add(Me.TxbSoLuongTon)
        Me.Controls.Add(Me.TxbTenMatHang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxbMaMatHang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QuanLyMatHangFrm"
        Me.Text = "QuanLyMatHangFrm"
        CType(Me.DgvMatHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxbDonGiaBan As TextBox
    Friend WithEvents BtnCapNhap As Button
    Friend WithEvents TxbSoLuongTon As TextBox
    Friend WithEvents TxbTenMatHang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbMaMatHang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvMatHang As DataGridView
    Friend WithEvents BtnXoa As Button
End Class
