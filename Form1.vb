Public Class StartForm

    Private Sub Instructions_Button_Click(sender As Object, e As EventArgs) Handles Instructions_Button.Click
        Me.Hide()
        InstructionsForm.Show()
    End Sub

    Private Sub Start_Button_Click(sender As Object, e As EventArgs) Handles Start_Button.Click
        Me.Hide()
        GameForm.Show()
    End Sub
End Class
