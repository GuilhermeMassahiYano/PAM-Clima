
using CommunityToolkit.Mvvm.ComponentModel;
using PAM_Clima.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAM_Clima.ViewModels
{
    public partial class ClimaViewModels:ObservableObject
    {
        [ ObservableProperty ]
        private string condicao_desc;

        [ObservableProperty]
        private string cidade;

        [ObservableProperty]
        private string estado;

        [ObservableProperty]
        private DateTime atualizado_em;

        private List<ClimaModel> clima;

        public ClimaViewModels()
        {
            cidade = "Guarulhos";
        }

        public void getPrevisao()
        {
            cidade = "São Paulo";
        }
    }


}

