namespace Pets_Web_MVC.Models;

public class Cliente
{
    /* A seguir sera criado os atributos para 
    Cliente e seus metodos getters e setters
    */
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Paciente { get; set; }

    /* A seguir sera criado o construtor da classe Cliente
    determinado quais parâmetros são necessários na criação 
    das instâncias
    */
    public Cliente(int id, string nome, string cpf, string email, string paciente)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;

    }

}