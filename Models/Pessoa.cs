public class Pessoa
{
    public int Id {get; set;}
    private string _nome = string.Empty;
    public string? Nome {
    get => _nome; 
    set 
    {
        _nome = string.IsNullOrWhiteSpace(value) ? "Sem Nome" : value.Trim();
    }
    }
    public string? Email {get; set;} = string.Empty;
}