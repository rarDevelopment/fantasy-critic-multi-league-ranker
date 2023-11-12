using System.Text.Json.Serialization;

namespace FantasyCriticMultiLeagueRanker;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public record AddedByUser(
    [property: JsonPropertyName("userID")] string UserID,
    [property: JsonPropertyName("displayName")] string DisplayName,
    [property: JsonPropertyName("displayNumber")] int DisplayNumber,
    [property: JsonPropertyName("emailAddress")] string EmailAddress,
    [property: JsonPropertyName("roles")] IReadOnlyList<object> Roles,
    [property: JsonPropertyName("emailConfirmed")] bool EmailConfirmed,
    [property: JsonPropertyName("showDecimalPoints")] bool ShowDecimalPoints
);

public record EligibilityOverride(
    [property: JsonPropertyName("masterGame")] MasterGame MasterGame,
    [property: JsonPropertyName("eligible")] bool Eligible
);

public record FormerGame(
    [property: JsonPropertyName("publisherGameID")] string PublisherGameID,
    [property: JsonPropertyName("gameName")] string GameName,
    [property: JsonPropertyName("timestamp")] DateTime Timestamp,
    [property: JsonPropertyName("counterPick")] bool CounterPick,
    [property: JsonPropertyName("estimatedReleaseDate")] string EstimatedReleaseDate,
    [property: JsonPropertyName("releaseDate")] DateTime? ReleaseDate,
    [property: JsonPropertyName("fantasyPoints")] double? FantasyPoints,
    [property: JsonPropertyName("criticScore")] double? CriticScore,
    [property: JsonPropertyName("masterGame")] MasterGame MasterGame,
    [property: JsonPropertyName("overallDraftPosition")] int? OverallDraftPosition,
    [property: JsonPropertyName("bidAmount")] int? BidAmount,
    [property: JsonPropertyName("acquiredInTradeID")] object AcquiredInTradeID,
    [property: JsonPropertyName("slotNumber")] int SlotNumber,
    [property: JsonPropertyName("linked")] bool Linked,
    [property: JsonPropertyName("released")] bool Released,
    [property: JsonPropertyName("willRelease")] bool WillRelease,
    [property: JsonPropertyName("manualCriticScore")] bool ManualCriticScore,
    [property: JsonPropertyName("manualWillNotRelease")] bool ManualWillNotRelease,
    [property: JsonPropertyName("counterPicked")] bool CounterPicked,
    [property: JsonPropertyName("dropBlocked")] bool DropBlocked,
    [property: JsonPropertyName("removedTimestamp")] DateTime RemovedTimestamp,
    [property: JsonPropertyName("removedNote")] string RemovedNote
);

public record Game(
    [property: JsonPropertyName("publisherGameID")] string PublisherGameID,
    [property: JsonPropertyName("gameName")] string GameName,
    [property: JsonPropertyName("timestamp")] DateTime Timestamp,
    [property: JsonPropertyName("counterPick")] bool CounterPick,
    [property: JsonPropertyName("estimatedReleaseDate")] string EstimatedReleaseDate,
    [property: JsonPropertyName("releaseDate")] DateTime? ReleaseDate,
    [property: JsonPropertyName("fantasyPoints")] double? FantasyPoints,
    [property: JsonPropertyName("criticScore")] double? CriticScore,
    [property: JsonPropertyName("masterGame")] MasterGame MasterGame,
    [property: JsonPropertyName("overallDraftPosition")] int? OverallDraftPosition,
    [property: JsonPropertyName("bidAmount")] int? BidAmount,
    [property: JsonPropertyName("acquiredInTradeID")] object AcquiredInTradeID,
    [property: JsonPropertyName("slotNumber")] int SlotNumber,
    [property: JsonPropertyName("linked")] bool Linked,
    [property: JsonPropertyName("released")] bool Released,
    [property: JsonPropertyName("willRelease")] bool WillRelease,
    [property: JsonPropertyName("manualCriticScore")] bool ManualCriticScore,
    [property: JsonPropertyName("manualWillNotRelease")] bool ManualWillNotRelease,
    [property: JsonPropertyName("counterPicked")] bool CounterPicked,
    [property: JsonPropertyName("dropBlocked")] bool DropBlocked,
    [property: JsonPropertyName("removedTimestamp")] object RemovedTimestamp,
    [property: JsonPropertyName("removedNote")] object RemovedNote
);

