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
/* File     : ColorButtonControl.cs                                          */
/* Version  : 1                                                              */
/* Language : C#                                                             */
/* Summary  : A button user control which shows a color dialog in order to   */
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
    public class ColorButtonControl : UserControl
    {
        /*****************************************
        *                Fields                  *
        ******************************************/
        #region Fields

        Color cSelctedColor = Color.Red;

        #endregion

        /*****************************************
        *              Constructor               *
        ******************************************/
        #region Constructor

        public ColorButtonControl()
        {
            InitializeComponent();
            this.btSelectColorButton = new Button();
            btSelectColorButton.BackColor = cSelctedColor;
        }

        #endregion

        /*****************************************
        *                 Methods                *
        ******************************************/
        #region Methods

        /// <summary>
        /// Set the selected color of the control
        /// </summary>
        /// <param name="cMySelectedColor">The selected color</param>
        public void SetSelectedColor(Color cMySelectedColor)
        {
            cSelctedColor = cMySelectedColor;
            btSelectColorButton.BackColor = cSelctedColor;
        }

        /// <summary>
        /// Get the selected color of the control
        /// </summary>
        /// <returns>The selected color</returns>
        public Color GetSelectedColor()
        {
            return cSelctedColor;
        }

        #endregion

        /*****************************************
        *               CallBacks                *
        ******************************************/
        #region CallBacks

        private void btSelectColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = cSelctedColor;
            colorDialog.ShowDialog();
            cSelctedColor = colorDialog.Color;
            btSelectColorButton.BackColor = cSelctedColor;
        }

        #endregion

        private void InitializeComponent()
        {

        }

        private System.Windows.Forms.Button btSelectColorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}
