using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM_Beispiel
{
    // ViewModel hält die Daten und Funktionalität vor.
    public class PersonViewModel : INotifyPropertyChanged
    {
        private readonly PersonModel personModel;
        private readonly PersonModelValidator validator;

        // Dem ViewModel wird eine Referenz zum Model gesetzt.
        public PersonViewModel()
        {
            personModel = new PersonModel();
            validator = new PersonModelValidator(); // Validator für den Namen
        }

        public string Name
        {
            get { return personModel.Name; }
            set
            {
                if (!validator.IsValid(value))
                {
                    return;
                }
                personModel.Name = value;
                OnPropertyChanged(); // Benachrichtigung für Änderungen
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
