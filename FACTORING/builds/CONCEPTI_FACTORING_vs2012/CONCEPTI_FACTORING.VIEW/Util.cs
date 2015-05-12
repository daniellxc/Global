﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONCEPTI_FACTORING.VIEW
{
   public class Util
    {

       public static void LimparForm(System.Windows.Forms.Control parent)
       {
           foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
           {
               //Loop through all controls
               if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
               {
                   //Check to see if it's a textbox
                   ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                   //If it is then set the text to String.Empty (empty textbox)
               }
               else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
               {
                   //If its a RichTextBox clear the text
                   ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
               }
               else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
               {
                   //Next check if it's a dropdown list
                   ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex =  ((System.Windows.Forms.ComboBox)ctrControl).Items.Count > 0 ? 0:-1;
                   //If it is then set its SelectedIndex to 0
               }
               else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
               {
                   //Next uncheck all checkboxes
                   ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
               }
               else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
               {
                   //Unselect all RadioButtons
                   ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
               }
               else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.DateTimePicker)))
               {
                   ((System.Windows.Forms.DateTimePicker)ctrControl).Value = DateTime.Now;
               }
               if (ctrControl.Controls.Count > 0)
               {
                   //Call itself to get all other controls in other containers
                   LimparForm(ctrControl);
               }
           }
       }
    }
}
