<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        Me.Down_Button = New System.Windows.Forms.Button()
        Me.Right_Button = New System.Windows.Forms.Button()
        Me.Up_Button = New System.Windows.Forms.Button()
        Me.Left_Button = New System.Windows.Forms.Button()
        Me.Fight_Button = New System.Windows.Forms.Button()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PH = New System.Windows.Forms.Label()
        Me.Next_Button = New System.Windows.Forms.Button()
        Me.BookPictBox = New System.Windows.Forms.PictureBox()
        Me.BossPicBox = New System.Windows.Forms.PictureBox()
        Me.FirePicBox = New System.Windows.Forms.PictureBox()
        Me.TrollPicBox = New System.Windows.Forms.PictureBox()
        Me.SpiderPicBox = New System.Windows.Forms.PictureBox()
        Me.AlienPicBox = New System.Windows.Forms.PictureBox()
        Me.MonsterPicBox = New System.Windows.Forms.PictureBox()
        Me.HallPicBox = New System.Windows.Forms.PictureBox()
        CType(Me.BookPictBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BossPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrollPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpiderPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlienPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonsterPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HallPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Down_Button
        '
        Me.Down_Button.Location = New System.Drawing.Point(261, 341)
        Me.Down_Button.Name = "Down_Button"
        Me.Down_Button.Size = New System.Drawing.Size(56, 23)
        Me.Down_Button.TabIndex = 0
        Me.Down_Button.Text = "DOWN"
        Me.Down_Button.UseVisualStyleBackColor = True
        '
        'Right_Button
        '
        Me.Right_Button.Location = New System.Drawing.Point(324, 312)
        Me.Right_Button.Name = "Right_Button"
        Me.Right_Button.Size = New System.Drawing.Size(56, 23)
        Me.Right_Button.TabIndex = 1
        Me.Right_Button.Text = "RIGHT"
        Me.Right_Button.UseVisualStyleBackColor = True
        '
        'Up_Button
        '
        Me.Up_Button.Location = New System.Drawing.Point(262, 283)
        Me.Up_Button.Name = "Up_Button"
        Me.Up_Button.Size = New System.Drawing.Size(56, 23)
        Me.Up_Button.TabIndex = 2
        Me.Up_Button.Text = "UP"
        Me.Up_Button.UseVisualStyleBackColor = True
        '
        'Left_Button
        '
        Me.Left_Button.Location = New System.Drawing.Point(200, 312)
        Me.Left_Button.Name = "Left_Button"
        Me.Left_Button.Size = New System.Drawing.Size(56, 23)
        Me.Left_Button.TabIndex = 3
        Me.Left_Button.Text = "LEFT"
        Me.Left_Button.UseVisualStyleBackColor = True
        '
        'Fight_Button
        '
        Me.Fight_Button.Location = New System.Drawing.Point(262, 312)
        Me.Fight_Button.Name = "Fight_Button"
        Me.Fight_Button.Size = New System.Drawing.Size(56, 23)
        Me.Fight_Button.TabIndex = 4
        Me.Fight_Button.Text = "FIGHT"
        Me.Fight_Button.UseVisualStyleBackColor = True
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(263, 312)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(55, 23)
        Me.Save_Button.TabIndex = 14
        Me.Save_Button.Text = "Save Princess"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(12, 257)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ReadOnly = True
        Me.TextBox.Size = New System.Drawing.Size(537, 20)
        Me.TextBox.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(441, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Health:"
        '
        'PH
        '
        Me.PH.AutoSize = True
        Me.PH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PH.Location = New System.Drawing.Point(514, 9)
        Me.PH.Name = "PH"
        Me.PH.Size = New System.Drawing.Size(20, 20)
        Me.PH.TabIndex = 18
        Me.PH.Text = "P"
        '
        'Next_Button
        '
        Me.Next_Button.Location = New System.Drawing.Point(263, 312)
        Me.Next_Button.Name = "Next_Button"
        Me.Next_Button.Size = New System.Drawing.Size(55, 23)
        Me.Next_Button.TabIndex = 20
        Me.Next_Button.Text = "Next"
        Me.Next_Button.UseVisualStyleBackColor = True
        '
        'BookPictBox
        '
        Me.BookPictBox.Image = Global.WindowsApplication1.My.Resources.Resources.Hallway_book
        Me.BookPictBox.Location = New System.Drawing.Point(151, 23)
        Me.BookPictBox.Name = "BookPictBox"
        Me.BookPictBox.Size = New System.Drawing.Size(274, 228)
        Me.BookPictBox.TabIndex = 27
        Me.BookPictBox.TabStop = False
        '
        'BossPicBox
        '
        Me.BossPicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Hallway_final_boss
        Me.BossPicBox.Location = New System.Drawing.Point(151, 23)
        Me.BossPicBox.Name = "BossPicBox"
        Me.BossPicBox.Size = New System.Drawing.Size(274, 228)
        Me.BossPicBox.TabIndex = 26
        Me.BossPicBox.TabStop = False
        '
        'FirePicBox
        '
        Me.FirePicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Hallway_fire
        Me.FirePicBox.Location = New System.Drawing.Point(151, 23)
        Me.FirePicBox.Name = "FirePicBox"
        Me.FirePicBox.Size = New System.Drawing.Size(274, 228)
        Me.FirePicBox.TabIndex = 25
        Me.FirePicBox.TabStop = False
        '
        'TrollPicBox
        '
        Me.TrollPicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Hallway_troll
        Me.TrollPicBox.Location = New System.Drawing.Point(151, 23)
        Me.TrollPicBox.Name = "TrollPicBox"
        Me.TrollPicBox.Size = New System.Drawing.Size(274, 228)
        Me.TrollPicBox.TabIndex = 24
        Me.TrollPicBox.TabStop = False
        '
        'SpiderPicBox
        '
        Me.SpiderPicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Hallway_spider
        Me.SpiderPicBox.Location = New System.Drawing.Point(151, 23)
        Me.SpiderPicBox.Name = "SpiderPicBox"
        Me.SpiderPicBox.Size = New System.Drawing.Size(274, 228)
        Me.SpiderPicBox.TabIndex = 23
        Me.SpiderPicBox.TabStop = False
        '
        'AlienPicBox
        '
        Me.AlienPicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Hallway_alien_princess
        Me.AlienPicBox.Location = New System.Drawing.Point(151, 23)
        Me.AlienPicBox.Name = "AlienPicBox"
        Me.AlienPicBox.Size = New System.Drawing.Size(274, 228)
        Me.AlienPicBox.TabIndex = 22
        Me.AlienPicBox.TabStop = False
        '
        'MonsterPicBox
        '
        Me.MonsterPicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Hallway_monster
        Me.MonsterPicBox.Location = New System.Drawing.Point(151, 23)
        Me.MonsterPicBox.Name = "MonsterPicBox"
        Me.MonsterPicBox.Size = New System.Drawing.Size(274, 228)
        Me.MonsterPicBox.TabIndex = 21
        Me.MonsterPicBox.TabStop = False
        '
        'HallPicBox
        '
        Me.HallPicBox.Image = CType(resources.GetObject("HallPicBox.Image"), System.Drawing.Image)
        Me.HallPicBox.Location = New System.Drawing.Point(151, 23)
        Me.HallPicBox.Name = "HallPicBox"
        Me.HallPicBox.Size = New System.Drawing.Size(274, 228)
        Me.HallPicBox.TabIndex = 6
        Me.HallPicBox.TabStop = False
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 377)
        Me.Controls.Add(Me.BookPictBox)
        Me.Controls.Add(Me.BossPicBox)
        Me.Controls.Add(Me.FirePicBox)
        Me.Controls.Add(Me.TrollPicBox)
        Me.Controls.Add(Me.SpiderPicBox)
        Me.Controls.Add(Me.AlienPicBox)
        Me.Controls.Add(Me.MonsterPicBox)
        Me.Controls.Add(Me.Next_Button)
        Me.Controls.Add(Me.PH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(Me.HallPicBox)
        Me.Controls.Add(Me.Fight_Button)
        Me.Controls.Add(Me.Left_Button)
        Me.Controls.Add(Me.Up_Button)
        Me.Controls.Add(Me.Right_Button)
        Me.Controls.Add(Me.Down_Button)
        Me.Name = "GameForm"
        Me.Text = "Hero Dungeon "
        CType(Me.BookPictBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BossPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrollPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpiderPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlienPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonsterPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HallPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Down_Button As System.Windows.Forms.Button
    Friend WithEvents Right_Button As System.Windows.Forms.Button
    Friend WithEvents Up_Button As System.Windows.Forms.Button
    Friend WithEvents Left_Button As System.Windows.Forms.Button
    Friend WithEvents Fight_Button As System.Windows.Forms.Button
    Friend WithEvents HallPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Save_Button As System.Windows.Forms.Button
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PH As System.Windows.Forms.Label
    Friend WithEvents Next_Button As System.Windows.Forms.Button
    Friend WithEvents MonsterPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents AlienPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents SpiderPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents TrollPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents FirePicBox As System.Windows.Forms.PictureBox
    Friend WithEvents BossPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents BookPictBox As System.Windows.Forms.PictureBox
End Class
