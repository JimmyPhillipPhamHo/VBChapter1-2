Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        lblName.Visible = True
        lblStreet.Visible = True
        lblCityStateZip.Visible = True
    End Sub
End Class
