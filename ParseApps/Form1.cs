using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using Leptonica;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ParseApps
{

    public partial class Form1 : Form
    {
        
        //KeyDown = new KeyEventHandler(this, keyboard_KeyDown);


        int[] leftTop = new int[2];
        int[] rightDown = new int[2];
        bool captureFirst = false;
        bool captureSecond = false;
        bool pickColor = false;
        Color balloonColor = Color.FromArgb(253, 253, 254);
        delegate void SetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();
        }

        private void coordinatesButton_Click(object sender, EventArgs e)
        {
            captureFirst = true;
            lefTopLabelContainer.Text = "J to capture";

        }


        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        private void CaptureMyScreen(int xheight, int xwidth)

        {

            try
            {
                
                Bitmap captureBitmap = new Bitmap(xwidth, xheight, PixelFormat.Format32bppArgb);
                Point leftTopCorner = new Point(leftTop[0], leftTop[1]);
                Rectangle captureRectangle = new Rectangle(leftTopCorner, captureBitmap.Size);
                System.Drawing.Graphics captureGraphics = System.Drawing.Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                // Capturing image and saving
                //imagePickedBox.Image = captureBitmap;
                Color auxColor;
                int[] leftTopBalloon = { 0, 0 };
                int[] rightDownBalloon = { 0, 0 };
                int i = 0;
                int j = 0;
                bool corner = false;
                colorPickerLabel.Text = "Height, Width: " +  captureBitmap.Height + ", " + captureBitmap.Width + Environment.NewLine + "Size: " + captureBitmap.Size + Environment.NewLine;
                imagePickedBox.Image = captureBitmap;
                Color pasada = Color.FromArgb(255, 244, 66, 66);
                while (!corner && j < captureBitmap.Height - 1)
                {
                    while (!corner && i < captureBitmap.Width - 1)
                    {
                        //Debug.WriteLine("J: " + j);
                        auxColor = captureBitmap.GetPixel(i, j);
                        if (auxColor == balloonColor)
                        {
                            if (leftTopBalloon[0] == 0 && leftTopBalloon[1] == 0)
                            {
                                leftTopBalloon[0] = i;
                                leftTopBalloon[1] = j;
                            }
                            else if (i < leftTopBalloon[0])
                            {
                                leftTopBalloon[0] = i;
                                leftTopBalloon[1] = j;
                            }
                            else if(captureBitmap.GetPixel(i, j-3) == captureBitmap.GetPixel(i, j) && captureBitmap.GetPixel(i - 1, j) != captureBitmap.GetPixel(i, j))
                            {
                                if (captureBitmap.GetPixel(i + 33, j) == captureBitmap.GetPixel(i, j)){
                                    corner = true;
                                }
                            }
                            //Debug.WriteLine(i + ", " + j);
                        }
                        else
                        {
                            captureBitmap.SetPixel(i, j, pasada);
                        }
                        i++;
                    }
                    j++;
                    i = 0;
                }
                corner = false;
                i = 0;
                pasada = Color.FromArgb(0, 0, 0);
                while (!corner)
                {
                    if(captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1]+i) != captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i + 1)){
                        Debug.WriteLine("Actual: " + captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i) + "Siguiente: " + captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i + 1));
                        corner = true;
                        rightDownBalloon[1] = leftTopBalloon[1] + i;
                    }
                    else
                    {
                        captureBitmap.SetPixel(leftTopBalloon[0], leftTopBalloon[1] + i, pasada);
                    }
                    i++;
                }
                i = 0;
                corner = false;
                while (!corner)
                {
                    if (captureBitmap.GetPixel(leftTopBalloon[0] + i, rightDownBalloon[1]) != captureBitmap.GetPixel(leftTopBalloon[0] + i + 1, rightDownBalloon[1]))
                    {
                        corner = true;
                        rightDownBalloon[0] = leftTopBalloon[0] + i;
                    }
                    else
                    {
                        captureBitmap.SetPixel(leftTopBalloon[0] + i, rightDownBalloon[1], pasada);
                    }
                    i++;
                }
                int widthBalloon = rightDownBalloon[0] - leftTopBalloon[0];
                int heightBalloon = rightDownBalloon[1] - leftTopBalloon[1];
                colorPickerLabel.Text = "X: " + leftTopBalloon[0] + " Y: " + leftTopBalloon[1] + Environment.NewLine + "Height, Width: " +  captureBitmap.Height + ", " + captureBitmap.Width + Environment.NewLine + "Size: " + captureBitmap.Size + Environment.NewLine;

                // Capturing Balloon and saving
                //Point leftTopCornerBalloon = new Point(leftTopBalloon[0], leftTopBalloon[1]);
                Rectangle cropRectangleBalloon = new Rectangle(leftTopBalloon[0], leftTopBalloon[1], widthBalloon, heightBalloon);
                Bitmap captureBitmapCropped = new Bitmap(cropRectangleBalloon.Width, cropRectangleBalloon.Height, PixelFormat.Format32bppArgb);
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(captureBitmapCropped))
                {
                    g.DrawImage(captureBitmap, new Rectangle(0, 0, captureBitmapCropped.Width, captureBitmapCropped.Height),
                                     cropRectangleBalloon,
                                     GraphicsUnit.Pixel);
                }
                imagePickedBox.Image = captureBitmapCropped;
              
                colorPickerLabel.Text = "X: " + leftTopBalloon[0] + " Y: " + leftTopBalloon[1] + Environment.NewLine + "Height, Width: " +  captureBitmap.Height + ", " + captureBitmap.Width + Environment.NewLine + "Size: " + captureBitmap.Size + Environment.NewLine;


                captureBitmapCropped.Save("imageSaved.bmp");
                convertImageToText();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void CaptureMyScreen2(int xheight, int xwidth)

        {

            try
            {

                Bitmap captureBitmap = new Bitmap(xwidth, xheight, PixelFormat.Format32bppArgb);
                Point leftTopCorner = new Point(leftTop[0], leftTop[1]);
                Rectangle captureRectangle = new Rectangle(leftTopCorner, captureBitmap.Size);
                System.Drawing.Graphics captureGraphics = System.Drawing.Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                // Capturing image and saving
                //imagePickedBox.Image = captureBitmap;
                Color auxColor;
                int[] leftTopBalloon = { 0, 0 };
                int[] rightDownBalloon = { 0, 0 };
                int i = 0;
                int j = 0;
                bool corner = false;
                colorPickerLabel.Text = "Height, Width: " + captureBitmap.Height + ", " + captureBitmap.Width + Environment.NewLine + "Size: " + captureBitmap.Size + Environment.NewLine;
                imagePickedBox.Image = captureBitmap;
                Color pasada = Color.FromArgb(255, 244, 66, 66);
                while (!corner && j < captureBitmap.Height - 1)
                {
                    while (!corner && i < captureBitmap.Width - 1)
                    {
                        //Debug.WriteLine("J: " + j);
                        auxColor = captureBitmap.GetPixel(i, j);
                        if (auxColor == balloonColor)
                        {
                            if (leftTopBalloon[0] == 0 && leftTopBalloon[1] == 0)
                            {
                                leftTopBalloon[0] = i;
                                leftTopBalloon[1] = j;
                            }
                            else if (i < leftTopBalloon[0])
                            {
                                leftTopBalloon[0] = i;
                                leftTopBalloon[1] = j;
                            }
                            else if (captureBitmap.GetPixel(i, j - 3) == captureBitmap.GetPixel(i, j) && captureBitmap.GetPixel(i - 1, j) != captureBitmap.GetPixel(i, j))
                            {
                                corner = true;
                            }
                            //Debug.WriteLine(i + ", " + j);
                        }
                        else
                        {
                            captureBitmap.SetPixel(i, j, pasada);
                        }
                        i++;
                    }
                    j++;
                    i = 0;
                }
                corner = false;
                i = 0;
                pasada = Color.FromArgb(0, 0, 0);
                while (!corner)
                {
                    if (captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i) != captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i + 1))
                    {
                        Debug.WriteLine("Actual: " + captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i) + "Siguiente: " + captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i + 1));
                        corner = true;
                        rightDownBalloon[1] = leftTopBalloon[1] + i;
                    }
                    else
                    {
                        captureBitmap.SetPixel(leftTopBalloon[0], leftTopBalloon[1] + i, pasada);
                    }
                    i++;
                }
                i = 0;
                corner = false;
                while (!corner)
                {
                    if (captureBitmap.GetPixel(leftTopBalloon[0] + i, rightDownBalloon[1]) != captureBitmap.GetPixel(leftTopBalloon[0] + i + 1, rightDownBalloon[1]))
                    {
                        corner = true;
                        rightDownBalloon[0] = leftTopBalloon[0] + i;
                    }
                    else
                    {
                        captureBitmap.SetPixel(leftTopBalloon[0] + i, rightDownBalloon[1], pasada);
                    }
                    i++;
                }
                int widthBalloon = rightDownBalloon[0] - leftTopBalloon[0];
                int heightBalloon = rightDownBalloon[1] - leftTopBalloon[1];
                colorPickerLabel.Text = "X: " + leftTopBalloon[0] + " Y: " + leftTopBalloon[1] + Environment.NewLine + "Height, Width: " + captureBitmap.Height + ", " + captureBitmap.Width + Environment.NewLine + "Size: " + captureBitmap.Size + Environment.NewLine;

                // Capturing Balloon and saving
                //Point leftTopCornerBalloon = new Point(leftTopBalloon[0], leftTopBalloon[1]);
                Rectangle cropRectangleBalloon = new Rectangle(leftTopBalloon[0], leftTopBalloon[1], widthBalloon, heightBalloon);
                Bitmap captureBitmapCropped = new Bitmap(cropRectangleBalloon.Width, cropRectangleBalloon.Height, PixelFormat.Format32bppArgb);
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(captureBitmapCropped))
                {
                    g.DrawImage(captureBitmap, new Rectangle(0, 0, captureBitmapCropped.Width, captureBitmapCropped.Height),
                                     cropRectangleBalloon,
                                     GraphicsUnit.Pixel);
                }
                imagePickedBox.Image = captureBitmap;

                colorPickerLabel.Text = "X: " + leftTopBalloon[0] + " Y: " + leftTopBalloon[1] + Environment.NewLine + "Height, Width: " + captureBitmap.Height + ", " + captureBitmap.Width + Environment.NewLine + "Size: " + captureBitmap.Size + Environment.NewLine;


                captureBitmapCropped.Save("imageSaved.bmp");
                convertImageToText();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }


        private void cutBalloon()
        {
            

        }
        private void convertImageToText()
        {
            try
            {
                string dataPath = "./tessdata";
                string language = "eng";
                string inputFile = "./imageSaved.bmp";
                OcrEngineMode oem = OcrEngineMode.DEFAULT;
                PageSegmentationMode psm = PageSegmentationMode.AUTO_OSD;


                TessBaseAPI tessBaseAPI = new TessBaseAPI();

                if (!tessBaseAPI.Init(dataPath, language, oem))
                {
                    throw new Exception("Could not initialize tesseract.");
                }

                // Set the Page Segmentation mode
                tessBaseAPI.SetPageSegMode(psm);

                // Set the input image
                tessBaseAPI.SetImage(inputFile);

                // Recognize image
                tessBaseAPI.Recognize();

                ResultIterator resultIterator = tessBaseAPI.GetIterator();

                // Extract text from result iterator
                StringBuilder stringBuilder = new StringBuilder();
                PageIteratorLevel pageIteratorLevel = PageIteratorLevel.RIL_WORD;// RIL_PARA;
                do
                {
                    stringBuilder.Append(resultIterator.GetUTF8Text(pageIteratorLevel) + " ");
                } while (resultIterator.Next(pageIteratorLevel));

                tessBaseAPI.Dispose();
                textParsedBox.Text = stringBuilder.ToString().Trim();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void coordinatesButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.J && captureFirst)
            {
                leftTop[0] = MousePosition.X;
                leftTop[1] = MousePosition.Y;
                lefTopLabelContainer.Text = "X: " + leftTop[0] + " Y: " + leftTop[1];
                captureFirst = false;
                captureSecond = true;
                rightDownLabelContainer.Text = "K to capture";

            }
            if (e.KeyValue == (char)Keys.K && captureSecond)
            {
                rightDown[0] = MousePosition.X;
                rightDown[1] = MousePosition.Y;
                rightDownLabelContainer.Text = "X: " + rightDown[0] + " Y: " + rightDown[1];
                captureFirst = false;
                captureSecond = false;

            }
            if (e.KeyValue == (char)Keys.X && pickColor)
            {
                Rectangle bounds = Screen.GetBounds(Point.Empty);
                Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                balloonColor = bitmap.GetPixel(MousePosition.X, MousePosition.Y);
                pickColor = false;
                colorPickerLabel.Text = "R: " + balloonColor.R + " G: " + balloonColor.G + " B: " + balloonColor.B;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int width = rightDown[0] - leftTop[0];
            int height = rightDown[1] - leftTop[1];
            CaptureMyScreen2(height, width);
            /*OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(openFile.FileName);
                imagePickedBox.Image = img;
                var pix = PixConverter.ToPix(img);
                var ocr = new TesseractEngine("./tessdata", "eng");
                var page = ocr.Process(img);
                textParsedBox.Text = page.GetText();
            }*/
        }

        private void colorPickerButton_Click(object sender, EventArgs e)
        {
            pickColor = true;
            colorPickerLabel.Text = "X to capture color";
        }

        
        private void colorPickerButton_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyValue == (char)Keys.J && pickColor)
            {
                int mouseX = MousePosition.X;
                int mouseY = MousePosition.Y;

                Color pickedColor = 
                pickColor = false;
                rightDownLabelContainer.Text = "K to capture";

            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int width = rightDown[0] - leftTop[0];
            int height = rightDown[1] - leftTop[1];
            CaptureMyScreen(height, width);


            

        }
    }
}



