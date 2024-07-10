<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(801, 451)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(206, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "New Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(206, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "New Password:"
        '
        'txtNewUsername
        '
        Me.txtNewUsername.Location = New System.Drawing.Point(447, 153)
        Me.txtNewUsername.Multiline = True
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(191, 29)
        Me.txtNewUsername.TabIndex = 10
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(447, 211)
        Me.txtNewPassword.Multiline = True
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(191, 29)
        Me.txtNewPassword.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(244, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Traders Convenience Store"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(298, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 31)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Register New User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(206, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Role:"
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(447, 270)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(191, 21)
        Me.cmbRole.TabIndex = 15
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(340, 319)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(141, 48)
        Me.btnAddUser.TabIndex = 16
        Me.btnAddUser.Text = "ADD USER"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(647, 390)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(141, 48)
        Me.btnLogout.TabIndex = 17
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtNewUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traders Convenience Store"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnLogout As Button
End Class
