Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports MetroFramework
Imports MLBAMGames.Library.Utilities
Imports NHLGames.Utilities

Namespace Controls
    Public Class CalendarControl
        Implements IDisposable

        Public Shared LabelDate As Label
        Public Shared FlpCalendar As FlowLayoutPanel
        Public Shared GameDate As Date = DateHelper.GetPacificTime()

        Private _currentDate As Date
        Private ReadOnly _arrayButtons(,) As Button
        Private ReadOnly _btnBackColor As Color = Color.White
        Private ReadOnly _btnForeColor As Color = Color.Black

        Private Sub ReloadCal(ldate As Date, selected As Integer)
            _currentDate = ldate
            lnkToday.Text = Lang.RmText.GetString("lnkCalendarToday")
            tt.SetToolTip(btnBeforeMonth, Lang.RmText.GetString("tipMonthLeft"))
            tt.SetToolTip(_btnBeforeYear, Lang.RmText.GetString("tipYearUp"))
            tt.SetToolTip(btnNextMonth, Lang.RmText.GetString("tipMonthRight"))
            tt.SetToolTip(btnNextYear, Lang.RmText.GetString("tipYearDown"))
            Clearall()
            lblDate.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ldate.Month) & $" " &
                           ldate.Year.ToString
            Sun.Text = DateHelper.GetFormattedWeek(0)
            Mon.Text = DateHelper.GetFormattedWeek(1)
            Tue.Text = DateHelper.GetFormattedWeek(2)
            Wed.Text = DateHelper.GetFormattedWeek(3)
            Thu.Text = DateHelper.GetFormattedWeek(4)
            Fri.Text = DateHelper.GetFormattedWeek(5)
            Sat.Text = DateHelper.GetFormattedWeek(6)
            Dim fdate As DayOfWeek = GetFirstOfMonthDay(ldate)
            Dim idate = 1
            Dim row = 0

            For c = 0 To fdate - 1
                _arrayButtons(row, c).Enabled = False
            Next

            While idate < Date.DaysInMonth(ldate.Year, ldate.Month) + 1
                _arrayButtons(row, fdate).Text = idate
                _arrayButtons(row, fdate).ForeColor = _btnForeColor
                _arrayButtons(row, fdate).BackColor = _btnBackColor
                If idate = selected And ldate.Month = Date.Today.Month And ldate.Year = Date.Today.Year Then
                    _arrayButtons(row, fdate).ForeColor = Color.White
                    _arrayButtons(row, fdate).BackColor = Color.FromArgb(CType(CType(0, Byte), Integer),
                                                                         CType(CType(170, Byte), Integer),
                                                                         CType(CType(210, Byte), Integer))
                End If
                If fdate = DayOfWeek.Saturday Then
                    row += 1
                End If
                fdate = If(fdate = 6, 0, fdate + 1)
                idate += 1
            End While

            While (idate + GetFirstOfMonthDay(ldate)) <= 42
                _arrayButtons(row, fdate).Enabled = False
                If fdate = DayOfWeek.Saturday Then
                    row += 1
                End If
                fdate = If(fdate = 6, 0, fdate + 1)
                idate += 1
            End While
        End Sub

        Private Sub Clearall()
            For Each bt In _arrayButtons
                bt.Text = Nothing
                bt.Enabled = True
            Next
        End Sub

        Private Function GetFirstOfMonthDay(thisDay As Date) As DayOfWeek
            Dim tday As DayOfWeek = thisDay.DayOfWeek
            Dim tint As Integer = thisDay.Day
            If tint = 1 Then
                Return tday
            End If
            Do
                tint -= 1
                tday = If(tday = 0, 6, tday - 1)
                If tint = 1 Then Exit Do
            Loop
            Return tday
        End Function

        Public Sub New()
            InitializeComponent()

            _arrayButtons = New Button(,) {
                                              {Su1, Mo1, Tu1, We1, Th1, Fr1, Sa1},
                                              {Su2, Mo2, Tu2, We2, Th2, Fr2, Sa2},
                                              {Su3, Mo3, Tu3, We3, Th3, Fr3, Sa3},
                                              {Su4, Mo4, Tu4, We4, Th4, Fr4, Sa4},
                                              {Su5, Mo5, Tu5, We5, Th5, Fr5, Sa5},
                                              {Su6, Mo6, Tu6, We6, Th6, Fr6, Sa6}
                                          }

            Dim theme = If(Parameters.IsDarkMode, "d", "l")
            If Parameters.IsDarkMode Then
                _btnBackColor = Color.FromArgb(40, 40, 40)
                _btnForeColor = Color.LightGray
                BackColor = Color.FromArgb(40, 40, 40)
                lblDate.BackColor = Color.FromArgb(80, 80, 80)
                lblDate.ForeColor = Color.LightGray
                btnNextYear.BackColor = Color.LightGray
                btnBeforeYear.BackColor = Color.LightGray
                btnBeforeMonth.BackColor = Color.LightGray
                btnNextMonth.BackColor = Color.LightGray
                lnkToday.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80)
                lblWeeksBackground.BackColor = Color.FromArgb(60, 60, 60)
                Sun.BackColor = Color.FromArgb(60, 60, 60)
                Sun.ForeColor = _btnForeColor
                Mon.BackColor = Color.FromArgb(60, 60, 60)
                Mon.ForeColor = _btnForeColor
                Tue.BackColor = Color.FromArgb(60, 60, 60)
                Tue.ForeColor = _btnForeColor
                Wed.BackColor = Color.FromArgb(60, 60, 60)
                Wed.ForeColor = _btnForeColor
                Thu.BackColor = Color.FromArgb(60, 60, 60)
                Thu.ForeColor = _btnForeColor
                Fri.BackColor = Color.FromArgb(60, 60, 60)
                Fri.ForeColor = _btnForeColor
                Sat.BackColor = Color.FromArgb(60, 60, 60)
                Sat.ForeColor = _btnForeColor
                lblWeeksBackground.ForeColor = Color.LightGray
                For Each b In _arrayButtons
                    b.ForeColor = _btnForeColor
                    b.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60)
                    b.BackColor = Color.FromArgb(40, 40, 40)
                    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80)
                Next
            End If
            btnNextMonth.BackgroundImage = ImageFetcher.GetEmbeddedImage($"right_{theme}")
            btnBeforeMonth.BackgroundImage = ImageFetcher.GetEmbeddedImage($"left_{theme}")
            btnBeforeYear.BackgroundImage = ImageFetcher.GetEmbeddedImage($"up_{theme}")
            btnNextYear.BackgroundImage = ImageFetcher.GetEmbeddedImage($"down_{theme}")

            ReloadCal(Date.Today, Date.Today.Day)
        End Sub

        Private Sub btnBeforeMonth_Click(sender As Object, e As EventArgs) Handles btnBeforeMonth.Click
            ReloadCal(_currentDate.AddMonths(-1), _currentDate.AddMonths(-1).Day)
        End Sub

        Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
            ReloadCal(_currentDate.AddMonths(1), _currentDate.AddMonths(1).Day)
        End Sub

        Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles lnkToday.Click
            ReloadCal(Date.Today, Date.Today.Day)
            GameDate = Date.Today
            LabelDate.Text = DateHelper.GetFormattedDate(Date.Today)
            FlpCalendar.Visible = False
        End Sub

        Private Sub Day_Click(sender As Object, e As EventArgs) _
            Handles We6.Click, We5.Click, We4.Click, We3.Click, We2.Click, We1.Click, Tu6.Click, Tu5.Click, Tu4.Click,
                    Tu3.Click, Tu2.Click, Tu1.Click, Th6.Click, Th5.Click, Th4.Click, Th3.Click, Th2.Click, Th1.Click,
                    Su6.Click, Su5.Click, Su4.Click, Su3.Click, Su2.Click, Su1.Click, Sa6.Click, Sa5.Click, Sa4.Click,
                    Sa3.Click, Sa2.Click, Sa1.Click, Mo6.Click, Mo5.Click, Mo4.Click, Mo3.Click, Mo2.Click, Mo1.Click,
                    Fr6.Click, Fr5.Click, Fr4.Click, Fr3.Click, Fr2.Click, Fr1.Click
            Dim btn As Button
            btn = sender
            Dim myDate = _currentDate.AddDays(-_currentDate.Day + btn.Text)
            GameDate = _currentDate.AddDays(-_currentDate.Day + btn.Text)
            LabelDate.Text = DateHelper.GetFormattedDate(myDate)
            FlpCalendar.Visible = False
        End Sub

        Private Sub btnBeforeYear_Click(sender As Object, e As EventArgs) Handles btnBeforeYear.Click
            ReloadCal(_currentDate.AddYears(1), _currentDate.AddYears(1).Day)
        End Sub

        Private Sub btnNextYear_Click(sender As Object, e As EventArgs) Handles btnNextYear.Click
            ReloadCal(_currentDate.AddYears(-1), _currentDate.AddYears(-1).Day)
        End Sub
    End Class
End Namespace
