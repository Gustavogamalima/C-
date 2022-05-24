using System;
class Aula15{
     static void Main(){

         int tempo=0;
         char escolha;

         Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
         Console.WriteLine("Escolha o transporte:[a]Avião | [c] Carro | [o] Ônibus ");
         escolha=char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo=50;
                break;
            case 'c':
            case 'C':
                tempo=480;
                break;
                tempo=660;
            case 'o':
            case 'O':
                break;
        }
        if(tempo<0){
            Console.WriteLine("Transporte indisponível");
        }else{
            Console.WriteLine("Para o Transporte escolhido o tempo é: {0} minutos", tempo);
        }
    }
}