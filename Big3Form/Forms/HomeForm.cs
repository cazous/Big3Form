using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Big3Form.Forms
{
    public partial class HomeForm : Form
    {
       
        private IconButton btnAtual;
        private Panel bordaEsquerdabtn;
        private Form formAtual;
        public HomeForm()
        {
            InitializeComponent();
            bordaEsquerdabtn = new Panel();
            bordaEsquerdabtn.Size = new Size(7, 55);
            panelMenu.Controls.Add(bordaEsquerdabtn);
        }
        //Structs
        private struct Cores
        {
            public static Color amareloCustom = Color.FromArgb(255, 200, 0);
        }

        private void AtivarBotao(object _button, Color _color)
        {
            if(_button != null)
            {
                DesativarBotao();
                //Botão
                btnAtual = (IconButton)_button;
                btnAtual.BackColor = Color.FromArgb(20, 20, 70);
                btnAtual.ForeColor = _color;
                btnAtual.TextAlign = ContentAlignment.MiddleCenter;
                btnAtual.IconColor = _color;
                btnAtual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnAtual.ImageAlign = ContentAlignment.MiddleRight;
                //Borda esquerda botão
                bordaEsquerdabtn.BackColor = _color;
                bordaEsquerdabtn.Location = new Point(0, btnAtual.Location.Y);
                bordaEsquerdabtn.Visible = true;
                bordaEsquerdabtn.BringToFront();
                //Painel superior
                iconFormAtual.IconChar = btnAtual.IconChar;
                iconFormAtual.ForeColor = _color;
                labelFormAtual.Text = btnAtual.Text;
                labelFormAtual.ForeColor = _color;
                //HomeLabel
                btnHome.ForeColor = _color;
                //Fechar & Minimizar
                iconButtonClose.IconColor = _color;
                iconButtonMinimize.IconColor = _color;
            }
        }

        private void DesativarBotao()
        {
            if (btnAtual != null)
            {
                btnAtual.BackColor = Color.FromArgb(40,40,90);
                btnAtual.ForeColor = Color.White;
                btnAtual.TextAlign = ContentAlignment.MiddleLeft;
                btnAtual.IconColor = Color.White;
                btnAtual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnAtual.ImageAlign = ContentAlignment.MiddleLeft;
                iconButtonClose.IconColor = Color.Goldenrod;
                iconButtonMinimize.IconColor = Color.Goldenrod;
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonJogos_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, Color.DarkOrange);
            AbrirFormConteudo(new JogosForm());
        }

        private void iconButtonJogador_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, Cores.amareloCustom);
            AbrirFormConteudo(new JogadorForm());
        }

        private void iconButtonGrafico_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, Color.Red);
            AbrirFormConteudo(new GraficoForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            Reset();
        }
        private void Reset()
        {
            DesativarBotao();
            btnHome.ForeColor = Color.Goldenrod;
            bordaEsquerdabtn.Visible = false;
            iconFormAtual.IconChar = IconChar.Home;
            iconFormAtual.ForeColor = Color.Goldenrod;
            labelFormAtual.Text = "Home";
            labelFormAtual.ForeColor = Color.Goldenrod;
            iconButtonClose.ForeColor = Color.Goldenrod;
            iconButtonMinimize.ForeColor = Color.Goldenrod;
        }

        private void AbrirFormConteudo(Form _form)
        {
            if (formAtual != null)
            {
                formAtual.Close();
            }
            formAtual = _form;
            _form.TopLevel = false;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(_form);
            panelConteudo.Tag = _form;
            _form.BringToFront();
            _form.Show();
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
