﻿using System;

// uiAreaDrawParams
namespace LibUISharp.Drawing
{
    public class DrawEventArgs : EventArgs
    {
        public DrawEventArgs(Context context, RectangleD clip, SizeD areaSize)
        {
            Context = context;
            Clip = clip;
            AreaSize = areaSize;
        }

        public Context Context { get; }
        public RectangleD Clip { get; }
        public SizeD AreaSize { get; }
    }
}