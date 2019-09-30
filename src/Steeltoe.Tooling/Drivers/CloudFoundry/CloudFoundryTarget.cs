﻿// Copyright 2018 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Steeltoe.Tooling.Drivers.CloudFoundry
{
    internal class CloudFoundryTarget : Target
    {
        internal CloudFoundryTarget(TargetConfiguration configuration) : base(configuration)
        {
        }

        public override IDriver GetDriver(Context context)
        {
            return new CloudFoundryDriver(context);
        }

        public override bool IsHealthy(Context context)
        {
            var cli = new CloudFoundryCli(context.Shell);
            try
            {
                context.Console.Write($"Cloud Foundry ... ");
                context.Console.WriteLine(cli.Run("--version", "getting Cloud Foundry CLI version").Trim());
            }
            catch (ShellException)
            {
                context.Console.WriteLine($"!!! {cli.Command} command not found");
                return false;
            }

            try
            {
                context.Console.Write("logged into Cloud Foundry ... ");
                cli.Run("target", "checking if logged into Cloud Foundry");
                context.Console.WriteLine("yes");
            }
            catch (ToolingException)
            {
                context.Console.WriteLine("!!! no");
                return false;
            }

            return true;
        }
    }
}