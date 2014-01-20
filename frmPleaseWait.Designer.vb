<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPleaseWait
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPleaseWait))
        Me.pic_PleaseWait = New System.Windows.Forms.PictureBox()
        CType(Me.pic_PleaseWait, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_PleaseWait
        '
        Me.pic_PleaseWait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_PleaseWait.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_PleaseWait.Image = CType(resources.GetObject("pic_PleaseWait.Image"), System.Drawing.Image)
        Me.pic_PleaseWait.Location = New System.Drawing.Point(0, 0)
        Me.pic_PleaseWait.Name = "pic_PleaseWait"
        Me.pic_PleaseWait.Size = New System.Drawing.Size(577, 273)
        Me.pic_PleaseWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_PleaseWait.TabIndex = 0
        Me.pic_PleaseWait.TabStop = False
        '
        'frmPleaseWait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 273)
        Me.Controls.Add(Me.pic_PleaseWait)
        Me.Name = "frmPleaseWait"
        Me.Text = "frmPleaseWait"
        CType(Me.pic_PleaseWait, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pic_PleaseWait As System.Windows.Forms.PictureBox
End Class
