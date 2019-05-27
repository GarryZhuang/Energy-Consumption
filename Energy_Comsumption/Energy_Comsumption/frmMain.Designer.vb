<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.lblEnergy = New System.Windows.Forms.Label()
        Me.lblActualUsage = New System.Windows.Forms.Label()
        Me.lblMessages = New System.Windows.Forms.Label()
        Me.btnCheckUsage = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnProduceBill = New System.Windows.Forms.Button()
        Me.rtbMessage = New System.Windows.Forms.RichTextBox()
        Me.txtTotalUsers = New System.Windows.Forms.TextBox()
        Me.rbxElectHotWater = New System.Windows.Forms.RadioButton()
        Me.rbxGasHotWater = New System.Windows.Forms.RadioButton()
        Me.txtActualUsage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSupply = New System.Windows.Forms.TextBox()
        Me.txtUsage = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(137, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Energy Consumption"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsers.ForeColor = System.Drawing.Color.White
        Me.lblUsers.Location = New System.Drawing.Point(28, 99)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(172, 19)
        Me.lblUsers.TabIndex = 1
        Me.lblUsers.Text = "Total Number of Users:"
        Me.lblUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEnergy
        '
        Me.lblEnergy.AutoSize = True
        Me.lblEnergy.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnergy.ForeColor = System.Drawing.Color.White
        Me.lblEnergy.Location = New System.Drawing.Point(136, 138)
        Me.lblEnergy.Name = "lblEnergy"
        Me.lblEnergy.Size = New System.Drawing.Size(64, 19)
        Me.lblEnergy.TabIndex = 2
        Me.lblEnergy.Text = "Energy:"
        Me.lblEnergy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblActualUsage
        '
        Me.lblActualUsage.AutoSize = True
        Me.lblActualUsage.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualUsage.ForeColor = System.Drawing.Color.White
        Me.lblActualUsage.Location = New System.Drawing.Point(93, 175)
        Me.lblActualUsage.Name = "lblActualUsage"
        Me.lblActualUsage.Size = New System.Drawing.Size(107, 19)
        Me.lblActualUsage.TabIndex = 3
        Me.lblActualUsage.Text = "Actual Usage:"
        Me.lblActualUsage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMessages
        '
        Me.lblMessages.AutoSize = True
        Me.lblMessages.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessages.ForeColor = System.Drawing.Color.White
        Me.lblMessages.Location = New System.Drawing.Point(123, 220)
        Me.lblMessages.Name = "lblMessages"
        Me.lblMessages.Size = New System.Drawing.Size(77, 19)
        Me.lblMessages.TabIndex = 4
        Me.lblMessages.Text = "Message:"
        Me.lblMessages.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCheckUsage
        '
        Me.btnCheckUsage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCheckUsage.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckUsage.Location = New System.Drawing.Point(206, 322)
        Me.btnCheckUsage.Name = "btnCheckUsage"
        Me.btnCheckUsage.Size = New System.Drawing.Size(157, 38)
        Me.btnCheckUsage.TabIndex = 5
        Me.btnCheckUsage.Text = "Check Usage"
        Me.btnCheckUsage.UseVisualStyleBackColor = False
        '
        'btnClearForm
        '
        Me.btnClearForm.BackColor = System.Drawing.Color.LightCoral
        Me.btnClearForm.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.Location = New System.Drawing.Point(463, 322)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(104, 38)
        Me.btnClearForm.TabIndex = 6
        Me.btnClearForm.Text = "Clear"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'btnProduceBill
        '
        Me.btnProduceBill.BackColor = System.Drawing.Color.LightGreen
        Me.btnProduceBill.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduceBill.Location = New System.Drawing.Point(206, 366)
        Me.btnProduceBill.Name = "btnProduceBill"
        Me.btnProduceBill.Size = New System.Drawing.Size(361, 38)
        Me.btnProduceBill.TabIndex = 7
        Me.btnProduceBill.Text = "Produce Bill"
        Me.btnProduceBill.UseVisualStyleBackColor = False
        '
        'rtbMessage
        '
        Me.rtbMessage.Location = New System.Drawing.Point(206, 220)
        Me.rtbMessage.Name = "rtbMessage"
        Me.rtbMessage.ReadOnly = True
        Me.rtbMessage.Size = New System.Drawing.Size(361, 96)
        Me.rtbMessage.TabIndex = 8
        Me.rtbMessage.Text = ""
        '
        'txtTotalUsers
        '
        Me.txtTotalUsers.Location = New System.Drawing.Point(206, 98)
        Me.txtTotalUsers.Name = "txtTotalUsers"
        Me.txtTotalUsers.Size = New System.Drawing.Size(60, 20)
        Me.txtTotalUsers.TabIndex = 9
        '
        'rbxElectHotWater
        '
        Me.rbxElectHotWater.AutoSize = True
        Me.rbxElectHotWater.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbxElectHotWater.ForeColor = System.Drawing.Color.White
        Me.rbxElectHotWater.Location = New System.Drawing.Point(206, 136)
        Me.rbxElectHotWater.Name = "rbxElectHotWater"
        Me.rbxElectHotWater.Size = New System.Drawing.Size(158, 23)
        Me.rbxElectHotWater.TabIndex = 10
        Me.rbxElectHotWater.TabStop = True
        Me.rbxElectHotWater.Text = "Electric Hot Water"
        Me.rbxElectHotWater.UseVisualStyleBackColor = True
        '
        'rbxGasHotWater
        '
        Me.rbxGasHotWater.AutoSize = True
        Me.rbxGasHotWater.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbxGasHotWater.ForeColor = System.Drawing.Color.White
        Me.rbxGasHotWater.Location = New System.Drawing.Point(370, 136)
        Me.rbxGasHotWater.Name = "rbxGasHotWater"
        Me.rbxGasHotWater.Size = New System.Drawing.Size(129, 23)
        Me.rbxGasHotWater.TabIndex = 11
        Me.rbxGasHotWater.TabStop = True
        Me.rbxGasHotWater.Text = "Gas Hot Water"
        Me.rbxGasHotWater.UseVisualStyleBackColor = True
        '
        'txtActualUsage
        '
        Me.txtActualUsage.Location = New System.Drawing.Point(206, 177)
        Me.txtActualUsage.Name = "txtActualUsage"
        Me.txtActualUsage.Size = New System.Drawing.Size(117, 20)
        Me.txtActualUsage.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(327, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "kwH"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtUsage)
        Me.GroupBox1.Controls.Add(Me.txtSupply)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 410)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 252)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Bill:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supply Charge:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total:"
        '
        'txtSupply
        '
        Me.txtSupply.Location = New System.Drawing.Point(158, 59)
        Me.txtSupply.Name = "txtSupply"
        Me.txtSupply.Size = New System.Drawing.Size(265, 30)
        Me.txtSupply.TabIndex = 3
        '
        'txtUsage
        '
        Me.txtUsage.Location = New System.Drawing.Point(158, 112)
        Me.txtUsage.Name = "txtUsage"
        Me.txtUsage.Size = New System.Drawing.Size(265, 30)
        Me.txtUsage.TabIndex = 4
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(158, 159)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(265, 30)
        Me.txtTotal.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(609, 674)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtActualUsage)
        Me.Controls.Add(Me.rbxGasHotWater)
        Me.Controls.Add(Me.rbxElectHotWater)
        Me.Controls.Add(Me.txtTotalUsers)
        Me.Controls.Add(Me.rtbMessage)
        Me.Controls.Add(Me.btnProduceBill)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCheckUsage)
        Me.Controls.Add(Me.lblMessages)
        Me.Controls.Add(Me.lblActualUsage)
        Me.Controls.Add(Me.lblEnergy)
        Me.Controls.Add(Me.lblUsers)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Energy Consumption"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsers As Label
    Friend WithEvents lblEnergy As Label
    Friend WithEvents lblActualUsage As Label
    Friend WithEvents lblMessages As Label
    Friend WithEvents btnCheckUsage As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnProduceBill As Button
    Friend WithEvents rtbMessage As RichTextBox
    Friend WithEvents txtTotalUsers As TextBox
    Friend WithEvents rbxElectHotWater As RadioButton
    Friend WithEvents rbxGasHotWater As RadioButton
    Friend WithEvents txtActualUsage As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtUsage As TextBox
    Friend WithEvents txtSupply As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
