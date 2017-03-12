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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hasRewardCheckBox = new System.Windows.Forms.CheckBox();
            this.goldRewardTextBox = new System.Windows.Forms.TextBox();
            this.xpRewardTextBox = new System.Windows.Forms.TextBox();
            this.itemRewardTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deliverRadioButton = new System.Windows.Forms.RadioButton();
            this.questTypeBox = new System.Windows.Forms.GroupBox();
            this.gotoRadioButton = new System.Windows.Forms.RadioButton();
            this.gatherRadioButton = new System.Windows.Forms.RadioButton();
            this.killRadioButton = new System.Windows.Forms.RadioButton();
            this.killGroupBox = new System.Windows.Forms.GroupBox();
            this.beastRadioButton = new System.Windows.Forms.RadioButton();
            this.humanoidRadioButton = new System.Windows.Forms.RadioButton();
            this.undeadRadioButton = new System.Windows.Forms.RadioButton();
            this.elementalRadioButton = new System.Windows.Forms.RadioButton();
            this.questTypeBox.SuspendLayout();
            this.killGroupBox.SuspendLayout();
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
            // deliverRadioButton
            // 
            this.deliverRadioButton.AutoSize = true;
            this.deliverRadioButton.Location = new System.Drawing.Point(19, 44);
            this.deliverRadioButton.Name = "deliverRadioButton";
            this.deliverRadioButton.Size = new System.Drawing.Size(82, 24);
            this.deliverRadioButton.TabIndex = 32;
            this.deliverRadioButton.TabStop = true;
            this.deliverRadioButton.Text = "Deliver";
            this.deliverRadioButton.UseVisualStyleBackColor = true;
            this.deliverRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // questTypeBox
            // 
            this.questTypeBox.Controls.Add(this.gotoRadioButton);
            this.questTypeBox.Controls.Add(this.gatherRadioButton);
            this.questTypeBox.Controls.Add(this.killRadioButton);
            this.questTypeBox.Controls.Add(this.deliverRadioButton);
            this.questTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questTypeBox.Location = new System.Drawing.Point(753, 57);
            this.questTypeBox.Name = "questTypeBox";
            this.questTypeBox.Size = new System.Drawing.Size(200, 221);
            this.questTypeBox.TabIndex = 33;
            this.questTypeBox.TabStop = false;
            this.questTypeBox.Text = "Quest Type";
            this.questTypeBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gotoRadioButton
            // 
            this.gotoRadioButton.AutoSize = true;
            this.gotoRadioButton.Location = new System.Drawing.Point(19, 181);
            this.gotoRadioButton.Name = "gotoRadioButton";
            this.gotoRadioButton.Size = new System.Drawing.Size(67, 24);
            this.gotoRadioButton.TabIndex = 34;
            this.gotoRadioButton.TabStop = true;
            this.gotoRadioButton.Text = "Goto";
            this.gotoRadioButton.UseVisualStyleBackColor = true;
            this.gotoRadioButton.CheckedChanged += new System.EventHandler(this.gotoRadioButton_CheckedChanged);
            // 
            // gatherRadioButton
            // 
            this.gatherRadioButton.AutoSize = true;
            this.gatherRadioButton.Location = new System.Drawing.Point(20, 136);
            this.gatherRadioButton.Name = "gatherRadioButton";
            this.gatherRadioButton.Size = new System.Drawing.Size(83, 24);
            this.gatherRadioButton.TabIndex = 34;
            this.gatherRadioButton.TabStop = true;
            this.gatherRadioButton.Text = "Gather";
            this.gatherRadioButton.UseVisualStyleBackColor = true;
            this.gatherRadioButton.CheckedChanged += new System.EventHandler(this.gatherRadioButton_CheckedChanged);
            // 
            // killRadioButton
            // 
            this.killRadioButton.AutoSize = true;
            this.killRadioButton.Location = new System.Drawing.Point(20, 90);
            this.killRadioButton.Name = "killRadioButton";
            this.killRadioButton.Size = new System.Drawing.Size(50, 24);
            this.killRadioButton.TabIndex = 33;
            this.killRadioButton.TabStop = true;
            this.killRadioButton.Text = "Kill";
            this.killRadioButton.UseVisualStyleBackColor = true;
            this.killRadioButton.CheckedChanged += new System.EventHandler(this.killRadioButton_CheckedChanged);
            // 
            // killGroupBox
            // 
            this.killGroupBox.Controls.Add(this.elementalRadioButton);
            this.killGroupBox.Controls.Add(this.humanoidRadioButton);
            this.killGroupBox.Controls.Add(this.beastRadioButton);
            this.killGroupBox.Controls.Add(this.undeadRadioButton);
            this.killGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killGroupBox.Location = new System.Drawing.Point(300, 514);
            this.killGroupBox.Name = "killGroupBox";
            this.killGroupBox.Size = new System.Drawing.Size(200, 168);
            this.killGroupBox.TabIndex = 34;
            this.killGroupBox.TabStop = false;
            this.killGroupBox.Text = "Quest Type Kill";
            // 
            // beastRadioButton
            // 
            this.beastRadioButton.AutoSize = true;
            this.beastRadioButton.Location = new System.Drawing.Point(19, 26);
            this.beastRadioButton.Name = "beastRadioButton";
            this.beastRadioButton.Size = new System.Drawing.Size(74, 24);
            this.beastRadioButton.TabIndex = 0;
            this.beastRadioButton.TabStop = true;
            this.beastRadioButton.Text = "Beast";
            this.beastRadioButton.UseVisualStyleBackColor = true;
            this.beastRadioButton.CheckedChanged += new System.EventHandler(this.beastRadioButton_CheckedChanged);
            // 
            // humanoidRadioButton
            // 
            this.humanoidRadioButton.AutoSize = true;
            this.humanoidRadioButton.Location = new System.Drawing.Point(19, 56);
            this.humanoidRadioButton.Name = "humanoidRadioButton";
            this.humanoidRadioButton.Size = new System.Drawing.Size(108, 24);
            this.humanoidRadioButton.TabIndex = 1;
            this.humanoidRadioButton.TabStop = true;
            this.humanoidRadioButton.Text = "Humanoid";
            this.humanoidRadioButton.UseVisualStyleBackColor = true;
            this.humanoidRadioButton.CheckedChanged += new System.EventHandler(this.humanoidRadioButton_CheckedChanged);
            // 
            // undeadRadioButton
            // 
            this.undeadRadioButton.AutoSize = true;
            this.undeadRadioButton.Location = new System.Drawing.Point(20, 86);
            this.undeadRadioButton.Name = "undeadRadioButton";
            this.undeadRadioButton.Size = new System.Drawing.Size(90, 24);
            this.undeadRadioButton.TabIndex = 2;
            this.undeadRadioButton.TabStop = true;
            this.undeadRadioButton.Text = "Undead";
            this.undeadRadioButton.UseVisualStyleBackColor = true;
            this.undeadRadioButton.CheckedChanged += new System.EventHandler(this.undeadRadioButton_CheckedChanged);
            // 
            // elementalRadioButton
            // 
            this.elementalRadioButton.AutoSize = true;
            this.elementalRadioButton.Location = new System.Drawing.Point(19, 116);
            this.elementalRadioButton.Name = "elementalRadioButton";
            this.elementalRadioButton.Size = new System.Drawing.Size(107, 24);
            this.elementalRadioButton.TabIndex = 3;
            this.elementalRadioButton.TabStop = true;
            this.elementalRadioButton.Text = "Elemental";
            this.elementalRadioButton.UseVisualStyleBackColor = true;
            this.elementalRadioButton.CheckedChanged += new System.EventHandler(this.elementalRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 749);
            this.Controls.Add(this.killGroupBox);
            this.Controls.Add(this.questTypeBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.itemRewardTextBox);
            this.Controls.Add(this.xpRewardTextBox);
            this.Controls.Add(this.goldRewardTextBox);
            this.Controls.Add(this.hasRewardCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
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
            this.questTypeBox.ResumeLayout(false);
            this.questTypeBox.PerformLayout();
            this.killGroupBox.ResumeLayout(false);
            this.killGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuestNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questDescriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox hasRewardCheckBox;
        private System.Windows.Forms.TextBox goldRewardTextBox;
        private System.Windows.Forms.TextBox xpRewardTextBox;
        private System.Windows.Forms.TextBox itemRewardTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton deliverRadioButton;
        private System.Windows.Forms.GroupBox questTypeBox;
        private System.Windows.Forms.RadioButton gotoRadioButton;
        private System.Windows.Forms.RadioButton gatherRadioButton;
        private System.Windows.Forms.RadioButton killRadioButton;
        private System.Windows.Forms.GroupBox killGroupBox;
        private System.Windows.Forms.RadioButton elementalRadioButton;
        private System.Windows.Forms.RadioButton humanoidRadioButton;
        private System.Windows.Forms.RadioButton beastRadioButton;
        private System.Windows.Forms.RadioButton undeadRadioButton;
    }
}

