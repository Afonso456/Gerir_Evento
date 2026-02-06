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
    public partial class Adicionar_Evento : Form
    {
        public Adicionar_Evento()
        {
            InitializeComponent();
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            //TODO: adicionar validações necessárias usando o errorprovider
            string nome = tb_nome.Text.Trim();
            DateTime data = dtp_data.Value;
            int capacidade = (int)nun_participantes.Value;

            if (string.IsNullOrEmpty(nome))
            {
                errorProvider1.SetError(tb_nome, "O nome do evento não pode estar vazio.");
                return;
            }


            Dados.evento.Add(new Evento(nome, data, capacidade));

            MessageBox.Show("Evento Adicionado");
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ação Cancelada");
            Close();
        }

        private void Adicionar_Evento_Load(object sender, EventArgs e)
        {
            dtp_data.MinDate = DateTime.Now;
        }
    }
}
