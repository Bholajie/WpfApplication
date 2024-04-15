using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.Model;

namespace WpfApplication.VIewModel
{
    class TransactionVM:Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public decimal TransactionAmount
        {
            get { return _pageModel.TransactionalValue; }
            set { _pageModel.TransactionalValue = value; OnPropertyChanged(); }
        }

        public TransactionVM()
        {
            _pageModel = new PageModel();
            TransactionAmount = 5638;
        }
    }
}
