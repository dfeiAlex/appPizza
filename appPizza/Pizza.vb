Public Class Pizza
    'Pizza details
    Public strPizzaType As String = ""
    Public strPizzaSize As String = ""
    Public boolExtraCheese As Boolean = False
    Public boolExtraHam As Boolean = False
    Public intAmount As Integer = 1

    Public boolValidPizza As Boolean = False

    Public dblTotal As Double = 0

    'Dictionary for pizza prices
    Dim dictPrices = New Dictionary(Of String, Double) From {
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

    'format price to 2 decimal places
    Private Function formatPrice(price As Double) As String
        Return $"{price:C2}" 'Return the price formatted to 2 decimal places and in the local currency
    End Function

    'Determine whether order is valid, calculate total and return formatted total
    Public Function calculateTotal() As String
        'Check for the two necessary inputs
        If strPizzaSize = "" Or strPizzaType = "" Then
            MessageBox.Show("Choose a pizza size and type!", "Mama Mia!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End If

        boolValidPizza = True

        dblTotal = 0
        dblTotal += dictPrices(strPizzaType) 'Add price for pizza type
        dblTotal += dictPrices(strPizzaSize) 'Add price for pizza size

        If boolExtraCheese Then
            dblTotal += dictPrices("Extra Cheese") 'Add price for extra cheese
        End If

        If boolExtraHam Then
            dblTotal += dictPrices("Extra Ham") 'Add price for extra cheese
        End If

        dblTotal *= intAmount 'Multiply total by the number of pizzas ordered
        Return formatPrice(dblTotal)
    End Function

    'Reset variables
    Public Sub reset()
        strPizzaType = ""
        strPizzaType = ""
        boolExtraCheese = False
        boolExtraHam = False
        intAmount = 1
        boolValidPizza = False
        dblTotal = 0
    End Sub

    'For debug
    Public Sub logPizzaDetails()
        Dim strDebug As String = ""
        Dim nl As String = Environment.NewLine

        strDebug += "Pizza Details" + nl
        strDebug += "----------------------------" + nl
        strDebug += $"Type: {strPizzaType}" + nl
        strDebug += $"Size: {strPizzaSize}" + nl
        strDebug += $"Extra Cheese: {boolExtraCheese}" + nl
        strDebug += $"Extra Ham: {boolExtraHam}" + nl
        strDebug += $"Number of Pizzas: {intAmount}" + nl
        strDebug += "----------------------------" + nl + nl
        strDebug += $"Total: {dblTotal:C2}"

        MessageBox.Show(strDebug, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
