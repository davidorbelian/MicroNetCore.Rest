﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using Humanizer;

namespace MicroNetCore.Rest.MediaTypes.Hypermedia.Models.Actions
{
    public sealed class AddAction : Action
    {
        public AddAction(Type modelType, string href, IEnumerable<Field> fields)
        {
            Name = $"add-{modelType.Name.Camelize()}";
            Href = href;
            Method = HttpMethod.Post.ToString();
            Title = $"Add {modelType.Name}";
            Type = "application/json";
            Fields = fields;
        }
    }
}