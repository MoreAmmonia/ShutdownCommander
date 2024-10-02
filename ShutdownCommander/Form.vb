Public Class Form
    Public ActionDict() As String = {" -s", " -sg", " -r", " -rg", " -a", " -h", " -l"}
    Public Loaded As Boolean = 0
    Sub RefreshCommand() Handles lsb_action.SelectedIndexChanged, chb_time.CheckedChanged, dtp_date.ValueChanged, dtp_time.ValueChanged
        If Not Loaded Then
            Return
        End If
        txt_command.Text = "shutdown" + ActionDict(lsb_action.SelectedIndex)
        If chb_time.Checked Then
            'MsgBox(DateDiff("s", Now, dtp_date.Value.AddHours(dtp_time.Value.Hour).AddMinutes(dtp_time.Value.Minute).AddSeconds(dtp_time.Value.Second)))
            'dtp_time.Value = dtp_date.Value.Date
            'MsgBox(dtp_time.Value.)
        End If
        txt_command.Text = txt_command.Text + " -t " + DateDiff("s", Now, dtp_date.Value.AddHours(dtp_time.Value.Hour).AddMinutes(dtp_time.Value.Minute).AddSeconds(dtp_time.Value.Second)).ToString
    End Sub

    Private Sub chb_time_CheckedChanged(sender As Object, e As EventArgs) Handles chb_time.CheckedChanged
        If chb_time.Checked Then
            dtp_date.Enabled = 1
            dtp_time.Enabled = 1
        Else
            dtp_date.Enabled = 0
            dtp_time.Enabled = 0
        End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsb_action.SelectedIndex = 0
        Loaded = 1
    End Sub

End Class
