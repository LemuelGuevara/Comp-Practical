Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ListBox1.Items.Add("Harry Potter")
            ListBox1.Items.Add("Florante at Laura")
            ListBox1.Items.Add("Visual Basic Programming")
            ListBox1.Items.Add("Noli Me Tangere")

        ElseIf ComboBox1.SelectedIndex = 1 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Harry Potter")

        ElseIf ComboBox1.SelectedIndex = 2 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Visual Basic Programming")

        ElseIf ComboBox1.SelectedIndex = 3 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Florante at Laura")
            ListBox1.Items.Add("Noli Me Tangere")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
    End Sub
End Class
