namespace Lena
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ClockwiseButton = new System.Windows.Forms.ToolStripButton();
            this.AntiClockwiseButton = new System.Windows.Forms.ToolStripButton();
            this.VerticalFlipButton = new System.Windows.Forms.ToolStripButton();
            this.HorizonalFlipButton = new System.Windows.Forms.ToolStripButton();
            this.PictureDisplayer = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BrightnessBar = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GaussianBlur = new System.Windows.Forms.TrackBar();
            this.图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrayScaleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDisplayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianBlur)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.图像ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileButton,
            this.SaveButton,
            this.SaveAsButton});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(112, 22);
            this.OpenFileButton.Text = "打开";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 22);
            this.SaveButton.Text = "保存";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(112, 22);
            this.SaveAsButton.Text = "另存为";
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetButton});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // ResetButton
            // 
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(124, 22);
            this.ResetButton.Text = "撤销更改";
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClockwiseButton,
            this.AntiClockwiseButton,
            this.VerticalFlipButton,
            this.HorizonalFlipButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 540);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ClockwiseButton
            // 
            this.ClockwiseButton.AutoSize = false;
            this.ClockwiseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClockwiseButton.Image = global::Lena.Properties.Resources.右旋转90度;
            this.ClockwiseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClockwiseButton.Name = "ClockwiseButton";
            this.ClockwiseButton.Size = new System.Drawing.Size(53, 53);
            this.ClockwiseButton.Text = "顺时针旋转90度";
            this.ClockwiseButton.Click += new System.EventHandler(this.ClockwiseButton_Click);
            // 
            // AntiClockwiseButton
            // 
            this.AntiClockwiseButton.AutoSize = false;
            this.AntiClockwiseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AntiClockwiseButton.Image = global::Lena.Properties.Resources.左旋转90度;
            this.AntiClockwiseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AntiClockwiseButton.Name = "AntiClockwiseButton";
            this.AntiClockwiseButton.Size = new System.Drawing.Size(53, 53);
            this.AntiClockwiseButton.Text = "逆时针旋转90度";
            this.AntiClockwiseButton.Click += new System.EventHandler(this.AntiClockwiseButton_Click);
            // 
            // VerticalFlipButton
            // 
            this.VerticalFlipButton.AutoSize = false;
            this.VerticalFlipButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VerticalFlipButton.Image = global::Lena.Properties.Resources.上下翻转;
            this.VerticalFlipButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VerticalFlipButton.Name = "VerticalFlipButton";
            this.VerticalFlipButton.Size = new System.Drawing.Size(53, 53);
            this.VerticalFlipButton.Text = "垂直翻转";
            this.VerticalFlipButton.Click += new System.EventHandler(this.VerticalFlipButton_Click);
            // 
            // HorizonalFlipButton
            // 
            this.HorizonalFlipButton.AutoSize = false;
            this.HorizonalFlipButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HorizonalFlipButton.Image = global::Lena.Properties.Resources.左右翻转;
            this.HorizonalFlipButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HorizonalFlipButton.Name = "HorizonalFlipButton";
            this.HorizonalFlipButton.Size = new System.Drawing.Size(53, 53);
            this.HorizonalFlipButton.Text = "水平翻转";
            this.HorizonalFlipButton.Click += new System.EventHandler(this.HorizonalFlipButton_Click);
            // 
            // PictureDisplayer
            // 
            this.PictureDisplayer.Location = new System.Drawing.Point(58, 25);
            this.PictureDisplayer.Name = "PictureDisplayer";
            this.PictureDisplayer.Size = new System.Drawing.Size(530, 526);
            this.PictureDisplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureDisplayer.TabIndex = 2;
            this.PictureDisplayer.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarB);
            this.groupBox1.Controls.Add(this.trackBarG);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBarR);
            this.groupBox1.Location = new System.Drawing.Point(594, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "颜色调整";
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(34, 122);
            this.trackBarB.Maximum = 50;
            this.trackBarB.Minimum = -50;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(225, 45);
            this.trackBarB.TabIndex = 7;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(34, 71);
            this.trackBarG.Maximum = 50;
            this.trackBarG.Minimum = -50;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(225, 45);
            this.trackBarG.TabIndex = 6;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe 黑体 Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe 黑体 Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe 黑体 Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(34, 20);
            this.trackBarR.Maximum = 50;
            this.trackBarR.Minimum = -50;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(225, 45);
            this.trackBarR.TabIndex = 0;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "图像文件|*.png;*.jpg;*.jpeg";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BrightnessBar);
            this.groupBox3.Location = new System.Drawing.Point(594, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 92);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "亮度";
            // 
            // BrightnessBar
            // 
            this.BrightnessBar.Location = new System.Drawing.Point(34, 29);
            this.BrightnessBar.Maximum = 100;
            this.BrightnessBar.Minimum = -100;
            this.BrightnessBar.Name = "BrightnessBar";
            this.BrightnessBar.Size = new System.Drawing.Size(225, 45);
            this.BrightnessBar.TabIndex = 8;
            this.BrightnessBar.Scroll += new System.EventHandler(this.BrightnessBar_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GaussianBlur);
            this.groupBox4.Location = new System.Drawing.Point(594, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 92);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "高斯模糊";
            // 
            // GaussianBlur
            // 
            this.GaussianBlur.Location = new System.Drawing.Point(34, 29);
            this.GaussianBlur.Maximum = 100;
            this.GaussianBlur.Name = "GaussianBlur";
            this.GaussianBlur.Size = new System.Drawing.Size(225, 45);
            this.GaussianBlur.TabIndex = 8;
            this.GaussianBlur.Scroll += new System.EventHandler(this.GaussianBlur_Scroll);
            // 
            // 图像ToolStripMenuItem
            // 
            this.图像ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GrayScaleButton});
            this.图像ToolStripMenuItem.Name = "图像ToolStripMenuItem";
            this.图像ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.图像ToolStripMenuItem.Text = "图像";
            // 
            // GrayScaleButton
            // 
            this.GrayScaleButton.Name = "GrayScaleButton";
            this.GrayScaleButton.Size = new System.Drawing.Size(152, 22);
            this.GrayScaleButton.Text = "灰度";
            this.GrayScaleButton.Click += new System.EventHandler(this.GrayScaleButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 565);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PictureDisplayer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Lena";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDisplayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianBlur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileButton;
        private System.Windows.Forms.ToolStripMenuItem SaveButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ClockwiseButton;
        private System.Windows.Forms.ToolStripButton AntiClockwiseButton;
        private System.Windows.Forms.ToolStripButton VerticalFlipButton;
        private System.Windows.Forms.ToolStripButton HorizonalFlipButton;
        private System.Windows.Forms.PictureBox PictureDisplayer;
        private System.Windows.Forms.ToolStripMenuItem SaveAsButton;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar BrightnessBar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar GaussianBlur;
        private System.Windows.Forms.ToolStripMenuItem 图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GrayScaleButton;
    }
}

