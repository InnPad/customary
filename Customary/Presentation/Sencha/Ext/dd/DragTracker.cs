﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custom.Presentation.Sencha.Ext.dd
{
    public abstract class DragTracker : Ext.Class
    {
        public static implicit operator Ext.util.Observable(Ext.dd.DragTracker model)
        {
            return model.Mixins.Get<Ext.util.Observable>();
        }
    }
}