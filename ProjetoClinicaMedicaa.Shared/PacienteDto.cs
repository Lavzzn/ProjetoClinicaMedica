﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinicaMedicaa.Shared
{
    public class PacienteDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; } 
        public string ContatoEmergencia { get; set; } = string.Empty;
        public string HistoricoMedico { get; set; }
    }
}
