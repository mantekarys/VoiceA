using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace VoiceAssistant.Tests
{
    public partial class LocationUtilsTest
    {

[TestMethod]
[PexGeneratedBy(typeof(LocationUtilsTest))]
public void GetLatiLongiTest705()
{
    double[] ds;
    ds = this.GetLatiLongiTest("", 
                               "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Distance\\worldcities.csv");
    Assert.IsNotNull((object)ds);
    Assert.AreEqual<int>(0, ds.Length);
}

[TestMethod]
[PexGeneratedBy(typeof(LocationUtilsTest))]
public void GetLatiLongiTest722()
{
    double[] ds;
    ds = this.GetLatiLongiTest((string)null, (string)null);
    Assert.IsNotNull((object)ds);
    Assert.AreEqual<int>(0, ds.Length);
}

[TestMethod]
[PexGeneratedBy(typeof(LocationUtilsTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void GetLatiLongiTest451()
{
    double[] ds;
    ds = this.GetLatiLongiTest("\b\b\b\b\b\b", 
                               "C:\\Users\\mante\\Desktop\\VoiceA\\VoiceAssistant\\Distance\\worldcities.csv");
}

[TestMethod]
[PexGeneratedBy(typeof(LocationUtilsTest))]
public void GetLatiLongiTest246()
{
    double[] ds;
    ds = this.GetLatiLongiTest("", (string)null);
    Assert.IsNotNull((object)ds);
    Assert.AreEqual<int>(0, ds.Length);
}
    }
}
