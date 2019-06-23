<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.LinkRecuperar = New System.Windows.Forms.LinkLabel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.Advertencia1 = New System.Windows.Forms.PictureBox()
        Me.Advertencia2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnMostrar = New System.Windows.Forms.PictureBox()
        Me.btnOcultar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Advertencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Advertencia2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOcultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 330)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(780, 330)
        Me.ShapeContainer2.TabIndex = 1
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.DimGray
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 331
        Me.LineShape2.X2 = 718
        Me.LineShape2.Y1 = 173
        Me.LineShape2.Y2 = 173
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.DimGray
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 330
        Me.LineShape1.X2 = 717
        Me.LineShape1.Y1 = 100
        Me.LineShape1.Y2 = 100
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsuario.Location = New System.Drawing.Point(330, 78)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(388, 20)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.Text = "USUARIO"
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.DimGray
        Me.txtContraseña.Location = New System.Drawing.Point(330, 151)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(388, 20)
        Me.txtContraseña.TabIndex = 2
        Me.txtContraseña.Text = "CONTRASEÑA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(424, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LOGIN"
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAcceder.FlatAppearance.BorderSize = 0
        Me.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcceder.Location = New System.Drawing.Point(330, 230)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(408, 40)
        Me.btnAcceder.TabIndex = 3
        Me.btnAcceder.Text = "ACCEDER"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'LinkRecuperar
        '
        Me.LinkRecuperar.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LinkRecuperar.AutoSize = True
        Me.LinkRecuperar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LinkRecuperar.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkRecuperar.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkRecuperar.Location = New System.Drawing.Point(478, 285)
        Me.LinkRecuperar.Name = "LinkRecuperar"
        Me.LinkRecuperar.Size = New System.Drawing.Size(119, 13)
        Me.LinkRecuperar.TabIndex = 0
        Me.LinkRecuperar.TabStop = True
        Me.LinkRecuperar.Text = "¿Olvido su contraseña?"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(741, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(15, 15)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 7
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(762, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(15, 15)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.TabStop = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.ForeColor = System.Drawing.Color.DimGray
        Me.lblUsuario.Location = New System.Drawing.Point(327, 62)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(60, 13)
        Me.lblUsuario.TabIndex = 10
        Me.lblUsuario.Text = "USUARIO*"
        Me.lblUsuario.Visible = False
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.ForeColor = System.Drawing.Color.DimGray
        Me.lblContraseña.Location = New System.Drawing.Point(328, 135)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(85, 13)
        Me.lblContraseña.TabIndex = 11
        Me.lblContraseña.Text = "CONTRASEÑA*"
        Me.lblContraseña.Visible = False
        '
        'Advertencia1
        '
        Me.Advertencia1.Image = CType(resources.GetObject("Advertencia1.Image"), System.Drawing.Image)
        Me.Advertencia1.Location = New System.Drawing.Point(309, 83)
        Me.Advertencia1.Name = "Advertencia1"
        Me.Advertencia1.Size = New System.Drawing.Size(15, 15)
        Me.Advertencia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Advertencia1.TabIndex = 12
        Me.Advertencia1.TabStop = False
        Me.Advertencia1.Visible = False
        '
        'Advertencia2
        '
        Me.Advertencia2.Image = CType(resources.GetObject("Advertencia2.Image"), System.Drawing.Image)
        Me.Advertencia2.Location = New System.Drawing.Point(309, 156)
        Me.Advertencia2.Name = "Advertencia2"
        Me.Advertencia2.Size = New System.Drawing.Size(15, 15)
        Me.Advertencia2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Advertencia2.TabIndex = 13
        Me.Advertencia2.TabStop = False
        Me.Advertencia2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(718, 81)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'btnMostrar
        '
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.Location = New System.Drawing.Point(718, 156)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(20, 20)
        Me.btnMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMostrar.TabIndex = 15
        Me.btnMostrar.TabStop = False
        '
        'btnOcultar
        '
        Me.btnOcultar.Image = CType(resources.GetObject("btnOcultar.Image"), System.Drawing.Image)
        Me.btnOcultar.Location = New System.Drawing.Point(718, 156)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Size = New System.Drawing.Size(20, 20)
        Me.btnOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnOcultar.TabIndex = 16
        Me.btnOcultar.TabStop = False
        Me.btnOcultar.Visible = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnAcceder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 330)
        Me.Controls.Add(Me.btnOcultar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Advertencia2)
        Me.Controls.Add(Me.Advertencia1)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.LinkRecuperar)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Advertencia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Advertencia2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOcultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAcceder As Button
    Friend WithEvents LinkRecuperar As LinkLabel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents Advertencia1 As PictureBox
    Friend WithEvents Advertencia2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnMostrar As PictureBox
    Friend WithEvents btnOcultar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
