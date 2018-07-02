<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoDoanhSo
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
        Me.TxbThang = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnLayDoanhSo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Báo cáo doanh số"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tháng:"
        '
        'TxbThang
        '
        Me.TxbThang.Location = New System.Drawing.Point(239, 66)
        Me.TxbThang.Name = "TxbThang"
        Me.TxbThang.Size = New System.Drawing.Size(256, 20)
        Me.TxbThang.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(68, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(652, 252)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnLayDoanhSo
        '
        Me.BtnLayDoanhSo.Location = New System.Drawing.Point(546, 57)
        Me.BtnLayDoanhSo.Name = "BtnLayDoanhSo"
        Me.BtnLayDoanhSo.Size = New System.Drawing.Size(123, 35)
        Me.BtnLayDoanhSo.TabIndex = 4
        Me.BtnLayDoanhSo.Text = "Lấy Doanh Số"
        Me.BtnLayDoanhSo.UseVisualStyleBackColor = True
        '
        'BaoCaoDoanhSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 408)
        Me.Controls.Add(Me.BtnLayDoanhSo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxbThang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BaoCaoDoanhSo"
        Me.Text = "BaoCaoDoanhSo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbThang As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnLayDoanhSo As Button
End Class
