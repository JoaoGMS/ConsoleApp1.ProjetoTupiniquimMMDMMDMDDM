using System;

namespace ConsoleApp1.ProjetoTupiniquimMMDMMDMDDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comando = "MMDMMDMDDM";

            char sentido = 'N';
            int LocalizacaoX = 3;
            int LocalizacaoY = 3;

            char[] instruçoes = comando.ToCharArray();

            for (int posição = 0; posição < instruçoes.Length; posição = posição + 1) //posição = posição + 1) = posição++
            {
                if (instruçoes[posição] == 'M')
                {
                    if (sentido == 'N')
                        LocalizacaoY = LocalizacaoY + 1;
                    else if (sentido == 'S')
                        LocalizacaoY = LocalizacaoY - 1;

                    if (sentido == 'L')
                        LocalizacaoX = LocalizacaoX + 1;
                    else if (sentido == 'O')
                        LocalizacaoX = LocalizacaoX - 1;
                }

                if (instruçoes[posição] == 'E')
                {
                    if (sentido == 'N')
                        sentido = 'O';
                    else if (sentido == 'O')
                        sentido = 'S';
                    else if (sentido == 'S')
                        sentido = 'L';
                    else if (sentido == 'L')
                        sentido = 'N';

                }

                if (instruçoes[posição] == 'D')
                {
                    if (sentido == 'N')
                        sentido = 'L';
                    else if (sentido == 'O')
                        sentido = 'N';
                    else if (sentido == 'S')
                        sentido = 'O';
                    else if (sentido == 'L')
                        sentido = 'S';
                    // sentido = 'L';
                    Console.WriteLine(LocalizacaoX + "  " + LocalizacaoY + "  " + sentido);
                    Console.ReadLine();
                }



            }
        }
    }
}
