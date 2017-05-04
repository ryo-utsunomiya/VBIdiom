Imports System.Console
Imports VBIdiom.Commodity

Module Module1

    Sub Main()
        Dim d = New Product(code:=98, name:="どら焼き", price:=210)
        WriteLine(d.GetTax())
    End Sub

End Module
