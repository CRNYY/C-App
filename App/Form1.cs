﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Size WindowSize;
        public bool OpenedLeftSideMenu = true;
        public bool OpenedRandomImages = true;
        public bool OpenedCapture = false;
        public Size OpenedMenuMainButtonSize = new Size(95, 30);
        public Size ClosedmenuMainButtonSize = new Size(35, 30);
        public Size OpenedMenuPanelSize = new Size(100, 450);
        public Size ClosedMenuPanelSize = new Size(40, 450);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
                if (WindowSize != Form1.ActiveForm.Size)
                    WindowSize = Form1.ActiveForm.Size;
            }catch(Exception ex) { }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if(!OpenedLeftSideMenu)
            {
                //Buttons
                buttonMenu.Size = ClosedmenuMainButtonSize;
                buttonRandomImages.Size = ClosedmenuMainButtonSize;
                buttonCapture.Size = ClosedmenuMainButtonSize;
                button3.Size = ClosedmenuMainButtonSize;
                //Panels
                LeftSideMenuPanel.Size = ClosedMenuPanelSize;
                //Bools
                OpenedLeftSideMenu = true;
            }
            else
            {
                //Buttons
                buttonMenu.Size = OpenedMenuMainButtonSize;
                buttonRandomImages.Size = OpenedMenuMainButtonSize;
                buttonCapture.Size = OpenedMenuMainButtonSize;
                button3.Size = OpenedMenuMainButtonSize;
                //Panels
                LeftSideMenuPanel.Size = OpenedMenuPanelSize;
                //Bools
                OpenedLeftSideMenu = false;
            }
        }

        private void buttonRandomImages_Click(object sender, EventArgs e)
        {
            if (OpenedRandomImages)
            {
                ucRandomImages1.Show();
                capture1.Hide();
                OpenedRandomImages = false;
            }
            else
            {
                ucRandomImages1.Hide();
                capture1.Hide();
                OpenedRandomImages = true;
            }
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            if (OpenedCapture)
            {
                ucRandomImages1.Hide();
                capture1.Show();
                OpenedCapture = false;
            }
            else
            {
                ucRandomImages1.Hide();
                capture1.Hide();
                OpenedCapture = true;
            }
        }
    }
}
