<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tStok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tHarga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tKategori = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bClear = New System.Windows.Forms.Button()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bCreate = New System.Windows.Forms.Button()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.tSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tStok)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tHarga)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tKategori)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.bClear)
        Me.Panel1.Controls.Add(Me.bDelete)
        Me.Panel1.Controls.Add(Me.bEdit)
        Me.Panel1.Controls.Add(Me.tNama)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.bCreate)
        Me.Panel1.Location = New System.Drawing.Point(6, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 274)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(207, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(380, 42)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Data Persediaan Barang"
        '
        'tStok
        '
        Me.tStok.Location = New System.Drawing.Point(129, 186)
        Me.tStok.Name = "tStok"
        Me.tStok.Size = New System.Drawing.Size(142, 22)
        Me.tStok.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Stok"
        '
        'tHarga
        '
        Me.tHarga.Location = New System.Drawing.Point(129, 158)
        Me.tHarga.Name = "tHarga"
        Me.tHarga.Size = New System.Drawing.Size(208, 22)
        Me.tHarga.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Harga"
        '
        'tKategori
        '
        Me.tKategori.Location = New System.Drawing.Point(129, 130)
        Me.tKategori.Name = "tKategori"
        Me.tKategori.Size = New System.Drawing.Size(208, 22)
        Me.tKategori.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kategori"
        '
        'bClear
        '
        Me.bClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bClear.Location = New System.Drawing.Point(129, 230)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(86, 33)
        Me.bClear.TabIndex = 5
        Me.bClear.Text = "Clear"
        Me.bClear.UseVisualStyleBackColor = False
        '
        'bDelete
        '
        Me.bDelete.BackColor = System.Drawing.Color.Tomato
        Me.bDelete.ForeColor = System.Drawing.Color.White
        Me.bDelete.Location = New System.Drawing.Point(597, 230)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Size = New System.Drawing.Size(94, 33)
        Me.bDelete.TabIndex = 4
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = False
        '
        'bEdit
        '
        Me.bEdit.BackColor = System.Drawing.Color.Yellow
        Me.bEdit.Location = New System.Drawing.Point(496, 230)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(94, 33)
        Me.bEdit.TabIndex = 3
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = False
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(129, 102)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(261, 22)
        Me.tNama.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Barang "
        '
        'bCreate
        '
        Me.bCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bCreate.ForeColor = System.Drawing.Color.White
        Me.bCreate.Location = New System.Drawing.Point(396, 230)
        Me.bCreate.Name = "bCreate"
        Me.bCreate.Size = New System.Drawing.Size(94, 33)
        Me.bCreate.TabIndex = 0
        Me.bCreate.Text = "Create"
        Me.bCreate.UseVisualStyleBackColor = False
        '
        'dg1
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(6, 338)
        Me.dg1.Name = "dg1"
        Me.dg1.RowHeadersWidth = 51
        Me.dg1.RowTemplate.Height = 24
        Me.dg1.Size = New System.Drawing.Size(785, 200)
        Me.dg1.TabIndex = 1
        '
        'tSearch
        '
        Me.tSearch.Location = New System.Drawing.Point(74, 301)
        Me.tSearch.Name = "tSearch"
        Me.tSearch.Size = New System.Drawing.Size(717, 22)
        Me.tSearch.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Search"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.tSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Beta Mart"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents tStok As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tHarga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tKategori As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bClear As Button
    Friend WithEvents bDelete As Button
    Friend WithEvents bEdit As Button
    Friend WithEvents tNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bCreate As Button
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents tSearch As TextBox
    Friend WithEvents Label6 As Label
End Class
