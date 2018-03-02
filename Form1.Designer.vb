<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.Instructions_Button = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 202)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Start_Button
        '
        Me.Start_Button.Location = New System.Drawing.Point(112, 220)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(75, 23)
        Me.Start_Button.TabIndex = 1
        Me.Start_Button.Text = "Start"
        Me.Start_Button.UseVisualStyleBackColor = True
        '
        'Instructions_Button
        '
        Me.Instructions_Button.Location = New System.Drawing.Point(259, 220)
        Me.Instructions_Button.Name = "Instructions_Button"
        Me.Instructions_Button.Size = New System.Drawing.Size(75, 23)
        Me.Instructions_Button.TabIndex = 2
        Me.Instructions_Button.Text = "Instructions"
        Me.Instructions_Button.UseVisualStyleBackColor = True
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 251)
        Me.Controls.Add(Me.Instructions_Button)
        Me.Controls.Add(Me.Start_Button)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "StartForm"
        Me.Text = "Hero Dungeon"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Start_Button As System.Windows.Forms.Button
    Friend WithEvents Instructions_Button As System.Windows.Forms.Button

End Class
