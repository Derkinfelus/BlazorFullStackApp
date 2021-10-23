using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Shared
{
    public class OpenableMultiDimentionalList
    {
        public List<OpenableMultiDimentionalList> LowerDimentionList { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Data { get; set; }
        public bool IsOpen { get; set; }
        public async Task RecoursiveCopyList(List<OpenableMultiDimentionalList> lowerDimentionList, List<MultiDimentionalList> result)
        {
            if (lowerDimentionList.Count == 0)
            {
                return;
            }
            foreach (var i in lowerDimentionList)
            {
                var tmp = new MultiDimentionalList { LowerDimentionList = new List<MultiDimentionalList>(), Id = i.Id, Name = i.Name, Data = i.Data };
                result.Add(tmp);
                await RecoursiveCopyList(i.LowerDimentionList, result.Last().LowerDimentionList);
            }
        }
    }
}
