Public Class frmMain
    'Elvis Cruz
    'Feb 2,2021 
    'I affirm that this program was created by me. It is solely my work and does not inlcude any work done by anybody else.


    Private Const SIRLOIN_PRICE As Single = 13.25
    Private Const RIBEYE_PRICE As Single = 18
    Private Const TENDERLOIN_PRICE As Single = 19.95

    Private Const SEASONING_PRICE As Single = 4.5
    Private Const SHIPPING_PRICE As Single = 18
    Private Const TAX_PERCENT As Single = 0.075

    Private strBeef As String
    Private radBeef(2) As RadioButton
    Private arrChk(1) As CheckBox
    Private summary As frmSummary

    Private Total As Single = 0




    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load



        radBeef(0) = radSirloin
        radBeef(1) = radRibeye
        radBeef(2) = radTenderloin

        arrChk(0) = chkShipping
        arrChk(1) = chkSeasoning

    End Sub

    Private Sub radBeef_CheckedChanged(sender As Object, e As EventArgs) Handles radRibeye.CheckedChanged, radSirloin.CheckedChanged, radTenderloin.CheckedChanged

        Dim rad As RadioButton

        rad = DirectCast(sender, RadioButton)

        If rad.Checked Then
            strBeef = rad.Text

        End If




    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim strResult As String
        Dim i As Integer
        Dim blnErrors As Boolean
        errP.Clear()

        If radBeef(0).Checked Then

            Total += SIRLOIN_PRICE * qntDropdown.SelectedItem


        End If
        If radBeef(1).Checked Then
            Total += RIBEYE_PRICE * qntDropdown.SelectedItem



        End If
        If radBeef(2).Checked Then
            Total += TENDERLOIN_PRICE * qntDropdown.SelectedItem

        End If

        If qntDropdown.SelectedIndex = -1 Then
            errP.SetError(qntDropdown, "You must select how much you would like")
            blnErrors = True

        End If

        If arrChk(0).Checked Then

            Total += SHIPPING_PRICE
            If txtName.Text = "" Then
                errP.SetError(txtName, "You must fill in required fields")
                blnErrors = True
            End If

            If txtCity.Text = "" Then
                errP.SetError(txtCity, "You must fill in required fields")
                blnErrors = True
            End If
            If txtAddress.Text = "" Then
                errP.SetError(txtAddress, "You must fill in required fields")
                blnErrors = True
            End If
            If txtPhone.Text = "" Then
                errP.SetError(txtPhone, "You must fill in required fields")
                blnErrors = True

            End If
            If txtState.Text = "" Then
                errP.SetError(txtState, "You must fill in required fields")
                blnErrors = True
            End If
            If txtZip.Text = "" Then
                errP.SetError(txtZip, "You must fill in required fields")
                blnErrors = True
            End If
        End If


        If blnErrors Then
            Exit Sub
        End If

        strResult = "Order Summary" & vbCrLf
        strResult &= "You selected the following:" & vbCrLf
        strResult &= strBeef & vbCrLf
        strResult &= "Quantity: " & qntDropdown.SelectedItem.ToString & " lbs" & vbCrLf


        If arrChk(1).Checked Then
            strResult &= arrChk(1).Text & vbCrLf
            Total += SEASONING_PRICE
            Console.WriteLine(Total)

        End If

        If arrChk(0).Checked Then
            strResult &= arrChk(0).Text & vbCrLf
        End If

        Total += Total * TAX_PERCENT



        strResult &= "Total: " & Total

        summary = New frmSummary
        summary.lblSummary.Text = strResult
        summary.ShowDialog()
        btnClear.PerformClick()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer

        For i = 0 To radBeef.Length - 1
            If radBeef(i).Checked Then
                radBeef(i).Checked = False
            End If
        Next
        arrChk(0).Checked = False
        arrChk(1).Checked = False

        qntDropdown.SelectedIndex = -1

        txtName.Clear()
        txtCity.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtState.Clear()
        txtZip.Clear()



        errP.Clear()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
