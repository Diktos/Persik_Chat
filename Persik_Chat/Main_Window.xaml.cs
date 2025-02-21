using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Persik_Chat_Classes;

namespace Persik_Chat
{
    // Не всі дані є у користувача, він отримує їх в залежності від запиту на сервер
    public partial class MainWindow : Window
    {
        private LanguageChat language = LanguageChat.Ua;
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

    }
    public enum LanguageChat
    {
        En,
        Ua
    }
    // Краще робити через окремі UserControl 



    // Запитати 

    // Як додати до проєкту контрол який знаходиться не у проєкті а у папці у проєкті чи у солушені.

    // Як змінити назву контрола, в даному випадку забув до їх назв додати Control, щоб нічого не ломалося потім.

    // Я змінив назву головного вікна на свою, потім на початкову(меін віндов) і тепер контроли не хочуть підключатися нові до головного вікна,
    // а після білду солушена повністю і ребілда, всі не знаходяться.
}