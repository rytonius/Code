using aspnetcore_timekeeping.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspnetcore_timekeeping.Models;

namespace aspnetcore_timekeeping.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonDataService DataService { get; }
        public IEnumerable<Data> Datas { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
        JsonDataService dataService)
        {
            _logger = logger;
            DataService = dataService;
        }



        public void OnGet() => Datas = DataService.GetInfo();
    }
}

