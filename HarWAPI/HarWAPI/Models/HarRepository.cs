using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HttpArchive;

namespace HarWAPI.Models
{
    public class HarRepository : IHarRepository
    {
        private List<HarEntity> harobjects = new List<HarEntity>();
        private int nextId = 1;

        public HarRepository() { }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HarEntity> Get()
        {
            return harobjects;
        }

        /// <summary>
        /// Gets the har text by index id.
        /// </summary>
        /// <param name="id">The index id.</param>
        /// <returns></returns>
        public HarEntity Get(int id)
        {
            return harobjects.Find(p => p.Id == id);
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">item</exception>
        public HarEntity Add(HarEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = nextId++;
            harobjects.Add(item);
            return item;
        }

        /// <summary>
        /// Removes the item by index id.
        /// </summary>
        /// <param name="id">The index id.</param>
        public void Remove(int id)
        {
            harobjects.RemoveAll(p => p.Id == id);
        }

        /// <summary>
        /// Updates the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">item</exception>
        public bool Update(HarEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = harobjects.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            harobjects.RemoveAt(index);
            harobjects.Add(item);
            return true;
        }

        /// <summary>
        /// Adds the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">source</exception>
        public HarEntity Add(string source)
        {
            HarEntity item;
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException("source");
            }
            
            try
            {
                item = Utility.HarConvert.DeserializeEntity(source);
            }
            catch
            {
                throw new ArgumentNullException("source");
            }
             
            if (!Utility.JsonValidate.Validate((IHar)item))
            {
                throw new ArgumentNullException("source");
            }

            item.Id = nextId++;
            harobjects.Add(item);
            return item;
        }

        /// <summary>
        /// Gets the Har requests.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public IEnumerable<request> GetRequests(int id)
        {
            return harobjects.Find(p => p.Id == id).log.entries.Select(a => a.request);
        }


    }
}