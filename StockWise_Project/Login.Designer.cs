
namespace StockWise_Project
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalirLogin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCancelarLogin = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtContraseñaLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsuarioLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjButton1 = new StockWise_Project.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(137, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesión";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.btnSalirLogin);
            this.panel1.Controls.Add(this.btnCancelarLogin);
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtContraseñaLogin);
            this.panel1.Controls.Add(this.txtUsuarioLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(471, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 311);
            this.panel1.TabIndex = 1;
            // 
            // btnSalirLogin
            // 
            this.btnSalirLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirLogin.Image")));
            this.btnSalirLogin.ImageActive = null;
            this.btnSalirLogin.Location = new System.Drawing.Point(410, 12);
            this.btnSalirLogin.Name = "btnSalirLogin";
            this.btnSalirLogin.Size = new System.Drawing.Size(33, 28);
            this.btnSalirLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalirLogin.TabIndex = 8;
            this.btnSalirLogin.TabStop = false;
            this.btnSalirLogin.Zoom = 10;
            this.btnSalirLogin.Click += new System.EventHandler(this.btnSalirLogin_Click);
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.BackColor = System.Drawing.Color.White;
            this.btnCancelarLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarLogin.FlatAppearance.BorderSize = 0;
            this.btnCancelarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarLogin.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarLogin.Location = new System.Drawing.Point(304, 248);
            this.btnCancelarLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Size = new System.Drawing.Size(91, 28);
            this.btnCancelarLogin.TabIndex = 7;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = false;
            this.btnCancelarLogin.Click += new System.EventHandler(this.btnCancelarLogin_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(193)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.Location = new System.Drawing.Point(205, 248);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(91, 28);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.Text = "Ingresar";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 170);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtContraseñaLogin
            // 
            this.txtContraseñaLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseñaLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseñaLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseñaLogin.ForeColor = System.Drawing.Color.Black;
            this.txtContraseñaLogin.HintForeColor = System.Drawing.Color.Gray;
            this.txtContraseñaLogin.HintText = "CONTRASEÑA";
            this.txtContraseñaLogin.isPassword = false;
            this.txtContraseñaLogin.LineFocusedColor = System.Drawing.Color.Transparent;
            this.txtContraseñaLogin.LineIdleColor = System.Drawing.Color.Transparent;
            this.txtContraseñaLogin.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.txtContraseñaLogin.LineThickness = 3;
            this.txtContraseñaLogin.Location = new System.Drawing.Point(101, 170);
            this.txtContraseñaLogin.Margin = new System.Windows.Forms.Padding(5);
            this.txtContraseñaLogin.Name = "txtContraseñaLogin";
            this.txtContraseñaLogin.Size = new System.Drawing.Size(307, 39);
            this.txtContraseñaLogin.TabIndex = 3;
            this.txtContraseñaLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuarioLogin.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarioLogin.HintForeColor = System.Drawing.Color.Gray;
            this.txtUsuarioLogin.HintText = "USUARIO";
            this.txtUsuarioLogin.isPassword = false;
            this.txtUsuarioLogin.LineFocusedColor = System.Drawing.Color.Transparent;
            this.txtUsuarioLogin.LineIdleColor = System.Drawing.Color.Transparent;
            this.txtUsuarioLogin.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.txtUsuarioLogin.LineThickness = 3;
            this.txtUsuarioLogin.Location = new System.Drawing.Point(101, 108);
            this.txtUsuarioLogin.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(307, 39);
            this.txtUsuarioLogin.TabIndex = 2;
            this.txtUsuarioLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(193)))));
            this.panel2.Location = new System.Drawing.Point(115, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 2);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(193)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 311);
            this.panel3.TabIndex = 2;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(44, 248);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 9;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelarLogin;
            this.ClientSize = new System.Drawing.Size(941, 311);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContraseñaLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuarioLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancelarLogin;
        private System.Windows.Forms.Button btnIniciarSesion;
        private Bunifu.Framework.UI.BunifuImageButton btnSalirLogin;
        private RJButton rjButton1;
    }
}