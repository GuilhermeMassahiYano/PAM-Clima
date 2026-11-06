using System;
using System.Collections.Generic;
using System.Text;

namespace PAM_Clima.Models
{
    public class ClimaModel
    {
       private DateTime data;
       private string Condicao;
       private int min;
       private int max;
       private int indice_uv;
       private string condicao_desc;

        public DateTime Data { get => data; set => data = value; }
    }

}
