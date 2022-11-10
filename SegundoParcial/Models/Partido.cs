using System.Security.Cryptography.Xml;

namespace SegundoParcial.Models
{
    public class Partido
    {
        public int id { get; set; }
        public string NombreP { get; set; }

        public int CantidadVotos { get; set; }

        public List<Diputado> Diputados { get; set; }

       



        public partial class Diputado
        {

            public int idD { get; set; }

            public string Nombre { get; set; }


        }

       
        


    }

  
}
