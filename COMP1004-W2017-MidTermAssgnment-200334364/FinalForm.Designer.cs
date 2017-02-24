namespace COMP1004_W2017_MidTermAssgnment_200334364
{
    partial class FinalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RacePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.HealthPointTextBox = new System.Windows.Forms.TextBox();
            this.JobTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CharacterInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AbilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.CHATextBox = new System.Windows.Forms.TextBox();
            this.PERTextBox = new System.Windows.Forms.TextBox();
            this.INTTextBox = new System.Windows.Forms.TextBox();
            this.ENDTextBox = new System.Windows.Forms.TextBox();
            this.DEXTextBox = new System.Windows.Forms.TextBox();
            this.STRTextBox = new System.Windows.Forms.TextBox();
            this.CHALabel = new System.Windows.Forms.Label();
            this.PERLabel = new System.Windows.Forms.Label();
            this.INTLabel = new System.Windows.Forms.Label();
            this.ENDLabel = new System.Windows.Forms.Label();
            this.DEXLabel = new System.Windows.Forms.Label();
            this.STRLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RacePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.CharacterInfoGroupBox.SuspendLayout();
            this.AbilitiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // RacePictureBox
            // 
            this.RacePictureBox.Location = new System.Drawing.Point(386, 187);
            this.RacePictureBox.Name = "RacePictureBox";
            this.RacePictureBox.Size = new System.Drawing.Size(213, 213);
            this.RacePictureBox.TabIndex = 1;
            this.RacePictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RaceTextBox);
            this.groupBox1.Controls.Add(this.HealthPointTextBox);
            this.groupBox1.Controls.Add(this.JobTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(386, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.Location = new System.Drawing.Point(133, 63);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.ReadOnly = true;
            this.RaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.RaceTextBox.TabIndex = 1;
            // 
            // HealthPointTextBox
            // 
            this.HealthPointTextBox.Location = new System.Drawing.Point(133, 104);
            this.HealthPointTextBox.Name = "HealthPointTextBox";
            this.HealthPointTextBox.ReadOnly = true;
            this.HealthPointTextBox.Size = new System.Drawing.Size(100, 20);
            this.HealthPointTextBox.TabIndex = 1;
            // 
            // JobTextBox
            // 
            this.JobTextBox.Location = new System.Drawing.Point(133, 20);
            this.JobTextBox.Name = "JobTextBox";
            this.JobTextBox.ReadOnly = true;
            this.JobTextBox.Size = new System.Drawing.Size(100, 20);
            this.JobTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Job";
            // 
            // CharacterInfoGroupBox
            // 
            this.CharacterInfoGroupBox.Controls.Add(this.HeightTextBox);
            this.CharacterInfoGroupBox.Controls.Add(this.WeightTextBox);
            this.CharacterInfoGroupBox.Controls.Add(this.AgeTextBox);
            this.CharacterInfoGroupBox.Controls.Add(this.NameTextBox);
            this.CharacterInfoGroupBox.Controls.Add(this.WeightLabel);
            this.CharacterInfoGroupBox.Controls.Add(this.AgeLabel);
            this.CharacterInfoGroupBox.Controls.Add(this.HeightLabel);
            this.CharacterInfoGroupBox.Controls.Add(this.NameLabel);
            this.CharacterInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterInfoGroupBox.Location = new System.Drawing.Point(24, 34);
            this.CharacterInfoGroupBox.Name = "CharacterInfoGroupBox";
            this.CharacterInfoGroupBox.Size = new System.Drawing.Size(339, 138);
            this.CharacterInfoGroupBox.TabIndex = 2;
            this.CharacterInfoGroupBox.TabStop = false;
            this.CharacterInfoGroupBox.Text = "Character\'s Information";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(234, 47);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(90, 22);
            this.HeightTextBox.TabIndex = 1;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(234, 85);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(90, 22);
            this.WeightTextBox.TabIndex = 1;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(70, 85);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(84, 22);
            this.AgeTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(70, 47);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(84, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(175, 88);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(56, 16);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "Weight :";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(22, 88);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(42, 16);
            this.AgeLabel.TabIndex = 0;
            this.AgeLabel.Text = "Age : ";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(175, 50);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(53, 16);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Height :";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(11, 50);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name :";
            // 
            // AbilitiesGroupBox
            // 
            this.AbilitiesGroupBox.Controls.Add(this.CHATextBox);
            this.AbilitiesGroupBox.Controls.Add(this.PERTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.INTTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.ENDTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.DEXTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.STRTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.CHALabel);
            this.AbilitiesGroupBox.Controls.Add(this.PERLabel);
            this.AbilitiesGroupBox.Controls.Add(this.INTLabel);
            this.AbilitiesGroupBox.Controls.Add(this.ENDLabel);
            this.AbilitiesGroupBox.Controls.Add(this.DEXLabel);
            this.AbilitiesGroupBox.Controls.Add(this.STRLabel);
            this.AbilitiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbilitiesGroupBox.Location = new System.Drawing.Point(38, 178);
            this.AbilitiesGroupBox.Name = "AbilitiesGroupBox";
            this.AbilitiesGroupBox.Size = new System.Drawing.Size(235, 262);
            this.AbilitiesGroupBox.TabIndex = 3;
            this.AbilitiesGroupBox.TabStop = false;
            this.AbilitiesGroupBox.Text = "Abilities";
            // 
            // CHATextBox
            // 
            this.CHATextBox.Location = new System.Drawing.Point(116, 205);
            this.CHATextBox.Name = "CHATextBox";
            this.CHATextBox.ReadOnly = true;
            this.CHATextBox.Size = new System.Drawing.Size(100, 22);
            this.CHATextBox.TabIndex = 1;
            // 
            // PERTextBox
            // 
            this.PERTextBox.Location = new System.Drawing.Point(116, 173);
            this.PERTextBox.Name = "PERTextBox";
            this.PERTextBox.ReadOnly = true;
            this.PERTextBox.Size = new System.Drawing.Size(100, 22);
            this.PERTextBox.TabIndex = 1;
            // 
            // INTTextBox
            // 
            this.INTTextBox.Location = new System.Drawing.Point(116, 139);
            this.INTTextBox.Name = "INTTextBox";
            this.INTTextBox.ReadOnly = true;
            this.INTTextBox.Size = new System.Drawing.Size(100, 22);
            this.INTTextBox.TabIndex = 1;
            // 
            // ENDTextBox
            // 
            this.ENDTextBox.Location = new System.Drawing.Point(116, 105);
            this.ENDTextBox.Name = "ENDTextBox";
            this.ENDTextBox.ReadOnly = true;
            this.ENDTextBox.Size = new System.Drawing.Size(100, 22);
            this.ENDTextBox.TabIndex = 1;
            // 
            // DEXTextBox
            // 
            this.DEXTextBox.Location = new System.Drawing.Point(117, 77);
            this.DEXTextBox.Name = "DEXTextBox";
            this.DEXTextBox.ReadOnly = true;
            this.DEXTextBox.Size = new System.Drawing.Size(100, 22);
            this.DEXTextBox.TabIndex = 1;
            // 
            // STRTextBox
            // 
            this.STRTextBox.Location = new System.Drawing.Point(117, 46);
            this.STRTextBox.Name = "STRTextBox";
            this.STRTextBox.ReadOnly = true;
            this.STRTextBox.Size = new System.Drawing.Size(100, 22);
            this.STRTextBox.TabIndex = 1;
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Location = new System.Drawing.Point(27, 211);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(39, 16);
            this.CHALabel.TabIndex = 0;
            this.CHALabel.Text = "CHA";
            // 
            // PERLabel
            // 
            this.PERLabel.AutoSize = true;
            this.PERLabel.Location = new System.Drawing.Point(27, 179);
            this.PERLabel.Name = "PERLabel";
            this.PERLabel.Size = new System.Drawing.Size(39, 16);
            this.PERLabel.TabIndex = 0;
            this.PERLabel.Text = "PER";
            // 
            // INTLabel
            // 
            this.INTLabel.AutoSize = true;
            this.INTLabel.Location = new System.Drawing.Point(27, 145);
            this.INTLabel.Name = "INTLabel";
            this.INTLabel.Size = new System.Drawing.Size(33, 16);
            this.INTLabel.TabIndex = 0;
            this.INTLabel.Text = "INT";
            // 
            // ENDLabel
            // 
            this.ENDLabel.AutoSize = true;
            this.ENDLabel.Location = new System.Drawing.Point(27, 113);
            this.ENDLabel.Name = "ENDLabel";
            this.ENDLabel.Size = new System.Drawing.Size(40, 16);
            this.ENDLabel.TabIndex = 0;
            this.ENDLabel.Text = "END";
            // 
            // DEXLabel
            // 
            this.DEXLabel.AutoSize = true;
            this.DEXLabel.Location = new System.Drawing.Point(27, 83);
            this.DEXLabel.Name = "DEXLabel";
            this.DEXLabel.Size = new System.Drawing.Size(38, 16);
            this.DEXLabel.TabIndex = 0;
            this.DEXLabel.Text = "DEX";
            // 
            // STRLabel
            // 
            this.STRLabel.AutoSize = true;
            this.STRLabel.Location = new System.Drawing.Point(27, 52);
            this.STRLabel.Name = "STRLabel";
            this.STRLabel.Size = new System.Drawing.Size(39, 16);
            this.STRLabel.TabIndex = 0;
            this.STRLabel.Text = "STR";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(571, 417);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(58, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FinalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(648, 452);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AbilitiesGroupBox);
            this.Controls.Add(this.CharacterInfoGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RacePictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Character Selections";
            this.Load += new System.EventHandler(this.FinalForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RacePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CharacterInfoGroupBox.ResumeLayout(false);
            this.CharacterInfoGroupBox.PerformLayout();
            this.AbilitiesGroupBox.ResumeLayout(false);
            this.AbilitiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox RacePictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RaceTextBox;
        private System.Windows.Forms.TextBox JobTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox CharacterInfoGroupBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox AbilitiesGroupBox;
        private System.Windows.Forms.TextBox CHATextBox;
        private System.Windows.Forms.TextBox PERTextBox;
        private System.Windows.Forms.TextBox INTTextBox;
        private System.Windows.Forms.TextBox ENDTextBox;
        private System.Windows.Forms.TextBox DEXTextBox;
        private System.Windows.Forms.TextBox STRTextBox;
        private System.Windows.Forms.Label CHALabel;
        private System.Windows.Forms.Label PERLabel;
        private System.Windows.Forms.Label INTLabel;
        private System.Windows.Forms.Label ENDLabel;
        private System.Windows.Forms.Label DEXLabel;
        private System.Windows.Forms.Label STRLabel;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.TextBox HealthPointTextBox;
    }
}