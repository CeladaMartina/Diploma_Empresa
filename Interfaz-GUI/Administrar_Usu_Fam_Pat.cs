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
    public partial class Administrar_Usu_Fam_Pat : Form, IObserver
    {
        int IdUsuario = -1;

        Propiedades_BE.Usuario UsuarioTemp = new Propiedades_BE.Usuario();
        Negocio_BLL.Usuario GestorUsuario = new Negocio_BLL.Usuario();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.Permisos GestorPermisos = new Negocio_BLL.Permisos();

        Propiedades_BE.Usuario UsSelect;
        Propiedades_BE.Usuario TempUs;

        private static Administrar_Usu_Fam_Pat _instancia;
        public static Administrar_Usu_Fam_Pat ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Administrar_Usu_Fam_Pat();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        long Dv;

        public Administrar_Usu_Fam_Pat()
        {
            InitializeComponent();
        }

        private void Administrar_Usu_Fam_Pat_Load(object sender, EventArgs e)
        {

            Traducir();
            ListarUsuarioPermisos();
            CargarComboxPatente();
        }

        #region Botones
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                UsSelect = (Propiedades_BE.Usuario)this.CmbUsuario.SelectedItem;
                TempUs = new Propiedades_BE.Usuario();
                TempUs.IdUsuario = UsSelect.IdUsuario;
                TempUs.Nombre = UsSelect.Nombre;
                GestorPermisos.FillUserComponents(TempUs);
                MostrarPermisos(TempUs);
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }

        }

        private void BtnAgregarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarFamilia();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnQuitarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                QuitarFamilia();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnAgregarPatente_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarPatente();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnQuitarPatente_Click(object sender, EventArgs e)
        {
            try
            {

                QuitarPatente();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void dataGridViewPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region Metodos
        //void LimpiarTxt()
        //{            
        //    CmbFamilia.SelectedIndex = -1;            
        //    CmbPatente.SelectedIndex = -1;
        //    CmbUsuario.SelectedIndex = -1;            
        //}

        void CargarComboxPatente()
        {
            this.CmbFamilia.DataSource = GestorPermisos.GetAllFamilias();
            this.CmbPatente.DataSource = GestorPermisos.GetAllPatentes();
            this.CmbUsuario.DataSource = GestorUsuario.GetAll();
        }

        public void MostrarPermisos(Propiedades_BE.Usuario U)
        {
            this.treeViewPermisos.Nodes.Clear();
            TreeNode Root = new TreeNode(U.Nombre);
            foreach (var item in U.Permisos)
            {
                LlenarTreeView(Root, item);
            }
            this.treeViewPermisos.Nodes.Add(Root);
            this.treeViewPermisos.ExpandAll();
        }

        void Guardar()
        {
            try
            {
                GestorUsuario.GuardarPermisos(TempUs);
                // Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Permisos usuario guardados", "Baja");
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Permisos de usuario guardados correctamente") ?? "Permisos de usuario guardados correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error guardando permisos usuarios") ?? "Error guardando permisos usuarios");
            }
            ListarUsuarioPermisos();
        }

        public void LlenarTreeView(TreeNode Padre, Propiedades_BE.Componente C)
        {
            TreeNode Hijo = new TreeNode(C.Nombre);
            Hijo.Tag = C;
            Padre.Nodes.Add(Hijo);
            foreach (var item in C.Hijos)
            {
                LlenarTreeView(Hijo, item);
            }
        }

        void ListarUsuarioPermisos()
        {
            dataGridViewPermisos.DataSource = null;
            dataGridViewPermisos.DataSource = GestorUsuario.GetAllUsuarioPermisos();
            dataGridViewPermisos.Columns["IdUsuario"].Visible = false;
            dataGridViewPermisos.Columns["Contraseña"].Visible = false;
            dataGridViewPermisos.Columns["Nick"].Visible = false;
            dataGridViewPermisos.Columns["Mail"].Visible = false;
            dataGridViewPermisos.Columns["Estado"].Visible = false;
            dataGridViewPermisos.Columns["Contador"].Visible = false;
            dataGridViewPermisos.Columns["BajaLogica"].Visible = false;
            dataGridViewPermisos.Columns["Idioma"].Visible = false;
            dataGridViewPermisos.Columns["IdIdioma"].Visible = false;
            dataGridViewPermisos.Columns["DVH"].Visible = false;
            dataGridViewPermisos.ReadOnly = true;
        }

        void QuitarPatente()
        {
            var Pat = (Propiedades_BE.Patente)CmbPatente.SelectedItem;
            //Propiedades_BE.Componente item; 
            if (Pat != null)
            {
                try
                {
                    //for(int i = TempUs.Permisos.Count() -1; i >= 0; i++)
                    //{
                    //    if(item.Id == Pat.Id)
                    //    {
                    //        TempUs.Permisos.Remove(item);
                    //        break;
                    //    }
                    //}

                    foreach (Propiedades_BE.Componente item in TempUs.Permisos.ToArray())
                    {
                        if (item.Id == Pat.Id)
                        {
                            TempUs.Permisos.Remove(item);
                            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Patente eliminada de usuario", "Baja",0);
                            MessageBox.Show(CambiarIdioma.TraducirGlobal("Patente eliminada de usuario") ?? "Patente eliminada de usuario");
                        }
                    }
                    MostrarPermisos(TempUs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error eliminando usuario patente") ?? "Error eliminando usuario patente");
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Problema por patente") ?? "Problema por patente");
            }
            //ListarUsuarioPermisos();
        }

        void AgregarPatente()
        {
            if (TempUs != null)
            {
                var Patente = (Propiedades_BE.Patente)CmbPatente.SelectedItem;
                if (Patente != null)
                {
                    var esta = false;
                    foreach (var item in TempUs.Permisos)
                    {
                        if (GestorPermisos.Existe(item, Patente.Id))
                        {
                            esta = true;
                            break;
                        }
                    }
                    if (esta)
                    {
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("El usuario ya tiene esa patente") ?? "El usuario ya tiene esa patente");
                    }
                    else
                    {
                        TempUs.Permisos.Add(Patente);
                        MostrarPermisos(TempUs);
                    }
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Seleccione un usuario") ?? "Seleccione un usuario");
            }
        }

        void QuitarFamilia()
        {            
            var Fam = (Propiedades_BE.Familia)CmbFamilia.SelectedItem;
            if (Fam != null)
            {
                try
                {
                    foreach (Propiedades_BE.Componente item in TempUs.Permisos.ToArray())
                    {
                        if (item.Id == Fam.Id)
                        {
                            TempUs.Permisos.Remove(item);
                            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Familia eliminada de usuario", "Baja",0);
                            MessageBox.Show(CambiarIdioma.TraducirGlobal("Familia eliminada de usuario") ?? "Familia eliminada de usuario");
                        }
                    }
                    MostrarPermisos(TempUs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Problema por patente") ?? "Problema por patente");
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error eliminando usuario familia") ?? "Error eliminando usuario familia");
            }
        }

        void AgregarFamilia()
        {
            if (TempUs != null)
            {
                var Familia = (Propiedades_BE.Familia)CmbFamilia.SelectedItem;
                if (Familia != null)
                {
                    var esta = false;
                    foreach (var item in TempUs.Permisos)
                    {
                        if (GestorPermisos.Existe(item, Familia.Id))
                        {
                            esta = true;
                        }
                    }
                    if (esta)
                    {
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("El usuario ya tiene esa familia asignada") ?? "El usuario ya tiene esa familia asignada");
                    }
                    else
                    {
                        GestorPermisos.FillFamilyComponents(Familia);
                        TempUs.Permisos.Add(Familia);
                        MostrarPermisos(TempUs);
                    }
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Seleccione un usuario") ?? "Seleccione un usuario");
            }
        }


        #endregion

        #region Traduccion
        public void Update(ISubject subject)
        {
            groupBox1.Text = subject.TraducirObserver(groupBox1.Tag.ToString()) ?? groupBox1.Tag.ToString();
            groupBox2.Text = subject.TraducirObserver(groupBox2.Tag.ToString()) ?? groupBox2.Tag.ToString();
            groupBox3.Text = subject.TraducirObserver(groupBox3.Tag.ToString()) ?? groupBox3.Tag.ToString();
            groupBox4.Text = subject.TraducirObserver(groupBox4.Tag.ToString()) ?? groupBox4.Tag.ToString();
            LblFamilia.Text = subject.TraducirObserver(LblFamilia.Tag.ToString()) ?? LblFamilia.Tag.ToString();
            LblPatente.Text = subject.TraducirObserver(LblPatente.Tag.ToString()) ?? LblPatente.Tag.ToString();
            LblUsuario.Text = subject.TraducirObserver(LblUsuario.Tag.ToString()) ?? LblUsuario.Tag.ToString();
            BtnAgregarFamilia.Text = subject.TraducirObserver(BtnAgregarFamilia.Tag.ToString()) ?? BtnAgregarFamilia.Tag.ToString();
            BtnAgregarPatente.Text = subject.TraducirObserver(BtnAgregarPatente.Tag.ToString()) ?? BtnAgregarPatente.Tag.ToString();
            BtnQuitarFamilia.Text = subject.TraducirObserver(BtnQuitarFamilia.Tag.ToString()) ?? BtnQuitarFamilia.Tag.ToString();
            BtnQuitarPatente.Text = subject.TraducirObserver(BtnQuitarPatente.Tag.ToString()) ?? BtnQuitarPatente.Tag.ToString();
            BtnSeleccionar.Text = subject.TraducirObserver(BtnSeleccionar.Tag.ToString()) ?? BtnSeleccionar.Tag.ToString();
        }

        void Traducir()
        {
            groupBox1.Text = CambiarIdioma.TraducirGlobal(groupBox1.Tag.ToString()) ?? groupBox1.Tag.ToString();
            groupBox2.Text = CambiarIdioma.TraducirGlobal(groupBox2.Tag.ToString()) ?? groupBox2.Tag.ToString();
            groupBox3.Text = CambiarIdioma.TraducirGlobal(groupBox3.Tag.ToString()) ?? groupBox3.Tag.ToString();
            groupBox4.Text = CambiarIdioma.TraducirGlobal(groupBox4.Tag.ToString()) ?? groupBox4.Tag.ToString();
            LblFamilia.Text = CambiarIdioma.TraducirGlobal(LblFamilia.Tag.ToString()) ?? LblFamilia.Tag.ToString();
            LblPatente.Text = CambiarIdioma.TraducirGlobal(LblPatente.Tag.ToString()) ?? LblPatente.Tag.ToString();
            LblUsuario.Text = CambiarIdioma.TraducirGlobal(LblUsuario.Tag.ToString()) ?? LblUsuario.Tag.ToString();
            BtnAgregarFamilia.Text = CambiarIdioma.TraducirGlobal(BtnAgregarFamilia.Tag.ToString()) ?? BtnAgregarFamilia.Tag.ToString();
            BtnAgregarPatente.Text = CambiarIdioma.TraducirGlobal(BtnAgregarPatente.Tag.ToString()) ?? BtnAgregarPatente.Tag.ToString();
            BtnGuardar.Text = CambiarIdioma.TraducirGlobal(BtnGuardar.Tag.ToString()) ?? BtnGuardar.Tag.ToString();
            BtnQuitarFamilia.Text = CambiarIdioma.TraducirGlobal(BtnQuitarFamilia.Tag.ToString()) ?? BtnQuitarFamilia.Tag.ToString();
            BtnQuitarPatente.Text = CambiarIdioma.TraducirGlobal(BtnQuitarPatente.Tag.ToString()) ?? BtnQuitarPatente.Tag.ToString();
            BtnSeleccionar.Text = CambiarIdioma.TraducirGlobal(BtnSeleccionar.Tag.ToString()) ?? BtnSeleccionar.Tag.ToString();
        }


        #endregion
    }
}
