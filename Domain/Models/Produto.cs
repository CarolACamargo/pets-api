using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Produto : Entity
    {
        public Produto(string titulo, string descricao, decimal preco, byte[] imagem)
        {
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            Imagem = imagem;
        }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public byte[]? Imagem { get; private set; }
    }
}
