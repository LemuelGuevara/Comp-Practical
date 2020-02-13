Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim array(3) As String
        array(0) = "Harry Potter"
        array(1) = "Florante at Laura"
        array(2) = "Visual Basic Programming"
        array(3) = "Noli Me Tangere"

        If ComboBox1.SelectedIndex = 0 Then
            For Each book As String In array
                ListBox1.Items.Add(book)
            Next

        ElseIf ComboBox1.SelectedIndex = 1 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add(array(0))

        ElseIf ComboBox1.SelectedIndex = 2 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add(array(2))

        ElseIf ComboBox1.SelectedIndex = 3 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add(array(1))
            ListBox1.Items.Add(array(3))
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
    End Sub
End Class
