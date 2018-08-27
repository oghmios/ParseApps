using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ParseApps
{

    public partial class Form1 : Form
    {
        
        //KeyDown = new KeyEventHandler(this, keyboard_KeyDown);
        bool captureFirst           = false;
        bool captureSecond          = false;
        bool captureMousePosition   = false;
        bool pickColor              = false;
        bool optionsComing          = false;


        VirtualMouse myMouse = new VirtualMouse();

        ImagesTreatment myImage = new ImagesTreatment();

        FinalText myText = new FinalText();

        Characters myCharacters = new Characters();

        List<Button> charButtons = new List<Button>();

        String lineToAdd = "";
        

        delegate void SetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();
            charButtons.Add(youButton);
            charButtons.Add(narratorButton);
            charButtons.Add(charButton3);
            charButtons.Add(charButton4);
            charButtons.Add(charButton5);
            charButtons.Add(charButton6);
            charButtons.Add(charButton7);
            charButtons.Add(charButton8);
            charButtons.Add(charButton9);
            charButtons.Add(charButton10);
            charButtons.Add(charButton11);
            charButtons.Add(charButton12);
            charButtons.Add(charButton13);
            charButtons.Add(charButton14);
            charButtons.Add(charButton15);
            charButtons.Add(charButton16);
            charButtons.Add(charButton17);
            charButtons.Add(charButton18);
            charButtons.Add(charButton19);
            charButtons.Add(charButton20);
            
        }


        ////////////////////////Keyboard controls////////////////////////////////////
        private void CoordinatesButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.J && captureFirst)
            {
                myImage.SetLeftTop(MousePosition.X, MousePosition.Y);
                lefTopLabelContainer.Text = "X: " + myImage.GetLeftTop().X + " Y: " + myImage.GetLeftTop().Y;
                captureFirst = false;
                captureSecond = true;
                rightDownLabelContainer.Text = "K to capture";

            }
            if (e.KeyValue == (char)Keys.K && captureSecond)
            {
                myImage.SetRightDown(MousePosition.X, MousePosition.Y);
                rightDownLabelContainer.Text = "X: " + myImage.GetRightDown().X + " Y: " + myImage.GetRightDown().Y;
                captureFirst = false;
                captureSecond = false;

            }
            if (e.KeyValue == (char)Keys.K && captureMousePosition)
            {
                myMouse.SetMouseToClick(MousePosition.X, MousePosition.Y);
                mousePositionLabel.Text = "X: " + myMouse.GetMouseToClick().X + " Y: " + myMouse.GetMouseToClick().Y;
                captureMousePosition = false;

            }
            if (e.KeyValue == (char)Keys.X && pickColor)
            {
                Rectangle bounds = Screen.GetBounds(Point.Empty);
                Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                myImage.SetBalloonColor(bitmap.GetPixel(MousePosition.X, MousePosition.Y));
                pickColor = false;
                colorPickerLabel.Text = "R: " + myImage.GetBallonColor().R + " G: " + myImage.GetBallonColor().G + " B: " + myImage.GetBallonColor().B;

            }
        }

        private void CoordinatesButton_Click(object sender, EventArgs e)
        {
            captureFirst = true;
            lefTopLabelContainer.Text = "J to capture";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            textParsedBox.Text = myImage.GetTextParsed();
            imagePickedBox.Image = myImage.GetImageResult();
            /*myMouse.MoveTo();
            myMouse.LeftClick();*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            captureMousePosition = true;
            mousePositionLabel.Text = "Press K to capture";
        }
        private void colorPickerButton_Click(object sender, EventArgs e)
        {
            pickColor = true;
            colorPickerLabel.Text = "X to capture color";
        }

        private void addTextButton_Click(object sender, EventArgs e)
        {
            if (!optionsComing)
            {
                myText.SetFinalText(textParsedBox.Text);
                textParsedBox.Text = "";
                /*myMouse.MoveTo();
                myMouse.LeftClick();*/
            }
            else
            {
                myText.SetFinalText(choicesAndOptionsBox.Text);
                choicesAndOptionsBox.Text = "";
            }
        }



        

        private void addCharacterButton_Click(object sender, EventArgs e)
        {
            String charName = addCharacterBox.Text;
            bool insertedName = false;
            int i = 2;
            while (!insertedName)
            {
                if(charButtons[i].Text == "Char" + (i + 1).ToString())
                {
                    charButtons[i].Text = charName;
                    insertedName = true;
                }
                i++;
                if (i > 19)
                {
                    insertedName = true;
                    MessageBox.Show("You can not add more characters");
                }
            }
            addCharacterBox.Text = "";
        }

        /////////////////////////////Characters Buttons/////////////////////////////

        private void youButton_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[0].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void narratorButton_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[1].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton3_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[2].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton4_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[3].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton5_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[4].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }
        
        private void charButton6_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[5].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton7_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[6].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton8_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[7].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton9_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[8].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton10_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[9].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton11_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[10].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton12_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[11].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton13_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[12].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton14_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[13].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton15_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[14].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton16_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[15].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton17_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[16].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton18_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[17].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton19_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[18].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        private void charButton20_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + charButtons[19].Text + "; " + myImage.GetTextParsed();
            textParsedBox.Text = lineToAdd;
        }

        /////////////////////Choices & Options Buttons///////////////////////

        private void choiceButton_Click(object sender, EventArgs e)
        {
            myImage.CaptureMyScreen();
            lineToAdd = "; " + choiceButton.Text + "; " + myImage.GetTextParsed();
            optionsComing = true;
            choicesAndOptionsBox.Text = lineToAdd;
        }

        private void optionButton_Click(object sender, EventArgs e)
        {
            lineToAdd = "; " + optionButton.Text + "; ; ";
            choicesAndOptionsBox.Text = lineToAdd;
        }

        private void premiumOptionButton_Click(object sender, EventArgs e)
        {
            lineToAdd = "; Premium option ; ; " ;
            choicesAndOptionsBox.Text = lineToAdd;
        }

        private void finishOptionButton_Click(object sender, EventArgs e)
        {
            optionsComing = false;
            /*myMouse.MoveTo();
            myMouse.LeftClick();*/
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            myText.saveAndClose();
            MessageBox.Show("Saved");
        }

        private void choicesLabel_Click(object sender, EventArgs e)
        {

        }
    }
}



