using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NoMemesTextItemCreator
{
    public partial class Form1 : Form
    {

        Item tmpItem;

        public Form1()
        {
            InitializeComponent();

            tmpItem = new Item();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Item(tmpItem));
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                nameFromSelected.Text = ((Item)listBox1.SelectedItem).mName;
                itemDescriptionFromList.Text = ((Item)listBox1.SelectedItem).mDescription;
                typeFromSelected.Text = ((Item)listBox1.SelectedItem).mType.ToString();
                slotFromSelected.Text = ((Item)listBox1.SelectedItem).mSlot.ToString();
                damageFromSelected.Text = ((Item)listBox1.SelectedItem).mDMG.ToString();
                armorFromSelected.Text = ((Item)listBox1.SelectedItem).mArmor.ToString();
                isQuestItemFromSelected.Text = ((Item)listBox1.SelectedItem).isQuestItem.ToString();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tmpItem.mName = nameTextBox.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            tmpItem.mDescription = descriptionTextBox.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmpItem.mSlot = (ItemSlot) Enum.Parse(typeof(ItemSlot), itemSlotDropDown.Text, true);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tmpItem.isQuestItem = questBox.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmpItem.mType = (ItemType)Enum.Parse(typeof(ItemType), itemTypeDropDown.Text, true);
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tmpItem.mDMG = (int)damageSelect.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            tmpItem.mArmor = (int)armorSelect.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList tmpArray = new ArrayList();
            List<string> tmpList = new List<string>();



            string tmpString;
            foreach (Item i in listBox1.Items)
            {
                tmpString = "";
                tmpString = i.mName + ',' + i.mDescription + ',' + i.mType + ',' + i.mSlot + ',' + i.mDMG + ',' + i.mArmor + ',' + i.mValue + ',' + i.isQuestItem;
                tmpList.Add(tmpString);
                
            }

            string[] tmpContents = tmpList.ToArray();
            File.WriteAllLines("items.csv", tmpContents);
        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[] tmpLines = File.ReadAllLines("items.csv");

            foreach (string s in tmpLines)
            {
                string[] s2 = s.Split(',');

                listBox1.Items.Add(new Item(s2[0], s2[1], (ItemType)Enum.Parse(typeof(ItemType), s2[2], true), tmpItem.mSlot = (ItemSlot)Enum.Parse(typeof(ItemSlot), s2[3], true), int.Parse(s2[4]), int.Parse(s2[5]), int.Parse(s2[6]), bool.Parse(s2[7])));
            }
        }

        private void SetSelected_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                nameTextBox.Text = ((Item)listBox1.SelectedItem).mName;
                descriptionTextBox.Text = ((Item)listBox1.SelectedItem).mDescription;
                itemTypeDropDown.SelectedIndex = (int)((Item)listBox1.SelectedItem).mType;
                itemSlotDropDown.SelectedIndex = (int)((Item)listBox1.SelectedItem).mSlot;
                damageSelect.Value = ((Item)listBox1.SelectedItem).mDMG;
                armorSelect.Value = ((Item)listBox1.SelectedItem).mArmor;
                questBox.Checked = ((Item)listBox1.SelectedItem).isQuestItem;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
