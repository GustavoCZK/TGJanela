using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JanelaBD
{
    public partial class FormPrin : Form
    {
        enum Acoes
        {
            DESENHAR,
            LIMPAR
        }
        private Acoes acao = Acoes.LIMPAR;

        private int count = 1;
        public FormPrin()
        {
            InitializeComponent();

        }

        public FormPrin(string o)
        {
            InitializeComponent();
            lbObjetos.Items.Add(o);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            Objeto o = new Objeto(boxName.Text, cbPonto, cbReta, Int32.Parse(corX.Text), Int32.Parse(corY.Text), Int32.Parse(corZ.Text));

            lbObjetos.Items.Add(o);

            boxName.Text = "";
            corX.Text = "";
            corY.Text = "";
            corZ.Text = "";


            acao = Acoes.DESENHAR;
            pbCaixaDesenho.Invalidate();

            // CreateObject createObject = new CreateObject();
            // createObject.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int posicao = lbObjetos.SelectedIndex;
            if (posicao != -1)
            {
                lbObjetos.Items.RemoveAt(lbObjetos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            acao = Acoes.LIMPAR;
            lbObjetos.Items.Clear();
            pbCaixaDesenho.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbCaixaDesenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen caneta = new Pen(Color.Black, 5);
            Brush Pincel = new SolidBrush(Color.Black);

            if (acao == Acoes.DESENHAR)
            {
                g.FillEllipse(Pincel, 10, 10, 5, 5);
            }
            else if (acao == Acoes.LIMPAR)
            {
                g.Clear(SystemColors.ActiveCaption);
            }

            // Desenha uma borda
            g.DrawRectangle(caneta, 0, 0,
                        pbCaixaDesenho.Width - 1,
                        pbCaixaDesenho.Height - 1);

            System.Diagnostics.Debug.WriteLine(count++);
        }
    }
    
}
