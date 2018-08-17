﻿// Copyright 2018 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using LightBDD.Framework.Scenarios.Extended;
using LightBDD.XUnit2;

namespace Steeltoe.Tooling.DotnetCli.Test.Target
{
    public partial class SetTargetCommandTest
    {
        [Scenario]
        public void RunCommand()
        {
            Runner.RunScenario(
                given => a_tooling_configuration(),
                when => set_target_is_run("cloud-foundry"),
                and => the_output_should_be("Target environment type set to 'cloud-foundry'."),
                and => the_target_should_be("cloud-foundry")
            );
        }
    }
}
