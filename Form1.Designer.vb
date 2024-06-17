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
        cmdEjecutar = New Button()
        Label1 = New Label()
        txtNumeroN = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.BackColor = Color.CornflowerBlue
        cmdEjecutar.BackgroundImageLayout = ImageLayout.Stretch
        cmdEjecutar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        cmdEjecutar.ForeColor = SystemColors.ControlText
        cmdEjecutar.ImageAlign = ContentAlignment.MiddleLeft
        cmdEjecutar.Location = New Point(726, 486)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(183, 62)
        cmdEjecutar.TabIndex = 0
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F)
        Label1.Location = New Point(22, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(699, 25)
        Label1.TabIndex = 1
        Label1.Text = "Cargar un Numero para determinar si existen Multiplos en el Vector"
        ' 
        ' txtNumeroN
        ' 
        txtNumeroN.Font = New Font("Verdana", 15F)
        txtNumeroN.Location = New Point(305, 108)
        txtNumeroN.Name = "txtNumeroN"
        txtNumeroN.Size = New Size(110, 38)
        txtNumeroN.TabIndex = 2
        txtNumeroN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.Font = New Font("Verdana", 12F)
        Label2.Location = New Point(35, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 25)
        Label2.TabIndex = 3
        Label2.Text = "Vector"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(921, 560)
        Controls.Add(Label2)
        Controls.Add(txtNumeroN)
        Controls.Add(Label1)
        Controls.Add(cmdEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumeroN As TextBox
    Friend WithEvents Label2 As Label

End Class
