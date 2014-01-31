/*
 *   Developer : Matt Smith (matt@matt40k.co.uk)
 *   All code (c) Matthew Smith all rights reserved
 * 
 *   This software is released under Microsoft Reciprocal License (MS-RL).
 *   The license and further copyright text can be found in the file
 *   LICENSE.TXT at the root directory of the distribution.
 */

using System.Drawing;
using System.Windows.Controls;
using Matt40k.Spelling.Fireworks;

namespace Matt40k.Spelling
{
    /// <summary>
    /// Interaction logic for Firework.xaml
    /// </summary>
    public partial class Firework : UserControl
    {
        private int masterTimerPeriod = 50;
        private SimulatorControl simulatorControl = new SimulatorControl();

        public Firework()
        {
            InitializeComponent();
        }

        /// <summary>
        /// LauNch a bomb on launcher #01
        /// </summary>
        void LaunchBomb_1()
        {
            FireworksBomb myBomb = new FireworksBomb(5, Color.FromArgb(0,0,255), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #02
        /// </summary>
        void LaunchBomb_2()
        {
            FireworksBomb myBomb = new FireworksBomb(15, Color.FromArgb(245, 245, 245), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #03
        /// </summary>
        void LaunchBomb_3()
        {
            FireworksBomb myBomb = new FireworksBomb(25, Color.FromArgb(255,0,0), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #04
        /// </summary>
        void LaunchBomb_4()
        {
            FireworksBomb myBomb = new FireworksBomb(35, Color.FromArgb(0, 128, 0), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #05
        /// </summary>
        void LaunchBomb_5()
        {
            FireworksBomb myBomb = new FireworksBomb(45, Color.FromArgb(0, 255, 255), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #06
        /// </summary>
        void LaunchBomb_6()
        {
            FireworksBomb myBomb = new FireworksBomb(55, Color.FromArgb(255, 255, 0), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #07
        /// </summary>
        void LaunchBomb_7()
        {
            FireworksBomb myBomb = new FireworksBomb(65, Color.FromArgb(255, 0, 255), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #08
        /// </summary>
        void LaunchBomb_8()
        {
            FireworksBomb myBomb = new FireworksBomb(75, Color.FromArgb(50, 205, 50), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #09
        /// </summary>
        void LaunchBomb_9()
        {
            FireworksBomb myBomb = new FireworksBomb(85, Color.FromArgb(255, 128, 0), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #10
        /// </summary>
        void LaunchBomb_10()
        {
            FireworksBomb myBomb = new FireworksBomb(95, Color.FromArgb(0, 0, 255), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #11
        /// </summary>
        void LaunchBomb_11()
        {
            FireworksBomb myBomb = new FireworksBomb(105, Color.FromArgb(245, 245, 245), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }

        /// <summary>
        /// LauNch a bomb on launcher #12
        /// </summary>
        void LaunchBomb_12()
        {
            FireworksBomb myBomb = new FireworksBomb(115, Color.FromArgb(50, 205, 50), 15, 10, 10, (float)(masterTimerPeriod) / 1000);
            simulatorControl.AddBomb(myBomb);
        }
    }
}
