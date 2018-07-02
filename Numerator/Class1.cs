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
        }

        public CustomData(string year)
        {
            yearName = year;
            dt = new DataTable();
        }

        // Convert an object to a byte array
        private byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        // Convert a byte array to an Object
        private Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }

        public void saveData()
        {
            File.Delete(Environment.CurrentDirectory + "\\Data\\" + yearName + ".db");
            File.Create(Environment.CurrentDirectory + "\\Data\\" + yearName + ".db");
            FileStream plik = File.OpenWrite(Environment.CurrentDirectory + "\\Data\\" + yearName + ".db");
            
            try
            {
                plik.Write(ObjectToByteArray(dt), 0, count: Int32.MaxValue);
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

        public void loadData()
        {
            FileStream plik = File.OpenRead(Environment.CurrentDirectory + "\\Data\\" + yearName + ".db");
            byte[] tempData = new byte[plik.Length];
            try
            {
                plik.Read(tempData, 0, (int)plik.Length);
                dt = ByteArrayToObject(tempData) as DataTable;
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

        public DataTable get()
        {
            return dt;
        }

    }
}
