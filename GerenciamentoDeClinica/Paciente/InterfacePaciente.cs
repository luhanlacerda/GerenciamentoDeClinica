﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeClinica.Paciente
{
    interface InterfacePaciente
    {
        //Cadastrar um paciente
        void cadastrar (Paciente p);
        //Atualizar um paciente
        void atualizar(Paciente p);
        //Remover um paciente
        void remover(Paciente p);
        //Devolver os pacientes que se encaixam no filtro de pesquisa
        List<Paciente> listar(Paciente filtro);
        //Verificar se um paciente já está cadastrado
        Boolean verificaExistencia(Paciente p);
        //Selecionar paciente
        Paciente selecionarPaciente(Paciente p); 
    }
}
