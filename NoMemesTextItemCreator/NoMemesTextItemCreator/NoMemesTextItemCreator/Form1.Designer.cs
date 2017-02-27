namespace NoMemesTextItemCreator
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
            this.components = new System.ComponentModel.Container();
            this.itemTypeDropDown = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemSlotDropDown = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.questBox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.damageSelect = new System.Windows.Forms.NumericUpDown();
            this.armorSelect = new System.Windows.Forms.NumericUpDown();
            this.SetSelected = new System.Windows.Forms.Button();
            this.itemDescriptionFromList = new System.Windows.Forms.RichTextBox();
            this.nameFromSelected = new System.Windows.Forms.TextBox();
            this.typeFromSelected = new System.Windows.Forms.TextBox();
            this.slotFromSelected = new System.Windows.Forms.TextBox();
            this.damageFromSelected = new System.Windows.Forms.TextBox();
            this.armorFromSelected = new System.Windows.Forms.TextBox();
            this.isQuestItemFromSelected = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damageSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // itemTypeDropDown
            // 
            this.itemTypeDropDown.FormattingEnabled = true;
            this.itemTypeDropDown.Items.AddRange(new object[] {
            "Weapon",
            "Armor",
            "Consumable",
            "Trinket"});
            this.itemTypeDropDown.Location = new System.Drawing.Point(23, 195);
            this.itemTypeDropDown.Name = "itemTypeDropDown";
            this.itemTypeDropDown.Size = new System.Drawing.Size(121, 21);
            this.itemTypeDropDown.TabIndex = 2;
            this.itemTypeDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(24, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 80);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(121, 96);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.Text = "";
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item Slot";
            // 
            // itemSlotDropDown
            // 
            this.itemSlotDropDown.FormattingEnabled = true;
            this.itemSlotDropDown.Items.AddRange(new object[] {
            "Head",
            "Torso",
            "Legs",
            "Feet",
            "MainHand",
            "OffHand"});
            this.itemSlotDropDown.Location = new System.Drawing.Point(23, 236);
            this.itemSlotDropDown.Name = "itemSlotDropDown";
            this.itemSlotDropDown.Size = new System.Drawing.Size(121, 21);
            this.itemSlotDropDown.TabIndex = 3;
            this.itemSlotDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(504, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 548);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 554);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Damage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Armor";
            // 
            // questBox
            // 
            this.questBox.AutoSize = true;
            this.questBox.Location = new System.Drawing.Point(24, 341);
            this.questBox.Name = "questBox";
            this.questBox.Size = new System.Drawing.Size(97, 17);
            this.questBox.TabIndex = 6;
            this.questBox.Text = "Is a Quest Item";
            this.questBox.UseVisualStyleBackColor = true;
            this.questBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 54);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.openToolStripMenuItem.Text = "open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "save";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem2,
            this.saveToolStripMenuItem1});
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.openToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem2
            // 
            this.openToolStripMenuItem2.Name = "openToolStripMenuItem2";
            this.openToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem2.Text = "Open";
            this.openToolStripMenuItem2.Click += new System.EventHandler(this.openToolStripMenuItem2_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Selected";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Description";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Item Type";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Item Slot";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Damage";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Armor";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Quest Item";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // damageSelect
            // 
            this.damageSelect.Location = new System.Drawing.Point(23, 276);
            this.damageSelect.Name = "damageSelect";
            this.damageSelect.Size = new System.Drawing.Size(120, 20);
            this.damageSelect.TabIndex = 4;
            this.damageSelect.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // armorSelect
            // 
            this.armorSelect.Location = new System.Drawing.Point(23, 315);
            this.armorSelect.Name = "armorSelect";
            this.armorSelect.Size = new System.Drawing.Size(120, 20);
            this.armorSelect.TabIndex = 5;
            this.armorSelect.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // SetSelected
            // 
            this.SetSelected.Location = new System.Drawing.Point(423, 408);
            this.SetSelected.Name = "SetSelected";
            this.SetSelected.Size = new System.Drawing.Size(75, 23);
            this.SetSelected.TabIndex = 10;
            this.SetSelected.Text = "Set Values From Selected";
            this.SetSelected.UseVisualStyleBackColor = true;
            this.SetSelected.Click += new System.EventHandler(this.SetSelected_Click);
            // 
            // itemDescriptionFromList
            // 
            this.itemDescriptionFromList.BackColor = System.Drawing.SystemColors.Control;
            this.itemDescriptionFromList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemDescriptionFromList.Location = new System.Drawing.Point(311, 120);
            this.itemDescriptionFromList.Name = "itemDescriptionFromList";
            this.itemDescriptionFromList.ReadOnly = true;
            this.itemDescriptionFromList.Size = new System.Drawing.Size(187, 59);
            this.itemDescriptionFromList.TabIndex = 36;
            this.itemDescriptionFromList.Text = "";
            // 
            // nameFromSelected
            // 
            this.nameFromSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameFromSelected.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameFromSelected.Location = new System.Drawing.Point(311, 99);
            this.nameFromSelected.Name = "nameFromSelected";
            this.nameFromSelected.ReadOnly = true;
            this.nameFromSelected.Size = new System.Drawing.Size(187, 20);
            this.nameFromSelected.TabIndex = 37;
            // 
            // typeFromSelected
            // 
            this.typeFromSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeFromSelected.Location = new System.Drawing.Point(311, 182);
            this.typeFromSelected.Name = "typeFromSelected";
            this.typeFromSelected.ReadOnly = true;
            this.typeFromSelected.Size = new System.Drawing.Size(187, 20);
            this.typeFromSelected.TabIndex = 38;
            // 
            // slotFromSelected
            // 
            this.slotFromSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slotFromSelected.Location = new System.Drawing.Point(311, 206);
            this.slotFromSelected.Name = "slotFromSelected";
            this.slotFromSelected.ReadOnly = true;
            this.slotFromSelected.Size = new System.Drawing.Size(187, 20);
            this.slotFromSelected.TabIndex = 39;
            // 
            // damageFromSelected
            // 
            this.damageFromSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.damageFromSelected.Location = new System.Drawing.Point(311, 232);
            this.damageFromSelected.Name = "damageFromSelected";
            this.damageFromSelected.ReadOnly = true;
            this.damageFromSelected.Size = new System.Drawing.Size(187, 20);
            this.damageFromSelected.TabIndex = 40;
            // 
            // armorFromSelected
            // 
            this.armorFromSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.armorFromSelected.Location = new System.Drawing.Point(311, 257);
            this.armorFromSelected.Name = "armorFromSelected";
            this.armorFromSelected.ReadOnly = true;
            this.armorFromSelected.Size = new System.Drawing.Size(187, 20);
            this.armorFromSelected.TabIndex = 41;
            // 
            // isQuestItemFromSelected
            // 
            this.isQuestItemFromSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isQuestItemFromSelected.Location = new System.Drawing.Point(311, 283);
            this.isQuestItemFromSelected.Name = "isQuestItemFromSelected";
            this.isQuestItemFromSelected.ReadOnly = true;
            this.isQuestItemFromSelected.Size = new System.Drawing.Size(187, 20);
            this.isQuestItemFromSelected.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 589);
            this.Controls.Add(this.isQuestItemFromSelected);
            this.Controls.Add(this.armorFromSelected);
            this.Controls.Add(this.damageFromSelected);
            this.Controls.Add(this.slotFromSelected);
            this.Controls.Add(this.typeFromSelected);
            this.Controls.Add(this.nameFromSelected);
            this.Controls.Add(this.itemDescriptionFromList);
            this.Controls.Add(this.SetSelected);
            this.Controls.Add(this.armorSelect);
            this.Controls.Add(this.damageSelect);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.questBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.itemSlotDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.itemTypeDropDown);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NoMemesText Item Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damageSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox itemTypeDropDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemSlotDropDown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox questBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown damageSelect;
        private System.Windows.Forms.NumericUpDown armorSelect;
        private System.Windows.Forms.Button SetSelected;
        private System.Windows.Forms.RichTextBox itemDescriptionFromList;
        private System.Windows.Forms.TextBox nameFromSelected;
        private System.Windows.Forms.TextBox typeFromSelected;
        private System.Windows.Forms.TextBox slotFromSelected;
        private System.Windows.Forms.TextBox damageFromSelected;
        private System.Windows.Forms.TextBox armorFromSelected;
        private System.Windows.Forms.TextBox isQuestItemFromSelected;
    }
}

