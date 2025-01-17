﻿//-----------------------------------------------------------------------
// <copyright file="WindowsConfigurationExtensions.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Implement extension methods for .NET Core configuration</summary>
//-----------------------------------------------------------------------
using System;

namespace Csla.Configuration
{
  /// <summary>
  /// Implement extension methods for Windows Forms
  /// </summary>
  public static class WindowsConfigurationExtensions
  {
    /// <summary>
    /// Registers services necessary for Windows Forms
    /// environments.
    /// </summary>
    /// <param name="config">CslaConfiguration object</param>
    /// <returns></returns>
    public static CslaOptions AddWindowsForms(this CslaOptions config)
    {
      return AddWindowsForms(config, null);
    }

    /// <summary>
    /// Registers services necessary for Windows Forms
    /// environments.
    /// </summary>
    /// <param name="config">CslaConfiguration object</param>
    /// <param name="options">XamlOptions action</param>
    /// <returns></returns>
    public static CslaOptions AddWindowsForms(this CslaOptions config, Action<WindowsFormsOptions> options)
    {
      var xamlOptions = new WindowsFormsOptions();
      options?.Invoke(xamlOptions);

      // use correct mode for raising PropertyChanged events
      ApplicationContext.PropertyChangedMode = ApplicationContext.PropertyChangedModes.Windows;
      return config;
    }
  }

  /// <summary>
  /// Configuration options for AddWindowsForms method
  /// </summary>
  public class WindowsFormsOptions
  {

  }
}
