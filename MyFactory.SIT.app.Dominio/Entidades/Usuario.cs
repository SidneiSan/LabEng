using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyFactory.SIT.app.CrossCutting.Enums;

namespace MyFactory.SIT.app.Dominio.Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public UserTipo TipoConta { get; set; }
    }


}
