using Senai.Personagens.WebApi.Manha.Domains;
using System.Collections.Generic;

namespace Senai.Personagens.WebApi.Manha.Interfaces
{
    interface IPersonagem
    {
        List<PersonagensDomain> ListarPersonagem();
        
        void RegistrarPersonagem(PersonagensDomain Personagens);
    }
}
