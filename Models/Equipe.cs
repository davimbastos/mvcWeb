using E_JOGOS.Interface;

namespace E_JOGOS.Models
{
    public class Equipe : EjogosBase, IEquipe
    {

        //Atalha Constructor CTOR tab tab

        const string path = "Database/equipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(path);
        }


        public int idEquipe { get; set; }
        public string nome { get; set; }
        public string imagem { get; set; }

        //Função para converter string para Equipe



        public void Create(Equipe newTeam)
        {
            string[] linha = { $"{newTeam.idEquipe};{newTeam.nome};{newTeam.imagem}"};
            File.AppendAllLines(path, linha);
            
        }

        public void Delete(int teamId)
        {
            throw new NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(path);

            foreach(string linha in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.idEquipe = int.Parse(linha.Split(' ')[0]);
                equipe.nome = linha.Split(' ')[1];
                equipe.imagem = linha.Split(' ')[2];

                equipes.Add(equipe);
            }

            return equipes;

        }

        public void Update(Equipe newTeam)
        {
            throw new NotImplementedException();
        }
    }
}
