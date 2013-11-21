﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapCreator
{

    public enum GameExpansion
    {
        Unknown = 0,

        Classic = 1,
        ShroudedIsles = 2,
        TrialsOfAtlantis = 3,
        Catacombs = 4,
        DarknessRising = 6,
        LabyrithOfTheMinotaur = 7,

        Foundations = 10,
        NewFrontiers = 11,
    }

    public enum RiverTypes
    {

        River = 0,
        Lake = 1,
        Swamp = 2,

        Lava = 10
    }

    public class Point3D
    {
        private int m_x;

        public int X
        {
            get { return m_x; }
            set { m_x = value; }
        }

        private int m_y;

        public int Y
        {
            get { return m_y; }
            set { m_y = value; }
        }

        private int m_z;

        public int Z
        {
            get { return m_z; }
            set { m_z = value; }
        }
    }

}