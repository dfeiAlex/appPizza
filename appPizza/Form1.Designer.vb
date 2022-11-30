<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblPizzaType = New System.Windows.Forms.Label()
        Me.imgHeader = New System.Windows.Forms.PictureBox()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.grpSizes = New System.Windows.Forms.GroupBox()
        Me.cboPizzaType = New System.Windows.Forms.ComboBox()
        Me.chkExtraCheese = New System.Windows.Forms.CheckBox()
        Me.chkExtraHam = New System.Windows.Forms.CheckBox()
        Me.grpExtraToppings = New System.Windows.Forms.GroupBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnMakePizza = New System.Windows.Forms.Button()
        Me.grpOrderDetails = New System.Windows.Forms.GroupBox()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnAddNewPizza = New System.Windows.Forms.Button()
        Me.grpReceipt = New System.Windows.Forms.GroupBox()
        Me.pnlReceipt = New System.Windows.Forms.Panel()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.lblAddNewPizza = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.imgHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSizes.SuspendLayout()
        Me.grpExtraToppings.SuspendLayout()
        Me.grpOrderDetails.SuspendLayout()
        Me.grpControls.SuspendLayout()
        Me.grpReceipt.SuspendLayout()
        Me.pnlReceipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPizzaType
        '
        Me.lblPizzaType.AutoSize = True
        Me.lblPizzaType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaType.Location = New System.Drawing.Point(3, 147)
        Me.lblPizzaType.Name = "lblPizzaType"
        Me.lblPizzaType.Size = New System.Drawing.Size(62, 13)
        Me.lblPizzaType.TabIndex = 2
        Me.lblPizzaType.Text = "Pizza Type:"
        '
        'imgHeader
        '
        Me.imgHeader.Image = CType(resources.GetObject("imgHeader.Image"), System.Drawing.Image)
        Me.imgHeader.Location = New System.Drawing.Point(-4, -11)
        Me.imgHeader.Name = "imgHeader"
        Me.imgHeader.Size = New System.Drawing.Size(549, 143)
        Me.imgHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHeader.TabIndex = 7
        Me.imgHeader.TabStop = False
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(6, 19)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(122, 17)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small Pizza ( 9 inch )"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(6, 42)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(112, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium ( 12 inch )"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(6, 65)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(102, 17)
        Me.radLarge.TabIndex = 2
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large ( 16 inch )"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'grpSizes
        '
        Me.grpSizes.Controls.Add(Me.radLarge)
        Me.grpSizes.Controls.Add(Me.radMedium)
        Me.grpSizes.Controls.Add(Me.radSmall)
        Me.grpSizes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSizes.Location = New System.Drawing.Point(6, 31)
        Me.grpSizes.Name = "grpSizes"
        Me.grpSizes.Size = New System.Drawing.Size(179, 95)
        Me.grpSizes.TabIndex = 0
        Me.grpSizes.TabStop = False
        Me.grpSizes.Text = "Pizza Size"
        '
        'cboPizzaType
        '
        Me.cboPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPizzaType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPizzaType.FormattingEnabled = True
        Me.cboPizzaType.Items.AddRange(New Object() {"Pepperoni", "Ham and Mushroom", "Vegetarian", "Special"})
        Me.cboPizzaType.Location = New System.Drawing.Point(71, 144)
        Me.cboPizzaType.Name = "cboPizzaType"
        Me.cboPizzaType.Size = New System.Drawing.Size(114, 21)
        Me.cboPizzaType.TabIndex = 1
        '
        'chkExtraCheese
        '
        Me.chkExtraCheese.AutoSize = True
        Me.chkExtraCheese.Location = New System.Drawing.Point(7, 20)
        Me.chkExtraCheese.Name = "chkExtraCheese"
        Me.chkExtraCheese.Size = New System.Drawing.Size(89, 17)
        Me.chkExtraCheese.TabIndex = 0
        Me.chkExtraCheese.Text = "Extra Cheese"
        Me.chkExtraCheese.UseVisualStyleBackColor = True
        '
        'chkExtraHam
        '
        Me.chkExtraHam.AutoSize = True
        Me.chkExtraHam.Location = New System.Drawing.Point(7, 44)
        Me.chkExtraHam.Name = "chkExtraHam"
        Me.chkExtraHam.Size = New System.Drawing.Size(75, 17)
        Me.chkExtraHam.TabIndex = 1
        Me.chkExtraHam.Text = "Extra Ham"
        Me.chkExtraHam.UseVisualStyleBackColor = True
        '
        'grpExtraToppings
        '
        Me.grpExtraToppings.Controls.Add(Me.chkExtraHam)
        Me.grpExtraToppings.Controls.Add(Me.chkExtraCheese)
        Me.grpExtraToppings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExtraToppings.Location = New System.Drawing.Point(6, 181)
        Me.grpExtraToppings.Name = "grpExtraToppings"
        Me.grpExtraToppings.Size = New System.Drawing.Size(179, 72)
        Me.grpExtraToppings.TabIndex = 3
        Me.grpExtraToppings.TabStop = False
        Me.grpExtraToppings.Text = "Extra Toppings"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(3, 266)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(92, 13)
        Me.lblAmount.TabIndex = 4
        Me.lblAmount.Text = "Number of Pizzas:"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(102, 263)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(83, 20)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMakePizza
        '
        Me.btnMakePizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakePizza.Location = New System.Drawing.Point(6, 295)
        Me.btnMakePizza.Name = "btnMakePizza"
        Me.btnMakePizza.Size = New System.Drawing.Size(179, 37)
        Me.btnMakePizza.TabIndex = 6
        Me.btnMakePizza.Text = "Make Pizza!"
        Me.btnMakePizza.UseVisualStyleBackColor = True
        '
        'grpOrderDetails
        '
        Me.grpOrderDetails.BackColor = System.Drawing.SystemColors.Control
        Me.grpOrderDetails.Controls.Add(Me.grpSizes)
        Me.grpOrderDetails.Controls.Add(Me.cboPizzaType)
        Me.grpOrderDetails.Controls.Add(Me.btnMakePizza)
        Me.grpOrderDetails.Controls.Add(Me.lblPizzaType)
        Me.grpOrderDetails.Controls.Add(Me.txtAmount)
        Me.grpOrderDetails.Controls.Add(Me.grpExtraToppings)
        Me.grpOrderDetails.Controls.Add(Me.lblAmount)
        Me.grpOrderDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOrderDetails.Location = New System.Drawing.Point(12, 138)
        Me.grpOrderDetails.Name = "grpOrderDetails"
        Me.grpOrderDetails.Size = New System.Drawing.Size(192, 340)
        Me.grpOrderDetails.TabIndex = 8
        Me.grpOrderDetails.TabStop = False
        Me.grpOrderDetails.Text = "Order Details"
        '
        'grpControls
        '
        Me.grpControls.BackColor = System.Drawing.SystemColors.Control
        Me.grpControls.Controls.Add(Me.Label2)
        Me.grpControls.Controls.Add(Me.Label1)
        Me.grpControls.Controls.Add(Me.lblAddNewPizza)
        Me.grpControls.Controls.Add(Me.btnNewOrder)
        Me.grpControls.Controls.Add(Me.btnPrint)
        Me.grpControls.Controls.Add(Me.btnAddNewPizza)
        Me.grpControls.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpControls.Location = New System.Drawing.Point(210, 140)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(118, 338)
        Me.grpControls.TabIndex = 9
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "Controls"
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewOrder.Location = New System.Drawing.Point(15, 138)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(89, 21)
        Me.btnNewOrder.TabIndex = 2
        Me.btnNewOrder.Text = "New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(15, 91)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 21)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnAddNewPizza
        '
        Me.btnAddNewPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewPizza.Location = New System.Drawing.Point(15, 45)
        Me.btnAddNewPizza.Name = "btnAddNewPizza"
        Me.btnAddNewPizza.Size = New System.Drawing.Size(89, 21)
        Me.btnAddNewPizza.TabIndex = 0
        Me.btnAddNewPizza.Text = "Add"
        Me.btnAddNewPizza.UseVisualStyleBackColor = True
        '
        'grpReceipt
        '
        Me.grpReceipt.BackColor = System.Drawing.SystemColors.Control
        Me.grpReceipt.Controls.Add(Me.pnlReceipt)
        Me.grpReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReceipt.Location = New System.Drawing.Point(334, 138)
        Me.grpReceipt.Name = "grpReceipt"
        Me.grpReceipt.Size = New System.Drawing.Size(192, 340)
        Me.grpReceipt.TabIndex = 9
        Me.grpReceipt.TabStop = False
        Me.grpReceipt.Text = "Receipt"
        '
        'pnlReceipt
        '
        Me.pnlReceipt.AutoScroll = True
        Me.pnlReceipt.Controls.Add(Me.lblReceipt)
        Me.pnlReceipt.Location = New System.Drawing.Point(6, 22)
        Me.pnlReceipt.Name = "pnlReceipt"
        Me.pnlReceipt.Size = New System.Drawing.Size(180, 310)
        Me.pnlReceipt.TabIndex = 0
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = True
        Me.lblReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceipt.Location = New System.Drawing.Point(0, 9)
        Me.lblReceipt.MaximumSize = New System.Drawing.Size(160, 0)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(0, 13)
        Me.lblReceipt.TabIndex = 0
        '
        'lblAddNewPizza
        '
        Me.lblAddNewPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddNewPizza.Location = New System.Drawing.Point(15, 29)
        Me.lblAddNewPizza.Name = "lblAddNewPizza"
        Me.lblAddNewPizza.Size = New System.Drawing.Size(89, 13)
        Me.lblAddNewPizza.TabIndex = 3
        Me.lblAddNewPizza.Text = "Add a new pizza"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Print receipt"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Create new order"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(538, 490)
        Me.Controls.Add(Me.grpReceipt)
        Me.Controls.Add(Me.grpControls)
        Me.Controls.Add(Me.grpOrderDetails)
        Me.Controls.Add(Me.imgHeader)
        Me.Name = "Form1"
        Me.Text = "La Mia Pizzaria"
        CType(Me.imgHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSizes.ResumeLayout(False)
        Me.grpSizes.PerformLayout()
        Me.grpExtraToppings.ResumeLayout(False)
        Me.grpExtraToppings.PerformLayout()
        Me.grpOrderDetails.ResumeLayout(False)
        Me.grpOrderDetails.PerformLayout()
        Me.grpControls.ResumeLayout(False)
        Me.grpReceipt.ResumeLayout(False)
        Me.pnlReceipt.ResumeLayout(False)
        Me.pnlReceipt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPizzaType As Label
    Friend WithEvents imgHeader As PictureBox
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents grpSizes As GroupBox
    Friend WithEvents cboPizzaType As ComboBox
    Friend WithEvents chkExtraCheese As CheckBox
    Friend WithEvents chkExtraHam As CheckBox
    Friend WithEvents grpExtraToppings As GroupBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnMakePizza As Button
    Friend WithEvents grpOrderDetails As GroupBox
    Friend WithEvents grpControls As GroupBox
    Friend WithEvents grpReceipt As GroupBox
    Friend WithEvents pnlReceipt As Panel
    Friend WithEvents lblReceipt As Label
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnAddNewPizza As Button
    Friend WithEvents lblAddNewPizza As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
