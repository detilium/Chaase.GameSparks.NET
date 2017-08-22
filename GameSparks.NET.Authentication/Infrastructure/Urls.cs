using GameSparks.NET.Authentication.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Infrastructure
{
    internal static class Urls
    {
        internal static string BaseUrl => "https://auth.gamesparks.net/restv2/auth";

        // ://auth.gamesparks.net/restv2/auth/{apiKey}
        internal static string BaseUrlWithApiKey => string.Format("{0}/{1}", BaseUrl, GameSparksAuthenticationSettings.GetApiKey());

        // ://auth.gamesparks.net/restv2/auth/game/{apiKey}
        internal static string BaseGameUrlWithApiKey => string.Format("{0}/game/{1}", BaseUrl, GameSparksAuthenticationSettings.GetApiKey());
        
        #region Collaborators URLs
        internal static string Collborators => BaseGameUrlWithApiKey + "/collaborators";

        // Structure: /restv2/auth/game/{apiKey}
        internal static string CollboratorsWithEmail => BaseGameUrlWithApiKey + "/collaborators/{0}";
        #endregion

        #region Connect URLs
        internal static string BaseConnectUrl => BaseUrl + "/connect";

            /// <summary>
            /// BitBucket
            /// </summary>
        
        internal static string BitBucketListRepos => BaseConnectUrl + "/bitbucket";
        
        // Structure: /restv2/auth/connect/bitbucket/{owner}/{repo}?branch={branch}
        internal static string BitBucketListLastCommits => BaseConnectUrl + "/bitbucket/{0}/{1}?branch={2}";

        // Structure: /restv2/auth/connect/bitbucket/{owner}/{repo}/branches?depth={integer}
        internal static string BitBucketListBranches => BaseConnectUrl + "/bitbucket/{0}/{1}/branches?depth={3}";

        // Structure: /restv2/auth/connect/bitbucket/{owner}/{repo}/{changeset}?depth={integer}
        internal static string BitBucketListFoldersInChangeset => BaseConnectUrl + "/bitbucket/{0}/{1}/{3}?depth={3}";

        // Structure: /restv2/auth/connect/bitbucket/{owner}/{repo}/{changeset}/**?depth={integer}
        internal static string BitBucketListFoldersInChangeset2 => BaseConnectUrl + "/bitbucket/{0}/{1}/{3}/**?depth={3}";

            /// <summary>
            /// GitHub
            /// </summary>

        internal static string GitHubListRepos => BaseConnectUrl + "/github";

        // Structure: /restv2/auth/connect/github/{owner}/{repo}?branch={branch}
        internal static string GitHubListLatestCommits => BaseConnectUrl + "/github/{0}/{1}?branch={2}";

        // Structure: /restv2/auth/connect/github/{owner}/{repo}/branches?depth={integer}
        internal static string GitHubListBranches => BaseConnectUrl + "/github/{0}/{1}/branches?depth={2}";

        // Structure: /restv2/auth/connect/github/{owner}/{repo}/tree/{ref}
        internal static string GitHubListFoldersInRef => BaseConnectUrl + "/github/{0}/{1}/tree/{2}";

        // Structure: /restv2/auth/connect/github/{owner}/{repo}/tree/{ref}/**
        internal static string GitHubListFoldersInRef2 => BaseConnectUrl + "/github/{0}/{1}/{2}/**";
        #endregion

        #region Features URLs
        internal static string FeaturesUrl => BaseGameUrlWithApiKey + "/features";
        #endregion

        #region Groups URLs
        internal static string BaseGroupsUrl => BaseGameUrlWithApiKey + "/groups";

        // Structure: /restv2/auth/game/{apiKey}/groups/{groupName}
        internal static string GroupsUrlWithName => BaseGroupsUrl + "/{0}";
        #endregion

        #region User URLs
        // Structure: /restv2/auth/game/{apiKey}/jwt?additionalApiKeys={keys}&includeProperties={bool}&unsigned={bool}&expireInSeconds={integer}
        internal static string UserJwt => BaseGameUrlWithApiKey + "/jwt?{0}";

        // Structure: /restv2/auth/game/{apiKey}/jwt/{filter}?additionalApiKeys={keys}&includeProperties={bool}&unsigned={bool}&expireInSeconds={integer}
        internal static string UserJwtFilter => BaseGameUrlWithApiKey + "/jwt/{0}?{1}";

        // Structure: /restv2/auth/game/{apiKey}/membership?groups={string}
        internal static string UserMembership => BaseGameUrlWithApiKey + "/membership?{0}";

        // Structure: /restv2/auth/game/{apiKey}/owner?newOwner={string}
        internal static string UserNewOwner => BaseGameUrlWithApiKey + "/owner?newOwner={0}";

        // Structure: /restv2/auth/game/{apiKey}/permissions
        internal static string UserPermissions => BaseGameUrlWithApiKey + "/permissions";

        // Structure: /restv2/auth/games
        internal static string UserGames => BaseUrl + "/games";

        // Structure: /restv2/auth/user?expireInSeconds={integer}
        internal static string User => BaseUrl + "/user?{0}";

        // Structure: /restv2/auth/user/jwt?expireInSeconds={integer}
        internal static string UserAuthJwt => BaseUrl + "/user/jwt?{0}";
        #endregion
    }
}
