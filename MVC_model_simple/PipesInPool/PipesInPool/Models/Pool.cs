using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool.Models
{
    public class Pool
    {
        public Pool(int v, int p1, int p2, float n)
        {
            V = v;
            P1 = p1;
            P2 = p2;
            N = n;
        }

        public int V { get; set; }
        public float Vafter { get; set; }
        public int P1 { get; set; }
        public float V1 { get; set; }
        public int P2 { get; set; }
        public float V2 { get; set; }
        public float N { get; set; }

        public string Fill()
        {
            V1 = P1 * N;
            V2 = P2 * N;
            Vafter = (V1 + V2) * 100 / V;
            if (Vafter > V)
            {
                return $"For {N} hours the pool overflows with {Vafter - V} liters.";
            }
            else
            {
                V1 = V1 * 100 / Vafter;
                V2 = V2 * 100 / Vafter;
                return $"The pool is {Vafter:0.00}% full. Pipe 1: {V1:0.00}%. Pipe 2: {V2:0.00}%.";
            }
        }
    }
}
