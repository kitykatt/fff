Public Class Form1
    Dim usd As Decimal
    Dim euro As Decimal = 0.861
    Dim pesos As Decimal = 20.34
    Dim rupies As Decimal = 74.785
    Dim yen As Decimal = 113.537
    Dim pound As Decimal = 0.724
    Dim canida As Decimal = 1.235
    Dim etimer As Decimal
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Decimal.TryParse(TextBox1.Text, usd)
        If usd = 0 Then
            Label7.Visible = True
            etimer = 5000
        End If
        Label1.Text = euro * usd
        Label2.Text = pesos * usd
        Label3.Text = rupies * usd
        Label4.Text = yen * usd
        Label5.Text = pound * usd
        Label6.Text = canida * usd
        etimer = etimer - 1000
        If etimer = 0 Then
            Label7.Visible = False
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
    End Sub
End Class
