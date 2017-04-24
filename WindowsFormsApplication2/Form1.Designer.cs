namespace WindowsFormsApplication2
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ptDisplay = new System.Windows.Forms.ListBox();
            this.clrDisplay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.tBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.TextBox();
            this.errTag = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPointsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openPointsToolStripMenuItem
            // 
            this.openPointsToolStripMenuItem.Name = "openPointsToolStripMenuItem";
            this.openPointsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openPointsToolStripMenuItem.Text = "Open Points";
            this.openPointsToolStripMenuItem.Click += new System.EventHandler(this.openPointsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ptDisplay
            // 
            this.ptDisplay.FormattingEnabled = true;
            this.ptDisplay.HorizontalScrollbar = true;
            this.ptDisplay.Location = new System.Drawing.Point(12, 43);
            this.ptDisplay.Name = "ptDisplay";
            this.ptDisplay.Size = new System.Drawing.Size(396, 368);
            this.ptDisplay.TabIndex = 2;
            // 
            // clrDisplay
            // 
            this.clrDisplay.Location = new System.Drawing.Point(162, 417);
            this.clrDisplay.Name = "clrDisplay";
            this.clrDisplay.Size = new System.Drawing.Size(83, 36);
            this.clrDisplay.TabIndex = 3;
            this.clrDisplay.Text = "Clear";
            this.clrDisplay.UseVisualStyleBackColor = true;
            this.clrDisplay.Click += new System.EventHandler(this.clrDisplay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Interpolate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(617, 85);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(100, 20);
            this.xBox.TabIndex = 5;
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(617, 111);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(100, 20);
            this.yBox.TabIndex = 6;
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(617, 137);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(100, 20);
            this.tBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter X value:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Y Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter a Date Value (1-364)";
            // 
            // txtTag
            // 
            this.txtTag.AutoSize = true;
            this.txtTag.Location = new System.Drawing.Point(447, 171);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(142, 13);
            this.txtTag.TabIndex = 11;
            this.txtTag.Text = "Enter a Power/Weight value";
            this.txtTag.Click += new System.EventHandler(this.label4_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(617, 164);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(100, 20);
            this.pBox.TabIndex = 12;
            this.pBox.Text = "2";
            this.pBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // errTag
            // 
            this.errTag.AutoSize = true;
            this.errTag.Location = new System.Drawing.Point(447, 362);
            this.errTag.Name = "errTag";
            this.errTag.Size = new System.Drawing.Size(0, 13);
            this.errTag.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.errTag);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clrDisplay);
            this.Controls.Add(this.ptDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPointsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox ptDisplay;
        private System.Windows.Forms.Button clrDisplay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTag;
        private System.Windows.Forms.TextBox pBox;
        private System.Windows.Forms.Label errTag;
    }
}

