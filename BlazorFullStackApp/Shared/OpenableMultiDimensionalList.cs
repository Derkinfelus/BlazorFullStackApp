using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Shared
{
    public class OpenableMultiDimensionalList
    {
        public List<OpenableMultiDimensionalList> LowerDimensionList { get; set; }
        public int ParrentId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Data { get; set; }
        public bool IsOpen { get; set; }
        public async Task<MultiDimensionalList> TransformElement()
        {
            async Task RecoursiveTransormList(List<OpenableMultiDimensionalList> lowerDimensionList, List<MultiDimensionalList> result)
            {
                if (lowerDimensionList.Count == 0)
                {
                    return;
                }
                foreach (var i in lowerDimensionList)
                {
                    var tmp = new MultiDimensionalList { LowerDimensionList = new List<MultiDimensionalList>(), ParrentId = i.ParrentId, Id = i.Id, Name = i.Name, Data = i.Data };
                    result.Add(tmp);
                    await RecoursiveTransormList(i.LowerDimensionList, tmp.LowerDimensionList);
                }
            }

            MultiDimensionalList result = new MultiDimensionalList 
            { 
                ParrentId = this.ParrentId, Id = this.Id, Name = this.Name, Data = this.Data, LowerDimensionList = new List<MultiDimensionalList>() 
            };
            await RecoursiveTransormList(LowerDimensionList, result.LowerDimensionList);

            return result;
        }
        public async Task<OpenableMultiDimensionalList> FindElement(int elementId)
        {
            bool recoursionEnd = false;
            async Task<OpenableMultiDimensionalList> RecoursiveFindElement(OpenableMultiDimensionalList element)
            {
                if (element.Id == elementId || recoursionEnd)
                {
                    recoursionEnd = true;
                    return element;
                }
                foreach (var i in element.LowerDimensionList)
                {
                    var tmp = await RecoursiveFindElement(i);
                    if (tmp != null)
                        return tmp;
                }

                return null;
            }

            return await RecoursiveFindElement(this);
        }
        public override string ToString()
        {
            return Id.ToString();
        }
        public 
    }
}
