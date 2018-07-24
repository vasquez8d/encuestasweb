using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EncuestasPeru.Models
{
    public class CandidatoModel
    {
        public int cand_id { get; set; }
        public string cand_nombre { get; set; }
        public string cand_ape_pat { get; set; }
        public string cand_ape_mat { get; set; }
        public int part_id { get; set; }
        public string cand_link_fb { get; set; }
        public string cand_link_twt { get; set; }
        public string cand_link_inst { get; set; }
        public string cand_img_url { get; set; }
        public int cand_flg_prv { get; set; }
        public string cand_ubigeo_prv { get; set; }
        public int cand_flg_dst { get; set; }
        public string cand_ubigeo_dist { get; set; }
        public int cand_est_registro { get; set; }
        public string cand_fec_registro { get; set; }
        public int cand_user_id { get; set; }
    }
}