<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLyDonViTinh
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
        Me.BtnCapNhap = New System.Windows.Forms.Button()
        Me.TxbTenDVT = New System.Windows.Forms.TextBox()
        Me.TxbMaDVT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.DgvDvt = New System.Windows.Forms.DataGridView()
        CType(Me.DgvDvt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCapNhap
        '
        Me.BtnCapNhap.Location = New System.Drawing.Point(69, 306)
        Me.BtnCapNhap.Name = "BtnCapNhap"
        Me.BtnCapNhap.Size = New System.Drawing.Size(119, 47)
        Me.BtnCapNhap.TabIndex = 10
        Me.BtnCapNhap.Text = "Cập Nhập"
        Me.BtnCapNhap.UseVisualStyleBackColor = True
        '
        'TxbTenDVT
        '
        Me.TxbTenDVT.Location = New System.Drawing.Point(190, 268)
        Me.TxbTenDVT.Name = "TxbTenDVT"
        Me.TxbTenDVT.Size = New System.Drawing.Size(222, 20)
        Me.TxbTenDVT.TabIndex = 8
        '
        'TxbMaDVT
        '
        Me.TxbMaDVT.Location = New System.Drawing.Point(190, 92)
        Me.TxbMaDVT.Name = "TxbMaDVT"
        Me.TxbMaDVT.Size = New System.Drawing.Size(222, 20)
        Me.TxbMaDVT.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tên Đơn Vị Tính :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mã Đơn Vị Tính :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Quản Lý Đơn Vị Tính"
        '
        'BtnXoa
        '
        Me.BtnXoa.Location = New System.Drawing.Point(293, 306)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(119, 47)
        Me.BtnXoa.TabIndex = 10
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'DgvDvt
        '
        Me.DgvDvt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDvt.Location = New System.Drawing.Point(43, 117)
        Me.DgvDvt.Name = "DgvDvt"
        Me.DgvDvt.Size = New System.Drawing.Size(369, 145)
        Me.DgvDvt.TabIndex = 11
        '
        'QuanLyDonViTinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 374)
        Me.Controls.Add(Me.DgvDvt)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.BtnCapNhap)
        Me.Controls.Add(Me.TxbTenDVT)
        Me.Controls.Add(Me.TxbMaDVT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QuanLyDonViTinh"
        Me.Text = "QuanLyDonViTinh"
        CType(Me.DgvDvt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCapNhap As Button
    Friend WithEvents TxbTenDVT As TextBox
    Friend WithEvents TxbMaDVT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnXoa As Button
    Friend WithEvents DgvDvt As DataGridView
End Class
