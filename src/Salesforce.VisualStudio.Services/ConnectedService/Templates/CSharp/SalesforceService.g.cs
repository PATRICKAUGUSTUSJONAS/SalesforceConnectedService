﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Salesforce.VisualStudio.Services.ConnectedService.Templates.CSharp
{
    using Salesforce.VisualStudio.Services.ConnectedService;
    using Salesforce.VisualStudio.Services.ConnectedService.CodeModel;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class SalesforceService : SalesforceServiceBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using Salesforce.Common;\r\n");
            
            #line 8 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"

    if (generatedService.AuthenticationStrategy == AuthenticationStrategy.WebServerFlow)
    {

            
            #line default
            #line hidden
            this.Write("using Salesforce.Common.Models;\r\n");
            
            #line 13 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"

    }

            
            #line default
            #line hidden
            this.Write("using Salesforce.Force;\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing " +
                    "System.Configuration;\r\nusing System.Globalization;\r\nusing System.Linq;\r\nusing Sy" +
                    "stem.Text;\r\nusing System.Threading.Tasks;\r\n");
            
            #line 24 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"

    if (generatedService.AuthenticationStrategy == AuthenticationStrategy.WebServerFlow)
    {

            
            #line default
            #line hidden
            this.Write("using System.Web;\r\n");
            
            #line 29 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 33 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ServiceNamespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    /// <summary>\r\n    /// Provides methods to interact with a Salesforce se" +
                    "rvice.\r\n    /// </summary>\r\n    public static class SalesforceService\r\n    {\r\n");
            
            #line 40 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"

    if (generatedService.AuthenticationStrategy == AuthenticationStrategy.UserNamePassword)
    {

            
            #line default
            #line hidden
            this.Write(@"        /// <summary>
        /// Gets a ForceClient that has been authenticated using the UserName, Password, and SecurityToken settings
        /// specified in the config file.
        /// </summary>
        /// <returns>The authenticated ForceClient.</returns>
        public static async Task<ForceClient> GetUserNamePasswordForceClientAsync()
        {
#error Update the config file with the connected app's UserName, Password and SecurityToken. For more information, see the Next Steps section of the Getting Started documentation.

            using (AuthenticationClient authenticationClient = new AuthenticationClient())
            {
                await authenticationClient.UsernamePasswordAsync(
                    SalesforceService.GetAppSetting(""");
            
            #line 56 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.ConsumerKey));
            
            #line default
            #line hidden
            this.Write("\"),\r\n                    SalesforceService.GetAppSetting(\"");
            
            #line 57 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.ConsumerSecret));
            
            #line default
            #line hidden
            this.Write("\"),\r\n                    SalesforceService.GetAppSetting(\"");
            
            #line 58 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.UserName));
            
            #line default
            #line hidden
            this.Write("\"),\r\n                    SalesforceService.GetAppSetting(\"");
            
            #line 59 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.Password));
            
            #line default
            #line hidden
            this.Write("\") + SalesforceService.GetAppSetting(\"");
            
            #line 59 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.SecurityToken));
            
            #line default
            #line hidden
            this.Write("\", true),\r\n                    SalesforceService.GetAppSetting(\"");
            
            #line 60 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.Domain));
            
            #line default
            #line hidden
            this.Write(@""") + ""/services/oauth2/token"");

                return new ForceClient(
                    authenticationClient.InstanceUrl,
                    authenticationClient.AccessToken,
                    authenticationClient.ApiVersion);
            }
        }

");
            
            #line 69 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"

    }
    else if (generatedService.AuthenticationStrategy == AuthenticationStrategy.WebServerFlow)
    {

            
            #line default
            #line hidden
            this.Write("        private static string TokenCacheKey = \"SalesforceToken\";\r\n\r\n        /// <" +
                    "summary>\r\n        /// Makes a request to the Salesforce client, wrapping the spe" +
                    "cified logic with the code necessary to handle authentication.\r\n        /// </su" +
                    "mmary>\r\n        /// <typeparam name=\"T\">The type of value returned from the requ" +
                    "est.</typeparam>\r\n        /// <param name=\"request\">The request to make on the S" +
                    "alesforce client.</param>\r\n        /// <exception cref=\"InvalidOperationExceptio" +
                    "n\">The current user is not authenticated.</exception>\r\n        /// <returns>The " +
                    "value returned by the request.</returns>\r\n        public static async Task<T> Ma" +
                    "keAuthenticatedClientRequestAsync<T>(Func<ForceClient, Task<T>> request)\r\n      " +
                    "  {\r\n            bool done = false;\r\n            bool refreshedToken = false;\r\n " +
                    "           T result = default(T);\r\n\r\n            do\r\n            {\r\n            " +
                    "    // 1. Get the token from the cache\r\n                SalesforceToken salesfor" +
                    "ceToken = HttpContext.Current.Session[SalesforceService.TokenCacheKey] as Salesf" +
                    "orceToken;\r\n\r\n                // 2. If no token is available, redirect to author" +
                    "ize\r\n                if (salesforceToken == null)\r\n                {\r\n          " +
                    "          // This exception message should be used to trigger the sign-in UI\r\n  " +
                    "                  throw new InvalidOperationException(\"AuthorizationRequired\");\r" +
                    "\n                }\r\n\r\n                // Initialize the ForceClient\r\n           " +
                    "     ForceClient forceClient = salesforceToken.GetForceClient();\r\n\r\n            " +
                    "    try\r\n                {\r\n                    // 3. Invoke the request with th" +
                    "e acquired token\r\n                    result = await request(forceClient);\r\n    " +
                    "                done = true;\r\n                }\r\n                catch (ForceExc" +
                    "eption e)\r\n                {\r\n                    // If message is \"Session expi" +
                    "red or invalid\", the access token is invalid, so eat the\r\n                    //" +
                    " exception and fall through to try to update it using the refresh token.\r\n      " +
                    "              if (e.Message != \"Session expired or invalid\")\r\n                  " +
                    "  {\r\n                        throw;\r\n                    }\r\n\r\n                  " +
                    "  if (refreshedToken)\r\n                    {\r\n                        // The acc" +
                    "ess token is invalid and was already refreshed once, give up and\r\n              " +
                    "          // re-throw the exception.\r\n                        throw;\r\n          " +
                    "          }\r\n                }\r\n\r\n                // 4. If the token is invalid," +
                    " attempt to acquire a new access token from the refresh token\r\n                i" +
                    "f (!done)\r\n                {\r\n                    await SalesforceService.Acquir" +
                    "eAccessTokenFromRefreshTokenAsync(salesforceToken);\r\n                    refresh" +
                    "edToken = true;\r\n                }\r\n\r\n            } while (!done);\r\n\r\n          " +
                    "  return result;\r\n        }\r\n\r\n        /// <summary>\r\n        /// Gets a Salesfo" +
                    "rce token from an authorization code and adds it to the cache.\r\n        /// </su" +
                    "mmary>\r\n        /// <param name=\"authorizationCode\">The code that was returned t" +
                    "o the OAuth callback.</param>\r\n        /// <param name=\"redirectUri\">The redirec" +
                    "t URI that was used to acquire the code.</param>\r\n        /// <returns>The async" +
                    "hronous task.</returns>\r\n        public static async Task AcquireTokenByAuthoriz" +
                    "ationCodeAsync(string authorizationCode, string redirectUri)\r\n        {\r\n       " +
                    "     using (AuthenticationClient authenticationClient = new AuthenticationClient" +
                    "())\r\n            {\r\n                await authenticationClient.WebServerAsync(\r\n" +
                    "                    SalesforceService.GetAppSetting(\"");
            
            #line 150 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.ConsumerKey));
            
            #line default
            #line hidden
            this.Write("\"),\r\n                    SalesforceService.GetAppSetting(\"");
            
            #line 151 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.ConsumerSecret));
            
            #line default
            #line hidden
            this.Write("\"),\r\n                    redirectUri,\r\n                    authorizationCode,\r\n  " +
                    "                  SalesforceService.GetAppSetting(\"");
            
            #line 154 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.Domain));
            
            #line default
            #line hidden
            this.Write(@""") + ""/services/oauth2/token"");

                SalesforceToken salesforceToken = new SalesforceToken(authenticationClient);

                // Add the new token to the cache
                HttpContext.Current.Session[SalesforceService.TokenCacheKey] = salesforceToken;
            }
        }

        /// <summary>
        /// Gets a Salesforce token based on the refresh token and adds it to the cache.
        /// </summary>
        /// <param name=""salesforceToken"">The Salesforce token that contains the refresh token to use.</param>
        /// <returns>The asynchronous task.</returns>
        private static async Task AcquireAccessTokenFromRefreshTokenAsync(SalesforceToken salesforceToken)
        {
            // Remove the old token from the cache
            HttpContext.Current.Session[SalesforceService.TokenCacheKey] = null;

            try
            {
                using (AuthenticationClient authenticationClient = salesforceToken.GetAuthenticationClient())
                {
                    // Attempt to refresh the token
                    await authenticationClient.TokenRefreshAsync(
                        SalesforceService.GetAppSetting(""");
            
            #line 179 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.ConsumerKey));
            
            #line default
            #line hidden
            this.Write("\"),\r\n                        salesforceToken.RefreshToken,\r\n                     " +
                    "   string.Empty,\r\n                        SalesforceService.GetAppSetting(\"");
            
            #line 182 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedService.ConfigurationKeyNames.Domain));
            
            #line default
            #line hidden
            this.Write(@""") + ""/services/oauth2/token"");

                    salesforceToken = new SalesforceToken(authenticationClient);

                    // Add the new token to the cache
                    HttpContext.Current.Session[SalesforceService.TokenCacheKey] = salesforceToken;
                }
            }
            catch (ForceException e)
            {
                // InvalidGrant means that the refresh token is invalid.
                // Just return in that case, so re-authorization can occur.
                if (e.Error != Error.InvalidGrant)
                {
                    throw;
                }
            }
        }

");
            
            #line 201 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"        /// <summary>
        /// Gets the value of the AppSetting with the specified name from the config file.
        /// </summary>
        /// <param name=""name"">The name of the AppSetting to retrieve.</param>
        /// <param name=""isOptional"">A Boolean value indicating whether or not the AppSetting is considered optional.</param>
        /// <exception cref=""InvalidOperationException"">If isOptional is set to false and the AppSetting is not found.</exception>
        /// <returns>
        /// The value of the AppSetting if found.  If isOptional is set to true and the AppSetting is not found, null is returned.
        /// </returns>
        internal static string GetAppSetting(string name, bool isOptional = false)
        {
            string setting = ConfigurationManager.AppSettings[name];
            if (!isOptional && (String.IsNullOrWhiteSpace(setting) || string.Equals(setting, ""RequiredValue"", StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException(
                    String.Format(CultureInfo.InvariantCulture, ""The value for the '{0}' key is missing from the appSettings section of the config file."", name));
            }
            else if (isOptional && (String.IsNullOrWhiteSpace(setting) || string.Equals(setting, ""OptionalValue"", StringComparison.OrdinalIgnoreCase)))
            {
                setting = null;
            }

            return setting;
        }
");
            
            #line 228 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"

    if (generatedService.AuthenticationStrategy == AuthenticationStrategy.WebServerFlow)
    {

            
            #line default
            #line hidden
            this.Write("\r\n        /// <summary>\r\n        /// Represents a Salesforce authentication token" +
                    ".\r\n        /// </summary>\r\n        private class SalesforceToken\r\n        {\r\n   " +
                    "         /// <summary>\r\n            /// Gets or sets the access token that can b" +
                    "e used to make authenticated Salesforce service requests.\r\n            /// </sum" +
                    "mary>\r\n            public string AccessToken { get; set; }\r\n\r\n            /// <s" +
                    "ummary>\r\n            /// Gets or sets the refresh token that can be used to obta" +
                    "in a new access token.\r\n            /// </summary>\r\n            public string Re" +
                    "freshToken { get; set; }\r\n\r\n            /// <summary>\r\n            /// Gets or s" +
                    "ets the Salesforce Service Url that was used to obtain this token.\r\n            " +
                    "/// </summary>\r\n            public string InstanceUrl { get; set; }\r\n\r\n         " +
                    "   /// <summary>\r\n            /// Gets or sets the Salesforce API version that t" +
                    "his token is valid for.\r\n            /// </summary>\r\n            public string A" +
                    "piVersion { get; set; }\r\n\r\n            /// <summary>\r\n            /// Initialize" +
                    "s a Salesforce token using an existing AuthenticationClient.\r\n            /// </" +
                    "summary>\r\n            /// <param name=\"authenticationClient\">The AuthenticationC" +
                    "lient from which to initialize the token.</param>\r\n            /// <exception cr" +
                    "ef=\"ArgumentNullException\">authenticationClient is null.</exception>\r\n          " +
                    "  public SalesforceToken(AuthenticationClient authenticationClient)\r\n           " +
                    " {\r\n                if (authenticationClient == null)\r\n                {\r\n      " +
                    "              throw new ArgumentNullException(\"authenticationClient\");\r\n        " +
                    "        }\r\n\r\n                this.AccessToken = authenticationClient.AccessToken" +
                    ";\r\n                this.RefreshToken = authenticationClient.RefreshToken;\r\n     " +
                    "           this.InstanceUrl = authenticationClient.InstanceUrl;\r\n               " +
                    " this.ApiVersion = authenticationClient.ApiVersion;\r\n            }\r\n\r\n          " +
                    "  /// <summary>\r\n            /// Get the AuthenticationClient from the Salesforc" +
                    "e token.\r\n            /// </summary>\r\n            /// <returns>The new Authentic" +
                    "ationClient.</returns>\r\n            public AuthenticationClient GetAuthenticatio" +
                    "nClient()\r\n            {\r\n                AuthenticationClient authenticationCli" +
                    "ent = new AuthenticationClient();\r\n                authenticationClient.AccessTo" +
                    "ken = this.AccessToken;\r\n                authenticationClient.RefreshToken = thi" +
                    "s.RefreshToken;\r\n                authenticationClient.InstanceUrl = this.Instanc" +
                    "eUrl;\r\n                authenticationClient.ApiVersion = this.ApiVersion;\r\n\r\n   " +
                    "             return authenticationClient;\r\n            }\r\n\r\n            /// <sum" +
                    "mary>\r\n            /// Get a ForceClient based on the Salesforce token.\r\n       " +
                    "     /// </summary>\r\n            /// <returns>The new ForceClient.</returns>\r\n  " +
                    "          public ForceClient GetForceClient()\r\n            {\r\n                re" +
                    "turn new ForceClient(this.InstanceUrl, this.AccessToken, this.ApiVersion);\r\n    " +
                    "        }\r\n        }\r\n");
            
            #line 300 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"

    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Repos\visual-studio-tools5\src\Salesforce.VisualStudio.Services\ConnectedService\Templates\CSharp\SalesforceService.tt"

private global::Salesforce.VisualStudio.Services.ConnectedService.CodeModel.GeneratedService _generatedServiceField;

/// <summary>
/// Access the generatedService parameter of the template.
/// </summary>
private global::Salesforce.VisualStudio.Services.ConnectedService.CodeModel.GeneratedService generatedService
{
    get
    {
        return this._generatedServiceField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool generatedServiceValueAcquired = false;
if (this.Session.ContainsKey("generatedService"))
{
    this._generatedServiceField = ((global::Salesforce.VisualStudio.Services.ConnectedService.CodeModel.GeneratedService)(this.Session["generatedService"]));
    generatedServiceValueAcquired = true;
}
if ((generatedServiceValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("generatedService");
    if ((data != null))
    {
        this._generatedServiceField = ((global::Salesforce.VisualStudio.Services.ConnectedService.CodeModel.GeneratedService)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class SalesforceServiceBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
