using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Operacoes
    {
                double resultado;
        public void Somar (double x, double y)
        {
            resultado = x + y;
            Console.WriteLine($"{x} + {y} = {resultado.ToString("0.00")}");
        }

          public void Subtrair (double x, double y)
        {
            resultado = x - y;
            Console.WriteLine($"{x} - {y} = {resultado.ToString("0.00")}");
        }

          public void Dividir (double x, double y)
        {
            resultado = x / y;
            Console.WriteLine($"{x} / {y} = {resultado.ToString("0.00")}");
        }

          public void Multiplicar (double x, double y)
        {
            resultado = x * y;
            Console.WriteLine($"{x} * {y} = {resultado.ToString("0.00")}");
        }

        //Fazendo Potencia 
        public void Potencia (double x, double y)
        {
          double resultado = Math.Pow(x, y); //Utilizado para calcular potência
          Console.WriteLine($"Potencia: \n {x}^{y} = {resultado}");
        }

        //Inserindo funções trigonométricas 
        public void Seno(double angulo)
        {
          double radiano = angulo * Math.PI / 180;
          double seno = Math.Sin(radiano);
          Console.WriteLine($"Seno de {angulo} = { Math.Round (seno, 4)}");
        }

        public void Coseno(double angulo)
        {
          double radiano = angulo * Math.PI / 180;
          double coseno = Math.Cos(radiano);
          Console.WriteLine($"Seno de {angulo} = {Math.Round (coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
          double radiano = angulo * Math.PI / 180;
          double tangente = Math.Tan(radiano);
          Console.WriteLine($"Seno de {angulo} = { Math.Round (tangente, 4)}");
        }

        //Raiz Quadrada 
        public void RaizQuadrada(double x){
          resultado = Math.Sqrt(x); //Função para encontrar raiz quadrada
          Console.WriteLine($"Raiz Quadrada de {x} = {resultado}");
        }

    }


}
