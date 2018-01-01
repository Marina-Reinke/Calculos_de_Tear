using System;

namespace Calculos_de_Tear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("****************Calculos de Tear****************");
            Console.WriteLine("");
            Console.WriteLine("Você deve escolher um numero e digitar ele e apartar Enter");
            Console.WriteLine("Escolha uma opção: (Digite apenas o Numero)");
            Console.WriteLine("");
            Console.WriteLine(" 1- TAFETA");
            Console.WriteLine(" 2- TAFETA PLUS");
            Console.WriteLine(" 3- SILK DAMASK");
            Console.WriteLine(" 4- CETIM BASIC");
            Console.WriteLine(" 0- FECHAR PROGRAMA");
            Console.WriteLine("");

            //definindao variavel do tipo string que recebe o valor ""
            // = recebe, atribui um valor
            // == igual, verifica se é igual
            string codigo = "";

            //Fica esperando o usuario digitar um valor e apartar enter
            //variavel codigo recebe o valor digitado pelo usuario
            codigo = Console.ReadLine();
            
            //if serve para fazer verificações (if == se, else == senão, else if == senão se)
            //Verifica qual o codigo que o usuario digitou
            if (codigo == "0")
            {
                //Fecha o programa
                Environment.Exit(0);
            }
            else if (codigo == "1")
            {
                decimal num_calculo = 2.8m;
                
                Console.Clear();
                Console.WriteLine("****************Calculos de Tear****************");
                Console.WriteLine("");
                Console.WriteLine("Digite os Centimetros:");

                decimal num_cm = 0;
                
                //funtion 'Parse' serve para converter o valor digitado pelo usuario de string para decimal
                num_cm = decimal.Parse(Console.ReadLine());

                decimal resultado_real = 0;
                decimal resultado_aredondado = 0;
                
                //Calcula multiplacando o 2.8 pelo valor digitado pelo usuario ex: 31.1 x 2.8
                resultado_real = (num_cm * num_calculo);

                Console.Clear();
                Console.WriteLine("****************Calculos de Tear****************");
                Console.WriteLine("");

                Console.WriteLine(" Resultado real: "+resultado_real);

                //Aredonda o valor do resultado
                //Round: recebe um valor do tipo decimal e retorna um valor do tipo decimal tbm, apesar de ser um valor inteiro, não tem virgula
                resultado_aredondado = Math.Round(resultado_real);

                Console.WriteLine("");
                Console.WriteLine(" Resultado aredondado: "+resultado_aredondado);
                
                //Verifica se o resultado_aredondado é Par
                if (resultado_aredondado % 2 != 0)
                {
                    decimal resultado_sugerido = 0;

                    resultado_sugerido = resultado_aredondado + 1; //TODO: as vezes precisa acresentar 1 as vezes subtrair 1
                    
                    Console.WriteLine("");
                    Console.WriteLine(" Resultado sugerido: "+resultado_sugerido);

                    Console.WriteLine("");
                    Console.WriteLine("Alerta Tafeta não pode ser impar!");
                }
            }
            else if (codigo == "2")
            {

            }
            else if (codigo == "3")
            {

            }
            else if (codigo == "4")
            {

            }
            else {
                Console.WriteLine("Você Não Digitou Nenhum Codigo Valido!");
            }
            
            Console.WriteLine("");
            Console.WriteLine("************************************************");
            Console.WriteLine("By: Marina R.");
        }

        void Mostrar_Titulo()
        {
            Console.Clear();
            Console.WriteLine("****************Calculos de Tear****************");
            Console.WriteLine("");
        }
    }
}
