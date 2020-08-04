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
    class Role
    {
        private String name;
        private Boolean killpower;
        private int targets;

        public Role(String name, Boolean killpower, int targets)
        {
            this.name = name;
            this.killpower = killpower;
            this.targets = targets;
        }

        public void setName(String name) { this.name = name; }
        public void setKillpower(Boolean killpower) { this.killpower = killpower; }
        public void setTargets(int targets) { this.targets = targets; }

        public String getName() { return name; }
        public Boolean getKillpower() { return killpower; }
        public int getTargets() { return targets; }
    }
}