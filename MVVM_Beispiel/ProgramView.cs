using System;

namespace MVVM_Beispiel
{
    // Die View ist nur für die Anzeige da.
    public class ProgramView : Framework
    {
        // Die Ansicht (View) hat eine Referenz auf das ViewModel. Diese wird hier gesetzt. Diese wird zur Laufzeit gesetzt.
        private readonly PersonViewModel viewModel = new PersonViewModel();
        public ProgramView()
        {
            DataContext = viewModel; // DataBinding - z.B. Button kann direkt auf dem ViewModel ausgeführt werden.
            SetBinding("Name"); // Bindungsname
        }

        public void Input()
        {
            string input = Console.ReadLine();
            viewModel.Name = input;
        }
    }
}
