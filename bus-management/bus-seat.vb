Public Class Form1

    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.available)
    Dim bookedIcon As New System.Drawing.Bitmap(My.Resources.booked)

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = availableIcon
            End If


        Next
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = bookedIcon
        ElseIf CType(sender, PictureBox).Image Is bookedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub
End Class
