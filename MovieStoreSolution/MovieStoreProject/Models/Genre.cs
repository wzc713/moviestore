using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStoreProject.Models
{
    public class Genre
    {
        //ID或者类名加上id默认作为主键，否则需要加上[key]关键字作为主键
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}