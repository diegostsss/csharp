using System;
using System.Collections.Generic;
using CursoCSharp.Atividade;
using CursoCSharp.Fundamentos;
using CursoCSharp.Estruturas;
using CursoCSharp.Copa;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Exercicio1 - Fundamentos", Exercicio1.Executar},

                {"ConvocacaoSelecao - Copa", ConvocacaoSelecao.Executar},
                {"VendaCamisasSelecao - Copa", VendaCamisasSelecao.Executar},
                {"VendaIngressos - Copa", VendaIngressos.Executar},
                {"CraqueDaCopa - Copa", CraqueDaCopa.Executar},
                {"FaseCompeticao - Copa", FaseCompeticao.Executar},
                {"ChuteAoGol - Copa", ChuteAoGol.Executar},
                {"ElePodeJogar - Copa", ElePodeJogar.Executar},
                {"ClassificacaoJogador - Copa", ClassificacaoJogador.Executar},

                {"Atividade1 - Atividade", Al.Executar},
                {"Atividade2 - Atividade", Copa1.Executar},
                {"Atividade3 - Atividade", Copa2.Executar},
                {"Atividade4 - Atividade", Copa3.Executar},
                {"Atividade5 - Atividade", Copa4.Executar},

                {"EstruturaRepeticao - Estruturas", EstruturaRepeticao.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}