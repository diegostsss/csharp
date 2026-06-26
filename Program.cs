using CursoCSharp.Atividade;
using CursoCSharp.ClassesEmetodos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Copa;
using CursoCSharp.Estruturas;
using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using static CursoCSharp.ClassesEMetodos.OrdemServico;
using static CursoCSharp.ClassesEMetodos.VendaCelular;

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
                {"Atividade da copa - Atividade", AtividadeDaCopa.Executar},
                

                {"EstruturaRepeticao - Estruturas", EstruturaRepeticao.Executar},

                {"Membros - ClassesEMetodos", Membros.Executar},
                {"Construtores - ClassesEMetodos", Construtores.Executar},
                {"MetodosComRetorno - ClassesEMetodos", MetodosComRetorno.Executar},
                {"ConversorDeTemperatura - ClassesEMetodos", ConversorDeTemperatura.Executar},
                {"Calculadora - ClassesEMetodos", CalcularDesconto.Executar},
                {"Oficina Mecanica - ClassesEMetodos", OficinaMecanica.Executar},
                {"Soma - ClassesEMetodos", Soma.Executar},
                {"Loja de Celulares - ClassesEMetodos", LojaCelulares.Executar},
                {"Lanchonete - ClassesEMetodos", lanchonete.Executar},
                {"Pizzaria - ClassesEMetodos", Pizzaria.Executar},
                {"GetSet - ClassesEMetodos", GetSet.Executar}

            });

            central.SelecionarEExecutar();
        }
    }
}