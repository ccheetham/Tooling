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

namespace Steeltoe.Tooling.Templates
{
    /// <summary>
    /// Template abstraction.
    /// </summary>
    public interface ITemplate
    {
        /// <summary>
        /// Binds the object to the named template variable.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="obj"></param>
        void Bind(string name, object obj);

        /// <summary>
        /// Returns the rendered template.
        /// </summary>
        /// <returns></returns>
        string Render();
    }
}
