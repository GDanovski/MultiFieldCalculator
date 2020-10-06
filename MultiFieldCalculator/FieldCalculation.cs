using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MultiFieldCalculator
{
    class FieldCalculation
    {
        public static void FindCompensations(DataStorage data)
        {
            data.dX = 0f;
            data.dY = 0f;
            data.angle = 0f;

            if (data.afterPoint == null || data.beforePoint == null) return;

            //calculate center of mass for the two times
            PointF befMid = CornerReader.CenterOfMass(data.beforePoint);
            PointF aftMid = CornerReader.CenterOfMass(data.afterPoint);
            //apply info to the data storage
            data.dX = befMid.X - aftMid.X;
            data.dY = befMid.Y - aftMid.Y;
            // move the center of mass to Cxy(0,0)
            PointF befP = new PointF(data.beforePoint[3].X, data.beforePoint[3].Y);
            befP.X -= befMid.X;
            befP.Y -= befMid.Y;

            PointF aftP = new PointF(data.afterPoint[3].X, data.afterPoint[3].Y);
            aftP.X -= aftMid.X;
            aftP.Y -= aftMid.Y;

            double befAngl = Math.Atan(befP.Y / befP.X);
            double aftAngl = Math.Atan(aftP.Y / aftP.X);
            //System.Windows.Forms.MessageBox.Show(befP.X + "\n" + befP.Y + "\n" + befAngl);
            //System.Windows.Forms.MessageBox.Show(aftP.X + "\n" + aftP.Y + "\n" + aftAngl);
            data.angle = befAngl - aftAngl;
        }
        public static void RecalculateFields(DataStorage data)
        {
            PointF befMid = CornerReader.CenterOfMass(data.beforePoint);
            PointF aftMid = CornerReader.CenterOfMass(data.afterPoint);
            
            double angle = -data.angle; // (Math.PI / 180);
            double sin = Math.Sin(angle);
            double cos =Math.Cos(angle);

            string[][] store = new string[data.dataPoint.Length + 1][];
            store[0] = new string[5];
            store[0][0] = "Field name";
            store[0][1] = "Old X";
            store[0][2] = "Old Y";
            store[0][3] = "New X";
            store[0][4] = "New Y";

            PointF p = Point.Empty;

            for (int i = 0, row = 1; i < data.dataPoint.Length; i++, row++)
            {
                store[row] = new string[5];
                p = data.dataPoint[i];

                string name = data.fileNames[i];
                store[row][0] = name.Substring(name.LastIndexOf("\\") + 1, name.Length - name.LastIndexOf("\\") - 5).Replace("Cerry","").Replace("GFP","");
                store[row][1] = p.X.ToString();
                store[row][2] = p.Y.ToString();

                p = RecalculatePoint(p, sin,cos, befMid,aftMid);
                store[row][3] = p.X.ToString();
                store[row][4] = p.Y.ToString();
            }

            data.store = store;
        }
        private static PointF RecalculatePoint(PointF p, double sin, double cos, PointF befMid, PointF aftMid)
        {
            //first translation
            PointF res = new PointF(p.X - befMid.X, p.Y - befMid.Y);
            PointF temp = new PointF();
            //rotation
            temp.X = (float)(res.X * cos - res.Y * sin);
            temp.Y = (float)(res.Y * cos + res.X * sin);
            res = temp;
            //secound translation
            res.X += aftMid.X;
            res.Y += aftMid.Y;
            //return result
            return res;
        }
    }
}
