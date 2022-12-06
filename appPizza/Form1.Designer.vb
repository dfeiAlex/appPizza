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
        Me.btnAddPizza = New System.Windows.Forms.Button()
        Me.grpOrderDetails = New System.Windows.Forms.GroupBox()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.lblCreateNewOrder = New System.Windows.Forms.Label()
        Me.lblPrintReceipt = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpReceipt = New System.Windows.Forms.GroupBox()
        Me.grpTotal = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalText = New System.Windows.Forms.Label()
        Me.pnlReceipt = New System.Windows.Forms.Panel()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.prtReceipt = New System.Drawing.Printing.PrintDocument()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.imgHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSizes.SuspendLayout()
        Me.grpExtraToppings.SuspendLayout()
        Me.grpOrderDetails.SuspendLayout()
        Me.grpControls.SuspendLayout()
        Me.grpReceipt.SuspendLayout()
        Me.grpTotal.SuspendLayout()
        Me.pnlReceipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPizzaType
        '
        Me.lblPizzaType.AutoSize = True
        Me.lblPizzaType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaType.Location = New System.Drawing.Point(3, 31)
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
        Me.imgHeader.Size = New System.Drawing.Size(597, 160)
        Me.imgHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHeader.TabIndex = 7
        Me.imgHeader.TabStop = False
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(6, 19)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(50, 17)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(6, 42)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(62, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(6, 65)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(52, 17)
        Me.radLarge.TabIndex = 2
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'grpSizes
        '
        Me.grpSizes.Controls.Add(Me.radLarge)
        Me.grpSizes.Controls.Add(Me.radMedium)
        Me.grpSizes.Controls.Add(Me.radSmall)
        Me.grpSizes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSizes.Location = New System.Drawing.Point(6, 66)
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
        Me.cboPizzaType.Location = New System.Drawing.Point(71, 28)
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
        Me.lblAmount.Size = New System.Drawing.Size(128, 13)
        Me.lblAmount.TabIndex = 4
        Me.lblAmount.Text = "Number of Pizzas (1 - 10):"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(137, 263)
        Me.txtAmount.MaxLength = 2
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(48, 20)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddPizza
        '
        Me.btnAddPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPizza.Location = New System.Drawing.Point(6, 295)
        Me.btnAddPizza.Name = "btnAddPizza"
        Me.btnAddPizza.Size = New System.Drawing.Size(179, 37)
        Me.btnAddPizza.TabIndex = 6
        Me.btnAddPizza.Text = "Add Pizza!"
        Me.btnAddPizza.UseVisualStyleBackColor = True
        '
        'grpOrderDetails
        '
        Me.grpOrderDetails.BackColor = System.Drawing.SystemColors.Control
        Me.grpOrderDetails.Controls.Add(Me.grpSizes)
        Me.grpOrderDetails.Controls.Add(Me.cboPizzaType)
        Me.grpOrderDetails.Controls.Add(Me.btnAddPizza)
        Me.grpOrderDetails.Controls.Add(Me.lblPizzaType)
        Me.grpOrderDetails.Controls.Add(Me.txtAmount)
        Me.grpOrderDetails.Controls.Add(Me.grpExtraToppings)
        Me.grpOrderDetails.Controls.Add(Me.lblAmount)
        Me.grpOrderDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOrderDetails.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpOrderDetails.Location = New System.Drawing.Point(12, 153)
        Me.grpOrderDetails.Name = "grpOrderDetails"
        Me.grpOrderDetails.Size = New System.Drawing.Size(192, 340)
        Me.grpOrderDetails.TabIndex = 8
        Me.grpOrderDetails.TabStop = False
        Me.grpOrderDetails.Text = "Order Details"
        '
        'grpControls
        '
        Me.grpControls.BackColor = System.Drawing.SystemColors.Control
        Me.grpControls.Controls.Add(Me.btnPrint)
        Me.grpControls.Controls.Add(Me.lblCreateNewOrder)
        Me.grpControls.Controls.Add(Me.lblPrintReceipt)
        Me.grpControls.Controls.Add(Me.lblAdd)
        Me.grpControls.Controls.Add(Me.btnNewOrder)
        Me.grpControls.Controls.Add(Me.btnAdd)
        Me.grpControls.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpControls.Location = New System.Drawing.Point(210, 155)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(118, 338)
        Me.grpControls.TabIndex = 9
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "Controls"
        '
        'lblCreateNewOrder
        '
        Me.lblCreateNewOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateNewOrder.Location = New System.Drawing.Point(15, 122)
        Me.lblCreateNewOrder.Name = "lblCreateNewOrder"
        Me.lblCreateNewOrder.Size = New System.Drawing.Size(89, 13)
        Me.lblCreateNewOrder.TabIndex = 5
        Me.lblCreateNewOrder.Text = "Create new order"
        Me.lblCreateNewOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPrintReceipt
        '
        Me.lblPrintReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintReceipt.Location = New System.Drawing.Point(15, 75)
        Me.lblPrintReceipt.Name = "lblPrintReceipt"
        Me.lblPrintReceipt.Size = New System.Drawing.Size(89, 13)
        Me.lblPrintReceipt.TabIndex = 4
        Me.lblPrintReceipt.Text = "Print receipt"
        Me.lblPrintReceipt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAdd
        '
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(15, 29)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(89, 13)
        Me.lblAdd.TabIndex = 3
        Me.lblAdd.Text = "Add a new pizza"
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
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(15, 45)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 21)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpReceipt
        '
        Me.grpReceipt.BackColor = System.Drawing.SystemColors.Control
        Me.grpReceipt.Controls.Add(Me.grpTotal)
        Me.grpReceipt.Controls.Add(Me.pnlReceipt)
        Me.grpReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReceipt.Location = New System.Drawing.Point(334, 153)
        Me.grpReceipt.Name = "grpReceipt"
        Me.grpReceipt.Size = New System.Drawing.Size(243, 340)
        Me.grpReceipt.TabIndex = 9
        Me.grpReceipt.TabStop = False
        Me.grpReceipt.Text = "Receipt"
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.lblTotal)
        Me.grpTotal.Controls.Add(Me.lblTotalText)
        Me.grpTotal.Location = New System.Drawing.Point(6, 289)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(231, 43)
        Me.grpTotal.TabIndex = 1
        Me.grpTotal.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotal.Location = New System.Drawing.Point(97, 17)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(128, 17)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "€ 0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalText
        '
        Me.lblTotalText.AutoSize = True
        Me.lblTotalText.Location = New System.Drawing.Point(6, 17)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(44, 17)
        Me.lblTotalText.TabIndex = 0
        Me.lblTotalText.Text = "Total:"
        '
        'pnlReceipt
        '
        Me.pnlReceipt.AutoScroll = True
        Me.pnlReceipt.Controls.Add(Me.lblReceipt)
        Me.pnlReceipt.Location = New System.Drawing.Point(6, 22)
        Me.pnlReceipt.Name = "pnlReceipt"
        Me.pnlReceipt.Size = New System.Drawing.Size(231, 261)
        Me.pnlReceipt.TabIndex = 0
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = True
        Me.lblReceipt.BackColor = System.Drawing.SystemColors.Control
        Me.lblReceipt.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceipt.Location = New System.Drawing.Point(0, 9)
        Me.lblReceipt.MaximumSize = New System.Drawing.Size(211, 0)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(0, 13)
        Me.lblReceipt.TabIndex = 0
        '
        'prtReceipt
        '
        Me.prtReceipt.DocumentName = "Receipt"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(15, 91)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 21)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(589, 507)
        Me.Controls.Add(Me.grpReceipt)
        Me.Controls.Add(Me.grpControls)
        Me.Controls.Add(Me.grpOrderDetails)
        Me.Controls.Add(Me.imgHeader)
        Me.MaximumSize = New System.Drawing.Size(605, 546)
        Me.MinimumSize = New System.Drawing.Size(605, 546)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "La Mia Pizzeria"
        CType(Me.imgHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSizes.ResumeLayout(False)
        Me.grpSizes.PerformLayout()
        Me.grpExtraToppings.ResumeLayout(False)
        Me.grpExtraToppings.PerformLayout()
        Me.grpOrderDetails.ResumeLayout(False)
        Me.grpOrderDetails.PerformLayout()
        Me.grpControls.ResumeLayout(False)
        Me.grpReceipt.ResumeLayout(False)
        Me.grpTotal.ResumeLayout(False)
        Me.grpTotal.PerformLayout()
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
    Friend WithEvents btnAddPizza As Button
    Friend WithEvents grpOrderDetails As GroupBox
    Friend WithEvents grpControls As GroupBox
    Friend WithEvents grpReceipt As GroupBox
    Friend WithEvents pnlReceipt As Panel
    Friend WithEvents lblReceipt As Label
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblCreateNewOrder As Label
    Friend WithEvents lblPrintReceipt As Label
    Friend WithEvents grpTotal As GroupBox
    Friend WithEvents lblTotalText As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents prtReceipt As Printing.PrintDocument
End Class
