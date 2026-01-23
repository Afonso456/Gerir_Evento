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

            // Validar campos
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Nome invalido");
                return;
            }

            if (idade < 0)
            {
                MessageBox.Show("Idade tem que ser um numero positivo maior que zero");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("Email precisa conter '@' para ser valido");
                return;
            }

            // Adicionar a BindingList
            Dados.participante.Add(new Participante(nome, idade,email));

            // Limpas os campos depois de adicionar
            tb_nome.Clear();
            nun_idade.Value = 0;
            tb_email.Clear();

            MessageBox.Show("Participante Adicionado");

            frmAdicionarParticipante.ActiveForm.Close();
        }

    }
}
