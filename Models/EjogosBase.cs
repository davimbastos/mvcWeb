namespace E_JOGOS.Models
{
    public class EjogosBase
    {
        //Função para criar pasta e arquivo
        public void CreateFolderAndFile(string p_path)
        {
            string folder = p_path.Split('/')[0];
            string file = p_path.Split('/')[1];


            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(file))
            {
                File.Create(p_path);
            }
                
        }


    }
}
