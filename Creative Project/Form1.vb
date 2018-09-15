Public Class frmPizzaMenu
    Private totalPrice As Double = 0
    Private discount As Integer = 0

    Private Sub frmPizzaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDiscount.Text = discount & "%"
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub radAlfredo_CheckedChanged(sender As Object, e As EventArgs) Handles radAlfredo.CheckedChanged
        If sender.Checked Then totalPrice += 1 Else totalPrice -= 1
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub radMarinara_CheckedChanged(sender As Object, e As EventArgs) Handles radMarinara.CheckedChanged
        If sender.Checked Then totalPrice += 1.5 Else totalPrice -= 1.5
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub radHot_CheckedChanged(sender As Object, e As EventArgs) Handles radHot.CheckedChanged
        If sender.Checked Then totalPrice += 0.5 Else totalPrice -= 0.5
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub radBbq_CheckedChanged(sender As Object, e As EventArgs) Handles radBbq.CheckedChanged
        If sender.Checked Then totalPrice += 0.25 Else totalPrice -= 0.25
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub
    Private Sub chkDiced_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiced.CheckedChanged
        If sender.Checked Then totalPrice += 0.5 Else totalPrice -= 0.5
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkMushrooms_CheckedChanged(sender As Object, e As EventArgs) Handles chkMushrooms.CheckedChanged
        If sender.Checked Then totalPrice += 0.5 Else totalPrice -= 0.5
        pbMushroom1.Visible = sender.Checked
        pbMushroom2.Visible = sender.Checked
        pbMushroom3.Visible = sender.Checked
        pbMushroom4.Visible = sender.Checked
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkGreen_CheckedChanged(sender As Object, e As EventArgs) Handles chkGreen.CheckedChanged
        If sender.Checked Then totalPrice += 0.5 Else totalPrice -= 0.5
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkOnions_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnions.CheckedChanged
        If sender.Checked Then totalPrice += 0.5 Else totalPrice -= 0.5
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkBacon_CheckedChanged(sender As Object, e As EventArgs) Handles chkBacon.CheckedChanged
        If sender.Checked Then totalPrice += 0.4 Else totalPrice -= 0.4
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkHam_CheckedChanged(sender As Object, e As EventArgs) Handles chkHam.CheckedChanged
        If sender.Checked Then totalPrice += 0.4 Else totalPrice -= 0.4
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkChicken_CheckedChanged(sender As Object, e As EventArgs) Handles chkChicken.CheckedChanged
        If sender.Checked Then totalPrice += 0.4 Else totalPrice -= 0.4
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkPepperoni_CheckedChanged(sender As Object, e As EventArgs) Handles chkPepperoni.CheckedChanged
        If sender.Checked Then totalPrice += 0.5 Else totalPrice -= 0.5
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub radHand_CheckedChanged(sender As Object, e As EventArgs) Handles radHand.CheckedChanged
        If sender.Checked Then totalPrice += 1 Else totalPrice -= 1
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub radHandmade_CheckedChanged(sender As Object, e As EventArgs) Handles radHandmade.CheckedChanged
        If sender.Checked Then totalPrice += 1 Else totalPrice -= 1
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub RadCrunchy_CheckedChanged(sender As Object, e As EventArgs) Handles radCrunchy.CheckedChanged
        If sender.Checked Then totalPrice += 1 Else totalPrice -= 1
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub radBrooklyn_CheckedChanged(sender As Object, e As EventArgs) Handles radBrooklyn.CheckedChanged
        If sender.Checked Then totalPrice += 1 Else totalPrice -= 1
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkChoco_CheckedChanged(sender As Object, e As EventArgs) Handles chkChoco.CheckedChanged
        If sender.Checked Then totalPrice += 5 Else totalPrice -= 5
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkCookie_CheckedChanged(sender As Object, e As EventArgs) Handles chkCookie.CheckedChanged
        If sender.Checked Then totalPrice += 5 Else totalPrice -= 5
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkCinnamon_CheckedChanged(sender As Object, e As EventArgs) Handles chkCinnamon.CheckedChanged
        If sender.Checked Then totalPrice += 5 Else totalPrice -= 5
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkTriple_CheckedChanged(sender As Object, e As EventArgs) Handles chkTriple.CheckedChanged
        If sender.Checked Then totalPrice += 7 Else totalPrice -= 7
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkCoke_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoke.CheckedChanged
        If sender.Checked Then totalPrice += 8 Else totalPrice -= 8
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkFanta_CheckedChanged(sender As Object, e As EventArgs) Handles chkFanta.CheckedChanged
        If sender.Checked Then totalPrice += 8 Else totalPrice -= 8
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkSprite_CheckedChanged(sender As Object, e As EventArgs) Handles chkSprite.CheckedChanged
        If sender.Checked Then totalPrice += 8 Else totalPrice -= 8
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkLemonade_CheckedChanged(sender As Object, e As EventArgs) Handles chkLemonade.CheckedChanged
        If sender.Checked Then totalPrice += 8 Else totalPrice -= 8
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged
        If sender.Checked Then totalPrice += 7 Else totalPrice -= 7
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkBread_CheckedChanged(sender As Object, e As EventArgs) Handles chkBread.CheckedChanged
        If sender.Checked Then totalPrice += 7 Else totalPrice -= 7
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkKnots_CheckedChanged(sender As Object, e As EventArgs) Handles chkKnots.CheckedChanged
        If sender.Checked Then totalPrice += 7 Else totalPrice -= 7
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub chkGarlic_CheckedChanged(sender As Object, e As EventArgs) Handles chkGarlic.CheckedChanged
        If sender.Checked Then totalPrice += 9 Else totalPrice -= 9
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub radSmall_CheckedChanged(sender As Object, e As EventArgs) Handles radSmall.CheckedChanged
        If sender.Checked Then totalPrice += 10 Else totalPrice -= 10
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)

    End Sub

    Private Sub radMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radMedium.CheckedChanged
        If sender.Checked Then totalPrice += 15 Else totalPrice -= 15
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub radLarge_CheckedChanged(sender As Object, e As EventArgs) Handles radLarge.CheckedChanged
        If sender.Checked Then totalPrice += 20 Else totalPrice -= 20
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ShowErrorMessage(message As String)
        MessageBox.Show(message, "T's Pizzeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnPlaceorder_Click(sender As Object, e As EventArgs) Handles btnPlaceorder.Click
        If Not (radSmall.Checked Or radMedium.Checked Or radLarge.Checked) Then
            ShowErrorMessage("Please select Size of Pizza")
            Return
        End If

        If Not (radHand.Checked Or radHandmade.Checked Or radBrooklyn.Checked Or radCrunchy.Checked) Then
            ShowErrorMessage("Please select Crust for the Pizza")
            Return
        End If

        If Not (radHot.Checked Or radAlfredo.Checked Or radMarinara.Checked Or radBbq.Checked) Then
            ShowErrorMessage("Please select Sauce for the Pizza")
            Return
        End If

        If Not (radDinein.Checked Or radCarryout.Checked Or radPickup.Checked) Then
            ShowErrorMessage("Please select Delivery option")
            Return
        End If

        Dim Items As String = "You have ordered "
        If radMedium.Checked = True Then
            Items &= "Medium Size, "
        End If
        If radLarge.Checked = True Then
            Items &= "Large Size, "
        End If
        If radSmall.Checked = True Then
            Items &= "Small Size, "
        End If

        If radHand.Checked = True Then
            Items &= "Hand Tossed"
        End If
        If radBrooklyn.Checked = True Then
            Items &= "Brooklyn Style"
        End If
        If radHandmade.Checked = True Then
            Items &= "Handmade Pan"
        End If
        If radCrunchy.Checked = True Then
            Items &= "Crunchy Thin Crust"
        End If

        Items &= " Pizza, with Cheese,"

        If radAlfredo.Checked = True Then
            Items &= " Alfredo Sauce, "
        End If
        If radHot.Checked = True Then
            Items &= " Hot Sauce, "
        End If
        If radMarinara.Checked = True Then
            Items &= " Marinara Sauce, "
        End If
        If radBbq.Checked = True Then
            Items &= " BBQ Sauce, "
        End If
        If chkGreen.Checked = True Then
            Items &= " Green Peppers, "
        End If
        If chkMushrooms.Checked = True Then
            Items &= " Mushrooms, "
        End If
        If chkOnions.Checked = True Then
            Items &= " Onions, "
        End If
        If chkDiced.Checked = True Then
            Items &= " Diced Tomatoes, "
        End If
        If chkHam.Checked = True Then
            Items &= " Ham, "
        End If
        If chkPepperoni.Checked = True Then
            Items &= " Pepperoni, "
        End If
        If chkChicken.Checked = True Then
            Items &= " Chicken, "
        End If
        If chkBacon.Checked = True Then
            Items &= " Bacon, "
        End If
        If chkChoco.Checked = True Then
            Items &= " Choco Lava Cake, "
        End If
        If chkCookie.Checked = True Then
            Items &= " Choco Chip Cookie, "
        End If
        If chkTriple.Checked = True Then
            Items &= " Tri Choco Brownie, "
        End If
        If chkCinnamon.Checked = True Then
            Items &= " Cinnamon Sticks, "
        End If
        If chkCoke.Checked = True Then
            Items &= " Coca Cola, "
        End If
        If chkFanta.Checked = True Then
            Items &= " Fanta, "
        End If
        If chkLemonade.Checked = True Then
            Items &= " Lemonade, "
        End If
        If chkSprite.Checked = True Then
            Items &= " Sprite, "
        End If
        If chkKnots.Checked = True Then
            Items &= " Bread Knots, "
        End If
        If chkBread.Checked = True Then
            Items &= " Bread Sticks, "
        End If
        If chkFries.Checked = True Then
            Items &= " Fries, "
        End If
        If chkGarlic.Checked = True Then
            Items &= " Garlic Knots, "
        End If
        If radOregeno.Checked = True Then
            Items &= " Garlic, Herb and Oregeno Seasoning, "
        End If
        If radCheddar.Checked = True Then
            Items &= " Cheddar Seasoning, "
        End If
        If radCarryout.Checked = True Then
            Items &= " for Carryout "
        End If
        If radDinein.Checked = True Then
            Items &= " for Dine In "
        End If
        If radPickup.Checked = True Then
            Items &= " for Pickup "
        End If

        Dim choice As DialogResult = MessageBox.Show(Items, "T's Pizzeria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If choice = DialogResult.OK Then
            MessageBox.Show("Order Placed. Thank You.", "T's Pizzeria", MessageBoxButtons.OK)
        End If
        If choice = DialogResult.Cancel Then
            MessageBox.Show("Order Cancelled", "T's Pizzeria", MessageBoxButtons.OK)
        End If
        discount = 0
        lblDiscount.Text = discount & "%"
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub

    Private Sub btnCoupon_Click(sender As Object, e As EventArgs) Handles btnCoupon.Click
        Dim rnd As Random = New Random()
        discount = rnd.Next(0, 20)
        lblDiscount.Text = discount & "%"
        lblTotal.Text = "Total: " & FormatCurrency(totalPrice * (100 - discount) / 100, 2)
    End Sub
End Class
