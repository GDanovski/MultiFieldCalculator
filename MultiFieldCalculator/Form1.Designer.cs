namespace MultiFieldCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadCornersBeforeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCornersAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recalculateFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Y4 = new System.Windows.Forms.Label();
            this.Y3 = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.Label();
            this.Y1 = new System.Windows.Forms.Label();
            this.X4 = new System.Windows.Forms.Label();
            this.X3 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nY4 = new System.Windows.Forms.Label();
            this.nY3 = new System.Windows.Forms.Label();
            this.nY2 = new System.Windows.Forms.Label();
            this.nY1 = new System.Windows.Forms.Label();
            this.nX4 = new System.Windows.Forms.Label();
            this.nX3 = new System.Windows.Forms.Label();
            this.nX2 = new System.Windows.Forms.Label();
            this.nX1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rotAngle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.translationY = new System.Windows.Forms.Label();
            this.translationX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCornersBeforeToolStripMenuItem,
            this.loadCornersAfterToolStripMenuItem,
            this.recalculateFieldsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadCornersBeforeToolStripMenuItem
            // 
            this.loadCornersBeforeToolStripMenuItem.Name = "loadCornersBeforeToolStripMenuItem";
            this.loadCornersBeforeToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.loadCornersBeforeToolStripMenuItem.Text = "Load Corners Before";
            this.loadCornersBeforeToolStripMenuItem.Click += new System.EventHandler(this.loadCornersBeforeToolStripMenuItem_Click);
            // 
            // loadCornersAfterToolStripMenuItem
            // 
            this.loadCornersAfterToolStripMenuItem.Name = "loadCornersAfterToolStripMenuItem";
            this.loadCornersAfterToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.loadCornersAfterToolStripMenuItem.Text = "Load Corners After";
            this.loadCornersAfterToolStripMenuItem.Click += new System.EventHandler(this.loadCornersAfterToolStripMenuItem_Click);
            // 
            // recalculateFieldsToolStripMenuItem
            // 
            this.recalculateFieldsToolStripMenuItem.Name = "recalculateFieldsToolStripMenuItem";
            this.recalculateFieldsToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.recalculateFieldsToolStripMenuItem.Text = "Recalculate fields";
            this.recalculateFieldsToolStripMenuItem.Click += new System.EventHandler(this.recalculateFieldsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Y4);
            this.groupBox1.Controls.Add(this.Y3);
            this.groupBox1.Controls.Add(this.Y2);
            this.groupBox1.Controls.Add(this.Y1);
            this.groupBox1.Controls.Add(this.X4);
            this.groupBox1.Controls.Add(this.X3);
            this.groupBox1.Controls.Add(this.X2);
            this.groupBox1.Controls.Add(this.X1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(88, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Before:";
            // 
            // Y4
            // 
            this.Y4.AutoSize = true;
            this.Y4.Location = new System.Drawing.Point(108, 97);
            this.Y4.Name = "Y4";
            this.Y4.Size = new System.Drawing.Size(17, 13);
            this.Y4.TabIndex = 7;
            this.Y4.Text = "Y:";
            // 
            // Y3
            // 
            this.Y3.AutoSize = true;
            this.Y3.Location = new System.Drawing.Point(108, 75);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(17, 13);
            this.Y3.TabIndex = 6;
            this.Y3.Text = "Y:";
            // 
            // Y2
            // 
            this.Y2.AutoSize = true;
            this.Y2.Location = new System.Drawing.Point(108, 53);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(17, 13);
            this.Y2.TabIndex = 5;
            this.Y2.Text = "Y:";
            // 
            // Y1
            // 
            this.Y1.AutoSize = true;
            this.Y1.Location = new System.Drawing.Point(108, 29);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(17, 13);
            this.Y1.TabIndex = 4;
            this.Y1.Text = "Y:";
            // 
            // X4
            // 
            this.X4.AutoSize = true;
            this.X4.Location = new System.Drawing.Point(6, 97);
            this.X4.Name = "X4";
            this.X4.Size = new System.Drawing.Size(17, 13);
            this.X4.TabIndex = 3;
            this.X4.Text = "X:";
            // 
            // X3
            // 
            this.X3.AutoSize = true;
            this.X3.Location = new System.Drawing.Point(6, 75);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(17, 13);
            this.X3.TabIndex = 2;
            this.X3.Text = "X:";
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Location = new System.Drawing.Point(6, 53);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(17, 13);
            this.X2.TabIndex = 1;
            this.X2.Text = "X:";
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Location = new System.Drawing.Point(6, 29);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(17, 13);
            this.X1.TabIndex = 0;
            this.X1.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nY4);
            this.groupBox2.Controls.Add(this.nY3);
            this.groupBox2.Controls.Add(this.nY2);
            this.groupBox2.Controls.Add(this.nY1);
            this.groupBox2.Controls.Add(this.nX4);
            this.groupBox2.Controls.Add(this.nX3);
            this.groupBox2.Controls.Add(this.nX2);
            this.groupBox2.Controls.Add(this.nX1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(301, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 132);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info After:";
            // 
            // nY4
            // 
            this.nY4.AutoSize = true;
            this.nY4.Location = new System.Drawing.Point(109, 97);
            this.nY4.Name = "nY4";
            this.nY4.Size = new System.Drawing.Size(17, 13);
            this.nY4.TabIndex = 8;
            this.nY4.Text = "Y:";
            // 
            // nY3
            // 
            this.nY3.AutoSize = true;
            this.nY3.Location = new System.Drawing.Point(109, 75);
            this.nY3.Name = "nY3";
            this.nY3.Size = new System.Drawing.Size(17, 13);
            this.nY3.TabIndex = 7;
            this.nY3.Text = "Y:";
            // 
            // nY2
            // 
            this.nY2.AutoSize = true;
            this.nY2.Location = new System.Drawing.Point(109, 53);
            this.nY2.Name = "nY2";
            this.nY2.Size = new System.Drawing.Size(17, 13);
            this.nY2.TabIndex = 6;
            this.nY2.Text = "Y:";
            // 
            // nY1
            // 
            this.nY1.AutoSize = true;
            this.nY1.Location = new System.Drawing.Point(109, 29);
            this.nY1.Name = "nY1";
            this.nY1.Size = new System.Drawing.Size(17, 13);
            this.nY1.TabIndex = 5;
            this.nY1.Text = "Y:";
            // 
            // nX4
            // 
            this.nX4.AutoSize = true;
            this.nX4.Location = new System.Drawing.Point(6, 97);
            this.nX4.Name = "nX4";
            this.nX4.Size = new System.Drawing.Size(17, 13);
            this.nX4.TabIndex = 4;
            this.nX4.Text = "X:";
            // 
            // nX3
            // 
            this.nX3.AutoSize = true;
            this.nX3.Location = new System.Drawing.Point(6, 75);
            this.nX3.Name = "nX3";
            this.nX3.Size = new System.Drawing.Size(17, 13);
            this.nX3.TabIndex = 3;
            this.nX3.Text = "X:";
            // 
            // nX2
            // 
            this.nX2.AutoSize = true;
            this.nX2.Location = new System.Drawing.Point(6, 53);
            this.nX2.Name = "nX2";
            this.nX2.Size = new System.Drawing.Size(17, 13);
            this.nX2.TabIndex = 2;
            this.nX2.Text = "X:";
            // 
            // nX1
            // 
            this.nX1.AutoSize = true;
            this.nX1.Location = new System.Drawing.Point(6, 29);
            this.nX1.Name = "nX1";
            this.nX1.Size = new System.Drawing.Size(17, 13);
            this.nX1.TabIndex = 1;
            this.nX1.Text = "X:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rotAngle);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.translationY);
            this.groupBox3.Controls.Add(this.translationX);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 83);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result:";
            // 
            // rotAngle
            // 
            this.rotAngle.AutoSize = true;
            this.rotAngle.Location = new System.Drawing.Point(94, 54);
            this.rotAngle.Name = "rotAngle";
            this.rotAngle.Size = new System.Drawing.Size(0, 13);
            this.rotAngle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rotation angle:";
            // 
            // translationY
            // 
            this.translationY.AutoSize = true;
            this.translationY.Location = new System.Drawing.Point(196, 25);
            this.translationY.Name = "translationY";
            this.translationY.Size = new System.Drawing.Size(17, 13);
            this.translationY.TabIndex = 5;
            this.translationY.Text = "Y:";
            // 
            // translationX
            // 
            this.translationX.AutoSize = true;
            this.translationX.Location = new System.Drawing.Point(94, 25);
            this.translationX.Name = "translationX";
            this.translationX.Size = new System.Drawing.Size(17, 13);
            this.translationX.TabIndex = 1;
            this.translationX.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Translation:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 132);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Right down:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Left up:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Right up:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Left down:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(523, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(508, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Copyright (c) 2017, Georgi Danovski";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Multi Field Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadCornersBeforeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCornersAfterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recalculateFieldsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Y4;
        private System.Windows.Forms.Label Y3;
        private System.Windows.Forms.Label Y2;
        private System.Windows.Forms.Label Y1;
        private System.Windows.Forms.Label X4;
        private System.Windows.Forms.Label X3;
        private System.Windows.Forms.Label X2;
        private System.Windows.Forms.Label X1;
        private System.Windows.Forms.Label nY4;
        private System.Windows.Forms.Label nY3;
        private System.Windows.Forms.Label nY2;
        private System.Windows.Forms.Label nY1;
        private System.Windows.Forms.Label nX4;
        private System.Windows.Forms.Label nX3;
        private System.Windows.Forms.Label nX2;
        private System.Windows.Forms.Label nX1;
        private System.Windows.Forms.Label rotAngle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label translationY;
        private System.Windows.Forms.Label translationX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