public record GameNews(
    [property: JsonPropertyName("upcomingGames")] IReadOnlyList<UpcomingGame> UpcomingGames,
    [property: JsonPropertyName("recentGames")] IReadOnlyList<RecentGame> RecentGames
);

public record GameSlot(
    [property: JsonPropertyName("slotNumber")] int SlotNumber,
    [property: JsonPropertyName("overallSlotNumber")] int OverallSlotNumber,
    [property: JsonPropertyName("counterPick")] bool CounterPick,
    [property: JsonPropertyName("specialSlot")] object SpecialSlot,
    [property: JsonPropertyName("publisherGame")] PublisherGame PublisherGame,
    [property: JsonPropertyName("eligibilityErrors")] IReadOnlyList<object> EligibilityErrors,
    [property: JsonPropertyName("gameMeetsSlotCriteria")] bool GameMeetsSlotCriteria,
    [property: JsonPropertyName("projectedFantasyPoints")] double ProjectedFantasyPoints
);

public record League(
    [property: JsonPropertyName("leagueID")] string LeagueID,
    [property: JsonPropertyName("leagueName")] string LeagueName,
    [property: JsonPropertyName("leagueManager")] LeagueManager LeagueManager,
    [property: JsonPropertyName("isManager")] bool IsManager,
    [property: JsonPropertyName("players")] IReadOnlyList<Player> Players,
    [property: JsonPropertyName("outstandingInvite")] object OutstandingInvite,
    [property: JsonPropertyName("years")] IReadOnlyList<int> Years,
    [property: JsonPropertyName("activeYear")] int ActiveYear,
    [property: JsonPropertyName("publicLeague")] bool PublicLeague,
    [property: JsonPropertyName("testLeague")] bool TestLeague,
    [property: JsonPropertyName("customRulesLeague")] bool CustomRulesLeague,
    [property: JsonPropertyName("archived")] bool Archived,
    [property: JsonPropertyName("userIsInLeague")] bool UserIsInLeague,
    [property: JsonPropertyName("userIsFollowingLeague")] bool UserIsFollowingLeague,
    [property: JsonPropertyName("numberOfFollowers")] int NumberOfFollowers
);

public record LeagueManager(
    [property: JsonPropertyName("leagueID")] string LeagueID,
    [property: JsonPropertyName("leagueName")] string LeagueName,
    [property: JsonPropertyName("userID")] string UserID,
    [property: JsonPropertyName("displayName")] string DisplayName,
    [property: JsonPropertyName("removable")] bool Removable
);

public record LeaguePublisherSet(
    [property: JsonPropertyName("leagueID")] string LeagueID,
    [property: JsonPropertyName("year")] int Year,
    [property: JsonPropertyName("leagueName")] string LeagueName,
    [property: JsonPropertyName("publisherID")] string PublisherID,
    [property: JsonPropertyName("publisherName")] string PublisherName,
    [property: JsonPropertyName("counterPickPublisherID")] string CounterPickPublisherID,
    [property: JsonPropertyName("counterPickPublisherName")] string CounterPickPublisherName
);

