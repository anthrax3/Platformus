﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Platformus.Infrastructure
{
  public class BackendMenuItem
  {
    public string Url { get; set; }
    public string Name { get; }
    public int Position { get; set; }
    public IEnumerable<string> PermissionCodes { get; set; }

    public BackendMenuItem(string url, string name, int position, IEnumerable<string> permissionCodes)
    {
      this.Url = url;
      this.Name = name;
      this.Position = position;
      this.PermissionCodes = permissionCodes;
    }
  }
}