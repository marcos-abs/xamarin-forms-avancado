using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2 {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent ();

            ListaFuncionarios.ItemsSource = GetFuncionarios();
        }

        private List<Pessoa> GetFuncionarios () {
            return new List<Pessoa> {
                new Pessoa { Nome = "José" },
                new Pessoa { Nome = "João" },
                new Pessoa { Nome = "Maria" },
                new Pessoa { Nome = "Felipe" },
                new Pessoa { Nome = "Judas" }
            };
        }


        public class Pessoa {
            public string Nome { get; set; }
        }
    }
}
