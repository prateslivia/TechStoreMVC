using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TechStoreMVC.Models;

public class Produto
{
    // Passo 01- Criar as Models
    //Atribuitos
  
  public int Id {get; set;} //Get para obter um id = Identificador
                            // Set para definir um novo valor, atualizar e etc.
  [Required(ErrorMessage = "informe um nome")]
  [StringLength(
    100,
    MinimumLength = 3,
    ErrorMessage = "O nome deve possuir entre 3 e 100 caracteres."
  )]
  public string Nome {get; set;}
  public decimal Preco {get; set;}
  public int Estoque {get; set;}

  //Metódo Construtor - Define valores imiciais desses atributos acima!

  public Produto(
    int id,
    string nome,
    decimal preco,
    int estoque
  )
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

}
