using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class Book
    {
        partial void Quantity_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if(this.Quantity < 0)
            {
                results.AddPropertyError("All copies of this item are currently checked out by other users.");
            }
        }
    }
}