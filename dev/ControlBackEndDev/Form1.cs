﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlBackEndDev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spControl1.Plot.AddSignal(ScottPlot.DataGen.Sin(51));
            spControl1.Plot.AddSignal(ScottPlot.DataGen.Cos(51));

            var vLine = spControl1.Plot.AddVerticalLine(23);
            vLine.DragEnabled = true;

            var vSpan = spControl1.Plot.AddVerticalSpan(-.5, .5);
            vSpan.DragEnabled = true;

            spControl1.Render();
        }
    }
}