public record MasterGame(
    [property: JsonPropertyName("masterGameID")] string MasterGameID,
    [property: JsonPropertyName("year")] int Year,
    [property: JsonPropertyName("gameName")] string GameName,
    [property: JsonPropertyName("estimatedReleaseDate")] string EstimatedReleaseDate,
    [property: JsonPropertyName("minimumReleaseDate")] string MinimumReleaseDate,
    [property: JsonPropertyName("maximumReleaseDate")] string MaximumReleaseDate,
    [property: JsonPropertyName("earlyAccessReleaseDate")] string EarlyAccessReleaseDate,
    [property: JsonPropertyName("internationalReleaseDate")] string InternationalReleaseDate,
    [property: JsonPropertyName("announcementDate")] string AnnouncementDate,
    [property: JsonPropertyName("releaseDate")] string ReleaseDate,
    [property: JsonPropertyName("isReleased")] bool IsReleased,
    [property: JsonPropertyName("releasingToday")] bool ReleasingToday,
    [property: JsonPropertyName("willRelease")] bool WillRelease,
    [property: JsonPropertyName("delayContention")] bool DelayContention,
    [property: JsonPropertyName("showNote")] bool ShowNote,
    [property: JsonPropertyName("criticScore")] double? CriticScore,
    [property: JsonPropertyName("fantasyPoints")] double? FantasyPoints,
    [property: JsonPropertyName("averagedScore")] bool AveragedScore,
    [property: JsonPropertyName("notes")] string Notes,
    [property: JsonPropertyName("openCriticID")] int? OpenCriticID,
    [property: JsonPropertyName("openCriticSlug")] string OpenCriticSlug,
    [property: JsonPropertyName("ggToken")] string GgToken,
    [property: JsonPropertyName("subGames")] IReadOnlyList<object> SubGames,
    [property: JsonPropertyName("tags")] IReadOnlyList<string> Tags,
    [property: JsonPropertyName("readableTags")] IReadOnlyList<string> ReadableTags,
    [property: JsonPropertyName("boxartFileName")] string BoxartFileName,
    [property: JsonPropertyName("ggCoverArtFileName")] string GgCoverArtFileName,
    [property: JsonPropertyName("addedTimestamp")] DateTime AddedTimestamp,
    [property: JsonPropertyName("percentStandardGame")] double PercentStandardGame,
    [property: JsonPropertyName("percentCounterPick")] double PercentCounterPick,
    [property: JsonPropertyName("eligiblePercentStandardGame")] double EligiblePercentStandardGame,
    [property: JsonPropertyName("adjustedPercentCounterPick")] double? AdjustedPercentCounterPick,
    [property: JsonPropertyName("averageDraftPosition")] double? AverageDraftPosition,
    [property: JsonPropertyName("hypeFactor")] double HypeFactor,
    [property: JsonPropertyName("dateAdjustedHypeFactor")] double DateAdjustedHypeFactor,
    [property: JsonPropertyName("peakHypeFactor")] double PeakHypeFactor,
    [property: JsonPropertyName("projectedFantasyPoints")] double ProjectedFantasyPoints,
    [property: JsonPropertyName("projectedOrRealFantasyPoints")] double ProjectedOrRealFantasyPoints,
    [property: JsonPropertyName("doNotRefreshDate")] bool DoNotRefreshDate,
    [property: JsonPropertyName("doNotRefreshAnything")] bool DoNotRefreshAnything,
    [property: JsonPropertyName("useSimpleEligibility")] bool UseSimpleEligibility,
    [property: JsonPropertyName("addedByUser")] AddedByUser AddedByUser,
    [property: JsonPropertyName("error")] bool Error,
    [property: JsonPropertyName("numberOutstandingCorrections")] int NumberOutstandingCorrections
);

public record OverallSlot(
    [property: JsonPropertyName("bannedTags")] IReadOnlyList<string> BannedTags,
    [property: JsonPropertyName("requiredTags")] IReadOnlyList<object> RequiredTags,
    [property: JsonPropertyName("counterPick")] bool CounterPick
);

public record Player(
    [property: JsonPropertyName("leagueID")] string LeagueID,
    [property: JsonPropertyName("leagueName")] string LeagueName,
    [property: JsonPropertyName("userID")] string UserID,
    [property: JsonPropertyName("displayName")] string DisplayName,
    [property: JsonPropertyName("removable")] bool Removable,
    [property: JsonPropertyName("inviteID")] object InviteID,
    [property: JsonPropertyName("inviteName")] object InviteName,
    [property: JsonPropertyName("user")] User User,
    [property: JsonPropertyName("publisher")] Publisher Publisher,
    [property: JsonPropertyName("totalFantasyPoints")] double TotalFantasyPoints,
    [property: JsonPropertyName("projectedFantasyPoints")] double ProjectedFantasyPoints,
    [property: JsonPropertyName("previousYearWinner")] bool PreviousYearWinner,
    [property: JsonPropertyName("ranking")] int Ranking,
    [property: JsonPropertyName("projectedRanking")] int ProjectedRanking
);

public record PlayStatusClass(
    [property: JsonPropertyName("playStatus")] string PlayStatus,
    [property: JsonPropertyName("readyToSetDraftOrder")] bool ReadyToSetDraftOrder,
    [property: JsonPropertyName("readyToDraft")] bool ReadyToDraft,
    [property: JsonPropertyName("playStarted")] bool PlayStarted,
    [property: JsonPropertyName("draftIsActive")] bool DraftIsActive,
    [property: JsonPropertyName("draftIsPaused")] bool DraftIsPaused,
    [property: JsonPropertyName("draftFinished")] bool DraftFinished,
    [property: JsonPropertyName("draftingCounterPicks")] bool DraftingCounterPicks,
    [property: JsonPropertyName("startDraftErrors")] IReadOnlyList<object> StartDraftErrors
);

