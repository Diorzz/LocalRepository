using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMRestaurant.Models;

namespace MVVMRestaurant.Services
{
    public interface IDataService
    {
        List<Dish> GetAllDishes();
    }
}
