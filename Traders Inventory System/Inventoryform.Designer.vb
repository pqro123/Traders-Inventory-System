<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1202, 694)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(33, 189)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Item Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(33, 277)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 42)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Quantity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(33, 360)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 42)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Price:"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(326, 189)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtItemName.Multiline = True
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(176, 42)
        Me.txtItemName.TabIndex = 12
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(326, 277)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(176, 42)
        Me.txtQuantity.TabIndex = 13
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(326, 360)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(176, 42)
        Me.txtPrice.TabIndex = 14
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(18, 443)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(156, 52)
        Me.btnAddItem.TabIndex = 17
        Me.btnAddItem.Text = "ADD ITEM"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateItem.Location = New System.Drawing.Point(183, 443)
        Me.btnUpdateItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Size = New System.Drawing.Size(156, 52)
        Me.btnUpdateItem.TabIndex = 18
        Me.btnUpdateItem.Text = "UPDATE ITEM"
        Me.btnUpdateItem.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.Location = New System.Drawing.Point(348, 443)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(156, 52)
        Me.btnDeleteItem.TabIndex = 19
        Me.btnDeleteItem.Text = "DELETE ITEM"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(378, 45)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(477, 44)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Traders Convenience Store"
        '
        'dgvInventory
        '
        Me.dgvInventory.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(620, 189)
        Me.dgvInventory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowHeadersWidth = 62
        Me.dgvInventory.Size = New System.Drawing.Size(528, 306)
        Me.dgvInventory.TabIndex = 21
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(811, 557)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(156, 52)
        Me.btnLogout.TabIndex = 22
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(992, 557)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(156, 52)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traders Convenience Store"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnUpdateItem As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnBack As Button
End Class
