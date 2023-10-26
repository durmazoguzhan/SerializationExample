namespace SerializationInveonOrnek.form
{
    partial class JsonForm
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
            btnYaz = new Button();
            btnOku = new Button();
            SuspendLayout();
            // 
            // btnYaz
            // 
            btnYaz.Location = new Point(57, 57);
            btnYaz.Name = "btnYaz";
            btnYaz.Size = new Size(128, 68);
            btnYaz.TabIndex = 0;
            btnYaz.Text = "Json Yaz";
            btnYaz.UseVisualStyleBackColor = true;
            btnYaz.Click += btnYaz_Click;
            // 
            // btnOku
            // 
            btnOku.Location = new Point(254, 57);
            btnOku.Name = "btnOku";
            btnOku.Size = new Size(128, 68);
            btnOku.TabIndex = 1;
            btnOku.Text = "Json Oku";
            btnOku.UseVisualStyleBackColor = true;
            // 
            // JsonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 185);
            Controls.Add(btnOku);
            Controls.Add(btnYaz);
            Name = "JsonForm";
            Text = "JsonForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYaz;
        private Button btnOku;
    }
}