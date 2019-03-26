// Copyright 2018 the original author or authors.
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

namespace Steeltoe.Tooling
{
    /// <summary>
    /// Represents errors when an item unexpectedly exists in the  Steeltoe Tooling project configuration.
    /// </summary>
    public class ItemExistsException : ToolingException
    {
        /// <summary>
        /// Item name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Item description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Creates a new ItemDoesNotExistException.
        /// </summary>
        /// <param name="name">Item name.</param>
        /// <param name="description">Item description.</param>
        public ItemExistsException(string name, string description) : base(
            $"{char.ToUpper(description[0]) + description.Substring(1)} '{name}' already exists")
        {
            Name = name;
            Description = description;
        }
    }
}
