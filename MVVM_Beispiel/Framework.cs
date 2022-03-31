using System.Collections.Generic;

namespace MVVM_Beispiel
{
    public abstract class Framework
    {
        private readonly Dictionary<string, Binding> bindings = new Dictionary<string, Binding>();
        public object DataContext { get; set; }

        protected void SetBinding(string property)
        {
            Binding binding = new Binding(property)
            {
                Source = DataContext
            };
            binding.Parse();
            bindings.Add(property, binding);
        }
    }
}
