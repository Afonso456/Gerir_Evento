using System.Diagnostics.Eventing.Reader;

namespace EventoTecnologia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //desativar a seleção multipla de linhas
            dgvDados.MultiSelect = false;

            //selecioar a linha toda
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //não permiter que o utilizador redimensione as colunas
            dgvDados.AllowUserToResizeColumns = false;

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

            cb_nomevento.Text = Dados.evento[0].Nome;
            dtp_data.Value = Dados.evento[0].Data;
            nup_participantes.Value = Dados.evento[0].CapacidadeMax;

            cb_nomevento.Enabled = false;
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

        private void chk_editar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_editar.Checked)
            {
                cb_nomevento.Enabled = true;
                dtp_data.Enabled = true;
                nup_participantes.Enabled = true;
            }
            else
            {
                cb_nomevento.Enabled = false;
                dtp_data.Enabled = false;
                nup_participantes.Enabled = false;
                //atualizar os dados do evento
                Dados.evento[0].Nome = cb_nomevento.Text;
                Dados.evento[0].Data = dtp_data.Value;
                Dados.evento[0].CapacidadeMax = (int)nup_participantes.Value;
            }
        }

        private void btn_adicionarevento_Click(object sender, EventArgs e)
        {

        }
    }
}
