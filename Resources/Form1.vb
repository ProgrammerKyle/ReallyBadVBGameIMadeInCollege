Public Class GameForm
    'All work for this project was done by me, Kyle Chaput, and any help I may have recieved was purely concecptual and did not invole writting code for me.
    Dim RoomNum As Integer = 0
    Dim Playerlife As Integer = 5
    Dim Monster1 As Boolean = True
    Dim Monster2 As Boolean = True
    Dim Monster3 As Boolean = True
    Dim Monster4 As Boolean = True
    Dim Monster5 As Boolean = True
    Dim Monster6 As Boolean = True
    Dim Boss As Integer = 2
    Dim Fire_princess As Boolean = False
    Dim Troll_princess As Boolean = False
    Dim Alien_princess As Boolean = False
    Dim Spider_princess As Boolean = False

    Private Sub GameForm_close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        StartForm.Show()

    End Sub

    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Fight_Button.Visible = False
        BossPicBox.Visible = False
        MonsterPicBox.Visible = False
        FirePicBox.Visible = False
        TrollPicBox.Visible = False
        AlienPicBox.Visible = False
        SpiderPicBox.Visible = False
        BookPictBox.Visible = False


        Down_Button.Visible = False
        Fight_Button.Visible = False
        Save_Button.Visible = False
        Next_Button.Visible = False

        PH.Text = Playerlife
        TextBox.Text = "Welcome to the Dungeon of Lonely Heroes!"






    End Sub

    Private Sub Up_Button_Click(sender As Object, e As EventArgs) Handles Up_Button.Click
        Select Case RoomNum
            Case 0
                RoomNum = 1
                Right_Button.Visible = False
                Left_Button.Visible = False
                Down_Button.Visible = True
                TextBox.Text = "You walk down the dank and dirty old hallway."

            Case 1
                RoomNum = 2
                Right_Button.Visible = True

            Case 2
                RoomNum = 3
                Right_Button.Visible = False

            Case 3
                RoomNum = 4
                Right_Button.Visible = True

            Case 4
                RoomNum = 5
                If Monster4 = True Then
                    MonsterPicBox.Visible = True
                    TextBox.Text = "A monster has appeared! Prepare yourself for armed combat!"
                    Up_Button.Visible = False
                    Down_Button.Visible = False
                    Left_Button.Visible = False
                    Right_Button.Visible = False
                    Fight_Button.Visible = True
                ElseIf Monster4 = False Then
                    Right_Button.Visible = False
                    Left_Button.Visible = True
                    Up_Button.Visible = False
                End If

            Case 6
                RoomNum = 7
                Up_Button.Visible = False
                Right_Button.Visible = True
                Left_Button.Visible = False
                Down_Button.Visible = True

            Case 9
                RoomNum = 10
                Down_Button.Visible = True
                Right_Button.Visible = False
                Left_Button.Visible = False
                Up_Button.Visible = False

            Case 12
                RoomNum = 13
                Right_Button.Visible = False
                Left_Button.Visible = False
                Down_Button.Visible = True

            Case 13
                RoomNum = 14
                Right_Button.Visible = True
                Left_Button.Visible = True

            Case 14
                RoomNum = 16
                Right_Button.Visible = True
                Left_Button.Visible = False
                Up_Button.Visible = False

            Case 17
                RoomNum = 20
                Right_Button.Visible = False
                Down_Button.Visible = True
                Up_Button.Visible = True
                Left_Button.Visible = True

            Case 20
                RoomNum = 21
                If Monster5 = True Then
                    MonsterPicBox.Visible = True
                    TextBox.Text = "A monster has appeared! Prepare yourself for armed combat!"
                    Right_Button.Visible = False
                    Left_Button.Visible = False
                    Up_Button.Visible = False
                    Down_Button.Visible = False
                    Fight_Button.Visible = True
                ElseIf Monster5 = False Then
                    Left_Button.Visible = False
                End If


            Case 21
                RoomNum = 22
                If Alien_princess = False Then
                    AlienPicBox.Visible = True
                    TextBox.Text = "I'm not sure if this is a princess...or even a girl. Oh well, might as well save her."
                    Up_Button.Visible = False
                    Down_Button.Visible = False
                    Save_Button.Visible = True
                ElseIf Alien_princess = True Then
                    Right_Button.Visible = True
                End If

            Case 22
                RoomNum = 35
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Right_Button.Visible = False

            Case 23
                RoomNum = 24
                Left_Button.Visible = False
                Down_Button.Visible = True

            Case 24
                RoomNum = 25
                If Monster3 = True Then
                    MonsterPicBox.Visible = True
                    TextBox.Text = "A monster has appeared! Prepare yourself for armed combat!"
                    Up_Button.Visible = False
                    Down_Button.Visible = False
                    Left_Button.Visible = False
                    Fight_Button.Visible = True
                ElseIf Monster3 = False Then
                    Up_Button.Visible = False
                    Left_Button.Visible = True
                End If

            Case 28
                RoomNum = 29
                Right_Button.Visible = False
                Down_Button.Visible = True
                Left_Button.Visible = True


            Case 29
                RoomNum = 31
                If Troll_princess = False Then
                    TextBox.Text = "You must save this horrible troll princess!"
                    TrollPicBox.Visible = True
                    Down_Button.Visible = False
                    Left_Button.Visible = False
                    Up_Button.Visible = False
                    Save_Button.Visible = True

                ElseIf Troll_princess = True Then
                    Left_Button.Visible = False
                    Up_Button.Visible = False
                End If

            Case 33
                RoomNum = 32
                Up_Button.Visible = False
                Down_Button.Visible = True
                Right_Button.Visible = True
                Left_Button.Visible = True

            Case 35
                RoomNum = 36
                Right_Button.Visible = True
                Up_Button.Visible = False

            Case 39
                RoomNum = 38
                Right_Button.Visible = False
                Up_Button.Visible = False
                Left_Button.Visible = True

            Case 40
                RoomNum = 39
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Left_Button.Visible = False
                Right_Button.Visible = True
                Down_Button.Visible = True

            Case 43
                RoomNum = 44
                Left_Button.Visible = False
                Right_Button.Visible = False
                Down_Button.Visible = True

            Case 44
                RoomNum = 45
                If Fire_princess = False Then
                    FirePicBox.Visible = True
                    TextBox.Text = "It's a princess made out of fire. You know what, I think she's got this one. No need to save her."
                    Down_Button.Visible = False
                    Up_Button.Visible = False
                    Save_Button.Visible = True
                ElseIf Fire_princess = True Then
                    Up_Button.Visible = True
                End If

            Case 47
                RoomNum = 48
                BossPicBox.Visible = True
                TextBox.Text = "The evil princess stealing beast has revealed itself, prepare for battle!"
                Left_Button.Visible = False
                Up_Button.Visible = False
                Fight_Button.Visible = True


            Case 48
                RoomNum = 49
                TextBox.Text = "You found the Holy Book of Princess Kissing!"
                Up_Button.Visible = False
                BookPictBox.Visible = True
                MessageBox.Show("YOU WIN! Now that you have found the Holy Book of Princess Kissing all those princess you saved will be all over you!")
                Me.Close()

        End Select
    End Sub

    Private Sub Right_Button_Click(sender As Object, e As EventArgs) Handles Right_Button.Click
        Select Case RoomNum
            Case 0
                TextBox.Text = "You walk down the dank and dirty old hallway."
                RoomNum = 23
                Right_Button.Visible = False
                Up_Button.Visible = True
                Left_Button.Visible = True

            Case 2
                RoomNum = 26
                Up_Button.Visible = False
                Down_Button.Visible = False
                Left_Button.Visible = True
                Right_Button.Visible = True

            Case 4
                RoomNum = 6
                If Monster2 = True Then
                    MonsterPicBox.Visible = True
                    TextBox.Text = "A monster has appeared! Prepare yourself for armed combat!"
                    Up_Button.Visible = False
                    Down_Button.Visible = False
                    Right_Button.Visible = False
                    Left_Button.Visible = False
                    Fight_Button.Visible = True
                ElseIf Monster2 = False Then
                    Right_Button.Visible = False
                    Down_Button.Visible = False
                    Left_Button.Visible = True
                    Up_Button.Visible = True
                End If

            Case 7
                RoomNum = 8
                Right_Button.Visible = True
                Left_Button.Visible = True
                Down_Button.Visible = False
                Up_Button.Visible = False

            Case 8
                RoomNum = 9
                Right_Button.Visible = True
                Left_Button.Visible = True
                Up_Button.Visible = True

            Case 9
                RoomNum = 11
                If Spider_princess = False Then
                    SpiderPicBox.Visible = True
                    TextBox.Text = "The giant spider princess is creeping along the walls. Yes, you have to save her."
                    Right_Button.Visible = False
                    Up_Button.Visible = False
                    Left_Button.Visible = False
                    Save_Button.Visible = True

                ElseIf Spider_princess = True Then
                    Right_Button.Visible = False
                    Up_Button.Visible = False
                    Left_Button.Visible = True
                End If

            Case 12
                RoomNum = 5
                Up_Button.Visible = False
                Right_Button.Visible = False
                Down_Button.Visible = True

            Case 14
                RoomNum = 17
                Down_Button.Visible = False

            Case 15
                RoomNum = 14
                Up_Button.Visible = True
                Down_Button.Visible = True

            Case 16
                RoomNum = 20
                Left_Button.Visible = True
                Up_Button.Visible = True
                Right_Button.Visible = False

            Case 17
                RoomNum = 19
                Right_Button.Visible = False
                Up_Button.Visible = False

            Case 18
                RoomNum = 15
                Left_Button.Visible = True

            Case 22
                RoomNum = 41
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Up_Button.Visible = False
                Down_Button.Visible = False
                Left_Button.Visible = True

            Case 26
                RoomNum = 25
                If Monster3 = True Then
                    MonsterPicBox.Visible = True
                    TextBox.Text = "A monster has appeared! Prepare yourself for armed combat!"
                    Down_Button.Visible = False
                    Left_Button.Visible = False
                    Right_Button.Visible = False
                    Fight_Button.Visible = True
                ElseIf Monster3 = False Then
                    Up_Button.Visible = False
                    Left_Button.Visible = True
                End If

            Case 27
                RoomNum = 0
                Up_Button.Visible = True

            Case 28
                RoomNum = 27
                Up_Button.Visible = False
                Left_Button.Visible = True

            Case 30
                RoomNum = 29
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Right_Button.Visible = False
                Left_Button.Visible = True
                Up_Button.Visible = True
                Down_Button.Visible = True


            Case 32
                RoomNum = 12
                Down_Button.Visible = False
                Up_Button.Visible = True

            Case 34
                RoomNum = 32
                Left_Button.Visible = True
                Down_Button.Visible = True

            Case 36
                RoomNum = 37
                Left_Button.Visible = True
                Down_Button.Visible = False

            Case 37
                RoomNum = 38
                Right_Button.Visible = False
                Down_Button.Visible = True

            Case 39
                RoomNum = 42
                Up_Button.Visible = False
                Down_Button.Visible = False
                Left_Button.Visible = True

            Case 41
                RoomNum = 40
                If Monster6 = True Then
                    MonsterPicBox.Visible = True
                    TextBox.Text = "A monster has appeared! Prepare yourself for armed combat!"
                    Right_Button.Visible = False
                    Left_Button.Visible = False
                    Up_Button.Visible = False
                    Down_Button.Visible = False
                    Fight_Button.Visible = True
                ElseIf Monster6 = False Then
                    Right_Button.Visible = False
                    Up_Button.Visible = True
                End If

            Case 42
                RoomNum = 43
                Left_Button.Visible = True
                Right_Button.Visible = True
                Up_Button.Visible = True

            Case 43
                RoomNum = 46
                Up_Button.Visible = False

            Case 46
                RoomNum = 47
                Right_Button.Visible = False
                Up_Button.Visible = True

        End Select
    End Sub

    Private Sub Left_Button_Click(sender As Object, e As EventArgs) Handles Left_Button.Click
        Select Case RoomNum
            Case 0
                TextBox.Text = "You walk down the dank and dirty old hallway."
                RoomNum = 27
                Up_Button.Visible = False

            Case 5
                RoomNum = 12
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Down_Button.Visible = False
                Right_Button.Visible = True
                Up_Button.Visible = True

            Case 6
                RoomNum = 4
                Left_Button.Visible = False
                Down_Button.Visible = True
                Right_Button.Visible = True
                Up_Button.Visible = True

            Case 8
                RoomNum = 7
                Left_Button.Visible = False
                Down_Button.Visible = True

            Case 9
                RoomNum = 8
                Up_Button.Visible = False

            Case 11
                TextBox.Text = "You walk down the dank and dirty old hallway."
                RoomNum = 9
                Right_Button.Visible = True
                Up_Button.Visible = True

            Case 12
                RoomNum = 32
                Up_Button.Visible = False
                Down_Button.Visible = True

            Case 14
                RoomNum = 15
                Up_Button.Visible = False
                Down_Button.Visible = False

            Case 15
                RoomNum = 18
                Left_Button.Visible = False

            Case 17
                RoomNum = 14
                Down_Button.Visible = True

            Case 19
                RoomNum = 17
                Right_Button.Visible = True
                Up_Button.Visible = True

            Case 20
                RoomNum = 16
                Up_Button.Visible = False
                Left_Button.Visible = False
                Right_Button.Visible = True

            Case 23
                RoomNum = 0
                Right_Button.Visible = True

            Case 25
                RoomNum = 26
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Down_Button.Visible = False
                Right_Button.Visible = True

            Case 26
                RoomNum = 2
                Left_Button.Visible = False
                Up_Button.Visible = True
                Down_Button.Visible = True

            Case 27
                RoomNum = 28
                Left_Button.Visible = False
                Up_Button.Visible = True

            Case 29
                RoomNum = 30
                If Monster1 = True Then
                    MonsterPicBox.Visible = True
                    TextBox.Text = "A monster has appeared! Prepare yourself for armed combat!"
                    Left_Button.Visible = False
                    Up_Button.Visible = False
                    Down_Button.Visible = False
                    Fight_Button.Visible = True
                ElseIf Monster1 = False Then
                    Left_Button.Visible = False
                    Down_Button.Visible = False
                    Up_Button.Visible = False
                    Right_Button.Visible = True
                End If

            Case 32
                RoomNum = 34
                Down_Button.Visible = False
                Left_Button.Visible = False

            Case 37
                RoomNum = 36
                Left_Button.Visible = False
                Down_Button.Visible = True

            Case 38
                RoomNum = 37
                Right_Button.Visible = True
                Down_Button.Visible = False

            Case 40
                RoomNum = 41
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Right_Button.Visible = True
                Up_Button.Visible = False

            Case 41
                RoomNum = 22
                Left_Button.Visible = False
                Up_Button.Visible = True
                Down_Button.Visible = True

            Case 42
                RoomNum = 39
                Left_Button.Visible = False
                Up_Button.Visible = True
                Down_Button.Visible = True

            Case 43
                RoomNum = 42
                Up_Button.Visible = False

            Case 46
                RoomNum = 43
                Up_Button.Visible = True

            Case 47
                RoomNum = 46
                Right_Button.Visible = True
        End Select
    End Sub

    Private Sub Down_Button_Click(sender As Object, e As EventArgs) Handles Down_Button.Click
        Select Case RoomNum
            Case 1
                RoomNum = 0
                Down_Button.Visible = False
                Right_Button.Visible = True
                Left_Button.Visible = True

            Case 2
                RoomNum = 1
                Right_Button.Visible = False

            Case 3
                RoomNum = 2
                Right_Button.Visible = True

            Case 4
                RoomNum = 3
                Right_Button.Visible = False

            Case 5
                RoomNum = 4
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Right_Button.Visible = True
                Up_Button.Visible = True
                Left_Button.Visible = False

            Case 7
                RoomNum = 6
                Down_Button.Visible = False
                Right_Button.Visible = False
                Up_Button.Visible = True
                Left_Button.Visible = True

            Case 10
                RoomNum = 9
                Down_Button.Visible = False
                Up_Button.Visible = True
                Left_Button.Visible = True
                Right_Button.Visible = True

            Case 13
                RoomNum = 12
                Down_Button.Visible = False
                Right_Button.Visible = True
                Left_Button.Visible = True

            Case 14
                RoomNum = 13
                Right_Button.Visible = False
                Left_Button.Visible = False

            Case 16
                RoomNum = 14
                Up_Button.Visible = True
                Left_Button.Visible = True
                Right_Button.Visible = True

            Case 20
                RoomNum = 17
                Down_Button.Visible = False
                Right_Button.Visible = True

            Case 21
                RoomNum = 20
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Left_Button.Visible = True

            Case 22
                RoomNum = 21
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Right_Button.Visible = False

            Case 24
                RoomNum = 23
                Down_Button.Visible = False
                Left_Button.Visible = True

            Case 25
                RoomNum = 24
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Left_Button.Visible = False
                Up_Button.Visible = True

            Case 29
                RoomNum = 28
                Down_Button.Visible = False
                Left_Button.Visible = False
                Right_Button.Visible = True

            Case 31
                RoomNum = 29
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Up_Button.Visible = True
                Left_Button.Visible = True

            Case 32
                RoomNum = 33
                Up_Button.Visible = True
                Right_Button.Visible = False
                Left_Button.Visible = False
                Down_Button.Visible = False

            Case 35
                RoomNum = 22
                Right_Button.Visible = True

            Case 36
                RoomNum = 35
                Right_Button.Visible = False
                Up_Button.Visible = True

            Case 38
                RoomNum = 39
                Left_Button.Visible = False
                Up_Button.Visible = True
                Right_Button.Visible = True

            Case 39
                RoomNum = 40
                If Monster6 = True Then
                    MonsterPicBox.Visible = True
                    TextBox.Text = "A monster has appeared! Prepare yourself for armed combat!"
                    Right_Button.Visible = False
                    Left_Button.Visible = False
                    Up_Button.Visible = False
                    Down_Button.Visible = False
                    Up_Button.Visible = True
                ElseIf Monster6 = False Then
                    Down_Button.Visible = False
                    Right_Button.Visible = False
                    Left_Button.Visible = True
                    Up_Button.Visible = True
                End If

            Case 44
                RoomNum = 43
                Down_Button.Visible = False
                Left_Button.Visible = True
                Right_Button.Visible = True

            Case 45
                RoomNum = 44
                TextBox.Text = "You walk down the dank and dirty old hallway."
                Up_Button.Visible = True

            Case 48
                RoomNum = 47
                Down_Button.Visible = False
                Left_Button.Visible = True

            Case 49
                RoomNum = 48
                Up_Button.Visible = True
        End Select
    End Sub
    Private Function damage_calculator() As Integer
        Dim numbergen As Integer
        Randomize()
        numbergen = CInt(1 + Rnd() * 10)
        Return numbergen
    End Function

    Private Sub Fight_Button_Click(sender As Object, e As EventArgs) Handles Fight_Button.Click
        Dim damage As Integer = damage_calculator()
        Dim enemydamage As Integer = damage_calculator()
        Dim bossdamage As Integer = damage_calculator()
        Select Case RoomNum
            Case 5
                If damage > enemydamage Then
                    Monster4 = False
                    TextBox.Text = "You have slayed the monster!"
                    Fight_Button.Visible = False
                    Next_Button.Visible = True
                    MonsterPicBox.Visible = False
                    HallPicBox.Visible = True
                ElseIf damage < enemydamage Then
                    Playerlife -= 1
                    TextBox.Text = "You got hit!"
                    PH.Text = Playerlife
                ElseIf damage = enemydamage Then
                    TextBox.Text = "The enemy has parried your attack!"
                End If
                If Playerlife = 0 Then
                    MessageBox.Show("You have died!")
                    Me.Close()
                End If

            Case 6
                If damage > enemydamage Then
                    Monster2 = False
                    TextBox.Text = "You have slayed the monster!"
                    Fight_Button.Visible = False
                    Next_Button.Visible = True
                    MonsterPicBox.Visible = False
                    HallPicBox.Visible = True
                ElseIf damage < enemydamage Then
                    Playerlife -= 1
                    TextBox.Text = "You have been hit!"
                    PH.Text = Playerlife
                ElseIf damage = enemydamage Then
                    TextBox.Text = "The enemy has parried your attack!"
                End If
                If Playerlife = 0 Then
                    MessageBox.Show("You have died!")
                    Me.Close()
                End If

            Case 21
                If damage > enemydamage Then
                    Monster5 = False
                    TextBox.Text = "You have slayed the monster!"
                    Fight_Button.Visible = False
                    Next_Button.Visible = True
                    MonsterPicBox.Visible = False
                    HallPicBox.Visible = True
                ElseIf damage < enemydamage Then
                    Playerlife -= 1
                    TextBox.Text = "You have been hit!"
                    PH.Text = Playerlife
                ElseIf damage = enemydamage Then
                    TextBox.Text = "The enemy has parried your attack!"
                End If
                If Playerlife = 0 Then
                    MessageBox.Show("You have died!")
                    Me.Close()
                End If

            Case 25
                If damage > enemydamage Then
                    Monster3 = False
                    TextBox.Text = "You have slayed the monster!"
                    Fight_Button.Visible = False
                    Next_Button.Visible = True
                    MonsterPicBox.Visible = False
                    HallPicBox.Visible = True
                ElseIf damage < enemydamage Then
                    Playerlife -= 1
                    TextBox.Text = "You have been hit!"
                    PH.Text = Playerlife
                ElseIf damage = enemydamage Then
                    TextBox.Text = "The enemy has parried your attack!"
                End If
                If Playerlife = 0 Then
                    MessageBox.Show("You have died!")
                    Me.Close()
                End If

            Case 30
                If damage > enemydamage Then
                    Monster1 = False
                    TextBox.Text = "You have slayed the monster!"
                    Fight_Button.Visible = False
                    Next_Button.Visible = True
                    MonsterPicBox.Visible = False
                    HallPicBox.Visible = True
                ElseIf damage < enemydamage Then
                    Playerlife -= 1
                    TextBox.Text = "You have been hit!"
                    PH.Text = Playerlife
                ElseIf damage = enemydamage Then
                    TextBox.Text = "The enemy has parried your attack!"
                End If
                If Playerlife = 0 Then
                    MessageBox.Show("You have died!")
                    Me.Close()
                End If

            Case 40
                If damage > enemydamage Then
                    Monster6 = False
                    TextBox.Text = "You have slayed the monster!"
                    Fight_Button.Visible = False
                    Next_Button.Visible = True
                    MonsterPicBox.Visible = False
                    HallPicBox.Visible = True
                ElseIf damage < enemydamage Then
                    Playerlife -= 1
                    TextBox.Text = "You have been hit!"
                    PH.Text = Playerlife
                ElseIf damage = enemydamage Then
                    TextBox.Text = "The enemy has parried your attack!"
                End If
                If Playerlife = 0 Then
                    MessageBox.Show("You have died!")
                    Me.Close()
                End If

            Case 48
                If damage > bossdamage Then
                    Boss -= 1
                    TextBox.Text = "Yopu hit the boss!"
                ElseIf damage < bossdamage Then
                    Playerlife -= 1
                    TextBox.Text = "You have been hit!"
                    PH.Text = Playerlife
                ElseIf damage = bossdamage Then
                    TextBox.Text = "The beast has blocked your blow! Keep fighting, save the princesses!"
                End If
                If Boss = 0 Then
                    HallPicBox.Visible = True
                    BossPicBox.Visible = False
                    Fight_Button.Visible = False
                    Next_Button.Visible = True
                    TextBox.Text = "You have salyed the boss!"
                End If
                If Playerlife = 0 Then
                    MessageBox.Show("You have died!")
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        Select Case RoomNum

            Case 11
                Spider_princess = True
                HallPicBox.Visible = True
                SpiderPicBox.Visible = False
                TextBox.Text = "The spider princess kisses you. Your nightmares be provided immediately."
                Left_Button.Visible = True
                Save_Button.Visible = False

            Case 22
                Alien_princess = True
                HallPicBox.Visible = True
                AlienPicBox.Visible = False
                TextBox.Text = "The...thing...stares at you with it's big red eyes. Yeah, let's just walk away now."
                Up_Button.Visible = True
                Down_Button.Visible = True
                Right_Button.Visible = True
                Save_Button.Visible = False

            Case 31
                Troll_princess = True
                HallPicBox.Visible = True
                TrollPicBox.Visible = False
                TextBox.Text = "The troll princess kisses you. A vomit bag will be provided at the end of the game."
                Down_Button.Visible = True
                Save_Button.Visible = False

            Case 45
                Fire_princess = True
                HallPicBox.Visible = True
                FirePicBox.Visible = False
                TextBox.Text = "Sweet! She gave you a fire sword!"
                Down_Button.Visible = True
                Save_Button.Visible = False

        End Select
    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click

        Select Case RoomNum
            Case 5
                Down_Button.Visible = True
                Left_Button.Visible = True
                Up_Button.Visible = False
                Right_Button.Visible = False
                Next_Button.Visible = False


            Case 6
                Left_Button.Visible = True
                Up_Button.Visible = True
                Down_Button.Visible = False
                Right_Button.Visible = False
                Next_Button.Visible = False


            Case 21
                Up_Button.Visible = True
                Down_Button.Visible = True
                Right_Button.Visible = False
                Left_Button.Visible = False
                Next_Button.Visible = False


            Case 25
                Down_Button.Visible = True
                Left_Button.Visible = True
                Right_Button.Visible = False
                Up_Button.Visible = False
                Next_Button.Visible = False


            Case 30
                Right_Button.Visible = True
                Up_Button.Visible = False
                Down_Button.Visible = False
                Left_Button.Visible = False
                Next_Button.Visible = False

            Case 40
                Up_Button.Visible = True
                Left_Button.Visible = True
                Down_Button.Visible = False
                Right_Button.Visible = False
                Next_Button.Visible = False

            Case 48
                Up_Button.Visible = True
                Left_Button.Visible = False
                Down_Button.Visible = False
                Right_Button.Visible = False
                Next_Button.Visible = False
        End Select

    End Sub
End Class