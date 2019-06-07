using Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class AlbumFacade
    {
        public Albums GetAlbums()
        {
            return new AlbumService().GetAlbums();
        }
    }
}
