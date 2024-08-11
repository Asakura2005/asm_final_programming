namespace asmwinform
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
            grbCWB = new GroupBox();
            btPrBill = new Button();
            lbAOWB = new Label();
            tbPhone = new TextBox();
            lbPhone = new Label();
            btDelete = new Button();
            btClear = new Button();
            lbTotalWaterB = new Label();
            lbLastM = new Label();
            btExit = new Button();
            btResult = new Button();
            btEdit = new Button();
            lbHuman = new Label();
            lbType = new Label();
            tbHuman = new TextBox();
            cbType = new ComboBox();
            tbThisM = new TextBox();
            tbLastM = new TextBox();
            lbThisM = new Label();
            LBname = new Label();
            tbName = new TextBox();
            label1 = new Label();
            listView1 = new ListView();
            grbCWB.SuspendLayout();
            SuspendLayout();
            // 
            // grbCWB
            // 
            grbCWB.BackColor = SystemColors.InactiveCaption;
            grbCWB.Controls.Add(btPrBill);
            grbCWB.Controls.Add(lbAOWB);
            grbCWB.Controls.Add(tbPhone);
            grbCWB.Controls.Add(lbPhone);
            grbCWB.Controls.Add(btDelete);
            grbCWB.Controls.Add(btClear);
            grbCWB.Controls.Add(lbTotalWaterB);
            grbCWB.Controls.Add(lbLastM);
            grbCWB.Controls.Add(btExit);
            grbCWB.Controls.Add(btResult);
            grbCWB.Controls.Add(btEdit);
            grbCWB.Controls.Add(lbHuman);
            grbCWB.Controls.Add(lbType);
            grbCWB.Controls.Add(tbHuman);
            grbCWB.Controls.Add(cbType);
            grbCWB.Controls.Add(tbThisM);
            grbCWB.Controls.Add(tbLastM);
            grbCWB.Controls.Add(lbThisM);
            grbCWB.Controls.Add(LBname);
            grbCWB.Controls.Add(tbName);
            grbCWB.Location = new Point(259, 62);
            grbCWB.Name = "grbCWB";
            grbCWB.Size = new Size(651, 287);
            grbCWB.TabIndex = 0;
            grbCWB.TabStop = false;
            // 
            // btPrBill
            // 
            btPrBill.Location = new Point(453, 246);
            btPrBill.Name = "btPrBill";
            btPrBill.Size = new Size(75, 23);
            btPrBill.TabIndex = 10;
            btPrBill.Text = "Print Bill";
            btPrBill.UseVisualStyleBackColor = true;
            btPrBill.Click += btPrBill_Click;
            // 
            // lbAOWB
            // 
            lbAOWB.AutoSize = true;
            lbAOWB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAOWB.Location = new Point(378, 131);
            lbAOWB.Name = "lbAOWB";
            lbAOWB.Size = new Size(150, 17);
            lbAOWB.TabIndex = 20;
            lbAOWB.Text = "Amount of water used:";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(169, 85);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(126, 25);
            tbPhone.TabIndex = 1;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(23, 88);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(108, 17);
            lbPhone.TabIndex = 18;
            lbPhone.Text = "PHONE NUMBER";
            // 
            // btDelete
            // 
            btDelete.Location = new Point(243, 248);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 8;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(348, 248);
            btClear.Name = "btClear";
            btClear.Size = new Size(75, 23);
            btClear.TabIndex = 9;
            btClear.Text = "Clear form";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // lbTotalWaterB
            // 
            lbTotalWaterB.AutoSize = true;
            lbTotalWaterB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalWaterB.Location = new Point(378, 185);
            lbTotalWaterB.Name = "lbTotalWaterB";
            lbTotalWaterB.Size = new Size(105, 17);
            lbTotalWaterB.TabIndex = 15;
            lbTotalWaterB.Text = "Total water bill:";
            // 
            // lbLastM
            // 
            lbLastM.AutoSize = true;
            lbLastM.Location = new Point(378, 43);
            lbLastM.Name = "lbLastM";
            lbLastM.Size = new Size(88, 17);
            lbLastM.TabIndex = 14;
            lbLastM.Text = "LAST MONTH";
            // 
            // btExit
            // 
            btExit.Location = new Point(553, 246);
            btExit.Name = "btExit";
            btExit.Size = new Size(75, 23);
            btExit.TabIndex = 11;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btResult
            // 
            btResult.Location = new Point(23, 248);
            btResult.Name = "btResult";
            btResult.Size = new Size(75, 23);
            btResult.TabIndex = 6;
            btResult.Text = "Add";
            btResult.UseVisualStyleBackColor = true;
            btResult.Click += btResult_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(124, 248);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(98, 23);
            btEdit.TabIndex = 7;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += Edit_Click;
            // 
            // lbHuman
            // 
            lbHuman.Location = new Point(23, 177);
            lbHuman.Name = "lbHuman";
            lbHuman.Size = new Size(145, 36);
            lbHuman.TabIndex = 10;
            lbHuman.Text = "NUMBER OF MEMBER (Only Type Family)";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(23, 131);
            lbType.Name = "lbType";
            lbType.Size = new Size(127, 17);
            lbType.TabIndex = 9;
            lbType.Text = "TYPE OF CUSTOMER";
            // 
            // tbHuman
            // 
            tbHuman.Location = new Point(169, 182);
            tbHuman.Name = "tbHuman";
            tbHuman.Size = new Size(126, 25);
            tbHuman.TabIndex = 3;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Family", "Administrative agency", "Public services", "Production units", "Business services" });
            cbType.Location = new Point(169, 128);
            cbType.Name = "cbType";
            cbType.Size = new Size(126, 25);
            cbType.TabIndex = 2;
            // 
            // tbThisM
            // 
            tbThisM.Location = new Point(504, 80);
            tbThisM.Name = "tbThisM";
            tbThisM.Size = new Size(86, 25);
            tbThisM.TabIndex = 5;
            // 
            // tbLastM
            // 
            tbLastM.Location = new Point(378, 80);
            tbLastM.Name = "tbLastM";
            tbLastM.Size = new Size(88, 25);
            tbLastM.TabIndex = 4;
            // 
            // lbThisM
            // 
            lbThisM.AutoSize = true;
            lbThisM.Location = new Point(504, 43);
            lbThisM.Name = "lbThisM";
            lbThisM.Size = new Size(86, 17);
            lbThisM.TabIndex = 3;
            lbThisM.Text = "THIS MONTH";
            // 
            // LBname
            // 
            LBname.AutoSize = true;
            LBname.Location = new Point(24, 43);
            LBname.Name = "LBname";
            LBname.Size = new Size(116, 17);
            LBname.TabIndex = 2;
            LBname.Text = "CUSTOMER NAME";
            // 
            // tbName
            // 
            tbName.Location = new Point(169, 40);
            tbName.Name = "tbName";
            tbName.Size = new Size(126, 25);
            tbName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(361, 9);
            label1.Name = "label1";
            label1.Size = new Size(449, 50);
            label1.TabIndex = 1;
            label1.Text = "CARCULATE WATER BILL";
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(2, 355);
            listView1.Name = "listView1";
            listView1.Size = new Size(1143, 183);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 540);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(grbCWB);
            Name = "Form1";
            Text = "CARCULATE WATER BILL";
            Load += Form1_Load;
            grbCWB.ResumeLayout(false);
            grbCWB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbCWB;
        private TextBox tbName;
        private Label LBname;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label3;
        private Label lbThisM;
        private Label lbHuman;
        private Label lbType;
        private TextBox tbHuman;
        private ComboBox cbType;
        private TextBox tbLastM;
        private TextBox tbThisM;
        private Button btExit;
        private Button btResult;
        private Button btEdit;
        private ListView listView1;
        private Label lbLastM;
        private Label lbTotalWaterB;
        private Button btClear;
        private Button btDelete;
        private TextBox tbPhone;
        private Label lbPhone;
        private Label lbAOWB;
        private Button btPrBill;
    }
}
