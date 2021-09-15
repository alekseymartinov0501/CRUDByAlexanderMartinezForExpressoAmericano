using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDByAlexanderMartinezForExpressoAmericano.Dtos
{
    public class ProductoDto
    {
        
        public int id_producto { get; set; }
        public int id_marca { get; set; }
        public int id_proveedr { get; set; }
        public int id_zona { get; set; }
        public int codigo { get; set; }
        public string descripcion_producto { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public int iva { get; set; }
        public float peso { get; set; }
    }
}
