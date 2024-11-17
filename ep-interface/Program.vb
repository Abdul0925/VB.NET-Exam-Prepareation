Imports System

Public Interface IVehicle
    Sub StartEngine()
    Sub StopEngine()

End Interface

Public Class car
    Implements IVehicle

    Public Sub StartEngine() Implements IVehicle.StartEngine
        Console.WriteLine("Car engine started.")
    End Sub

    Public Sub StopEngine() Implements IVehicle.StopEngine
        Console.WriteLine("Car engine stoped.")
    End Sub
End Class

Public Class motorcycle
    Implements IVehicle

    Public Sub StartEngine() Implements IVehicle.StartEngine
        Console.WriteLine("motorcycle engine started.")
    End Sub

    Public Sub StopEngine() Implements IVehicle.StopEngine
        Console.WriteLine("motorcycle engine stoped.")
    End Sub
End Class

Module Program
    Sub Main(args As String())
        'Abstraction
        Dim myvehicle As IVehicle
        myvehicle = New car
        myvehicle.StartEngine()
        myvehicle.StopEngine()
        myvehicle = New motorcycle
        myvehicle.StartEngine()
        myvehicle.StopEngine()
    End Sub
End Module
