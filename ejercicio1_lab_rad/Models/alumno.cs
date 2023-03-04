using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ejercicio1_lab_rad.Models
{
    internal class alumno
    {
        [PrimaryKey, AutoIncrement]
        int id { get; set; }

        [MaxLength(100)]
        public string Nombres { get; set; }

        [MaxLength(100)]
        public string Apellidos { get; set; }

        public string Edad { get; set; }

        public string Correo { get; set; }


        [MaxLength(300)]
        public string Direccion { get; set; }



    }
     
}
