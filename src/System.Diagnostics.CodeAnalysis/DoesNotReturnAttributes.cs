﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Applied to a method that will never return under any circumstance.
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class DoesNotReturnAttribute : Attribute
{
}

/// <summary>
/// Specifies that the method will not return if the associated Boolean parameter is passed the specified value.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
public sealed class DoesNotReturnIfAttribute : Attribute
{
    /// <summary>
    /// Initializes the attribute with the specified parameter value.
    /// </summary>
    /// <param name="parameterValue">
    /// The condition parameter value. Code after the method will be considered unreachable
    /// by diagnostics if the argument to the associated parameter matches this value.
    /// </param>
    public DoesNotReturnIfAttribute(bool parameterValue) => ParameterValue = parameterValue;

    /// <summary>
    /// Gets the condition parameter value.
    /// </summary>
    public bool ParameterValue { get; }
}