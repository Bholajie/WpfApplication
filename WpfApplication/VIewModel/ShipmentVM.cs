using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.Model;

namespace WpfApplication.VIewModel
{
     class ShipmentVM: Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public DateTime ShipmentTracking
        {
            get { return _pageModel.ShipmentDelivery; }
            set { _pageModel.ShipmentDelivery = value; OnPropertyChanged(); }
        }

        public ShipmentVM()
        {
            _pageModel = new PageModel();
            DateTime time = DateTime.Now;
            ShipmentTracking = time;
        }
    }
}
