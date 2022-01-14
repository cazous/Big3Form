using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big3Form.Forms
{
    public partial class JogosForm : Form
    {
        public JogosForm()
        {
            InitializeComponent();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void JogosForm_Load(object sender, EventArgs e)
        {

        }

        //Coluna status tem que ser preenchida automaticamente ao cadastrar jogos novos com um 'W' verde ou com um 'L' vermelho
    }
}
