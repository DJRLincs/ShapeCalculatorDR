Public Class RectangleMenu
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub txt_rectangleAreaInputLength_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RectangleAreaInputLength.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txt_RectangleAreaInputWidth_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_RectangleAreaInputWidth.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txt_RectanglePerimeterInputLength_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_RectanglePerimeterInputLength.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txt_RectanglePerimeterInputWidth_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_RectanglePerimeterInputWidth.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btn_CalculateRectangleArea_Click(sender As Object, e As EventArgs) Handles btn_CalculateRectangleArea.Click


        lbl_RectangleAreaOutput.Text = Val(txt_RectangleAreaInputLength.Text) * Val(txt_RectangleAreaInputWidth.Text)

        'Calculates the Area with Length times Width
    End Sub

    Private Sub btn_CalculateRectanglePerimeter_Click(sender As Object, e As EventArgs) Handles btn_CalculateRectanglePerimeter.Click


        lbl_RectanglePerimeterOutput.Text = 2 * (Val(txt_RectanglePerimeterInputLength.Text) + Val(txt_RectanglePerimeterInputWidth.Text))

        'Calculates the Area with Length times Width
    End Sub
End Class