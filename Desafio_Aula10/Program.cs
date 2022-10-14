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

            try
            {
                Origem_Destino destinoSelect = EscolherDestino();

                FormaDePassagem formaPassagemSelecionada = EscolherFormaDePassagem(listaOpcoesFormasDePassagemn);

                double valorPassagem = formaPassagemSelecionada.CalcularValorPassagem(destinoSelect.ValorViagem);

                Console.WriteLine($"Valor da passagem: R$ {valorPassagem}\n");

                PoltronasViewModel poltronaSelect = EscolherPoltrona();

                Seguro seguro = EscolherSeguro();

                TiposPassageiro tipoPassageiroSelecionado = EscolherTipoDePassagem(listaOpcoesDePassagem);

                tipoPassageiroSelecionado.CalcularTotalPagamento(valorPassagem, seguro, poltronaSelect);

                servidorPassagem.Salvar(tipoPassageiroSelecionado, destinoSelect, formaPassagemSelecionada);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
      
        }

        private static TiposPassageiro EscolherTipoDePassagem(List<TiposPassageiro> listaOpcoesDePassagem)
        {
            bool EscolheuTipoPassageiro = false;
            TiposPassageiro tipoPassageiroSelecionado = null;
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Escolha o tipo de sua Passagem:");
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
                    Console.WriteLine("Poltronas disponíveis: P1 a P30\n");
                    Console.WriteLine("Poltronas de 1 a 5 com desconto de 15%\n");
                    Console.WriteLine("Escolha a forma de Passagem:");
                    foreach (var formaDisponivel in listaOpcoesFormasDePassagemn)
                    {
                        Console.WriteLine($"Digite {formaDisponivel.Id_FormaDePassagem} para {formaDisponivel.FormaPassagem}");
                    }

                    string id_formaPassagem = Console.ReadLine();
                    Console.WriteLine();
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

        private static Origem_Destino EscolherDestino()
        {
            bool EscolheuDestino = false;
            Origem_Destino destinoSelecionado = null;
            do
            {
                try
                {
                    Console.WriteLine("Embarque de São Leopoldo");
                    Console.WriteLine("Escolha seu destino:\n");
                    foreach (var destinoDisponivel in Origem_DestinoDB.ListaDestinos)
                    {
                        Console.WriteLine($"{destinoDisponivel}");
                    }
                    Console.WriteLine();
                    Console.Write("Destino: ");
                    string destino = Console.ReadLine();
                    Console.WriteLine();
                    destinoSelecionado = ValidacaoDestino.ValidadarDestinoExistente(destino);
                    destinoSelecionado.CalculoValorPassagem(destino);
                    EscolheuDestino = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Tente novamente!");
                }

            } while (EscolheuDestino == false);
            return destinoSelecionado;
        }

        private static Seguro EscolherSeguro()
        {
            bool EscolheuSeguro = false;
            Seguro seguro_ = null;
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite 1 caso queira Seguro Passagem: *acréscimo de 3% ");
                    Console.WriteLine("Digite 2 caso não queira Seguro Passagem");
                    int Id_Seguro = int.Parse(Console.ReadLine());
                    if(Id_Seguro == 1 || Id_Seguro == 2)
                    {
                        seguro_ = new Seguro(Id_Seguro);
                        EscolheuSeguro = true;
                    }                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Opção inexistente. Tente novamente!");
                }

            } while (EscolheuSeguro == false);
            return seguro_;
        }

    }
}






