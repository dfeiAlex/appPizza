Public Class Form1
    Dim boolExtraCheese, boolExtraHam As Boolean
    Dim strPizzaSize, strPizzaType, strReceipt As String
    Dim intNumberOfPizzas As Integer
    Dim decTotal As Decimal
    Dim intOrderNumber As Integer = 1

    'Dictionary to store item and price values. The price is added onto the subtotal 
    'Entry format: { String ITEM , Decimal PRICE }
    Dim priceList = New Dictionary(Of String, Decimal) From {
        {"Pepperoni", 9.5},
        {"Ham and Mushroom", 9.0},
        {"Vegetarian", 8.0},
        {"Special", 11},
        {"Small", 0.0},
        {"Medium", 2.0},
        {"Large", 5.0},
        {"Extra Cheese", 1.0},
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

            formatReceipt()
            displayTotal()
        End If
    End Sub

    'Reset all variables and clear input and output
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        intOrderNumber += 1

        resetForm()
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
    Private Function calculatePrice() As Decimal
        Dim decPrice As Decimal

        'Get cost for pizza type and size
        decPrice += priceList(strPizzaType)
        decPrice += priceList(strPizzaSize)

        'Check if there are extra toppings. If true add the extra cost, else add nothing
        decPrice += If(boolExtraCheese, priceList("Extra Cheese"), 0)
        decPrice += If(boolExtraHam, priceList("Extra Ham"), 0)

        decPrice *= intNumberOfPizzas

        Console.WriteLine($"Total: {decPrice}")
        Return decPrice
    End Function

    'Format the receipt
    Private Sub formatReceipt()
        Dim newline As String = Environment.NewLine

        strReceipt = ""

        'Add header
        strReceipt += $"Order No. {intOrderNumber}" + newline
        strReceipt += $"{TimeOfDay.ToShortTimeString} {Today.ToShortDateString}" + newline
        strReceipt += "----------------------------------" + newline + newline

        'Add pizza details and add controlled spacing between item and price
        strReceipt += $"{intNumberOfPizzas} x" + newline
        strReceipt += $"{strPizzaType + " Pizza",-23}{"€" + priceList(strPizzaType).ToString,11}" + newline
        strReceipt += $"{"- " + strPizzaSize,-23}{"€" + priceList(strPizzaSize).ToString,11}" + newline

        If boolExtraHam Then
            strReceipt += $"{"- Extra Ham",-23}{"€" + priceList("Extra Ham").ToString,11}" + newline
        End If

        If boolExtraCheese Then
            strReceipt += $"{"- Extra Cheese",-23}{"€" + priceList("Extra Cheese").ToString,11}" + newline
        End If

        'Add subtotal section
        strReceipt += newline + $"Price: {"€" + decTotal.ToString("F2"),27}"

        lblReceipt.Text = strReceipt
    End Sub

    'Display the total in lblTotal
    Private Sub displayTotal()
        Dim strFormattedAnswer As String = decTotal.ToString("F2")
        lblTotal.Text = $"€ {strFormattedAnswer}"
    End Sub

    Private Sub resetForm()
        'Reset variables
        boolExtraCheese = False
        boolExtraHam = False

        strPizzaSize = ""
        strPizzaType = ""
        strReceipt = ""

        intNumberOfPizzas = 0
        decTotal = 0

        'Clear input and output
        'Input
        cboPizzaType.SelectedIndex = -1

        radSmall.Checked = False
        radMedium.Checked = False
        radLarge.Checked = False

        chkExtraCheese.Checked = False
        chkExtraHam.Checked = False

        txtAmount.Text = ""

        'Output
        lblReceipt.Text = ""
        lblTotal.Text = ""
    End Sub
End Class
