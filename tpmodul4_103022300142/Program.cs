// See https://aka.ms/new-console-template for more information
using tpmodul4_103022300142;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        KodePos.PrintKodePos();
        Console.Write("masukin nama kelurahannya vro:)) ");
        string input=Console.ReadLine();
        Console.WriteLine($"Kode Pos {input}: {KodePos.GetKodePos(input)}");

        DoorMachine door=new DoorMachine();
        door.BukaPintu();
        door.KunciPintu();
    }
}