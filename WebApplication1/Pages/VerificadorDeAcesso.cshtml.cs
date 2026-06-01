using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class VerificadorDeAcessoModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; }

        [BindProperty]
        public int Idade { get; set; }

        public string MensagemDeRetorno { get; set; }

        public void OnPost()
        {
            if (Idade >= 18)
                MensagemDeRetorno = $"Olá, {Nome}! Entrada Liberada.";
            else
                MensagemDeRetorno = $"Olá, {Nome}! Entrada Bloqueada para menores.";
        }
    }
}