public record Publisher(
    [property: JsonPropertyName("publisherID")] string PublisherID,
    [property: JsonPropertyName("leagueID")] string LeagueID,
    [property: JsonPropertyName("userID")] string UserID,
    [property: JsonPropertyName("publisherName")] string PublisherName,
    [property: JsonPropertyName("publisherIcon")] object PublisherIcon,
    [property: JsonPropertyName("leagueName")] string LeagueName,
    [property: JsonPropertyName("playerName")] string PlayerName,
    [property: JsonPropertyName("year")] int Year,
    [property: JsonPropertyName("draftPosition")] int DraftPosition,
    [property: JsonPropertyName("autoDraft")] bool AutoDraft,
    [property: JsonPropertyName("averageCriticScore")] double? AverageCriticScore,
    [property: JsonPropertyName("totalFantasyPoints")] double TotalFantasyPoints,
    [property: JsonPropertyName("totalProjectedPoints")] double TotalProjectedPoints,
    [property: JsonPropertyName("budget")] int Budget,
    [property: JsonPropertyName("userIsInLeague")] bool UserIsInLeague,
    [property: JsonPropertyName("publicLeague")] bool PublicLeague,
    [property: JsonPropertyName("outstandingInvite")] bool OutstandingInvite,
    [property: JsonPropertyName("gamesReleased")] int GamesReleased,
    [property: JsonPropertyName("gamesWillRelease")] int GamesWillRelease,
    [property: JsonPropertyName("freeGamesDropped")] int FreeGamesDropped,
    [property: JsonPropertyName("willNotReleaseGamesDropped")] int WillNotReleaseGamesDropped,
    [property: JsonPropertyName("willReleaseGamesDropped")] int WillReleaseGamesDropped,
    [property: JsonPropertyName("freeDroppableGames")] int FreeDroppableGames,
    [property: JsonPropertyName("willNotReleaseDroppableGames")] int WillNotReleaseDroppableGames,
    [property: JsonPropertyName("willReleaseDroppableGames")] int WillReleaseDroppableGames
);

public record Publisher2(
    [property: JsonPropertyName("publisherID")] string PublisherID,
    [property: JsonPropertyName("leagueID")] string LeagueID,
    [property: JsonPropertyName("userID")] string UserID,
    [property: JsonPropertyName("publisherName")] string PublisherName,
    [property: JsonPropertyName("publisherIcon")] object PublisherIcon,
    [property: JsonPropertyName("publisherSlogan")] object PublisherSlogan,
    [property: JsonPropertyName("leagueName")] string LeagueName,
    [property: JsonPropertyName("playerName")] string PlayerName,
    [property: JsonPropertyName("year")] int Year,
    [property: JsonPropertyName("draftPosition")] int DraftPosition,
    [property: JsonPropertyName("autoDraft")] bool AutoDraft,
    [property: JsonPropertyName("games")] IReadOnlyList<Game> Games,
    [property: JsonPropertyName("formerGames")] IReadOnlyList<FormerGame> FormerGames,
    [property: JsonPropertyName("gameSlots")] IReadOnlyList<GameSlot> GameSlots,
    [property: JsonPropertyName("averageCriticScore")] double? AverageCriticScore,
    [property: JsonPropertyName("totalFantasyPoints")] double TotalFantasyPoints,
    [property: JsonPropertyName("totalProjectedPoints")] double TotalProjectedPoints,
    [property: JsonPropertyName("budget")] int Budget,
    [property: JsonPropertyName("nextToDraft")] bool NextToDraft,
    [property: JsonPropertyName("userIsInLeague")] bool UserIsInLeague,
    [property: JsonPropertyName("publicLeague")] bool PublicLeague,
    [property: JsonPropertyName("outstandingInvite")] bool OutstandingInvite,
    [property: JsonPropertyName("gamesReleased")] int GamesReleased,
    [property: JsonPropertyName("gamesWillRelease")] int GamesWillRelease,
    [property: JsonPropertyName("freeGamesDropped")] int FreeGamesDropped,
    [property: JsonPropertyName("willNotReleaseGamesDropped")] int WillNotReleaseGamesDropped,
    [property: JsonPropertyName("willReleaseGamesDropped")] int WillReleaseGamesDropped,
    [property: JsonPropertyName("freeDroppableGames")] int FreeDroppableGames,
    [property: JsonPropertyName("willNotReleaseDroppableGames")] int WillNotReleaseDroppableGames,
    [property: JsonPropertyName("willReleaseDroppableGames")] int WillReleaseDroppableGames,
    [property: JsonPropertyName("superDropsAvailable")] int SuperDropsAvailable
);

