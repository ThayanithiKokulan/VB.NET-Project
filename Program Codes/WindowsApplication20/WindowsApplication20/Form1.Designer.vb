<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivity1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblInsert = New System.Windows.Forms.Label()
        Me.txtInsert = New System.Windows.Forms.TextBox()
        Me.lblNumList = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.OrderList = New System.Windows.Forms.ListBox()
        Me.btnHighest = New System.Windows.Forms.Button()
        Me.txtHighest = New System.Windows.Forms.TextBox()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.txtLow = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInsert
        '
        Me.lblInsert.AutoSize = True
        Me.lblInsert.Location = New System.Drawing.Point(12, 18)
        Me.lblInsert.Name = "lblInsert"
        Me.lblInsert.Size = New System.Drawing.Size(73, 13)
        Me.lblInsert.TabIndex = 0
        Me.lblInsert.Text = "Insert Number"
        '
        'txtInsert
        '
        Me.txtInsert.Location = New System.Drawing.Point(91, 18)
        Me.txtInsert.Name = "txtInsert"
        Me.txtInsert.Size = New System.Drawing.Size(94, 20)
        Me.txtInsert.TabIndex = 1
        '
        'lblNumList
        '
        Me.lblNumList.AutoSize = True
        Me.lblNumList.Location = New System.Drawing.Point(328, 25)
        Me.lblNumList.Name = "lblNumList"
        Me.lblNumList.Size = New System.Drawing.Size(63, 13)
        Me.lblNumList.TabIndex = 2
        Me.lblNumList.Text = "Number List"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(202, 20)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'OrderList
        '
        Me.OrderList.FormattingEnabled = True
        Me.OrderList.Location = New System.Drawing.Point(332, 53)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Size = New System.Drawing.Size(106, 199)
        Me.OrderList.TabIndex = 5
        '
        'btnHighest
        '
        Me.btnHighest.Location = New System.Drawing.Point(18, 70)
        Me.btnHighest.Name = "btnHighest"
        Me.btnHighest.Size = New System.Drawing.Size(81, 23)
        Me.btnHighest.TabIndex = 6
        Me.btnHighest.Text = "Highest Value"
        Me.btnHighest.UseVisualStyleBackColor = True
        '
        'txtHighest
        '
        Me.txtHighest.Location = New System.Drawing.Point(114, 73)
        Me.txtHighest.Name = "txtHighest"
        Me.txtHighest.Size = New System.Drawing.Size(100, 20)
        Me.txtHighest.TabIndex = 7
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(18, 111)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(81, 23)
        Me.btnLow.TabIndex = 8
        Me.btnLow.Text = "Low Value"
        Me.btnLow.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(18, 159)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(81, 23)
        Me.btnTotal.TabIndex = 9
        Me.btnTotal.Text = "Total Value"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'txtLow
        '
        Me.txtLow.Location = New System.Drawing.Point(114, 114)
        Me.txtLow.Name = "txtLow"
        Me.txtLow.Size = New System.Drawing.Size(100, 20)
        Me.txtLow.TabIndex = 10
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(114, 162)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 11
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(286, 268)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 24)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(382, 268)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmActivity1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 303)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtLow)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.txtHighest)
        Me.Controls.Add(Me.btnHighest)
        Me.Controls.Add(Me.OrderList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblNumList)
        Me.Controls.Add(Me.txtInsert)
        Me.Controls.Add(Me.lblInsert)
        Me.Name = "frmActivity1"
        Me.Text = "Activity 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInsert As System.Windows.Forms.Label
    Friend WithEvents txtInsert As System.Windows.Forms.TextBox
    Friend WithEvents lblNumList As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents OrderList As System.Windows.Forms.ListBox
    Friend WithEvents btnHighest As System.Windows.Forms.Button
    Friend WithEvents txtHighest As System.Windows.Forms.TextBox
    Friend WithEvents btnLow As System.Windows.Forms.Button
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents txtLow As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
