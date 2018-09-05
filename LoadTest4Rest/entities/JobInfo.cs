using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.Repower.LoadTest4Rest.entities
{
    /// <summary>
    /// Entità del job, dal file
    /// </summary>
    public class JobInfo
    {
        #region Properties
        /// <summary>Il nome del Job</summary>
        public string Name { get;  set; }
        public List<string> Calls { get; set; }
        #endregion
        #region  Static Methods

        /// <summary>
        /// Carica la lista dei job dal server
        /// </summary>
        /// <returns></returns>
        public static List<JobInfo> Load()
        {
            List<JobInfo> lista = null;

            try
            {
                string jsondata = File.ReadAllText("./data/jobcollection.json");
                lista = Newtonsoft.Json.JsonConvert.DeserializeObject<List<JobInfo>>(jsondata);

            }
            catch (Exception ex)
            {
                MessageBox.Show("E' stata generata un'eccezione con questo messaggio:\n" + ex.Message, "E R R O R E!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }

        #endregion

        public override string ToString()
        {
            return $"{Name} ({Calls.Count} Chiamate)";
        }
    }
}
