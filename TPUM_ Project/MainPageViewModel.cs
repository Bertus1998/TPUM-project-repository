using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
//Model to data
//View to UI
//View Models Logika
namespace TPUM__Project
{
    // implementacja danych w formacie XML
    //warsty są jak wodospad i dana warstwa ma tylko dostęp do górnej i dolnej
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private string theNote;

        public string TheNote
        {
            get => theNote;
            set
            {
                theNote = value;
                var args = new PropertyChangedEventArgs(nameof(TheNote));
                PropertyChanged?.Invoke(this, args);
            }
        }
    }
}
