using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MultiFieldCalculator
{
    class DataStorage
    {
        public PointF[] beforePoint = new PointF[] { PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty };
        public PointF[] afterPoint = new PointF[] { PointF.Empty, PointF.Empty, PointF.Empty, PointF.Empty };
        public PointF[] dataPoint = null;
        public string[][] store = null;
        public string[] fileNames;
        public float dX = 0f;
        public float dY = 0f;
        public double angle = 0;
        
    }
}
