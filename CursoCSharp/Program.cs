using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes- Fundamentos", VariaveisEConstantes.Executar},
                   {"Inferencia - fundamentos", Inferencia.Executar},
                   {"Interpolacao - fundamentos", interpolacao.Executar},
                   

            });

            central.SelecionarEExecutar();
        }
    }
}