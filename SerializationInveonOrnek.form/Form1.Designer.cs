namespace SerializationInveonOrnek.form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtTelefon = new TextBox();
            txtDepartman = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            btnSerialize = new Button();
            btnDeserialize = new Button();
            label5 = new Label();
            nudMaas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudMaas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 50);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 83);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Telefon :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 118);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 0;
            label3.Text = "Doğum Tarihi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 149);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 0;
            label4.Text = "Departman :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(177, 47);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(250, 27);
            txtAd.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(177, 80);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(250, 27);
            txtTelefon.TabIndex = 1;
            // 
            // txtDepartman
            // 
            txtDepartman.Location = new Point(177, 146);
            txtDepartman.Name = "txtDepartman";
            txtDepartman.Size = new Size(250, 27);
            txtDepartman.TabIndex = 1;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(177, 113);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(250, 27);
            dtpDogumTarihi.TabIndex = 2;
            // 
            // btnSerialize
            // 
            btnSerialize.Location = new Point(177, 212);
            btnSerialize.Name = "btnSerialize";
            btnSerialize.Size = new Size(120, 36);
            btnSerialize.TabIndex = 3;
            btnSerialize.Text = "Serialize";
            btnSerialize.UseVisualStyleBackColor = true;
            btnSerialize.Click += btnSerialize_Click;
            // 
            // btnDeserialize
            // 
            btnDeserialize.Location = new Point(303, 212);
            btnDeserialize.Name = "btnDeserialize";
            btnDeserialize.Size = new Size(124, 36);
            btnDeserialize.TabIndex = 4;
            btnDeserialize.Text = "DeSerialize";
            btnDeserialize.UseVisualStyleBackColor = true;
            btnDeserialize.Click += btnDeserialize_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 181);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 5;
            label5.Text = "Maaş :";
            // 
            // nudMaas
            // 
            nudMaas.Location = new Point(177, 179);
            nudMaas.Name = "nudMaas";
            nudMaas.Size = new Size(250, 27);
            nudMaas.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 309);
            Controls.Add(nudMaas);
            Controls.Add(label5);
            Controls.Add(btnDeserialize);
            Controls.Add(btnSerialize);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtDepartman);
            Controls.Add(txtTelefon);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudMaas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtTelefon;
        private TextBox txtDepartman;
        private DateTimePicker dtpDogumTarihi;
        private Button btnSerialize;
        private Button btnDeserialize;
        private Label label5;
        private NumericUpDown nudMaas;
    }
}