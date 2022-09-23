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
    public partial class CambiarIdioma : Form , ISubject
    {
        Negocio_BLL.Idioma GestorIdioma = new Negocio_BLL.Idioma();
        Negocio_BLL.Traduccion GestorTraduccion = new Negocio_BLL.Traduccion();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();

        List<IObserver> ListaObservadores = new List<IObserver>();

        public static Dictionary<string, string> DiccionarioTraduccionGlobal;

        private static CambiarIdioma _instancia;
        
        public static CambiarIdioma ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new CambiarIdioma();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public CambiarIdioma()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DiccionarioTraduccionGlobal = new Dictionary<string, string>();
                foreach (var item in GestorTraduccion.ListarTraduccionDicionario(comboBoxIdiomas.SelectedItem.ToString()))
                {
                    DiccionarioTraduccionGlobal.Add(item.Original, item.Traducido);
                }
                this.NotificarCambio();
                Traducir();
            }
            catch (Exception)
            {
                MessageBox.Show(TraducirGlobal("Error") ?? "Error");
            }
        }

        #region Metodos Traduccion

        public void Attach(IObserver observer)
        {
            ListaObservadores.Add(observer);
        }

        public void NotificarCambio()
        {
            var numerator = Application.OpenForms.GetEnumerator();
            while (numerator.MoveNext())
            {
                if (numerator.Current is IObserver)
                {
                    this.Attach((IObserver)numerator.Current);
                }
            }
            ListaObservadores.ForEach(item => item.Update(this));
        }

        public string TraducirObserver(string variable)
        {
            string trad = "";
            try
            {
                trad = DiccionarioTraduccionGlobal[variable];
            }
            catch (Exception)
            {
                trad = null;
            }
            return trad;
        }

        public static string TraducirGlobal(string variable)
        {
            string trad = "";
            try
            {
                trad = DiccionarioTraduccionGlobal[variable];
            }
            catch (Exception)
            {
                trad = null;
            }
            return trad;
        }

        void Traducir()
        {
            LblElegirIdioma.Text = TraducirGlobal(LblElegirIdioma.Tag.ToString()) ?? LblElegirIdioma.Tag.ToString();
            BtnAceptar.Text = TraducirGlobal(BtnAceptar.Tag.ToString()) ?? BtnAceptar.Tag.ToString();
            groupBoxIdioma.Text = TraducirGlobal(groupBoxIdioma.Tag.ToString()) ?? groupBoxIdioma.Tag.ToString();            
            //this.Text = TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }
        #endregion

        private void CambiarIdioma_Load(object sender, EventArgs e)
        {
            List<string> Idiomas = GestorIdioma.NombreIdioma();
            foreach (var NomIdioma in Idiomas)
            {
                comboBoxIdiomas.Items.Add(NomIdioma.ToString());
            }
            Traducir();
        }

        private void groupBoxIdioma_Enter(object sender, EventArgs e)
        {

        }
    }
}
