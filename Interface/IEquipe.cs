using E_JOGOS.Models;

namespace E_JOGOS.Interface
{
    /// <summary>
    /// RESPONSÁVEL POR DEFINIR TODOS OS MÉTODOS QUE UMA CLASSE DEVE TER
    /// </summary>
    public interface IEquipe
    {
        //CREATE
        void Create(Equipe newTeam);

        //READALL
        List<Equipe> ReadAll();

        //UPDATE
        void Update(Equipe newTeam);

        //DELETE
        void Delete(int teamId);
    }
}
