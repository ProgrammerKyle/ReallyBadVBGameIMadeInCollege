Public Class InstructionsForm

    Private Sub Done_Button_Click(sender As Object, e As EventArgs) Handles Done_Button.Click
        StartForm.Show()
        Me.Close()
    End Sub

    Private Sub InstructionsForm_close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        StartForm.Show()

    End Sub
End Class