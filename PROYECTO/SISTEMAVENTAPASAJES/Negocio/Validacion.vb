Imports DATOS
Public Class Validacion
    Private obj As New Procesos
    Public Event mistake(ByVal c As Integer)
    Public Function REGISTRAVENTA(ByVal nom As Procesos.Venta) As Boolean
        Dim opc As Boolean
        If nom.numasiento = "#" Then
            opc = False
            RaiseEvent mistake(1)
            Throw New Exception("INGRESE N° DE ASIENTO")
        Else
            obj.RegistrarVenta(nom)
            opc = True
        End If
        Return opc
    End Function
    Public Function insertarbus(ByVal nom As Procesos.bus) As Boolean
        Dim opc As Boolean
        If nom.modbus = "" Then
            opc = False
            RaiseEvent mistake(1)
            Throw New Exception("Ingrese Modelo del Bus")
        Else
            obj.insertabus(nom)
            opc = True
        End If
        Return opc
    End Function
    Public Function modificarbus(ByVal nom As Procesos.bus) As Boolean
        Dim opc As Boolean
        If nom.modbus = "" Then
            opc = False
            RaiseEvent mistake(1)
            Throw New Exception("Ingrese Modelo del Bus")
        Else
            obj.modificarbus(nom)
            opc = True
        End If
        Return opc
    End Function

    Public Function eliminarbus(ByVal nom As Procesos.bus) As Boolean
        Dim opc As Boolean
        If nom.codbus = "" Then
            opc = False
            RaiseEvent mistake(1)
            Throw New Exception("Ingrese Código del Bus")
        Else
            obj.eliminarbus(nom)
            opc = True
        End If
        Return opc
    End Function

    Public Function insertarcliente(ByVal nom As Procesos.cliente) As Boolean
        Dim opc As Boolean
        If nom.nombres = "" Then
            opc = False
            RaiseEvent mistake(1)
            Throw New Exception("Ingrese Noombre del Cliente")
        Else
            obj.insertarcliente(nom)
            opc = True
        End If
        Return opc
    End Function
    Public Function modificarcliente(ByVal nom As Procesos.cliente) As Boolean
        Dim opc As Boolean
        If nom.nombres = "" Then
            opc = False
            RaiseEvent mistake(1)
            Throw New Exception("Ingrese Modelo del Bus")
        Else
            obj.modificarcliente(nom)
            opc = True
        End If
        Return opc
    End Function

    Public Function eliminarcliente(ByVal nom As Procesos.cliente) As Boolean
        Dim opc As Boolean
        If nom.codcliente = "" Then
            opc = False
            RaiseEvent mistake(1)
            Throw New Exception("Ingrese Código del Cliente")
        Else
            obj.eliminarcliente(nom)
            opc = True
        End If
        Return opc
    End Function
End Class
