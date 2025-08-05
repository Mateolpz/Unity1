using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Package2D
{

    [Serializable]

    public class Punto2D : MonoBehaviour
    {
        private double X;
        private double Y;

        public Punto2D()
        {

        }

        public Punto2D(double x, double y)
        {
            X1 = x;
            Y1 = y;
        }

        public double X1 { get => X; set => X = value; }
        public double Y1 { get => Y; set => Y = value; }
    }
}

