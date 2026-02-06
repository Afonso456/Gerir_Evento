using System.ComponentModel;
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
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //desativar a seleção multipla de linhas
            dgvDados.MultiSelect = false;

            //selecioar a linha toda
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //não permiter que o utilizador redimensione as colunas
            dgvDados.AllowUserToResizeColumns = false;
            dgvDados.AllowUserToResizeRows = false;

            //não permiter que o utilizador adicione ou remove colunas
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;


            dgvDados.RowHeadersVisible = false;
            dgvDados.ReadOnly = true;
            dgvDados.DataSource = Dados.participante;
            for (int i = 3; i < dgvDados.Columns.Count; i++)
            {
                dgvDados.Columns[i].Visible = true;
            }

            foreach (var evento in Dados.evento)
            {
                cb_nomevento.Items.Add(evento.Nome);
                dtp_data.Value = Dados.evento[0].Data;
                nup_participantes.Value = Dados.evento[0].CapacidadeMax;
            }
            if(cb_nomevento.Items.Count > 0)
            {
                cb_nomevento.SelectedIndex = 0;
            }
            cb_nomevento.Enabled = true;
            dtp_data.Enabled = false;
            nup_participantes.Enabled = false;

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
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
                    Dados.participante.RemoveAt(index);
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
                    Dados.evento.RemoveAt(Dados.evento.Count - 1);
                    //atualizar os dados do evento na tela
                    cb_nomevento.Text = Dados.evento[Dados.evento.Count - 1].Nome;
                    dtp_data.Value = Dados.evento[Dados.evento.Count - 1].Data;
                    nup_participantes.Value = Dados.evento[Dados.evento.Count - 1].CapacidadeMax;
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
            cb_nomevento.Text = Dados.evento[0].Nome;
            dtp_data.Value = Dados.evento[0].Data;
            nup_participantes.Value = Dados.evento[0].CapacidadeMax;

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
