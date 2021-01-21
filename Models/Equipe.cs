using System.Collections.Generic;
using System.IO;
using EPlayers_AspNetCore.Interfaces;

namespace EPlayers_AspNetCore.Models
{
    public class Equipe : EplayersBase, IEquipe
    {
        public int IdEquipe { get; set; }
        
        public string Nome { get; set; }
        
        public string Imagem { get; set; }

        private const string PATH = "DataBase/Equipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(PATH);
        }
        // Criamos o método para preparar a linha do csv
        public string Prepare(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }
        public void Create(Equipe e)
        {   // preparamos um array de string para o método appendalllines
            string[] linhas = {Prepare (e)};
            // acrescentamos a nova linha
            File.AppendAllLines(PATH, linhas);
        }

        public void Delete(int id)
        {
            List<string>  linhas = ReadAllLinesCSV(PATH);
            // 2; SNK; snk.jpg
            // Expressão lambda para retirar os ; e comparar o IdEquipe
            // To.String converte para texto
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            // Remover as linhas com o código comparado
            
            RewriteCSV(PATH, linhas);
            // Reescreve o CSV com a lista alterada
        }

        public List<Equipe> ReadAll()
        {   // Criando uma lista de equipes para poder ler
            List<Equipe> equipes = new List<Equipe>();
            // Lemos todas as linhas do csv
            string[] linhas = File.ReadAllLines(PATH);
            foreach (string item in linhas)
            {
                //1;VivoKeyd;vivo.jpg
                // [0] == 1 / Representa o IdEquipe
                // [1] == VivoKeyd / Representa o nome da Equipe
                // [2] == vivo.jpg / Representa a imagem da Equipe 
                string[] linha = item.Split(";");
                // instanciando novaEquipe para colocar atributos
                Equipe novaEquipe = new Equipe();
                novaEquipe.IdEquipe = int.Parse(linha[0]);
                novaEquipe.Nome = linha[1];
                novaEquipe.Imagem = linha[2];

                equipes.Add(novaEquipe);
            }
            return equipes;
        }

        public void Update(Equipe e)
        {
            List<string>  linhas = ReadAllLinesCSV(PATH);
            // 2; SNK; snk.jpg
            // Expressão lambda para retirar os ; e comparar o IdEquipe
            linhas.RemoveAll(x => x.Split(";")[0] == e.IdEquipe.ToString());
            // Remover as linhas com o código comparado
            linhas.Add(Prepare(e));
            // Adicionar na lista a equipe alterada
            RewriteCSV(PATH, linhas);
            // Reescreve o CSV com a lista alterada
        }
    }
}