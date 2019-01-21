Public NotInheritable Class AboutBox

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
         Me.LabelProductName.Text = My.Application.Info.ProductName

        Me.TextBoxDescription.Text = "Developed By:" & " Kris Trinidad"


    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

  
End Class
