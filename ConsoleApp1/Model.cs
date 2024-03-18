using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI20N
{
    class Model
    {

        //Contrutor
        public Model()
        {

        }//Fim do Método Construtor

        //Exercício 01: Faça um programa que imprima os números de 1 a 10.
        public string ExercicioUm()
        {
            string resultado = "";

            for (int i = 0; i < 10; i++)
            {
                resultado += "\n" + (i + 1);
            }

            return resultado;
        }//Fim do Método

        //Exercício 02: Faça um programa que imprima os números pares de 1 a 20.
        public string ExercicioDois()
        {
            string resultado = "";

            for (int i = 0; i < 20; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    resultado += "\n" + (i + 1);
                }//Fim do If
            }//Fim do For

            return resultado;
        }//Fim do Exercício Dois

        //Exercicio 03: Faça um programa que calcule a soma dos números de 1 a 100.
        public int ExercicioTres()
        {
            int resultado = 0;
            for (int i = 1; i <= 100; i++)
            {
                resultado += i;
            }//Fim da For

            return resultado;
        }//Fim do Exercício Três

        //Exercício 04: Faça um programa que imprima os múltiplos  de 5 de 1 a 50.
        public string ExercicioQuatro()
        {
            string resultado = "";
            for (int i = 1; i <= 50; i++)
            {
                if ((i + 1) % 5 == 0)
                {
                    resultado += "\n" + (i + 1);
                }//Fim do If
            }//Fim da For

            return resultado;
        }//Fim do Exercício Quatro

        //Exercício 05: Faça um programa que peça ao usuário um número e imprima se é par ou impar.
        public string ExercicioCinco(int num)
        {
            if (num % 2 == 0)
            {
                return "O número informado é par";
            }
            else
            {
                return "O número informado é ímpar";
            }
        }//Fim do Exercício Cinco

        //Exercício 06: Faça um programa que peça ao usuário um número e imprima se é positivo, negativo ou zero.
        public string ExercicioSeis(int num)
        {
            if (num > 0)
            {
                return "O número informado é positivo!";
            }
            else if (num < 0)
            {
                return "O número informado é negativo!";
            }
            else
            {
                return "O número informado é zero!";
            }//Fim do If
        }//Fim do Exercício Seis

        //Exercício 07: Faça um programa que peça ao usuário um número e imprima a tabauada desse número.
        public string ExercicioSete(int num)
        {
            string resultado = "";
            resultado += " Tabuada de " + num;
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n " + num + " * " + i + " = " + (num * i);
            }//Fim do For
            return resultado;
        }//Fim do Exercício 07

        //Exercício 08: Faça um programa que peça ao usuário um número e imprima os números de 1 até esse número.
        public string ExercicioOito(int num)
        {
            string resultado = "";
            for (int i = 0; i < num; i++)
            {
                resultado += "\n" + (i + 1);
            }
            return resultado;
        }//Fim do Exercício Oito

        //Exercício 09: Faça um programa que peça ao usuário um número e imprima a soma dos números de 1 até esse número.
        public int ExercicioNove(int num)
        {
            int resultado = 0;
            for (int i = 1; i <= num; i++)
            {
                resultado += i;
            }
            return resultado;
        }//Fim do Exercício Nove

        //Exercício 10: Faça um programa que imprima os números primos de 1 a 20.
        public string ExercicioDez()
        {
            string primos = "";
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    primos += "" + i;
                }//Fim do If
            }//Fim do For
            return primos;
        }//Fim do Exercício Dez

        //Exercício 11: Faça um programa que peça ao usuário um número e verifique se é primo.
        public bool ExercicioOnze(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }//Fim do If
            }//Fim do For
            return true;
        }//Fim do Exercício Onze

        //Exercicio 13: Faça um programa que imprima e sequência de Fibonacci até o décimo termo.
        public string ExercicioTreze()
        {
            string resultado = "0 1";
            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;
            for (int i = 1; i <= 8; i++)
            {
                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2;
                fib2 = fib3;
            }//Fim do For

            return resultado;
        }//Fim do Exercicio Treze

        //Exercicio 14: Faça um programa que peça ao usuário um número e imprima se é um número de Fibonacci.
        public string ExercicioCatorze(int num)
        {
            string resultado = "0 1";
            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;
            for (int i = 1; i <= num - 2; i++)
            {
                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2;
                fib2 = fib3;
            }//Fim do For

            return resultado;
        }//Fim do Exercicio Catorze

        //Exercício 15: Faça um programa que peça ao usuário um número e calcule a soma dos seus dígitos.
        public int ExercicioQuinze(int num)
        {
            int soma = 0;
            while (num != 0)
            {
                soma += num % 10;
                num /= 10;
            }
            return soma;
        }//Fim do Exercício Quinze

        //Exercício 16: Faça um programa que peça ao usuário um número e imprima os números pares e ímpares de 1 até esse número.
        public string ExercicioDezesseis(int num)
        {
            string par = "";
            string impar = "";

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    par += " " + i;
                }//Fim do If
                else
                {
                    impar += " " + i;
                }//Fim do Else
            }//Fim do For

            return "Pares: " + par + "\nÍmpares: " + impar;

        }//Fim do Exercício Dezesseis





        //exercicio 17: faça um programa  que peça  ao usuario  um numero 
        //e imprima o dobro desse número.

        public int ExercicioDezessete(int num)
        {
            return num * 2;

        }// fim do dezessete


        //exercicio 18: faça um programa que peça ao usuario dois numeros
        //e imprima a media deles
        public double ExercicioDezoito(double num1, double num2)
        {
            return (num1 + num2) / 2;
          
        }//fim do metodo 
        

        // exercicio 19: faça um programa  que converta a 
        //temperatura de celcius  para fahrenheit. A formula  é F = C * 9/5 + 32. 
        public double ExercicioDezenove(double celcius)
        {
            return celcius * 9 / 5 + 32;

        }//fim do metodo


        //Exercicio 20: faça um preograma que  peça o raio  de um  círculo e imprima a area 
        //a formula é  A =  

        public double ExercicioVinte(double raio)
        {
            return Math.PI * Math.Pow(raio, 2);

        }//fim do metodo

    }//Fim do Exercício Vinte Um
     //Exercício 22: Faça um programa que peça dois números e imprima o maior deles.
        public int ExercicioVinteDois(int num3, int num4)
    {
        if (num3 > num4)
        {
            return num3;
        }//Fim do If
        else
        {
            return num4;
        }//Fim do Else
    }//Fim do Exercício Vinte Dois
     //Exercício 23: Faça um programa que peça dois números e imprima "São Iguais" se os números forem iguais ou imprima "São Diferentes" se forem diferentes.
    public string ExercicioVinteTres(int num5, int num6)
    {
        if (num5 == num6)
            if (num5 == num6)
            {
                return "Os números são iguais";
            }//Fim do If
            else
            {
                return "Os números são diferentes";
            }//Fim do Else
    }//Fim do Exercício Vinte Tres

    //Exerc~icio 24: Faça um programa que peça idade do usuário e imprima se ele é maior de idade ou menor de idade.
    //Exercício 24: Faça um programa que peça idade do usuário e imprima se ele é maior de idade ou menor de idade.
    public string ExercicioVinteQuatro(int idade)
    {
        if (idade >= 18) ;

        return "Menor de idade"

    } };,99;@@ public string ExercicioVinteCinco(int num7, int num8);
            }//Fim do Else
        }//Fim do Exercício Vinte Cinco
 
        //Exercício 26: Faça um programa que peça a altura e o peso de uma pessoa e calcule o IMC. A fórmula é IMC = peso / altura^2.
        public double ExercicioVinteSeis(double altura, double peso)
{
        double IMC = 0;
        IMC = altura / (Math.Pow(peso, 2));
        return "O IMC é: " + IMC;
}//Fim do Exercício Vinte Seis

