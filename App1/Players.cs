using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    class Players
    {
        private String name;
        private Role role;
        private Players[] chosen;

        public Players(String name, Role role, Players[] chosen)
        {
            this.name = name;
            this.role = role;
            this.chosen = chosen;
        }

        public void setName(String name) { this.name = name; }
        public void setRole(Role role) { this.role = role; }
        public void setChosen(Players[] chosen) { this.chosen = chosen; }

        public String getName() { return name; }
        public Role getRole() { return role; }
        public Players[] getChosen() { return chosen; }
    }
}