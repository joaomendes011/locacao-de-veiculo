public class Cliente
{
    private string _nome;
    private string _cpf;
 
    public string Nome
    {
        get
        {
            return _nome;
        }
 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O nome do cliente não pode ficar vazio."
                );
            }
 
            _nome = value.Trim();
        }
    }
 
    public string CPF
    {
        get
        {
            return _cpf;
        }
 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O CPF não pode ficar vazio."
                );
            }
 
            _cpf = value.Trim();
        }
    }
 
    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }
 
    public void ExibirDados()
    {
        Console.WriteLine($"Cliente: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
    }
}