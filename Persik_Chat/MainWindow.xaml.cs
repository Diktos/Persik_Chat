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
    // Краще робити через окремі UserControl чи через окремі Window? 
    // Запитати за розміщення, та сама бібліотека, вийде її підкючити так щоб вона приймала ксамла елементи 
    // 
}