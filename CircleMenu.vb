Public Class CircleMenu
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Hide()
        MainMenu.Show()

        'Allows Page Switching back and fourth from MainMenu

    End Sub

    Private Sub btn_CalculateCircleCircumference_Click(sender As Object, e As EventArgs) Handles btn_CalculateCircleCircumference.Click
        Const pi As Double = 3.142

        lbl_CircleCircumferenceOutput.Text = 2 * pi * Val(txt_CircleCircumferenceInputRadius.Text)

        'Calculates the Circumference with Pie and the Value of Radius
    End Sub

    Private Sub btn_CalculateCircleArea_Click(sender As Object, e As EventArgs) Handles btn_CalculateCircleArea.Click
        Const pi As Double = 3.142

        lbl_CircleAreaOutput.Text = pi * Val(txt_CircleAreaInputRadius.Text)

        'Calculates the Area with Pie and the Value of Radius
    End Sub

    ' if Assci Values Stop Working Switch too this line of code

    ' If IsNumeric(Txt_CircleAreaInputRadius.Text) = 
    '    lbl
    ' Elseif IsNumeric (txt_.text) = False
    '    MsgBox("Error. Incorrect Value Input.")
    '    txt_ .text = ""
    ' End If

End Class