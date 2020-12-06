using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios
{
    public partial class frmSistema : Form
    {
        public frmSistema()
        {
            InitializeComponent();
        }

        private void frmSistema_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro objfrmcadastro = new frmCadastro(); // crio um objeto para instancia o frmcadastro

            objfrmcadastro.MdiParent = this; // digo que o frmcadastro vai ser o formulario filho do frmsistema


            this.DesabilitaBotoes(sender, e); // instancio o metodo desabilita botoes

            objfrmcadastro.tsbtnCancelar.Click += new EventHandler(this.HabilitaBotoes); //instancio o objfrmcadastro para que quando o click em cancelar os botoes do sistema volte a habilitar
            objfrmcadastro.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes); ////instancio o objfrmcadastro para que quando o click em cancelar os botoes do sistema volte a habilitar



            if (objfrmcadastro.Visible == false) // instancio o objfrmcadastro e comparo se ele está visivel. Se voltar false 
            {
                objfrmcadastro.Show(); // ele abre o formulario
                
            }
            else
            {
                // se comparar e vier verdadeiro ele exibe uma imagem de erro, onde só pode abrir 1 form por vez.   
                MessageBox.Show("O formulário já está aberto com a gravação dos dados em andamento! Feche este formulário para abrir outro!",
                                                                    "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
            
        }
        private void DesabilitaBotoes(object sender, EventArgs e)// metodo para desabilitar botoes.
        {
            
            tsbtnCadastrar.Enabled = false; // botao cadastrar ficara falso
            tsbtnSair.Enabled = false;  // botao sair ficara falso

        }
        private void HabilitaBotoes(object sender, EventArgs e)// metodo para habilitar botoes
        {
           
            tsbtnCadastrar.Enabled = true; // botao cadastrar ficara verdadeiro
            tsbtnSair.Enabled = true;   // botao sair ficara verdadeiro
        }

        private void tsbtnSair_Click(object sender, EventArgs e)// metodo para botão sair.
        {
            // faço uma condição que ao clicar no botão sair apereça uma mensagem, com um questionamento e se o resultado for sim.
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); // a aplicação fechará
            }
        }

    }
}
