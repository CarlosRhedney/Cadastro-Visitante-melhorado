using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, visit, rgpesq, cad, pesq, rg;
            int and, tel;

                Console.Write("\nDigite o nome completo do visitante: ");
                nome = Console.ReadLine();
                Console.Write("\nDigite o rg do visitante: ");
                rg = Console.ReadLine();
                Console.Write("\nDigite o nome da pessoa a ser visitada: ");
                visit = Console.ReadLine();
                Console.Write("\nDigite um telefone para contato: ");
                tel = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nDigite o andar visitado: ");
                and = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nNome: {0}\tRG: {1}", nome, rg);
                Console.Write("\nPessoa Visitada: {0}\tTel: {1} ", visit, tel);
                Console.Write("\nAndar Visitado: {0}º andar ", and);
                Console.Write("\nCadastro realizado com sucesso!");
                Console.Write("\n********************************************************************************");
                Console.Write("\nDeseja continuar com mais cadastros?\nDigite \'s\' para sim ou \'n\' para não: ");
                cad = Console.ReadLine();
            while (cad.ToLower() == "s")
            {
                Console.Write("\nDigite o nome completo do visitante: ");
                nome = Console.ReadLine();
                Console.Write("\nDigite o rg do visitante: ");
                rg = Console.ReadLine();
                Console.Write("\nDigite o nome da pessoa a ser visitada: ");
                visit = Console.ReadLine();
                Console.Write("\nDigite um telefone para contato: ");
                tel = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nDigite o andar visitado: ");
                and = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nNome: {0}\tRG: {1}", nome, rg);
                Console.Write("\nPessoa Visitada: {0}\tTel: {1} ", visit, tel);
                Console.Write("\nAndar Visitado: {0}º andar ", and);
                Console.Write("\nCadastro realizado com sucesso!");
                Console.Write("\n********************************************************************************");
                Console.Write("\nDeseja continuar com mais cadastros?\nDigite \'s\' para sim ou \'n\' para não: ");
                cad = Console.ReadLine();
            }
                if (cad != "s")
                    Console.Write("\nDeseja pesquisar algum cadastro?\nDigite \'s\' para sim ou \'n\' para sair: ");
                    pesq = Console.ReadLine();
            while (pesq.ToLower() == "s")
            {
                Console.Write("\nDigite o RG do cadastro a ser pesquisado: ");
                rgpesq = Console.ReadLine();
            if (rgpesq == rg)
                Console.Write("\nNome: {0}\tRG: {1}", nome, rg);
                Console.Write("\nPessoa Visitada: {0}\tTel: {1} ", visit, tel);
                Console.Write("\nAndar Visitado: {0}º andar ", and);
                Console.Write("\n********************************************************************************");
                Console.Write("\nDeseja pesquisar mais algum cadastro?\nDigite \'s\' para sim ou \'n\' para sair:");
                pesq = Console.ReadLine();
            }
        }
    }
}
