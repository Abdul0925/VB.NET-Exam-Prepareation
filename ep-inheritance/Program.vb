Imports System
Imports System.ComponentModel.DataAnnotations

Public Class Base
    Protected Length As Integer
    Protected Breadth As Integer
End Class
Public Class Derived
    Inherits Base
    Public Sub New(ByVal l As Integer, ByVal b As Integer)
        Length = l
        Breadth = b
    End Sub

    Public Sub Show()
        Console.WriteLine("Length = {0} and Breadth = {1}", Length, Breadth)
    End Sub

End Class
Module Program
    Sub Main(args As String())
        Dim obj As Derived
        obj = New Derived(10, 15)
        obj.Show()
    End Sub
End Module
