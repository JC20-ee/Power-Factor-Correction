Imports System.Math
Public Class Form1
    Const pi As Double = Math.PI
    Private Sub FormReset(sender As Object, e As EventArgs) Handles Me.Load, btnReset.Click, ResetToolStripMenuItem.Click
        txtF.Clear()
        txtNpf.Clear()
        txtOpf.Clear()
        txtP.Clear()
        txtV.Clear()
        txtC.Clear()
        txtP.Focus()
        cmbPrefix.SelectedItem = "μF" 'Default display in microfarads
    End Sub
    Private Sub txtP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtP.KeyPress, txtV.KeyPress, txtOpf.KeyPress, txtNpf.KeyPress, txtF.KeyPress
        If Char.IsControl(e.KeyChar) Then Return

        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c) Then e.Handled = True

        If e.KeyChar = "."c AndAlso (txtP.SelectionStart = 0 OrElse txtP.Text.Contains(".")) Then e.Handled = True
    End Sub
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Try
            Dim Pt As Double = txtP.Text
            Dim pfOld As Double = txtOpf.Text
            Dim pfNew As Double = txtNpf.Text
            Dim VL As Double = txtV.Text
            Dim f As Double

            If txtF.Text = "" Then
                f = 60
                txtF.Text = "60"
            Else
                f = txtF.Text
            End If

            If Pt = 0 Or pfOld = 0 Or pfOld > 1 Or pfNew = 0 Or pfNew > 1 Or VL = 0 Or f = 0 Then
                MessageBox.Show("Please enter valid numeric values for all fields.", "Input Error")
                Exit Sub
            End If

            Dim S_old As Double = Pt * 1000 / pfOld
            Dim Q_old As Double = Sqrt(S_old ^ 2 - (Pt * 1000) ^ 2)
            Dim S_new As Double = Pt * 1000 / pfNew
            Dim Q_new As Double = Sqrt(S_new ^ 2 - (Pt * 1000) ^ 2)
            Dim Q_pfc As Double = Q_old - Q_new
            Dim Xc As Double = (3 * VL ^ 2) / Q_pfc
            Dim C As Double = 1 / (2 * pi * f * Xc)

            Dim displayValue As Double = ConvertCapacitance(C, cmbPrefix.SelectedItem.ToString())
            txtC.Text = Math.Round(displayValue, 4).ToString()
            txtData.Text = "S_old: " & Math.Round(S_old / 10 ^ 3, 4) & " kVA" & vbNewLine & vbNewLine & "Q_old: " &
            Math.Round(Q_old / 10 ^ 3, 4) & " kvar" & vbNewLine & vbNewLine & "S_new: " &
            Math.Round(S_new / 10 ^ 3, 4) & " kVA" & vbNewLine & vbNewLine & "Q_new: " &
            Math.Round(Q_new / 10 ^ 3, 4) & " kvar" & vbNewLine & vbNewLine & "Q_pfc: " &
            Math.Round(Q_pfc / 10 ^ 3, 4) & " kvar" & vbNewLine & vbNewLine & "X_c: " &
            Math.Round(Xc, 4) & " ohm"

            ' Show chart in new form with values
            Dim chartWindow As New ChartForm()
            chartWindow.LoadReactivePower(Q_old, Q_new, Q_pfc)
            chartWindow.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error during calculation: " & ex.Message, "Error")
            FormReset(Nothing, Nothing)
        End Try
    End Sub
    Private Function ConvertCapacitance(C_Farad As Double, unitPrefix As String) As Double
        Select Case unitPrefix
            Case "pF"
                Return C_Farad * 10 ^ 12
            Case "nF"
                Return C_Farad * 10 ^ 9
            Case "mF"
                Return C_Farad * 10 ^ 3
            Case "F"
                Return C_Farad
            Case "kF"
                Return C_Farad / 10 ^ 3
            Case "MF"
                Return C_Farad / 10 ^ 6
            Case Else
                Return C_Farad * 10 ^ 6 ' Default to μF
        End Select
    End Function
    Private Sub cmbPrefix_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrefix.SelectedIndexChanged
        ' Recalculate output with new unit
        If txtC.Text <> "" Then
            btnCompute.PerformClick()
        End If
    End Sub
    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim ExitYN = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "Exit?")

        If ExitYN = MsgBoxResult.No Then e.Cancel = True
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim NForm2 As New Form2()

        NForm2.ShowDialog()
    End Sub
    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        Dim imgForm As New ImageForm()
        imgForm.LoadEmbeddedImage()
        imgForm.ShowDialog()
    End Sub
End Class
