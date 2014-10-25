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
/* File     : StructFile.cs                                                  */
/* Version  : 1                                                              */
/* Language : C#                                                             */
/* Creation : 21/01/2009                                                     */
/* Author   : Guillaume CHOUTEAU                                             */
/* History  :                                                                */
/*****************************************************************************/

namespace Matt40k.Spelling.Fireworks
{
    public struct PositionVector
    {
        public PositionVector(float x, float y)
        {
            this.xPosition = x;
            this.yPosition = y;
        }
        public float xPosition;
        public float yPosition;
    }

    public struct SpeedVector
    {
        public SpeedVector(float x, float y)
        {
            this.xSpeed = x;
            this.ySpeed = y;
        }
        public float xSpeed;
        public float ySpeed;
    }

    public struct AccelerationVector
    {
        public AccelerationVector(float x, float y)
        {
            this.xAcceleration = x;
            this.yAcceleration = y;
        }
        public float xAcceleration;
        public float yAcceleration;
    }

    public struct ForceVector
    {
        public ForceVector(float x, float y)
        {
            this.xForce = x;
            this.yForce = y;
        }
        public float xForce;
        public float yForce;
    }
}
