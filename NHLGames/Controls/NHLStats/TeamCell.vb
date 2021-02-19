Imports NHLGames.Utilities

Namespace NHLStats
    Public Class TeamCell
        Inherits DataGridViewCell
        'Public Overrides ReadOnly Property ValueType() As Type
        '    Get
        '        ' Return the type of the value that CalendarCell contains.
        '        Return GetType(StandingRowHeaderViewModel)
        '    End Get
        'End Property

        Public Overrides ReadOnly Property DefaultNewRowValue() As Object
            Get
                ' Use the current date and time as the default value.
                Return String.Empty
            End Get
        End Property

        Protected Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, cellBounds As Rectangle, rowIndex As Integer, cellState As DataGridViewElementStates, value As Object, formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
            PaintPrivate(graphics,
                           clipBounds,
                           cellBounds,
                           rowIndex,
                           cellState,
                           formattedValue,
                           errorText,
                           cellStyle,
                           advancedBorderStyle,
                           paintParts,
                           False,
                           False,
                           True)
        End Sub

        Private Function PaintPrivate(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, ByVal formattedValue As StandingRowHeaderViewModel, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts, ByVal computeContentBounds As Boolean, ByVal computeErrorIconBounds As Boolean, ByVal paint As Boolean) As Rectangle

            Dim resultBounds As Rectangle = Rectangle.Empty

            If paint AndAlso PaintBorderCheck(paintParts) Then
                PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle)
            End If

            Dim borderWidthsRect As Rectangle = BorderWidths(advancedBorderStyle)
            Dim valBounds As Rectangle = cellBounds
            valBounds.Offset(borderWidthsRect.X, borderWidthsRect.Y)
            valBounds.Width -= borderWidthsRect.Right
            valBounds.Height -= borderWidthsRect.Bottom
            Dim br As SolidBrush
            Dim ptCurrentCell As Point = Me.DataGridView.CurrentCellAddress
            Dim cellCurrent As Boolean = ptCurrentCell.X = Me.ColumnIndex AndAlso ptCurrentCell.Y = rowIndex
            Dim cellEdited As Boolean = cellCurrent AndAlso Me.DataGridView.EditingControl IsNot Nothing
            Dim cellSelected As Boolean = (cellState And DataGridViewElementStates.Selected) <> 0

            If PaintSelectionBackgroundCheck(paintParts) AndAlso cellSelected AndAlso Not cellEdited Then
                br = New SolidBrush(cellStyle.SelectionBackColor)
            Else
                br = New SolidBrush(cellStyle.BackColor)
            End If

            If paint AndAlso PaintBackgroundCheck(paintParts) AndAlso br.Color.A = 255 AndAlso valBounds.Width > 0 AndAlso valBounds.Height > 0 Then
                graphics.FillRectangle(br, valBounds)
            End If

            Dim formattedString As String = String.Format($"{formattedValue.Rank.ToString().PadLeft(2)}              {formattedValue.TeamName}")
            If formattedString IsNot Nothing AndAlso ((paint AndAlso Not cellEdited) OrElse computeContentBounds) Then
                Dim verticalTextMarginTop As Integer = If(cellStyle.WrapMode = DataGridViewTriState.[True], DATAGRIDVIEWTEXTBOXCELL_verticalTextMarginTopWithWrapping, DATAGRIDVIEWTEXTBOXCELL_verticalTextMarginTopWithoutWrapping)
                valBounds.Offset(DATAGRIDVIEWTEXTBOXCELL_horizontalTextMarginLeft, verticalTextMarginTop)
                valBounds.Width -= DATAGRIDVIEWTEXTBOXCELL_horizontalTextMarginLeft + DATAGRIDVIEWTEXTBOXCELL_horizontalTextMarginRight
                valBounds.Height -= verticalTextMarginTop + DATAGRIDVIEWTEXTBOXCELL_verticalTextMarginBottom

                If valBounds.Width > 0 AndAlso valBounds.Height > 0 Then
                    Dim flags As TextFormatFlags = ComputeTextFormatFlagsForCellStyleAlignment(DataGridView.RightToLeft, cellStyle.Alignment, cellStyle.WrapMode)

                    If paint Then

                        If PaintContentForegroundCheck(paintParts) Then

                            If (flags And TextFormatFlags.SingleLine) <> 0 Then
                                flags = flags Or TextFormatFlags.EndEllipsis
                            End If

                            TextRenderer.DrawText(graphics, formattedString, cellStyle.Font, valBounds, If(cellSelected, cellStyle.SelectionForeColor, cellStyle.ForeColor), flags)
                        End If
                    End If
                End If
            End If

            Dim themeChar = "l"
            If NHLGamesMetro.IsDarkMode Then
                themeChar = "d"
            End If

            Dim teamName = $"{Team.TeamAbbreviation(formattedValue.TeamName)}_{themeChar}"
            If paint AndAlso PaintContentForegroundCheck(paintParts) Then

                Dim image = ImageFetcher.GetEmbeddedImage(teamName)
                Dim width = 24
                Dim height = 24
                Dim scale = Math.Min(width / image.Width, height / image.Height)

                Dim scaleWidth = CType(image.Width * scale, Int32)
                Dim scaleHeight = CType(image.Height * scale, Int32)

                graphics.DrawImage(image, valBounds.X + 25, valBounds.Y, scaleWidth, scaleHeight)
            End If

            Return resultBounds
        End Function

        Friend Shared Function PaintBackgroundCheck(ByVal paintParts As DataGridViewPaintParts) As Boolean
            Return (paintParts And DataGridViewPaintParts.Background) <> 0
        End Function

        Friend Shared Function PaintSelectionBackgroundCheck(ByVal paintParts As DataGridViewPaintParts) As Boolean
            Return (paintParts And DataGridViewPaintParts.SelectionBackground) <> 0
        End Function

        Friend Shared Function PaintBorderCheck(ByVal paintParts As DataGridViewPaintParts) As Boolean
            Return (paintParts And DataGridViewPaintParts.Border) <> 0
        End Function

        Friend Shared Function PaintFocusCheck(ByVal paintParts As DataGridViewPaintParts) As Boolean
            Return (paintParts And DataGridViewPaintParts.Focus) <> 0
        End Function

        Friend Shared Function PaintContentForegroundCheck(ByVal paintParts As DataGridViewPaintParts) As Boolean
            Return (paintParts And DataGridViewPaintParts.ContentForeground) <> 0
        End Function

        Private Const DATAGRIDVIEWTEXTBOXCELL_horizontalTextMarginLeft As Byte = 0
        Private Const DATAGRIDVIEWTEXTBOXCELL_horizontalTextMarginRight As Byte = 0
        Private Const DATAGRIDVIEWTEXTBOXCELL_verticalTextMarginTopWithWrapping As Byte = 1
        Private Const DATAGRIDVIEWTEXTBOXCELL_verticalTextMarginTopWithoutWrapping As Byte = 2
        Private Const DATAGRIDVIEWTEXTBOXCELL_verticalTextMarginBottom As Byte = 1

        Friend Shared Function ComputeTextFormatFlagsForCellStyleAlignment(ByVal rightToLeft As Boolean, ByVal alignment As DataGridViewContentAlignment, ByVal wrapMode As DataGridViewTriState) As TextFormatFlags
            Dim tff As TextFormatFlags

            Select Case alignment
                Case DataGridViewContentAlignment.TopLeft
                    tff = TextFormatFlags.Top

                    If rightToLeft Then
                        tff = tff Or TextFormatFlags.Right
                    Else
                        tff = tff Or TextFormatFlags.Left
                    End If

                Case DataGridViewContentAlignment.TopCenter
                    tff = TextFormatFlags.Top Or TextFormatFlags.HorizontalCenter
                Case DataGridViewContentAlignment.TopRight
                    tff = TextFormatFlags.Top

                    If rightToLeft Then
                        tff = tff Or TextFormatFlags.Left
                    Else
                        tff = tff Or TextFormatFlags.Right
                    End If

                Case DataGridViewContentAlignment.MiddleLeft
                    tff = TextFormatFlags.VerticalCenter

                    If rightToLeft Then
                        tff = tff Or TextFormatFlags.Right
                    Else
                        tff = tff Or TextFormatFlags.Left
                    End If

                Case DataGridViewContentAlignment.MiddleCenter
                    tff = TextFormatFlags.VerticalCenter Or TextFormatFlags.HorizontalCenter
                Case DataGridViewContentAlignment.MiddleRight
                    tff = TextFormatFlags.VerticalCenter

                    If rightToLeft Then
                        tff = tff Or TextFormatFlags.Left
                    Else
                        tff = tff Or TextFormatFlags.Right
                    End If

                Case DataGridViewContentAlignment.BottomLeft
                    tff = TextFormatFlags.Bottom

                    If rightToLeft Then
                        tff = tff Or TextFormatFlags.Right
                    Else
                        tff = tff Or TextFormatFlags.Left
                    End If

                Case DataGridViewContentAlignment.BottomCenter
                    tff = TextFormatFlags.Bottom Or TextFormatFlags.HorizontalCenter
                Case DataGridViewContentAlignment.BottomRight
                    tff = TextFormatFlags.Bottom

                    If rightToLeft Then
                        tff = tff Or TextFormatFlags.Left
                    Else
                        tff = tff Or TextFormatFlags.Right
                    End If

                Case Else
                    tff = TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter
            End Select

            If wrapMode = DataGridViewTriState.[False] Then
                tff = tff Or TextFormatFlags.SingleLine
            Else
                tff = tff Or TextFormatFlags.WordBreak
            End If

            tff = tff Or TextFormatFlags.NoPrefix
            tff = tff Or TextFormatFlags.PreserveGraphicsClipping

            If rightToLeft Then
                tff = tff Or TextFormatFlags.RightToLeft
            End If

            Return tff
        End Function

    End Class
End Namespace
