int qtdnumeros;
int diferenca;
int[] numeros;
int ocorre = 0;

//Solicitação de entrada de informações
Console.WriteLine("Questão 2: Diferença");
Console.WriteLine("Digite o número que será usado como referência para a diferença entre os números que serão digitados: ");
diferenca = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de números que quer verificar a diferença de "+diferenca+": ");
qtdnumeros = int.Parse(Console.ReadLine());
//Criação de vetor com quantidade estipulada pelo usuário
numeros = new int[qtdnumeros];
//Atribuição dos valores dos números ao vetor
for (int i = 0; i < qtdnumeros; i++)
{
    Console.WriteLine("Digite o " + (i+1) + "º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}
//Busca pelos pares de números com a diferença estipulada pelo usuário
for (int i = 0; i < qtdnumeros-1; i++)
{
    for (int j = i+1; j < qtdnumeros; j++)
    {
        if(numeros[i]-diferenca == numeros[j] || numeros[i]+diferenca == numeros[j]){
            ocorre++;
}
    }
}

Console.WriteLine("Foram encontrados "+ocorre+" pares dentre os digitados com a diferença escolhida.");