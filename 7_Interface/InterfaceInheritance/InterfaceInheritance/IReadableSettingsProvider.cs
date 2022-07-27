using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    internal interface IReadableSettingsProvider
    {
        string GetSetting(String name, string DefaultValues);

    }
    interface ISettingProvider
    {
        void SetSetting(string name, string Value);

    }
    class IFileSettingProvider
    {
        #region ISettingsProvider Members
        public void SetSetting(string name, string value)
        {


        }
        #endregion
        #region IReadableSettingsProvider Members
        public string GetSetting(string name, string defaultValue)
        {
            return name;

        }
        #endregion 
    }
}
