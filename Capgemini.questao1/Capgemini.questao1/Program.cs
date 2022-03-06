            //Declaração de Variáveis
            List<int> lista = new List<int>();
            int qtdnumeros;
            Boolean qtdtest = false;

            //Solicitação de entrada da quantidade de números
            Console.WriteLine("Questão 1: Mediana");
            Console.WriteLine("Digite a quantidade de números para encontrar a mediana, lembre-se que precisa ser um número ímpar:");
            do
            {
                //Testando se o valor digitado foi ímpar
                qtdnumeros = int.Parse(Console.ReadLine());
                if (qtdnumeros % 2 != 0)
                {
                    qtdtest = true;
                }
                else { Console.WriteLine("Quantidade de números precisa ser ímpar, tente novamente: "); }
            } while (qtdtest == false);
            
            //Solicitação de entrada dos números para descobrir mediana
            for (int i = 0; i < qtdnumeros; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "º número:");
                lista.Add(int.Parse(Console.ReadLine()));
            }

            //Organizar números em ordem alfabética

            lista.Sort();

            //Apresenta a mediana através de um cálculo
            Console.WriteLine("A Mediana dos números digitados é: " + lista[(qtdnumeros-1)/2]);
