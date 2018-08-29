using System;
using System.Windows.Forms;

namespace ParseApps{

    public partial class DebugWindow : Form{

        public DebugWindow(){

            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e){

            ToolBox.myImage.CaptureMyScreenDebug();
            textParsedBox.Text = ToolBox.myImage.GetTextParsed();

            if (!ToolBox.imageDebugForm.IsHandleCreated){

                ToolBox.imageDebugForm = new ImageDebug();

            }

            ToolBox.imageDebugForm.Show();
            ToolBox.imageDebugForm.debugImageBox.Image = ToolBox.myImage.GetImageResult();
            /*myMouse.MoveTo();
            myMouse.LeftClick();*/

        }

        private void captureDebugButton_Click(object sender, EventArgs e){

            ToolBox.myImage.CaptureMyScreen();
            textParsedBox.Text = ToolBox.myImage.GetTextParsed();

            if (!ToolBox.imageDebugForm.IsHandleCreated){

                ToolBox.imageDebugForm = new ImageDebug();

            }

            ToolBox.imageDebugForm.Show();
            ToolBox.imageDebugForm.debugImageBox.Image = ToolBox.myImage.GetImageResult();

        }
    }
}
