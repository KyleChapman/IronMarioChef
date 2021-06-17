// Author:  Kyle Chapman
// Created: June 10, 2021
// Modified: June 13, 2021
// Description:
//  This class represents parts for use in Super Mario Maker 2, for use with
// a randomization engine. Methods to determine what game styles the parts are
// supported in are included.

using System;
using System.Collections.Generic;
using System.Text;

namespace IronMarioChef
{
    class Part
    {
        #region "Declarations"

        // Instance variables, unique to each part.
        private int partId;
        private string partName;
        private bool[] validStyles = new bool[] { false, false, false, false, false };

        // Static variables, shared among all parts.
        private static int totalPartCount = 0;
        
        // A list of all parts that will be added to as parts are created.
        private static List<Part> parts = new List<Part>();

        // A game-specific list of parts for each game style.
        // It's a lot of data, but it's better to populate these once
        // than do it every single time we pick a random value.
        private static List<Part> smbParts = new List<Part>();
        private static List<Part> smb3Parts = new List<Part>();
        private static List<Part> smwParts = new List<Part>();
        private static List<Part> nsmbuParts = new List<Part>();
        private static List<Part> sm3dwParts = new List<Part>();

        #endregion

        #region "Constructors"

        /// <summary>
        /// Default constructor. Makes a blank part and adds it to the list.
        /// </summary>
        public Part()
        {
            totalPartCount++;
            partId = totalPartCount;
        }

        /// <summary>
        /// Constructor that creates a part supported in all game styles.
        /// </summary>
        /// <param name="name">The name of the part.</param>
        public Part(string name) : this()
        {
            partName = name;

            // This part is supported in all game styles.
            validStyles = new bool[] { true, true, true, true, true };
        }

        /// <summary>
        /// Constructor that creates a part supported either (true) ONLY Super Mario 3D World or (false) all styles BUT Super Mario 3D World.
        /// </summary>
        /// <param name="name">The name of the part.</param>/// <param name="isSuperMario3dWorldSupported">true if this part is unique to Super Mario 3D World; false is this part is allowed in all styles other than Super Mario 3D World</param>
        public Part(string name, bool isSuperMario3dWorldSupported) : this()
        {
            partName = name;
            
            // Check if this part is supported for Super Mario 3D World.
            if (isSuperMario3dWorldSupported)
            {
                // This part is only supported in Super Mario 3D World.
                validStyles = new bool[] { false, false, false, false, true };
            }
            else
            {
                // This part is supported in all game styles other than Super Mario 3D World.
                validStyles = new bool[] { true, true, true, true, false };
            }
        }

        /// <summary>
        /// Constructor that creates a part and allows you to specify which exact game styles the part is valid for.
        /// </summary>
        /// <param name="name">The name of the part.</param>
        /// <param name="isInSuperMarioBros">Is the part valid in Super Mario Bros.?</param>
        /// <param name="isInSuperMarioBros3">Is the part valid in Super Mario Bros. 3?</param>
        /// <param name="isInSuperMarioWorld">Is the part valid in Super Mario World?</param>
        /// <param name="isInNewSuperMarioBrosU">Is the part valid in New Super Mario Bros. U?</param>
        /// <param name="isInSuperMario3dWorld">Is the part valid in Super Mario 3D World?</param>
        public Part(string name, bool isInSuperMarioBros, bool isInSuperMarioBros3, bool isInSuperMarioWorld, bool isInNewSuperMarioBrosU, bool isInSuperMario3dWorld) : this()
        {
            partName = name;

            // Check if the part is valid in Super Mario Bros.
            if (isInSuperMarioBros)
            {
                validStyles[(int)GameStyle.SuperMarioBros] = true;
            }
            // Check if the part is valid in Super Mario Bros. 3
            if (isInSuperMarioBros3)
            {
                validStyles[(int)GameStyle.SuperMarioBros3] = true;
            }
            // Check if the part is valid in Super Mario World
            if (isInSuperMarioWorld)
            {
                validStyles[(int)GameStyle.SuperMarioWorld] = true;
            }
            // Check if the part is valid in New Super Mario Bros. U
            if (isInNewSuperMarioBrosU)
            {
                validStyles[(int)GameStyle.NewSuperMarioBrosU] = true;
            }
            // Check if the part is valid in Super Mario 3D World
            if (isInSuperMario3dWorld)
            {
                validStyles[(int)GameStyle.SuperMario3DWorld] = true;
            }
        }

        #endregion

        #region "Properties"

        /// <summary>
        /// Returns a part's identification number
        /// </summary>
        public int Id
        {
            get
            {
                return partId;
            }
        }

        /// <summary>
        /// Gets or sets a part's name.
        /// </summary>
        public string Name
        {
            get
            {
                return partName;
            }
            set
            {
                partName = value;
            }
        }

