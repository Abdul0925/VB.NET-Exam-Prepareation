
# Multiple Inheritance in VB.NET

VB.NET does not support multiple inheritance directly, meaning a class cannot inherit from more than one class. However, it allows for multiple inheritance-like behavior using interfaces. A class in VB.NET can implement multiple interfaces, which enables it to inherit behavior from multiple sources.





## Error Code

If you Write this code you will get Error

```bash
Imports System

Public Class FirstParent
    Protected var1 As Integer
End Class

Public Class SecondParent
    Protected var2 As Integer
End Class

Public Class Child
    Inherits FirstParent, SecondParent

    Public Sub New(ByVal a As Integer)
        var1 = a
    End Sub

    Public Sub Show()
        Console.WriteLine("First Child Accesing Variable 1 : {0}", var1)
    End Sub
End Class


Module Program
    Sub Main(args As String())
        Dim obj As Child
        obj = New Child(10)
        obj.Show()
    End Sub
End Module

```