//Exercício 27: Faça um algorítimo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade apenas em dias. Considerar ano com 365 dias e mês com 30 dias.
    public int ExercicioVinteSete(int ano, int mes, int dia)
    {   
    return ano * 365 + mes * 30 + dia;
    }//Fim do Exercício Vinte Sete

//Exercício 28: Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa. Sabendo-se que ele recebe uma comissão 3% sobre o total das vendas até R$ 1.500,00 mais 5% sobre o que ultrapassar este valor, calcular e escrever o seu salário total
    public double ExercicioVinteOito(double salarioFixo,Double valorVendas)
    {
        double salarioFinal = 0;
        if (valorVendas <= 1500)
    }
    else 
    {
        salarioFixo + (valorVendas * 0.03) + salarioFixo

    }
    else
    {
        salarioFinal = (1500 * 0, 03) + ((valorVendas - 1500) * 0.05) + salarioFixo;
    }
    return salarioFinal;

}//Fim do Exercício Vinte Oito

//Exercício 29: Ler 10 valores e escrever quantos desses valores lidos são negativos.
    public void ExercicioVinteNove()
    {   
        int num = 0;
        int cont = 0;
    }
    
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine("Informe um número: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            cont++;
        }//Fim do If
    }//Fim da For

    return "A quantidade de números negativos são: " + cont;
}//Fim do Exercício Vinte Nove

