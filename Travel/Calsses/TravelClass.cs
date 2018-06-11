using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayer;
using Helper;

namespace Travel.Calsses
{
    public static class TravelClass
    {
        public static class DropDown
        {
            public static List<IdTitle> PlaceIdTitles()
            {
                var idTitle = new List<IdTitle>()
                {
                    new IdTitle()
                    {
                        Id = 0,
                        Title = "قاره"
                    }
                };
                using (TravelContext db =new TravelContext())
                {
                    idTitle.AddRange(db.Places.Select(u => new IdTitle()
                    {
                        Title = u.Title,
                        Id = u.Id
                    }));
                }

                return idTitle;
            }
        }
    }
}