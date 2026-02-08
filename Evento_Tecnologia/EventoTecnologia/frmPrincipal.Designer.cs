namespace EventoTecnologia
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            dtp_data = new DateTimePicker();
            bt_remover = new Button();
            bt_adicionarp = new Button();
            bt_sair = new Button();
            groupBox1 = new GroupBox();
            btn_editar = new Button();
            dgvDados = new DataGridView();
            nup_participantes = new NumericUpDown();
            cb_nomevento = new ComboBox();
            btn_adicionarevento = new Button();
            btn_removerevento = new Button();
            btn_editarevento = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nup_participantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 54);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 56);
            label4.Name = "label4";
            label4.Size = new Size(168, 15);
            label4.TabIndex = 0;
            label4.Text = "Numero Maximo Participantes";
            // 
            // dtp_data
            // 
            dtp_data.Format = DateTimePickerFormat.Short;
            dtp_data.Location = new Point(103, 54);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(102, 23);
            dtp_data.TabIndex = 2;
            // 
            // bt_remover
            // 
            bt_remover.Location = new Point(530, 188);
            bt_remover.Name = "bt_remover";
            bt_remover.Size = new Size(78, 38);
            bt_remover.TabIndex = 4;
            bt_remover.Text = "&Remover Inscrição";
            bt_remover.UseVisualStyleBackColor = true;
            bt_remover.Click += bt_removerp_Click;
            // 
            // bt_adicionarp
            // 
            bt_adicionarp.Location = new Point(530, 144);
            bt_adicionarp.Name = "bt_adicionarp";
            bt_adicionarp.Size = new Size(78, 38);
            bt_adicionarp.TabIndex = 4;
            bt_adicionarp.Text = "&Inscrever Participante";
            bt_adicionarp.UseVisualStyleBackColor = true;
            bt_adicionarp.Click += bt_adicionarp_Click;
            // 
            // bt_sair
            // 
            bt_sair.Location = new Point(567, 359);
            bt_sair.Name = "bt_sair";
            bt_sair.Size = new Size(75, 26);
            bt_sair.TabIndex = 4;
            bt_sair.Text = "&Sair";
            bt_sair.UseVisualStyleBackColor = true;
            bt_sair.Click += bt_sair_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_editar);
            groupBox1.Controls.Add(dgvDados);
            groupBox1.Controls.Add(bt_remover);
            groupBox1.Controls.Add(bt_adicionarp);
            groupBox1.Location = new Point(34, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(625, 240);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Participantes";
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(530, 100);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(78, 38);
            btn_editar.TabIndex = 6;
            btn_editar.Text = "&Editar Participante";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editarp_Click;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(17, 19);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(494, 207);
            dgvDados.TabIndex = 5;
            // 
            // nup_participantes
            // 
            nup_participantes.Location = new Point(460, 54);
            nup_participantes.Name = "nup_participantes";
            nup_participantes.Size = new Size(85, 23);
            nup_participantes.TabIndex = 6;
            // 
            // cb_nomevento
            // 
            cb_nomevento.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_nomevento.FormattingEnabled = true;
            cb_nomevento.Location = new Point(103, 22);
            cb_nomevento.Name = "cb_nomevento";
            cb_nomevento.Size = new Size(442, 23);
            cb_nomevento.TabIndex = 7;
            cb_nomevento.SelectedIndexChanged += cb_nomevento_SelectedIndexChanged;
            // 
            // btn_adicionarevento
            // 
            btn_adicionarevento.Location = new Point(36, 359);
            btn_adicionarevento.Name = "btn_adicionarevento";
            btn_adicionarevento.Size = new Size(114, 26);
            btn_adicionarevento.TabIndex = 8;
            btn_adicionarevento.Text = "&Adicionar Evento";
            btn_adicionarevento.UseVisualStyleBackColor = true;
            btn_adicionarevento.Click += btn_adicionarevento_Click;
            // 
            // btn_removerevento
            // 
            btn_removerevento.Location = new Point(156, 359);
            btn_removerevento.Name = "btn_removerevento";
            btn_removerevento.Size = new Size(118, 26);
            btn_removerevento.TabIndex = 8;
            btn_removerevento.Text = "R&emover Evento";
            btn_removerevento.UseVisualStyleBackColor = true;
            btn_removerevento.Click += btn_removerevento_Click;
            // 
            // btn_editarevento
            // 
            btn_editarevento.Location = new Point(280, 359);
            btn_editarevento.Name = "btn_editarevento";
            btn_editarevento.Size = new Size(118, 26);
            btn_editarevento.TabIndex = 8;
            btn_editarevento.Text = "&Editar Evento";
            btn_editarevento.UseVisualStyleBackColor = true;
            btn_editarevento.Click += btn_editarevento_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 397);
            Controls.Add(btn_editarevento);
            Controls.Add(btn_removerevento);
            Controls.Add(btn_adicionarevento);
            Controls.Add(cb_nomevento);
            Controls.Add(nup_participantes);
            Controls.Add(groupBox1);
            Controls.Add(bt_sair);
            Controls.Add(dtp_data);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "Gestão de Inscrições para Eventos de Tecnologia";
            FormClosing += frmPrincipal_FormClosing;
            Load += frmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)nup_participantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private DateTimePicker dtp_data;
        private Button bt_remover;
        private Button bt_adicionarp;
        private Button bt_sair;
        private GroupBox groupBox1;
        private NumericUpDown nup_participantes;
        private DataGridView dgvDados;
        private Button btn_editar;
        private ComboBox cb_nomevento;
        private Button btn_adicionarevento;
        private Button btn_removerevento;
        private Button btn_editarevento;
    }
}
