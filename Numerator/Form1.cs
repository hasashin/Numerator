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
            yearSelectComboBox.Items.Clear();
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Data"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Data");
            }
            string[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\Data");
            foreach (string file in files)
            {
                if (file.EndsWith(".bin"))
                {
                    string newfile = file.Replace(Environment.CurrentDirectory + "\\Data\\", "");
                    yearSelectComboBox.Items.Add(newfile.Substring(0, newfile.IndexOf('.')));
                }
            }
            if (yearSelectComboBox.Items.Count > 0)
            {
                try
                {
                    yearSelectComboBox.SelectedIndex = yearSelectComboBox.Items.IndexOf(dane.yearName);
                }
                catch
                {
                    yearSelectComboBox.SelectedIndex = 0;
                }
            }
        }

        public Numerator()
        {
            InitializeComponent();
            loadYears();
            dataGrid.AutoGenerateColumns = true;
            BindData(dane.get());
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
            if(!string.IsNullOrEmpty(dane.yearName)) dane.saveData();
            dane.yearName = yearSelectComboBox.Text;
            dane.loadData();
            BindData(dane.get());
        }

        private void addNumer_Click(object sender, EventArgs e)
        {
            NewDialog dlg = new NewDialog(yearSelectComboBox.Items, dane.get());
            DialogResult res = dlg.ShowDialog(this);

            if (res == DialogResult.OK)
            {
                if (dlg.get()[0] == dane.yearName)
                {
                    dane.AddNew(dlg.get());
                }
                else
                {
                    dane.saveData();
                    dane.Clean();
                    dane.yearName = dlg.get()[0];
                    dane.loadData();
                    dane.AddNew(dlg.get());

                }
                dane.saveData();
                loadYears();
                BindData(dane.get());
            }
        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dane.saveData();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteNumer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this,  "Jesteś pewny, że chcesz usunąć dane z roku " + dane.yearName + "?", "Czy jesteś pewny?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                File.Delete(Environment.CurrentDirectory + "\\Dane\\" + dane.yearName + ".bin");
                MessageBox.Show(this, "Usunięto", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dane.yearName = null;
                loadYears();
            }
        }
    }
}
