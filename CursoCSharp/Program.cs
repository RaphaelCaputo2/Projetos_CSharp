using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
namespace CursoCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      var central = new CentralDeExercicios(new Dictionary<string, Action>() {
        {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
        {"Comentários - Fundamentos", Comentarios.Executar},
        {"Variaveis e Constantes- Fundamentos", VariaveisEConstantes.Executar},
        {"Inferencia - fundamentos", Inferencia.Executar},
        {"Interpolacao - fundamentos", interpolacao.Executar},
        {"Notacao Ponto - fundamentos", NotacaoPonto.Executar},
        {"Lendo Dados - fundamentos", LendoDados.Executar},
        {"Formatando Números - fundamentos", FormatandoNumeros.Executar},
        {"Conversoes - fundamentos", Conversoes.Executar},
        {"Operadores Aritmeticos - fundamentos", OperadoresAritmeticos.Executar},
        {"Operadores Relacionais- fundamentos", OperadoresRelacionais.Executar},
        {"Operadores Lógico- fundamentos", OperadoresLogicos.Executar},
        {"Operadores Atribuição- fundamentos", OperadoresAtribuicao.Executar},
        //Estruturas de controle
        {"Estrutura If-  Estruturas de Controle", EstruturaIf.Executar},
        {"Estrutura Switch-  Estruturas de Controle", EstruturaSwitch.Executar},
        {"Estrutura While-  Estruturas de Controle", EstruturaWhile.Executar},
        {"Estrutura For-  Estruturas de Controle", EstruturaFor.Executar},
        {"Estrutura ForEach-  Estruturas de Controle", EstruturaForEach.Executar},
        // Classes e metodos
        {"Membros - Classes e Metodos", Membros.Executar},
        {"Construtores - Classes e Metodos", Construtores.Executar},
        {"Metodos com retorno - Classes e Metodos", MetodosComRetorno.Executar},
        {"Desafio Atributo  - Classes e Metodos", DesafioAtributo.Executar},
        {"Params - Classes e Metodos", Params.Executar},
        {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
        {"Getters e Setters - Classes e Metodos", GetSet.Executar},
        {"Propriedades - Classes e Metodos", Props.Executar},
        {"ReadOnlye - Classes e Metodos", ReadOnly.Executar},
        {"Struct vs Classe - Classes e Metodos", StructVsClasse.Executar},
        {"Parametros Por Referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
        //Colecoes
        {"Array Colecoes - Classes e Metodos", ArrayColecao.Executar},
        {"List Colecoes - Classes e Metodos", ListColecao.Executar},
        {"Array ListColecoes - Classes e Metodos", ArrayListColecao.Executar},
        {"Set Colecoes - Classes e Metodos", SetColecao.Executar},
        {"Queue Colecoes - Classes e Metodos", QueueColecao.Executar},
        {"IgualdadeColecoes - Classes e Metodos", IgualdadeColecao.Executar},
        {"Stack Colecoes - Classes e Metodos", StackColecao.Executar},
        {"Dictionary Colecoes - Classes e Metodos", DictionaryColecao.Executar},
    });

      central.SelecionarEExecutar();
    }
  }
}