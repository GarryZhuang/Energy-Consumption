Public Class frmMain

    'This is the sub used to calculate the average
    Public Sub CalculateUsage(ByVal numberOfUsers As Integer, ByVal energyType As EnergyType, ByVal Usage As String)
        Try 'We will use try just in case if a user try's to enter invalid data





            'Average Data(s):

            'ELECTRICITY
            Dim averageElectricity_1 As String = "13.1"
            Dim averageElectricity_2 As String = "16.3"
            Dim averageElectricity_3 As String = "18.3"
            Dim averageElectricity_4 As String = "21"
            Dim averageElectricity_5 As String = "23.1"
            Dim averageElectricity_6 As String = "25.3"

            'GAS
            Dim averageGas_1 As String = "10.6"
            Dim averageGas_2 As String = "13.9"
            Dim averageGas_3 As String = "15.8"
            Dim averageGas_4 As String = "18.6"
            Dim averageGas_5 As String = "20.6"
            Dim averageGas_6 As String = "22.8"

            If energyType = 1 Then 'Electricity
                Select Case numberOfUsers
                'We will now select the amount of users
                    Case 1
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageElectricity_1
                        msgController(calculateUsageRate)
                    Case 2
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageElectricity_2
                        msgController(calculateUsageRate)
                    Case 3
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageElectricity_3
                        msgController(calculateUsageRate)
                    Case 4
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageElectricity_4
                        msgController(calculateUsageRate)
                    Case 5
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageElectricity_5
                        msgController(calculateUsageRate)
                    Case 6
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageElectricity_6
                        msgController(calculateUsageRate)
                    Case Else
                        'Error message if out of data range
                        rtbMessage.Text = "Sorry, The data you have provided is out of our data range. Please re-enter valid data or contact your energy company for more information."
                End Select
            End If

            If energyType = 2 Then 'Gas
                Select Case numberOfUsers
                'We will now select the amount of users
                    Case 1
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageGas_1
                        msgController(calculateUsageRate)
                    Case 2
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageGas_2
                        msgController(calculateUsageRate)
                    Case 3
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageGas_3
                        msgController(calculateUsageRate)
                    Case 4
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageGas_4
                        msgController(calculateUsageRate)
                    Case 5
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageGas_5
                        msgController(calculateUsageRate)
                    Case 6
                        'We will caluclate the standardised score 
                        Dim calculateUsageRate As String = Usage - averageGas_6
                        msgController(calculateUsageRate)
                    Case Else
                        'Error message if out of data range
                        rtbMessage.Text = "Sorry, The data you have provided is out of our data range. Please re-enter valid data or contact your energy company for more information."
                End Select
            End If

            'In the event of a critical error
        Catch ex As Exception
            MsgBox("Please check your entries and try again.")
            btnClearForm.PerformClick()
        End Try
    End Sub

    'This is the message controller, this determin's if the calculated usage rates
    'are above average or below average.
    Public Sub msgController(ByVal calculateUsageRate As String)
        'Below Average
        If calculateUsageRate < 1 Then
            rtbMessage.Text = "Congrats, you are in the average consumption of the energy!"
        End If

        'Above Average Calculations
        If calculateUsageRate >= 1 Then

            'Above Average
            If calculateUsageRate < 2 Then
                rtbMessage.Text = "Oh No! You should increase insulation around your house. You are slightly above average!"
            End If

            'Over Average
            If calculateUsageRate >= 2 Then
                rtbMessage.Text = "Oh No! You should increase insulation around your house AND maybe turn off that extra fridge! You are highly above average!"
            End If
        End If
    End Sub

    'When the check usage button is clicked
    Private Sub btnCheckUsage_Click(sender As Object, e As EventArgs) Handles btnCheckUsage.Click
        Try 'We will use try just in case if a user try's to enter invalid data



            'We will check if its hot water or gas 

            'Hot Water
            If rbxElectHotWater.Checked = True Then
                'We will now exercute the sub
                CalculateUsage(txtTotalUsers.Text, 1, txtActualUsage.Text)
            End If

            'Gas
            If rbxGasHotWater.Checked = True Then
                'We will now exercute the sub
                CalculateUsage(txtTotalUsers.Text, 2, txtActualUsage.Text)
            End If




            'In the event of a critical error
        Catch ex As Exception
            MsgBox("Please check your entries and try again.")
            btnClearForm.PerformClick()
        End Try
    End Sub

    'We will be defining the Energy Type that is used in this project as a Enum, therefore in future when required,
    'More types of Energy Types can be added.
    Public Enum EnergyType
        'Electricity:
        ENERGY_ELECTRICITY = 1

        'Gas:
        ENERGY_GAS = 2
    End Enum

    'This will clear the form of all previous data
    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        'We will clear the message boxes
        txtTotalUsers.Clear()
        txtActualUsage.Clear()
        rtbMessage.Clear()
    End Sub

    'Produce The Bill
    Private Sub btnProduceBill_Click(sender As Object, e As EventArgs) Handles btnProduceBill.Click
        'Lets do some math here ;)
        Dim usageCharge As String
        If txtActualUsage.Text * 91 <= 1000 Then
            'Calculate the usageCharge
            usageCharge = 22.066 * txtActualUsage.Text.ToString * 91 / 100
        Else
            'Calculate the usageCharge
            usageCharge = 22.594 * txtActualUsage.Text.ToString * 91 / 100
        End If
        'Calculate the totalCharge
        Dim totalCharge As String
        totalCharge = usageCharge + 86.493 * 91 / 100

        'Calculate the supplyCharge
        Dim supplyCharge As String
        supplyCharge = 86.493 * 91 / 100

        'Return the objects
        txtSupply.Text = supplyCharge
        txtUsage.Text = usageCharge
        txtTotal.Text = totalCharge
    End Sub
End Class
'Copyright Garry Zhuang 2019 | Software Development 3 & 4 | Unit 3 Outcome 1 Task 2
