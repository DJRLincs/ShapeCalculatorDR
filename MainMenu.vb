Public Class MainMenu
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Rectangle.Click
        Me.Hide()
        RectangleMenu.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Cuboid.Click
        Me.Hide()
        CuboidMenu.Show()
    End Sub

    Private Sub Btn_Circle_Click(sender As Object, e As EventArgs) Handles Btn_Circle.Click
        Me.Hide()
        CircleMenu.Show()
    End Sub

    Private Sub Btn_Sphere_Click(sender As Object, e As EventArgs) Handles Btn_Sphere.Click
        Me.Hide()
        SphereMenu.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub
End Class
