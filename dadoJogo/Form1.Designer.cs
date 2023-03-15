namespace dadoJogo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dadoUser = new System.Windows.Forms.Label();
            this.dadoMachine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userPontos = new System.Windows.Forms.Label();
            this.maquinaPontos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.jogadaLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(283, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo dos Dados\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(369, 504);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Jogar Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(181, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Você";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(580, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Máquina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(261, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuário VS Máquina\r\n";
            // 
            // dadoUser
            // 
            this.dadoUser.AutoSize = true;
            this.dadoUser.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dadoUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dadoUser.Location = new System.Drawing.Point(267, 328);
            this.dadoUser.Name = "dadoUser";
            this.dadoUser.Size = new System.Drawing.Size(32, 37);
            this.dadoUser.TabIndex = 6;
            this.dadoUser.Text = "0";
            // 
            // dadoMachine
            // 
            this.dadoMachine.AutoSize = true;
            this.dadoMachine.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dadoMachine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dadoMachine.Location = new System.Drawing.Point(674, 328);
            this.dadoMachine.Name = "dadoMachine";
            this.dadoMachine.Size = new System.Drawing.Size(32, 37);
            this.dadoMachine.TabIndex = 7;
            this.dadoMachine.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(181, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(580, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(181, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pontos:";
            // 
            // userPontos
            // 
            this.userPontos.AutoSize = true;
            this.userPontos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPontos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userPontos.Location = new System.Drawing.Point(290, 382);
            this.userPontos.Name = "userPontos";
            this.userPontos.Size = new System.Drawing.Size(32, 37);
            this.userPontos.TabIndex = 13;
            this.userPontos.Text = "0";
            // 
            // maquinaPontos
            // 
            this.maquinaPontos.AutoSize = true;
            this.maquinaPontos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maquinaPontos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maquinaPontos.Location = new System.Drawing.Point(689, 382);
            this.maquinaPontos.Name = "maquinaPontos";
            this.maquinaPontos.Size = new System.Drawing.Size(32, 37);
            this.maquinaPontos.TabIndex = 15;
            this.maquinaPontos.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(580, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 37);
            this.label9.TabIndex = 14;
            this.label9.Text = "Pontos:";
            // 
            // jogadaLabel
            // 
            this.jogadaLabel.AutoSize = true;
            this.jogadaLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jogadaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jogadaLabel.Location = new System.Drawing.Point(369, 171);
            this.jogadaLabel.Name = "jogadaLabel";
            this.jogadaLabel.Size = new System.Drawing.Size(0, 46);
            this.jogadaLabel.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(146, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 185);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(548, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 185);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.jogadaLabel);
            this.Controls.Add(this.maquinaPontos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userPontos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dadoMachine);
            this.Controls.Add(this.dadoUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label dadoUser;
        private Label dadoMachine;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label userPontos;
        private Label maquinaPontos;
        private Label label9;
        private Label jogadaLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}