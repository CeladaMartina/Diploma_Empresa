using Diploma_Empresa_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_GUI
{
    public partial class Administrar_Permisos : Form, IObserver
    {
        Propiedades_BE.Familia FamTemp = new Propiedades_BE.Familia();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.Permisos GestorPermisos = new Negocio_BLL.Permisos();

        //List<string> NomPat = new List<string>();
        //List<string> NickUsuario = new List<string>();
        //List<string> NombreFamilia = new List<string>();

        private static Administrar_Permisos _instancia;
        public static Administrar_Permisos ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Administrar_Permisos();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Administrar_Permisos()
        {
            InitializeComponent();
            CargarCombos();
        }

      
        private void Administrar_Permisos_Load(object sender, EventArgs e)
        {
            //ListarAdmPermisos();
            ValidarPermisos();
            Traducir();
        }

        #region Metodos Administrar Permisos

        void ValidarPermisos()
        {
            if (Propiedades_BE.SingletonLogIn.GetInstance.IsLoggedIn())
            {
                //((Control).this)
                //((Control)this.tabPage1).Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Familia);
                //((Control)this.tabPage2).Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Patentes);
                //((Control)this.tabPage3).Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Permisos);
            }
            else
            {
                //((Control)this.tabPage1).Enabled = false;
                //((Control)this.tabPage2).Enabled = false;
                //((Control)this.tabPage3).Enabled = false;
            }
        }
        

        public void AgregarFamilia()
        {
            if (FamTemp != null)
            {
                var familia = (Propiedades_BE.Familia)CmbFamiliaP.SelectedItem;
                if (familia != null)
                {
                    var esta = GestorPermisos.Existe(FamTemp, familia.Id);
                    if (esta)
                    {
                        MessageBox.Show("Ya existe");
                    }
                    else
                    {
                        GestorPermisos.FillFamilyComponents(familia);
                        FamTemp.AgregarHijo(familia);
                        MostrarFamiliaPermisos(false);
                    }
                }
            }
        }

        public void AgregarPatente()
        {
            if (FamTemp != null)
            {
                var patente = (Propiedades_BE.Patente)CmbPatenteP.SelectedItem;
                if (patente != null)
                {
                    var esta = GestorPermisos.Existe(FamTemp, patente.Id);
                    if (esta)
                    {
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("Ya Existe") ?? "Ya Existe");
                    }
                    else
                    {
                        FamTemp.AgregarHijo(patente);
                        Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Patente agregada a familia", "Baja",0);
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("Patente agregada a familia") ?? "Patente agregada a familia");
                    }
                }
            }
        }

        public void GuardarFamPat()
        {
            GestorPermisos.GuardarFamilia(FamTemp);
            FamTemp.VaciarHijo();
            FamTemp = new Propiedades_BE.Familia();
            //ListarAdmPermisos();
        }

        public void QuitarFamPat(string NomFam, string NomPat, bool EsFam)
        {
            GestorPermisos.EliminarFamilia(NomFam, NomPat, EsFam);
            //ListarAdmPermisos();
            MostrarFamiliaPermisos(true);
        }

        void MostrarFamiliaPermisos(bool Fam)
        {
            if (FamTemp == null)
            {
                return;
            }
            IList<Propiedades_BE.Componente> Familia = null;
            if (Fam)
            {
                Familia = GestorPermisos.GetAll("=" + FamTemp.Id);
                foreach (var i in Familia)
                {
                    FamTemp.AgregarHijo(i);
                    
                }
            }
            else
            {
                Familia = FamTemp.Hijos;
            }
            this.treeViewFamilia.Nodes.Clear();
            TreeNode root = new TreeNode(FamTemp.Nombre);
            root.Tag = FamTemp;
            this.treeViewFamilia.Nodes.Add(root);
            foreach (var item in Familia)
            {
                LlenarTreeView(root, item);
            }
            treeViewFamilia.ExpandAll();
        }

        public void LlenarTreeView(TreeNode Padre, Propiedades_BE.Componente C)
        {
            TreeNode Hijo = new TreeNode(C.Nombre);
            Padre.Tag = C;
            Padre.Nodes.Add(Hijo);
            if (C.Hijos != null)
            {
                foreach (var item in C.Hijos)
                {
                    LlenarTreeView(Hijo, item);
                }
            }
        }

        void CargarCombos()
        {            
            this.CmbPatenteP.DataSource = GestorPermisos.GetAllPatentes();           
            this.CmbFamiliaP.DataSource = GestorPermisos.GetAllFamilias();
            
        }

        bool ChequearFallaTxt(string Nombre)
        {
            bool A = false;
            if (string.IsNullOrEmpty(Nombre))
            {
                A = true;
            }
            return A;
        }

        void AltaPatente(string NombrePatente)
        {
            Propiedades_BE.Patente Pat = new Propiedades_BE.Patente();
            Pat.Nombre = NombrePatente;
            Pat.Permiso = (Propiedades_BE.TipoPermiso)this.CmbPatenteP.SelectedItem;
            GestorPermisos.GuardarComponente(Pat, false);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta patente", "Baja",0);           
            CargarCombos();
        }

        void AltaFamilia(string NombreFamilia)
        {
            Propiedades_BE.Familia Fam = new Propiedades_BE.Familia();
            Fam.Nombre = NombreFamilia;
            GestorPermisos.GuardarComponente(Fam, true);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta familia", "Media",0);
            txtNombreFamilia.Clear();
            CargarCombos();
        }

        #endregion

        #region Botones

        private void BtnAgregarF_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarFamilia();
                MostrarFamiliaPermisos(false);
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
       

        private void BtnBorrarF_Click(object sender, EventArgs e)
        {
            if(GestorPermisos.VerificarBorradoFam(CmbFamiliaP.SelectedItem.ToString()) == 0)
            {
                try
                {
                    var familia = (Propiedades_BE.Familia)CmbFamiliaP.SelectedItem; //seleccion del combo                                    

                    foreach(Propiedades_BE.Componente item in FamTemp.Hijos)
                    {
                        if(item.Id == familia.Id)
                        {
                            FamTemp.EliminarHijo(item);
                        }
                        
                    }
                    MostrarFamiliaPermisos(false);

                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarPatente();
                MostrarFamiliaPermisos(false);
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnBorrarP_Click(object sender, EventArgs e)
        {
            if (GestorPermisos.VerificarBorradoFam(CmbFamiliaP.SelectedItem.ToString()) == 0)
            {
                try
                {
                    var patente = (Propiedades_BE.Patente)CmbPatenteP.SelectedItem; //seleccion del combo                                    

                    foreach (Propiedades_BE.Componente item in FamTemp.Hijos)
                    {
                        if (item.Id == patente.Id)
                        {
                            FamTemp.EliminarHijo(item);
                        }
                    }
                    MostrarFamiliaPermisos(false);

                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            //var Tmp = (Propiedades_BE.Familia)this.CmbFamiliaP.SelectedItem;
            //FamTemp = new Propiedades_BE.Familia();
            //FamTemp.Id = Tmp.Id;
            //FamTemp.Nombre = Tmp.Nombre;

            //MostrarFamiliaPermisos(true);
        }

        private void BtnCargarFP_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarFamPat();
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Usuario guardado correctamente.") ?? "Usuario guardado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        //private void dataGridViewAdmPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
            //try
            //{
            //    CmbFamiliaP.Text = Convert.ToString(dataGridViewAdmPermisos.Rows[e.RowIndex].Cells["NombreFamilia"].Value.ToString());
            //    CmbPatenteP.Text = Convert.ToString(dataGridViewAdmPermisos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString());
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            //}
        //}

        #endregion

        #region Traduccion 
        public void Update(ISubject subject)
        {
            BtnAgregarF.Text = subject.TraducirObserver(BtnAgregarF.Tag.ToString()) ?? BtnAgregarF.Tag.ToString();
            BtnAgregarP.Text = subject.TraducirObserver(BtnAgregarP.Tag.ToString()) ?? BtnAgregarP.Tag.ToString();
            BtnCargarFP.Text = subject.TraducirObserver(BtnCargarFP.Tag.ToString()) ?? BtnCargarFP.Tag.ToString();
            BtnSeleccionar.Text = subject.TraducirObserver(BtnSeleccionar.Tag.ToString()) ?? BtnSeleccionar.Tag.ToString();
            BtnBorrarF.Text = subject.TraducirObserver(BtnBorrarF.Tag.ToString()) ?? BtnBorrarF.Tag.ToString();
            BtnBorrarP.Text = subject.TraducirObserver(BtnBorrarP.Tag.ToString()) ?? BtnBorrarP.Tag.ToString();         
        }

        public void Traducir()
        {
            BtnAgregarF.Text = CambiarIdioma.TraducirGlobal(BtnAgregarF.Tag.ToString()) ?? BtnAgregarF.Tag.ToString();
            BtnAgregarP.Text = CambiarIdioma.TraducirGlobal(BtnAgregarP.Tag.ToString()) ?? BtnAgregarP.Tag.ToString();
            BtnCargarFP.Text = CambiarIdioma.TraducirGlobal(BtnCargarFP.Tag.ToString()) ?? BtnCargarFP.Tag.ToString();
            BtnSeleccionar.Text = CambiarIdioma.TraducirGlobal(BtnSeleccionar.Tag.ToString()) ?? BtnSeleccionar.Tag.ToString();
            BtnBorrarF.Text = CambiarIdioma.TraducirGlobal(BtnBorrarF.Tag.ToString()) ?? BtnBorrarF.Tag.ToString();
            BtnBorrarP.Text = CambiarIdioma.TraducirGlobal(BtnBorrarP.Tag.ToString()) ?? BtnBorrarP.Tag.ToString();
        }

        #endregion

        //private void btnCrearPermiso_Click(object sender, EventArgs e)
        //{
        //    if (ChequearFallaTxt(txtNombrePatente.Text) == false)
        //    {
        //        try
        //        {
        //            AltaPatente(txtNombrePatente.Text);                    
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show(CambiarIdioma.TraducirGlobal("Complete todos los campos") ?? "Complete todos los campos");
        //    }
        //}

        private void BtnAgregarFamilia_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt(txtNombreFamilia.Text) == false)
            {
                try
                {
                    AltaFamilia(txtNombreFamilia.Text);
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Se agrego la familia.") ?? "Se agrego la familia.");
                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Complete todos los campos") ?? "Complete todos los campos");
            }
        }

        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
        {
            var Tmp = (Propiedades_BE.Familia)this.CmbFamiliaP.SelectedItem;
            FamTemp = new Propiedades_BE.Familia();
            FamTemp.Id = Tmp.Id;
            FamTemp.Nombre = Tmp.Nombre;

            MostrarFamiliaPermisos(true);
        }
    }

}
