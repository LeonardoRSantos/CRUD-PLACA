using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Usuarios
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            pbBarra.Increment(1);// avança a posição atual da barra de progresso na quantidade especificada

            if (pbBarra.Value == 100)
            {

                relogio.Stop(); // para o relogio 
                this.Hide();// fecha a janela após completar 100%
                frmSistema sistema = new frmSistema();//cria um objeto para instanciar o sistema
                sistema.ShowDialog();// abre o sistema
                

            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            this.Opacity =0; //define o nivel da opacidade do formulario e começa com 0

            for (double i = 0; i <= 1; i += 0.1) // para variavel double i = 0, i menor ou igual a 1, vari acrecentar i em 0.1 até chegar
            {
                this.Opacity = i; // a opacity receberá o valor de I
                this.Refresh();    //Atualiza o form para que venha instantâneo 
                Thread.Sleep(15); //Suspende o thread atual para o período de tempo especificado.

            }

        }
    }
}
