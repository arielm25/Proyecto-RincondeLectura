'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class editorial
    Public Property ideditorial As Integer
    Public Property nombre As String
    Public Property direccion As String
    Public Property telefono As Integer
    Public Property mail As String
    Public Property descripcion As String
    Public Property estado As String
    Public Property logo As Byte()

    Public Overridable Property libro As ICollection(Of libro) = New HashSet(Of libro)

End Class
