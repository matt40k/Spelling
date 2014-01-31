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
/* File     : Particle.cs                                                    */
/* Version  : 1                                                              */
/* Language : C#                                                             */
/* Summary  : The object represents a particle with its characteristics:     */
/*            acceleration,speed,position, applied forces and mass.          */
/* Creation : 21/07/2008                                                     */
/* Author   : Guillaume CHOUTEAU                                             */
/* History  :                                                                */
/*****************************************************************************/

using System.Collections.Generic;

namespace Spelling.Fireworks
{
    class Particle
    {
        /*****************************************
*                Fields                  *
******************************************/
        #region Fields

        // Acceleration - Speed - Position
        private PositionVector particlePosition = new PositionVector(0, 0);
        private SpeedVector particleSpeed = new SpeedVector(0, 0);
        private AccelerationVector particleAcceleration = new AccelerationVector(0, 0);

        // Force
        private List<ForceVector> particleAppliedForceList = new List<ForceVector>();

        // Weight
        private float particleMass = 1;

        // Flags
        private bool apogee = false;

        #endregion

        /*****************************************
        *              Constructor               *
        ******************************************/
        #region Constructor

        public Particle(PositionVector initPosition, SpeedVector initSpeed)
        {
            // Init position
            particlePosition.xPosition = initPosition.xPosition;
            particlePosition.yPosition = initPosition.yPosition;

            // Init speed
            particleSpeed.xSpeed = initSpeed.xSpeed;
            particleSpeed.ySpeed = initSpeed.ySpeed;
        }

        #endregion

        /*****************************************
        *                 Methods                *
        ******************************************/
        #region Methods

        /// <summary>
        /// Apply a force to the particle
        /// </summary>
        /// <param name="addForce">The force to apply</param>
        public void ApplyForce(ForceVector addForce)
        {
            particleAppliedForceList.Add(addForce);
        }

        /// <summary>
        /// Un-apply a force to the particle
        /// </summary>
        /// <param name="deleteForce">The force to remove</param>
        public void UnApplyForce(ForceVector deleteForce)
        {
            particleAppliedForceList.Remove(deleteForce);
        }

        /// <summary>
        /// Update the position of the particle
        /// </summary>
        /// <param name="fdeltaTime">Delta time between two updates (seconds)</param>
        /// <returns>The position vector of the particle</returns>
        public PositionVector UpdateParticlePosition(float deltaTime)
        {
            ForceVector extForce = new ForceVector(0, 0);
            SpeedVector prevSpeed = new SpeedVector(particleSpeed.xSpeed, particleSpeed.ySpeed);

            // Sum of ext forces
            foreach (ForceVector force in particleAppliedForceList)
            {
                extForce.xForce = extForce.xForce + force.xForce;
                extForce.yForce = extForce.yForce + force.yForce;
            }

            // PFD
            particleAcceleration.xAcceleration = (1 / particleMass) * extForce.xForce;
            particleAcceleration.yAcceleration = (1 / particleMass) * extForce.yForce;

            // Acceleration integration => Speed
            particleSpeed.xSpeed = particleAcceleration.xAcceleration * deltaTime + particleSpeed.xSpeed;
            particleSpeed.ySpeed = particleAcceleration.yAcceleration * deltaTime + particleSpeed.ySpeed;

            // Speed integration => Position
            particlePosition.xPosition = particleSpeed.xSpeed * deltaTime + particlePosition.xPosition;
            particlePosition.yPosition = particleSpeed.ySpeed * deltaTime + particlePosition.yPosition;

            // Apogee detection 
            if (((particleSpeed.ySpeed < 0) && (prevSpeed.ySpeed > 0)) || ((particleSpeed.ySpeed > 0) && (prevSpeed.ySpeed < 0)))
            {
                apogee = true;
            }
            else
            {
                apogee = false;
            }

            // Return updated position
            return particlePosition;
        }

        /// <summary>
        /// Get the position of the particle
        /// </summary>
        /// <returns>The position vector of the particle</returns>
        public PositionVector GetParticlePosition()
        {
            return particlePosition;
        }

        /// <summary>
        /// Get the speed of the particle
        /// </summary>
        /// <returns>The speed vector of the particle</returns>
        public SpeedVector GetParticleSpeed()
        {
            return particleSpeed;
        }

        /// <summary>
        /// Get the apogee flag of the particle
        /// </summary>
        /// <returns>The apogee flag of the particle</returns>
        public bool IsParticleApogee()
        {
            return apogee;
        }

        #endregion
    }
}
