using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2 {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            ListaFuncionarios.ItemsSource = GetFuncionarios();
        }

        private List<Grupo> GetFuncionarios () {
            return new List<Grupo> { 
                new Grupo("Presidente", "CEO", "Presidente da Empresa") {
                    new Pessoa { Nome = "José" }
                },
                new Grupo("Diretores", "Dir.", "Diretor da Empresa") {
                    new Pessoa { Nome = "João" },
                    new Pessoa { Nome = "Maria" }
                },
                new Grupo("Gerentes", "Ger.", "Gerente da Empresa") {
                    new Pessoa { Nome = "Felipe" },
                    new Pessoa { Nome = "Judas" }
                }
            };
        }

        public class Grupo : List<Pessoa> {
            public string Titulo { get; set; }
            public string TituloCurto { get; set; }
            public string Descricao { get; set; }

            public Grupo (string titulo, string tituloCurto, string descricao) {
                this.Titulo = titulo;
                this.TituloCurto = tituloCurto;
                this.Descricao = descricao;
            }
        }

        public class Pessoa {
            public string Nome { get; set; }
        }
    }
}
