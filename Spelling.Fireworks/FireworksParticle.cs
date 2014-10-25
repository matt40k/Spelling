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
/* File     : FireworksParticle.cs                                            */
/* Version  : 1                                                              */
/* Language : C#                                                             */
/* Summary  : The object represents a fireworks particle inherited from the  */
/*            particle object. It has a colour, a size and a life cycle      */
/*            which manage a fader effect on the size and the colour.        */
/* Creation : 10/01/2009                                                     */
/* Author   : Guillaume CHOUTEAU                                             */
/* History  :                                                                */
/*****************************************************************************/

using System.Drawing;

namespace Matt40k.Spelling.Fireworks
{
    public class FireworksParticle : Particle
    {
        /*****************************************
        *                Fields                  *
        ******************************************/
        #region Fields

        Color cInitColor;    // Base colour 
        Color cCurrentColor; // Current colour
        int iInitSize;       // Base size
        int iCurrentSize;    // Current size
        int iNbCycle;        // Nubmber of cycle 
        int iCurrentCycle;   // Current 
        bool bIsAlive = true;// Flag

        #endregion

        /*****************************************
        *              Constructor               *
        ******************************************/
        #region Constructor

        public FireworksParticle(PositionVector initPosition, SpeedVector initSpeed, Color initColor, int initSize, int initNbCycle)
            : base(initPosition, initSpeed)
        {
            // Init
            cInitColor = initColor;
            iInitSize = initSize;
            iNbCycle = initNbCycle;
            iCurrentCycle = 0;
            cCurrentColor = initColor;
        }

        #endregion

        /*****************************************
        *                 Methods                *
        ******************************************/
        #region Methods

        /// <summary>
        /// Update the characteristics of the particle
        /// </summary>
        /// <param name="fdeltaTime">Delta time between two updates (seconds)</param>
        /// <returns>The position vector of the fireworks particle</returns>
        public PositionVector UpdateFireworksParticle(float fdeltaTime)
        {
            if (iCurrentCycle <= iNbCycle)
            {
                int iAlphaCoef = 0;

                // Computes fader coefficent
                iAlphaCoef = (int)(-255 * iCurrentCycle / iNbCycle + 255);

                // Updates colour and size
                cCurrentColor = Color.FromArgb(iAlphaCoef, cInitColor);
                iCurrentSize = (int)(-iInitSize * iCurrentCycle / iNbCycle + iInitSize);

                // Updates counter
                iCurrentCycle++;
            }
            else
            {
                // The fire particle is over
                bIsAlive = false;
            }

            // Basic particle update method
            return UpdateParticlePosition(fdeltaTime);
        }

        /// <summary>
        /// Get the colour of the FireWrks particle
        /// </summary>
        /// <returns>The colour of the FireWrks particle</returns>
        public Color GetFireworksParticuleColor()
        {
            return cCurrentColor;
        }

        /// <summary>
        /// Get the size of the FireWrks particle
        /// </summary>
        /// <returns>The size of the FireWrks particle</returns>
        public int GetFireworksParticuleSize()
        {
            return iCurrentSize;
        }

        /// <summary>
        /// Get the base colour of the FireWrks particle
        /// </summary>
        /// <returns>The init colour of the FireWrks particle</returns>
        public Color GetFireworksParticuleInitColor()
        {
            return cInitColor;
        }

        /// <summary>
        /// Get the IsAlive flag of the FireWrks particle
        /// </summary>
        /// <returns>The IsAlive flag of the FireWrks particle</returns>
        public bool GetFireworksParticuleIsAlive()
        {
            return bIsAlive;
        }

        #endregion
    }
}
