using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFieldCalculator
{
    class DataGridForm:Form
    {
        public DataGridView dataGrid = new DataGridView();
        private DataStorage data = null;
        public DataGridForm(DataStorage data)
        {
            this.data = data;
            this.Width = 600;
            this.Height = 400;
            this.Text = "Data";
            this.StartPosition = FormStartPosition.CenterScreen;
            
            dataGrid.Dock = DockStyle.Fill;
            this.Controls.Add(dataGrid);

            MenuStrip ms = new MenuStrip();
            this.Controls.Add(ms);

            ToolStripMenuItem save = new ToolStripMenuItem();
            save.Text = "Save";
            save.Click += save_Clicked;
            ms.Items.Add(save);

            this.Hide();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            //base.OnClosing(e);
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible != true) return;
            
            LoadStrings();
        }
        private void LoadStrings()
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();

            foreach (string val in data.store[0])
                dataGrid.Columns.Add(val, val);

            for (int i = 1; i < data.store.Length; i++)
                dataGrid.Rows.Add(data.store[i]);
        }
        private string StringBuilder()
        {
            string[] l = new string[data.store.GetLength(0)];
            for (int i = 0; i < l.Length; i++)
                l[i] = string.Join("\t", data.store[i]);

            return string.Join("\n", l);
        }
        private void save_Clicked(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text File|*.txt";
            dialog.RestoreDirectory = true;

            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            // setup for export
            dataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGrid.SelectAll();
            // hiding row headers to avoid extra \t in exported text
            var rowHeaders = dataGrid.RowHeadersVisible;
            dataGrid.RowHeadersVisible = false;

            // ! creating text from grid values
            string content = dataGrid.GetClipboardContent().GetText();

            // restoring grid state
            dataGrid.ClearSelection();
            dataGrid.RowHeadersVisible = rowHeaders;

            System.IO.File.WriteAllText(dialog.FileName, content);
            MessageBox.Show(@"Text file was created.");
        }
    }
}
