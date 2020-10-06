using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MultiFieldCalculator
{
    class CornerReader
    {
        public static PointF[] CalculatePoints(string[] corners)
        {
            PointF[] points = new PointF[corners.Length];
            for(int i = 0; i<corners.Length; i++)
            {
                /*
                string source = corners[i];
                int begin = source.IndexOf("(");
                int Length = source.IndexOf(")") - begin - 1;
                */
                string raw = corners[i];//source.Substring(begin+1, Length);

                string[] vals = raw.Split(new string[] { "\t" }, System.StringSplitOptions.None);

                points[i].X = float.Parse(vals[2]);
                points[i].Y = float.Parse(vals[3]);
            }

            //points = ReorderPoints(points);

            return points;
        }
        public static PointF CenterOfMass(PointF[] points)
        {
            PointF p = new PointF(0, 0);

            foreach (PointF cur in points)
            {
                p.X += cur.X;
                p.Y += cur.Y;
            }

            p.X /= points.Length;
            p.Y /= points.Length;

            return p;
        }
       public static PointF[] ReorderPoints(PointF[] points)
        {
            PointF[] resPoints = new PointF[points.Length];
            /*
            1   |   3
            -   -   -
            2   |   4
            */
            PointF p = CenterOfMass(points);

            float CX = p.X;
            float CY = p.Y;
            
            foreach (PointF cur in points)
                if (cur.X < CX && cur.Y < CY)
                {
                    resPoints[0].X = cur.X;
                    resPoints[0].Y = cur.Y;
                }
                else if (cur.X < CX && cur.Y > CY)
                {
                    resPoints[1].X = cur.X;
                    resPoints[1].Y = cur.Y;
                }
                else if (cur.X > CX && cur.Y < CY)
                {
                    resPoints[2].X = cur.X;
                    resPoints[2].Y = cur.Y;
                }
                else if (cur.X > CX && cur.Y > CY)
                {
                    resPoints[3].X = cur.X;
                    resPoints[3].Y = cur.Y;
                }


            return resPoints;
        }
    }
}
