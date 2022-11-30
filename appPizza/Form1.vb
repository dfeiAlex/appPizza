Public Class Form1
    Private Function isValid() As Boolean
        'Declare booleans for each of the necessary inputs
        Dim boolPizzaSize, boolPizzaType, boolAmount, boolIsValid As Boolean
        Dim intAmount As Integer = Val(txtAmount.Text)

        boolPizzaSize = (radSmall.Checked Or radMedium.Checked Or radLarge.Checked) 'Check to see if a size for the pizza was selected, is false if no size is selected
        boolPizzaType = (cboPizzaType.SelectedItem <> "") 'Check to see if a pizza type was selected, is false if no type was selected
        boolAmount = (txtAmount.Text <> "" And (Val(txtAmount.Text) >= 1 And Val(txtAmount.Text) <= 10)) 'Checks whether an amount was input and if that amount is between 1 and 10

        'Check to see that all booleans are True
        boolIsValid = boolPizzaSize And boolPizzaType And boolAmount

        If boolIsValid Then
            MessageBox.Show("Everything is working.")
            Return True 'All necessary inputs were given; the order is valid
        Else
            Select Case False
                Case boolPizzaSize
                    MessageBox.Show("Please select a pizza size!", "Mama Mia!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case boolPizzaType
                    MessageBox.Show("Please select a pizza type!", "Mama Mia!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case boolAmount
                    If txtAmount.Text = "" Then
                        MessageBox.Show("Please enter the number of pizzas!", "Mama Mia!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf intAmount > 10 Or intAmount < 1 Then
                        MessageBox.Show("The number of pizzas must be a number between 1 and 10!", "Mama Mia!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select

            Return False
        End If
    End Function

    Private Sub btnMakePizza_Click(sender As Object, e As EventArgs) Handles btnMakePizza.Click
        isValid()
    End Sub
End Class
