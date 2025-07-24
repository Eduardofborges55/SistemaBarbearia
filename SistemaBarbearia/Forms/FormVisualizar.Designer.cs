namespace SistemaBarbearia.Forms
{
    partial class FormVisualizar
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
            statusStrip1 = new StatusStrip();
            dataGridViewListadodia = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListadodia).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 350);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // dataGridViewListadodia
            // 
            dataGridViewListadodia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListadodia.Location = new Point(440, 1);
            dataGridViewListadodia.Name = "dataGridViewListadodia";
            dataGridViewListadodia.RowHeadersWidth = 62;
            dataGridViewListadodia.Size = new Size(360, 371);
            dataGridViewListadodia.TabIndex = 1;
            dataGridViewListadodia.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormVisualizar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(dataGridViewListadodia);
            Controls.Add(statusStrip1);
            Name = "FormVisualizar";
            Text = "Form1";
            Load += FormVisualizar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListadodia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private DataGridView dataGridViewListadodia;
    }
}