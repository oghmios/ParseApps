﻿using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Text;
using System.Windows.Forms;
using Tesseract;

namespace ParseApps{

    public class ImagesTreatment{

        private Point leftTop;  
        private Point rightDown; 
        private Color balloonColor = Color.FromArgb(253, 253, 254);
        private String textParsed = "";
        private Bitmap imageResult;

        public ImagesTreatment(){

        }

        public ImagesTreatment(Point leftTop, Point rightDown, Color picked){

            this.leftTop = new Point(leftTop.X, leftTop.Y);
            this.rightDown = new Point(rightDown.X, rightDown.Y);
            balloonColor = picked;

        }

        // Getters & Setters

        public Point GetRightDown(){

            return rightDown;

        }

        public void SetRightDown(int x, int y){

            rightDown.X = x;
            rightDown.Y = y;

        }

        public Point GetLeftTop(){

            return leftTop;

        }

        public void SetLeftTop(int x, int y){

            leftTop.X = x;
            leftTop.Y = y;

        }

        public Color GetBallonColor(){

            return balloonColor;

        }

        public void SetBalloonColor(Color picked){

            balloonColor = picked;

        }

        public String GetTextParsed(){

            return textParsed;

        }

        public Bitmap GetImageResult(){

            return imageResult;

        }

        private void ConvertImageToText(){

            try{

                string dataPath = "./tessdata";
                string language = "eng";
                string inputFile = "./imageSaved.bmp";
                OcrEngineMode oem = OcrEngineMode.DEFAULT;
                PageSegmentationMode psm = PageSegmentationMode.AUTO_OSD;

                TessBaseAPI tessBaseAPI = new TessBaseAPI();

                if (!tessBaseAPI.Init(dataPath, language, oem)){

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

                do{

                    stringBuilder.Append(resultIterator.GetUTF8Text(pageIteratorLevel) + " ");

                } while (resultIterator.Next(pageIteratorLevel));

                tessBaseAPI.Dispose();
                textParsed = stringBuilder.ToString().Trim();
                //textParsedBox.Text = stringBuilder.ToString().Trim();

            } catch (Exception ex){

                MessageBox.Show(ex.Message);

            }

        }

        public Object[] CaptureDialogBalloon(Bitmap captureBitmap){

            Object[] result = new Object[3];

            //imagePickedBox.Image = captureBitmap;
            Color auxColor;
            int[] leftTopBalloon = { 0, 0 };
            int[] rightDownBalloon = { 0, 0 };
            int i = 0;
            int j = 0;
            int k = 0;
            bool lineSearch = false;
            bool corner = false;

            //colorPickerLabel.Text = "Height, Width: " + captureBitmap.Height + ", " + captureBitmap.Width + Environment.NewLine + "Size: " + captureBitmap.Size + Environment.NewLine;
            //imagePickedBox.Image = captureBitmap;
            Color pasada = Color.FromArgb(255, 244, 66, 66);

            while (!corner && j < captureBitmap.Height - 1){

                while (!corner && i < captureBitmap.Width - 1){

                    //Debug.WriteLine("J: " + j);
                    auxColor = captureBitmap.GetPixel(i, j);

                    if (auxColor == balloonColor){

                        if (leftTopBalloon[0] == 0 && leftTopBalloon[1] == 0){

                            leftTopBalloon[0] = i;
                            leftTopBalloon[1] = j;
                            captureBitmap.SetPixel(i, j, pasada);

                        }

                        if (i < leftTopBalloon[0]){

                            captureBitmap.SetPixel(leftTopBalloon[0], leftTopBalloon[1], pasada);
                            leftTopBalloon[0] = i;
                            leftTopBalloon[1] = j;

                        } else {

                            while (!lineSearch && k < 125){

                                if (captureBitmap.GetPixel(i + k, j) != captureBitmap.GetPixel(i, j)){

                                    lineSearch = true;

                                } else {

                                    k++;

                                }

                            }

                            if (lineSearch){

                                captureBitmap.SetPixel(leftTopBalloon[0], leftTopBalloon[1], pasada);
                                k = 0;
                                j++;
                                i = 0;
                                lineSearch = false;

                            } else {

                                leftTopBalloon[0] = i;
                                leftTopBalloon[1] = j;
                                corner = true;

                            }

                        }

                        //Debug.WriteLine(i + ", " + j);

                    } else {

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
            j = 0;
            pasada = Color.FromArgb(0, 0, 0);

            while (!corner){

                if (captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i) != captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i + 1)){

                    if (leftTopBalloon[1] + 40 > leftTopBalloon[1] + i){

                        leftTopBalloon[0] = leftTopBalloon[0] + 5;
                        i = 0;

                    } else if (captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i) == captureBitmap.GetPixel(leftTopBalloon[0] + 5, leftTopBalloon[1] + i + 5)){

                        leftTopBalloon[0] = leftTopBalloon[0] + 5;
                        i = 0;

                    } else {

                        corner = true;
                        rightDownBalloon[1] = leftTopBalloon[1] + i;

                    }

                    //Debug.WriteLine("Actual: " + captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i) + "Siguiente: " + captureBitmap.GetPixel(leftTopBalloon[0], leftTopBalloon[1] + i + 1));

                } else {

                    captureBitmap.SetPixel(leftTopBalloon[0], leftTopBalloon[1] + i, pasada);

                }

                i++;

            }

            i = 0;
            corner = false;

            while (!corner){

                if (captureBitmap.GetPixel(leftTopBalloon[0] + i, rightDownBalloon[1]) != captureBitmap.GetPixel(leftTopBalloon[0] + i + 1, rightDownBalloon[1])){

                    if (leftTopBalloon[0] + 40 > leftTopBalloon[0] + i){

                        rightDownBalloon[1] = rightDownBalloon[1] - 5;
                        i = 0;

                    } else {

                        corner = true;
                        rightDownBalloon[0] = leftTopBalloon[0] + i;

                    }

                } else {

                    captureBitmap.SetPixel(leftTopBalloon[0] + i, rightDownBalloon[1], pasada);

                }

                i++;

            }

            result[0] = captureBitmap;
            result[1] = leftTopBalloon;
            result[2] = rightDownBalloon;

            return result;
        }

        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]

