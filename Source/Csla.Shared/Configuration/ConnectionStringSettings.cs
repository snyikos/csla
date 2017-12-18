﻿//-----------------------------------------------------------------------
// <copyright file="ConnectionStringSettings.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>Information about a connection string</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Csla.Configuration
{
  /// <summary>
  /// Information about a connection string
  /// </summary>
  [Serializable]
  public class ConnectionStringSettings
  {
    /// <summary>
    /// Gets or sets the connection string text.
    /// </summary>
    public string ConnectionString { get; set; }
  }
}
