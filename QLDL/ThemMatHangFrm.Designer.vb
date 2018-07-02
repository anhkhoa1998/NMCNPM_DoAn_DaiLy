<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemMatHangFrm
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
        Me.TxbMaMatHang = New System.Windows.Forms.TextBox()
        Me.TxbTenMatHang = New System.Windows.Forms.TextBox()
        Me.TxbSoLuongTon = New System.Windows.Forms.TextBox()
        Me.BtnNhap = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbDonGiaBan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thêm Mặt Hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Mặt Hàng :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên Mặt Hàng :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Số Lượng Tồn :"
        '
        'TxbMaMatHang
        '
        Me.TxbMaMatHang.Location = New System.Drawing.Point(219, 77)
        Me.TxbMaMatHang.Name = "TxbMaMatHang"
        Me.TxbMaMatHang.Size = New System.Drawing.Size(301, 20)
        Me.TxbMaMatHang.TabIndex = 2
        '
        'TxbTenMatHang
        '
        Me.TxbTenMatHang.Location = New System.Drawing.Point(219, 134)
        Me.TxbTenMatHang.Name = "TxbTenMatHang"
        Me.TxbTenMatHang.Size = New System.Drawing.Size(301, 20)
        Me.TxbTenMatHang.TabIndex = 2
        '
        'TxbSoLuongTon
        '
        Me.TxbSoLuongTon.Location = New System.Drawing.Point(219, 188)
        Me.TxbSoLuongTon.Name = "TxbSoLuongTon"
        Me.TxbSoLuongTon.Size = New System.Drawing.Size(301, 20)
        Me.TxbSoLuongTon.TabIndex = 2
        '
        'BtnNhap
        '
        Me.BtnNhap.Location = New System.Drawing.Point(249, 293)
        Me.BtnNhap.Name = "BtnNhap"
        Me.BtnNhap.Size = New System.Drawing.Size(185, 56)
        Me.BtnNhap.TabIndex = 3
        Me.BtnNhap.Text = "Nhập"
        Me.BtnNhap.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Đơn Giá Bán :"
        '
        'TxbDonGiaBan
        '
        Me.TxbDonGiaBan.Location = New System.Drawing.Point(219, 239)
        Me.TxbDonGiaBan.Name = "TxbDonGiaBan"
        Me.TxbDonGiaBan.Size = New System.Drawing.Size(301, 20)
        Me.TxbDonGiaBan.TabIndex = 2
        '
        'ThemMatHangFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 379)
        Me.Controls.Add(Me.TxbDonGiaBan)
        Me.Controls.Add(Me.BtnNhap)
        Me.Controls.Add(Me.TxbSoLuongTon)
        Me.Controls.Add(Me.TxbTenMatHang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxbMaMatHang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ThemMatHangFrm"
        Me.Text = "ThemMatHangFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbMaMatHang As TextBox
    Friend WithEvents TxbTenMatHang As TextBox
    Friend WithEvents TxbSoLuongTon As TextBox
    Friend WithEvents BtnNhap As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbDonGiaBan As TextBox
End Class
