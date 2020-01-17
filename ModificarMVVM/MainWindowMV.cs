using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModificarMVVM
{
    class MainWindowMV : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private InformesEntities contexto;
        public ObservableCollection<CLIENTE> CLIENTEs { get; set; }
        

        public MainWindowMV()
        {
            contexto = new InformesEntities();
            contexto.CLIENTES.Load();
            CLIENTEs = contexto.CLIENTES.Local;
        
        }

        public void Actualizar()
        {
            contexto.SaveChanges();
            MessageBox.Show("Info: " + "Usuario Actualizado", "Actualización", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
