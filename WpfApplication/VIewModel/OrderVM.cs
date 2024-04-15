using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.Model;

namespace WpfApplication.VIewModel
{
    class OrderVM: Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public DateTime DisplayOrderDate
        {
            get { return _pageModel.OrderDate; }
            set { _pageModel.OrderDate = value; OnPropertyChanged(); }
        }

        public OrderVM()
        {
            _pageModel = new PageModel();
            DisplayOrderDate = DateTime.Now;
        }
    }
}
