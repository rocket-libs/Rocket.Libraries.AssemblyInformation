using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Rocket.Libraries.AssemblyInformation
{
    public static class AssemblyInformationReader
    {
        public static InformationAboutAssembly Read()
        {
            return new InformationAboutAssembly
            {
                Version = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion,
                Id = Assembly.GetEntryAssembly().GetName().Name,
                Created = CreatedDate
            };
        }

        private static DateTime CreatedDate
        {
            get
            {
                var fileInfo = new FileInfo(Assembly.GetEntryAssembly().Location);
                return fileInfo.LastWriteTime;
            }
        }
    }
}