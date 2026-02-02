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
    public partial class frmEditarEvento : Form
    {
        public frmEditarEvento()
        {
            InitializeComponent();
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            int capacidade = (int)nun_participantes.Value;

            // Validar campos
            if (string.IsNullOrWhiteSpace("txt"))
            {
                MessageBox.Show("Evento invalido");
                return;
            }

            if (capacidade < 0)
            {
                MessageBox.Show("Numero de participantes tem que ser maior que zero");
                return;
            }

            // Adicionar o evento na BindingList
            Dados.evento[0].Nome = nome;
            Dados.evento[0].Data = dtp_data.Value;
            Dados.evento[0].CapacidadeMax = capacidade;

            MessageBox.Show("Evento Editado");

            frmAdicionarParticipante.ActiveForm.Close();
        }

        private void frmEditarEvento_Load(object sender, EventArgs e)
        {
            //carregar os dados do evento nos campos
            tb_nome.Text = Dados.evento[0].Nome;
            dtp_data.Value = Dados.evento[0].Data;
            dtp_data.MinDate = DateTime.Now;
            nun_participantes.Value = Dados.evento[0].CapacidadeMax;
        }
    }
}
