<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHomePage))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnRegisterUser = New System.Windows.Forms.Button()
        Me.btnAuditlogs = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1202, 694)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(321, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(611, 56)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Traders Convenience Store"
        '
        'btnInventory
        '
        Me.btnInventory.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Location = New System.Drawing.Point(817, 286)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(312, 94)
        Me.btnInventory.TabIndex = 17
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnRegisterUser
        '
        Me.btnRegisterUser.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterUser.Location = New System.Drawing.Point(85, 286)
        Me.btnRegisterUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegisterUser.Name = "btnRegisterUser"
        Me.btnRegisterUser.Size = New System.Drawing.Size(312, 94)
        Me.btnRegisterUser.TabIndex = 18
        Me.btnRegisterUser.Text = "Register New User"
        Me.btnRegisterUser.UseVisualStyleBackColor = True
        '
        'btnAuditlogs
        '
        Me.btnAuditlogs.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuditlogs.Location = New System.Drawing.Point(455, 286)
        Me.btnAuditlogs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAuditlogs.Name = "btnAuditlogs"
        Me.btnAuditlogs.Size = New System.Drawing.Size(312, 94)
        Me.btnAuditlogs.TabIndex = 19
        Me.btnAuditlogs.Text = "Audit Logs"
        Me.btnAuditlogs.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(917, 547)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(212, 70)
        Me.btnLogout.TabIndex = 20
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AdminHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnAuditlogs)
        Me.Controls.Add(Me.btnRegisterUser)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AdminHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnRegisterUser As Button
    Friend WithEvents btnAuditlogs As Button
    Friend WithEvents btnLogout As Button
End Class
