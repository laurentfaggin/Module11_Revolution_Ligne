namespace POOII_Module11_Revolution_Lignes
{
    public partial class fRevolutionLignes : Form
    {
        public fRevolutionLignes()
        {
            InitializeComponent();
            
        }

        public ConfigurationRevolution EtablirConfiguration()
        {
            ConfigurationRevolution configRev = new ConfigurationRevolution()
            {
                PasAngle = (int)nudPasAngle.Value,
                LongueurDepart = (int)nudLongueurDepart.Value,
                NombreLignes = (int)nudNombreLignes.Value,
                PasLongueur = (int)nudPasLongueur.Value,
                PositionDepart = new PointF(pCanvas.Width / 2, pCanvas.Height / 2)
            };
            return configRev;
            
        }

        public void Dessiner(ConfigurationRevolution cr, Graphics graph, Pen pen)
        {
            List<PointF> points = DessinRevolution.GenererPoints(cr);
            graph.DrawLines(pen, points.ToArray());
        }

        private void btnDessiner_Click_1(object sender, EventArgs e)
        {
            using (Graphics graphics = pCanvas.CreateGraphics())
            {
                graphics.Clear(Color.White);
                using (Pen pen = new Pen(Color.Black))
                {
                    Dessiner(this.EtablirConfiguration(), graphics, pen);
                }
            }
        }
    }
}