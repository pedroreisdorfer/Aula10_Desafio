using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class Seguro
    {
        public int Id_Seguro { get; set; }

        public double ValorSeguro { get; set; }

        //public decimal ValorSemSeguro { get => 0,00; }
        // CREIO QUE terá que ser feito com o seguro com é feito com tipo passagem

        public Seguro(int tipo)
        {

            if (tipo == 1)
            {
                ValorSeguro = 0.03;
            }
            if (tipo == 2)
            {
                ValorSeguro = 0;
            }

            // mas aqui precisa ter validação caso seja digitado outro número

        }

        //public void RetornarSeguro()
        //{

        //}

        // if Id == 0, seguro é zero
        // if Id == 1, seguro é 3%


        //public static int ComSeguro = 1;
        //public static int SemSeguro = 2;

        //public double criar(int tipo)
        //{
        //    if (tipo == ComSeguro)
        //    {
        //        ValorSeguro = 0.03;
        //        return ValorSeguro;
        //    }
        //    if (tipo == SemSeguro)
        //    {
        //        ValorSeguro = 0.00;
        //        return ValorSeguro;
        //    }

        //    throw new Exception("Tipo de janela invalida [" + tipo + "]");

        //}
    }
}
