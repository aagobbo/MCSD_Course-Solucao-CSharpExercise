using System.Collections.Generic;

namespace Exercicio12
{
    public interface Sorteio
    {
        SortedSet<int> Jogos { get; set; }
        System.DateTime data { get; set; }
        int id { get; set; }

        

    }
}