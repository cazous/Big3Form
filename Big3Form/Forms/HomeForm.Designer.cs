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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonGrafico = new FontAwesome.Sharp.IconButton();
            this.iconButtonJogador = new FontAwesome.Sharp.IconButton();
            this.iconButtonJogos = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Label();
            this.panelFormAtual = new System.Windows.Forms.Panel();
            this.iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.labelFormAtual = new System.Windows.Forms.Label();
            this.iconFormAtual = new FontAwesome.Sharp.IconPictureBox();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.bunifuDragControlPanelFormAtual = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlPanelLogo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlPanelMenu = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlPanelConteudo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelFormAtual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormAtual)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.panelMenu.Controls.Add(this.iconButtonGrafico);
            this.panelMenu.Controls.Add(this.iconButtonJogador);
            this.panelMenu.Controls.Add(this.iconButtonJogos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 655);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonGrafico
            // 
            this.iconButtonGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
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
            this.iconButtonGrafico.Click += new System.EventHandler(this.iconButtonGrafico_Click);
            // 
            // iconButtonJogador
            // 
            this.iconButtonJogador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
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
            this.iconButtonJogador.Click += new System.EventHandler(this.iconButtonJogador_Click);
            // 
            // iconButtonJogos
            // 
            this.iconButtonJogos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
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
            this.iconButtonJogos.UseVisualStyleBackColor = false;
            this.iconButtonJogos.Click += new System.EventHandler(this.iconButtonJogos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 168);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnHome.Location = new System.Drawing.Point(36, 60);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "BIG 3";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelFormAtual
            // 
            this.panelFormAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.panelFormAtual.Controls.Add(this.iconButtonMinimize);
            this.panelFormAtual.Controls.Add(this.iconButtonClose);
            this.panelFormAtual.Controls.Add(this.labelFormAtual);
            this.panelFormAtual.Controls.Add(this.iconFormAtual);
            this.panelFormAtual.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormAtual.Location = new System.Drawing.Point(200, 0);
            this.panelFormAtual.Name = "panelFormAtual";
            this.panelFormAtual.Size = new System.Drawing.Size(975, 67);
            this.panelFormAtual.TabIndex = 1;
            // 
            // iconButtonMinimize
            // 
            this.iconButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMinimize.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimize.ForeColor = System.Drawing.Color.Goldenrod;
            this.iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.iconButtonMinimize.IconColor = System.Drawing.Color.Goldenrod;
            this.iconButtonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinimize.IconSize = 22;
            this.iconButtonMinimize.Location = new System.Drawing.Point(926, 3);
            this.iconButtonMinimize.Name = "iconButtonMinimize";
            this.iconButtonMinimize.Size = new System.Drawing.Size(20, 20);
            this.iconButtonMinimize.TabIndex = 3;
            this.iconButtonMinimize.UseVisualStyleBackColor = true;
            this.iconButtonMinimize.Click += new System.EventHandler(this.iconButtonMinimize_Click);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonClose.IconColor = System.Drawing.Color.Goldenrod;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 24;
            this.iconButtonClose.Location = new System.Drawing.Point(951, 3);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(20, 20);
            this.iconButtonClose.TabIndex = 2;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // labelFormAtual
            // 
            this.labelFormAtual.AutoSize = true;
            this.labelFormAtual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormAtual.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelFormAtual.Location = new System.Drawing.Point(64, 26);
            this.labelFormAtual.Name = "labelFormAtual";
            this.labelFormAtual.Size = new System.Drawing.Size(40, 13);
            this.labelFormAtual.TabIndex = 1;
            this.labelFormAtual.Text = "Home";
            // 
            // iconFormAtual
            // 
            this.iconFormAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.iconFormAtual.ForeColor = System.Drawing.Color.Goldenrod;
            this.iconFormAtual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFormAtual.IconColor = System.Drawing.Color.Goldenrod;
            this.iconFormAtual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFormAtual.Location = new System.Drawing.Point(22, 18);
            this.iconFormAtual.Name = "iconFormAtual";
            this.iconFormAtual.Size = new System.Drawing.Size(32, 32);
            this.iconFormAtual.TabIndex = 0;
            this.iconFormAtual.TabStop = false;
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(200, 67);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(975, 5);
            this.panelSombra.TabIndex = 2;
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.Color.White;
            this.panelConteudo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelConteudo.BackgroundImage")));
            this.panelConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(200, 72);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(975, 583);
            this.panelConteudo.TabIndex = 3;
            // 
            // bunifuDragControlPanelFormAtual
            // 
            this.bunifuDragControlPanelFormAtual.Fixed = true;
            this.bunifuDragControlPanelFormAtual.Horizontal = true;
            this.bunifuDragControlPanelFormAtual.TargetControl = this.panelFormAtual;
            this.bunifuDragControlPanelFormAtual.Vertical = true;
            // 
            // bunifuDragControlPanelLogo
            // 
            this.bunifuDragControlPanelLogo.Fixed = true;
            this.bunifuDragControlPanelLogo.Horizontal = true;
            this.bunifuDragControlPanelLogo.TargetControl = null;
            this.bunifuDragControlPanelLogo.Vertical = true;
            // 
            // bunifuDragControlPanelMenu
            // 
            this.bunifuDragControlPanelMenu.Fixed = true;
            this.bunifuDragControlPanelMenu.Horizontal = true;
            this.bunifuDragControlPanelMenu.TargetControl = null;
            this.bunifuDragControlPanelMenu.Vertical = true;
            // 
            // bunifuDragControlPanelConteudo
            // 
            this.bunifuDragControlPanelConteudo.Fixed = true;
            this.bunifuDragControlPanelConteudo.Horizontal = true;
            this.bunifuDragControlPanelConteudo.TargetControl = null;
            this.bunifuDragControlPanelConteudo.Vertical = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 655);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panelFormAtual);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "JogosForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelFormAtual.ResumeLayout(false);
            this.panelFormAtual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormAtual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonJogos;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonJogador;
        private FontAwesome.Sharp.IconButton iconButtonGrafico;
        private System.Windows.Forms.Label btnHome;
        private System.Windows.Forms.Panel panelFormAtual;
        private FontAwesome.Sharp.IconPictureBox iconFormAtual;
        private System.Windows.Forms.Label labelFormAtual;
        private System.Windows.Forms.Panel panelSombra;
        private System.Windows.Forms.Panel panelConteudo;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlPanelFormAtual;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlPanelLogo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlPanelMenu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlPanelConteudo;
    }
}