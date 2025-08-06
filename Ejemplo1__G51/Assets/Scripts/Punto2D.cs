using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Package2D
{

    [Serializable]

    public class Puntos2D 
    {

        [SerializeField] private double X;
        [SerializeField] private double Y;


        public Puntos2D()
        {

        }

        public Puntos2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X1 { get => X; set => X = value; }
        public double Y1 { get => Y; set => Y = value; }
    }
}

