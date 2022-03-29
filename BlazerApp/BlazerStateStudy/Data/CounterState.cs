using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerStateStudy.Data
{
    public class CounterState
    {
        int _count = 0;

        public Action OnStatChanged;

        public int Count
        {
            get {
                return _count;
            }

            set {
                _count = value;
                Refresh();
            }
        }

        void Refresh()
        {
            OnStatChanged?.Invoke();
        }
    }
}
