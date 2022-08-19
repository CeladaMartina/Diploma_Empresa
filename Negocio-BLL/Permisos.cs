﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class Permisos
    {
        Acceso_DAL.Permisos _permisos;

        public Permisos()
        {
            _permisos = new Acceso_DAL.Permisos();
        }

        #region Componente
        public Propiedades_BE.Componente GuardarComponente(Propiedades_BE.Componente p, bool esfamilia)
        {
            return _permisos.GuardarComponente(p, esfamilia);
        }

        public Propiedades_BE.Componente EliminarComponente(Propiedades_BE.Componente p, bool esfamilia)
        {
            return _permisos.EliminarComponente(p, esfamilia);
        }

        public IList<Propiedades_BE.Componente> GetAll(string familia)
        {
            return _permisos.GetAll(familia);

        }

        public void FillUserComponents(Propiedades_BE.Usuario u)
        {
            _permisos.FillUserComponents(u);
        }

        public void FillFamilyComponents(Propiedades_BE.Familia familia)
        {
            _permisos.FillFamilyComponents(familia);
        }
        #endregion

        #region Familia
        public void GuardarFamilia(Propiedades_BE.Familia c)
        {
            _permisos.GuardarFamilia(c);
        }

        public void EliminarFamilia(string NomFam, string NomPat, bool isfam)
        {
            _permisos.EliminarFamilia(NomFam, NomPat, isfam);
        }

        public void ModificarFamilia(string NomOriginal, string NomNuevo)
        {
            _permisos.ModificarFamilia(NomOriginal, NomNuevo);
        }

        public IList<Propiedades_BE.Familia> GetAllFamilias()
        {
            return _permisos.GetAllFamilias();
        }

        public bool Contains(Propiedades_BE.Componente component, Propiedades_BE.Componente includes)
        {
            bool exist = false;
            if (component.Id.Equals(includes.Id))
            {
                exist = true;
            }
            else
            {
                foreach (Propiedades_BE.Componente item in component.Hijos)
                {
                    if (Contains(item, includes)) 
                    {
                        return true;
                    }
                        
                }
            }
            return exist;
        }
        #endregion

        #region Permisos 
        public Array GetAllPermisos()
        {
            return _permisos.GetAllPermisos();
        }
        #endregion

        #region Patentes
        public IList<Propiedades_BE.Patente> GetAllPatentes()
        {
            return _permisos.GetAllPatentes();
        }

        #endregion

        #region Verificar Borrado
        public int VerificarBorradoFam(string NombreFamilia)
        {
            return _permisos.VerificarBorradoFam(NombreFamilia);
        }

        public int VerificarBorradoPatFam(string NombreFamilia, string NombrePatente)
        {
            return _permisos.VerificarBorradoPatFam(NombreFamilia, NombrePatente);
        }

        public int VerificarBorradoPatente(string NombrePatente)
        {
            return _permisos.VerificarBorradoPatente(NombrePatente);
        }

        #endregion

        #region Permisos
        public IList<Propiedades_BE.Familia> GetAllPermisosPermisos()
        {
            return _permisos.GetAllPermisosPermisos();
        }

        public bool Existe(Propiedades_BE.Componente c, int id)
        {
            bool existe = false;

            if (c.Id.Equals(id))
                existe = true;
            else

                foreach (var item in c.Hijos)
                {

                    existe = Existe(item, id);
                    if (existe) return true;
                }

            return existe;

        }
        #endregion
    }
}