//Exercício 30: Escreva um algoritmo para ler 10 números. Todos os números lidos com valor inferior a 40 devem ser somados. Escreva o valor final da soma efetuada.
public void ExercicioTrinta()
{
    int soma = 0;
    int num = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Informe um número: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num < 40)
        {
            soma += num;
        }//Fim do If
    }//Fim da For

    Console.WriteLine ("A soma dos valores inferiores a 40 é: " + soma);

}//Fim do Exercício Trinta

//Exercicio 31:Escreva um algoritmo que permita a leitura das notas de uma turma de 20 alunos.Calcular a média da turma.Escrever a média da turma.
public string ExercicioTrintaUm()
{
    int soma = 0;
    int media = 0;
    int nota = 0;

    for (int i = 0; i <= 20; i++)
    {
        Console.WriteLine("Informe um número: ");
        nota = Convert.ToInt32(Console.ReadLine());

        soma += nota;

    }//Fim do For

    media = soma / 20;

    return "A média da turma é: " + media;

}//Fim do Exercicio Trinta e Um
    
//Exercício 32: Faça um algoritmo que calcule a quantidade de litros de
        //combustível gasta em uma viagem, utilizando um automóvel
        //que faz 12Km por litro.Para obter o cálculo, o usuário deve
        //fornecer o tempo gasto na viagem e a velocidade média
        //durante ela.Desta forma, será possível obter a distância
        //percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
        //Tendo o valor da distância, basta calcular a quantidade de
        //litros de combustível utilizada na viagem com a fórmula:
        //LITROS_USADOS = DISTANCIA / 12.O programa deve
        //apresentar os valores da velocidade média, tempo gasto na
        //viagem, a distância percorrida e a quantidade de litros
        //utilizada na viagem

 //Exercício 41: Faça um algoritmo que leia os valores de A, B, C e em
        //seguida imprima na tela a soma entre A e B é mostre se a soma é menor que C.

 

        //Exercício 42: Faça um algoritmo que leia dois valores inteiros A e B,
        //se os valores de A e B forem iguais, deverá somar os dois valores,
        //senão deverá multiplicar. Ao final de qualquer um dos cálculos deve-se
        //atribuir o resultado a uma variável C e imprimir na tela.

 

        //Exercício 43: Faça um algoritmo que receba um número inteiro e imprima na
        //tela o seu antecessor e o seu sucessor.

 

        //Exercício 44: Faça um algoritmo que leia o valor do salário mínimo e o
        //valor do salário de um usuário, calcule quantos salários mínimos esse 
        //usuário ganha e imprima na tela o resultado.

 

        //Exercício 45:  Faça um algoritmo que leia três valores inteiros diferentes e
        //imprima na tela os valores em ordem decrescente.

 

        //Exercício 46:Faça um algoritmo que leia quatro notas obtidas por um aluno,
        //calcule a média das nota obtidas, imprima na tela o nome do aluno e 
        //se o aluno foi aprovado ou reprovado.
        //Para o aluno ser considerado aprovado sua média final deve ser maior ou igual a 7.

 

        //Exercício 47: Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o
        //valor de B por A e imprima na tela os valores.

 

        //Exercício 48: Faça um algoritmo que leia o ano em que uma pessoa nasceu,
        //imprima na tela quantos anos, meses e dias essa pessoa ja viveu. Leve em 
        //consideração o ano com 365 dias e o mês com 30 dias. (Ex: 5 anos, 2 meses e 15 dias de vida)

 

        //Exercício 49: Faça um algoritmo que leia três valores que representam os três lados
        //de um triângulo e verifique se são válidos, determine se o triângulo é 
        //equilátero, isósceles ou escaleno.

 

        //Exercício 50: Faça um algoritmo que calcule a quantidade de litros de combustível
        //gastos em uma viagem, sabendo que o carro faz 12km com um litro.
        //Deve-se fornecer ao usuário o tempo que será gasto na viagem a sua velocidade média,
        //distância percorrida e a quantidade de litros utilizados para fazer a viagem.
        // Fórmula: distância = tempo x velocidade.  litros usados = distância / 12.

































       
    }//Fim da Classe
}//Fim do Projeto