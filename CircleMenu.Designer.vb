<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CircleMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CircleMenu))
        Me.txt_CircleAreaInputRadius = New System.Windows.Forms.TextBox()
        Me.txt_CircleCircumferenceInputRadius = New System.Windows.Forms.TextBox()
        Me.lbl_CircleAreaOutput = New System.Windows.Forms.Label()
        Me.lbl_CircleCircumferenceOutput = New System.Windows.Forms.Label()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.btn_CalculateCircleArea = New System.Windows.Forms.Button()
        Me.btn_CalculateCircleCircumference = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_CircleAreaInputRadius
        '
        Me.txt_CircleAreaInputRadius.Location = New System.Drawing.Point(140, 213)
        Me.txt_CircleAreaInputRadius.Name = "txt_CircleAreaInputRadius"
        Me.txt_CircleAreaInputRadius.Size = New System.Drawing.Size(100, 20)
        Me.txt_CircleAreaInputRadius.TabIndex = 2
        '
        'txt_CircleCircumferenceInputRadius
        '
        Me.txt_CircleCircumferenceInputRadius.Location = New System.Drawing.Point(642, 213)
        Me.txt_CircleCircumferenceInputRadius.Name = "txt_CircleCircumferenceInputRadius"
        Me.txt_CircleCircumferenceInputRadius.Size = New System.Drawing.Size(100, 20)
        Me.txt_CircleCircumferenceInputRadius.TabIndex = 3
        '
        'lbl_CircleAreaOutput
        '
        Me.lbl_CircleAreaOutput.AutoSize = True
        Me.lbl_CircleAreaOutput.Location = New System.Drawing.Point(124, 388)
        Me.lbl_CircleAreaOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_CircleAreaOutput.Name = "lbl_CircleAreaOutput"
        Me.lbl_CircleAreaOutput.Size = New System.Drawing.Size(39, 13)
        Me.lbl_CircleAreaOutput.TabIndex = 5
        Me.lbl_CircleAreaOutput.Text = "Label1"
        '
        'lbl_CircleCircumferenceOutput
        '
        Me.lbl_CircleCircumferenceOutput.AutoSize = True
        Me.lbl_CircleCircumferenceOutput.Location = New System.Drawing.Point(633, 396)
        Me.lbl_CircleCircumferenceOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_CircleCircumferenceOutput.Name = "lbl_CircleCircumferenceOutput"
        Me.lbl_CircleCircumferenceOutput.Size = New System.Drawing.Size(39, 13)
        Me.lbl_CircleCircumferenceOutput.TabIndex = 6
        Me.lbl_CircleCircumferenceOutput.Text = "Label2"
        '
        'Btn_Back
        '
        Me.Btn_Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Back.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Back.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Back.Image = CType(resources.GetObject("Btn_Back.Image"), System.Drawing.Image)
        Me.Btn_Back.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(94, 63)
        Me.Btn_Back.TabIndex = 7
        Me.Btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'btn_CalculateCircleArea
        '
        Me.btn_CalculateCircleArea.Location = New System.Drawing.Point(96, 288)
        Me.btn_CalculateCircleArea.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_CalculateCircleArea.Name = "btn_CalculateCircleArea"
        Me.btn_CalculateCircleArea.Size = New System.Drawing.Size(98, 40)
        Me.btn_CalculateCircleArea.TabIndex = 8
        Me.btn_CalculateCircleArea.Text = "Calculate Area"
        Me.btn_CalculateCircleArea.UseVisualStyleBackColor = True
        '
        'btn_CalculateCircleCircumference
        '
        Me.btn_CalculateCircleCircumference.Location = New System.Drawing.Point(589, 288)
        Me.btn_CalculateCircleCircumference.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_CalculateCircleCircumference.Name = "btn_CalculateCircleCircumference"
        Me.btn_CalculateCircleCircumference.Size = New System.Drawing.Size(132, 40)
        Me.btn_CalculateCircleCircumference.TabIndex = 9
        Me.btn_CalculateCircleCircumference.Text = "Calculate Circumference"
        Me.btn_CalculateCircleCircumference.UseVisualStyleBackColor = True
        '
        'CircleMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_CalculateCircleCircumference)
        Me.Controls.Add(Me.btn_CalculateCircleArea)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.lbl_CircleCircumferenceOutput)
        Me.Controls.Add(Me.lbl_CircleAreaOutput)
        Me.Controls.Add(Me.txt_CircleCircumferenceInputRadius)
        Me.Controls.Add(Me.txt_CircleAreaInputRadius)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CircleMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShapeCalculater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_CircleAreaInputRadius As TextBox
    Friend WithEvents txt_CircleCircumferenceInputRadius As TextBox
    Friend WithEvents lbl_CircleAreaOutput As Label
    Friend WithEvents lbl_CircleCircumferenceOutput As Label
    Friend WithEvents Btn_Back As Button
    Friend WithEvents btn_CalculateCircleArea As Button
    Friend WithEvents btn_CalculateCircleCircumference As Button
End Class
