////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.96272-live
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: a4b */
    public partial class GuiFurnitureItemProxy : GuiDurableItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a4b _internal;
        
        #region Properties
        
        public a4b GuiFurnitureItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public GuiFurnitureItemProxy(a4b instance) : base(instance)
        {
            _internal = instance;
        }
        
        static GuiFurnitureItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a4b(GuiFurnitureItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GuiFurnitureItemProxy(a4b instance)
        {
            return new GuiFurnitureItemProxy(instance);
        }
        
        public static implicit operator bool(GuiFurnitureItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}