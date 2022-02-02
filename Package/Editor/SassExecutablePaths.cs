//
// Copyright (c) arfinity GmbH and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for details.
//
using System;
using System.IO;
using UnityEngine;

namespace Arfinity.Libraries.Unity.SassExecutables.Editor
{
    public static class SassExecutable
    {
        public static string GetEmbeddedSassPath()
        {
            switch (Application.platform)
            {
               case RuntimePlatform.LinuxEditor:
                   return Path.GetFullPath("Packages/io.arfinity.unity.packages.sassexecutables/Editor/sass-linux/sass");
               case RuntimePlatform.WindowsEditor:
                   return Path.GetFullPath("Packages/io.arfinity.unity.packages.sassexecutables/Editor/sass-windows/sass.bat");
               case RuntimePlatform.OSXEditor:
                   return Path.GetFullPath("Packages/io.arfinity.unity.packages.sassexecutables/Editor/sass-macosx/sass");
            }

            throw new NotSupportedException("Platform not supported by Sass-Executables package");
        }
    }
}
