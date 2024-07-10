<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditLogs
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
        Me.dgvAuditLogs = New System.Windows.Forms.DataGridView()
        Me.BtnBack = New System.Windows.Forms.Button()
        CType(Me.dgvAuditLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAuditLogs
        '
        Me.dgvAuditLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAuditLogs.Location = New System.Drawing.Point(56, 38)
        Me.dgvAuditLogs.Name = "dgvAuditLogs"
        Me.dgvAuditLogs.RowHeadersWidth = 62
        Me.dgvAuditLogs.RowTemplate.Height = 28
        Me.dgvAuditLogs.Size = New System.Drawing.Size(676, 310)
        Me.dgvAuditLogs.TabIndex = 0
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(569, 371)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(163, 67)
        Me.BtnBack.TabIndex = 1
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'AuditLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.dgvAuditLogs)
        Me.Name = "AuditLogs"
        Me.Text = "AuditLogs"
        CType(Me.dgvAuditLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAuditLogs As DataGridView
    Friend WithEvents BtnBack As Button
End Class
