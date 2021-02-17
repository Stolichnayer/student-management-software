﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;

// TODO: Disabled Fields and enabled with Add and Edit button
// TODO: Paging
// TODO: Refresh
// TODO: Search
// TODO: first column numbers

namespace student_management_system.Forms
{
    public partial class MainForm : Form
    {
        private Panel _leftBorderPanel;
        private IconButton _focusedButton;
        private Form _activeForm;

        public MainForm()
        {
            InitializeComponent();
            CreateButtonFocusBorder();

            //Draw round borders
             Region = Region.
                FromHrgn(CreateRoundRectRgn(0, 0, 
                                            Width, Height, 
                                            20, 20));
             DoubleBuffered = true;
        }

        private void CreateButtonFocusBorder()
        {
            _leftBorderPanel = new Panel();
            _leftBorderPanel.Size = new Size(4, 52);
            panelMenu.Controls.Add(_leftBorderPanel);

        }

        //Native Windows dll function to make Form with rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     //x-coordinate of upper-left corner
            int nTopRect,      //y-coordinate of upper-left corner
            int nRightRect,    //x-coordinate of lower-right corner
            int nBottomRect,   //y-coordinate of lower-right corner
            int nWidthEllipse, //width of ellipse
            int nHeightEllipse //height of ellipse
        );

        private void FocusButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                UnfocusFocusedButton();

                //Button Propeties
                _focusedButton = (IconButton) senderBtn;
                _focusedButton.BackColor = Color.FromArgb(37, 36, 81);
                _focusedButton.ForeColor = color;
                _focusedButton.IconColor = color;

                //Left Border Panel Properties
                _leftBorderPanel.BackColor = color;
                _leftBorderPanel.Location = new Point(0, _focusedButton.Location.Y);
                _leftBorderPanel.Visible = true;
                _leftBorderPanel.BringToFront();
            }
        }

        private void UnfocusFocusedButton()
        {
            if (_focusedButton != null)
            {
                _focusedButton.BackColor = Color.FromArgb(31, 30, 68);
                _focusedButton.ForeColor = Color.Gainsboro;
                _focusedButton.IconColor = Color.Gainsboro;
            }
        }


        private void iconBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconBtnStudents_Click(object sender, EventArgs e)
        {
            FocusButton(sender, Color.LightSalmon);

            if (_activeForm is StudentsForm studentsForm)
                return;

            _activeForm = new StudentsForm();
            _activeForm.TopLevel = false;
            panelMain.Controls.Add(_activeForm);
            _activeForm.BringToFront();
            _activeForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _activeForm.Dock = DockStyle.Fill;
            _activeForm.Show();
        }

        private void iconBtnCourses_Click(object sender, EventArgs e)
        {
            FocusButton(sender, Color.LightSalmon);
        }

        private void iconBtnSomething_Click(object sender, EventArgs e)
        {
            FocusButton(sender, Color.LightSalmon);
        }

        private void iconBtnSettings_Click(object sender, EventArgs e)
        {
            FocusButton(sender, Color.LightSalmon);
        }
        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconBtnTitleBarMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconBtnTitlebarMaximize_Click(object sender, EventArgs e)
        {
            
            if (WindowState == FormWindowState.Maximized)
            {
                //Restore
                WindowState = FormWindowState.Normal;
                Region = Region.
                    FromHrgn(CreateRoundRectRgn
                    (0, 0, Width,
                        Height, 20, 20));
            }
            else
            {
                //Maximize
                WindowState = FormWindowState.Maximized;
                Region = Region.
                    FromHrgn(CreateRoundRectRgn
                    (0, 0, Screen.PrimaryScreen.WorkingArea.Width,
                        Screen.PrimaryScreen.WorkingArea.Height, 20, 20));
            }
        }

        //Add Drag Operation to titlebar
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}