using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_de_recursividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region exercicio 1
        private void Btn_exerc_1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(text_exerc_1.Text);

            int resultado = Fatorial(n);

            MessageBox.Show("O fatorial de " + n + " é " + resultado.ToString(), "Exercicio 1");
        }

        //metodo calcular fatorial
        private int Fatorial(int n)
        {
            if (n <= 0)
                return 1;
            else
                return n * Fatorial(n - 1);
        }
        #endregion
        #region exercicio 2
        private void Btn_fibonacci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(text_exerc_2.Text);

            int resultado = Fibonacci(n);
            MessageBox.Show("O resultado da sequência Fibonacci é " + resultado.ToString(), "Exercicio 2");
        }

        //metodo calcular fibonacci
        private int Fibonacci(int n)
        {

            if (n <= 1)
                return 1;

            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        #endregion
        #region exercicio 3
        private void Btn_exerc_3_Click(object sender, EventArgs e)
        {
            string n = text_exerc_3.Text;
            char[] numeros = n.ToArray();


            string resultado = InverterNumeros(n.Length - 1, numeros);


            MessageBox.Show("lista invertida é " + resultado, "Exercicio 3");
        }
        //metodo para inverter numeros
        private string InverterNumeros(int i, char[] n)
        {
            if (i <= 0)
                return n[i].ToString();


            return n[i].ToString() + InverterNumeros(i - 1, n);
        }
        #endregion
        #region exercicio 4
        private void Btn_exerc_4_Click(object sender, EventArgs e)
        {
            string elementos = text_exerc_4.Text;
            string[] listaElementos = elementos.Split(',');
            int[] elementosInt = new int[listaElementos.Length];

            for (int i = 0; i < listaElementos.Length; i++)
                elementosInt[i] = int.Parse(listaElementos[i]);


            int resultado = SomarVetor(elementosInt.Length - 1, elementosInt);


            MessageBox.Show("A soma do vetor é " + resultado, "Exercicio 4");
        }
        //somar vetor
        private int SomarVetor(int i, int[] numeros)
        {
            if (i <= 0)
                return numeros[i];

            return numeros[i] + SomarVetor(i - 1, numeros);
        }
        #endregion
        #region exercicio 5
        private void Btn_exerc_5_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(text_exerc_5.Text);

            int resultado = SomaNumeros(numero);

            MessageBox.Show("A soma do numero 1 até " + numero + " é " + resultado, "Exercicio 5");
        }
        //metodo somar numero 1 a N
        private int SomaNumeros(int numero)
        {
            if (numero <= 1)
                return 1;
            return numero + SomaNumeros(numero - 1);
        }
        #endregion
        #region exercicio 6
        private void Btn_exerc_6_Click(object sender, EventArgs e)
        {
            int k = int.Parse(text1_exerc_6.Text);
            int n = int.Parse(text2_exerc_6.Text);

            int resultado = Calcular(k, n);

            MessageBox.Show("O Calculo de " + k + " x " + n + "  é  " + resultado, "Exercicio 6");
        }
        //metodo para calcular k n 
        private int Calcular(int numero, int vezes)
        {
            if (vezes == 0)
                return 0;
            return numero + Calcular(numero, vezes - 1);
        }
        #endregion
        #region exercicio 7
        private void Btn_exerc_7_Click(object sender, EventArgs e)
        {
            string elementos = text_exerc_7.Text;
            string[] vetorString = elementos.Split(',');
            
            string vetorInvertido = InverterNumerosVetor(vetorString.Length - 1, vetorString);

            MessageBox.Show("vetor invertido é \n" + vetorInvertido, "Exercicio 7");
        }

        //metodo para inverter numeros
        private string InverterNumerosVetor(int i, string[] n)
        {
            if (i <= 0)
                return n[i];


            return n[i] + ", " + InverterNumerosVetor(i - 1, n);
        }
        #endregion
        #region exercicio 8
        private void Btn_exerc_8_Click(object sender, EventArgs e)
        {
            int x = int.Parse(text_x_exerc_8.Text);
            int y = int.Parse(text_y_exerc_8.Text);
            if (x == 0 || y == 0)
                MessageBox.Show("Não pode haver valores 0", "ATENÇÃO ! ");
            else
            {
                int resultado = CalculoMdc(x, y);
                MessageBox.Show("O MDC de " + x + " e " + y + " é " + resultado, "Exercicio 8");
            }
            
        }
        //metodo para calcular mdc de x y
        private int CalculoMdc(int x, int y) 
        {
            if (y == 0) 
                return x; 

            return CalculoMdc(y, x % y); 
        }
        #endregion
        #region exercicio 9
        private void Btn_exerc_9_Click(object sender, EventArgs e)
        {
            string numero = text_N_exerc_9.Text;
            char[] lista = numero.ToArray();
            string k = text_k_exerc_9.Text;
            int rep = 0;

            int resultado = ContarRepeticoes(lista.Length - 1, lista, k, rep);


            MessageBox.Show("O digito " + k + " repete " + resultado + " vezes ", "Exercicio 9");
        }
        //metodo para contar repetições 
        private int ContarRepeticoes(int i, char[] lista, string k, int vezes)
        {
            if (i == 0)
                return vezes;

            if (lista[i].ToString() == k)
                vezes++;

            return ContarRepeticoes(i - 1, lista, k, vezes);
        }
        #endregion
        #region exercicio 10
        private void Btn_exerc_10_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(text_N1_exerc_10.Text);
            int N2 = int.Parse(text_N2_exerc_10.Text);

            //chama metodo utilizado no exercicio 6
            int resultado = Calcular(N1, N2);

            MessageBox.Show("O Calculo de " + N1 + " x " + N2 + "  é  " + resultado, "Exercicio 10");
        }
        #endregion
        #region exercicio 11
        private void Btn_exerc_11_Click(object sender, EventArgs e)
        {
            string N = text_exerc_11.Text;
            int i = 0;
            string resultado = ImprimeNumeros(N, i);

            MessageBox.Show("Numeros de 0 a " + N + "\n" + resultado, "Exercicio 11");
        }

        //metodo imprime numero 0 a N
        private string ImprimeNumeros(string N, int i)
        {
            if (i == int.Parse(N))
                return N;
            return i.ToString() + " - " + ImprimeNumeros(N, i + 1);
        }
        #endregion
        #region exercicio 12
        private void Btn_exerc_12_Click(object sender, EventArgs e)
        {
            string N = text_exerc_12.Text;
            int i = int.Parse(N);
            string resultado = ImprimeNumerosDec(N, i);

            MessageBox.Show("Numeros de" + N + " a 0" + "\n" + resultado, "Exercicio 12");
        }
        //metodo imprime numero 0 a N
        private string ImprimeNumerosDec(string N, int i)
        {
            if (i == 0)
                return "0";
            return i.ToString() + " - " + ImprimeNumerosDec(N, i - 1);
        }
        #endregion
        #region exercicio 13
        private void Btn_exerc_13_Click(object sender, EventArgs e)
        {
            if (int.Parse(text_exerc_13.Text) % 2 == 0)
            {
                string N = text_exerc_13.Text;
                int i = 0;
                string resultado = ImprimeNumerosPares(N, i);
                MessageBox.Show("Numeros pares de 0 a " + N + "\n" + resultado, "Exercicio 13");
            }
            else
            {
                MessageBox.Show("Insira um numero par", "ATENÇÃO!");
            }
        }
        //metodo imprime numero 0 a N Pares
        private string ImprimeNumerosPares(string N, int i)
        {
            if (i == int.Parse(N))
                return N;

            return i.ToString() + " - " + ImprimeNumerosPares(N, i + 2);
        }
        #endregion
        #region exercicio 14
        private void Btn_exerc_14_Click(object sender, EventArgs e)
        {
            if (int.Parse(text_exerc_14.Text) % 2 == 0)
            {
                string N = text_exerc_14.Text;
                int i = int.Parse(N);
                string resultado = ImprimeNumerosParesDec(N, i);
                MessageBox.Show("Numeros pares de" + N + " a 0" + "\n" + resultado, "Exercicio 14");
            }
            else
            {
                MessageBox.Show("Insira um numero par", "ATENÇÃO!");
            }
           
        }
        //metodo imprime numero Pares 0 a N
        private string ImprimeNumerosParesDec(string N, int i)
        {
            if (i == 0)
                return "0";
            return i.ToString() + " - " + ImprimeNumerosParesDec(N, i - 2);
        }
        #endregion
        #region exercicio 15
        private void Btn_exerc_15_Click(object sender, EventArgs e)
        {
            if (int.Parse(text_exerc_15.Text) % 2 != 0)
            {
                int n = int.Parse(text_exerc_15.Text);

                int resultado = FatorialDuplo(n);
                MessageBox.Show("O fatorial duplo de " + n + " é  " + resultado, "Exercicio 15");
            }
            else
            {
                MessageBox.Show("Insira um numero impar", "ATENÇÃO!");
            }


        }

        //metodo calcular fatorial duplo
        private int FatorialDuplo(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * FatorialDuplo(n - 2);
        }
        #endregion
        #region metodo para gerar vetor numeros aleatórios
        private void Btn_gerarVetor_7_Click(object sender, EventArgs e)
        {
            text_exerc_7.Clear();

            int[] vetor = new int[100];

            Random randNum = new Random();

            for (int i = 0; i <= 99; i++)
            {
                vetor[i] = randNum.Next(0, 100);
                text_exerc_7.Text += vetor[i].ToString();
                if (i < vetor.Length - 1)
                    text_exerc_7.Text += ",";
            }

        }
        #endregion
        #region Botões perguntas
        private void Btn_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Faça uma função recursiva que calcule e retorne o fatorial de um número inteiro N.", "Exercicio 1");
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Faça uma função recursiva que calcule e retorne o N-ésimo termo da sequência Fibonacci.Alguns números desta sequência são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89...", "Exercicio 2");
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Faça uma função recursiva que permita inverter um número inteiro N."
                +" Ex: 123 - 321","Exercicio 3");
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Faça uma função recursiva que permita somar os elementos de um vetor de inteiros."
                + "\n\nObs: usar virgula para separar numeros", "Exercicio 4");
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Crie uma função recursiva que receba um número inteiro positivo N e"
                + " calcule o somatório dos números de 1 a N.", "Exercicio 5");
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Crie um programa que contenha uma função recursiva que receba dois inteiros"
                +" positivos k e n e calcule kn.Utilize apenas multiplicações.O programa principal deve solicitar "
                +"ao usuário os valores de k e n e imprimir o resultado da chamada da função.", "Exercicio 6");
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Crie um programa que receba um vetor de números reais com 100 elementos."
                +"Escreva uma função recursiva que inverta ordem dos elementos presentes no vetor.", "Exercicio 7");
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" O máximo divisor comum dos inteiros x e y é o maior inteiro que é divisível por x e y."
                +"Escreva uma função recursiva mdc que retorna o máximo divisor comum de x e y.O mdc de x e y é "
                +"definido como segue: se y é igual a 0, então mdc(x, y) é x; caso contrário, mdc(x, y) é mdc(y, x% y), onde % é o operador resto.", "Exercicio 8");
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Escreva uma função recursiva que determine quantas vezes um dígito K ocorre em um"
                +" número natural N.Por exemplo, o dígito 2 ocorre 3 vezes em 762021192.", "Exercicio 9");
        }

        private void Btn_10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" A multiplicação de dois números inteiros pode ser feita através de somas sucessivas."
                +"Proponha um algoritmo recursivo  que calcule a multiplicação de dois inteiros.", "Exercicio 10");
        }

        private void Btn_11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Faça uma função recursiva que receba um número inteiro positivo N e imprima todos "
                +"os números naturais de 0 até N em ordem crescente. ", "Exercicio 11");
        }

        private void Btn_12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Faça uma função recursiva que receba um número inteiro positivo N e imprima todos"
                +" os números naturais de 0 até N em ordem decrescente.", "Exercicio 12");
        }

        private void Btn_13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Faça uma função recursiva que receba um número inteiro positivo par N e imprima todos"
                +" os números pares de 0 até N em ordem crescente.", "Exercicio 13");
        }

        private void Btn_14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Faça uma função recursiva que receba um número inteiro positivo par N e imprima todos"
                +" os números pares de 0 até N em ordem decrescente. ", "Exercicio 14");
        }

        private void Btn_15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" A função fatorial duplo é definida como o produto de todos os números naturais ímpares"
                +" de 1 até algum número natural ímpar N. Assim, o fatorial duplo de 5 é 5!! = 1 * 3 * 5 = 15 Faça "
                +"uma função recursiva que receba um número inteiro positivo impar N e retorne o fatorial duplo desse"
                +" número.", "Exercicio 15");
        }
        #endregion
        #region limpar caixas de texto
        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            text_exerc_1.Clear();
            text_exerc_2.Clear();
            text_exerc_3.Clear();
            text_exerc_4.Clear();
            text_exerc_5.Clear();
            text1_exerc_6.Clear();
            text2_exerc_6.Clear();
            text_exerc_7.Clear();
            text_y_exerc_8.Clear();
            text_x_exerc_8.Clear();
            text_N_exerc_9.Clear();
            text_k_exerc_9.Clear();
            text_N1_exerc_10.Clear();
            text_N2_exerc_10.Clear();
            text_exerc_11.Clear();
            text_exerc_12.Clear();
            text_exerc_13.Clear();
            text_exerc_14.Clear();
            text_exerc_15.Clear();

        }
        #endregion
    }
}
