using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRender
{
    // 3维三角形类
    public class Triangle3D
    {
        public Vector4 A, B, C;
        public Triangle3D() { }
        public Triangle3D(Vector4 a,Vector4 b,Vector4 c)
        {
            this.A = new Vector4(a);
            this.B = new Vector4(b);
            this.C = new Vector4(c);
        }
    }
}
