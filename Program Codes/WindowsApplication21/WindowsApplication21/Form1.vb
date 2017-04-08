Public Class frmActivity2

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Num As Integer
        Num = GetNum(Num)
        'Calling the procedure'
    End Sub
    Public Function GetNum(ByVal num As Integer) As Integer
        'Procedure for displaying numbers in the listbox'
        If Integer.TryParse(txtInsert.Text, num) Then
            'converts string to integer'
            'Here it is used to accept only the integer values' 

            If OrderList.Items.Count = 10 Then
                'checks whether the listbox is filled with its maximum numbers'
                MsgBox("10 values are already loaded", vbCritical, "Overloaded")
            Else
                OrderList.Items.Add(txtInsert.Text)
                'Add number to the list box'
            End If
        Else : MsgBox("Not a number! Only numbers are allowed", vbCritical, "Error")
        End If
        Return num


    End Function

    Private Sub btnOdd_Click(sender As Object, e As EventArgs) Handles btnOdd.Click
        Dim k As Integer = 1
        'setting count'
        Dim ordersize As Integer = OrderList.Items.Count

        Do While (k < ordersize)
            'works until the count is less than the count of the number in the listbox'
            If o_Num(OrderList.Items.Item(k)) Then
                'Calling the procedure and using if condition to add the odd number to the listbox'
                OddList.Items.Add(OrderList.Items.Item(k))
            End If
            k += 1
        Loop


    End Sub
    Private Function o_Num(i_Num As Integer) As Boolean
        'procedure for checking the odd number'
        If (i_Num Mod 2 = 1) Then
            Return True
        Else
            Return False

        End If
        'If condition to check the odd number'
    End Function

    Private Sub btnEven_Click(sender As Object, e As EventArgs) Handles btnEven.Click
        Dim k As Integer = 1
        'setting count'
        Dim ordersize As Integer = OrderList.Items.Count

        Do While (k < ordersize)
            'works until the count is less than the count of the number in the listbox'
            If e_Num(OrderList.Items.Item(k)) Then
                'Calling the procedure and using if condition to add the even number to the listbox'
                EvenList.Items.Add(OrderList.Items.Item(k))
            End If
            k += 1
        Loop
    End Sub
    Private Function e_Num(o_Num As Integer) As Boolean
        'procedure for checking the even number'
        If (o_Num Mod 2 = 0) Then
            Return True
        Else
            Return False

        End If
        'If condition to check the even number'
    End Function
End Class
