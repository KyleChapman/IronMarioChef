// Author:  Kyle Chapman
// Created: June 10, 2021
// Modified: June 10, 2021
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
        private bool[] validStyles;

        // Static variables, shared among all parts.
        private static int totalParts = 0;
        private static int smbParts = 0;
        private static int smb3Parts = 0;
        private static int smwParts = 0;
        private static int nsmbuParts = 0;
        private static int sm3dwParts = 0;

        // A list of all parts that will be added to as parts are created.
        private static List<Part> parts;

        #endregion
        #region "Constructors"

        /// <summary>
        /// Default constructor. Makes a blank part and adds it to the list.
        /// </summary>
        public Part()
        {
            totalParts++;
            partId = totalParts;

            parts.Add(this);
        }

        /// <summary>
        /// Constructor that creates a part supported in all game styles.
        /// </summary>
        /// <param name="name">The name of the part.</param>
        public Part(string name)
        {
            totalParts++;
            partId = totalParts;
            partName = name;

            // This part is supported in all game styles.
            validStyles = new bool[] { true, true, true, true, true };

            // Increment the number of valid parts for all game styles.
            smbParts += 1;
            smb3Parts += 1;
            smwParts += 1;
            nsmbuParts += 1;
            sm3dwParts += 1;

            // Add this part to the list.
            parts.Add(this);
        }

        /// <summary>
        /// Constructor that creates a part supported either (true) ONLY Super Mario 3D World or (false) all styles BUT Super Mario 3D World.
        /// </summary>
        /// <param name="name">The name of the part.</param>/// <param name="isSuperMario3dWorldSupported">true if this part is unique to Super Mario 3D World; false is this part is allowed in all styles other than Super Mario 3D World</param>
        public Part(string name, bool isSuperMario3dWorldSupported)
        {
            totalParts++;
            partId = totalParts;
            partName = name;
            
            // Check if this part is supported for Super Mario 3D World.
            if (isSuperMario3dWorldSupported)
            {
                // This part is only supported in Super Mario 3D World.
                validStyles = new bool[] { false, false, false, false, true };
                sm3dwParts += 1;
            }
            else
            {
                // This part is supported in all game styles other than Super Mario 3D World.
                validStyles = new bool[] { true, true, true, true, false };
                smbParts += 1;
                smb3Parts += 1;
                smwParts += 1;
                nsmbuParts += 1;
            }

            // Add this part to the list.
            parts.Add(this);
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
        public Part(string name, bool isInSuperMarioBros, bool isInSuperMarioBros3, bool isInSuperMarioWorld, bool isInNewSuperMarioBrosU, bool isInSuperMario3dWorld)
        {
            totalParts++;
            partId = totalParts;
            partName = name;

            // Check if the part is valid in Super Mario Bros.
            if (isInSuperMarioBros)
            {
                validStyles[0] = true;
                smbParts += 1;
            }
            // Check if the part is valid in Super Mario Bros. 3
            if (isInSuperMarioBros3)
            {
                validStyles[1] = true;
                smb3Parts += 1;
            }
            // Check if the part is valid in Super Mario World
            if (isInSuperMarioWorld)
            {
                validStyles[2] = true;
                smwParts += 1;
            }
            // Check if the part is valid in New Super Mario Bros. U
            if (isInNewSuperMarioBrosU)
            {
                validStyles[3] = true;
                nsmbuParts += 1;
            }
            // Check if the part is valid in Super Mario 3D World
            if (isInSuperMario3dWorld)
            {
                validStyles[4] = true;
                sm3dwParts += 1;
            }

            // Add this part to the list.
            parts.Add(this);
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
                return validStyles[0];
            }
            set
            {
                validStyles[0] = value;
            }
        }

        /// <summary>
        /// Gets or sets whether a part is supported in Super Mario Bros. 3 style.
        /// </summary>
        public bool InSuperMarioBros3
        {
            get
            {
                return validStyles[1];
            }
            set
            {
                validStyles[1] = value;
            }
        }

        /// <summary>
        /// Gets or sets whether a part is supported in Super Mario World style.
        /// </summary>
        public bool InSuperMarioWorld
        {
            get
            {
                return validStyles[2];
            }
            set
            {
                validStyles[2] = value;
            }
        }

        /// <summary>
        /// Gets or sets whether a part is supported in New Super Mario Bros. U style.
        /// </summary>
        public bool InNewSuperMarioBrosU
        {
            get
            {
                return validStyles[3];
            }
            set
            {
                validStyles[3] = value;
            }
        }

        /// <summary>
        /// Gets or sets whether a part is supported in Super Mario 3D World style.
        /// </summary>
        public bool InSuperMario3dWorld
        {
            get
            {
                return validStyles[4];
            }
            set
            {
                validStyles[4] = value;
            }
        }

        #endregion
        #region "Functions"

        /// <summary>
        /// Gets an array of all parts supported in the Super Mario Bros. style.
        /// </summary>
        /// <returns>An array of parts supported in Super Mario Bros. style.</returns>
        public Part[] GetSuperMarioBrosParts()
        {
            Part[] partsArray = new Part[smbParts];
            int collectedParts = 0;

            foreach (Part candidatePart in parts)
            {
                if (candidatePart.InSuperMarioBros)
                {
                    partsArray[collectedParts] = candidatePart;
                    collectedParts++;
                }
            }

            return partsArray;
        }

        /// <summary>
        /// Gets an array of all parts supported in the Super Mario Bros. 3 style.
        /// </summary>
        /// <returns>An array of parts supported in Super Mario Bros. 3 style.</returns>
        public Part[] GetSuperMarioBros3Parts()
        {
            Part[] partsArray = new Part[smb3Parts];
            int collectedParts = 0;

            foreach (Part candidatePart in parts)
            {
                if (candidatePart.InSuperMarioBros3)
                {
                    partsArray[collectedParts] = candidatePart;
                    collectedParts++;
                }
            }

            return partsArray;
        }

        /// <summary>
        /// Gets an array of all parts supported in the Super Mario World style.
        /// </summary>
        /// <returns>An array of parts supported in Super Mario World style.</returns>
        public Part[] GetSuperMarioWorldParts()
        {
            Part[] partsArray = new Part[smwParts];
            int collectedParts = 0;

            foreach (Part candidatePart in parts)
            {
                if (candidatePart.InSuperMarioWorld)
                {
                    partsArray[collectedParts] = candidatePart;
                    collectedParts++;
                }
            }

            return partsArray;
        }

        /// <summary>
        /// Gets an array of all parts supported in the New Super Mario Bros. U style.
        /// </summary>
        /// <returns>An array of parts supported in New Super Mario Bros. U style.</returns>
        public Part[] GetNewSuperMarioBrosUParts()
        {
            Part[] partsArray = new Part[nsmbuParts];
            int collectedParts = 0;

            foreach (Part candidatePart in parts)
            {
                if (candidatePart.InNewSuperMarioBrosU)
                {
                    partsArray[collectedParts] = candidatePart;
                    collectedParts++;
                }
            }

            return partsArray;
        }

        /// <summary>
        /// Gets an array of all parts supported in the Super Mario 3D World style.
        /// </summary>
        /// <returns>An array of parts supported in Super Mario 3D World style.</returns>
        public Part[] GetSuperMario3dWorldParts()
        {
            Part[] partsArray = new Part[sm3dwParts];
            int collectedParts = 0;

            foreach (Part candidatePart in parts)
            {
                if (candidatePart.InSuperMario3dWorld)
                {
                    partsArray[collectedParts] = candidatePart;
                    collectedParts++;
                }
            }

            return partsArray;
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
