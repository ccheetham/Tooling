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

using Shouldly;
using Steeltoe.Tooling.Cli.Executors.Service;
using Xunit;

namespace Steeltoe.Tooling.Cli.Test.Executors.Service
{
    public class ListServicesExecutorTest : ExecutorTest
    {
        [Fact]
        public void TestListNone()
        {
            var svc = new ListServicesExecutor();
            svc.Execute(Config, null, Output);
            Output.ToString().ShouldBeEmpty();
        }

        [Fact]
        public void TestListSeveral()
        {
            Config.services.Add("service-a", new Configuration.Service("service-a-type"));
            Config.services.Add("service-b", new Configuration.Service("service-b-type"));
            var svc = new ListServicesExecutor();
            svc.Execute(Config, Shell, Output);
            Output.ToString().ShouldContain("service-a (service-a-type)");
            Output.ToString().ShouldContain("service-b (service-b-type)");
        }
    }
}
