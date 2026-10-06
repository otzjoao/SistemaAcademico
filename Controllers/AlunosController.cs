using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[Controller]")]
public class AlunosController : ControllerBase
{
    private static Dictionary<int, Aluno> _alunos = new Dictionary<int, Aluno>()
    {
        {1, new Aluno() { Id = 1, Nome = "João", Email = "joao@email.com", Matricula = "2023001", NotaFinal = 8.5 }},
        {2, new Aluno() { Id = 2, Nome = "Ryan", Email = "ryan@email.com", Matricula = "2023002", NotaFinal = 7.0 }},
        {3, new Aluno() { Id = 3, Nome = "Edgar", Email = "edgar@email.com", Matricula = "2023003", NotaFinal = 9.5 }},
        {4, new Aluno() { Id = 4, Nome = "Vinícius", Email = "vinicius@email.com", Matricula = "2023004", NotaFinal = 6.5 }}
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_alunos.Values);
    }
}