using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;

namespace ROVER
{
    public class Case
    {

        public string misdrijf { get; set; }
        public string waarneming { get; set; }
        public DateTime datumVoor { get; set; }
        public string svVerdachte { get; set; }
        public string svGetuige { get; set; }
        public string vNaam { get; set; }
        public string aNaam { get; set; }
        public string bsn { get; set; }
        public string meldingsnummer { get; set; }

        public string Fullname
        {
            get
            {
                return $"{vNaam} {aNaam}";
            }
        }
        
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
