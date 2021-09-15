Public Class CuboidMenu

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub txt_CuboidInputLength_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_CuboidInputLength.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txt_CuboidInputWidth_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_CuboidInputWidth.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txt_CuboidInputHeight_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_CuboidInputHeight.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btn_CalculateCuboidVolume_Click(sender As Object, e As EventArgs) Handles btn_CalculateCuboidVolume.Click


        lbl_CuboidVolumeOutput.Text = Val(txt_CuboidInputLength.Text) * Val(txt_CuboidInputWidth.Text) * Val(txt_CuboidInputHeight.Text)

        'Calculates the Volume with  Length, Width and Height
    End Sub
End Class