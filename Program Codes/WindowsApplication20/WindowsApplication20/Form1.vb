Public Class frmActivity1
    Private _numList As Object

    Private Property NumList(x As String) As Object
        Get
            Return _numList
        End Get
        Set(value As Object)
            _numList = value
        End Set
    End Property

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim num As Integer
        num = GetNum(num)
        'Calling the procedure'

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim Sum As Integer
        For Each row As String In OrderList.Items
            Sum = Sum + CInt(row)
        Next
        'Using for loop to add each number in the listbox'
        txtTotal.Text = Sum

    End Sub

    Private Sub btnHighest_Click(sender As Object, e As EventArgs) Handles btnHighest.Click
        Dim k As Integer = 1
        Dim ordersize As Integer = OrderList.Items.Count
        Dim h_Num As Integer = CInt(OrderList.Items(0))

        Do While (k < ordersize)
            If (CInt(OrderList.Items(k)) > h_Num) Then
                h_Num = CInt(OrderList.Items(k))
            End If
            k += 1
        Loop
        'Using while loop to find maximum value from the listbox and display the maximum value'
        txtHighest.Text = h_Num.ToString


    End Sub

    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click
        Dim k As Integer = 1
        Dim ordersize As Integer = OrderList.Items.Count
        Dim l_Num As Integer = CInt(OrderList.Items(0))

        Do While (k < ordersize)
            If (CInt(OrderList.Items(k)) < l_Num) Then
                l_Num = CInt(OrderList.Items(k))
            End If
            k += 1
        Loop
        'Using while loop to find minimum value from the listbox and display the minimum value'
        txtLow.Text = l_Num.ToString

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the screen for the next entry'
        txtHighest.Text = ""
        txtInsert.Text = ""
        txtLow.Text = ""
        txtTotal.Text = ""
        OrderList.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
        'Exit from the program'
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
End Class