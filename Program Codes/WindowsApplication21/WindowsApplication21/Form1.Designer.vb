<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivity2
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.OrderList = New System.Windows.Forms.ListBox()
        Me.btnOdd = New System.Windows.Forms.Button()
        Me.OddList = New System.Windows.Forms.ListBox()
        Me.btnEven = New System.Windows.Forms.Button()
        Me.EvenList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblInsert
        '
        Me.lblInsert.AutoSize = True
        Me.lblInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsert.Location = New System.Drawing.Point(12, 20)
        Me.lblInsert.Name = "lblInsert"
        Me.lblInsert.Size = New System.Drawing.Size(85, 15)
        Me.lblInsert.TabIndex = 0
        Me.lblInsert.Text = "Insert Number"
        '
        'txtInsert
        '
        Me.txtInsert.Location = New System.Drawing.Point(103, 19)
        Me.txtInsert.Name = "txtInsert"
        Me.txtInsert.Size = New System.Drawing.Size(100, 20)
        Me.txtInsert.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(239, 17)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'OrderList
        '
        Me.OrderList.FormattingEnabled = True
        Me.OrderList.Location = New System.Drawing.Point(15, 67)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Size = New System.Drawing.Size(120, 264)
        Me.OrderList.TabIndex = 3
        '
        'btnOdd
        '
        Me.btnOdd.Location = New System.Drawing.Point(146, 195)
        Me.btnOdd.Name = "btnOdd"
        Me.btnOdd.Size = New System.Drawing.Size(75, 23)
        Me.btnOdd.TabIndex = 4
        Me.btnOdd.Text = "Filter Odd"
        Me.btnOdd.UseVisualStyleBackColor = True
        '
        'OddList
        '
        Me.OddList.FormattingEnabled = True
        Me.OddList.Location = New System.Drawing.Point(231, 67)
        Me.OddList.Name = "OddList"
        Me.OddList.Size = New System.Drawing.Size(120, 264)
        Me.OddList.TabIndex = 5
        '
        'btnEven
        '
        Me.btnEven.Location = New System.Drawing.Point(367, 195)
        Me.btnEven.Name = "btnEven"
        Me.btnEven.Size = New System.Drawing.Size(75, 23)
        Me.btnEven.TabIndex = 6
        Me.btnEven.Text = "Filter Even"
        Me.btnEven.UseVisualStyleBackColor = True
        '
        'EvenList
        '
        Me.EvenList.FormattingEnabled = True
        Me.EvenList.Location = New System.Drawing.Point(459, 67)
        Me.EvenList.Name = "EvenList"
        Me.EvenList.Size = New System.Drawing.Size(120, 264)
        Me.EvenList.TabIndex = 7
        '
        'frmActivity2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 355)
        Me.Controls.Add(Me.EvenList)
        Me.Controls.Add(Me.btnEven)
        Me.Controls.Add(Me.OddList)
        Me.Controls.Add(Me.btnOdd)
        Me.Controls.Add(Me.OrderList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtInsert)
        Me.Controls.Add(Me.lblInsert)
        Me.Name = "frmActivity2"
        Me.Text = "Activity 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInsert As System.Windows.Forms.Label
    Friend WithEvents txtInsert As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents OrderList As System.Windows.Forms.ListBox
    Friend WithEvents btnOdd As System.Windows.Forms.Button
    Friend WithEvents OddList As System.Windows.Forms.ListBox
    Friend WithEvents btnEven As System.Windows.Forms.Button
    Friend WithEvents EvenList As System.Windows.Forms.ListBox

End Class
