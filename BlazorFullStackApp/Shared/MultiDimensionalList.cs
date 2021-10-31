using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Shared
{
    public class MultiDimensionalList
    {
        public List<MultiDimensionalList> LowerDimensionList { get; set; }
        public int ParrentId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Data { get; set; }
        public async Task<OpenableMultiDimensionalList> TransformElement()
        {
            async Task RecoursiveTransormList(List<MultiDimensionalList> lowerDimensionList, List<OpenableMultiDimensionalList> result)
            {
                if (lowerDimensionList.Count == 0)
                {
                    return;
                }
                foreach (var i in lowerDimensionList)
                {
                    var tmp = new OpenableMultiDimensionalList
                    {
                        LowerDimensionList = new List<OpenableMultiDimensionalList>(), ParrentId = i.ParrentId, Id = i.Id, Name = i.Name, Data = i.Data, IsOpen = false
                    };
                    result.Add(tmp);
                    await RecoursiveTransormList(i.LowerDimensionList, tmp.LowerDimensionList);
                }
            }

            OpenableMultiDimensionalList result = new OpenableMultiDimensionalList 
            { 
                ParrentId = this.ParrentId, Id = this.Id, Name = this.Name, Data = this.Data, LowerDimensionList = new List<OpenableMultiDimensionalList>() 
            };
            await RecoursiveTransormList(LowerDimensionList, result.LowerDimensionList);

            return result;
        }
        public async Task<MultiDimensionalList> FindElement(int elementId)
        {
            bool recoursionEnd = false;
            async Task<MultiDimensionalList> RecoursiveFindElement(MultiDimensionalList element)
            {
                if (element.Id == elementId || recoursionEnd)
                {
                    recoursionEnd = true;
                    return element;
                }
                foreach (var i in element.LowerDimensionList)
                {
                    await RecoursiveFindElement(i);
                }

                return null;
            }

            return await RecoursiveFindElement(this);
        }
    }
}
