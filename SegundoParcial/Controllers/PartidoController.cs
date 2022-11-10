using Microsoft.AspNetCore.Mvc;
using SegundoParcial.Models;
using System.Security.Cryptography.Xml;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SegundoParcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidoController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EstudiantesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public List<DHondt> Post(List<Partido> partidos)
        {
            List<DHondt> responses = new List<DHondt>();
            foreach (var parti in partidos)
            {

              
                
                    DHondt response = new DHondt();
                    var est = partidos.FirstOrDefault();
                    response.Nombre = parti.NombreP;
                    response.Votos = (parti.CantidadVotos);
                response.lugar = 0;

                decimal porce = 0;
                 porce += parti.CantidadVotos * 3 / 100;

                if (parti.CantidadVotos>=porce)
                {
                    responses.Add(response);
                };

                   
             


             

            }
            return responses.OrderByDescending(s => s.lugar).ToList();
        }

       

      
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

       
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


    }
}
