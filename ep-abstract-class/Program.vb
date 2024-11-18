Imports System
Imports System.IO

Public Interface IShape
    Function Area() As Integer
    Sub Display()

End Interface

Public MustInherit Class BaseShape
    Implements IShape

    Protected MustOverride Function CalculateArea() As Integer
    Private Sub Display() Implements IShape.Display
        Console.WriteLine("Area of a given Rectangle is {0}", Area())
    End Sub

    Private Function Area() As Integer Implements IShape.Area
        Return CalculateArea()
    End Function
End Class
Public Class Rectangle
    Inherits BaseShape
    Private length As Integer
    Private breadth As Integer
    Public Sub New(ByVal l As Integer, ByVal b As Integer)
        length = l
        breadth = b
    End Sub

    Protected Overrides Function CalculateArea() As Integer
        Return length * breadth
    End Function
End Class

Module Program
    Sub Main(args As String())
        Dim rect As IShape = New Rectangle(10, 15)
        rect.Display
        'Dim abstractexample As New Derived
        'abstractexample.Display()
    End Sub
End Module
