using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateBaseV01.Models
{
    public class Person
    {
        public Person(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string nome { get; set; }
        public int idade { get; set; }
    }
}