using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new Form1());
        }
    }
}
