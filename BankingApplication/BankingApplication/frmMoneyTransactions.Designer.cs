namespace BankingApplication
{
    partial class frmMoneyTransactions
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
            this.lblMusteriId = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.tbxMusteriId = new System.Windows.Forms.TextBox();
            this.tbxHesapNo = new System.Windows.Forms.TextBox();
            this.tbxTutar = new System.Windows.Forms.TextBox();
            this.lblIslemTarihi = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblIslemTuru = new System.Windows.Forms.Label();
            this.dtpIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbxIslemTuru = new System.Windows.Forms.ComboBox();
            this.btnYatir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMusteriId
            // 
            this.lblMusteriId.AutoSize = true;
            this.lblMusteriId.Location = new System.Drawing.Point(69, 33);
            this.lblMusteriId.Name = "lblMusteriId";
            this.lblMusteriId.Size = new System.Drawing.Size(62, 13);
            this.lblMusteriId.TabIndex = 0;
            this.lblMusteriId.Text = "Müşteri Id : ";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(69, 59);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(64, 13);
            this.lblHesapNo.TabIndex = 1;
            this.lblHesapNo.Text = "Hesap No : ";
            // 
            // tbxMusteriId
            // 
            this.tbxMusteriId.Location = new System.Drawing.Point(136, 30);
            this.tbxMusteriId.Name = "tbxMusteriId";
            this.tbxMusteriId.Size = new System.Drawing.Size(100, 20);
            this.tbxMusteriId.TabIndex = 2;
            // 
            // tbxHesapNo
            // 
            this.tbxHesapNo.Location = new System.Drawing.Point(136, 56);
            this.tbxHesapNo.Name = "tbxHesapNo";
            this.tbxHesapNo.Size = new System.Drawing.Size(100, 20);
            this.tbxHesapNo.TabIndex = 3;
            // 
            // tbxTutar
            // 
            this.tbxTutar.Location = new System.Drawing.Point(136, 108);
            this.tbxTutar.Name = "tbxTutar";
            this.tbxTutar.Size = new System.Drawing.Size(100, 20);
            this.tbxTutar.TabIndex = 5;
            // 
            // lblIslemTarihi
            // 
            this.lblIslemTarihi.AutoSize = true;
            this.lblIslemTarihi.Location = new System.Drawing.Point(69, 85);
            this.lblIslemTarihi.Name = "lblIslemTarihi";
            this.lblIslemTarihi.Size = new System.Drawing.Size(69, 13);
            this.lblIslemTarihi.TabIndex = 8;
            this.lblIslemTarihi.Text = "İşlem Tarihi : ";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(69, 111);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(41, 13);
            this.lblTutar.TabIndex = 7;
            this.lblTutar.Text = "Tutar : ";
            // 
            // lblIslemTuru
            // 
            this.lblIslemTuru.AutoSize = true;
            this.lblIslemTuru.Location = new System.Drawing.Point(69, 137);
            this.lblIslemTuru.Name = "lblIslemTuru";
            this.lblIslemTuru.Size = new System.Drawing.Size(65, 13);
            this.lblIslemTuru.TabIndex = 9;
            this.lblIslemTuru.Text = "İşlem Türü : ";
            // 
            // dtpIslemTarihi
            // 
            this.dtpIslemTarihi.Location = new System.Drawing.Point(136, 82);
            this.dtpIslemTarihi.Name = "dtpIslemTarihi";
            this.dtpIslemTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpIslemTarihi.TabIndex = 10;
            // 
            // cbxIslemTuru
            // 
            this.cbxIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIslemTuru.FormattingEnabled = true;
            this.cbxIslemTuru.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR"});
            this.cbxIslemTuru.Location = new System.Drawing.Point(136, 134);
            this.cbxIslemTuru.Name = "cbxIslemTuru";
            this.cbxIslemTuru.Size = new System.Drawing.Size(121, 21);
            this.cbxIslemTuru.TabIndex = 11;
            // 
            // btnYatir
            // 
            this.btnYatir.Location = new System.Drawing.Point(261, 174);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(75, 23);
            this.btnYatir.TabIndex = 12;
            this.btnYatir.Text = "Para Yatır";
            this.btnYatir.UseVisualStyleBackColor = true;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // frmMoneyTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYatir);
            this.Controls.Add(this.cbxIslemTuru);
            this.Controls.Add(this.dtpIslemTarihi);
            this.Controls.Add(this.lblIslemTuru);
            this.Controls.Add(this.lblIslemTarihi);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.tbxTutar);
            this.Controls.Add(this.tbxHesapNo);
            this.Controls.Add(this.tbxMusteriId);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblMusteriId);
            this.Name = "frmMoneyTransactions";
            this.Text = "frmMoneyTransactions";
            this.Load += new System.EventHandler(this.frmMoneyTransactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriId;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.TextBox tbxMusteriId;
        private System.Windows.Forms.TextBox tbxHesapNo;
        private System.Windows.Forms.TextBox tbxTutar;
        private System.Windows.Forms.Label lblIslemTarihi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblIslemTuru;
        private System.Windows.Forms.DateTimePicker dtpIslemTarihi;
        private System.Windows.Forms.ComboBox cbxIslemTuru;
        private System.Windows.Forms.Button btnYatir;
    }
}