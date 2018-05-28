<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.EXPAND_BUTTON = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SAVE_BUTTON = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PROFILE_CB = New System.Windows.Forms.ComboBox()
        Me.BOX_CB = New System.Windows.Forms.ComboBox()
        Me.ID_CB = New System.Windows.Forms.ComboBox()
        Me.LIST_CB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LIST = New System.Windows.Forms.Label()
        Me.ADD_BUTTON = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EXPAND_BUTTON
        '
        Me.EXPAND_BUTTON.Location = New System.Drawing.Point(796, 5)
        Me.EXPAND_BUTTON.Name = "EXPAND_BUTTON"
        Me.EXPAND_BUTTON.Size = New System.Drawing.Size(34, 33)
        Me.EXPAND_BUTTON.TabIndex = 28
        Me.EXPAND_BUTTON.Text = "+"
        Me.EXPAND_BUTTON.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 29
        Me.ListBox1.Location = New System.Drawing.Point(14, 171)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(816, 582)
        Me.ListBox1.TabIndex = 27
        '
        'SAVE_BUTTON
        '
        Me.SAVE_BUTTON.Location = New System.Drawing.Point(404, 101)
        Me.SAVE_BUTTON.Name = "SAVE_BUTTON"
        Me.SAVE_BUTTON.Size = New System.Drawing.Size(426, 64)
        Me.SAVE_BUTTON.TabIndex = 26
        Me.SAVE_BUTTON.Text = "SAVE"
        Me.SAVE_BUTTON.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(844, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1595, 743)
        Me.DataGridView1.TabIndex = 25
        '
        'PROFILE_CB
        '
        Me.PROFILE_CB.FormattingEnabled = True
        Me.PROFILE_CB.Location = New System.Drawing.Point(186, 44)
        Me.PROFILE_CB.Name = "PROFILE_CB"
        Me.PROFILE_CB.Size = New System.Drawing.Size(208, 37)
        Me.PROFILE_CB.Sorted = True
        Me.PROFILE_CB.TabIndex = 17
        '
        'BOX_CB
        '
        Me.BOX_CB.FormattingEnabled = True
        Me.BOX_CB.Location = New System.Drawing.Point(400, 44)
        Me.BOX_CB.Name = "BOX_CB"
        Me.BOX_CB.Size = New System.Drawing.Size(114, 37)
        Me.BOX_CB.Sorted = True
        Me.BOX_CB.TabIndex = 18
        '
        'ID_CB
        '
        Me.ID_CB.FormattingEnabled = True
        Me.ID_CB.Location = New System.Drawing.Point(520, 44)
        Me.ID_CB.Name = "ID_CB"
        Me.ID_CB.Size = New System.Drawing.Size(310, 37)
        Me.ID_CB.TabIndex = 19
        '
        'LIST_CB
        '
        Me.LIST_CB.FormattingEnabled = True
        Me.LIST_CB.Location = New System.Drawing.Point(14, 44)
        Me.LIST_CB.Name = "LIST_CB"
        Me.LIST_CB.Size = New System.Drawing.Size(166, 37)
        Me.LIST_CB.Sorted = True
        Me.LIST_CB.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(515, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 29)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "IDENTIFIER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(395, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 29)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "BOX #"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "PROFILE"
        '
        'LIST
        '
        Me.LIST.AutoSize = True
        Me.LIST.Location = New System.Drawing.Point(9, 12)
        Me.LIST.Name = "LIST"
        Me.LIST.Size = New System.Drawing.Size(64, 29)
        Me.LIST.TabIndex = 21
        Me.LIST.Text = "LIST"
        '
        'ADD_BUTTON
        '
        Me.ADD_BUTTON.Location = New System.Drawing.Point(14, 101)
        Me.ADD_BUTTON.Name = "ADD_BUTTON"
        Me.ADD_BUTTON.Size = New System.Drawing.Size(187, 64)
        Me.ADD_BUTTON.TabIndex = 20
        Me.ADD_BUTTON.Text = "ADD"
        Me.ADD_BUTTON.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(207, 101)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(187, 64)
        Me.deleteButton.TabIndex = 29
        Me.deleteButton.Text = "DELETE"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2443, 763)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.EXPAND_BUTTON)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.SAVE_BUTTON)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PROFILE_CB)
        Me.Controls.Add(Me.BOX_CB)
        Me.Controls.Add(Me.ID_CB)
        Me.Controls.Add(Me.LIST_CB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LIST)
        Me.Controls.Add(Me.ADD_BUTTON)
        Me.Name = "Form2"
        Me.Text = "Remake Generator"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EXPAND_BUTTON As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents SAVE_BUTTON As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PROFILE_CB As ComboBox
    Friend WithEvents BOX_CB As ComboBox
    Friend WithEvents ID_CB As ComboBox
    Friend WithEvents LIST_CB As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LIST As Label
    Friend WithEvents ADD_BUTTON As Button
    Friend WithEvents deleteButton As Button
End Class
