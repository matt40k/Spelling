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

        private int _wordLen = 8;

        public MainWindow()
        {
            InitializeComponent();

            // Load Logic
            logic = new Logic();
            if (logic.HasOnlyOneFolder)
            {
                logic.GetRandomWord();
                _wordLen = logic.GetWordLength;
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

            // Reset the values in the textboxes
            ResetTextboxes();
        }

        private void LoadWordPicture()
        {
            this.wordPicture.Source = logic.GetWordPicture;
            this.wordPicture.Margin = new Thickness(0, 0, 0, 100);
        }

        private void Letter_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.A) || (e.Key > Key.Z))
                e.Handled = true;
        }

        private void revealButton_Click(object sender, RoutedEventArgs e)
        {
            string buttonText = this.revealButton.Content.ToString();

            if (buttonText == "Reveal")
            {
                int len = _wordLen;
                if (len >= 1)
                {
                    // Reveal Letter1
                    this.Letter1.Text = logic.RevealLetter(1);
                }

                if (len >= 2)
                {
                    // Reveal Letter2
                    this.Letter2.Text = logic.RevealLetter(2);
                }
                if (len >= 3)
                {
                    // Reveal Letter3
                    this.Letter3.Text = logic.RevealLetter(3);
                }
                if (len >= 4)
                {
                    // Reveal Letter4
                    this.Letter4.Text = logic.RevealLetter(4);
                }
                if (len >= 5)
                {
                    // Reveal Letter5
                    this.Letter5.Text = logic.RevealLetter(5);
                }
                if (len >= 6)
                {
                    // Reveal Letter6
                    this.Letter6.Text = logic.RevealLetter(6);
                }
                if (len >= 7)
                {
                    // Reveal Letter7
                    this.Letter7.Text = logic.RevealLetter(7);
                }
                if (len >= 8)
                {
                    // Reveal Letter8
                    this.Letter8.Text = logic.RevealLetter(8);
                }
                if (len >= 9)
                {
                    // Reveal Letter9
                    this.Letter9.Text = logic.RevealLetter(9);
                }
                if (len >= 10)
                {
                    // Reveal Letter10
                    this.Letter10.Text = logic.RevealLetter(10);
                }
                if (len >= 11)
                {
                    // Reveal Letter11
                    this.Letter11.Text = logic.RevealLetter(11);
                }
                if (len >= 12)
                {
                    // Reveal Letter12
                    this.Letter12.Text = logic.RevealLetter(12);
                }

                // Change button to hide
                this.revealButton.Content = "Reset";
            }
            else
            {
                ResetTextboxes();
            }
        }

        private void ResetTextboxes()
        {
            // Reset textboxes
            this.Letter1.Text = "";
            this.Letter2.Text = "";
            this.Letter3.Text = "";
            this.Letter4.Text = "";
            this.Letter5.Text = "";
            this.Letter6.Text = "";
            this.Letter7.Text = "";
            this.Letter8.Text = "";
            this.Letter9.Text = "";
            this.Letter10.Text = "";
            this.Letter11.Text = "";
            this.Letter12.Text = "";

            // Re-run validation to reset background
            Validation();

            // Change button to reveal
            this.revealButton.Content = "Reveal";
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            logic.GetRandomWord();
            _wordLen = logic.GetWordLength;

            SetUIBoxes(_wordLen);
            LoadWordPicture();
        }

        private void Validation()
        {
            int len = _wordLen;
            if (len >= 1)
            {
                // Reveal Letter1
                string letter = this.Letter1.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 1);
                if (IsValid)
                    this.Letter1.Background = Brushes.Green;
                else
                    this.Letter1.ClearValue(TextBox.BackgroundProperty);
            }

            if (len >= 2)
            {
                // Reveal Letter2
                string letter = this.Letter2.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 2);
                if (IsValid)
                    this.Letter2.Background = Brushes.Green;
                else
                    this.Letter2.ClearValue(TextBox.BackgroundProperty);
            }
            if (len >= 3)
            {
                // Reveal Letter3
                string letter = this.Letter3.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 3);
                if (IsValid)
                    this.Letter3.Background = Brushes.Green;
                else
                    this.Letter3.ClearValue(TextBox.BackgroundProperty);
            }
            if (len >= 4)
            {
                // Reveal Letter4
                string letter = this.Letter4.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 4);
                if (IsValid)
                    this.Letter4.Background = Brushes.Green;
                else
                    this.Letter4.ClearValue(TextBox.BackgroundProperty);
            }
            if (len >= 5)
            {
                // Reveal Letter5
                string letter = this.Letter5.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 5);
                if (IsValid)
                    this.Letter5.Background = Brushes.Green;
                else
                    this.Letter5.ClearValue(TextBox.BackgroundProperty);
            }
            if (len >= 6)
            {
                // Reveal Letter6
                string letter = this.Letter6.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 6);
                if (IsValid)
                    this.Letter6.Background = Brushes.Green;
                else
                    this.Letter6.ClearValue(TextBox.BackgroundProperty);
            }
            if (len >= 7)
            {
                // Reveal Letter7
                string letter = this.Letter7.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 7);
                if (IsValid)
                    this.Letter7.Background = Brushes.Green;
                else
                    this.Letter7.ClearValue(TextBox.BackgroundProperty);
            }
            if (len >= 8)
            {
                // Reveal Letter8
                string letter = this.Letter8.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 8);
                if (IsValid)
                    this.Letter8.Background = Brushes.Green;
                else
                    this.Letter8.ClearValue(TextBox.BackgroundProperty);
            }
            if (len >= 9)
            {
                // Reveal Letter9
                string letter = this.Letter9.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 9);
                if (IsValid)
                    this.Letter9.Background = Brushes.Green;
                else
                    this.Letter9.ClearValue(TextBox.BackgroundProperty);
            }
            if (len >= 10)
            {
                // Reveal Letter10
                string letter = this.Letter10.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 10);
                if (IsValid)
                    this.Letter10.Background = Brushes.Green;
                else
                    this.Letter10.ClearValue(TextBox.BackgroundProperty);
            }
            if (len >= 11)
            {
                // Reveal Letter11
                string letter = this.Letter11.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 11);
                if (IsValid)
                    this.Letter11.Background = Brushes.Green;
                else
                    this.Letter11.ClearValue(TextBox.BackgroundProperty);
            }
            if (len >= 12)
            {
                // Reveal Letter12
                string letter = this.Letter12.Text.ToString();
                bool IsValid = logic.IsLetterCorrect(letter, 12);
                if (IsValid)
                    this.Letter12.Background = Brushes.Green;
                else
                    this.Letter12.ClearValue(TextBox.BackgroundProperty);
            }

        }

        private void Letter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validation();
        }
    }
}
