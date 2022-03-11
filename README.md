# sharpiversal
<strong>What is this?</strong>

This is my collection of .Net projects that incorporate the new <a href="https://github.com/microsoft/PowerPlatform-DataverseServiceClient">Microsoft.PowerPlatform.Dataverse.Client</a> package for connectivity to Dataverse sources like Dynamics 365.


<strong>What is in here?</strong>

SimpleDotNetFourEightWebApi and UpdatedDotNetFourEightWebApi are straightforward .Net Web API projects built from the C# template in VS 2022 with a simple controller that allows a Dataverse connection to be tested using the Dataverse ServiceClient.

Neither of these should be used as templates for new projects as I built them with the sole intention of highlighting a problem with newer versions of Microsoft.PowerPlatform.Dataverse.Client that seems to manifest in .NET Framework project usage (as opposed to .Net Core).
