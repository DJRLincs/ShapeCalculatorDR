<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImperialMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImperialMenu))
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.Txt_Length = New System.Windows.Forms.TextBox()
        Me.Txt_Area = New System.Windows.Forms.TextBox()
        Me.Txt_Volume = New System.Windows.Forms.TextBox()
        Me.Txt_Mass = New System.Windows.Forms.TextBox()
        Me.Txt_Temperature = New System.Windows.Forms.TextBox()
        Me.Btn_LengthConvert = New System.Windows.Forms.Button()
        Me.Btn_AreaConvert = New System.Windows.Forms.Button()
        Me.Lbl_LengthAnswear = New System.Windows.Forms.Label()
        Me.Btn_VolumeConvert = New System.Windows.Forms.Button()
        Me.Btn_MassConvert = New System.Windows.Forms.Button()
        Me.Btn_TemperatureConvert = New System.Windows.Forms.Button()
        Me.Lbl_AreaAnswear = New System.Windows.Forms.Label()
        Me.Lbl_VolumeAnswear = New System.Windows.Forms.Label()
        Me.Lbl_MassAnswear = New System.Windows.Forms.Label()
        Me.Lbl_TemperatureAnswear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Back
        '
        Me.Btn_Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Back.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Back.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Back.Image = CType(resources.GetObject("Btn_Back.Image"), System.Drawing.Image)
        Me.Btn_Back.Location = New System.Drawing.Point(12, 12)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(82, 46)
        Me.Btn_Back.TabIndex = 7
        Me.Btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'Txt_Length
        '
        Me.Txt_Length.Location = New System.Drawing.Point(65, 165)
        Me.Txt_Length.Name = "Txt_Length"
        Me.Txt_Length.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Length.TabIndex = 8
        '
        'Txt_Area
        '
        Me.Txt_Area.Location = New System.Drawing.Point(171, 165)
        Me.Txt_Area.Name = "Txt_Area"
        Me.Txt_Area.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Area.TabIndex = 9
        '
        'Txt_Volume
        '
        Me.Txt_Volume.Location = New System.Drawing.Point(277, 165)
        Me.Txt_Volume.Name = "Txt_Volume"
        Me.Txt_Volume.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Volume.TabIndex = 10
        '
        'Txt_Mass
        '
        Me.Txt_Mass.Location = New System.Drawing.Point(383, 165)
        Me.Txt_Mass.Name = "Txt_Mass"
        Me.Txt_Mass.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Mass.TabIndex = 11
        '
        'Txt_Temperature
        '
        Me.Txt_Temperature.Location = New System.Drawing.Point(489, 165)
        Me.Txt_Temperature.Name = "Txt_Temperature"
        Me.Txt_Temperature.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Temperature.TabIndex = 12
        '
        'Btn_LengthConvert
        '
        Me.Btn_LengthConvert.Location = New System.Drawing.Point(65, 314)
        Me.Btn_LengthConvert.Name = "Btn_LengthConvert"
        Me.Btn_LengthConvert.Size = New System.Drawing.Size(100, 23)
        Me.Btn_LengthConvert.TabIndex = 13
        Me.Btn_LengthConvert.Text = "Button1"
        Me.Btn_LengthConvert.UseVisualStyleBackColor = True
        '
        'Btn_AreaConvert
        '
        Me.Btn_AreaConvert.Location = New System.Drawing.Point(171, 314)
        Me.Btn_AreaConvert.Name = "Btn_AreaConvert"
        Me.Btn_AreaConvert.Size = New System.Drawing.Size(100, 23)
        Me.Btn_AreaConvert.TabIndex = 14
        Me.Btn_AreaConvert.Text = "Button2"
        Me.Btn_AreaConvert.UseVisualStyleBackColor = True
        '
        'Lbl_LengthAnswear
        '
        Me.Lbl_LengthAnswear.AutoSize = True
        Me.Lbl_LengthAnswear.Location = New System.Drawing.Point(94, 350)
        Me.Lbl_LengthAnswear.Name = "Lbl_LengthAnswear"
        Me.Lbl_LengthAnswear.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_LengthAnswear.TabIndex = 15
        '
        'Btn_VolumeConvert
        '
        Me.Btn_VolumeConvert.Location = New System.Drawing.Point(277, 314)
        Me.Btn_VolumeConvert.Name = "Btn_VolumeConvert"
        Me.Btn_VolumeConvert.Size = New System.Drawing.Size(100, 23)
        Me.Btn_VolumeConvert.TabIndex = 16
        Me.Btn_VolumeConvert.Text = "Button3"
        Me.Btn_VolumeConvert.UseVisualStyleBackColor = True
        '
        'Btn_MassConvert
        '
        Me.Btn_MassConvert.Location = New System.Drawing.Point(383, 314)
        Me.Btn_MassConvert.Name = "Btn_MassConvert"
        Me.Btn_MassConvert.Size = New System.Drawing.Size(100, 23)
        Me.Btn_MassConvert.TabIndex = 17
        Me.Btn_MassConvert.Text = "Button4"
        Me.Btn_MassConvert.UseVisualStyleBackColor = True
        '
        'Btn_TemperatureConvert
        '
        Me.Btn_TemperatureConvert.Location = New System.Drawing.Point(489, 314)
        Me.Btn_TemperatureConvert.Name = "Btn_TemperatureConvert"
        Me.Btn_TemperatureConvert.Size = New System.Drawing.Size(100, 23)
        Me.Btn_TemperatureConvert.TabIndex = 18
        Me.Btn_TemperatureConvert.Text = "Button5"
        Me.Btn_TemperatureConvert.UseVisualStyleBackColor = True
        '
        'Lbl_AreaAnswear
        '
        Me.Lbl_AreaAnswear.AutoSize = True
        Me.Lbl_AreaAnswear.Location = New System.Drawing.Point(199, 350)
        Me.Lbl_AreaAnswear.Name = "Lbl_AreaAnswear"
        Me.Lbl_AreaAnswear.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_AreaAnswear.TabIndex = 19
        '
        'Lbl_VolumeAnswear
        '
        Me.Lbl_VolumeAnswear.AutoSize = True
        Me.Lbl_VolumeAnswear.Location = New System.Drawing.Point(300, 350)
        Me.Lbl_VolumeAnswear.Name = "Lbl_VolumeAnswear"
        Me.Lbl_VolumeAnswear.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_VolumeAnswear.TabIndex = 20
        '
        'Lbl_MassAnswear
        '
        Me.Lbl_MassAnswear.AutoSize = True
        Me.Lbl_MassAnswear.Location = New System.Drawing.Point(411, 350)
        Me.Lbl_MassAnswear.Name = "Lbl_MassAnswear"
        Me.Lbl_MassAnswear.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_MassAnswear.TabIndex = 21
        '
        'Lbl_TemperatureAnswear
        '
        Me.Lbl_TemperatureAnswear.AutoSize = True
        Me.Lbl_TemperatureAnswear.Location = New System.Drawing.Point(517, 350)
        Me.Lbl_TemperatureAnswear.Name = "Lbl_TemperatureAnswear"
        Me.Lbl_TemperatureAnswear.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_TemperatureAnswear.TabIndex = 22
        '
        'ImperialMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_TemperatureAnswear)
        Me.Controls.Add(Me.Lbl_MassAnswear)
        Me.Controls.Add(Me.Lbl_VolumeAnswear)
        Me.Controls.Add(Me.Lbl_AreaAnswear)
        Me.Controls.Add(Me.Btn_TemperatureConvert)
        Me.Controls.Add(Me.Btn_MassConvert)
        Me.Controls.Add(Me.Btn_VolumeConvert)
        Me.Controls.Add(Me.Lbl_LengthAnswear)
        Me.Controls.Add(Me.Btn_AreaConvert)
        Me.Controls.Add(Me.Btn_LengthConvert)
        Me.Controls.Add(Me.Txt_Temperature)
        Me.Controls.Add(Me.Txt_Mass)
        Me.Controls.Add(Me.Txt_Volume)
        Me.Controls.Add(Me.Txt_Area)
        Me.Controls.Add(Me.Txt_Length)
        Me.Controls.Add(Me.Btn_Back)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ImperialMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImperialConvertMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Back As Button
    Friend WithEvents Txt_Length As TextBox
    Friend WithEvents Txt_Area As TextBox
    Friend WithEvents Txt_Volume As TextBox
    Friend WithEvents Txt_Mass As TextBox
    Friend WithEvents Txt_Temperature As TextBox
    Friend WithEvents Btn_LengthConvert As Button
    Friend WithEvents Btn_AreaConvert As Button
    Friend WithEvents Lbl_LengthAnswear As Label
    Friend WithEvents Btn_VolumeConvert As Button
    Friend WithEvents Btn_MassConvert As Button
    Friend WithEvents Btn_TemperatureConvert As Button
    Friend WithEvents Lbl_AreaAnswear As Label
    Friend WithEvents Lbl_VolumeAnswear As Label
    Friend WithEvents Lbl_MassAnswear As Label
    Friend WithEvents Lbl_TemperatureAnswear As Label
End Class
