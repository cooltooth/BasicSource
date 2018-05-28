<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SelectAllButton = New System.Windows.Forms.Button()
        Me.SelectNoneButton = New System.Windows.Forms.Button()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ListNumber_tbox = New System.Windows.Forms.TextBox()
        Me.FileLocation_tbox = New System.Windows.Forms.TextBox()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.LISTNUMBER = New System.Windows.Forms.TextBox()
        Me.ELUFILELOCATION = New System.Windows.Forms.TextBox()
        Me.SELECTFILES = New System.Windows.Forms.TextBox()
        Me.RemakeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SelectAllButton
        '
        Me.SelectAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SelectAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectAllButton.Location = New System.Drawing.Point(8, 911)
        Me.SelectAllButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SelectAllButton.Name = "SelectAllButton"
        Me.SelectAllButton.Size = New System.Drawing.Size(100, 30)
        Me.SelectAllButton.TabIndex = 5
        Me.SelectAllButton.Text = "Select All"
        Me.SelectAllButton.UseVisualStyleBackColor = True
        '
        'SelectNoneButton
        '
        Me.SelectNoneButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SelectNoneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectNoneButton.Location = New System.Drawing.Point(8, 941)
        Me.SelectNoneButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SelectNoneButton.Name = "SelectNoneButton"
        Me.SelectNoneButton.Size = New System.Drawing.Size(100, 30)
        Me.SelectNoneButton.TabIndex = 6
        Me.SelectNoneButton.Text = "Select None"
        Me.SelectNoneButton.UseVisualStyleBackColor = True
        '
        'GenerateButton
        '
        Me.GenerateButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenerateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateButton.Location = New System.Drawing.Point(110, 911)
        Me.GenerateButton.Margin = New System.Windows.Forms.Padding(0)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(1668, 60)
        Me.GenerateButton.TabIndex = 7
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.Window
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("SansSerif", 9.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(8, 85)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(1769, 818)
        Me.CheckedListBox1.TabIndex = 4
        Me.CheckedListBox1.ThreeDCheckBoxes = True
        '
        'ListNumber_tbox
        '
        Me.ListNumber_tbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListNumber_tbox.Location = New System.Drawing.Point(8, 30)
        Me.ListNumber_tbox.Margin = New System.Windows.Forms.Padding(0)
        Me.ListNumber_tbox.Name = "ListNumber_tbox"
        Me.ListNumber_tbox.Size = New System.Drawing.Size(94, 41)
        Me.ListNumber_tbox.TabIndex = 1
        '
        'FileLocation_tbox
        '
        Me.FileLocation_tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileLocation_tbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileLocation_tbox.Location = New System.Drawing.Point(110, 30)
        Me.FileLocation_tbox.Margin = New System.Windows.Forms.Padding(0)
        Me.FileLocation_tbox.Name = "FileLocation_tbox"
        Me.FileLocation_tbox.Size = New System.Drawing.Size(1569, 41)
        Me.FileLocation_tbox.TabIndex = 2
        Me.FileLocation_tbox.Text = "Z:\"
        '
        'LoadButton
        '
        Me.LoadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadButton.Location = New System.Drawing.Point(1689, 30)
        Me.LoadButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(87, 55)
        Me.LoadButton.TabIndex = 3
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'LISTNUMBER
        '
        Me.LISTNUMBER.BackColor = System.Drawing.SystemColors.MenuBar
        Me.LISTNUMBER.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LISTNUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LISTNUMBER.Location = New System.Drawing.Point(8, 8)
        Me.LISTNUMBER.Margin = New System.Windows.Forms.Padding(0)
        Me.LISTNUMBER.Name = "LISTNUMBER"
        Me.LISTNUMBER.Size = New System.Drawing.Size(94, 34)
        Me.LISTNUMBER.TabIndex = 0
        Me.LISTNUMBER.TabStop = False
        Me.LISTNUMBER.Text = "List#:"
        '
        'ELUFILELOCATION
        '
        Me.ELUFILELOCATION.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ELUFILELOCATION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ELUFILELOCATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ELUFILELOCATION.Location = New System.Drawing.Point(110, 8)
        Me.ELUFILELOCATION.Margin = New System.Windows.Forms.Padding(0)
        Me.ELUFILELOCATION.Name = "ELUFILELOCATION"
        Me.ELUFILELOCATION.Size = New System.Drawing.Size(1260, 34)
        Me.ELUFILELOCATION.TabIndex = 10
        Me.ELUFILELOCATION.TabStop = False
        Me.ELUFILELOCATION.Text = "Elumatec File Location:"
        '
        'SELECTFILES
        '
        Me.SELECTFILES.BackColor = System.Drawing.SystemColors.MenuBar
        Me.SELECTFILES.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SELECTFILES.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SELECTFILES.Location = New System.Drawing.Point(8, 60)
        Me.SELECTFILES.Margin = New System.Windows.Forms.Padding(0)
        Me.SELECTFILES.Name = "SELECTFILES"
        Me.SELECTFILES.Size = New System.Drawing.Size(209, 34)
        Me.SELECTFILES.TabIndex = 11
        Me.SELECTFILES.TabStop = False
        Me.SELECTFILES.Text = "Select Files:"
        '
        'RemakeButton
        '
        Me.RemakeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemakeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemakeButton.Location = New System.Drawing.Point(1756, 8)
        Me.RemakeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RemakeButton.Name = "RemakeButton"
        Me.RemakeButton.Size = New System.Drawing.Size(20, 20)
        Me.RemakeButton.TabIndex = 12
        Me.RemakeButton.Text = "*"
        Me.RemakeButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1784, 979)
        Me.Controls.Add(Me.RemakeButton)
        Me.Controls.Add(Me.SELECTFILES)
        Me.Controls.Add(Me.ELUFILELOCATION)
        Me.Controls.Add(Me.LISTNUMBER)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.FileLocation_tbox)
        Me.Controls.Add(Me.ListNumber_tbox)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.SelectNoneButton)
        Me.Controls.Add(Me.SelectAllButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "Form1"
        Me.Text = "Elumatec List Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelectAllButton As Button
    Friend WithEvents SelectNoneButton As Button
    Friend WithEvents GenerateButton As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents ListNumber_tbox As TextBox
    Friend WithEvents FileLocation_tbox As TextBox
    Friend WithEvents LoadButton As Button
    Friend WithEvents LISTNUMBER As TextBox
    Friend WithEvents ELUFILELOCATION As TextBox
    Friend WithEvents SELECTFILES As TextBox
    Friend WithEvents RemakeButton As Button
End Class
