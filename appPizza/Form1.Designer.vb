<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grpSizes = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.comboPizzaType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbExtraHam = New System.Windows.Forms.CheckBox()
        Me.tbExtraCheese = New System.Windows.Forms.CheckBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnMakePizza = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpSizes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSizes
        '
        Me.grpSizes.Controls.Add(Me.radLarge)
        Me.grpSizes.Controls.Add(Me.radMedium)
        Me.grpSizes.Controls.Add(Me.radSmall)
        Me.grpSizes.Location = New System.Drawing.Point(12, 110)
        Me.grpSizes.Name = "grpSizes"
        Me.grpSizes.Size = New System.Drawing.Size(179, 95)
        Me.grpSizes.TabIndex = 0
        Me.grpSizes.TabStop = False
        Me.grpSizes.Text = "Pizza Size"
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
        'comboPizzaType
        '
        Me.comboPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPizzaType.FormattingEnabled = True
        Me.comboPizzaType.Items.AddRange(New Object() {"Pepperoni", "Ham and Mushroom", "Vegetarian", "Special"})
        Me.comboPizzaType.Location = New System.Drawing.Point(77, 223)
        Me.comboPizzaType.Name = "comboPizzaType"
        Me.comboPizzaType.Size = New System.Drawing.Size(114, 21)
        Me.comboPizzaType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pizza Type:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbExtraHam)
        Me.GroupBox1.Controls.Add(Me.tbExtraCheese)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 72)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Extra Toppings"
        '
        'tbExtraHam
        '
        Me.tbExtraHam.AutoSize = True
        Me.tbExtraHam.Location = New System.Drawing.Point(7, 44)
        Me.tbExtraHam.Name = "tbExtraHam"
        Me.tbExtraHam.Size = New System.Drawing.Size(75, 17)
        Me.tbExtraHam.TabIndex = 1
        Me.tbExtraHam.Text = "Extra Ham"
        Me.tbExtraHam.UseVisualStyleBackColor = True
        '
        'tbExtraCheese
        '
        Me.tbExtraCheese.AutoSize = True
        Me.tbExtraCheese.Location = New System.Drawing.Point(7, 20)
        Me.tbExtraCheese.Name = "tbExtraCheese"
        Me.tbExtraCheese.Size = New System.Drawing.Size(89, 17)
        Me.tbExtraCheese.TabIndex = 0
        Me.tbExtraCheese.Text = "Extra Cheese"
        Me.tbExtraCheese.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(9, 345)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(92, 13)
        Me.lblAmount.TabIndex = 4
        Me.lblAmount.Text = "Number of Pizzas:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(108, 342)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(83, 20)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMakePizza
        '
        Me.btnMakePizza.Enabled = False
        Me.btnMakePizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakePizza.Location = New System.Drawing.Point(12, 374)
        Me.btnMakePizza.Name = "btnMakePizza"
        Me.btnMakePizza.Size = New System.Drawing.Size(179, 37)
        Me.btnMakePizza.TabIndex = 6
        Me.btnMakePizza.Text = "Make Pizza!"
        Me.btnMakePizza.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rage Italic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(340, 61)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "La Mia Pizzeria"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 423)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnMakePizza)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboPizzaType)
        Me.Controls.Add(Me.grpSizes)
        Me.Name = "Form1"
        Me.Text = "La Mia Pizzaria"
        Me.grpSizes.ResumeLayout(False)
        Me.grpSizes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSizes As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents comboPizzaType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbExtraHam As CheckBox
    Friend WithEvents tbExtraCheese As CheckBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnMakePizza As Button
    Friend WithEvents Label2 As Label
End Class
