using Switch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    class Usuario
    {
        public int Id { get; private set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public String UrlFoto { get; set; }
        public SexoEnum Sexo { get; set; }
    }
}
