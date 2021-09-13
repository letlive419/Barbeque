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
        Me.components = New System.ComponentModel.Container()
        Me.radSirloin = New System.Windows.Forms.RadioButton()
        Me.radRibeye = New System.Windows.Forms.RadioButton()
        Me.radTenderloin = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.qntDropdown = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkSeasoning = New System.Windows.Forms.CheckBox()
        Me.chkShipping = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtZip = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'radSirloin
        '
        Me.radSirloin.AutoSize = True
        Me.radSirloin.Location = New System.Drawing.Point(9, 30)
        Me.radSirloin.Name = "radSirloin"
        Me.radSirloin.Size = New System.Drawing.Size(125, 17)
        Me.radSirloin.TabIndex = 0
        Me.radSirloin.TabStop = True
        Me.radSirloin.Text = "Top Sirloin: $13.25 lb"
        Me.radSirloin.UseVisualStyleBackColor = True
        '
        'radRibeye
        '
        Me.radRibeye.AutoSize = True
        Me.radRibeye.Location = New System.Drawing.Point(9, 53)
        Me.radRibeye.Name = "radRibeye"
        Me.radRibeye.Size = New System.Drawing.Size(140, 17)
        Me.radRibeye.TabIndex = 1
        Me.radRibeye.TabStop = True
        Me.radRibeye.Text = "Rib eye steak: $18.00 lb"
        Me.radRibeye.UseVisualStyleBackColor = True
        '
        'radTenderloin
        '
        Me.radTenderloin.AutoSize = True
        Me.radTenderloin.Location = New System.Drawing.Point(9, 76)
        Me.radTenderloin.Name = "radTenderloin"
        Me.radTenderloin.Size = New System.Drawing.Size(125, 17)
        Me.radTenderloin.TabIndex = 2
        Me.radTenderloin.TabStop = True
        Me.radTenderloin.Text = "Tenderloin: $19.95 lb"
        Me.radTenderloin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(763, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SouthWest Barbeque"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.qntDropdown)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.radTenderloin)
        Me.GroupBox1.Controls.Add(Me.radRibeye)
        Me.GroupBox1.Controls.Add(Me.radSirloin)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 125)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choice of beef"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "lbs"
        '
        'qntDropdown
        '
        Me.qntDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.qntDropdown.FormattingEnabled = True
        Me.qntDropdown.Items.AddRange(New Object() {"5", "10", "15", "20"})
        Me.qntDropdown.Location = New System.Drawing.Point(186, 89)
        Me.qntDropdown.Name = "qntDropdown"
        Me.qntDropdown.Size = New System.Drawing.Size(43, 21)
        Me.qntDropdown.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quantity:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkSeasoning)
        Me.GroupBox2.Controls.Add(Me.chkShipping)
        Me.GroupBox2.Location = New System.Drawing.Point(337, 309)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 86)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional Services"
        '
        'chkSeasoning
        '
        Me.chkSeasoning.AutoSize = True
        Me.chkSeasoning.Location = New System.Drawing.Point(6, 54)
        Me.chkSeasoning.Name = "chkSeasoning"
        Me.chkSeasoning.Size = New System.Drawing.Size(149, 17)
        Me.chkSeasoning.TabIndex = 1
        Me.chkSeasoning.Text = "Seasoning: $4.50 per item"
        Me.chkSeasoning.UseVisualStyleBackColor = True
        '
        'chkShipping
        '
        Me.chkShipping.AutoSize = True
        Me.chkShipping.Location = New System.Drawing.Point(6, 31)
        Me.chkShipping.Name = "chkShipping"
        Me.chkShipping.Size = New System.Drawing.Size(176, 17)
        Me.chkShipping.TabIndex = 0
        Me.chkShipping.Text = "Shipping: One flat fee of $18.00"
        Me.chkShipping.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(400, 599)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(400, 478)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(92, 33)
        Me.btnOrder.TabIndex = 7
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SouthWest_Barbeque.My.Resources.Resources.doggy_635408_960_720
        Me.PictureBox1.Location = New System.Drawing.Point(223, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(445, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(400, 538)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 32)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(180, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Zip"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(180, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "PhoneNumber"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 43)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(108, 20)
        Me.txtName.TabIndex = 16
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(183, 43)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(147, 20)
        Me.txtAddress.TabIndex = 17
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(18, 97)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(105, 20)
        Me.txtCity.TabIndex = 18
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(183, 97)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(147, 20)
        Me.txtState.TabIndex = 19
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPhone)
        Me.GroupBox3.Controls.Add(Me.txtZip)
        Me.GroupBox3.Controls.Add(Me.txtState)
        Me.GroupBox3.Controls.Add(Me.txtCity)
        Me.GroupBox3.Controls.Add(Me.txtAddress)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(564, 290)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 202)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Shipping Information"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(183, 158)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(147, 20)
        Me.txtPhone.TabIndex = 21
        Me.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(15, 159)
        Me.txtZip.Mask = "00000-9999"
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(108, 20)
        Me.txtZip.TabIndex = 20
        Me.txtZip.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1022, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "SouthWestBarbeque"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radSirloin As RadioButton
    Friend WithEvents radRibeye As RadioButton
    Friend WithEvents radTenderloin As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents qntDropdown As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkSeasoning As CheckBox
    Friend WithEvents chkShipping As CheckBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtZip As MaskedTextBox
End Class
