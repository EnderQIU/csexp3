using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lena
{
    public partial class MainWindow : Form
    {
        private string filename;

        private Image image;

        private Image o_image;

        private Image getImage()
        {
            return image;
        }

        private void setImage(Image image)
        {
            this.o_image = image;
            this.image = image;
        }

        public MainWindow()
        {
            InitializeComponent();
            filename = "";
        }

        // 打开文件
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                setImage(Image.FromFile(filename));
                PictureDisplayer.Image = getImage();
            }
        }

        // 保存文件
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(filename))
            {
                try
                {
                    System.IO.File.Delete(filename);
                }
                catch (System.IO.IOException ioe)
                {
                    Console.WriteLine(ioe.Message);
                    return;
                }
            }
            getImage().Save(filename);
        }


        // 另存为文件
        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Png Image|*.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        getImage().Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        getImage().Save(fs,
                           System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
        }

        // 还原所有更改
        private void ResetButton_Click(object sender, EventArgs e)
        {
            setImage(Image.FromFile(filename));
            PictureDisplayer.Image = getImage();
        }

        // 顺时针旋转
        private void ClockwiseButton_Click(object sender, EventArgs e)
        {
            setImage(ImageProcessor.Clockwise(getImage()));
            PictureDisplayer.Image = getImage();
        }

        // 逆时针旋转
        private void AntiClockwiseButton_Click(object sender, EventArgs e)
        {
            setImage(ImageProcessor.AntiClockwise(getImage()));
            PictureDisplayer.Image = getImage();
        }
        
        // 垂直翻转
        private void VerticalFlipButton_Click(object sender, EventArgs e)
        {
            setImage(ImageProcessor.VerticalFlit(getImage()));
            PictureDisplayer.Image = getImage();
        }

        // 水平翻转
        private void HorizonalFlipButton_Click(object sender, EventArgs e)
        {
            setImage(ImageProcessor.HorizenalFlit(getImage()));
            PictureDisplayer.Image = getImage();
        }

        // 分通道调整
        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            image = ImageProcessor.SetR(getImage(), o_image, trackBarR.Value);
            PictureDisplayer.Image = getImage();
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            image = ImageProcessor.SetG(getImage(), o_image, trackBarG.Value);
            PictureDisplayer.Image = getImage();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            image = ImageProcessor.SetB(getImage(), o_image, trackBarB.Value);
            PictureDisplayer.Image = getImage();
        }

        // 灰度化
        private void GrayScaleButton_Click(object sender, EventArgs e)
        {
            image = ImageProcessor.Greyscale(getImage());
            PictureDisplayer.Image = getImage();
        }

        // 高斯模糊
        private void GaussianBlur_Scroll(object sender, EventArgs e)
        {
     
            image = ImageProcessor.GaussianBlur(o_image, GaussianBlur.Value);
            PictureDisplayer.Image = getImage();
        }

        // 亮度调整
        private void BrightnessBar_Scroll(object sender, EventArgs e)
        {
            image = ImageProcessor.BrightnessAdjust(o_image, BrightnessBar.Value);
            PictureDisplayer.Image = getImage();
        }
    }
}
