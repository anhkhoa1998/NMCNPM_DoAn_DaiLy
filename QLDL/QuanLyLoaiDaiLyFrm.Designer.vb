﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuanLyLoaiDaiLyFrm
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
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.TxbNoToiDa = New System.Windows.Forms.TextBox()
        Me.TxbTenldl = New System.Windows.Forms.TextBox()
        Me.TxbMaldl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvListLoaiDaiLy = New System.Windows.Forms.DataGridView()
        Me.BtnCapNhap = New System.Windows.Forms.Button()
        CType(Me.DgvListLoaiDaiLy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnXoa
        '
        Me.BtnXoa.Location = New System.Drawing.Point(309, 344)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(157, 56)
        Me.BtnXoa.TabIndex = 13
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'TxbNoToiDa
        '
        Me.TxbNoToiDa.Location = New System.Drawing.Point(217, 287)
        Me.TxbNoToiDa.Name = "TxbNoToiDa"
        Me.TxbNoToiDa.Size = New System.Drawing.Size(249, 20)
        Me.TxbNoToiDa.TabIndex = 10
        '
        'TxbTenldl
        '
        Me.TxbTenldl.Location = New System.Drawing.Point(217, 251)
        Me.TxbTenldl.Name = "TxbTenldl"
        Me.TxbTenldl.Size = New System.Drawing.Size(249, 20)
        Me.TxbTenldl.TabIndex = 11
        '
        'TxbMaldl
        '
        Me.TxbMaldl.Location = New System.Drawing.Point(217, 51)
        Me.TxbMaldl.Name = "TxbMaldl"
        Me.TxbMaldl.Size = New System.Drawing.Size(249, 20)
        Me.TxbMaldl.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nợ Tối Đa :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tên Loại Đại Lý :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mã Loại Đại Lý :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Thêm Loại Đại Lý"
        '
        'DgvListLoaiDaiLy
        '
        Me.DgvListLoaiDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListLoaiDaiLy.Location = New System.Drawing.Point(93, 77)
        Me.DgvListLoaiDaiLy.Name = "DgvListLoaiDaiLy"
        Me.DgvListLoaiDaiLy.Size = New System.Drawing.Size(404, 150)
        Me.DgvListLoaiDaiLy.TabIndex = 14
        '
        'BtnCapNhap
        '
        Me.BtnCapNhap.Location = New System.Drawing.Point(93, 344)
        Me.BtnCapNhap.Name = "BtnCapNhap"
        Me.BtnCapNhap.Size = New System.Drawing.Size(157, 56)
        Me.BtnCapNhap.TabIndex = 13
        Me.BtnCapNhap.Text = "Cập Nhập"
        Me.BtnCapNhap.UseVisualStyleBackColor = True
        '
        'QuanLyLoaiDaiLyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 450)
        Me.Controls.Add(Me.DgvListLoaiDaiLy)
        Me.Controls.Add(Me.BtnCapNhap)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.TxbNoToiDa)
        Me.Controls.Add(Me.TxbTenldl)
        Me.Controls.Add(Me.TxbMaldl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QuanLyLoaiDaiLyFrm"
        Me.Text = "QuanLyLoaiDaiLyFrm"
        CType(Me.DgvListLoaiDaiLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnXoa As Button
    Friend WithEvents TxbNoToiDa As TextBox
    Friend WithEvents TxbTenldl As TextBox
    Friend WithEvents TxbMaldl As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvListLoaiDaiLy As DataGridView
    Friend WithEvents BtnCapNhap As Button
End Class
