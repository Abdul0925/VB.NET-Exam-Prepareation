Imports System

Public Interface IVehicle
    Sub StartEngine()
    Sub StopEngine()
End Interface

Public Class Car
    Implements IVehicle

    Public Sub StartEngine() Implements IVehicle.StartEngine
        Console.WriteLine("Car Engine is Starting")
    End Sub

    Public Sub StopEngine() Implements IVehicle.StopEngine
        Console.WriteLine("Car Engine is Stoping")
    End Sub
End Class


Public Class Bus
    Implements IVehicle

    Public Sub StartEngine() Implements IVehicle.StartEngine
        Console.WriteLine("Bus Engine is Starting")
    End Sub

    Public Sub StopEngine() Implements IVehicle.StopEngine
        Console.WriteLine("Bus Engine is Stoping")
    End Sub
End Class





Module Program
    Sub Main(args As String())
        'Abstraction
        Dim obj As IVehicle
        obj = New Car
        obj.StartEngine()
        obj.StopEngine()
        obj = New Bus
        obj.StartEngine()
        obj.StopEngine()

    End Sub
End Module
