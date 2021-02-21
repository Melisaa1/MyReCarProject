using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car: IEntity 
    {
        public int CarId { get; set; }
        public int CategoryId { get; set; }
        public string CarBrandId { get; set; }
        public string CarColorId { get; set; }
        public int CarModelYear { get; set; }
        public int CarDailyPrice { get; set; }
        public string CarDescription { get; set; }

    }
}
