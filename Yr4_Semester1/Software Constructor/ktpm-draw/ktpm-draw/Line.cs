using System.Collections.Generic;
using System.Drawing;

namespace ktpm_draw
{
    class Line : IShape {
        private Point _p1;
        private Point _p2;

        public Line(IList<Point> points) {
            _p1 = points[0];
            _p2 = points[1];
        }

        public bool valid() {
            return !(_p1 == _p2);
        }

        public void draw() {
            Global.graphic.DrawLine(Global.pen,new Point(_p1.X+20,_p1.Y+20),_p2);
        }
    }
}
