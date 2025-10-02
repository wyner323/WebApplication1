using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProjetosController : ControllerBase
{
    private readonly IProjetoRepository _repo;

    public ProjetosController(IProjetoRepository repo)
    {
        _repo = repo;
    }

    #region Projetos

    [HttpPost]
    public IActionResult CadastrarProjeto([FromBody] Projeto projeto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        if (!_repo.AdicionarProjeto(projeto))
            return BadRequest("Já existe um projeto com esse número.");

        return Ok(projeto);
    }

    [HttpGet]
    public IActionResult ListarProjetos()
    {
        return Ok(_repo.ObterProjetos());
    }

    #endregion

    #region Visitas

    [HttpPost("visita")]
    public IActionResult RegistrarVisita([FromBody] Visita visita)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        if (!_repo.ProjetoExiste(visita.NumeroProjeto))
            return BadRequest("Projeto não encontrado.");

        _repo.AdicionarVisita(visita);
        return Ok(visita);
    }

    [HttpGet("visita/{numeroProjeto}")]
    public IActionResult ListarVisitas(int numeroProjeto)
    {
        var visitas = _repo.ObterVisitasPorProjeto(numeroProjeto);
        return Ok(visitas);
    }

    #endregion
}