using System;
using System.Windows.Forms;

namespace OurTestForm
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new Form1 ());
        }
    }
}

// Coś podobnego wygeneruje VisualStudio dla każdego projekt WindowsForms.
