Public Class frmCalculator
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtResult.Text = txtResult.Text + "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtResult.Text = txtResult.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtResult.Text = txtResult.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtResult.Text = txtResult.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtResult.Text = txtResult.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtResult.Text = txtResult.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtResult.Text = txtResult.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtResult.Text = txtResult.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtResult.Text = txtResult.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtResult.Text = txtResult.Text + "9"
    End Sub
    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        txtResult.Text = txtResult.Text + "."
    End Sub
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        lblFNum.Text = txtResult.Text
        lblSign.Text = "÷"
        txtResult.Text = ""
    End Sub
    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        lblFNum.Text = txtResult.Text
        lblSign.Text = "x"
        txtResult.Text = ""
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        lblFNum.Text = txtResult.Text
        lblSign.Text = "-"
        txtResult.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblFNum.Text = txtResult.Text
        lblSign.Text = "+"
        txtResult.Text = ""
    End Sub
    Private Sub btnPercent_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        lblFNum.Text = txtResult.Text
        lblSign.Text = "%"
        txtResult.Text = ""
    End Sub
    Private Sub btnAc_Click(sender As Object, e As EventArgs) Handles btnAc.Click
        lblFNum.Text = ""
        lblSign.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If lblSign.Text = "÷" Then
            txtResult.Text = Val(lblFNum.Text) / Val(txtResult.Text)
            lblFNum.Text = ""
            lblSign.Text = ""
        End If

        If lblSign.Text = "x" Then
            txtResult.Text = Val(lblFNum.Text) * Val(txtResult.Text)
            lblFNum.Text = ""
            lblSign.Text = ""
        End If

        If lblSign.Text = "-" Then
            txtResult.Text = Val(lblFNum.Text) - Val(txtResult.Text)
            lblFNum.Text = ""
            lblSign.Text = ""
        End If

        If lblSign.Text = "+" Then
            txtResult.Text = Val(lblFNum.Text) + Val(txtResult.Text)
            lblFNum.Text = ""
            lblSign.Text = ""
        End If

        If lblSign.Text = "%" Then
            txtResult.Text = Val(lblFNum.Text) / 100 * Val(txtResult.Text)
            lblFNum.Text = ""
            lblSign.Text = ""
        End If
    End Sub


End Class
