using System;
using System.Collections.Generic;
using System.Drawing;

namespace ktpm_draw
{
    class Rectangle : IShape
    {
        private Point _p1;
        private Point _p2;
        private Point _p3;
        private Point _p4;
        private int _w;
        private int _h;
        private IList<Point> _points;

        public Rectangle(IList<Point> points) {
            _points = points;
            _p1 = points[0];
            _p2 = points[1];
            _p3 = points[2];
            _p4 = points[3];
        }

        public bool valid() {
            if (_p1 == _p2 || _p1 == _p3 || _p1 == _p4 || _p2 == _p3 || _p2 == _p4 || _p3 == _p4)
                return false;

            for (var i = 1; i < 4; i++) {
                if (_points[i].Y == _p1.Y)
                    for (int j = 1; j < 4; j++) {
                        if (j != i && _points[j].X == _points[i].X) {
                            for (int k = 1; k < 4; k++) {
                                if (k != i && k != j &&
                                    _points[k].Y == _points[j].Y && _p1.X == _points[k].X) {
                                    _w = Math.Abs(_p1.X - _points[i].X);
                                    _h = Math.Abs(_p1.Y - _points[k].Y);
                                    return true;
                                }
                            }
                        }
                    }
            }
            return false;
        }

        public void draw() {
            Global.graphic.DrawRectangle(Global.pen, new System.Drawing.Rectangle(new Point(_p1.X+20,_p1.Y+20), new Size(_w,_h)));
        }
    }
}
