namespace PuntoDeVenta
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
            this.TBLoginUsuario = new System.Windows.Forms.TextBox();
            this.TBLoginContrasena = new System.Windows.Forms.TextBox();
            this.LBLoginUsuario = new System.Windows.Forms.Label();
            this.LBLoginContrasena = new System.Windows.Forms.Label();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBLoginUsuario
            // 
            this.TBLoginUsuario.Location = new System.Drawing.Point(109, 53);
            this.TBLoginUsuario.Name = "TBLoginUsuario";
            this.TBLoginUsuario.Size = new System.Drawing.Size(181, 20);
            this.TBLoginUsuario.TabIndex = 0;
            // 
            // TBLoginContrasena
            // 
            this.TBLoginContrasena.Location = new System.Drawing.Point(109, 106);
            this.TBLoginContrasena.Name = "TBLoginContrasena";
            this.TBLoginContrasena.Size = new System.Drawing.Size(181, 20);
            this.TBLoginContrasena.TabIndex = 1;
            // 
            // LBLoginUsuario
            // 
            this.LBLoginUsuario.AutoSize = true;
            this.LBLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLoginUsuario.Location = new System.Drawing.Point(37, 54);
            this.LBLoginUsuario.Name = "LBLoginUsuario";
            this.LBLoginUsuario.Size = new System.Drawing.Size(66, 16);
            this.LBLoginUsuario.TabIndex = 2;
            this.LBLoginUsuario.Text = "Usuario:";
            // 
            // LBLoginContrasena
            // 
            this.LBLoginContrasena.AutoSize = true;
            this.LBLoginContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLoginContrasena.Location = new System.Drawing.Point(12, 106);
            this.LBLoginContrasena.Name = "LBLoginContrasena";
            this.LBLoginContrasena.Size = new System.Drawing.Size(91, 16);
            this.LBLoginContrasena.TabIndex = 3;
            this.LBLoginContrasena.Text = "Contraseña:";
            // 
            // BTNLogin
            // 
            this.BTNLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogin.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BTNLogin.Image = ((System.Drawing.Image)(resources.GetObject("BTNLogin.Image")));
            this.BTNLogin.Location = new System.Drawing.Point(312, 54);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(90, 72);
            this.BTNLogin.TabIndex = 4;
            this.BTNLogin.Text = "Login";
            this.BTNLogin.UseVisualStyleBackColor = true;
            this.BTNLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 241);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.LBLoginContrasena);
            this.Controls.Add(this.LBLoginUsuario);
            this.Controls.Add(this.TBLoginContrasena);
            this.Controls.Add(this.TBLoginUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBLoginUsuario;
        private System.Windows.Forms.TextBox TBLoginContrasena;
        private System.Windows.Forms.Label LBLoginUsuario;
        private System.Windows.Forms.Label LBLoginContrasena;
        private System.Windows.Forms.Button BTNLogin;
    }
}

