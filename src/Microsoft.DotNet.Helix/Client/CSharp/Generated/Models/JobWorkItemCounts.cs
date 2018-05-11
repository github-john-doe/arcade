// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class JobWorkItemCounts
    {
        /// <summary>
        /// Initializes a new instance of the JobWorkItemCounts class.
        /// </summary>
        public JobWorkItemCounts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobWorkItemCounts class.
        /// </summary>
        /// <param name="unscheduled">Number of jobs present in initial upload
        /// that have no been scheduled to a queue yet</param>
        /// <param name="waiting">Number of jobs that are currently queued and
        /// waiting for a machine</param>
        /// <param name="running">Number of jobs that are currently executing
        /// for this job</param>
        /// <param name="finished">Number of jobs that have finished</param>
        /// <param name="listUrl">Url to a list of all work items associated
        /// with this job</param>
        public JobWorkItemCounts(int unscheduled, int waiting, int running, int finished, string listUrl)
        {
            Unscheduled = unscheduled;
            Waiting = waiting;
            Running = running;
            Finished = finished;
            ListUrl = listUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of jobs present in initial upload that have no
        /// been scheduled to a queue yet
        /// </summary>
        [JsonProperty(PropertyName = "Unscheduled")]
        public int Unscheduled { get; set; }

        /// <summary>
        /// Gets or sets number of jobs that are currently queued and waiting
        /// for a machine
        /// </summary>
        [JsonProperty(PropertyName = "Waiting")]
        public int Waiting { get; set; }

        /// <summary>
        /// Gets or sets number of jobs that are currently executing for this
        /// job
        /// </summary>
        [JsonProperty(PropertyName = "Running")]
        public int Running { get; set; }

        /// <summary>
        /// Gets or sets number of jobs that have finished
        /// </summary>
        [JsonProperty(PropertyName = "Finished")]
        public int Finished { get; set; }

        /// <summary>
        /// Gets or sets url to a list of all work items associated with this
        /// job
        /// </summary>
        [JsonProperty(PropertyName = "ListUrl")]
        public string ListUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ListUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ListUrl");
            }
        }
    }
}