Imports System
Public MustInherit Class Shape
    Public MustOverride Sub Draw()
    Public Sub Display()
        Console.WriteLine("Displaying A Shape")
    End Sub
End Class
Public Class Rectangle
    Inherits Shape

    Public Overrides Sub Draw()
        Console.WriteLine("Drwaing A Rectangle")
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim obj As Rectangle = New Rectangle
        obj.Display()
        obj.Draw()

    End Sub
End Module
