namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Audit log entry for a org.restore_member event.
    /// </summary>
    public class OrgRestoreMemberAuditEntry : QueryableValue<OrgRestoreMemberAuditEntry>
    {
        internal OrgRestoreMemberAuditEntry(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The action name
        /// </summary>
        public string Action { get; }

        /// <summary>
        /// The user who initiated the action
        /// </summary>
        public AuditEntryActor Actor => this.CreateProperty(x => x.Actor, Octokit.GraphQL.Model.AuditEntryActor.Create);

        /// <summary>
        /// The IP address of the actor
        /// </summary>
        public string ActorIp { get; }

        /// <summary>
        /// A readable representation of the actor's location
        /// </summary>
        public ActorLocation ActorLocation => this.CreateProperty(x => x.ActorLocation, Octokit.GraphQL.Model.ActorLocation.Create);

        /// <summary>
        /// The username of the user who initiated the action
        /// </summary>
        public string ActorLogin { get; }

        /// <summary>
        /// The HTTP path for the actor.
        /// </summary>
        public string ActorResourcePath { get; }

        /// <summary>
        /// The HTTP URL for the actor.
        /// </summary>
        public string ActorUrl { get; }

        /// <summary>
        /// The time the action was initiated
        /// </summary>
        public string CreatedAt { get; }

        public ID Id { get; }

        /// <summary>
        /// The corresponding operation type for the action
        /// </summary>
        public OperationType? OperationType { get; }

        /// <summary>
        /// The Organization associated with the Audit Entry.
        /// </summary>
        public Organization Organization => this.CreateProperty(x => x.Organization, Octokit.GraphQL.Model.Organization.Create);

        /// <summary>
        /// The name of the Organization.
        /// </summary>
        public string OrganizationName { get; }

        /// <summary>
        /// The HTTP path for the organization
        /// </summary>
        public string OrganizationResourcePath { get; }

        /// <summary>
        /// The HTTP URL for the organization
        /// </summary>
        public string OrganizationUrl { get; }

        /// <summary>
        /// The number of custom email routings for the restored member.
        /// </summary>
        public int? RestoredCustomEmailRoutingsCount { get; }

        /// <summary>
        /// The number of issue assignments for the restored member.
        /// </summary>
        public int? RestoredIssueAssignmentsCount { get; }

        /// <summary>
        /// Restored organization membership objects.
        /// </summary>
        public IQueryableList<OrgRestoreMemberAuditEntryMembership> RestoredMemberships => this.CreateProperty(x => x.RestoredMemberships);

        /// <summary>
        /// The number of restored memberships.
        /// </summary>
        public int? RestoredMembershipsCount { get; }

        /// <summary>
        /// The number of repositories of the restored member.
        /// </summary>
        public int? RestoredRepositoriesCount { get; }

        /// <summary>
        /// The number of starred repositories for the restored member.
        /// </summary>
        public int? RestoredRepositoryStarsCount { get; }

        /// <summary>
        /// The number of watched repositories for the restored member.
        /// </summary>
        public int? RestoredRepositoryWatchesCount { get; }

        /// <summary>
        /// The user affected by the action
        /// </summary>
        public User User => this.CreateProperty(x => x.User, Octokit.GraphQL.Model.User.Create);

        /// <summary>
        /// For actions involving two users, the actor is the initiator and the user is the affected user.
        /// </summary>
        public string UserLogin { get; }

        /// <summary>
        /// The HTTP path for the user.
        /// </summary>
        public string UserResourcePath { get; }

        /// <summary>
        /// The HTTP URL for the user.
        /// </summary>
        public string UserUrl { get; }

        internal static OrgRestoreMemberAuditEntry Create(Expression expression)
        {
            return new OrgRestoreMemberAuditEntry(expression);
        }
    }
}