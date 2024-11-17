Public Interface IExample
    Sub Display()
End Interface
Public Class Test
    Implements IExample

    Public Sub Display() Implements IExample.Display
        Console.WriteLine("This is Example of Implicit Interface")
    End Sub
End Class
