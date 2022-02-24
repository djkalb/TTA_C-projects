using System;

namespace void_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates Void class so i can call shiny new Voided method -- could have just used static but this is fine
            Void voided = new Void();
            voided.Voided(11, 22);
            // names the peramaters when passing in the args i can do them backwards now
            voided.Voided(num2: 22, num1: 11);
        }
    }
}
