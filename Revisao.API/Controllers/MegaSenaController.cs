using Microsoft.AspNetCore.Mvc;
using Revisao.Application.ViewModels;
using Newtonsoft.Json;
using Revisao.Application.Interfaces;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MegaSenaController : ControllerBase
    {

        //dia 2
        private readonly IJogoService _jogoService;

        public MegaSenaController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }


        //private readonly string _megacaminhoArquivo;

        //public MegaSenaController()
        //{
        //    _megacaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "Data", "FileJsonData", "MegaSena.json");
        //}

        //#region Operaçoes arquivo
        //private List<RegistroJogoViewModel> LerjogosDoArquivo()
        //{
        //    if (!System.IO.File.Exists(_megacaminhoArquivo))
        //    {
        //        return new List<RegistroJogoViewModel>();
        //    }

        //    string json = System.IO.File.ReadAllText(_megacaminhoArquivo);
        //    return JsonConvert.DeserializeObject<List<RegistroJogoViewModel>>(json);
        //}

        //private void EscreverJogosNoArquivo(List<RegistroJogoViewModel> jogos)
        //{
        //    string json = JsonConvert.SerializeObject(jogos);
        //    System.IO.File.WriteAllText(_megacaminhoArquivo, json);
        //}

        //#endregion


        [HttpPost]
        public IActionResult Post(NovoRegistroJogoViewModel registroJogoViewModel)
        {

            //var jogosRealizaddos = LerjogosDoArquivo();

            //registroJogoViewModel.DataJogo = DateTime.Now;

            //jogosRealizaddos.Add(registroJogoViewModel);

            //EscreverJogosNoArquivo(jogosRealizaddos);
            _jogoService.Adicionar(registroJogoViewModel);
            return Ok("Jogo registrado com sucesso");
        }

        [HttpGet]
        public IActionResult Get()
        {
            //return Ok(LerjogosDoArquivo());
            return Ok(_jogoService.ObterTodos());

        }

    }
}
