namespace Big3Form.Forms
{
    partial class HomeForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonGrafico = new FontAwesome.Sharp.IconButton();
            this.iconButtonJogador = new FontAwesome.Sharp.IconButton();
            this.iconButtonJogos = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenu.Controls.Add(this.iconButtonGrafico);
            this.panelMenu.Controls.Add(this.iconButtonJogador);
            this.panelMenu.Controls.Add(this.iconButtonJogos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonGrafico
            // 
            this.iconButtonGrafico.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonGrafico.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonGrafico.FlatAppearance.BorderSize = 0;
            this.iconButtonGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonGrafico.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonGrafico.ForeColor = System.Drawing.Color.White;
            this.iconButtonGrafico.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconButtonGrafico.IconColor = System.Drawing.Color.White;
            this.iconButtonGrafico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGrafico.Location = new System.Drawing.Point(0, 278);
            this.iconButtonGrafico.Name = "iconButtonGrafico";
            this.iconButtonGrafico.Size = new System.Drawing.Size(200, 55);
            this.iconButtonGrafico.TabIndex = 3;
            this.iconButtonGrafico.Text = "Gráfico";
            this.iconButtonGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGrafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonGrafico.UseVisualStyleBackColor = false;
            // 
            // iconButtonJogador
            // 
            this.iconButtonJogador.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonJogador.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonJogador.FlatAppearance.BorderSize = 0;
            this.iconButtonJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonJogador.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonJogador.ForeColor = System.Drawing.Color.White;
            this.iconButtonJogador.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonJogador.IconColor = System.Drawing.Color.White;
            this.iconButtonJogador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonJogador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonJogador.Location = new System.Drawing.Point(0, 223);
            this.iconButtonJogador.Name = "iconButtonJogador";
            this.iconButtonJogador.Size = new System.Drawing.Size(200, 55);
            this.iconButtonJogador.TabIndex = 2;
            this.iconButtonJogador.Text = "Big 3";
            this.iconButtonJogador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonJogador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonJogador.UseVisualStyleBackColor = false;
            // 
            // iconButtonJogos
            // 
            this.iconButtonJogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonJogos.FlatAppearance.BorderSize = 0;
            this.iconButtonJogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonJogos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonJogos.ForeColor = System.Drawing.Color.White;
            this.iconButtonJogos.IconChar = FontAwesome.Sharp.IconChar.BasketballBall;
            this.iconButtonJogos.IconColor = System.Drawing.Color.White;
            this.iconButtonJogos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonJogos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonJogos.Location = new System.Drawing.Point(0, 168);
            this.iconButtonJogos.Name = "iconButtonJogos";
            this.iconButtonJogos.Size = new System.Drawing.Size(200, 55);
            this.iconButtonJogos.TabIndex = 1;
            this.iconButtonJogos.Text = "Jogos";
            this.iconButtonJogos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonJogos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonJogos.UseVisualStyleBackColor = true;
            this.iconButtonJogos.Click += new System.EventHandler(this.iconButtonJogos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 168);
            this.panelLogo.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panelMenu);
            this.Name = "HomeForm";
            this.Text = "JogosForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonJogos;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonJogador;
        private FontAwesome.Sharp.IconButton iconButtonGrafico;
    }
}