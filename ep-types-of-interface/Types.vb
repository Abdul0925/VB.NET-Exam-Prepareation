Imports System
Module Program
    Sub Main(args As String())
        'Implicit Interface
        Dim obj As IExample = New Test
        obj.Display()
        'OR
        Dim obj1 As New Test
        obj1.Display()

        'Explicit Interface

        Dim exp As IExplicit = New Base
        exp.Display()
    End Sub
End Module
