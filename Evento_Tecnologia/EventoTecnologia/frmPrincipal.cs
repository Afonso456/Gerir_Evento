using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Text.Json;

namespace EventoTecnologia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        BindingList<Evento> eventos;
        BindingList<Participante> participantes;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            eventos = Dados.LerEventos() ?? new BindingList<Evento>();
            participantes = Dados.LerParticipantes() ?? new BindingList<Participante>();

            cb_nomevento.DataSource = eventos;
            cb_nomevento.DisplayMember = "Nome";
            cb_nomevento.ValueMember = "Id";
            dgvDados.DataSource = participantes;

            //desativar a seleção multipla de linhas
            dgvDados.MultiSelect = false;

            //selecionar a linha toda
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //não permiter que o utilizador redimensione as colunas
            dgvDados.AllowUserToResizeColumns = false;
            dgvDados.AllowUserToResizeRows = false;

            //adaptar o tamanho das colunas ao conteudo e ao tamanho da dataGridView
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //alterar o tamanho da coluna da idade para o tamanho do conteudo
            dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //não permiter que o utilizador adicione ou remove colunas
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;


            dgvDados.RowHeadersVisible = false;
            dgvDados.ReadOnly = true;
            for (int i = 3; i < dgvDados.Columns.Count; i++)
            {
                dgvDados.Columns[i].Visible = true;
            }

            dtp_data.Enabled = false;
            nup_participantes.Enabled = false;

            if (eventos.Count > 0)
            {
                dtp_data.Value = eventos[0].Data;
                nup_participantes.Value = eventos[0].CapacidadeMax;
            }

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Adicionar participantes chamando o formulario de adicionar_participante
        private void bt_adicionarp_Click(object sender, EventArgs e)
        {
            if (eventos.Count == 0)
            {
                MessageBox.Show("Adicione um evento antes de adicionar participantes.");
                return;
            }
            //verificar se o numero de participantes é menor que a capacidade maxima do evento
            if (participantes.Count >= eventos[0].CapacidadeMax)
            {
                MessageBox.Show("O número máximo de participantes para este evento foi atingido.");
                return;
            }

            Evento eventoselecionado = (Evento)cb_nomevento.SelectedItem;
            frmAdicionarParticipante f = new frmAdicionarParticipante(participantes,eventoselecionado);
            f.ShowDialog();

        }
        private void btn_editarp_Click(object sender, EventArgs e)
        {
            //verificar se existe um participante para editar
            if (participantes.Count == 0)
            {
                MessageBox.Show("Não há participantes para editar.");
                return;
            }
            Participante p =
                (Participante)dgvDados.SelectedRows[0].DataBoundItem;
            frmEditarParticipante editarparticipante = new frmEditarParticipante(p);
            editarparticipante.ShowDialog();

            //atualizar os dados do participante de acordo com as edições feitas
            dgvDados.Refresh();
        }
        //Remover a linha selecionada no datagridview
        private void bt_removerp_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover o participante selecionado?", Dados.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Participante p = (Participante)dgvDados.SelectedRows[0].DataBoundItem;
                    participantes.Remove(p);
                }

                else
                    return;
            }
            else
            {
                MessageBox.Show("Selecione uma linha para remover.");
            }
        }

        private void btn_adicionarevento_Click(object sender, EventArgs e)
        {
            Adicionar_Evento f = new Adicionar_Evento(eventos);

            f.ShowDialog();

            //atualizar os dados do evento de acordo com o evento adicionado
            cb_nomevento.Text = eventos[eventos.Count - 1].Nome;
            if (eventos.Count > 0)
            {
                dtp_data.Value = eventos[eventos.Count - 1].Data;
                nup_participantes.Value = eventos[eventos.Count - 1].CapacidadeMax;
            }
        }

        private void btn_removerevento_Click(object sender, EventArgs e)
        {
            if (eventos.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover o evento selecionado?", Dados.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    eventos.RemoveAt(0);
                    participantes.Clear();
                    cb_nomevento.Text = "";
                    dtp_data.Value = DateTime.Now;
                    nup_participantes.Value = 0;
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("Não há eventos para remover.");
            }
        }

        private void btn_editarevento_Click(object sender, EventArgs e)
        {
            //verificar se existe um evento para editar
            if (eventos.Count == 0)
            {
                MessageBox.Show("Não há eventos para editar.");
                return;
            }
            Evento ev =
                (Evento)cb_nomevento.SelectedItem;
            frmEditarEvento editarevento = new frmEditarEvento(ev);
            editarevento.ShowDialog();

            //atualizar os dados do evento de acordo com as edições feitas
            cb_nomevento.Refresh();

            //atualizar os dados do evento de acordo com as edições feitas
            cb_nomevento.Text = eventos[0].Nome;
            if (eventos.Count > 0)
            {
                dtp_data.Value = eventos[0].Data;
                nup_participantes.Value = eventos[0].CapacidadeMax;
            }
        }

        private void cb_nomevento_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarDataGridParticipantes();
        }
        private void AtualizarDataGridParticipantes()
        {
            if (cb_nomevento.SelectedItem == null) return;

            int eventoIdSelecionado = ((Evento)cb_nomevento.SelectedItem).Id;
            var participantesDoEvento = participantes
                                        .Where(p => p.EventoId == eventoIdSelecionado)
                                        .ToList();

            dgvDados.DataSource = participantesDoEvento;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dados.GuardarEventos(eventos);
            Dados.GuardarParticipantes(participantes);
        }
    }
}
