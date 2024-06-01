namespace Ej1
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngresar = new Button();
            lblUsuario = new Label();
            lblPass = new Label();
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.ForeColor = SystemColors.ActiveCaption;
            btnIngresar.Location = new Point(222, 165);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 49);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(52, 66);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(52, 113);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(83, 20);
            lblPass.TabIndex = 2;
            lblPass.Text = "Contraseña";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(191, 113);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(191, 66);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 4;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 280);
            Controls.Add(txtUsuario);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label lblUsuario;
        private Label lblPass;
        private TextBox txtPass;
        private TextBox txtUsuario;
    }
}
