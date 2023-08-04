<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fruitMachine
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fruitMachine))
		Me.btnSpin = New System.Windows.Forms.Button()
		Me.lblBank = New System.Windows.Forms.Label()
		Me.lblCredit = New System.Windows.Forms.Label()
		Me.btnHoldOne = New System.Windows.Forms.Button()
		Me.btnHoldTwo = New System.Windows.Forms.Button()
		Me.btnHoldThree = New System.Windows.Forms.Button()
		Me.btn10p = New System.Windows.Forms.Button()
		Me.btn50p = New System.Windows.Forms.Button()
		Me.btn1Pound = New System.Windows.Forms.Button()
		Me.pnlTop = New System.Windows.Forms.Panel()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.picThree = New System.Windows.Forms.PictureBox()
		Me.picTwo = New System.Windows.Forms.PictureBox()
		Me.picOne = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pnlTop.SuspendLayout()
		CType(Me.picThree, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnSpin
		'
		Me.btnSpin.BackColor = System.Drawing.Color.LightCyan
		Me.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnSpin.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSpin.Location = New System.Drawing.Point(15, 328)
		Me.btnSpin.Name = "btnSpin"
		Me.btnSpin.Size = New System.Drawing.Size(298, 40)
		Me.btnSpin.TabIndex = 3
		Me.btnSpin.TabStop = False
		Me.btnSpin.Text = "Spin!"
		Me.btnSpin.UseVisualStyleBackColor = False
		'
		'lblBank
		'
		Me.lblBank.AutoSize = True
		Me.lblBank.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBank.Location = New System.Drawing.Point(25, 234)
		Me.lblBank.Name = "lblBank"
		Me.lblBank.Size = New System.Drawing.Size(85, 23)
		Me.lblBank.TabIndex = 4
		Me.lblBank.Text = "Bank: £10"
		'
		'lblCredit
		'
		Me.lblCredit.AutoSize = True
		Me.lblCredit.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCredit.Location = New System.Drawing.Point(25, 276)
		Me.lblCredit.Name = "lblCredit"
		Me.lblCredit.Size = New System.Drawing.Size(90, 23)
		Me.lblCredit.TabIndex = 5
		Me.lblCredit.Text = "Credit: £0"
		'
		'btnHoldOne
		'
		Me.btnHoldOne.BackColor = System.Drawing.Color.LightCyan
		Me.btnHoldOne.Enabled = False
		Me.btnHoldOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnHoldOne.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnHoldOne.Location = New System.Drawing.Point(15, 180)
		Me.btnHoldOne.Name = "btnHoldOne"
		Me.btnHoldOne.Size = New System.Drawing.Size(87, 29)
		Me.btnHoldOne.TabIndex = 6
		Me.btnHoldOne.TabStop = False
		Me.btnHoldOne.Text = "Hold"
		Me.btnHoldOne.UseVisualStyleBackColor = False
		'
		'btnHoldTwo
		'
		Me.btnHoldTwo.BackColor = System.Drawing.Color.LightCyan
		Me.btnHoldTwo.Enabled = False
		Me.btnHoldTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnHoldTwo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnHoldTwo.Location = New System.Drawing.Point(121, 180)
		Me.btnHoldTwo.Name = "btnHoldTwo"
		Me.btnHoldTwo.Size = New System.Drawing.Size(87, 29)
		Me.btnHoldTwo.TabIndex = 7
		Me.btnHoldTwo.TabStop = False
		Me.btnHoldTwo.Text = "Hold"
		Me.btnHoldTwo.UseVisualStyleBackColor = False
		'
		'btnHoldThree
		'
		Me.btnHoldThree.BackColor = System.Drawing.Color.LightCyan
		Me.btnHoldThree.Enabled = False
		Me.btnHoldThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnHoldThree.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnHoldThree.Location = New System.Drawing.Point(226, 180)
		Me.btnHoldThree.Name = "btnHoldThree"
		Me.btnHoldThree.Size = New System.Drawing.Size(87, 29)
		Me.btnHoldThree.TabIndex = 8
		Me.btnHoldThree.TabStop = False
		Me.btnHoldThree.Text = "Hold"
		Me.btnHoldThree.UseVisualStyleBackColor = False
		'
		'btn10p
		'
		Me.btn10p.BackColor = System.Drawing.Color.LightCyan
		Me.btn10p.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btn10p.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn10p.Location = New System.Drawing.Point(240, 218)
		Me.btn10p.Name = "btn10p"
		Me.btn10p.Size = New System.Drawing.Size(64, 29)
		Me.btn10p.TabIndex = 9
		Me.btn10p.TabStop = False
		Me.btn10p.Text = "10p"
		Me.btn10p.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btn10p.UseVisualStyleBackColor = False
		'
		'btn50p
		'
		Me.btn50p.BackColor = System.Drawing.Color.LightCyan
		Me.btn50p.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btn50p.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn50p.Location = New System.Drawing.Point(240, 253)
		Me.btn50p.Name = "btn50p"
		Me.btn50p.Size = New System.Drawing.Size(64, 29)
		Me.btn50p.TabIndex = 12
		Me.btn50p.TabStop = False
		Me.btn50p.Text = "50p"
		Me.btn50p.UseVisualStyleBackColor = False
		'
		'btn1Pound
		'
		Me.btn1Pound.BackColor = System.Drawing.Color.LightCyan
		Me.btn1Pound.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btn1Pound.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn1Pound.Location = New System.Drawing.Point(240, 287)
		Me.btn1Pound.Name = "btn1Pound"
		Me.btn1Pound.Size = New System.Drawing.Size(64, 29)
		Me.btn1Pound.TabIndex = 13
		Me.btn1Pound.TabStop = False
		Me.btn1Pound.Text = "£1"
		Me.btn1Pound.UseVisualStyleBackColor = False
		'
		'pnlTop
		'
		Me.pnlTop.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.pnlTop.Controls.Add(Me.btnClose)
		Me.pnlTop.Location = New System.Drawing.Point(0, 0)
		Me.pnlTop.Name = "pnlTop"
		Me.pnlTop.Size = New System.Drawing.Size(324, 24)
		Me.pnlTop.TabIndex = 14
		'
		'btnClose
		'
		Me.btnClose.BackColor = System.Drawing.Color.Red
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnClose.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.ForeColor = System.Drawing.Color.White
		Me.btnClose.Location = New System.Drawing.Point(288, -1)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(30, 27)
		Me.btnClose.TabIndex = 15
		Me.btnClose.TabStop = False
		Me.btnClose.Text = "X"
		Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'picThree
		'
		Me.picThree.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.picThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.picThree.Location = New System.Drawing.Point(226, 83)
		Me.picThree.Name = "picThree"
		Me.picThree.Size = New System.Drawing.Size(86, 86)
		Me.picThree.TabIndex = 17
		Me.picThree.TabStop = False
		'
		'picTwo
		'
		Me.picTwo.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.picTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.picTwo.Location = New System.Drawing.Point(122, 83)
		Me.picTwo.Name = "picTwo"
		Me.picTwo.Size = New System.Drawing.Size(86, 86)
		Me.picTwo.TabIndex = 16
		Me.picTwo.TabStop = False
		'
		'picOne
		'
		Me.picOne.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.picOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.picOne.Location = New System.Drawing.Point(16, 83)
		Me.picOne.Name = "picOne"
		Me.picOne.Size = New System.Drawing.Size(86, 86)
		Me.picOne.TabIndex = 15
		Me.picOne.TabStop = False
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(16, 31)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(296, 49)
		Me.Label1.TabIndex = 18
		Me.Label1.Text = "FRUIT MACHINE"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'fruitMachine
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(324, 380)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.picThree)
		Me.Controls.Add(Me.picTwo)
		Me.Controls.Add(Me.picOne)
		Me.Controls.Add(Me.pnlTop)
		Me.Controls.Add(Me.btn1Pound)
		Me.Controls.Add(Me.btn50p)
		Me.Controls.Add(Me.btn10p)
		Me.Controls.Add(Me.btnHoldThree)
		Me.Controls.Add(Me.btnHoldTwo)
		Me.Controls.Add(Me.btnHoldOne)
		Me.Controls.Add(Me.lblCredit)
		Me.Controls.Add(Me.lblBank)
		Me.Controls.Add(Me.btnSpin)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "fruitMachine"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Fruit Machine"
		Me.pnlTop.ResumeLayout(False)
		CType(Me.picThree, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnSpin As Button
	Friend WithEvents lblBank As Label
	Friend WithEvents lblCredit As Label
	Friend WithEvents btnHoldOne As Button
	Friend WithEvents btnHoldTwo As Button
	Friend WithEvents btnHoldThree As Button
	Friend WithEvents btn10p As Button
	Friend WithEvents btn50p As Button
	Friend WithEvents btn1Pound As Button
	Friend WithEvents pnlTop As Panel
	Friend WithEvents btnClose As Button
	Friend WithEvents picOne As PictureBox
	Friend WithEvents picTwo As PictureBox
	Friend WithEvents picThree As PictureBox
	Friend WithEvents Label1 As Label
End Class
