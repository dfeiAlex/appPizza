Public Class Form1
    Dim objPizza As Pizza = New Pizza()

    'Select pizza type
    Private Sub cboPizzaType_SelectedIndexChanged(cboBox As Object, e As EventArgs) Handles cboPizzaType.SelectedIndexChanged
        objPizza.strPizzaType = cboBox.SelectedItem
    End Sub

    'Select pizza size
    Private Sub radSmall_CheckedChanged(radButton As Object, e As EventArgs) Handles radSmall.CheckedChanged, radMedium.CheckedChanged, radLarge.CheckedChanged
        Select Case True
            Case radSmall.Checked
                objPizza.strPizzaSize = radSmall.Text
            Case radMedium.Checked
                objPizza.strPizzaSize = radMedium.Text
            Case radLarge.Checked
                objPizza.strPizzaSize = radLarge.Text
        End Select
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

    'Display total and receipt
    Private Sub btnMakePizza_Click(sender As Object, e As EventArgs) Handles btnMakePizza.Click
        objPizza.calculateTotal()

        'Check if pizza is valid
        If objPizza.boolValidPizza Then
            'Display total and receipt
            lblTotal.Text = objPizza.calculateTotal()
            lblReceipt.Text = objPizza.getReceipt()
        End If
    End Sub

    'Reset variables for the new pizza
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        objPizza.reset()

        'Clear form
        lblReceipt.Text = ""
        lblTotal.Text = ""

        cboPizzaType.SelectedIndex = -1

        radSmall.Checked = True
        radMedium.Checked = False
        radLarge.Checked = False

        chkExtraCheese.Checked = False
        chkExtraHam.Checked = False

        txtAmount.Text = "1"
    End Sub

    'Debug
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        objPizza.logPizzaDetails()
    End Sub
End Class