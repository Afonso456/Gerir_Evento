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
        Participante participante;
        public frmEditarParticipante(Participante p)
        {
            InitializeComponent();
            this.participante = p;
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string email = tb_email.Text;
            int idade = Convert.ToInt32(nun_idade.Value);
            // Validar campos
            if (string.IsNullOrWhiteSpace(nome))
            {
                errorProvider1.SetError(tb_nome, "Nome do participante é obrigatorio");
                return;
            }

            if (idade < 16)
            {
                errorProvider1.SetError(nun_idade, "Idade precisa ser maior que 16 anos");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                errorProvider1.SetError(tb_email, "Email inválido");
                return;
            }
            //Atualizar o participante na BindingList
            participante.Nome = tb_nome.Text;
            participante.Idade = idade;
            participante.Email = email;

            // Limpas os campos depois de adicionar
            tb_nome.Clear();
            nun_idade.Value = 16;
            tb_email.Clear();

            MessageBox.Show("Participante Adicionado");

            Close();
        }

        private void btb_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditarParticipante_Load(object sender, EventArgs e)
        {
            //carregar os dados do participante nos campos
            if (participante != null)
            {
                tb_nome.Text = participante.Nome;
                nun_idade.Value = participante.Idade;
                tb_email.Text = participante.Email;
            }
        }
    }
}
