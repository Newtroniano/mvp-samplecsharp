namespace MVPCRUD.View
{
    partial class UserVIew
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            userIdbox = new TextBox();
            nickName = new TextBox();
            userPassbox = new TextBox();
            userEmailbox = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "UserID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "UserEmail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 106);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "UserPassword";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 175);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "NickName";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(602, 349);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(userEmailbox);
            tabPage1.Controls.Add(userPassbox);
            tabPage1.Controls.Add(nickName);
            tabPage1.Controls.Add(userIdbox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(594, 321);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(594, 321);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // userIdbox
            // 
            userIdbox.Location = new Point(9, 51);
            userIdbox.Name = "userIdbox";
            userIdbox.Size = new Size(100, 23);
            userIdbox.TabIndex = 5;
            userIdbox.TextChanged += textBox1_TextChanged;
            // 
            // nickName
            // 
            nickName.Location = new Point(9, 193);
            nickName.Name = "nickName";
            nickName.Size = new Size(100, 23);
            nickName.TabIndex = 6;
            nickName.TextChanged += nickName_TextChanged;
            // 
            // userPassbox
            // 
            userPassbox.Location = new Point(115, 124);
            userPassbox.Name = "userPassbox";
            userPassbox.Size = new Size(100, 23);
            userPassbox.TabIndex = 7;
            userPassbox.TextChanged += userPassbox_TextChanged;
            // 
            // userEmailbox
            // 
            userEmailbox.Location = new Point(9, 124);
            userEmailbox.Name = "userEmailbox";
            userEmailbox.Size = new Size(100, 23);
            userEmailbox.TabIndex = 8;
            userEmailbox.TextChanged += userEmailbox_TextChanged;
            // 
            // UserVIew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "UserVIew";
            Text = "UserVIew";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox userEmailbox;
        private TextBox userPassbox;
        private TextBox nickName;
        private TextBox userIdbox;
    }
}