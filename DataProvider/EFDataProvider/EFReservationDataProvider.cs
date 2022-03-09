using Hotel.DataProvider.IDataProvider;
using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.DataProvider.EFDataProvider
{
    public class EFReservationDataProvider : IReservationDataProvider
    {
        public String Add(reservationX r)
        {
            using (var mcontext = new Context())
            {
                mcontext.reservations.Add(r);
                mcontext.SaveChanges();
            }
            return "Başarıyla kaydedildi.";
                
        }
    }
}
