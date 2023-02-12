Public Class Form1

    Public Shared fullNam As String
    Public dob As Date
    Public ageOf As Byte
    Public gender As String
    Public blood As Char
    Public rhFactor As String
    Public email As String
    Public mobile As Long
    Public address As String
    Public yearOfPass, y2, y3 As Date
    Public board, b2, b3 As String
    Public percentage, p2, p3 As Double
    Public educ, educ1, educ2 As String
    Public s1, s2, s3, s4, s5, s6 As String
    Public l1, l2, l3 As String


    Private Sub NameOfUser_TextChanged(sender As Object, e As EventArgs) Handles fullName.TextChanged
        fullNam = fullName.Text
    End Sub

    Private Sub dateOfBirth_ValueChanged(sender As Object, e As EventArgs) Handles dateOfBirth.ValueChanged
        If dateOfBirth.Value.Date = DateTime.Today Then
            MessageBox.Show("Enter valid date")
        Else
            dob = dateOfBirth.Value
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub build_Click(sender As Object, e As EventArgs) Handles build.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub age_TextChanged(sender As Object, e As EventArgs) Handles age.TextChanged
        ageOf = age.Text
    End Sub

    Private Sub male_CheckedChanged(sender As Object, e As EventArgs) Handles male.CheckedChanged
        gender = male.Text
    End Sub

    Private Sub female_CheckedChanged(sender As Object, e As EventArgs) Handles female.CheckedChanged
        gender = female.Text
    End Sub

    Private Sub tenthPassDate_ValueChanged(sender As Object, e As EventArgs) Handles tenthPassDate.ValueChanged
        yearOfPass = tenthPassDate.Value
    End Sub

    Private Sub tenthGrade_TextChanged(sender As Object, e As EventArgs) Handles tenthGrade.TextChanged
        percentage = tenthGrade.Text
    End Sub

    Private Sub diploma_CheckedChanged(sender As Object, e As EventArgs) Handles diploma.CheckedChanged
        educ1 = diploma.Text
    End Sub

    Private Sub twelBoard_TextChanged(sender As Object, e As EventArgs) Handles twelBoard.TextChanged
        b2 = twelBoard.Text
    End Sub

    Private Sub dipDate_ValueChanged(sender As Object, e As EventArgs) Handles dipDate.ValueChanged
        y2 = dipDate.Value 
    End Sub

    Private Sub dipGrade_TextChanged(sender As Object, e As EventArgs) Handles dipGrade.TextChanged
        p2 = dipGrade.Text
    End Sub

    Private Sub cpp_CheckedChanged(sender As Object, e As EventArgs) Handles cpp.CheckedChanged
        s2 = cpp.Text
    End Sub

    Private Sub java_CheckedChanged(sender As Object, e As EventArgs) Handles java.CheckedChanged
        s3 = java.Text
    End Sub

    Private Sub frontEnd_CheckedChanged(sender As Object, e As EventArgs) Handles frontEnd.CheckedChanged
        s4 = frontEnd.Text
    End Sub

    Private Sub backEnd_CheckedChanged(sender As Object, e As EventArgs) Handles backEnd.CheckedChanged
        s5 = backEnd.Text
    End Sub

    Private Sub hindi_CheckedChanged(sender As Object, e As EventArgs) Handles hindi.CheckedChanged
        l2 = hindi.Text
    End Sub

    Private Sub urdu_CheckedChanged(sender As Object, e As EventArgs) Handles urdu.CheckedChanged
        l3 = urdu.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Form1

    End Sub

    Private Sub python_CheckedChanged(sender As Object, e As EventArgs) Handles python.CheckedChanged
        s6 = python.Text
    End Sub

    Private Sub english_CheckedChanged(sender As Object, e As EventArgs) Handles english.CheckedChanged
        l1 = english.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        educ2 = CheckBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        b3 = TextBox2.Text
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        y3 = DateTimePicker1.Value
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        p3 = TextBox1.Text
    End Sub

    Private Sub c_CheckedChanged(sender As Object, e As EventArgs) Handles c.CheckedChanged
        s1 = c.Text
    End Sub

    Private Sub BloodG_TextChanged(sender As Object, e As EventArgs) Handles BloodG.TextChanged
        blood = BloodG.Text
    End Sub

    Private Sub pos_CheckedChanged(sender As Object, e As EventArgs) Handles pos.CheckedChanged
        rhFactor = pos.Text
    End Sub

    Private Sub neg_CheckedChanged(sender As Object, e As EventArgs) Handles neg.CheckedChanged
        rhFactor = neg.Text
    End Sub

    Private Sub emailAdd_TextChanged(sender As Object, e As EventArgs) Handles emailAdd.TextChanged
        email = emailAdd.Text
    End Sub

    Private Sub mobNo_TextChanged(sender As Object, e As EventArgs) Handles mobNo.TextChanged
        mobile = mobNo.Text
    End Sub

    Private Sub AddressCurrentAdd_TextChanged(sender As Object, e As EventArgs) Handles AddressCurrent.TextChanged
        address = AddressCurrent.Text
    End Sub

    Private Sub tenth_CheckedChanged(sender As Object, e As EventArgs) Handles tenth.CheckedChanged
        educ = tenth.Text

    End Sub

    Private Sub tenthBoards_TextChanged(sender As Object, e As EventArgs) Handles tenthBoards.TextChanged
        board = tenthBoards.Text
    End Sub

End Class
