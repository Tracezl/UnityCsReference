// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;

using UnityEngine;

namespace UnityEditor.Modules
{
    internal abstract class DefaultBuildPostprocessor
        : IBuildPostprocessor
    {
        public virtual void LaunchPlayer(BuildLaunchPlayerArgs args)
        {
            throw new NotSupportedException();
        }

        public virtual void PostProcess(BuildPostProcessArgs args)
        {
        }

        public virtual bool SupportsInstallInBuildFolder()
        {
            return false;
        }

        public virtual bool SupportsLz4Compression()
        {
            return false;
        }

        public virtual void PostProcessScriptsOnly(BuildPostProcessArgs args)
        {
            if (!SupportsScriptsOnlyBuild())
                throw new NotSupportedException();
        }

        public virtual bool SupportsScriptsOnlyBuild()
        {
            return true;
        }

        public virtual string PrepareForBuild(BuildOptions options, BuildTarget target)
        {
            return null;
        }

        public virtual void UpdateBootConfig(BuildTarget target, BootConfigData config, BuildOptions options)
        {
        }

        public virtual string GetExtension(BuildTarget target, BuildOptions options)
        {
            return string.Empty;
        }
    }
}
