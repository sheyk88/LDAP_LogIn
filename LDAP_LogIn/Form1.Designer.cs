namespace LDAP_LogIn
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.bt_login = new System.Windows.Forms.Button();
            this.txtb_user = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtb_pass = new System.Windows.Forms.TextBox();
            this.lbl_check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_login.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(150, 110);
            this.bt_login.Name = "bt_login";
            this.bt_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_login.Size = new System.Drawing.Size(75, 25);
            this.bt_login.TabIndex = 0;
            this.bt_login.Text = "LogIn";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtb_user
            // 
            this.txtb_user.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtb_user.Location = new System.Drawing.Point(150, 35);
            this.txtb_user.Name = "txtb_user";
            this.txtb_user.Size = new System.Drawing.Size(170, 20);
            this.txtb_user.TabIndex = 1;
            this.txtb_user.Text = "Username";
            this.txtb_user.TextChanged += new System.EventHandler(this.txtb_user_TextChanged);
            this.txtb_user.Enter += new System.EventHandler(this.txtb_user_TextChanged);
            this.txtb_user.Leave += new System.EventHandler(this.txtb_user_TextChanged);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(75, 35);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(67, 16);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(75, 70);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(65, 16);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password";
            this.lbl_password.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtb_pass
            // 
            this.txtb_pass.AccessibleDescription = "Password";
            this.txtb_pass.AccessibleName = "Password";
            this.txtb_pass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtb_pass.Location = new System.Drawing.Point(150, 70);
            this.txtb_pass.Name = "txtb_pass";
            this.txtb_pass.Size = new System.Drawing.Size(170, 20);
            this.txtb_pass.TabIndex = 4;
            this.txtb_pass.Text = "Password";
            this.txtb_pass.UseSystemPasswordChar = true;
            this.txtb_pass.TextChanged += new System.EventHandler(this.txtb_pass_TextChanged);
            this.txtb_pass.Enter += new System.EventHandler(this.txtb_pass_TextChanged);
            this.txtb_pass.Leave += new System.EventHandler(this.txtb_pass_TextChanged);
            // 
            // lbl_check
            // 
            this.lbl_check.Location = new System.Drawing.Point(370, 150);
            this.lbl_check.MaximumSize = new System.Drawing.Size(10, 10);
            this.lbl_check.Name = "lbl_check";
            this.lbl_check.Size = new System.Drawing.Size(10, 10);
            this.lbl_check.TabIndex = 6;
            this.lbl_check.Click += new System.EventHandler(this.lbl_check_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.lbl_check);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtb_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txtb_user);
            this.Controls.Add(this.bt_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "Title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox txtb_user;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtb_pass;
        private System.Windows.Forms.Label lbl_check;
    }
}

