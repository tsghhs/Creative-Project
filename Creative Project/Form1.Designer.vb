<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPizzaMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCreate = New System.Windows.Forms.Label()
        Me.grpSauces = New System.Windows.Forms.GroupBox()
        Me.radAlfredo = New System.Windows.Forms.RadioButton()
        Me.radHot = New System.Windows.Forms.RadioButton()
        Me.radMarinara = New System.Windows.Forms.RadioButton()
        Me.radBbq = New System.Windows.Forms.RadioButton()
        Me.grpVeggie = New System.Windows.Forms.GroupBox()
        Me.chkDiced = New System.Windows.Forms.CheckBox()
        Me.chkGreen = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkChicken = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.grpPizzacrusts = New System.Windows.Forms.GroupBox()
        Me.radHand = New System.Windows.Forms.RadioButton()
        Me.radHandmade = New System.Windows.Forms.RadioButton()
        Me.radCrunchy = New System.Windows.Forms.RadioButton()
        Me.radBrooklyn = New System.Windows.Forms.RadioButton()
        Me.grpDesserts = New System.Windows.Forms.GroupBox()
        Me.chkChoco = New System.Windows.Forms.CheckBox()
        Me.chkCookie = New System.Windows.Forms.CheckBox()
        Me.chkCinnamon = New System.Windows.Forms.CheckBox()
        Me.chkTriple = New System.Windows.Forms.CheckBox()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.chkCoke = New System.Windows.Forms.CheckBox()
        Me.chkFanta = New System.Windows.Forms.CheckBox()
        Me.chkLemonade = New System.Windows.Forms.CheckBox()
        Me.chkSprite = New System.Windows.Forms.CheckBox()
        Me.grpSides = New System.Windows.Forms.GroupBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkGarlic = New System.Windows.Forms.CheckBox()
        Me.chkBread = New System.Windows.Forms.CheckBox()
        Me.chkKnots = New System.Windows.Forms.CheckBox()
        Me.grpSizes = New System.Windows.Forms.GroupBox()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.grpSeasonings = New System.Windows.Forms.GroupBox()
        Me.radCheddar = New System.Windows.Forms.RadioButton()
        Me.radOregeno = New System.Windows.Forms.RadioButton()
        Me.btnPlaceorder = New System.Windows.Forms.Button()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.radDinein = New System.Windows.Forms.RadioButton()
        Me.radCarryout = New System.Windows.Forms.RadioButton()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCoupon = New System.Windows.Forms.Button()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.grpSauces.SuspendLayout()
        Me.grpVeggie.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.grpPizzacrusts.SuspendLayout()
        Me.grpDesserts.SuspendLayout()
        Me.grpDrinks.SuspendLayout()
        Me.grpSides.SuspendLayout()
        Me.grpSizes.SuspendLayout()
        Me.grpSeasonings.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCreate
        '
        Me.lblCreate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreate.AutoSize = True
        Me.lblCreate.BackColor = System.Drawing.Color.Transparent
        Me.lblCreate.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreate.Location = New System.Drawing.Point(305, 26)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(336, 33)
        Me.lblCreate.TabIndex = 0
        Me.lblCreate.Text = "Welcome to T's Pizzeria"
        Me.lblCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpSauces
        '
        Me.grpSauces.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSauces.BackColor = System.Drawing.Color.Transparent
        Me.grpSauces.Controls.Add(Me.radAlfredo)
        Me.grpSauces.Controls.Add(Me.radHot)
        Me.grpSauces.Controls.Add(Me.radMarinara)
        Me.grpSauces.Controls.Add(Me.radBbq)
        Me.grpSauces.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpSauces.Location = New System.Drawing.Point(647, 62)
        Me.grpSauces.Name = "grpSauces"
        Me.grpSauces.Size = New System.Drawing.Size(282, 100)
        Me.grpSauces.TabIndex = 1
        Me.grpSauces.TabStop = False
        Me.grpSauces.Text = "Sauces"
        '
        'radAlfredo
        '
        Me.radAlfredo.AutoSize = True
        Me.radAlfredo.BackColor = System.Drawing.Color.Transparent
        Me.radAlfredo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAlfredo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radAlfredo.Location = New System.Drawing.Point(9, 28)
        Me.radAlfredo.Name = "radAlfredo"
        Me.radAlfredo.Size = New System.Drawing.Size(109, 30)
        Me.radAlfredo.TabIndex = 11
        Me.radAlfredo.TabStop = True
        Me.radAlfredo.Text = "Alfredo Sauce " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($1.00)"
        Me.radAlfredo.UseVisualStyleBackColor = False
        '
        'radHot
        '
        Me.radHot.AutoSize = True
        Me.radHot.BackColor = System.Drawing.Color.Transparent
        Me.radHot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radHot.Location = New System.Drawing.Point(9, 63)
        Me.radHot.Name = "radHot"
        Me.radHot.Size = New System.Drawing.Size(89, 30)
        Me.radHot.TabIndex = 12
        Me.radHot.TabStop = True
        Me.radHot.Text = "Hot Sauce " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(50 cents)"
        Me.radHot.UseVisualStyleBackColor = False
        '
        'radMarinara
        '
        Me.radMarinara.AutoSize = True
        Me.radMarinara.BackColor = System.Drawing.Color.Transparent
        Me.radMarinara.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMarinara.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radMarinara.Location = New System.Drawing.Point(150, 28)
        Me.radMarinara.Name = "radMarinara"
        Me.radMarinara.Size = New System.Drawing.Size(118, 30)
        Me.radMarinara.TabIndex = 13
        Me.radMarinara.TabStop = True
        Me.radMarinara.Text = "Marinara Sauce " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($1.50)"
        Me.radMarinara.UseVisualStyleBackColor = False
        '
        'radBbq
        '
        Me.radBbq.AutoSize = True
        Me.radBbq.BackColor = System.Drawing.Color.Transparent
        Me.radBbq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBbq.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radBbq.Location = New System.Drawing.Point(150, 63)
        Me.radBbq.Name = "radBbq"
        Me.radBbq.Size = New System.Drawing.Size(94, 30)
        Me.radBbq.TabIndex = 14
        Me.radBbq.TabStop = True
        Me.radBbq.Text = "BBQ Sauce " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(25 cents)"
        Me.radBbq.UseVisualStyleBackColor = False
        '
        'grpVeggie
        '
        Me.grpVeggie.BackColor = System.Drawing.Color.Transparent
        Me.grpVeggie.Controls.Add(Me.chkDiced)
        Me.grpVeggie.Controls.Add(Me.chkGreen)
        Me.grpVeggie.Controls.Add(Me.chkOnions)
        Me.grpVeggie.Controls.Add(Me.chkMushrooms)
        Me.grpVeggie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVeggie.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpVeggie.Location = New System.Drawing.Point(14, 180)
        Me.grpVeggie.Name = "grpVeggie"
        Me.grpVeggie.Size = New System.Drawing.Size(282, 100)
        Me.grpVeggie.TabIndex = 0
        Me.grpVeggie.TabStop = False
        Me.grpVeggie.Text = "Veggie Toppings"
        '
        'chkDiced
        '
        Me.chkDiced.AutoSize = True
        Me.chkDiced.BackColor = System.Drawing.Color.Transparent
        Me.chkDiced.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiced.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkDiced.Location = New System.Drawing.Point(9, 28)
        Me.chkDiced.Name = "chkDiced"
        Me.chkDiced.Size = New System.Drawing.Size(122, 30)
        Me.chkDiced.TabIndex = 11
        Me.chkDiced.Text = "Diced Tomatoes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(50 cents)"
        Me.chkDiced.UseVisualStyleBackColor = False
        '
        'chkGreen
        '
        Me.chkGreen.AutoSize = True
        Me.chkGreen.BackColor = System.Drawing.Color.Transparent
        Me.chkGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkGreen.Location = New System.Drawing.Point(9, 60)
        Me.chkGreen.Name = "chkGreen"
        Me.chkGreen.Size = New System.Drawing.Size(110, 30)
        Me.chkGreen.TabIndex = 12
        Me.chkGreen.Text = "Green Peppers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(50 cents)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkGreen.UseVisualStyleBackColor = False
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.BackColor = System.Drawing.Color.Transparent
        Me.chkOnions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnions.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkOnions.Location = New System.Drawing.Point(150, 60)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(83, 30)
        Me.chkOnions.TabIndex = 14
        Me.chkOnions.Text = "Onions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(50 cents)"
        Me.chkOnions.UseVisualStyleBackColor = False
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.BackColor = System.Drawing.Color.Transparent
        Me.chkMushrooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMushrooms.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkMushrooms.Location = New System.Drawing.Point(150, 28)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(93, 30)
        Me.chkMushrooms.TabIndex = 13
        Me.chkMushrooms.Text = "Mushrooms " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(50 cents)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkMushrooms.UseVisualStyleBackColor = False
        '
        'grpToppings
        '
        Me.grpToppings.BackColor = System.Drawing.Color.Transparent
        Me.grpToppings.Controls.Add(Me.chkBacon)
        Me.grpToppings.Controls.Add(Me.chkChicken)
        Me.grpToppings.Controls.Add(Me.chkHam)
        Me.grpToppings.Controls.Add(Me.chkPepperoni)
        Me.grpToppings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpToppings.Location = New System.Drawing.Point(14, 298)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(282, 100)
        Me.grpToppings.TabIndex = 3
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Meat Toppings"
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.BackColor = System.Drawing.Color.Transparent
        Me.chkBacon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBacon.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkBacon.Location = New System.Drawing.Point(9, 30)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(83, 30)
        Me.chkBacon.TabIndex = 11
        Me.chkBacon.Text = "Bacon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(40 cents)"
        Me.chkBacon.UseVisualStyleBackColor = False
        '
        'chkChicken
        '
        Me.chkChicken.AutoSize = True
        Me.chkChicken.BackColor = System.Drawing.Color.Transparent
        Me.chkChicken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChicken.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkChicken.Location = New System.Drawing.Point(9, 66)
        Me.chkChicken.Name = "chkChicken"
        Me.chkChicken.Size = New System.Drawing.Size(83, 30)
        Me.chkChicken.TabIndex = 12
        Me.chkChicken.Text = "Chicken" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(40 cents)"
        Me.chkChicken.UseVisualStyleBackColor = False
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.BackColor = System.Drawing.Color.Transparent
        Me.chkHam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHam.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkHam.Location = New System.Drawing.Point(150, 30)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(83, 30)
        Me.chkHam.TabIndex = 13
        Me.chkHam.Text = "Ham " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(40 cents)"
        Me.chkHam.UseVisualStyleBackColor = False
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.BackColor = System.Drawing.Color.Transparent
        Me.chkPepperoni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPepperoni.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkPepperoni.Location = New System.Drawing.Point(150, 66)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(83, 30)
        Me.chkPepperoni.TabIndex = 14
        Me.chkPepperoni.Text = "Pepperoni" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(50 cents)"
        Me.chkPepperoni.UseVisualStyleBackColor = False
        '
        'grpPizzacrusts
        '
        Me.grpPizzacrusts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpPizzacrusts.BackColor = System.Drawing.Color.Transparent
        Me.grpPizzacrusts.Controls.Add(Me.radHand)
        Me.grpPizzacrusts.Controls.Add(Me.radHandmade)
        Me.grpPizzacrusts.Controls.Add(Me.radCrunchy)
        Me.grpPizzacrusts.Controls.Add(Me.radBrooklyn)
        Me.grpPizzacrusts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPizzacrusts.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpPizzacrusts.Location = New System.Drawing.Point(331, 62)
        Me.grpPizzacrusts.Name = "grpPizzacrusts"
        Me.grpPizzacrusts.Size = New System.Drawing.Size(282, 100)
        Me.grpPizzacrusts.TabIndex = 0
        Me.grpPizzacrusts.TabStop = False
        Me.grpPizzacrusts.Text = "Pizza Crusts"
        '
        'radHand
        '
        Me.radHand.AutoSize = True
        Me.radHand.BackColor = System.Drawing.Color.Transparent
        Me.radHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHand.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radHand.Location = New System.Drawing.Point(9, 28)
        Me.radHand.Name = "radHand"
        Me.radHand.Size = New System.Drawing.Size(100, 30)
        Me.radHand.TabIndex = 11
        Me.radHand.TabStop = True
        Me.radHand.Text = "Hand Tossed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($1.00)"
        Me.radHand.UseVisualStyleBackColor = False
        '
        'radHandmade
        '
        Me.radHandmade.AutoSize = True
        Me.radHandmade.BackColor = System.Drawing.Color.Transparent
        Me.radHandmade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHandmade.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radHandmade.Location = New System.Drawing.Point(144, 28)
        Me.radHandmade.Name = "radHandmade"
        Me.radHandmade.Size = New System.Drawing.Size(111, 30)
        Me.radHandmade.TabIndex = 13
        Me.radHandmade.TabStop = True
        Me.radHandmade.Text = "Handmade Pan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($1.00)"
        Me.radHandmade.UseVisualStyleBackColor = False
        '
        'radCrunchy
        '
        Me.radCrunchy.AutoSize = True
        Me.radCrunchy.BackColor = System.Drawing.Color.Transparent
        Me.radCrunchy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCrunchy.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radCrunchy.Location = New System.Drawing.Point(9, 63)
        Me.radCrunchy.Name = "radCrunchy"
        Me.radCrunchy.Size = New System.Drawing.Size(133, 30)
        Me.radCrunchy.TabIndex = 12
        Me.radCrunchy.TabStop = True
        Me.radCrunchy.Text = "Crunchy Thin Crust" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($1.00)"
        Me.radCrunchy.UseVisualStyleBackColor = False
        '
        'radBrooklyn
        '
        Me.radBrooklyn.AutoSize = True
        Me.radBrooklyn.BackColor = System.Drawing.Color.Transparent
        Me.radBrooklyn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBrooklyn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radBrooklyn.Location = New System.Drawing.Point(144, 63)
        Me.radBrooklyn.Name = "radBrooklyn"
        Me.radBrooklyn.Size = New System.Drawing.Size(106, 30)
        Me.radBrooklyn.TabIndex = 14
        Me.radBrooklyn.TabStop = True
        Me.radBrooklyn.Text = "Brooklyn Style" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($1.00)"
        Me.radBrooklyn.UseVisualStyleBackColor = False
        '
        'grpDesserts
        '
        Me.grpDesserts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpDesserts.BackColor = System.Drawing.Color.Transparent
        Me.grpDesserts.Controls.Add(Me.chkChoco)
        Me.grpDesserts.Controls.Add(Me.chkCookie)
        Me.grpDesserts.Controls.Add(Me.chkCinnamon)
        Me.grpDesserts.Controls.Add(Me.chkTriple)
        Me.grpDesserts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDesserts.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpDesserts.Location = New System.Drawing.Point(331, 180)
        Me.grpDesserts.Name = "grpDesserts"
        Me.grpDesserts.Size = New System.Drawing.Size(282, 100)
        Me.grpDesserts.TabIndex = 0
        Me.grpDesserts.TabStop = False
        Me.grpDesserts.Text = "Desserts"
        '
        'chkChoco
        '
        Me.chkChoco.AutoSize = True
        Me.chkChoco.BackColor = System.Drawing.Color.Transparent
        Me.chkChoco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChoco.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkChoco.Location = New System.Drawing.Point(9, 28)
        Me.chkChoco.Name = "chkChoco"
        Me.chkChoco.Size = New System.Drawing.Size(127, 30)
        Me.chkChoco.TabIndex = 11
        Me.chkChoco.Text = "Choco Lava Cake" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($5.00)"
        Me.chkChoco.UseVisualStyleBackColor = False
        '
        'chkCookie
        '
        Me.chkCookie.AutoSize = True
        Me.chkCookie.BackColor = System.Drawing.Color.Transparent
        Me.chkCookie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCookie.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkCookie.Location = New System.Drawing.Point(144, 28)
        Me.chkCookie.Name = "chkCookie"
        Me.chkCookie.Size = New System.Drawing.Size(134, 30)
        Me.chkCookie.TabIndex = 13
        Me.chkCookie.Text = "Choco-Chip Cookie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($5.00)"
        Me.chkCookie.UseVisualStyleBackColor = False
        '
        'chkCinnamon
        '
        Me.chkCinnamon.AutoSize = True
        Me.chkCinnamon.BackColor = System.Drawing.Color.Transparent
        Me.chkCinnamon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCinnamon.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkCinnamon.Location = New System.Drawing.Point(9, 60)
        Me.chkCinnamon.Name = "chkCinnamon"
        Me.chkCinnamon.Size = New System.Drawing.Size(120, 30)
        Me.chkCinnamon.TabIndex = 12
        Me.chkCinnamon.Text = "Cinnamon Sticks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($5.00)"
        Me.chkCinnamon.UseVisualStyleBackColor = False
        '
        'chkTriple
        '
        Me.chkTriple.AutoSize = True
        Me.chkTriple.BackColor = System.Drawing.Color.Transparent
        Me.chkTriple.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTriple.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkTriple.Location = New System.Drawing.Point(144, 60)
        Me.chkTriple.Name = "chkTriple"
        Me.chkTriple.Size = New System.Drawing.Size(130, 30)
        Me.chkTriple.TabIndex = 14
        Me.chkTriple.Text = "Tri-Choco Brownie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($7.00)"
        Me.chkTriple.UseVisualStyleBackColor = False
        '
        'grpDrinks
        '
        Me.grpDrinks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpDrinks.BackColor = System.Drawing.Color.Transparent
        Me.grpDrinks.Controls.Add(Me.chkCoke)
        Me.grpDrinks.Controls.Add(Me.chkFanta)
        Me.grpDrinks.Controls.Add(Me.chkLemonade)
        Me.grpDrinks.Controls.Add(Me.chkSprite)
        Me.grpDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDrinks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpDrinks.Location = New System.Drawing.Point(331, 298)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(282, 100)
        Me.grpDrinks.TabIndex = 0
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Drinks"
        '
        'chkCoke
        '
        Me.chkCoke.AutoSize = True
        Me.chkCoke.BackColor = System.Drawing.Color.Transparent
        Me.chkCoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCoke.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkCoke.Location = New System.Drawing.Point(9, 30)
        Me.chkCoke.Name = "chkCoke"
        Me.chkCoke.Size = New System.Drawing.Size(84, 30)
        Me.chkCoke.TabIndex = 11
        Me.chkCoke.Text = "Coca-Cola" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($8.00)"
        Me.chkCoke.UseVisualStyleBackColor = False
        '
        'chkFanta
        '
        Me.chkFanta.AutoSize = True
        Me.chkFanta.BackColor = System.Drawing.Color.Transparent
        Me.chkFanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFanta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkFanta.Location = New System.Drawing.Point(144, 30)
        Me.chkFanta.Name = "chkFanta"
        Me.chkFanta.Size = New System.Drawing.Size(66, 30)
        Me.chkFanta.TabIndex = 13
        Me.chkFanta.Text = "Fanta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($8.00)"
        Me.chkFanta.UseVisualStyleBackColor = False
        '
        'chkLemonade
        '
        Me.chkLemonade.AutoSize = True
        Me.chkLemonade.BackColor = System.Drawing.Color.Transparent
        Me.chkLemonade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLemonade.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkLemonade.Location = New System.Drawing.Point(144, 66)
        Me.chkLemonade.Name = "chkLemonade"
        Me.chkLemonade.Size = New System.Drawing.Size(84, 30)
        Me.chkLemonade.TabIndex = 14
        Me.chkLemonade.Text = "Lemonade" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($8.00)"
        Me.chkLemonade.UseVisualStyleBackColor = False
        '
        'chkSprite
        '
        Me.chkSprite.AutoSize = True
        Me.chkSprite.BackColor = System.Drawing.Color.Transparent
        Me.chkSprite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSprite.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkSprite.Location = New System.Drawing.Point(9, 66)
        Me.chkSprite.Name = "chkSprite"
        Me.chkSprite.Size = New System.Drawing.Size(66, 30)
        Me.chkSprite.TabIndex = 12
        Me.chkSprite.Text = "Sprite" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($8.00)"
        Me.chkSprite.UseVisualStyleBackColor = False
        '
        'grpSides
        '
        Me.grpSides.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSides.BackColor = System.Drawing.Color.Transparent
        Me.grpSides.Controls.Add(Me.chkFries)
        Me.grpSides.Controls.Add(Me.chkGarlic)
        Me.grpSides.Controls.Add(Me.chkBread)
        Me.grpSides.Controls.Add(Me.chkKnots)
        Me.grpSides.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSides.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpSides.Location = New System.Drawing.Point(647, 180)
        Me.grpSides.Name = "grpSides"
        Me.grpSides.Size = New System.Drawing.Size(282, 100)
        Me.grpSides.TabIndex = 0
        Me.grpSides.TabStop = False
        Me.grpSides.Text = "Sides"
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.BackColor = System.Drawing.Color.Transparent
        Me.chkFries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFries.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkFries.Location = New System.Drawing.Point(9, 28)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(66, 30)
        Me.chkFries.TabIndex = 11
        Me.chkFries.Text = "Fries" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($7.00)"
        Me.chkFries.UseVisualStyleBackColor = False
        '
        'chkGarlic
        '
        Me.chkGarlic.AutoSize = True
        Me.chkGarlic.BackColor = System.Drawing.Color.Transparent
        Me.chkGarlic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarlic.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkGarlic.Location = New System.Drawing.Point(150, 28)
        Me.chkGarlic.Name = "chkGarlic"
        Me.chkGarlic.Size = New System.Drawing.Size(95, 30)
        Me.chkGarlic.TabIndex = 13
        Me.chkGarlic.Text = "Garlic Knots" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($9.00)"
        Me.chkGarlic.UseVisualStyleBackColor = False
        '
        'chkBread
        '
        Me.chkBread.AutoSize = True
        Me.chkBread.BackColor = System.Drawing.Color.Transparent
        Me.chkBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBread.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkBread.Location = New System.Drawing.Point(9, 60)
        Me.chkBread.Name = "chkBread"
        Me.chkBread.Size = New System.Drawing.Size(98, 30)
        Me.chkBread.TabIndex = 12
        Me.chkBread.Text = "Bread Sticks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($7.00)"
        Me.chkBread.UseVisualStyleBackColor = False
        '
        'chkKnots
        '
        Me.chkKnots.AutoSize = True
        Me.chkKnots.BackColor = System.Drawing.Color.Transparent
        Me.chkKnots.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKnots.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkKnots.Location = New System.Drawing.Point(150, 60)
        Me.chkKnots.Name = "chkKnots"
        Me.chkKnots.Size = New System.Drawing.Size(95, 30)
        Me.chkKnots.TabIndex = 14
        Me.chkKnots.Text = "Bread Knots" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($7.00)"
        Me.chkKnots.UseVisualStyleBackColor = False
        '
        'grpSizes
        '
        Me.grpSizes.BackColor = System.Drawing.Color.Transparent
        Me.grpSizes.Controls.Add(Me.radSmall)
        Me.grpSizes.Controls.Add(Me.radLarge)
        Me.grpSizes.Controls.Add(Me.radMedium)
        Me.grpSizes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSizes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpSizes.Location = New System.Drawing.Point(14, 62)
        Me.grpSizes.Name = "grpSizes"
        Me.grpSizes.Size = New System.Drawing.Size(282, 100)
        Me.grpSizes.TabIndex = 0
        Me.grpSizes.TabStop = False
        Me.grpSizes.Text = "Sizes"
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.BackColor = System.Drawing.Color.Transparent
        Me.radSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSmall.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radSmall.Location = New System.Drawing.Point(9, 28)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(72, 30)
        Me.radSmall.TabIndex = 11
        Me.radSmall.Text = "Small" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($10.00)"
        Me.radSmall.UseVisualStyleBackColor = False
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.BackColor = System.Drawing.Color.Transparent
        Me.radLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLarge.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radLarge.Location = New System.Drawing.Point(9, 63)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(72, 30)
        Me.radLarge.TabIndex = 13
        Me.radLarge.Text = "Large" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($20.00)"
        Me.radLarge.UseVisualStyleBackColor = False
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.BackColor = System.Drawing.Color.Transparent
        Me.radMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMedium.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radMedium.Location = New System.Drawing.Point(150, 28)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(72, 30)
        Me.radMedium.TabIndex = 12
        Me.radMedium.Text = "Medium" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "($15.00)"
        Me.radMedium.UseVisualStyleBackColor = False
        '
        'grpSeasonings
        '
        Me.grpSeasonings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSeasonings.BackColor = System.Drawing.Color.Transparent
        Me.grpSeasonings.Controls.Add(Me.radCheddar)
        Me.grpSeasonings.Controls.Add(Me.radOregeno)
        Me.grpSeasonings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSeasonings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpSeasonings.Location = New System.Drawing.Point(647, 298)
        Me.grpSeasonings.Name = "grpSeasonings"
        Me.grpSeasonings.Size = New System.Drawing.Size(282, 100)
        Me.grpSeasonings.TabIndex = 0
        Me.grpSeasonings.TabStop = False
        Me.grpSeasonings.Text = "Seasonings"
        '
        'radCheddar
        '
        Me.radCheddar.AutoSize = True
        Me.radCheddar.BackColor = System.Drawing.Color.Transparent
        Me.radCheddar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCheddar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radCheddar.Location = New System.Drawing.Point(9, 30)
        Me.radCheddar.Name = "radCheddar"
        Me.radCheddar.Size = New System.Drawing.Size(164, 30)
        Me.radCheddar.TabIndex = 11
        Me.radCheddar.Text = "Cheddar Cheese Powder" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Free"
        Me.radCheddar.UseVisualStyleBackColor = False
        '
        'radOregeno
        '
        Me.radOregeno.AutoSize = True
        Me.radOregeno.BackColor = System.Drawing.Color.Transparent
        Me.radOregeno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOregeno.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radOregeno.Location = New System.Drawing.Point(9, 66)
        Me.radOregeno.Name = "radOregeno"
        Me.radOregeno.Size = New System.Drawing.Size(170, 30)
        Me.radOregeno.TabIndex = 12
        Me.radOregeno.Text = "Oregeno, Herb and Garlic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Free"
        Me.radOregeno.UseVisualStyleBackColor = False
        '
        'btnPlaceorder
        '
        Me.btnPlaceorder.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPlaceorder.BackColor = System.Drawing.Color.Silver
        Me.btnPlaceorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceorder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPlaceorder.Location = New System.Drawing.Point(331, 508)
        Me.btnPlaceorder.Name = "btnPlaceorder"
        Me.btnPlaceorder.Size = New System.Drawing.Size(282, 53)
        Me.btnPlaceorder.TabIndex = 9
        Me.btnPlaceorder.Text = "Place Order"
        Me.btnPlaceorder.UseVisualStyleBackColor = False
        '
        'grpDelivery
        '
        Me.grpDelivery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDelivery.BackColor = System.Drawing.Color.Transparent
        Me.grpDelivery.Controls.Add(Me.radPickup)
        Me.grpDelivery.Controls.Add(Me.radDinein)
        Me.grpDelivery.Controls.Add(Me.radCarryout)
        Me.grpDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDelivery.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpDelivery.Location = New System.Drawing.Point(647, 461)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(282, 100)
        Me.grpDelivery.TabIndex = 10
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Delivery"
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Location = New System.Drawing.Point(9, 74)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(64, 17)
        Me.radPickup.TabIndex = 13
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'radDinein
        '
        Me.radDinein.AutoSize = True
        Me.radDinein.BackColor = System.Drawing.Color.Transparent
        Me.radDinein.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDinein.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radDinein.Location = New System.Drawing.Point(9, 28)
        Me.radDinein.Name = "radDinein"
        Me.radDinein.Size = New System.Drawing.Size(65, 17)
        Me.radDinein.TabIndex = 11
        Me.radDinein.TabStop = True
        Me.radDinein.Text = "Dine-in"
        Me.radDinein.UseVisualStyleBackColor = False
        '
        'radCarryout
        '
        Me.radCarryout.AutoSize = True
        Me.radCarryout.BackColor = System.Drawing.Color.Transparent
        Me.radCarryout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCarryout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radCarryout.Location = New System.Drawing.Point(9, 51)
        Me.radCarryout.Name = "radCarryout"
        Me.radCarryout.Size = New System.Drawing.Size(78, 17)
        Me.radCarryout.TabIndex = 12
        Me.radCarryout.TabStop = True
        Me.radCarryout.Text = "Carry Out"
        Me.radCarryout.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotal.Location = New System.Drawing.Point(9, 477)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 29)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(946, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnCoupon
        '
        Me.btnCoupon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCoupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoupon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCoupon.Location = New System.Drawing.Point(14, 522)
        Me.btnCoupon.Name = "btnCoupon"
        Me.btnCoupon.Size = New System.Drawing.Size(108, 39)
        Me.btnCoupon.TabIndex = 15
        Me.btnCoupon.Text = "Coupon"
        Me.btnCoupon.UseVisualStyleBackColor = True
        '
        'lblDiscount
        '
        Me.lblDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(162, 529)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(0, 25)
        Me.lblDiscount.TabIndex = 16
        '
        'frmPizzaMenu
        '
        Me.AcceptButton = Me.btnPlaceorder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.Creative_Project.My.Resources.Resources.pizzeria_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(946, 675)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.btnCoupon)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.grpDelivery)
        Me.Controls.Add(Me.btnPlaceorder)
        Me.Controls.Add(Me.grpSeasonings)
        Me.Controls.Add(Me.grpSizes)
        Me.Controls.Add(Me.grpSides)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.grpDesserts)
        Me.Controls.Add(Me.grpPizzacrusts)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.grpVeggie)
        Me.Controls.Add(Me.grpSauces)
        Me.Controls.Add(Me.lblCreate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPizzaMenu"
        Me.Text = "T's Pizzeria Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpSauces.ResumeLayout(False)
        Me.grpSauces.PerformLayout()
        Me.grpVeggie.ResumeLayout(False)
        Me.grpVeggie.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.grpPizzacrusts.ResumeLayout(False)
        Me.grpPizzacrusts.PerformLayout()
        Me.grpDesserts.ResumeLayout(False)
        Me.grpDesserts.PerformLayout()
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.grpSides.ResumeLayout(False)
        Me.grpSides.PerformLayout()
        Me.grpSizes.ResumeLayout(False)
        Me.grpSizes.PerformLayout()
        Me.grpSeasonings.ResumeLayout(False)
        Me.grpSeasonings.PerformLayout()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCreate As Label
    Friend WithEvents grpSauces As GroupBox
    Friend WithEvents grpVeggie As GroupBox
    Friend WithEvents grpToppings As GroupBox
    Friend WithEvents grpPizzacrusts As GroupBox
    Friend WithEvents grpDesserts As GroupBox
    Friend WithEvents grpDrinks As GroupBox
    Friend WithEvents grpSides As GroupBox
    Friend WithEvents grpSizes As GroupBox
    Friend WithEvents grpSeasonings As GroupBox
    Friend WithEvents btnPlaceorder As Button
    Friend WithEvents grpDelivery As GroupBox
    Friend WithEvents radAlfredo As RadioButton
    Friend WithEvents radHot As RadioButton
    Friend WithEvents radMarinara As RadioButton
    Friend WithEvents radBbq As RadioButton
    Friend WithEvents chkChicken As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkPepperoni As CheckBox
    Friend WithEvents chkBacon As CheckBox
    Friend WithEvents chkDiced As CheckBox
    Friend WithEvents chkGreen As CheckBox
    Friend WithEvents chkOnions As CheckBox
    Friend WithEvents chkMushrooms As CheckBox
    Friend WithEvents radHand As RadioButton
    Friend WithEvents radHandmade As RadioButton
    Friend WithEvents radCrunchy As RadioButton
    Friend WithEvents radBrooklyn As RadioButton
    Friend WithEvents chkChoco As CheckBox
    Friend WithEvents chkCookie As CheckBox
    Friend WithEvents chkCinnamon As CheckBox
    Friend WithEvents chkTriple As CheckBox
    Friend WithEvents chkCoke As CheckBox
    Friend WithEvents chkFanta As CheckBox
    Friend WithEvents chkLemonade As CheckBox
    Friend WithEvents chkSprite As CheckBox
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkGarlic As CheckBox
    Friend WithEvents chkBread As CheckBox
    Friend WithEvents chkKnots As CheckBox
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radCheddar As RadioButton
    Friend WithEvents radOregeno As RadioButton
    Friend WithEvents radDinein As RadioButton
    Friend WithEvents radCarryout As RadioButton
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents lblTotal As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCoupon As Button
    Friend WithEvents lblDiscount As Label
End Class
