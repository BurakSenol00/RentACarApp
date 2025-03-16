namespace RentACarApp
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
            listView1 = new ListView();
            btnOlustur = new Button();
            cmbGunSayisi = new ComboBox();
            cmbAraclar = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Araç Tipi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(30, 98);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 0;
            label2.Text = "Gün";
            // 
            // listView1
            // 
            listView1.Location = new Point(5, 185);
            listView1.Name = "listView1";
            listView1.Size = new Size(582, 121);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnOlustur
            // 
            btnOlustur.Location = new Point(87, 150);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(170, 29);
            btnOlustur.TabIndex = 3;
            btnOlustur.Text = "Kirala";
            btnOlustur.UseVisualStyleBackColor = true;
            // 
            // cmbGunSayisi
            // 
            cmbGunSayisi.FormattingEnabled = true;
            cmbGunSayisi.Location = new Point(87, 90);
            cmbGunSayisi.Name = "cmbGunSayisi";
            cmbGunSayisi.Size = new Size(96, 28);
            cmbGunSayisi.TabIndex = 4;
            // 
            // cmbAraclar
            // 
            cmbAraclar.FormattingEnabled = true;
            cmbAraclar.Location = new Point(87, 36);
            cmbAraclar.Name = "cmbAraclar";
            cmbAraclar.Size = new Size(478, 28);
            cmbAraclar.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(592, 312);
            Controls.Add(cmbAraclar);
            Controls.Add(cmbGunSayisi);
            Controls.Add(btnOlustur);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BS Rent A Car";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listView1;
        private Button btnOlustur;
        private ComboBox cmbGunSayisi;
        private ComboBox cmbAraclar;
    }
}
