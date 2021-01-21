using System;
using System.IO;
using EPlayers_AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPlayers_AspNetCore.Controllers
{
    [Route("Equipe")]
    // Estou nomeando a dominio da rota como Equipe, para verificar digite a rota a seguir:
    //  http://localhost:5000/Equipe
    public class EquipeController : Controller
    // Essa herança de controler vem de using Microsoft.AspNetCore.Mvc;
    {   
        // Criamos um objeto instanciado com base em Models para acessar tudo que foi definido em models
        Equipe equipeModel = new Equipe();
        [Route("Listar")]
        public IActionResult Index()
        {
            // Listamos todas as equipes e enviamos para View, através ViewBag
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
            

            // Upload Inicio

            //Verificamos se o usuario selecionou um arquivo
            if(form.Files.Count > 0)
            {
                // Recebemos o arquivo que o usuario enviou e armazenamos na variavel file
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                Console.WriteLine($"{folder}");
                
                
                //Verificamos se o diretorio (pasta) já existe, senão criamos
                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                                        // localhost:5001                                Equipes    imagem.jpg(nome do arquivo)
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);

                }
                novaEquipe.Imagem = file.FileName;
            }
                else
                {
                    novaEquipe.Imagem = "padrao.png";
                }
            
            // Upload Final

            // Chamamos o método create para salvar a nova equipe no csv
            equipeModel.Create(novaEquipe);
            // Atualiza a lista de equipes na view
            ViewBag.Equipes = equipeModel.ReadAll();
            return LocalRedirect("~/Equipe/Listar");
        }
        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            equipeModel.Delete(id);
            ViewBag.Equipes = equipeModel.ReadAll();
            return LocalRedirect("~/Equipe/Listar");
        }
    }
}