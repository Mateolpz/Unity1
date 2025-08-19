using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Package2D
{

    [Serializable]

    public class Puntos2D 
    {

        [SerializeField] 
        private float X;
        [SerializeField] 
        private float Y;


        public Puntos2D()
        {

        }

        public Puntos2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public float X1 { get => X; set => X = value; }
        public float Y1 { get => Y; set => Y = value; }
    }
}

