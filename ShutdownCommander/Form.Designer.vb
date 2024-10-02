<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_command = New System.Windows.Forms.TextBox()
        Me.chb_time = New System.Windows.Forms.CheckBox()
        Me.lsb_action = New System.Windows.Forms.ListBox()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.dtp_time = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txt_command
        '
        Me.txt_command.Location = New System.Drawing.Point(12, 12)
        Me.txt_command.Name = "txt_command"
        Me.txt_command.Size = New System.Drawing.Size(642, 28)
        Me.txt_command.TabIndex = 0
        Me.txt_command.Text = "shutdown"
        '
        'chb_time
        '
        Me.chb_time.AutoSize = True
        Me.chb_time.Location = New System.Drawing.Point(229, 46)
        Me.chb_time.Name = "chb_time"
        Me.chb_time.Size = New System.Drawing.Size(160, 22)
        Me.chb_time.TabIndex = 1
        Me.chb_time.Text = "定时关机 Timer"
        Me.chb_time.UseVisualStyleBackColor = True
        '
        'lsb_action
        '
        Me.lsb_action.FormattingEnabled = True
        Me.lsb_action.ItemHeight = 18
        Me.lsb_action.Items.AddRange(New Object() {"关机", "关机并登录上次用户", "重启", "重启并登录上次用户", "中止关闭", "休眠", "注销"})
        Me.lsb_action.Location = New System.Drawing.Point(12, 46)
        Me.lsb_action.Name = "lsb_action"
        Me.lsb_action.Size = New System.Drawing.Size(211, 130)
        Me.lsb_action.TabIndex = 2
        Me.lsb_action.Tag = ""
        '
        'dtp_date
        '
        Me.dtp_date.Enabled = False
        Me.dtp_date.Location = New System.Drawing.Point(229, 75)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(200, 28)
        Me.dtp_date.TabIndex = 3
        Me.dtp_date.Value = New Date(2024, 10, 2, 0, 0, 0, 0)
        '
        'dtp_time
        '
        Me.dtp_time.Enabled = False
        Me.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_time.Location = New System.Drawing.Point(230, 110)
        Me.dtp_time.Name = "dtp_time"
        Me.dtp_time.ShowUpDown = True
        Me.dtp_time.Size = New System.Drawing.Size(200, 28)
        Me.dtp_time.TabIndex = 4
        Me.dtp_time.Value = New Date(2024, 10, 2, 17, 32, 5, 0)
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 189)
        Me.Controls.Add(Me.dtp_time)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.lsb_action)
        Me.Controls.Add(Me.chb_time)
        Me.Controls.Add(Me.txt_command)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(822, 506)
        Me.Name = "Form"
        Me.Text = "Shutdown Commander"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_command As TextBox
    Friend WithEvents chb_time As CheckBox
    Friend WithEvents lsb_action As ListBox
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents dtp_time As DateTimePicker
End Class
