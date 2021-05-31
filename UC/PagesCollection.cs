using System.Collections.Generic;
using System.Linq;

namespace TemperatureTool.UC
{
    public class PagesCollection
    {
        private IList<Page> _pages;

        public PagesCollection()
        {
            _pages = new List<Page>();
        }

        public void Add(int pageNumber, int totalRows)
        {
            var exist = _pages.Where(r => r.PageNumber == pageNumber).FirstOrDefault();
            if (exist != null)
            {
                exist.TotalRows = totalRows;
            }
            else
                _pages.Add(new Page() { PageNumber = pageNumber, TotalRows = totalRows });
        }

        public int TotalRows(int pageNumber)
        {
            var exist = _pages.Where(r => r.PageNumber == pageNumber).FirstOrDefault();
            if (exist != null)
                return exist.TotalRows;
            return 0;
        }

        public int StartIndex(int pageNumber)
        {
            int startIndex = 0;
            if (pageNumber == 1)
            {
                startIndex = pageNumber;
            }
            else
            {
                foreach (var page in this._pages)
                {                   
                    if (page.PageNumber >= pageNumber) 
                        break;
                    startIndex += page.PageNumber * page.TotalRows;
                }
            }

            return startIndex;
        }
    }

    public class Page
    {
        public int PageNumber { get; set; }
        public int TotalRows { get; set; }
    }
}
