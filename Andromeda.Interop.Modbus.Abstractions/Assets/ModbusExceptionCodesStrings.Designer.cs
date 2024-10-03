﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Andromeda.Interop.Modbus.Abstractions.Assets {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ModbusExceptionCodesStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ModbusExceptionCodesStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Andromeda.Interop.Modbus.Abstractions.Assets.ModbusExceptionCodesStrings", typeof(ModbusExceptionCodesStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server has accepted request and is processing it, but a long duration of time is required. This response is returned to prevent a timeout error from occurring in the client. Client can next issue a Poll Program Complete message to determine whether processing is completed.
        /// </summary>
        internal static string Acknowledge {
            get {
                return ResourceManager.GetString("Acknowledge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specialized for Modbus gateways: indicates a misconfigured gateway.
        /// </summary>
        internal static string GatewayPathUnavailable {
            get {
                return ResourceManager.GetString("GatewayPathUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specialized for Modbus gateways: sent when server fails to respond.
        /// </summary>
        internal static string GatewayTargetDeviceFailedToRespond {
            get {
                return ResourceManager.GetString("GatewayTargetDeviceFailedToRespond", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data address of some or all the required entities are not allowed or do not exist in server.
        /// </summary>
        internal static string InvalidDataAddress {
            get {
                return ResourceManager.GetString("InvalidDataAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value is not accepted by server.
        /// </summary>
        internal static string InvalidDataValue {
            get {
                return ResourceManager.GetString("InvalidDataValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function code received in the query is not recognized or allowed by server.
        /// </summary>
        internal static string InvalidFunctionCode {
            get {
                return ResourceManager.GetString("InvalidFunctionCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server detected a parity error in memory; client can retry the request.
        /// </summary>
        internal static string MemoryParityError {
            get {
                return ResourceManager.GetString("MemoryParityError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server cannot perform the programming functions; client should request diagnostic or error information from server.
        /// </summary>
        internal static string NegativeAcknowledge {
            get {
                return ResourceManager.GetString("NegativeAcknowledge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server is engaged in processing a long-duration command; client should retry later.
        /// </summary>
        internal static string ServerDeviceBusy {
            get {
                return ResourceManager.GetString("ServerDeviceBusy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecoverable error occurred while server was attempting to perform requested action.
        /// </summary>
        internal static string ServerDeviceFailure {
            get {
                return ResourceManager.GetString("ServerDeviceFailure", resourceCulture);
            }
        }
    }
}