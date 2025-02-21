using Persik_Chat_Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Persik_Chat.Extra_Classes
{
    /// <summary>
    /// Interaction logic for LoadingProgressBar.xaml
    /// </summary>
    public partial class LoadingProgressBar : UserControl
    {
        public ObservableCollection<CellModel> Cells { get; } = new ObservableCollection<CellModel>();
        private int _progressIndex;
        private DispatcherTimer _timer;

        public LoadingProgressBar()
        {
            for (int i = 0; i < 16; i++)
                Cells.Add(new CellModel());

            _timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(300) };
            _timer.Tick += (s, e) => UpdateProgress();
            _timer.Start();
        }

        private void UpdateProgress()
        {
            if (_progressIndex < Cells.Count)
            {
                Cells[_progressIndex].IsFilled = true;
                _progressIndex++;
            }
            else
            {
                _timer.Stop();
            }
        }

    }
}
