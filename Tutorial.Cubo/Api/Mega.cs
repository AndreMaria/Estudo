using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;

namespace Api
{
    public class Mega
    {
        public List<int[]> getList()
        {
            List<int[]> list = new List<int[]>();
            list.Add(new int[] { 06, 18, 20, 24, 43, 48 });
            list.Add(new int[] { 01, 09, 24, 38, 48, 49 });
            list.Add(new int[] { 09, 13, 16, 17, 36, 47 });
            list.Add(new int[] { 07, 24, 29, 39, 45, 52 });
            list.Add(new int[] { 10, 16, 32, 40, 42, 54 });
            list.Add(new int[] { 06, 10, 24, 29, 43, 55 });
            list.Add(new int[] { 03, 12, 24, 40, 51, 52 });
            list.Add(new int[] { 01, 03, 10, 17, 23, 24 });
            list.Add(new int[] { 08, 23, 35, 39, 56, 59 });
            list.Add(new int[] { 02, 14, 15, 19, 35, 59 });
            list.Add(new int[] { 10, 16, 21, 29, 44, 55 });
            list.Add(new int[] { 02, 08, 09, 15, 22, 34 });
            list.Add(new int[] { 04, 17, 18, 37, 52, 56 });
            list.Add(new int[] { 03, 10, 23, 36, 43, 52 });
            list.Add(new int[] { 10, 26, 28, 51, 53, 59 });
            list.Add(new int[] { 05, 11, 13, 19, 30, 31 });
            list.Add(new int[] { 02, 03, 14, 20, 30, 46 });
            list.Add(new int[] { 01, 17, 38, 43, 45, 47 });
            list.Add(new int[] { 12, 16, 30, 52, 53, 58 });
            list.Add(new int[] { 09, 34, 42, 45, 46, 59 });
            list.Add(new int[] { 20, 22, 36, 38, 41, 43 });
            list.Add(new int[] { 10, 15, 16, 19, 28, 35 });
            list.Add(new int[] { 25, 31, 33, 39, 43, 45 });
            list.Add(new int[] { 11, 28, 37, 45, 54, 60 });
            list.Add(new int[] { 16, 17, 20, 22, 38, 50 });
            list.Add(new int[] { 04, 21, 25, 33, 36, 46 });
            list.Add(new int[] { 03, 09, 18, 23, 50, 52 });
            list.Add(new int[] { 02, 20, 21, 33, 48, 57 });
            list.Add(new int[] { 16, 29, 33, 39, 42, 44 });
            list.Add(new int[] { 04, 14, 17, 43, 52, 56 });
            list.Add(new int[] { 10, 13, 33, 35, 36, 42 });
            list.Add(new int[] { 16, 18, 23, 30, 32, 33 });
            list.Add(new int[] { 06, 09, 15, 22, 39, 48 });
            list.Add(new int[] { 11, 40, 43, 45, 47, 57 });
            list.Add(new int[] { 04, 10, 13, 23, 27, 57 });
            list.Add(new int[] { 03, 25, 35, 38, 44, 48 });
            list.Add(new int[] { 06, 27, 33, 39, 40, 60 });
            list.Add(new int[] { 29, 35, 43, 54, 56, 57 });
            list.Add(new int[] { 12, 15, 18, 21, 51, 56 });
            list.Add(new int[] { 09, 10, 15, 28, 43, 45 });
            list.Add(new int[] { 02, 07, 09, 18, 21, 25 });
            list.Add(new int[] { 11, 12, 26, 30, 37, 53 });
            list.Add(new int[] { 08, 11, 27, 28, 43, 46 });
            list.Add(new int[] { 20, 23, 35, 36, 44, 48 });
            list.Add(new int[] { 12, 34, 45, 53, 55, 58 });
            list.Add(new int[] { 09, 22, 25, 47, 52, 58 });
            list.Add(new int[] { 03, 06, 14, 15, 21, 25 });
            list.Add(new int[] { 02, 03, 05, 10, 15, 34 });
            list.Add(new int[] { 21, 31, 35, 53, 54, 57 });
            list.Add(new int[] { 16, 17, 19, 28, 45, 58 });
            list.Add(new int[] { 06, 17, 22, 30, 37, 50 });
            list.Add(new int[] { 01, 03, 19, 23, 47, 58 });

            return list;
        }

