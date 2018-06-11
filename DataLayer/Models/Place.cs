using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Place
    {
        [Key]
        public int Id { get; set; }
        public int? PlaceId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
        public string ImageName { get; set; }

        public Place()
        {
            
        }

        public virtual Place Place1{ get; set; }
        public virtual List<Place> Places { get; set; }




    }
}
