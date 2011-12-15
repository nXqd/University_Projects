using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace ktpm_draw
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var shape = readData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(shape));
            // check if shape is valid draw to our form
        }

        private static IShape readData()
        {
            IShape shape = null;
            var points = new List<Point>();
            var reader = new XmlTextReader("data.xml");
            XmlNodeType node;
            reader.Read();

            while (reader.Read()) {
                node = reader.NodeType;
                if (node == XmlNodeType.Element)
                    switch (reader.Name)
                    {
                        case "ellipse": {
                            var x = float.Parse(reader.GetAttribute("x"));
                            var y = float.Parse(reader.GetAttribute("y"));
                            var w = float.Parse(reader.GetAttribute("w"));
                            var h = float.Parse(reader.GetAttribute("h"));
                            shape = new Ellipse(x,y,w,h);
                            break;
                        }
                        case "rectangle": {
                            points.Add((Point)Global.converter.ConvertFromString(reader.GetAttribute("point1")));
                            points.Add((Point)Global.converter.ConvertFromString(reader.GetAttribute("point2")));
                            points.Add((Point)Global.converter.ConvertFromString(reader.GetAttribute("point3")));
                            points.Add((Point)Global.converter.ConvertFromString(reader.GetAttribute("point4")));
                            shape = new Rectangle(points);
                            break;
                        }
                        case "line":
                            points.Add((Point)Global.converter.ConvertFromString(reader.GetAttribute("point1")));
                            points.Add((Point)Global.converter.ConvertFromString(reader.GetAttribute("point2")));
                            shape = new Line(points);
                            break;
                    }
            }
            return shape;
        }
    }
}
