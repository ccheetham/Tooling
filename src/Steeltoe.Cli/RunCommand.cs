// Copyright 2020 the original author or authors.
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

using McMaster.Extensions.CommandLineUtils;
using Steeltoe.Tooling.Controllers;

namespace Steeltoe.Cli
{
    [Command(Description = "Runs project in the local Docker environment",
        ExtendedHelpText = @"
Overview:
  Starts the project application and its dependencies in the local Docker environment.

Examples:
  Run the default configuration:
  $ st run

See Also:
  stop")]
    public class RunCommand : Command
    {
        public const string CommandName = "run";

        public RunCommand(IConsole console) : base(console)
        {
        }

        protected override Controller GetController()
        {
            return new RunController();
        }
    }
}
