﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.TestFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class SimpleMethodTests : Generators.BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.IO;\r\nusing System." +
                    "Linq;\r\nusing System.Text;\r\nusing Microsoft.VisualStudio.TestTools.UnitTesting;\r\n" +
                    "\r\nusing ");
            
            #line 16 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\nusing ");
            
            #line 17 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nnamespace AWSSDK_DotNet35.UnitTests.TestTools\r\n{\r\n    [TestClass]\r\n    publi" +
                    "c class ");
            
            #line 22 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("MethodCustomizationsTests\r\n    {\r\n        [TestMethod]\r\n\t\t[TestCategory(\"UnitTest" +
                    "\")]\r\n        [TestCategory(\"SimpleMethods\"), TestCategory(\"");
            
            #line 26 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public void ");
            
            #line 27 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("SimpleMethodTests()\r\n        {\r\n");
            
            #line 29 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"

        foreach(var operation in this.Config.ServiceModel.Operations)
        {
            if (this.Config.ServiceModel.Customizations.SimpleMethodsModel.CreateSimpleMethods(operation.Name))
            {
                var forms = this.Config.ServiceModel.Customizations.SimpleMethodsModel.SimpleMethods[operation.Name].Forms;
                var members = this.Config.ServiceModel.FindShape(operation.RequestStructure.Name).Members;

                foreach (var form in forms)
                {
                    var docMembers = this.Config.ServiceModel.Customizations.SimpleMethodsModel.GetFormMembers(form, members);

            
            #line default
            #line hidden
            this.Write("            EnsureSimpleMethodExists(typeof(");
            
            #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Amazon");
            
            #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client), \"");
            
            #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\", new Type[] { ");
            
            #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
foreach (var member in docMembers) { 
            
            #line default
            #line hidden
            this.Write("typeof(");
            
            #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            this.Write("), ");
            
            #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"
 }
            
            #line default
            #line hidden
            this.Write("});\r\n");
            
            #line 42 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\SimpleMethodTests.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write(@"        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), ""Failed to find simple method "" + methodName);
        }
    }
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
