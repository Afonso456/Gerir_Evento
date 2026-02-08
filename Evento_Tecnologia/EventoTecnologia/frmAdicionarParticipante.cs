using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventoTecnologia
{
    public partial class frmAdicionarParticipante : Form
    {
        BindingList<Participante> participantes;
        private Evento eventoSelecionado;
        public frmAdicionarParticipante(BindingList<Participante> lista, Evento evento)
        {
            InitializeComponent();
            participantes = lista;
            eventoSelecionado = evento;
        }

        //Botão que confirma a adição do participante á binding list de participantes e ao datagridview
        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text.Trim();
            string email = tb_email.Text.Trim();
            int idade = (int)nun_idade.Value;
            //verificar se ja existe um participante com o mesmo nome e email
            if (participantes.Any(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase) && p.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Já existe um participante com o mesmo nome e/ou email.");
                return;
            }
            // Validar campos
            if (string.IsNullOrWhiteSpace(nome))
            {
                errorProvider1.SetError(tb_nome, "Nome do participante é obrigatorio");
                return;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(email, pattern))
            {
                errorProvider1.SetError(tb_email, string.Empty);
            }
            else
            {
                errorProvider1.SetError(tb_email, "Email inválido");
                return;
            }

            //adicionar o participante á BindingList
            Participante p = new Participante()
            {
                Nome = tb_nome.Text,
                Email = tb_email.Text,
                Idade = idade,
                EventoId = eventoSelecionado.Id
            };

            participantes.Add(p);
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
