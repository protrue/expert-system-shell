using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Gui
{
    public partial class DomainForm : Form
    {
        public IndexedList<Domain> AllDomains { get; set; }
        public Domain DomainToEdit { get; set; }

        public DomainForm()
        {
            InitializeComponent();
        }

        private bool TrySetIndexedNamedItem(Action setAction)
        {
            var isSuccess = false;

            try
            {
                setAction.Invoke();
                isSuccess = true;
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                MessageBox.Show(argumentOutOfRangeException.Message);
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
            }

            return isSuccess;
        }

        private void DomainForm_Load(object sender, EventArgs e)
        {
            if (AllDomains == null)
                AllDomains = new IndexedList<Domain>();

            if (DomainToEdit == null)
                DomainToEdit = new Domain($"Домен {AllDomains.Count + 1}");

            textBoxName.Text = DomainToEdit.Name;
            foreach (var item in DomainToEdit.Values)
                listBoxValues.Items.Add(item);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var domainValue = new IndexedNamedItem(textBoxValue.Text);
            //    DomainToEdit.Values.Add(domainValue);
            //    listBoxValues.Items.Add(domainValue);
            //}
            //catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            //{
            //    MessageBox.Show(argumentOutOfRangeException.Message);
            //}
            //catch (ArgumentException argumentException)
            //{
            //    MessageBox.Show(argumentException.Message);
            //}

            TrySetIndexedNamedItem(() =>
            {
                var domainValue = new IndexedNamedItem(textBoxValue.Text);
                DomainToEdit.Values.Add(domainValue);
                listBoxValues.Items.Add(domainValue);
            });
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxValues.SelectedIndex;
            if (selectedIndex < 0)
                return;

            TrySetIndexedNamedItem(() =>
            {
                DomainToEdit.Values[selectedIndex].Name = textBoxValue.Text;
                listBoxValues.Items[selectedIndex] = DomainToEdit.Values[selectedIndex];
            });

            //try
            //{
            //    DomainToEdit.Values[selectedIndex].Name = textBoxValue.Text;
            //    listBoxValues.Items[selectedIndex] = DomainToEdit.Values[selectedIndex];
            //}
            //catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            //{
            //    MessageBox.Show(argumentOutOfRangeException.Message);
            //}
            //catch (ArgumentException argumentException)
            //{
            //    MessageBox.Show(argumentException.Message);
            //}
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxValues.SelectedIndex;
            DomainToEdit.Values.Delete(selectedIndex);
            listBoxValues.Items.RemoveAt(selectedIndex);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (AllDomains.Contains(DomainToEdit))
                return;

            try
            {
                AllDomains.Add(DomainToEdit);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listBoxValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxValues.SelectedIndex < 0)
                return;

            textBoxValue.Text = listBoxValues.SelectedItem.ToString();
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            try
            {
                DomainToEdit.Name = textBoxName.Text;
            }
            catch (Exception exception)
            {
                textBoxName.Text = DomainToEdit.Name;
                textBoxName.Select();
                textBoxName.Focus();
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
