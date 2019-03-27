﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystemShell.Core;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Gui
{
    public partial class MainForm : Form
    {
        public KnowledgeBase KnowledgeBase { get; set; }

        public MainForm()
        {
            InitializeComponent();
            var form = new DomainForm();            
            form.ShowDialog();
        }
    }
}
