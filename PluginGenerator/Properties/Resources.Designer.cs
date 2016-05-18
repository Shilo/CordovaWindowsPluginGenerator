﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PluginGenerator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PluginGenerator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace WPCordovaClassLib.Cordova.Commands
        ///{
        ///    public class $PluginName$ : BaseCommand
        ///    {
        ///        public void $MethodName$(string options)
        ///        {
        ///            string upperCase = JSON.JsonHelper.Deserialize&lt;string[]&gt;(options)[0].ToUpper();
        ///            PluginResult result;
        ///            if (upperCase != &quot;&quot;)
        ///            {
        ///                result = new PluginResult(PluginResult.Status.OK, upperCase);
        ///            }
        ///            else
        ///            {
        ///                result = new P [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string code {
            get {
                return ResourceManager.GetString("code", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var $PluginName$ = {
        ///    $MethodName$: function (successCallback, errorCallback, strInput) {
        ///        cordova.exec(successCallback, errorCallback, &quot;$PluginName$&quot;, &quot;$MethodName$&quot;, [strInput]);
        ///    }
        ///}
        ///
        ///module.exports = $PluginName$;
        ///.
        /// </summary>
        internal static string javascript {
            get {
                return ResourceManager.GetString("javascript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;plugin xmlns=&quot;http://apache.org/cordova/ns/plugins/1.0&quot;
        ///      id=&quot;com.contoso.$PluginName$&quot;
        ///      version=&quot;0.1.0&quot;&gt;
        ///    &lt;name&gt;$PluginName$&lt;/name&gt;
        ///    &lt;description&gt;$PluginName$ plugin for Apache Cordova&lt;/description&gt;
        ///    &lt;license&gt;MIT&lt;/license&gt;
        ///    &lt;keywords&gt;&lt;/keywords&gt;
        ///    &lt;repo&gt;&lt;/repo&gt;
        ///    &lt;issue&gt;&lt;/issue&gt;
        ///
        ///    &lt;js-module src=&quot;www/$PluginName$.js&quot; name=&quot;$PluginName$&quot;&gt;
        ///        &lt;clobbers target=&quot;$PluginName$&quot; /&gt;
        ///    &lt;/js-module&gt;
        ///
        ///    &lt;!-- wp8 --&gt;
        ///    &lt;plat [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string plugin {
            get {
                return ResourceManager.GetString("plugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var cordova = require(&apos;cordova&apos;),
        ///    WinEightOne= require(&apos;./$PluginName&apos;);
        ///
        ///module.exports = {
        ///
        ///    $MethodName$: function (successCallback, errorCallback, strInput) {
        ///
        ///        var upperCase = strInput[0].toUpperCase();
        ///        if(upperCase != &quot;&quot;) {
        ///            successCallback(upperCase);
        ///        }
        ///        else {
        ///            errorCallback(upperCase);
        ///        }
        ///    }
        ///};
        ///
        ///require(&quot;cordova/exec/proxy&quot;).add(&quot;$PluginName$&quot;, module.exports);
        ///
        ///.
        /// </summary>
        internal static string proxy {
            get {
                return ResourceManager.GetString("proxy", resourceCulture);
            }
        }
    }
}
