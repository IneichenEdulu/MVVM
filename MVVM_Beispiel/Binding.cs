using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel;
using System.Reflection;

namespace MVVM_Beispiel
{
    public class Binding
    {
        public Binding(string property)
        {
            Name = property;
        }

        public object Source { get; set; }

        public string Name { get; set; }

        public void Parse()
        {
            INotifyPropertyChanged inpc = Source as INotifyPropertyChanged;
            if (inpc == null)
            {
                return;
            }
            inpc.PropertyChanged += Inpc_PropertyChanged;
        }

        private void Inpc_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyInfo propertyInfo = Source.GetType().GetProperty(e.PropertyName);
            object value = propertyInfo?.GetValue(Source);
            Console.WriteLine($"{e.PropertyName} hat sich geändert zu {value}");
        }
    }
}
