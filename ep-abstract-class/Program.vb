Imports System

Public Interface IShape
    Function Area() As Integer
    Sub Display()
End Interface

Public MustInherit Class BaseShape
    Implements IShape

    Protected MustOverride Function CalculateArea() As Integer
    Private Function Area() As Integer Implements IShape.Area
        Return CalculateArea()
    End Function

    Private Sub Display() Implements IShape.Display
        Console.WriteLine(Area)
    End Sub
End Class

Public Class Rectangle
    Inherits BaseShape
    Protected Overrides Function CalculateArea() As Integer
        Return 10 * 15
    End Function


End Class

Module Program
    Sub Main(args As String())
        Dim rect As IShape = New Rectangle
        rect.Display
        Dim abstractexample As New Derived
        abstractexample.Display()
    End Sub
End Module
