
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
            this.labelGameStyle = new System.Windows.Forms.Label();
            this.textBoxGameStyle = new System.Windows.Forms.TextBox();
            this.labelCourseStyle = new System.Windows.Forms.Label();
            this.textBoxCourseStyle = new System.Windows.Forms.TextBox();
            this.labelPrimaryPart = new System.Windows.Forms.Label();
            this.textBoxPrimaryPart = new System.Windows.Forms.TextBox();
            this.labelSecondaryPart = new System.Windows.Forms.Label();
            this.textBoxSecondaryPart = new System.Windows.Forms.TextBox();
            this.labelBannedPart = new System.Windows.Forms.Label();
            this.textBoxBannedPart = new System.Windows.Forms.TextBox();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelGameStyle
            // 
            this.labelGameStyle.Location = new System.Drawing.Point(79, 21);
            this.labelGameStyle.Name = "labelGameStyle";
            this.labelGameStyle.Size = new System.Drawing.Size(175, 25);
            this.labelGameStyle.TabIndex = 0;
            this.labelGameStyle.Text = "&Game Style:";
            this.labelGameStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxGameStyle
            // 
            this.textBoxGameStyle.Location = new System.Drawing.Point(260, 21);
            this.textBoxGameStyle.Name = "textBoxGameStyle";
            this.textBoxGameStyle.ReadOnly = true;
            this.textBoxGameStyle.Size = new System.Drawing.Size(244, 27);
            this.textBoxGameStyle.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxGameStyle, "Displays the selected game style");
            // 
            // labelCourseStyle
            // 
            this.labelCourseStyle.Location = new System.Drawing.Point(79, 79);
            this.labelCourseStyle.Name = "labelCourseStyle";
            this.labelCourseStyle.Size = new System.Drawing.Size(175, 25);
            this.labelCourseStyle.TabIndex = 2;
            this.labelCourseStyle.Text = "&Course Style:";
            this.labelCourseStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCourseStyle
            // 
            this.textBoxCourseStyle.Location = new System.Drawing.Point(260, 79);
            this.textBoxCourseStyle.Name = "textBoxCourseStyle";
            this.textBoxCourseStyle.ReadOnly = true;
            this.textBoxCourseStyle.Size = new System.Drawing.Size(244, 27);
            this.textBoxCourseStyle.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxCourseStyle, "Displays the selected course style");
            // 
            // labelPrimaryPart
            // 
            this.labelPrimaryPart.Location = new System.Drawing.Point(79, 137);
            this.labelPrimaryPart.Name = "labelPrimaryPart";
            this.labelPrimaryPart.Size = new System.Drawing.Size(175, 25);
            this.labelPrimaryPart.TabIndex = 4;
            this.labelPrimaryPart.Text = "&Primary Theme Part:";
            this.labelPrimaryPart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPrimaryPart
            // 
            this.textBoxPrimaryPart.Location = new System.Drawing.Point(260, 137);
            this.textBoxPrimaryPart.Name = "textBoxPrimaryPart";
            this.textBoxPrimaryPart.ReadOnly = true;
            this.textBoxPrimaryPart.Size = new System.Drawing.Size(244, 27);
            this.textBoxPrimaryPart.TabIndex = 5;
            this.toolTip.SetToolTip(this.textBoxPrimaryPart, "Displays the selected primary theme part");
            // 
            // labelSecondaryPart
            // 
            this.labelSecondaryPart.Location = new System.Drawing.Point(79, 195);
            this.labelSecondaryPart.Name = "labelSecondaryPart";
            this.labelSecondaryPart.Size = new System.Drawing.Size(175, 25);
            this.labelSecondaryPart.TabIndex = 6;
            this.labelSecondaryPart.Text = "&Secondary Theme Part:";
            this.labelSecondaryPart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSecondaryPart
            // 
            this.textBoxSecondaryPart.Location = new System.Drawing.Point(260, 195);
            this.textBoxSecondaryPart.Name = "textBoxSecondaryPart";
            this.textBoxSecondaryPart.ReadOnly = true;
            this.textBoxSecondaryPart.Size = new System.Drawing.Size(244, 27);
            this.textBoxSecondaryPart.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxSecondaryPart, "Displays the selected secondary theme part");
            // 
            // labelBannedPart
            // 
            this.labelBannedPart.Location = new System.Drawing.Point(79, 253);
            this.labelBannedPart.Name = "labelBannedPart";
            this.labelBannedPart.Size = new System.Drawing.Size(175, 25);
            this.labelBannedPart.TabIndex = 8;
            this.labelBannedPart.Text = "&Banned Part:";
            this.labelBannedPart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBannedPart
            // 
            this.textBoxBannedPart.Location = new System.Drawing.Point(260, 253);
            this.textBoxBannedPart.Name = "textBoxBannedPart";
            this.textBoxBannedPart.ReadOnly = true;
            this.textBoxBannedPart.Size = new System.Drawing.Size(244, 27);
            this.textBoxBannedPart.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxBannedPart, "Displays the selected banned part");
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(72, 307);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(108, 29);
            this.buttonRandomize.TabIndex = 10;
            this.buttonRandomize.Text = "Randomi&ze!";
            this.toolTip.SetToolTip(this.buttonRandomize, "Click to randomize the selections above");
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.RandomizeClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(248, 307);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset the form to its default state");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(410, 307);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // formIronMarioChef
            // 
            this.AcceptButton = this.buttonRandomize;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.textBoxBannedPart);
            this.Controls.Add(this.labelBannedPart);
            this.Controls.Add(this.textBoxSecondaryPart);
            this.Controls.Add(this.labelSecondaryPart);
            this.Controls.Add(this.textBoxPrimaryPart);
            this.Controls.Add(this.labelPrimaryPart);
            this.Controls.Add(this.textBoxCourseStyle);
            this.Controls.Add(this.labelCourseStyle);
            this.Controls.Add(this.textBoxGameStyle);
            this.Controls.Add(this.labelGameStyle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formIronMarioChef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iron Mario Chef";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameStyle;
        private System.Windows.Forms.TextBox textBoxGameStyle;
        private System.Windows.Forms.Label labelCourseStyle;
        private System.Windows.Forms.TextBox textBoxCourseStyle;
        private System.Windows.Forms.Label labelPrimaryPart;
        private System.Windows.Forms.TextBox textBoxPrimaryPart;
        private System.Windows.Forms.Label labelSecondaryPart;
        private System.Windows.Forms.TextBox textBoxSecondaryPart;
        private System.Windows.Forms.Label labelBannedPart;
        private System.Windows.Forms.TextBox textBoxBannedPart;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

