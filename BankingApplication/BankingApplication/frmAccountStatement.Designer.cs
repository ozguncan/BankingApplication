namespace BankingApplication
{
    partial class frmAccountStatement
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
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.tbxAccountNumberStatement = new System.Windows.Forms.TextBox();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.tbxNameStatement = new System.Windows.Forms.TextBox();
            this.lblNameStatement = new System.Windows.Forms.Label();
            this.tbxSurnameStatement = new System.Windows.Forms.TextBox();
            this.lblSurnameStatement = new System.Windows.Forms.Label();
            this.tbxIdentificationNumberStatement = new System.Windows.Forms.TextBox();
            this.lblIdentificationNumberStatement = new System.Windows.Forms.Label();
            this.tbxAccountTypeStatement = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblMoneyDeposited = new System.Windows.Forms.Label();
            this.lblWithdrawnMoney = new System.Windows.Forms.Label();
            this.lblRemainder = new System.Windows.Forms.Label();
            this.tbxMoneyDeposited = new System.Windows.Forms.TextBox();
            this.tbxWithdrawnMoney = new System.Windows.Forms.TextBox();
            this.tbxRemainder = new System.Windows.Forms.TextBox();
            this.btnDepositMoney = new System.Windows.Forms.Button();
            this.lvAccountStatement = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(77, 52);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(61, 13);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Hesap No :";
            // 
            // tbxAccountNumberStatement
            // 
            this.tbxAccountNumberStatement.Location = new System.Drawing.Point(152, 49);
            this.tbxAccountNumberStatement.Name = "tbxAccountNumberStatement";
            this.tbxAccountNumberStatement.Size = new System.Drawing.Size(100, 20);
            this.tbxAccountNumberStatement.TabIndex = 1;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Location = new System.Drawing.Point(300, 47);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAccount.TabIndex = 2;
            this.btnSearchAccount.Text = "Hesap Ara";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // tbxNameStatement
            // 
            this.tbxNameStatement.Location = new System.Drawing.Point(152, 75);
            this.tbxNameStatement.Name = "tbxNameStatement";
            this.tbxNameStatement.ReadOnly = true;
            this.tbxNameStatement.Size = new System.Drawing.Size(223, 20);
            this.tbxNameStatement.TabIndex = 4;
            // 
            // lblNameStatement
            // 
            this.lblNameStatement.AutoSize = true;
            this.lblNameStatement.Location = new System.Drawing.Point(77, 78);
            this.lblNameStatement.Name = "lblNameStatement";
            this.lblNameStatement.Size = new System.Drawing.Size(29, 13);
            this.lblNameStatement.TabIndex = 3;
            this.lblNameStatement.Text = "Ad : ";
            // 
            // tbxSurnameStatement
            // 
            this.tbxSurnameStatement.Location = new System.Drawing.Point(152, 101);
            this.tbxSurnameStatement.Name = "tbxSurnameStatement";
            this.tbxSurnameStatement.ReadOnly = true;
            this.tbxSurnameStatement.Size = new System.Drawing.Size(223, 20);
            this.tbxSurnameStatement.TabIndex = 6;
            // 
            // lblSurnameStatement
            // 
            this.lblSurnameStatement.AutoSize = true;
            this.lblSurnameStatement.Location = new System.Drawing.Point(77, 104);
            this.lblSurnameStatement.Name = "lblSurnameStatement";
            this.lblSurnameStatement.Size = new System.Drawing.Size(43, 13);
            this.lblSurnameStatement.TabIndex = 5;
            this.lblSurnameStatement.Text = "Soyad :";
            // 
            // tbxIdentificationNumberStatement
            // 
            this.tbxIdentificationNumberStatement.Location = new System.Drawing.Point(152, 127);
            this.tbxIdentificationNumberStatement.Name = "tbxIdentificationNumberStatement";
            this.tbxIdentificationNumberStatement.ReadOnly = true;
            this.tbxIdentificationNumberStatement.Size = new System.Drawing.Size(223, 20);
            this.tbxIdentificationNumberStatement.TabIndex = 8;
            // 
            // lblIdentificationNumberStatement
            // 
            this.lblIdentificationNumberStatement.AutoSize = true;
            this.lblIdentificationNumberStatement.Location = new System.Drawing.Point(77, 130);
            this.lblIdentificationNumberStatement.Name = "lblIdentificationNumberStatement";
            this.lblIdentificationNumberStatement.Size = new System.Drawing.Size(57, 13);
            this.lblIdentificationNumberStatement.TabIndex = 7;
            this.lblIdentificationNumberStatement.Text = "Kimlik No :";
            // 
            // tbxAccountTypeStatement
            // 
            this.tbxAccountTypeStatement.Location = new System.Drawing.Point(152, 153);
            this.tbxAccountTypeStatement.Name = "tbxAccountTypeStatement";
            this.tbxAccountTypeStatement.ReadOnly = true;
            this.tbxAccountTypeStatement.Size = new System.Drawing.Size(223, 20);
            this.tbxAccountTypeStatement.TabIndex = 10;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(77, 156);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(69, 13);
            this.lblAccountType.TabIndex = 9;
            this.lblAccountType.Text = "Hesap Türü :";
            // 
            // lblMoneyDeposited
            // 
            this.lblMoneyDeposited.AutoSize = true;
            this.lblMoneyDeposited.Location = new System.Drawing.Point(77, 305);
            this.lblMoneyDeposited.Name = "lblMoneyDeposited";
            this.lblMoneyDeposited.Size = new System.Drawing.Size(107, 13);
            this.lblMoneyDeposited.TabIndex = 12;
            this.lblMoneyDeposited.Text = "Toplam Yatan Para : ";
            // 
            // lblWithdrawnMoney
            // 
            this.lblWithdrawnMoney.AutoSize = true;
            this.lblWithdrawnMoney.Location = new System.Drawing.Point(77, 327);
            this.lblWithdrawnMoney.Name = "lblWithdrawnMoney";
            this.lblWithdrawnMoney.Size = new System.Drawing.Size(114, 13);
            this.lblWithdrawnMoney.TabIndex = 13;
            this.lblWithdrawnMoney.Text = "Toplam Çekilen Para : ";
            // 
            // lblRemainder
            // 
            this.lblRemainder.AutoSize = true;
            this.lblRemainder.Location = new System.Drawing.Point(77, 349);
            this.lblRemainder.Name = "lblRemainder";
            this.lblRemainder.Size = new System.Drawing.Size(48, 13);
            this.lblRemainder.TabIndex = 14;
            this.lblRemainder.Text = "Bakiye : ";
            // 
            // tbxMoneyDeposited
            // 
            this.tbxMoneyDeposited.Location = new System.Drawing.Point(205, 302);
            this.tbxMoneyDeposited.Name = "tbxMoneyDeposited";
            this.tbxMoneyDeposited.Size = new System.Drawing.Size(100, 20);
            this.tbxMoneyDeposited.TabIndex = 15;
            // 
            // tbxWithdrawnMoney
            // 
            this.tbxWithdrawnMoney.Location = new System.Drawing.Point(205, 324);
            this.tbxWithdrawnMoney.Name = "tbxWithdrawnMoney";
            this.tbxWithdrawnMoney.Size = new System.Drawing.Size(100, 20);
            this.tbxWithdrawnMoney.TabIndex = 16;
            // 
            // tbxRemainder
            // 
            this.tbxRemainder.Location = new System.Drawing.Point(205, 346);
            this.tbxRemainder.Name = "tbxRemainder";
            this.tbxRemainder.Size = new System.Drawing.Size(100, 20);
            this.tbxRemainder.TabIndex = 17;
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.Location = new System.Drawing.Point(327, 321);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(75, 23);
            this.btnDepositMoney.TabIndex = 18;
            this.btnDepositMoney.Text = "Para Yatır";
            this.btnDepositMoney.UseVisualStyleBackColor = true;
            this.btnDepositMoney.Click += new System.EventHandler(this.btnDepositMoney_Click);
            // 
            // lvAccountStatement
            // 
            this.lvAccountStatement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvAccountStatement.HideSelection = false;
            this.lvAccountStatement.Location = new System.Drawing.Point(31, 182);
            this.lvAccountStatement.Name = "lvAccountStatement";
            this.lvAccountStatement.Size = new System.Drawing.Size(431, 114);
            this.lvAccountStatement.TabIndex = 11;
            this.lvAccountStatement.UseCompatibleStateImageBehavior = false;
            this.lvAccountStatement.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Id";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Hesap No";
            this.columnHeader14.Width = 73;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "İşlem Tarihi";
            this.columnHeader15.Width = 76;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Tutar";
            this.columnHeader16.Width = 61;
            // 
            // columnHeader17
            // 
            this.columnHeader17.DisplayIndex = 5;
            this.columnHeader17.Text = "İşlem Türü";
            this.columnHeader17.Width = 90;
            // 
            // columnHeader18
            // 
            this.columnHeader18.DisplayIndex = 4;
            this.columnHeader18.Text = "Para Birimi";
            this.columnHeader18.Width = 67;
            // 
            // frmAccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 442);
            this.Controls.Add(this.btnDepositMoney);
            this.Controls.Add(this.tbxRemainder);
            this.Controls.Add(this.tbxWithdrawnMoney);
            this.Controls.Add(this.tbxMoneyDeposited);
            this.Controls.Add(this.lblRemainder);
            this.Controls.Add(this.lblWithdrawnMoney);
            this.Controls.Add(this.lblMoneyDeposited);
            this.Controls.Add(this.lvAccountStatement);
            this.Controls.Add(this.tbxAccountTypeStatement);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.tbxIdentificationNumberStatement);
            this.Controls.Add(this.lblIdentificationNumberStatement);
            this.Controls.Add(this.tbxSurnameStatement);
            this.Controls.Add(this.lblSurnameStatement);
            this.Controls.Add(this.tbxNameStatement);
            this.Controls.Add(this.lblNameStatement);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.tbxAccountNumberStatement);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "frmAccountStatement";
            this.Text = "frmAccountStatement";
            this.Load += new System.EventHandler(this.frmAccountStatement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox tbxAccountNumberStatement;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.TextBox tbxNameStatement;
        private System.Windows.Forms.Label lblNameStatement;
        private System.Windows.Forms.TextBox tbxSurnameStatement;
        private System.Windows.Forms.Label lblSurnameStatement;
        private System.Windows.Forms.TextBox tbxIdentificationNumberStatement;
        private System.Windows.Forms.Label lblIdentificationNumberStatement;
        private System.Windows.Forms.TextBox tbxAccountTypeStatement;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblMoneyDeposited;
        private System.Windows.Forms.Label lblWithdrawnMoney;
        private System.Windows.Forms.Label lblRemainder;
        private System.Windows.Forms.TextBox tbxMoneyDeposited;
        private System.Windows.Forms.TextBox tbxWithdrawnMoney;
        private System.Windows.Forms.TextBox tbxRemainder;
        private System.Windows.Forms.Button btnDepositMoney;
        private System.Windows.Forms.ListView lvAccountStatement;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
    }
}