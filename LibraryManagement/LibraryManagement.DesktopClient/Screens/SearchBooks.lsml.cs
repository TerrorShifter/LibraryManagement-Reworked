using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;

namespace LightSwitchApplication
{
    public partial class SearchBooks
    {
        partial void AddtoCart_Execute()
        {
            // Write your code here.
            this.Books.SelectedItem.Quantity -= 1;
                                   
        }

        partial void AddtoCart_CanExecute(ref bool result)
        {
            // Write your code here.
            //result = this.Application.User.HasPermission(Permissions.SecurityAdministration);
            
        }

        partial void RemoveFromCart_Execute()
        {
            // Write your code here.
            this.Books.SelectedItem.Quantity += 1;
        }

        partial void RemoveFromCart_CanExecute(ref bool result)
        {
            // Write your code here.

        }

        partial void Method_Execute()
        {
            // Write your code here.

        }

        partial void Method_CanExecute(ref bool result)
        {
            // Write your code here.

        }
    }
}