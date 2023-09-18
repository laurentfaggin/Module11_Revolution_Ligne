using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOII_Module11_Revolution_Lignes
{
    public partial class fRevolutionDesLignes : Form
    {
        public fRevolutionDesLignes()
        {
            InitializeComponent();
        }

        public ConfigurationRevolution EtablirConfiguration()
        {
            Point ptDepart = new Point(pCanvas.Width / 2, pCanvas.Height / 2);
            ConfigurationRevolution configRev = new ConfigurationRevolution();
            return configRev;
        }
    }
}
