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
            InitializeComponent();

            table = dt;
            yearComboBox.Items.Add("Dodaj nowy");
            foreach (Object item in combo)
            {
                yearComboBox.Items.Add(item);
            }
        }

        private void numberTBox_Click(object sender, EventArgs e)
        {
            int value=0;
            CustomData tempTable = new CustomData();
            tempTable.yearName = yearComboBox.Text;
            tempTable.loadData();
            foreach(DataRow row in tempTable.get().Rows)
            {
                if (int.Parse(row[0].ToString()) > value)
                    value = int.Parse(row[0].ToString());
            }
            value++;
            numberTBox.Text = value.ToString();
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yearComboBox.SelectedIndex == yearComboBox.Items.Count-1)
            {
                AskForStringDIalog dialog = new AskForStringDIalog();
                dialog.ShowDialog(this);
                if(dialog.DialogResult == DialogResult.OK)
                {
                    yearComboBox.Items.Add(dialog.get());
                    yearComboBox.SelectedText = dialog.get();
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public string[] get()
        {
            string[] arr = new string[4];
            arr[0] = yearComboBox.Text;
            arr[1] = kergTBox.Text;
            arr[2] = numberTBox.Text;
            arr[3] = iloscSzkicyTBox.Text;
            return arr;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
