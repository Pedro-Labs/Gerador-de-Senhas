using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeSenhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int comprimentoSenha = 12; // Comprimento da senha
            string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*"; // Caracteres permitidos na senha

            // Cria uma instância do gerador de números aleatórios
            Random random = new Random();

            // Cria um StringBuilder para construir a senha
            StringBuilder senhaBuilder = new StringBuilder();

            // Gera a senha aleatória
            for (int i = 0; i < comprimentoSenha; i++)
            {
                int index = random.Next(caracteresPermitidos.Length);
                char caractere = caracteresPermitidos[index];
                senhaBuilder.Append(caractere);
            }

            string senhaGerada = senhaBuilder.ToString();

            Console.WriteLine("Senha gerada: " + senhaGerada);
        }
    }
}
