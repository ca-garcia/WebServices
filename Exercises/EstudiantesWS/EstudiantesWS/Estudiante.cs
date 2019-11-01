using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudiantesWS
{
     public struct notas
    {
        public int es;
        public int mat;
        public int ing;
        public int hist;
        public int geo;
    }

    public class Estudiante
    {
        private string name;
        private string ci;
        private notas notes;

        public Estudiante(string name, string ci, notas notes)
        {
            this.name = name;
            this.ci = ci;
            this.notes = notes;
        
        }

        public string getName()
        {
            return this.name;
        }

        public string getCI()
        {
            return this.ci;
        }

        //public notas getNotas()
        //{
        //    return this.notes;
        //}

        public float Average()
        {
            return (notes.es + notes.mat + notes.ing + notes.hist + notes.geo)/5;
        
        }

    }
}