Imports System.Console

Module Module1

    Sub Main()
        Dim c = New MyKlass() With {.X = 10, .Y = 20}
        Dim s = New MyStruct() With {.X = 5, .Y = 40}
        PrintObjects(c, s)
        WriteLine($"X: {c.X} Y: {c.Y}")
        WriteLine($"X: {s.X} Y: {s.Y}")
    End Sub

    Sub PrintObjects(c As MyKlass, s As MyStruct)
        c.X *= 2
        c.Y *= 2
        s.X *= 2
        s.Y *= 2
        WriteLine($"X: {c.X} Y: {c.Y}")
        WriteLine($"X: {s.X} Y: {s.Y}")
    End Sub

End Module
