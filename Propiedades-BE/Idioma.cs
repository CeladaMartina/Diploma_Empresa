using System;
using System.Collections.Generic;
using System.Text;

namespace Propiedades_BE
{
    public class Idioma
    {
        private int _ididioma;

        public int IdIdioma
        {
            get { return _ididioma; }
            set { _ididioma = value; }
        }

        private string _nombreidioma;

        public string NombreIdioma
        {
            get { return _nombreidioma; }
            set { _nombreidioma = value; }
        }

        private bool _bajalogica;

        public bool BajaLogica
        {
            get { return _bajalogica; }
            set { _bajalogica = value; }
        }
    }
}
