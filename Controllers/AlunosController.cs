using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[Controller]")]
public class AlunosController : ControllerBase
{
    private static readonly List<Aluno> ListadeAlunos = new List<Aluno>
    {
        new Aluno { Id = 1, Nome = "João"},
        new Aluno { Id = 2, Nome = "Ryan"},
        new Aluno { Id = 3, Nome = "Edgar"},
        new Aluno { Id = 4, Nome = "Vinícius"}
    };
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(ListadeAlunos);
    }
    [HttpPost]
    public IActionResult Post(Aluno NovoAluno)
    {
        ListadeAlunos.Add(NovoAluno);
        return Ok(NovoAluno);
    }
    [HttpPut("{id}")]
    public IActionResult Put(int id, Aluno alunoAtualizado)
    {
        //percorre a lista de alunos e verifica se o id do aluno é igual ao id passado na requisição
        foreach (var aluno in ListadeAlunos)
        {
            //se encontrar o aluno com o id igual ao id passado na requisição, atualiza o nome do aluno com o nome passado na requisição
            if (aluno.Id == id)
            {
                aluno.Nome = alunoAtualizado.Nome;

                return Ok(aluno);
            }
        }
        //se não encontrar o aluno com o id igual ao id passado na requisição, retorna NotFound
        return NotFound();
    }
}