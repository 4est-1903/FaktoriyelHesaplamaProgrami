namespace stajornek7
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
            txtsayi = new TextBox();
            lstfaktoriyel = new ListBox();
            lblsonuc = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(126, 29);
            label1.TabIndex = 0;
            label1.Text = "Sayı Girin:";
            // 
            // txtsayi
            // 
            txtsayi.Location = new Point(144, 66);
            txtsayi.Name = "txtsayi";
            txtsayi.Size = new Size(231, 23);
            txtsayi.TabIndex = 1;
            // 
            // lstfaktoriyel
            // 
            lstfaktoriyel.BackColor = Color.Tomato;
            lstfaktoriyel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstfaktoriyel.ForeColor = Color.White;
            lstfaktoriyel.FormattingEnabled = true;
            lstfaktoriyel.ItemHeight = 18;
            lstfaktoriyel.Location = new Point(12, 191);
            lstfaktoriyel.Name = "lstfaktoriyel";
            lstfaktoriyel.Size = new Size(195, 238);
            lstfaktoriyel.TabIndex = 2;
            // 
            // lblsonuc
            // 
            lblsonuc.AutoSize = true;
            lblsonuc.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblsonuc.Location = new Point(262, 282);
            lblsonuc.Name = "lblsonuc";
            lblsonuc.Size = new Size(78, 29);
            lblsonuc.TabIndex = 3;
            lblsonuc.Text = "Sonuç";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Tomato;
            button1.Location = new Point(12, 108);
            button1.Name = "button1";
            button1.Size = new Size(163, 36);
            button1.TabIndex = 4;
            button1.Text = "Faktöriyel Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Tomato;
            button2.Location = new Point(212, 108);
            button2.Name = "button2";
            button2.Size = new Size(163, 36);
            button2.TabIndex = 5;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(401, 432);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblsonuc);
            Controls.Add(lstfaktoriyel);
            Controls.Add(txtsayi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtsayi;
        private ListBox lstfaktoriyel;
        private Label lblsonuc;
        private Button button1;
        private Button button2;
    }
}