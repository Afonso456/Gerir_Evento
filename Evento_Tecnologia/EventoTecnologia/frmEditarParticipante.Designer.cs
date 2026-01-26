namespace EventoTecnologia
{
    partial class frmEditarParticipante
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
            nun_idade = new NumericUpDown();
            btb_cancelar = new Button();
            bt_confirmar = new Button();
            lb_email = new Label();
            lb_idade = new Label();
            lb_nome = new Label();
            tb_email = new TextBox();
            tb_nome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nun_idade).BeginInit();
            SuspendLayout();
            // 
            // nun_idade
            // 
            nun_idade.Location = new Point(347, 18);
            nun_idade.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            nun_idade.Name = "nun_idade";
            nun_idade.Size = new Size(46, 23);
            nun_idade.TabIndex = 9;
            nun_idade.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // btb_cancelar
            // 
            btb_cancelar.Location = new Point(172, 97);
            btb_cancelar.Name = "btb_cancelar";
            btb_cancelar.Size = new Size(96, 23);
            btb_cancelar.TabIndex = 10;
            btb_cancelar.Text = "C&ancelar";
            btb_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_confirmar
            // 
            bt_confirmar.Location = new Point(70, 97);
            bt_confirmar.Name = "bt_confirmar";
            bt_confirmar.Size = new Size(96, 23);
            bt_confirmar.TabIndex = 11;
            bt_confirmar.Text = "&Confirmar";
            bt_confirmar.UseVisualStyleBackColor = true;
            bt_confirmar.Click += bt_confirmar_Click;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Location = new Point(10, 59);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(36, 15);
            lb_email.TabIndex = 5;
            lb_email.Text = "Email";
            // 
            // lb_idade
            // 
            lb_idade.AutoSize = true;
            lb_idade.Location = new Point(287, 20);
            lb_idade.Name = "lb_idade";
            lb_idade.Size = new Size(36, 15);
            lb_idade.TabIndex = 6;
            lb_idade.Text = "Idade";
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Location = new Point(10, 20);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(40, 15);
            lb_nome.TabIndex = 7;
            lb_nome.Text = "Nome";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(70, 59);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(197, 23);
            tb_email.TabIndex = 8;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(70, 12);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(197, 23);
            tb_nome.TabIndex = 4;
            // 
            // frmEditarParticipante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 139);
            Controls.Add(nun_idade);
            Controls.Add(btb_cancelar);
            Controls.Add(bt_confirmar);
            Controls.Add(lb_email);
            Controls.Add(lb_idade);
            Controls.Add(lb_nome);
            Controls.Add(tb_email);
            Controls.Add(tb_nome);
            Name = "frmEditarParticipante";
            Text = "frmEditarParticipante";
            ((System.ComponentModel.ISupportInitialize)nun_idade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nun_idade;
        private Button btb_cancelar;
        private Button bt_confirmar;
        private Label lb_email;
        private Label lb_idade;
        private Label lb_nome;
        private TextBox tb_email;
        private TextBox tb_nome;
    }
}