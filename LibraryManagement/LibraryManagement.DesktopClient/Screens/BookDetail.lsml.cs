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
    public partial class BookDetail
    {
        partial void Book_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Book);
        }

        partial void Book_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Book);
        }

        partial void BookDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Book);
        }

        partial void Method1_Execute()
        {
            // Write your code here.

        }
    }
}