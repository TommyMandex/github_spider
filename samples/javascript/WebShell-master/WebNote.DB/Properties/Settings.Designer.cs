﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebNote.DB.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\sqlexpress;AttachDbFilename=\"D:\\1 Hisham\\amal\\WebShell\\Pages\\App_Da" +
            "ta\\WebNote.mdf\";Integrated Security=True")]
        public string WebNoteConnectionString {
            get {
                return ((string)(this["WebNoteConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\sqlexpress;Initial Catalog=\"D:\\1 HISHAM\\AMAL\\WEBSHELL\\PAGES\\APP_DAT" +
            "A\\WEBNOTE.MDF\";Integrated Security=True")]
        public string D__1_HISHAM_AMAL_WEBSHELL_PAGES_APP_DATA_WEBNOTE_MDFConnectionString {
            get {
                return ((string)(this["D__1_HISHAM_AMAL_WEBSHELL_PAGES_APP_DATA_WEBNOTE_MDFConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\sqlexpress;AttachDbFilename=\"D:\\1 Hisham\\amal\\WebShell\\Pages\\App_Da" +
            "ta\\WebNote.mdf\";Initial Catalog=WebNoteDB;Integrated Security=True")]
        public string WebNoteDBConnectionString {
            get {
                return ((string)(this["WebNoteDBConnectionString"]));
            }
        }
    }
}
