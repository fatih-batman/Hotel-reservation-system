using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.DataProvider.IDataProvider
{
    interface IReservationDataProvider
    {

        string Add(reservationX reservation);
    }
}
