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
        BindingList<Evento> eventos;
        public Adicionar_Evento(BindingList<Evento> eventos)
        {
            InitializeComponent();
            this.eventos = eventos;
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text.Trim();
            DateTime data = dtp_data.Value;
            int capacidade = (int)nun_participantes.Value;

            if (string.IsNullOrEmpty(nome))
            {
                errorProvider1.SetError(tb_nome, "O nome do evento não pode estar vazio.");
                return;
            }

            if(nun_participantes.Value <= 0)
            {
                errorProvider1.SetError(nun_participantes, "A capacidade deve ser maior que 0.");
                return;
            }
            //verificar se o nome do evento ja existe
            if (eventos.Any(ev => ev.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(tb_nome, "Já existe um evento com esse nome.");
                return;
            }
            //adicionar o evento á BindingList
            Evento ev = new Evento(
            tb_nome.Text,
            dtp_data.Value,
            (int)nun_participantes.Value);
            eventos.Add(ev);
            MessageBox.Show("Evento adicionado");
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
