// <copyright file="PexAssemblyInfo.cs">Copyright ©  2021</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "MSTestv2")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("VoiceAssistant")]
[assembly: PexInstrumentAssembly("System.Drawing")]
[assembly: PexInstrumentAssembly("Google.Apis")]
[assembly: PexInstrumentAssembly("WindowsInput")]
[assembly: PexInstrumentAssembly("System.Xml.Linq")]
[assembly: PexInstrumentAssembly("SeleniumExtras.WaitHelpers")]
[assembly: PexInstrumentAssembly("AudioSwitcher.AudioApi")]
[assembly: PexInstrumentAssembly("Google.Apis.Core")]
[assembly: PexInstrumentAssembly("Microsoft.CSharp")]
[assembly: PexInstrumentAssembly("Google.Apis.Auth")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("System.Windows.Forms")]
[assembly: PexInstrumentAssembly("Google.Apis.Calendar.v3")]
[assembly: PexInstrumentAssembly("System.Speech")]
[assembly: PexInstrumentAssembly("AudioSwitcher.AudioApi.CoreAudio")]
[assembly: PexInstrumentAssembly("Gma.System.MouseKeyHook")]
[assembly: PexInstrumentAssembly("WebDriver")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Drawing")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Google.Apis")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "WindowsInput")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Xml.Linq")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "SeleniumExtras.WaitHelpers")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "AudioSwitcher.AudioApi")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Google.Apis.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.CSharp")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Google.Apis.Auth")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Windows.Forms")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Google.Apis.Calendar.v3")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Speech")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "AudioSwitcher.AudioApi.CoreAudio")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Gma.System.MouseKeyHook")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "WebDriver")]

