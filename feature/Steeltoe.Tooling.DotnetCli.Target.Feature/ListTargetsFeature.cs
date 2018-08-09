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

using LightBDD.Framework;
using LightBDD.Framework.Scenarios.Extended;
using LightBDD.XUnit2;

[assembly: LightBddScope]

namespace Steeltoe.Tooling.DotnetCli.Target.Feature
{
    [Label("target")]
    public partial class ListTargetsFeature
    {
        [Scenario]
        public void RunListTargets()
        {
            Runner.RunScenario(
                given => a_blank_project("run_list_targets"),
                when => the_developer_runs_steeltoe_("list-targets"),
                then => the_command_succeeds(),
                and => the_developer_sees_the_output("cloud-foundry"));
        }
    }
}