<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuboidMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuboidMenu))
        Me.txt_CuboidInputLength = New System.Windows.Forms.TextBox()
        Me.txt_CuboidInputWidth = New System.Windows.Forms.TextBox()
        Me.txt_CuboidInputHeight = New System.Windows.Forms.TextBox()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.lbl_CuboidVolumeOutput = New System.Windows.Forms.Label()
        Me.btn_CalculateCuboidVolume = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_CuboidInputLength
        '
        Me.txt_CuboidInputLength.Location = New System.Drawing.Point(388, 252)
        Me.txt_CuboidInputLength.Name = "txt_CuboidInputLength"
        Me.txt_CuboidInputLength.Size = New System.Drawing.Size(111, 20)
        Me.txt_CuboidInputLength.TabIndex = 1
        '
        'txt_CuboidInputWidth
        '
        Me.txt_CuboidInputWidth.Location = New System.Drawing.Point(388, 292)
        Me.txt_CuboidInputWidth.Name = "txt_CuboidInputWidth"
        Me.txt_CuboidInputWidth.Size = New System.Drawing.Size(111, 20)
        Me.txt_CuboidInputWidth.TabIndex = 2
        '
        'txt_CuboidInputHeight
        '
        Me.txt_CuboidInputHeight.Location = New System.Drawing.Point(388, 327)
        Me.txt_CuboidInputHeight.Name = "txt_CuboidInputHeight"
        Me.txt_CuboidInputHeight.Size = New System.Drawing.Size(111, 20)
        Me.txt_CuboidInputHeight.TabIndex = 3
        '
        'Btn_Back
        '
        Me.Btn_Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Back.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Back.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Back.Image = CType(resources.GetObject("Btn_Back.Image"), System.Drawing.Image)
        Me.Btn_Back.Location = New System.Drawing.Point(135, 48)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(94, 63)
        Me.Btn_Back.TabIndex = 4
        Me.Btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'lbl_CuboidVolumeOutput
        '
        Me.lbl_CuboidVolumeOutput.AutoSize = True
        Me.lbl_CuboidVolumeOutput.Location = New System.Drawing.Point(379, 397)
        Me.lbl_CuboidVolumeOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_CuboidVolumeOutput.Name = "lbl_CuboidVolumeOutput"
        Me.lbl_CuboidVolumeOutput.Size = New System.Drawing.Size(39, 13)
        Me.lbl_CuboidVolumeOutput.TabIndex = 5
        Me.lbl_CuboidVolumeOutput.Text = "Label1"
        '
        'btn_CalculateCuboidVolume
        '
        Me.btn_CalculateCuboidVolume.Location = New System.Drawing.Point(104, 285)
        Me.btn_CalculateCuboidVolume.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_CalculateCuboidVolume.Name = "btn_CalculateCuboidVolume"
        Me.btn_CalculateCuboidVolume.Size = New System.Drawing.Size(96, 32)
        Me.btn_CalculateCuboidVolume.TabIndex = 6
        Me.btn_CalculateCuboidVolume.Text = "Caculate Volume"
        Me.btn_CalculateCuboidVolume.UseVisualStyleBackColor = True
        '
        'CuboidMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_CalculateCuboidVolume)
        Me.Controls.Add(Me.lbl_CuboidVolumeOutput)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.txt_CuboidInputHeight)
        Me.Controls.Add(Me.txt_CuboidInputWidth)
        Me.Controls.Add(Me.txt_CuboidInputLength)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CuboidMenu"
        Me.Text = "ShapeCalculater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_CuboidInputLength As TextBox
    Friend WithEvents txt_CuboidInputWidth As TextBox
    Friend WithEvents txt_CuboidInputHeight As TextBox
    Friend WithEvents Btn_Back As Button
    Friend WithEvents lbl_CuboidVolumeOutput As Label
    Friend WithEvents btn_CalculateCuboidVolume As Button
End Class
