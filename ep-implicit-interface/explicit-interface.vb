Public Interface IExplicit
    Sub Display()
End Interface

Public Class Base
    Implements IExplicit

    Private Sub Display() Implements IExplicit.Display
        Console.WriteLine("This is Explicit Interface Example")
    End Sub
End Class
