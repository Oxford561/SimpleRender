using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRender
{
    // 向量类
    public class Vector4
    {
        public double x, y, z, w;
        public Vector4() { }
        public Vector4(Vector4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        public Vector4(double x,double y,double z,double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
}
