﻿using System.ComponentModel.DataAnnotations;

namespace DomZaStaraLicaApi.Data.Models
{
    public class PoslovnaPozicija
    {
        [Key]
        public int PozicijaId { get; set; }
        public string OpisPosla { get; set; }
        public int BrojSati { get; set; }
        public string Zvanje { get; set; }
    }
}
