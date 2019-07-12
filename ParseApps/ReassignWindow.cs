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
    public partial class ReassignWindow : Form
    {
        bool captureFirst = false;
        bool captureSecond = false;
        bool captureMousePosition = false;
        bool pickColor = false;
        

        Point leftTop = new Point(0, 0);
        Point rightDown = new Point(0, 0);
        Point mouse = new Point(0, 0);
        Color picked = Color.FromArgb(253, 253, 254);

        public ReassignWindow()
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
                ToolBox.myImage.SetLeftTop(leftTop.X, leftTop.Y);

            }
            if (e.KeyValue == (char)Keys.K && captureSecond)
            {
                rightDown.X = MousePosition.X;
                rightDown.Y = MousePosition.Y;
                rightDownLabelContainer.Text = "X: " + rightDown.X + " Y: " + rightDown.Y;
                captureFirst = false;
                captureSecond = false;
                ToolBox.myImage.SetRightDown(rightDown.X, rightDown.Y);


            }
            if (e.KeyValue == (char)Keys.K && captureMousePosition)
            {
                mouse.X = MousePosition.X;
                mouse.Y = MousePosition.Y;
                mousePositionLabel.Text = "X: " + mouse.X + " Y: " + mouse.Y;
                captureMousePosition = false;
                ToolBox.myMouse.SetMouseToClick(mouse.X, mouse.Y);

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
                ToolBox.myImage.SetBalloonColor(picked);

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
            if (leftTop.X == 0 || rightDown.X == 0 || mouse.X == 0 || picked.R == 0)
            {
                MessageBox.Show("Some option is not selected");
            }
            else
            {
                ToolBox myTool = new ToolBox(leftTop, rightDown, mouse, picked);
                myTool.Show();
                this.Hide();

            }
        }
    }
}
