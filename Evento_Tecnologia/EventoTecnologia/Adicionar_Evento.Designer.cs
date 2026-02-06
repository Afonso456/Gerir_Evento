namespace EventoTecnologia
{
    partial class Adicionar_Evento
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
            nun_participantes = new NumericUpDown();
            bt_confirmar = new Button();
            lb_detalhes = new Label();
            lb_participantes = new Label();
            lb_nome = new Label();
            tb_nome = new TextBox();
            btn_cancelar = new Button();
            dtp_data = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nun_participantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // nun_participantes
            // 
            nun_participantes.Location = new Point(391, 29);
            nun_participantes.Name = "nun_participantes";
            nun_participantes.Size = new Size(46, 23);
            nun_participantes.TabIndex = 2;
            // 
            // bt_confirmar
            // 
            bt_confirmar.Location = new Point(80, 110);
            bt_confirmar.Name = "bt_confirmar";
            bt_confirmar.Size = new Size(96, 23);
            bt_confirmar.TabIndex = 3;
            bt_confirmar.Text = "&Confirmar";
            bt_confirmar.UseVisualStyleBackColor = true;
            bt_confirmar.Click += bt_confirmar_Click;
            // 
            // lb_detalhes
            // 
            lb_detalhes.AutoSize = true;
            lb_detalhes.Location = new Point(21, 73);
            lb_detalhes.Name = "lb_detalhes";
            lb_detalhes.Size = new Size(52, 15);
            lb_detalhes.TabIndex = 6;
            lb_detalhes.Text = "Detalhes";
            // 
            // lb_participantes
            // 
            lb_participantes.AutoSize = true;
            lb_participantes.Location = new Point(301, 31);
            lb_participantes.Name = "lb_participantes";
            lb_participantes.Size = new Size(75, 15);
            lb_participantes.TabIndex = 7;
            lb_participantes.Text = "Participantes";
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Location = new Point(21, 31);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(40, 15);
            lb_nome.TabIndex = 8;
            lb_nome.Text = "Nome";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(81, 23);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(197, 23);
            tb_nome.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(182, 111);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(96, 21);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "C&ancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // dtp_data
            // 
            dtp_data.Format = DateTimePickerFormat.Short;
            dtp_data.Location = new Point(79, 67);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(97, 23);
            dtp_data.TabIndex = 10;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Adicionar_Evento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 149);
            Controls.Add(dtp_data);
            Controls.Add(btn_cancelar);
            Controls.Add(nun_participantes);
            Controls.Add(bt_confirmar);
            Controls.Add(lb_detalhes);
            Controls.Add(lb_participantes);
            Controls.Add(lb_nome);
            Controls.Add(tb_nome);
            Name = "Adicionar_Evento";
            Text = "Adicionar Evento";
            Load += Adicionar_Evento_Load;
            ((System.ComponentModel.ISupportInitialize)nun_participantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nun_participantes;
        private Button bt_confirmar;
        private Label lb_detalhes;
        private Label lb_participantes;
        private Label lb_nome;
        private TextBox tb_nome;
        private Button btn_cancelar;
        private DateTimePicker dtp_data;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}