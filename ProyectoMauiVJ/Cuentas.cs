using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProyectoMauiVJ
{

    [Table("cuentas")]
    public class Cuentas
    {

        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("contraseña")]
        public string Contraseña { get; set; }

    }
}
