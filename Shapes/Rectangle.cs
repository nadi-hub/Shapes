using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shapes
{
    internal class Rectangle
    {
        // field with private accessibility.
        // It cannot be accessed from outside the Rectangle class.
        private double heigth = 5.22;


        // Ein readonly-Feld, dessen Wert nach der Initialisierung nicht mehr verändert werden kann
        public readonly string color = "Black";


        public double width = 3.44;
        // Instanziierung eines Objekts der Klasse Rectangle 
        Rectangle rectangle = new Rectangle();


        // Read-only Eigenschaft
        public int strichstärke
       
        {
            get
            {
                return strichstärke;
            }
        }

        // Read-write Eigenschaft
        public string füllung
        {
            get
            {
                return füllung;
            }
            set
            {
                // Hier könnte man zusätzliche Logik hinzufügen, wie Validierung etc.
                füllung = value;
            }
        }

        // Write-only Eigenschaft
        public double height
        {
            set
            {
                height = 3.44;
            }
        }


        // Automatisch implementierte read-only Eigenschaft
        public int Winkel { get; }

        public Rectangle(int winkel)
        {
            Winkel = winkel;
        }
    }

    public class Rectangle
    {
        // Automatisch implementierte read-write Eigenschaft
        public int Strichstärke { get; set; }

        // Konstruktor zum Setzen des Werts der Eigenschaft
        public Rectangle(int Strichstärke)
        {
            Strichstärke = strichstärke;
        }
    }

    public class Rectangle
    {
        // Automatisch implementierte Write-only Eigenschaft
        public int Strichstärke
        {
            private get;  // Getter ist private, so dass der Wert nicht von außen gelesen werden kann
            set;        // Setter ist öffentlich, um den Wert von außen zu setzen
        }




        public class Rectangle
        {
            private double _width;
            private double _height;

            // Read-only Eigenschaft mit expression-bodied Syntax
            public double Area => _width * _height;

            // Read-write Eigenschaft mit expression-bodied Setter
            public double Width
            {
                get => _width;
                set => _width = value < 0 ? 0 : value; 
            }
        }
    }




}
}
