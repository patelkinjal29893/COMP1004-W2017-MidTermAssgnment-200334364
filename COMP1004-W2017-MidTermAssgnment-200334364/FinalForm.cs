// App Name : Final Form
// Author's Name : Kinjal Patel 
// Student ID : 200334364
// App Creation Date : February 22, 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200334364
{
    public partial class FinalForm : Form
    {
        public JobForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is handler for Exit Button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This is the handler for Form loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalForm_Load(object sender, EventArgs e)
        {
            HealthPointTextBox.Text = Program.character.Health;
            RaceTextBox.Text = Program.character.Race;
            JobTextBox.Text = Program.character.Job;
            STRTextBox.Text = Program.character.STR;
            DEXTextBox.Text = Program.character.DEX;
            ENDTextBox.Text = Program.character.END;
            INTTextBox.Text = Program.character.INT;
            PERTextBox.Text = Program.character.PER;
            CHATextBox.Text = Program.character.CHA;

            if (RaceTextBox.Text == "Human")
            {
                RacePictureBox.Image = Properties.Resources.M_Human1;
            }
            else if (RaceTextBox.Text == "Elf")
            {
                RacePictureBox.Image = Properties.Resources.M_Elf1;
            }
            else if (RaceTextBox.Text == "Dwarf")
            { 
                RacePictureBox.Image = Properties.Resources.M_Dwarf1;
            }
            else if (RaceTextBox.Text == "Halfling")
            {
                RacePictureBox.Image = Properties.Resources.M_Halfling2;
            }
        }

        /// <summary>
        /// This is handler for print menu to pass the Message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sending your information to printer.!!!!!!!");
        }
        /// <summary>
        /// This is handler for about menu to display new AboutBox for pass message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();

            aboutBox.ShowDialog();
        }
        /// <summary>
        /// This is handler for Font menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowDialog();

            NameTextBox.Font = fontDialog.Font;
            AgeTextBox.Font = fontDialog.Font;
            HeightTextBox.Font = fontDialog.Font;
        }
    }
}
