using AutoMapper;
using Projeto.Entities;
using Projeto.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Presentation.Mappings
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {

            CreateMap<EstoqueCadastroViewModel, Estoque>();
            CreateMap<Estoque, EstoqueConsultaViewModel>();

        }
    }
}