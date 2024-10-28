using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

public class DetallesModel : PageModel
{
    public Declaracion Declaracion { get; private set; }

    public async Task OnGet(int id)
    {
        // Cargar la declaración y sus detalles desde la base de datos
        Declaracion = LoadDeclaracion(id);
    }

    private Declaracion LoadDeclaracion(int id)
    {
        // Cargar desde la base de datos
    }
}
