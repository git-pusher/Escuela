using   System;

namespace CoreEscuela.Entidades
{
    //Calse abstracta: no puedo crear objetos de una clase abstracta, sólo hereda
    public  class ObjetoEscuelaBase
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase ()
        {
            UniqueId = Guid.NewGuid().ToString();    
        }
    }
}