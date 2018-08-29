using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ParseApps
{

    public partial class MainParseApps : Form
    {
        
        //KeyDown = new KeyEventHandler(this, keyboard_KeyDown);
        bool captureFirst           = false;
        bool captureSecond          = false;
        bool captureMousePosition   = false;
        bool pickColor              = false;


        ImageDebug imageDebugForm = new ImageDebug();

        Point leftTop = new Point(0, 0);
        Point rightDown = new Point(0, 0);
        Point mouse = new Point(0, 0);
        Color picked = Color.FromArgb(253, 253, 254);
        

        

        delegate void SetTextCallback(string text);
        public MainParseApps()
        {
            InitializeComponent();
            
            
        }


        ////////////////////////Keyboard controls////////////////////////////////////
        private void CoordinatesButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.J && captureFirst)
            {
                leftTop.X = MousePosition.X;
                leftTop.Y = MousePosition.Y;
                lefTopLabelContainer.Text = "X: " + leftTop.X + " Y: " + leftTop.Y;
                captureFirst = false;
                captureSecond = true;
                rightDownLabelContainer.Text = "K to capture";

            }
            if (e.KeyValue == (char)Keys.K && captureSecond)
            {
                rightDown.X = MousePosition.X;
                rightDown.Y = MousePosition.Y;
                rightDownLabelContainer.Text = "X: " + rightDown.X + " Y: " + rightDown.Y;
                captureFirst = false;
                captureSecond = false;

            }
            if (e.KeyValue == (char)Keys.K && captureMousePosition)
            {
                mouse.X = MousePosition.X;
                mouse.Y = MousePosition.Y;
                mousePositionLabel.Text = "X: " + mouse.X + " Y: " + mouse.Y;
                captureMousePosition = false;

            }
            if (e.KeyValue == (char)Keys.X && pickColor)
            {
                Rectangle bounds = Screen.GetBounds(Point.Empty);
                Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                picked = bitmap.GetPixel(MousePosition.X, MousePosition.Y);
                //myImage.SetBalloonColor(bitmap.GetPixel(MousePosition.X, MousePosition.Y));
                pickColor = false;
                colorPickerLabel.Text = "R: " + picked.R + " G: " + picked.G + " B: " + picked.B;

            }
        }

        private void CoordinatesButton_Click(object sender, EventArgs e)
        {
            captureFirst = true;
            lefTopLabelContainer.Text = "J to capture";

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

        private void startButton_Click(object sender, EventArgs e)
        {
            if(leftTop.X == 0 || rightDown.X == 0 || mouse.X == 0 || picked.R == 0)
            {
                MessageBox.Show("Some option is not selected");
            }
            else
            {
                ToolBox myTool = new ToolBox(leftTop, rightDown, mouse, picked);
                myTool.Show();
                this.Hide();
                myTool.FormClosed += MyTool_FormClosed;

            }
        }

        private void MyTool_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            //throw new NotImplementedException();
        }
    }
}



