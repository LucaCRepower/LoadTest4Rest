using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    /// Entità della chiamata, dal file
    /// </summary>
    public class CallInfo
    {
        #region Properties

        private static List<CallInfo> _lista { get; set; }

        public string Name { get; set; }
        public string Method { get; set; }
        public string URL { get; set; }
        public string Body { get; set; }
        #endregion

        #region  Static Methods

        /// <summary>
        /// Recupera un CallInfo dal nome.
        /// </summary>
        /// <param name="callName"></param>
        /// <returns></returns>
        public static CallInfo Get(string callName)
        {
            try
            {
                return _lista.Where(l => l.Name == callName).First();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Carica la lista dei job dal server
        /// </summary>
        /// <returns></returns>
        public static void Load()
        {

            if (_lista == null)
            {

                try
                {
                    string jsondata = File.ReadAllText("./data/callcollection.json");
                    var obj = Newtonsoft.Json.Linq.JObject.Parse(jsondata);

                    var items = obj["item"].Children();
                    ReadData(items);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("E' stata generata un'eccezione con questo messaggio:\n" + ex.Message,
                                        "E R R O R E!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }



        #endregion

        #region Private Methods     

        /// <summary>
        /// Legge le varie entita e 
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="items"></param>
        private static void ReadData(JEnumerable<JToken> items)
        {
            _lista = new List<CallInfo>();

            foreach (JToken item in items)
            {

                _lista.Add(new CallInfo
                {
                    Name = item["name"].Value<string>(),
                    Method = item["request"]["method"].Value<string>().ToUpper(),
                    URL = item["request"]["url"]["raw"].Value<string>(),
                    Body = item["request"]["body"]["raw"].Value<string>()
                });

            }

        }

        #endregion
    }
}
