using EncuestasPeru.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace EncuestasPeru.Logic
{
    public class CandidatoLogic
    {
        public CandidatoLogic()
        {

        }

        public List<CandidatoModel> ObtenerBusquedaCandidato(string search)
        {
            var data = new List<CandidatoModel>();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:1337/candidato/search");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"cand_search\": \""+ search + "\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var dataReponse = JsonConvert.DeserializeObject<ServiceReponseModel>(result);
                if(dataReponse.res_service == "ok")
                {
                    
                }
            }          
            return data;
        }
    }
}