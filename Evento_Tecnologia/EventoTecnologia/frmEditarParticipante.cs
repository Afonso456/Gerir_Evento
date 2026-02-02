using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoTecnologia
{
    public partial class frmEditarParticipante : Form
    {
        public frmEditarParticipante()
        {
            InitializeComponent();
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            int idade = Convert.ToInt32(nun_idade.Value);
            //TODO: Trocar os if's pelo errorprovider
            // Validar campos
            if (string.IsNullOrWhiteSpace("txt"))
            {
                MessageBox.Show("Nome invalido");
                return;
            }

            if (idade < 0 || idade < 16)
            {
                MessageBox.Show("Idade tem que ser um numero positivo maior que zero e maior de 16");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("Email precisa conter '@' para ser valido");
                return;
            }

            // Editar o participante na BindingList
            Dados.participante[0].Nome = tb_nome.Text;
            Dados.participante[0].Idade = idade;
            Dados.participante[0].Email = email;

            // Limpas os campos depois de adicionar
            tb_nome.Clear();
            nun_idade.Value = 16;
            tb_email.Clear();

            MessageBox.Show("Participante Adicionado");

            frmAdicionarParticipante.ActiveForm.Close();
        }

        private void btb_cancelar_Click(object sender, EventArgs e)
        {
            frmAdicionarParticipante.ActiveForm.Close();
        }

        private void frmEditarParticipante_Load(object sender, EventArgs e)
        {
            tb_nome.Text = Dados.participante[0].Nome;
            tb_email.Text = Dados.participante[0].Email;
            nun_idade.Value = Dados.participante[0].Idade;
        }
    }
}
