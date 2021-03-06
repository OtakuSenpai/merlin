////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;

namespace Albion_Direct
{
    /* Internal type: atj */
    public partial class SimpleItemObject : ItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private atj _internal;
        
        #region Properties
        
        public atj SimpleItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public SimpleItemObject(atj instance) : base(instance)
        {
            _internal = instance;
        }
        
        static SimpleItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator atj(SimpleItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SimpleItemObject(atj instance)
        {
            return new SimpleItemObject(instance);
        }
        
        public static implicit operator bool(SimpleItemObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
