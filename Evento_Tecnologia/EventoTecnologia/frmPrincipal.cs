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
            CarregarJ();
        }
        BindingList<Evento> eventos;
        BindingList<Participante> participantes;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            eventos = Dados.LerEventos();
            participantes = Dados.LerParticipantes();

            cb_nomevento.DataSource = Dados.evento[0];
            dgvDados.DataSource = Dados.participante;

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

            cb_nomevento.DataSource = eventos;
            if (eventos.Count > 0)
            {
                cb_nomevento.Items.Add(evento.Nome);
                dtp_data.Value = Dados.evento[0].Data;
                nup_participantes.Value = Dados.evento[0].CapacidadeMax;
            }
            if(cb_nomevento.Items.Count > 0)
            {
                cb_nomevento.SelectedIndex = 0;
            }
                dtp_data.Value = eventos[0].Data;
                nup_participantes.Value = eventos[0].CapacidadeMax;
            }

            cb_nomevento.Enabled = true;
            dtp_data.Enabled = false;
            nup_participantes.Enabled = false;

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Dados.GuardarEventos(eventos);
            Dados.GuardarParticipantes(participantes);
            Application.Exit();
        }

        //Adicionar participantes chamando o formulario de adicionar_participante
        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarParticipante adicionarParticipante = new frmAdicionarParticipante();
            adicionarParticipante.ShowDialog();
        }
        //Remover a linha selecionada no datagridview
        private void bt_remover_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja remover o participante selecionado?", Dados.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int index = dgvDados.SelectedRows[0].Index;
                    participantes.RemoveAt(index);

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
            Adicionar_Evento adicionarevento = new Adicionar_Evento();
            adicionarevento.ShowDialog();
        }

        private void btn_removerevento_Click(object sender, EventArgs e)
        {
            if (Dados.evento.Count > 1)
            {
                DialogResult result = MessageBox.Show("Deseja remover o evento selecionado?", Dados.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    eventos.RemoveAt(eventos.Count - 1);
                    //atualizar os dados do evento na tela
                    cb_nomevento.Text = Dados.evento[Dados.evento.Count - 1].Nome;
                    if (eventos.Count > 0)
                    {
                        dtp_data.Value = eventos[0].Data;
                        nup_participantes.Value = eventos[0].CapacidadeMax;
                    }
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("Não é possivel remover o ultimo evento.");
            }
        }

        private void btn_editarevento_Click(object sender, EventArgs e)
        {
            frmEditarEvento editarevento = new frmEditarEvento();
            editarevento.ShowDialog();

            //atualizar os dados do evento de acordo com as edições feitas
            cb_nomevento.Text = eventos[0].Nome;
            if (eventos.Count > 0)
            {
                dtp_data.Value = eventos[0].Data;
                nup_participantes.Value = eventos[0].CapacidadeMax;
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            frmEditarParticipante editarparticipante = new frmEditarParticipante();
            editarparticipante.ShowDialog();

            //atualizar os dados do participante de acordo com as edições feitas
            dgvDados.Refresh();
        }

        public void GuardarJ()
        {
            try
            {
                string json = JsonSerializer.Serialize(Dados.evento, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("evento.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar os dados: " + ex.Message);
            }
        }
        public void CarregarJ()
        {
            try
            {
                if (File.Exists("evento.json"))
                {
                    string json = File.ReadAllText("evento.json");
                    var eventos = JsonSerializer.Deserialize<BindingList<Evento>>(json,
                        new JsonSerializerOptions { }) ?? new BindingList<Evento>();
                    Dados.evento = eventos; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }
    }
}
