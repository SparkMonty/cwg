﻿namespace cwg.web.Generators
{
    public class DLLGenerator : BaseGenerator
    {
        public override string Name => "DLL";

        public override bool Active => true;

        protected override string SourceName => "sourceDLL";

        protected override string CleanSourceName => "sourceCleanDLL.dll";

        protected override string OutputExtension => "dll";

        public override bool Packable => true;
    }
}