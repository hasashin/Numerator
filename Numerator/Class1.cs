using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


namespace Numerator
{
    class CustomData
    {
        private DataTable dt;
        public string yearName { get; set; }

        public CustomData()
        {
            dt = new DataTable();
            PrepareDataTable();
        }

        public CustomData(string year)
        {
            yearName = year;
            dt = new DataTable();
            PrepareDataTable();
        }

        private void PrepareDataTable()
        {
            dt.Clear();
            dt.Columns.Add("Numer");
            dt.Columns.Add("KERG");
            dt.Columns.Add("Ilość szkiców");
        }

        public void saveData()
        {
            if (dt.Rows.Count > 0)
            {
                File.Delete(Environment.CurrentDirectory + "\\Data\\" + yearName + ".bin");
                FileStream plik = File.Create(Environment.CurrentDirectory + "\\Data\\" + yearName + ".bin");
                BinaryFormatter bf = new BinaryFormatter();

                try
                {
                    bf.Serialize(plik, dt);
                }
                catch (Exception e)
                {
                    MessageBox.Show(null, e.Message + "\n" + e.TargetSite, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    plik.Close();
                }
            }
            
        }

        public void loadData()
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\Data\\" + yearName + ".bin"))
            {
                dt.Clear();
            }
            else {
                FileStream plik = File.OpenRead(Environment.CurrentDirectory + "\\Data\\" + yearName + ".bin");
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    dt = bf.Deserialize(plik) as DataTable;
                }
                catch (Exception e)
                {
                    MessageBox.Show(null, e.Message + "\n" + e.TargetSite, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    plik.Close();
                }
            }
        }

        public DataTable get()
        {
            return dt;
        }

        public void AddNew(string[] newData)
        {
            if (yearName != newData[0])
                throw new InvalidDataException("Rok nowych danych nie zgadza się z aktualnym.");
            DataRow newRow = dt.NewRow();
            newRow["KERG"] = newData[1];
            newRow["Numer"] = newData[2];
            newRow["Ilość szkiców"] = newData[3];
            dt.Rows.Add(newRow);
        }

        public void Clean()
        {
            dt.Clear();
        }

    }
}