public record PublisherGame(
    [property: JsonPropertyName("publisherGameID")] string PublisherGameID,
    [property: JsonPropertyName("gameName")] string GameName,
    [property: JsonPropertyName("timestamp")] DateTime Timestamp,
    [property: JsonPropertyName("counterPick")] bool CounterPick,
    [property: JsonPropertyName("estimatedReleaseDate")] string EstimatedReleaseDate,
    [property: JsonPropertyName("releaseDate")] DateTime? ReleaseDate,
    [property: JsonPropertyName("fantasyPoints")] double? FantasyPoints,
    [property: JsonPropertyName("criticScore")] double? CriticScore,
    [property: JsonPropertyName("masterGame")] MasterGame MasterGame,
    [property: JsonPropertyName("overallDraftPosition")] int? OverallDraftPosition,
    [property: JsonPropertyName("bidAmount")] int? BidAmount,
    [property: JsonPropertyName("acquiredInTradeID")] object AcquiredInTradeID,
    [property: JsonPropertyName("slotNumber")] int SlotNumber,
    [property: JsonPropertyName("linked")] bool Linked,
    [property: JsonPropertyName("released")] bool Released,
    [property: JsonPropertyName("willRelease")] bool WillRelease,
    [property: JsonPropertyName("manualCriticScore")] bool ManualCriticScore,
    [property: JsonPropertyName("manualWillNotRelease")] bool ManualWillNotRelease,
    [property: JsonPropertyName("counterPicked")] bool CounterPicked,
    [property: JsonPropertyName("dropBlocked")] bool DropBlocked,
    [property: JsonPropertyName("removedTimestamp")] object RemovedTimestamp,
    [property: JsonPropertyName("removedNote")] object RemovedNote
);

public record RecentGame(
    [property: JsonPropertyName("masterGame")] MasterGame MasterGame,
    [property: JsonPropertyName("masterGameID")] string MasterGameID,
    [property: JsonPropertyName("gameName")] string GameName,
    [property: JsonPropertyName("estimatedReleaseDate")] string EstimatedReleaseDate,
    [property: JsonPropertyName("maximumReleaseDate")] string MaximumReleaseDate,
    [property: JsonPropertyName("releaseDate")] string ReleaseDate,
    [property: JsonPropertyName("leaguePublisherSets")] IReadOnlyList<LeaguePublisherSet> LeaguePublisherSets
);

public record RegularSlot(
    [property: JsonPropertyName("bannedTags")] IReadOnlyList<string> BannedTags,
    [property: JsonPropertyName("requiredTags")] IReadOnlyList<object> RequiredTags,
    [property: JsonPropertyName("counterPick")] bool CounterPick
);

public record Root(
    [property: JsonPropertyName("league")] League League,
    [property: JsonPropertyName("leagueID")] string LeagueID,
    [property: JsonPropertyName("year")] int Year,
    [property: JsonPropertyName("supportedYear")] SupportedYear SupportedYear,
    [property: JsonPropertyName("settings")] Settings Settings,
    [property: JsonPropertyName("slotInfo")] SlotInfo SlotInfo,
    [property: JsonPropertyName("unlinkedGameExists")] bool UnlinkedGameExists,
    [property: JsonPropertyName("userIsActive")] bool UserIsActive,
    [property: JsonPropertyName("players")] IReadOnlyList<Player> Players,
    [property: JsonPropertyName("publishers")] IReadOnlyList<Publisher> Publishers,
    [property: JsonPropertyName("eligibilityOverrides")] IReadOnlyList<EligibilityOverride> EligibilityOverrides,
    [property: JsonPropertyName("tagOverrides")] IReadOnlyList<object> TagOverrides,
    [property: JsonPropertyName("playStatus")] PlayStatusClass PlayStatus,
    [property: JsonPropertyName("managerMessages")] IReadOnlyList<object> ManagerMessages,
    [property: JsonPropertyName("publicBiddingGames")] object PublicBiddingGames,
    [property: JsonPropertyName("activeTrades")] IReadOnlyList<object> ActiveTrades,
    [property: JsonPropertyName("activeSpecialAuctions")] IReadOnlyList<object> ActiveSpecialAuctions,
    [property: JsonPropertyName("privatePublisherData")] object PrivatePublisherData,
    [property: JsonPropertyName("gameNews")] GameNews GameNews
);

