using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma_Empresa_Final
{
    public interface ISubject
    {
        void Attach(IObserver Observer);
        void NotificarCambio();
        string TraducirObserver(string st);
    }
}
