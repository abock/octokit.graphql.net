namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CreateCheckRun
    /// </summary>
    public class CreateCheckRunInput
    {
        /// <summary>
        /// The node ID of the repository.
        /// </summary>
        public ID RepositoryId { get; set; }

        /// <summary>
        /// The name of the check.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The SHA of the head commit.
        /// </summary>
        public string HeadSha { get; set; }

        /// <summary>
        /// The URL of the integrator's site that has the full details of the check.
        /// </summary>
        public string DetailsUrl { get; set; }

        /// <summary>
        /// A reference for the run on the integrator's system.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// The current status.
        /// </summary>
        public RequestableCheckStatusState? Status { get; set; }

        /// <summary>
        /// The time that the check run began.
        /// </summary>
        public DateTimeOffset? StartedAt { get; set; }

        /// <summary>
        /// The final conclusion of the check.
        /// </summary>
        public CheckConclusionState? Conclusion { get; set; }

        /// <summary>
        /// The time that the check run finished.
        /// </summary>
        public DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// Descriptive details about the run.
        /// </summary>
        public CheckRunOutput Output { get; set; }

        /// <summary>
        /// Possible further actions the integrator can perform, which a user may trigger.
        /// </summary>
        public IEnumerable<CheckRunAction> Actions { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}