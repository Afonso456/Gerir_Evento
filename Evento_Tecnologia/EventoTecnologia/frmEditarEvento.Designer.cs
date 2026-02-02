namespace EventoTecnologia
{
    partial class frmEditarEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dtp_data = new DateTimePicker();
            btn_cancelar = new Button();
            nun_participantes = new NumericUpDown();
            bt_confirmar = new Button();
            lb_detalhes = new Label();
            lb_participantes = new Label();
            lb_nome = new Label();
            tb_nome = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nun_participantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dtp_data
            // 
            dtp_data.Format = DateTimePickerFormat.Short;
            dtp_data.Location = new Point(70, 56);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(97, 23);
            dtp_data.TabIndex = 18;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(173, 100);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(96, 21);
            btn_cancelar.TabIndex = 17;
            btn_cancelar.Text = "C&ancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // nun_participantes
            // 
            nun_participantes.Location = new Point(382, 18);
            nun_participantes.Name = "nun_participantes";
            nun_participantes.Size = new Size(46, 23);
            nun_participantes.TabIndex = 12;
            // 
            // bt_confirmar
            // 
            bt_confirmar.Location = new Point(71, 99);
            bt_confirmar.Name = "bt_confirmar";
            bt_confirmar.Size = new Size(96, 23);
            bt_confirmar.TabIndex = 13;
            bt_confirmar.Text = "&Confirmar";
            bt_confirmar.UseVisualStyleBackColor = true;
            bt_confirmar.Click += bt_confirmar_Click;
            // 
            // lb_detalhes
            // 
            lb_detalhes.AutoSize = true;
            lb_detalhes.Location = new Point(12, 62);
            lb_detalhes.Name = "lb_detalhes";
            lb_detalhes.Size = new Size(52, 15);
            lb_detalhes.TabIndex = 14;
            lb_detalhes.Text = "Detalhes";
            // 
            // lb_participantes
            // 
            lb_participantes.AutoSize = true;
            lb_participantes.Location = new Point(292, 20);
            lb_participantes.Name = "lb_participantes";
            lb_participantes.Size = new Size(75, 15);
            lb_participantes.TabIndex = 15;
            lb_participantes.Text = "Participantes";
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Location = new Point(12, 20);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(40, 15);
            lb_nome.TabIndex = 16;
            lb_nome.Text = "Nome";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(72, 12);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(197, 23);
            tb_nome.TabIndex = 11;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEditarEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 143);
            Controls.Add(dtp_data);
            Controls.Add(btn_cancelar);
            Controls.Add(nun_participantes);
            Controls.Add(bt_confirmar);
            Controls.Add(lb_detalhes);
            Controls.Add(lb_participantes);
            Controls.Add(lb_nome);
            Controls.Add(tb_nome);
            Name = "frmEditarEvento";
            Text = "Editar Evento";
            Load += frmEditarEvento_Load;
            ((System.ComponentModel.ISupportInitialize)nun_participantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_data;
        private Button btn_cancelar;
        private NumericUpDown nun_participantes;
        private Button bt_confirmar;
        private Label lb_detalhes;
        private Label lb_participantes;
        private Label lb_nome;
        private TextBox tb_nome;
        private ErrorProvider errorProvider1;
    }
}