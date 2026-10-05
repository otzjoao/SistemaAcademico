public class Professor : Pessoa // herda de pessoa
{
    public string? Materia {get; set;} = string.Empty;
    private string _senha = "123456";
    public string? Senha {
        get => _senha; 
        set 
        {
            _senha = string.IsNullOrWhiteSpace(value) ? "123456" : value.Trim();
        }
    }
}