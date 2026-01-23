namespace EventoTecnologia
{
    partial class frmAdicionarParticipante
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
            tb_nome = new TextBox();
            tb_email = new TextBox();
            lb_nome = new Label();
            lb_idade = new Label();
            lb_email = new Label();
            bt_confirmar = new Button();
            nun_idade = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nun_idade).BeginInit();
            SuspendLayout();
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(82, 11);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(197, 23);
            tb_nome.TabIndex = 0;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(82, 58);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(197, 23);
            tb_email.TabIndex = 0;
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Location = new Point(22, 19);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(40, 15);
            lb_nome.TabIndex = 1;
            lb_nome.Text = "Nome";
            // 
            // lb_idade
            // 
            lb_idade.AutoSize = true;
            lb_idade.Location = new Point(22, 112);
            lb_idade.Name = "lb_idade";
            lb_idade.Size = new Size(36, 15);
            lb_idade.TabIndex = 1;
            lb_idade.Text = "Idade";
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Location = new Point(22, 58);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(36, 15);
            lb_email.TabIndex = 1;
            lb_email.Text = "Email";
            // 
            // bt_confirmar
            // 
            bt_confirmar.Location = new Point(183, 110);
            bt_confirmar.Name = "bt_confirmar";
            bt_confirmar.Size = new Size(96, 23);
            bt_confirmar.TabIndex = 2;
            bt_confirmar.Text = "Confirmar";
            bt_confirmar.UseVisualStyleBackColor = true;
            bt_confirmar.Click += bt_confirmar_Click;
            // 
            // nun_idade
            // 
            nun_idade.Location = new Point(82, 110);
            nun_idade.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            nun_idade.Name = "nun_idade";
            nun_idade.Size = new Size(46, 23);
            nun_idade.TabIndex = 3;
            nun_idade.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // frmAdicionarParticipante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 159);
            Controls.Add(nun_idade);
            Controls.Add(bt_confirmar);
            Controls.Add(lb_email);
            Controls.Add(lb_idade);
            Controls.Add(lb_nome);
            Controls.Add(tb_email);
            Controls.Add(tb_nome);
            Name = "frmAdicionarParticipante";
            Text = "frmAdicionarParticipante";
            ((System.ComponentModel.ISupportInitialize)nun_idade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_nome;
        private TextBox tb_email;
        private Label lb_nome;
        private Label lb_idade;
        private Label lb_email;
        private Button bt_confirmar;
        private NumericUpDown nun_idade;
    }
}