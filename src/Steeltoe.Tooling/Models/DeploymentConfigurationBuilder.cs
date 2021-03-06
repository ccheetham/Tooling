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

using System.IO;

namespace Steeltoe.Tooling.Models
{
    /// <summary>
    /// Helper for building a deployment configuration.
    /// </summary>
    public class DeploymentConfigurationBuilder
    {
        private readonly Context _context;

        /// <summary>
        /// Create a DeploymentConfigurationBuilder for the specified directory.
        /// </summary>
        public DeploymentConfigurationBuilder(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns a deployment configuration.
        /// </summary>
        /// <returns>deployment configuration model</returns>
        public DeploymentConfiguration BuildDeployment()
        {
            var name = Path.GetFileName(_context.WorkingDirectory);
            var deployment = new DeploymentConfiguration
            {
                Name = name,
                Project = new ProjectBuilder(_context, Path.Join(_context.WorkingDirectory, $"{name}.csproj"))
                    .BuildProject()
            };
            return deployment;
        }
    }
}
