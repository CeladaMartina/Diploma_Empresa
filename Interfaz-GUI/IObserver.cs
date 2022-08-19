using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma_Empresa_Final
{
    public interface IObserver
    {
        void Update(ISubject Sujeto);
    }
}
