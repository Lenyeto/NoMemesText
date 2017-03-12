using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMemesTextQuestCreator
{
    public partial class Form1 : Form
    {


        Quest tmpQuest;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Quest Name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tmpQuest.mName = QuestNameBox.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //Quest Description
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            tmpQuest.mDescription = questDescriptionTextBox.Text;
        }

        //Quest Type


        private void objectiveTargetTextBox_TextChanged(object sender, EventArgs e)
        {
            //tmpQuest.mTargetObjID = objectiveTargetTextBox.Text;
        }

        //Gold reward
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            tmpQuest.mGoldReward = Convert.ToInt32(goldRewardTextBox.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tmpQuest.mHasReward = hasRewardCheckBox.Checked;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            tmpQuest.mXPReward = Convert.ToInt32(xpRewardTextBox.Text);
        }

        //Item reward
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (tmpQuest.mHasReward == true)
            {
                tmpQuest.mItemIDReward = Convert.ToInt32(itemRewardTextBox.Text);
            }
            else
            {
                tmpQuest.mItemIDReward = 0; //Assigning no item reward
            }

        }

        private void deliverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //tmpQuest.
        }
    }
}
