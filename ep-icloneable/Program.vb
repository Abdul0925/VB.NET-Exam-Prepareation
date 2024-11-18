Imports System
Public Class Person
    Implements ICloneable

    Public Property Name As String
    Public Property Age As Integer

    ' Implementation of Clone method
    Public Function Clone() As Object Implements ICloneable.Clone
        Return Me.MemberwiseClone() ' Creates a shallow copy
    End Function
    Public Sub display()
        Console.WriteLine(Name)
    End Sub
End Class



Module Program
    Sub Main(args As String())
        Dim original As New Person With {.Name = "Alice", .Age = 25}
        Dim clone As Person = CType(original.Clone(), Person)
        clone.Name = "Abdul"
        Console.WriteLine("{0}:{1}", clone.Name, clone.Age)
        Console.WriteLine("{0}:{1}", original.Name, original.Age) ' Output: Alice
        clone.display()
        original.display()
    End Sub
End Module
