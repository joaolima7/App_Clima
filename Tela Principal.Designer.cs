namespace APP_CLIMA
{
    partial class Tela_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Lbl_Umid = new Label();
            Lbl_Vento = new Label();
            Lbl_Descricao = new Label();
            Lbl_Temper = new Label();
            Lbl_City = new Label();
            Txb_Pesq = new TextBox();
            Btn_Pesq = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Lbl_Umid);
            panel1.Controls.Add(Lbl_Vento);
            panel1.Controls.Add(Lbl_Descricao);
            panel1.Controls.Add(Lbl_Temper);
            panel1.Controls.Add(Lbl_City);
            panel1.Location = new Point(165, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 290);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(74, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 73);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.umidade__1_;
            pictureBox2.Location = new Point(158, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vento__1_;
            pictureBox1.Location = new Point(44, 219);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Lbl_Umid
            // 
            Lbl_Umid.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Umid.Location = new Point(128, 248);
            Lbl_Umid.Name = "Lbl_Umid";
            Lbl_Umid.Size = new Size(89, 28);
            Lbl_Umid.TabIndex = 4;
            Lbl_Umid.Text = "Umid";
            Lbl_Umid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_Vento
            // 
            Lbl_Vento.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Vento.Location = new Point(14, 248);
            Lbl_Vento.Name = "Lbl_Vento";
            Lbl_Vento.Size = new Size(89, 28);
            Lbl_Vento.TabIndex = 3;
            Lbl_Vento.Text = "Vento";
            Lbl_Vento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_Descricao
            // 
            Lbl_Descricao.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Descricao.Location = new Point(3, 182);
            Lbl_Descricao.Name = "Lbl_Descricao";
            Lbl_Descricao.Size = new Size(226, 28);
            Lbl_Descricao.TabIndex = 2;
            Lbl_Descricao.Text = "Descrição";
            Lbl_Descricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_Temper
            // 
            Lbl_Temper.Font = new Font("Times New Roman", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Temper.Location = new Point(0, 121);
            Lbl_Temper.Name = "Lbl_Temper";
            Lbl_Temper.Size = new Size(226, 56);
            Lbl_Temper.TabIndex = 1;
            Lbl_Temper.Text = "Temp";
            Lbl_Temper.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_City
            // 
            Lbl_City.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lbl_City.Location = new Point(3, 14);
            Lbl_City.Name = "Lbl_City";
            Lbl_City.Size = new Size(226, 28);
            Lbl_City.TabIndex = 0;
            Lbl_City.Text = "Cidade";
            Lbl_City.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txb_Pesq
            // 
            Txb_Pesq.BackColor = Color.LightGray;
            Txb_Pesq.Location = new Point(165, 379);
            Txb_Pesq.Name = "Txb_Pesq";
            Txb_Pesq.Size = new Size(198, 23);
            Txb_Pesq.TabIndex = 1;
            // 
            // Btn_Pesq
            // 
            Btn_Pesq.BackColor = Color.LightGray;
            Btn_Pesq.Image = Properties.Resources.procurar__1_;
            Btn_Pesq.Location = new Point(364, 377);
            Btn_Pesq.Name = "Btn_Pesq";
            Btn_Pesq.Size = new Size(32, 26);
            Btn_Pesq.TabIndex = 2;
            Btn_Pesq.UseVisualStyleBackColor = false;
            Btn_Pesq.Click += Btn_Pesq_Click_1;
            // 
            // Tela_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_andre_moura_3289880;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 478);
            Controls.Add(Btn_Pesq);
            Controls.Add(Txb_Pesq);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Tela_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iTempo";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Lbl_City;
        private Label Lbl_Vento;
        private Label Lbl_Descricao;
        private Label Lbl_Temper;
        private Label Lbl_Umid;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox Txb_Pesq;
        private Button Btn_Pesq;
    }
}