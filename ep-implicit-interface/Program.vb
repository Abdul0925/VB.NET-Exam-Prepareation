Imports System
Public Interface IImplicit
    Sub Display()
End Interface

Public Class Demo
    Implements IImplicit

    Public Sub Display() Implements IImplicit.Display
        Console.WriteLine("This is Implicit Interface Example")
    End Sub
End Class
Module Program
    Sub Main(args As String())
        Dim obj As Demo = New Demo
        obj.Display()
        Dim obj1 As IImplicit = New Demo
        obj1.Display()
    End Sub
End Module
