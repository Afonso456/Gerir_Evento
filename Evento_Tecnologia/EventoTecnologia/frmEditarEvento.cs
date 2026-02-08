using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventoTecnologia
{
    public partial class frmEditarEvento : Form
    {
        Evento evento;
        public frmEditarEvento(Evento ev)
        {
            InitializeComponent();
            this.evento = ev;
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            int capacidade = (int)nun_participantes.Value;
            //TODO: Trocar os if's pelo errorprovider
            if (capacidade < Dados.Participante.Count)
            {
                errorProvider1.SetError(nun_participantes, "Capacidade menor que o numero de participantes ja inscritos");
                return;
            }

            // Validar campos
            if (string.IsNullOrWhiteSpace("txt"))
            {
                errorProvider1.SetError(tb_nome, "Nome do evento e obrigatorio");
                return;
            }

            //verificar se o numero de participantes é menor que 0 e menor que o numero de participantes ja inscritos
            if (capacidade < 0)
            {
                errorProvider1.SetError(nun_participantes, "Capacidade do evento precisa ser maior que 0");
                return;
            }
            if (capacidade < Dados.Participante.Count)
            {
                errorProvider1.SetError(nun_participantes, "Capacidade do evento precisa ser maior que o numero atual de participantes");
                return;
            }
            //Atualizar o evento na BindingList
            evento.Nome = tb_nome.Text;
            evento.Data = dtp_data.Value;
            evento.CapacidadeMax = capacidade;

            MessageBox.Show("Evento Editado");

            Close();
        }

        private void frmEditarEvento_Load(object sender, EventArgs e)
        {
            //carregar os dados do evento nos campos
            if (evento != null)
            {
                tb_nome.Text = evento.Nome;
                dtp_data.Value = evento.Data;
                nun_participantes.Value = evento.CapacidadeMax;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
