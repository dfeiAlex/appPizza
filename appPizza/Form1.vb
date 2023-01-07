Public Class Form1
    Dim objPizza As Pizza = New Pizza()

    'Select pizza type
    Private Sub cboPizzaType_SelectedIndexChanged(objSender As Object, e As EventArgs) Handles cboPizzaType.SelectedIndexChanged
        objPizza.strPizzaType = objSender.SelectedItem
    End Sub

    'Select pizza size
    Private Sub radSmall_CheckedChanged(objSender As Object, e As EventArgs) Handles radSmall.CheckedChanged, radMedium.CheckedChanged, radLarge.CheckedChanged
        'Added to prevent event from firing twice each time a size is selected
        If Not objSender.Checked Then
            Return
        End If

        objPizza.strPizzaSize = objSender.Text
    End Sub

    'Check for extra cheese
    Private Sub chkExtraCheese_CheckedChanged(objSender As Object, e As EventArgs) Handles chkExtraCheese.CheckedChanged
        objPizza.boolExtraCheese = objSender.Checked
    End Sub

    'Check for extra ham
    Private Sub chkExtraHam_CheckedChanged(objSender As Object, e As EventArgs) Handles chkExtraHam.CheckedChanged
        objPizza.boolExtraHam = objSender.Checked
    End Sub

    'Choose number of pizzas
    Private Sub txtAmount_TextChanged(objSender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If Not IsNumeric(objSender.Text) Then
            MessageBox.Show("Please enter a valid number!", "Mama Mia!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Val(objSender.Text) > 10 Then
            objSender.Text = 10
        ElseIf Val(objSender.Text) < 1 Then
            objSender.Text = 1
        End If

        objPizza.intAmount = Val(objSender.Text)
    End Sub

    'Debug
    Private Sub btnMakePizza_Click(sender As Object, e As EventArgs) Handles btnMakePizza.Click
        objPizza.logPizzaDetails()
    End Sub
End Class
