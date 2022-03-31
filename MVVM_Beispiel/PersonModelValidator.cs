using System;

namespace MVVM_Beispiel
{
    public class PersonModelValidator
    {
        public bool IsValid(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return true;
            }
            Console.WriteLine("Der Name darf kein leerer String sein.");
            return false;
        }
    }
}
