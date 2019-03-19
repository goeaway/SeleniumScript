﻿using SeleniumFluentAPI.Abstractions;
using System;

namespace SeleniumFluentAPI.Domains
{
    public abstract class Page : IPage
    {
        public IDomain Domain { get; }

        public Uri FullUri => new Uri(Domain.BaseUri, RelativeUri);

        public abstract string RelativeUri { get; }

        public Page(IDomain domain)
        {
            Domain = domain;
        }
    }
}
