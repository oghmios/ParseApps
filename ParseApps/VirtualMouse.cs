using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ParseApps
{
    public class VirtualMouse
    {
        private Point mouseToClick = new Point(0, 0);

        public VirtualMouse()
        {

        }



        // Getters & Setters

        public Point GetMouseToClick()
        {
            return mouseToClick;
        }
        public void SetMouseToClick(int x, int y)
        {
            mouseToClick.X = x;
            mouseToClick.Y = y;
        }



        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public static void Move(int xDelta, int yDelta)
        {
            mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
        }
        public void MoveTo()
        {
            mouse_event(MOUSEEVENTF_MOVE, mouseToClick.X, mouseToClick.Y, 0, 0);
        }
        public void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        public void LeftDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, mouseToClick.X, mouseToClick.Y, 0, 0);
        }

        public void LeftUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, mouseToClick.X, mouseToClick.Y, 0, 0);
        }

        public void RightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, mouseToClick.X, mouseToClick.Y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, mouseToClick.X, mouseToClick.Y, 0, 0);
        }

        public void RightDown()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, mouseToClick.X, mouseToClick.Y, 0, 0);
        }

        public void RightUp()
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, mouseToClick.X, mouseToClick.Y, 0, 0);
        }
    }
}
