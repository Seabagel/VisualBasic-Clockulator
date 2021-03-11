<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblClockIn = New System.Windows.Forms.Label()
        Me.lblLunchIn = New System.Windows.Forms.Label()
        Me.lblLunchOut = New System.Windows.Forms.Label()
        Me.lblClockOut = New System.Windows.Forms.Label()
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.txtClockInHour = New System.Windows.Forms.TextBox()
        Me.txtClockInMinute = New System.Windows.Forms.TextBox()
        Me.txtLunchInMinute = New System.Windows.Forms.TextBox()
        Me.txtLunchInHour = New System.Windows.Forms.TextBox()
        Me.txtLunchOutMinute = New System.Windows.Forms.TextBox()
        Me.txtLunchOutHour = New System.Windows.Forms.TextBox()
        Me.txtClockOutMinute = New System.Windows.Forms.TextBox()
        Me.txtClockOutHour = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.chkClockIn = New System.Windows.Forms.CheckBox()
        Me.chkLunchIn = New System.Windows.Forms.CheckBox()
        Me.chkLunchOut = New System.Windows.Forms.CheckBox()
        Me.chkClockOut = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblOvertime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 18.33962!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(107, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(234, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Clock Time Calculator"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.Location = New System.Drawing.Point(79, 86)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(88, 17)
        Me.lblHour.TabIndex = 1
        Me.lblHour.Text = "Work Hour : "
        '
        'lblClockIn
        '
        Me.lblClockIn.AutoSize = True
        Me.lblClockIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockIn.Location = New System.Drawing.Point(98, 126)
        Me.lblClockIn.Name = "lblClockIn"
        Me.lblClockIn.Size = New System.Drawing.Size(69, 17)
        Me.lblClockIn.TabIndex = 3
        Me.lblClockIn.Text = "Clock In : "
        '
        'lblLunchIn
        '
        Me.lblLunchIn.AutoSize = True
        Me.lblLunchIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLunchIn.Location = New System.Drawing.Point(93, 166)
        Me.lblLunchIn.Name = "lblLunchIn"
        Me.lblLunchIn.Size = New System.Drawing.Size(74, 17)
        Me.lblLunchIn.TabIndex = 9
        Me.lblLunchIn.Text = "Lunch In : "
        '
        'lblLunchOut
        '
        Me.lblLunchOut.AutoSize = True
        Me.lblLunchOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLunchOut.Location = New System.Drawing.Point(81, 206)
        Me.lblLunchOut.Name = "lblLunchOut"
        Me.lblLunchOut.Size = New System.Drawing.Size(86, 17)
        Me.lblLunchOut.TabIndex = 13
        Me.lblLunchOut.Text = "Lunch Out : "
        '
        'lblClockOut
        '
        Me.lblClockOut.AutoSize = True
        Me.lblClockOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockOut.Location = New System.Drawing.Point(86, 246)
        Me.lblClockOut.Name = "lblClockOut"
        Me.lblClockOut.Size = New System.Drawing.Size(81, 17)
        Me.lblClockOut.TabIndex = 17
        Me.lblClockOut.Text = "Clock Out : "
        '
        'txtHour
        '
        Me.txtHour.Font = New System.Drawing.Font("Calibri", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHour.Location = New System.Drawing.Point(182, 82)
        Me.txtHour.MaxLength = 1
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(48, 27)
        Me.txtHour.TabIndex = 2
        Me.txtHour.Text = "8"
        '
        'txtClockInHour
        '
        Me.txtClockInHour.Font = New System.Drawing.Font("Calibri", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClockInHour.Location = New System.Drawing.Point(182, 122)
        Me.txtClockInHour.MaxLength = 2
        Me.txtClockInHour.Name = "txtClockInHour"
        Me.txtClockInHour.Size = New System.Drawing.Size(48, 27)
        Me.txtClockInHour.TabIndex = 4
        Me.txtClockInHour.Text = "8"
        '
        'txtClockInMinute
        '
        Me.txtClockInMinute.Font = New System.Drawing.Font("Calibri", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClockInMinute.Location = New System.Drawing.Point(236, 122)
        Me.txtClockInMinute.MaxLength = 2
        Me.txtClockInMinute.Name = "txtClockInMinute"
        Me.txtClockInMinute.Size = New System.Drawing.Size(48, 27)
        Me.txtClockInMinute.TabIndex = 5
        Me.txtClockInMinute.Text = "0"
        '
        'txtLunchInMinute
        '
        Me.txtLunchInMinute.Font = New System.Drawing.Font("Calibri", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLunchInMinute.Location = New System.Drawing.Point(236, 162)
        Me.txtLunchInMinute.MaxLength = 2
        Me.txtLunchInMinute.Name = "txtLunchInMinute"
        Me.txtLunchInMinute.Size = New System.Drawing.Size(48, 27)
        Me.txtLunchInMinute.TabIndex = 11
        Me.txtLunchInMinute.Text = "0"
        '
        'txtLunchInHour
        '
        Me.txtLunchInHour.Font = New System.Drawing.Font("Calibri", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLunchInHour.Location = New System.Drawing.Point(182, 162)
        Me.txtLunchInHour.MaxLength = 2
        Me.txtLunchInHour.Name = "txtLunchInHour"
        Me.txtLunchInHour.Size = New System.Drawing.Size(48, 27)
        Me.txtLunchInHour.TabIndex = 10
        Me.txtLunchInHour.Text = "12"
        '
        'txtLunchOutMinute
        '
        Me.txtLunchOutMinute.Font = New System.Drawing.Font("Calibri", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLunchOutMinute.Location = New System.Drawing.Point(236, 202)
        Me.txtLunchOutMinute.MaxLength = 2
        Me.txtLunchOutMinute.Name = "txtLunchOutMinute"
        Me.txtLunchOutMinute.Size = New System.Drawing.Size(48, 27)
        Me.txtLunchOutMinute.TabIndex = 15
        Me.txtLunchOutMinute.Text = "0"
        '
        'txtLunchOutHour
        '
        Me.txtLunchOutHour.Font = New System.Drawing.Font("Calibri", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLunchOutHour.Location = New System.Drawing.Point(182, 202)
        Me.txtLunchOutHour.MaxLength = 2
        Me.txtLunchOutHour.Name = "txtLunchOutHour"
        Me.txtLunchOutHour.Size = New System.Drawing.Size(48, 27)
        Me.txtLunchOutHour.TabIndex = 14
        Me.txtLunchOutHour.Text = "1"
        '
        'txtClockOutMinute
        '
        Me.txtClockOutMinute.Font = New System.Drawing.Font("Calibri", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClockOutMinute.Location = New System.Drawing.Point(236, 242)
        Me.txtClockOutMinute.MaxLength = 2
        Me.txtClockOutMinute.Name = "txtClockOutMinute"
        Me.txtClockOutMinute.Size = New System.Drawing.Size(48, 27)
        Me.txtClockOutMinute.TabIndex = 19
        Me.txtClockOutMinute.Text = "0"
        '
        'txtClockOutHour
        '
        Me.txtClockOutHour.Font = New System.Drawing.Font("Calibri", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClockOutHour.Location = New System.Drawing.Point(182, 242)
        Me.txtClockOutHour.MaxLength = 2
        Me.txtClockOutHour.Name = "txtClockOutHour"
        Me.txtClockOutHour.Size = New System.Drawing.Size(48, 27)
        Me.txtClockOutHour.TabIndex = 18
        Me.txtClockOutHour.Text = "5"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(115, 330)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(104, 35)
        Me.btnCalculate.TabIndex = 23
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(178, 285)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(82, 20)
        Me.lblTotal.TabIndex = 22
        Me.lblTotal.Text = "0 Minutes"
        '
        'chkClockIn
        '
        Me.chkClockIn.AutoSize = True
        Me.chkClockIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!)
        Me.chkClockIn.Location = New System.Drawing.Point(292, 128)
        Me.chkClockIn.Name = "chkClockIn"
        Me.chkClockIn.Size = New System.Drawing.Size(42, 17)
        Me.chkClockIn.TabIndex = 6
        Me.chkClockIn.Text = "PM"
        Me.chkClockIn.UseVisualStyleBackColor = True
        '
        'chkLunchIn
        '
        Me.chkLunchIn.AutoSize = True
        Me.chkLunchIn.Checked = True
        Me.chkLunchIn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLunchIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!)
        Me.chkLunchIn.Location = New System.Drawing.Point(292, 168)
        Me.chkLunchIn.Name = "chkLunchIn"
        Me.chkLunchIn.Size = New System.Drawing.Size(42, 17)
        Me.chkLunchIn.TabIndex = 12
        Me.chkLunchIn.Text = "PM"
        Me.chkLunchIn.UseVisualStyleBackColor = True
        '
        'chkLunchOut
        '
        Me.chkLunchOut.AutoSize = True
        Me.chkLunchOut.Checked = True
        Me.chkLunchOut.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLunchOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!)
        Me.chkLunchOut.Location = New System.Drawing.Point(292, 208)
        Me.chkLunchOut.Name = "chkLunchOut"
        Me.chkLunchOut.Size = New System.Drawing.Size(42, 17)
        Me.chkLunchOut.TabIndex = 16
        Me.chkLunchOut.Text = "PM"
        Me.chkLunchOut.UseVisualStyleBackColor = True
        '
        'chkClockOut
        '
        Me.chkClockOut.AutoSize = True
        Me.chkClockOut.Checked = True
        Me.chkClockOut.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClockOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!)
        Me.chkClockOut.Location = New System.Drawing.Point(292, 248)
        Me.chkClockOut.Name = "chkClockOut"
        Me.chkClockOut.Size = New System.Drawing.Size(42, 17)
        Me.chkClockOut.TabIndex = 20
        Me.chkClockOut.Text = "PM"
        Me.chkClockOut.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(225, 330)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 35)
        Me.btnReset.TabIndex = 24
        Me.btnReset.Text = "Clear"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblOvertime
        '
        Me.lblOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOvertime.Location = New System.Drawing.Point(57, 286)
        Me.lblOvertime.Name = "lblOvertime"
        Me.lblOvertime.Size = New System.Drawing.Size(107, 19)
        Me.lblOvertime.TabIndex = 21
        Me.lblOvertime.Text = "On-Time :"
        Me.lblOvertime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 402)
        Me.Controls.Add(Me.lblOvertime)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.chkClockOut)
        Me.Controls.Add(Me.chkLunchOut)
        Me.Controls.Add(Me.chkLunchIn)
        Me.Controls.Add(Me.chkClockIn)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtClockOutMinute)
        Me.Controls.Add(Me.txtClockOutHour)
        Me.Controls.Add(Me.txtLunchOutMinute)
        Me.Controls.Add(Me.txtLunchOutHour)
        Me.Controls.Add(Me.txtLunchInMinute)
        Me.Controls.Add(Me.txtLunchInHour)
        Me.Controls.Add(Me.txtClockInMinute)
        Me.Controls.Add(Me.txtClockInHour)
        Me.Controls.Add(Me.txtHour)
        Me.Controls.Add(Me.lblClockOut)
        Me.Controls.Add(Me.lblLunchOut)
        Me.Controls.Add(Me.lblLunchIn)
        Me.Controls.Add(Me.lblClockIn)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Clockulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHour As Label
    Friend WithEvents lblClockIn As Label
    Friend WithEvents lblLunchIn As Label
    Friend WithEvents lblLunchOut As Label
    Friend WithEvents lblClockOut As Label
    Friend WithEvents txtHour As TextBox
    Friend WithEvents txtClockInHour As TextBox
    Friend WithEvents txtClockInMinute As TextBox
    Friend WithEvents txtLunchInMinute As TextBox
    Friend WithEvents txtLunchInHour As TextBox
    Friend WithEvents txtLunchOutMinute As TextBox
    Friend WithEvents txtLunchOutHour As TextBox
    Friend WithEvents txtClockOutMinute As TextBox
    Friend WithEvents txtClockOutHour As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents chkClockIn As CheckBox
    Friend WithEvents chkLunchIn As CheckBox
    Friend WithEvents chkLunchOut As CheckBox
    Friend WithEvents chkClockOut As CheckBox
    Friend WithEvents btnReset As Button
    Friend WithEvents lblOvertime As Label
End Class
