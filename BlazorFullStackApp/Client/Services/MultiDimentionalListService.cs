using BlazorFullStackApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client.Services
{
    public class MultiDimentionalListService : IMultiDimentionalListService
    {
        public List<OpenableMultiDimentionalList> ListOfElements { get; set; } = new List<OpenableMultiDimentionalList>();
        private readonly HttpClient _HttpClient;

        public event Action OnChange;

        public MultiDimentionalListService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task PostElement(int id, OpenableMultiDimentionalList transporter)
        {
            await _HttpClient.PostAsJsonAsync($"api/Drop_downList/{id}", transporter);
            OnChange.Invoke();
        }

        public async Task GetList()
        {
            foreach (var i in await _HttpClient.GetFromJsonAsync<List<MultiDimentionalList>>($"api/MultiDimentionalList"))
            {
                var tmp = new OpenableMultiDimentionalList { Id = i.Id, Name = i.Name, Data = i.Data, IsOpen = false };
                await i.RecoursiveCopyList(i.LowerDimentionList, tmp.LowerDimentionList);
            }

            OnChange.Invoke();
        }
    }
}
