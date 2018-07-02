<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLyQuanFrm
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
        Me.TxbTenQuan = New System.Windows.Forms.TextBox()
        Me.TxbMaQuan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvQuan = New System.Windows.Forms.DataGridView()
        Me.BtnXoa = New System.Windows.Forms.Button()
        CType(Me.DgvQuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCapNhap
        '
        Me.BtnCapNhap.Location = New System.Drawing.Point(116, 294)
        Me.BtnCapNhap.Name = "BtnCapNhap"
        Me.BtnCapNhap.Size = New System.Drawing.Size(142, 53)
        Me.BtnCapNhap.TabIndex = 10
        Me.BtnCapNhap.Text = "Cập Nhập"
        Me.BtnCapNhap.UseVisualStyleBackColor = True
        '
        'TxbTenQuan
        '
        Me.TxbTenQuan.Location = New System.Drawing.Point(209, 235)
        Me.TxbTenQuan.Name = "TxbTenQuan"
        Me.TxbTenQuan.Size = New System.Drawing.Size(203, 20)
        Me.TxbTenQuan.TabIndex = 9
        '
        'TxbMaQuan
        '
        Me.TxbMaQuan.Location = New System.Drawing.Point(209, 53)
        Me.TxbMaQuan.Name = "TxbMaQuan"
        Me.TxbMaQuan.Size = New System.Drawing.Size(203, 20)
        Me.TxbMaQuan.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mã Quận :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tên Quận :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Quản Lý Quận"
        '
        'DgvQuan
        '
        Me.DgvQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvQuan.Location = New System.Drawing.Point(116, 79)
        Me.DgvQuan.Name = "DgvQuan"
        Me.DgvQuan.Size = New System.Drawing.Size(296, 132)
        Me.DgvQuan.TabIndex = 11
        '
        'BtnXoa
        '
        Me.BtnXoa.Location = New System.Drawing.Point(270, 294)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(142, 53)
        Me.BtnXoa.TabIndex = 10
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'QuanLyQuanFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 450)
        Me.Controls.Add(Me.DgvQuan)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.BtnCapNhap)
        Me.Controls.Add(Me.TxbTenQuan)
        Me.Controls.Add(Me.TxbMaQuan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QuanLyQuanFrm"
        Me.Text = "QuanLyQuanFrm"
        CType(Me.DgvQuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCapNhap As Button
    Friend WithEvents TxbTenQuan As TextBox
    Friend WithEvents TxbMaQuan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvQuan As DataGridView
    Friend WithEvents BtnXoa As Button
End Class
