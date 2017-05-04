Namespace Commodity

    Public Class Product
        Public ReadOnly Property Code As Integer
        Public ReadOnly Property Name As String
        Public ReadOnly Property Price As Integer

        Sub New(code As Integer, name As String, price As Integer)
            Me.Code = code
            Me.Name = name
            Me.Price = price
        End Sub

        ''' <summary>
        ''' 消費税額を求める
        ''' </summary>
        ''' <returns></returns>
        Public Function GetTax() As Integer
            Return CInt(Price * 0.08)
        End Function

        Public Function GetPriceIncludingTax() As Integer
            Return Price + GetTax()
        End Function
    End Class

End Namespace