namespace BankingApplication
{
    partial class frmNewAccount
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
            this.tbxClientId = new System.Windows.Forms.TextBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.tbxAccountNumber = new System.Windows.Forms.TextBox();
            this.lblOpeningDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblRemainingBalance = new System.Windows.Forms.Label();
            this.tbxRemainingBalance = new System.Windows.Forms.TextBox();
            this.lblIdentificationNumber = new System.Windows.Forms.Label();
            this.tbxIdentificationNumber = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.dtpOpeningDate = new System.Windows.Forms.DateTimePicker();
            this.cbxAccountType = new System.Windows.Forms.ComboBox();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxClientId
            // 
            this.tbxClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxClientId.Location = new System.Drawing.Point(138, 38);
            this.tbxClientId.Name = "tbxClientId";
            this.tbxClientId.ReadOnly = true;
            this.tbxClientId.Size = new System.Drawing.Size(100, 20);
            this.tbxClientId.TabIndex = 0;
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(54, 41);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(62, 13);
            this.lblClientId.TabIndex = 1;
            this.lblClientId.Text = "Müşteri Id : ";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(54, 67);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(64, 13);
            this.lblAccountNumber.TabIndex = 3;
            this.lblAccountNumber.Text = "Hesap No : ";
            // 
            // tbxAccountNumber
            // 
            this.tbxAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAccountNumber.Location = new System.Drawing.Point(138, 64);
            this.tbxAccountNumber.Name = "tbxAccountNumber";
            this.tbxAccountNumber.ReadOnly = true;
            this.tbxAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxAccountNumber.TabIndex = 2;
            // 
            // lblOpeningDate
            // 
            this.lblOpeningDate.AutoSize = true;
            this.lblOpeningDate.Location = new System.Drawing.Point(54, 93);
            this.lblOpeningDate.Name = "lblOpeningDate";
            this.lblOpeningDate.Size = new System.Drawing.Size(69, 13);
            this.lblOpeningDate.TabIndex = 5;
            this.lblOpeningDate.Text = "Açılış Tarihi : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(54, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Ad : ";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(138, 116);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 6;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(54, 223);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(72, 13);
            this.lblAccountType.TabIndex = 15;
            this.lblAccountType.Text = "Hesap Türü : ";
            // 
            // lblRemainingBalance
            // 
            this.lblRemainingBalance.AutoSize = true;
            this.lblRemainingBalance.Location = new System.Drawing.Point(54, 197);
            this.lblRemainingBalance.Name = "lblRemainingBalance";
            this.lblRemainingBalance.Size = new System.Drawing.Size(48, 13);
            this.lblRemainingBalance.TabIndex = 13;
            this.lblRemainingBalance.Text = "Bakiye : ";
            // 
            // tbxRemainingBalance
            // 
            this.tbxRemainingBalance.Location = new System.Drawing.Point(138, 194);
            this.tbxRemainingBalance.Name = "tbxRemainingBalance";
            this.tbxRemainingBalance.Size = new System.Drawing.Size(100, 20);
            this.tbxRemainingBalance.TabIndex = 12;
            // 
            // lblIdentificationNumber
            // 
            this.lblIdentificationNumber.AutoSize = true;
            this.lblIdentificationNumber.Location = new System.Drawing.Point(54, 171);
            this.lblIdentificationNumber.Name = "lblIdentificationNumber";
            this.lblIdentificationNumber.Size = new System.Drawing.Size(60, 13);
            this.lblIdentificationNumber.TabIndex = 11;
            this.lblIdentificationNumber.Text = "Kimlik No : ";
            // 
            // tbxIdentificationNumber
            // 
            this.tbxIdentificationNumber.Location = new System.Drawing.Point(138, 168);
            this.tbxIdentificationNumber.Name = "tbxIdentificationNumber";
            this.tbxIdentificationNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxIdentificationNumber.TabIndex = 10;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(54, 145);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(46, 13);
            this.lblSurname.TabIndex = 9;
            this.lblSurname.Text = "Soyad : ";
            this.lblSurname.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(138, 142);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 8;
            // 
            // dtpOpeningDate
            // 
            this.dtpOpeningDate.Location = new System.Drawing.Point(138, 90);
            this.dtpOpeningDate.Name = "dtpOpeningDate";
            this.dtpOpeningDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOpeningDate.TabIndex = 16;
            // 
            // cbxAccountType
            // 
            this.cbxAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccountType.FormattingEnabled = true;
            this.cbxAccountType.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR"});
            this.cbxAccountType.Location = new System.Drawing.Point(138, 220);
            this.cbxAccountType.Name = "cbxAccountType";
            this.cbxAccountType.Size = new System.Drawing.Size(121, 21);
            this.cbxAccountType.TabIndex = 17;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(263, 291);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAccount.TabIndex = 18;
            this.btnOpenAccount.Text = "Hesap Aç";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // frmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(436, 394);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.cbxAccountType);
            this.Controls.Add(this.dtpOpeningDate);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblRemainingBalance);
            this.Controls.Add(this.tbxRemainingBalance);
            this.Controls.Add(this.lblIdentificationNumber);
            this.Controls.Add(this.tbxIdentificationNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblOpeningDate);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.tbxAccountNumber);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.tbxClientId);
            this.Name = "frmNewAccount";
            this.Text = "frmNewAccount";
            this.Load += new System.EventHandler(this.frmNewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxClientId;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox tbxAccountNumber;
        private System.Windows.Forms.Label lblOpeningDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblRemainingBalance;
        private System.Windows.Forms.TextBox tbxRemainingBalance;
        private System.Windows.Forms.Label lblIdentificationNumber;
        private System.Windows.Forms.TextBox tbxIdentificationNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.DateTimePicker dtpOpeningDate;
        private System.Windows.Forms.ComboBox cbxAccountType;
        private System.Windows.Forms.Button btnOpenAccount;
    }
}