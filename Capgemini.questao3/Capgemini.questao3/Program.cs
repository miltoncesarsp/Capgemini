string frase, resultado = "";
int qtdletras,colunas,contador=0;
char[,] grid;

//Entrada da palavra ser encriptada
Console.WriteLine("Questão 3: Encriptado");
Console.WriteLine("Digite a palavra ou frase que deseja encriptar:");
frase = Console.ReadLine();
//Remoção dos espaços
frase = frase.Replace(" ","");
//Descobrindo a quantidade de letras e a quantidade de linhas/colunas
qtdletras = frase.Length;
colunas = Convert.ToInt32(Math.Ceiling(Math.Sqrt(qtdletras)));
grid = new char[colunas, colunas];
//Encriptando utilizando matriz
for (int i = 0; i < grid.GetLength(0); i++)
    for(int j = 0; j < grid.GetLength(0); j++)
    {
        if (contador < frase.Length)
        {
            grid[j, i] = frase[contador];
            contador++;
        }
    }
//Exibição do código encriptado
for (int i = 0; i < grid.GetLength(0); i++)
{
    for (int j = 0; j < grid.GetLength(1); j++)
    {
        resultado += grid[i, j];
    }
    resultado += " ";
}
    
Console.WriteLine(resultado);