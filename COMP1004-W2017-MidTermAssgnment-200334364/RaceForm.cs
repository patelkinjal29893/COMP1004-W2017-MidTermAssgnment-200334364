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
        private String _race;
        public AbilityForm abilityForm;

        public Form previousForm;

        private int _STR = Convert.ToInt32(Program.character.STR);
        private int _DEX = Convert.ToInt32(Program.character.DEX);
        private int _END = Convert.ToInt32(Program.character.END);
        private int _INT = Convert.ToInt32(Program.character.INT);
        private int _PER = Convert.ToInt32(Program.character.PER);
        private int _CHA = Convert.ToInt32(Program.character.CHA);

        public RaceForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = _race;

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

                RacialBonusTextBox.Text = "Increase all abilities by 10";
                _STR = _STR + 5;
                _DEX = _DEX + 5;
                _END = _END + 5;
                _INT = _INT + 5;
                _PER = _PER + 5;
                _CHA = _CHA + 5;

                this._race = RacialBonusTextBox.Text;
            }
        }        
        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this._checkedChangeEvent();

            RacialBonusTextBox.Text = "Increase STR and PER by 20, Decrease CHA by 10";

            _STR = _STR + 20;
            _PER = _PER + 20;
            _CHA = _CHA - 10;
            this._race = RacialBonusTextBox.Text;

        }

        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this._checkedChangeEvent();

            RacialBonusTextBox.Text = "Increase DEX and PER by 20";

            _DEX = _DEX + 20;
            _PER = _PER + 20;

            this._race = RacialBonusTextBox.Text;
        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this._checkedChangeEvent();

            RacialBonusTextBox.Text = "Increase DEX and INT by 20, Decrease STR by 10";
            _DEX = _DEX + 20;
            _INT = _INT + 20;
            _STR = _STR - 10;

            this._race = RacialBonusTextBox.Text;
        }

    }        
}
