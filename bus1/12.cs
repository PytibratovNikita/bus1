﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus1
{
    public partial class _12 : Component
    {
        public _12()
        {
            InitializeComponent();
        }

        public _12(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
