using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpArchive;

namespace HarWAPI.Models
{
    public interface IHarRepository
    {
        IEnumerable<HarEntity> Get();
        HarEntity Get(int id);
        HarEntity Add(HarEntity item);
        void Remove(int id);
        bool Update(HarEntity item);

        HarEntity Add(string source);
        //IEnumerable<request> GetRequests(int id);
    }
}
