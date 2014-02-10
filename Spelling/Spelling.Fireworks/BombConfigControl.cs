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
/* File     : BombConfigControl.cs                                           */
/* Version  : 1                                                              */
/* Language : C#                                                             */
/* Summary  : A user control which sets all the parameters of a FireWrksBomb */
/*            and generates a launch event                                   */
/*            select a color and display it on the button                    */
/* Creation : 11/01/2009                                                     */
/* Autor    : Guillaume CHOUTEAU                                             */
/* History  :                                                                */
/*****************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Matt40k.Spelling.Fireworks
{
    public partial class BombConfigControl : UserControl
    {
        /*****************************************
        *                Fields                  *
        ******************************************/
        #region Fields

        public event EventHandler FireButtonPressed;

        #endregion

        /*****************************************
        *              Constructor               *
        ******************************************/
        #region Constructor

        public BombConfigControl()
        {
            InitializeComponent();
        }

        #endregion

        /*****************************************
        *                 Methods                *
        ******************************************/
        #region Methods

        /// <summary>
        /// Launch the FireButtonPressed event
        /// </summary>
        public void LaunchOnFireButtonPressed()
        {
            OnFireButtonPressed(this, EventArgs.Empty);
        }

        /// <summary>
        /// Get the color of the bomb
        /// </summary>
        /// <returns>The color of the bomb</returns>
        public Color GetBombColor()
        {
            return btColorButton.GetSelectedColor();
        }

        /// <summary>
        /// Get the launch speed of the bomb
        /// </summary>
        /// <returns>The launch speed of the bomb</returns>
        public int GetLaunchSpeed()
        {
            return (int)(udLauchSpeed.Value);
        }

        /// <summary>
        /// Get the explosion speed of the bomb
        /// </summary>
        /// <returns>The explosion speed of the bomb</returns>
        public int GetExploseSpeed()
        {
            return (int)(udExlposeSpeed.Value);
        }

        /// <summary>
        /// Get the explosion form of the bomb
        /// </summary>
        /// <returns>The explosion form od the bomb</returns>
        public int GetExploseForm()
        {
            return (int)(udExploseForm.Value);
        }

        /// <summary>
        /// Set the text on the fire button
        /// </summary>
        /// <param name="szMyFireButtonText">The string to display</param>
        public void SetFireButtonText(String szMyFireButtonText)
        {
            btFireButton.Text = szMyFireButtonText;
        }

        /// <summary>
        /// Set the color of the bomb
        /// </summary>
        /// <param name="cMyBombColor">The color of the bomb</param>
        public void SetBombColor(Color cMyBombColor)
        {
            btColorButton.SetSelectedColor(cMyBombColor);
        }

        /// <summary>
        /// Set the launch speed of the bomb
        /// </summary>
        /// <param name="iMyLaunchSpeed">The launch speed of the bomb</param>
        public void SetLaunchSpeed(int iMyLaunchSpeed)
        {
            udLauchSpeed.Value = iMyLaunchSpeed;
        }

        /// <summary>
        /// Set the explosion speed of the bomb
        /// </summary>
        /// <param name="iMyExploseSpeed">The explosion speed of the bomb</param>
        public void SetExploseSpeed(int iMyExploseSpeed)
        {
            udExlposeSpeed.Value = iMyExploseSpeed;
        }

        /// <summary>
        /// Set the explosion form of the bomb
        /// </summary>
        /// <param name="iMyExploseFormIndex">The index of the explosion form of the bomb</param>
        public void SetExploseForm(int iMyExploseFormIndex)
        {
            udExploseForm.Value = iMyExploseFormIndex;
        }

        #endregion

        /*****************************************
        *               CallBacks                *
        ******************************************/
        #region CallBacks

        private void btFireButton_Click(object sender, EventArgs e)
        {
            LaunchOnFireButtonPressed();
        }

        #endregion

        /*****************************************
        *                 Events                 *
        ******************************************/
        #region Events

        protected virtual void OnFireButtonPressed(object sender, EventArgs e)
        {
            if (FireButtonPressed != null)
                FireButtonPressed(sender, e);
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private void InitializeComponent()
        {

        }

        private System.Windows.Forms.NumericUpDown udLauchSpeed;
        private System.Windows.Forms.NumericUpDown udExlposeSpeed;
        private System.Windows.Forms.NumericUpDown udExploseForm;
        private ColorButtonControl btColorButton;
        private System.Windows.Forms.Button btFireButton;
    }
}
