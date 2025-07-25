

namespace SistemaBarbearia.Forms
{
    partial class FormHorarios
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
            monthCalendar1 = new MonthCalendar();
            txtHorarios = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            button1 = new Button();
            Horário_disponivel = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTipo = new TextBox();
            preco = new Label();
            txtPreco = new TextBox();
            id = new Label();
            TextId = new TextBox();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(-5, 202);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // txtHorarios
            // 
            txtHorarios.Location = new Point(538, 105);
            txtHorarios.Name = "txtHorarios";
            txtHorarios.Size = new Size(82, 31);
            txtHorarios.TabIndex = 2;
            txtHorarios.TextChanged += txtHorarios_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 77);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 3;
            label2.Text = "Horarios";
            label2.Click += label2_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(536, 167);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(82, 31);
            txtNome.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(536, 328);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Visualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Horário_disponivel
            // 
            Horário_disponivel.Location = new Point(656, 328);
            Horário_disponivel.Name = "Horário_disponivel";
            Horário_disponivel.Size = new Size(132, 34);
            Horário_disponivel.TabIndex = 6;
            Horário_disponivel.Text = "salvar";
            Horário_disponivel.UseVisualStyleBackColor = true;
            Horário_disponivel.Click += Horário_disponivel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(538, 77);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 77);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(536, 139);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 9;
            label4.Text = "Nome";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(536, 201);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 10;
            label5.Text = "Tipo";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(536, 229);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(82, 31);
            txtTipo.TabIndex = 11;
            // 
            // preco
            // 
            preco.AutoSize = true;
            preco.Location = new Point(536, 263);
            preco.Name = "preco";
            preco.Size = new Size(56, 25);
            preco.TabIndex = 12;
            preco.Text = "Preco";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(536, 291);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(82, 31);
            txtPreco.TabIndex = 13;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(538, 9);
            id.Name = "id";
            id.Size = new Size(28, 25);
            id.TabIndex = 14;
            id.Text = "Id";
            // 
            // TextId
            // 
            TextId.Location = new Point(536, 43);
            TextId.Name = "TextId";
            TextId.Size = new Size(84, 31);
            TextId.TabIndex = 15;
            // 
            // FormHorarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(TextId);
            Controls.Add(id);
            Controls.Add(txtPreco);
            Controls.Add(preco);
            Controls.Add(txtTipo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Horário_disponivel);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtHorarios);
            Controls.Add(monthCalendar1);
            Name = "FormHorarios";
            Text = "Form1";
            Load += FormHorarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Horário_disponivel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox txtHorarios;
        private Label label2;
        private TextBox txtNome;
        private Button button1;
        private Button Horário_disponivel;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTipo;
        private Label preco;
        private TextBox txtPreco;
        private Label id;
        private TextBox TextId;
    }
}