// App Name : Race Form
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
    public partial class RaceForm : Form
    {
        public Form previousForm;
        public RaceForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Create an object of JobForm
            JobForm jobForm = new JobForm();

            jobForm.previosForm = this;
            jobForm.Show();
            this.Hide();
        }
        private void _checkedChangeEvent()
        {
            if(HumanRadioButton.Checked == true)
            {
                CharacterPictureBox.Load("c:/users/kinjal/documents/visual studio 2015/Projects/COMP1004-W2017-MidTermAssgnment-200334364/COMP1004-W2017-MidTermAssgnment-200334364/Resources/M_Human1.png");
            }
            else if(DwarfRadioButton.Checked == true)
            {
                CharacterPictureBox.Load("c:/users/kinjal/documents/visual studio 2015/Projects/COMP1004-W2017-MidTermAssgnment-200334364/COMP1004-W2017-MidTermAssgnment-200334364/Resources/M_Dwarf1.png");
            }
            else if (ElfRadioButton.Checked == true)
            {
                CharacterPictureBox.Load("c:/users/kinjal/documents/visual studio 2015/Projects/COMP1004-W2017-MidTermAssgnment-200334364/COMP1004-W2017-MidTermAssgnment-200334364/Resources/M_Elf1.png");
            }
            else if(HalflingRadioButton.Checked == true)
            { 
                CharacterPictureBox.Load("c:/users/kinjal/documents/visual studio 2015/Projects/COMP1004-W2017-MidTermAssgnment-200334364/COMP1004-W2017-MidTermAssgnment-200334364/Resources/M_Halfling2.png");
            }
            else
            {
                CharacterPictureBox.Load("c:/users/kinjal/documents/visual studio 2015/Projects/COMP1004-W2017-MidTermAssgnment-200334364/COMP1004-W2017-MidTermAssgnment-200334364/Resources/M_Human1.png");
            }
        }        
        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this._checkedChangeEvent();
        }

        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this._checkedChangeEvent();
        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this._checkedChangeEvent();
        }
    }
}
