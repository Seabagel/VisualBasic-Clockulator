Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHour.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtHour.Focus()

        txtHour.Text = 8

        chkClockIn.Checked = False
        txtClockInHour.Text = 8
        txtClockInMinute.Text = 0

        chkLunchIn.Checked = True
        txtLunchInHour.Text = 12
        txtLunchInMinute.Text = 0

        chkLunchOut.Checked = True
        txtLunchOutHour.Text = 1
        txtLunchOutMinute.Text = 0

        chkClockOut.Checked = True
        txtClockOutHour.Text = 5
        txtClockOutMinute.Text = 0

        lblTotal.Text = "0 Minute"
        lblOvertime.Text = "On-Time :"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Initialize Variables

        ' Length of Work Hour Today
        Dim work As Integer = CInt(txtHour.Text)

        ' Clock In & Out for the whole Day
        Dim clockIn As clock12 = New clock12(CInt(txtClockInHour.Text), CInt(txtClockInMinute.Text), chkClockIn.Checked)
        Dim clockOut As clock12 = New clock12(CInt(txtClockOutHour.Text), CInt(txtClockOutMinute.Text), chkClockOut.Checked)

        ' Lunch In & Out
        Dim LunchIn As clock12 = New clock12(CInt(txtLunchInHour.Text), CInt(txtLunchInMinute.Text), chkLunchIn.Checked)
        Dim LunchOut As clock12 = New clock12(CInt(txtLunchOutHour.Text), CInt(txtLunchOutMinute.Text), chkLunchOut.Checked)

        ' Convert the Time from 12 Hour format to Minutes
        clockIn.convertToMinute()
        clockOut.convertToMinute()
        LunchIn.convertToMinute()
        LunchOut.convertToMinute()

        Console.WriteLine()
        Console.WriteLine("work " + CStr(work * 60))
        Console.WriteLine("clockIn.minute " + CStr(clockIn.minute))
        Console.WriteLine("clockOut.minute " + CStr(clockOut.minute))
        Console.WriteLine()
        Console.WriteLine("LunchIn.minute " + CStr(LunchIn.minute))
        Console.WriteLine("LunchOut.minute " + CStr(LunchOut.minute))

        ' Total Overtime / Undertime in Minutes
        Dim total As Integer = (clockOut.minute - clockIn.minute) - (work * 60) - (LunchOut.minute - LunchIn.minute)

        If total > 0 Then
            lblOvertime.Text = "Overtime :"
        ElseIf total < 0 Then
            lblOvertime.Text = "Undertime :"
        Else
            lblOvertime.Text = "On-Time :"
        End If

        lblTotal.Text = CStr(Math.Abs(total)) + " Minutes"

    End Sub

End Class

Public Class clock12
    Public hour As Integer
    Public minute As Integer
    Public pm As Boolean

    Public Sub convertToMinute()
        If pm And hour <> 12 Then
            minute += (hour * 60) + 720
        Else
            minute += hour * 60
        End If
        hour = 0
    End Sub

    Public Sub convertToHour()
        hour = Math.Floor(minute / 60)
        If minute >= 720 Then
            pm = True
            hour -= 12
        Else
            pm = False
        End If
        minute = minute Mod 60
    End Sub

    Sub New(ByVal hour As Integer, ByVal minute As Integer, ByVal pm As Boolean)
        Me.hour = CInt(hour)
        Me.minute = CInt(minute)
        Me.pm = pm
    End Sub
End Class