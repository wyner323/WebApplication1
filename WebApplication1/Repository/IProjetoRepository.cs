using System.Collections.Generic;

public interface IProjetoRepository
{
    bool AdicionarProjeto(Projeto projeto);
    IEnumerable<Projeto> ObterProjetos();
    bool ProjetoExiste(int numeroProjeto);

    void AdicionarVisita(Visita visita);
    IEnumerable<Visita> ObterVisitasPorProjeto(int numeroProjeto);
}