using MySql.Data.MySqlClient;
using SistemaBarbearia.Forms;
using SistemaFarmacia.Database;

namespace SistemaBarbearia
{
    partial class FormCadastro
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
            button1 = new Button();
            label1 = new Label();
            Textemail = new TextBox();
            label2 = new Label();
            TextSenha = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(268, 196);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 0;
            button1.Text = "Cadastro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 94);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "email";
            // 
            // Textemail
            // 
            Textemail.Location = new Point(268, 117);
            Textemail.Margin = new Padding(2);
            Textemail.Name = "Textemail";
            Textemail.Size = new Size(295, 27);
            Textemail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 144);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "senha";
            // 
            // TextSenha
            // 
            TextSenha.Location = new Point(268, 166);
            TextSenha.Margin = new Padding(2);
            TextSenha.Name = "TextSenha";
            TextSenha.Size = new Size(121, 27);
            TextSenha.TabIndex = 4;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(TextSenha);
            Controls.Add(label2);
            Controls.Add(Textemail);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "FormCadastro";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Textemail.Text) || string.IsNullOrWhiteSpace(TextSenha.Text))

                {
                MessageBox.Show("Preencha todos os campos!");
            }
                try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"INSERT INTO Cadastro
                    (Nome,Senha)
                    VALUES
                     (@Nome,@Senha)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@Nome", Textemail.Text);
                    cmd.Parameters.AddWithValue("@Senha", TextSenha.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente salvo com sucesso!!");


                    Textemail.Clear();
                    TextSenha.Clear();

                    FormHorarios formHorarios = new FormHorarios();
                    formHorarios.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no cadastro");
            }
            
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox Textemail;
        private Label label2;
        private TextBox TextSenha;
    }
}
