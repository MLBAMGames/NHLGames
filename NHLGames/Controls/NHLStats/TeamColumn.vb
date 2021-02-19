Imports System.Windows.Forms

Namespace NHLStats
    Public Class TeamColumn
        Inherits DataGridViewColumn

        Public Sub New()
            MyBase.New(New TeamCell())
        End Sub

        Public Overrides Property CellTemplate() As DataGridViewCell
            Get
                Return MyBase.CellTemplate
            End Get
            Set(ByVal value As DataGridViewCell)

                ' Ensure that the cell used for the template is a CalendarCell.
                If (value IsNot Nothing) AndAlso
                    Not value.GetType().IsAssignableFrom(GetType(TeamCell)) Then
                    Throw New InvalidCastException("Must be a CalendarCell")
                End If
                MyBase.CellTemplate = value

            End Set
        End Property

    End Class
End Namespace
