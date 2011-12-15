using System;
using System.Collections.Generic;
using System.Drawing;

namespace ktpm_draw
{
    class Ellipse : IShape
    {
        private float _x;
        private float _y;
        private float _w;
        private float _h;

        public Ellipse(float y,float x, float w, float h) {
            _x = x;
            _y = y;
            _w = w;
            _h = h;
        }

        public bool valid() {
            return true;
        }

        public void draw() {
            Global.graphic.DrawEllipse(Global.pen, _x+10,_y+10,_w,_h);
        }
    }
}
