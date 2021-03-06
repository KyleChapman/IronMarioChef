
namespace IronMarioChef
{
    partial class formIronMarioChef
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIronMarioChef));
            this.textBoxPrimaryPart = new System.Windows.Forms.TextBox();
            this.textBoxSecondaryPart = new System.Windows.Forms.TextBox();
            this.textBoxBannedPart = new System.Windows.Forms.TextBox();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxGameStyle = new System.Windows.Forms.GroupBox();
            this.radioButtonGameStyleLock = new System.Windows.Forms.RadioButton();
            this.radioButtonGameStyleRandomize = new System.Windows.Forms.RadioButton();
            this.comboBoxGameStyle = new System.Windows.Forms.ComboBox();
            this.groupBoxCourseStyle = new System.Windows.Forms.GroupBox();
            this.radioButtonCourseStyleLock = new System.Windows.Forms.RadioButton();
            this.comboBoxDayNight = new System.Windows.Forms.ComboBox();
            this.radioButtonCourseStyleRandomize = new System.Windows.Forms.RadioButton();
            this.comboBoxCourseStyle = new System.Windows.Forms.ComboBox();
            this.groupBoxPrimaryPart = new System.Windows.Forms.GroupBox();
            this.radioButtonPrimaryLock = new System.Windows.Forms.RadioButton();
            this.radioButtonPrimaryRandomize = new System.Windows.Forms.RadioButton();
            this.groupBoxSecondaryPart = new System.Windows.Forms.GroupBox();
            this.radioButtonSecondaryLock = new System.Windows.Forms.RadioButton();
            this.radioButtonSecondaryRandomize = new System.Windows.Forms.RadioButton();
            this.groupBoxBannedPart = new System.Windows.Forms.GroupBox();
            this.radioButtonBannedLock = new System.Windows.Forms.RadioButton();
            this.radioButtonBannedRandomize = new System.Windows.Forms.RadioButton();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.groupBoxGameStyle.SuspendLayout();
            this.groupBoxCourseStyle.SuspendLayout();
            this.groupBoxPrimaryPart.SuspendLayout();
            this.groupBoxSecondaryPart.SuspendLayout();
            this.groupBoxBannedPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPrimaryPart
            // 
            this.textBoxPrimaryPart.Location = new System.Drawing.Point(308, 17);
            this.textBoxPrimaryPart.Name = "textBoxPrimaryPart";
            this.textBoxPrimaryPart.ReadOnly = true;
            this.textBoxPrimaryPart.Size = new System.Drawing.Size(244, 27);
            this.textBoxPrimaryPart.TabIndex = 12;
            this.toolTip.SetToolTip(this.textBoxPrimaryPart, "Displays the selected primary theme part");
            // 
            // textBoxSecondaryPart
            // 
            this.textBoxSecondaryPart.Location = new System.Drawing.Point(308, 17);
            this.textBoxSecondaryPart.Name = "textBoxSecondaryPart";
            this.textBoxSecondaryPart.ReadOnly = true;
            this.textBoxSecondaryPart.Size = new System.Drawing.Size(244, 27);
            this.textBoxSecondaryPart.TabIndex = 16;
            this.toolTip.SetToolTip(this.textBoxSecondaryPart, "Displays the selected secondary theme part");
            // 
            // textBoxBannedPart
            // 
            this.textBoxBannedPart.Location = new System.Drawing.Point(308, 17);
            this.textBoxBannedPart.Name = "textBoxBannedPart";
            this.textBoxBannedPart.ReadOnly = true;
            this.textBoxBannedPart.Size = new System.Drawing.Size(244, 27);
            this.textBoxBannedPart.TabIndex = 20;
            this.toolTip.SetToolTip(this.textBoxBannedPart, "Displays the selected banned part");
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(12, 307);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(120, 30);
            this.buttonRandomize.TabIndex = 21;
            this.buttonRandomize.Text = "Randomi&ze!";
            this.toolTip.SetToolTip(this.buttonRandomize, "Click to randomize the selections above");
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.RandomizeClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(158, 307);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(120, 30);
            this.buttonReset.TabIndex = 22;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset the form to its default state");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(450, 307);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 30);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // groupBoxGameStyle
            // 
            this.groupBoxGameStyle.Controls.Add(this.radioButtonGameStyleLock);
            this.groupBoxGameStyle.Controls.Add(this.radioButtonGameStyleRandomize);
            this.groupBoxGameStyle.Controls.Add(this.comboBoxGameStyle);
            this.groupBoxGameStyle.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGameStyle.Name = "groupBoxGameStyle";
            this.groupBoxGameStyle.Size = new System.Drawing.Size(558, 50);
            this.groupBoxGameStyle.TabIndex = 0;
            this.groupBoxGameStyle.TabStop = false;
            this.groupBoxGameStyle.Text = "&Game Style:";
            // 
            // radioButtonGameStyleLock
            // 
            this.radioButtonGameStyleLock.AutoSize = true;
            this.radioButtonGameStyleLock.Location = new System.Drawing.Point(163, 18);
            this.radioButtonGameStyleLock.Name = "radioButtonGameStyleLock";
            this.radioButtonGameStyleLock.Size = new System.Drawing.Size(109, 24);
            this.radioButtonGameStyleLock.TabIndex = 2;
            this.radioButtonGameStyleLock.Text = "Lock/Ignore";
            this.toolTip.SetToolTip(this.radioButtonGameStyleLock, "Select to avoid randomizing the game style");
            this.radioButtonGameStyleLock.UseVisualStyleBackColor = true;
            // 
            // radioButtonGameStyleRandomize
            // 
            this.radioButtonGameStyleRandomize.AutoSize = true;
            this.radioButtonGameStyleRandomize.Checked = true;
            this.radioButtonGameStyleRandomize.Location = new System.Drawing.Point(19, 18);
            this.radioButtonGameStyleRandomize.Name = "radioButtonGameStyleRandomize";
            this.radioButtonGameStyleRandomize.Size = new System.Drawing.Size(105, 24);
            this.radioButtonGameStyleRandomize.TabIndex = 1;
            this.radioButtonGameStyleRandomize.TabStop = true;
            this.radioButtonGameStyleRandomize.Text = "Randomize";
            this.toolTip.SetToolTip(this.radioButtonGameStyleRandomize, "Select to randomize the game style");
            this.radioButtonGameStyleRandomize.UseVisualStyleBackColor = true;
            // 
            // comboBoxGameStyle
            // 
            this.comboBoxGameStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGameStyle.FormattingEnabled = true;
            this.comboBoxGameStyle.Items.AddRange(new object[] {
            "Super Mario Bros.",
            "Super Mario Bros. 3",
            "Super Mario World",
            "New Super Mario Bros. U",
            "Super Mario 3D World"});
            this.comboBoxGameStyle.Location = new System.Drawing.Point(307, 16);
            this.comboBoxGameStyle.MaxDropDownItems = 10;
            this.comboBoxGameStyle.Name = "comboBoxGameStyle";
            this.comboBoxGameStyle.Size = new System.Drawing.Size(244, 28);
            this.comboBoxGameStyle.TabIndex = 3;
            this.toolTip.SetToolTip(this.comboBoxGameStyle, "Displays and allows selection of a game style");
            // 
            // groupBoxCourseStyle
            // 
            this.groupBoxCourseStyle.Controls.Add(this.radioButtonCourseStyleLock);
            this.groupBoxCourseStyle.Controls.Add(this.comboBoxDayNight);
            this.groupBoxCourseStyle.Controls.Add(this.radioButtonCourseStyleRandomize);
            this.groupBoxCourseStyle.Controls.Add(this.comboBoxCourseStyle);
            this.groupBoxCourseStyle.Location = new System.Drawing.Point(12, 68);
            this.groupBoxCourseStyle.Name = "groupBoxCourseStyle";
            this.groupBoxCourseStyle.Size = new System.Drawing.Size(558, 50);
            this.groupBoxCourseStyle.TabIndex = 4;
            this.groupBoxCourseStyle.TabStop = false;
            this.groupBoxCourseStyle.Text = "&Course Style:";
            // 
            // radioButtonCourseStyleLock
            // 
            this.radioButtonCourseStyleLock.AutoSize = true;
            this.radioButtonCourseStyleLock.Location = new System.Drawing.Point(163, 18);
            this.radioButtonCourseStyleLock.Name = "radioButtonCourseStyleLock";
            this.radioButtonCourseStyleLock.Size = new System.Drawing.Size(109, 24);
            this.radioButtonCourseStyleLock.TabIndex = 6;
            this.radioButtonCourseStyleLock.Text = "Lock/Ignore";
            this.toolTip.SetToolTip(this.radioButtonCourseStyleLock, "Select to avoid randomizing the course style");
            this.radioButtonCourseStyleLock.UseVisualStyleBackColor = true;
            // 
            // comboBoxDayNight
            // 
            this.comboBoxDayNight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDayNight.FormattingEnabled = true;
            this.comboBoxDayNight.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.comboBoxDayNight.Location = new System.Drawing.Point(440, 16);
            this.comboBoxDayNight.MaxDropDownItems = 10;
            this.comboBoxDayNight.Name = "comboBoxDayNight";
            this.comboBoxDayNight.Size = new System.Drawing.Size(112, 28);
            this.comboBoxDayNight.TabIndex = 8;
            this.toolTip.SetToolTip(this.comboBoxDayNight, "Displays and allows selection between day and night courses");
            // 
            // radioButtonCourseStyleRandomize
            // 
            this.radioButtonCourseStyleRandomize.AutoSize = true;
            this.radioButtonCourseStyleRandomize.Checked = true;
            this.radioButtonCourseStyleRandomize.Location = new System.Drawing.Point(19, 18);
            this.radioButtonCourseStyleRandomize.Name = "radioButtonCourseStyleRandomize";
            this.radioButtonCourseStyleRandomize.Size = new System.Drawing.Size(105, 24);
            this.radioButtonCourseStyleRandomize.TabIndex = 5;
            this.radioButtonCourseStyleRandomize.TabStop = true;
            this.radioButtonCourseStyleRandomize.Text = "Randomize";
            this.toolTip.SetToolTip(this.radioButtonCourseStyleRandomize, "Select to randomize the course style");
            this.radioButtonCourseStyleRandomize.UseVisualStyleBackColor = true;
            // 
            // comboBoxCourseStyle
            // 
            this.comboBoxCourseStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourseStyle.FormattingEnabled = true;
            this.comboBoxCourseStyle.Items.AddRange(new object[] {
            "Ground",
            "Underground",
            "Underwater",
            "Ghost House",
            "Castle",
            "Airship",
            "Forest",
            "Sky",
            "Desert",
            "Snow"});
            this.comboBoxCourseStyle.Location = new System.Drawing.Point(308, 16);
            this.comboBoxCourseStyle.MaxDropDownItems = 10;
            this.comboBoxCourseStyle.Name = "comboBoxCourseStyle";
            this.comboBoxCourseStyle.Size = new System.Drawing.Size(126, 28);
            this.comboBoxCourseStyle.TabIndex = 7;
            this.toolTip.SetToolTip(this.comboBoxCourseStyle, "Displays and allows selection of a course style");
            // 
            // groupBoxPrimaryPart
            // 
            this.groupBoxPrimaryPart.Controls.Add(this.radioButtonPrimaryLock);
            this.groupBoxPrimaryPart.Controls.Add(this.textBoxPrimaryPart);
            this.groupBoxPrimaryPart.Controls.Add(this.radioButtonPrimaryRandomize);
            this.groupBoxPrimaryPart.Location = new System.Drawing.Point(12, 124);
            this.groupBoxPrimaryPart.Name = "groupBoxPrimaryPart";
            this.groupBoxPrimaryPart.Size = new System.Drawing.Size(558, 50);
            this.groupBoxPrimaryPart.TabIndex = 9;
            this.groupBoxPrimaryPart.TabStop = false;
            this.groupBoxPrimaryPart.Text = "&Primary Theme Part:";
            // 
            // radioButtonPrimaryLock
            // 
            this.radioButtonPrimaryLock.AutoSize = true;
            this.radioButtonPrimaryLock.Location = new System.Drawing.Point(163, 18);
            this.radioButtonPrimaryLock.Name = "radioButtonPrimaryLock";
            this.radioButtonPrimaryLock.Size = new System.Drawing.Size(109, 24);
            this.radioButtonPrimaryLock.TabIndex = 11;
            this.radioButtonPrimaryLock.Text = "Lock/Ignore";
            this.toolTip.SetToolTip(this.radioButtonPrimaryLock, "Select to avoid randomizing the primary part");
            this.radioButtonPrimaryLock.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrimaryRandomize
            // 
            this.radioButtonPrimaryRandomize.AutoSize = true;
            this.radioButtonPrimaryRandomize.Checked = true;
            this.radioButtonPrimaryRandomize.Location = new System.Drawing.Point(19, 18);
            this.radioButtonPrimaryRandomize.Name = "radioButtonPrimaryRandomize";
            this.radioButtonPrimaryRandomize.Size = new System.Drawing.Size(105, 24);
            this.radioButtonPrimaryRandomize.TabIndex = 10;
            this.radioButtonPrimaryRandomize.TabStop = true;
            this.radioButtonPrimaryRandomize.Text = "Randomize";
            this.toolTip.SetToolTip(this.radioButtonPrimaryRandomize, "Select to randomize the primary part");
            this.radioButtonPrimaryRandomize.UseVisualStyleBackColor = true;
            // 
            // groupBoxSecondaryPart
            // 
            this.groupBoxSecondaryPart.Controls.Add(this.radioButtonSecondaryLock);
            this.groupBoxSecondaryPart.Controls.Add(this.textBoxSecondaryPart);
            this.groupBoxSecondaryPart.Controls.Add(this.radioButtonSecondaryRandomize);
            this.groupBoxSecondaryPart.Location = new System.Drawing.Point(12, 180);
            this.groupBoxSecondaryPart.Name = "groupBoxSecondaryPart";
            this.groupBoxSecondaryPart.Size = new System.Drawing.Size(558, 50);
            this.groupBoxSecondaryPart.TabIndex = 13;
            this.groupBoxSecondaryPart.TabStop = false;
            this.groupBoxSecondaryPart.Text = "&Secondary Theme Part:";
            // 
            // radioButtonSecondaryLock
            // 
            this.radioButtonSecondaryLock.AutoSize = true;
            this.radioButtonSecondaryLock.Location = new System.Drawing.Point(163, 18);
            this.radioButtonSecondaryLock.Name = "radioButtonSecondaryLock";
            this.radioButtonSecondaryLock.Size = new System.Drawing.Size(109, 24);
            this.radioButtonSecondaryLock.TabIndex = 15;
            this.radioButtonSecondaryLock.Text = "Lock/Ignore";
            this.toolTip.SetToolTip(this.radioButtonSecondaryLock, "Select to avoid randomizing the secondary part");
            this.radioButtonSecondaryLock.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecondaryRandomize
            // 
            this.radioButtonSecondaryRandomize.AutoSize = true;
            this.radioButtonSecondaryRandomize.Checked = true;
            this.radioButtonSecondaryRandomize.Location = new System.Drawing.Point(19, 18);
            this.radioButtonSecondaryRandomize.Name = "radioButtonSecondaryRandomize";
            this.radioButtonSecondaryRandomize.Size = new System.Drawing.Size(105, 24);
            this.radioButtonSecondaryRandomize.TabIndex = 14;
            this.radioButtonSecondaryRandomize.TabStop = true;
            this.radioButtonSecondaryRandomize.Text = "Randomize";
            this.toolTip.SetToolTip(this.radioButtonSecondaryRandomize, "Select to randomize the secondary part");
            this.radioButtonSecondaryRandomize.UseVisualStyleBackColor = true;
            // 
            // groupBoxBannedPart
            // 
            this.groupBoxBannedPart.Controls.Add(this.radioButtonBannedLock);
            this.groupBoxBannedPart.Controls.Add(this.textBoxBannedPart);
            this.groupBoxBannedPart.Controls.Add(this.radioButtonBannedRandomize);
            this.groupBoxBannedPart.Location = new System.Drawing.Point(12, 236);
            this.groupBoxBannedPart.Name = "groupBoxBannedPart";
            this.groupBoxBannedPart.Size = new System.Drawing.Size(558, 50);
            this.groupBoxBannedPart.TabIndex = 17;
            this.groupBoxBannedPart.TabStop = false;
            this.groupBoxBannedPart.Tag = "";
            this.groupBoxBannedPart.Text = "&Banned Part:";
            // 
            // radioButtonBannedLock
            // 
            this.radioButtonBannedLock.AutoSize = true;
            this.radioButtonBannedLock.Location = new System.Drawing.Point(163, 18);
            this.radioButtonBannedLock.Name = "radioButtonBannedLock";
            this.radioButtonBannedLock.Size = new System.Drawing.Size(109, 24);
            this.radioButtonBannedLock.TabIndex = 19;
            this.radioButtonBannedLock.Text = "Lock/Ignore";
            this.toolTip.SetToolTip(this.radioButtonBannedLock, "Select to avoid randomizing the banned part");
            this.radioButtonBannedLock.UseVisualStyleBackColor = true;
            // 
            // radioButtonBannedRandomize
            // 
            this.radioButtonBannedRandomize.AutoSize = true;
            this.radioButtonBannedRandomize.Checked = true;
            this.radioButtonBannedRandomize.Location = new System.Drawing.Point(19, 18);
            this.radioButtonBannedRandomize.Name = "radioButtonBannedRandomize";
            this.radioButtonBannedRandomize.Size = new System.Drawing.Size(105, 24);
            this.radioButtonBannedRandomize.TabIndex = 18;
            this.radioButtonBannedRandomize.TabStop = true;
            this.radioButtonBannedRandomize.Text = "Randomize";
            this.toolTip.SetToolTip(this.radioButtonBannedRandomize, "Select to randomize the banned part");
            this.radioButtonBannedRandomize.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(304, 307);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(120, 30);
            this.buttonAbout.TabIndex = 23;
            this.buttonAbout.Text = "&About";
            this.toolTip.SetToolTip(this.buttonAbout, "Click to learn about this application");
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.AboutClick);
            // 
            // formIronMarioChef
            // 
            this.AcceptButton = this.buttonRandomize;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.groupBoxBannedPart);
            this.Controls.Add(this.groupBoxSecondaryPart);
            this.Controls.Add(this.groupBoxPrimaryPart);
            this.Controls.Add(this.groupBoxCourseStyle);
            this.Controls.Add(this.groupBoxGameStyle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRandomize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formIronMarioChef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iron Mario Chef";
            this.groupBoxGameStyle.ResumeLayout(false);
            this.groupBoxGameStyle.PerformLayout();
            this.groupBoxCourseStyle.ResumeLayout(false);
            this.groupBoxCourseStyle.PerformLayout();
            this.groupBoxPrimaryPart.ResumeLayout(false);
            this.groupBoxPrimaryPart.PerformLayout();
            this.groupBoxSecondaryPart.ResumeLayout(false);
            this.groupBoxSecondaryPart.PerformLayout();
            this.groupBoxBannedPart.ResumeLayout(false);
            this.groupBoxBannedPart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPrimaryPart;
        private System.Windows.Forms.TextBox textBoxSecondaryPart;
        private System.Windows.Forms.TextBox textBoxBannedPart;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBoxGameStyle;
        private System.Windows.Forms.ComboBox comboBoxGameStyle;
        private System.Windows.Forms.GroupBox groupBoxCourseStyle;
        private System.Windows.Forms.ComboBox comboBoxCourseStyle;
        private System.Windows.Forms.GroupBox groupBoxPrimaryPart;
        private System.Windows.Forms.GroupBox groupBoxSecondaryPart;
        private System.Windows.Forms.GroupBox groupBoxBannedPart;
        private System.Windows.Forms.RadioButton radioButtonGameStyleLock;
        private System.Windows.Forms.RadioButton radioButtonGameStyleRandomize;
        private System.Windows.Forms.RadioButton radioButtonCourseStyleLock;
        private System.Windows.Forms.ComboBox comboBoxDayNight;
        private System.Windows.Forms.RadioButton radioButtonCourseStyleRandomize;
        private System.Windows.Forms.RadioButton radioButtonPrimaryLock;
        private System.Windows.Forms.RadioButton radioButtonPrimaryRandomize;
        private System.Windows.Forms.RadioButton radioButtonSecondaryLock;
        private System.Windows.Forms.RadioButton radioButtonSecondaryRandomize;
        private System.Windows.Forms.RadioButton radioButtonBannedLock;
        private System.Windows.Forms.RadioButton radioButtonBannedRandomize;
        private System.Windows.Forms.Button buttonAbout;
    }
}

