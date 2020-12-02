using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using BusinessFramework.Client.Contracts;
using BusinessFramework.Contracts;

namespace Northwind.Client.Contracts.BusinessObjects
{
    [Serializable]
    public sealed class SysSettingProperty : CodeBehind.CodeBehindSysSettingProperty
    {
        private Type _defType;
        private Type _uIEditType;

        public SysSettingProperty()
        {
        }

        private SysSettingProperty(SysSettingProperty origin)
            : base(origin)
        {
            _defType = origin._defType;
            _uIEditType = origin._uIEditType;
        }

        public override string DefaultType
        {
            [DebuggerStepThrough]
            set
            {
                _defType = ParseType(value);
                base.DefaultType = value;
            }
        }

        public override string UIEditorType
        {
            set
            {
                base.UIEditorType = value;
                _uIEditType = ParseType(value);
            }
        }

        public override SysSettingProperty Clone()
        {
            return new SysSettingProperty(this);
        }

        public Type GetUIEditorType()
        {
            return _uIEditType;
        }

        public Type GetDefaultType()
        {
            return _defType;
        }

        private static Type ParseType(string typeString)
        {
            if (typeString == null)
            {
                return null;
            }

            var result = Type.GetType(typeString, false, true);
            if (result == null)
            {
                switch (typeString)
                {
                    case "":
                        break;
                    default:
                        var typeName = Regex.Match(typeString, @"(?<=(.*\.)|\A)([^\.\,])*(?=,.*)").Value;
                        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                        {
                            try
                            {
                                if (!assembly.FullName.StartsWith("Microsoft")
                                    && !assembly.FullName.StartsWith("System"))
                                {
                                    foreach (var type in assembly.GetTypes())
                                    {
                                        if (type.Name == typeName)
                                        {
                                            //System.Diagnostics.Debugger.Break();
                                            return type;
                                        }
                                    }
                                }
                            }
                            catch (Exception exc)
                            {
                                GlobalServices.Logger.Error(exc, "Error");
                            }
                        }
                        break;
                }
            }
            if (result == null)
            {
                GlobalServices.Logger.Error("SettingPropertyDao: Unable to locate type " + typeString);
            }
            return result;
        }
    }
}