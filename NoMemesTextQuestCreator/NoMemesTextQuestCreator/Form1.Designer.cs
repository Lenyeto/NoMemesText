namespace NoMemesTextQuestCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.QuestNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.questDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hasRewardCheckBox = new System.Windows.Forms.CheckBox();
            this.goldRewardTextBox = new System.Windows.Forms.TextBox();
            this.xpRewardTextBox = new System.Windows.Forms.TextBox();
            this.itemRewardTextBox = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.deliverCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quest Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuestNameBox
            // 
            this.QuestNameBox.Location = new System.Drawing.Point(22, 82);
            this.QuestNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuestNameBox.Multiline = true;
            this.QuestNameBox.Name = "QuestNameBox";
            this.QuestNameBox.Size = new System.Drawing.Size(214, 43);
            this.QuestNameBox.TabIndex = 2;
            this.QuestNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quest Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // questDescriptionTextBox
            // 
            this.questDescriptionTextBox.Location = new System.Drawing.Point(22, 153);
            this.questDescriptionTextBox.Multiline = true;
            this.questDescriptionTextBox.Name = "questDescriptionTextBox";
            this.questDescriptionTextBox.Size = new System.Drawing.Size(382, 315);
            this.questDescriptionTextBox.TabIndex = 4;
            this.questDescriptionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(749, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quest Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Objective Target";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gold Reward";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "XP Reward";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(487, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Item Reward";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // hasRewardCheckBox
            // 
            this.hasRewardCheckBox.AutoSize = true;
            this.hasRewardCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasRewardCheckBox.Location = new System.Drawing.Point(487, 211);
            this.hasRewardCheckBox.Name = "hasRewardCheckBox";
            this.hasRewardCheckBox.Size = new System.Drawing.Size(167, 24);
            this.hasRewardCheckBox.TabIndex = 11;
            this.hasRewardCheckBox.Text = "Has Item Reward";
            this.hasRewardCheckBox.UseVisualStyleBackColor = true;
            this.hasRewardCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // goldRewardTextBox
            // 
            this.goldRewardTextBox.Location = new System.Drawing.Point(487, 80);
            this.goldRewardTextBox.Name = "goldRewardTextBox";
            this.goldRewardTextBox.Size = new System.Drawing.Size(170, 26);
            this.goldRewardTextBox.TabIndex = 15;
            this.goldRewardTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // xpRewardTextBox
            // 
            this.xpRewardTextBox.Location = new System.Drawing.Point(487, 147);
            this.xpRewardTextBox.Name = "xpRewardTextBox";
            this.xpRewardTextBox.Size = new System.Drawing.Size(170, 26);
            this.xpRewardTextBox.TabIndex = 16;
            this.xpRewardTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // itemRewardTextBox
            // 
            this.itemRewardTextBox.Location = new System.Drawing.Point(487, 261);
            this.itemRewardTextBox.Multiline = true;
            this.itemRewardTextBox.Name = "itemRewardTextBox";
            this.itemRewardTextBox.Size = new System.Drawing.Size(170, 149);
            this.itemRewardTextBox.TabIndex = 17;
            this.itemRewardTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(294, 533);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(140, 24);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "beastCheckBox";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(294, 571);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(170, 24);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "humanoidCheckBox";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(294, 615);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(154, 24);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "undeadCheckBox";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(294, 656);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(169, 24);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Text = "elementalCheckBox";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 724);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(299, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "ONLY SELECT ONE CHECK BOX AT THIS TIME";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(291, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Quest Type Kill";
            // 
            // deliverCheckBox
            // 
            this.deliverCheckBox.AutoSize = true;
            this.deliverCheckBox.Location = new System.Drawing.Point(753, 121);
            this.deliverCheckBox.Name = "deliverCheckBox";
            this.deliverCheckBox.Size = new System.Drawing.Size(73, 24);
            this.deliverCheckBox.TabIndex = 25;
            this.deliverCheckBox.Text = "deliver";
            this.deliverCheckBox.UseVisualStyleBackColor = true;
            this.deliverCheckBox.CheckedChanged += new System.EventHandler(this.deliverCheckBox_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(753, 151);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(45, 24);
            this.checkBox7.TabIndex = 26;
            this.checkBox7.Text = "kill";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(753, 181);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(74, 24);
            this.checkBox8.TabIndex = 27;
            this.checkBox8.Text = "gather";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(753, 211);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(60, 24);
            this.checkBox9.TabIndex = 28;
            this.checkBox9.Text = "goto";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Quest Type Deliver";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(568, 514);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Quest Type Gather";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(778, 514);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Quest Type Goto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 749);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.deliverCheckBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.itemRewardTextBox);
            this.Controls.Add(this.xpRewardTextBox);
            this.Controls.Add(this.goldRewardTextBox);
            this.Controls.Add(this.hasRewardCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.questDescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestNameBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuestNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox hasRewardCheckBox;
        private System.Windows.Forms.TextBox goldRewardTextBox;
        private System.Windows.Forms.TextBox xpRewardTextBox;
        private System.Windows.Forms.TextBox itemRewardTextBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox deliverCheckBox;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

