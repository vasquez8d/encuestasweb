using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EncuestasPeru.Models
{
    public class ServiceReponseModel
    {
        public string res_service { get; set; }
        public string des_error { get; set; }
        public List<object> data_result { get; set; }
    }
}