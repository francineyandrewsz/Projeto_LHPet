namespace LHPet.Models;

public class Cliente {
    private int v1;
    private string v2;
    private string v3;
    private string v4;
    private string v5;

    /* No trecho de código a seguir são criados os atributos de Cliente e seus
    getters e setters correspondentes. */
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Paciente { get; set; }

    public Cliente()
    {
        
    }

    /* Nesse trecho do código, é criado o Construtor do model Cliente e determinado 
    quais parâmetros são necessários na criação das instâncias. */

    public Cliente(int id, string nome, object gates, string cpf, string email, string paciente)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }

    public Cliente(int v1, string v2, string v3, string v4, string v5)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
        this.v5 = v5;
    }
}