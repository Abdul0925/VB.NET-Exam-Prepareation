Imports System
Imports System.Runtime.CompilerServices



Public Class Animal
    ' Virtual method
    Public Sub Speak()
        Console.WriteLine("The animal makes a sound")
    End Sub
End Class

Public Class Dog
    Inherits Animal

    ' Override method
    Public Sub Speak()
        Console.WriteLine("The dog barks")
    End Sub
End Class

Public Class Cat
    Inherits Animal

    ' Override method
    Public Sub Speak()
        Console.WriteLine("The cat meows")
    End Sub
End Class

Public Class Rectangle
    Private length As Integer
    Private breadth As Integer

    Public Sub New(ByVal len As Integer, ByVal brt As Integer)
        length = len
        breadth = brt
    End Sub


    Public Function Area() As Integer
        Return (length * breadth)
    End Function
    Protected Overrides Sub Finalize()
        Try
            Console.WriteLine("An Object of the Rectangle is being destroyed")
        Finally
            MyBase.Finalize()
        End Try
    End Sub

End Class

Module Program
    Sub Main(args As String())

        'Create a function to create obj of class to call destructor
        Get_Area()

        GC.Collect()

        Console.WriteLine("Press any key to exit")

        'Polymorphism
        'Dim myAnimal As Animal
        'myAnimal = New Dog()
        'myAnimal.Speak()
        'myAnimal = New Cat()
        'myAnimal.Speak()



        Console.ReadKey()

    End Sub
    Public Sub Get_Area()
        Dim rect As Rectangle = New Rectangle(10, 4)
        Console.WriteLine("Area is {0} ", rect.Area())
    End Sub
End Module

