Imports System
Public Interface IExplicit1
    Sub Display()
End Interface

Public Interface IExplicit2
    Sub Display()
End Interface
Public Class Test
    Implements IExplicit1, IExplicit2

    Private Sub IExplicit1_Display() Implements IExplicit1.Display
        Console.WriteLine("1st Interface Display Methode")
    End Sub

    Private Sub IExplicit2_Display() Implements IExplicit2.Display
        Console.WriteLine("2nd Interface Display Methode")
    End Sub
End Class
Module Program
    Sub Main(args As String())
        Dim obj1 As IExplicit1 = New Test
        Dim obj2 As IExplicit2 = New Test
        obj1.Display()
        obj2.Display()
    End Sub
End Module
