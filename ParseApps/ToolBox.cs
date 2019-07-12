using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseApps
{
    public partial class ToolBox : Form
    {
        bool optionsComing = false;


        public static VirtualMouse myMouse;

        public static ImagesTreatment myImage;

        FinalText myText = new FinalText();

        Characters myCharacters = new Characters();

        DebugWindow myDebug = new DebugWindow();

        ReassignWindow myReAssign = new ReassignWindow();

        Point actualPosMouse = new Point(0, 0);



        public List<Button> charButtons = new List<Button>();

        public String lineToAdd = "";

        public static ImageDebug imageDebugForm = new ImageDebug();

        public ToolBox(Point leftTop, Point rightDown, Point mouse, Color picked)
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

            myMouse = new VirtualMouse(mouse);
            myImage = new ImagesTreatment(leftTop, rightDown, picked);
        }

        

        private void AddTextButton_Click(object sender, EventArgs e)
        {
            if (!optionsComing)
            {
                myText.SetFinalText(textParsedBox.Text);
                textParsedBox.Text = "";
                actualPosMouse = Cursor.Position;
                Cursor.Position = myMouse.GetMouseToClick();
                myMouse.LeftClick();
                myMouse.LeftClick();
                Cursor.Position = actualPosMouse;
            }
            else
            {
                myText.SetFinalText(choicesAndOptionsBox.Text);
                choicesAndOptionsBox.Text = "";
                
            }
        }

        private void AddCharacterButton_Click(object sender, EventArgs e)
        {
            String charName = addCharacterBox.Text;
            bool insertedName = false;
            int i = 2;
            while (!insertedName)
            {
                if (charButtons[i].Text == "Char" + (i + 1).ToString())
                {
                    charButtons[i].Text = charName;
                    insertedName = true;
                    removeCharInput.Items.Add(charName);
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
            lineToAdd = "; Premium option ; ; ";
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

        private void debugButton_Click(object sender, EventArgs e)
        {
            if(!myDebug.IsHandleCreated)
            {
                myDebug = new DebugWindow();
            }

            
            myDebug.Show();
        }

        private void reasignButton_Click(object sender, EventArgs e)
        {
            if (!myReAssign.IsHandleCreated)
            {
                myReAssign = new ReassignWindow();
            }
            
            myReAssign.Show();
        }

        private void removeCharButton_Click(object sender, EventArgs e)
        {
            String charToRemove = removeCharInput.Text;
            bool insertedName = false;
            int i = 2;
            while (!insertedName)
            {
                if (charButtons[i].Text == charToRemove)
                {
                    charButtons[i].Text = "Char" + (i + 1).ToString();
                    removeCharInput.Items.Remove(removeCharInput.Text);
                    removeCharInput.DownButton();
                    insertedName = true;
                    
                }
                i++;
                if (i > 19)
                {
                    insertedName = true;
                    MessageBox.Show(charToRemove + " doesn't exist");
                }
            }
            
        }
    }
}
