Public Class Pizza
    Public strPizzaType As String = ""
    Public strPizzaSize As String = ""
    Public boolExtraCheese As Boolean = False
    Public boolExtraHam As Boolean = False
    Public intAmount As Integer = 1

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

    'For debug
    Public Sub logPizzaDetails()
        Console.WriteLine("----------------------------")
        Console.WriteLine($"Type: {strPizzaType}")
        Console.WriteLine($"Size: {strPizzaSize}")
        Console.WriteLine($"Extra Cheese: {boolExtraCheese}")
        Console.WriteLine($"Extra Ham: {boolExtraHam}")
        Console.WriteLine($"Number of Pizzas: {intAmount}")
    End Sub
End Class
