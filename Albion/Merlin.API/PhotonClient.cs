////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
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

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: aq9 */
    public class PhotonClient
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private aq9 _internal;
        
        #region Properties
        
        public aq9 Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public GameData GetGameData() => _internal.an();
        public static PhotonClient GetInstance() => aq9.aj();
        
        #endregion
        
        #region Constructor
        
        public PhotonClient(aq9 instance)
        {
            _internal = instance;
        }
        
        static PhotonClient()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aq9(PhotonClient instance)
        {
            return instance._internal;
        }
        
        public static implicit operator PhotonClient(aq9 instance)
        {
            return new PhotonClient(instance);
        }
        
        #endregion
    }
}
