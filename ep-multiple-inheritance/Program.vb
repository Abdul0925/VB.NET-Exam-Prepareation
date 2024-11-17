Imports System


Public Interface IDraw
    Sub draw()
End Interface
Public Interface IColor
    Sub fillColor()
End Interface

Public Class Rectangle
    Implements IDraw, IColor

    Public Sub draw() Implements IDraw.draw
        Console.WriteLine("Drawing a Rectangle")
    End Sub

    Public Sub fillColor() Implements IColor.fillColor
        Console.WriteLine("Filing a color in Rectangle")
    End Sub
End Class


Module Program
    Sub Main(args As String())
        Dim obj As New Rectangle
        obj.draw()
        obj.fillColor()
    End Sub
End Module
