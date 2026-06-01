using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class CalculadoraDivisaoModel : PageModel
    {
        [BindProperty]
        public int Numero1 { get; set; }

        [BindProperty]
        public int Numero2 { get; set; }

        public int? Resultado { get; set; }
        public string MensagemDeErro { get; set; }

        public void OnPost()
        {
            try
            {
                Resultado = Numero1 / Numero2;
            }
            catch (DivideByZeroException)
            {
                MensagemDeErro = "Erro: Não é possível dividir por zero!";
            }
        }
    }
}
