// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace iovation.LaunchKey.Sdk.Tests.Integration.Features.Directory_Client.Services.Policy
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DirectoryClientCanSetDirectoryServicePolicyFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "directory-client-service-policy-set.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Directory Client can set Directory Service Policy", "  In order to manage the Authorization Policy of a Directory Service\n  As a Direc" +
                    "tory Client\n  I can set the Authorization Policy of a Directory Service", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Directory Client can set Directory Service Policy")))
            {
                global::iovation.LaunchKey.Sdk.Tests.Integration.Features.Directory_Client.Services.Policy.DirectoryClientCanSetDirectoryServicePolicyFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
  #line 7
    testRunner.Given("I created a Directory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
    testRunner.And("I created a Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Setting the policy for invalid Service throws Forbidden")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Directory Client can set Directory Service Policy")]
        public virtual void SettingThePolicyForInvalidServiceThrowsForbidden()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Setting the policy for invalid Service throws Forbidden", null, ((string[])(null)));
#line 10
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line 11
    testRunner.When("the Directory Service Policy is set to require 2 factors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
    testRunner.And("I attempt to set the Policy for the Directory Service with the ID \"eba60cb8-c649-" +
                    "11e7-abc4-cec278b6b50a\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.Then("a ServiceNotFound error occurs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Setting the required factors will set only the factors and all else will be empty" +
            " or null")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Directory Client can set Directory Service Policy")]
        public virtual void SettingTheRequiredFactorsWillSetOnlyTheFactorsAndAllElseWillBeEmptyOrNull()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Setting the required factors will set only the factors and all else will be empty" +
                    " or null", null, ((string[])(null)));
#line 15
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line 16
    testRunner.When("the Directory Service Policy is set to require 2 factors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
    testRunner.And("I set the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
    testRunner.And("I retrieve the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
    testRunner.Then("the Directory Service Policy requires 2 factors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
    testRunner.And("the Directory Service Policy has no requirement for inherence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
    testRunner.And("the Directory Service Policy has no requirement for knowledge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
    testRunner.And("the Directory Service Policy has no requirement for possession", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
    testRunner.And("the Directory Service Policy has 0 locations", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.And("the Directory Service Policy has 0 time fences", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
    testRunner.And("the Directory Service Policy has no requirement for jail break protection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Setting the individual factors will set only the factors and all else will be emp" +
            "ty or null")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Directory Client can set Directory Service Policy")]
        public virtual void SettingTheIndividualFactorsWillSetOnlyTheFactorsAndAllElseWillBeEmptyOrNull()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Setting the individual factors will set only the factors and all else will be emp" +
                    "ty or null", null, ((string[])(null)));
#line 27
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line 28
    testRunner.When("the Directory Service Policy is set to require inherence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
    testRunner.And("the Directory Service Policy is set to require knowledge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
    testRunner.And("the Directory Service Policy is set to require possession", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
    testRunner.And("I set the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
    testRunner.And("I retrieve the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
    testRunner.Then("the Directory Service Policy has no requirement for number of factors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
    testRunner.And("the Directory Service Policy does require inherence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
    testRunner.And("the Directory Service Policy does require knowledge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
    testRunner.And("the Directory Service Policy does require possession", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
    testRunner.And("the Directory Service Policy has 0 locations", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
    testRunner.And("the Directory Service Policy has 0 time fences", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
    testRunner.And("the Directory Service Policy has no requirement for jail break protection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Setting jail break protection will only set jail break protection and everything " +
            "else will be empty of null")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Directory Client can set Directory Service Policy")]
        public virtual void SettingJailBreakProtectionWillOnlySetJailBreakProtectionAndEverythingElseWillBeEmptyOfNull()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Setting jail break protection will only set jail break protection and everything " +
                    "else will be empty of null", null, ((string[])(null)));
#line 41
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line 42
    testRunner.And("the Directory Service Policy is set to require jail break protection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
    testRunner.And("I set the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
    testRunner.And("I retrieve the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
    testRunner.Then("the Directory Service Policy does require jail break protection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
    testRunner.And("the Directory Service Policy has no requirement for number of factors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
    testRunner.And("the Directory Service Policy has no requirement for inherence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
    testRunner.And("the Directory Service Policy has no requirement for knowledge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
    testRunner.And("the Directory Service Policy has no requirement for possession", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
    testRunner.And("the Directory Service Policy has 0 locations", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
    testRunner.And("the Directory Service Policy has 0 time fences", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When setting Time Fences, they are set and nothing else as expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Directory Client can set Directory Service Policy")]
        public virtual void WhenSettingTimeFencesTheyAreSetAndNothingElseAsExpected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When setting Time Fences, they are set and nothing else as expected", null, ((string[])(null)));
#line 55
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Days",
                        "Start Hour",
                        "Start Minute",
                        "End Hour",
                        "End Minute",
                        "Time Zone"});
            table9.AddRow(new string[] {
                        "Week Days",
                        "Monday,Tuesday,Wednesday,Thursday,Friday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/Los_Angeles"});
            table9.AddRow(new string[] {
                        "Week Ends",
                        "Saturday,Sunday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/New_York"});
#line 56
    testRunner.When("the Directory Service Policy is set to have the following Time Fences:", ((string)(null)), table9, "When ");
#line 60
    testRunner.And("I set the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
    testRunner.And("I retrieve the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Days",
                        "Start Hour",
                        "Start Minute",
                        "End Hour",
                        "End Minute",
                        "Time Zone"});
            table10.AddRow(new string[] {
                        "Week Days",
                        "Monday,Tuesday,Wednesday,Thursday,Friday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/Los_Angeles"});
            table10.AddRow(new string[] {
                        "Week Ends",
                        "Saturday,Sunday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/New_York"});
#line 62
    testRunner.Then("the Directory Service Policy has the following Time Fences:", ((string)(null)), table10, "Then ");
#line 66
    testRunner.And("the Directory Service Policy has no requirement for number of factors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
    testRunner.And("the Directory Service Policy has no requirement for inherence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
    testRunner.And("the Directory Service Policy has no requirement for knowledge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
    testRunner.And("the Directory Service Policy has no requirement for possession", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
    testRunner.And("the Directory Service Policy has 0 locations", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Geofence locations work as expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Directory Client can set Directory Service Policy")]
        public virtual void GeofenceLocationsWorkAsExpected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Geofence locations work as expected", null, ((string[])(null)));
#line 73
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Latitude",
                        "Longitude",
                        "Radius"});
            table11.AddRow(new string[] {
                        "Location Alpha",
                        "12.3",
                        "23.4",
                        "500"});
            table11.AddRow(new string[] {
                        "Location Beta",
                        "32.1",
                        "43.2",
                        "1000"});
#line 74
    testRunner.When("the Directory Service Policy is set to have the following Geofence locations:", ((string)(null)), table11, "When ");
#line 78
    testRunner.And("I set the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
    testRunner.And("I retrieve the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Latitude",
                        "Longitude",
                        "Radius"});
            table12.AddRow(new string[] {
                        "Location Alpha",
                        "12.3",
                        "23.4",
                        "500"});
            table12.AddRow(new string[] {
                        "Location Beta",
                        "32.1",
                        "43.2",
                        "1000"});
#line 80
    testRunner.Then("the Directory Service Policy has the following Geofence locations:", ((string)(null)), table12, "Then ");
#line 84
    testRunner.And("the Directory Service Policy has no requirement for number of factors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
    testRunner.And("the Directory Service Policy has no requirement for inherence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
    testRunner.And("the Directory Service Policy has no requirement for knowledge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
    testRunner.And("the Directory Service Policy has no requirement for possession", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
    testRunner.And("the Directory Service Policy has 0 time fences", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Setting required factors, locations, and fences properly set the values.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Directory Client can set Directory Service Policy")]
        public virtual void SettingRequiredFactorsLocationsAndFencesProperlySetTheValues_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Setting required factors, locations, and fences properly set the values.", null, ((string[])(null)));
#line 90
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line 91
    testRunner.When("the Directory Service Policy is set to require 2 factors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
    testRunner.And("the Directory Service Policy is set to require jail break protection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Days",
                        "Start Hour",
                        "Start Minute",
                        "End Hour",
                        "End Minute",
                        "Time Zone"});
            table13.AddRow(new string[] {
                        "Week Days",
                        "Monday,Tuesday,Wednesday,Thursday,Friday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/Los_Angeles"});
            table13.AddRow(new string[] {
                        "Week Ends",
                        "Saturday,Sunday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/New_York"});
#line 93
    testRunner.And("the Directory Service Policy is set to have the following Time Fences:", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Latitude",
                        "Longitude",
                        "Radius"});
            table14.AddRow(new string[] {
                        "Location Alpha",
                        "12.3",
                        "23.4",
                        "500"});
            table14.AddRow(new string[] {
                        "Location Beta",
                        "32.1",
                        "43.2",
                        "1000"});
#line 97
    testRunner.And("the Directory Service Policy is set to have the following Geofence locations:", ((string)(null)), table14, "And ");
#line 101
    testRunner.And("I set the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
    testRunner.And("I retrieve the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
    testRunner.Then("the Directory Service Policy requires 2 factors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
    testRunner.And("the Directory Service Policy does require jail break protection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
    testRunner.And("the Directory Service Policy has no requirement for inherence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
    testRunner.And("the Directory Service Policy has no requirement for knowledge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
    testRunner.And("the Directory Service Policy has no requirement for possession", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Days",
                        "Start Hour",
                        "Start Minute",
                        "End Hour",
                        "End Minute",
                        "Time Zone"});
            table15.AddRow(new string[] {
                        "Week Days",
                        "Monday,Tuesday,Wednesday,Thursday,Friday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/Los_Angeles"});
            table15.AddRow(new string[] {
                        "Week Ends",
                        "Saturday,Sunday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/New_York"});
#line 108
    testRunner.And("the Directory Service Policy has the following Time Fences:", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Latitude",
                        "Longitude",
                        "Radius"});
            table16.AddRow(new string[] {
                        "Location Alpha",
                        "12.3",
                        "23.4",
                        "500"});
            table16.AddRow(new string[] {
                        "Location Beta",
                        "32.1",
                        "43.2",
                        "1000"});
#line 112
    testRunner.And("the Directory Service Policy has the following Geofence locations:", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Setting individual factors, locations, and fences properly set the values.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Directory Client can set Directory Service Policy")]
        public virtual void SettingIndividualFactorsLocationsAndFencesProperlySetTheValues_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Setting individual factors, locations, and fences properly set the values.", null, ((string[])(null)));
#line 117
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
  this.FeatureBackground();
#line 118
    testRunner.When("the Directory Service Policy is set to require inherence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
    testRunner.And("the Directory Service Policy is set to require knowledge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
    testRunner.And("the Directory Service Policy is set to require possession", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
    testRunner.And("the Directory Service Policy is set to require jail break protection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Latitude",
                        "Longitude",
                        "Radius"});
            table17.AddRow(new string[] {
                        "Location Alpha",
                        "12.3",
                        "23.4",
                        "500"});
            table17.AddRow(new string[] {
                        "Location Beta",
                        "32.1",
                        "43.2",
                        "1000"});
#line 122
    testRunner.And("the Directory Service Policy is set to have the following Geofence locations:", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Days",
                        "Start Hour",
                        "Start Minute",
                        "End Hour",
                        "End Minute",
                        "Time Zone"});
            table18.AddRow(new string[] {
                        "Week Days",
                        "Monday,Tuesday,Wednesday,Thursday,Friday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/Los_Angeles"});
            table18.AddRow(new string[] {
                        "Week Ends",
                        "Saturday,Sunday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/New_York"});
#line 126
    testRunner.And("the Directory Service Policy is set to have the following Time Fences:", ((string)(null)), table18, "And ");
#line 130
    testRunner.And("I set the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
    testRunner.And("I retrieve the Policy for the Current Directory Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
    testRunner.Then("the Directory Service Policy has no requirement for number of factors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
    testRunner.And("the Directory Service Policy does require jail break protection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
    testRunner.And("the Directory Service Policy does require inherence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
    testRunner.And("the Directory Service Policy does require knowledge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
    testRunner.And("the Directory Service Policy does require possession", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Days",
                        "Start Hour",
                        "Start Minute",
                        "End Hour",
                        "End Minute",
                        "Time Zone"});
            table19.AddRow(new string[] {
                        "Week Days",
                        "Monday,Tuesday,Wednesday,Thursday,Friday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/Los_Angeles"});
            table19.AddRow(new string[] {
                        "Week Ends",
                        "Saturday,Sunday",
                        "0",
                        "0",
                        "23",
                        "59",
                        "America/New_York"});
#line 137
    testRunner.And("the Directory Service Policy has the following Time Fences:", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Latitude",
                        "Longitude",
                        "Radius"});
            table20.AddRow(new string[] {
                        "Location Alpha",
                        "12.3",
                        "23.4",
                        "500"});
            table20.AddRow(new string[] {
                        "Location Beta",
                        "32.1",
                        "43.2",
                        "1000"});
#line 141
    testRunner.And("the Directory Service Policy has the following Geofence locations:", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
