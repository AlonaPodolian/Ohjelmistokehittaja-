<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class harjoitus2FM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        OtsikkoLB = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ViestiTB = New TextBox()
        TulostaBT = New Button()
        SuspendLayout()
        ' 
        ' OtsikkoLB
        ' 
        OtsikkoLB.AutoSize = True
        OtsikkoLB.Font = New Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        OtsikkoLB.Location = New Point(46, 22)
        OtsikkoLB.Name = "OtsikkoLB"
        OtsikkoLB.Size = New Size(442, 51)
        OtsikkoLB.TabIndex = 0
        OtsikkoLB.Text = "Anna tulostettava teksti:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(358, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 45)
        Label2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(46, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 51)
        Label1.TabIndex = 2
        Label1.Text = "xxxx"
        ' 
        ' ViestiTB
        ' 
        ViestiTB.Location = New Point(508, 23)
        ViestiTB.Name = "ViestiTB"
        ViestiTB.Size = New Size(499, 50)
        ViestiTB.TabIndex = 3
        ' 
        ' TulostaBT
        ' 
        TulostaBT.Location = New Point(508, 92)
        TulostaBT.Name = "TulostaBT"
        TulostaBT.Size = New Size(112, 34)
        TulostaBT.TabIndex = 4
        TulostaBT.Text = "FlatStyleksi System" & vbCrLf
        TulostaBT.UseVisualStyleBackColor = True
        ' 
        ' harjoitus2FM
        ' 
        AutoScaleDimensions = New SizeF(18F, 45F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Salmon
        ClientSize = New Size(1924, 913)
        Controls.Add(TulostaBT)
        Controls.Add(ViestiTB)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(OtsikkoLB)
        Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.MintCream
        Margin = New Padding(5, 6, 5, 6)
        Name = "harjoitus2FM"
        Text = "Harjoitus2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OtsikkoLB As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ViestiTB As TextBox
    Friend WithEvents TulostaBT As Button

End Class
