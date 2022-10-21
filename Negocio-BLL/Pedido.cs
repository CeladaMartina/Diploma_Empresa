using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Negocio_BLL
{
    public class Pedido
    {
        Acceso_DAL.Pedido Mapper = new Acceso_DAL.Pedido();
        Propiedades_BE.Pedido PedidoTemp = new Propiedades_BE.Pedido();

        public List<Propiedades_BE.Pedido> Listar()
        {
            List<Propiedades_BE.Pedido> Lista = Mapper.Listar();
            return Lista;
        }

        public int Alta(int IdArticulo, int Cantidad)
        {
            PedidoTemp.IdArticulo = IdArticulo;
            PedidoTemp.Cantidad = Cantidad;

            return Mapper.Alta(PedidoTemp);
        }

        public int Modificar(int IdArticulo, int Cantidad)
        {
            PedidoTemp.IdArticulo = IdArticulo;
            PedidoTemp.Cantidad = Cantidad;

            return Mapper.Modificar(PedidoTemp);
        }

        public int Baja(int IdArticulo)
        {
            PedidoTemp.IdArticulo = IdArticulo;

            return Mapper.Baja(PedidoTemp);
        }

        public void SerializarPedido(string Ruta, DataGridView GridViewPedido)
        {
            List<Propiedades_BE.Pedido> ListarPedido = new List<Propiedades_BE.Pedido>();

            foreach (DataGridViewRow DataPedido in GridViewPedido.Rows)
            {
                Propiedades_BE.Pedido Pe = new Propiedades_BE.Pedido();
                Pe.IdPedido = int.Parse(DataPedido.Cells["IdPedido"].Value.ToString());
                Pe.CodProd = int.Parse(DataPedido.Cells["CodProd"].Value.ToString());
                Pe.NombreProd = DataPedido.Cells["NombreProd"].Value.ToString();
                Pe.Cantidad = int.Parse(DataPedido.Cells["Cantidad"].Value.ToString());
                ListarPedido.Add(Pe);
            }

            Directory.CreateDirectory(Ruta);
            DirectorySecurity sec = Directory.GetAccessControl(Ruta);

            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            Directory.SetAccessControl(Ruta, sec);

            XmlSerializer Formateador = new XmlSerializer(typeof(List<Propiedades_BE.Pedido>));

            string fecha_final = DateTime.Now.ToShortDateString().Replace("/", "-");
            XmlTextWriter Stream = new XmlTextWriter("" + Ruta + "\\Serializacion_Pedido_" + fecha_final + ".xml", Encoding.UTF8);

            Stream.Formatting = Formatting.Indented;
            Stream.Indentation = 1;
            Stream.IndentChar = '\t';

            Formateador.Serialize(Stream, ListarPedido);
            Stream.Close();
        }

        public List<Propiedades_BE.Pedido> DeserializarPedido(string Ruta)
        {
            XmlSerializer Formateador = new XmlSerializer(typeof(List<Propiedades_BE.Pedido>));

            DirectorySecurity sec = Directory.GetAccessControl(Ruta);

            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            Directory.SetAccessControl(Ruta, sec);


            XmlTextReader Stream = new XmlTextReader(Ruta);
            List<Propiedades_BE.Pedido> ListarPedido = Formateador.Deserialize(Stream) as List<Propiedades_BE.Pedido>;
            Stream.Close();
            return ListarPedido;
        }

        public void ReduccionPedido(int IdCompra)
        {
            Mapper.ReduccionPedido(IdCompra);
        }
    }
}
