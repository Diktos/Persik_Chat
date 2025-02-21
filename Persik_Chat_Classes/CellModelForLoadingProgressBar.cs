using sabatex.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persik_Chat_Classes
{
    public class CellModel : ObservableObject
    {
        private bool _isFilled;

        public bool IsFilled
        {
            get => _isFilled;
            set => SetProperty(ref _isFilled, value);
        }
    }
}
