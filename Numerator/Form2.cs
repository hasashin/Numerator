using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerator
{
    public partial class NewDialog : Form
    {
        private DataTable table;
        public NewDialog(ComboBox.ObjectCollection combo ,DataTable dt)
        {
            table = dt;
            foreach(Object item in combo)
            {
                yearComboBox.Items.Add(item);
            }
            yearComboBox.Items.Add("Dodaj nowy");
            
            InitializeComponent();
        }

        private void numberTBox_Click(object sender, EventArgs e)
        {
            
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yearComboBox.SelectedIndex == yearComboBox.Items.Count - 1)
            {
                
            }
        }
    }
}
