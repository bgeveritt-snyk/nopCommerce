using System.Collections.Generic;
using System.Linq;
using Nop.Core.Domain.Topics;

namespace Nop.Services.Topics
{
    /// <summary>
    /// Topic service interface
    /// </summary>
    public partial interface ITopicService
    {
        /// <summary>
        /// Apply constraints to display on the frontend if these exist and enabled.
        /// </summary>
        /// <param name="storeId">A store identifier</param>
        /// <param name="customerRoleIds">Identifiers of customer's roles</param>
        /// <param name="productsQuery">A query to apply</param>
        /// <returns>True if any a mapping rule is applied; otherwise false</returns>
        bool ApplyTopicConstraints(int storeId, int[] customerRoleIds, out IQueryable<Topic> topicsQuery);

        /// <summary>
        /// Deletes a topic
        /// </summary>
        /// <param name="topic">Topic</param>
        void DeleteTopic(Topic topic);

        /// <summary>
        /// Gets a topic
        /// </summary>
        /// <param name="topicId">The topic identifier</param>
        /// <returns>Topic</returns>
        Topic GetTopicById(int topicId);

        /// <summary>
        /// Gets a topic
        /// </summary>
        /// <param name="systemName">The topic system name</param>
        /// <param name="storeId">Store identifier; pass 0 to ignore filtering by store and load the first one</param>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <returns>Topic</returns>
        Topic GetTopicBySystemName(string systemName, int storeId = 0, bool showHidden = false);

        /// <summary>
        /// Gets all topics
        /// </summary>
        /// <param name="storeId">Store identifier; pass 0 to load all records</param>
        /// <param name="ignorAcl">A value indicating whether to ignore ACL rules</param>
        /// <param name="showHidden">A value indicating whether to show hidden topics</param>
        /// <param name="onlyIncludedInTopMenu">A value indicating whether to show only topics which include on the top menu</param>
        /// <returns>Topics</returns>
        IList<Topic> GetAllTopics(int storeId, bool ignorAcl = false, bool showHidden = false, bool onlyIncludedInTopMenu = false);

        /// <summary>
        /// Gets all topics
        /// </summary>
        /// <param name="storeId">Store identifier; pass 0 to load all records</param>
        /// <param name="keywords">Keywords to search into body or title</param>
        /// <param name="ignoreAcl">A value indicating whether to ignore ACL rules</param>
        /// <param name="showHidden">A value indicating whether to show hidden topics</param>
        /// <param name="onlyIncludedInTopMenu">A value indicating whether to show only topics which include on the top menu</param>
        /// <returns>Topics</returns>
        IList<Topic> GetAllTopics(int storeId, string keywords, bool ignoreAcl = false, bool showHidden = false, bool onlyIncludedInTopMenu = false);

        /// <summary>
        /// Inserts a topic
        /// </summary>
        /// <param name="topic">Topic</param>
        void InsertTopic(Topic topic);

        /// <summary>
        /// Updates the topic
        /// </summary>
        /// <param name="topic">Topic</param>
        void UpdateTopic(Topic topic);
    }
}
