using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace pooCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string vCPF;
            CPF cpf = new CPF();
            cpf.nome = "Paulo";
            System.Console.WriteLine(cpf.Saudar());

            cpf.cpf = "000.000.000-00";
            vCPF = cpf.cpf; 
            Console.WriteLine(cpf.validarCPF(vCPF));

        }
    }
}
