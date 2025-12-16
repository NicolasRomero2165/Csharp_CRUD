using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2025.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto
        {
            get { return this.PrecioCosto * Convert.ToDecimal(Margen); }
        }
        public decimal PrecioVenta
        {
            get { return this.PrecioBruto * Convert.ToDecimal(IVA); }
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        public Producto(int id, string nombre, string descripcion, decimal precioCosto, double margen, double iVA, string proveedor, string categoria, string subcategoria)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.PrecioCosto = precioCosto;
            this.Margen = margen;
            this.IVA = iVA;
            this.Proveedor = proveedor;
            this.Categoria = categoria;
            this.SubCategoria = subcategoria;
        }
    }
}
