using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Gui
{
    public partial class VariableForm : Form
    {
        public IndexedList<Variable> Variables { get; set; }
        public Variable Variable { get; set; }

        public VariableForm()
        {
            InitializeComponent();
        }

        private void VariableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
