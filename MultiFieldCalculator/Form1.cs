using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFieldCalculator
{
    public partial class Form1 : Form
    {
        private DataStorage data;
        private DataGridForm dataForm;
        public Form1()
        {
            InitializeComponent();
            //load events
            data = new DataStorage();
            dataForm = new DataGridForm(data);
        }

        private void loadCornersBeforeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = FolderBrowser("Select folder with metadata txt - before");

            if (dir == null) return;

            //find all .txt files in the directory
            List<string> dirs = FileDecoder.TakeFileNames(dir);
            //System.Windows.Forms.MessageBox.Show(string.Join("\n", dirs));

            //find all strings with "Move XY"
            string[] cornerInfo = FileDecoder.readCorners(dirs);
            //System.Windows.Forms.MessageBox.Show(string.Join("\n", cornerInfo));

            //calculate points
            data.beforePoint = CornerReader.ReorderPoints(CornerReader.CalculatePoints(cornerInfo));

            if (data.beforePoint == null) return;
            //Load data
            X1.Text = "X: " + data.beforePoint[0].X.ToString();
            X2.Text = "X: " + data.beforePoint[1].X.ToString();
            X3.Text = "X: " + data.beforePoint[2].X.ToString();
            X4.Text = "X: " + data.beforePoint[3].X.ToString();

            Y1.Text = "Y: " + data.beforePoint[0].Y.ToString();
            Y2.Text = "Y: " + data.beforePoint[1].Y.ToString();
            Y3.Text = "Y: " + data.beforePoint[2].Y.ToString();
            Y4.Text = "Y: " + data.beforePoint[3].Y.ToString();
            
            FieldCalculation.FindCompensations(data);

            translationX.Text = "X: " + data.dX.ToString();
            translationY.Text = "Y: " + data.dY.ToString();
            rotAngle.Text = (-data.angle* (180/Math.PI)).ToString() + "°";
        }

        private void loadCornersAfterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = FolderBrowser("Select folder with metadata txt - after");

            if (dir == null) return;

            //find all .txt files in the directory
            List<string> dirs = FileDecoder.TakeFileNames(dir);
            //System.Windows.Forms.MessageBox.Show(string.Join("\n", dirs));

            //find all strings with "Move XY"
            string[] cornerInfo = FileDecoder.readCorners(dirs);
            //System.Windows.Forms.MessageBox.Show(string.Join("\n", cornerInfo));

            //calculate points
            data.afterPoint = CornerReader.ReorderPoints(CornerReader.CalculatePoints(cornerInfo));

            if (data.afterPoint == null) return;
            //Load data
            nX1.Text = "X: " + data.afterPoint[0].X.ToString();
            nX2.Text = "X: " + data.afterPoint[1].X.ToString();
            nX3.Text = "X: " + data.afterPoint[2].X.ToString();
            nX4.Text = "X: " + data.afterPoint[3].X.ToString();

            nY1.Text = "Y: " + data.afterPoint[0].Y.ToString();
            nY2.Text = "Y: " + data.afterPoint[1].Y.ToString();
            nY3.Text = "Y: " + data.afterPoint[2].Y.ToString();
            nY4.Text = "Y: " + data.afterPoint[3].Y.ToString();

            FieldCalculation.FindCompensations(data);

            translationX.Text = "X: " + data.dX.ToString();
            translationY.Text = "Y: " + data.dY.ToString();
            rotAngle.Text = (-data.angle * (180 / Math.PI)).ToString() + "°";
        }

        private void recalculateFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = FolderBrowser("Select folder with metadata txt for recalculation");

            if (dir == null) return;

            //find all .txt files in the directory
            List<string> dirs = FileDecoder.TakeFileNames(dir);
            //System.Windows.Forms.MessageBox.Show(string.Join("\n", dirs));
            data.fileNames = dirs.ToArray();

            //find all strings with "Move XY"
            string[] cornerInfo = FileDecoder.readFields(dirs);
            //System.Windows.Forms.MessageBox.Show(string.Join("\n", cornerInfo));

            //calculate points
            data.dataPoint = CornerReader.CalculatePoints(cornerInfo);

            if (data.dataPoint == null || data.afterPoint == null ||
                data.beforePoint == null) return;

            //Load data

            FieldCalculation.RecalculateFields(data);
            //save data
            dataForm.Hide();
            dataForm.Show();
        }
        private string FolderBrowser(string description)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = description;

            if (Properties.Settings.Default.RootFolder != "")
                fbd.SelectedPath = Properties.Settings.Default.RootFolder;
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.RootFolder = fbd.SelectedPath;
                Properties.Settings.Default.Save();
                return fbd.SelectedPath;
            }

            return null;
        }
    }
}
