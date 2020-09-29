Public Class adressLabelViewerForm1
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        Dim textbox As Control
        displayLabelButton.Text = ""
        For Each textbox Is textbox then 
                textbox.Text = ""
    End Sub
End Class
