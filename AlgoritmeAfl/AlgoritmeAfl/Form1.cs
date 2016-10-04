﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmeAfl
{
    public partial class Form1 : Form
    {
        private GridManager visualManager;
        public Form1()
        {
            InitializeComponent();

            ClientSize = new Size(800,800);

            visualManager = new GridManager(CreateGraphics(),this.DisplayRectangle);
        }


        private void Loop_Tick(object sender, EventArgs e)
        {
            visualManager.Render();
        }
    }
}
