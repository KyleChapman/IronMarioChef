// Author:  Kyle Chapman
// Created: June 13, 2021
// Modified: June 13, 2021
// Description:
//  This file contains enumerations for the GameStyle and CourseStyle, separating these out so they can be used from within both IronMarioChef.cs and Part.cs.

using System;
using System.Collections.Generic;
using System.Text;

namespace IronMarioChef
{
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

}
