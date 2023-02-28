Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblCostTickets.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGroupSize.Clear()

        radSuper.Checked = True
        radSuper.Checked = False
        radSuper.Checked = False
        txtGroupSize.Focus()
    End Sub

    Private Sub txtGroupSize_TextChanged(sender As Object, e As EventArgs) Handles txtGroupSize.TextChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        Dim intGroup As Integer = 0
        Dim decReg As Decimal
        Dim decTotal As Decimal
        Dim decSuper As Decimal = 3800
        Dim decAuto As Decimal = 2750
        Dim decCon As Decimal = 2090

        If IsNumeric(txtGroupSize.Text) Then
            If intGroup > 0 And intGroup < 20 Then
                If radSuper.Checked Then
                    decReg = decSuper
                ElseIf radAuto.Checked Then
                    decReg = decAuto
                ElseIf radCon.Checked Then
                    decReg = decCon

                End If

                decTotal = (intGroup * decReg)
                lblCostTickets.Text = decTotal.ToString("C")

            Else
                MsgBox("Enter a postive Number between 1 - 20", , "Invaldi Entry Error")

            End If

        Else
            MsgBox("Enter a  Number between 1 - 20", , "Invaldi Entry Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroupSize.Clear()
        lblCostTickets.Text = ""
        radSuper.Checked = True
        radSuper.Checked = False
        radSuper.Checked = False
        txtGroupSize.Focus()
    End Sub
End Class
