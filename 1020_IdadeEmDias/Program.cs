using System;

class URI
{

    static void Main(string[] args)
    {

        int Dias, idadeDias, idadeAno, idadeMeses;
        int diaAno = 365;
        int diaMeses = 30;

        Console.WriteLine("Escreva o número de dias abaixo para descobrir a idade: ");
        Dias = int.Parse(Console.ReadLine());

        idadeAno = Dias / diaAno;
        idadeMeses = (Dias - (diaAno * idadeAno)) / diaMeses;
        idadeDias = (Dias - (diaAno * idadeAno)) - (diaMeses * idadeMeses);


        Console.WriteLine(idadeAno + " ano(s)");
        Console.WriteLine(idadeMeses + " mes(es)");
        Console.WriteLine(idadeDias + " dia(s)");

    }

}