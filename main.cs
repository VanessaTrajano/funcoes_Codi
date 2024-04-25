using System;

class Program {
  public static void Main (string[] args) {
    // Exercício 1 ----------------------------------
    // Faça uma função para o programa dos triângulos, a função deve receber como parâmetro as medidas, e retorna o perímetro do triângulo.
    Console.WriteLine(perimetro(3,8,9));
  }

  public static int perimetro(int lado1, int lado2, int lado3){
    return lado1+lado2+lado3;
  }
}