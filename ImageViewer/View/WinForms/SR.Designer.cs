﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.6407
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.View.WinForms {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ClearCanvas.ImageViewer.View.WinForms.SR", typeof(SR).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AE Title of the local DICOM server is &apos;{0}&apos;.
        /// </summary>
        public static string ActivityMonitorAeTitleToolTip {
            get {
                return ResourceManager.GetString("ActivityMonitorAeTitleToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open folder {0}.
        /// </summary>
        public static string ActivityMonitorFileStoreToolTip {
            get {
                return ResourceManager.GetString("ActivityMonitorFileStoreToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The host/port on which the local DICOM server is listening is {0}.
        /// </summary>
        public static string ActivityMonitorHostPortToolTip {
            get {
                return ResourceManager.GetString("ActivityMonitorHostPortToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stack.
        /// </summary>
        public static string CommandNameStackImageScroller {
            get {
                return ResourceManager.GetString("CommandNameStackImageScroller", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PresentationImage not associated with an IRenderer..
        /// </summary>
        public static string ExceptionPresentationImageNotAssociatedWithARenderer {
            get {
                return ResourceManager.GetString("ExceptionPresentationImageNotAssociatedWithARenderer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TileControl is not associated with a tile..
        /// </summary>
        public static string ExceptionTileControlNoAssociatedTile {
            get {
                return ResourceManager.GetString("ExceptionTileControlNoAssociatedTile", resourceCulture);
            }
        }
    }
}
