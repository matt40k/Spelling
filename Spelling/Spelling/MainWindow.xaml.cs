/*
 *   Developer : Matt Smith (matt@matt40k.co.uk)
 *   All code (c) Matthew Smith all rights reserved
 * 
 *   This software is released under Microsoft Reciprocal License (MS-RL).
 *   The license and further copyright text can be found in the file
 *   LICENSE.TXT at the root directory of the distribution.
 */

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Matt40k.Spelling
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Logic logic;
        private readonly Thickness tbNoneThickness = new Thickness(0, 0, 0, 0);
        private readonly Thickness tbThickness = new Thickness(0, 0, 25, 0);

        private int _wordLen = 8;

        public MainWindow()
        {
            InitializeComponent();

            // Load Logic
            logic = new Logic();

            bool? hasOnlyOneFolder = logic.HasOnlyOneFolder;
            if (!hasOnlyOneFolder.HasValue)
            {
                // No sub-folder in Spelling
            }
            else
            {
                if ((bool)hasOnlyOneFolder)
                {
                    SelectFolderUI(false);
                    logic.GetRandomWord();
                    _wordLen = logic.GetWordLength;

                    SetUIBoxes(_wordLen);
                    LoadWordPicture();
                }
                else
                {
                    folderComboBox.ItemsSource = logic.GetFolderNames;
                    SelectFolderUI(true);
                }
            }
        }

        public List<string> FolderList { get; set; }

        private void SetUIBoxes(int len)
        {
            // Reset the Textboxes
            ResetUI();

            if (len >= 1)
            {
                // Enable Letter1
                Letter1.Visibility = Visibility.Visible;
                Letter1.Margin = tbThickness;
                Letter1.Height = 100;
                Letter1.Width = 100;
            }

            if (len >= 2)
            {
                // Enable Letter2
                Letter2.Visibility = Visibility.Visible;
                Letter2.Margin = tbThickness;
                Letter2.Height = 100;
                Letter2.Width = 100;
            }
            if (len >= 3)
            {
                // Enable Letter3
                Letter3.Visibility = Visibility.Visible;
                Letter3.Margin = tbThickness;
                Letter3.Height = 100;
                Letter3.Width = 100;
            }
            if (len >= 4)
            {
                // Enable Letter4
                Letter4.Visibility = Visibility.Visible;
                Letter4.Margin = tbThickness;
                Letter4.Height = 100;
                Letter4.Width = 100;
            }
            if (len >= 5)
            {
                // Enable Letter5
                Letter5.Visibility = Visibility.Visible;
                Letter5.Margin = tbThickness;
                Letter5.Height = 100;
                Letter5.Width = 100;
            }
            if (len >= 6)
            {
                // Enable Letter6
                Letter6.Visibility = Visibility.Visible;
                Letter6.Margin = tbThickness;
                Letter6.Height = 100;
                Letter6.Width = 100;
            }
            if (len >= 7)
            {
                // Enable Letter7
                Letter7.Visibility = Visibility.Visible;
                Letter7.Margin = tbThickness;
                Letter7.Height = 100;
                Letter7.Width = 100;
            }
            if (len >= 8)
            {
                // Enable Letter8
                Letter8.Visibility = Visibility.Visible;
                Letter8.Margin = tbThickness;
                Letter8.Height = 100;
                Letter8.Width = 100;
            }
            if (len >= 9)
            {
                // Enable Letter9
                Letter9.Visibility = Visibility.Visible;
                Letter9.Margin = tbThickness;
                Letter9.Height = 100;
                Letter9.Width = 100;
            }
            if (len >= 10)
            {
                // Enable Letter10
                Letter10.Visibility = Visibility.Visible;
                Letter10.Margin = tbThickness;
                Letter10.Height = 100;
                Letter10.Width = 100;
            }
            if (len >= 11)
            {
                // Enable Letter11
                Letter11.Visibility = Visibility.Visible;
                Letter11.Margin = tbThickness;
                Letter11.Height = 100;
                Letter11.Width = 100;
            }
            if (len >= 12)
            {
                // Enable Letter12
                Letter12.Visibility = Visibility.Visible;
                Letter12.Margin = tbThickness;
                Letter12.Height = 100;
                Letter12.Width = 100;
            }
        }

        private void ResetUI()
        {
            // Set all textboxes to invisible 
            Letter1.Visibility = Visibility.Hidden;
            Letter2.Visibility = Visibility.Hidden;
            Letter3.Visibility = Visibility.Hidden;
            Letter4.Visibility = Visibility.Hidden;
            Letter5.Visibility = Visibility.Hidden;
            Letter6.Visibility = Visibility.Hidden;
            Letter7.Visibility = Visibility.Hidden;
            Letter8.Visibility = Visibility.Hidden;
            Letter9.Visibility = Visibility.Hidden;
            Letter10.Visibility = Visibility.Hidden;
            Letter11.Visibility = Visibility.Hidden;
            Letter12.Visibility = Visibility.Hidden;

            // Set all textboxes margins to zero
            Letter1.Margin = tbNoneThickness;
            Letter2.Margin = tbNoneThickness;
            Letter3.Margin = tbNoneThickness;
            Letter4.Margin = tbNoneThickness;
            Letter5.Margin = tbNoneThickness;
            Letter6.Margin = tbNoneThickness;
            Letter7.Margin = tbNoneThickness;
            Letter8.Margin = tbNoneThickness;
            Letter9.Margin = tbNoneThickness;
            Letter10.Margin = tbNoneThickness;
            Letter11.Margin = tbNoneThickness;
            Letter12.Margin = tbNoneThickness;

            // Set all textboxes Height to zero
            Letter1.Height = 0;
            Letter2.Height = 0;
            Letter3.Height = 0;
            Letter4.Height = 0;
            Letter5.Height = 0;
            Letter6.Height = 0;
            Letter7.Height = 0;
            Letter8.Height = 0;
            Letter9.Height = 0;
            Letter10.Height = 0;
            Letter11.Height = 0;
            Letter12.Height = 0;

            // Set all textboxes Width to zero
            Letter1.Width = 0;
            Letter2.Width = 0;
            Letter3.Width = 0;
            Letter4.Width = 0;
            Letter5.Width = 0;
            Letter6.Width = 0;
            Letter7.Width = 0;
            Letter8.Width = 0;
            Letter9.Width = 0;
            Letter10.Width = 0;
            Letter11.Width = 0;
            Letter12.Width = 0;

            wordPicture.Margin = tbNoneThickness;

            // Reset the values in the textboxes
            ResetTextboxes();
        }

        private void LoadWordPicture()
        {
            wordPicture.Source = logic.GetWordPicture;
            wordPicture.Margin = new Thickness(0, 0, 0, 100);
        }

        private void Letter_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.A) || (e.Key > Key.Z))
                e.Handled = true;
        }

        private void revealButton_Click(object sender, RoutedEventArgs e)
        {
            string buttonText = revealButton.Content.ToString();

            if (buttonText == "Reveal")
            {
                int len = _wordLen;
                if (len >= 1)
                {
                    // Reveal Letter1
                    Letter1.Text = logic.RevealLetter(1);
                }

                if (len >= 2)
                {
                    // Reveal Letter2
                    Letter2.Text = logic.RevealLetter(2);
                }
                if (len >= 3)
                {
                    // Reveal Letter3
                    Letter3.Text = logic.RevealLetter(3);
                }
                if (len >= 4)
                {
                    // Reveal Letter4
                    Letter4.Text = logic.RevealLetter(4);
                }
                if (len >= 5)
                {
                    // Reveal Letter5
                    Letter5.Text = logic.RevealLetter(5);
                }
                if (len >= 6)
                {
                    // Reveal Letter6
                    Letter6.Text = logic.RevealLetter(6);
                }
                if (len >= 7)
                {
                    // Reveal Letter7
                    Letter7.Text = logic.RevealLetter(7);
                }
                if (len >= 8)
                {
                    // Reveal Letter8
                    Letter8.Text = logic.RevealLetter(8);
                }
                if (len >= 9)
                {
                    // Reveal Letter9
                    Letter9.Text = logic.RevealLetter(9);
                }
                if (len >= 10)
                {
                    // Reveal Letter10
                    Letter10.Text = logic.RevealLetter(10);
                }
                if (len >= 11)
                {
                    // Reveal Letter11
                    Letter11.Text = logic.RevealLetter(11);
                }
                if (len >= 12)
                {
                    // Reveal Letter12
                    Letter12.Text = logic.RevealLetter(12);
                }

                // Change button to hide
                revealButton.Content = "Reset";
            }
            else
            {
                ResetTextboxes();
            }
        }

        private void ResetTextboxes()
        {
            // Reset textboxes
            Letter1.Text = "";
            Letter2.Text = "";
            Letter3.Text = "";
            Letter4.Text = "";
            Letter5.Text = "";
            Letter6.Text = "";
            Letter7.Text = "";
            Letter8.Text = "";
            Letter9.Text = "";
            Letter10.Text = "";
            Letter11.Text = "";
            Letter12.Text = "";

            // Re-run validation to reset background
            Validation();

            // Change button to reveal
            revealButton.Content = "Reveal";
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            SelectFolderUI(false);

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
                string letter = Letter1.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 1);
                if (IsValid)
                    Letter1.Background = Brushes.Green;
                else
                {
                    Letter1.ClearValue(BackgroundProperty);
                }
            }

            if (len >= 2)
            {
                // Reveal Letter2
                string letter = Letter2.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 2);
                if (IsValid)
                    Letter2.Background = Brushes.Green;
                else
                    Letter2.ClearValue(BackgroundProperty);
            }
            if (len >= 3)
            {
                // Reveal Letter3
                string letter = Letter3.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 3);
                if (IsValid)
                    Letter3.Background = Brushes.Green;
                else
                    Letter3.ClearValue(BackgroundProperty);
            }
            if (len >= 4)
            {
                // Reveal Letter4
                string letter = Letter4.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 4);
                if (IsValid)
                    Letter4.Background = Brushes.Green;
                else
                    Letter4.ClearValue(BackgroundProperty);
            }
            if (len >= 5)
            {
                // Reveal Letter5
                string letter = Letter5.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 5);
                if (IsValid)
                    Letter5.Background = Brushes.Green;
                else
                    Letter5.ClearValue(BackgroundProperty);
            }
            if (len >= 6)
            {
                // Reveal Letter6
                string letter = Letter6.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 6);
                if (IsValid)
                    Letter6.Background = Brushes.Green;
                else
                    Letter6.ClearValue(BackgroundProperty);
            }
            if (len >= 7)
            {
                // Reveal Letter7
                string letter = Letter7.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 7);
                if (IsValid)
                    Letter7.Background = Brushes.Green;
                else
                    Letter7.ClearValue(BackgroundProperty);
            }
            if (len >= 8)
            {
                // Reveal Letter8
                string letter = Letter8.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 8);
                if (IsValid)
                    Letter8.Background = Brushes.Green;
                else
                    Letter8.ClearValue(BackgroundProperty);
            }
            if (len >= 9)
            {
                // Reveal Letter9
                string letter = Letter9.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 9);
                if (IsValid)
                    Letter9.Background = Brushes.Green;
                else
                    Letter9.ClearValue(BackgroundProperty);
            }
            if (len >= 10)
            {
                // Reveal Letter10
                string letter = Letter10.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 10);
                if (IsValid)
                    Letter10.Background = Brushes.Green;
                else
                    Letter10.ClearValue(BackgroundProperty);
            }
            if (len >= 11)
            {
                // Reveal Letter11
                string letter = Letter11.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 11);
                if (IsValid)
                    Letter11.Background = Brushes.Green;
                else
                    Letter11.ClearValue(BackgroundProperty);
            }
            if (len >= 12)
            {
                // Reveal Letter12
                string letter = Letter12.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 12);
                if (IsValid)
                    Letter12.Background = Brushes.Green;
                else
                    Letter12.ClearValue(BackgroundProperty);
            }
        }

        private void Letter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validation();
        }

        private void SelectFolderUI(bool value)
        {
            if (value)
            {
                folderComboBox.Visibility = Visibility.Visible;
                revealButton.Visibility = Visibility.Hidden;
            }
            else
            {
                folderComboBox.Visibility = Visibility.Hidden;
                revealButton.Visibility = Visibility.Visible;
            }
        }

        private void folderComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logic.SetSelectedFolder = folderComboBox.SelectedValue.ToString();
        }
    }
}