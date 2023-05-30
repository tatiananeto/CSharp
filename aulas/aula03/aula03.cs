using System;
  class aula03{
    static void Main(){
      int num = 0; //declaração de variavel e inicialização de variavel int aceita sinais negativos
      char letra ='c';
      float valor = 5.3f;
      byte n1 = 10; // inteiro de 8 bites dem sinal armazena de 0 a 255
      string nome = "Tatiana";

      var aux = nome; // var nao especifica o tipo da variavel, o tipo e definido no acto da compilacao de acordo com o dado que recebeu na atribuicao 

    Console.WriteLine("valor da variavel é : " + aux);// 0 + ´epara concatenar imprimir o texto e o valor armazenado em uma variavel
      
      int num1, num2, res;
      num1 = 10;
      num2 = 2;
      res = num1 * num2;
      Console.WriteLine("a multiplicação de " + num1 + " com " + num2 + " é igual a " + res);

    }
  }