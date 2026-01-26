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
            string nome = tb_nome.Text.Trim();
            DateTime data = dtp_data.Value;
            int capacidade = (int)nun_participantes.Value;


            Dados.evento.Add(new Evento(nome, data, capacidade));

            // Limpar os campos depois de adicionar
            tb_nome.Clear();
            dtp_data.Value = DateTime.Now;
            nun_participantes.Value = 0;
            

            MessageBox.Show("Evento Adicionado");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ação Cancelada");
            Adicionar_Evento.ActiveForm.Close();
        }
    }
}
