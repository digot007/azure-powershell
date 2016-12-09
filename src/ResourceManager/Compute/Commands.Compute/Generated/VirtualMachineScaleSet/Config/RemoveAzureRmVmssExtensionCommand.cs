// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet("Remove", "AzureRmVmssExtension")]
    [OutputType(typeof(VirtualMachineScaleSet))]
    public class RemoveAzureRmVmssExtensionCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 1,
            ParameterSetName = "NameParameterSet",
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 1,
            ParameterSetName = "IdParameterSet",
            ValueFromPipelineByPropertyName = true)]
        public string Id { get; set; }

        protected override void ProcessRecord()
        {
            // VirtualMachineProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
            {
                WriteObject(this.VirtualMachineScaleSet);
                return;
            }

            // ExtensionProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile == null)
            {
                WriteObject(this.VirtualMachineScaleSet);
                return;
            }

            // Extensions
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions == null)
            {
                WriteObject(this.VirtualMachineScaleSet);
                return;
            }
            var vExtensions = this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions.First
                (e =>
                    (this.Name != null && e.Name == this.Name)
                    || (this.Id != null && e.Id == this.Id)
                );

            if (vExtensions != null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions.Remove(vExtensions);
            }

            if (this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions.Count == 0)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions = null;
            }
            WriteObject(this.VirtualMachineScaleSet);
        }
    }
}

