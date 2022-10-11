using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public static class DB_ContextPoltronas
    {
        public static List<string> ListaPoltronas;

        static DB_ContextPoltronas()
        {
            ListaPoltronas = new List<string>();

            InicializaDB();

        }

        public static void InicializaDB()
        {
            for (int i = 1; i < 31; i++)
            {
                ListaPoltronas.Add($"P{i}");
            }
           
        }
    }
}
