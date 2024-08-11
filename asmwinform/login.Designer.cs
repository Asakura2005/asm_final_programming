namespace asmwinform
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            tbPass = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 71);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 0;
            label1.Text = "Used Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 117);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(176, 71);
            tbName.Name = "tbName";
            tbName.Size = new Size(109, 25);
            tbName.TabIndex = 2;
            tbName.Text = "admin";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(176, 114);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(109, 25);
            tbPass.TabIndex = 3;
            tbPass.Text = "strong_password";
            // 
            // button1
            // 
            button1.Location = new Point(106, 155);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbPass);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbName);
            groupBox1.Location = new Point(126, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 204);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 21);
            label3.Name = "label3";
            label3.Size = new Size(286, 30);
            label3.TabIndex = 5;
            label3.Text = "Login to calculate water bill";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(574, 267);
            Controls.Add(groupBox1);
            Name = "login";
            Text = "login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private TextBox tbPass;
        private Button button1;
        private GroupBox groupBox1;
        private Label label3;
    }
}