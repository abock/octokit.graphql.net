namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of DeleteProjectNextItem
    /// </summary>
    public class DeleteProjectNextItemPayload : QueryableValue<DeleteProjectNextItemPayload>
    {
        internal DeleteProjectNextItemPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The ID of the deleted item.
        /// </summary>
        [Obsolete(@"The `ProjectNext` API is deprecated in favour of the more capable `ProjectV2` API. Follow the ProjectV2 guide at https://github.blog/changelog/2022-06-23-the-new-github-issues-june-23rd-update/, to find a suitable replacement. Removal on 2022-10-01 UTC.")]
        public ID? DeletedItemId { get; }

        internal static DeleteProjectNextItemPayload Create(Expression expression)
        {
            return new DeleteProjectNextItemPayload(expression);
        }
    }
}