using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Text;
using System.Windows.Forms;
using Tesseract;
using System.Diagnostics;

namespace ParseApps
{
    class ImagesTreatment
    {

        private Point leftTop   = new Point(0, 0);
        private Point rightDown = new Point(0, 0);

        private Color balloonColor = Color.FromArgb(253, 253, 254);

        private String textParsed = "";
        
        private Bitmap imageResult;
        

        public ImagesTreatment()
        {

        }

        // Getters & Setters

        public Point GetLeftTop()
        {
            return leftTop;
        }
        public void SetLeftTop(int x, int y)
        {
            leftTop.X = x;
            leftTop.Y = y;
        }

        public Point GetRightDown()
        {
            return rightDown;
        }
        public void SetRightDown(int x, int y)
        {
            rightDown.X = x;
            rightDown.Y = y;
        }

        public Color GetBallonColor()
        {
            return balloonColor;
        }
        public void SetBalloonColor(Color picked)
        {
            balloonColor = picked;
        }

        public String GetTextParsed()
        {
            return textParsed;
        }

        public Bitmap GetImageResult()
        {
            return imageResult;
        }


        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        public void CaptureMyScreen()

        {
            try
            {

                Bitmap captureBitmap = new Bitmap(rightDown.X - leftTop.X, rightDown.Y - leftTop.Y, PixelFormat.Format32bppArgb);
                Point leftTopCorner = new Point(leftTop.X, leftTop.Y);
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
                //colorPickerLabel.Text = "Height, Width: " + captureBitmap.Height + ", " + captureBitmap.Width + Environment.NewLine + "Size: " + captureBitmap.Size + Environment.NewLine;
                //imagePickedBox.Image = captureBitmap;
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
                                captureBitmap.SetPixel(i, j, pasada);
                            }
                            else if (i < leftTopBalloon[0])
                            {
                                captureBitmap.SetPixel(leftTopBalloon[0], leftTopBalloon[1], pasada);
                                leftTopBalloon[0] = i;
                                leftTopBalloon[1] = j;
                            }
                            else if (captureBitmap.GetPixel(i, j - 3) == captureBitmap.GetPixel(i, j) && captureBitmap.GetPixel(i - 1, j) != captureBitmap.GetPixel(i, j))
                            {
                                if (captureBitmap.GetPixel(i + 115, j) == captureBitmap.GetPixel(i, j))
                                {
                                    leftTopBalloon[0] = i;
                                    leftTopBalloon[1] = j;
                                    corner = true;
                                }
                            }
                            else
                            {
                                captureBitmap.SetPixel(i, j, pasada);
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
                //imageResult = new Bitmap(captureBitmap);
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
                //colorPickerLabel.Text = "X: " + leftTopBalloon[0] + " Y: " + leftTopBalloon[1] + Environment.NewLine + "Height, Width: " + captureBitmap.Height + ", " + captureBitmap.Width + Environment.NewLine + "Size: " + captureBitmap.Size + Environment.NewLine;

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
                imageResult = new Bitmap(captureBitmap);
                //imageResult = new Bitmap(captureBitmapCropped);
                

                captureBitmapCropped.Save("imageSaved.bmp");
                ConvertImageToText();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                

            }


        }

        

        private void ConvertImageToText()
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
                textParsed = stringBuilder.ToString().Trim();
                //textParsedBox.Text = stringBuilder.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
