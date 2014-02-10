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
using Matt40k.Spelling.Fireworks;

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

        private SimulatorControl simulatorControl;
        private int masterTimerPeriod = 50;
        private BombConfigControl bombConfigControl4;
        private BombConfigControl bombConfigControl3;
        private BombConfigControl bombConfigControl2;
        private BombConfigControl bombConfigControl1;
        private BombConfigControl bombConfigControl9;
        private BombConfigControl bombConfigControl8;
        private BombConfigControl bombConfigControl7;
        private BombConfigControl bombConfigControl6;
        private BombConfigControl bombConfigControl5;
        private BombConfigControl bombConfigControl10;

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

                    LoadFire();
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
                    Letter1.ClearValue(BackgroundProperty);
            }

            if (len >= 2)
            {
                // Reveal Letter2
                string letter = Letter2.Text;
                bool IsValid = logic.IsLetterCorrect(letter, 2);
                if (IsValid)
                {
                    Letter2.Background = Brushes.Green;

                }
                else
                {
                    Letter2.ClearValue(BackgroundProperty);
                }
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

            // Move selected textbox to the next one if the current one is correct.
            int nextLetter = GetNextLetter;
            if (nextLetter == 100)
            {
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private int GetNextLetter
        {
            get
            {
                int len = _wordLen;
                if (Letter1.Background != Brushes.Green && len >= 1)
                {
                    Letter1.Focus();
                    return 1;
                }
                if (Letter2.Background != Brushes.Green && len >= 2)
                {
                    Letter2.Focus();
                    return 2;
                }
                if (Letter3.Background != Brushes.Green && len >= 3)
                {
                    Letter3.Focus();
                    return 3;
                }
                if (Letter4.Background != Brushes.Green && len >= 4)
                {
                    Letter4.Focus();
                    return 4;
                }
                if (Letter5.Background != Brushes.Green && len >= 5)
                {
                    Letter5.Focus();
                    return 5;
                }
                if (Letter6.Background != Brushes.Green && len >= 6)
                {
                    Letter6.Focus();
                    return 6;
                }
                if (Letter7.Background != Brushes.Green && len >= 7)
                {
                    Letter7.Focus();
                    return 7;
                }
                if (Letter8.Background != Brushes.Green && len >= 8)
                {
                    Letter8.Focus();
                    return 8;
                }

                if (Letter9.Background != Brushes.Green && len >= 9)
                {
                    Letter9.Focus();
                    return 9;
                }
                if (Letter10.Background != Brushes.Green && len >= 10)
                {
                    Letter10.Focus();
                    return 10;
                }
                if (Letter11.Background != Brushes.Green && len >= 11)
                {
                    Letter11.Focus();
                    return 11;
                }
                if (Letter12.Background != Brushes.Green && len >= 12)
                {
                    Letter12.Focus();
                    return 12;
                }

                return 100;
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

        private void LoadFire()
        {
            //
            //
            //
            this.bombConfigControl10 = new Fireworks.BombConfigControl();
            this.bombConfigControl9 = new Fireworks.BombConfigControl();
            this.bombConfigControl8 = new Fireworks.BombConfigControl();
            this.bombConfigControl7 = new Fireworks.BombConfigControl();
            this.bombConfigControl6 = new Fireworks.BombConfigControl();
            this.bombConfigControl5 = new Fireworks.BombConfigControl();
            this.bombConfigControl4 = new Fireworks.BombConfigControl();
            this.bombConfigControl3 = new Fireworks.BombConfigControl();
            this.bombConfigControl2 = new Fireworks.BombConfigControl();
            this.bombConfigControl1 = new Fireworks.BombConfigControl();


            // 
            // bombConfigControl10
            // 
            this.bombConfigControl10.BackColor = System.Drawing.Color.DimGray;
            this.bombConfigControl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombConfigControl10.Location = new System.Drawing.Point(957, 6);
            this.bombConfigControl10.Name = "bombConfigControl10";
            this.bombConfigControl10.Size = new System.Drawing.Size(100, 182);
            this.bombConfigControl10.TabIndex = 8;
            this.bombConfigControl10.FireButtonPressed += new System.EventHandler(this.bombConfigControl10_FireButtonPressed);
            // 
            // bombConfigControl9
            // 
            this.bombConfigControl9.BackColor = System.Drawing.Color.Silver;
            this.bombConfigControl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombConfigControl9.Location = new System.Drawing.Point(851, 6);
            this.bombConfigControl9.Name = "bombConfigControl9";
            this.bombConfigControl9.Size = new System.Drawing.Size(100, 182);
            this.bombConfigControl9.TabIndex = 7;
            this.bombConfigControl9.FireButtonPressed += new System.EventHandler(this.bombConfigControl9_FireButtonPressed);
            // 
            // bombConfigControl8
            // 
            this.bombConfigControl8.BackColor = System.Drawing.Color.Gray;
            this.bombConfigControl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombConfigControl8.Location = new System.Drawing.Point(745, 6);
            this.bombConfigControl8.Name = "bombConfigControl8";
            this.bombConfigControl8.Size = new System.Drawing.Size(100, 182);
            this.bombConfigControl8.TabIndex = 5;
            this.bombConfigControl8.FireButtonPressed += new System.EventHandler(this.bombConfigControl8_FireButtonPressed);
            // 
            // bombConfigControl7
            // 
            this.bombConfigControl7.BackColor = System.Drawing.Color.Silver;
            this.bombConfigControl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombConfigControl7.Location = new System.Drawing.Point(639, 6);
            this.bombConfigControl7.Name = "bombConfigControl7";
            this.bombConfigControl7.Size = new System.Drawing.Size(100, 182);
            this.bombConfigControl7.TabIndex = 6;
            this.bombConfigControl7.FireButtonPressed += new System.EventHandler(this.bombConfigControl7_FireButtonPressed);
            // 
            // bombConfigControl6
            // 
            this.bombConfigControl6.BackColor = System.Drawing.Color.Gray;
            this.bombConfigControl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombConfigControl6.Location = new System.Drawing.Point(533, 6);
            this.bombConfigControl6.Name = "bombConfigControl6";
            this.bombConfigControl6.Size = new System.Drawing.Size(100, 182);
            this.bombConfigControl6.TabIndex = 5;
            this.bombConfigControl6.FireButtonPressed += new System.EventHandler(this.bombConfigControl6_FireButtonPressed);
            // 
            // bombConfigControl5
            // 
            this.bombConfigControl5.BackColor = System.Drawing.Color.Silver;
            this.bombConfigControl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombConfigControl5.Location = new System.Drawing.Point(427, 6);
            this.bombConfigControl5.Name = "bombConfigControl5";
            this.bombConfigControl5.Size = new System.Drawing.Size(100, 182);
            this.bombConfigControl5.TabIndex = 4;
            this.bombConfigControl5.FireButtonPressed += new System.EventHandler(this.bombConfigControl5_FireButtonPressed);
            // 
            // bombConfigControl4
            // 
            this.bombConfigControl4.BackColor = System.Drawing.Color.Gray;
            this.bombConfigControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombConfigControl4.Location = new System.Drawing.Point(321, 6);
            this.bombConfigControl4.Name = "bombConfigControl4";
            this.bombConfigControl4.Size = new System.Drawing.Size(100, 182);
            this.bombConfigControl4.TabIndex = 3;
            this.bombConfigControl4.FireButtonPressed += new System.EventHandler(this.bombConfigControl4_FireButtonPressed);
            // 
            // bombConfigControl3
            // 
            this.bombConfigControl3.BackColor = System.Drawing.Color.Silver;
            this.bombConfigControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombConfigControl3.Location = new System.Drawing.Point(215, 6);
            this.bombConfigControl3.Name = "bombConfigControl3";
            this.bombConfigControl3.Size = new System.Drawing.Size(100, 182);
            this.bombConfigControl3.TabIndex = 2;
            this.bombConfigControl3.FireButtonPressed += new System.EventHandler(this.bombConfigControl3_FireButtonPressed);
            // 
            // bombConfigControl2
            // 
            this.bombConfigControl2.BackColor = System.Drawing.Color.Gray;
            this.bombConfigControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombConfigControl2.Location = new System.Drawing.Point(109, 6);
            this.bombConfigControl2.Name = "bombConfigControl2";
            this.bombConfigControl2.Size = new System.Drawing.Size(100, 182);
            this.bombConfigControl2.TabIndex = 1;
            this.bombConfigControl2.FireButtonPressed += new System.EventHandler(this.bombConfigControl2_FireButtonPressed);
            // 
            // bombConfigControl1
            // 
            this.bombConfigControl1.BackColor = System.Drawing.Color.Silver;
            this.bombConfigControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bombConfigControl1.Location = new System.Drawing.Point(3, 6);
            this.bombConfigControl1.Name = "bombConfigControl1";
            this.bombConfigControl1.Size = new System.Drawing.Size(100, 182);
            this.bombConfigControl1.TabIndex = 0;
            this.bombConfigControl1.FireButtonPressed += new System.EventHandler(this.bombConfigControl1_FireButtonPressed);


            //
            //
            //

            // Init launcher #01
            //bombConfigControl1.SetFireButtonText("Fire! (F1)");
            bombConfigControl1.SetBombColor(System.Drawing.Color.Blue);
            bombConfigControl1.SetLaunchSpeed(15);
            bombConfigControl1.SetExploseSpeed(10);
            bombConfigControl1.SetExploseForm(1);

            // Init launcher #02
            //bombConfigControl2.SetFireButtonText("Fire! (F2)");
            bombConfigControl2.SetBombColor(System.Drawing.Color.WhiteSmoke);
            bombConfigControl2.SetLaunchSpeed(20);
            bombConfigControl2.SetExploseSpeed(10);
            bombConfigControl2.SetExploseForm(1);

            // Init launcher #03
            //bombConfigControl3.SetFireButtonText("Fire! (F3)");
            bombConfigControl3.SetBombColor(System.Drawing.Color.Red);
            bombConfigControl3.SetLaunchSpeed(25);
            bombConfigControl3.SetExploseSpeed(10);
            bombConfigControl3.SetExploseForm(1);

            // Init launcher #04
            //bombConfigControl4.SetFireButtonText("Fire! (F4)");
            bombConfigControl4.SetBombColor(System.Drawing.Color.Green);
            bombConfigControl4.SetLaunchSpeed(20);
            bombConfigControl4.SetExploseSpeed(10);
            bombConfigControl4.SetExploseForm(1);

            // Init launcher #05
            //bombConfigControl5.SetFireButtonText("Fire! (F5)");
            bombConfigControl5.SetBombColor(System.Drawing.Color.Pink);
            bombConfigControl5.SetLaunchSpeed(15);
            bombConfigControl5.SetExploseSpeed(10);
            bombConfigControl5.SetExploseForm(1);

            // Init launcher #06
            //bombConfigControl6.SetFireButtonText("Fire! (F6)");
            bombConfigControl6.SetBombColor(System.Drawing.Color.LightSkyBlue);
            bombConfigControl6.SetLaunchSpeed(20);
            bombConfigControl6.SetExploseSpeed(10);
            bombConfigControl6.SetExploseForm(1);

            // Init launcher #07
            //bombConfigControl7.SetFireButtonText("Fire! (F7)");
            bombConfigControl7.SetBombColor(System.Drawing.Color.Yellow);
            bombConfigControl7.SetLaunchSpeed(25);
            bombConfigControl7.SetExploseSpeed(10);
            bombConfigControl7.SetExploseForm(1);

            // Init launcher #08
            //bombConfigControl8.SetFireButtonText("Fire! (F8)");
            bombConfigControl8.SetBombColor(System.Drawing.Color.Fuchsia);
            bombConfigControl8.SetLaunchSpeed(20);
            bombConfigControl8.SetExploseSpeed(10);
            bombConfigControl8.SetExploseForm(1);

            // Init launcher #09
            //bombConfigControl9.SetFireButtonText("Fire! (F9)");
            bombConfigControl9.SetBombColor(System.Drawing.Color.LimeGreen);
            bombConfigControl9.SetLaunchSpeed(15);
            bombConfigControl9.SetExploseSpeed(10);
            bombConfigControl9.SetExploseForm(1);

            // Init launcher #10
            //bombConfigControl10.SetFireButtonText("Fire! (F10)");
            bombConfigControl10.SetBombColor(System.Drawing.Color.Thistle);
            bombConfigControl10.SetLaunchSpeed(20);
            bombConfigControl10.SetExploseSpeed(10);
            bombConfigControl10.SetExploseForm(1);

            // Replace bombs launcher
            //ReplaceLaunchers();

            // Start simulation
            //Start();
        }

        private void bombConfigControl1_FireButtonPressed(object sender, System.EventArgs e)
        {
            LaunchBomb_1();
        }

        private void bombConfigControl2_FireButtonPressed(object sender, System.EventArgs e)
        {
            LaunchBomb_2();
        }

        private void bombConfigControl3_FireButtonPressed(object sender, System.EventArgs e)
        {
            LaunchBomb_3();
        }

        private void bombConfigControl4_FireButtonPressed(object sender, System.EventArgs e)
        {
            LaunchBomb_4();
        }

        private void bombConfigControl5_FireButtonPressed(object sender, System.EventArgs e)
        {
            LaunchBomb_5();
        }

        private void bombConfigControl6_FireButtonPressed(object sender, System.EventArgs e)
        {
            LaunchBomb_6();
        }

        private void bombConfigControl7_FireButtonPressed(object sender, System.EventArgs e)
        {
            LaunchBomb_7();
        }

        private void bombConfigControl8_FireButtonPressed(object sender, System.EventArgs e)
        {
            LaunchBomb_8();
        }

        private void bombConfigControl9_FireButtonPressed(object sender, System.EventArgs e)
        {
            LaunchBomb_9();
        }

        private void bombConfigControl10_FireButtonPressed(object sender, System.EventArgs e)
        {
            LaunchBomb_10();
        }

        /// <summary>
        /// Launch a bomb on launcher #01
        /// </summary>
        private void LaunchBomb_1()
        {
            FireworksBomb myBomb = new FireworksBomb(5, bombConfigControl1.GetBombColor(), bombConfigControl1.GetLaunchSpeed(), bombConfigControl1.GetExploseSpeed(), bombConfigControl1.GetExploseForm(), (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// Launch a bomb on launcher #02
        /// </summary>
        private void LaunchBomb_2()
        {
            FireworksBomb myBomb = new FireworksBomb(15, bombConfigControl2.GetBombColor(), bombConfigControl2.GetLaunchSpeed(), bombConfigControl2.GetExploseSpeed(), bombConfigControl2.GetExploseForm(), (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// Launch a bomb on launcher #03
        /// </summary>
        private void LaunchBomb_3()
        {
            FireworksBomb myBomb = new FireworksBomb(25, bombConfigControl3.GetBombColor(), bombConfigControl3.GetLaunchSpeed(), bombConfigControl3.GetExploseSpeed(), bombConfigControl3.GetExploseForm(), (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// Launch a bomb on launcher #04
        /// </summary>
        private void LaunchBomb_4()
        {
            FireworksBomb myBomb = new FireworksBomb(35, bombConfigControl4.GetBombColor(), bombConfigControl4.GetLaunchSpeed(), bombConfigControl4.GetExploseSpeed(), bombConfigControl4.GetExploseForm(), (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// Launch a bomb on launcher #05
        /// </summary>
        private void LaunchBomb_5()
        {
            FireworksBomb myBomb = new FireworksBomb(45, bombConfigControl5.GetBombColor(), bombConfigControl5.GetLaunchSpeed(), bombConfigControl5.GetExploseSpeed(), bombConfigControl5.GetExploseForm(), (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// Launch a bomb on launcher #06
        /// </summary>
        private void LaunchBomb_6()
        {
            FireworksBomb myBomb = new FireworksBomb(55, bombConfigControl6.GetBombColor(), bombConfigControl6.GetLaunchSpeed(), bombConfigControl6.GetExploseSpeed(), bombConfigControl6.GetExploseForm(), (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// Launch a bomb on launcher #07
        /// </summary>
        private void LaunchBomb_7()
        {
            FireworksBomb myBomb = new FireworksBomb(65, bombConfigControl7.GetBombColor(), bombConfigControl7.GetLaunchSpeed(), bombConfigControl7.GetExploseSpeed(), bombConfigControl7.GetExploseForm(), (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// Launch a bomb on launcher #08
        /// </summary>
        private void LaunchBomb_8()
        {
            FireworksBomb myBomb = new FireworksBomb(75, bombConfigControl8.GetBombColor(), bombConfigControl8.GetLaunchSpeed(), bombConfigControl8.GetExploseSpeed(), bombConfigControl8.GetExploseForm(), (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// Launch a bomb on launcher #09
        /// </summary>
        private void LaunchBomb_9()
        {
            FireworksBomb myBomb = new FireworksBomb(85, bombConfigControl9.GetBombColor(), bombConfigControl9.GetLaunchSpeed(), bombConfigControl9.GetExploseSpeed(), bombConfigControl9.GetExploseForm(), (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// Launch a bomb on launcher #10
        /// </summary>
        private void LaunchBomb_10()
        {
            FireworksBomb myBomb = new FireworksBomb(95, bombConfigControl10.GetBombColor(), bombConfigControl10.GetLaunchSpeed(), bombConfigControl10.GetExploseSpeed(), bombConfigControl10.GetExploseForm(), (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }
    }
}