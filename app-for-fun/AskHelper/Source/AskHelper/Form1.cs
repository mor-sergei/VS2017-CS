using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Reflection;

namespace AskHelper
{
    public partial class fMain : Form
    {
        public string[] textMessages;
        public fMain()
        {
            InitializeComponent();
            Assembly tassembly = Assembly.GetExecutingAssembly();
            StreamReader reader = new StreamReader(tassembly.GetManifestResourceStream("AskHelper.questlist.txt"));
            textMessages = reader.ReadToEnd().Split('\n');
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            lText.Text = textMessages[rand.Next(0, textMessages.Length)];
            bNext.Text = "Next";
            bExit.Visible = true;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
    }
}
