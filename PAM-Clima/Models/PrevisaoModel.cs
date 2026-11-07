using CommunityToolkit.Mvvm.ComponentModel;
using PAM_Clima.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAM_Clima.Models
{
    public class PrevisaoModel
    {
        private string Cidade;

        private string Estado;

        private DateTime Atualizado_em;

        private List<ClimaModel> clima;

    }
}
