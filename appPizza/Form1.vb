Public Class Form1
    Dim objPizza As Pizza = New Pizza()

    'Select pizza type
    Private Sub cboPizzaType_SelectedIndexChanged(cboBox As Object, e As EventArgs) Handles cboPizzaType.SelectedIndexChanged
        objPizza.strPizzaType = cboBox.SelectedItem
    End Sub

    'Select pizza size
    Private Sub radSmall_CheckedChanged(radButton As Object, e As EventArgs) Handles radSmall.CheckedChanged, radMedium.CheckedChanged, radLarge.CheckedChanged
        'Added to prevent event from firing twice each time a size is selected
        If Not radButton.Checked Then
            Return
        End If

        objPizza.strPizzaSize = radButton.Text
    End Sub

    'Check for extra cheese
    Private Sub chkExtraCheese_CheckedChanged(chkBox As Object, e As EventArgs) Handles chkExtraCheese.CheckedChanged
        objPizza.boolExtraCheese = chkBox.Checked
    End Sub

    'Check for extra ham
    Private Sub chkExtraHam_CheckedChanged(chkBox As Object, e As EventArgs) Handles chkExtraHam.CheckedChanged
        objPizza.boolExtraHam = chkBox.Checked
    End Sub

    'Choose number of pizzas
    Private Sub txtAmount_TextChanged(txtBox As Object, e As EventArgs) Handles txtAmount.TextChanged
        If Not IsNumeric(txtBox.Text) And txtBox.Text <> "" Then
            MessageBox.Show("Please enter a valid number!", "Mama Mia!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBox.Text = ""
            Return
        End If

        If txtBox.Text <> "" Then
            If Val(txtBox.Text) > 10 Then
                txtBox.Text = 10
            ElseIf Val(txtBox.Text) < 1 Then
                txtBox.Text = 1
            End If

            txtBox.Select(txtBox.Text.Length, 0)
        End If

        objPizza.intAmount = Val(txtBox.Text)
    End Sub

    'Check if order is valid and display total
    Private Sub btnMakePizza_Click(sender As Object, e As EventArgs) Handles btnMakePizza.Click
        objPizza.calculateTotal()

        If objPizza.boolValidPizza Then
            lblTotal.Text = objPizza.calculateTotal()
        End If
    End Sub

    'Reset variables for the new pizza
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        objPizza.reset()
    End Sub

    'Debug
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        objPizza.logPizzaDetails()
    End Sub
End Class
