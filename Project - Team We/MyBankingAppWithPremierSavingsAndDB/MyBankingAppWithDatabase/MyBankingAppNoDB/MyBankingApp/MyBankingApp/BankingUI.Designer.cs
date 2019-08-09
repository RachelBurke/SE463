namespace MyBankingApp
{
    partial class BankingUI
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
            this.lblBalance = new System.Windows.Forms.TextBox();
            this.lblToday = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.lstTransactions = new System.Windows.Forms.ListBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbxAccount = new System.Windows.Forms.ComboBox();
            this.gbxCheck = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCheckOrder = new System.Windows.Forms.TextBox();
            this.txtCheckPay = new System.Windows.Forms.TextBox();
            this.btnSignCheck = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbxTransfer = new System.Windows.Forms.ComboBox();
            this.txtTransfer = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatabaseLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatabaseSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddInterest = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbxCheck.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(412, 57);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.ReadOnly = true;
            this.lblBalance.Size = new System.Drawing.Size(100, 22);
            this.lblBalance.TabIndex = 33;
            // 
            // lblToday
            // 
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.Location = new System.Drawing.Point(736, 57);
            this.lblToday.Name = "lblToday";
            this.lblToday.ReadOnly = true;
            this.lblToday.Size = new System.Drawing.Size(93, 22);
            this.lblToday.TabIndex = 32;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(628, 60);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(102, 16);
            this.Label7.TabIndex = 31;
            this.Label7.Text = "Today\'s Date";
            // 
            // lstTransactions
            // 
            this.lstTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTransactions.FormattingEnabled = true;
            this.lstTransactions.ItemHeight = 16;
            this.lstTransactions.Location = new System.Drawing.Point(16, 290);
            this.lstTransactions.Name = "lstTransactions";
            this.lstTransactions.Size = new System.Drawing.Size(928, 116);
            this.lstTransactions.TabIndex = 30;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(343, 60);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 16);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "Balance";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(24, 55);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 16);
            this.Label1.TabIndex = 28;
            this.Label1.Text = "Account";
            // 
            // cbxAccount
            // 
            this.cbxAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAccount.FormattingEnabled = true;
            this.cbxAccount.Items.AddRange(new object[] {
            "Checking",
            "Savings",
            "Premier Savings"});
            this.cbxAccount.Location = new System.Drawing.Point(98, 52);
            this.cbxAccount.Name = "cbxAccount";
            this.cbxAccount.Size = new System.Drawing.Size(161, 24);
            this.cbxAccount.TabIndex = 27;
            this.cbxAccount.TabStop = false;
            this.cbxAccount.SelectedIndexChanged += new System.EventHandler(this.cbxAccount_SelectedIndexChanged);
            // 
            // gbxCheck
            // 
            this.gbxCheck.Controls.Add(this.Label6);
            this.gbxCheck.Controls.Add(this.Label5);
            this.gbxCheck.Controls.Add(this.txtCheckOrder);
            this.gbxCheck.Controls.Add(this.txtCheckPay);
            this.gbxCheck.Controls.Add(this.btnSignCheck);
            this.gbxCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCheck.Location = new System.Drawing.Point(578, 133);
            this.gbxCheck.Name = "gbxCheck";
            this.gbxCheck.Size = new System.Drawing.Size(257, 137);
            this.gbxCheck.TabIndex = 19;
            this.gbxCheck.TabStop = false;
            this.gbxCheck.Text = "Check";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 67);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(112, 16);
            this.Label6.TabIndex = 16;
            this.Label6.Text = "to the order of :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 26);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(117, 16);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "Pay this amount";
            // 
            // txtCheckOrder
            // 
            this.txtCheckOrder.Location = new System.Drawing.Point(129, 67);
            this.txtCheckOrder.Name = "txtCheckOrder";
            this.txtCheckOrder.Size = new System.Drawing.Size(122, 22);
            this.txtCheckOrder.TabIndex = 14;
            // 
            // txtCheckPay
            // 
            this.txtCheckPay.Location = new System.Drawing.Point(129, 23);
            this.txtCheckPay.Name = "txtCheckPay";
            this.txtCheckPay.Size = new System.Drawing.Size(122, 22);
            this.txtCheckPay.TabIndex = 13;
            this.txtCheckPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCheckPay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCheckPay_MouseClick);
            // 
            // btnSignCheck
            // 
            this.btnSignCheck.Location = new System.Drawing.Point(64, 104);
            this.btnSignCheck.Name = "btnSignCheck";
            this.btnSignCheck.Size = new System.Drawing.Size(80, 26);
            this.btnSignCheck.TabIndex = 3;
            this.btnSignCheck.Text = "Sign Check";
            this.btnSignCheck.UseVisualStyleBackColor = true;
            this.btnSignCheck.Click += new System.EventHandler(this.btnSignCheck_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.lblAccount);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.cbxTransfer);
            this.GroupBox3.Controls.Add(this.txtTransfer);
            this.GroupBox3.Controls.Add(this.btnTransfer);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(299, 126);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(263, 158);
            this.GroupBox3.TabIndex = 26;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Transfer";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(13, 77);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(81, 16);
            this.lblAccount.TabIndex = 15;
            this.lblAccount.Text = "to Savings";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(104, 16);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Transfer from:";
            // 
            // cbxTransfer
            // 
            this.cbxTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTransfer.FormattingEnabled = true;
            this.cbxTransfer.Items.AddRange(new object[] {
            "Checking",
            "Savings",
            "Premier Savings"});
            this.cbxTransfer.Location = new System.Drawing.Point(116, 29);
            this.cbxTransfer.Name = "cbxTransfer";
            this.cbxTransfer.Size = new System.Drawing.Size(141, 24);
            this.cbxTransfer.TabIndex = 14;
            this.cbxTransfer.SelectedIndexChanged += new System.EventHandler(this.cbxTransfer_SelectedIndexChanged);
            // 
            // txtTransfer
            // 
            this.txtTransfer.Location = new System.Drawing.Point(113, 74);
            this.txtTransfer.Name = "txtTransfer";
            this.txtTransfer.Size = new System.Drawing.Size(144, 22);
            this.txtTransfer.TabIndex = 13;
            this.txtTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(66, 117);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(88, 35);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtDeposit);
            this.GroupBox2.Controls.Add(this.btnDeposit);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(19, 98);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(240, 86);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Deposit";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(37, 38);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(83, 22);
            this.txtDeposit.TabIndex = 11;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(128, 35);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(80, 25);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtWithdraw);
            this.GroupBox1.Controls.Add(this.btnWithdraw);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(14, 190);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(240, 94);
            this.GroupBox1.TabIndex = 24;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Withdrawal";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(42, 38);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(83, 22);
            this.txtWithdraw.TabIndex = 12;
            this.txtWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(133, 34);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(80, 27);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(365, 421);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 35);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(694, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 35);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(956, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatabase});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 25);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDatabase
            // 
            this.mnuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatabaseLoad,
            this.mnuDatabaseSave});
            this.mnuDatabase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDatabase.Name = "mnuDatabase";
            this.mnuDatabase.Size = new System.Drawing.Size(77, 21);
            this.mnuDatabase.Text = "Database";
            // 
            // mnuDatabaseLoad
            // 
            this.mnuDatabaseLoad.Name = "mnuDatabaseLoad";
            this.mnuDatabaseLoad.Size = new System.Drawing.Size(152, 22);
            this.mnuDatabaseLoad.Text = "Load";
            this.mnuDatabaseLoad.Click += new System.EventHandler(this.mnuDatabaseLoad_Click);
            this.mnuDatabaseLoad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mnuDatabaseLoad_MouseDown);
            // 
            // mnuDatabaseSave
            // 
            this.mnuDatabaseSave.Name = "mnuDatabaseSave";
            this.mnuDatabaseSave.Size = new System.Drawing.Size(152, 22);
            this.mnuDatabaseSave.Text = "Save";
            this.mnuDatabaseSave.Click += new System.EventHandler(this.mnuDatabaseSave_Click);
            this.mnuDatabaseSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mnuDatabaseSave_MouseDown);
            // 
            // btnAddInterest
            // 
            this.btnAddInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInterest.Location = new System.Drawing.Point(16, 421);
            this.btnAddInterest.Name = "btnAddInterest";
            this.btnAddInterest.Size = new System.Drawing.Size(170, 35);
            this.btnAddInterest.TabIndex = 36;
            this.btnAddInterest.Text = "Add Interest";
            this.btnAddInterest.UseVisualStyleBackColor = true;
            this.btnAddInterest.Click += new System.EventHandler(this.btnAddInterest_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BankingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 492);
            this.Controls.Add(this.btnAddInterest);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lstTransactions);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbxAccount);
            this.Controls.Add(this.gbxCheck);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BankingUI";
            this.Text = "Banking Transactions";
            this.Load += new System.EventHandler(this.BankingUI_Load);
            this.gbxCheck.ResumeLayout(false);
            this.gbxCheck.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox lblBalance;
        internal System.Windows.Forms.TextBox lblToday;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ListBox lstTransactions;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbxAccount;
        internal System.Windows.Forms.GroupBox gbxCheck;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCheckOrder;
        internal System.Windows.Forms.TextBox txtCheckPay;
        internal System.Windows.Forms.Button btnSignCheck;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label lblAccount;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cbxTransfer;
        internal System.Windows.Forms.TextBox txtTransfer;
        internal System.Windows.Forms.Button btnTransfer;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtDeposit;
        internal System.Windows.Forms.Button btnDeposit;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtWithdraw;
        internal System.Windows.Forms.Button btnWithdraw;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuDatabaseLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuDatabaseSave;
        internal System.Windows.Forms.Button btnAddInterest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

