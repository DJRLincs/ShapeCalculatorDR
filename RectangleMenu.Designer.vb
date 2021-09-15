<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RectangleMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RectangleMenu))
        Me.lbl_RectangleAreaOutput = New System.Windows.Forms.Label()
        Me.lbl_RectanglePerimeterOutput = New System.Windows.Forms.Label()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.txt_RectangleAreaInputLength = New System.Windows.Forms.TextBox()
        Me.txt_RectangleAreaInputWidth = New System.Windows.Forms.TextBox()
        Me.btn_CalculateRectangleArea = New System.Windows.Forms.Button()
        Me.btn_CalculateRectanglePerimeter = New System.Windows.Forms.Button()
        Me.txt_RectanglePerimeterInputLength = New System.Windows.Forms.TextBox()
        Me.txt_RectanglePerimeterInputWidth = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_RectangleAreaOutput
        '
        Me.lbl_RectangleAreaOutput.AutoSize = True
        Me.lbl_RectangleAreaOutput.Location = New System.Drawing.Point(125, 394)
        Me.lbl_RectangleAreaOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_RectangleAreaOutput.Name = "lbl_RectangleAreaOutput"
        Me.lbl_RectangleAreaOutput.Size = New System.Drawing.Size(39, 13)
        Me.lbl_RectangleAreaOutput.TabIndex = 2
        Me.lbl_RectangleAreaOutput.Text = "Label1"
        '
        'lbl_RectanglePerimeterOutput
        '
        Me.lbl_RectanglePerimeterOutput.AutoSize = True
        Me.lbl_RectanglePerimeterOutput.Location = New System.Drawing.Point(626, 394)
        Me.lbl_RectanglePerimeterOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_RectanglePerimeterOutput.Name = "lbl_RectanglePerimeterOutput"
        Me.lbl_RectanglePerimeterOutput.Size = New System.Drawing.Size(39, 13)
        Me.lbl_RectanglePerimeterOutput.TabIndex = 3
        Me.lbl_RectanglePerimeterOutput.Text = "Label2"
        '
        'Btn_Back
        '
        Me.Btn_Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Back.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Back.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Back.Image = CType(resources.GetObject("Btn_Back.Image"), System.Drawing.Image)
        Me.Btn_Back.Location = New System.Drawing.Point(2, 2)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(94, 63)
        Me.Btn_Back.TabIndex = 5
        Me.Btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'txt_RectangleAreaInputLength
        '
        Me.txt_RectangleAreaInputLength.Location = New System.Drawing.Point(149, 217)
        Me.txt_RectangleAreaInputLength.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_RectangleAreaInputLength.Name = "txt_RectangleAreaInputLength"
        Me.txt_RectangleAreaInputLength.Size = New System.Drawing.Size(76, 20)
        Me.txt_RectangleAreaInputLength.TabIndex = 6
        '
        'txt_RectangleAreaInputWidth
        '
        Me.txt_RectangleAreaInputWidth.Location = New System.Drawing.Point(149, 256)
        Me.txt_RectangleAreaInputWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_RectangleAreaInputWidth.Name = "txt_RectangleAreaInputWidth"
        Me.txt_RectangleAreaInputWidth.Size = New System.Drawing.Size(76, 20)
        Me.txt_RectangleAreaInputWidth.TabIndex = 7
        '
        'btn_CalculateRectangleArea
        '
        Me.btn_CalculateRectangleArea.Location = New System.Drawing.Point(90, 295)
        Me.btn_CalculateRectangleArea.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_CalculateRectangleArea.Name = "btn_CalculateRectangleArea"
        Me.btn_CalculateRectangleArea.Size = New System.Drawing.Size(96, 37)
        Me.btn_CalculateRectangleArea.TabIndex = 8
        Me.btn_CalculateRectangleArea.Text = "Calculate Area"
        Me.btn_CalculateRectangleArea.UseVisualStyleBackColor = True
        '
        'btn_CalculateRectanglePerimeter
        '
        Me.btn_CalculateRectanglePerimeter.Location = New System.Drawing.Point(590, 288)
        Me.btn_CalculateRectanglePerimeter.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_CalculateRectanglePerimeter.Name = "btn_CalculateRectanglePerimeter"
        Me.btn_CalculateRectanglePerimeter.Size = New System.Drawing.Size(99, 44)
        Me.btn_CalculateRectanglePerimeter.TabIndex = 9
        Me.btn_CalculateRectanglePerimeter.Text = "Calculate Perimeter"
        Me.btn_CalculateRectanglePerimeter.UseVisualStyleBackColor = True
        '
        'txt_RectanglePerimeterInputLength
        '
        Me.txt_RectanglePerimeterInputLength.Location = New System.Drawing.Point(614, 217)
        Me.txt_RectanglePerimeterInputLength.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_RectanglePerimeterInputLength.Name = "txt_RectanglePerimeterInputLength"
        Me.txt_RectanglePerimeterInputLength.Size = New System.Drawing.Size(76, 20)
        Me.txt_RectanglePerimeterInputLength.TabIndex = 10
        '
        'txt_RectanglePerimeterInputWidth
        '
        Me.txt_RectanglePerimeterInputWidth.Location = New System.Drawing.Point(614, 256)
        Me.txt_RectanglePerimeterInputWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_RectanglePerimeterInputWidth.Name = "txt_RectanglePerimeterInputWidth"
        Me.txt_RectanglePerimeterInputWidth.Size = New System.Drawing.Size(76, 20)
        Me.txt_RectanglePerimeterInputWidth.TabIndex = 11
        '
        'RectangleMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_RectanglePerimeterInputWidth)
        Me.Controls.Add(Me.txt_RectanglePerimeterInputLength)
        Me.Controls.Add(Me.btn_CalculateRectanglePerimeter)
        Me.Controls.Add(Me.btn_CalculateRectangleArea)
        Me.Controls.Add(Me.txt_RectangleAreaInputWidth)
        Me.Controls.Add(Me.txt_RectangleAreaInputLength)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.lbl_RectanglePerimeterOutput)
        Me.Controls.Add(Me.lbl_RectangleAreaOutput)
        Me.DoubleBuffered = True
        Me.Name = "RectangleMenu"
        Me.Text = "ShapeCalculater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_RectangleAreaOutput As Label
    Friend WithEvents lbl_RectanglePerimeterOutput As Label
    Friend WithEvents Btn_Back As Button
    Friend WithEvents txt_RectangleAreaInputLength As TextBox
    Friend WithEvents txt_RectangleAreaInputWidth As TextBox
    Friend WithEvents btn_CalculateRectangleArea As Button
    Friend WithEvents btn_CalculateRectanglePerimeter As Button
    Friend WithEvents txt_RectanglePerimeterInputLength As TextBox
    Friend WithEvents txt_RectanglePerimeterInputWidth As TextBox
End Class