        /// <summary>
        /// Gets or sets whether a part is supported in Super Mario Bros. style.
        /// </summary>
        public bool InSuperMarioBros
        {
            get
            {
                return validStyles[(int)GameStyle.SuperMarioBros];
            }
            set
            {
                validStyles[(int)GameStyle.SuperMarioBros] = value;
            }
        }

        /// <summary>
        /// Gets or sets whether a part is supported in Super Mario Bros. 3 style.
        /// </summary>
        public bool InSuperMarioBros3
        {
            get
            {
                return validStyles[(int)GameStyle.SuperMarioBros3];
            }
            set
            {
                validStyles[(int)GameStyle.SuperMarioBros3] = value;
            }
        }

        /// <summary>
        /// Gets or sets whether a part is supported in Super Mario World style.
        /// </summary>
        public bool InSuperMarioWorld
        {
            get
            {
                return validStyles[(int)GameStyle.SuperMarioWorld];
            }
            set
            {
                validStyles[(int)GameStyle.SuperMarioWorld] = value;
            }
        }

        /// <summary>
        /// Gets or sets whether a part is supported in New Super Mario Bros. U style.
        /// </summary>
        public bool InNewSuperMarioBrosU
        {
            get
            {
                return validStyles[(int)GameStyle.NewSuperMarioBrosU];
            }
            set
            {
                validStyles[(int)GameStyle.NewSuperMarioBrosU] = value;
            }
        }

        /// <summary>
        /// Gets or sets whether a part is supported in Super Mario 3D World style.
        /// </summary>
        public bool InSuperMario3dWorld
        {
            get
            {
                return validStyles[(int)GameStyle.SuperMario3DWorld];
            }
            set
            {
                validStyles[(int)GameStyle.SuperMario3DWorld] = value;
            }
        }

        #endregion

        #region "Functions"

        /// <summary>
        /// Gets a List of all parts.
        /// </summary>
        /// <returns>A List of all parts.</returns>
        public static List<Part> GetParts()
        {
            return parts;
        }

        /// <summary>
        /// Gets a List of all parts supported in a given game style.
        /// </summary>
        /// <param name="style">A GameStyle (0-4); the style you want a List of compatible parts for</param>
        /// <returns>A List of parts supported in the specified style.</returns>
        public static List<Part> GetParts(GameStyle style)
        {
            // SMB is requested; return all SMB parts.
            if (style == GameStyle.SuperMarioBros)
            {
                return smbParts;
            }
            // SMB3 is requested; return all SMB3 parts.
            else if (style == GameStyle.SuperMarioBros3)
            {
                return smb3Parts;
            }
            // SMW is requested; return all SMW parts.
            else if (style == GameStyle.SuperMarioWorld)
            {
                return smwParts;
            }
            // NSMBU is requested; return all NSMBU parts.
            else if (style == GameStyle.NewSuperMarioBrosU)
            {
                return nsmbuParts;
            }
            // Else, all that's left is SM3DW. Return that.
            else
            {
                return sm3dwParts;
            }
        }

