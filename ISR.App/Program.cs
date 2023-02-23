using System;
using ISR.Core.Entities;
using ISR.Core.Enums;
using ISR.Core.Managers;
using ISR.Core.Services;
using ISR.Core.Managers.Interfaces;
using ISR.Core.Services.Interfaces;

public static class Program {

    public static void Main(string[] args){
        float Salary = 0;

        System.Console.WriteLine("Please enter your salary");
        Single.TryParse(System.Console.ReadLine(), out Salary);

        var user = new user{salary = Salary};

        var service = new ISRServices();
        var manager = new ISRManager(service);

        Isr isr = manager.GetISR(user);

        System.Console.WriteLine($"ISR {isr.isrTotal}");

    }
    
}
