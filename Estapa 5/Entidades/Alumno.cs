using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
 
        //cosntructor
         public Alumno() => UniqueId = Guid.NewGuid().ToString();      
    }
}