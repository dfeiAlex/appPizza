Imports System.Drawing.Text

Module Receipt
    'Format price
    Private Function formatPrice(price As Double) As String
        Return $"{price:C2}"
    End Function

    'Format the receipt
    Public Function formatReceipt(dictInputs As Dictionary(Of String, Object), dictPriceList As Dictionary(Of String, Double), dblTotal As Double)
        Dim nl As String = Environment.NewLine
        Dim strReceipt As String = ""

        Dim rndRandom = New Random()
        Dim intOrderNumber As Integer = rndRandom.Next(1, 1000)

        Dim intAmount As Integer = dictInputs("intAmount")
        Dim strPizzaType As String = dictInputs("strPizzaType")
        Dim strPizzaSize As String = dictInputs("strPizzaSize")
        Dim boolExtraCheese As Boolean = dictInputs("boolExtraCheese")
        Dim boolExtraHam As Boolean = dictInputs("boolExtraHam")

        Dim strIntAmount As String = $"{intAmount}x"

        'Add header
        strReceipt += "LA MIA PIZZERIA" + nl + nl
        strReceipt += $"Order No. {intOrderNumber}" + nl 'Order number
        strReceipt += $"{TimeOfDay.ToShortTimeString} {Today.ToShortDateString}" + nl 'Current time and date
        strReceipt += nl + nl

        'Add pizza details and add controlled spacing between item and price
        strReceipt += "----------------------------------" + nl + nl
        strReceipt += $"{strIntAmount,-34}" + nl 'Number of pizzas
        strReceipt += $"{strPizzaType + " Pizza",-23}{formatPrice(dictPriceList(strPizzaType)),11}" + nl 'Pizza type and price
        strReceipt += $"{"- " + strPizzaSize,-23}{formatPrice(dictPriceList(strPizzaSize)),11}" + nl 'Pizza size and price

        If boolExtraHam Then
            strReceipt += $"{"- Extra Ham",-23}{formatPrice(dictPriceList("Extra Ham")),11}" + nl
        End If

        If boolExtraCheese Then
            strReceipt += $"{"- Extra Cheese",-23}{formatPrice(dictPriceList("Extra Cheese")),11}" + nl
        End If

        strReceipt += nl

        strReceipt += "----------------------------------" + nl

        'Add subtotal section
        strReceipt += nl + $"Total: {formatPrice(dblTotal),27}"

        Return strReceipt
    End Function
End Module
