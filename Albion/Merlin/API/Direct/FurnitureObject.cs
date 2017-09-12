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
    /* Internal type: azx */
    public partial class FurnitureObject : BuildingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private azx _internal;
        
        #region Properties
        
        public azx FurnitureObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FurnitureObject(azx instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FurnitureObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator azx(FurnitureObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FurnitureObject(azx instance)
        {
            return new FurnitureObject(instance);
        }
        
        public static implicit operator bool(FurnitureObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}