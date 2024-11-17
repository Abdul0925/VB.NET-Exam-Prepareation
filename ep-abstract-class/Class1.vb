Public MustInherit Class Class1
    Public MustOverride Sub Display()

End Class

Public Class Derived
    Inherits Class1

    Public Overrides Sub Display()
        Console.WriteLine("Displaying Message")
    End Sub
End Class