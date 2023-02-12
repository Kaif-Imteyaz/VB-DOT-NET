Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Form1.fullNam

        Label10.Text = Form1.mobile

        Label42.Text = Form1.email

        Label3.Text = Form1.ageOf

        Label8.Text = Form1.dob

        Label6.Text = Form1.gender

        Label5.Text = Form1.blood

        Label43.Text = Form1.rhFactor

        Label15.Text = Form1.l1
        Label16.Text = Form1.l2
        Label17.Text = Form1.l3

        Label23.Text = Form1.educ
        Label24.Text = Form1.board
        Label25.Text = Form1.yearOfPass
        Label26.Text = Form1.percentage

        Label27.Text = Form1.educ1
        Label28.Text = Form1.b2
        Label29.Text = Form1.y2
        Label30.Text = Form1.p2

        Label38.Text = Form1.educ2
        Label39.Text = Form1.b3
        Label40.Text = Form1.y3
        Label41.Text = Form1.p3

        Label32.Text = Form1.s1
        Label33.Text = Form1.s2
        Label34.Text = Form1.s3
        Label35.Text = Form1.s4
        Label36.Text = Form1.s5
        Label37.Text = Form1.s6



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub
End Class