using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventoTecnologia
{
    public partial class frmAdicionarParticipante : Form
    {
        public frmAdicionarParticipante()
        {
            InitializeComponent();
        }

        //Botão que confirma a adição do participante á binding list de participantes e ao datagridview
        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text.Trim();
            string email = tb_email.Text.Trim();
            int idade = (int)nun_idade.Value;
            //TODO: Trocar os if's pelo errorprovider
            // Validar campos
            if (string.IsNullOrWhiteSpace(nome))
            {
                errorProvider1.SetError(tb_nome, "Nome do participante é obrigatorio");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                errorProvider1.SetError(tb_email, "Email inválido");
                return;
            }

            // Adicionar a BindingList
            Dados.participante.Add(new Participante(nome, idade, email));

            MessageBox.Show("Participante Adicionado");

            Close();
        }

        private void btb_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ação Cancelada");
            Close();
        }
    }
}
