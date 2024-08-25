<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculator))
        txtResult = New TextBox()
        Button1 = New Button()
        btnAc = New Button()
        btnSquareRoot = New Button()
        btnPercent = New Button()
        btnDivide = New Button()
        btnMultiply = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btnSubtract = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btnAdd = New Button()
        btn3 = New Button()
        btn2 = New Button()
        btn1 = New Button()
        btnEqual = New Button()
        btnPoint = New Button()
        lblFNum = New Label()
        lblSign = New Label()
        SuspendLayout()
        ' 
        ' txtResult
        ' 
        txtResult.BackColor = SystemColors.ActiveCaptionText
        txtResult.BorderStyle = BorderStyle.None
        txtResult.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtResult.ForeColor = SystemColors.Info
        txtResult.Location = New Point(32, 55)
        txtResult.Multiline = True
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(318, 92)
        txtResult.TabIndex = 0
        txtResult.TextAlign = HorizontalAlignment.Right
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(32, 457)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 62)
        Button1.TabIndex = 20
        Button1.Text = "0"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnAc
        ' 
        btnAc.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnAc.FlatAppearance.BorderSize = 0
        btnAc.FlatStyle = FlatStyle.Flat
        btnAc.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnAc.Location = New Point(32, 185)
        btnAc.Name = "btnAc"
        btnAc.Size = New Size(75, 62)
        btnAc.TabIndex = 21
        btnAc.Text = "AC"
        btnAc.UseVisualStyleBackColor = False
        ' 
        ' btnSquareRoot
        ' 
        btnSquareRoot.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnSquareRoot.FlatAppearance.BorderSize = 0
        btnSquareRoot.FlatStyle = FlatStyle.Flat
        btnSquareRoot.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnSquareRoot.Location = New Point(113, 185)
        btnSquareRoot.Name = "btnSquareRoot"
        btnSquareRoot.Size = New Size(75, 62)
        btnSquareRoot.TabIndex = 22
        btnSquareRoot.Text = "√"
        btnSquareRoot.UseVisualStyleBackColor = False
        ' 
        ' btnPercent
        ' 
        btnPercent.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnPercent.FlatAppearance.BorderSize = 0
        btnPercent.FlatStyle = FlatStyle.Flat
        btnPercent.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnPercent.Location = New Point(194, 185)
        btnPercent.Name = "btnPercent"
        btnPercent.Size = New Size(75, 62)
        btnPercent.TabIndex = 23
        btnPercent.Text = "%"
        btnPercent.UseVisualStyleBackColor = False
        ' 
        ' btnDivide
        ' 
        btnDivide.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnDivide.BackgroundImage = My.Resources.Resources.color
        btnDivide.FlatAppearance.BorderSize = 0
        btnDivide.FlatStyle = FlatStyle.Flat
        btnDivide.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnDivide.ForeColor = SystemColors.ButtonHighlight
        btnDivide.Location = New Point(275, 185)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(75, 62)
        btnDivide.TabIndex = 24
        btnDivide.Text = "÷"
        btnDivide.UseVisualStyleBackColor = False
        ' 
        ' btnMultiply
        ' 
        btnMultiply.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnMultiply.BackgroundImage = My.Resources.Resources.color
        btnMultiply.FlatAppearance.BorderSize = 0
        btnMultiply.FlatStyle = FlatStyle.Flat
        btnMultiply.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnMultiply.ForeColor = SystemColors.ButtonHighlight
        btnMultiply.Location = New Point(275, 253)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(75, 62)
        btnMultiply.TabIndex = 28
        btnMultiply.Text = "x"
        btnMultiply.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn9.FlatAppearance.BorderSize = 0
        btn9.FlatStyle = FlatStyle.Flat
        btn9.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn9.ForeColor = SystemColors.ButtonHighlight
        btn9.Location = New Point(194, 253)
        btn9.Name = "btn9"
        btn9.Size = New Size(75, 62)
        btn9.TabIndex = 27
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn8.FlatAppearance.BorderSize = 0
        btn8.FlatStyle = FlatStyle.Flat
        btn8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn8.ForeColor = SystemColors.ButtonHighlight
        btn8.Location = New Point(113, 253)
        btn8.Name = "btn8"
        btn8.Size = New Size(75, 62)
        btn8.TabIndex = 26
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn7.FlatAppearance.BorderSize = 0
        btn7.FlatStyle = FlatStyle.Flat
        btn7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn7.ForeColor = SystemColors.ButtonHighlight
        btn7.Location = New Point(32, 253)
        btn7.Name = "btn7"
        btn7.Size = New Size(75, 62)
        btn7.TabIndex = 25
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btnSubtract
        ' 
        btnSubtract.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnSubtract.BackgroundImage = My.Resources.Resources.color
        btnSubtract.FlatAppearance.BorderSize = 0
        btnSubtract.FlatStyle = FlatStyle.Flat
        btnSubtract.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnSubtract.ForeColor = SystemColors.ButtonHighlight
        btnSubtract.Location = New Point(275, 321)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(75, 62)
        btnSubtract.TabIndex = 32
        btnSubtract.Text = "-"
        btnSubtract.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn6.FlatAppearance.BorderSize = 0
        btn6.FlatStyle = FlatStyle.Flat
        btn6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn6.ForeColor = SystemColors.ButtonHighlight
        btn6.Location = New Point(194, 321)
        btn6.Name = "btn6"
        btn6.Size = New Size(75, 62)
        btn6.TabIndex = 31
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn5.FlatAppearance.BorderSize = 0
        btn5.FlatStyle = FlatStyle.Flat
        btn5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn5.ForeColor = SystemColors.ButtonHighlight
        btn5.Location = New Point(113, 321)
        btn5.Name = "btn5"
        btn5.Size = New Size(75, 62)
        btn5.TabIndex = 30
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn4.FlatAppearance.BorderSize = 0
        btn4.FlatStyle = FlatStyle.Flat
        btn4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn4.ForeColor = SystemColors.ButtonHighlight
        btn4.Location = New Point(32, 321)
        btn4.Name = "btn4"
        btn4.Size = New Size(75, 62)
        btn4.TabIndex = 29
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnAdd.BackgroundImage = My.Resources.Resources.color
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnAdd.ForeColor = SystemColors.ButtonHighlight
        btnAdd.Location = New Point(275, 389)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 62)
        btnAdd.TabIndex = 36
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn3.FlatAppearance.BorderSize = 0
        btn3.FlatStyle = FlatStyle.Flat
        btn3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn3.ForeColor = SystemColors.ButtonHighlight
        btn3.Location = New Point(194, 389)
        btn3.Name = "btn3"
        btn3.Size = New Size(75, 62)
        btn3.TabIndex = 35
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn2.FlatAppearance.BorderSize = 0
        btn2.FlatStyle = FlatStyle.Flat
        btn2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn2.ForeColor = SystemColors.ButtonHighlight
        btn2.Location = New Point(113, 389)
        btn2.Name = "btn2"
        btn2.Size = New Size(75, 62)
        btn2.TabIndex = 34
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn1.FlatAppearance.BorderSize = 0
        btn1.FlatStyle = FlatStyle.Flat
        btn1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn1.ForeColor = SystemColors.ButtonHighlight
        btn1.Location = New Point(32, 389)
        btn1.Name = "btn1"
        btn1.Size = New Size(75, 62)
        btn1.TabIndex = 33
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btnEqual
        ' 
        btnEqual.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnEqual.BackgroundImage = My.Resources.Resources.color
        btnEqual.FlatAppearance.BorderSize = 0
        btnEqual.FlatStyle = FlatStyle.Flat
        btnEqual.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnEqual.ForeColor = SystemColors.ButtonHighlight
        btnEqual.Location = New Point(275, 457)
        btnEqual.Name = "btnEqual"
        btnEqual.Size = New Size(75, 62)
        btnEqual.TabIndex = 38
        btnEqual.Text = "="
        btnEqual.UseVisualStyleBackColor = False
        ' 
        ' btnPoint
        ' 
        btnPoint.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnPoint.FlatAppearance.BorderSize = 0
        btnPoint.FlatStyle = FlatStyle.Flat
        btnPoint.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnPoint.ForeColor = SystemColors.ButtonHighlight
        btnPoint.Location = New Point(194, 457)
        btnPoint.Name = "btnPoint"
        btnPoint.Size = New Size(75, 62)
        btnPoint.TabIndex = 37
        btnPoint.Text = "."
        btnPoint.UseVisualStyleBackColor = False
        ' 
        ' lblFNum
        ' 
        lblFNum.AutoSize = True
        lblFNum.BackColor = SystemColors.ActiveCaptionText
        lblFNum.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lblFNum.ForeColor = SystemColors.ButtonHighlight
        lblFNum.Location = New Point(279, 157)
        lblFNum.Name = "lblFNum"
        lblFNum.Size = New Size(0, 20)
        lblFNum.TabIndex = 39
        lblFNum.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblSign
        ' 
        lblSign.AutoSize = True
        lblSign.BackColor = SystemColors.ActiveCaptionText
        lblSign.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lblSign.ForeColor = SystemColors.ButtonHighlight
        lblSign.Location = New Point(356, 89)
        lblSign.Name = "lblSign"
        lblSign.Size = New Size(0, 20)
        lblSign.TabIndex = 40
        ' 
        ' frmCalculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(380, 557)
        Controls.Add(lblSign)
        Controls.Add(lblFNum)
        Controls.Add(btnEqual)
        Controls.Add(btnPoint)
        Controls.Add(btnAdd)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btnSubtract)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btnMultiply)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btnDivide)
        Controls.Add(btnPercent)
        Controls.Add(btnSquareRoot)
        Controls.Add(btnAc)
        Controls.Add(Button1)
        Controls.Add(txtResult)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmCalculator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtResult As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAc As Button
    Friend WithEvents btnSquareRoot As Button
    Friend WithEvents btnPercent As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents btnPoint As Button
    Friend WithEvents lblFNum As Label
    Friend WithEvents lblSign As Label

End Class
