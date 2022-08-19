﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Propiedades_BE
{
    public class Patente : Componente
    { 
        private IList<Componente> _hijos;
        public override IList<Componente> Hijos
        {
            get { return new List<Componente>(); }
        }

        public override void AgregarHijo(Componente C) { }

        public override void EliminarHijo(Componente C) { }

        public override void VaciarHijo() { }
    }
}
