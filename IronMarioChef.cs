// Author:  Kyle Chapman
// Created: May 10, 2021
// Modified: June 16, 2021
// Description:
//  Code for a form used to select random attributes of a level for Super Mario Maker 2.
// This includes a random game style, a random course type, and a random "primary part"
// to inform the level design of a new level.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronMarioChef
{
    public partial class formIronMarioChef : Form
    {
        #region "Class-Level Variable Declarations"

        // Variables representing all randomized values.
        // Class-level variables are a bit yucky but these are used in more than one function/event handler and perhaps even moreso later.
        GameStyle currentGameStyle;
        CourseStyle currentCourseStyle;
        int dayOrNight;
        int currentPrimaryPart;
        int currentSecondaryPart;
        int currentBannedPart;
        
        Random randomValue = new Random();

        // Arrays containing the various game and course styles to reduce the amount of decision logic.
        string[] gameStyles = { "Super Mario Bros.", "Super Mario Bros. 3", "Super Mario World", "New Super Mario Bros. U", "Super Mario 3D World" };
        string[] courseStyles = { "Ground", "Underground", "Underwater", "Ghost House", "Castle", "Airship", "Forest", "Sky", "Desert", "Snow"};

        // No need for an enumeration when there are only two options for day/night, right?
        const int Day = 0;
        const int Night = 1;

        #endregion

        /// <summary>
        /// Auto-generated code to initialize the form, plus we initialize the list of parts.
        /// </summary>
        public formIronMarioChef()
        {
            InitializeComponent();
            Part.InitializeParts();

            comboBoxGameStyle.SelectedIndex = 0;
        }

        #region "Event Handlers"

        /// <summary>
        /// Selects random values for all fields on the form, and populates the form with them.
        /// </summary>
        private void RandomizeClick(object sender, EventArgs e)
        {
            // Processing.
            if (radioButtonGameStyleRandomize.Checked)
            {
                // Randomize the game style and store it as an integer.
                currentGameStyle = (GameStyle)GetRandomIndex(gameStyles);
            }
            else
            {
                currentGameStyle = (GameStyle)comboBoxGameStyle.SelectedIndex;
            }

            if (radioButtonCourseStyleRandomize.Checked)
            {
                // Randomize the course style (as an integer) and a value indicating whether it's day or night.
                currentCourseStyle = (CourseStyle)GetRandomIndex(courseStyles);
                dayOrNight = randomValue.Next(0, 2);
            }
            else
            {
                currentCourseStyle = (CourseStyle)comboBoxCourseStyle.SelectedIndex;
                dayOrNight = comboBoxDayNight.SelectedIndex;
            }

            if (radioButtonPrimaryRandomize.Checked)
            {
                // Randomize the primary part and store it as an integer.
                currentPrimaryPart = GetRandomIndex(Part.GetParts(currentGameStyle));
            }

            if (radioButtonSecondaryRandomize.Checked)
            {
                // Randomize the secondary part (as an integer) and repeat if it matches the primary part.
                do
                {
                    currentSecondaryPart = GetRandomIndex(Part.GetParts(currentGameStyle));
                }
                while (currentPrimaryPart == currentSecondaryPart);
            }

            if (radioButtonBannedRandomize.Checked)
            {
                // Randomize the banned part (as an integer) and repeat if it matches the other parts selected so far.
                do
                {
                    currentBannedPart = GetRandomIndex(Part.GetParts(currentGameStyle));
                }
                while (currentPrimaryPart == currentBannedPart || currentSecondaryPart == currentBannedPart);
            }

            // Output.
            // Output the text for the random game style.
            comboBoxGameStyle.SelectedIndex = (int)currentGameStyle;
            // Output the text for the random course style.
            comboBoxCourseStyle.SelectedIndex = (int)currentCourseStyle;
            // Add into the course style something identifying whether it's day or night.
            comboBoxDayNight.SelectedIndex = dayOrNight;
            // Assign the randomized parts to the textboxes.
            textBoxPrimaryPart.Text = Part.GetParts(currentGameStyle)[currentPrimaryPart].ToString();
            textBoxSecondaryPart.Text = Part.GetParts(currentGameStyle)[currentSecondaryPart].ToString();
            textBoxBannedPart.Text = Part.GetParts(currentGameStyle)[currentBannedPart].ToString();
        }

        /// <summary>
        /// Reset the form to its default state.
        /// </summary>
        private void ResetClick(object sender, EventArgs e)
        {
            // Clear all of the output controls.
            comboBoxGameStyle.SelectedIndex = 0;
            comboBoxCourseStyle.SelectedItem = null;
            comboBoxDayNight.SelectedItem = null;
            textBoxPrimaryPart.Clear();
            textBoxSecondaryPart.Clear();
            textBoxBannedPart.Clear();

            // Set all radiobuttons to their default checked position.
            radioButtonGameStyleRandomize.Checked = true;
            radioButtonCourseStyleRandomize.Checked = true;
            radioButtonPrimaryRandomize.Checked = true;
            radioButtonSecondaryRandomize.Checked = true;
            radioButtonBannedRandomize.Checked = true;

            // Set focus to make repeated use easier.
            buttonRandomize.Focus();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
        #region "Functions"

        /// <summary>
        /// Returns a random index from an array of strings.
        /// </summary>
        /// <returns>A random integer between 0 and the length of the array</returns>
        private int GetRandomIndex(string[] arrayToRandomize)
        {
            // Generate a random number between 0 and the length of the array.
            int randomIndex = randomValue.Next(0, arrayToRandomize.Length);

            return randomIndex;
        }

        /// <summary>
        /// Returns a random index from a List of Parts.
        /// </summary>
        /// <returns>A random integer between 0 and the length of the List</returns>
        private int GetRandomIndex(List<Part> listToRandomize)
        {
            // Generate a random number between 0 and the length of the array.
            int randomIndex = randomValue.Next(0, listToRandomize.Count);

            return randomIndex;
        }

        #endregion
    }
}
