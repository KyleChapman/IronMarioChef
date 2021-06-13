// Author:  Kyle Chapman
// Created: May 10, 2021
// Modified: June 13, 2021
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
        int currentGameStyle;
        int currentCourseStyle;
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
        }

        #region "Event Handlers"

        /// <summary>
        /// Selects random values for all fields on the form, and populates the form with them.
        /// </summary>
        private void RandomizeClick(object sender, EventArgs e)
        {
            // Processing.
            // Randomize the game style and store it as an integer.
            currentGameStyle = GetRandomIndex(gameStyles);

            // Randomize the course style (as an integer) and a value indicating whether it's day or night.
            currentCourseStyle = GetRandomIndex(courseStyles);
            dayOrNight = randomValue.Next(0, 2);

            // Randomize the primary part and store it as an integer.
            currentPrimaryPart = GetRandomIndex(Part.GetParts((GameStyle)currentGameStyle));
            
            // Randomize the secondary part (as an integer) and repeat if it matches the primary part.
            do
            {
                currentSecondaryPart = GetRandomIndex(Part.GetParts((GameStyle)currentGameStyle));
            }
            while (currentPrimaryPart == currentSecondaryPart);

            // Randomize the banned part (as an integer) and repeat if it matches the other parts selected so far.
            do
            {
                currentBannedPart = GetRandomIndex(Part.GetParts((GameStyle)currentGameStyle));
            }
            while (currentPrimaryPart == currentBannedPart || currentSecondaryPart == currentBannedPart);

            // Output.
            // Output the text for the random game style.
            textBoxGameStyle.Text = gameStyles[currentGameStyle];
            
            // Output the text for the random course style, including whether it's day or night.
            if (dayOrNight == Day)
            {
                textBoxCourseStyle.Text = courseStyles[currentCourseStyle] + " (Day)";
            }
            else
            {
                textBoxCourseStyle.Text = courseStyles[currentCourseStyle] + " (Night)";
            }

            // Assign the randomized parts to the textboxes.
            textBoxPrimaryPart.Text = Part.GetParts((GameStyle)currentGameStyle)[currentPrimaryPart].ToString();
            textBoxSecondaryPart.Text = Part.GetParts((GameStyle)currentGameStyle)[currentSecondaryPart].ToString();
            textBoxBannedPart.Text = Part.GetParts((GameStyle)currentGameStyle)[currentBannedPart].ToString();
        }

        /// <summary>
        /// Reset the form to its default state.
        /// </summary>
        private void ResetClick(object sender, EventArgs e)
        {
            // Clear all of the output controls.
            textBoxGameStyle.Clear();
            textBoxCourseStyle.Clear();
            textBoxPrimaryPart.Clear();
            textBoxSecondaryPart.Clear();
            textBoxBannedPart.Clear();

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
        /// Returns a random index from an array of Parts.
        /// </summary>
        /// <returns>A random integer between 0 and the length of the array</returns>
        private int GetRandomIndex(Part[] arrayToRandomize)
        {
            // Generate a random number between 0 and the length of the array.
            int randomIndex = randomValue.Next(0, arrayToRandomize.Length);

            return randomIndex;
        }

        #endregion
    }
}
