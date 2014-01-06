using System;
using System.Collections.Generic;
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



using System.IO;

namespace Matt40k.Spelling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Logic logic;
        private Thickness tbThickness = new Thickness(0, 0, 25, 0);
        private Thickness tbNoneThickness = new Thickness(0, 0, 0, 0);

        //private string _word = "spelling";
        private int _wordLen = 8;
        private string _wordPic;

        public MainWindow()
        {
            InitializeComponent();

            // Load Logic
            logic = new Logic();
            if (logic.HasOnlyOneFolder)
            {
                logic.GetRandomWord();
                _wordLen = logic.GetWordLength;
                _wordPic = logic.GetWordPicturePath;
            }
            else
            {
                // TODO
            }

            SetUIBoxes(_wordLen);
            LoadWordPicture();
        }

        private void SetUIBoxes(int len)
        {
            // Reset the Textboxes
            ResetUI();

            if (len >= 1)
            {
                // Enable Letter1
                this.Letter1.Visibility = Visibility.Visible;
                this.Letter1.Margin = tbThickness;
                this.Letter1.Height = 100;
                this.Letter1.Width = 100;
            }

            if (len >= 2)
            {
                // Enable Letter2
                this.Letter2.Visibility = Visibility.Visible;
                this.Letter2.Margin = tbThickness;
                this.Letter2.Height = 100;
                this.Letter2.Width = 100;
            }
            if (len >= 3)
            {
                // Enable Letter3
                this.Letter3.Visibility = Visibility.Visible;
                this.Letter3.Margin = tbThickness;
                this.Letter3.Height = 100;
                this.Letter3.Width = 100;
            }
            if (len >= 4)
            {
                // Enable Letter4
                this.Letter4.Visibility = Visibility.Visible;
                this.Letter4.Margin = tbThickness;
                this.Letter4.Height = 100;
                this.Letter4.Width = 100;
            }
            if (len >= 5)
            {
                // Enable Letter5
                this.Letter5.Visibility = Visibility.Visible;
                this.Letter5.Margin = tbThickness;
                this.Letter5.Height = 100;
                this.Letter5.Width = 100;
            }
            if (len >= 6)
            {
                // Enable Letter6
                this.Letter6.Visibility = Visibility.Visible;
                this.Letter6.Margin = tbThickness;
                this.Letter6.Height = 100;
                this.Letter6.Width = 100;
            }
            if (len >= 7)
            {
                // Enable Letter7
                this.Letter7.Visibility = Visibility.Visible;
                this.Letter7.Margin = tbThickness;
                this.Letter7.Height = 100;
                this.Letter7.Width = 100;
            }
            if (len >= 8)
            {
                // Enable Letter8
                this.Letter8.Visibility = Visibility.Visible;
                this.Letter8.Margin = tbThickness;
                this.Letter8.Height = 100;
                this.Letter8.Width = 100;
            }
            if (len >= 9)
            {
                // Enable Letter9
                this.Letter9.Visibility = Visibility.Visible;
                this.Letter9.Margin = tbThickness;
                this.Letter9.Height = 100;
                this.Letter9.Width = 100;
            }
            if (len >= 10)
            {
                // Enable Letter10
                this.Letter10.Visibility = Visibility.Visible;
                this.Letter10.Margin = tbThickness;
                this.Letter10.Height = 100;
                this.Letter10.Width = 100;
            }
            if (len >= 11)
            {
                // Enable Letter11
                this.Letter11.Visibility = Visibility.Visible;
                this.Letter11.Margin = tbThickness;
                this.Letter11.Height = 100;
                this.Letter11.Width = 100;
            }
            if (len >= 12)
            {
                // Enable Letter12
                this.Letter12.Visibility = Visibility.Visible;
                this.Letter12.Margin = tbThickness;
                this.Letter12.Height = 100;
                this.Letter12.Width = 100;
            }
        }

        private void ResetUI()
        {
            // Set all textboxes to invisible 
            this.Letter1.Visibility = Visibility.Hidden;
            this.Letter2.Visibility = Visibility.Hidden;
            this.Letter3.Visibility = Visibility.Hidden;
            this.Letter4.Visibility = Visibility.Hidden;
            this.Letter5.Visibility = Visibility.Hidden;
            this.Letter6.Visibility = Visibility.Hidden;
            this.Letter7.Visibility = Visibility.Hidden;
            this.Letter8.Visibility = Visibility.Hidden;
            this.Letter9.Visibility = Visibility.Hidden;
            this.Letter10.Visibility = Visibility.Hidden;
            this.Letter11.Visibility = Visibility.Hidden;
            this.Letter12.Visibility = Visibility.Hidden;

            // Set all textboxes margins to zero
            this.Letter1.Margin = tbNoneThickness;
            this.Letter2.Margin = tbNoneThickness;
            this.Letter3.Margin = tbNoneThickness;
            this.Letter4.Margin = tbNoneThickness;
            this.Letter5.Margin = tbNoneThickness;
            this.Letter6.Margin = tbNoneThickness;
            this.Letter7.Margin = tbNoneThickness; 
            this.Letter8.Margin = tbNoneThickness;
            this.Letter9.Margin = tbNoneThickness;
            this.Letter10.Margin = tbNoneThickness;
            this.Letter11.Margin = tbNoneThickness;
            this.Letter12.Margin = tbNoneThickness;

            // Set all textboxes Height to zero
            this.Letter1.Height = 0;
            this.Letter2.Height = 0;
            this.Letter3.Height = 0;
            this.Letter4.Height = 0;
            this.Letter5.Height = 0;
            this.Letter6.Height = 0;
            this.Letter7.Height = 0;
            this.Letter8.Height = 0;
            this.Letter9.Height = 0;
            this.Letter10.Height = 0;
            this.Letter11.Height = 0;
            this.Letter12.Height = 0;

            // Set all textboxes Width to zero
            this.Letter1.Width = 0;
            this.Letter2.Width = 0;
            this.Letter3.Width = 0;
            this.Letter4.Width = 0;
            this.Letter5.Width = 0;
            this.Letter6.Width = 0;
            this.Letter7.Width = 0;
            this.Letter8.Width = 0;
            this.Letter9.Width = 0;
            this.Letter10.Width = 0;
            this.Letter11.Width = 0;
            this.Letter12.Width = 0;

            this.wordPicture.Margin = tbNoneThickness;
        }

        private void LoadWordPicture()
        {
            if (string.IsNullOrEmpty(_wordPic))
            {
                // Word Picture not set
            }
            else
            {
                this.wordPicture.Source = logic.GetWordPicture;
                this.wordPicture.Margin = new Thickness(0, 0, 0, 100);
            }
        }
    }
}