        public List<int> GetAll() {
            int[] list = new int[]{
                      06, 18, 20, 24, 43, 48
                    , 01, 09, 24, 38, 48, 49
                    , 09, 13, 16, 17, 36, 47
                    , 07, 24, 29, 39, 45, 52
                    , 10, 16, 32, 40, 42, 54
                    , 06, 10, 24, 29, 43, 55
                    , 03, 12, 24, 40, 51, 52
                    , 01, 03, 10, 17, 23, 24
                    , 08, 23, 35, 39, 56, 59
                    , 02, 14, 15, 19, 35, 59
                    , 10, 16, 21, 29, 44, 55
                    , 02, 08, 09, 15, 22, 34
                    , 04, 17, 18, 37, 52, 56
                    , 03, 10, 23, 36, 43, 52
                    , 10, 26, 28, 51, 53, 59
                    , 05, 11, 13, 19, 30, 31
                    , 02, 03, 14, 20, 30, 46
                    , 01, 17, 38, 43, 45, 47
                    , 12, 16, 30, 52, 53, 58
                    , 09, 34, 42, 45, 46, 59
                    , 20, 22, 36, 38, 41, 43
                    , 10, 15, 16, 19, 28, 35
                    , 25, 31, 33, 39, 43, 45
                    , 11, 28, 37, 45, 54, 60
                    , 16, 17, 20, 22, 38, 50
                    , 04, 21, 25, 33, 36, 46
                    , 03, 09, 18, 23, 50, 52
                    , 02, 20, 21, 33, 48, 57
                    , 16, 29, 33, 39, 42, 44
                    , 04, 14, 17, 43, 52, 56
                    , 10, 13, 33, 35, 36, 42
                    , 16, 18, 23, 30, 32, 33
                    , 06, 09, 15, 22, 39, 48
                    , 11, 40, 43, 45, 47, 57
                    , 04, 10, 13, 23, 27, 57
                    , 03, 25, 35, 38, 44, 48
                    , 06, 27, 33, 39, 40, 60
                    , 29, 35, 43, 54, 56, 57
                    , 12, 15, 18, 21, 51, 56
                    , 09, 10, 15, 28, 43, 45
                    , 02, 07, 09, 18, 21, 25
                    , 11, 12, 26, 30, 37, 53
                    , 08, 11, 27, 28, 43, 46
                    , 20, 23, 35, 36, 44, 48
                    , 12, 34, 45, 53, 55, 58
                    , 09, 22, 25, 47, 52, 58
                    , 03, 06, 14, 15, 21, 25
                    , 02, 03, 05, 10, 15, 34
                    , 21, 31, 35, 53, 54, 57
                    , 16, 17, 19, 28, 45, 58
                    , 06, 17, 22, 30, 37, 50
                    , 01, 03, 19, 23, 47, 58
            };

            return list.ToList();
        }

        public List<Sorteio> GetSorteios()
        {
            var result = GetAll().GroupBy(x => x)
            .OrderByDescending(x => x.Count())
            .Select(n => new Sorteio { Numero = n.Key, Vezes = n.Count() }).ToList();
            return result;
        }

        public List<int> NovoSorteio()
        {
            Random randNum = new Random();
            List<int> newSorteio = new List<int>();
            var sorteiosPassados = GetSorteios().Take(35).ToList();
            var listRandom = ListRandom();
            for (int i = 0; i < 6; i++)
            {
                newSorteio.Add(sorteiosPassados[listRandom[i]].Numero);
            }

            return newSorteio;
        }

        private List<int> ListRandom()
        {
            int count = 0;
            List<int> list = new List<int>();
            while (count < 6)
            {
                var ram = new Random().Next(0, 20);
                if (!list.Contains(ram))
                {
                    list.Add(ram);
                    count++;
                }
            }
            return list;
        }

        public List<Estatistica> GetTop20()
        {
            List<Estatistica> est = new List<Estatistica>();
            var sorteiosPassados = GetSorteios().Take(35).ToList();
            int start = 12;
            List<int> valores = null;

            foreach (var item in sorteiosPassados)
            {
                if (item.Vezes == start)
                {
                    valores.Add(item.Numero);
                }
                else
                {
                    est.Add(new Estatistica() { Vezes = start, Valores = valores });
                    start--;
                    valores = new List<int>();
                    valores.Add(item.Numero);
                }
            }
            return est;
        }

        public List<int> GerarSorteioTop10()
        {
            List<int> list = new List<int>();
            int start = 11;
            var top10 = GetTop20();
            int valorCurrent = 0;
            for (int i = 11; i > 0; i--)
            {
                var current = top10.Where(x => x.Vezes == i);

                foreach (var item in current)
                {
                    if (null != item.Valores)
                    {
                        valorCurrent = item.Valores.FirstOrDefault();
                        list.Add(valorCurrent);
                        break;
                    }
                }
                current.Where(x => x.Valores.Remove(valorCurrent));
            }

            return list;
        }
    }

    public class Sorteio
    {
        public int Numero { get; set; }
        public int Vezes { get; set; }
    }

    public class Estatistica
    {
        public int Vezes { get; set; }
        public List<int> Valores { get; set; }
    }
}