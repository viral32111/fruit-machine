Public Class fruitMachine
	' The three boolean variables for each hold button indicating their state.
	' This also meets a design requirement saying I need 3 reels and 3 hold buttons.
	Dim holdOne As Boolean = False
	Dim holdTwo As Boolean = False
	Dim holdThree As Boolean = False

	' Credit and bank balance integer variables
	Dim credit As Integer = 0
	Dim bank As Integer = 10

	' Bitmap array to hold all 8 fruit images.
	Dim fruit = New Bitmap() {
		My.Resources.Apple,
		My.Resources.Orange,
		My.Resources.Watermelon,
		My.Resources.Banana,
		My.Resources.Carrot,
		My.Resources.Strawberry,
		My.Resources.Grapes,
		My.Resources.Pear
	}

	' Wait function that takes an integer value as a parameter.
	'This Function just() creates a timer In the background that does Nothing until the timespan is met.
	'(It just delays code execution when called)
	Private Sub wait(ByVal interval As Integer)
		Dim stopwatch As New Stopwatch ' Create a new variable with the stopwatch class.

		stopwatch.Start() ' Start the stopwatch.

		Do While stopwatch.ElapsedMilliseconds < interval ' Keep going until elapsed time is greater than the time we set.
			Application.DoEvents() ' Keeps calling events so the program doesnt go into a "Not responding" state.
		Loop

		stopwatch.Stop() ' Stop that stopwatch/
	End Sub

	' Event handler for when the spin button is pressed. This is the spin code.
	Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
		If (holdOne And holdTwo And holdThree) Then ' Check if all the reel buttons are held down.
			MsgBox("Cannot spin while all reels are held.") ' If so, display a messagebox.
			Return ' Stop running any code after this.
		End If

		' Split credit label string and substring it then select the second value in the array (Indexing starts at 0) then convert to datatype double.
		Dim credit As Double = lblCredit.Text.Split("£")(1)
		If (credit >= 0.2) Then ' Is the credit greater than 0.20?
			Dim split As String() = lblCredit.Text.Split("£") ' Split the entire stirng this time into a string array.
			Dim newCredit = split(1) - 0.2 ' Subtract the game fee from their current credit balance.
			lblCredit.Text = "Credit: £" + newCredit.ToString() ' Update the label with their new credit balance.
		Else
			MsgBox("You don't have enough credit! Each spin is £0.20.") ' Tell them if they don't have enough to play.
			Return ' Stop running any code after this.
		End If

		' Disable all the buttons so they don't touch anything while the reels spin.
		btnSpin.Enabled = False
		btnHoldOne.Enabled = False
		btnHoldTwo.Enabled = False
		btnHoldThree.Enabled = False
		' These 3 buttons below meet the design requirement saying I need a way to enter different coins.
		btn10p.Enabled = False
		btn50p.Enabled = False
		btn1Pound.Enabled = False

		' Create a new random class variable and 3 integer variables that are empty.
		Dim rand As Random = New Random()
		Dim randOne As Integer
		Dim randTwo As Integer
		Dim randThree As Integer

		' Iterate 0 to 100. This will be for animations on the reels
		For num As Integer = 0 To 100
			If (holdOne = False) Then ' Is the first reel not being held?
				randOne = rand.Next(0, 7) ' New number between 0 and 7 (Its actually 1 and 8 but .Next starts at 0)
				picOne.BackgroundImage = fruit(randOne) ' Get the image that corrisponds to the random integer index in the array.
			End If

			If (holdTwo = False) Then ' Is the second reel not being held?
				randTwo = rand.Next(0, 7) ' New number between 0 and 7 (Its actually 1 and 8 but .Next starts at 0)
				picTwo.BackgroundImage = fruit(randTwo) ' Get the image that corrisponds to the random integer index in the array.
			End If

			If (holdThree = False) Then ' Is the third reel not being held?
				randThree = rand.Next(0, 7) ' New number between 0 and 7 (Its actually 1 and 8 but .Next starts at 0)
				picThree.BackgroundImage = fruit(randThree) ' Get the image that corrisponds to the random integer index in the array.
			End If

			wait(num / 1.1) ' Delay the for loop, this adds the animation and makes it look like it slows down towards the end since it divides the iterating number by 1.1
		Next

		' Do all numbers match?
		If (randOne = randTwo And randThree = randTwo) Then
			MsgBox("You've won £1") ' Tell them they have won. This also meets the requirement saying they need to be shown they won.

			' Add money to their bank balance.
			Dim bank As Double = lblBank.Text.Split("£")(1)
			bank += 1
			lblBank.Text = "Bank: £" + bank.ToString()
		End If

		' Renable all the buttons so they can play again.
		btnSpin.Enabled = True
		btnHoldOne.Enabled = True
		btnHoldTwo.Enabled = True
		btnHoldThree.Enabled = True
		btn10p.Enabled = True
		btn50p.Enabled = True
		btn1Pound.Enabled = True
	End Sub

	' Event handler for when the third hold button is pressed. This holds the third reel.
	Private Sub btnHoldThree_Click(sender As Object, e As EventArgs) Handles btnHoldThree.Click
		If (holdThree) Then ' Is it pressed?
			btnHoldThree.BackColor = Color.LightCyan ' Update back color so it is no longer visually pressed.
			holdThree = False ' Set it being pressed to no.
		Else
			btnHoldThree.BackColor = Color.LightCoral ' Update back color so it looks like its pressed.
			holdThree = True ' Set it being pressed to yes.
		End If
	End Sub

	' Event handler for when the second hold button is pressed. This holds the second reel.
	Private Sub btnHoldTwo_Click(sender As Object, e As EventArgs) Handles btnHoldTwo.Click
		If (holdTwo) Then ' Is it pressed?
			btnHoldTwo.BackColor = Color.LightCyan ' Update back color so it is no longer visually pressed.
			holdTwo = False ' Set it being pressed to no.
		Else
			btnHoldTwo.BackColor = Color.LightCoral ' Update back color so it looks like its pressed.
			holdTwo = True ' Set it being pressed to yes.
		End If
	End Sub

	' Event handler for when the first hold button is pressed. This holds the first reel.
	Private Sub btnHoldOne_Click(sender As Object, e As EventArgs) Handles btnHoldOne.Click
		If (holdOne) Then ' Is it pressed?
			btnHoldOne.BackColor = Color.LightCyan ' Update back color so it is no longer visually pressed.
			holdOne = False ' Set it being pressed to no.
		Else
			btnHoldOne.BackColor = Color.LightCoral ' Update back color so it looks like its pressed.
			holdOne = True ' Set it being pressed to yes.
		End If
	End Sub

	' Event handler for when the close button is pressed. This closes the application.
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Close() ' Close the entire application safley.
	End Sub

	' Event hander for when the add £1 button is pressed. This takes money from the bank and puts it in credit.
	Private Sub btn1Pound_Click(sender As Object, e As EventArgs) Handles btn1Pound.Click
		Dim bank As Double = lblBank.Text.Split("£")(1) ' Split string and select second value
		If (bank >= 1) Then ' Is there balance greater than £1?
			' Update their credit with £1 added and subtracted from bank
			Dim split As String() = lblCredit.Text.Split("£")
			Dim credit = split(1) + 1
			lblCredit.Text = "Credit: £" + credit.ToString() ' This meets the requirement saying I need a credit field.
			bank -= 1
			lblBank.Text = "Bank: £" + bank.ToString() ' This meets the requirement saying I need a bank field
		Else
			MsgBox("You don't have enough funds!") ' Tell them they don't have enough funds in the bank
		End If
	End Sub

	' Event hander for when the add 10p button is pressed. This takes money from the bank and puts it in credit.
	Private Sub btn10p_Click(sender As Object, e As EventArgs) Handles btn10p.Click
		Dim bank As Double = lblBank.Text.Split("£")(1) ' Split string and select second value
		If (bank >= 0.1) Then ' Is there balance greater than £0.10?
			' Update their credit with £0.10 added and subtracted from bank
			Dim split As String() = lblCredit.Text.Split("£")
			Dim credit = split(1) + 0.1
			lblCredit.Text = "Credit: £" + credit.ToString()
			bank -= 0.1
			lblBank.Text = "Bank: £" + bank.ToString()
		Else
			MsgBox("You don't have enough funds!") ' Tell them they don't have enough funds in the bank
		End If
	End Sub

	' Event hander for when the add 50p button is pressed. This takes money from the bank and puts it in credit.
	Private Sub btn50p_Click(sender As Object, e As EventArgs) Handles btn50p.Click
		Dim bank As Double = lblBank.Text.Split("£")(1) ' Split string and select second value
		If (bank >= 0.5) Then ' Is there balance greater than £0.50?
			' Update their credit with £0.50 added and subtracted from bank
			Dim split As String() = lblCredit.Text.Split("£")
			Dim credit = split(1) + 0.5
			lblCredit.Text = "Credit: £" + credit.ToString()
			bank -= 0.5
			lblBank.Text = "Bank: £" + bank.ToString()
		Else
			MsgBox("You don't have enough funds!") ' Tell them they don't have enough funds in the bank
		End If
	End Sub
End Class
