using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diploma_Empresa_Final;

namespace Interfaz_GUI
{
    public partial class PatenteFamilias : Form
    {
        Negocio_BLL.Permisos GestorPermisos = new Negocio_BLL.Permisos();
        //Propiedades_BE.Familia seleccion;
        //Propiedades_BE.Componente componente;
        public PatenteFamilias()
        {
            InitializeComponent();
        }

        private void PatenteFamilias_Load(object sender, EventArgs e)
        {
           
        }

        #region Botones
        #endregion

        #region Metodos
        private void MostrarEnTreeView(TreeNode padre, Propiedades_BE.Componente component)
        {
            TreeNode node = new TreeNode(component.Nombre);
            padre.Tag = component;
            padre.Nodes.Add(node);
            if (component.Hijos != null)
                foreach (Propiedades_BE.Componente item in component.Hijos)
                {
                    MostrarEnTreeView(node, item);
                }
        }

        //private void MostrarFamilia(bool init)
        //{
        //    if (seleccion == null) return;


        //    IList<componente> flia = null;
        //    if (init)
        //    {
        //        flia = GestorPermisos.GetAll('pepe');

        //        foreach (componente i in flia)
        //        {
        //            seleccion.AgregarHijo(i);
        //        }                    
        //    }
        //    else
        //    {
        //        flia = seleccion.Hijos;
        //    }

        //    treeConfigurarFamilia.Nodes.Clear();

        //    TreeNode root = new TreeNode(seleccion.Nombre);
        //    root.Tag = seleccion;
        //    treeConfigurarFamilia.Nodes.Add(root);

        //    foreach (Component item in flia)
        //    {
        //        MostrarEnTreeView(root, item);
        //    }

        //    treeConfigurarFamilia.ExpandAll();
        //}

        private void LlenarPatentesFamilias()
        {

            cboPatentes.DataSource = GestorPermisos.GetAllPatentes();
            cboPatentes.DisplayMember = "nombre";
            cboFamilias.DataSource = GestorPermisos.GetAllFamilias();
            //falta llenar el combo2 de familia 
            
        }
        #endregion
    }
}
