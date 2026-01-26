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
            tb_nome.Text = "txt";
            tb_email.Text = "txt";
            int idade = (int)nun_idade.Value;

            // Validar campos
            if (string.IsNullOrWhiteSpace("txt"))
            {
                MessageBox.Show("Nome invalido");
                return;
            }

            if (idade < 0)
            {
                MessageBox.Show("Idade tem que ser um numero positivo maior que zero");
                return;
            }

            if (string.IsNullOrWhiteSpace("txt") || !"txt".Contains("@"))
            {
                MessageBox.Show("Email precisa conter '@' para ser valido");
                return;
            }

            // Adicionar a BindingList
            Dados.participante.Add(new Participante("txt", idade, "txt"));

            // Limpas os campos depois de adicionar
            tb_nome.Clear();
            nun_idade.Value = 0;
            tb_email.Clear();

            MessageBox.Show("Participante Adicionado");

            frmAdicionarParticipante.ActiveForm.Close();
        }

        private void btb_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ação Cancelada");
            frmAdicionarParticipante.ActiveForm.Close();
        }
    }
}
