﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NifUtil;
using System.Drawing;

namespace MapCreator
{
    class NifRow
    {
        private int m_nifId;
        private string m_textualName;
        private string m_filename;
        private int m_color;

        private Polygon[] m_polygons;

        #region Getter/setter

        public int Color
        {
            get { return m_color; }
            set { m_color = value; }
        }

        public string Filename
        {
            get { return m_filename; }
            set { m_filename = value; }
        }

        public string TextualName
        {
            get { return m_textualName; }
            set { m_textualName = value; }
        }

        public int NifId
        {
            get { return m_nifId; }
            set { m_nifId = value; }
        }

        public Polygon[] Polygons
        {
            get { return m_polygons; }
            set { m_polygons = value; }
        }

        #endregion

        public NifRow()
        {
        }

        public SizeF GetSize(double scale, double angle)
        {
            // Create a copy of the polygons
            List<Polygon> polygons = new List<Polygon>(m_polygons);

            var vectors = Polygons.SelectMany(p => p.Vectors);
            double minX = vectors.Min(p => p.X);
            double maxX = vectors.Max(p => p.X);
            double minY = vectors.Min(p => p.Y);
            double maxY = vectors.Max(p => p.Y);

            // Get the nif dimensions
            double minXProduct = (minX < 0) ? minX * -1 : minX;
            double maxXProduct = (maxX < 0) ? maxX * -1 : maxX;
            double minYProduct = (minY < 0) ? minY * -1 : minY;
            double maxYProduct = (maxY < 0) ? maxY * -1 : maxY;

            SizeF size = new SizeF();
            size.Width = (float)((minXProduct < maxXProduct) ? maxXProduct * 2d : minXProduct * 2d);
            size.Height = (float)((minYProduct < maxYProduct) ? maxYProduct * 2d : minYProduct * 2d);
            return size;
        }

        public override string ToString()
        {
            return m_nifId.ToString() + ": " + m_textualName + "(" + m_filename + ")";
        }
    }
}
