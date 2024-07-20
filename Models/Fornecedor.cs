namespace Pets_Web_MVC.Models;

public class Fornecedor
{
    /* A seguir sera criado os atributos para 
    Fornecedor e seus metodos getters e setters
    */
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cnpj { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }

    /* A seguir sera criado o construtor da classe Fornecedor
    determinado quais parâmetros são necessários na criação 
    das instâncias
    */
    public Fornecedor(int id, string nome, string cnpj, string email, string telefone)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cnpj = cnpj;
        this.Email = email;
        this.Telefone = telefone;

    }

}