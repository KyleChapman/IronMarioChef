// Author:  Kyle Chapman
// Created: May 10, 2021
// Modified: May 28, 2021
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

        // This array is still huge and unwieldy... but it's a lot better than the alternative!
        string[] parts = { "? Block", "Brick Block", "Bridge", "Cloud Block", "Conveyor Belt", "Donut Block", "Gentle Slope", "Ground", "Hard Block", "Hidden Block", "Ice Block", "Mushroom Platform", "Music Block", "Note Block", "Pipe", "Semisolid Platform", "Steep Slope", "Spike Trap", "Style-Specific Power-up 1", "Style-Specific Power-up 2", "1-Up Mushroom", "Coin", "Fire Flower", "Frozen Coin", "Master Sword", "Multi-Coin", "Pink Coin", "Shoe Goomba / Yoshi Egg", "Stiletto Goomba / Red Yoshi Egg", "Super Mushroom", "Super Star", "Superball Flower", "Angry Sun", "Blooper", "Blooper Nanny", "Bob-omb", "Boo", "Boo Buddies", "Boom Boom", "Bowser", "Bowser Jr.", "Buzzy Beetle", "Buzzy Beetle Shell", "Chain Chomp", "Cheep Cheep", "Deep Cheep", "Dry Bones", "Dry Bones Shell", "Fire Koopa Clown Car", "Fire Piranha Plant", "Fish Bone", "Goomba", "Goombrat", "Hammer Bro", "Koopa Clown Car", "Koopa Troopa", "Lakitu", "Lakitu's Cloud", "Lava Bubble", "Magikoopa", "Monty Mole", "Moon", "Muncher", "Piranha Plant", "Pokey", "Rocky Wrench", "Sledge Bro", "Spike", "Spike Ball", "Spike Top", "Spiny", "Spiny Egg", "Spiny Shell", "Stretch", "Thwomp", "Unchained Chomp", "Wiggler", "Larry", "Iggy", "Wendy", "Lemmy", "Roy", "Morton", "Ludwig", "Mechakoopa", "Red Mechakoopa", "Blue Mechakoopa", "Arrow Sign", "Banzai Bill", "Bull's-Eye Banzai", "Bill Blaster", "Bull's-Eye Blaster", "Bumper", "Burner", "Cannon", "Checkpoint Flag", "Cursed Key", "Dotted-Line Block", "Fast Snake Block", "Fire Bar", "Flimsy Lift", "Grinder", "Icicle", "Key", "Key Door", "Lava Lift (Skull Raft)", "Lift", "ON/OFF Switch", "One-Way Wall", "P Block", "P Warp Door", "P Switch", "POW Block", "Seesaw", "Skewer", "Snake Block", "Swinging Claw", "Track", "Trampoline", "Twister", "Vine", "Warp Door" };
        // Arrays containing the various game and course styles to reduce the amount of decision logic.
        string[] gameStyles = { "Super Mario Bros.", "Super Mario Bros. 3", "Super Mario World", "New Super Mario Bros. U" };
        string[] courseStyles = { "Ground", "Underground", "Underwater", "Ghost House", "Castle", "Airship", "Forest", "Sky", "Desert", "Snow"};

        // No need for an enumeration when there are only two options for day/night, right?
        const int Day = 0;
        const int Night = 1;

        #endregion
        #region "Enumerations"

        /// <summary>
        /// SpecificPart has values for parts that are handled differently in different course styles or game styles. This is used to name these values for comparison later.
        /// </summary>
        enum SpecificPart
        {
            BrickBlock = 1,
            SpikeTrap = 17,
            StyleSpecificPowerUp1 = 18,
            StyleSpecificPowerUp2 = 19,
            OneUpMushroom = 20,
            MasterSword = 24,
            ShoeGoomba = 27,
            StilettoGoomba = 28,
            SuperBallFlower = 31,
            DeepCheep = 45,
            Goomba = 51,
            Goombrat = 52,
            SpikeBall = 68,
            CursedKey = 96
        }

        /// <summary>
        /// A value from 0-4 representing the various game styles for neatly-named comparisons later.
        /// </summary>
        enum GameStyle
        {
            SuperMarioBros,
            SuperMarioBros3,
            SuperMarioWorld,
            NewSuperMarioBrosU,
            SuperMario3DWorld
        }

        /// <summary>
        /// A value from 0-9 representing the various course styles for neatly-named comparisons later.
        /// </summary>
        enum CourseStyle
        {
            Ground,
            Underground,
            Underwater,
            GhostHouse,
            Castle,
            Airship,
            Forest,
            Sky,
            Desert,
            Snow
        }
        
        #endregion

        /// <summary>
        /// Auto-generated code. Initialize the form!
        /// </summary>
        public formIronMarioChef()
        {
            InitializeComponent();
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
            currentPrimaryPart = GetRandomIndex(parts);
            
            // Randomize the secondary part (as an integer) and repeat if it matches the primary part.
            do
            {
                currentSecondaryPart = GetRandomIndex(parts);
            }
            while (currentPrimaryPart == currentSecondaryPart);

            // Randomize the banned part (as an integer) and repeat if it matches the other parts selected so far.
            do
            {
                currentBannedPart = GetRandomIndex(parts);
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

            // Call a function to sanitize and output the random parts.
            OutputPart(currentPrimaryPart, textBoxPrimaryPart);
            OutputPart(currentSecondaryPart, textBoxSecondaryPart);
            OutputPart(currentBannedPart, textBoxBannedPart);
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
        /// Outputs the part with the selected index to the specified TextBox. This is used to ensure the part matches the specific course and game styles.
        /// </summary>
        /// <param name="partIndex">Integer index of a part to output.</param>
        /// <param name="outputTextBox">The TextBox on the form that you would like to populate.</param>
        private void OutputPart(int partIndex, TextBox outputTextBox)
        {
            // If the part is a Brick Block, it is a Rotating Block for SMW.
            if (partIndex == (int)SpecificPart.BrickBlock)
            {
                if (currentGameStyle == (int)GameStyle.SuperMarioWorld)
                {
                    outputTextBox.Text = "Rotating Block";
                }
            }
            // If the part is a Spike Trap, it is treated differently underwater for some styles.
            else if (partIndex == (int)SpecificPart.SpikeTrap)
            {
                if (currentGameStyle == (int)GameStyle.SuperMarioBros3 &&
                    currentCourseStyle == (int)CourseStyle.Underwater)
                {
                    outputTextBox.Text = "Jelectro";
                }
                else if (currentGameStyle == (int)GameStyle.SuperMarioWorld &&
                    currentCourseStyle == (int)CourseStyle.Underwater)
                {
                    outputTextBox.Text = "Sea Urchin";
                }
            }
            // Style-specific power ups are technically different power-ups in each different style.
            else if (partIndex == (int)SpecificPart.StyleSpecificPowerUp1)
            {
                if (currentGameStyle == (int)GameStyle.SuperMarioBros)
                {
                    outputTextBox.Text = "Big Mushroom";
                }
                else if (currentGameStyle == (int)GameStyle.SuperMarioBros3)
                {
                    outputTextBox.Text = "Super Leaf";
                }
                else if (currentGameStyle == (int)GameStyle.SuperMarioWorld)
                {
                    outputTextBox.Text = "Cape Feather";
                }
                else if (currentGameStyle == (int)GameStyle.NewSuperMarioBrosU)
                {
                    outputTextBox.Text = "Propeller Mushroom";
                }
            }
            // Style-specific power ups are technically different power-ups in each different style.
            else if (partIndex == (int)SpecificPart.StyleSpecificPowerUp2)
            {
                if (currentGameStyle == (int)GameStyle.SuperMarioBros)
                {
                    outputTextBox.Text = "SMB2 Mushroom";
                }
                else if (currentGameStyle == (int)GameStyle.SuperMarioBros3)
                {
                    outputTextBox.Text = "Frog Suit";
                }
                else if (currentGameStyle == (int)GameStyle.SuperMarioWorld)
                {
                    outputTextBox.Text = "P-Balloon";
                }
                else if (currentGameStyle == (int)GameStyle.NewSuperMarioBrosU)
                {
                    outputTextBox.Text = "Acorn Mushroom";
                }
            }
            // 1-up Mushrooms become Rotten Mushrooms in the ground theme at night.
            else if (partIndex == (int)SpecificPart.OneUpMushroom)
            {
                if (dayOrNight == Night && currentCourseStyle == (int)CourseStyle.Ground)
                {
                    outputTextBox.Text = "Rotten Mushroom";
                }
            }
            // MasterSword, Superball Flowers and Cursed Keys only exist in the SMB1 style.
            else if (partIndex == (int)SpecificPart.MasterSword ||
                partIndex == (int)SpecificPart.SuperBallFlower ||
                partIndex == (int)SpecificPart.CursedKey)
            {
                currentGameStyle = (int)GameStyle.SuperMarioBros;
                textBoxGameStyle.Text = gameStyles[currentGameStyle];
            }
            // Shoe Goombas are used in some styles, and Yoshi eggs are used in others.
            else if (partIndex == (int)SpecificPart.ShoeGoomba)
            {
                if (currentGameStyle == (int)GameStyle.SuperMarioWorld ||
                    currentGameStyle == (int)GameStyle.NewSuperMarioBrosU)
                {
                    outputTextBox.Text = "Yoshi Egg";
                }
            }
            // Stiletto Goombas are used in some styles, and big Yoshi eggs are used in others.
            else if (partIndex == (int)SpecificPart.StilettoGoomba)
            {
                if (currentGameStyle == (int)GameStyle.SuperMarioWorld ||
                    currentGameStyle == (int)GameStyle.NewSuperMarioBrosU)
                {
                    outputTextBox.Text = "Big Yoshi Egg";
                }
            }
            // Deep Cheeps are called Blurps in Super Mario World. Did I do this correctly?
            else if (partIndex == (int)SpecificPart.DeepCheep)
            {
                if (currentGameStyle == (int)GameStyle.SuperMarioWorld)
                {
                    outputTextBox.Text = "Blurp";
                }
            }
            // In Super Mario World, Goombas are replaced with Galoombas.
            else if (partIndex == (int)SpecificPart.Goomba)
            {
                if (currentGameStyle == (int)GameStyle.SuperMarioWorld)
                {
                    outputTextBox.Text = "Galoomba";
                }
            }
            // In Super Mario World, Goombrats are replaced with Goombuds.
            else if (partIndex == (int)SpecificPart.Goombrat)
            {
                if (currentGameStyle == (int)GameStyle.SuperMarioWorld)
                {
                    outputTextBox.Text = "Goombud";
                }
            }
            // Spike Balls are instead Snow Balls in the Snow course style.
            else if (partIndex == (int)SpecificPart.SpikeBall)
            {
                if (currentCourseStyle == (int)CourseStyle.Snow)
                {
                    outputTextBox.Text = "Snow Ball";
                }
            }
            // If none of those conditions are met... then output it normally!
            else
            {
                outputTextBox.Text = parts[partIndex];
            }
        }

        #endregion
    }
}
