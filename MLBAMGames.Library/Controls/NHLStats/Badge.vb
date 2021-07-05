Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework.Components
Imports MetroFramework.Controls

Namespace NHLStats
    Public Module Adorner
        Private controls As List(Of Control) = New List(Of Control)()

        Function AddBadgeTo(ByVal ctl As Control, ByVal Text As String) As Boolean
            If controls.Contains(ctl) Then Return False
            Dim badge As Badge = New Badge()
            badge.AutoSize = True
            badge.Text = Text.PadLeft(2, "0")
            badge.BackColor = Color.Transparent
            controls.Add(ctl)
            ctl.Controls.Add(badge)
            SetPosition(badge, ctl)
            Return True
        End Function

        Function RemoveBadgeFrom(ByVal ctl As Control) As Boolean
            Dim badge As Badge = GetBadge(ctl)

            If badge IsNot Nothing Then
                ctl.Controls.Remove(badge)
                controls.Remove(ctl)
                Return True
            Else
                Return False
            End If
        End Function

        Sub SetBadgeText(ByVal ctl As Control, ByVal newText As String)
            Dim badge As Badge = GetBadge(ctl)

            If badge IsNot Nothing Then
                badge.Text = newText
                SetPosition(badge, ctl)
            End If
        End Sub

        Function GetBadgeText(ByVal ctl As Control) As String
            Dim badge As Badge = GetBadge(ctl)
            If badge IsNot Nothing Then Return badge.Text
            Return ""
        End Function

        Private Sub SetPosition(ByVal badge As Badge, ByVal ctl As Control)
            badge.Location = New Point(ctl.Width - badge.Width, ctl.Height - badge.Height)
        End Sub

        Private Function GetBadge(ByVal ctl As Control) As Badge
            For c As Integer = 0 To ctl.Controls.Count - 1
                If TypeOf ctl.Controls(c) Is Badge Then Return TryCast(ctl.Controls(c), Badge)
            Next

            Return Nothing
        End Function

        Class Badge
            Inherits Label

            Private ellipseBackColor As Color = Color.FromArgb(0, 174, 219)
            Private ellipseForeColor As Color = Color.White
            Private ellipseFont As Font = New Font("Sans Serif", 8.0F)

            Public Sub New()
                Me.AutoSize = True
                Me.TextAlign = ContentAlignment.MiddleCenter
            End Sub

            Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
                e.Graphics.FillEllipse(New SolidBrush(ellipseBackColor), Me.ClientRectangle)
                e.Graphics.DrawString(Text, ellipseFont, New SolidBrush(ellipseForeColor), 1, 4)
            End Sub

        End Class
    End Module

End Namespace