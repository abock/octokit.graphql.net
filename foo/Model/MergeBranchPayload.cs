namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of MergeBranch
    /// </summary>
    public class MergeBranchPayload : QueryableValue<MergeBranchPayload>
    {
        internal MergeBranchPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The resulting merge Commit.
        /// </summary>
        public Commit MergeCommit => this.CreateProperty(x => x.MergeCommit, Octokit.GraphQL.Model.Commit.Create);

        internal static MergeBranchPayload Create(Expression expression)
        {
            return new MergeBranchPayload(expression);
        }
    }
}