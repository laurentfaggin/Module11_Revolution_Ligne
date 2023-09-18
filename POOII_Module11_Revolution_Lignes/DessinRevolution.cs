using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module11_Revolution_Lignes
{
    public class DessinRevolution
    {
        public static List<PointF> GenererPoints(ConfigurationRevolution cr)
        {
            if (cr is null) { throw new ArgumentNullException(nameof(cr)); }
            
            List<PointF> points = new List<PointF>();
            PointF pointReference = cr.PositionDepart;
            points.Add(pointReference);
            double conversionEnRadians = Math.PI / 180.0;
            double angle = 0;
            int longueurTrait = cr.LongueurDepart;
            int nombreDeLignes = cr.NombreLignes;

            for (int i = 0; i < nombreDeLignes; ++i)
            {
                float nouveauX = (float)(pointReference.X + Math.Cos(angle * conversionEnRadians) * longueurTrait);
                float nouveauY = (float)(pointReference.Y + Math.Sin(angle * conversionEnRadians) * longueurTrait);
                PointF nouveauPoint = new PointF()
                {
                    X = nouveauX,
                    Y = nouveauY

                };

                points.Add(nouveauPoint);
                angle = (360 + angle + cr.PasAngle)% 360;
                longueurTrait += cr.PasLongueur;
                pointReference = nouveauPoint;
            }
            

            return points;
        }

 
    }
}
