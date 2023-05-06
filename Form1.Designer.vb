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
        components = New ComponentModel.Container()
        Label1 = New Label()
        txtFName = New TextBox()
        txtMName = New TextBox()
        Label2 = New Label()
        txtLName = New TextBox()
        Label3 = New Label()
        birthDate = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        genderSelector = New ComboBox()
        btnSubmit = New Button()
        DataGridView1 = New DataGridView()
        SchoolYear = New Label()
        btnSubmit1 = New Button()
        ComboBox3 = New ComboBox()
        scho = New Label()
        ComboBox4 = New ComboBox()
        Label7 = New Label()
        yearStart = New TextBox()
        yearEnd = New TextBox()
        ToolTip1 = New ToolTip(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(86, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' txtFName
        ' 
        txtFName.Location = New Point(86, 110)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(189, 23)
        txtFName.TabIndex = 1
        ' 
        ' txtMName
        ' 
        txtMName.Location = New Point(282, 110)
        txtMName.Name = "txtMName"
        txtMName.Size = New Size(189, 23)
        txtMName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(282, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 2
        Label2.Text = "Middle Name"
        ' 
        ' txtLName
        ' 
        txtLName.Location = New Point(476, 110)
        txtLName.Name = "txtLName"
        txtLName.Size = New Size(189, 23)
        txtLName.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(476, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 4
        Label3.Text = "Last Name"
        ' 
        ' birthDate
        ' 
        birthDate.Location = New Point(86, 178)
        birthDate.Name = "birthDate"
        birthDate.Size = New Size(189, 23)
        birthDate.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(86, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 7
        Label4.Text = "Birthdate"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(282, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(25, 15)
        Label5.TabIndex = 8
        Label5.Text = "Sex"
        ' 
        ' genderSelector
        ' 
        genderSelector.FormattingEnabled = True
        genderSelector.Items.AddRange(New Object() {"Male", "Female"})
        genderSelector.Location = New Point(281, 178)
        genderSelector.Name = "genderSelector"
        genderSelector.Size = New Size(190, 23)
        genderSelector.TabIndex = 9
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(282, 209)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(189, 49)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(86, 364)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(579, 231)
        DataGridView1.TabIndex = 11
        ' 
        ' SchoolYear
        ' 
        SchoolYear.AutoSize = True
        SchoolYear.Location = New Point(86, 21)
        SchoolYear.Name = "SchoolYear"
        SchoolYear.Size = New Size(64, 15)
        SchoolYear.TabIndex = 12
        SchoolYear.Text = "First Name"
        ' 
        ' btnSubmit1
        ' 
        btnSubmit1.Location = New Point(226, 13)
        btnSubmit1.Name = "btnSubmit1"
        btnSubmit1.Size = New Size(189, 49)
        btnSubmit1.TabIndex = 15
        btnSubmit1.Text = "SUBMIT"
        btnSubmit1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox3.Location = New Point(475, 178)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(190, 23)
        ComboBox3.TabIndex = 17
        ' 
        ' scho
        ' 
        scho.AutoSize = True
        scho.Location = New Point(476, 160)
        scho.Name = "scho"
        scho.Size = New Size(68, 15)
        scho.TabIndex = 16
        scho.Text = "School Year"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox4.Location = New Point(85, 235)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(190, 23)
        ComboBox4.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(86, 217)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 15)
        Label7.TabIndex = 18
        Label7.Text = "Grade Level"
        ' 
        ' yearStart
        ' 
        yearStart.Location = New Point(86, 39)
        yearStart.Name = "yearStart"
        yearStart.Size = New Size(64, 23)
        yearStart.TabIndex = 20
        ' 
        ' yearEnd
        ' 
        yearEnd.Location = New Point(156, 39)
        yearEnd.Name = "yearEnd"
        yearEnd.Size = New Size(64, 23)
        yearEnd.TabIndex = 21
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(760, 625)
        Controls.Add(yearEnd)
        Controls.Add(yearStart)
        Controls.Add(ComboBox4)
        Controls.Add(Label7)
        Controls.Add(ComboBox3)
        Controls.Add(scho)
        Controls.Add(btnSubmit1)
        Controls.Add(SchoolYear)
        Controls.Add(DataGridView1)
        Controls.Add(btnSubmit)
        Controls.Add(genderSelector)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(birthDate)
        Controls.Add(txtLName)
        Controls.Add(Label3)
        Controls.Add(txtMName)
        Controls.Add(Label2)
        Controls.Add(txtFName)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents birthDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents genderSelector As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SchoolYear As Label
    Friend WithEvents btnSubmit1 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents scho As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents yearStart As TextBox
    Friend WithEvents yearEnd As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