        public void CaptureMyScreen(){

            try{

                Bitmap captureBitmap = new Bitmap(rightDown.X - leftTop.X, rightDown.Y - leftTop.Y, PixelFormat.Format32bppArgb);
                Point leftTopCorner = new Point(leftTop.X, leftTop.Y);
                Rectangle captureRectangle = new Rectangle(leftTopCorner, captureBitmap.Size);
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                // Capturing image and saving
                Object[] resultDialogBallon = CaptureDialogBalloon(captureBitmap);

                captureBitmap = (Bitmap) resultDialogBallon[0];
                int[] leftTopBalloon = (int[]) resultDialogBallon[1];
                int[] rightDownBalloon = (int[]) resultDialogBallon[2];

                int widthBalloon = rightDownBalloon[0] - leftTopBalloon[0];
                int heightBalloon = rightDownBalloon[1] - leftTopBalloon[1];
                //colorPickerLabel.Text = "X: " + leftTopBalloon[0] + " Y: " + leftTopBalloon[1] + Environment.NewLine + "Height, Width: " + captureBitmap.Height + ", " + captureBitmap.Width + Environment.NewLine + "Size: " + captureBitmap.Size + Environment.NewLine;

                // Capturing Balloon and saving
                //Point leftTopCornerBalloon = new Point(leftTopBalloon[0], leftTopBalloon[1]);
                Rectangle cropRectangleBalloon = new Rectangle(leftTopBalloon[0], leftTopBalloon[1], widthBalloon, heightBalloon);
                Bitmap captureBitmapCropped = new Bitmap(cropRectangleBalloon.Width, cropRectangleBalloon.Height, PixelFormat.Format32bppArgb);

                using (Graphics g = Graphics.FromImage(captureBitmapCropped)){

                    g.DrawImage(captureBitmap, new Rectangle(0, 0, captureBitmapCropped.Width, captureBitmapCropped.Height),
                                     cropRectangleBalloon,
                                     GraphicsUnit.Pixel);

                }
                
                //imageResult = new Bitmap(captureBitmap);
                imageResult = new Bitmap(captureBitmapCropped);
                
                captureBitmapCropped.Save("imageSaved.bmp");
                ConvertImageToText();

            } catch (Exception ex){

                MessageBox.Show(ex.Message);
                
            }

        }

    }
}