        /// <summary>
        /// Creates the list of parts with their supported styles.
        /// </summary>
        public static void InitializeParts()
        {
            // Start the list off fresh!
            parts.Clear();

            // Initialize all parts with their supported game styles, one-by-one.

            #region "Part Initialization"

            // Terrain parts.
            parts.Add(new Part("? Block"));
            parts.Add(new Part("Brick Block", true, true, false, true, true));
            parts.Add(new Part("Rotating Block", false, false, true, false, false));
            parts.Add(new Part("Bridge", false));
            parts.Add(new Part("Cloud Block"));
            parts.Add(new Part("Conveyor Belt"));
            parts.Add(new Part("Donut Block"));
            parts.Add(new Part("Gentle Slope"));
            parts.Add(new Part("Ground"));
            parts.Add(new Part("Hard Block"));
            parts.Add(new Part("Hidden Block"));
            parts.Add(new Part("Ice Block"));
            parts.Add(new Part("Mushroom Platform", false));
            parts.Add(new Part("Music Block", false));
            parts.Add(new Part("Note Block", false));
            parts.Add(new Part("Pipe"));
            parts.Add(new Part("Semisolid Platform"));
            parts.Add(new Part("Steep Slope"));
            parts.Add(new Part("Spike Trap", true, false, false, true, false));
            parts.Add(new Part("Spike Trap / Jelectro", false, true, false, false, false));
            parts.Add(new Part("Spike Trap / Sea Urchin", false, false, true, false, false));

            // Style-specific power-ups.
            parts.Add(new Part("Big Mushroom", true, false, false, false, false));
            parts.Add(new Part("Super Leaf", false, true, false, false, false));
            parts.Add(new Part("Cape Feather", false, false, true, false, false));
            parts.Add(new Part("Propeller Mushroom", false, false, false, true, false));
            parts.Add(new Part("SMB2 Mushroom", true, false, false, false, false));
            parts.Add(new Part("Frog Suit", false, true, false, false, false));
            parts.Add(new Part("P Balloon", false, false, true, false, false));
            parts.Add(new Part("Super Acorn", false, false, false, true, false));

            // Other items/power-ups.
            parts.Add(new Part("1-up Mushroom / Rotten Mushroom"));
            parts.Add(new Part("Coin"));
            parts.Add(new Part("Fire Flower"));
            parts.Add(new Part("Frozen Coin", false));
            parts.Add(new Part("Master Sword", true, false, false, false, false));
            parts.Add(new Part("Multi-Coin"));
            parts.Add(new Part("Pink Coin"));
            parts.Add(new Part("Shoe Goomba", true, true, false, false, false));
            parts.Add(new Part("Yoshi Egg", false, false, true, true, false));
            parts.Add(new Part("Stiletto Goomba", true, true, false, false, false));
            parts.Add(new Part("Big Egg", false, false, true, true, false));
            parts.Add(new Part("Super Mushroom"));
            parts.Add(new Part("Super Star"));
            parts.Add(new Part("Superball Flower", true, false, false, false, false));

            // Enemies, and enemy-associated items.
            parts.Add(new Part("Angry Sun", false));
            parts.Add(new Part("Blooper"));
            parts.Add(new Part("Blooper Nanny", false));
            parts.Add(new Part("Bob-omb"));
            parts.Add(new Part("Boo"));
            parts.Add(new Part("Boo Buddies", false));
            parts.Add(new Part("Boom Boom"));
            parts.Add(new Part("Bowser", false));
            parts.Add(new Part("Bowser Jr.", false));
            parts.Add(new Part("Buzzy Beetle", false));
            parts.Add(new Part("Buzzy Beetle Shell", false));
            parts.Add(new Part("Chain Chomp", false));
            parts.Add(new Part("Cheep Cheep"));
            parts.Add(new Part("Deep Cheep", true, true, false, true, true));
            parts.Add(new Part("Blurp", false, false, true, false, false));
            parts.Add(new Part("Dry Bones"));
            parts.Add(new Part("Dry Bones Shell", false));
            parts.Add(new Part("Fire Koopa Clown Car", false));
            parts.Add(new Part("Fire Pirahna Plant"));
            parts.Add(new Part("Fish Bone"));
            parts.Add(new Part("Goomba", true, true, false, true, true));
            parts.Add(new Part("Galoomba", false, false, true, false, false));
            parts.Add(new Part("Goombrat", true, true, false, true, false));
            parts.Add(new Part("Goombud", false, false, true, false, false));
            parts.Add(new Part("Hammer Bro"));
            parts.Add(new Part("Koopa Clown Car", false));
            parts.Add(new Part("Koopa Troopa"));
            parts.Add(new Part("Lakitu", false));
            parts.Add(new Part("Lakitu's Cloud", false));
            parts.Add(new Part("Magikoopa"));
            parts.Add(new Part("Monty Mole", false));
            parts.Add(new Part("Moon", false));
            parts.Add(new Part("Muncher", false));
            parts.Add(new Part("Pirahna Plant"));
            parts.Add(new Part("Pokey"));
            parts.Add(new Part("Rocky Wrench", false));
            parts.Add(new Part("Sledge Bro"));
            parts.Add(new Part("Spike"));
            parts.Add(new Part("Spike Ball / Snow Ball"));
            parts.Add(new Part("Spike Top", false));
            parts.Add(new Part("Spiny"));
            parts.Add(new Part("Spiny Shell", false));
            parts.Add(new Part("Stretch"));
            parts.Add(new Part("Thwomp"));
            parts.Add(new Part("Unchained Chomp", false));
            parts.Add(new Part("Wiggler", false));
            parts.Add(new Part("Larry", false));
            parts.Add(new Part("Iggy", false));
            parts.Add(new Part("Wendy", false));
            parts.Add(new Part("Lemmy", false));
            parts.Add(new Part("Roy", false));
            parts.Add(new Part("Morton", false));
            parts.Add(new Part("Ludwig", false));
            parts.Add(new Part("Mechakoopa", false));
            parts.Add(new Part("Blasta Mechakoopa", false));
            parts.Add(new Part("Zappa Mechakoopa", false));

            // Gizmos
            parts.Add(new Part("Arrow Sign"));
            parts.Add(new Part("Banzai Bill"));
            parts.Add(new Part("Bull's-Eye Banzai"));
            parts.Add(new Part("Bill Blaster"));
            parts.Add(new Part("Bull's-Eye Blaster"));
            parts.Add(new Part("Bumper", false));
            parts.Add(new Part("Burner", false));
            parts.Add(new Part("Cannon", false));
            parts.Add(new Part("Checkpoint Flag"));
            parts.Add(new Part("Cursed Key", true, false, false, false, false));
            parts.Add(new Part("Dotted-Line Block"));
            parts.Add(new Part("Fast Snake Block", false));
            parts.Add(new Part("Fire Bar", false));
            parts.Add(new Part("Flimsy Lift", false));
            parts.Add(new Part("Grinder", false));
            parts.Add(new Part("Icicle"));
            parts.Add(new Part("Key"));
            parts.Add(new Part("Key Door"));
            parts.Add(new Part("Lava Lift (Skull Raft)", false));
            parts.Add(new Part("Lift", false));
            parts.Add(new Part("ON/OFF Switch"));
            parts.Add(new Part("One-Way Wall", false));
            parts.Add(new Part("P Block"));
            parts.Add(new Part("P Warp Door"));
            parts.Add(new Part("P Switch"));
            parts.Add(new Part("POW Block"));
            parts.Add(new Part("Seesaw", false));
            parts.Add(new Part("Skewer", false));
            parts.Add(new Part("Snake Block", false));
            parts.Add(new Part("Swinging Claw", false));
            parts.Add(new Part("Track", false));
            parts.Add(new Part("Twister"));
            parts.Add(new Part("Vine", false));
            parts.Add(new Part("Warp Door"));

            // Super Mario 3D World-specific parts.
            parts.Add(new Part("Clear Pipe", true));
            parts.Add(new Part("Super Bell", true));
            parts.Add(new Part("Super Hammer", true));
            parts.Add(new Part("Boomerang Flower", true));
            parts.Add(new Part("Cannon Box", true));
            parts.Add(new Part("POW Box", true));
            parts.Add(new Part("Propeller Box", true));
            parts.Add(new Part("Goomba Mask", true));
            parts.Add(new Part("Bullet Bill Mask", true));
            parts.Add(new Part("Red POW Box", true));
            parts.Add(new Part("Ant Trooper", true));
            parts.Add(new Part("Horned Ant Trooper", true));
            parts.Add(new Part("Skipsqueak", true));
            parts.Add(new Part("Spiny Skipsqueak", true));
            parts.Add(new Part("Stingby", true));
            parts.Add(new Part("Pirahna Creeper", true));
            parts.Add(new Part("Fire Bro", true));
            parts.Add(new Part("Heavy Fire Bro", true));
            parts.Add(new Part("Hop-Chops", true));
            parts.Add(new Part("Peepa", true));
            parts.Add(new Part("Meowser", true));
            parts.Add(new Part("Pom Pom", true));
            parts.Add(new Part("Charvaargh", true));
            parts.Add(new Part("Bully", true));
            parts.Add(new Part("Porcupuffer", true));
            parts.Add(new Part("Koopa Troopa Car", true));
            parts.Add(new Part("! Block", true));
            parts.Add(new Part("Tree", true));
            parts.Add(new Part("Crate", true));
            parts.Add(new Part("Warp Box", true));
            parts.Add(new Part("Spike Block", true));
            parts.Add(new Part("Track Block", true));
            parts.Add(new Part("ON/OFF Trampoline", true));
            parts.Add(new Part("Mushroom Trampoline", true));
            parts.Add(new Part("Cloud Lift", true));
            parts.Add(new Part("Dash Block", true));
            parts.Add(new Part("Blinking Block", true));

            #endregion

            #region "List Initialization"

            // Count through the list to assign values to each array.
            foreach (Part candidatePart in parts)
            {
                // If the part is SMB, add it to the list.
                if (candidatePart.InSuperMarioBros)
                {
                    smbParts.Add(candidatePart);
                }
                // If the part is SMB3, add it to the list.
                if (candidatePart.InSuperMarioBros3)
                {
                    smb3Parts.Add(candidatePart);
                }
                // If the part is SMW, add it to the list.
                if (candidatePart.InSuperMarioWorld)
                {
                    smwParts.Add(candidatePart);
                }
                // If the part is NSMBU, add it to the list.
                if (candidatePart.InNewSuperMarioBrosU)
                {
                    nsmbuParts.Add(candidatePart);
                }
                // If the part is SM3DW, add it to the list.
                if (candidatePart.InSuperMario3dWorld)
                {
                    sm3dwParts.Add(candidatePart);
                }
            }

            #endregion
        }

        /// <summary>
        /// Returns this part as a string.
        /// </summary>
        /// <returns>The name of the part.</returns>
        public override string ToString()
        {
            return Name;
        }

        #endregion

    }
}
