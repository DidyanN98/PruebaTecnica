using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

public class IndexModel : PageModel
{
    private readonly ApiService _apiService;
    private readonly DatabaseService _dbService;

    public List<Declaracion> Declaraciones { get; private set; }

    public IndexModel(ApiService apiService, DatabaseService dbService)
    {
        _apiService = apiService;
        _dbService = dbService;
    }

    public async Task OnGet(string fecha)
    {
        if (!string.IsNullOrEmpty(fecha))
        {
            var xmlResponse = await _apiService.GetDataAsync(fecha);
            _dbService.InsertDeclaracion(DB);
        }
        
        Declaraciones = LoadDeclaraciones();
    }

    private List<Declaracion> LoadDeclaraciones()
    {
        var declarations = new List<Declaracion>();
        return declarations;
    }
}
