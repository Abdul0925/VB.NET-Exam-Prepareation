Imports System

Public Interface IExample
    Sub Display()
End Interface
Public Class Test
    Implements IExample

    Public Sub Display() Implements IExample.Display
        Console.WriteLine("This is Example of Implicit Interface")
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim obj As IExample = New Test
        obj.Display()
        'OR
        Dim obj1 As New Test
        obj1.Display()
    End Sub
End Module
