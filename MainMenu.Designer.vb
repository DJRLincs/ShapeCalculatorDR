<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Btn_Rectangle = New System.Windows.Forms.Button()
        Me.Btn_Circle = New System.Windows.Forms.Button()
        Me.Btn_Cuboid = New System.Windows.Forms.Button()
        Me.Btn_Sphere = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Rectangle
        '
        Me.Btn_Rectangle.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Rectangle.Location = New System.Drawing.Point(12, 17)
        Me.Btn_Rectangle.Name = "Btn_Rectangle"
        Me.Btn_Rectangle.Size = New System.Drawing.Size(167, 83)
        Me.Btn_Rectangle.TabIndex = 1
        Me.Btn_Rectangle.Text = "Rectangle"
        Me.Btn_Rectangle.UseVisualStyleBackColor = False
        '
        'Btn_Circle
        '
        Me.Btn_Circle.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Circle.Location = New System.Drawing.Point(621, 17)
        Me.Btn_Circle.Name = "Btn_Circle"
        Me.Btn_Circle.Size = New System.Drawing.Size(167, 83)
        Me.Btn_Circle.TabIndex = 2
        Me.Btn_Circle.Text = "Circle"
        Me.Btn_Circle.UseVisualStyleBackColor = False
        '
        'Btn_Cuboid
        '
        Me.Btn_Cuboid.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Cuboid.Location = New System.Drawing.Point(621, 355)
        Me.Btn_Cuboid.Name = "Btn_Cuboid"
        Me.Btn_Cuboid.Size = New System.Drawing.Size(167, 83)
        Me.Btn_Cuboid.TabIndex = 4
        Me.Btn_Cuboid.Text = "Cuboid"
        Me.Btn_Cuboid.UseVisualStyleBackColor = False
        '
        'Btn_Sphere
        '
        Me.Btn_Sphere.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Sphere.Location = New System.Drawing.Point(12, 355)
        Me.Btn_Sphere.Name = "Btn_Sphere"
        Me.Btn_Sphere.Size = New System.Drawing.Size(167, 83)
        Me.Btn_Sphere.TabIndex = 3
        Me.Btn_Sphere.Text = "Sphere"
        Me.Btn_Sphere.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Exit.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_Exit.Location = New System.Drawing.Point(318, 296)
        Me.btn_Exit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(163, 51)
        Me.btn_Exit.TabIndex = 5
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.Btn_Cuboid)
        Me.Controls.Add(Me.Btn_Sphere)
        Me.Controls.Add(Me.Btn_Circle)
        Me.Controls.Add(Me.Btn_Rectangle)
        Me.DoubleBuffered = True
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShapeCalculater"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Rectangle As Button
    Friend WithEvents Btn_Circle As Button
    Friend WithEvents Btn_Cuboid As Button
    Friend WithEvents Btn_Sphere As Button
    Friend WithEvents btn_Exit As Button
End Class
