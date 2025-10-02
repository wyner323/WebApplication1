using System.Collections.Generic;
using System.Linq;

public class ProjetoRepository : IProjetoRepository
{
    private readonly List<Projeto> _projetos = new();
    private readonly List<Visita> _visitas = new();

    public bool AdicionarProjeto(Projeto projeto)
    {
        if (_projetos.Any(p => p.NumeroProjeto == projeto.NumeroProjeto))
            return false;

        _projetos.Add(projeto);
        return true;
    }

    public IEnumerable<Projeto> ObterProjetos() => _projetos;

    public bool ProjetoExiste(int NumeroProjeto) =>
        _projetos.Any(static p => p.NumeroProjeto = NumeroProjeto);

    public void AdicionarVisita(Visita visita)
    {
        _visitas.Add(visita);
    }

    public IEnumerable<Visita> ObterVisitasPorProjeto(int numeroProjeto) =>
        _visitas.Where(v => v.NumeroProjeto == numeroProjeto);
}