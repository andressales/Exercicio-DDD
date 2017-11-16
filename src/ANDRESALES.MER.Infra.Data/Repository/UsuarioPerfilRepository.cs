﻿using ANDRESALES.MER.Domain.Interfaces;
using ANDRESALES.MER.Domain.Models;
using ANDRESALES.MER.Infra.Data.Context;

namespace ANDRESALES.MER.Infra.Data.Repository
{
    public class UsuarioPerfilRepository : Repository<UsuarioPerfil>, IUsuarioPerfilRepository
    {
        public UsuarioPerfilRepository(MERContext context) 
            : base(context)
        {
        }
    }
}