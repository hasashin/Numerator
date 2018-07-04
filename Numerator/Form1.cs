using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerator
{
    public partial class Numerator : Form
    {
        private CustomData dane = new CustomData();
        private void loadYears()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Data"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Data");
            }
            string[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\Data");
            foreach (string file in files)
            {
                if (file.EndsWith(".db"))
                {
                    string newfile = file.Replace(Environment.CurrentDirectory + "\\Data", "");
                    yearSelectComboBox.Items.Add(file.Substring(0, newfile.IndexOf('.')));
                }
            }
            if (yearSelectComboBox.Items.Count > 0)
                yearSelectComboBox.SelectedIndex = 0;
        }

        public Numerator()
        {
            InitializeComponent();
            loadYears();
            dataGrid.DataSource = dane.get();
            dataGrid.AutoGenerateColumns = true;
        }

        private void fillGrid()
        {
            DataTable table = dane.get();
            foreach(DataRow row in table.AsEnumerable())
            {
                dataGrid.Rows.Add(row[0], row[1]);
            }
        }

        private void BindData(DataTable dt)
        {
            dataGrid.Columns.Clear();
            BindingSource bindingSource = new BindingSource
            {
                DataSource = dt
            };
            dataGrid.DataSource = bindingSource;
        }

        private void yearSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dane.saveData();
            dane.yearName = yearSelectComboBox.SelectedText;
            dane.loadData();
            fillGrid();
        }

        private void addNumer_Click(object sender, EventArgs e)
        {
            NewDialog dlg = new NewDialog(yearSelectComboBox.Items, dane.get());
            dlg.ShowDialog(this);
            if(dlg.DialogResult == DialogResult.OK)
            {
                dane.AddNew(dlg.get());
            }
            BindData(dane.get());
            yearSelectComboBox.SelectedText = dane.yearName;
        }
    }
}
