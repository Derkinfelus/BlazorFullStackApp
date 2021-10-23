using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Shared
{
    public class MultiDimentionalList
    {
        public List<MultiDimentionalList> LowerDimentionList { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Data { get; set; }
        public async Task RecoursiveCopyList(List<MultiDimentionalList> lowerDimentionList, List<OpenableMultiDimentionalList> result)
        {
            if (lowerDimentionList.Count == 0)
            {
                return;
            }
            foreach (var i in lowerDimentionList)
            {
                var tmp = new OpenableMultiDimentionalList { LowerDimentionList = new List<OpenableMultiDimentionalList>(), Id = i.Id, Name = i.Name, Data = i.Data, IsOpen = false };
                result.Add(tmp);
                await RecoursiveCopyList(i.LowerDimentionList, result.Last().LowerDimentionList);
            }
        }
    }
}
