<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SphereMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SphereMenu))
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.txt_SphereInputRadius = New System.Windows.Forms.TextBox()
        Me.lbl_SphereVolumeOutput = New System.Windows.Forms.Label()
        Me.btn_CalculateSphereVolume = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Back
        '
        Me.Btn_Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Back.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Back.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Back.Image = CType(resources.GetObject("Btn_Back.Image"), System.Drawing.Image)
        Me.Btn_Back.Location = New System.Drawing.Point(3, 1)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(94, 63)
        Me.Btn_Back.TabIndex = 5
        Me.Btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'txt_SphereInputRadius
        '
        Me.txt_SphereInputRadius.Location = New System.Drawing.Point(400, 236)
        Me.txt_SphereInputRadius.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_SphereInputRadius.Name = "txt_SphereInputRadius"
        Me.txt_SphereInputRadius.Size = New System.Drawing.Size(76, 20)
        Me.txt_SphereInputRadius.TabIndex = 6
        '
        'lbl_SphereVolumeOutput
        '
        Me.lbl_SphereVolumeOutput.AutoSize = True
        Me.lbl_SphereVolumeOutput.Location = New System.Drawing.Point(379, 402)
        Me.lbl_SphereVolumeOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_SphereVolumeOutput.Name = "lbl_SphereVolumeOutput"
        Me.lbl_SphereVolumeOutput.Size = New System.Drawing.Size(39, 13)
        Me.lbl_SphereVolumeOutput.TabIndex = 7
        Me.lbl_SphereVolumeOutput.Text = "Label1"
        '
        'btn_CalculateSphereVolume
        '
        Me.btn_CalculateSphereVolume.Location = New System.Drawing.Point(344, 297)
        Me.btn_CalculateSphereVolume.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_CalculateSphereVolume.Name = "btn_CalculateSphereVolume"
        Me.btn_CalculateSphereVolume.Size = New System.Drawing.Size(114, 42)
        Me.btn_CalculateSphereVolume.TabIndex = 8
        Me.btn_CalculateSphereVolume.Text = "Calculate Volume"
        Me.btn_CalculateSphereVolume.UseVisualStyleBackColor = True
        '
        'SphereMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_CalculateSphereVolume)
        Me.Controls.Add(Me.lbl_SphereVolumeOutput)
        Me.Controls.Add(Me.txt_SphereInputRadius)
        Me.Controls.Add(Me.Btn_Back)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SphereMenu"
        Me.Text = "ShapeCalculater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Back As Button
    Friend WithEvents txt_SphereInputRadius As TextBox
    Friend WithEvents lbl_SphereVolumeOutput As Label
    Friend WithEvents btn_CalculateSphereVolume As Button
End Class
