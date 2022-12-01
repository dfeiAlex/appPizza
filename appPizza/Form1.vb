Public Class Form1
    Dim boolExtraCheese, boolExtraHam As Boolean
    Dim strPizzaSize, strPizzaType As String
    Dim intNumberOfPizzas As Integer
    Dim decTotal As Decimal

    'Dictionary with the key being the input and the value being the cost to be added to the total
    Dim priceList = New Dictionary(Of String, Double) From {
        {"Pepperoni", 9.5},
        {"Ham and Mushroom", 9},
        {"Vegetarian", 8},
        {"Special", 11},
        {"Small", 0},
        {"Medium", 2},
        {"Large", 5},
        {"Extra Cheese", 1},
        {"Extra Ham", 1.5}
    }

    'Is run when the make pizza button is pressed, most of the logic originates from here
    Private Sub makePizza(sender As Object, e As EventArgs) Handles btnMakePizza.Click
        If isOrderValid() Then
            'Setting the values for all of the input variables here
            boolExtraCheese = chkExtraCheese.Checked
            boolExtraHam = chkExtraHam.Checked

            strPizzaType = cboPizzaType.SelectedItem
            intNumberOfPizzas = Val(txtAmount.Text)

            Select Case True
                Case radSmall.Checked
                    strPizzaSize = radSmall.Text
                Case radMedium.Checked
                    strPizzaSize = radMedium.Text
                Case radLarge.Checked
                    strPizzaSize = radLarge.Text
            End Select

            decTotal = calculatePrice()

            displayTotal()
        End If
    End Sub

    'Check if all necessary inputs have been given
    Private Function isOrderValid() As Boolean
        'Declare booleans for each of the necessary inputs
        Dim boolPizzaSize, boolPizzaType, boolAmount, boolIsValid As Boolean
        Dim intAmount As Integer = Val(txtAmount.Text)

        boolPizzaSize = (radSmall.Checked Or radMedium.Checked Or radLarge.Checked) 'Check to see if a size for the pizza was selected, is false if no size is selected
        boolPizzaType = (cboPizzaType.SelectedItem <> "") 'Check to see if a pizza type was selected, is false if no type was selected
        boolAmount = (txtAmount.Text <> "" And (Val(txtAmount.Text) >= 1 And Val(txtAmount.Text) <= 10)) 'Checks whether an amount was input and if that amount is between 1 and 10

        'Check to see that all booleans are True
        boolIsValid = boolPizzaSize And boolPizzaType And boolAmount

        If boolIsValid Then
            'MessageBox.Show("Everything is working.") 'Debug
            Return True 'All necessary inputs were given; the order is valid
        Else
            'Display error message for relevant missing inputs
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

            Return False 'Necessary inputs were not given, order cannot be made yet
        End If
    End Function

    'Calculate price for current pizza
    Private Function calculatePrice() As Double
        Dim dblPrice As Double

        'Get cost for pizza type and size
        dblPrice += priceList(strPizzaType)
        dblPrice += priceList(strPizzaSize)

        'Check if there are extra toppings. If true add the extra cost, else add nothing
        dblPrice += If(boolExtraCheese, priceList("Extra Cheese"), 0)
        dblPrice += If(boolExtraHam, priceList("Extra Ham"), 0)

        dblPrice *= intNumberOfPizzas

        Console.WriteLine($"Total: {dblPrice}")
        Return dblPrice
    End Function

    'Display the total in lblTotal
    Private Sub displayTotal()
        Dim strFormattedAnswer As String = decTotal.ToString("F2")
        lblTotal.Text = $"€ {strFormattedAnswer}"
    End Sub
End Class