public record Settings(
    [property: JsonPropertyName("leagueID")] string LeagueID,
    [property: JsonPropertyName("year")] int Year,
    [property: JsonPropertyName("standardGames")] int StandardGames,
    [property: JsonPropertyName("gamesToDraft")] int GamesToDraft,
    [property: JsonPropertyName("counterPicks")] int CounterPicks,
    [property: JsonPropertyName("counterPicksToDraft")] int CounterPicksToDraft,
    [property: JsonPropertyName("freeDroppableGames")] int FreeDroppableGames,
    [property: JsonPropertyName("willNotReleaseDroppableGames")] int WillNotReleaseDroppableGames,
    [property: JsonPropertyName("willReleaseDroppableGames")] int WillReleaseDroppableGames,
    [property: JsonPropertyName("unlimitedFreeDroppableGames")] bool UnlimitedFreeDroppableGames,
    [property: JsonPropertyName("unlimitedWillNotReleaseDroppableGames")] bool UnlimitedWillNotReleaseDroppableGames,
    [property: JsonPropertyName("unlimitedWillReleaseDroppableGames")] bool UnlimitedWillReleaseDroppableGames,
    [property: JsonPropertyName("dropOnlyDraftGames")] bool DropOnlyDraftGames,
    [property: JsonPropertyName("grantSuperDrops")] bool GrantSuperDrops,
    [property: JsonPropertyName("counterPicksBlockDrops")] bool CounterPicksBlockDrops,
    [property: JsonPropertyName("allowMoveIntoIneligible")] bool AllowMoveIntoIneligible,
    [property: JsonPropertyName("minimumBidAmount")] int MinimumBidAmount,
    [property: JsonPropertyName("draftSystem")] string DraftSystem,
    [property: JsonPropertyName("pickupSystem")] string PickupSystem,
    [property: JsonPropertyName("scoringSystem")] string ScoringSystem,
    [property: JsonPropertyName("tradingSystem")] string TradingSystem,
    [property: JsonPropertyName("tiebreakSystem")] string TiebreakSystem,
    [property: JsonPropertyName("releaseSystem")] string ReleaseSystem,
    [property: JsonPropertyName("counterPickDeadline")] string CounterPickDeadline,
    [property: JsonPropertyName("mightReleaseDroppableDate")] object MightReleaseDroppableDate,
    [property: JsonPropertyName("tags")] Tags Tags,
    [property: JsonPropertyName("specialGameSlots")] IReadOnlyList<object> SpecialGameSlots,
    [property: JsonPropertyName("hasSpecialSlots")] bool HasSpecialSlots
);

public record SlotInfo(
    [property: JsonPropertyName("overallSlot")] OverallSlot OverallSlot,
    [property: JsonPropertyName("regularSlot")] RegularSlot RegularSlot,
    [property: JsonPropertyName("specialSlots")] IReadOnlyList<object> SpecialSlots
);

public record SupportedYear(
    [property: JsonPropertyName("year")] int Year,
    [property: JsonPropertyName("openForCreation")] bool OpenForCreation,
    [property: JsonPropertyName("openForPlay")] bool OpenForPlay,
    [property: JsonPropertyName("startDate")] DateTime StartDate,
    [property: JsonPropertyName("finished")] bool Finished
);

public record Tags(
    [property: JsonPropertyName("banned")] IReadOnlyList<string> Banned,
    [property: JsonPropertyName("required")] IReadOnlyList<object> Required
);

public record UpcomingGame(
    [property: JsonPropertyName("masterGame")] MasterGame MasterGame,
    [property: JsonPropertyName("masterGameID")] string MasterGameID,
    [property: JsonPropertyName("gameName")] string GameName,
    [property: JsonPropertyName("estimatedReleaseDate")] string EstimatedReleaseDate,
    [property: JsonPropertyName("maximumReleaseDate")] string MaximumReleaseDate,
    [property: JsonPropertyName("releaseDate")] string ReleaseDate,
    [property: JsonPropertyName("leaguePublisherSets")] IReadOnlyList<LeaguePublisherSet> LeaguePublisherSets
);

public record User(
    [property: JsonPropertyName("leagueID")] string LeagueID,
    [property: JsonPropertyName("leagueName")] string LeagueName,
    [property: JsonPropertyName("userID")] string UserID,
    [property: JsonPropertyName("displayName")] string DisplayName,
    [property: JsonPropertyName("removable")] bool Removable
);

