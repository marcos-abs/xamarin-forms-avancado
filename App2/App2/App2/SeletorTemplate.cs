using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2 {
    public class SeletorTemplate : DataTemplateSelector {
        DataTemplate ItemPessoaObrigatoria;
        DataTemplate ItemPessoaNObrigatoria;

        public SeletorTemplate() {

        }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container) {
            throw new NotImplementedException();
        }
    }
}
