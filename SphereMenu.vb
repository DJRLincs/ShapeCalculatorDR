Public Class SphereMenu
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub btn_CalculateSphereVolume_Click(sender As Object, e As EventArgs) Handles btn_CalculateSphereVolume.Click
        Const pi As Double = 3.142

        lbl_SphereVolumeOutput.Text = 4 / 3 * pi * Val(txt_SphereInputRadius.Text) * Val(txt_SphereInputRadius.Text) * Val(txt_SphereInputRadius.Text)

        'Calculates the Volume with 
    End Sub
End Class