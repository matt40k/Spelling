/*
 *   Developer : Matt Smith (matt@matt40k.co.uk)
 *   All modified code (c) Matthew Smith all rights reserved
 * 
 *   This modified code is released under Microsoft Reciprocal License (MS-RL).
 *   The license and further copyright text can be found in the file
 *   LICENSE.TXT at the root directory of the distribution.
 *   
 *   Original code is licensed under the Code Project Open License (CPOL) 1.02.
 *   http://www.codeproject.com/info/cpol10.aspx
 *   
 *   Reference: http://www.codeproject.com/Articles/33406/A-C-Tiny-Fireworks-Simulator
 */

/*****************************************************************************/
/* Project  : FireWorksSimulator                                             */
/* File     : SimulatorControl.cs                                            */
/* Version  : 1                                                              */
/* Language : C#                                                             */
/* Summary  : Control which manages particles (computes and displays)        */
/* Creation : 23/07/2008                                                     */
/* Author   : Guillaume CHOUTEAU                                             */
/* History  :                                                                */
/*****************************************************************************/

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Matt40k.Spelling.Fireworks
{
    public class SimulatorControl : System.Windows.Forms.Control
    {
        /*****************************************
        *                Fields                  *
        ******************************************/
        #region Fields

        private int masterTimerPeriod = 50;                                  // Period for the updater timer
        private List<FireworksBomb> ltSimBombList = new List<FireworksBomb>(); // List of the bomb managesd by the control 
        private Multimedia.Timer masterTimer = new Multimedia.Timer();       // Multimedia timer for the updates
        object Verrou = new object();                                        // Lock object

        #endregion

        /*****************************************
        *              Constructor               *
        ******************************************/
        #region Constructor

        public SimulatorControl()
        {
            // Double bufferisation
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            // Init master timer
            masterTimer.Mode = Multimedia.TimerMode.Periodic;
            masterTimer.Period = masterTimerPeriod;
            masterTimer.Resolution = 5;
            masterTimer.SynchronizingObject = null;
            masterTimer.Tick += new System.EventHandler(this.masterTimer_Tick);
        }

        #endregion

        /*****************************************
        *                 Methods                *
        ******************************************/
        #region Methods


        /// <summary>
        /// Add a bomb to the simulator bomb list
        /// </summary>
        /// <param name="fbMyBomb">The bomb to add</param>
        public void AddBomb(FireworksBomb fbMyBomb)
        {
            ltSimBombList.Add(fbMyBomb);
        }

        /// <summary>
        /// Start the update timer
        /// </summary>
        public void StartSimulation()
        {
            masterTimer.Start();
        }

        /// <summary>
        /// Stop the update timer
        /// </summary>
        public void StopSimulation()
        {
            masterTimer.Stop();
        }


        /// <summary>
        /// Update the characteristics of all the bomb particles
        /// </summary>
        private void UpdateParticlePosition()
        {
            lock (Verrou)
            {
                int iCount = ltSimBombList.Count;
                FireworksBomb[] tempBombArray = new FireworksBomb[iCount];

                // Copy the lsit
                ltSimBombList.CopyTo(0, tempBombArray, 0, iCount);

                foreach (FireworksBomb fbBomb in tempBombArray)
                {
                    bool bIsBombAlive = true;

                    // Update the particles of teh bomb
                    bIsBombAlive = fbBomb.Update((float)(masterTimerPeriod) / 1000);

                    // If the bomb is finished, it's removed
                    if (bIsBombAlive == false)
                    {
                        ltSimBombList.Remove(fbBomb);
                    }
                }
            }
        }

        /// <summary>
        /// Convert the position of particle in classical system to the image coordinate system
        /// </summary>
        /// <param name="particle">The particle to convert the position</param>
        /// <returns>The position of the particle in the image coordinate system</returns>
        private Point FromSimParticleToImg(FireworksParticle particle)
        {
            Point returnPoint = new Point(0, 0);
            float scaleFactor = 0;

            scaleFactor = (float)(this.Width) / 100;

            returnPoint.X = (int)(particle.GetParticlePosition().xPosition * scaleFactor);
            returnPoint.Y = (int)(-particle.GetParticlePosition().yPosition * scaleFactor + this.Height);

            return returnPoint;
        }

        #endregion

        /*****************************************
        *               CallBacks                *
        ******************************************/
        #region CallBacks

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);

            lock (Verrou)
            {
                foreach (FireworksBomb fbBomb in ltSimBombList)
                {
                    foreach (FireworksParticle fpParticle in fbBomb.GetBombParticleList())
                    {
                        Point ptParticlePoint = new Point(0, 0);
                        ptParticlePoint = FromSimParticleToImg(fpParticle);

                        SolidBrush sbParticleBrush = new SolidBrush(fpParticle.GetFireworksParticuleColor());
                        pe.Graphics.FillEllipse(sbParticleBrush, ptParticlePoint.X, ptParticlePoint.Y, fpParticle.GetFireworksParticuleSize(), fpParticle.GetFireworksParticuleSize());
                    }
                }
            }
        }

        private void masterTimer_Tick(object sender, System.EventArgs e)
        {
            UpdateParticlePosition();
        }

        #endregion

    }
}
