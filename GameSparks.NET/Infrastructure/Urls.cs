using GameSparks.NET.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Infrastructure
{
    internal static class Urls
    {
        internal static string BaseUrl => string.Format("https://{0}.{1}.gamesparks.net/rs/{2}/{3}", 
            GameSparksSettings.GetApiKey(), 
            (GameSparksSettings.GetIsLive() ? "live" : "preview"),
            GameSparksSettings.GetCredentials(),
            GameSparksSettings.GetSecret());


        #region Admin URLs
        internal static string BatchAdminRequest => BaseUrl + "/BatchAdminRequest";
        internal static string CancelBulkJobAdminRequest => BaseUrl + "/CancelBulkJobAdminRequest";
        internal static string ListBulkJobsAdminRequest => BaseUrl + "/ListBulkJobsAdminRequest";
        internal static string RevokePurchaseGoodsRequest => BaseUrl + "/RevokePurchaseGoodsRequest";
        internal static string ScheduleBulkJobAdminRequest => BaseUrl + "/ScheduleBulkJobAdminRequest";
        #endregion

        #region Authentication URLs
        internal static string AmazonConnectRequest => BaseUrl + "/AmazonConnectRequest";
        internal static string AuthenticationRequest => BaseUrl + "/AuthenticationRequest";
        internal static string DeviceAuthenticationRequest => BaseUrl + "/DeviceAuthenticationRequest";
        internal static string FacebookConnectRequest => BaseUrl + "/FacebookConnectRequest";
        internal static string GameCenterConnectRequest => BaseUrl + "/GameCenterConnectRequest";
        internal static string GooglePlayConnectRequest => BaseUrl + "/GooglePlayConnectRequest";
        internal static string GooglePlusConnectRequest => BaseUrl + "/GooglePlusConnectRequest";
        internal static string KongregateConnectRequest => BaseUrl + "/KongregateConnectRequest";
        internal static string NXConnectRequest => BaseUrl + "/NXConnectRequest";
        internal static string PSNConnectRequest => BaseUrl + "/PSNConnectRequest";
        internal static string QQConnectRequest => BaseUrl + "/QQConnectRequest";
        internal static string RegistrationRequest => BaseUrl + "/RegistrationRequest";
        internal static string SteamConnectRequest => BaseUrl + "/SteamConnectRequest";
        internal static string TwitchConnectRequest => BaseUrl + "/TwitchConnectRequest";
        internal static string TwitterConnectRequest => BaseUrl + "/TwitterConnectRequest";
        internal static string ViberConnectRequest => BaseUrl + "/ViberConnectRequest";
        internal static string WeChatConnectRequest => BaseUrl + "/WeChatConnectRequest";
        internal static string XBOXLiveConnectRequest => BaseUrl + "/XBOXLiveConnectRequest";
        internal static string XboxOneConnectRequest => BaseUrl + "/XBOXOneConnectRequest";
        #endregion

        #region Analytics URLs
        internal static string AnalyticsRequest => BaseUrl + "/AnalyticsRequest";
        internal static string EndSessionRequest => BaseUrl + "/EndSessionRequest";
        #endregion

        #region Events URLs
        internal static string LogChallengeEventRequest => BaseUrl + "/LogChallengeEventRequest";
        internal static string LogEventRequest => BaseUrl + "/LogEventRequest";
        #endregion

        #region Leaderboard URLs
        internal static string AroundMeLeaderboardRequest => BaseUrl + "/AroundMeLeaderboardRequest";
        internal static string GetLeaderboardEntriesRequest => BaseUrl + "/GetLeaderboardEntriesRequest";
        internal static string LeaderboardDataRequest => BaseUrl + "/LeaderboardDataRequest";
        internal static string LeaderboardsEntriesRequest => BaseUrl + "/LeaderboardsEntriesRequest";
        internal static string ListLeaderboardsRequest => BaseUrl + "/ListLeaderboardRequest";
        internal static string SocialLeaderboardDataRequest => BaseUrl + "/SocialLeaderboardDataRequest";
        #endregion

        #region Messages URLs
        internal static string MessagesRequest => BaseUrl + "/Messages";
        #endregion

        #region Misc URLs
        internal static string GetDownloadableRequest => BaseUrl + "/GetDownloadableRequest";
        internal static string GetPropertyRequest => BaseUrl + "/GetPropertyRequest";
        internal static string GetPropertySetRequest => BaseUrl + "/GetPropertySetRequest";
        internal static string GetUploadUrlRequest => BaseUrl + "/GetUploadUrlRequest";
        internal static string GetUploadedRequest => BaseUrl + "/GetUploadedRequest";
        internal static string PushRegistrationRequest => BaseUrl + "/PushRegistrationRequest";
        internal static string SocialStatusRequest => BaseUrl + "/SocialStatusRequest";
        #endregion

        #region Multiplayer URLs
        internal static string AcceptChallengeRequest => BaseUrl + "/AcceptChallengeRequest";
        internal static string ChatOnChallengeRequest => BaseUrl + "/ChatOnChallengeRequest";
        internal static string CreateChallengeRequest => BaseUrl + "/CreateChallengeRequest";
        internal static string DeclineChallengeRequest => BaseUrl + "/DeclineChallengeRequest";
        internal static string FindChallengeRequest => BaseUrl + "/FindChallengeRequest";
        internal static string FindMatchRequest => BaseUrl + "/FindMatchRequest";
        internal static string FindPendingMatchesRequest => BaseUrl + "/FindPendingMatchesRequest";
        internal static string GetChallengeRequest => BaseUrl + "/GetChallengeRequest";
        internal static string JoinChallengeRequest => BaseUrl + "/JoinChallengeRequest";
        internal static string JoinPendingMatchRequest => BaseUrl + "/JoinPendingMatchRequest";
        internal static string ListChallengeRequest => BaseUrl + "/ListChallengeRequest";
        internal static string ListChallengeTypeRequest => BaseUrl + "/LigeChallengeTypeRequest";
        internal static string MatchDetailsRequest => BaseUrl + "/MatchDetailsRequest";
        internal static string MatchmakingRequest => BaseUrl + "/MatchmakingRequest";
        internal static string WithdrawChallengeRequest => BaseUrl + "/WithdrawChallengeRequest";
        #endregion

        #region Player URLs
        internal static string AccountDetailsRequest => BaseUrl + "/AccountDetailsRequest";
        internal static string ChangeUserDetailsRequest => BaseUrl + "/ChangeUserDetailsRequest";
        internal static string DismissMessageRequest => BaseUrl + "/DismissMessageRequest";
        internal static string DismissMultipleMessagesRequest => BaseUrl + "/DismissMultipleMessagesRequest";
        internal static string GetMessageRequest => BaseUrl + "/GetMessageRequest";
        internal static string ListAchievementsRequest => BaseUrl + "/ListAchievementsRequest";
        internal static string ListGameFriendsRequest => BaseUrl + "/ListGameFriendsRequest";
        internal static string ListInviteFriendsRequest => BaseUrl + "/ListInviteFriendsRequest";
        internal static string ListMessageDetailRequest => BaseUrl + "/ListMessageDetailRequest";
        internal static string ListMessageRequest => BaseUrl + "/ListMessageRequest";
        internal static string ListMessageSummaryRequest => BaseUrl + "/ListMessageSummaryRequest";
        internal static string ListTransactionsRequest => BaseUrl + "/ListTransactionsRequest";
        internal static string SendFriendMessageRequest => BaseUrl + "/SendFriendMessageRequest";
        internal static string SocialDisconnectRequest => BaseUrl + "/SocialDisconnectRequest";
        internal static string UpdateMessageRequest => BaseUrl + "/UpdateMessageRequest";
        #endregion

        #region Store URLs
        internal static string AmazonBuyGoodsRequest => BaseUrl + "/AmazonBuyGoodsRequest";
        internal static string BuyVirtualGoodsRequest => BaseUrl + "/BuyVirtualGoodsRequest";
        internal static string ConsumeVirtualGoodRequest => BaseUrl + "/ConsumeVirtualGoodRequest";
        internal static string GooglePlayBuyGoodsRequest => BaseUrl + "/GooglePlayBuyGoodsRequest";
        internal static string IOSBuyGoodsRequest => BaseUrl + "/IOSBuyGoodsRequest";
        internal static string ListVirtualGoodsRequest => BaseUrl + "/ListVirtualGoodsRequest";
        internal static string PsnBuyGoodsRequest => BaseUrl + "/PsnBuyGoodsRequest";
        internal static string SteamBuyGoodsRequest => BaseUrl + "/SteamBuyGoodsRequest";
        internal static string WindowsBuyGoodsRequest => BaseUrl + "/WindowsBuyGoodsRequest";
        #endregion

        #region Teams URLs
        internal static string CreateTeamRequest => BaseUrl + "/CreateTeamRequest";
        internal static string DropTeamRequest => BaseUrl + "/DropTeamRequest";
        internal static string GetMyTeamsRequest => BaseUrl + "/GetMyTeamsRequest";
        internal static string GetTeamRequest => BaseUrl + "/GetTeamRequest";
        internal static string JoinTeamRequest => BaseUrl + "/JoinTeamRequest";
        internal static string LeaveTeamRequest => BaseUrl + "/LeaveTeamRequest";
        internal static string ListTeamChatRequest => BaseUrl + "/ListTeamChatRequest";
        internal static string ListTeamsRequest => BaseUrl + "/ListTeamsRequest";
        internal static string SendTeamChatMessageRequest => BaseUrl + "/SendTeamChatMessageRequest";
        #endregion
    }
}
