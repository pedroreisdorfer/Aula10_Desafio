using System;
using System.Collections.Generic;

namespace Desafio_Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            DB_ContextPoltronas.InicializaDB();

            List<TiposPassageiro> listaOpcoesDePassagem = new List<TiposPassageiro> { new PassagemNormal(), new PassagemEstudante(), new PassagemAposentado(), new PassagemDeficiente() };

            List<FormaDePassagem> listaOpcoesFormasDePassagemn = new List<FormaDePassagem> { new Digital(), new Impressa()};

            ServidorPassagem servidorPassagem = new ServidorPassagem();

            Console.Write("Escolha sua Origem: ");
            string origem = Console.ReadLine(); // validação contra número. Em um programa mais completo, colocar lista de opção de origem
            Console.Write("Escolha sua Destino: ");
            string destino = Console.ReadLine();
            Origem_Destino origem_Destino = new Origem_Destino(origem, destino); // PASSADO DENTRO DO OBJETO PASSAGEM COMO PARÂMETRO DE ENTRADA

            origem_Destino.Origem = origem;
            origem_Destino.Destino = destino;

            Console.WriteLine();

            FormaDePassagem formaPassagemSelecionada = EscolherFormaDePassagem(listaOpcoesFormasDePassagemn);

            double valorPassagem = formaPassagemSelecionada.CalcularValorPassagem(60.00);

            Console.WriteLine($"Valor da passagem: R$ {valorPassagem}"); // Pode ser mais complexo caso seja variado conforme origem/destino

            // Deseja continuar com a compra? Digite uma para continuar. 2 para cancelar passagem

            Console.WriteLine("Poltronas disponíveis: P1 a P30");

            Console.WriteLine();

            Console.WriteLine("Poltronas de 1 a 5 com desconto de 15%");

            Console.WriteLine();

            PoltronasViewModel poltronaSelect = EscolherPoltrona();

            Console.WriteLine();

            Console.WriteLine("Digite 1 caso queira Seguro Passagem: *acréscimo de 3% ");
            Console.WriteLine("Digite 2 caso não queira Seguro Passagem");
            int Id_Seguro = int.Parse(Console.ReadLine());

            Seguro seguro_ = new Seguro(Id_Seguro);

            Console.WriteLine();

            TiposPassageiro tipoPassageiroSelecionado = EscolherTipoDePassagem(listaOpcoesDePassagem);
            
            tipoPassageiroSelecionado.CalcularTotalPagamento(valorPassagem, seguro_, poltronaSelect);

            servidorPassagem.Salvar(tipoPassageiroSelecionado, origem_Destino, formaPassagemSelecionada); // AQUI ESTÃO SENDO SALVOS OS ITENS PARA IMPRESSÃO DA PASSAGEM

        }

        private static TiposPassageiro EscolherTipoDePassagem(List<TiposPassageiro> listaOpcoesDePassagem)
        {
            bool EscolheuTipoPassageiro = false;
            TiposPassageiro tipoPassageiroSelecionado = null;
            do
            {
                try
                {
                    Console.WriteLine("Escolha o meio de Pagamento de sua Passagem:");
                    foreach (var tipoDisponivel in listaOpcoesDePassagem)
                    {
                        Console.WriteLine($"Digite {tipoDisponivel.Id_TipoPassageiro} para {tipoDisponivel.TipoPassageiro}");
                    }

                    string id_tipoPassageiro = Console.ReadLine();
                    tipoPassageiroSelecionado = TipoPassageiroFactory.ValidadorTipoPassageiro(id_tipoPassageiro);
                    EscolheuTipoPassageiro = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Tente novamente!");
                }

            } while (EscolheuTipoPassageiro == false);
            return tipoPassageiroSelecionado;
        }
        private static FormaDePassagem EscolherFormaDePassagem(List<FormaDePassagem> listaOpcoesFormasDePassagemn)
        {
            bool EscolheuFormaDePassagem = false;
            FormaDePassagem formaPassagemSelecionada = null;
            do
            {
                try
                {
                    Console.WriteLine("Escolha a forma de Passagem:");
                    foreach (var formaDisponivel in listaOpcoesFormasDePassagemn)
                    {
                        Console.WriteLine($"Digite {formaDisponivel.Id_FormaDePassagem} para {formaDisponivel.FormaPassagem}");
                    }

                    string id_formaPassagem = Console.ReadLine();
                    formaPassagemSelecionada = FornaDePassagemFactory.ValidaFormaPassagem(id_formaPassagem);
  
                    EscolheuFormaDePassagem = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Tente novamente!");
                }

            } while (EscolheuFormaDePassagem == false);
            return formaPassagemSelecionada;
        }

        private static PoltronasViewModel EscolherPoltrona()
        {
            bool EscolheuPoltrona = false;
            PoltronasViewModel poltrona = null;
            do
            {
                try
                {
                    Console.Write("Que Poltrona você deseja? ");
                    string POLTRONA_SELECIONADA = Console.ReadLine();
                    poltrona = ValidacaoPoltrona.ValidadarPoltronaExistente(POLTRONA_SELECIONADA);
                    
                    EscolheuPoltrona = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Tente novamente!");
                    Console.WriteLine();
                }
            } while (EscolheuPoltrona == false);
            return poltrona;
        }
    }
}

