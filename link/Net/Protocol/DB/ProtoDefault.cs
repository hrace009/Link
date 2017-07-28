
      using System;
      using Link.IO;
      using Link.Net.Protocol.Core;

      namespace Link.Net.Protocol.Known.Default
      {
        public class ProtoBuilderDefault : ProtoGenericTable<ProtoBuilderDefault>
         {
        public static readonly ProtoBuilderDefault Instance = new ProtoBuilderDefault();

        public ProtoBuilderDefault()
        {
            Register<Challenge, ChallengeX>(new PacketBaseInformation(id: 1, maximumSize: 64));
Register<KeyExchange, KeyExchangeX>(new PacketBaseInformation(id: 2, maximumSize: 32));
Register<Response, ResponseX>(new PacketBaseInformation(id: 3, maximumSize: 512));
Register<OnlineAnnounce, OnlineAnnounceX>(new PacketBaseInformation(id: 4, maximumSize: 64));
Register<ErrorInfo, ErrorInfoX>(new PacketBaseInformation(id: 5, maximumSize: 256));
Register<StatusAnnounce, StatusAnnounceX>(new PacketBaseInformation(id: 6, maximumSize: 32));
Register<RoleStatusAnnounce, RoleStatusAnnounceX>(new PacketBaseInformation(id: 7, maximumSize: 64));
Register<KickoutUser, KickoutUserX>(new PacketBaseInformation(id: 10, maximumSize: 32));
Register<GameDataSend, GameDataSendX>(new PacketBaseInformation(id: 34, maximumSize: 65535));
Register<ReportIP, ReportIPX>(new PacketBaseInformation(id: 35, maximumSize: 64));
Register<UpdateRemainTime, UpdateRemainTimeX>(new PacketBaseInformation(id: 36, maximumSize: 64));
Register<StatInfoVital, StatInfoVitalX>(new PacketBaseInformation(id: 59, maximumSize: 1024));
Register<StatInfo, StatInfoX>(new PacketBaseInformation(id: 60, maximumSize: 1024));
Register<RemoteLogVital, RemoteLogVitalX>(new PacketBaseInformation(id: 61, maximumSize: 1024));
Register<RemoteLog, RemoteLogX>(new PacketBaseInformation(id: 62, maximumSize: 1024));
Register<PlayerKickout, PlayerKickoutX>(new PacketBaseInformation(id: 63, maximumSize: 32));
Register<PlayerKickout_Re, PlayerKickout_ReX>(new PacketBaseInformation(id: 64, maximumSize: 32));
Register<PlayerLogin, PlayerLoginX>(new PacketBaseInformation(id: 65, maximumSize: 1024));
Register<PlayerLogin_Re, PlayerLogin_ReX>(new PacketBaseInformation(id: 66, maximumSize: 32));
Register<PlayerOffline, PlayerOfflineX>(new PacketBaseInformation(id: 67, maximumSize: 32));
Register<PlayerOffline_Re, PlayerOffline_ReX>(new PacketBaseInformation(id: 68, maximumSize: 32));
Register<PlayerLogout, PlayerLogoutX>(new PacketBaseInformation(id: 69, maximumSize: 32));
Register<SelectRole, SelectRoleX>(new PacketBaseInformation(id: 70, maximumSize: 32));
Register<SelectRole_Re, SelectRole_ReX>(new PacketBaseInformation(id: 71, maximumSize: 1024));
Register<EnterWorld, EnterWorldX>(new PacketBaseInformation(id: 72, maximumSize: 32));
Register<AnnounceProviderID, AnnounceProviderIDX>(new PacketBaseInformation(id: 73, maximumSize: 64));
Register<S2CGamedataSend, S2CGamedataSendX>(new PacketBaseInformation(id: 74, maximumSize: 65535));
Register<C2SGamedataSend, C2SGamedataSendX>(new PacketBaseInformation(id: 75, maximumSize: 65535));
Register<S2CMulticast, S2CMulticastX>(new PacketBaseInformation(id: 77, maximumSize: 102400));
Register<S2CBroadcast, S2CBroadcastX>(new PacketBaseInformation(id: 78, maximumSize: 102400));
Register<PublicChat, PublicChatX>(new PacketBaseInformation(id: 79, maximumSize: 1024));
Register<ChatMessage, ChatMessageX>(new PacketBaseInformation(id: 80, maximumSize: 1024));
Register<ChatMultiCast, ChatMultiCastX>(new PacketBaseInformation(id: 81, maximumSize: 102400));
Register<RoleList, RoleListX>(new PacketBaseInformation(id: 82, maximumSize: 32));
Register<RoleList_Re, RoleList_ReX>(new PacketBaseInformation(id: 83, maximumSize: 8192));
Register<CreateRole, CreateRoleX>(new PacketBaseInformation(id: 84, maximumSize: 8192));
Register<CreateRole_Re, CreateRole_ReX>(new PacketBaseInformation(id: 85, maximumSize: 8192));
Register<DeleteRole, DeleteRoleX>(new PacketBaseInformation(id: 86, maximumSize: 32));
Register<DeleteRole_Re, DeleteRole_ReX>(new PacketBaseInformation(id: 87, maximumSize: 32));
Register<UndoDeleteRole, UndoDeleteRoleX>(new PacketBaseInformation(id: 88, maximumSize: 32));
Register<UndoDeleteRole_Re, UndoDeleteRole_ReX>(new PacketBaseInformation(id: 89, maximumSize: 32));
Register<Keepalive, KeepaliveX>(new PacketBaseInformation(id: 90, maximumSize: 16));
Register<PlayerBaseInfo, PlayerBaseInfoX>(new PacketBaseInformation(id: 91, maximumSize: 2048));
Register<PlayerBaseInfo_Re, PlayerBaseInfo_ReX>(new PacketBaseInformation(id: 92, maximumSize: 1536));
Register<PlayerHeartBeat, PlayerHeartBeatX>(new PacketBaseInformation(id: 93, maximumSize: 32));
Register<ChatSingleCast, ChatSingleCastX>(new PacketBaseInformation(id: 94, maximumSize: 1024));
Register<PlayerStatusSync, PlayerStatusSyncX>(new PacketBaseInformation(id: 95, maximumSize: 64));
Register<PrivateChat, PrivateChatX>(new PacketBaseInformation(id: 96, maximumSize: 1024));
Register<PlayerBaseInfoCRC, PlayerBaseInfoCRCX>(new PacketBaseInformation(id: 98, maximumSize: 512));
Register<PlayerBaseInfoCRC_Re, PlayerBaseInfoCRC_ReX>(new PacketBaseInformation(id: 99, maximumSize: 512));
Register<SetCustomData, SetCustomDataX>(new PacketBaseInformation(id: 100, maximumSize: 1536));
Register<SetCustomData_Re, SetCustomData_ReX>(new PacketBaseInformation(id: 101, maximumSize: 64));
Register<SetUIConfig, SetUIConfigX>(new PacketBaseInformation(id: 102, maximumSize: 4096));
Register<SetUIConfig_Re, SetUIConfig_ReX>(new PacketBaseInformation(id: 103, maximumSize: 64));
Register<GetUIConfig, GetUIConfigX>(new PacketBaseInformation(id: 104, maximumSize: 64));
Register<GetUIConfig_Re, GetUIConfig_ReX>(new PacketBaseInformation(id: 105, maximumSize: 4096));
Register<DisconnectPlayer, DisconnectPlayerX>(new PacketBaseInformation(id: 106, maximumSize: 64));
Register<GetPlayerBriefInfo, GetPlayerBriefInfoX>(new PacketBaseInformation(id: 107, maximumSize: 2048));
Register<GetPlayerBriefInfo_Re, GetPlayerBriefInfo_ReX>(new PacketBaseInformation(id: 108, maximumSize: 16384));
Register<PlayerStatusAnnounce, PlayerStatusAnnounceX>(new PacketBaseInformation(id: 109, maximumSize: 204800));
Register<QueryPlayerStatus, QueryPlayerStatusX>(new PacketBaseInformation(id: 110, maximumSize: 1024));
Register<GetTaskData, GetTaskDataX>(new PacketBaseInformation(id: 111, maximumSize: 8192));
Register<GetTaskData_Re, GetTaskData_ReX>(new PacketBaseInformation(id: 112, maximumSize: 8192));
Register<SetTaskData, SetTaskDataX>(new PacketBaseInformation(id: 113, maximumSize: 288));
Register<SetTaskData_Re, SetTaskData_ReX>(new PacketBaseInformation(id: 114, maximumSize: 32));
Register<GetCustomData, GetCustomDataX>(new PacketBaseInformation(id: 116, maximumSize: 2048));
Register<GetCustomData_Re, GetCustomData_ReX>(new PacketBaseInformation(id: 117, maximumSize: 1536));
Register<GetPlayerIdByName, GetPlayerIdByNameX>(new PacketBaseInformation(id: 118, maximumSize: 64));
Register<GetPlayerIdByName_Re, GetPlayerIdByName_ReX>(new PacketBaseInformation(id: 119, maximumSize: 64));
Register<ChatBroadCast, ChatBroadCastX>(new PacketBaseInformation(id: 120, maximumSize: 10240));
Register<AnnounceGM, AnnounceGMX>(new PacketBaseInformation(id: 121, maximumSize: 512));
Register<GMPrivilegeChange, GMPrivilegeChangeX>(new PacketBaseInformation(id: 122, maximumSize: 32));
Register<AnnounceForbidInfo, AnnounceForbidInfoX>(new PacketBaseInformation(id: 123, maximumSize: 384));
Register<FaceModify, FaceModifyX>(new PacketBaseInformation(id: 125, maximumSize: 2048));
Register<FaceModifyCancel, FaceModifyCancelX>(new PacketBaseInformation(id: 126, maximumSize: 32));
Register<FaceModify_Re, FaceModify_ReX>(new PacketBaseInformation(id: 127, maximumSize: 128));
Register<SetHelpStates, SetHelpStatesX>(new PacketBaseInformation(id: 128, maximumSize: 4096));
Register<SetHelpStates_Re, SetHelpStates_ReX>(new PacketBaseInformation(id: 129, maximumSize: 64));
Register<GetHelpStates, GetHelpStatesX>(new PacketBaseInformation(id: 130, maximumSize: 64));
Register<GetHelpStates_Re, GetHelpStates_ReX>(new PacketBaseInformation(id: 131, maximumSize: 8192));
Register<AnnounceServerAttribute, AnnounceServerAttributeX>(new PacketBaseInformation(id: 132, maximumSize: 64));
Register<WorldChat, WorldChatX>(new PacketBaseInformation(id: 133, maximumSize: 1024));
Register<SetChatEmotion, SetChatEmotionX>(new PacketBaseInformation(id: 134, maximumSize: 32));
Register<AnnounceChallengeAlgo, AnnounceChallengeAlgoX>(new PacketBaseInformation(id: 136, maximumSize: 16));
Register<AnnounceAuthdVersion, AnnounceAuthdVersionX>(new PacketBaseInformation(id: 137, maximumSize: 16));
Register<UserCoupon, UserCouponX>(new PacketBaseInformation(id: 138, maximumSize: 16));
Register<UserCoupon_Re, UserCoupon_ReX>(new PacketBaseInformation(id: 139, maximumSize: 32));
Register<UserCouponExchange, UserCouponExchangeX>(new PacketBaseInformation(id: 140, maximumSize: 16));
Register<UserCouponExchange_Re, UserCouponExchange_ReX>(new PacketBaseInformation(id: 141, maximumSize: 32));
Register<AddCashNotify, AddCashNotifyX>(new PacketBaseInformation(id: 142, maximumSize: 32));
Register<AccountLoginRecord, AccountLoginRecordX>(new PacketBaseInformation(id: 143, maximumSize: 32));
Register<UserAddCash, UserAddCashX>(new PacketBaseInformation(id: 144, maximumSize: 128));
Register<UserAddCash_Re, UserAddCash_ReX>(new PacketBaseInformation(id: 145, maximumSize: 16));
Register<SynMutaData, SynMutaDataX>(new PacketBaseInformation(id: 146, maximumSize: 32));
Register<SSOGetTicket, SSOGetTicketX>(new PacketBaseInformation(id: 147, maximumSize: 2048));
Register<SSOGetTicket_Re, SSOGetTicket_ReX>(new PacketBaseInformation(id: 148, maximumSize: 2048));
Register<QPAnnounceDiscount, QPAnnounceDiscountX>(new PacketBaseInformation(id: 149, maximumSize: 1024));
Register<QPGetActivatedServices, QPGetActivatedServicesX>(new PacketBaseInformation(id: 150, maximumSize: 512));
Register<QPGetActivatedServices_Re, QPGetActivatedServices_ReX>(new PacketBaseInformation(id: 151, maximumSize: 1024));
Register<QPAddCash, QPAddCashX>(new PacketBaseInformation(id: 152, maximumSize: 512));
Register<QPAddCash_Re, QPAddCash_ReX>(new PacketBaseInformation(id: 153, maximumSize: 512));
Register<ReportChat, ReportChatX>(new PacketBaseInformation(id: 156, maximumSize: 1024));
Register<CashMoneyExchangeNotify, CashMoneyExchangeNotifyX>(new PacketBaseInformation(id: 157, maximumSize: 64));
Register<PlayerNameUpdate, PlayerNameUpdateX>(new PacketBaseInformation(id: 158, maximumSize: 4096));
Register<MobileServerRegister, MobileServerRegisterX>(new PacketBaseInformation(id: 159, maximumSize: 64));
Register<ServerForbidNotify, ServerForbidNotifyX>(new PacketBaseInformation(id: 160, maximumSize: 1024));
Register<PlayerAccuse, PlayerAccuseX>(new PacketBaseInformation(id: 161, maximumSize: 1024));
Register<PlayerAccuse_Re, PlayerAccuse_ReX>(new PacketBaseInformation(id: 162, maximumSize: 1024));
Register<ServerTriggerNotify, ServerTriggerNotifyX>(new PacketBaseInformation(id: 163, maximumSize: 1024));
Register<AddFriend, AddFriendX>(new PacketBaseInformation(id: 202, maximumSize: 128));
Register<AddFriend_Re, AddFriend_ReX>(new PacketBaseInformation(id: 203, maximumSize: 128));
Register<GetFriends, GetFriendsX>(new PacketBaseInformation(id: 206, maximumSize: 4096));
Register<GetFriends_Re, GetFriends_ReX>(new PacketBaseInformation(id: 207, maximumSize: 8192));
Register<SetGroupName, SetGroupNameX>(new PacketBaseInformation(id: 208, maximumSize: 64));
Register<SetGroupName_Re, SetGroupName_ReX>(new PacketBaseInformation(id: 209, maximumSize: 128));
Register<SetFriendGroup, SetFriendGroupX>(new PacketBaseInformation(id: 210, maximumSize: 32));
Register<SetFriendGroup_Re, SetFriendGroup_ReX>(new PacketBaseInformation(id: 211, maximumSize: 64));
Register<DelFriend, DelFriendX>(new PacketBaseInformation(id: 212, maximumSize: 32));
Register<DelFriend_Re, DelFriend_ReX>(new PacketBaseInformation(id: 213, maximumSize: 32));
Register<FriendStatus, FriendStatusX>(new PacketBaseInformation(id: 214, maximumSize: 32));
Register<GetSavedMsg, GetSavedMsgX>(new PacketBaseInformation(id: 217, maximumSize: 32));
Register<GetSavedMsg_Re, GetSavedMsg_ReX>(new PacketBaseInformation(id: 218, maximumSize: 8192));
Register<ChatRoomCreate, ChatRoomCreateX>(new PacketBaseInformation(id: 219, maximumSize: 48));
Register<ChatRoomCreate_Re, ChatRoomCreate_ReX>(new PacketBaseInformation(id: 220, maximumSize: 48));
Register<ChatRoomInvite, ChatRoomInviteX>(new PacketBaseInformation(id: 221, maximumSize: 128));
Register<ChatRoomInvite_Re, ChatRoomInvite_ReX>(new PacketBaseInformation(id: 222, maximumSize: 32));
Register<ChatRoomJoin, ChatRoomJoinX>(new PacketBaseInformation(id: 223, maximumSize: 48));
Register<ChatRoomJoin_Re, ChatRoomJoin_ReX>(new PacketBaseInformation(id: 224, maximumSize: 1024));
Register<ChatRoomLeave, ChatRoomLeaveX>(new PacketBaseInformation(id: 225, maximumSize: 16));
Register<ChatRoomExpel, ChatRoomExpelX>(new PacketBaseInformation(id: 226, maximumSize: 32));
Register<ChatRoomSpeak, ChatRoomSpeakX>(new PacketBaseInformation(id: 227, maximumSize: 256));
Register<ChatRoomList, ChatRoomListX>(new PacketBaseInformation(id: 228, maximumSize: 16));
Register<ChatRoomList_Re, ChatRoomList_ReX>(new PacketBaseInformation(id: 229, maximumSize: 1024));
Register<FriendExtList, FriendExtListX>(new PacketBaseInformation(id: 230, maximumSize: 16384));
Register<DBFriendExtList, DBFriendExtListX>(new PacketBaseInformation(id: 231, maximumSize: 8192));
Register<DBFriendExtList_Re, DBFriendExtList_ReX>(new PacketBaseInformation(id: 232, maximumSize: 8192));
Register<SendAUMail, SendAUMailX>(new PacketBaseInformation(id: 233, maximumSize: 1024));
Register<SendAUMail_Re, SendAUMail_ReX>(new PacketBaseInformation(id: 234, maximumSize: 1024));
Register<AUMailSended, AUMailSendedX>(new PacketBaseInformation(id: 235, maximumSize: 1024));
Register<GMOnlineNum, GMOnlineNumX>(new PacketBaseInformation(id: 350, maximumSize: 64));
Register<GMOnlineNum_Re, GMOnlineNum_ReX>(new PacketBaseInformation(id: 351, maximumSize: 64));
Register<GMListOnlineUser, GMListOnlineUserX>(new PacketBaseInformation(id: 352, maximumSize: 64));
Register<GMListOnlineUser_Re, GMListOnlineUser_ReX>(new PacketBaseInformation(id: 353, maximumSize: 102400));
Register<GMKickoutUser, GMKickoutUserX>(new PacketBaseInformation(id: 354, maximumSize: 256));
Register<GMKickoutUser_Re, GMKickoutUser_ReX>(new PacketBaseInformation(id: 355, maximumSize: 64));
Register<GMShutup, GMShutupX>(new PacketBaseInformation(id: 356, maximumSize: 256));
Register<GMShutup_Re, GMShutup_ReX>(new PacketBaseInformation(id: 357, maximumSize: 64));
Register<GMRestartServer, GMRestartServerX>(new PacketBaseInformation(id: 358, maximumSize: 64));
Register<GMRestartServer_Re, GMRestartServer_ReX>(new PacketBaseInformation(id: 359, maximumSize: 64));
Register<GMKickoutRole, GMKickoutRoleX>(new PacketBaseInformation(id: 360, maximumSize: 256));
Register<GMKickoutRole_Re, GMKickoutRole_ReX>(new PacketBaseInformation(id: 361, maximumSize: 64));
Register<GMShutupRole, GMShutupRoleX>(new PacketBaseInformation(id: 362, maximumSize: 256));
Register<GMShutupRole_Re, GMShutupRole_ReX>(new PacketBaseInformation(id: 363, maximumSize: 64));
Register<GMToggleChat, GMToggleChatX>(new PacketBaseInformation(id: 364, maximumSize: 64));
Register<GMToggleChat_Re, GMToggleChat_ReX>(new PacketBaseInformation(id: 365, maximumSize: 64));
Register<GMForbidRole, GMForbidRoleX>(new PacketBaseInformation(id: 366, maximumSize: 256));
Register<GMForbidRole_Re, GMForbidRole_ReX>(new PacketBaseInformation(id: 367, maximumSize: 64));
Register<Report2GM, Report2GMX>(new PacketBaseInformation(id: 368, maximumSize: 512));
Register<Report2GM_Re, Report2GM_ReX>(new PacketBaseInformation(id: 369, maximumSize: 64));
Register<Complain2GM, Complain2GMX>(new PacketBaseInformation(id: 370, maximumSize: 256));
Register<Complain2GM_Re, Complain2GM_ReX>(new PacketBaseInformation(id: 371, maximumSize: 64));
Register<AnnounceLinkType, AnnounceLinkTypeX>(new PacketBaseInformation(id: 372, maximumSize: 32));
Register<SetMaxOnlineNum, SetMaxOnlineNumX>(new PacketBaseInformation(id: 373, maximumSize: 64));
Register<SetMaxOnlineNum_Re, SetMaxOnlineNum_ReX>(new PacketBaseInformation(id: 374, maximumSize: 64));
Register<GMForbidSellPoint, GMForbidSellPointX>(new PacketBaseInformation(id: 378, maximumSize: 64));
Register<GMForbidSellPoint_Re, GMForbidSellPoint_ReX>(new PacketBaseInformation(id: 379, maximumSize: 64));
Register<GMControlGame, GMControlGameX>(new PacketBaseInformation(id: 380, maximumSize: 256));
Register<GMControlGame_Re, GMControlGame_ReX>(new PacketBaseInformation(id: 381, maximumSize: 4096));
Register<GMGetPlayerConsumeInfo, GMGetPlayerConsumeInfoX>(new PacketBaseInformation(id: 382, maximumSize: 1024));
Register<GMGetPlayerConsumeInfo_Re, GMGetPlayerConsumeInfo_ReX>(new PacketBaseInformation(id: 383, maximumSize: 8192));
Register<GMSetTimelessAutoLock, GMSetTimelessAutoLockX>(new PacketBaseInformation(id: 385, maximumSize: 32));
Register<GMSetTimelessAutoLock_Re, GMSetTimelessAutoLock_ReX>(new PacketBaseInformation(id: 386, maximumSize: 32));
Register<IWebAutolockGet, IWebAutolockGetX>(new PacketBaseInformation(id: 387, maximumSize: 16));
Register<IWebAutolockGet_Re, IWebAutolockGet_ReX>(new PacketBaseInformation(id: 388, maximumSize: 128));
Register<IWebAutolockSet, IWebAutolockSetX>(new PacketBaseInformation(id: 389, maximumSize: 16));
Register<IWebAutolockSet_Re, IWebAutolockSet_ReX>(new PacketBaseInformation(id: 390, maximumSize: 128));
Register<StockCommission, StockCommissionX>(new PacketBaseInformation(id: 401, maximumSize: 64));
Register<StockTransaction, StockTransactionX>(new PacketBaseInformation(id: 402, maximumSize: 131072));
Register<StockBill, StockBillX>(new PacketBaseInformation(id: 405, maximumSize: 64));
Register<StockBill_Re, StockBill_ReX>(new PacketBaseInformation(id: 406, maximumSize: 4096));
Register<StockAccount, StockAccountX>(new PacketBaseInformation(id: 407, maximumSize: 64));
Register<StockAccount_Re, StockAccount_ReX>(new PacketBaseInformation(id: 408, maximumSize: 4096));
Register<StockCommission_Re, StockCommission_ReX>(new PacketBaseInformation(id: 409, maximumSize: 4096));
Register<StockTransaction_Re, StockTransaction_ReX>(new PacketBaseInformation(id: 410, maximumSize: 64));
Register<StockCancel, StockCancelX>(new PacketBaseInformation(id: 411, maximumSize: 64));
Register<StockCancel_Re, StockCancel_ReX>(new PacketBaseInformation(id: 412, maximumSize: 64));
Register<AccountingRequest, AccountingRequestX>(new PacketBaseInformation(id: 503, maximumSize: 128));
Register<AccountingResponse, AccountingResponseX>(new PacketBaseInformation(id: 504, maximumSize: 32));
Register<AnnounceZoneid, AnnounceZoneidX>(new PacketBaseInformation(id: 505, maximumSize: 32));
Register<QueryUserPrivilege, QueryUserPrivilegeX>(new PacketBaseInformation(id: 506, maximumSize: 32));
Register<QueryUserPrivilege_Re, QueryUserPrivilege_ReX>(new PacketBaseInformation(id: 507, maximumSize: 512));
Register<QueryUserForbid, QueryUserForbidX>(new PacketBaseInformation(id: 508, maximumSize: 32));
Register<QueryUserForbid_Re, QueryUserForbid_ReX>(new PacketBaseInformation(id: 509, maximumSize: 4096));
Register<QueryRewardType, QueryRewardTypeX>(new PacketBaseInformation(id: 510, maximumSize: 64));
Register<QueryRewardType_Re, QueryRewardType_ReX>(new PacketBaseInformation(id: 511, maximumSize: 64));
Register<QueryGameServerAttr, QueryGameServerAttrX>(new PacketBaseInformation(id: 512, maximumSize: 32));
Register<QueryGameServerAttr_Re, QueryGameServerAttr_ReX>(new PacketBaseInformation(id: 513, maximumSize: 2048));
Register<AddCash, AddCashX>(new PacketBaseInformation(id: 515, maximumSize: 256));
Register<AddCash_Re, AddCash_ReX>(new PacketBaseInformation(id: 516, maximumSize: 256));
Register<UseCash, UseCashX>(new PacketBaseInformation(id: 517, maximumSize: 128));
Register<UseCash_Re, UseCash_ReX>(new PacketBaseInformation(id: 518, maximumSize: 128));
Register<VerifyMaster, VerifyMasterX>(new PacketBaseInformation(id: 519, maximumSize: 128));
Register<VerifyMaster_Re, VerifyMaster_ReX>(new PacketBaseInformation(id: 520, maximumSize: 128));
Register<DebugAddCash, DebugAddCashX>(new PacketBaseInformation(id: 521, maximumSize: 256));
Register<AnnounceZoneid2, AnnounceZoneid2X>(new PacketBaseInformation(id: 523, maximumSize: 32));
Register<AnnounceZoneid3, AnnounceZoneid3X>(new PacketBaseInformation(id: 527, maximumSize: 64));
Register<NetBarAnnounce, NetBarAnnounceX>(new PacketBaseInformation(id: 529, maximumSize: 1024));
Register<CertRequest, CertRequestX>(new PacketBaseInformation(id: 545, maximumSize: 8192));
Register<CertAnswer, CertAnswerX>(new PacketBaseInformation(id: 546, maximumSize: 8192));
Register<CertKey, CertKeyX>(new PacketBaseInformation(id: 547, maximumSize: 8192));
Register<CertFinish, CertFinishX>(new PacketBaseInformation(id: 548, maximumSize: 8192));
Register<MatrixChallenge, MatrixChallengeX>(new PacketBaseInformation(id: 551, maximumSize: 64));
Register<MatrixResponse, MatrixResponseX>(new PacketBaseInformation(id: 552, maximumSize: 64));
Register<MatrixFailure, MatrixFailureX>(new PacketBaseInformation(id: 553, maximumSize: 64));
Register<AddictionControl, AddictionControlX>(new PacketBaseInformation(id: 556, maximumSize: 512));
Register<SellPoint, SellPointX>(new PacketBaseInformation(id: 601, maximumSize: 128));
Register<SellPoint_Re, SellPoint_ReX>(new PacketBaseInformation(id: 602, maximumSize: 512));
Register<GetSellList, GetSellListX>(new PacketBaseInformation(id: 603, maximumSize: 128));
Register<GetSellList_Re, GetSellList_ReX>(new PacketBaseInformation(id: 604, maximumSize: 102400));
Register<SellCancel, SellCancelX>(new PacketBaseInformation(id: 605, maximumSize: 128));
Register<SellCancel_Re, SellCancel_ReX>(new PacketBaseInformation(id: 606, maximumSize: 128));
Register<BuyPoint, BuyPointX>(new PacketBaseInformation(id: 607, maximumSize: 128));
Register<BuyPoint_Re, BuyPoint_ReX>(new PacketBaseInformation(id: 608, maximumSize: 128));
Register<SyncSellInfo, SyncSellInfoX>(new PacketBaseInformation(id: 609, maximumSize: 128));
Register<AnnounceSellResult, AnnounceSellResultX>(new PacketBaseInformation(id: 610, maximumSize: 128));
Register<TransBuyPoint, TransBuyPointX>(new PacketBaseInformation(id: 616, maximumSize: 512));
Register<TransBuyPoint_Re, TransBuyPoint_ReX>(new PacketBaseInformation(id: 617, maximumSize: 512));
Register<FindSellPointInfo, FindSellPointInfoX>(new PacketBaseInformation(id: 619, maximumSize: 512));
Register<FindSellPointInfo_Re, FindSellPointInfo_ReX>(new PacketBaseInformation(id: 620, maximumSize: 102400));
Register<DomainLogin, DomainLoginX>(new PacketBaseInformation(id: 700, maximumSize: 128));
Register<DomainValidate, DomainValidateX>(new PacketBaseInformation(id: 770, maximumSize: 1024));
Register<DomainCmd, DomainCmdX>(new PacketBaseInformation(id: 771, maximumSize: 1024));
Register<DomainCmd_Re, DomainCmd_ReX>(new PacketBaseInformation(id: 772, maximumSize: 65535));
Register<AutolockSet, AutolockSetX>(new PacketBaseInformation(id: 782, maximumSize: 128));
Register<AutolockSet_Re, AutolockSet_ReX>(new PacketBaseInformation(id: 783, maximumSize: 128));
Register<AutolockChanged, AutolockChangedX>(new PacketBaseInformation(id: 785, maximumSize: 32));
Register<AuctionOpen, AuctionOpenX>(new PacketBaseInformation(id: 800, maximumSize: 131072));
Register<AuctionOpen_Re, AuctionOpen_ReX>(new PacketBaseInformation(id: 801, maximumSize: 128));
Register<AuctionBid, AuctionBidX>(new PacketBaseInformation(id: 802, maximumSize: 32));
Register<AuctionBid_Re, AuctionBid_ReX>(new PacketBaseInformation(id: 803, maximumSize: 128));
Register<AuctionList, AuctionListX>(new PacketBaseInformation(id: 804, maximumSize: 32));
Register<AuctionList_Re, AuctionList_ReX>(new PacketBaseInformation(id: 805, maximumSize: 1024));
Register<AuctionClose, AuctionCloseX>(new PacketBaseInformation(id: 806, maximumSize: 32));
Register<AuctionClose_Re, AuctionClose_ReX>(new PacketBaseInformation(id: 807, maximumSize: 32));
Register<AuctionGet, AuctionGetX>(new PacketBaseInformation(id: 808, maximumSize: 64));
Register<AuctionGet_Re, AuctionGet_ReX>(new PacketBaseInformation(id: 809, maximumSize: 2048));
Register<AuctionAttendList, AuctionAttendListX>(new PacketBaseInformation(id: 816, maximumSize: 32));
Register<AuctionAttendList_Re, AuctionAttendList_ReX>(new PacketBaseInformation(id: 817, maximumSize: 2048));
Register<AuctionExitBid, AuctionExitBidX>(new PacketBaseInformation(id: 818, maximumSize: 32));
Register<AuctionExitBid_Re, AuctionExitBid_ReX>(new PacketBaseInformation(id: 819, maximumSize: 32));
Register<AuctionGetItem, AuctionGetItemX>(new PacketBaseInformation(id: 820, maximumSize: 64));
Register<AuctionGetItem_Re, AuctionGetItem_ReX>(new PacketBaseInformation(id: 821, maximumSize: 8192));
Register<SendAuctionBid, SendAuctionBidX>(new PacketBaseInformation(id: 822, maximumSize: 131072));
Register<AuctionListUpdate, AuctionListUpdateX>(new PacketBaseInformation(id: 823, maximumSize: 128));
Register<AuctionListUpdate_Re, AuctionListUpdate_ReX>(new PacketBaseInformation(id: 824, maximumSize: 1024));
Register<BattleGetMap, BattleGetMapX>(new PacketBaseInformation(id: 850, maximumSize: 16));
Register<BattleGetMap_Re, BattleGetMap_ReX>(new PacketBaseInformation(id: 851, maximumSize: 2048));
Register<BattleChallenge, BattleChallengeX>(new PacketBaseInformation(id: 852, maximumSize: 64));
Register<BattleChallenge_Re, BattleChallenge_ReX>(new PacketBaseInformation(id: 853, maximumSize: 64));
Register<BattleChallengeMap, BattleChallengeMapX>(new PacketBaseInformation(id: 854, maximumSize: 32));
Register<BattleChallengeMap_Re, BattleChallengeMap_ReX>(new PacketBaseInformation(id: 855, maximumSize: 2048));
Register<BattleServerRegister, BattleServerRegisterX>(new PacketBaseInformation(id: 856, maximumSize: 64));
Register<BattleStart, BattleStartX>(new PacketBaseInformation(id: 857, maximumSize: 64));
Register<BattleStart_Re, BattleStart_ReX>(new PacketBaseInformation(id: 858, maximumSize: 64));
Register<BattleEnter, BattleEnterX>(new PacketBaseInformation(id: 860, maximumSize: 32));
Register<BattleEnter_Re, BattleEnter_ReX>(new PacketBaseInformation(id: 861, maximumSize: 32));
Register<BattleEnterNotice, BattleEnterNoticeX>(new PacketBaseInformation(id: 862, maximumSize: 32));
Register<BattleStatus, BattleStatusX>(new PacketBaseInformation(id: 866, maximumSize: 16));
Register<BattleStatus_Re, BattleStatus_ReX>(new PacketBaseInformation(id: 867, maximumSize: 128));
Register<SendBattleChallenge, SendBattleChallengeX>(new PacketBaseInformation(id: 869, maximumSize: 131072));
Register<BattleMapNotice, BattleMapNoticeX>(new PacketBaseInformation(id: 870, maximumSize: 2048));
Register<DebugCommand, DebugCommandX>(new PacketBaseInformation(id: 873, maximumSize: 256));
Register<BattleFactionNotice, BattleFactionNoticeX>(new PacketBaseInformation(id: 874, maximumSize: 512));
Register<PShopCreate, PShopCreateX>(new PacketBaseInformation(id: 900, maximumSize: 131072));
Register<PShopCreate_Re, PShopCreate_ReX>(new PacketBaseInformation(id: 901, maximumSize: 32));
Register<PShopBuy, PShopBuyX>(new PacketBaseInformation(id: 902, maximumSize: 1024));
Register<PShopBuy_Re, PShopBuy_ReX>(new PacketBaseInformation(id: 903, maximumSize: 1024));
Register<PShopSell, PShopSellX>(new PacketBaseInformation(id: 904, maximumSize: 131072));
Register<PShopSell_Re, PShopSell_ReX>(new PacketBaseInformation(id: 905, maximumSize: 131072));
Register<PShopCancelGoods, PShopCancelGoodsX>(new PacketBaseInformation(id: 906, maximumSize: 131072));
Register<PShopCancelGoods_Re, PShopCancelGoods_ReX>(new PacketBaseInformation(id: 907, maximumSize: 1024));
Register<PShopPlayerBuy, PShopPlayerBuyX>(new PacketBaseInformation(id: 908, maximumSize: 131072));
Register<PShopPlayerBuy_Re, PShopPlayerBuy_ReX>(new PacketBaseInformation(id: 909, maximumSize: 131072));
Register<PShopPlayerSell, PShopPlayerSellX>(new PacketBaseInformation(id: 910, maximumSize: 131072));
Register<PShopPlayerSell_Re, PShopPlayerSell_ReX>(new PacketBaseInformation(id: 911, maximumSize: 131072));
Register<PShopSetType, PShopSetTypeX>(new PacketBaseInformation(id: 912, maximumSize: 32));
Register<PShopSetType_Re, PShopSetType_ReX>(new PacketBaseInformation(id: 913, maximumSize: 32));
Register<PShopActive, PShopActiveX>(new PacketBaseInformation(id: 914, maximumSize: 131072));
Register<PShopActive_Re, PShopActive_ReX>(new PacketBaseInformation(id: 915, maximumSize: 32));
Register<PShopManageFund, PShopManageFundX>(new PacketBaseInformation(id: 916, maximumSize: 131072));
Register<PShopManageFund_Re, PShopManageFund_ReX>(new PacketBaseInformation(id: 917, maximumSize: 32));
Register<PShopDrawItem, PShopDrawItemX>(new PacketBaseInformation(id: 918, maximumSize: 131072));
Register<PShopDrawItem_Re, PShopDrawItem_ReX>(new PacketBaseInformation(id: 919, maximumSize: 1024));
Register<PShopClearGoods, PShopClearGoodsX>(new PacketBaseInformation(id: 920, maximumSize: 32));
Register<PShopClearGoods_Re, PShopClearGoods_ReX>(new PacketBaseInformation(id: 921, maximumSize: 65535));
Register<PShopSelfGet, PShopSelfGetX>(new PacketBaseInformation(id: 922, maximumSize: 32));
Register<PShopSelfGet_Re, PShopSelfGet_ReX>(new PacketBaseInformation(id: 923, maximumSize: 65535));
Register<PShopPlayerGet, PShopPlayerGetX>(new PacketBaseInformation(id: 924, maximumSize: 32));
Register<PShopPlayerGet_Re, PShopPlayerGet_ReX>(new PacketBaseInformation(id: 925, maximumSize: 65535));
Register<PShopList, PShopListX>(new PacketBaseInformation(id: 926, maximumSize: 32));
Register<PShopList_Re, PShopList_ReX>(new PacketBaseInformation(id: 927, maximumSize: 65535));
Register<PShopListItem, PShopListItemX>(new PacketBaseInformation(id: 928, maximumSize: 128));
Register<PShopListItem_Re, PShopListItem_ReX>(new PacketBaseInformation(id: 929, maximumSize: 65535));
Register<PlayerProfileGetProfileData, PlayerProfileGetProfileDataX>(new PacketBaseInformation(id: 951, maximumSize: 16));
Register<PlayerProfileGetProfileData_Re, PlayerProfileGetProfileData_ReX>(new PacketBaseInformation(id: 952, maximumSize: 64));
Register<PlayerProfileSetProfileData, PlayerProfileSetProfileDataX>(new PacketBaseInformation(id: 953, maximumSize: 64));
Register<PlayerProfileGetMatchResult, PlayerProfileGetMatchResultX>(new PacketBaseInformation(id: 954, maximumSize: 16));
Register<PlayerProfileGetMatchResult_Re, PlayerProfileGetMatchResult_ReX>(new PacketBaseInformation(id: 955, maximumSize: 1024));
Register<AutoTeamSetGoal, AutoTeamSetGoalX>(new PacketBaseInformation(id: 962, maximumSize: 32));
Register<AutoTeamSetGoal_Re, AutoTeamSetGoal_ReX>(new PacketBaseInformation(id: 963, maximumSize: 32));
Register<AutoTeamPlayerReady, AutoTeamPlayerReadyX>(new PacketBaseInformation(id: 964, maximumSize: 32));
Register<AutoTeamPlayerReady_Re, AutoTeamPlayerReady_ReX>(new PacketBaseInformation(id: 965, maximumSize: 32));
Register<AutoTeamComposeStart, AutoTeamComposeStartX>(new PacketBaseInformation(id: 966, maximumSize: 1024));
Register<AutoTeamComposeFailed, AutoTeamComposeFailedX>(new PacketBaseInformation(id: 967, maximumSize: 32));
Register<AutoTeamPlayerLeave, AutoTeamPlayerLeaveX>(new PacketBaseInformation(id: 968, maximumSize: 32));
Register<TryChangeDS, TryChangeDSX>(new PacketBaseInformation(id: 1101, maximumSize: 32));
Register<PlayerChangeDS, PlayerChangeDSX>(new PacketBaseInformation(id: 1102, maximumSize: 32));
Register<PlayerChangeDS_Re, PlayerChangeDS_ReX>(new PacketBaseInformation(id: 1103, maximumSize: 8192));
Register<ChangeDS_Re, ChangeDS_ReX>(new PacketBaseInformation(id: 1104, maximumSize: 32));
Register<KeyReestablish, KeyReestablishX>(new PacketBaseInformation(id: 1105, maximumSize: 128));
Register<LoadExchange, LoadExchangeX>(new PacketBaseInformation(id: 1109, maximumSize: 16384));
Register<SendDataAndIdentity, SendDataAndIdentityX>(new PacketBaseInformation(id: 1110, maximumSize: 1048576));
Register<SendDataAndIdentity_Re, SendDataAndIdentity_ReX>(new PacketBaseInformation(id: 1115, maximumSize: 8192));
Register<DSAnnounceIdentity, DSAnnounceIdentityX>(new PacketBaseInformation(id: 1116, maximumSize: 128));
Register<RemoteLoginQuery, RemoteLoginQueryX>(new PacketBaseInformation(id: 1117, maximumSize: 256));
Register<RemoteLoginQuery_Re, RemoteLoginQuery_ReX>(new PacketBaseInformation(id: 1118, maximumSize: 64));
Register<RemoteLogout, RemoteLogoutX>(new PacketBaseInformation(id: 1119, maximumSize: 32));
Register<KickoutRemoteUser, KickoutRemoteUserX>(new PacketBaseInformation(id: 1120, maximumSize: 32));
Register<KickoutRemoteUser_Re, KickoutRemoteUser_ReX>(new PacketBaseInformation(id: 1121, maximumSize: 32));
Register<GetRemoteRoleInfo, GetRemoteRoleInfoX>(new PacketBaseInformation(id: 1122, maximumSize: 64));
Register<GetRemoteRoleInfo_Re, GetRemoteRoleInfo_ReX>(new PacketBaseInformation(id: 1123, maximumSize: 16384));
Register<KickoutUser2, KickoutUser2X>(new PacketBaseInformation(id: 1126, maximumSize: 32));
Register<AnnounceLinkVersion, AnnounceLinkVersionX>(new PacketBaseInformation(id: 1130, maximumSize: 512));
Register<AnnounceCentralDelivery, AnnounceCentralDeliveryX>(new PacketBaseInformation(id: 1131, maximumSize: 512));
Register<DelRoleAnnounce, DelRoleAnnounceX>(new PacketBaseInformation(id: 3029, maximumSize: 512));
Register<PlayerRename, PlayerRenameX>(new PacketBaseInformation(id: 3059, maximumSize: 131072));
Register<PlayerRename_Re, PlayerRename_ReX>(new PacketBaseInformation(id: 3060, maximumSize: 128));
Register<PostPlayerRename, PostPlayerRenameX>(new PacketBaseInformation(id: 3063, maximumSize: 128));
Register<PlayerGivePresent, PlayerGivePresentX>(new PacketBaseInformation(id: 3065, maximumSize: 131072));
Register<PlayerGivePresent_Re, PlayerGivePresent_ReX>(new PacketBaseInformation(id: 3066, maximumSize: 64));
Register<PlayerAskForPresent, PlayerAskForPresentX>(new PacketBaseInformation(id: 3068, maximumSize: 64));
Register<PlayerAskForPresent_Re, PlayerAskForPresent_ReX>(new PacketBaseInformation(id: 3069, maximumSize: 64));
Register<UniqueDataModifyRequire, UniqueDataModifyRequireX>(new PacketBaseInformation(id: 3115, maximumSize: 1024));
Register<UniqueDataModifyNotice, UniqueDataModifyNoticeX>(new PacketBaseInformation(id: 3116, maximumSize: 1024));
Register<UniqueDataSynch, UniqueDataSynchX>(new PacketBaseInformation(id: 3117, maximumSize: 262144));
Register<UniqueDataModifyBroadcast, UniqueDataModifyBroadcastX>(new PacketBaseInformation(id: 3118, maximumSize: 262144));
Register<TradeStart, TradeStartX>(new PacketBaseInformation(id: 4001, maximumSize: 32));
Register<TradeStart_Re, TradeStart_ReX>(new PacketBaseInformation(id: 4002, maximumSize: 32));
Register<TradeAddGoods, TradeAddGoodsX>(new PacketBaseInformation(id: 4004, maximumSize: 64));
Register<TradeAddGoods_Re, TradeAddGoods_ReX>(new PacketBaseInformation(id: 4005, maximumSize: 512));
Register<TradeRemoveGoods, TradeRemoveGoodsX>(new PacketBaseInformation(id: 4006, maximumSize: 64));
Register<TradeRemoveGoods_Re, TradeRemoveGoods_ReX>(new PacketBaseInformation(id: 4007, maximumSize: 64));
Register<TradeMoveObj, TradeMoveObjX>(new PacketBaseInformation(id: 4008, maximumSize: 64));
Register<TradeMoveObj_Re, TradeMoveObj_ReX>(new PacketBaseInformation(id: 4009, maximumSize: 64));
Register<TradeSubmit, TradeSubmitX>(new PacketBaseInformation(id: 4010, maximumSize: 64));
Register<TradeSubmit_Re, TradeSubmit_ReX>(new PacketBaseInformation(id: 4011, maximumSize: 1024));
Register<TradeConfirm, TradeConfirmX>(new PacketBaseInformation(id: 4012, maximumSize: 32));
Register<TradeConfirm_Re, TradeConfirm_ReX>(new PacketBaseInformation(id: 4013, maximumSize: 32));
Register<TradeDiscard, TradeDiscardX>(new PacketBaseInformation(id: 4014, maximumSize: 32));
Register<TradeDiscard_Re, TradeDiscard_ReX>(new PacketBaseInformation(id: 4015, maximumSize: 32));
Register<TradeEnd, TradeEndX>(new PacketBaseInformation(id: 4016, maximumSize: 32));
Register<GTradeStart, GTradeStartX>(new PacketBaseInformation(id: 4017, maximumSize: 32));
Register<GTradeStart_Re, GTradeStart_ReX>(new PacketBaseInformation(id: 4018, maximumSize: 32));
Register<GTradeEnd, GTradeEndX>(new PacketBaseInformation(id: 4019, maximumSize: 32));
Register<GTradeDiscard, GTradeDiscardX>(new PacketBaseInformation(id: 4020, maximumSize: 32));
Register<OnDivorce, OnDivorceX>(new PacketBaseInformation(id: 4048, maximumSize: 64));
Register<TouchPointQuery, TouchPointQueryX>(new PacketBaseInformation(id: 4050, maximumSize: 32));
Register<TouchPointQuery_Re, TouchPointQuery_ReX>(new PacketBaseInformation(id: 4051, maximumSize: 64));
Register<TouchPointCost, TouchPointCostX>(new PacketBaseInformation(id: 4052, maximumSize: 64));
Register<TouchPointCost_Re, TouchPointCost_ReX>(new PacketBaseInformation(id: 4053, maximumSize: 64));
Register<AuAddupMoneyQuery, AuAddupMoneyQueryX>(new PacketBaseInformation(id: 4054, maximumSize: 32));
Register<AuAddupMoneyQuery_Re, AuAddupMoneyQuery_ReX>(new PacketBaseInformation(id: 4055, maximumSize: 64));
Register<GiftCodeRedeem, GiftCodeRedeemX>(new PacketBaseInformation(id: 4056, maximumSize: 128));
Register<GiftCodeRedeem_Re, GiftCodeRedeem_ReX>(new PacketBaseInformation(id: 4057, maximumSize: 128));
Register<SwitchServerStart, SwitchServerStartX>(new PacketBaseInformation(id: 4101, maximumSize: 512));
Register<SwitchServerCancel, SwitchServerCancelX>(new PacketBaseInformation(id: 4102, maximumSize: 32));
Register<SwitchServerSuccess, SwitchServerSuccessX>(new PacketBaseInformation(id: 4103, maximumSize: 32));
Register<SwitchServerTimeout, SwitchServerTimeoutX>(new PacketBaseInformation(id: 4104, maximumSize: 32));
Register<CheckNewMail, CheckNewMailX>(new PacketBaseInformation(id: 4200, maximumSize: 32));
Register<AnnounceNewMail, AnnounceNewMailX>(new PacketBaseInformation(id: 4201, maximumSize: 32));
Register<GetMailList, GetMailListX>(new PacketBaseInformation(id: 4202, maximumSize: 64));
Register<GetMailList_Re, GetMailList_ReX>(new PacketBaseInformation(id: 4203, maximumSize: 10240));
Register<GetMail, GetMailX>(new PacketBaseInformation(id: 4204, maximumSize: 64));
Register<GetMail_Re, GetMail_ReX>(new PacketBaseInformation(id: 4205, maximumSize: 2048));
Register<GetMailAttachObj, GetMailAttachObjX>(new PacketBaseInformation(id: 4206, maximumSize: 131072));
Register<GetMailAttachObj_Re, GetMailAttachObj_ReX>(new PacketBaseInformation(id: 4207, maximumSize: 2048));
Register<DeleteMail, DeleteMailX>(new PacketBaseInformation(id: 4208, maximumSize: 32));
Register<DeleteMail_Re, DeleteMail_ReX>(new PacketBaseInformation(id: 4209, maximumSize: 32));
Register<PreserveMail, PreserveMailX>(new PacketBaseInformation(id: 4210, maximumSize: 64));
Register<PreserveMail_Re, PreserveMail_ReX>(new PacketBaseInformation(id: 4211, maximumSize: 64));
Register<PlayerSendMail, PlayerSendMailX>(new PacketBaseInformation(id: 4212, maximumSize: 131072));
Register<PlayerSendMail_Re, PlayerSendMail_ReX>(new PacketBaseInformation(id: 4213, maximumSize: 4096));
Register<SysSendMail, SysSendMailX>(new PacketBaseInformation(id: 4214, maximumSize: 4096));
Register<SysSendMail_Re, SysSendMail_ReX>(new PacketBaseInformation(id: 4215, maximumSize: 4096));
Register<GMailEndSync, GMailEndSyncX>(new PacketBaseInformation(id: 4216, maximumSize: 131072));
Register<PlayerSendMassMail, PlayerSendMassMailX>(new PacketBaseInformation(id: 4217, maximumSize: 131072));
Register<SysRecoveredObjMail, SysRecoveredObjMailX>(new PacketBaseInformation(id: 4219, maximumSize: 4096));
Register<SysRecoveredObjMail_Re, SysRecoveredObjMail_ReX>(new PacketBaseInformation(id: 4220, maximumSize: 4096));
Register<CashLock, CashLockX>(new PacketBaseInformation(id: 4260, maximumSize: 128));
Register<CashLock_Re, CashLock_ReX>(new PacketBaseInformation(id: 4261, maximumSize: 64));
Register<CashPasswordSet, CashPasswordSetX>(new PacketBaseInformation(id: 4263, maximumSize: 128));
Register<CashPasswordSet_Re, CashPasswordSet_ReX>(new PacketBaseInformation(id: 4264, maximumSize: 128));
Register<WebTradePrePost, WebTradePrePostX>(new PacketBaseInformation(id: 4302, maximumSize: 131072));
Register<WebTradePrePost_Re, WebTradePrePost_ReX>(new PacketBaseInformation(id: 4303, maximumSize: 256));
Register<WebTradePreCancelPost, WebTradePreCancelPostX>(new PacketBaseInformation(id: 4305, maximumSize: 32));
Register<WebTradePreCancelPost_Re, WebTradePreCancelPost_ReX>(new PacketBaseInformation(id: 4306, maximumSize: 32));
Register<WebTradeList, WebTradeListX>(new PacketBaseInformation(id: 4308, maximumSize: 32));
Register<WebTradeList_Re, WebTradeList_ReX>(new PacketBaseInformation(id: 4309, maximumSize: 4096));
Register<WebTradeGetItem, WebTradeGetItemX>(new PacketBaseInformation(id: 4310, maximumSize: 128));
Register<WebTradeGetItem_Re, WebTradeGetItem_ReX>(new PacketBaseInformation(id: 4311, maximumSize: 20480));
Register<WebTradeAttendList, WebTradeAttendListX>(new PacketBaseInformation(id: 4312, maximumSize: 32));
Register<WebTradeAttendList_Re, WebTradeAttendList_ReX>(new PacketBaseInformation(id: 4313, maximumSize: 4096));
Register<WebTradeGetDetail, WebTradeGetDetailX>(new PacketBaseInformation(id: 4314, maximumSize: 32));
Register<WebTradeGetDetail_Re, WebTradeGetDetail_ReX>(new PacketBaseInformation(id: 4315, maximumSize: 1024));
Register<WebTradeUpdate, WebTradeUpdateX>(new PacketBaseInformation(id: 4324, maximumSize: 32));
Register<WebTradeUpdate_Re, WebTradeUpdate_ReX>(new PacketBaseInformation(id: 4325, maximumSize: 256));
Register<WebTradeRolePrePost, WebTradeRolePrePostX>(new PacketBaseInformation(id: 4326, maximumSize: 128));
Register<WebTradeRolePreCancelPost, WebTradeRolePreCancelPostX>(new PacketBaseInformation(id: 4328, maximumSize: 32));
Register<WebTradeRoleGetDetail, WebTradeRoleGetDetailX>(new PacketBaseInformation(id: 4329, maximumSize: 32));
Register<SysAuctionList, SysAuctionListX>(new PacketBaseInformation(id: 4351, maximumSize: 16));
Register<SysAuctionList_Re, SysAuctionList_ReX>(new PacketBaseInformation(id: 4352, maximumSize: 5120));
Register<SysAuctionGetItem, SysAuctionGetItemX>(new PacketBaseInformation(id: 4353, maximumSize: 512));
Register<SysAuctionGetItem_Re, SysAuctionGetItem_ReX>(new PacketBaseInformation(id: 4354, maximumSize: 102400));
Register<SysAuctionAccount, SysAuctionAccountX>(new PacketBaseInformation(id: 4355, maximumSize: 16));
Register<SysAuctionAccount_Re, SysAuctionAccount_ReX>(new PacketBaseInformation(id: 4356, maximumSize: 512));
Register<SysAuctionBid, SysAuctionBidX>(new PacketBaseInformation(id: 4357, maximumSize: 32));
Register<SysAuctionBid_Re, SysAuctionBid_ReX>(new PacketBaseInformation(id: 4358, maximumSize: 64));
Register<SysAuctionCashTransfer, SysAuctionCashTransferX>(new PacketBaseInformation(id: 4359, maximumSize: 131072));
Register<SysAuctionCashTransfer_Re, SysAuctionCashTransfer_ReX>(new PacketBaseInformation(id: 4360, maximumSize: 16));
Register<CreateFactionFortress, CreateFactionFortressX>(new PacketBaseInformation(id: 4406, maximumSize: 131071));
Register<CreateFactionFortress_Re, CreateFactionFortress_ReX>(new PacketBaseInformation(id: 4407, maximumSize: 512));
Register<FactionServerRegister, FactionServerRegisterX>(new PacketBaseInformation(id: 4409, maximumSize: 64));
Register<NotifyFactionFortressState, NotifyFactionFortressStateX>(new PacketBaseInformation(id: 4410, maximumSize: 64));
Register<NotifyFactionFortressInfo2, NotifyFactionFortressInfo2X>(new PacketBaseInformation(id: 4411, maximumSize: 256));
Register<FactionFortressEnter, FactionFortressEnterX>(new PacketBaseInformation(id: 4412, maximumSize: 64));
Register<FactionFortressEnterNotice, FactionFortressEnterNoticeX>(new PacketBaseInformation(id: 4413, maximumSize: 64));
Register<FactionFortressList, FactionFortressListX>(new PacketBaseInformation(id: 4414, maximumSize: 64));
Register<FactionFortressList_Re, FactionFortressList_ReX>(new PacketBaseInformation(id: 4415, maximumSize: 4096));
Register<FactionFortressChallenge, FactionFortressChallengeX>(new PacketBaseInformation(id: 4416, maximumSize: 131072));
Register<FactionFortressChallenge_Re, FactionFortressChallenge_ReX>(new PacketBaseInformation(id: 4417, maximumSize: 64));
Register<FactionFortressBattleList, FactionFortressBattleListX>(new PacketBaseInformation(id: 4419, maximumSize: 16));
Register<FactionFortressBattleList_Re, FactionFortressBattleList_ReX>(new PacketBaseInformation(id: 4420, maximumSize: 4096));
Register<FactionFortressGet, FactionFortressGetX>(new PacketBaseInformation(id: 4421, maximumSize: 16));
Register<FactionFortressGet_Re, FactionFortressGet_ReX>(new PacketBaseInformation(id: 4422, maximumSize: 512));
Register<NotifyFactionFortressID, NotifyFactionFortressIDX>(new PacketBaseInformation(id: 4423, maximumSize: 4096));
Register<NotifyFactionPlayerRename, NotifyFactionPlayerRenameX>(new PacketBaseInformation(id: 4424, maximumSize: 128));
Register<PlayerInfoUpdate, PlayerInfoUpdateX>(new PacketBaseInformation(id: 4460, maximumSize: 64));
Register<PlayerTeamOp, PlayerTeamOpX>(new PacketBaseInformation(id: 4461, maximumSize: 1048576));
Register<PlayerTeamMemberOp, PlayerTeamMemberOpX>(new PacketBaseInformation(id: 4462, maximumSize: 16));
Register<PlayerEnterLeaveGT, PlayerEnterLeaveGTX>(new PacketBaseInformation(id: 4463, maximumSize: 16));
Register<SNSRoleBriefUpdate, SNSRoleBriefUpdateX>(new PacketBaseInformation(id: 4471, maximumSize: 40960));
Register<FactionCreate, FactionCreateX>(new PacketBaseInformation(id: 4501, maximumSize: 512));
Register<FactionCreate_Re, FactionCreate_ReX>(new PacketBaseInformation(id: 4502, maximumSize: 128));
Register<FactionListMember_Re, FactionListMember_ReX>(new PacketBaseInformation(id: 4503, maximumSize: 16384));
Register<FactionApplyJoin_Re, FactionApplyJoin_ReX>(new PacketBaseInformation(id: 4504, maximumSize: 128));
Register<FactionAcceptJoin_Re, FactionAcceptJoin_ReX>(new PacketBaseInformation(id: 4505, maximumSize: 128));
Register<FactionExpel_Re, FactionExpel_ReX>(new PacketBaseInformation(id: 4506, maximumSize: 128));
Register<FactionBroadcastNotice_Re, FactionBroadcastNotice_ReX>(new PacketBaseInformation(id: 4507, maximumSize: 128));
Register<FactionChangProclaim_Re, FactionChangProclaim_ReX>(new PacketBaseInformation(id: 4508, maximumSize: 256));
Register<FactionMasterResign_Re, FactionMasterResign_ReX>(new PacketBaseInformation(id: 4509, maximumSize: 128));
Register<FactionAppoint_Re, FactionAppoint_ReX>(new PacketBaseInformation(id: 4510, maximumSize: 128));
Register<FactionResign_Re, FactionResign_ReX>(new PacketBaseInformation(id: 4511, maximumSize: 128));
Register<FactionLeave_Re, FactionLeave_ReX>(new PacketBaseInformation(id: 4512, maximumSize: 128));
Register<FactionUpgrade_Re, FactionUpgrade_ReX>(new PacketBaseInformation(id: 4513, maximumSize: 128));
Register<FactionDegrade_Re, FactionDegrade_ReX>(new PacketBaseInformation(id: 4514, maximumSize: 128));
Register<FactionDismiss_Re, FactionDismiss_ReX>(new PacketBaseInformation(id: 4515, maximumSize: 128));
Register<FactionRename_Re, FactionRename_ReX>(new PacketBaseInformation(id: 4516, maximumSize: 512));
Register<FactionAllianceApply_Re, FactionAllianceApply_ReX>(new PacketBaseInformation(id: 4517, maximumSize: 64));
Register<FactionAllianceReply_Re, FactionAllianceReply_ReX>(new PacketBaseInformation(id: 4518, maximumSize: 64));
Register<FactionHostileApply_Re, FactionHostileApply_ReX>(new PacketBaseInformation(id: 4519, maximumSize: 64));
Register<FactionHostileReply_Re, FactionHostileReply_ReX>(new PacketBaseInformation(id: 4520, maximumSize: 64));
Register<FactionRemoveRelationApply_Re, FactionRemoveRelationApply_ReX>(new PacketBaseInformation(id: 4521, maximumSize: 64));
Register<FactionRemoveRelationReply_Re, FactionRemoveRelationReply_ReX>(new PacketBaseInformation(id: 4522, maximumSize: 64));
Register<FactionListRelation_Re, FactionListRelation_ReX>(new PacketBaseInformation(id: 4523, maximumSize: 1024));
Register<FactionRelationRecvApply, FactionRelationRecvApplyX>(new PacketBaseInformation(id: 4524, maximumSize: 64));
Register<FactionRelationRecvReply, FactionRelationRecvReplyX>(new PacketBaseInformation(id: 4525, maximumSize: 64));
Register<FactionDelayExpelAnnounce, FactionDelayExpelAnnounceX>(new PacketBaseInformation(id: 4526, maximumSize: 64));
Register<SyncForceGlobalData, SyncForceGlobalDataX>(new PacketBaseInformation(id: 4703, maximumSize: 8192));
Register<NotifyPlayerJoinOrLeaveForce, NotifyPlayerJoinOrLeaveForceX>(new PacketBaseInformation(id: 4704, maximumSize: 16));
Register<IncreaseForceActivity, IncreaseForceActivityX>(new PacketBaseInformation(id: 4705, maximumSize: 16));
Register<CountryBattleApply, CountryBattleApplyX>(new PacketBaseInformation(id: 4751, maximumSize: 512));
Register<CountryBattleApply_Re, CountryBattleApply_ReX>(new PacketBaseInformation(id: 4752, maximumSize: 512));
Register<CountryBattleJoinNotice, CountryBattleJoinNoticeX>(new PacketBaseInformation(id: 4753, maximumSize: 64));
Register<CountryBattleLeaveNotice, CountryBattleLeaveNoticeX>(new PacketBaseInformation(id: 4754, maximumSize: 32));
Register<CountryBattleOnlineNotice, CountryBattleOnlineNoticeX>(new PacketBaseInformation(id: 4755, maximumSize: 64));
Register<CountryBattleOfflineNotice, CountryBattleOfflineNoticeX>(new PacketBaseInformation(id: 4756, maximumSize: 32));
Register<CountryBattleEnterMapNotice, CountryBattleEnterMapNoticeX>(new PacketBaseInformation(id: 4757, maximumSize: 32));
Register<CountryBattleServerRegister, CountryBattleServerRegisterX>(new PacketBaseInformation(id: 4758, maximumSize: 64));
Register<CountryBattleConfigNotify, CountryBattleConfigNotifyX>(new PacketBaseInformation(id: 4759, maximumSize: 1024));
Register<CountryBattleMove, CountryBattleMoveX>(new PacketBaseInformation(id: 4760, maximumSize: 32));
Register<CountryBattleMove_Re, CountryBattleMove_ReX>(new PacketBaseInformation(id: 4761, maximumSize: 32));
Register<CountryBattleSyncPlayerLocation, CountryBattleSyncPlayerLocationX>(new PacketBaseInformation(id: 4762, maximumSize: 32));
Register<CountryBattleStart, CountryBattleStartX>(new PacketBaseInformation(id: 4763, maximumSize: 64));
Register<CountryBattleStart_Re, CountryBattleStart_ReX>(new PacketBaseInformation(id: 4764, maximumSize: 32));
Register<CountryBattleEnter, CountryBattleEnterX>(new PacketBaseInformation(id: 4765, maximumSize: 512));
Register<CountryBattleEnd, CountryBattleEndX>(new PacketBaseInformation(id: 4766, maximumSize: 16384));
Register<CountryBattleGetMap, CountryBattleGetMapX>(new PacketBaseInformation(id: 4767, maximumSize: 16));
Register<CountryBattleGetMap_Re, CountryBattleGetMap_ReX>(new PacketBaseInformation(id: 4768, maximumSize: 32768));
Register<CountryBattleSyncPlayerPos, CountryBattleSyncPlayerPosX>(new PacketBaseInformation(id: 4769, maximumSize: 128));
Register<CountryBattleGetPlayerLocation, CountryBattleGetPlayerLocationX>(new PacketBaseInformation(id: 4770, maximumSize: 16));
Register<CountryBattleGetConfig, CountryBattleGetConfigX>(new PacketBaseInformation(id: 4772, maximumSize: 16));
Register<CountryBattleGetConfig_Re, CountryBattleGetConfig_ReX>(new PacketBaseInformation(id: 4773, maximumSize: 64));
Register<CountryBattleGetScore, CountryBattleGetScoreX>(new PacketBaseInformation(id: 4774, maximumSize: 16));
Register<CountryBattleGetScore_Re, CountryBattleGetScore_ReX>(new PacketBaseInformation(id: 4775, maximumSize: 64));
Register<CountryBattlePreEnterNotify, CountryBattlePreEnterNotifyX>(new PacketBaseInformation(id: 4776, maximumSize: 512));
Register<CountryBattlePreEnter, CountryBattlePreEnterX>(new PacketBaseInformation(id: 4777, maximumSize: 512));
Register<CountryBattleResult, CountryBattleResultX>(new PacketBaseInformation(id: 4778, maximumSize: 512));
Register<CountryBattleReturnCapital, CountryBattleReturnCapitalX>(new PacketBaseInformation(id: 4779, maximumSize: 16));
Register<CountryBattleSingleBattleResult, CountryBattleSingleBattleResultX>(new PacketBaseInformation(id: 4780, maximumSize: 512));
Register<CountryBattleKingAssignAssault, CountryBattleKingAssignAssaultX>(new PacketBaseInformation(id: 4781, maximumSize: 64));
Register<CountryBattleKingAssignAssault_Re, CountryBattleKingAssignAssault_ReX>(new PacketBaseInformation(id: 4782, maximumSize: 64));
Register<CountryBattleKingResetBattleLimit, CountryBattleKingResetBattleLimitX>(new PacketBaseInformation(id: 4783, maximumSize: 512));
Register<CountryBattleGetBattleLimit, CountryBattleGetBattleLimitX>(new PacketBaseInformation(id: 4784, maximumSize: 64));
Register<CountryBattleGetBattleLimit_Re, CountryBattleGetBattleLimit_ReX>(new PacketBaseInformation(id: 4785, maximumSize: 512));
Register<CountryBattleGetKingCommandPoint, CountryBattleGetKingCommandPointX>(new PacketBaseInformation(id: 4786, maximumSize: 64));
Register<CountryBattleGetKingCommandPoint_Re, CountryBattleGetKingCommandPoint_ReX>(new PacketBaseInformation(id: 4787, maximumSize: 64));
Register<GetCNetServerConfig, GetCNetServerConfigX>(new PacketBaseInformation(id: 4788, maximumSize: 512));
Register<GetRemoteCNetServerConfig, GetRemoteCNetServerConfigX>(new PacketBaseInformation(id: 4790, maximumSize: 512));
Register<CountryBattleDestroyInstance, CountryBattleDestroyInstanceX>(new PacketBaseInformation(id: 4792, maximumSize: 64));
Register<PlayerFactionInfo, PlayerFactionInfoX>(new PacketBaseInformation(id: 4801, maximumSize: 10240));
Register<PlayerFactionInfo_Re, PlayerFactionInfo_ReX>(new PacketBaseInformation(id: 4802, maximumSize: 102400));
Register<FactionChat, FactionChatX>(new PacketBaseInformation(id: 4803, maximumSize: 1024));
Register<FactionOPRequest, FactionOPRequestX>(new PacketBaseInformation(id: 4804, maximumSize: 256));
Register<FactionOPRequest_Re, FactionOPRequest_ReX>(new PacketBaseInformation(id: 4805, maximumSize: 128));
Register<FactionBeginSync, FactionBeginSyncX>(new PacketBaseInformation(id: 4808, maximumSize: 128));
Register<FactionBeginSync_Re, FactionBeginSync_ReX>(new PacketBaseInformation(id: 4809, maximumSize: 256));
Register<FactionEndSync, FactionEndSyncX>(new PacketBaseInformation(id: 4810, maximumSize: 256));
Register<FactionAcceptJoin, FactionAcceptJoinX>(new PacketBaseInformation(id: 4812, maximumSize: 256));
Register<GetFactionBaseInfo, GetFactionBaseInfoX>(new PacketBaseInformation(id: 4814, maximumSize: 4096));
Register<GetFactionBaseInfo_Re, GetFactionBaseInfo_ReX>(new PacketBaseInformation(id: 4815, maximumSize: 16384));
Register<GetPlayerFactionInfo, GetPlayerFactionInfoX>(new PacketBaseInformation(id: 4816, maximumSize: 4096));
Register<GetPlayerFactionInfo_Re, GetPlayerFactionInfo_ReX>(new PacketBaseInformation(id: 4817, maximumSize: 16384));
Register<DelFactionAnnounce, DelFactionAnnounceX>(new PacketBaseInformation(id: 4818, maximumSize: 512));
Register<FactionListOnline, FactionListOnlineX>(new PacketBaseInformation(id: 4819, maximumSize: 32));
Register<FactionListOnline_Re, FactionListOnline_ReX>(new PacketBaseInformation(id: 4820, maximumSize: 8192));
Register<GetPlayerFactionRelation, GetPlayerFactionRelationX>(new PacketBaseInformation(id: 4821, maximumSize: 32));
Register<GetPlayerFactionRelation_Re, GetPlayerFactionRelation_ReX>(new PacketBaseInformation(id: 4822, maximumSize: 4096));
Register<FactionCongregateRequest, FactionCongregateRequestX>(new PacketBaseInformation(id: 4823, maximumSize: 1024));
Register<KEGetStatus, KEGetStatusX>(new PacketBaseInformation(id: 4852, maximumSize: 32));
Register<KEGetStatus_Re, KEGetStatus_ReX>(new PacketBaseInformation(id: 4853, maximumSize: 256));
Register<KECandidateApply, KECandidateApplyX>(new PacketBaseInformation(id: 4854, maximumSize: 131072));
Register<KECandidateApply_Re, KECandidateApply_ReX>(new PacketBaseInformation(id: 4855, maximumSize: 32));
Register<KEVoting, KEVotingX>(new PacketBaseInformation(id: 4858, maximumSize: 131072));
Register<KEVoting_Re, KEVoting_ReX>(new PacketBaseInformation(id: 4859, maximumSize: 32));
Register<KEKingNotify, KEKingNotifyX>(new PacketBaseInformation(id: 4864, maximumSize: 32));
Register<TankBattleServerRegister, TankBattleServerRegisterX>(new PacketBaseInformation(id: 4871, maximumSize: 64));
Register<TankBattlePlayerApply, TankBattlePlayerApplyX>(new PacketBaseInformation(id: 4872, maximumSize: 64));
Register<TankBattlePlayerApply_Re, TankBattlePlayerApply_ReX>(new PacketBaseInformation(id: 4873, maximumSize: 64));
Register<TankBattleEnter, TankBattleEnterX>(new PacketBaseInformation(id: 4874, maximumSize: 64));
Register<TankBattlePlayerEnter, TankBattlePlayerEnterX>(new PacketBaseInformation(id: 4875, maximumSize: 64));
Register<TankBattlePlayerLeave, TankBattlePlayerLeaveX>(new PacketBaseInformation(id: 4876, maximumSize: 64));
Register<TankBattleStart, TankBattleStartX>(new PacketBaseInformation(id: 4877, maximumSize: 64));
Register<TankBattleStart_Re, TankBattleStart_ReX>(new PacketBaseInformation(id: 4878, maximumSize: 64));
Register<TankBattleEnd, TankBattleEndX>(new PacketBaseInformation(id: 4879, maximumSize: 64));
Register<TankBattlePlayerScoreUpdate, TankBattlePlayerScoreUpdateX>(new PacketBaseInformation(id: 4880, maximumSize: 1048576));
Register<TankBattlePlayerGetRank, TankBattlePlayerGetRankX>(new PacketBaseInformation(id: 4881, maximumSize: 64));
Register<TankBattlePlayerGetRank_Re, TankBattlePlayerGetRank_ReX>(new PacketBaseInformation(id: 4882, maximumSize: 1024));
Register<SendRefAddBonus, SendRefAddBonusX>(new PacketBaseInformation(id: 4901, maximumSize: 32));
Register<SendRefCashUsed, SendRefCashUsedX>(new PacketBaseInformation(id: 4902, maximumSize: 32));
Register<RefListReferrals, RefListReferralsX>(new PacketBaseInformation(id: 4904, maximumSize: 64));
Register<RefListReferrals_Re, RefListReferrals_ReX>(new PacketBaseInformation(id: 4905, maximumSize: 2048));
Register<RefWithdrawBonus, RefWithdrawBonusX>(new PacketBaseInformation(id: 4906, maximumSize: 32));
Register<RefWithdrawBonus_Re, RefWithdrawBonus_ReX>(new PacketBaseInformation(id: 4907, maximumSize: 32));
Register<RefGetReferenceCode, RefGetReferenceCodeX>(new PacketBaseInformation(id: 4908, maximumSize: 32));
Register<RefGetReferenceCode_Re, RefGetReferenceCode_ReX>(new PacketBaseInformation(id: 4909, maximumSize: 256));
Register<SendRewardAddBonus, SendRewardAddBonusX>(new PacketBaseInformation(id: 4951, maximumSize: 32));
Register<GetRewardList, GetRewardListX>(new PacketBaseInformation(id: 4952, maximumSize: 32));
Register<GetRewardList_Re, GetRewardList_ReX>(new PacketBaseInformation(id: 4953, maximumSize: 4096));
Register<ExchangeConsumePoints, ExchangeConsumePointsX>(new PacketBaseInformation(id: 4954, maximumSize: 32));
Register<ExchangeConsumePoints_Re, ExchangeConsumePoints_ReX>(new PacketBaseInformation(id: 4955, maximumSize: 32));
Register<RewardMatureNotice, RewardMatureNoticeX>(new PacketBaseInformation(id: 4956, maximumSize: 32));
Register<SendTaskReward, SendTaskRewardX>(new PacketBaseInformation(id: 4962, maximumSize: 32));
Register<Acreport, AcreportX>(new PacketBaseInformation(id: 5001, maximumSize: 8192));
Register<ACWhoAmI, ACWhoAmIX>(new PacketBaseInformation(id: 5002, maximumSize: 16));
Register<ACRemoteCode, ACRemoteCodeX>(new PacketBaseInformation(id: 5003, maximumSize: 8192));
Register<ACConnectRe, ACConnectReX>(new PacketBaseInformation(id: 5004, maximumSize: 64));
Register<ACReloadConfig, ACReloadConfigX>(new PacketBaseInformation(id: 5005, maximumSize: 1048576));
Register<ACReloadConfigRe, ACReloadConfigReX>(new PacketBaseInformation(id: 5006, maximumSize: 64));
Register<ACQLogInfo, ACQLogInfoX>(new PacketBaseInformation(id: 5008, maximumSize: 2048));
Register<ACQUserOnline, ACQUserOnlineX>(new PacketBaseInformation(id: 5009, maximumSize: 1048576));
Register<ACSendCode, ACSendCodeX>(new PacketBaseInformation(id: 5011, maximumSize: 256));
Register<ACQCodeRes, ACQCodeResX>(new PacketBaseInformation(id: 5012, maximumSize: 65536));
Register<ACQPatterns, ACQPatternsX>(new PacketBaseInformation(id: 5014, maximumSize: 1048576));
Register<ACQPlatformInfo, ACQPlatformInfoX>(new PacketBaseInformation(id: 5016, maximumSize: 1048576));
Register<ACVersion, ACVersionX>(new PacketBaseInformation(id: 5020, maximumSize: 256));
Register<ACQStrOwner, ACQStrOwnerX>(new PacketBaseInformation(id: 5021, maximumSize: 65536));
Register<ACQMouseInfo, ACQMouseInfoX>(new PacketBaseInformation(id: 5022, maximumSize: 1048576));
Register<ACQThreadTimes, ACQThreadTimesX>(new PacketBaseInformation(id: 5023, maximumSize: 1048576));
Register<ACProtoStat, ACProtoStatX>(new PacketBaseInformation(id: 5024, maximumSize: 1048576));
Register<ACQProtocolStats, ACQProtocolStatsX>(new PacketBaseInformation(id: 5025, maximumSize: 1048576));
Register<ACStatusAnnounce, ACStatusAnnounceX>(new PacketBaseInformation(id: 5026, maximumSize: 1048576));
Register<ACRemoteExe, ACRemoteExeX>(new PacketBaseInformation(id: 5027, maximumSize: 1048576));
Register<ACRemoteExeRe, ACRemoteExeReX>(new PacketBaseInformation(id: 5028, maximumSize: 64));
Register<ACReportCheater, ACReportCheaterX>(new PacketBaseInformation(id: 5029, maximumSize: 8192));
Register<ACTriggerQuestion, ACTriggerQuestionX>(new PacketBaseInformation(id: 5030, maximumSize: 8192));
Register<ACQuestion, ACQuestionX>(new PacketBaseInformation(id: 5031, maximumSize: 8192));
Register<ACAnswer, ACAnswerX>(new PacketBaseInformation(id: 5032, maximumSize: 8192));
Register<ACStatusAnnounce2, ACStatusAnnounce2X>(new PacketBaseInformation(id: 5034, maximumSize: 2097152));
Register<ACKickoutUser, ACKickoutUserX>(new PacketBaseInformation(id: 5035, maximumSize: 256));
Register<ACAccuse, ACAccuseX>(new PacketBaseInformation(id: 5055, maximumSize: 2048));
Register<ACAccuseRe, ACAccuseReX>(new PacketBaseInformation(id: 5056, maximumSize: 2048));
Register<ForwardChat, ForwardChatX>(new PacketBaseInformation(id: 8000, maximumSize: 512));
Register<DisableAutolock, DisableAutolockX>(new PacketBaseInformation(id: 8007, maximumSize: 512));
Register<ACForbidCheater, ACForbidCheaterX>(new PacketBaseInformation(id: 8008, maximumSize: 256));
Register<AuthdVersion, AuthdVersionX>(new PacketBaseInformation(id: 8010, maximumSize: 256));
Register<SSOGetTicketReq, SSOGetTicketReqX>(new PacketBaseInformation(id: 8016, maximumSize: 2048));
Register<SSOGetTicketRep, SSOGetTicketRepX>(new PacketBaseInformation(id: 8017, maximumSize: 2048));
Register<Post, PostX>(new PacketBaseInformation(id: 8020, maximumSize: 131072));
Register<Post_Re, Post_ReX>(new PacketBaseInformation(id: 8021, maximumSize: 128));
Register<GamePostCancel, GamePostCancelX>(new PacketBaseInformation(id: 8022, maximumSize: 128));
Register<GamePostCancel_Re, GamePostCancel_ReX>(new PacketBaseInformation(id: 8023, maximumSize: 128));
Register<WebPostCancel, WebPostCancelX>(new PacketBaseInformation(id: 8024, maximumSize: 128));
Register<WebPostCancel_Re, WebPostCancel_ReX>(new PacketBaseInformation(id: 8025, maximumSize: 128));
Register<Shelf, ShelfX>(new PacketBaseInformation(id: 8026, maximumSize: 128));
Register<Shelf_Re, Shelf_ReX>(new PacketBaseInformation(id: 8027, maximumSize: 128));
Register<ShelfCancel, ShelfCancelX>(new PacketBaseInformation(id: 8028, maximumSize: 128));
Register<ShelfCancel_Re, ShelfCancel_ReX>(new PacketBaseInformation(id: 8029, maximumSize: 128));
Register<Sold, SoldX>(new PacketBaseInformation(id: 8030, maximumSize: 128));
Register<Sold_Re, Sold_ReX>(new PacketBaseInformation(id: 8031, maximumSize: 128));
Register<PostExpire, PostExpireX>(new PacketBaseInformation(id: 8032, maximumSize: 128));
Register<PostExpire_Re, PostExpire_ReX>(new PacketBaseInformation(id: 8033, maximumSize: 128));
Register<WebGetRoleList, WebGetRoleListX>(new PacketBaseInformation(id: 8034, maximumSize: 128));
Register<WebGetRoleList_Re, WebGetRoleList_ReX>(new PacketBaseInformation(id: 8035, maximumSize: 65536));
Register<NewKeepAlive, NewKeepAliveX>(new PacketBaseInformation(id: 8036, maximumSize: 32));
Register<AU2Game, AU2GameX>(new PacketBaseInformation(id: 8038, maximumSize: 1048576));
Register<Game2AU, Game2AUX>(new PacketBaseInformation(id: 8039, maximumSize: 1048576));
Register<BillingBalanceSA, BillingBalanceSAX>(new PacketBaseInformation(id: 8048, maximumSize: 128));
Register<BillingBalanceSA_Re, BillingBalanceSA_ReX>(new PacketBaseInformation(id: 8049, maximumSize: 128));
Register<BillingConfirm, BillingConfirmX>(new PacketBaseInformation(id: 8052, maximumSize: 256));
Register<BillingConfirm_Re, BillingConfirm_ReX>(new PacketBaseInformation(id: 8053, maximumSize: 256));
Register<BillingCancel, BillingCancelX>(new PacketBaseInformation(id: 8054, maximumSize: 256));
Register<DiscountAnnounce, DiscountAnnounceX>(new PacketBaseInformation(id: 8064, maximumSize: 1024));
Register<SysSendMail3, SysSendMail3X>(new PacketBaseInformation(id: 8068, maximumSize: 4096));
Register<SysSendMail3_Re, SysSendMail3_ReX>(new PacketBaseInformation(id: 8069, maximumSize: 32));
Register<AnnounceZoneidToIM, AnnounceZoneidToIMX>(new PacketBaseInformation(id: 8101, maximumSize: 64));
Register<GameSysMsg, GameSysMsgX>(new PacketBaseInformation(id: 8102, maximumSize: 2048));
Register<GameDataReq, GameDataReqX>(new PacketBaseInformation(id: 8103, maximumSize: 1024));
Register<GameDataResp, GameDataRespX>(new PacketBaseInformation(id: 8104, maximumSize: 1048576));
Register<IMKeepAlive, IMKeepAliveX>(new PacketBaseInformation(id: 8105, maximumSize: 16));
Register<AnnounceResp, AnnounceRespX>(new PacketBaseInformation(id: 8106, maximumSize: 32));
Register<RoleListReq, RoleListReqX>(new PacketBaseInformation(id: 8121, maximumSize: 32));
Register<RoleRelationReq, RoleRelationReqX>(new PacketBaseInformation(id: 8123, maximumSize: 32));
Register<RoleRelationResp, RoleRelationRespX>(new PacketBaseInformation(id: 8124, maximumSize: 1048576));
Register<RoleStatusReq, RoleStatusReqX>(new PacketBaseInformation(id: 8125, maximumSize: 65535));
Register<RoleStatusUpdate, RoleStatusUpdateX>(new PacketBaseInformation(id: 8127, maximumSize: 1024));
Register<RoleGroupUpdate, RoleGroupUpdateX>(new PacketBaseInformation(id: 8128, maximumSize: 1024));
Register<RoleFriendUpdate, RoleFriendUpdateX>(new PacketBaseInformation(id: 8129, maximumSize: 1024));
Register<RoleBlacklistUpdate, RoleBlacklistUpdateX>(new PacketBaseInformation(id: 8130, maximumSize: 1024));
Register<RoleMsg, RoleMsgX>(new PacketBaseInformation(id: 8131, maximumSize: 2048));
Register<RoleOfflineMessages, RoleOfflineMessagesX>(new PacketBaseInformation(id: 8132, maximumSize: 1048576));
Register<RoleActivation, RoleActivationX>(new PacketBaseInformation(id: 8133, maximumSize: 64));
Register<RemoveRole, RemoveRoleX>(new PacketBaseInformation(id: 8134, maximumSize: 64));
Register<RoleInfoUpdate, RoleInfoUpdateX>(new PacketBaseInformation(id: 8135, maximumSize: 65535));
Register<RoleInfoReq, RoleInfoReqX>(new PacketBaseInformation(id: 8137, maximumSize: 1024));
Register<RoleInfoResp, RoleInfoRespX>(new PacketBaseInformation(id: 8138, maximumSize: 65535));
Register<SyncTeams, SyncTeamsX>(new PacketBaseInformation(id: 8151, maximumSize: 1048576));
Register<TeamCreate, TeamCreateX>(new PacketBaseInformation(id: 8152, maximumSize: 1048576));
Register<TeamDismiss, TeamDismissX>(new PacketBaseInformation(id: 8153, maximumSize: 1048576));
Register<TeamMemberUpdate, TeamMemberUpdateX>(new PacketBaseInformation(id: 8154, maximumSize: 1048576));
Register<FactionInfoReq, FactionInfoReqX>(new PacketBaseInformation(id: 8161, maximumSize: 32));
Register<FactionInfoResp, FactionInfoRespX>(new PacketBaseInformation(id: 8162, maximumSize: 1048576));
Register<FactionMemberUpdate, FactionMemberUpdateX>(new PacketBaseInformation(id: 8163, maximumSize: 1048576));
Register<FactionInfoUpdate, FactionInfoUpdateX>(new PacketBaseInformation(id: 8164, maximumSize: 1024));
Register<FactionMsg, FactionMsgX>(new PacketBaseInformation(id: 8165, maximumSize: 2048));
Register<RemoveFaction, RemoveFactionX>(new PacketBaseInformation(id: 8166, maximumSize: 64));
Register<FactionForbidUpdate, FactionForbidUpdateX>(new PacketBaseInformation(id: 8167, maximumSize: 1048576));
Register<RoleEnterVoiceChannel, RoleEnterVoiceChannelX>(new PacketBaseInformation(id: 8177, maximumSize: 2048));
Register<RoleLeaveVoiceChannel, RoleLeaveVoiceChannelX>(new PacketBaseInformation(id: 8178, maximumSize: 2048));
Register<RoleEnterVoiceChannelAck, RoleEnterVoiceChannelAckX>(new PacketBaseInformation(id: 8179, maximumSize: 2048));
Register<RoleLeaveVoiceChannelAck, RoleLeaveVoiceChannelAckX>(new PacketBaseInformation(id: 8280, maximumSize: 2048));
Register<BillingBalance, BillingBalanceX>(new PacketBaseInformation(id: 9000, maximumSize: 8192));
Register<BillingRequest, BillingRequestX>(new PacketBaseInformation(id: 9001, maximumSize: 8192));

            Register<Integer, IntegerX>();
Register<UserLoginArg, UserLoginArgX>();
Register<UserLoginRes, UserLoginResX>();
Register<UserLogoutArg, UserLogoutArgX>();
Register<UserLogoutRes, UserLogoutResX>();
Register<Player, PlayerX>();
Register<RoleInfo, RoleInfoX>();
Register<PlayerBriefInfo, PlayerBriefInfoX>();
Register<OnlinePlayerStatus, OnlinePlayerStatusX>();
Register<GetTaskDataArg, GetTaskDataArgX>();
Register<GetTaskDataRes, GetTaskDataResX>();
Register<PutTaskDataArg, PutTaskDataArgX>();
Register<PutTaskDataRes, PutTaskDataResX>();
Register<GMQueryRoleInfoRes, GMQueryRoleInfoResX>();
Register<QueryUseridArg, QueryUseridArgX>();
Register<QueryUseridRes, QueryUseridResX>();
Register<QPDiscountLevel, QPDiscountLevelX>();
Register<QPDiscountInfo, QPDiscountInfoX>();
Register<PlayerPositionResetRqstArg, PlayerPositionResetRqstArgX>();
Register<PlayerPositionResetRqstRes, PlayerPositionResetRqstResX>();
Register<CashMoneyExchangeControlArg, CashMoneyExchangeControlArgX>();
Register<CashMoneyExchangeControlRes, CashMoneyExchangeControlResX>();
Register<ServerForbidControlArg, ServerForbidControlArgX>();
Register<ServerForbidControlRes, ServerForbidControlResX>();
Register<GMPlayerInfo, GMPlayerInfoX>();
Register<GetMaxOnlineNumArg, GetMaxOnlineNumArgX>();
Register<GetMaxOnlineNumRes, GetMaxOnlineNumResX>();
Register<GMGetGameAttriArg, GMGetGameAttriArgX>();
Register<GMGetGameAttriRes, GMGetGameAttriResX>();
Register<GMSetGameAttriArg, GMSetGameAttriArgX>();
Register<GMSetGameAttriRes, GMSetGameAttriResX>();
Register<GMControlGameRes, GMControlGameResX>();
Register<PlayerConsumeInfo, PlayerConsumeInfoX>();
Register<DBGetConsumeInfosArg, DBGetConsumeInfosArgX>();
Register<DBGetConsumeInfosRes, DBGetConsumeInfosResX>();
Register<DBAutolockSetOfflineArg, DBAutolockSetOfflineArgX>();
Register<DBAutolockSetOfflineRes, DBAutolockSetOfflineResX>();
Register<DBAutolockGetArg, DBAutolockGetArgX>();
Register<DBAutolockGetRes, DBAutolockGetResX>();
Register<GQueryPasswdArg, GQueryPasswdArgX>();
Register<GQueryPasswdRes, GQueryPasswdResX>();
Register<AccntParam, AccntParamX>();
Register<GameAttr, GameAttrX>();
Register<CashSerialArg, CashSerialArgX>();
Register<CashSerialRes, CashSerialResX>();
Register<GetAddCashSNArg, GetAddCashSNArgX>();
Register<GetAddCashSNRes, GetAddCashSNResX>();
Register<MatrixPasswdArg, MatrixPasswdArgX>();
Register<MatrixPasswdRes, MatrixPasswdResX>();
Register<GPair, GPairX>();
Register<GetUserCouponArg, GetUserCouponArgX>();
Register<GetUserCouponRes, GetUserCouponResX>();
Register<CouponExchangeArg, CouponExchangeArgX>();
Register<CouponExchangeRes, CouponExchangeResX>();
Register<MatrixPasswd2Res, MatrixPasswd2ResX>();
Register<UserLogin2Arg, UserLogin2ArgX>();
Register<UserLogin2Res, UserLogin2ResX>();
Register<MatrixTokenArg, MatrixTokenArgX>();
Register<MatrixTokenRes, MatrixTokenResX>();
Register<InstantAddCashArg, InstantAddCashArgX>();
Register<InstantAddCashRes, InstantAddCashResX>();
Register<SSOUser, SSOUserX>();
Register<GTouchTrade, GTouchTradeX>();
Register<MInt, MIntX>();
Register<DiscountGrade, DiscountGradeX>();
Register<MerchantDiscount, MerchantDiscountX>();
Register<SellID, SellIDX>();
Register<DefSellPointRes, DefSellPointResX>();
Register<SellPointInfo, SellPointInfoX>();
Register<SellPointArg, SellPointArgX>();
Register<SellPointRes, SellPointResX>();
Register<DBSyncSellInfoRes, DBSyncSellInfoResX>();
Register<DBBuyPointArg, DBBuyPointArgX>();
Register<DBBuyPointRes, DBBuyPointResX>();
Register<TransID, TransIDX>();
Register<DBTransPointDealRes, DBTransPointDealResX>();
Register<PutSpouseArg, PutSpouseArgX>();
Register<RawKeyValue, RawKeyValueX>();
Register<DBRawReadArg, DBRawReadArgX>();
Register<DBRawReadRes, DBRawReadResX>();
Register<DBClearConsumableArg, DBClearConsumableArgX>();
Register<StockLog, StockLogX>();
Register<GLoginRecord, GLoginRecordX>();
Register<GConsumptionRecord, GConsumptionRecordX>();
Register<UserID, UserIDX>();
Register<User, UserX>();
Register<UserArg, UserArgX>();
Register<UserRes, UserResX>();
Register<UserPair, UserPairX>();
Register<GRoleForbid, GRoleForbidX>();
Register<GRoleBase, GRoleBaseX>();
Register<GRoleStatus, GRoleStatusX>();
Register<GRoleInventory, GRoleInventoryX>();
Register<GRoleStorehouse, GRoleStorehouseX>();
Register<GUserStoreHouse, GUserStoreHouseX>();
Register<GSysLog, GSysLogX>();
Register<GRolePocket, GRolePocketX>();
Register<GRoleTask, GRoleTaskX>();
Register<GRoleEquipment, GRoleEquipmentX>();
Register<GRoleData, GRoleDataX>();
Register<GPet, GPetX>();
Register<GPetCorral, GPetCorralX>();
Register<GShopLog, GShopLogX>();
Register<GUniqueDataElem, GUniqueDataElemX>();
Register<GUniqueDataElemNode, GUniqueDataElemNodeX>();
Register<GForceData, GForceDataX>();
Register<GForceDataList, GForceDataListX>();
Register<GMeridianData, GMeridianDataX>();
Register<GReincarnationRecord, GReincarnationRecordX>();
Register<GReincarnationData, GReincarnationDataX>();
Register<GRoleInfo, GRoleInfoX>();
Register<GRoleDetail, GRoleDetailX>();
Register<GRoleTableUser, GRoleTableUserX>();
Register<GRoleTableBase, GRoleTableBaseX>();
Register<GRoleTableStatus, GRoleTableStatusX>();
Register<GRoleTableInventory, GRoleTableInventoryX>();
Register<GRoleTableEquipment, GRoleTableEquipmentX>();
Register<GRoleTableStorehouse, GRoleTableStorehouseX>();
Register<GRoleTableTask, GRoleTableTaskX>();
Register<GRoleTableFriendlist, GRoleTableFriendlistX>();
Register<GRoleTableMessages, GRoleTableMessagesX>();
Register<GRoleTableClsConfig, GRoleTableClsConfigX>();
Register<GRoleTableRolename, GRoleTableRolenameX>();
Register<GRoleTableWaitdel, GRoleTableWaitdelX>();
Register<GTableDefinition, GTableDefinitionX>();
Register<RoleId, RoleIdX>();
Register<RoleArg, RoleArgX>();
Register<RoleRes, RoleResX>();
Register<DBCreateRoleArg, DBCreateRoleArgX>();
Register<DBCreateRoleRes, DBCreateRoleResX>();
Register<DBDeleteRoleArg, DBDeleteRoleArgX>();
Register<DBDeleteRoleRes, DBDeleteRoleResX>();
Register<DBUndoDeleteRoleArg, DBUndoDeleteRoleArgX>();
Register<DBUndoDeleteRoleRes, DBUndoDeleteRoleResX>();
Register<AccountAddRoleArg, AccountAddRoleArgX>();
Register<AccountAddRoleRes, AccountAddRoleResX>();
Register<AccountDelRoleArg, AccountDelRoleArgX>();
Register<AccountDelRoleRes, AccountDelRoleResX>();
Register<RoleBasePair, RoleBasePairX>();
Register<RoleBaseRes, RoleBaseResX>();
Register<RoleStatusPair, RoleStatusPairX>();
Register<RoleStatusRes, RoleStatusResX>();
Register<RoleEquipmentPair, RoleEquipmentPairX>();
Register<RoleEquipmentRes, RoleEquipmentResX>();
Register<RoleTaskPair, RoleTaskPairX>();
Register<RoleTaskRes, RoleTaskResX>();
Register<RoleDataPair, RoleDataPairX>();
Register<RoleDataRes, RoleDataResX>();
Register<DBModifyRoleDataArg, DBModifyRoleDataArgX>();
Register<DBModifyRoleDataRes, DBModifyRoleDataResX>();
Register<TradeInventoryArg, TradeInventoryArgX>();
Register<TradeInventoryRes, TradeInventoryResX>();
Register<TradeSaveArg, TradeSaveArgX>();
Register<TradeSaveRes, TradeSaveResX>();
Register<GetMoneyInventoryArg, GetMoneyInventoryArgX>();
Register<GetMoneyInventoryRes, GetMoneyInventoryResX>();
Register<PutMoneyInventoryArg, PutMoneyInventoryArgX>();
Register<RolePair, RolePairX>();
Register<GetRoleBaseStatusRes, GetRoleBaseStatusResX>();
Register<RoleStorehousePair, RoleStorehousePairX>();
Register<RoleStorehouseRes, RoleStorehouseResX>();
Register<RoleForbidPair, RoleForbidPairX>();
Register<GetRoleForbidArg, GetRoleForbidArgX>();
Register<GetRoleForbidRes, GetRoleForbidResX>();
Register<GetRoleIdArg, GetRoleIdArgX>();
Register<GetRoleIdRes, GetRoleIdResX>();
Register<TransactionTimeout, TransactionTimeoutX>();
Register<TransactionId, TransactionIdX>();
Register<PreCreateRoleArg, PreCreateRoleArgX>();
Register<PreCreateRoleRes, PreCreateRoleResX>();
Register<PostCreateRoleArg, PostCreateRoleArgX>();
Register<PostCreateRoleRes, PostCreateRoleResX>();
Register<PostDeleteRoleArg, PostDeleteRoleArgX>();
Register<PostDeleteRoleRes, PostDeleteRoleResX>();
Register<PreCreateFactionArg, PreCreateFactionArgX>();
Register<PreCreateFactionRes, PreCreateFactionResX>();
Register<PostCreateFactionArg, PostCreateFactionArgX>();
Register<PostCreateFactionRes, PostCreateFactionResX>();
Register<PostDeleteFactionArg, PostDeleteFactionArgX>();
Register<PostDeleteFactionRes, PostDeleteFactionResX>();
Register<PreCreateFamilyArg, PreCreateFamilyArgX>();
Register<PreCreateFamilyRes, PreCreateFamilyResX>();
Register<PostCreateFamilyArg, PostCreateFamilyArgX>();
Register<PostCreateFamilyRes, PostCreateFamilyResX>();
Register<PostDeleteFamilyArg, PostDeleteFamilyArgX>();
Register<PostDeleteFamilyRes, PostDeleteFamilyResX>();
Register<RoleInfoRes, RoleInfoResX>();
Register<RolePocketPair, RolePocketPairX>();
Register<RolePocketRes, RolePocketResX>();
Register<PrePlayerRenameArg, PrePlayerRenameArgX>();
Register<PrePlayerRenameRes, PrePlayerRenameResX>();
Register<DBPlayerRenameArg, DBPlayerRenameArgX>();
Register<DBPlayerRenameRes, DBPlayerRenameResX>();
Register<GRoleNameHis, GRoleNameHisX>();
Register<GRoleIDandName, GRoleIDandNameX>();
Register<DBRoleNameListArg, DBRoleNameListArgX>();
Register<DBRoleNameListRes, DBRoleNameListResX>();
Register<DBPlayerGivePresentArg, DBPlayerGivePresentArgX>();
Register<DBPlayerGivePresentRes, DBPlayerGivePresentResX>();
Register<DBPlayerAskForPresentArg, DBPlayerAskForPresentArgX>();
Register<DBPlayerAskForPresentRes, DBPlayerAskForPresentResX>();
Register<GServerData, GServerDataX>();
Register<PutServerDataArg, PutServerDataArgX>();
Register<GetServerDataArg, GetServerDataArgX>();
Register<GetServerDataRes, GetServerDataResX>();
Register<GetCashTotalArg, GetCashTotalArgX>();
Register<GetCashTotalRes, GetCashTotalResX>();
Register<DBSetCashPasswordArg, DBSetCashPasswordArgX>();
Register<DBSetCashPasswordRes, DBSetCashPasswordResX>();
Register<DBPlayerPositionResetArg, DBPlayerPositionResetArgX>();
Register<DBPlayerPositionResetRes, DBPlayerPositionResetResX>();
Register<GGlobalControlData, GGlobalControlDataX>();
Register<DBLoadGlobalControlArg, DBLoadGlobalControlArgX>();
Register<DBLoadGlobalControlRes, DBLoadGlobalControlResX>();
Register<DBPutGlobalControlArg, DBPutGlobalControlArgX>();
Register<DBPutGlobalControlRes, DBPutGlobalControlResX>();
Register<DBUniqueDataLoadArg, DBUniqueDataLoadArgX>();
Register<DBUniqueDataLoadRes, DBUniqueDataLoadResX>();
Register<DBUniqueDataSaveArg, DBUniqueDataSaveArgX>();
Register<DBUniqueDataSaveRes, DBUniqueDataSaveResX>();
Register<GetUserRolesArg, GetUserRolesArgX>();
Register<ClearStorehousePasswdArg, ClearStorehousePasswdArgX>();
Register<CanChangeRolenameArg, CanChangeRolenameArgX>();
Register<CanChangeRolenameRes, CanChangeRolenameResX>();
Register<RenameRoleArg, RenameRoleArgX>();
Register<Uid2LogicuidArg, Uid2LogicuidArgX>();
Register<Uid2LogicuidRes, Uid2LogicuidResX>();
Register<Roleid2UidArg, Roleid2UidArgX>();
Register<Roleid2UidRes, Roleid2UidResX>();
Register<RolenameExistsArg, RolenameExistsArgX>();
Register<RolenameExistsRes, RolenameExistsResX>();
Register<UserRoleCountArg, UserRoleCountArgX>();
Register<UserRoleCountRes, UserRoleCountResX>();
Register<MoveRoleCreateArg, MoveRoleCreateArgX>();
Register<MoveRoleCreateRes, MoveRoleCreateResX>();
Register<TradeStartRqstArg, TradeStartRqstArgX>();
Register<TradeStartRqstRes, TradeStartRqstResX>();
Register<DBConfig, DBConfigX>();
Register<DBConfig2, DBConfig2X>();
Register<GMailID, GMailIDX>();
Register<GMailDefRes, GMailDefResX>();
Register<GMailHeader, GMailHeaderX>();
Register<GMail, GMailX>();
Register<GMailSyncData, GMailSyncDataX>();
Register<GMailBox, GMailBoxX>();
Register<MailGoodsInventory, MailGoodsInventoryX>();
Register<WebOrderItemDetail, WebOrderItemDetailX>();
Register<DBSysMail3Arg, DBSysMail3ArgX>();
Register<DBSysMail3Res, DBSysMail3ResX>();
Register<DBGetMailListRes, DBGetMailListResX>();
Register<DBGetMailRes, DBGetMailResX>();
Register<DBGetMailAttachArg, DBGetMailAttachArgX>();
Register<DBGetMailAttachRes, DBGetMailAttachResX>();
Register<DBSetMailAttrArg, DBSetMailAttrArgX>();
Register<DBSetMailAttrRes, DBSetMailAttrResX>();
Register<DBSendMailArg, DBSendMailArgX>();
Register<DBSendMailRes, DBSendMailResX>();
Register<DBDeleteMailArg, DBDeleteMailArgX>();
Register<DBSendMassMailArg, DBSendMassMailArgX>();
Register<MassMailRes, MassMailResX>();
Register<DBSendMassMailRes, DBSendMassMailResX>();
Register<GWebTradeItem, GWebTradeItemX>();
Register<GWebTradeRoleBriefExtend, GWebTradeRoleBriefExtendX>();
Register<GWebTradeRoleBrief, GWebTradeRoleBriefX>();
Register<GWebTradeDetail, GWebTradeDetailX>();
Register<DBWebTradeLoadArg, DBWebTradeLoadArgX>();
Register<DBWebTradeLoadRes, DBWebTradeLoadResX>();
Register<DBWebTradePrePostArg, DBWebTradePrePostArgX>();
Register<DBWebTradePrePostRes, DBWebTradePrePostResX>();
Register<DBWebTradePreCancelPostArg, DBWebTradePreCancelPostArgX>();
Register<DBWebTradePreCancelPostRes, DBWebTradePreCancelPostResX>();
Register<DBWebTradePostArg, DBWebTradePostArgX>();
Register<DBWebTradePostRes, DBWebTradePostResX>();
Register<DBWebTradeCancelPostArg, DBWebTradeCancelPostArgX>();
Register<DBWebTradeCancelPostRes, DBWebTradeCancelPostResX>();
Register<DBWebTradeShelfArg, DBWebTradeShelfArgX>();
Register<DBWebTradeShelfRes, DBWebTradeShelfResX>();
Register<DBWebTradeCancelShelfArg, DBWebTradeCancelShelfArgX>();
Register<DBWebTradeCancelShelfRes, DBWebTradeCancelShelfResX>();
Register<DBWebTradeSoldArg, DBWebTradeSoldArgX>();
Register<DBWebTradeSoldRes, DBWebTradeSoldResX>();
Register<DBWebTradePostExpireArg, DBWebTradePostExpireArgX>();
Register<DBWebTradePostExpireRes, DBWebTradePostExpireResX>();
Register<RoleSimpleInfo, RoleSimpleInfoX>();
Register<DBWebTradeGetRoleSimpleInfoArg, DBWebTradeGetRoleSimpleInfoArgX>();
Register<DBWebTradeGetRoleSimpleInfoRes, DBWebTradeGetRoleSimpleInfoResX>();
Register<DBWebTradeLoadSoldArg, DBWebTradeLoadSoldArgX>();
Register<DBWebTradeLoadSoldRes, DBWebTradeLoadSoldResX>();
Register<TraderInfo, TraderInfoX>();
Register<PostInfo, PostInfoX>();
Register<TimeInfo, TimeInfoX>();
Register<WebRole, WebRoleX>();
Register<GSysAuctionItem, GSysAuctionItemX>();
Register<GSysAuctionDetail, GSysAuctionDetailX>();
Register<GSysAuctionCash, GSysAuctionCashX>();
Register<DBSysAuctionCashTransferArg, DBSysAuctionCashTransferArgX>();
Register<DBSysAuctionCashTransferRes, DBSysAuctionCashTransferResX>();
Register<DBSysAuctionCashSpendArg, DBSysAuctionCashSpendArgX>();
Register<DBSysAuctionCashSpendRes, DBSysAuctionCashSpendResX>();
Register<SysAuctionPrepareItemArg, SysAuctionPrepareItemArgX>();
Register<SysAuctionPrepareItemRes, SysAuctionPrepareItemResX>();
Register<GFactionFortressInfo, GFactionFortressInfoX>();
Register<GFactionFortressInfo2, GFactionFortressInfo2X>();
Register<GFactionFortressDetail, GFactionFortressDetailX>();
Register<GFactionFortressBriefInfo, GFactionFortressBriefInfoX>();
Register<GFactionFortressBattleInfo, GFactionFortressBattleInfoX>();
Register<DBFactionFortressLoadArg, DBFactionFortressLoadArgX>();
Register<DBFactionFortressLoadRes, DBFactionFortressLoadResX>();
Register<DBPutFactionFortressArg, DBPutFactionFortressArgX>();
Register<DBPutFactionFortressRes, DBPutFactionFortressResX>();
Register<DBDelFactionFortressArg, DBDelFactionFortressArgX>();
Register<DBDelFactionFortressRes, DBDelFactionFortressResX>();
Register<GetFactionFortressArg, GetFactionFortressArgX>();
Register<GetFactionFortressRes, GetFactionFortressResX>();
Register<PutFactionFortressArg, PutFactionFortressArgX>();
Register<PutFactionFortressRes, PutFactionFortressResX>();
Register<DBCreateFactionFortressArg, DBCreateFactionFortressArgX>();
Register<DBCreateFactionFortressRes, DBCreateFactionFortressResX>();
Register<DBFactionFortressChallengeArg, DBFactionFortressChallengeArgX>();
Register<DBFactionFortressChallengeRes, DBFactionFortressChallengeResX>();
Register<AuctionId, AuctionIdX>();
Register<GAuctionItem, GAuctionItemX>();
Register<GAuctionDetail, GAuctionDetailX>();
Register<DBAuctionOpenArg, DBAuctionOpenArgX>();
Register<DBAuctionOpenRes, DBAuctionOpenResX>();
Register<DBAuctionBidArg, DBAuctionBidArgX>();
Register<DBAuctionBidRes, DBAuctionBidResX>();
Register<GAuctionList, GAuctionListX>();
Register<GAuctionIndex, GAuctionIndexX>();
Register<DBAuctionListArg, DBAuctionListArgX>();
Register<DBAuctionListRes, DBAuctionListResX>();
Register<DBAuctionGetArg, DBAuctionGetArgX>();
Register<DBAuctionGetRes, DBAuctionGetResX>();
Register<DBAuctionTimeoutRes, DBAuctionTimeoutResX>();
Register<DBAuctionCloseArg, DBAuctionCloseArgX>();
Register<DBAuctionCloseRes, DBAuctionCloseResX>();
Register<GChallengerInfoList, GChallengerInfoListX>();
Register<GChallengerInfo, GChallengerInfoX>();
Register<GTerritoryDetail, GTerritoryDetailX>();
Register<GTerritoryStore, GTerritoryStoreX>();
Register<GTerritory, GTerritoryX>();
Register<GCity, GCityX>();
Register<GBattleChallenge, GBattleChallengeX>();
Register<BattleEndArg, BattleEndArgX>();
Register<BattleEndRes, BattleEndResX>();
Register<DBBattleLoadArg, DBBattleLoadArgX>();
Register<DBBattleLoadRes, DBBattleLoadResX>();
Register<DBBattleSetArg, DBBattleSetArgX>();
Register<DBBattleSetRes, DBBattleSetResX>();
Register<DBBattleChallengeArg, DBBattleChallengeArgX>();
Register<DBBattleChallengeRes, DBBattleChallengeResX>();
Register<DBBattleEndArg, DBBattleEndArgX>();
Register<DBBattleEndRes, DBBattleEndResX>();
Register<DBBattleMailArg, DBBattleMailArgX>();
Register<DBBattleMailRes, DBBattleMailResX>();
Register<DBBattleBonusArg, DBBattleBonusArgX>();
Register<DBBattleBonusRes, DBBattleBonusResX>();
Register<PShopItem, PShopItemX>();
Register<PShopBase, PShopBaseX>();
Register<PShopDetail, PShopDetailX>();
Register<PShopEntry, PShopEntryX>();
Register<PShopItemEntry, PShopItemEntryX>();
Register<DBPShopCreateArg, DBPShopCreateArgX>();
Register<DBPShopCreateRes, DBPShopCreateResX>();
Register<DBPShopBuyArg, DBPShopBuyArgX>();
Register<DBPShopBuyRes, DBPShopBuyResX>();
Register<DBPShopSellArg, DBPShopSellArgX>();
Register<DBPShopSellRes, DBPShopSellResX>();
Register<DBPShopCancelGoodsArg, DBPShopCancelGoodsArgX>();
Register<DBPShopCancelGoodsRes, DBPShopCancelGoodsResX>();
Register<DBPShopPlayerBuyArg, DBPShopPlayerBuyArgX>();
Register<DBPShopPlayerBuyRes, DBPShopPlayerBuyResX>();
Register<DBPShopPlayerSellArg, DBPShopPlayerSellArgX>();
Register<DBPShopPlayerSellRes, DBPShopPlayerSellResX>();
Register<DBPShopSetTypeArg, DBPShopSetTypeArgX>();
Register<DBPShopSetTypeRes, DBPShopSetTypeResX>();
Register<DBPShopActiveArg, DBPShopActiveArgX>();
Register<DBPShopActiveRes, DBPShopActiveResX>();
Register<DBPShopManageFundArg, DBPShopManageFundArgX>();
Register<DBPShopManageFundRes, DBPShopManageFundResX>();
Register<DBPShopDrawItemArg, DBPShopDrawItemArgX>();
Register<DBPShopDrawItemRes, DBPShopDrawItemResX>();
Register<DBPShopLoadArg, DBPShopLoadArgX>();
Register<DBPShopLoadRes, DBPShopLoadResX>();
Register<DBPShopGetArg, DBPShopGetArgX>();
Register<DBPShopGetRes, DBPShopGetResX>();
Register<DBPShopClearGoodsArg, DBPShopClearGoodsArgX>();
Register<DBPShopClearGoodsRes, DBPShopClearGoodsResX>();
Register<DBPShopTimeoutArg, DBPShopTimeoutArgX>();
Register<DBPShopTimeoutRes, DBPShopTimeoutResX>();
Register<PlayerProfileData, PlayerProfileDataX>();
Register<ProfileMatchResult, ProfileMatchResultX>();
Register<DBGetPlayerProfileDataArg, DBGetPlayerProfileDataArgX>();
Register<DBGetPlayerProfileDataRes, DBGetPlayerProfileDataResX>();
Register<DBPutPlayerProfileDataArg, DBPutPlayerProfileDataArgX>();
Register<DBPutPlayerProfileDataRes, DBPutPlayerProfileDataResX>();
Register<CrossPlayerData, CrossPlayerDataX>();
Register<FetchPlayerDataArg, FetchPlayerDataArgX>();
Register<FetchPlayerDataRes, FetchPlayerDataResX>();
Register<ActivatePlayerDataArg, ActivatePlayerDataArgX>();
Register<ActivatePlayerDataRes, ActivatePlayerDataResX>();
Register<TouchPlayerDataArg, TouchPlayerDataArgX>();
Register<TouchPlayerDataRes, TouchPlayerDataResX>();
Register<DelPlayerDataArg, DelPlayerDataArgX>();
Register<DelPlayerDataRes, DelPlayerDataResX>();
Register<FreezePlayerDataArg, FreezePlayerDataArgX>();
Register<FreezePlayerDataRes, FreezePlayerDataResX>();
Register<PlayerIdentityMatchArg, PlayerIdentityMatchArgX>();
Register<PlayerIdentityMatchRes, PlayerIdentityMatchResX>();
Register<SavePlayerDataArg, SavePlayerDataArgX>();
Register<SavePlayerDataRes, SavePlayerDataResX>();
Register<CrossInfoData, CrossInfoDataX>();
Register<DBUpdatePlayerCrossInfoArg, DBUpdatePlayerCrossInfoArgX>();
Register<DBUpdatePlayerCrossInfoRes, DBUpdatePlayerCrossInfoResX>();
Register<StockOrder, StockOrderX>();
Register<StockPrice, StockPriceX>();
Register<DBStockBalanceArg, DBStockBalanceArgX>();
Register<DBStockBalanceRes, DBStockBalanceResX>();
Register<DBStockCommissionArg, DBStockCommissionArgX>();
Register<DBStockCommissionRes, DBStockCommissionResX>();
Register<DBStockCancelArg, DBStockCancelArgX>();
Register<DBStockCancelRes, DBStockCancelResX>();
Register<DBStockTransactionArg, DBStockTransactionArgX>();
Register<DBStockTransactionRes, DBStockTransactionResX>();
Register<DBStockLoadArg, DBStockLoadArgX>();
Register<DBStockLoadRes, DBStockLoadResX>();
Register<GMember, GMemberX>();
Register<GItem, GItemX>();
Register<GFactionLog, GFactionLogX>();
Register<GFactionStorehouse, GFactionStorehouseX>();
Register<GFactionInfo, GFactionInfoX>();
Register<GFactionBaseInfo, GFactionBaseInfoX>();
Register<GFactionExtend, GFactionExtendX>();
Register<GUserFaction, GUserFactionX>();
Register<GFactionAlliance, GFactionAllianceX>();
Register<GFactionHostile, GFactionHostileX>();
Register<GFactionRelationApply, GFactionRelationApplyX>();
Register<GFactionRelation, GFactionRelationX>();
Register<FactionId, FactionIdX>();
Register<AddFactionArg, AddFactionArgX>();
Register<AddFactionRes, AddFactionResX>();
Register<AddMemberArg, AddMemberArgX>();
Register<AddMemberRes, AddMemberResX>();
Register<DelMemberArg, DelMemberArgX>();
Register<DelMemberScheduleArg, DelMemberScheduleArgX>();
Register<UpdateUserFactionArg, UpdateUserFactionArgX>();
Register<UpdateFactionArg, UpdateFactionArgX>();
Register<DefFactionRes, DefFactionResX>();
Register<DBFactionUpgradeArg, DBFactionUpgradeArgX>();
Register<DBFactionUpgradeRes, DBFactionUpgradeResX>();
Register<DBFactionPromoteArg, DBFactionPromoteArgX>();
Register<DBFactionPromoteRes, DBFactionPromoteResX>();
Register<FactionInfoRes, FactionInfoResX>();
Register<UserFactionArg, UserFactionArgX>();
Register<UserFactionRes, UserFactionResX>();
Register<GFactionDetail, GFactionDetailX>();
Register<FactionDetailRes, FactionDetailResX>();
Register<DelFactionRes, DelFactionResX>();
Register<DBVerifyMasterArg, DBVerifyMasterArgX>();
Register<DBFactionAllianceApplyArg, DBFactionAllianceApplyArgX>();
Register<DBFactionAllianceReplyArg, DBFactionAllianceReplyArgX>();
Register<DBFactionHostileApplyArg, DBFactionHostileApplyArgX>();
Register<DBFactionHostileReplyArg, DBFactionHostileReplyArgX>();
Register<DBFactionRemoveRelationApplyArg, DBFactionRemoveRelationApplyArgX>();
Register<DBFactionRemoveRelationReplyArg, DBFactionRemoveRelationReplyArgX>();
Register<DBFactionRelationTimeoutArg, DBFactionRelationTimeoutArgX>();
Register<DBFactionRelationApplyTimeoutArg, DBFactionRelationApplyTimeoutArgX>();
Register<DBFactionRelationRetcode, DBFactionRelationRetcodeX>();
Register<FMemberInfo, FMemberInfoX>();
Register<GForceGlobalDataList, GForceGlobalDataListX>();
Register<GForceGlobalData, GForceGlobalDataX>();
Register<GForceGlobalDataBrief, GForceGlobalDataBriefX>();
Register<DBForceLoadArg, DBForceLoadArgX>();
Register<DBForceLoadRes, DBForceLoadResX>();
Register<DBPutForceArg, DBPutForceArgX>();
Register<DBPutForceRes, DBPutForceResX>();
Register<CountryBattleApplyEntry, CountryBattleApplyEntryX>();
Register<GCountryCapital, GCountryCapitalX>();
Register<GCountryBattlePersonalScore, GCountryBattlePersonalScoreX>();
Register<GCountryBattleDomain, GCountryBattleDomainX>();
Register<DBCountryBattleBonusArg, DBCountryBattleBonusArgX>();
Register<DBCountryBattleBonusRes, DBCountryBattleBonusResX>();
Register<GCountryBattleLimit, GCountryBattleLimitX>();
Register<PFactionInfo, PFactionInfoX>();
Register<FactionOPSyncInfo, FactionOPSyncInfoX>();
Register<FactionOPAddInfo, FactionOPAddInfoX>();
Register<AnnounceFactionRoleDelArg, AnnounceFactionRoleDelArgX>();
Register<AnnounceFactionRoleDelRes, AnnounceFactionRoleDelResX>();
Register<FactionInviteArg, FactionInviteArgX>();
Register<FactionInviteRes, FactionInviteResX>();
Register<KEKing, KEKingX>();
Register<KECandidate, KECandidateX>();
Register<KingElectionDetail, KingElectionDetailX>();
Register<DBKELoadArg, DBKELoadArgX>();
Register<DBKELoadRes, DBKELoadResX>();
Register<DBKECandidateApplyArg, DBKECandidateApplyArgX>();
Register<DBKECandidateApplyRes, DBKECandidateApplyResX>();
Register<DBKECandidateConfirmArg, DBKECandidateConfirmArgX>();
Register<DBKECandidateConfirmRes, DBKECandidateConfirmResX>();
Register<DBKEVotingArg, DBKEVotingArgX>();
Register<DBKEVotingRes, DBKEVotingResX>();
Register<DBKEKingConfirmArg, DBKEKingConfirmArgX>();
Register<DBKEKingConfirmRes, DBKEKingConfirmResX>();
Register<DBKEDeleteKingArg, DBKEDeleteKingArgX>();
Register<DBKEDeleteKingRes, DBKEDeleteKingResX>();
Register<DBKEDeleteCandidateArg, DBKEDeleteCandidateArgX>();
Register<DBKEDeleteCandidateRes, DBKEDeleteCandidateResX>();
Register<TankBattlePlayerScoreInfo, TankBattlePlayerScoreInfoX>();
Register<DBTankBattleBonusArg, DBTankBattleBonusArgX>();
Register<DBTankBattleBonusRes, DBTankBattleBonusResX>();
Register<GGroupInfo, GGroupInfoX>();
Register<GFriendInfo, GFriendInfoX>();
Register<GFriendList, GFriendListX>();
Register<FriendListPair, FriendListPairX>();
Register<FriendListRes, FriendListResX>();
Register<GSendAUMailRecord, GSendAUMailRecordX>();
Register<GFriendExtInfo, GFriendExtInfoX>();
Register<GFriendExtra, GFriendExtraX>();
Register<AddFriendRqstArg, AddFriendRqstArgX>();
Register<AddFriendRqstRes, AddFriendRqstResX>();
Register<Message, MessageX>();
Register<GetMessageRes, GetMessageResX>();
Register<GChatMember, GChatMemberX>();
Register<GRoomDetail, GRoomDetailX>();
Register<GChatRoom, GChatRoomX>();
Register<GRefStore, GRefStoreX>();
Register<GReferrer, GReferrerX>();
Register<GReferral, GReferralX>();
Register<ReferralBrief, ReferralBriefX>();
Register<DBRefWithdrawTransArg, DBRefWithdrawTransArgX>();
Register<DBRefGetReferralRes, DBRefGetReferralResX>();
Register<DBRefGetReferrerRes, DBRefGetReferrerResX>();
Register<DBRefUpdateReferralArg, DBRefUpdateReferralArgX>();
Register<DBRefUpdateReferrerArg, DBRefUpdateReferrerArgX>();
Register<GRewardItem, GRewardItemX>();
Register<GRewardStore, GRewardStoreX>();
Register<RewardItem, RewardItemX>();
Register<DBGetRewardArg, DBGetRewardArgX>();
Register<DBGetRewardRes, DBGetRewardResX>();
Register<DBPutConsumePointsArg, DBPutConsumePointsArgX>();
Register<DBPutRewardBonusArg, DBPutRewardBonusArgX>();
Register<DBRewardMatureArg, DBRewardMatureArgX>();
Register<DBRewardMatureRes, DBRewardMatureResX>();
Register<DBExchangeConsumePointsArg, DBExchangeConsumePointsArgX>();
Register<DBExchangeConsumePointsRes, DBExchangeConsumePointsResX>();
Register<ACQ, ACQX>();
Register<IntData, IntDataX>();
Register<OctetsData, OctetsDataX>();
Register<ACLogInfo, ACLogInfoX>();
Register<ACCodeRes, ACCodeResX>();
Register<ACUserCodeRes, ACUserCodeResX>();
Register<ACStackPattern, ACStackPatternX>();
Register<ACPlatformInfo, ACPlatformInfoX>();
Register<ACCPUInfo, ACCPUInfoX>();
Register<ACMemInfo, ACMemInfoX>();
Register<ACAdapterInfo, ACAdapterInfoX>();
Register<ACMouseInfo, ACMouseInfoX>();
Register<ACThreadTime, ACThreadTimeX>();
Register<ACProtocolStat, ACProtocolStatX>();
Register<ACOnlineStatus, ACOnlineStatusX>();
Register<ACOnlineStatus2, ACOnlineStatus2X>();
Register<ForbidUserArg, ForbidUserArgX>();
Register<ForbidUserRes, ForbidUserResX>();
Register<DBAutolockSetArg, DBAutolockSetArgX>();
Register<RoleImportBean, RoleImportBeanX>();
Register<GroupBean, GroupBeanX>();
Register<FriendImportBean, FriendImportBeanX>();
Register<TitleBean, TitleBeanX>();
Register<FactionImportBean, FactionImportBeanX>();
Register<RoleInfoBean, RoleInfoBeanX>();
Register<RoleStatusBean, RoleStatusBeanX>();
Register<RoleBean, RoleBeanX>();
Register<RoleGroupBean, RoleGroupBeanX>();
Register<RoleMsgBean, RoleMsgBeanX>();
Register<FactionIDBean, FactionIDBeanX>();
Register<FactionInfoBean, FactionInfoBeanX>();
Register<FactionTitleBean, FactionTitleBeanX>();
Register<FactionExt, FactionExtX>();
Register<CityWar, CityWarX>();
Register<TeamBean, TeamBeanX>();
Register<DBGameTalkRoleListArg, DBGameTalkRoleListArgX>();
Register<DBGameTalkRoleRelationArg, DBGameTalkRoleRelationArgX>();
Register<DBRoleBase, DBRoleBaseX>();
Register<DBRoleGroup, DBRoleGroupX>();
Register<DBGameTalkRoleRelationRes, DBGameTalkRoleRelationResX>();
Register<DBGameTalkFactionInfoArg, DBGameTalkFactionInfoArgX>();
Register<DBFactionMember, DBFactionMemberX>();
Register<DBGameTalkFactionInfoRes, DBGameTalkFactionInfoResX>();
Register<DBGameTalkRoleStatusArg, DBGameTalkRoleStatusArgX>();
Register<DBGameTalkRoleStatusRes, DBGameTalkRoleStatusResX>();
Register<DBGameTalkRoleInfoArg, DBGameTalkRoleInfoArgX>();
Register<DBGameTalkRoleInfoRes, DBGameTalkRoleInfoResX>();
Register<SNSRoleBrief, SNSRoleBriefX>();
Register<SNSRoleSkills, SNSRoleSkillsX>();
Register<SNSRoleEquipment, SNSRoleEquipmentX>();
Register<SNSRolePetCorral, SNSRolePetCorralX>();

        }
        }
      
    public class ChallengeX : Challenge
    {
        public ChallengeX()
        {
             Nonce = new Octets(); 
 Version = default(UInt32);
 Algo = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Nonce); 
 ds.Write(Version); 
 ds.Write(Algo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Nonce)  &&
 ds.TryRead(out Version)  &&
 ds.TryRead(out Algo) ;
        }
    }
      

    public class KeyExchangeX : KeyExchange
    {
        public KeyExchangeX()
        {
             Nonce = new Octets(); 
 KickUser = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Nonce); 
 ds.Write(KickUser); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Nonce)  &&
 ds.TryRead(out KickUser) ;
        }
    }
      

    public class ResponseX : Response
    {
        public ResponseX()
        {
             Identity = new Octets(); 
 Key = new Octets(); 
 UseToken = default(Boolean);
 CliFingerprint = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Identity); 
 ds.Write(Key); 
 ds.Write(UseToken); 
 ds.Write(CliFingerprint); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Identity)  &&
 ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead(out UseToken)  &&
 ds.TryRead((IDataSerializer)CliFingerprint) ;
        }
    }
      

    public class OnlineAnnounceX : OnlineAnnounce
    {
        public OnlineAnnounceX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
 RemainTime = default(Int32);
 ZoneId = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(RemainTime); 
 ds.Write(ZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out RemainTime)  &&
 ds.TryRead(out ZoneId) ;
        }
    }
      

    public class ErrorInfoX : ErrorInfo
    {
        public ErrorInfoX()
        {
             ErrCode = default(Int32);
 Info = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ErrCode); 
 ds.Write(Info); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ErrCode)  &&
 ds.TryRead((IDataSerializer)Info) ;
        }
    }
      

    public class StatusAnnounceX : StatusAnnounce
    {
        public StatusAnnounceX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
 Status = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(Status); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Status) ;
        }
    }
      

    public class RoleStatusAnnounceX : RoleStatusAnnounce
    {
        public RoleStatusAnnounceX()
        {
             ZoneId = default(Byte);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Status = default(Boolean);
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Status); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class KickoutUserX : KickoutUser
    {
        public KickoutUserX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
 Cause = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(Cause); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Cause) ;
        }
    }
      

    public class GameDataSendX : GameDataSend
    {
        public GameDataSendX()
        {
             Data = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class ReportIPX : ReportIP
    {
        public ReportIPX()
        {
             UserID = default(Int32);
 Ip = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Ip); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out Ip) ;
        }
    }
      

    public class UpdateRemainTimeX : UpdateRemainTime
    {
        public UpdateRemainTimeX()
        {
             UserID = default(Int32);
 LocalSid = default(Int32);
 RemainTime = default(Int32);
 FreeTimeLeft = default(Int32);
 FreeTimeEnd = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(RemainTime); 
 ds.Write(FreeTimeLeft); 
 ds.Write(FreeTimeEnd); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out RemainTime)  &&
 ds.TryRead(out FreeTimeLeft)  &&
 ds.TryRead(out FreeTimeEnd) ;
        }
    }
      

    public class StatInfoVitalX : StatInfoVital
    {
        public StatInfoVitalX()
        {
             Priority = default(Int32);
 Message = new Octets(); 
 HostName = new Octets(); 
 ServiceName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Priority); 
 ds.Write(Message); 
 ds.Write(HostName); 
 ds.Write(ServiceName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Priority)  &&
 ds.TryRead((IDataSerializer)Message)  &&
 ds.TryRead((IDataSerializer)HostName)  &&
 ds.TryRead((IDataSerializer)ServiceName) ;
        }
    }
      

    public class StatInfoX : StatInfo
    {
        public StatInfoX()
        {
             Priority = default(Int32);
 Message = new Octets(); 
 HostName = new Octets(); 
 ServiceName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Priority); 
 ds.Write(Message); 
 ds.Write(HostName); 
 ds.Write(ServiceName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Priority)  &&
 ds.TryRead((IDataSerializer)Message)  &&
 ds.TryRead((IDataSerializer)HostName)  &&
 ds.TryRead((IDataSerializer)ServiceName) ;
        }
    }
      

    public class RemoteLogVitalX : RemoteLogVital
    {
        public RemoteLogVitalX()
        {
             Priority = default(Int32);
 Message = new Octets(); 
 HostName = new Octets(); 
 ServiceName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Priority); 
 ds.Write(Message); 
 ds.Write(HostName); 
 ds.Write(ServiceName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Priority)  &&
 ds.TryRead((IDataSerializer)Message)  &&
 ds.TryRead((IDataSerializer)HostName)  &&
 ds.TryRead((IDataSerializer)ServiceName) ;
        }
    }
      

    public class RemoteLogX : RemoteLog
    {
        public RemoteLogX()
        {
             Priority = default(Int32);
 Message = new Octets(); 
 HostName = new Octets(); 
 ServiceName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Priority); 
 ds.Write(Message); 
 ds.Write(HostName); 
 ds.Write(ServiceName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Priority)  &&
 ds.TryRead((IDataSerializer)Message)  &&
 ds.TryRead((IDataSerializer)HostName)  &&
 ds.TryRead((IDataSerializer)ServiceName) ;
        }
    }
      

    public class PlayerKickoutX : PlayerKickout
    {
        public PlayerKickoutX()
        {
             RoleId = default(Int32);
 ProviderLinkId = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ProviderLinkId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ProviderLinkId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class PlayerKickout_ReX : PlayerKickout_Re
    {
        public PlayerKickout_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class PlayerLoginX : PlayerLogin
    {
        public PlayerLoginX()
        {
             RoleId = default(Int32);
 ProviderLinkId = default(Int32);
 LocalSid = default(UInt32);
 Auth = new Octets(); 
 UsbBind = default(Byte);
 Flag = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ProviderLinkId); 
 ds.Write(LocalSid); 
 ds.Write(Auth); 
 ds.Write(UsbBind); 
 ds.Write(Flag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ProviderLinkId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Auth)  &&
 ds.TryRead(out UsbBind)  &&
 ds.TryRead(out Flag) ;
        }
    }
      

    public class PlayerLogin_ReX : PlayerLogin_Re
    {
        public PlayerLogin_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
 SrcProviderId = default(Int32);
 LocalSid = default(UInt32);
 Flag = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
 ds.Write(SrcProviderId); 
 ds.Write(LocalSid); 
 ds.Write(Flag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out SrcProviderId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Flag) ;
        }
    }
      

    public class PlayerOfflineX : PlayerOffline
    {
        public PlayerOfflineX()
        {
             RoleId = default(Int32);
 ProviderLinkId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ProviderLinkId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ProviderLinkId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class PlayerOffline_ReX : PlayerOffline_Re
    {
        public PlayerOffline_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class PlayerLogoutX : PlayerLogout
    {
        public PlayerLogoutX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
 ProviderLinkId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
 ds.Write(ProviderLinkId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out ProviderLinkId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SelectRoleX : SelectRole
    {
        public SelectRoleX()
        {
             RoleId = default(Int32);
 Flag = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Flag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Flag) ;
        }
    }
      

    public class SelectRole_ReX : SelectRole_Re
    {
        public SelectRole_ReX()
        {
             Result = default(Int32);
 Auth = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(Auth); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead((IDataSerializer)Auth) ;
        }
    }
      

    public class EnterWorldX : EnterWorld
    {
        public EnterWorldX()
        {
             RoleId = default(Int32);
 ProviderLinkId = default(Int32);
 LockTime = default(Int32);
 Timeout = default(Int32);
 SetTime = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ProviderLinkId); 
 ds.Write(LockTime); 
 ds.Write(Timeout); 
 ds.Write(SetTime); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ProviderLinkId)  &&
 ds.TryRead(out LockTime)  &&
 ds.TryRead(out Timeout)  &&
 ds.TryRead(out SetTime)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AnnounceProviderIDX : AnnounceProviderID
    {
        public AnnounceProviderIDX()
        {
             Id = default(Int32);
 Left = default(Single);
 Right = default(Single);
 Top = default(Single);
 Bottom = default(Single);
 Worldtag = default(Int32);
 Edition = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Left); 
 ds.Write(Right); 
 ds.Write(Top); 
 ds.Write(Bottom); 
 ds.Write(Worldtag); 
 ds.Write(Edition); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out Left)  &&
 ds.TryRead(out Right)  &&
 ds.TryRead(out Top)  &&
 ds.TryRead(out Bottom)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead((IDataSerializer)Edition) ;
        }
    }
      

    public class S2CGamedataSendX : S2CGamedataSend
    {
        public S2CGamedataSendX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Data = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class C2SGamedataSendX : C2SGamedataSend
    {
        public C2SGamedataSendX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Data = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class S2CMulticastX : S2CMulticast
    {
        public S2CMulticastX()
        {
             Data = new Octets(); 
 Playerlist = new Vector<Player, PlayerX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Data); 
 ds.Write(Playerlist); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Data)  &&
 ds.TryRead((IDataSerializer)Playerlist) ;
        }
    }
      

    public class S2CBroadcastX : S2CBroadcast
    {
        public S2CBroadcastX()
        {
             Data = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class PublicChatX : PublicChat
    {
        public PublicChatX()
        {
             Channel = default(Byte);
 Emotion = default(Byte);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Message = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Channel); 
 ds.Write(Emotion); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Channel)  &&
 ds.TryRead(out Emotion)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class ChatMessageX : ChatMessage
    {
        public ChatMessageX()
        {
             Channel = default(Byte);
 Emotion = default(Byte);
 SrcroleId = default(Int32);
 Message = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Channel); 
 ds.Write(Emotion); 
 ds.Write(SrcroleId); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Channel)  &&
 ds.TryRead(out Emotion)  &&
 ds.TryRead(out SrcroleId)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class ChatMultiCastX : ChatMultiCast
    {
        public ChatMultiCastX()
        {
             Playerlist = new Vector<Player, PlayerX>(); 
 Channel = default(Byte);
 Emotion = default(Byte);
 SrcroleId = default(Int32);
 Message = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Playerlist); 
 ds.Write(Channel); 
 ds.Write(Emotion); 
 ds.Write(SrcroleId); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Playerlist)  &&
 ds.TryRead(out Channel)  &&
 ds.TryRead(out Emotion)  &&
 ds.TryRead(out SrcroleId)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class RoleListX : RoleList
    {
        public RoleListX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
 Handle = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Handle) ;
        }
    }
      

    public class RoleList_ReX : RoleList_Re
    {
        public RoleList_ReX()
        {
             Result = default(Int32);
 Handle = default(Int32);
 UserID = default(Int32);
 LocalSid = default(UInt32);
 RoleList = new Vector<RoleInfo, RoleInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(Handle); 
 ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(RoleList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out Handle)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)RoleList) ;
        }
    }
      

    public class CreateRoleX : CreateRole
    {
        public CreateRoleX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
 RoleInfo = new RoleInfoX(); 
 ReferId = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(RoleInfo); 
 ds.Write(ReferId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)RoleInfo)  &&
 ds.TryRead((IDataSerializer)ReferId) ;
        }
    }
      

    public class CreateRole_ReX : CreateRole_Re
    {
        public CreateRole_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 RoleInfo = new RoleInfoX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(RoleInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)RoleInfo) ;
        }
    }
      

    public class DeleteRoleX : DeleteRole
    {
        public DeleteRoleX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class DeleteRole_ReX : DeleteRole_Re
    {
        public DeleteRole_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class UndoDeleteRoleX : UndoDeleteRole
    {
        public UndoDeleteRoleX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class UndoDeleteRole_ReX : UndoDeleteRole_Re
    {
        public UndoDeleteRole_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class KeepaliveX : Keepalive
    {
        public KeepaliveX()
        {
             Code = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Code); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Code) ;
        }
    }
      

    public class PlayerBaseInfoX : PlayerBaseInfo
    {
        public PlayerBaseInfoX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Playerlist = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Playerlist); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Playerlist) ;
        }
    }
      

    public class PlayerBaseInfo_ReX : PlayerBaseInfo_Re
    {
        public PlayerBaseInfo_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Player = new GRoleBaseX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Player); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Player) ;
        }
    }
      

    public class PlayerHeartBeatX : PlayerHeartBeat
    {
        public PlayerHeartBeatX()
        {
             RoleId = default(Int32);
 LinkId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LinkId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LinkId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatSingleCastX : ChatSingleCast
    {
        public ChatSingleCastX()
        {
             Channel = default(Byte);
 Emotion = default(Byte);
 SrcroleId = default(Int32);
 DstroleId = default(Int32);
 DstlocalSid = default(UInt32);
 Message = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Channel); 
 ds.Write(Emotion); 
 ds.Write(SrcroleId); 
 ds.Write(DstroleId); 
 ds.Write(DstlocalSid); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Channel)  &&
 ds.TryRead(out Emotion)  &&
 ds.TryRead(out SrcroleId)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead(out DstlocalSid)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class PlayerStatusSyncX : PlayerStatusSync
    {
        public PlayerStatusSyncX()
        {
             RoleId = default(Int32);
 ProviderLinkId = default(Int32);
 LocalSid = default(UInt32);
 Status = default(Int32);
 GSId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ProviderLinkId); 
 ds.Write(LocalSid); 
 ds.Write(Status); 
 ds.Write(GSId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ProviderLinkId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out GSId) ;
        }
    }
      

    public class PrivateChatX : PrivateChat
    {
        public PrivateChatX()
        {
             Channel = default(Byte);
 Emotion = default(Byte);
 SrcName = new Octets(); 
 SrcroleId = default(Int32);
 DstName = new Octets(); 
 DstroleId = default(Int32);
 Message = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Channel); 
 ds.Write(Emotion); 
 ds.Write(SrcName); 
 ds.Write(SrcroleId); 
 ds.Write(DstName); 
 ds.Write(DstroleId); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Channel)  &&
 ds.TryRead(out Emotion)  &&
 ds.TryRead((IDataSerializer)SrcName)  &&
 ds.TryRead(out SrcroleId)  &&
 ds.TryRead((IDataSerializer)DstName)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class PlayerBaseInfoCRCX : PlayerBaseInfoCRC
    {
        public PlayerBaseInfoCRCX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Playerlist = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Playerlist); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Playerlist) ;
        }
    }
      

    public class PlayerBaseInfoCRC_ReX : PlayerBaseInfoCRC_Re
    {
        public PlayerBaseInfoCRC_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Playerlist = new Vector<Int32>(); 
 CRClist = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Playerlist); 
 ds.Write(CRClist); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Playerlist)  &&
 ds.TryRead((IDataSerializer)CRClist) ;
        }
    }
      

    public class SetCustomDataX : SetCustomData
    {
        public SetCustomDataX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 CustomData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(CustomData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)CustomData) ;
        }
    }
      

    public class SetCustomData_ReX : SetCustomData_Re
    {
        public SetCustomData_ReX()
        {
             Result = default(Int32);
 CRC = default(UInt32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(CRC); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out CRC)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SetUIConfigX : SetUIConfig
    {
        public SetUIConfigX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 UiConfig = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(UiConfig); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)UiConfig) ;
        }
    }
      

    public class SetUIConfig_ReX : SetUIConfig_Re
    {
        public SetUIConfig_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetUIConfigX : GetUIConfig
    {
        public GetUIConfigX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetUIConfig_ReX : GetUIConfig_Re
    {
        public GetUIConfig_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 UiConfig = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(UiConfig); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)UiConfig) ;
        }
    }
      

    public class DisconnectPlayerX : DisconnectPlayer
    {
        public DisconnectPlayerX()
        {
             RoleId = default(Int32);
 ProviderLinkId = default(Int32);
 LocalSid = default(UInt32);
 GameId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ProviderLinkId); 
 ds.Write(LocalSid); 
 ds.Write(GameId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ProviderLinkId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out GameId) ;
        }
    }
      

    public class GetPlayerBriefInfoX : GetPlayerBriefInfo
    {
        public GetPlayerBriefInfoX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Playerlist = new Vector<Int32>(); 
 Reason = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Playerlist); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Playerlist)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class GetPlayerBriefInfo_ReX : GetPlayerBriefInfo_Re
    {
        public GetPlayerBriefInfo_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Playerlist = new Vector<PlayerBriefInfo, PlayerBriefInfoX>(); 
 Reason = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Playerlist); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Playerlist)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class PlayerStatusAnnounceX : PlayerStatusAnnounce
    {
        public PlayerStatusAnnounceX()
        {
             Status = default(Boolean);
 PlayerStatusList = new Vector<OnlinePlayerStatus, OnlinePlayerStatusX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
 ds.Write(PlayerStatusList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)PlayerStatusList) ;
        }
    }
      

    public class QueryPlayerStatusX : QueryPlayerStatus
    {
        public QueryPlayerStatusX()
        {
             RoleList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)RoleList) ;
        }
    }
      

    public class GetTaskDataX : GetTaskData
    {
        public GetTaskDataX()
        {
             TaskId = default(Int32);
 PlayerId = default(Int32);
 Env = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TaskId); 
 ds.Write(PlayerId); 
 ds.Write(Env); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TaskId)  &&
 ds.TryRead(out PlayerId)  &&
 ds.TryRead((IDataSerializer)Env) ;
        }
    }
      

    public class GetTaskData_ReX : GetTaskData_Re
    {
        public GetTaskData_ReX()
        {
             TaskId = default(Int32);
 PlayerId = default(Int32);
 Env = new Octets(); 
 RetCode = default(Int32);
 TaskData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TaskId); 
 ds.Write(PlayerId); 
 ds.Write(Env); 
 ds.Write(RetCode); 
 ds.Write(TaskData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TaskId)  &&
 ds.TryRead(out PlayerId)  &&
 ds.TryRead((IDataSerializer)Env)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)TaskData) ;
        }
    }
      

    public class SetTaskDataX : SetTaskData
    {
        public SetTaskDataX()
        {
             TaskId = default(Int32);
 TaskData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TaskId); 
 ds.Write(TaskData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TaskId)  &&
 ds.TryRead((IDataSerializer)TaskData) ;
        }
    }
      

    public class SetTaskData_ReX : SetTaskData_Re
    {
        public SetTaskData_ReX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class GetCustomDataX : GetCustomData
    {
        public GetCustomDataX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Playerlist = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Playerlist); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Playerlist) ;
        }
    }
      

    public class GetCustomData_ReX : GetCustomData_Re
    {
        public GetCustomData_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 CusRoleId = default(UInt32);
 CustomData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(CusRoleId); 
 ds.Write(CustomData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out CusRoleId)  &&
 ds.TryRead((IDataSerializer)CustomData) ;
        }
    }
      

    public class GetPlayerIdByNameX : GetPlayerIdByName
    {
        public GetPlayerIdByNameX()
        {
             RoleName = new Octets(); 
 LocalSid = default(UInt32);
 Reason = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleName); 
 ds.Write(LocalSid); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class GetPlayerIdByName_ReX : GetPlayerIdByName_Re
    {
        public GetPlayerIdByName_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
 RoleName = new Octets(); 
 RoleId = default(Int32);
 Reason = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(RoleName); 
 ds.Write(RoleId); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class ChatBroadCastX : ChatBroadCast
    {
        public ChatBroadCastX()
        {
             Channel = default(Byte);
 Emotion = default(Byte);
 SrcroleId = default(Int32);
 Message = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Channel); 
 ds.Write(Emotion); 
 ds.Write(SrcroleId); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Channel)  &&
 ds.TryRead(out Emotion)  &&
 ds.TryRead(out SrcroleId)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class AnnounceGMX : AnnounceGM
    {
        public AnnounceGMX()
        {
             RoleId = default(Int32);
 Auth = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Auth); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Auth) ;
        }
    }
      

    public class GMPrivilegeChangeX : GMPrivilegeChange
    {
        public GMPrivilegeChangeX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class AnnounceForbidInfoX : AnnounceForbidInfo
    {
        public AnnounceForbidInfoX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
 Forbid = new GRoleForbidX(); 
 Disconnect = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(Forbid); 
 ds.Write(Disconnect); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Forbid)  &&
 ds.TryRead(out Disconnect) ;
        }
    }
      

    public class FaceModifyX : FaceModify
    {
        public FaceModifyX()
        {
             RoleId = default(Int32);
 TicketId = default(Int32);
 TicketPos = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(TicketId); 
 ds.Write(TicketPos); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out TicketId)  &&
 ds.TryRead(out TicketPos) ;
        }
    }
      

    public class FaceModifyCancelX : FaceModifyCancel
    {
        public FaceModifyCancelX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class FaceModify_ReX : FaceModify_Re
    {
        public FaceModify_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 TicketId = default(Int32);
 TicketPos = default(Int32);
 CRC = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(TicketId); 
 ds.Write(TicketPos); 
 ds.Write(CRC); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out TicketId)  &&
 ds.TryRead(out TicketPos)  &&
 ds.TryRead(out CRC) ;
        }
    }
      

    public class SetHelpStatesX : SetHelpStates
    {
        public SetHelpStatesX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 HelpStates = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(HelpStates); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)HelpStates) ;
        }
    }
      

    public class SetHelpStates_ReX : SetHelpStates_Re
    {
        public SetHelpStates_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetHelpStatesX : GetHelpStates
    {
        public GetHelpStatesX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetHelpStates_ReX : GetHelpStates_Re
    {
        public GetHelpStates_ReX()
        {
             Result = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 HelpStates = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(HelpStates); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)HelpStates) ;
        }
    }
      

    public class AnnounceServerAttributeX : AnnounceServerAttribute
    {
        public AnnounceServerAttributeX()
        {
             Attr = default(UInt32);
 FreeCreaTime = default(Int32);
 ExpRate = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Attr); 
 ds.Write(FreeCreaTime); 
 ds.Write(ExpRate); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Attr)  &&
 ds.TryRead(out FreeCreaTime)  &&
 ds.TryRead(out ExpRate) ;
        }
    }
      

    public class WorldChatX : WorldChat
    {
        public WorldChatX()
        {
             Channel = default(Byte);
 Emotion = default(Byte);
 RoleId = default(Int32);
 Name = new Octets(); 
 Message = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Channel); 
 ds.Write(Emotion); 
 ds.Write(RoleId); 
 ds.Write(Name); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Channel)  &&
 ds.TryRead(out Emotion)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class SetChatEmotionX : SetChatEmotion
    {
        public SetChatEmotionX()
        {
             RoleId = default(Int32);
 Emotion = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Emotion); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Emotion) ;
        }
    }
      

    public class AnnounceChallengeAlgoX : AnnounceChallengeAlgo
    {
        public AnnounceChallengeAlgoX()
        {
             ChallengeAlgo = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ChallengeAlgo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ChallengeAlgo) ;
        }
    }
      

    public class AnnounceAuthdVersionX : AnnounceAuthdVersion
    {
        public AnnounceAuthdVersionX()
        {
             AuVersion = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(AuVersion); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out AuVersion) ;
        }
    }
      

    public class UserCouponX : UserCoupon
    {
        public UserCouponX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class UserCoupon_ReX : UserCoupon_Re
    {
        public UserCoupon_ReX()
        {
             RetCode = default(Int32);
 RemainCoupon = default(Int32);
 TodayExchangeCoupon = default(Int32);
 TodayRemainCoupon = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RemainCoupon); 
 ds.Write(TodayExchangeCoupon); 
 ds.Write(TodayRemainCoupon); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RemainCoupon)  &&
 ds.TryRead(out TodayExchangeCoupon)  &&
 ds.TryRead(out TodayRemainCoupon)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class UserCouponExchangeX : UserCouponExchange
    {
        public UserCouponExchangeX()
        {
             UserID = default(Int32);
 CouponNumber = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(CouponNumber); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out CouponNumber)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class UserCouponExchange_ReX : UserCouponExchange_Re
    {
        public UserCouponExchange_ReX()
        {
             RetCode = default(Int32);
 RemainCoupon = default(Int32);
 TodayExchangeCoupon = default(Int32);
 TodayRemainCoupon = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RemainCoupon); 
 ds.Write(TodayExchangeCoupon); 
 ds.Write(TodayRemainCoupon); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RemainCoupon)  &&
 ds.TryRead(out TodayExchangeCoupon)  &&
 ds.TryRead(out TodayRemainCoupon)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AddCashNotifyX : AddCashNotify
    {
        public AddCashNotifyX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class AccountLoginRecordX : AccountLoginRecord
    {
        public AccountLoginRecordX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
 LoginTime = default(Int32);
 Loginip = default(Int32);
 CurrentIp = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(LoginTime); 
 ds.Write(Loginip); 
 ds.Write(CurrentIp); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out LoginTime)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead(out CurrentIp) ;
        }
    }
      

    public class UserAddCashX : UserAddCash
    {
        public UserAddCashX()
        {
             UserID = default(Int32);
 Cardnum = new Octets(); 
 CardPasswd = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Cardnum); 
 ds.Write(CardPasswd); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)Cardnum)  &&
 ds.TryRead((IDataSerializer)CardPasswd)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class UserAddCash_ReX : UserAddCash_Re
    {
        public UserAddCash_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SynMutaDataX : SynMutaData
    {
        public SynMutaDataX()
        {
             SynMask = default(UInt32);
 RoleId = default(UInt32);
 Level = default(Int32);
 ReincarnationTimes = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(SynMask); 
 ds.Write(RoleId); 
 ds.Write(Level); 
 ds.Write(ReincarnationTimes); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out SynMask)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out ReincarnationTimes) ;
        }
    }
      

    public class SSOGetTicketX : SSOGetTicket
    {
        public SSOGetTicketX()
        {
             User = new SSOUserX(); 
 ToaId = default(Int32);
 ToZoneId = default(Int32);
 Info = new Octets(); 
 LocalContext = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(User); 
 ds.Write(ToaId); 
 ds.Write(ToZoneId); 
 ds.Write(Info); 
 ds.Write(LocalContext); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)User)  &&
 ds.TryRead(out ToaId)  &&
 ds.TryRead(out ToZoneId)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead((IDataSerializer)LocalContext) ;
        }
    }
      

    public class SSOGetTicket_ReX : SSOGetTicket_Re
    {
        public SSOGetTicket_ReX()
        {
             RetCode = default(Int32);
 Ticket = new Octets(); 
 LocalContext = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Ticket); 
 ds.Write(LocalContext); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Ticket)  &&
 ds.TryRead((IDataSerializer)LocalContext)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class QPAnnounceDiscountX : QPAnnounceDiscount
    {
        public QPAnnounceDiscountX()
        {
             LocalSid = default(Int32);
 Discount = new Vector<QPDiscountInfo, QPDiscountInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(Discount); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Discount) ;
        }
    }
      

    public class QPGetActivatedServicesX : QPGetActivatedServices
    {
        public QPGetActivatedServicesX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class QPGetActivatedServices_ReX : QPGetActivatedServices_Re
    {
        public QPGetActivatedServices_ReX()
        {
             LocalSid = default(Int32);
 Merchants = new Vector<Int32>(); 
 RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(Merchants); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Merchants)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class QPAddCashX : QPAddCash
    {
        public QPAddCashX()
        {
             UserID = default(Int32);
 Cash = default(Int32);
 CashAfterDiscount = default(Int32);
 MerchantId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Cash); 
 ds.Write(CashAfterDiscount); 
 ds.Write(MerchantId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out CashAfterDiscount)  &&
 ds.TryRead(out MerchantId) ;
        }
    }
      

    public class QPAddCash_ReX : QPAddCash_Re
    {
        public QPAddCash_ReX()
        {
             LocalSid = default(Int32);
 Cash = default(Int32);
 CashAfterDiscount = default(Int32);
 MerchantId = default(Int32);
 RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(Cash); 
 ds.Write(CashAfterDiscount); 
 ds.Write(MerchantId); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out CashAfterDiscount)  &&
 ds.TryRead(out MerchantId)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class ReportChatX : ReportChat
    {
        public ReportChatX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 DstroleId = default(Int32);
 DstRoleName = new Octets(); 
 Content = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(DstroleId); 
 ds.Write(DstRoleName); 
 ds.Write(Content); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead((IDataSerializer)DstRoleName)  &&
 ds.TryRead((IDataSerializer)Content) ;
        }
    }
      

    public class CashMoneyExchangeNotifyX : CashMoneyExchangeNotify
    {
        public CashMoneyExchangeNotifyX()
        {
             Open = default(Byte);
 Rate = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Open); 
 ds.Write(Rate); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Open)  &&
 ds.TryRead(out Rate) ;
        }
    }
      

    public class PlayerNameUpdateX : PlayerNameUpdate
    {
        public PlayerNameUpdateX()
        {
             RoleId = default(Int32);
 NewName = new Octets(); 
 LinkLocalsidList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(NewName); 
 ds.Write(LinkLocalsidList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)NewName)  &&
 ds.TryRead((IDataSerializer)LinkLocalsidList) ;
        }
    }
      

    public class MobileServerRegisterX : MobileServerRegister
    {
        public MobileServerRegisterX()
        {
             ServerId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ServerId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ServerId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class ServerForbidNotifyX : ServerForbidNotify
    {
        public ServerForbidNotifyX()
        {
             ForbidCtrlList = new Vector<Int32>(); 
 ForbidItemList = new Vector<Int32>(); 
 ForbidServiceList = new Vector<Int32>(); 
 ForbidTaskList = new Vector<Int32>(); 
 ForbidSkillList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ForbidCtrlList); 
 ds.Write(ForbidItemList); 
 ds.Write(ForbidServiceList); 
 ds.Write(ForbidTaskList); 
 ds.Write(ForbidSkillList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ForbidCtrlList)  &&
 ds.TryRead((IDataSerializer)ForbidItemList)  &&
 ds.TryRead((IDataSerializer)ForbidServiceList)  &&
 ds.TryRead((IDataSerializer)ForbidTaskList)  &&
 ds.TryRead((IDataSerializer)ForbidSkillList) ;
        }
    }
      

    public class PlayerAccuseX : PlayerAccuse
    {
        public PlayerAccuseX()
        {
             RoleId = default(Int32);
 DstroleId = default(Int32);
 Content = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(DstroleId); 
 ds.Write(Content); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead((IDataSerializer)Content) ;
        }
    }
      

    public class PlayerAccuse_ReX : PlayerAccuse_Re
    {
        public PlayerAccuse_ReX()
        {
             LocalSid = default(UInt32);
 DstroleId = default(Int32);
 ReCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(DstroleId); 
 ds.Write(ReCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead(out ReCode) ;
        }
    }
      

    public class ServerTriggerNotifyX : ServerTriggerNotify
    {
        public ServerTriggerNotifyX()
        {
             TriggerCtrlList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TriggerCtrlList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)TriggerCtrlList) ;
        }
    }
      

    public class AddFriendX : AddFriend
    {
        public AddFriendX()
        {
             SrcroleId = default(Int32);
 DstroleId = default(Int32);
 DstName = new Octets(); 
 SrclSId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(SrcroleId); 
 ds.Write(DstroleId); 
 ds.Write(DstName); 
 ds.Write(SrclSId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out SrcroleId)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead((IDataSerializer)DstName)  &&
 ds.TryRead(out SrclSId) ;
        }
    }
      

    public class AddFriend_ReX : AddFriend_Re
    {
        public AddFriend_ReX()
        {
             RetCode = default(Byte);
 Info = new GFriendInfoX(); 
 SrclSId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Info); 
 ds.Write(SrclSId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead(out SrclSId) ;
        }
    }
      

    public class GetFriendsX : GetFriends
    {
        public GetFriendsX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetFriends_ReX : GetFriends_Re
    {
        public GetFriends_ReX()
        {
             RoleId = default(Int32);
 Groups = new Vector<GGroupInfo, GGroupInfoX>(); 
 Friends = new Vector<GFriendInfo, GFriendInfoX>(); 
 Status = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Groups); 
 ds.Write(Friends); 
 ds.Write(Status); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Groups)  &&
 ds.TryRead((IDataSerializer)Friends)  &&
 ds.TryRead((IDataSerializer)Status)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SetGroupNameX : SetGroupName
    {
        public SetGroupNameX()
        {
             RoleId = default(Int32);
 GId = default(Byte);
 Name = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(GId); 
 ds.Write(Name); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out GId)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SetGroupName_ReX : SetGroupName_Re
    {
        public SetGroupName_ReX()
        {
             RetCode = default(Byte);
 RoleId = default(Int32);
 GId = default(Byte);
 Name = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(GId); 
 ds.Write(Name); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out GId)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SetFriendGroupX : SetFriendGroup
    {
        public SetFriendGroupX()
        {
             GId = default(Byte);
 RoleId = default(Int32);
 FriendId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GId); 
 ds.Write(RoleId); 
 ds.Write(FriendId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out FriendId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SetFriendGroup_ReX : SetFriendGroup_Re
    {
        public SetFriendGroup_ReX()
        {
             RetCode = default(Byte);
 GId = default(Byte);
 RoleId = default(Int32);
 FriendId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(GId); 
 ds.Write(RoleId); 
 ds.Write(FriendId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out GId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out FriendId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class DelFriendX : DelFriend
    {
        public DelFriendX()
        {
             RoleId = default(Int32);
 FriendId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(FriendId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out FriendId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class DelFriend_ReX : DelFriend_Re
    {
        public DelFriend_ReX()
        {
             RetCode = default(Byte);
 RoleId = default(Int32);
 FriendId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(FriendId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out FriendId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FriendStatusX : FriendStatus
    {
        public FriendStatusX()
        {
             RoleId = default(Int32);
 Status = default(Boolean);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Status); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetSavedMsgX : GetSavedMsg
    {
        public GetSavedMsgX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetSavedMsg_ReX : GetSavedMsg_Re
    {
        public GetSavedMsg_ReX()
        {
             RetCode = default(Byte);
 Messages = new Vector<Message, MessageX>(); 
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Messages); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Messages)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomCreateX : ChatRoomCreate
    {
        public ChatRoomCreateX()
        {
             RoleId = default(Int32);
 Subject = new Octets(); 
 Capacity = default(UInt16);
 Password = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Subject); 
 ds.Write(Capacity); 
 ds.Write(Password); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Subject)  &&
 ds.TryRead(out Capacity)  &&
 ds.TryRead((IDataSerializer)Password)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomCreate_ReX : ChatRoomCreate_Re
    {
        public ChatRoomCreate_ReX()
        {
             RetCode = default(Int16);
 RoomId = default(UInt16);
 Subject = new Octets(); 
 Capacity = default(UInt16);
 Status = default(Boolean);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoomId); 
 ds.Write(Subject); 
 ds.Write(Capacity); 
 ds.Write(Status); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoomId)  &&
 ds.TryRead((IDataSerializer)Subject)  &&
 ds.TryRead(out Capacity)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomInviteX : ChatRoomInvite
    {
        public ChatRoomInviteX()
        {
             RoomId = default(UInt16);
 Invitee = default(Int32);
 Inviter = default(Int32);
 Name = new Octets(); 
 Subject = new Octets(); 
 Capacity = default(UInt16);
 Number = default(UInt16);
 Password = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoomId); 
 ds.Write(Invitee); 
 ds.Write(Inviter); 
 ds.Write(Name); 
 ds.Write(Subject); 
 ds.Write(Capacity); 
 ds.Write(Number); 
 ds.Write(Password); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoomId)  &&
 ds.TryRead(out Invitee)  &&
 ds.TryRead(out Inviter)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)Subject)  &&
 ds.TryRead(out Capacity)  &&
 ds.TryRead(out Number)  &&
 ds.TryRead((IDataSerializer)Password)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomInvite_ReX : ChatRoomInvite_Re
    {
        public ChatRoomInvite_ReX()
        {
             RoomId = default(UInt16);
 Invitee = default(Int32);
 Inviter = default(Int32);
 RetCode = default(Int16);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoomId); 
 ds.Write(Invitee); 
 ds.Write(Inviter); 
 ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoomId)  &&
 ds.TryRead(out Invitee)  &&
 ds.TryRead(out Inviter)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomJoinX : ChatRoomJoin
    {
        public ChatRoomJoinX()
        {
             RoomId = default(UInt16);
 OwnerId = default(Int32);
 OwnerName = new Octets(); 
 RoleId = default(UInt32);
 Password = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoomId); 
 ds.Write(OwnerId); 
 ds.Write(OwnerName); 
 ds.Write(RoleId); 
 ds.Write(Password); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoomId)  &&
 ds.TryRead(out OwnerId)  &&
 ds.TryRead((IDataSerializer)OwnerName)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Password)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomJoin_ReX : ChatRoomJoin_Re
    {
        public ChatRoomJoin_ReX()
        {
             RetCode = default(Int16);
 RoomId = default(UInt16);
 RoleId = default(Int32);
 Name = new Octets(); 
 Detail = new GRoomDetailX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoomId); 
 ds.Write(RoleId); 
 ds.Write(Name); 
 ds.Write(Detail); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoomId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)Detail)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomLeaveX : ChatRoomLeave
    {
        public ChatRoomLeaveX()
        {
             RoomId = default(UInt16);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoomId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoomId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomExpelX : ChatRoomExpel
    {
        public ChatRoomExpelX()
        {
             RoomId = default(UInt16);
 RoleId = default(Int32);
 Owner = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoomId); 
 ds.Write(RoleId); 
 ds.Write(Owner); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoomId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Owner)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomSpeakX : ChatRoomSpeak
    {
        public ChatRoomSpeakX()
        {
             RoomId = default(UInt16);
 Emotion = default(Byte);
 Message = new Octets(); 
 Src = default(Int32);
 Dst = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoomId); 
 ds.Write(Emotion); 
 ds.Write(Message); 
 ds.Write(Src); 
 ds.Write(Dst); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoomId)  &&
 ds.TryRead(out Emotion)  &&
 ds.TryRead((IDataSerializer)Message)  &&
 ds.TryRead(out Src)  &&
 ds.TryRead(out Dst)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomListX : ChatRoomList
    {
        public ChatRoomListX()
        {
             Begin = default(UInt16);
 Reverse = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Begin); 
 ds.Write(Reverse); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Begin)  &&
 ds.TryRead(out Reverse)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ChatRoomList_ReX : ChatRoomList_Re
    {
        public ChatRoomList_ReX()
        {
             Sum = default(UInt16);
 Rooms = new Vector<GChatRoom, GChatRoomX>(); 
 End = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sum); 
 ds.Write(Rooms); 
 ds.Write(End); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sum)  &&
 ds.TryRead((IDataSerializer)Rooms)  &&
 ds.TryRead(out End)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FriendExtListX : FriendExtList
    {
        public FriendExtListX()
        {
             RoleId = default(Int32);
 ExtraInfo = new Vector<GFriendExtInfo, GFriendExtInfoX>(); 
 SendInfo = new Vector<GSendAUMailRecord, GSendAUMailRecordX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ExtraInfo); 
 ds.Write(SendInfo); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)ExtraInfo)  &&
 ds.TryRead((IDataSerializer)SendInfo)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class DBFriendExtListX : DBFriendExtList
    {
        public DBFriendExtListX()
        {
             RId = default(Int32);
 RoleIdList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RId); 
 ds.Write(RoleIdList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RId)  &&
 ds.TryRead((IDataSerializer)RoleIdList) ;
        }
    }
      

    public class DBFriendExtList_ReX : DBFriendExtList_Re
    {
        public DBFriendExtList_ReX()
        {
             RetCode = default(Int32);
 RId = default(Int32);
 Friendext = new Vector<GFriendExtInfo, GFriendExtInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RId); 
 ds.Write(Friendext); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RId)  &&
 ds.TryRead((IDataSerializer)Friendext) ;
        }
    }
      

    public class SendAUMailX : SendAUMail
    {
        public SendAUMailX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 FriendId = default(Int32);
 MailTemplateId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(FriendId); 
 ds.Write(MailTemplateId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out FriendId)  &&
 ds.TryRead(out MailTemplateId) ;
        }
    }
      

    public class SendAUMail_ReX : SendAUMail_Re
    {
        public SendAUMail_ReX()
        {
             RoleId = default(Int32);
 Result = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Result); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Result)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AUMailSendedX : AUMailSended
    {
        public AUMailSendedX()
        {
             RoleId = default(Int32);
 Level = default(Int32);
 ExtReward = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Level); 
 ds.Write(ExtReward); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out ExtReward) ;
        }
    }
      

    public class GMOnlineNumX : GMOnlineNum
    {
        public GMOnlineNumX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GMOnlineNum_ReX : GMOnlineNum_Re
    {
        public GMOnlineNum_ReX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
 TotalNum = default(Int32);
 LocalNum = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(TotalNum); 
 ds.Write(LocalNum); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out TotalNum)  &&
 ds.TryRead(out LocalNum) ;
        }
    }
      

    public class GMListOnlineUserX : GMListOnlineUser
    {
        public GMListOnlineUserX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
 Handler = default(Int32);
 Cond = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(Handler); 
 ds.Write(Cond); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Handler)  &&
 ds.TryRead((IDataSerializer)Cond) ;
        }
    }
      

    public class GMListOnlineUser_ReX : GMListOnlineUser_Re
    {
        public GMListOnlineUser_ReX()
        {
             RetCode = default(Int32);
 GmroleId = default(Int32);
 LocalSid = default(UInt32);
 Handler = default(Int32);
 UserList = new Vector<GMPlayerInfo, GMPlayerInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(Handler); 
 ds.Write(UserList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Handler)  &&
 ds.TryRead((IDataSerializer)UserList) ;
        }
    }
      

    public class GMKickoutUserX : GMKickoutUser
    {
        public GMKickoutUserX()
        {
             GmroleId = default(Int32);
 LocalSid = default(Int32);
 KickUserId = default(Int32);
 ForbidTime = default(Int32);
 Reason = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(KickUserId); 
 ds.Write(ForbidTime); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out KickUserId)  &&
 ds.TryRead(out ForbidTime)  &&
 ds.TryRead((IDataSerializer)Reason) ;
        }
    }
      

    public class GMKickoutUser_ReX : GMKickoutUser_Re
    {
        public GMKickoutUser_ReX()
        {
             RetCode = default(Int32);
 GmroleId = default(Int32);
 LocalSid = default(Int32);
 KickUserId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(KickUserId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out KickUserId) ;
        }
    }
      

    public class GMShutupX : GMShutup
    {
        public GMShutupX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
 DstUserId = default(Int32);
 ForbidTime = default(Int32);
 Reason = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(DstUserId); 
 ds.Write(ForbidTime); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out DstUserId)  &&
 ds.TryRead(out ForbidTime)  &&
 ds.TryRead((IDataSerializer)Reason) ;
        }
    }
      

    public class GMShutup_ReX : GMShutup_Re
    {
        public GMShutup_ReX()
        {
             RetCode = default(Int32);
 DstUserId = default(Int32);
 ForbidTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DstUserId); 
 ds.Write(ForbidTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DstUserId)  &&
 ds.TryRead(out ForbidTime) ;
        }
    }
      

    public class GMRestartServerX : GMRestartServer
    {
        public GMRestartServerX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
 GSId = default(Int32);
 RestartTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(GSId); 
 ds.Write(RestartTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out GSId)  &&
 ds.TryRead(out RestartTime) ;
        }
    }
      

    public class GMRestartServer_ReX : GMRestartServer_Re
    {
        public GMRestartServer_ReX()
        {
             RetCode = default(Int32);
 GmroleId = default(Int32);
 LocalSid = default(UInt32);
 GSId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(GSId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out GSId) ;
        }
    }
      

    public class GMKickoutRoleX : GMKickoutRole
    {
        public GMKickoutRoleX()
        {
             GmroleId = default(Int32);
 LocalSid = default(Int32);
 KickroleId = default(Int32);
 ForbidTime = default(Int32);
 Reason = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(KickroleId); 
 ds.Write(ForbidTime); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out KickroleId)  &&
 ds.TryRead(out ForbidTime)  &&
 ds.TryRead((IDataSerializer)Reason) ;
        }
    }
      

    public class GMKickoutRole_ReX : GMKickoutRole_Re
    {
        public GMKickoutRole_ReX()
        {
             RetCode = default(Int32);
 GmroleId = default(Int32);
 LocalSid = default(Int32);
 KickroleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(KickroleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out KickroleId) ;
        }
    }
      

    public class GMShutupRoleX : GMShutupRole
    {
        public GMShutupRoleX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
 DstroleId = default(Int32);
 ForbidTime = default(Int32);
 Reason = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(DstroleId); 
 ds.Write(ForbidTime); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead(out ForbidTime)  &&
 ds.TryRead((IDataSerializer)Reason) ;
        }
    }
      

    public class GMShutupRole_ReX : GMShutupRole_Re
    {
        public GMShutupRole_ReX()
        {
             RetCode = default(Int32);
 DstroleId = default(Int32);
 ForbidTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DstroleId); 
 ds.Write(ForbidTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead(out ForbidTime) ;
        }
    }
      

    public class GMToggleChatX : GMToggleChat
    {
        public GMToggleChatX()
        {
             GmroleId = default(Int32);
 LocalSid = default(Int32);
 Enable = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(Enable); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Enable) ;
        }
    }
      

    public class GMToggleChat_ReX : GMToggleChat_Re
    {
        public GMToggleChat_ReX()
        {
             RetCode = default(Int32);
 GmroleId = default(Int32);
 LocalSid = default(Int32);
 Enable = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(Enable); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Enable) ;
        }
    }
      

    public class GMForbidRoleX : GMForbidRole
    {
        public GMForbidRoleX()
        {
             FbdType = default(Byte);
 GmroleId = default(Int32);
 LocalSid = default(UInt32);
 DstroleId = default(Int32);
 ForbidTime = default(Int32);
 Reason = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FbdType); 
 ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(DstroleId); 
 ds.Write(ForbidTime); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FbdType)  &&
 ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead(out ForbidTime)  &&
 ds.TryRead((IDataSerializer)Reason) ;
        }
    }
      

    public class GMForbidRole_ReX : GMForbidRole_Re
    {
        public GMForbidRole_ReX()
        {
             RetCode = default(Int32);
 FbdType = default(Byte);
 DstroleId = default(Int32);
 ForbidTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(FbdType); 
 ds.Write(DstroleId); 
 ds.Write(ForbidTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out FbdType)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead(out ForbidTime) ;
        }
    }
      

    public class Report2GMX : Report2GM
    {
        public Report2GMX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 RoleName = new Octets(); 
 ZoneId = default(Int32);
 MapZone = new Octets(); 
 PosX = default(Single);
 PosY = default(Single);
 PosZ = default(Single);
 Content = new Octets(); 
 AId = default(Int32);
 Line = new Octets(); 
 ComRoleId = default(Int32);
 ComRoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(RoleName); 
 ds.Write(ZoneId); 
 ds.Write(MapZone); 
 ds.Write(PosX); 
 ds.Write(PosY); 
 ds.Write(PosZ); 
 ds.Write(Content); 
 ds.Write(AId); 
 ds.Write(Line); 
 ds.Write(ComRoleId); 
 ds.Write(ComRoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead((IDataSerializer)MapZone)  &&
 ds.TryRead(out PosX)  &&
 ds.TryRead(out PosY)  &&
 ds.TryRead(out PosZ)  &&
 ds.TryRead((IDataSerializer)Content)  &&
 ds.TryRead(out AId)  &&
 ds.TryRead((IDataSerializer)Line)  &&
 ds.TryRead(out ComRoleId)  &&
 ds.TryRead((IDataSerializer)ComRoleName) ;
        }
    }
      

    public class Report2GM_ReX : Report2GM_Re
    {
        public Report2GM_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class Complain2GMX : Complain2GM
    {
        public Complain2GMX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 RoleName = new Octets(); 
 CompRoleName = new Octets(); 
 ZoneId = default(Int32);
 MapZone = new Octets(); 
 PosX = default(Single);
 PosY = default(Single);
 PosZ = default(Single);
 Content = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(RoleName); 
 ds.Write(CompRoleName); 
 ds.Write(ZoneId); 
 ds.Write(MapZone); 
 ds.Write(PosX); 
 ds.Write(PosY); 
 ds.Write(PosZ); 
 ds.Write(Content); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead((IDataSerializer)CompRoleName)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead((IDataSerializer)MapZone)  &&
 ds.TryRead(out PosX)  &&
 ds.TryRead(out PosY)  &&
 ds.TryRead(out PosZ)  &&
 ds.TryRead((IDataSerializer)Content) ;
        }
    }
      

    public class Complain2GM_ReX : Complain2GM_Re
    {
        public Complain2GM_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AnnounceLinkTypeX : AnnounceLinkType
    {
        public AnnounceLinkTypeX()
        {
             LinkType = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LinkType); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LinkType) ;
        }
    }
      

    public class SetMaxOnlineNumX : SetMaxOnlineNum
    {
        public SetMaxOnlineNumX()
        {
             Maxnum = default(Int32);
 FakeMaxnum = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Maxnum); 
 ds.Write(FakeMaxnum); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Maxnum)  &&
 ds.TryRead(out FakeMaxnum) ;
        }
    }
      

    public class SetMaxOnlineNum_ReX : SetMaxOnlineNum_Re
    {
        public SetMaxOnlineNum_ReX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class GMForbidSellPointX : GMForbidSellPoint
    {
        public GMForbidSellPointX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
 ForbidTime = default(Int32);
 On = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(ForbidTime); 
 ds.Write(On); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out ForbidTime)  &&
 ds.TryRead(out On) ;
        }
    }
      

    public class GMForbidSellPoint_ReX : GMForbidSellPoint_Re
    {
        public GMForbidSellPoint_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GMControlGameX : GMControlGame
    {
        public GMControlGameX()
        {
             XId = default(Int32);
 Worldtag = default(Int32);
 Command = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(XId); 
 ds.Write(Worldtag); 
 ds.Write(Command); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out XId)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead((IDataSerializer)Command) ;
        }
    }
      

    public class GMControlGame_ReX : GMControlGame_Re
    {
        public GMControlGame_ReX()
        {
             XId = default(Int32);
 RetCode = default(Int32);
 ResVector = new Vector<GMControlGameRes, GMControlGameResX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(XId); 
 ds.Write(RetCode); 
 ds.Write(ResVector); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out XId)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)ResVector) ;
        }
    }
      

    public class GMGetPlayerConsumeInfoX : GMGetPlayerConsumeInfo
    {
        public GMGetPlayerConsumeInfoX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
 Playerlist = new Vector<Int32>(); 
 Reason = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(Playerlist); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Playerlist)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class GMGetPlayerConsumeInfo_ReX : GMGetPlayerConsumeInfo_Re
    {
        public GMGetPlayerConsumeInfo_ReX()
        {
             RetCode = default(Int32);
 GmroleId = default(Int32);
 LocalSid = default(UInt32);
 Playerlist = new Vector<PlayerConsumeInfo, PlayerConsumeInfoX>(); 
 Reason = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(Playerlist); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Playerlist)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class GMSetTimelessAutoLockX : GMSetTimelessAutoLock
    {
        public GMSetTimelessAutoLockX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
 DstroleId = default(Int32);
 Enable = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(DstroleId); 
 ds.Write(Enable); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead(out Enable) ;
        }
    }
      

    public class GMSetTimelessAutoLock_ReX : GMSetTimelessAutoLock_Re
    {
        public GMSetTimelessAutoLock_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
 DstroleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(DstroleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out DstroleId) ;
        }
    }
      

    public class IWebAutolockGetX : IWebAutolockGet
    {
        public IWebAutolockGetX()
        {
             TId = default(Int32);
 UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out UserID) ;
        }
    }
      

    public class IWebAutolockGet_ReX : IWebAutolockGet_Re
    {
        public IWebAutolockGet_ReX()
        {
             TId = default(Int32);
 RetCode = default(Int32);
 UserID = default(Int32);
 SetTime = default(Int32);
 LockTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(SetTime); 
 ds.Write(LockTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out SetTime)  &&
 ds.TryRead(out LockTime) ;
        }
    }
      

    public class IWebAutolockSetX : IWebAutolockSet
    {
        public IWebAutolockSetX()
        {
             TId = default(Int32);
 UserID = default(Int32);
 LockTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(UserID); 
 ds.Write(LockTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out LockTime) ;
        }
    }
      

    public class IWebAutolockSet_ReX : IWebAutolockSet_Re
    {
        public IWebAutolockSet_ReX()
        {
             TId = default(Int32);
 RetCode = default(Int32);
 UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RetCode); 
 ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID) ;
        }
    }
      

    public class StockCommissionX : StockCommission
    {
        public StockCommissionX()
        {
             RoleId = default(Int32);
 Isbuy = default(Byte);
 Price = default(Int32);
 Volume = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Isbuy); 
 ds.Write(Price); 
 ds.Write(Volume); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Isbuy)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out Volume)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class StockTransactionX : StockTransaction
    {
        public StockTransactionX()
        {
             RoleId = default(Int32);
 WithDraw = default(Byte);
 Cash = default(Int32);
 Money = default(Int32);
 LocalSid = default(UInt32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(WithDraw); 
 ds.Write(Cash); 
 ds.Write(Money); 
 ds.Write(LocalSid); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out WithDraw)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class StockBillX : StockBill
    {
        public StockBillX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class StockBill_ReX : StockBill_Re
    {
        public StockBill_ReX()
        {
             LocalSid = default(UInt32);
 Orders = new Vector<StockOrder, StockOrderX>(); 
 Logs = new Vector<StockLog, StockLogX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(Orders); 
 ds.Write(Logs); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Orders)  &&
 ds.TryRead((IDataSerializer)Logs) ;
        }
    }
      

    public class StockAccountX : StockAccount
    {
        public StockAccountX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class StockAccount_ReX : StockAccount_Re
    {
        public StockAccount_ReX()
        {
             Cash = default(Int32);
 Money = default(Int32);
 Prices = new Vector<StockPrice, StockPriceX>(); 
 Locked = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Cash); 
 ds.Write(Money); 
 ds.Write(Prices); 
 ds.Write(Locked); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Cash)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Prices)  &&
 ds.TryRead(out Locked)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class StockCommission_ReX : StockCommission_Re
    {
        public StockCommission_ReX()
        {
             RetCode = default(Int32);
 Cash = default(Int32);
 Money = default(Int32);
 Prices = new Vector<StockPrice, StockPriceX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cash); 
 ds.Write(Money); 
 ds.Write(Prices); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Prices)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class StockTransaction_ReX : StockTransaction_Re
    {
        public StockTransaction_ReX()
        {
             RetCode = default(Int32);
 Cash = default(Int32);
 Money = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cash); 
 ds.Write(Money); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class StockCancelX : StockCancel
    {
        public StockCancelX()
        {
             RoleId = default(Int32);
 TId = default(UInt32);
 Price = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(TId); 
 ds.Write(Price); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class StockCancel_ReX : StockCancel_Re
    {
        public StockCancel_ReX()
        {
             RetCode = default(Int32);
 TId = default(UInt32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AccountingRequestX : AccountingRequest
    {
        public AccountingRequestX()
        {
             Stamp = default(UInt32);
 UserID = default(Int32);
 Authenticator = new Octets(); 
 Attributes = new Vector<AccntParam, AccntParamX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Stamp); 
 ds.Write(UserID); 
 ds.Write(Authenticator); 
 ds.Write(Attributes); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Stamp)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)Authenticator)  &&
 ds.TryRead((IDataSerializer)Attributes) ;
        }
    }
      

    public class AccountingResponseX : AccountingResponse
    {
        public AccountingResponseX()
        {
             Stamp = default(UInt32);
 UserID = default(Int32);
 Authenticator = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Stamp); 
 ds.Write(UserID); 
 ds.Write(Authenticator); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Stamp)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)Authenticator) ;
        }
    }
      

    public class AnnounceZoneidX : AnnounceZoneid
    {
        public AnnounceZoneidX()
        {
             ZoneId = default(Byte);
 AId = default(Byte);
 reset = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(AId); 
 ds.Write(reset); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out AId)  &&
 ds.TryRead(out reset) ;
        }
    }
      

    public class QueryUserPrivilegeX : QueryUserPrivilege
    {
        public QueryUserPrivilegeX()
        {
             UserID = default(Int32);
 ZoneId = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(ZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId) ;
        }
    }
      

    public class QueryUserPrivilege_ReX : QueryUserPrivilege_Re
    {
        public QueryUserPrivilege_ReX()
        {
             UserID = default(Int32);
 Auth = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Auth); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)Auth) ;
        }
    }
      

    public class QueryUserForbidX : QueryUserForbid
    {
        public QueryUserForbidX()
        {
             UserID = default(Int32);
 ZoneId = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(ZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId) ;
        }
    }
      

    public class QueryUserForbid_ReX : QueryUserForbid_Re
    {
        public QueryUserForbid_ReX()
        {
             UserID = default(Int32);
 ListType = default(Int32);
 Forbid = new Vector<GRoleForbid, GRoleForbidX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(ListType); 
 ds.Write(Forbid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out ListType)  &&
 ds.TryRead((IDataSerializer)Forbid) ;
        }
    }
      

    public class QueryRewardTypeX : QueryRewardType
    {
        public QueryRewardTypeX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class QueryRewardType_ReX : QueryRewardType_Re
    {
        public QueryRewardType_ReX()
        {
             RoleId = default(Int32);
 Reward = default(Int32);
 Reward2 = default(Int32);
 Param = default(Int32);
 RewardMask = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Reward); 
 ds.Write(Reward2); 
 ds.Write(Param); 
 ds.Write(RewardMask); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Reward)  &&
 ds.TryRead(out Reward2)  &&
 ds.TryRead(out Param)  &&
 ds.TryRead(out RewardMask) ;
        }
    }
      

    public class QueryGameServerAttrX : QueryGameServerAttr
    {
        public QueryGameServerAttrX()
        {
             Paddings = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Paddings); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Paddings) ;
        }
    }
      

    public class QueryGameServerAttr_ReX : QueryGameServerAttr_Re
    {
        public QueryGameServerAttr_ReX()
        {
             Attr = new Vector<GameAttr, GameAttrX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Attr); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Attr) ;
        }
    }
      

    public class AddCashX : AddCash
    {
        public AddCashX()
        {
             UserID = default(Int32);
 ZoneId = default(Int32);
 Sn = default(Int32);
 Cash = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(ZoneId); 
 ds.Write(Sn); 
 ds.Write(Cash); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out Cash) ;
        }
    }
      

    public class AddCash_ReX : AddCash_Re
    {
        public AddCash_ReX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 ZoneId = default(Int32);
 Sn = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(ZoneId); 
 ds.Write(Sn); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Sn) ;
        }
    }
      

    public class UseCashX : UseCash
    {
        public UseCashX()
        {
             UserID = default(Int32);
 ZoneId = default(Int32);
 AId = default(Int32);
 Point = default(Int32);
 Cash = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(ZoneId); 
 ds.Write(AId); 
 ds.Write(Point); 
 ds.Write(Cash); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out AId)  &&
 ds.TryRead(out Point)  &&
 ds.TryRead(out Cash) ;
        }
    }
      

    public class UseCash_ReX : UseCash_Re
    {
        public UseCash_ReX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 ZoneId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(ZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId) ;
        }
    }
      

    public class VerifyMasterX : VerifyMaster
    {
        public VerifyMasterX()
        {
             ZoneId = default(Int32);
 RoleId = default(Int32);
 RoleName = new Octets(); 
 Faction = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(RoleId); 
 ds.Write(RoleName); 
 ds.Write(Faction); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead((IDataSerializer)Faction) ;
        }
    }
      

    public class VerifyMaster_ReX : VerifyMaster_Re
    {
        public VerifyMaster_ReX()
        {
             RoleName = new Octets(); 
 Ret = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleName); 
 ds.Write(Ret); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead(out Ret) ;
        }
    }
      

    public class DebugAddCashX : DebugAddCash
    {
        public DebugAddCashX()
        {
             UserID = default(Int32);
 Cash = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Cash); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out Cash) ;
        }
    }
      

    public class AnnounceZoneid2X : AnnounceZoneid2
    {
        public AnnounceZoneid2X()
        {
             ZoneId = default(Int32);
 AId = default(Int32);
 reset = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(AId); 
 ds.Write(reset); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out AId)  &&
 ds.TryRead(out reset) ;
        }
    }
      

    public class AnnounceZoneid3X : AnnounceZoneid3
    {
        public AnnounceZoneid3X()
        {
             ZoneId = default(Int32);
 AId = default(Int32);
 reset = default(Boolean);
 Ip1 = default(Int32);
 Ip2 = default(Int32);
 Ip3 = default(Int32);
 GetAuVersion = default(Int32);
 Reserved = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(AId); 
 ds.Write(reset); 
 ds.Write(Ip1); 
 ds.Write(Ip2); 
 ds.Write(Ip3); 
 ds.Write(GetAuVersion); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out AId)  &&
 ds.TryRead(out reset)  &&
 ds.TryRead(out Ip1)  &&
 ds.TryRead(out Ip2)  &&
 ds.TryRead(out Ip3)  &&
 ds.TryRead(out GetAuVersion)  &&
 ds.TryRead(out Reserved) ;
        }
    }
      

    public class NetBarAnnounceX : NetBarAnnounce
    {
        public NetBarAnnounceX()
        {
             UserID = default(Int32);
 AId = default(Int32);
 ZoneId = default(Int32);
 Title = default(Int32);
 RoleName = new Octets(); 
 NetbarId = default(Int32);
 NetbarZone = default(Int32);
 NetbarName = new Octets(); 
 NetbarLevel = default(Int32);
 NetbarTitle = new Octets(); 
 AwardType = new Octets(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(AId); 
 ds.Write(ZoneId); 
 ds.Write(Title); 
 ds.Write(RoleName); 
 ds.Write(NetbarId); 
 ds.Write(NetbarZone); 
 ds.Write(NetbarName); 
 ds.Write(NetbarLevel); 
 ds.Write(NetbarTitle); 
 ds.Write(AwardType); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out AId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Title)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead(out NetbarId)  &&
 ds.TryRead(out NetbarZone)  &&
 ds.TryRead((IDataSerializer)NetbarName)  &&
 ds.TryRead(out NetbarLevel)  &&
 ds.TryRead((IDataSerializer)NetbarTitle)  &&
 ds.TryRead((IDataSerializer)AwardType)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class CertRequestX : CertRequest
    {
        public CertRequestX()
        {
             Reserved1 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Reserved1); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Reserved1) ;
        }
    }
      

    public class CertAnswerX : CertAnswer
    {
        public CertAnswerX()
        {
             AuthdCert = new Octets(); 
 Reserved1 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(AuthdCert); 
 ds.Write(Reserved1); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)AuthdCert)  &&
 ds.TryRead(out Reserved1) ;
        }
    }
      

    public class CertKeyX : CertKey
    {
        public CertKeyX()
        {
             DKey1Encrypt = new Octets(); 
 DKey2Encrypt = new Octets(); 
 Reserved1 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(DKey1Encrypt); 
 ds.Write(DKey2Encrypt); 
 ds.Write(Reserved1); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)DKey1Encrypt)  &&
 ds.TryRead((IDataSerializer)DKey2Encrypt)  &&
 ds.TryRead(out Reserved1) ;
        }
    }
      

    public class CertFinishX : CertFinish
    {
        public CertFinishX()
        {
             Reserved1 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Reserved1); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Reserved1) ;
        }
    }
      

    public class MatrixChallengeX : MatrixChallenge
    {
        public MatrixChallengeX()
        {
             Algorithm = default(Int32);
 Nonce = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Algorithm); 
 ds.Write(Nonce); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Algorithm)  &&
 ds.TryRead(out Nonce) ;
        }
    }
      

    public class MatrixResponseX : MatrixResponse
    {
        public MatrixResponseX()
        {
             Response = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Response); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Response) ;
        }
    }
      

    public class MatrixFailureX : MatrixFailure
    {
        public MatrixFailureX()
        {
             UserID = default(Int32);
 Loginip = default(Int32);
 Weight = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Loginip); 
 ds.Write(Weight); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead(out Weight) ;
        }
    }
      

    public class AddictionControlX : AddictionControl
    {
        public AddictionControlX()
        {
             ZoneId = default(Int32);
 UserID = default(Int32);
 Rate = default(Int32);
 Message = default(Int32);
 Data = new Vector<GPair, GPairX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(UserID); 
 ds.Write(Rate); 
 ds.Write(Message); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Rate)  &&
 ds.TryRead(out Message)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class SellPointX : SellPoint
    {
        public SellPointX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Point = default(Int32);
 Price = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Point); 
 ds.Write(Price); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Point)  &&
 ds.TryRead(out Price) ;
        }
    }
      

    public class SellPoint_ReX : SellPoint_Re
    {
        public SellPoint_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
 Info = new SellPointInfoX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(Info); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Info) ;
        }
    }
      

    public class GetSellListX : GetSellList
    {
        public GetSellListX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetSellList_ReX : GetSellList_Re
    {
        public GetSellList_ReX()
        {
             LocalSid = default(UInt32);
 List = new Vector<SellPointInfo, SellPointInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(List); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)List) ;
        }
    }
      

    public class SellCancelX : SellCancel
    {
        public SellCancelX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 SellID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(SellID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out SellID) ;
        }
    }
      

    public class SellCancel_ReX : SellCancel_Re
    {
        public SellCancel_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
 SellID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(SellID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out SellID) ;
        }
    }
      

    public class BuyPointX : BuyPoint
    {
        public BuyPointX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 SellID = default(Int32);
 Seller = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(SellID); 
 ds.Write(Seller); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out SellID)  &&
 ds.TryRead(out Seller) ;
        }
    }
      

    public class BuyPoint_ReX : BuyPoint_Re
    {
        public BuyPoint_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
 SellID = default(Int32);
 Seller = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(SellID); 
 ds.Write(Seller); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out SellID)  &&
 ds.TryRead(out Seller) ;
        }
    }
      

    public class SyncSellInfoX : SyncSellInfo
    {
        public SyncSellInfoX()
        {
             Info = new SellPointInfoX(); 
 Buyer = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Info); 
 ds.Write(Buyer); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead(out Buyer) ;
        }
    }
      

    public class AnnounceSellResultX : AnnounceSellResult
    {
        public AnnounceSellResultX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 SellID = default(Int32);
 Seller = default(Int32);
 Point = default(Int32);
 Price = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(SellID); 
 ds.Write(Seller); 
 ds.Write(Point); 
 ds.Write(Price); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out SellID)  &&
 ds.TryRead(out Seller)  &&
 ds.TryRead(out Point)  &&
 ds.TryRead(out Price) ;
        }
    }
      

    public class TransBuyPointX : TransBuyPoint
    {
        public TransBuyPointX()
        {
             TId = new TransIDX(); 
 SellID = new SellIDX(); 
 Buyer = default(Int32);
 Price = default(Int32);
 Point = default(Int32);
 AId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(SellID); 
 ds.Write(Buyer); 
 ds.Write(Price); 
 ds.Write(Point); 
 ds.Write(AId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)TId)  &&
 ds.TryRead((IDataSerializer)SellID)  &&
 ds.TryRead(out Buyer)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out Point)  &&
 ds.TryRead(out AId) ;
        }
    }
      

    public class TransBuyPoint_ReX : TransBuyPoint_Re
    {
        public TransBuyPoint_ReX()
        {
             RetCode = default(Int32);
 TId = new TransIDX(); 
 SellID = new SellIDX(); 
 Buyer = default(Int32);
 Price = default(Int32);
 Point = default(Int32);
 AId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(SellID); 
 ds.Write(Buyer); 
 ds.Write(Price); 
 ds.Write(Point); 
 ds.Write(AId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)TId)  &&
 ds.TryRead((IDataSerializer)SellID)  &&
 ds.TryRead(out Buyer)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out Point)  &&
 ds.TryRead(out AId) ;
        }
    }
      

    public class FindSellPointInfoX : FindSellPointInfo
    {
        public FindSellPointInfoX()
        {
             StarTId = default(Int32);
 LocalSid = default(UInt32);
 Forward = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(StarTId); 
 ds.Write(LocalSid); 
 ds.Write(Forward); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out StarTId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Forward) ;
        }
    }
      

    public class FindSellPointInfo_ReX : FindSellPointInfo_Re
    {
        public FindSellPointInfo_ReX()
        {
             LocalSid = default(UInt32);
 List = new Vector<SellPointInfo, SellPointInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(List); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)List) ;
        }
    }
      

    public class DomainLoginX : DomainLogin
    {
        public DomainLoginX()
        {
             Nonce = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Nonce); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Nonce)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class DomainValidateX : DomainValidate
    {
        public DomainValidateX()
        {
             Version = new Octets(); 
 Nonce = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Version); 
 ds.Write(Nonce); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Version)  &&
 ds.TryRead((IDataSerializer)Nonce)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class DomainCmdX : DomainCmd
    {
        public DomainCmdX()
        {
             Cmd = new Octets(); 
 Stamp = new Octets(); 
 Length = default(Int32);
 Dest = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Cmd); 
 ds.Write(Stamp); 
 ds.Write(Length); 
 ds.Write(Dest); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Cmd)  &&
 ds.TryRead((IDataSerializer)Stamp)  &&
 ds.TryRead(out Length)  &&
 ds.TryRead(out Dest)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class DomainCmd_ReX : DomainCmd_Re
    {
        public DomainCmd_ReX()
        {
             Res = new Octets(); 
 Serial = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Res); 
 ds.Write(Serial); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Res)  &&
 ds.TryRead(out Serial)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AutolockSetX : AutolockSet
    {
        public AutolockSetX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
 Timeout = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(Timeout); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Timeout)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AutolockSet_ReX : AutolockSet_Re
    {
        public AutolockSet_ReX()
        {
             Result = default(Int32);
 Timeout = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(Timeout); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out Timeout)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AutolockChangedX : AutolockChanged
    {
        public AutolockChangedX()
        {
             RoleId = default(Int32);
 LockTime = default(Int32);
 Timeout = default(Int32);
 SetTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LockTime); 
 ds.Write(Timeout); 
 ds.Write(SetTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LockTime)  &&
 ds.TryRead(out Timeout)  &&
 ds.TryRead(out SetTime) ;
        }
    }
      

    public class AuctionOpenX : AuctionOpen
    {
        public AuctionOpenX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Category = default(UInt16);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemNumber = default(Int32);
 BasePrice = default(UInt32);
 BinPrice = default(UInt32);
 ElapseTime = default(Int32);
 Deposit = default(UInt32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Category); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemNumber); 
 ds.Write(BasePrice); 
 ds.Write(BinPrice); 
 ds.Write(ElapseTime); 
 ds.Write(Deposit); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Category)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead(out BasePrice)  &&
 ds.TryRead(out BinPrice)  &&
 ds.TryRead(out ElapseTime)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class AuctionOpen_ReX : AuctionOpen_Re
    {
        public AuctionOpen_ReX()
        {
             RetCode = default(UInt16);
 AuctionId = default(UInt32);
 Info = new GAuctionItemX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(AuctionId); 
 ds.Write(Info); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AuctionBidX : AuctionBid
    {
        public AuctionBidX()
        {
             RoleId = default(Int32);
 AuctionId = default(UInt32);
 BidPrice = default(UInt32);
 Bin = default(Byte);
 LocalSid = default(UInt32);
 Money = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(AuctionId); 
 ds.Write(BidPrice); 
 ds.Write(Bin); 
 ds.Write(LocalSid); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead(out BidPrice)  &&
 ds.TryRead(out Bin)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class AuctionBid_ReX : AuctionBid_Re
    {
        public AuctionBid_ReX()
        {
             RetCode = default(UInt16);
 BidPrice = default(UInt32);
 AuctionId = default(UInt32);
 Info = new GAuctionItemX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(BidPrice); 
 ds.Write(AuctionId); 
 ds.Write(Info); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out BidPrice)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AuctionListX : AuctionList
    {
        public AuctionListX()
        {
             RoleId = default(Int32);
 Category = default(UInt16);
 ItemId = default(UInt32);
 Begin = default(UInt32);
 Reverse = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Category); 
 ds.Write(ItemId); 
 ds.Write(Begin); 
 ds.Write(Reverse); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Category)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out Begin)  &&
 ds.TryRead(out Reverse)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AuctionList_ReX : AuctionList_Re
    {
        public AuctionList_ReX()
        {
             LocalSid = default(UInt32);
 Category = default(UInt16);
 End = default(UInt32);
 Items = new Vector<GAuctionItem, GAuctionItemX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(Category); 
 ds.Write(End); 
 ds.Write(Items); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Category)  &&
 ds.TryRead(out End)  &&
 ds.TryRead((IDataSerializer)Items) ;
        }
    }
      

    public class AuctionCloseX : AuctionClose
    {
        public AuctionCloseX()
        {
             RoleId = default(Int32);
 AuctionId = default(UInt32);
 Reason = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(AuctionId); 
 ds.Write(Reason); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead(out Reason)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AuctionClose_ReX : AuctionClose_Re
    {
        public AuctionClose_ReX()
        {
             RetCode = default(UInt16);
 AuctionId = default(UInt32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(AuctionId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AuctionGetX : AuctionGet
    {
        public AuctionGetX()
        {
             RoleId = default(Int32);
 AuctionId = default(UInt32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(AuctionId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AuctionGet_ReX : AuctionGet_Re
    {
        public AuctionGet_ReX()
        {
             RetCode = default(UInt16);
 AuctionId = default(UInt32);
 Item = new GAuctionDetailX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(AuctionId); 
 ds.Write(Item); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead((IDataSerializer)Item)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AuctionAttendListX : AuctionAttendList
    {
        public AuctionAttendListX()
        {
             RoleId = default(Int32);
 TargetType = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(TargetType); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out TargetType)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AuctionAttendList_ReX : AuctionAttendList_Re
    {
        public AuctionAttendList_ReX()
        {
             LocalSid = default(UInt32);
 TargetType = default(Int32);
 Items = new Vector<GAuctionItem, GAuctionItemX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(TargetType); 
 ds.Write(Items); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead(out TargetType)  &&
 ds.TryRead((IDataSerializer)Items) ;
        }
    }
      

    public class AuctionExitBidX : AuctionExitBid
    {
        public AuctionExitBidX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 AuctionId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(AuctionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out AuctionId) ;
        }
    }
      

    public class AuctionExitBid_ReX : AuctionExitBid_Re
    {
        public AuctionExitBid_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
 AuctionId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(AuctionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out AuctionId) ;
        }
    }
      

    public class AuctionGetItemX : AuctionGetItem
    {
        public AuctionGetItemX()
        {
             RoleId = default(Int32);
 Ids = new Vector<UInt32>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Ids); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Ids)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AuctionGetItem_ReX : AuctionGetItem_Re
    {
        public AuctionGetItem_ReX()
        {
             LocalSid = default(UInt32);
 Ids = new Vector<UInt32>(); 
 Items = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(Ids); 
 ds.Write(Items); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Ids)  &&
 ds.TryRead((IDataSerializer)Items) ;
        }
    }
      

    public class SendAuctionBidX : SendAuctionBid
    {
        public SendAuctionBidX()
        {
             RoleId = default(Int32);
 AuctionId = default(UInt32);
 BidPrice = default(UInt32);
 Bin = default(Byte);
 LocalSid = default(UInt32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(AuctionId); 
 ds.Write(BidPrice); 
 ds.Write(Bin); 
 ds.Write(LocalSid); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead(out BidPrice)  &&
 ds.TryRead(out Bin)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class AuctionListUpdateX : AuctionListUpdate
    {
        public AuctionListUpdateX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Ids = new Vector<UInt32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Ids); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Ids) ;
        }
    }
      

    public class AuctionListUpdate_ReX : AuctionListUpdate_Re
    {
        public AuctionListUpdate_ReX()
        {
             LocalSid = default(UInt32);
 ExpiredIds = new Vector<UInt32>(); 
 Items = new Vector<GAuctionItem, GAuctionItemX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(ExpiredIds); 
 ds.Write(Items); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)ExpiredIds)  &&
 ds.TryRead((IDataSerializer)Items) ;
        }
    }
      

    public class BattleGetMapX : BattleGetMap
    {
        public BattleGetMapX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class BattleGetMap_ReX : BattleGetMap_Re
    {
        public BattleGetMap_ReX()
        {
             RetCode = default(UInt16);
 MaxbId = default(UInt16);
 Status = default(Int32);
 Cities = new Vector<GTerritory, GTerritoryX>(); 
 BonusId = default(Int32);
 BonusCount1 = default(Int32);
 BonusCount2 = default(Int32);
 BonusCount3 = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(MaxbId); 
 ds.Write(Status); 
 ds.Write(Cities); 
 ds.Write(BonusId); 
 ds.Write(BonusCount1); 
 ds.Write(BonusCount2); 
 ds.Write(BonusCount3); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out MaxbId)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)Cities)  &&
 ds.TryRead(out BonusId)  &&
 ds.TryRead(out BonusCount1)  &&
 ds.TryRead(out BonusCount2)  &&
 ds.TryRead(out BonusCount3)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class BattleChallengeX : BattleChallenge
    {
        public BattleChallengeX()
        {
             RoleId = default(Int32);
 Id = default(Int16);
 FactionId = default(UInt32);
 Deposit = default(UInt32);
 Authentication = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Id); 
 ds.Write(FactionId); 
 ds.Write(Deposit); 
 ds.Write(Authentication); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Id)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out Authentication)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class BattleChallenge_ReX : BattleChallenge_Re
    {
        public BattleChallenge_ReX()
        {
             RetCode = default(UInt16);
 RoleId = default(Int32);
 Id = default(Int16);
 Deposit = default(UInt32);
 Maxbonus = default(UInt32);
 Challenger = default(UInt32);
 CutffTime = default(UInt32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(Id); 
 ds.Write(Deposit); 
 ds.Write(Maxbonus); 
 ds.Write(Challenger); 
 ds.Write(CutffTime); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Id)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out Maxbonus)  &&
 ds.TryRead(out Challenger)  &&
 ds.TryRead(out CutffTime)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class BattleChallengeMapX : BattleChallengeMap
    {
        public BattleChallengeMapX()
        {
             RoleId = default(Int32);
 FactionId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(FactionId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class BattleChallengeMap_ReX : BattleChallengeMap_Re
    {
        public BattleChallengeMap_ReX()
        {
             RoleId = default(Int32);
 RetCode = default(UInt16);
 Status = default(Int32);
 Maxbonus = default(UInt32);
 Cities = new Vector<GBattleChallenge, GBattleChallengeX>(); 
 RandNum = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RetCode); 
 ds.Write(Status); 
 ds.Write(Maxbonus); 
 ds.Write(Cities); 
 ds.Write(RandNum); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out Maxbonus)  &&
 ds.TryRead((IDataSerializer)Cities)  &&
 ds.TryRead(out RandNum)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class BattleServerRegisterX : BattleServerRegister
    {
        public BattleServerRegisterX()
        {
             MapType = default(Int32);
 ServerId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(MapType); 
 ds.Write(ServerId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out MapType)  &&
 ds.TryRead(out ServerId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class BattleStartX : BattleStart
    {
        public BattleStartX()
        {
             BattleId = default(Int32);
 MapType = default(Int32);
 BattleType = default(Int32);
 Defender = default(UInt32);
 Attacker = default(UInt32);
 EndTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(MapType); 
 ds.Write(BattleType); 
 ds.Write(Defender); 
 ds.Write(Attacker); 
 ds.Write(EndTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out MapType)  &&
 ds.TryRead(out BattleType)  &&
 ds.TryRead(out Defender)  &&
 ds.TryRead(out Attacker)  &&
 ds.TryRead(out EndTime) ;
        }
    }
      

    public class BattleStart_ReX : BattleStart_Re
    {
        public BattleStart_ReX()
        {
             BattleId = default(Int32);
 RetCode = default(Int16);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class BattleEnterX : BattleEnter
    {
        public BattleEnterX()
        {
             RoleId = default(Int32);
 BattleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(BattleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out BattleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class BattleEnter_ReX : BattleEnter_Re
    {
        public BattleEnter_ReX()
        {
             RetCode = default(UInt16);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class BattleEnterNoticeX : BattleEnterNotice
    {
        public BattleEnterNoticeX()
        {
             RetCode = default(UInt16);
 RoleId = default(Int32);
 BattleId = default(Int32);
 ServerId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(BattleId); 
 ds.Write(ServerId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out BattleId)  &&
 ds.TryRead(out ServerId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class BattleStatusX : BattleStatus
    {
        public BattleStatusX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class BattleStatus_ReX : BattleStatus_Re
    {
        public BattleStatus_ReX()
        {
             RetCode = default(UInt16);
 Cities = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cities); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Cities)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SendBattleChallengeX : SendBattleChallenge
    {
        public SendBattleChallengeX()
        {
             RoleId = default(Int32);
 Id = default(Int16);
 FactionId = default(UInt32);
 Deposit = default(UInt32);
 Authentication = default(Int32);
 LocalSid = default(UInt32);
 Maxbonus = default(UInt32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Id); 
 ds.Write(FactionId); 
 ds.Write(Deposit); 
 ds.Write(Authentication); 
 ds.Write(LocalSid); 
 ds.Write(Maxbonus); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Id)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out Authentication)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Maxbonus)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class BattleMapNoticeX : BattleMapNotice
    {
        public BattleMapNoticeX()
        {
             Status = default(Int32);
 Cities = new Vector<GCity, GCityX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
 ds.Write(Cities); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)Cities) ;
        }
    }
      

    public class DebugCommandX : DebugCommand
    {
        public DebugCommandX()
        {
             RoleId = default(UInt32);
 Tag = default(Int32);
 Data = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Tag); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Tag)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class BattleFactionNoticeX : BattleFactionNotice
    {
        public BattleFactionNoticeX()
        {
             FactionIds = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionIds); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FactionIds) ;
        }
    }
      

    public class PShopCreateX : PShopCreate
    {
        public PShopCreateX()
        {
             RoleId = default(Int32);
 ShopType = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemNumber = default(Int32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ShopType); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemNumber); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ShopType)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PShopCreate_ReX : PShopCreate_Re
    {
        public PShopCreate_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class PShopBuyX : PShopBuy
    {
        public PShopBuyX()
        {
             RoleId = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 ItemPrice = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(ItemPrice); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out ItemPrice) ;
        }
    }
      

    public class PShopBuy_ReX : PShopBuy_Re
    {
        public PShopBuy_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 ItemPrice = default(UInt32);
 ItemSell = new PShopItemX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(ItemPrice); 
 ds.Write(ItemSell); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out ItemPrice)  &&
 ds.TryRead((IDataSerializer)ItemSell) ;
        }
    }
      

    public class PShopSellX : PShopSell
    {
        public PShopSellX()
        {
             RoleId = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 ItemPrice = default(UInt32);
 InvPos = default(Int32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(ItemPrice); 
 ds.Write(InvPos); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out ItemPrice)  &&
 ds.TryRead(out InvPos)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PShopSell_ReX : PShopSell_Re
    {
        public PShopSell_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 ItemPrice = default(UInt32);
 InvPos = default(Int32);
 ItemSell = new PShopItemX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(ItemPrice); 
 ds.Write(InvPos); 
 ds.Write(ItemSell); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out ItemPrice)  &&
 ds.TryRead(out InvPos)  &&
 ds.TryRead((IDataSerializer)ItemSell) ;
        }
    }
      

    public class PShopCancelGoodsX : PShopCancelGoods
    {
        public PShopCancelGoodsX()
        {
             RoleId = default(Int32);
 CancelType = default(Int32);
 Pos = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CancelType); 
 ds.Write(Pos); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out CancelType)  &&
 ds.TryRead(out Pos) ;
        }
    }
      

    public class PShopCancelGoods_ReX : PShopCancelGoods_Re
    {
        public PShopCancelGoods_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 CancelType = default(Int32);
 Pos = default(Int32);
 ItemStore = new GRoleInventoryX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(CancelType); 
 ds.Write(Pos); 
 ds.Write(ItemStore); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out CancelType)  &&
 ds.TryRead(out Pos)  &&
 ds.TryRead((IDataSerializer)ItemStore) ;
        }
    }
      

    public class PShopPlayerBuyX : PShopPlayerBuy
    {
        public PShopPlayerBuyX()
        {
             RoleId = default(Int32);
 Master = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 MoneyCost = default(Int64);
 YpCost = default(Int32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Master); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(MoneyCost); 
 ds.Write(YpCost); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Master)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out MoneyCost)  &&
 ds.TryRead(out YpCost)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PShopPlayerBuy_ReX : PShopPlayerBuy_Re
    {
        public PShopPlayerBuy_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 Master = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 ItemChange = new PShopItemX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(Master); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(ItemChange); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Master)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead((IDataSerializer)ItemChange) ;
        }
    }
      

    public class PShopPlayerSellX : PShopPlayerSell
    {
        public PShopPlayerSellX()
        {
             RoleId = default(Int32);
 Master = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 ItemPrice = default(UInt32);
 InvPos = default(Int32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Master); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(ItemPrice); 
 ds.Write(InvPos); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Master)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out ItemPrice)  &&
 ds.TryRead(out InvPos)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PShopPlayerSell_ReX : PShopPlayerSell_Re
    {
        public PShopPlayerSell_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 Master = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 ItemBuy = new PShopItemX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(Master); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(ItemBuy); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Master)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead((IDataSerializer)ItemBuy) ;
        }
    }
      

    public class PShopSetTypeX : PShopSetType
    {
        public PShopSetTypeX()
        {
             RoleId = default(Int32);
 NewType = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(NewType); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out NewType) ;
        }
    }
      

    public class PShopSetType_ReX : PShopSetType_Re
    {
        public PShopSetType_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 NewType = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(NewType); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out NewType) ;
        }
    }
      

    public class PShopActiveX : PShopActive
    {
        public PShopActiveX()
        {
             RoleId = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemNumber = default(Int32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemNumber); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PShopActive_ReX : PShopActive_Re
    {
        public PShopActive_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 Status = default(Int32);
 ExpireTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(Status); 
 ds.Write(ExpireTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out ExpireTime) ;
        }
    }
      

    public class PShopManageFundX : PShopManageFund
    {
        public PShopManageFundX()
        {
             RoleId = default(Int32);
 OpType = default(Int32);
 Money = default(UInt32);
 Yinpiao = default(UInt32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(OpType); 
 ds.Write(Money); 
 ds.Write(Yinpiao); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out OpType)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out Yinpiao)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PShopManageFund_ReX : PShopManageFund_Re
    {
        public PShopManageFund_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 Money = default(UInt32);
 Yinpiao = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(Money); 
 ds.Write(Yinpiao); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out Yinpiao) ;
        }
    }
      

    public class PShopDrawItemX : PShopDrawItem
    {
        public PShopDrawItemX()
        {
             RoleId = default(Int32);
 ItemPos = default(Int32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemPos); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PShopDrawItem_ReX : PShopDrawItem_Re
    {
        public PShopDrawItem_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 ItemPos = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(ItemPos); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out ItemPos) ;
        }
    }
      

    public class PShopClearGoodsX : PShopClearGoods
    {
        public PShopClearGoodsX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class PShopClearGoods_ReX : PShopClearGoods_Re
    {
        public PShopClearGoods_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 SList = new Vector<PShopItem, PShopItemX>(); 
 Store = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(SList); 
 ds.Write(Store); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)SList)  &&
 ds.TryRead((IDataSerializer)Store) ;
        }
    }
      

    public class PShopSelfGetX : PShopSelfGet
    {
        public PShopSelfGetX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class PShopSelfGet_ReX : PShopSelfGet_Re
    {
        public PShopSelfGet_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 Detail = new PShopDetailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(Detail); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Detail) ;
        }
    }
      

    public class PShopPlayerGetX : PShopPlayerGet
    {
        public PShopPlayerGetX()
        {
             RoleId = default(Int32);
 Master = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Master); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Master) ;
        }
    }
      

    public class PShopPlayerGet_ReX : PShopPlayerGet_Re
    {
        public PShopPlayerGet_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
 Base = new PShopBaseX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
 ds.Write(Base); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Base) ;
        }
    }
      

    public class PShopListX : PShopList
    {
        public PShopListX()
        {
             RoleId = default(Int32);
 LocalSid = default(Int32);
 ShopType = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(ShopType); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out ShopType) ;
        }
    }
      

    public class PShopList_ReX : PShopList_Re
    {
        public PShopList_ReX()
        {
             LocalSid = default(Int32);
 ShopList = new Vector<PShopEntry, PShopEntryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(ShopList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)ShopList) ;
        }
    }
      

    public class PShopListItemX : PShopListItem
    {
        public PShopListItemX()
        {
             RoleId = default(Int32);
 LocalSid = default(Int32);
 ItemId = default(Int32);
 ListType = default(Byte);
 PageNum = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(ItemId); 
 ds.Write(ListType); 
 ds.Write(PageNum); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ListType)  &&
 ds.TryRead(out PageNum) ;
        }
    }
      

    public class PShopListItem_ReX : PShopListItem_Re
    {
        public PShopListItem_ReX()
        {
             LocalSid = default(Int32);
 ItemList = new Vector<PShopItemEntry, PShopItemEntryX>(); 
 ListType = default(Byte);
 PageNum = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(ItemList); 
 ds.Write(ListType); 
 ds.Write(PageNum); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)ItemList)  &&
 ds.TryRead(out ListType)  &&
 ds.TryRead(out PageNum) ;
        }
    }
      

    public class PlayerProfileGetProfileDataX : PlayerProfileGetProfileData
    {
        public PlayerProfileGetProfileDataX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class PlayerProfileGetProfileData_ReX : PlayerProfileGetProfileData_Re
    {
        public PlayerProfileGetProfileData_ReX()
        {
             RetCode = default(Int32);
 Data = new PlayerProfileDataX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Data); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Data)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class PlayerProfileSetProfileDataX : PlayerProfileSetProfileData
    {
        public PlayerProfileSetProfileDataX()
        {
             RoleId = default(Int32);
 Data = new PlayerProfileDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class PlayerProfileGetMatchResultX : PlayerProfileGetMatchResult
    {
        public PlayerProfileGetMatchResultX()
        {
             RoleId = default(Int32);
 MatchMode = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(MatchMode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out MatchMode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class PlayerProfileGetMatchResult_ReX : PlayerProfileGetMatchResult_Re
    {
        public PlayerProfileGetMatchResult_ReX()
        {
             RoleId = default(Int32);
 Result = new Vector<ProfileMatchResult, ProfileMatchResultX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Result); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Result)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AutoTeamSetGoalX : AutoTeamSetGoal
    {
        public AutoTeamSetGoalX()
        {
             RoleId = default(Int32);
 GoalType = default(Byte);
 Op = default(Byte);
 GoalId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(GoalType); 
 ds.Write(Op); 
 ds.Write(GoalId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out GoalType)  &&
 ds.TryRead(out Op)  &&
 ds.TryRead(out GoalId) ;
        }
    }
      

    public class AutoTeamSetGoal_ReX : AutoTeamSetGoal_Re
    {
        public AutoTeamSetGoal_ReX()
        {
             RoleId = default(Int32);
 GoalType = default(Byte);
 Op = default(Byte);
 GoalId = default(Int32);
 RetCode = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(GoalType); 
 ds.Write(Op); 
 ds.Write(GoalId); 
 ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out GoalType)  &&
 ds.TryRead(out Op)  &&
 ds.TryRead(out GoalId)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AutoTeamPlayerReadyX : AutoTeamPlayerReady
    {
        public AutoTeamPlayerReadyX()
        {
             RoleId = default(Int32);
 LeaderId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LeaderId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LeaderId) ;
        }
    }
      

    public class AutoTeamPlayerReady_ReX : AutoTeamPlayerReady_Re
    {
        public AutoTeamPlayerReady_ReX()
        {
             RoleId = default(Int32);
 LeaderId = default(Int32);
 RetCode = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LeaderId); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LeaderId)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class AutoTeamComposeStartX : AutoTeamComposeStart
    {
        public AutoTeamComposeStartX()
        {
             GoalId = default(Int32);
 RoleId = default(Int32);
 MemberList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GoalId); 
 ds.Write(RoleId); 
 ds.Write(MemberList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GoalId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)MemberList) ;
        }
    }
      

    public class AutoTeamComposeFailedX : AutoTeamComposeFailed
    {
        public AutoTeamComposeFailedX()
        {
             RoleId = default(Int32);
 LeaderId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LeaderId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LeaderId) ;
        }
    }
      

    public class AutoTeamPlayerLeaveX : AutoTeamPlayerLeave
    {
        public AutoTeamPlayerLeaveX()
        {
             RoleId = default(Int32);
 Reason = default(Byte);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Reason); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Reason)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class TryChangeDSX : TryChangeDS
    {
        public TryChangeDSX()
        {
             RoleId = default(Int32);
 Flag = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Flag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Flag) ;
        }
    }
      

    public class PlayerChangeDSX : PlayerChangeDS
    {
        public PlayerChangeDSX()
        {
             RoleId = default(Int32);
 Flag = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Flag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Flag) ;
        }
    }
      

    public class PlayerChangeDS_ReX : PlayerChangeDS_Re
    {
        public PlayerChangeDS_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 RemoteRoleId = default(Int32);
 UserID = default(Int32);
 Flag = default(Boolean);
 Random = new Octets(); 
 DstZoneId = default(Int32);
 LocalSid = default(UInt32);
 RoleinfoPack = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(RemoteRoleId); 
 ds.Write(UserID); 
 ds.Write(Flag); 
 ds.Write(Random); 
 ds.Write(DstZoneId); 
 ds.Write(LocalSid); 
 ds.Write(RoleinfoPack); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Flag)  &&
 ds.TryRead((IDataSerializer)Random)  &&
 ds.TryRead(out DstZoneId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)RoleinfoPack) ;
        }
    }
      

    public class ChangeDS_ReX : ChangeDS_Re
    {
        public ChangeDS_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class KeyReestablishX : KeyReestablish
    {
        public KeyReestablishX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
 Flag = default(Boolean);
 SrcZoneId = default(Int32);
 Random = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(Flag); 
 ds.Write(SrcZoneId); 
 ds.Write(Random); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Flag)  &&
 ds.TryRead(out SrcZoneId)  &&
 ds.TryRead((IDataSerializer)Random) ;
        }
    }
      

    public class LoadExchangeX : LoadExchange
    {
        public LoadExchangeX()
        {
             ZoneId = default(Int32);
 Version = default(UInt32);
 Edition = new Octets(); 
 ServerLimit = default(Int32);
 ServerCount = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(Version); 
 ds.Write(Edition); 
 ds.Write(ServerLimit); 
 ds.Write(ServerCount); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Version)  &&
 ds.TryRead((IDataSerializer)Edition)  &&
 ds.TryRead(out ServerLimit)  &&
 ds.TryRead(out ServerCount) ;
        }
    }
      

    public class SendDataAndIdentityX : SendDataAndIdentity
    {
        public SendDataAndIdentityX()
        {
             RoleId = default(Int32);
 RemoteRoleId = default(Int32);
 UserID = default(Int32);
 SrcZoneId = default(Int32);
 Ip = default(Int32);
 ISeckey = new Octets(); 
 OSeckey = new Octets(); 
 Account = new Octets(); 
 Random = new Octets(); 
 Flag = default(Boolean);
 Data = new CrossPlayerDataX(); 
 DataTimestamp = default(Int32);
 LoginTime = default(Int32);
 AuIsGM = default(Byte);
 AuFunc = default(Int32);
 AuFuncparm = default(Int32);
 Auth = new Octets(); 
 UsbBind = default(Byte);
 RewardMask = default(Int32);
 ForbidTalk = new GRoleForbidX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RemoteRoleId); 
 ds.Write(UserID); 
 ds.Write(SrcZoneId); 
 ds.Write(Ip); 
 ds.Write(ISeckey); 
 ds.Write(OSeckey); 
 ds.Write(Account); 
 ds.Write(Random); 
 ds.Write(Flag); 
 ds.Write(Data); 
 ds.Write(DataTimestamp); 
 ds.Write(LoginTime); 
 ds.Write(AuIsGM); 
 ds.Write(AuFunc); 
 ds.Write(AuFuncparm); 
 ds.Write(Auth); 
 ds.Write(UsbBind); 
 ds.Write(RewardMask); 
 ds.Write(ForbidTalk); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out SrcZoneId)  &&
 ds.TryRead(out Ip)  &&
 ds.TryRead((IDataSerializer)ISeckey)  &&
 ds.TryRead((IDataSerializer)OSeckey)  &&
 ds.TryRead((IDataSerializer)Account)  &&
 ds.TryRead((IDataSerializer)Random)  &&
 ds.TryRead(out Flag)  &&
 ds.TryRead((IDataSerializer)Data)  &&
 ds.TryRead(out DataTimestamp)  &&
 ds.TryRead(out LoginTime)  &&
 ds.TryRead(out AuIsGM)  &&
 ds.TryRead(out AuFunc)  &&
 ds.TryRead(out AuFuncparm)  &&
 ds.TryRead((IDataSerializer)Auth)  &&
 ds.TryRead(out UsbBind)  &&
 ds.TryRead(out RewardMask)  &&
 ds.TryRead((IDataSerializer)ForbidTalk) ;
        }
    }
      

    public class SendDataAndIdentity_ReX : SendDataAndIdentity_Re
    {
        public SendDataAndIdentity_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 RemoteRoleId = default(Int32);
 UserID = default(Int32);
 Flag = default(Boolean);
 DstZoneId = default(Int32);
 RoleinfoPack = new Octets(); 
 IsRemoteRoleidChanged = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(RemoteRoleId); 
 ds.Write(UserID); 
 ds.Write(Flag); 
 ds.Write(DstZoneId); 
 ds.Write(RoleinfoPack); 
 ds.Write(IsRemoteRoleidChanged); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Flag)  &&
 ds.TryRead(out DstZoneId)  &&
 ds.TryRead((IDataSerializer)RoleinfoPack)  &&
 ds.TryRead(out IsRemoteRoleidChanged) ;
        }
    }
      

    public class DSAnnounceIdentityX : DSAnnounceIdentity
    {
        public DSAnnounceIdentityX()
        {
             ZoneId = default(Int32);
 Version = default(UInt32);
 Edition = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(Version); 
 ds.Write(Edition); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Version)  &&
 ds.TryRead((IDataSerializer)Edition) ;
        }
    }
      

    public class RemoteLoginQueryX : RemoteLoginQuery
    {
        public RemoteLoginQueryX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 RemoteRoleId = default(Int32);
 UserID = default(Int32);
 Flag = default(Boolean);
 RemoteZoneId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(RemoteRoleId); 
 ds.Write(UserID); 
 ds.Write(Flag); 
 ds.Write(RemoteZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Flag)  &&
 ds.TryRead(out RemoteZoneId) ;
        }
    }
      

    public class RemoteLoginQuery_ReX : RemoteLoginQuery_Re
    {
        public RemoteLoginQuery_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 RemoteRoleId = default(Int32);
 UserID = default(Int32);
 Flag = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(RemoteRoleId); 
 ds.Write(UserID); 
 ds.Write(Flag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Flag) ;
        }
    }
      

    public class RemoteLogoutX : RemoteLogout
    {
        public RemoteLogoutX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class KickoutRemoteUserX : KickoutRemoteUser
    {
        public KickoutRemoteUserX()
        {
             UserID = default(Int32);
 ZoneId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(ZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId) ;
        }
    }
      

    public class KickoutRemoteUser_ReX : KickoutRemoteUser_Re
    {
        public KickoutRemoteUser_ReX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID) ;
        }
    }
      

    public class GetRemoteRoleInfoX : GetRemoteRoleInfo
    {
        public GetRemoteRoleInfoX()
        {
             RoleId = default(Int32);
 RemoteRoleId = default(Int32);
 UserID = default(Int32);
 ZoneId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RemoteRoleId); 
 ds.Write(UserID); 
 ds.Write(ZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId) ;
        }
    }
      

    public class GetRemoteRoleInfo_ReX : GetRemoteRoleInfo_Re
    {
        public GetRemoteRoleInfo_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 RemoteRoleId = default(Int32);
 UserID = default(Int32);
 Value = new GRoleInfoX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(RemoteRoleId); 
 ds.Write(UserID); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class KickoutUser2X : KickoutUser2
    {
        public KickoutUser2X()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
 Cause = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(Cause); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Cause) ;
        }
    }
      

    public class AnnounceLinkVersionX : AnnounceLinkVersion
    {
        public AnnounceLinkVersionX()
        {
             Version = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Version); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Version) ;
        }
    }
      

    public class AnnounceCentralDeliveryX : AnnounceCentralDelivery
    {
        public AnnounceCentralDeliveryX()
        {
             IsCentral = default(Byte);
 AcceptedZoneList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(IsCentral); 
 ds.Write(AcceptedZoneList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out IsCentral)  &&
 ds.TryRead((IDataSerializer)AcceptedZoneList) ;
        }
    }
      

    public class DelRoleAnnounceX : DelRoleAnnounce
    {
        public DelRoleAnnounceX()
        {
             RoleList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)RoleList) ;
        }
    }
      

    public class PlayerRenameX : PlayerRename
    {
        public PlayerRenameX()
        {
             RoleId = default(Int32);
 AttachObjId = default(Int32);
 AttachObjNum = default(Int32);
 AttachObjPos = default(Int32);
 NewName = new Octets(); 
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(AttachObjId); 
 ds.Write(AttachObjNum); 
 ds.Write(AttachObjPos); 
 ds.Write(NewName); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out AttachObjId)  &&
 ds.TryRead(out AttachObjNum)  &&
 ds.TryRead(out AttachObjPos)  &&
 ds.TryRead((IDataSerializer)NewName)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PlayerRename_ReX : PlayerRename_Re
    {
        public PlayerRename_ReX()
        {
             LocalSid = default(Int32);
 RoleId = default(Int32);
 NewName = new Octets(); 
 RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(RoleId); 
 ds.Write(NewName); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)NewName)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class PostPlayerRenameX : PostPlayerRename
    {
        public PostPlayerRenameX()
        {
             RoleId = default(Int32);
 ZoneId = default(Int32);
 RetCode = default(Int32);
 NewName = new Octets(); 
 OldName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ZoneId); 
 ds.Write(RetCode); 
 ds.Write(NewName); 
 ds.Write(OldName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)NewName)  &&
 ds.TryRead((IDataSerializer)OldName) ;
        }
    }
      

    public class PlayerGivePresentX : PlayerGivePresent
    {
        public PlayerGivePresentX()
        {
             RoleId = default(Int32);
 TargetRoleId = default(Int32);
 MailId = default(Int32);
 Goods = new Vector<GRoleInventory, GRoleInventoryX>(); 
 CashCost = default(UInt32);
 HasGift = default(Byte);
 LogPrice1 = default(Int32);
 LogPrice2 = default(Int32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(TargetRoleId); 
 ds.Write(MailId); 
 ds.Write(Goods); 
 ds.Write(CashCost); 
 ds.Write(HasGift); 
 ds.Write(LogPrice1); 
 ds.Write(LogPrice2); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out TargetRoleId)  &&
 ds.TryRead(out MailId)  &&
 ds.TryRead((IDataSerializer)Goods)  &&
 ds.TryRead(out CashCost)  &&
 ds.TryRead(out HasGift)  &&
 ds.TryRead(out LogPrice1)  &&
 ds.TryRead(out LogPrice2)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PlayerGivePresent_ReX : PlayerGivePresent_Re
    {
        public PlayerGivePresent_ReX()
        {
             LocalSid = default(Int32);
 RoleId = default(Int32);
 CashCost = default(UInt32);
 RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(RoleId); 
 ds.Write(CashCost); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out CashCost)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class PlayerAskForPresentX : PlayerAskForPresent
    {
        public PlayerAskForPresentX()
        {
             RoleId = default(Int32);
 TargetRoleId = default(Int32);
 GoodsId = default(Int32);
 GoodsIndex = default(Int32);
 GoodsSlot = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(TargetRoleId); 
 ds.Write(GoodsId); 
 ds.Write(GoodsIndex); 
 ds.Write(GoodsSlot); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out TargetRoleId)  &&
 ds.TryRead(out GoodsId)  &&
 ds.TryRead(out GoodsIndex)  &&
 ds.TryRead(out GoodsSlot) ;
        }
    }
      

    public class PlayerAskForPresent_ReX : PlayerAskForPresent_Re
    {
        public PlayerAskForPresent_ReX()
        {
             LocalSid = default(Int32);
 RoleId = default(Int32);
 RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalSid); 
 ds.Write(RoleId); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalSid)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class UniqueDataModifyRequireX : UniqueDataModifyRequire
    {
        public UniqueDataModifyRequireX()
        {
             Worldtag = default(Int32);
 Key = default(Int32);
 VType = default(Int32);
 Value = new Octets(); 
 Oldvalue = new Octets(); 
 Exclusive = default(Boolean);
 Broadcast = default(Boolean);
 Version = default(Int32);
 Timeout = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Worldtag); 
 ds.Write(Key); 
 ds.Write(VType); 
 ds.Write(Value); 
 ds.Write(Oldvalue); 
 ds.Write(Exclusive); 
 ds.Write(Broadcast); 
 ds.Write(Version); 
 ds.Write(Timeout); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Worldtag)  &&
 ds.TryRead(out Key)  &&
 ds.TryRead(out VType)  &&
 ds.TryRead((IDataSerializer)Value)  &&
 ds.TryRead((IDataSerializer)Oldvalue)  &&
 ds.TryRead(out Exclusive)  &&
 ds.TryRead(out Broadcast)  &&
 ds.TryRead(out Version)  &&
 ds.TryRead(out Timeout) ;
        }
    }
      

    public class UniqueDataModifyNoticeX : UniqueDataModifyNotice
    {
        public UniqueDataModifyNoticeX()
        {
             Worldtag = default(Int32);
 Key = default(Int32);
 VType = default(Int32);
 Value = new Octets(); 
 Oldvalue = new Octets(); 
 Exclusive = default(Boolean);
 RetCode = default(Int32);
 Version = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Worldtag); 
 ds.Write(Key); 
 ds.Write(VType); 
 ds.Write(Value); 
 ds.Write(Oldvalue); 
 ds.Write(Exclusive); 
 ds.Write(RetCode); 
 ds.Write(Version); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Worldtag)  &&
 ds.TryRead(out Key)  &&
 ds.TryRead(out VType)  &&
 ds.TryRead((IDataSerializer)Value)  &&
 ds.TryRead((IDataSerializer)Oldvalue)  &&
 ds.TryRead(out Exclusive)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out Version) ;
        }
    }
      

    public class UniqueDataSynchX : UniqueDataSynch
    {
        public UniqueDataSynchX()
        {
             Finish = default(Byte);
 Values = new Vector<GUniqueDataElemNode, GUniqueDataElemNodeX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Finish); 
 ds.Write(Values); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Finish)  &&
 ds.TryRead((IDataSerializer)Values) ;
        }
    }
      

    public class UniqueDataModifyBroadcastX : UniqueDataModifyBroadcast
    {
        public UniqueDataModifyBroadcastX()
        {
             Handle = default(Int32);
 Values = new Vector<GUniqueDataElemNode, GUniqueDataElemNodeX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Handle); 
 ds.Write(Values); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Handle)  &&
 ds.TryRead((IDataSerializer)Values) ;
        }
    }
      

    public class TradeStartX : TradeStart
    {
        public TradeStartX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 PartnerRoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(PartnerRoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out PartnerRoleId) ;
        }
    }
      

    public class TradeStart_ReX : TradeStart_Re
    {
        public TradeStart_ReX()
        {
             RetCode = default(Int32);
 TId = default(UInt32);
 PartnerRoleId = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(PartnerRoleId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out PartnerRoleId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class TradeAddGoodsX : TradeAddGoods
    {
        public TradeAddGoodsX()
        {
             TId = default(UInt32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Goods = new GRoleInventoryX(); 
 Money = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Goods); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Goods)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class TradeAddGoods_ReX : TradeAddGoods_Re
    {
        public TradeAddGoods_ReX()
        {
             RetCode = default(Int32);
 TId = default(UInt32);
 OwnerRoleId = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(Int32);
 Goods = new GRoleInventoryX(); 
 Money = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(OwnerRoleId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Goods); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out OwnerRoleId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Goods)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class TradeRemoveGoodsX : TradeRemoveGoods
    {
        public TradeRemoveGoodsX()
        {
             TId = default(UInt32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Goods = new GRoleInventoryX(); 
 Money = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Goods); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Goods)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class TradeRemoveGoods_ReX : TradeRemoveGoods_Re
    {
        public TradeRemoveGoods_ReX()
        {
             RetCode = default(Int32);
 TId = default(UInt32);
 OwnerRoleId = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(Int32);
 Goods = new GRoleInventoryX(); 
 Money = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(OwnerRoleId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Goods); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out OwnerRoleId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Goods)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class TradeMoveObjX : TradeMoveObj
    {
        public TradeMoveObjX()
        {
             TId = default(UInt32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Goods = new GRoleInventoryX(); 
 DstPos = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Goods); 
 ds.Write(DstPos); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Goods)  &&
 ds.TryRead(out DstPos) ;
        }
    }
      

    public class TradeMoveObj_ReX : TradeMoveObj_Re
    {
        public TradeMoveObj_ReX()
        {
             RetCode = default(Int32);
 TId = default(UInt32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 SrcPos = default(Byte);
 Count = default(Int32);
 DstPos = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(SrcPos); 
 ds.Write(Count); 
 ds.Write(DstPos); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out SrcPos)  &&
 ds.TryRead(out Count)  &&
 ds.TryRead(out DstPos) ;
        }
    }
      

    public class TradeSubmitX : TradeSubmit
    {
        public TradeSubmitX()
        {
             TId = default(UInt32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class TradeSubmit_ReX : TradeSubmit_Re
    {
        public TradeSubmit_ReX()
        {
             RetCode = default(Int32);
 TId = default(UInt32);
 SubmitRoleId = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(SubmitRoleId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out SubmitRoleId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class TradeConfirmX : TradeConfirm
    {
        public TradeConfirmX()
        {
             TId = default(UInt32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class TradeConfirm_ReX : TradeConfirm_Re
    {
        public TradeConfirm_ReX()
        {
             RetCode = default(Int32);
 TId = default(UInt32);
 ConfirmRoleId = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(ConfirmRoleId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out ConfirmRoleId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class TradeDiscardX : TradeDiscard
    {
        public TradeDiscardX()
        {
             TId = default(UInt32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class TradeDiscard_ReX : TradeDiscard_Re
    {
        public TradeDiscard_ReX()
        {
             RetCode = default(Int32);
 TId = default(UInt32);
 DiscardRoleId = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(DiscardRoleId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out DiscardRoleId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class TradeEndX : TradeEnd
    {
        public TradeEndX()
        {
             TId = default(UInt32);
 Cause = default(Byte);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(Cause); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out Cause)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GTradeStartX : GTradeStart
    {
        public GTradeStartX()
        {
             TId = default(UInt32);
 RoleId1 = default(Int32);
 LocalsId1 = default(UInt32);
 RoleId2 = default(Int32);
 LocalsId2 = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RoleId1); 
 ds.Write(LocalsId1); 
 ds.Write(RoleId2); 
 ds.Write(LocalsId2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId1)  &&
 ds.TryRead(out LocalsId1)  &&
 ds.TryRead(out RoleId2)  &&
 ds.TryRead(out LocalsId2) ;
        }
    }
      

    public class GTradeStart_ReX : GTradeStart_Re
    {
        public GTradeStart_ReX()
        {
             RetCode = default(Int32);
 TId = default(UInt32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GTradeEndX : GTradeEnd
    {
        public GTradeEndX()
        {
             TId = default(UInt32);
 RoleId1 = default(Int32);
 NeedReadDB1 = default(Byte);
 RoleId2 = default(Int32);
 NeedReadDB2 = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RoleId1); 
 ds.Write(NeedReadDB1); 
 ds.Write(RoleId2); 
 ds.Write(NeedReadDB2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId1)  &&
 ds.TryRead(out NeedReadDB1)  &&
 ds.TryRead(out RoleId2)  &&
 ds.TryRead(out NeedReadDB2) ;
        }
    }
      

    public class GTradeDiscardX : GTradeDiscard
    {
        public GTradeDiscardX()
        {
             TId = default(UInt32);
 Paddings = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(Paddings); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out Paddings) ;
        }
    }
      

    public class OnDivorceX : OnDivorce
    {
        public OnDivorceX()
        {
             RId1 = default(Int32);
 RId2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RId1); 
 ds.Write(RId2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RId1)  &&
 ds.TryRead(out RId2) ;
        }
    }
      

    public class TouchPointQueryX : TouchPointQuery
    {
        public TouchPointQueryX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class TouchPointQuery_ReX : TouchPointQuery_Re
    {
        public TouchPointQuery_ReX()
        {
             RoleId = default(Int32);
 Income = default(Int64);
 Remain = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Income); 
 ds.Write(Remain); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Income)  &&
 ds.TryRead(out Remain) ;
        }
    }
      

    public class TouchPointCostX : TouchPointCost
    {
        public TouchPointCostX()
        {
             RoleId = default(Int32);
 OrderId = default(Int64);
 Cost = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(OrderId); 
 ds.Write(Cost); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out OrderId)  &&
 ds.TryRead(out Cost) ;
        }
    }
      

    public class TouchPointCost_ReX : TouchPointCost_Re
    {
        public TouchPointCost_ReX()
        {
             RoleId = default(Int32);
 OrderId = default(Int64);
 Cost = default(UInt32);
 Income = default(Int64);
 Remain = default(Int64);
 RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(OrderId); 
 ds.Write(Cost); 
 ds.Write(Income); 
 ds.Write(Remain); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out OrderId)  &&
 ds.TryRead(out Cost)  &&
 ds.TryRead(out Income)  &&
 ds.TryRead(out Remain)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class AuAddupMoneyQueryX : AuAddupMoneyQuery
    {
        public AuAddupMoneyQueryX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class AuAddupMoneyQuery_ReX : AuAddupMoneyQuery_Re
    {
        public AuAddupMoneyQuery_ReX()
        {
             RoleId = default(Int32);
 AddupMoney = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(AddupMoney); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out AddupMoney) ;
        }
    }
      

    public class GiftCodeRedeemX : GiftCodeRedeem
    {
        public GiftCodeRedeemX()
        {
             RoleId = default(Int32);
 CardNumber = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CardNumber); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)CardNumber) ;
        }
    }
      

    public class GiftCodeRedeem_ReX : GiftCodeRedeem_Re
    {
        public GiftCodeRedeem_ReX()
        {
             RoleId = default(Int32);
 CardNumber = new Octets(); 
 CodeType = default(Int32);
 ParentType = default(Int32);
 RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CardNumber); 
 ds.Write(CodeType); 
 ds.Write(ParentType); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)CardNumber)  &&
 ds.TryRead(out CodeType)  &&
 ds.TryRead(out ParentType)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class SwitchServerStartX : SwitchServerStart
    {
        public SwitchServerStartX()
        {
             RoleId = default(Int32);
 LinkId = default(Int32);
 LocalSid = default(UInt32);
 SrcGSId = default(Int32);
 DstGSId = default(Int32);
 Key = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LinkId); 
 ds.Write(LocalSid); 
 ds.Write(SrcGSId); 
 ds.Write(DstGSId); 
 ds.Write(Key); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LinkId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out SrcGSId)  &&
 ds.TryRead(out DstGSId)  &&
 ds.TryRead((IDataSerializer)Key) ;
        }
    }
      

    public class SwitchServerCancelX : SwitchServerCancel
    {
        public SwitchServerCancelX()
        {
             RoleId = default(Int32);
 LinkId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LinkId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LinkId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SwitchServerSuccessX : SwitchServerSuccess
    {
        public SwitchServerSuccessX()
        {
             RoleId = default(Int32);
 LinkId = default(Int32);
 LocalSid = default(UInt32);
 DstGSId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LinkId); 
 ds.Write(LocalSid); 
 ds.Write(DstGSId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LinkId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out DstGSId) ;
        }
    }
      

    public class SwitchServerTimeoutX : SwitchServerTimeout
    {
        public SwitchServerTimeoutX()
        {
             RoleId = default(Int32);
 LinkId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LinkId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LinkId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CheckNewMailX : CheckNewMail
    {
        public CheckNewMailX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class AnnounceNewMailX : AnnounceNewMail
    {
        public AnnounceNewMailX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 RemainTime = default(Int32);
 PresentType = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(RemainTime); 
 ds.Write(PresentType); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out RemainTime)  &&
 ds.TryRead(out PresentType) ;
        }
    }
      

    public class GetMailListX : GetMailList
    {
        public GetMailListX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetMailList_ReX : GetMailList_Re
    {
        public GetMailList_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 MailList = new Vector<GMailHeader, GMailHeaderX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(MailList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)MailList) ;
        }
    }
      

    public class GetMailX : GetMail
    {
        public GetMailX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 MailId = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(MailId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out MailId) ;
        }
    }
      

    public class GetMail_ReX : GetMail_Re
    {
        public GetMail_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Mail = new GMailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Mail); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Mail) ;
        }
    }
      

    public class GetMailAttachObjX : GetMailAttachObj
    {
        public GetMailAttachObjX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 MailId = default(Byte);
 ObjType = default(Byte);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(MailId); 
 ds.Write(ObjType); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out MailId)  &&
 ds.TryRead(out ObjType)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class GetMailAttachObj_ReX : GetMailAttachObj_Re
    {
        public GetMailAttachObj_ReX()
        {
             RetCode = default(Int32);
 MailId = default(Byte);
 MoneyLeft = default(UInt32);
 ItemLeft = default(UInt32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(MailId); 
 ds.Write(MoneyLeft); 
 ds.Write(ItemLeft); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out MailId)  &&
 ds.TryRead(out MoneyLeft)  &&
 ds.TryRead(out ItemLeft)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class DeleteMailX : DeleteMail
    {
        public DeleteMailX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 MailId = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(MailId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out MailId) ;
        }
    }
      

    public class DeleteMail_ReX : DeleteMail_Re
    {
        public DeleteMail_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 MailId = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(MailId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out MailId) ;
        }
    }
      

    public class PreserveMailX : PreserveMail
    {
        public PreserveMailX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 MailId = default(Byte);
 Preserve = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(MailId); 
 ds.Write(Preserve); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out MailId)  &&
 ds.TryRead(out Preserve) ;
        }
    }
      

    public class PreserveMail_ReX : PreserveMail_Re
    {
        public PreserveMail_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 MailId = default(Byte);
 Preserve = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(MailId); 
 ds.Write(Preserve); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out MailId)  &&
 ds.TryRead(out Preserve) ;
        }
    }
      

    public class PlayerSendMailX : PlayerSendMail
    {
        public PlayerSendMailX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Receiver = default(Int32);
 Title = new Octets(); 
 Context = new Octets(); 
 AttachObjId = default(Int32);
 AttachObjNum = default(Int32);
 AttachObjPos = default(Int32);
 AttachMoney = default(UInt32);
 SenderName = new Octets(); 
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Receiver); 
 ds.Write(Title); 
 ds.Write(Context); 
 ds.Write(AttachObjId); 
 ds.Write(AttachObjNum); 
 ds.Write(AttachObjPos); 
 ds.Write(AttachMoney); 
 ds.Write(SenderName); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Receiver)  &&
 ds.TryRead((IDataSerializer)Title)  &&
 ds.TryRead((IDataSerializer)Context)  &&
 ds.TryRead(out AttachObjId)  &&
 ds.TryRead(out AttachObjNum)  &&
 ds.TryRead(out AttachObjPos)  &&
 ds.TryRead(out AttachMoney)  &&
 ds.TryRead((IDataSerializer)SenderName)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PlayerSendMail_ReX : PlayerSendMail_Re
    {
        public PlayerSendMail_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Receiver = default(Int32);
 AttachObjNum = default(Int32);
 AttachObjPos = default(Int32);
 AttachMoney = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Receiver); 
 ds.Write(AttachObjNum); 
 ds.Write(AttachObjPos); 
 ds.Write(AttachMoney); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Receiver)  &&
 ds.TryRead(out AttachObjNum)  &&
 ds.TryRead(out AttachObjPos)  &&
 ds.TryRead(out AttachMoney) ;
        }
    }
      

    public class SysSendMailX : SysSendMail
    {
        public SysSendMailX()
        {
             TId = default(UInt32);
 SysId = default(Int32);
 SysType = default(Byte);
 Receiver = default(Int32);
 Title = new Octets(); 
 Context = new Octets(); 
 AttachObj = new GRoleInventoryX(); 
 AttachMoney = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(SysId); 
 ds.Write(SysType); 
 ds.Write(Receiver); 
 ds.Write(Title); 
 ds.Write(Context); 
 ds.Write(AttachObj); 
 ds.Write(AttachMoney); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out SysId)  &&
 ds.TryRead(out SysType)  &&
 ds.TryRead(out Receiver)  &&
 ds.TryRead((IDataSerializer)Title)  &&
 ds.TryRead((IDataSerializer)Context)  &&
 ds.TryRead((IDataSerializer)AttachObj)  &&
 ds.TryRead(out AttachMoney) ;
        }
    }
      

    public class SysSendMail_ReX : SysSendMail_Re
    {
        public SysSendMail_ReX()
        {
             RetCode = default(UInt16);
 TId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId) ;
        }
    }
      

    public class GMailEndSyncX : GMailEndSync
    {
        public GMailEndSyncX()
        {
             TId = default(UInt32);
 RetCode = default(Int32);
 RoleId = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class PlayerSendMassMailX : PlayerSendMassMail
    {
        public PlayerSendMassMailX()
        {
             MassType = default(Byte);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Title = new Octets(); 
 Context = new Octets(); 
 SenderName = new Octets(); 
 ReceiverList = new Vector<Int32>(); 
 CostObjId = default(Int32);
 CostObjNum = default(Int32);
 CostObjPos = default(Int32);
 CostMoney = default(UInt32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(MassType); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Title); 
 ds.Write(Context); 
 ds.Write(SenderName); 
 ds.Write(ReceiverList); 
 ds.Write(CostObjId); 
 ds.Write(CostObjNum); 
 ds.Write(CostObjPos); 
 ds.Write(CostMoney); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out MassType)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Title)  &&
 ds.TryRead((IDataSerializer)Context)  &&
 ds.TryRead((IDataSerializer)SenderName)  &&
 ds.TryRead((IDataSerializer)ReceiverList)  &&
 ds.TryRead(out CostObjId)  &&
 ds.TryRead(out CostObjNum)  &&
 ds.TryRead(out CostObjPos)  &&
 ds.TryRead(out CostMoney)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class SysRecoveredObjMailX : SysRecoveredObjMail
    {
        public SysRecoveredObjMailX()
        {
             TId = default(Int32);
 SysType = default(Byte);
 Receiver = default(Int32);
 Title = new Octets(); 
 Context = new Octets(); 
 Obj = new Octets(); 
 Checksum = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(SysType); 
 ds.Write(Receiver); 
 ds.Write(Title); 
 ds.Write(Context); 
 ds.Write(Obj); 
 ds.Write(Checksum); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out SysType)  &&
 ds.TryRead(out Receiver)  &&
 ds.TryRead((IDataSerializer)Title)  &&
 ds.TryRead((IDataSerializer)Context)  &&
 ds.TryRead((IDataSerializer)Obj)  &&
 ds.TryRead((IDataSerializer)Checksum) ;
        }
    }
      

    public class SysRecoveredObjMail_ReX : SysRecoveredObjMail_Re
    {
        public SysRecoveredObjMail_ReX()
        {
             RetCode = default(Int16);
 TId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId) ;
        }
    }
      

    public class CashLockX : CashLock
    {
        public CashLockX()
        {
             UserID = default(Int32);
 CashPassword = new Octets(); 
 LocalSid = default(UInt32);
 Lock = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(CashPassword); 
 ds.Write(LocalSid); 
 ds.Write(Lock); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)CashPassword)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Lock) ;
        }
    }
      

    public class CashLock_ReX : CashLock_Re
    {
        public CashLock_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CashPasswordSetX : CashPasswordSet
    {
        public CashPasswordSetX()
        {
             UserID = default(Int32);
 CashPassword = new Octets(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(CashPassword); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)CashPassword)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CashPasswordSet_ReX : CashPasswordSet_Re
    {
        public CashPasswordSet_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradePrePostX : WebTradePrePost
    {
        public WebTradePrePostX()
        {
             RoleId = default(Int32);
 PostType = default(Int32);
 Money = default(UInt32);
 ItemId = default(UInt32);
 ItemPos = default(Int32);
 ItemNumber = default(Int32);
 Price = default(Int32);
 SellPeriod = default(Int32);
 BuyerroleId = default(Int32);
 LocalSid = default(UInt32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(PostType); 
 ds.Write(Money); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemNumber); 
 ds.Write(Price); 
 ds.Write(SellPeriod); 
 ds.Write(BuyerroleId); 
 ds.Write(LocalSid); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out PostType)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out SellPeriod)  &&
 ds.TryRead(out BuyerroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class WebTradePrePost_ReX : WebTradePrePost_Re
    {
        public WebTradePrePost_ReX()
        {
             RetCode = default(Int32);
 Sn = default(Int64);
 Info = new GWebTradeItemX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Sn); 
 ds.Write(Info); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradePreCancelPostX : WebTradePreCancelPost
    {
        public WebTradePreCancelPostX()
        {
             Sn = default(Int64);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradePreCancelPost_ReX : WebTradePreCancelPost_Re
    {
        public WebTradePreCancelPost_ReX()
        {
             RetCode = default(Int32);
 Sn = default(Int64);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Sn); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeListX : WebTradeList
    {
        public WebTradeListX()
        {
             RoleId = default(Int32);
 Category = default(UInt32);
 Begin = default(UInt32);
 Reverse = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Category); 
 ds.Write(Begin); 
 ds.Write(Reverse); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Category)  &&
 ds.TryRead(out Begin)  &&
 ds.TryRead(out Reverse)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeList_ReX : WebTradeList_Re
    {
        public WebTradeList_ReX()
        {
             Category = default(UInt32);
 End = default(UInt32);
 Items = new Vector<GWebTradeItem, GWebTradeItemX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Category); 
 ds.Write(End); 
 ds.Write(Items); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Category)  &&
 ds.TryRead(out End)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeGetItemX : WebTradeGetItem
    {
        public WebTradeGetItemX()
        {
             RoleId = default(Int32);
 Sns = new Vector<Int64>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Sns); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Sns)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeGetItem_ReX : WebTradeGetItem_Re
    {
        public WebTradeGetItem_ReX()
        {
             Sns = new Vector<Int64>(); 
 Items = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Rolebriefs = new Vector<Octets>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sns); 
 ds.Write(Items); 
 ds.Write(Rolebriefs); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Sns)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead((IDataSerializer)Rolebriefs)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeAttendListX : WebTradeAttendList
    {
        public WebTradeAttendListX()
        {
             RoleId = default(Int32);
 GetSell = default(Byte);
 Begin = default(UInt32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(GetSell); 
 ds.Write(Begin); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out GetSell)  &&
 ds.TryRead(out Begin)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeAttendList_ReX : WebTradeAttendList_Re
    {
        public WebTradeAttendList_ReX()
        {
             GetSell = default(Byte);
 End = default(UInt32);
 Items = new Vector<GWebTradeItem, GWebTradeItemX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GetSell); 
 ds.Write(End); 
 ds.Write(Items); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GetSell)  &&
 ds.TryRead(out End)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeGetDetailX : WebTradeGetDetail
    {
        public WebTradeGetDetailX()
        {
             RoleId = default(Int32);
 Sn = default(Int64);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeGetDetail_ReX : WebTradeGetDetail_Re
    {
        public WebTradeGetDetail_ReX()
        {
             RetCode = default(Int32);
 Sn = default(Int64);
 Detail = new GWebTradeDetailX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Sn); 
 ds.Write(Detail); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead((IDataSerializer)Detail)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeUpdateX : WebTradeUpdate
    {
        public WebTradeUpdateX()
        {
             Sn = default(Int64);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeUpdate_ReX : WebTradeUpdate_Re
    {
        public WebTradeUpdate_ReX()
        {
             RetCode = default(Int32);
 Sn = default(Int64);
 Item = new GWebTradeItemX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Sn); 
 ds.Write(Item); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead((IDataSerializer)Item)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeRolePrePostX : WebTradeRolePrePost
    {
        public WebTradeRolePrePostX()
        {
             UserID = default(Int32);
 RoleId = default(Int32);
 Price = default(Int32);
 SellPeriod = default(Int32);
 BuyerroleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Price); 
 ds.Write(SellPeriod); 
 ds.Write(BuyerroleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out SellPeriod)  &&
 ds.TryRead(out BuyerroleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeRolePreCancelPostX : WebTradeRolePreCancelPost
    {
        public WebTradeRolePreCancelPostX()
        {
             UserID = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class WebTradeRoleGetDetailX : WebTradeRoleGetDetail
    {
        public WebTradeRoleGetDetailX()
        {
             UserID = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SysAuctionListX : SysAuctionList
    {
        public SysAuctionListX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SysAuctionList_ReX : SysAuctionList_Re
    {
        public SysAuctionList_ReX()
        {
             Items = new Vector<GSysAuctionItem, GSysAuctionItemX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Items); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SysAuctionGetItemX : SysAuctionGetItem
    {
        public SysAuctionGetItemX()
        {
             RoleId = default(Int32);
 Ids = new Vector<UInt32>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Ids); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Ids)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SysAuctionGetItem_ReX : SysAuctionGetItem_Re
    {
        public SysAuctionGetItem_ReX()
        {
             Ids = new Vector<UInt32>(); 
 Items = new Vector<GRoleInventory, GRoleInventoryX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Ids); 
 ds.Write(Items); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Ids)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SysAuctionAccountX : SysAuctionAccount
    {
        public SysAuctionAccountX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SysAuctionAccount_ReX : SysAuctionAccount_Re
    {
        public SysAuctionAccount_ReX()
        {
             RetCode = default(Int32);
 Cash = default(UInt32);
 BidIds = new Vector<UInt32>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cash); 
 ds.Write(BidIds); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead((IDataSerializer)BidIds)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SysAuctionBidX : SysAuctionBid
    {
        public SysAuctionBidX()
        {
             RoleId = default(Int32);
 SaId = default(UInt32);
 BidPrice = default(UInt32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(SaId); 
 ds.Write(BidPrice); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out SaId)  &&
 ds.TryRead(out BidPrice)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SysAuctionBid_ReX : SysAuctionBid_Re
    {
        public SysAuctionBid_ReX()
        {
             RetCode = default(Int32);
 Cash = default(UInt32);
 Info = new GSysAuctionItemX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cash); 
 ds.Write(Info); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SysAuctionCashTransferX : SysAuctionCashTransfer
    {
        public SysAuctionCashTransferX()
        {
             RoleId = default(Int32);
 WithDraw = default(Byte);
 Cash = default(UInt32);
 LocalSid = default(UInt32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(WithDraw); 
 ds.Write(Cash); 
 ds.Write(LocalSid); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out WithDraw)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class SysAuctionCashTransfer_ReX : SysAuctionCashTransfer_Re
    {
        public SysAuctionCashTransfer_ReX()
        {
             RetCode = default(Int32);
 Cash = default(UInt32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cash); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CreateFactionFortressX : CreateFactionFortress
    {
        public CreateFactionFortressX()
        {
             RoleId = default(Int32);
 FactionId = default(Int32);
 ItemCost = new Octets(); 
 FortressInfo = new Octets(); 
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(FactionId); 
 ds.Write(ItemCost); 
 ds.Write(FortressInfo); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead((IDataSerializer)ItemCost)  &&
 ds.TryRead((IDataSerializer)FortressInfo)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class CreateFactionFortress_ReX : CreateFactionFortress_Re
    {
        public CreateFactionFortress_ReX()
        {
             RetCode = default(Int32);
 Brief = new GFactionFortressBriefInfoX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Brief); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Brief)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionServerRegisterX : FactionServerRegister
    {
        public FactionServerRegisterX()
        {
             ServerId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ServerId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ServerId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class NotifyFactionFortressStateX : NotifyFactionFortressState
    {
        public NotifyFactionFortressStateX()
        {
             FactionId = default(Int32);
 State = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(State); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead(out State) ;
        }
    }
      

    public class NotifyFactionFortressInfo2X : NotifyFactionFortressInfo2
    {
        public NotifyFactionFortressInfo2X()
        {
             FactionId = default(Int32);
 Info2 = new GFactionFortressInfo2X(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(Info2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead((IDataSerializer)Info2) ;
        }
    }
      

    public class FactionFortressEnterX : FactionFortressEnter
    {
        public FactionFortressEnterX()
        {
             RoleId = default(Int32);
 FactionId = default(Int32);
 DstFactionId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(FactionId); 
 ds.Write(DstFactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out DstFactionId) ;
        }
    }
      

    public class FactionFortressEnterNoticeX : FactionFortressEnterNotice
    {
        public FactionFortressEnterNoticeX()
        {
             RoleId = default(Int32);
 DstFactionId = default(Int32);
 DstWorldTag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(DstFactionId); 
 ds.Write(DstWorldTag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out DstFactionId)  &&
 ds.TryRead(out DstWorldTag) ;
        }
    }
      

    public class FactionFortressListX : FactionFortressList
    {
        public FactionFortressListX()
        {
             RoleId = default(Int32);
 Begin = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Begin); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Begin) ;
        }
    }
      

    public class FactionFortressList_ReX : FactionFortressList_Re
    {
        public FactionFortressList_ReX()
        {
             Status = default(Int32);
 Begin = default(UInt32);
 List = new Vector<GFactionFortressBriefInfo, GFactionFortressBriefInfoX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
 ds.Write(Begin); 
 ds.Write(List); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Status)  &&
 ds.TryRead(out Begin)  &&
 ds.TryRead((IDataSerializer)List)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionFortressChallengeX : FactionFortressChallenge
    {
        public FactionFortressChallengeX()
        {
             RoleId = default(Int32);
 FactionId = default(Int32);
 TargetFactionId = default(Int32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(FactionId); 
 ds.Write(TargetFactionId); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out TargetFactionId)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class FactionFortressChallenge_ReX : FactionFortressChallenge_Re
    {
        public FactionFortressChallenge_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionFortressBattleListX : FactionFortressBattleList
    {
        public FactionFortressBattleListX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class FactionFortressBattleList_ReX : FactionFortressBattleList_Re
    {
        public FactionFortressBattleList_ReX()
        {
             Status = default(Int32);
 List = new Vector<GFactionFortressBattleInfo, GFactionFortressBattleInfoX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
 ds.Write(List); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)List)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionFortressGetX : FactionFortressGet
    {
        public FactionFortressGetX()
        {
             RoleId = default(Int32);
 FactionId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out FactionId) ;
        }
    }
      

    public class FactionFortressGet_ReX : FactionFortressGet_Re
    {
        public FactionFortressGet_ReX()
        {
             RetCode = default(Int32);
 Brief = new GFactionFortressBriefInfoX(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Brief); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Brief)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class NotifyFactionFortressIDX : NotifyFactionFortressID
    {
        public NotifyFactionFortressIDX()
        {
             FactionIds = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionIds); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FactionIds) ;
        }
    }
      

    public class NotifyFactionPlayerRenameX : NotifyFactionPlayerRename
    {
        public NotifyFactionPlayerRenameX()
        {
             RoleId = default(Int32);
 NewName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(NewName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)NewName) ;
        }
    }
      

    public class PlayerInfoUpdateX : PlayerInfoUpdate
    {
        public PlayerInfoUpdateX()
        {
             RoleId = default(Int32);
 Level = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Level); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Level) ;
        }
    }
      

    public class PlayerTeamOpX : PlayerTeamOp
    {
        public PlayerTeamOpX()
        {
             Operation = default(Byte);
 TeamUId = default(Int64);
 Captain = default(Int64);
 Members = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Operation); 
 ds.Write(TeamUId); 
 ds.Write(Captain); 
 ds.Write(Members); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Operation)  &&
 ds.TryRead(out TeamUId)  &&
 ds.TryRead(out Captain)  &&
 ds.TryRead((IDataSerializer)Members) ;
        }
    }
      

    public class PlayerTeamMemberOpX : PlayerTeamMemberOp
    {
        public PlayerTeamMemberOpX()
        {
             TeamUId = default(Int64);
 Operation = default(Byte);
 Member = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TeamUId); 
 ds.Write(Operation); 
 ds.Write(Member); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TeamUId)  &&
 ds.TryRead(out Operation)  &&
 ds.TryRead(out Member) ;
        }
    }
      

    public class PlayerEnterLeaveGTX : PlayerEnterLeaveGT
    {
        public PlayerEnterLeaveGTX()
        {
             RoleId = default(Int32);
 Operation = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Operation); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Operation) ;
        }
    }
      

    public class SNSRoleBriefUpdateX : SNSRoleBriefUpdate
    {
        public SNSRoleBriefUpdateX()
        {
             RoleId = default(Int32);
 Brief = new SNSRoleBriefX(); 
 Skills = new SNSRoleSkillsX(); 
 Equipment = new SNSRoleEquipmentX(); 
 Petcorral = new SNSRolePetCorralX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Brief); 
 ds.Write(Skills); 
 ds.Write(Equipment); 
 ds.Write(Petcorral); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Brief)  &&
 ds.TryRead((IDataSerializer)Skills)  &&
 ds.TryRead((IDataSerializer)Equipment)  &&
 ds.TryRead((IDataSerializer)Petcorral) ;
        }
    }
      

    public class FactionCreateX : FactionCreate
    {
        public FactionCreateX()
        {
             FactionName = new Octets(); 
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 FactionProclaim = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionName); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(FactionProclaim); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FactionName)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)FactionProclaim) ;
        }
    }
      

    public class FactionCreate_ReX : FactionCreate_Re
    {
        public FactionCreate_ReX()
        {
             RetCode = default(Int32);
 FactionName = new Octets(); 
 FactionId = default(UInt32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(FactionName); 
 ds.Write(FactionId); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)FactionName)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionListMember_ReX : FactionListMember_Re
    {
        public FactionListMember_ReX()
        {
             Handle = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Proclaim = new Octets(); 
 MemberList = new Vector<FMemberInfo, FMemberInfoX>(); 
 OnlineList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Handle); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Proclaim); 
 ds.Write(MemberList); 
 ds.Write(OnlineList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Handle)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)Proclaim)  &&
 ds.TryRead((IDataSerializer)MemberList)  &&
 ds.TryRead((IDataSerializer)OnlineList) ;
        }
    }
      

    public class FactionApplyJoin_ReX : FactionApplyJoin_Re
    {
        public FactionApplyJoin_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 FactionId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out FactionId) ;
        }
    }
      

    public class FactionAcceptJoin_ReX : FactionAcceptJoin_Re
    {
        public FactionAcceptJoin_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 NewMember = default(Int32);
 Operater = default(Int32);
 FactionId = default(UInt32);
 Level = default(Int32);
 Cls = default(Byte);
 Name = new Octets(); 
 Reputation = default(Int32);
 ReincarnTimes = default(Byte);
 Gender = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(NewMember); 
 ds.Write(Operater); 
 ds.Write(FactionId); 
 ds.Write(Level); 
 ds.Write(Cls); 
 ds.Write(Name); 
 ds.Write(Reputation); 
 ds.Write(ReincarnTimes); 
 ds.Write(Gender); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out NewMember)  &&
 ds.TryRead(out Operater)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Cls)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Reputation)  &&
 ds.TryRead(out ReincarnTimes)  &&
 ds.TryRead(out Gender) ;
        }
    }
      

    public class FactionExpel_ReX : FactionExpel_Re
    {
        public FactionExpel_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 ExpelRoleId = default(UInt32);
 Operater = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(ExpelRoleId); 
 ds.Write(Operater); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out ExpelRoleId)  &&
 ds.TryRead(out Operater) ;
        }
    }
      

    public class FactionBroadcastNotice_ReX : FactionBroadcastNotice_Re
    {
        public FactionBroadcastNotice_ReX()
        {
             SrcroleId = default(Int32);
 DstroleId = default(Int32);
 DstlocalSid = default(UInt32);
 Message = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(SrcroleId); 
 ds.Write(DstroleId); 
 ds.Write(DstlocalSid); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out SrcroleId)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead(out DstlocalSid)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class FactionChangProclaim_ReX : FactionChangProclaim_Re
    {
        public FactionChangProclaim_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Operater = default(Int32);
 Proclaim = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Operater); 
 ds.Write(Proclaim); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Operater)  &&
 ds.TryRead((IDataSerializer)Proclaim) ;
        }
    }
      

    public class FactionMasterResign_ReX : FactionMasterResign_Re
    {
        public FactionMasterResign_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 NewMaster = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(NewMaster); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out NewMaster) ;
        }
    }
      

    public class FactionAppoint_ReX : FactionAppoint_Re
    {
        public FactionAppoint_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 DstroleId = default(Int32);
 NewOccup = default(Byte);
 Operater = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(DstroleId); 
 ds.Write(NewOccup); 
 ds.Write(Operater); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead(out NewOccup)  &&
 ds.TryRead(out Operater) ;
        }
    }
      

    public class FactionResign_ReX : FactionResign_Re
    {
        public FactionResign_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 ResignedRole = default(Int32);
 OldOccup = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(ResignedRole); 
 ds.Write(OldOccup); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out ResignedRole)  &&
 ds.TryRead(out OldOccup) ;
        }
    }
      

    public class FactionLeave_ReX : FactionLeave_Re
    {
        public FactionLeave_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 LeavedRole = default(Int32);
 OldOccup = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(LeavedRole); 
 ds.Write(OldOccup); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out LeavedRole)  &&
 ds.TryRead(out OldOccup) ;
        }
    }
      

    public class FactionUpgrade_ReX : FactionUpgrade_Re
    {
        public FactionUpgrade_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionDegrade_ReX : FactionDegrade_Re
    {
        public FactionDegrade_ReX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Reason = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class FactionDismiss_ReX : FactionDismiss_Re
    {
        public FactionDismiss_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionRename_ReX : FactionRename_Re
    {
        public FactionRename_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 RenamedRoleId = default(Int32);
 NewName = new Octets(); 
 Operater = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(RenamedRoleId); 
 ds.Write(NewName); 
 ds.Write(Operater); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out RenamedRoleId)  &&
 ds.TryRead((IDataSerializer)NewName)  &&
 ds.TryRead(out Operater) ;
        }
    }
      

    public class FactionAllianceApply_ReX : FactionAllianceApply_Re
    {
        public FactionAllianceApply_ReX()
        {
             RetCode = default(Int32);
 DstFId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DstFId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionAllianceReply_ReX : FactionAllianceReply_Re
    {
        public FactionAllianceReply_ReX()
        {
             RetCode = default(Int32);
 DstFId = default(Int32);
 Agree = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DstFId); 
 ds.Write(Agree); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out Agree)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionHostileApply_ReX : FactionHostileApply_Re
    {
        public FactionHostileApply_ReX()
        {
             RetCode = default(Int32);
 DstFId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DstFId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionHostileReply_ReX : FactionHostileReply_Re
    {
        public FactionHostileReply_ReX()
        {
             RetCode = default(Int32);
 DstFId = default(Int32);
 Agree = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DstFId); 
 ds.Write(Agree); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out Agree)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionRemoveRelationApply_ReX : FactionRemoveRelationApply_Re
    {
        public FactionRemoveRelationApply_ReX()
        {
             RetCode = default(Int32);
 DstFId = default(Int32);
 Force = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DstFId); 
 ds.Write(Force); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out Force)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionRemoveRelationReply_ReX : FactionRemoveRelationReply_Re
    {
        public FactionRemoveRelationReply_ReX()
        {
             RetCode = default(Int32);
 DstFId = default(Int32);
 Agree = default(Byte);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DstFId); 
 ds.Write(Agree); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out Agree)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionListRelation_ReX : FactionListRelation_Re
    {
        public FactionListRelation_ReX()
        {
             LastOpTime = default(Int32);
 Alliance = new Vector<GFactionAlliance, GFactionAllianceX>(); 
 Hostile = new Vector<GFactionHostile, GFactionHostileX>(); 
 Apply = new Vector<GFactionRelationApply, GFactionRelationApplyX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LastOpTime); 
 ds.Write(Alliance); 
 ds.Write(Hostile); 
 ds.Write(Apply); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LastOpTime)  &&
 ds.TryRead((IDataSerializer)Alliance)  &&
 ds.TryRead((IDataSerializer)Hostile)  &&
 ds.TryRead((IDataSerializer)Apply)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionRelationRecvApplyX : FactionRelationRecvApply
    {
        public FactionRelationRecvApplyX()
        {
             ApplyType = default(Int32);
 SrcFId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ApplyType); 
 ds.Write(SrcFId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ApplyType)  &&
 ds.TryRead(out SrcFId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionRelationRecvReplyX : FactionRelationRecvReply
    {
        public FactionRelationRecvReplyX()
        {
             PreApplyType = default(Int32);
 Agree = default(Byte);
 SrcFId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(PreApplyType); 
 ds.Write(Agree); 
 ds.Write(SrcFId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out PreApplyType)  &&
 ds.TryRead(out Agree)  &&
 ds.TryRead(out SrcFId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionDelayExpelAnnounceX : FactionDelayExpelAnnounce
    {
        public FactionDelayExpelAnnounceX()
        {
             RetCode = default(Int32);
 OptType = default(Byte);
 Operater = default(Int32);
 ExpelRoleId = default(Int32);
 Time = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(OptType); 
 ds.Write(Operater); 
 ds.Write(ExpelRoleId); 
 ds.Write(Time); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out OptType)  &&
 ds.TryRead(out Operater)  &&
 ds.TryRead(out ExpelRoleId)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SyncForceGlobalDataX : SyncForceGlobalData
    {
        public SyncForceGlobalDataX()
        {
             List = new Vector<GForceGlobalDataBrief, GForceGlobalDataBriefX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(List); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)List) ;
        }
    }
      

    public class NotifyPlayerJoinOrLeaveForceX : NotifyPlayerJoinOrLeaveForce
    {
        public NotifyPlayerJoinOrLeaveForceX()
        {
             ForceId = default(Int32);
 IsJoin = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ForceId); 
 ds.Write(IsJoin); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ForceId)  &&
 ds.TryRead(out IsJoin) ;
        }
    }
      

    public class IncreaseForceActivityX : IncreaseForceActivity
    {
        public IncreaseForceActivityX()
        {
             ForceId = default(Int32);
 Activity = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ForceId); 
 ds.Write(Activity); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ForceId)  &&
 ds.TryRead(out Activity) ;
        }
    }
      

    public class CountryBattleApplyX : CountryBattleApply
    {
        public CountryBattleApplyX()
        {
             List = new Vector<CountryBattleApplyEntry, CountryBattleApplyEntryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(List); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)List) ;
        }
    }
      

    public class CountryBattleApply_ReX : CountryBattleApply_Re
    {
        public CountryBattleApply_ReX()
        {
             RetCode = default(Int32);
 CountryId = default(Int32);
 CountryInvalidTimestamp = default(Int32);
 CapitalWorldtag = default(Int32);
 CapitalPosX = default(Single);
 CapitalPosY = default(Single);
 CapitalPosZ = default(Single);
 List = new Vector<CountryBattleApplyEntry, CountryBattleApplyEntryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(CountryId); 
 ds.Write(CountryInvalidTimestamp); 
 ds.Write(CapitalWorldtag); 
 ds.Write(CapitalPosX); 
 ds.Write(CapitalPosY); 
 ds.Write(CapitalPosZ); 
 ds.Write(List); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out CountryId)  &&
 ds.TryRead(out CountryInvalidTimestamp)  &&
 ds.TryRead(out CapitalWorldtag)  &&
 ds.TryRead(out CapitalPosX)  &&
 ds.TryRead(out CapitalPosY)  &&
 ds.TryRead(out CapitalPosZ)  &&
 ds.TryRead((IDataSerializer)List) ;
        }
    }
      

    public class CountryBattleJoinNoticeX : CountryBattleJoinNotice
    {
        public CountryBattleJoinNoticeX()
        {
             RoleId = default(Int32);
 CountryId = default(Int32);
 Worldtag = default(Int32);
 MajorStrength = default(Int32);
 MinorStrength = default(Int32);
 IsKing = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CountryId); 
 ds.Write(Worldtag); 
 ds.Write(MajorStrength); 
 ds.Write(MinorStrength); 
 ds.Write(IsKing); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out CountryId)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead(out MajorStrength)  &&
 ds.TryRead(out MinorStrength)  &&
 ds.TryRead(out IsKing) ;
        }
    }
      

    public class CountryBattleLeaveNoticeX : CountryBattleLeaveNotice
    {
        public CountryBattleLeaveNoticeX()
        {
             RoleId = default(Int32);
 CountryId = default(Int32);
 MajorStrength = default(Int32);
 MinorStrength = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CountryId); 
 ds.Write(MajorStrength); 
 ds.Write(MinorStrength); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out CountryId)  &&
 ds.TryRead(out MajorStrength)  &&
 ds.TryRead(out MinorStrength) ;
        }
    }
      

    public class CountryBattleOnlineNoticeX : CountryBattleOnlineNotice
    {
        public CountryBattleOnlineNoticeX()
        {
             RoleId = default(Int32);
 CountryId = default(Int32);
 Worldtag = default(Int32);
 MinorStrength = default(Int32);
 IsKing = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CountryId); 
 ds.Write(Worldtag); 
 ds.Write(MinorStrength); 
 ds.Write(IsKing); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out CountryId)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead(out MinorStrength)  &&
 ds.TryRead(out IsKing) ;
        }
    }
      

    public class CountryBattleOfflineNoticeX : CountryBattleOfflineNotice
    {
        public CountryBattleOfflineNoticeX()
        {
             RoleId = default(Int32);
 CountryId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CountryId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out CountryId) ;
        }
    }
      

    public class CountryBattleEnterMapNoticeX : CountryBattleEnterMapNotice
    {
        public CountryBattleEnterMapNoticeX()
        {
             RoleId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class CountryBattleServerRegisterX : CountryBattleServerRegister
    {
        public CountryBattleServerRegisterX()
        {
             ServerType = default(Int32);
 WarType = default(Int32);
 ServerId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ServerType); 
 ds.Write(WarType); 
 ds.Write(ServerId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ServerType)  &&
 ds.TryRead(out WarType)  &&
 ds.TryRead(out ServerId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class CountryBattleConfigNotifyX : CountryBattleConfigNotify
    {
        public CountryBattleConfigNotifyX()
        {
             CountryCapitals = new Vector<GCountryCapital, GCountryCapitalX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CountryCapitals); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)CountryCapitals) ;
        }
    }
      

    public class CountryBattleMoveX : CountryBattleMove
    {
        public CountryBattleMoveX()
        {
             RoleId = default(Int32);
 Dest = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Dest); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Dest)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleMove_ReX : CountryBattleMove_Re
    {
        public CountryBattleMove_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 Dest = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(Dest); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Dest)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleSyncPlayerLocationX : CountryBattleSyncPlayerLocation
    {
        public CountryBattleSyncPlayerLocationX()
        {
             RoleId = default(Int32);
 DomainId = default(Int32);
 Reason = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(DomainId); 
 ds.Write(Reason); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out DomainId)  &&
 ds.TryRead(out Reason)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleStartX : CountryBattleStart
    {
        public CountryBattleStartX()
        {
             BattleId = default(Int32);
 Defender = default(UInt32);
 Attacker = default(UInt32);
 PlayerLimit = default(UInt32);
 EndTime = default(Int32);
 DefenderPlayerCount = default(UInt32);
 AttackerPlayerCount = default(UInt32);
 CountryMaxPlayerCount = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(Defender); 
 ds.Write(Attacker); 
 ds.Write(PlayerLimit); 
 ds.Write(EndTime); 
 ds.Write(DefenderPlayerCount); 
 ds.Write(AttackerPlayerCount); 
 ds.Write(CountryMaxPlayerCount); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out Defender)  &&
 ds.TryRead(out Attacker)  &&
 ds.TryRead(out PlayerLimit)  &&
 ds.TryRead(out EndTime)  &&
 ds.TryRead(out DefenderPlayerCount)  &&
 ds.TryRead(out AttackerPlayerCount)  &&
 ds.TryRead(out CountryMaxPlayerCount) ;
        }
    }
      

    public class CountryBattleStart_ReX : CountryBattleStart_Re
    {
        public CountryBattleStart_ReX()
        {
             RetCode = default(Int32);
 BattleId = default(Int32);
 Worldtag = default(Int32);
 Defender = default(UInt32);
 Attacker = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(BattleId); 
 ds.Write(Worldtag); 
 ds.Write(Defender); 
 ds.Write(Attacker); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out BattleId)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead(out Defender)  &&
 ds.TryRead(out Attacker) ;
        }
    }
      

    public class CountryBattleEnterX : CountryBattleEnter
    {
        public CountryBattleEnterX()
        {
             BattleId = default(Int32);
 Worldtag = default(Int32);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(Worldtag); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class CountryBattleEndX : CountryBattleEnd
    {
        public CountryBattleEndX()
        {
             BattleId = default(Int32);
 BattleResult = default(Int32);
 Attacker = default(Int32);
 Defender = default(Int32);
 AttackerScore = new Vector<GCountryBattlePersonalScore, GCountryBattlePersonalScoreX>(); 
 DefenderScore = new Vector<GCountryBattlePersonalScore, GCountryBattlePersonalScoreX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(BattleResult); 
 ds.Write(Attacker); 
 ds.Write(Defender); 
 ds.Write(AttackerScore); 
 ds.Write(DefenderScore); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out BattleResult)  &&
 ds.TryRead(out Attacker)  &&
 ds.TryRead(out Defender)  &&
 ds.TryRead((IDataSerializer)AttackerScore)  &&
 ds.TryRead((IDataSerializer)DefenderScore) ;
        }
    }
      

    public class CountryBattleGetMapX : CountryBattleGetMap
    {
        public CountryBattleGetMapX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleGetMap_ReX : CountryBattleGetMap_Re
    {
        public CountryBattleGetMap_ReX()
        {
             RetCode = default(Int32);
 Domains = new Vector<GCountryBattleDomain, GCountryBattleDomainX>(); 
 Kings = new Vector<Int32>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Domains); 
 ds.Write(Kings); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Domains)  &&
 ds.TryRead((IDataSerializer)Kings)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleSyncPlayerPosX : CountryBattleSyncPlayerPos
    {
        public CountryBattleSyncPlayerPosX()
        {
             RoleId = default(Int32);
 Worldtag = default(Int32);
 PosX = default(Single);
 PosY = default(Single);
 PosZ = default(Single);
 IsCapital = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Worldtag); 
 ds.Write(PosX); 
 ds.Write(PosY); 
 ds.Write(PosZ); 
 ds.Write(IsCapital); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead(out PosX)  &&
 ds.TryRead(out PosY)  &&
 ds.TryRead(out PosZ)  &&
 ds.TryRead(out IsCapital) ;
        }
    }
      

    public class CountryBattleGetPlayerLocationX : CountryBattleGetPlayerLocation
    {
        public CountryBattleGetPlayerLocationX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleGetConfigX : CountryBattleGetConfig
    {
        public CountryBattleGetConfigX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleGetConfig_ReX : CountryBattleGetConfig_Re
    {
        public CountryBattleGetConfig_ReX()
        {
             StartTimestamp = default(Int32);
 EndTimetamp = default(Int32);
 Bonus = default(Int32);
 IsBattleOpen = default(Byte);
 Domain2DataType = default(Byte);
 Domain2DatatTimestamp = default(UInt32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(StartTimestamp); 
 ds.Write(EndTimetamp); 
 ds.Write(Bonus); 
 ds.Write(IsBattleOpen); 
 ds.Write(Domain2DataType); 
 ds.Write(Domain2DatatTimestamp); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out StartTimestamp)  &&
 ds.TryRead(out EndTimetamp)  &&
 ds.TryRead(out Bonus)  &&
 ds.TryRead(out IsBattleOpen)  &&
 ds.TryRead(out Domain2DataType)  &&
 ds.TryRead(out Domain2DatatTimestamp)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleGetScoreX : CountryBattleGetScore
    {
        public CountryBattleGetScoreX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleGetScore_ReX : CountryBattleGetScore_Re
    {
        public CountryBattleGetScore_ReX()
        {
             PlayerScore = default(Int32);
 CountryScore = new Vector<Int32>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(PlayerScore); 
 ds.Write(CountryScore); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out PlayerScore)  &&
 ds.TryRead((IDataSerializer)CountryScore)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattlePreEnterNotifyX : CountryBattlePreEnterNotify
    {
        public CountryBattlePreEnterNotifyX()
        {
             BattleId = default(Int32);
 RoleId = default(Int32);
 Timeout = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(RoleId); 
 ds.Write(Timeout); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Timeout)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattlePreEnterX : CountryBattlePreEnter
    {
        public CountryBattlePreEnterX()
        {
             BattleId = default(Int32);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class CountryBattleResultX : CountryBattleResult
    {
        public CountryBattleResultX()
        {
             PlayerBonus = default(Int32);
 CountryBonus = new Vector<Int32>(); 
 CountryDomainsCount = new Vector<Int32>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(PlayerBonus); 
 ds.Write(CountryBonus); 
 ds.Write(CountryDomainsCount); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out PlayerBonus)  &&
 ds.TryRead((IDataSerializer)CountryBonus)  &&
 ds.TryRead((IDataSerializer)CountryDomainsCount)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleReturnCapitalX : CountryBattleReturnCapital
    {
        public CountryBattleReturnCapitalX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class CountryBattleSingleBattleResultX : CountryBattleSingleBattleResult
    {
        public CountryBattleSingleBattleResultX()
        {
             DomainId = default(Int32);
 SingleBattleTotalScore = default(Int32);
 PlayerSingleBattleScore = default(Int32);
 PlayerRank = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(DomainId); 
 ds.Write(SingleBattleTotalScore); 
 ds.Write(PlayerSingleBattleScore); 
 ds.Write(PlayerRank); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out DomainId)  &&
 ds.TryRead(out SingleBattleTotalScore)  &&
 ds.TryRead(out PlayerSingleBattleScore)  &&
 ds.TryRead(out PlayerRank)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleKingAssignAssaultX : CountryBattleKingAssignAssault
    {
        public CountryBattleKingAssignAssaultX()
        {
             KingRoleId = default(Int32);
 DomainId = default(Int32);
 AssaultType = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(KingRoleId); 
 ds.Write(DomainId); 
 ds.Write(AssaultType); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out KingRoleId)  &&
 ds.TryRead(out DomainId)  &&
 ds.TryRead(out AssaultType) ;
        }
    }
      

    public class CountryBattleKingAssignAssault_ReX : CountryBattleKingAssignAssault_Re
    {
        public CountryBattleKingAssignAssault_ReX()
        {
             RetCode = default(Int32);
 DomainId = default(Int32);
 AssaultType = default(Byte);
 CommandPoint = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DomainId); 
 ds.Write(AssaultType); 
 ds.Write(CommandPoint); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DomainId)  &&
 ds.TryRead(out AssaultType)  &&
 ds.TryRead(out CommandPoint)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleKingResetBattleLimitX : CountryBattleKingResetBattleLimit
    {
        public CountryBattleKingResetBattleLimitX()
        {
             KingRoleId = default(Int32);
 DomainId = default(Int32);
 Op = default(Byte);
 Limit = new Vector<GCountryBattleLimit, GCountryBattleLimitX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(KingRoleId); 
 ds.Write(DomainId); 
 ds.Write(Op); 
 ds.Write(Limit); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out KingRoleId)  &&
 ds.TryRead(out DomainId)  &&
 ds.TryRead(out Op)  &&
 ds.TryRead((IDataSerializer)Limit) ;
        }
    }
      

    public class CountryBattleGetBattleLimitX : CountryBattleGetBattleLimit
    {
        public CountryBattleGetBattleLimitX()
        {
             RoleId = default(Int32);
 DomainId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(DomainId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out DomainId) ;
        }
    }
      

    public class CountryBattleGetBattleLimit_ReX : CountryBattleGetBattleLimit_Re
    {
        public CountryBattleGetBattleLimit_ReX()
        {
             RetCode = default(Int32);
 DomainId = default(Int32);
 Limit = new Vector<GCountryBattleLimit, GCountryBattleLimitX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DomainId); 
 ds.Write(Limit); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DomainId)  &&
 ds.TryRead((IDataSerializer)Limit)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleGetKingCommandPointX : CountryBattleGetKingCommandPoint
    {
        public CountryBattleGetKingCommandPointX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class CountryBattleGetKingCommandPoint_ReX : CountryBattleGetKingCommandPoint_Re
    {
        public CountryBattleGetKingCommandPoint_ReX()
        {
             CommandPoint = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CommandPoint); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out CommandPoint)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetCNetServerConfigX : GetCNetServerConfig
    {
        public GetCNetServerConfigX()
        {
             RoleId = default(Int32);
 Keys = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Keys); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Keys) ;
        }
    }
      

    public class GetRemoteCNetServerConfigX : GetRemoteCNetServerConfig
    {
        public GetRemoteCNetServerConfigX()
        {
             Keys = new Vector<Int32>(); 
 LinkSId = default(UInt32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Keys); 
 ds.Write(LinkSId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Keys)  &&
 ds.TryRead(out LinkSId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class CountryBattleDestroyInstanceX : CountryBattleDestroyInstance
    {
        public CountryBattleDestroyInstanceX()
        {
             DomainId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(DomainId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out DomainId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class PlayerFactionInfoX : PlayerFactionInfo
    {
        public PlayerFactionInfoX()
        {
             RoleList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)RoleList) ;
        }
    }
      

    public class PlayerFactionInfo_ReX : PlayerFactionInfo_Re
    {
        public PlayerFactionInfo_ReX()
        {
             RetCode = default(Int32);
 FactionInfo = new Vector<PFactionInfo, PFactionInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(FactionInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)FactionInfo) ;
        }
    }
      

    public class FactionChatX : FactionChat
    {
        public FactionChatX()
        {
             Channel = default(Byte);
 Emotion = default(Byte);
 SrcroleId = default(Int32);
 Message = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Channel); 
 ds.Write(Emotion); 
 ds.Write(SrcroleId); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Channel)  &&
 ds.TryRead(out Emotion)  &&
 ds.TryRead(out SrcroleId)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class FactionOPRequestX : FactionOPRequest
    {
        public FactionOPRequestX()
        {
             OpType = default(Int32);
 RoleId = default(Int32);
 Params = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(OpType); 
 ds.Write(RoleId); 
 ds.Write(Params); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out OpType)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Params) ;
        }
    }
      

    public class FactionOPRequest_ReX : FactionOPRequest_Re
    {
        public FactionOPRequest_ReX()
        {
             RetCode = default(Int32);
 OpType = default(Int32);
 RoleId = default(Int32);
 LinkId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(OpType); 
 ds.Write(RoleId); 
 ds.Write(LinkId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out OpType)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LinkId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionBeginSyncX : FactionBeginSync
    {
        public FactionBeginSyncX()
        {
             TId = default(UInt32);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class FactionBeginSync_ReX : FactionBeginSync_Re
    {
        public FactionBeginSync_ReX()
        {
             RetCode = default(Int32);
 TId = default(UInt32);
 RoleId = default(Int32);
 SyncData = new FactionOPSyncInfoX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TId); 
 ds.Write(RoleId); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class FactionEndSyncX : FactionEndSync
    {
        public FactionEndSyncX()
        {
             TId = default(UInt32);
 RoleId = default(Int32);
 SyncData = new FactionOPSyncInfoX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(RoleId); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class FactionAcceptJoinX : FactionAcceptJoin
    {
        public FactionAcceptJoinX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 FactionId = default(UInt32);
 InvitedRoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(FactionId); 
 ds.Write(InvitedRoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out InvitedRoleId) ;
        }
    }
      

    public class GetFactionBaseInfoX : GetFactionBaseInfo
    {
        public GetFactionBaseInfoX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 FactionList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(FactionList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)FactionList) ;
        }
    }
      

    public class GetFactionBaseInfo_ReX : GetFactionBaseInfo_Re
    {
        public GetFactionBaseInfo_ReX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 FactionInfo = new GFactionBaseInfoX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(FactionInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)FactionInfo) ;
        }
    }
      

    public class GetPlayerFactionInfoX : GetPlayerFactionInfo
    {
        public GetPlayerFactionInfoX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetPlayerFactionInfo_ReX : GetPlayerFactionInfo_Re
    {
        public GetPlayerFactionInfo_ReX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 FactionInfo = new GUserFactionX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(FactionInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead((IDataSerializer)FactionInfo) ;
        }
    }
      

    public class DelFactionAnnounceX : DelFactionAnnounce
    {
        public DelFactionAnnounceX()
        {
             FactionId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId) ;
        }
    }
      

    public class FactionListOnlineX : FactionListOnline
    {
        public FactionListOnlineX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class FactionListOnline_ReX : FactionListOnline_Re
    {
        public FactionListOnline_ReX()
        {
             FidList = new Vector<UInt32>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FidList); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FidList)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetPlayerFactionRelationX : GetPlayerFactionRelation
    {
        public GetPlayerFactionRelationX()
        {
             FactionId = default(Int32);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class GetPlayerFactionRelation_ReX : GetPlayerFactionRelation_Re
    {
        public GetPlayerFactionRelation_ReX()
        {
             FactionId = default(Int32);
 RoleIdList = new Vector<Int32>(); 
 Alliance = new Vector<Int32>(); 
 Hostile = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(RoleIdList); 
 ds.Write(Alliance); 
 ds.Write(Hostile); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead((IDataSerializer)RoleIdList)  &&
 ds.TryRead((IDataSerializer)Alliance)  &&
 ds.TryRead((IDataSerializer)Hostile) ;
        }
    }
      

    public class FactionCongregateRequestX : FactionCongregateRequest
    {
        public FactionCongregateRequestX()
        {
             FactionId = default(Int32);
 Sponsor = default(Int32);
 Data = new Octets(); 
 Member = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(Sponsor); 
 ds.Write(Data); 
 ds.Write(Member); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead(out Sponsor)  &&
 ds.TryRead((IDataSerializer)Data)  &&
 ds.TryRead((IDataSerializer)Member) ;
        }
    }
      

    public class KEGetStatusX : KEGetStatus
    {
        public KEGetStatusX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class KEGetStatus_ReX : KEGetStatus_Re
    {
        public KEGetStatus_ReX()
        {
             Status = default(Int32);
 King = new KEKingX(); 
 CandidateList = new Vector<KECandidate, KECandidateX>(); 
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
 ds.Write(King); 
 ds.Write(CandidateList); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)King)  &&
 ds.TryRead((IDataSerializer)CandidateList)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class KECandidateApplyX : KECandidateApply
    {
        public KECandidateApplyX()
        {
             RoleId = default(Int32);
 ItemId = default(UInt32);
 ItemNumber = default(Int32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemId); 
 ds.Write(ItemNumber); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class KECandidateApply_ReX : KECandidateApply_Re
    {
        public KECandidateApply_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class KEVotingX : KEVoting
    {
        public KEVotingX()
        {
             RoleId = default(Int32);
 ItemId = default(UInt32);
 ItemPos = default(Int32);
 ItemNumber = default(Int32);
 CandidateRoleId = default(Int32);
 SyncData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemNumber); 
 ds.Write(CandidateRoleId); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead(out CandidateRoleId)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class KEVoting_ReX : KEVoting_Re
    {
        public KEVoting_ReX()
        {
             RetCode = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class KEKingNotifyX : KEKingNotify
    {
        public KEKingNotifyX()
        {
             RoleId = default(Int32);
 EndTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(EndTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out EndTime) ;
        }
    }
      

    public class TankBattleServerRegisterX : TankBattleServerRegister
    {
        public TankBattleServerRegisterX()
        {
             ServerId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ServerId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ServerId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class TankBattlePlayerApplyX : TankBattlePlayerApply
    {
        public TankBattlePlayerApplyX()
        {
             RoleId = default(Int32);
 Model = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Model); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Model) ;
        }
    }
      

    public class TankBattlePlayerApply_ReX : TankBattlePlayerApply_Re
    {
        public TankBattlePlayerApply_ReX()
        {
             RoleId = default(Int32);
 RetCode = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RetCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class TankBattleEnterX : TankBattleEnter
    {
        public TankBattleEnterX()
        {
             RoleId = default(Int32);
 BattleId = default(Int32);
 Worldtag = default(Int32);
 Model = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(BattleId); 
 ds.Write(Worldtag); 
 ds.Write(Model); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out BattleId)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead(out Model) ;
        }
    }
      

    public class TankBattlePlayerEnterX : TankBattlePlayerEnter
    {
        public TankBattlePlayerEnterX()
        {
             RoleId = default(Int32);
 BattleId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(BattleId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out BattleId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class TankBattlePlayerLeaveX : TankBattlePlayerLeave
    {
        public TankBattlePlayerLeaveX()
        {
             RoleId = default(Int32);
 BattleId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(BattleId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out BattleId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class TankBattleStartX : TankBattleStart
    {
        public TankBattleStartX()
        {
             BattleId = default(Int32);
 EndTime = default(Int32);
 MaxPlayerCount = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(EndTime); 
 ds.Write(MaxPlayerCount); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out EndTime)  &&
 ds.TryRead(out MaxPlayerCount) ;
        }
    }
      

    public class TankBattleStart_ReX : TankBattleStart_Re
    {
        public TankBattleStart_ReX()
        {
             RetCode = default(Int32);
 BattleId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(BattleId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out BattleId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class TankBattleEndX : TankBattleEnd
    {
        public TankBattleEndX()
        {
             BattleId = default(Int32);
 Worldtag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(Worldtag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out Worldtag) ;
        }
    }
      

    public class TankBattlePlayerScoreUpdateX : TankBattlePlayerScoreUpdate
    {
        public TankBattlePlayerScoreUpdateX()
        {
             BattleId = default(Int32);
 Worldtag = default(Int32);
 PlayerScores = new Vector<TankBattlePlayerScoreInfo, TankBattlePlayerScoreInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(Worldtag); 
 ds.Write(PlayerScores); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead((IDataSerializer)PlayerScores) ;
        }
    }
      

    public class TankBattlePlayerGetRankX : TankBattlePlayerGetRank
    {
        public TankBattlePlayerGetRankX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class TankBattlePlayerGetRank_ReX : TankBattlePlayerGetRank_Re
    {
        public TankBattlePlayerGetRank_ReX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 RetCode = default(Int32);
 YourScore = new TankBattlePlayerScoreInfoX(); 
 PlayerScores = new Vector<TankBattlePlayerScoreInfo, TankBattlePlayerScoreInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(RetCode); 
 ds.Write(YourScore); 
 ds.Write(PlayerScores); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)YourScore)  &&
 ds.TryRead((IDataSerializer)PlayerScores) ;
        }
    }
      

    public class SendRefAddBonusX : SendRefAddBonus
    {
        public SendRefAddBonusX()
        {
             RoleId = default(Int32);
 Bonus = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Bonus); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Bonus) ;
        }
    }
      

    public class SendRefCashUsedX : SendRefCashUsed
    {
        public SendRefCashUsedX()
        {
             RoleId = default(Int32);
 CashUsed = default(Int32);
 Level = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CashUsed); 
 ds.Write(Level); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out CashUsed)  &&
 ds.TryRead(out Level) ;
        }
    }
      

    public class RefListReferralsX : RefListReferrals
    {
        public RefListReferralsX()
        {
             RoleId = default(Int32);
 StartIndex = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(StartIndex); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out StartIndex)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class RefListReferrals_ReX : RefListReferrals_Re
    {
        public RefListReferrals_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 StartIndex = default(Int32);
 Total = default(Int32);
 BonusAvailToday = default(Int32);
 Referrals = new Vector<ReferralBrief, ReferralBriefX>(); 
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(StartIndex); 
 ds.Write(Total); 
 ds.Write(BonusAvailToday); 
 ds.Write(Referrals); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out StartIndex)  &&
 ds.TryRead(out Total)  &&
 ds.TryRead(out BonusAvailToday)  &&
 ds.TryRead((IDataSerializer)Referrals)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class RefWithdrawBonusX : RefWithdrawBonus
    {
        public RefWithdrawBonusX()
        {
             RoleId = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class RefWithdrawBonus_ReX : RefWithdrawBonus_Re
    {
        public RefWithdrawBonus_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class RefGetReferenceCodeX : RefGetReferenceCode
    {
        public RefGetReferenceCodeX()
        {
             RoleId = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class RefGetReferenceCode_ReX : RefGetReferenceCode_Re
    {
        public RefGetReferenceCode_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 Level = default(Int32);
 Reputation = default(Int32);
 RefCode = new Octets(); 
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(Level); 
 ds.Write(Reputation); 
 ds.Write(RefCode); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Reputation)  &&
 ds.TryRead((IDataSerializer)RefCode)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SendRewardAddBonusX : SendRewardAddBonus
    {
        public SendRewardAddBonusX()
        {
             RoleId = default(Int32);
 Bonus = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Bonus); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Bonus) ;
        }
    }
      

    public class GetRewardListX : GetRewardList
    {
        public GetRewardListX()
        {
             RoleId = default(Int32);
 StartIndex = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(StartIndex); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out StartIndex)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class GetRewardList_ReX : GetRewardList_Re
    {
        public GetRewardList_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 ConsumePoints = default(Int32);
 StartIndex = default(Int32);
 Total = default(Int32);
 RewardList = new Vector<RewardItem, RewardItemX>(); 
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(ConsumePoints); 
 ds.Write(StartIndex); 
 ds.Write(Total); 
 ds.Write(RewardList); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out ConsumePoints)  &&
 ds.TryRead(out StartIndex)  &&
 ds.TryRead(out Total)  &&
 ds.TryRead((IDataSerializer)RewardList)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ExchangeConsumePointsX : ExchangeConsumePoints
    {
        public ExchangeConsumePointsX()
        {
             RoleId = default(Int32);
 RewardType = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RewardType); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out RewardType)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class ExchangeConsumePoints_ReX : ExchangeConsumePoints_Re
    {
        public ExchangeConsumePoints_ReX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 BonusAdd = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(BonusAdd); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out BonusAdd)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class RewardMatureNoticeX : RewardMatureNotice
    {
        public RewardMatureNoticeX()
        {
             RoleId = default(Int32);
 BonusReward = default(Int32);
 LocalSid = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(BonusReward); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out BonusReward)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class SendTaskRewardX : SendTaskReward
    {
        public SendTaskRewardX()
        {
             RoleId = default(Int32);
 BonusAdd = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(BonusAdd); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out BonusAdd) ;
        }
    }
      

    public class AcreportX : Acreport
    {
        public AcreportX()
        {
             RoleId = default(Int32);
 Report = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Report); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Report) ;
        }
    }
      

    public class ACWhoAmIX : ACWhoAmI
    {
        public ACWhoAmIX()
        {
             ClientType = default(Int32);
 SubId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ClientType); 
 ds.Write(SubId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ClientType)  &&
 ds.TryRead(out SubId) ;
        }
    }
      

    public class ACRemoteCodeX : ACRemoteCode
    {
        public ACRemoteCodeX()
        {
             DstroleId = default(Int32);
 Content = new Vector<Octets>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(DstroleId); 
 ds.Write(Content); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out DstroleId)  &&
 ds.TryRead((IDataSerializer)Content) ;
        }
    }
      

    public class ACConnectReX : ACConnectRe
    {
        public ACConnectReX()
        {
             AId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(AId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out AId) ;
        }
    }
      

    public class ACReloadConfigX : ACReloadConfig
    {
        public ACReloadConfigX()
        {
             ReloadType = default(Int32);
 Config = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ReloadType); 
 ds.Write(Config); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ReloadType)  &&
 ds.TryRead((IDataSerializer)Config) ;
        }
    }
      

    public class ACReloadConfigReX : ACReloadConfigRe
    {
        public ACReloadConfigReX()
        {
             ResCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ResCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ResCode) ;
        }
    }
      

    public class ACQLogInfoX : ACQLogInfo
    {
        public ACQLogInfoX()
        {
             ACQ = new ACQX(); 
 Logs = new Vector<ACLogInfo, ACLogInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ACQ); 
 ds.Write(Logs); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ACQ)  &&
 ds.TryRead((IDataSerializer)Logs) ;
        }
    }
      

    public class ACQUserOnlineX : ACQUserOnline
    {
        public ACQUserOnlineX()
        {
             ACQ = new ACQX(); 
 Users = new Vector<IntData, IntDataX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ACQ); 
 ds.Write(Users); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ACQ)  &&
 ds.TryRead((IDataSerializer)Users) ;
        }
    }
      

    public class ACSendCodeX : ACSendCode
    {
        public ACSendCodeX()
        {
             RoleId = default(Int32);
 CodeName = new Octets(); 
 Param = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CodeName); 
 ds.Write(Param); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)CodeName)  &&
 ds.TryRead((IDataSerializer)Param) ;
        }
    }
      

    public class ACQCodeResX : ACQCodeRes
    {
        public ACQCodeResX()
        {
             ACQ = new ACQX(); 
 Res = new Vector<ACUserCodeRes, ACUserCodeResX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ACQ); 
 ds.Write(Res); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ACQ)  &&
 ds.TryRead((IDataSerializer)Res) ;
        }
    }
      

    public class ACQPatternsX : ACQPatterns
    {
        public ACQPatternsX()
        {
             ACQ = new ACQX(); 
 Patterns = new Vector<ACStackPattern, ACStackPatternX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ACQ); 
 ds.Write(Patterns); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ACQ)  &&
 ds.TryRead((IDataSerializer)Patterns) ;
        }
    }
      

    public class ACQPlatformInfoX : ACQPlatformInfo
    {
        public ACQPlatformInfoX()
        {
             ACQ = new ACQX(); 
 PlatformInfo = new Vector<ACPlatformInfo, ACPlatformInfoX>(); 
 CpuInfo = new Vector<ACCPUInfo, ACCPUInfoX>(); 
 MemInfo = new Vector<ACMemInfo, ACMemInfoX>(); 
 AdapterInfo = new Vector<ACAdapterInfo, ACAdapterInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ACQ); 
 ds.Write(PlatformInfo); 
 ds.Write(CpuInfo); 
 ds.Write(MemInfo); 
 ds.Write(AdapterInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ACQ)  &&
 ds.TryRead((IDataSerializer)PlatformInfo)  &&
 ds.TryRead((IDataSerializer)CpuInfo)  &&
 ds.TryRead((IDataSerializer)MemInfo)  &&
 ds.TryRead((IDataSerializer)AdapterInfo) ;
        }
    }
      

    public class ACVersionX : ACVersion
    {
        public ACVersionX()
        {
             Version = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Version); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Version) ;
        }
    }
      

    public class ACQStrOwnerX : ACQStrOwner
    {
        public ACQStrOwnerX()
        {
             ACQ = new ACQX(); 
 Owners = new Vector<IntData, IntDataX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ACQ); 
 ds.Write(Owners); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ACQ)  &&
 ds.TryRead((IDataSerializer)Owners) ;
        }
    }
      

    public class ACQMouseInfoX : ACQMouseInfo
    {
        public ACQMouseInfoX()
        {
             ACQ = new ACQX(); 
 MouseInfo = new Vector<ACMouseInfo, ACMouseInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ACQ); 
 ds.Write(MouseInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ACQ)  &&
 ds.TryRead((IDataSerializer)MouseInfo) ;
        }
    }
      

    public class ACQThreadTimesX : ACQThreadTimes
    {
        public ACQThreadTimesX()
        {
             ACQ = new ACQX(); 
 ProcessTime = new ACThreadTimeX(); 
 ThreadTimes = new Vector<ACThreadTime, ACThreadTimeX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ACQ); 
 ds.Write(ProcessTime); 
 ds.Write(ThreadTimes); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ACQ)  &&
 ds.TryRead((IDataSerializer)ProcessTime)  &&
 ds.TryRead((IDataSerializer)ThreadTimes) ;
        }
    }
      

    public class ACProtoStatX : ACProtoStat
    {
        public ACProtoStatX()
        {
             RoleId = default(Int32);
 Keepalive = default(Int32);
 GameDataSend = default(Int32);
 PublicChat = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Keepalive); 
 ds.Write(GameDataSend); 
 ds.Write(PublicChat); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Keepalive)  &&
 ds.TryRead(out GameDataSend)  &&
 ds.TryRead(out PublicChat) ;
        }
    }
      

    public class ACQProtocolStatsX : ACQProtocolStats
    {
        public ACQProtocolStatsX()
        {
             ACQ = new ACQX(); 
 ProtoStats = new Vector<ACProtocolStat, ACProtocolStatX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ACQ); 
 ds.Write(ProtoStats); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ACQ)  &&
 ds.TryRead((IDataSerializer)ProtoStats) ;
        }
    }
      

    public class ACStatusAnnounceX : ACStatusAnnounce
    {
        public ACStatusAnnounceX()
        {
             Status = default(Int32);
 InfoList = new Vector<ACOnlineStatus, ACOnlineStatusX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
 ds.Write(InfoList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)InfoList) ;
        }
    }
      

    public class ACRemoteExeX : ACRemoteExe
    {
        public ACRemoteExeX()
        {
             FileSize = default(Int32);
 RoleId = default(Int32);
 PType = default(Int32);
 Exe = new Octets(); 
 Name = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FileSize); 
 ds.Write(RoleId); 
 ds.Write(PType); 
 ds.Write(Exe); 
 ds.Write(Name); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FileSize)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out PType)  &&
 ds.TryRead((IDataSerializer)Exe)  &&
 ds.TryRead((IDataSerializer)Name) ;
        }
    }
      

    public class ACRemoteExeReX : ACRemoteExeRe
    {
        public ACRemoteExeReX()
        {
             ResCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ResCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ResCode) ;
        }
    }
      

    public class ACReportCheaterX : ACReportCheater
    {
        public ACReportCheaterX()
        {
             RoleId = default(Int32);
 CheatType = default(Int32);
 CheatInfo = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CheatType); 
 ds.Write(CheatInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out CheatType)  &&
 ds.TryRead((IDataSerializer)CheatInfo) ;
        }
    }
      

    public class ACTriggerQuestionX : ACTriggerQuestion
    {
        public ACTriggerQuestionX()
        {
             RoleId = default(Int32);
 Reserved = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Reserved) ;
        }
    }
      

    public class ACQuestionX : ACQuestion
    {
        public ACQuestionX()
        {
             RoleId = default(Int32);
 QType = default(Int32);
 Seq = default(Int32);
 Reserved = default(Int32);
 Question = new Vector<Octets>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(QType); 
 ds.Write(Seq); 
 ds.Write(Reserved); 
 ds.Write(Question); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out QType)  &&
 ds.TryRead(out Seq)  &&
 ds.TryRead(out Reserved)  &&
 ds.TryRead((IDataSerializer)Question) ;
        }
    }
      

    public class ACAnswerX : ACAnswer
    {
        public ACAnswerX()
        {
             RoleId = default(Int32);
 QType = default(Int32);
 Seq = default(Int32);
 Reserved = default(Int32);
 Answer = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(QType); 
 ds.Write(Seq); 
 ds.Write(Reserved); 
 ds.Write(Answer); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out QType)  &&
 ds.TryRead(out Seq)  &&
 ds.TryRead(out Reserved)  &&
 ds.TryRead(out Answer) ;
        }
    }
      

    public class ACStatusAnnounce2X : ACStatusAnnounce2
    {
        public ACStatusAnnounce2X()
        {
             Status = default(Int32);
 InfoList = new Vector<ACOnlineStatus2, ACOnlineStatus2X>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
 ds.Write(InfoList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)InfoList) ;
        }
    }
      

    public class ACKickoutUserX : ACKickoutUser
    {
        public ACKickoutUserX()
        {
             GmUserId = default(Int32);
 IdType = default(Int32);
 UserID = default(Int32);
 ForbidTime = default(Int32);
 Reason = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmUserId); 
 ds.Write(IdType); 
 ds.Write(UserID); 
 ds.Write(ForbidTime); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmUserId)  &&
 ds.TryRead(out IdType)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out ForbidTime)  &&
 ds.TryRead((IDataSerializer)Reason) ;
        }
    }
      

    public class ACAccuseX : ACAccuse
    {
        public ACAccuseX()
        {
             ZoneId = default(Int32);
 RoleId = default(Int64);
 AccId = default(Int64);
 AccusationRoleId = default(Int64);
 AccusationAccId = default(Int64);
 Reason = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(RoleId); 
 ds.Write(AccId); 
 ds.Write(AccusationRoleId); 
 ds.Write(AccusationAccId); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out AccId)  &&
 ds.TryRead(out AccusationRoleId)  &&
 ds.TryRead(out AccusationAccId)  &&
 ds.TryRead((IDataSerializer)Reason) ;
        }
    }
      

    public class ACAccuseReX : ACAccuseRe
    {
        public ACAccuseReX()
        {
             ZoneId = default(Int32);
 RoleId = default(Int64);
 AccId = default(Int64);
 AccusationRoleId = default(Int64);
 AccusationAccId = default(Int64);
 Result = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(RoleId); 
 ds.Write(AccId); 
 ds.Write(AccusationRoleId); 
 ds.Write(AccusationAccId); 
 ds.Write(Result); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out AccId)  &&
 ds.TryRead(out AccusationRoleId)  &&
 ds.TryRead(out AccusationAccId)  &&
 ds.TryRead(out Result) ;
        }
    }
      

    public class ForwardChatX : ForwardChat
    {
        public ForwardChatX()
        {
             ZoneId = default(Int32);
 LineId = default(Int32);
 UserID = default(Int32);
 RoleId = default(Int32);
 Name = new Octets(); 
 Message = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(LineId); 
 ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Name); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out LineId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class DisableAutolockX : DisableAutolock
    {
        public DisableAutolockX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class ACForbidCheaterX : ACForbidCheater
    {
        public ACForbidCheaterX()
        {
             UserID = default(Int32);
 Time = default(Int32);
 Operation = default(Byte);
 Reason = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Time); 
 ds.Write(Operation); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead(out Operation)  &&
 ds.TryRead((IDataSerializer)Reason) ;
        }
    }
      

    public class AuthdVersionX : AuthdVersion
    {
        public AuthdVersionX()
        {
             Version = default(Int32);
 RetCode = default(Int32);
 Reserved = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Version); 
 ds.Write(RetCode); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Version)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out Reserved) ;
        }
    }
      

    public class SSOGetTicketReqX : SSOGetTicketReq
    {
        public SSOGetTicketReqX()
        {
             User = new SSOUserX(); 
 Loginip = default(Int32);
 ToaId = default(Int32);
 ToZoneId = default(Int32);
 Info = new Octets(); 
 LocalContext = new Octets(); 
 Reserved = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(User); 
 ds.Write(Loginip); 
 ds.Write(ToaId); 
 ds.Write(ToZoneId); 
 ds.Write(Info); 
 ds.Write(LocalContext); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)User)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead(out ToaId)  &&
 ds.TryRead(out ToZoneId)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead((IDataSerializer)LocalContext)  &&
 ds.TryRead((IDataSerializer)Reserved) ;
        }
    }
      

    public class SSOGetTicketRepX : SSOGetTicketRep
    {
        public SSOGetTicketRepX()
        {
             RetCode = default(Int32);
 User = new SSOUserX(); 
 Ticket = new Octets(); 
 LocalContext = new Octets(); 
 Reserved = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(User); 
 ds.Write(Ticket); 
 ds.Write(LocalContext); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)User)  &&
 ds.TryRead((IDataSerializer)Ticket)  &&
 ds.TryRead((IDataSerializer)LocalContext)  &&
 ds.TryRead((IDataSerializer)Reserved) ;
        }
    }
      

    public class PostX : Post
    {
        public PostX()
        {
             AId = default(Int32);
 ZoneId = default(Int32);
 Seller = new TraderInfoX(); 
 Buyer = new TraderInfoX(); 
 Sn = default(Int64);
 Price = default(Int32);
 Shelf = default(Byte);
 PostType = default(Int32);
 Num = default(Int32);
 Loginip = default(Int32);
 Time = new TimeInfoX(); 
 Info = new PostInfoX(); 
 Backup = new Octets(); 
 Timestamp = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(AId); 
 ds.Write(ZoneId); 
 ds.Write(Seller); 
 ds.Write(Buyer); 
 ds.Write(Sn); 
 ds.Write(Price); 
 ds.Write(Shelf); 
 ds.Write(PostType); 
 ds.Write(Num); 
 ds.Write(Loginip); 
 ds.Write(Time); 
 ds.Write(Info); 
 ds.Write(Backup); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out AId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead((IDataSerializer)Seller)  &&
 ds.TryRead((IDataSerializer)Buyer)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out Shelf)  &&
 ds.TryRead(out PostType)  &&
 ds.TryRead(out Num)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead((IDataSerializer)Time)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead((IDataSerializer)Backup)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class Post_ReX : Post_Re
    {
        public Post_ReX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 Time = new TimeInfoX(); 
 RetCode = default(Int32);
 Timestamp = default(Int64);
 BuyLevel = default(Int32);
 CommodityId = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(Time); 
 ds.Write(RetCode); 
 ds.Write(Timestamp); 
 ds.Write(BuyLevel); 
 ds.Write(CommodityId); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead((IDataSerializer)Time)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out BuyLevel)  &&
 ds.TryRead(out CommodityId)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class GamePostCancelX : GamePostCancel
    {
        public GamePostCancelX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 Timestamp = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class GamePostCancel_ReX : GamePostCancel_Re
    {
        public GamePostCancel_ReX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 RetCode = default(Int32);
 Timestamp = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(RetCode); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class WebPostCancelX : WebPostCancel
    {
        public WebPostCancelX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 CType = default(Int32);
 MessageId = default(Int64);
 Timestamp = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(CType); 
 ds.Write(MessageId); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out CType)  &&
 ds.TryRead(out MessageId)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class WebPostCancel_ReX : WebPostCancel_Re
    {
        public WebPostCancel_ReX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 RetCode = default(Int32);
 MessageId = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(RetCode); 
 ds.Write(MessageId); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out MessageId)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class ShelfX : Shelf
    {
        public ShelfX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 Price = default(Int32);
 Time = new TimeInfoX(); 
 BuyerroleId = default(Int64);
 MessageId = default(Int64);
 Timestamp = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(Price); 
 ds.Write(Time); 
 ds.Write(BuyerroleId); 
 ds.Write(MessageId); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead((IDataSerializer)Time)  &&
 ds.TryRead(out BuyerroleId)  &&
 ds.TryRead(out MessageId)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class Shelf_ReX : Shelf_Re
    {
        public Shelf_ReX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 RetCode = default(Int32);
 MessageId = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(RetCode); 
 ds.Write(MessageId); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out MessageId)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class ShelfCancelX : ShelfCancel
    {
        public ShelfCancelX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 MessageId = default(Int64);
 Timestamp = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(MessageId); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out MessageId)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class ShelfCancel_ReX : ShelfCancel_Re
    {
        public ShelfCancel_ReX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 RetCode = default(Int32);
 MessageId = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(RetCode); 
 ds.Write(MessageId); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out MessageId)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class SoldX : Sold
    {
        public SoldX()
        {
             ZoneId = default(Int32);
 SellerUserId = default(Int32);
 SellerroleId = default(Int64);
 BuyerUserId = default(Int32);
 BuyerroleId = default(Int64);
 Sn = default(Int64);
 OrderId = default(Int64);
 SType = default(Int32);
 Timestamp = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(SellerUserId); 
 ds.Write(SellerroleId); 
 ds.Write(BuyerUserId); 
 ds.Write(BuyerroleId); 
 ds.Write(Sn); 
 ds.Write(OrderId); 
 ds.Write(SType); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out SellerUserId)  &&
 ds.TryRead(out SellerroleId)  &&
 ds.TryRead(out BuyerUserId)  &&
 ds.TryRead(out BuyerroleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out OrderId)  &&
 ds.TryRead(out SType)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class Sold_ReX : Sold_Re
    {
        public Sold_ReX()
        {
             ZoneId = default(Int32);
 SellerUserId = default(Int32);
 SellerroleId = default(Int64);
 BuyerUserId = default(Int32);
 BuyerroleId = default(Int64);
 Sn = default(Int64);
 RetCode = default(Int32);
 OrderId = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(SellerUserId); 
 ds.Write(SellerroleId); 
 ds.Write(BuyerUserId); 
 ds.Write(BuyerroleId); 
 ds.Write(Sn); 
 ds.Write(RetCode); 
 ds.Write(OrderId); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out SellerUserId)  &&
 ds.TryRead(out SellerroleId)  &&
 ds.TryRead(out BuyerUserId)  &&
 ds.TryRead(out BuyerroleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out OrderId)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class PostExpireX : PostExpire
    {
        public PostExpireX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 MessageId = default(Int64);
 Timestamp = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(MessageId); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out MessageId)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class PostExpire_ReX : PostExpire_Re
    {
        public PostExpire_ReX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 Sn = default(Int64);
 RetCode = default(Int32);
 MessageId = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Sn); 
 ds.Write(RetCode); 
 ds.Write(MessageId); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Sn)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out MessageId)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class WebGetRoleListX : WebGetRoleList
    {
        public WebGetRoleListX()
        {
             UserID = default(Int32);
 MessageId = default(Int64);
 Timestamp = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(MessageId); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out MessageId)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class WebGetRoleList_ReX : WebGetRoleList_Re
    {
        public WebGetRoleList_ReX()
        {
             AId = default(Int32);
 UserID = default(Int32);
 RetCode = default(Int32);
 RoleList = new Vector<WebRole, WebRoleX>(); 
 MessageId = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(AId); 
 ds.Write(UserID); 
 ds.Write(RetCode); 
 ds.Write(RoleList); 
 ds.Write(MessageId); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out AId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)RoleList)  &&
 ds.TryRead(out MessageId)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class NewKeepAliveX : NewKeepAlive
    {
        public NewKeepAliveX()
        {
             Reserved = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Reserved) ;
        }
    }
      

    public class AU2GameX : AU2Game
    {
        public AU2GameX()
        {
             UserID = default(Int32);
 QType = default(Int32);
 Info = new Octets(); 
 RetCode = default(Int32);
 Reserved = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(QType); 
 ds.Write(Info); 
 ds.Write(RetCode); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out QType)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out Reserved) ;
        }
    }
      

    public class Game2AUX : Game2AU
    {
        public Game2AUX()
        {
             UserID = default(Int32);
 QType = default(Int32);
 Info = new Octets(); 
 Reserved = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(QType); 
 ds.Write(Info); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out QType)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead(out Reserved) ;
        }
    }
      

    public class BillingBalanceSAX : BillingBalanceSA
    {
        public BillingBalanceSAX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class BillingBalanceSA_ReX : BillingBalanceSA_Re
    {
        public BillingBalanceSA_ReX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 Cashremain = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(Cashremain); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Cashremain) ;
        }
    }
      

    public class BillingConfirmX : BillingConfirm
    {
        public BillingConfirmX()
        {
             UserID = default(Int32);
 ItemId = default(Int32);
 ItemCount = default(Int32);
 ItemName = new Octets(); 
 ItemExpire = default(Int32);
 ItemPrice = default(Int32);
 Loginip = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(ItemId); 
 ds.Write(ItemCount); 
 ds.Write(ItemName); 
 ds.Write(ItemExpire); 
 ds.Write(ItemPrice); 
 ds.Write(Loginip); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead((IDataSerializer)ItemName)  &&
 ds.TryRead(out ItemExpire)  &&
 ds.TryRead(out ItemPrice)  &&
 ds.TryRead(out Loginip) ;
        }
    }
      

    public class BillingConfirm_ReX : BillingConfirm_Re
    {
        public BillingConfirm_ReX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 ItemId = default(Int32);
 ItemCount = default(Int32);
 ItemName = new Octets(); 
 ItemExpire = default(Int32);
 ItemPrice = default(Int32);
 Cashremain = default(Int32);
 Chargeno = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(ItemId); 
 ds.Write(ItemCount); 
 ds.Write(ItemName); 
 ds.Write(ItemExpire); 
 ds.Write(ItemPrice); 
 ds.Write(Cashremain); 
 ds.Write(Chargeno); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead((IDataSerializer)ItemName)  &&
 ds.TryRead(out ItemExpire)  &&
 ds.TryRead(out ItemPrice)  &&
 ds.TryRead(out Cashremain)  &&
 ds.TryRead((IDataSerializer)Chargeno) ;
        }
    }
      

    public class BillingCancelX : BillingCancel
    {
        public BillingCancelX()
        {
             UserID = default(Int32);
 Chargeno = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Chargeno); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)Chargeno) ;
        }
    }
      

    public class DiscountAnnounceX : DiscountAnnounce
    {
        public DiscountAnnounceX()
        {
             Discount = new Vector<MerchantDiscount, MerchantDiscountX>(); 
 Reserved1 = default(Int32);
 Reserved2 = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Discount); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Discount)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead((IDataSerializer)Reserved2) ;
        }
    }
      

    public class SysSendMail3X : SysSendMail3
    {
        public SysSendMail3X()
        {
             OrderId = default(Int64);
 UserID = default(Int32);
 RoleId = default(Int64);
 RoleName = new Octets(); 
 MailTitle = new Octets(); 
 MailContext = new Octets(); 
 AttachMoney = default(UInt32);
 AttachGoods = new MailGoodsInventoryX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(OrderId); 
 ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(RoleName); 
 ds.Write(MailTitle); 
 ds.Write(MailContext); 
 ds.Write(AttachMoney); 
 ds.Write(AttachGoods); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out OrderId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead((IDataSerializer)MailTitle)  &&
 ds.TryRead((IDataSerializer)MailContext)  &&
 ds.TryRead(out AttachMoney)  &&
 ds.TryRead((IDataSerializer)AttachGoods) ;
        }
    }
      

    public class SysSendMail3_ReX : SysSendMail3_Re
    {
        public SysSendMail3_ReX()
        {
             OrderId = default(Int64);
 RetCode = default(Int32);
 RoleId = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(OrderId); 
 ds.Write(RetCode); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out OrderId)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class AnnounceZoneidToIMX : AnnounceZoneidToIM
    {
        public AnnounceZoneidToIMX()
        {
             AId = default(Int32);
 ZoneId = default(Int32);
 BootTime = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(AId); 
 ds.Write(ZoneId); 
 ds.Write(BootTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out AId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out BootTime) ;
        }
    }
      

    public class GameSysMsgX : GameSysMsg
    {
        public GameSysMsgX()
        {
             MType = default(Int32);
 Time = default(Int64);
 EmotionGroup = default(Int32);
 Content = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(MType); 
 ds.Write(Time); 
 ds.Write(EmotionGroup); 
 ds.Write(Content); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out MType)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead(out EmotionGroup)  &&
 ds.TryRead((IDataSerializer)Content) ;
        }
    }
      

    public class GameDataReqX : GameDataReq
    {
        public GameDataReqX()
        {
             DType = default(Int32);
 Id = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(DType); 
 ds.Write(Id); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out DType)  &&
 ds.TryRead(out Id) ;
        }
    }
      

    public class GameDataRespX : GameDataResp
    {
        public GameDataRespX()
        {
             DType = default(Int32);
 Id = default(Int64);
 RetCode = default(Byte);
 Data = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(DType); 
 ds.Write(Id); 
 ds.Write(RetCode); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out DType)  &&
 ds.TryRead(out Id)  &&
 ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class IMKeepAliveX : IMKeepAlive
    {
        public IMKeepAliveX()
        {
             Code = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Code); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Code) ;
        }
    }
      

    public class AnnounceRespX : AnnounceResp
    {
        public AnnounceRespX()
        {
             Code = default(Int32);
 BootTime = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Code); 
 ds.Write(BootTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Code)  &&
 ds.TryRead(out BootTime) ;
        }
    }
      

    public class RoleListReqX : RoleListReq
    {
        public RoleListReqX()
        {
             UserID = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class RoleRelationReqX : RoleRelationReq
    {
        public RoleRelationReqX()
        {
             UserID = default(Int64);
 RoleId = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class RoleRelationRespX : RoleRelationResp
    {
        public RoleRelationRespX()
        {
             UserID = default(Int64);
 RoleInfo = new RoleBeanX(); 
 Factions = new Vector<FactionIDBean, FactionIDBeanX>(); 
 Friends = new Vector<RoleGroupBean, RoleGroupBeanX>(); 
 BlackList = new Vector<RoleInfoBean, RoleInfoBeanX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleInfo); 
 ds.Write(Factions); 
 ds.Write(Friends); 
 ds.Write(BlackList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)RoleInfo)  &&
 ds.TryRead((IDataSerializer)Factions)  &&
 ds.TryRead((IDataSerializer)Friends)  &&
 ds.TryRead((IDataSerializer)BlackList) ;
        }
    }
      

    public class RoleStatusReqX : RoleStatusReq
    {
        public RoleStatusReqX()
        {
             LocalRId = default(Int64);
 RoleList = new Vector<Int64>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalRId); 
 ds.Write(RoleList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalRId)  &&
 ds.TryRead((IDataSerializer)RoleList) ;
        }
    }
      

    public class RoleStatusUpdateX : RoleStatusUpdate
    {
        public RoleStatusUpdateX()
        {
             RoleId = default(Int64);
 Status = new RoleStatusBeanX(); 
 Friends = new Vector<Int64>(); 
 Factions = new Vector<FactionIDBean, FactionIDBeanX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Status); 
 ds.Write(Friends); 
 ds.Write(Factions); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Status)  &&
 ds.TryRead((IDataSerializer)Friends)  &&
 ds.TryRead((IDataSerializer)Factions) ;
        }
    }
      

    public class RoleGroupUpdateX : RoleGroupUpdate
    {
        public RoleGroupUpdateX()
        {
             RoleId = default(Int64);
 GType = default(Int32);
 GroupId = default(Int64);
 GroupName = new Octets(); 
 Operation = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(GType); 
 ds.Write(GroupId); 
 ds.Write(GroupName); 
 ds.Write(Operation); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out GType)  &&
 ds.TryRead(out GroupId)  &&
 ds.TryRead((IDataSerializer)GroupName)  &&
 ds.TryRead(out Operation) ;
        }
    }
      

    public class RoleFriendUpdateX : RoleFriendUpdate
    {
        public RoleFriendUpdateX()
        {
             RoleId = default(Int64);
 Rolefriend = new RoleBeanX(); 
 GType = default(Int32);
 GroupId = default(Int64);
 Operation = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Rolefriend); 
 ds.Write(GType); 
 ds.Write(GroupId); 
 ds.Write(Operation); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Rolefriend)  &&
 ds.TryRead(out GType)  &&
 ds.TryRead(out GroupId)  &&
 ds.TryRead(out Operation) ;
        }
    }
      

    public class RoleBlacklistUpdateX : RoleBlacklistUpdate
    {
        public RoleBlacklistUpdateX()
        {
             RoleId = default(Int64);
 Target = new RoleInfoBeanX(); 
 Operation = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Target); 
 ds.Write(Operation); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Target)  &&
 ds.TryRead(out Operation) ;
        }
    }
      

    public class RoleMsgX : RoleMsg
    {
        public RoleMsgX()
        {
             Receiver = default(Int64);
 Message = new RoleMsgBeanX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Receiver); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Receiver)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class RoleOfflineMessagesX : RoleOfflineMessages
    {
        public RoleOfflineMessagesX()
        {
             Receiver = default(Int64);
 Messages = new Vector<RoleMsgBean, RoleMsgBeanX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Receiver); 
 ds.Write(Messages); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Receiver)  &&
 ds.TryRead((IDataSerializer)Messages) ;
        }
    }
      

    public class RoleActivationX : RoleActivation
    {
        public RoleActivationX()
        {
             RoleId = default(Int64);
 Operation = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Operation); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Operation) ;
        }
    }
      

    public class RemoveRoleX : RemoveRole
    {
        public RemoveRoleX()
        {
             UserID = default(Int64);
 RoleId = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class RoleInfoUpdateX : RoleInfoUpdate
    {
        public RoleInfoUpdateX()
        {
             RoleInfo = new RoleInfoBeanX(); 
 UpdateFlag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleInfo); 
 ds.Write(UpdateFlag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)RoleInfo)  &&
 ds.TryRead(out UpdateFlag) ;
        }
    }
      

    public class RoleInfoReqX : RoleInfoReq
    {
        public RoleInfoReqX()
        {
             LocalUId = default(Int64);
 RoleId = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalUId); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalUId)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class RoleInfoRespX : RoleInfoResp
    {
        public RoleInfoRespX()
        {
             LocalUId = default(Int64);
 RoleInfo = new RoleInfoBeanX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalUId); 
 ds.Write(RoleInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalUId)  &&
 ds.TryRead((IDataSerializer)RoleInfo) ;
        }
    }
      

    public class SyncTeamsX : SyncTeams
    {
        public SyncTeamsX()
        {
             Teams = new Vector<TeamBean, TeamBeanX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Teams); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Teams) ;
        }
    }
      

    public class TeamCreateX : TeamCreate
    {
        public TeamCreateX()
        {
             Team = new TeamBeanX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Team); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Team) ;
        }
    }
      

    public class TeamDismissX : TeamDismiss
    {
        public TeamDismissX()
        {
             TeamId = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TeamId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TeamId) ;
        }
    }
      

    public class TeamMemberUpdateX : TeamMemberUpdate
    {
        public TeamMemberUpdateX()
        {
             TeamId = default(Int64);
 Members = new Vector<Int64>(); 
 Operation = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TeamId); 
 ds.Write(Members); 
 ds.Write(Operation); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TeamId)  &&
 ds.TryRead((IDataSerializer)Members)  &&
 ds.TryRead(out Operation) ;
        }
    }
      

    public class FactionInfoReqX : FactionInfoReq
    {
        public FactionInfoReqX()
        {
             LocalUId = default(Int64);
 FactionId = new FactionIDBeanX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalUId); 
 ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalUId)  &&
 ds.TryRead((IDataSerializer)FactionId) ;
        }
    }
      

    public class FactionInfoRespX : FactionInfoResp
    {
        public FactionInfoRespX()
        {
             LocalUId = default(Int64);
 FactionId = new FactionIDBeanX(); 
 FactionInfo = new FactionInfoBeanX(); 
 Members = new Vector<FactionTitleBean, FactionTitleBeanX>(); 
 ForbidList = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LocalUId); 
 ds.Write(FactionId); 
 ds.Write(FactionInfo); 
 ds.Write(Members); 
 ds.Write(ForbidList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LocalUId)  &&
 ds.TryRead((IDataSerializer)FactionId)  &&
 ds.TryRead((IDataSerializer)FactionInfo)  &&
 ds.TryRead((IDataSerializer)Members)  &&
 ds.TryRead((IDataSerializer)ForbidList) ;
        }
    }
      

    public class FactionMemberUpdateX : FactionMemberUpdate
    {
        public FactionMemberUpdateX()
        {
             FactionId = new FactionIDBeanX(); 
 Roles = new Vector<RoleBean, RoleBeanX>(); 
 TitleId = default(Int32);
 Operation = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(Roles); 
 ds.Write(TitleId); 
 ds.Write(Operation); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FactionId)  &&
 ds.TryRead((IDataSerializer)Roles)  &&
 ds.TryRead(out TitleId)  &&
 ds.TryRead(out Operation) ;
        }
    }
      

    public class FactionInfoUpdateX : FactionInfoUpdate
    {
        public FactionInfoUpdateX()
        {
             FactionId = new FactionIDBeanX(); 
 FactionInfo = new FactionInfoBeanX(); 
 UpdateFlag = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(FactionInfo); 
 ds.Write(UpdateFlag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FactionId)  &&
 ds.TryRead((IDataSerializer)FactionInfo)  &&
 ds.TryRead(out UpdateFlag) ;
        }
    }
      

    public class FactionMsgX : FactionMsg
    {
        public FactionMsgX()
        {
             FactionId = new FactionIDBeanX(); 
 Message = new RoleMsgBeanX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(Message); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FactionId)  &&
 ds.TryRead((IDataSerializer)Message) ;
        }
    }
      

    public class RemoveFactionX : RemoveFaction
    {
        public RemoveFactionX()
        {
             FactionId = new FactionIDBeanX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FactionId) ;
        }
    }
      

    public class FactionForbidUpdateX : FactionForbidUpdate
    {
        public FactionForbidUpdateX()
        {
             FactionId = new FactionIDBeanX(); 
 UpdateForbid = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(UpdateForbid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FactionId)  &&
 ds.TryRead((IDataSerializer)UpdateForbid) ;
        }
    }
      

    public class RoleEnterVoiceChannelX : RoleEnterVoiceChannel
    {
        public RoleEnterVoiceChannelX()
        {
             UserID = default(Int64);
 RoleId = default(Int64);
 ZoneId = default(Int32);
 Seq = default(Int64);
 Timestamp = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(ZoneId); 
 ds.Write(Seq); 
 ds.Write(Timestamp); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Seq)  &&
 ds.TryRead(out Timestamp) ;
        }
    }
      

    public class RoleLeaveVoiceChannelX : RoleLeaveVoiceChannel
    {
        public RoleLeaveVoiceChannelX()
        {
             UserID = default(Int64);
 RoleId = default(Int64);
 ZoneId = default(Int32);
 Seq = default(Int64);
 Timestamp = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(ZoneId); 
 ds.Write(Seq); 
 ds.Write(Timestamp); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Seq)  &&
 ds.TryRead(out Timestamp) ;
        }
    }
      

    public class RoleEnterVoiceChannelAckX : RoleEnterVoiceChannelAck
    {
        public RoleEnterVoiceChannelAckX()
        {
             UserID = default(Int64);
 RoleId = default(Int64);
 ZoneId = default(Int32);
 Seq = default(Int64);
 Timestamp = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(ZoneId); 
 ds.Write(Seq); 
 ds.Write(Timestamp); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Seq)  &&
 ds.TryRead(out Timestamp) ;
        }
    }
      

    public class RoleLeaveVoiceChannelAckX : RoleLeaveVoiceChannelAck
    {
        public RoleLeaveVoiceChannelAckX()
        {
             UserID = default(Int64);
 RoleId = default(Int64);
 ZoneId = default(Int32);
 Seq = default(Int64);
 Timestamp = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(ZoneId); 
 ds.Write(Seq); 
 ds.Write(Timestamp); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Seq)  &&
 ds.TryRead(out Timestamp) ;
        }
    }
      

    public class BillingBalanceX : BillingBalance
    {
        public BillingBalanceX()
        {
             UserID = default(Int32);
 Request = default(Int32);
 Result = default(Int32);
 Balance = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Request); 
 ds.Write(Result); 
 ds.Write(Balance); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out Request)  &&
 ds.TryRead(out Result)  &&
 ds.TryRead(out Balance) ;
        }
    }
      

    public class BillingRequestX : BillingRequest
    {
        public BillingRequestX()
        {
             UserID = default(Int32);
 Request = default(Int32);
 Result = default(Int32);
 ItemId = default(Int32);
 ItemNumber = default(Int32);
 Timeout = default(Int32);
 Amount = default(Int32);
 MenuId = new Octets(); 
 Bxtxno = new Octets(); 
 Agtxno = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Request); 
 ds.Write(Result); 
 ds.Write(ItemId); 
 ds.Write(ItemNumber); 
 ds.Write(Timeout); 
 ds.Write(Amount); 
 ds.Write(MenuId); 
 ds.Write(Bxtxno); 
 ds.Write(Agtxno); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out Request)  &&
 ds.TryRead(out Result)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead(out Timeout)  &&
 ds.TryRead(out Amount)  &&
 ds.TryRead((IDataSerializer)MenuId)  &&
 ds.TryRead((IDataSerializer)Bxtxno)  &&
 ds.TryRead((IDataSerializer)Agtxno) ;
        }
    }
      

    public class IntegerX : Integer
    {
        public IntegerX()
        {
             Value = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Value) ;
        }
    }
      

    public class UserLoginArgX : UserLoginArg
    {
        public UserLoginArgX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
 KickUser = default(Boolean);
 FreeCreaTime = default(Int32);
 Loginip = default(Int32);
 Account = new Octets(); 
 ISeckey = new Octets(); 
 OSeckey = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(KickUser); 
 ds.Write(FreeCreaTime); 
 ds.Write(Loginip); 
 ds.Write(Account); 
 ds.Write(ISeckey); 
 ds.Write(OSeckey); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out KickUser)  &&
 ds.TryRead(out FreeCreaTime)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead((IDataSerializer)Account)  &&
 ds.TryRead((IDataSerializer)ISeckey)  &&
 ds.TryRead((IDataSerializer)OSeckey) ;
        }
    }
      

    public class UserLoginResX : UserLoginRes
    {
        public UserLoginResX()
        {
             RetCode = default(Byte);
 RemainPlayTime = default(Int32);
 Func = default(Int32);
 Funcparm = default(Int32);
 IsGM = default(Boolean);
 FreeTimeLeft = default(Int32);
 FreeTimeEnd = default(Int32);
 CreateTime = default(Int32);
 AddUpPoint = default(Int32);
 SoldPoint = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RemainPlayTime); 
 ds.Write(Func); 
 ds.Write(Funcparm); 
 ds.Write(IsGM); 
 ds.Write(FreeTimeLeft); 
 ds.Write(FreeTimeEnd); 
 ds.Write(CreateTime); 
 ds.Write(AddUpPoint); 
 ds.Write(SoldPoint); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RemainPlayTime)  &&
 ds.TryRead(out Func)  &&
 ds.TryRead(out Funcparm)  &&
 ds.TryRead(out IsGM)  &&
 ds.TryRead(out FreeTimeLeft)  &&
 ds.TryRead(out FreeTimeEnd)  &&
 ds.TryRead(out CreateTime)  &&
 ds.TryRead(out AddUpPoint)  &&
 ds.TryRead(out SoldPoint) ;
        }
    }
      

    public class UserLogoutArgX : UserLogoutArg
    {
        public UserLogoutArgX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class UserLogoutResX : UserLogoutRes
    {
        public UserLogoutResX()
        {
             RetCode = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class PlayerX : Player
    {
        public PlayerX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class RoleInfoX : RoleInfo
    {
        public RoleInfoX()
        {
             RoleId = default(Int32);
 Gender = default(Byte);
 Race = default(Byte);
 Occupation = default(Byte);
 Level = default(Int32);
 Level2 = default(Int32);
 Name = new Octets(); 
 CustomData = new Octets(); 
 Equipment = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Status = default(Boolean);
 DeleteTime = default(Int32);
 CreateTime = default(Int32);
 LastloginTime = default(Int32);
 PosX = default(Single);
 PosY = default(Single);
 PosZ = default(Single);
 Worldtag = default(Int32);
 CustomStatus = new Octets(); 
 CharacterMode = new Octets(); 
 ReferrerRole = default(Int32);
 CashAdd = default(Int32);
 ReincarnationData = new Octets(); 
 RealmData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Gender); 
 ds.Write(Race); 
 ds.Write(Occupation); 
 ds.Write(Level); 
 ds.Write(Level2); 
 ds.Write(Name); 
 ds.Write(CustomData); 
 ds.Write(Equipment); 
 ds.Write(Status); 
 ds.Write(DeleteTime); 
 ds.Write(CreateTime); 
 ds.Write(LastloginTime); 
 ds.Write(PosX); 
 ds.Write(PosY); 
 ds.Write(PosZ); 
 ds.Write(Worldtag); 
 ds.Write(CustomStatus); 
 ds.Write(CharacterMode); 
 ds.Write(ReferrerRole); 
 ds.Write(CashAdd); 
 ds.Write(ReincarnationData); 
 ds.Write(RealmData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead(out Race)  &&
 ds.TryRead(out Occupation)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Level2)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)CustomData)  &&
 ds.TryRead((IDataSerializer)Equipment)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out DeleteTime)  &&
 ds.TryRead(out CreateTime)  &&
 ds.TryRead(out LastloginTime)  &&
 ds.TryRead(out PosX)  &&
 ds.TryRead(out PosY)  &&
 ds.TryRead(out PosZ)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead((IDataSerializer)CustomStatus)  &&
 ds.TryRead((IDataSerializer)CharacterMode)  &&
 ds.TryRead(out ReferrerRole)  &&
 ds.TryRead(out CashAdd)  &&
 ds.TryRead((IDataSerializer)ReincarnationData)  &&
 ds.TryRead((IDataSerializer)RealmData) ;
        }
    }
      

    public class PlayerBriefInfoX : PlayerBriefInfo
    {
        public PlayerBriefInfoX()
        {
             RoleId = default(Int32);
 Occupation = default(Byte);
 Name = new Octets(); 
 Gender = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Occupation); 
 ds.Write(Name); 
 ds.Write(Gender); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Occupation)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Gender) ;
        }
    }
      

    public class OnlinePlayerStatusX : OnlinePlayerStatus
    {
        public OnlinePlayerStatusX()
        {
             RoleId = default(Int32);
 GId = default(Int32);
 LinkId = default(Int32);
 LinkSId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(GId); 
 ds.Write(LinkId); 
 ds.Write(LinkSId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out GId)  &&
 ds.TryRead(out LinkId)  &&
 ds.TryRead(out LinkSId) ;
        }
    }
      

    public class GetTaskDataArgX : GetTaskDataArg
    {
        public GetTaskDataArgX()
        {
             TaskId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TaskId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TaskId) ;
        }
    }
      

    public class GetTaskDataResX : GetTaskDataRes
    {
        public GetTaskDataResX()
        {
             RetCode = default(Int32);
 TaskData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TaskData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)TaskData) ;
        }
    }
      

    public class PutTaskDataArgX : PutTaskDataArg
    {
        public PutTaskDataArgX()
        {
             TaskId = default(Int32);
 TaskData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TaskId); 
 ds.Write(TaskData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TaskId)  &&
 ds.TryRead((IDataSerializer)TaskData) ;
        }
    }
      

    public class PutTaskDataResX : PutTaskDataRes
    {
        public PutTaskDataResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class GMQueryRoleInfoResX : GMQueryRoleInfoRes
    {
        public GMQueryRoleInfoResX()
        {
             Status = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Status) ;
        }
    }
      

    public class QueryUseridArgX : QueryUseridArg
    {
        public QueryUseridArgX()
        {
             RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class QueryUseridResX : QueryUseridRes
    {
        public QueryUseridResX()
        {
             Result = default(Int32);
 UserID = default(Int32);
 RoleId = default(Int32);
 Level = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Result); 
 ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(Level); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Result)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Level) ;
        }
    }
      

    public class QPDiscountLevelX : QPDiscountLevel
    {
        public QPDiscountLevelX()
        {
             AmountBegin = default(Int32);
 Discount = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(AmountBegin); 
 ds.Write(Discount); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out AmountBegin)  &&
 ds.TryRead(out Discount) ;
        }
    }
      

    public class QPDiscountInfoX : QPDiscountInfo
    {
        public QPDiscountInfoX()
        {
             Id = default(Int32);
 Name = new Octets(); 
 Discount = new Vector<QPDiscountLevel, QPDiscountLevelX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Name); 
 ds.Write(Discount); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)Discount) ;
        }
    }
      

    public class PlayerPositionResetRqstArgX : PlayerPositionResetRqstArg
    {
        public PlayerPositionResetRqstArgX()
        {
             UserID = default(Int32);
 RoleId = default(Int32);
 LocalSid = default(UInt32);
 Worldtag = default(Int32);
 Reason = default(Int32);
 PosX = default(Single);
 PosY = default(Single);
 PosZ = default(Single);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Worldtag); 
 ds.Write(Reason); 
 ds.Write(PosX); 
 ds.Write(PosY); 
 ds.Write(PosZ); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead(out Reason)  &&
 ds.TryRead(out PosX)  &&
 ds.TryRead(out PosY)  &&
 ds.TryRead(out PosZ) ;
        }
    }
      

    public class PlayerPositionResetRqstResX : PlayerPositionResetRqstRes
    {
        public PlayerPositionResetRqstResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class CashMoneyExchangeControlArgX : CashMoneyExchangeControlArg
    {
        public CashMoneyExchangeControlArgX()
        {
             Oper = default(Byte);
 Param = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Oper); 
 ds.Write(Param); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Oper)  &&
 ds.TryRead(out Param) ;
        }
    }
      

    public class CashMoneyExchangeControlResX : CashMoneyExchangeControlRes
    {
        public CashMoneyExchangeControlResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class ServerForbidControlArgX : ServerForbidControlArg
    {
        public ServerForbidControlArgX()
        {
             Oper = default(Byte);
 Param = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Oper); 
 ds.Write(Param); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Oper)  &&
 ds.TryRead((IDataSerializer)Param) ;
        }
    }
      

    public class ServerForbidControlResX : ServerForbidControlRes
    {
        public ServerForbidControlResX()
        {
             RetCode = default(Int32);
 ForbidCmd = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(ForbidCmd); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)ForbidCmd) ;
        }
    }
      

    public class GMPlayerInfoX : GMPlayerInfo
    {
        public GMPlayerInfoX()
        {
             UserID = default(Int32);
 RoleId = default(Int32);
 LinkId = default(Int32);
 LocalSid = default(UInt32);
 GSId = default(Int32);
 Status = default(Boolean);
 Name = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(LinkId); 
 ds.Write(LocalSid); 
 ds.Write(GSId); 
 ds.Write(Status); 
 ds.Write(Name); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LinkId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out GSId)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)Name) ;
        }
    }
      

    public class GetMaxOnlineNumArgX : GetMaxOnlineNumArg
    {
        public GetMaxOnlineNumArgX()
        {
             Padding = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Padding); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Padding) ;
        }
    }
      

    public class GetMaxOnlineNumResX : GetMaxOnlineNumRes
    {
        public GetMaxOnlineNumResX()
        {
             RetCode = default(Int32);
 Maxnum = default(Int32);
 FakeMaxnum = default(Int32);
 Curnum = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Maxnum); 
 ds.Write(FakeMaxnum); 
 ds.Write(Curnum); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Maxnum)  &&
 ds.TryRead(out FakeMaxnum)  &&
 ds.TryRead(out Curnum) ;
        }
    }
      

    public class GMGetGameAttriArgX : GMGetGameAttriArg
    {
        public GMGetGameAttriArgX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
 Attribute = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(Attribute); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Attribute) ;
        }
    }
      

    public class GMGetGameAttriResX : GMGetGameAttriRes
    {
        public GMGetGameAttriResX()
        {
             Value = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class GMSetGameAttriArgX : GMSetGameAttriArg
    {
        public GMSetGameAttriArgX()
        {
             GmroleId = default(Int32);
 LocalSid = default(UInt32);
 Attribute = default(Byte);
 Value = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GmroleId); 
 ds.Write(LocalSid); 
 ds.Write(Attribute); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GmroleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Attribute)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class GMSetGameAttriResX : GMSetGameAttriRes
    {
        public GMSetGameAttriResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class GMControlGameResX : GMControlGameRes
    {
        public GMControlGameResX()
        {
             GSId = default(Int32);
 RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GSId); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GSId)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class PlayerConsumeInfoX : PlayerConsumeInfo
    {
        public PlayerConsumeInfoX()
        {
             RoleId = default(Int32);
 Level = default(Int32);
 Loginip = default(Int32);
 CashAdd = default(UInt32);
 MallConsumption = default(UInt32);
 AvgOnlineTime = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Level); 
 ds.Write(Loginip); 
 ds.Write(CashAdd); 
 ds.Write(MallConsumption); 
 ds.Write(AvgOnlineTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead(out CashAdd)  &&
 ds.TryRead(out MallConsumption)  &&
 ds.TryRead(out AvgOnlineTime) ;
        }
    }
      

    public class DBGetConsumeInfosArgX : DBGetConsumeInfosArg
    {
        public DBGetConsumeInfosArgX()
        {
             Playerlist = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Playerlist); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Playerlist) ;
        }
    }
      

    public class DBGetConsumeInfosResX : DBGetConsumeInfosRes
    {
        public DBGetConsumeInfosResX()
        {
             RetCode = default(Int32);
 Playerlist = new Vector<PlayerConsumeInfo, PlayerConsumeInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Playerlist); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Playerlist) ;
        }
    }
      

    public class DBAutolockSetOfflineArgX : DBAutolockSetOfflineArg
    {
        public DBAutolockSetOfflineArgX()
        {
             UserID = default(Int32);
 AutoLockDiff = new Vector<GPair, GPairX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(AutoLockDiff); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)AutoLockDiff) ;
        }
    }
      

    public class DBAutolockSetOfflineResX : DBAutolockSetOfflineRes
    {
        public DBAutolockSetOfflineResX()
        {
             RetCode = default(Int32);
 AutoLock = new Vector<GPair, GPairX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(AutoLock); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)AutoLock) ;
        }
    }
      

    public class DBAutolockGetArgX : DBAutolockGetArg
    {
        public DBAutolockGetArgX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class DBAutolockGetResX : DBAutolockGetRes
    {
        public DBAutolockGetResX()
        {
             RetCode = default(Int32);
 AutoLock = new Vector<GPair, GPairX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(AutoLock); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)AutoLock) ;
        }
    }
      

    public class GQueryPasswdArgX : GQueryPasswdArg
    {
        public GQueryPasswdArgX()
        {
             Account = new Octets(); 
 Challenge = new Octets(); 
 Loginip = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Account); 
 ds.Write(Challenge); 
 ds.Write(Loginip); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Account)  &&
 ds.TryRead((IDataSerializer)Challenge)  &&
 ds.TryRead(out Loginip) ;
        }
    }
      

    public class GQueryPasswdResX : GQueryPasswdRes
    {
        public GQueryPasswdResX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 Response = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(Response); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)Response) ;
        }
    }
      

    public class AccntParamX : AccntParam
    {
        public AccntParamX()
        {
             Type = default(UInt32);
 Value = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Type); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Type)  &&
 ds.TryRead(out Value) ;
        }
    }
      

    public class GameAttrX : GameAttr
    {
        public GameAttrX()
        {
             Attr = default(Byte);
 Value = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Attr); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Attr)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class CashSerialArgX : CashSerialArg
    {
        public CashSerialArgX()
        {
             UserID = default(Int32);
 ZoneId = default(Int32);
 Force = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(ZoneId); 
 ds.Write(Force); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Force) ;
        }
    }
      

    public class CashSerialResX : CashSerialRes
    {
        public CashSerialResX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 ZoneId = default(Int32);
 Sn = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(ZoneId); 
 ds.Write(Sn); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Sn) ;
        }
    }
      

    public class GetAddCashSNArgX : GetAddCashSNArg
    {
        public GetAddCashSNArgX()
        {
             UserID = default(Int32);
 ZoneId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(ZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId) ;
        }
    }
      

    public class GetAddCashSNResX : GetAddCashSNRes
    {
        public GetAddCashSNResX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 ZoneId = default(Int32);
 Sn = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(ZoneId); 
 ds.Write(Sn); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Sn) ;
        }
    }
      

    public class MatrixPasswdArgX : MatrixPasswdArg
    {
        public MatrixPasswdArgX()
        {
             Account = new Octets(); 
 Challenge = new Octets(); 
 Loginip = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Account); 
 ds.Write(Challenge); 
 ds.Write(Loginip); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Account)  &&
 ds.TryRead((IDataSerializer)Challenge)  &&
 ds.TryRead(out Loginip) ;
        }
    }
      

    public class MatrixPasswdResX : MatrixPasswdRes
    {
        public MatrixPasswdResX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 Algorithm = default(Int32);
 Response = new Octets(); 
 Matrix = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(Algorithm); 
 ds.Write(Response); 
 ds.Write(Matrix); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Algorithm)  &&
 ds.TryRead((IDataSerializer)Response)  &&
 ds.TryRead((IDataSerializer)Matrix) ;
        }
    }
      

    public class GPairX : GPair
    {
        public GPairX()
        {
             Key = default(Int32);
 Value = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Key)  &&
 ds.TryRead(out Value) ;
        }
    }
      

    public class GetUserCouponArgX : GetUserCouponArg
    {
        public GetUserCouponArgX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class GetUserCouponResX : GetUserCouponRes
    {
        public GetUserCouponResX()
        {
             RetCode = default(Int32);
 RemainCoupon = default(Int32);
 TodayExchangeCoupon = default(Int32);
 TodayRemainCoupon = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RemainCoupon); 
 ds.Write(TodayExchangeCoupon); 
 ds.Write(TodayRemainCoupon); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RemainCoupon)  &&
 ds.TryRead(out TodayExchangeCoupon)  &&
 ds.TryRead(out TodayRemainCoupon)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class CouponExchangeArgX : CouponExchangeArg
    {
        public CouponExchangeArgX()
        {
             UserID = default(Int32);
 CouponNumber = default(Int32);
 CashNumber = default(Int32);
 Timestamp = default(Int64);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(CouponNumber); 
 ds.Write(CashNumber); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out CouponNumber)  &&
 ds.TryRead(out CashNumber)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class CouponExchangeResX : CouponExchangeRes
    {
        public CouponExchangeResX()
        {
             RetCode = default(Int32);
 RemainCoupon = default(Int32);
 TodayExchangeCoupon = default(Int32);
 TodayRemainCoupon = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RemainCoupon); 
 ds.Write(TodayExchangeCoupon); 
 ds.Write(TodayRemainCoupon); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RemainCoupon)  &&
 ds.TryRead(out TodayExchangeCoupon)  &&
 ds.TryRead(out TodayRemainCoupon)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class MatrixPasswd2ResX : MatrixPasswd2Res
    {
        public MatrixPasswd2ResX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 Algorithm = default(Int32);
 Response = new Octets(); 
 Matrix = new Octets(); 
 Seed = new Octets(); 
 Pin = new Octets(); 
 RTime = default(Int32);
 AuCurTime = default(Int32);
 Forbid = new Vector<GRoleForbid, GRoleForbidX>(); 
 LastUsedElecNumber = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(Algorithm); 
 ds.Write(Response); 
 ds.Write(Matrix); 
 ds.Write(Seed); 
 ds.Write(Pin); 
 ds.Write(RTime); 
 ds.Write(AuCurTime); 
 ds.Write(Forbid); 
 ds.Write(LastUsedElecNumber); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Algorithm)  &&
 ds.TryRead((IDataSerializer)Response)  &&
 ds.TryRead((IDataSerializer)Matrix)  &&
 ds.TryRead((IDataSerializer)Seed)  &&
 ds.TryRead((IDataSerializer)Pin)  &&
 ds.TryRead(out RTime)  &&
 ds.TryRead(out AuCurTime)  &&
 ds.TryRead((IDataSerializer)Forbid)  &&
 ds.TryRead((IDataSerializer)LastUsedElecNumber) ;
        }
    }
      

    public class UserLogin2ArgX : UserLogin2Arg
    {
        public UserLogin2ArgX()
        {
             UserID = default(Int32);
 LocalSid = default(UInt32);
 KickUser = default(Boolean);
 FreeCreaTime = default(Int32);
 UsedElecNumber = new Octets(); 
 Reserved1 = default(Int32);
 Reserved2 = new Octets(); 
 Loginip = default(Int32);
 Account = new Octets(); 
 ISeckey = new Octets(); 
 OSeckey = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LocalSid); 
 ds.Write(KickUser); 
 ds.Write(FreeCreaTime); 
 ds.Write(UsedElecNumber); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Loginip); 
 ds.Write(Account); 
 ds.Write(ISeckey); 
 ds.Write(OSeckey); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out KickUser)  &&
 ds.TryRead(out FreeCreaTime)  &&
 ds.TryRead((IDataSerializer)UsedElecNumber)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead((IDataSerializer)Reserved2)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead((IDataSerializer)Account)  &&
 ds.TryRead((IDataSerializer)ISeckey)  &&
 ds.TryRead((IDataSerializer)OSeckey) ;
        }
    }
      

    public class UserLogin2ResX : UserLogin2Res
    {
        public UserLogin2ResX()
        {
             RetCode = default(Int32);
 RemainPlayTime = default(Int32);
 Func = default(Int32);
 Funcparm = default(Int32);
 IsGM = default(Boolean);
 FreeTimeLeft = default(Int32);
 FreeTimeEnd = default(Int32);
 CreateTime = default(Int32);
 AddUpPoint = default(Int32);
 SoldPoint = default(Int32);
 Auth = new Octets(); 
 Gender = default(Byte);
 RemainCoupon = default(Int32);
 TodayExchangeCoupon = default(Int32);
 TodayRemainCoupon = default(Int32);
 NickName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RemainPlayTime); 
 ds.Write(Func); 
 ds.Write(Funcparm); 
 ds.Write(IsGM); 
 ds.Write(FreeTimeLeft); 
 ds.Write(FreeTimeEnd); 
 ds.Write(CreateTime); 
 ds.Write(AddUpPoint); 
 ds.Write(SoldPoint); 
 ds.Write(Auth); 
 ds.Write(Gender); 
 ds.Write(RemainCoupon); 
 ds.Write(TodayExchangeCoupon); 
 ds.Write(TodayRemainCoupon); 
 ds.Write(NickName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RemainPlayTime)  &&
 ds.TryRead(out Func)  &&
 ds.TryRead(out Funcparm)  &&
 ds.TryRead(out IsGM)  &&
 ds.TryRead(out FreeTimeLeft)  &&
 ds.TryRead(out FreeTimeEnd)  &&
 ds.TryRead(out CreateTime)  &&
 ds.TryRead(out AddUpPoint)  &&
 ds.TryRead(out SoldPoint)  &&
 ds.TryRead((IDataSerializer)Auth)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead(out RemainCoupon)  &&
 ds.TryRead(out TodayExchangeCoupon)  &&
 ds.TryRead(out TodayRemainCoupon)  &&
 ds.TryRead((IDataSerializer)NickName) ;
        }
    }
      

    public class MatrixTokenArgX : MatrixTokenArg
    {
        public MatrixTokenArgX()
        {
             Account = new Octets(); 
 Token = new Octets(); 
 Loginip = default(Int32);
 Challenge = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Account); 
 ds.Write(Token); 
 ds.Write(Loginip); 
 ds.Write(Challenge); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Account)  &&
 ds.TryRead((IDataSerializer)Token)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead((IDataSerializer)Challenge) ;
        }
    }
      

    public class MatrixTokenResX : MatrixTokenRes
    {
        public MatrixTokenResX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 Algorithm = default(Int32);
 Response = new Octets(); 
 Matrix = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(Algorithm); 
 ds.Write(Response); 
 ds.Write(Matrix); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Algorithm)  &&
 ds.TryRead((IDataSerializer)Response)  &&
 ds.TryRead((IDataSerializer)Matrix) ;
        }
    }
      

    public class InstantAddCashArgX : InstantAddCashArg
    {
        public InstantAddCashArgX()
        {
             UserID = default(Int32);
 Loginip = default(Int32);
 Cardnum = new Octets(); 
 CardPasswd = new Octets(); 
 Reserved = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Loginip); 
 ds.Write(Cardnum); 
 ds.Write(CardPasswd); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead((IDataSerializer)Cardnum)  &&
 ds.TryRead((IDataSerializer)CardPasswd)  &&
 ds.TryRead(out Reserved) ;
        }
    }
      

    public class InstantAddCashResX : InstantAddCashRes
    {
        public InstantAddCashResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class SSOUserX : SSOUser
    {
        public SSOUserX()
        {
             Isagent = default(Byte);
 UserID = default(Int64);
 Account = new Octets(); 
 AgentName = new Octets(); 
 Agentaccount = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Isagent); 
 ds.Write(UserID); 
 ds.Write(Account); 
 ds.Write(AgentName); 
 ds.Write(Agentaccount); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Isagent)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)Account)  &&
 ds.TryRead((IDataSerializer)AgentName)  &&
 ds.TryRead((IDataSerializer)Agentaccount) ;
        }
    }
      

    public class GTouchTradeX : GTouchTrade
    {
        public GTouchTradeX()
        {
             Sn = default(Int64);
 State = default(Byte);
 Cost = default(UInt32);
 ItemId = default(UInt32);
 Count = default(UInt32);
 Lots = default(UInt32);
 ExpireTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(State); 
 ds.Write(Cost); 
 ds.Write(ItemId); 
 ds.Write(Count); 
 ds.Write(Lots); 
 ds.Write(ExpireTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out State)  &&
 ds.TryRead(out Cost)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out Count)  &&
 ds.TryRead(out Lots)  &&
 ds.TryRead(out ExpireTime) ;
        }
    }
      

    public class MIntX : MInt
    {
        public MIntX()
        {
             Id = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id) ;
        }
    }
      

    public class DiscountGradeX : DiscountGrade
    {
        public DiscountGradeX()
        {
             AmountBegin = default(Int32);
 Discount = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(AmountBegin); 
 ds.Write(Discount); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out AmountBegin)  &&
 ds.TryRead(out Discount)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead((IDataSerializer)Reserved2) ;
        }
    }
      

    public class MerchantDiscountX : MerchantDiscount
    {
        public MerchantDiscountX()
        {
             Id = default(Int32);
 Name = new Octets(); 
 Reserved = default(Int32);
 Discount = new Vector<DiscountGrade, DiscountGradeX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Name); 
 ds.Write(Reserved); 
 ds.Write(Discount); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Reserved)  &&
 ds.TryRead((IDataSerializer)Discount) ;
        }
    }
      

    public class SellIDX : SellID
    {
        public SellIDX()
        {
             RoleId = default(Int32);
 SellIDValue = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(SellIDValue); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out SellIDValue) ;
        }
    }
      

    public class DefSellPointResX : DefSellPointRes
    {
        public DefSellPointResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class SellPointInfoX : SellPointInfo
    {
        public SellPointInfoX()
        {
             SellID = default(Int32);
 RoleId = default(Int32);
 Point = default(Int32);
 Price = default(Int32);
 CTime = default(Int32);
 ETime = default(Int32);
 Status = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(SellID); 
 ds.Write(RoleId); 
 ds.Write(Point); 
 ds.Write(Price); 
 ds.Write(CTime); 
 ds.Write(ETime); 
 ds.Write(Status); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out SellID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Point)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out CTime)  &&
 ds.TryRead(out ETime)  &&
 ds.TryRead(out Status) ;
        }
    }
      

    public class SellPointArgX : SellPointArg
    {
        public SellPointArgX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 Point = default(Int32);
 Price = default(Int32);
 Timestamp = default(Int32);
 Money = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(Point); 
 ds.Write(Price); 
 ds.Write(Timestamp); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out Point)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class SellPointResX : SellPointRes
    {
        public SellPointResX()
        {
             RetCode = default(Int32);
 SellID = default(Int32);
 CTime = default(Int32);
 ETime = default(Int32);
 Status = default(Boolean);
 Money = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SellID); 
 ds.Write(CTime); 
 ds.Write(ETime); 
 ds.Write(Status); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out SellID)  &&
 ds.TryRead(out CTime)  &&
 ds.TryRead(out ETime)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class DBSyncSellInfoResX : DBSyncSellInfoRes
    {
        public DBSyncSellInfoResX()
        {
             RetCode = default(Int32);
 List = new Vector<SellPointInfo, SellPointInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(List); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)List) ;
        }
    }
      

    public class DBBuyPointArgX : DBBuyPointArg
    {
        public DBBuyPointArgX()
        {
             Buyer = default(Int32);
 LocalSid = default(UInt32);
 SellID = default(Int32);
 Seller = default(Int32);
 Timestamp = default(Int32);
 Money = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Buyer); 
 ds.Write(LocalSid); 
 ds.Write(SellID); 
 ds.Write(Seller); 
 ds.Write(Timestamp); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Buyer)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out SellID)  &&
 ds.TryRead(out Seller)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class DBBuyPointResX : DBBuyPointRes
    {
        public DBBuyPointResX()
        {
             RetCode = default(Int32);
 Point = default(Int32);
 Price = default(Int32);
 Money = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Point); 
 ds.Write(Price); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Point)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class TransIDX : TransID
    {
        public TransIDX()
        {
             ZoneId = default(Int32);
 SerialNo = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(SerialNo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out SerialNo) ;
        }
    }
      

    public class DBTransPointDealResX : DBTransPointDealRes
    {
        public DBTransPointDealResX()
        {
             RetCode = default(Int32);
 DelSell = new Vector<Int32>(); 
 GetMoney = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DelSell); 
 ds.Write(GetMoney); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)DelSell)  &&
 ds.TryRead(out GetMoney) ;
        }
    }
      

    public class PutSpouseArgX : PutSpouseArg
    {
        public PutSpouseArgX()
        {
             Oper = default(Int32);
 RId1 = default(Int32);
 RId2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Oper); 
 ds.Write(RId1); 
 ds.Write(RId2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Oper)  &&
 ds.TryRead(out RId1)  &&
 ds.TryRead(out RId2) ;
        }
    }
      

    public class RawKeyValueX : RawKeyValue
    {
        public RawKeyValueX()
        {
             Key = new Octets(); 
 Value = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class DBRawReadArgX : DBRawReadArg
    {
        public DBRawReadArgX()
        {
             Table = new Octets(); 
 Handle = new Octets(); 
 Key = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Table); 
 ds.Write(Handle); 
 ds.Write(Key); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Table)  &&
 ds.TryRead((IDataSerializer)Handle)  &&
 ds.TryRead((IDataSerializer)Key) ;
        }
    }
      

    public class DBRawReadResX : DBRawReadRes
    {
        public DBRawReadResX()
        {
             RetCode = default(Int32);
 Handle = new Octets(); 
 Values = new Vector<RawKeyValue, RawKeyValueX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Handle); 
 ds.Write(Values); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Handle)  &&
 ds.TryRead((IDataSerializer)Values) ;
        }
    }
      

    public class DBClearConsumableArgX : DBClearConsumableArg
    {
        public DBClearConsumableArgX()
        {
             UserID = default(Int32);
 LoginTime = default(Int32);
 Dryrun = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LoginTime); 
 ds.Write(Dryrun); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LoginTime)  &&
 ds.TryRead(out Dryrun) ;
        }
    }
      

    public class StockLogX : StockLog
    {
        public StockLogX()
        {
             TId = default(UInt32);
 Time = default(Int32);
 Result = default(Int16);
 Volume = default(Int16);
 Cost = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(Time); 
 ds.Write(Result); 
 ds.Write(Volume); 
 ds.Write(Cost); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead(out Result)  &&
 ds.TryRead(out Volume)  &&
 ds.TryRead(out Cost) ;
        }
    }
      

    public class GLoginRecordX : GLoginRecord
    {
        public GLoginRecordX()
        {
             LoginTime = default(Int32);
 Loginip = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LoginTime); 
 ds.Write(Loginip); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LoginTime)  &&
 ds.TryRead(out Loginip) ;
        }
    }
      

    public class GConsumptionRecordX : GConsumptionRecord
    {
        public GConsumptionRecordX()
        {
             Consumption = default(Int32);
 Reserved = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Consumption); 
 ds.Write(Reserved); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Consumption)  &&
 ds.TryRead(out Reserved)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class UserIDX : UserID
    {
        public UserIDX()
        {
             Id = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id) ;
        }
    }
      

    public class UserX : User
    {
        public UserX()
        {
             LogicUId = default(UInt32);
 RoleList = default(UInt32);
 Cash = default(Int32);
 Money = default(Int32);
 CashAdd = default(UInt32);
 CashBuy = default(UInt32);
 CashSell = default(UInt32);
 CashUsed = default(UInt32);
 AddSerial = default(Int32);
 UseSerial = default(Int32);
 ExgLog = new Vector<StockLog, StockLogX>(); 
 Addiction = new Octets(); 
 CashPassword = new Octets(); 
 AutoLock = new Vector<GPair, GPairX>(); 
 Status = default(Boolean);
 Forbid = new Vector<GRoleForbid, GRoleForbidX>(); 
 Reference = new Octets(); 
 ConsumeReward = new Octets(); 
 Taskcounter = new Octets(); 
 CashSysauction = new Octets(); 
 LoginRecord = new Octets(); 
 MallConsumption = new Octets(); 
 Reserved32 = default(Int16);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LogicUId); 
 ds.Write(RoleList); 
 ds.Write(Cash); 
 ds.Write(Money); 
 ds.Write(CashAdd); 
 ds.Write(CashBuy); 
 ds.Write(CashSell); 
 ds.Write(CashUsed); 
 ds.Write(AddSerial); 
 ds.Write(UseSerial); 
 ds.Write(ExgLog); 
 ds.Write(Addiction); 
 ds.Write(CashPassword); 
 ds.Write(AutoLock); 
 ds.Write(Status); 
 ds.Write(Forbid); 
 ds.Write(Reference); 
 ds.Write(ConsumeReward); 
 ds.Write(Taskcounter); 
 ds.Write(CashSysauction); 
 ds.Write(LoginRecord); 
 ds.Write(MallConsumption); 
 ds.Write(Reserved32); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LogicUId)  &&
 ds.TryRead(out RoleList)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out CashAdd)  &&
 ds.TryRead(out CashBuy)  &&
 ds.TryRead(out CashSell)  &&
 ds.TryRead(out CashUsed)  &&
 ds.TryRead(out AddSerial)  &&
 ds.TryRead(out UseSerial)  &&
 ds.TryRead((IDataSerializer)ExgLog)  &&
 ds.TryRead((IDataSerializer)Addiction)  &&
 ds.TryRead((IDataSerializer)CashPassword)  &&
 ds.TryRead((IDataSerializer)AutoLock)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)Forbid)  &&
 ds.TryRead((IDataSerializer)Reference)  &&
 ds.TryRead((IDataSerializer)ConsumeReward)  &&
 ds.TryRead((IDataSerializer)Taskcounter)  &&
 ds.TryRead((IDataSerializer)CashSysauction)  &&
 ds.TryRead((IDataSerializer)LoginRecord)  &&
 ds.TryRead((IDataSerializer)MallConsumption)  &&
 ds.TryRead(out Reserved32) ;
        }
    }
      

    public class UserArgX : UserArg
    {
        public UserArgX()
        {
             Id = default(UInt32);
 LoginTime = default(Int32);
 Loginip = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(LoginTime); 
 ds.Write(Loginip); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out LoginTime)  &&
 ds.TryRead(out Loginip) ;
        }
    }
      

    public class UserResX : UserRes
    {
        public UserResX()
        {
             RetCode = default(Int32);
 Value = new UserX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class UserPairX : UserPair
    {
        public UserPairX()
        {
             Key = new UserIDX(); 
 Value = new UserX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class GRoleForbidX : GRoleForbid
    {
        public GRoleForbidX()
        {
             Type = default(Byte);
 Time = default(Int32);
 CreateTime = default(Int32);
 Reason = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Type); 
 ds.Write(Time); 
 ds.Write(CreateTime); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Type)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead(out CreateTime)  &&
 ds.TryRead((IDataSerializer)Reason) ;
        }
    }
      

    public class GRoleBaseX : GRoleBase
    {
        public GRoleBaseX()
        {
             Version = default(Byte);
 Id = default(UInt32);
 Name = new Octets(); 
 Race = default(Int32);
 Cls = default(Int32);
 Gender = default(Byte);
 CustomData = new Octets(); 
 ConfigData = new Octets(); 
 CustomStamp = default(UInt32);
 Status = default(Boolean);
 DeleteTime = default(Int32);
 CreateTime = default(Int32);
 LastloginTime = default(Int32);
 Forbid = new Vector<GRoleForbid, GRoleForbidX>(); 
 HelpStates = new Octets(); 
 Spouse = default(UInt32);
 UserID = default(UInt32);
 CrossData = new Octets(); 
 Reserved2 = default(Byte);
 Reserved3 = default(Byte);
 Reserved4 = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Version); 
 ds.Write(Id); 
 ds.Write(Name); 
 ds.Write(Race); 
 ds.Write(Cls); 
 ds.Write(Gender); 
 ds.Write(CustomData); 
 ds.Write(ConfigData); 
 ds.Write(CustomStamp); 
 ds.Write(Status); 
 ds.Write(DeleteTime); 
 ds.Write(CreateTime); 
 ds.Write(LastloginTime); 
 ds.Write(Forbid); 
 ds.Write(HelpStates); 
 ds.Write(Spouse); 
 ds.Write(UserID); 
 ds.Write(CrossData); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Version)  &&
 ds.TryRead(out Id)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Race)  &&
 ds.TryRead(out Cls)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead((IDataSerializer)CustomData)  &&
 ds.TryRead((IDataSerializer)ConfigData)  &&
 ds.TryRead(out CustomStamp)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out DeleteTime)  &&
 ds.TryRead(out CreateTime)  &&
 ds.TryRead(out LastloginTime)  &&
 ds.TryRead((IDataSerializer)Forbid)  &&
 ds.TryRead((IDataSerializer)HelpStates)  &&
 ds.TryRead(out Spouse)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)CrossData)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4) ;
        }
    }
      

    public class GRoleStatusX : GRoleStatus
    {
        public GRoleStatusX()
        {
             Version = default(Byte);
 Level = default(Int32);
 Level2 = default(Int32);
 Exp = default(Int32);
 Sp = default(Int32);
 Pp = default(Int32);
 Hp = default(Int32);
 Mp = default(Int32);
 PosX = default(Single);
 PosY = default(Single);
 PosZ = default(Single);
 Worldtag = default(Int32);
 InvaderState = default(Int32);
 InvaderTime = default(Int32);
 PariahTime = default(Int32);
 Reputation = default(Int32);
 CustomStatus = new Octets(); 
 FilterData = new Octets(); 
 CharacterMode = new Octets(); 
 InstancekeyList = new Octets(); 
 DoubleTimeExpire = default(Int32);
 DoubleTimeMode = default(Int32);
 DoubleTimeBegin = default(Int32);
 DoubleTimeUsed = default(Int32);
 DoubleTimeMax = default(Int32);
 TimeUsed = default(Int32);
 DoubleTimeData = new Octets(); 
 StoreSize = default(UInt16);
 Petcorral = new Octets(); 
 Property = new Octets(); 
 VarData = new Octets(); 
 Skills = new Octets(); 
 StorehousePasswd = new Octets(); 
 WaypointList = new Octets(); 
 CoolingTime = new Octets(); 
 NpcRelation = new Octets(); 
 MultiExpCtrl = new Octets(); 
 StorageTask = new Octets(); 
 FactionContrib = new Octets(); 
 ForceData = new Octets(); 
 OnlineAward = new Octets(); 
 ProfitTimeData = new Octets(); 
 CountryData = new Octets(); 
 KingData = new Octets(); 
 MeridianData = new Octets(); 
 ExtraProp = new Octets(); 
 TitleData = new Octets(); 
 ReincarnationData = new Octets(); 
 RealmData = new Octets(); 
 Reserved2 = default(Byte);
 Reserved3 = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Version); 
 ds.Write(Level); 
 ds.Write(Level2); 
 ds.Write(Exp); 
 ds.Write(Sp); 
 ds.Write(Pp); 
 ds.Write(Hp); 
 ds.Write(Mp); 
 ds.Write(PosX); 
 ds.Write(PosY); 
 ds.Write(PosZ); 
 ds.Write(Worldtag); 
 ds.Write(InvaderState); 
 ds.Write(InvaderTime); 
 ds.Write(PariahTime); 
 ds.Write(Reputation); 
 ds.Write(CustomStatus); 
 ds.Write(FilterData); 
 ds.Write(CharacterMode); 
 ds.Write(InstancekeyList); 
 ds.Write(DoubleTimeExpire); 
 ds.Write(DoubleTimeMode); 
 ds.Write(DoubleTimeBegin); 
 ds.Write(DoubleTimeUsed); 
 ds.Write(DoubleTimeMax); 
 ds.Write(TimeUsed); 
 ds.Write(DoubleTimeData); 
 ds.Write(StoreSize); 
 ds.Write(Petcorral); 
 ds.Write(Property); 
 ds.Write(VarData); 
 ds.Write(Skills); 
 ds.Write(StorehousePasswd); 
 ds.Write(WaypointList); 
 ds.Write(CoolingTime); 
 ds.Write(NpcRelation); 
 ds.Write(MultiExpCtrl); 
 ds.Write(StorageTask); 
 ds.Write(FactionContrib); 
 ds.Write(ForceData); 
 ds.Write(OnlineAward); 
 ds.Write(ProfitTimeData); 
 ds.Write(CountryData); 
 ds.Write(KingData); 
 ds.Write(MeridianData); 
 ds.Write(ExtraProp); 
 ds.Write(TitleData); 
 ds.Write(ReincarnationData); 
 ds.Write(RealmData); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Version)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Level2)  &&
 ds.TryRead(out Exp)  &&
 ds.TryRead(out Sp)  &&
 ds.TryRead(out Pp)  &&
 ds.TryRead(out Hp)  &&
 ds.TryRead(out Mp)  &&
 ds.TryRead(out PosX)  &&
 ds.TryRead(out PosY)  &&
 ds.TryRead(out PosZ)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead(out InvaderState)  &&
 ds.TryRead(out InvaderTime)  &&
 ds.TryRead(out PariahTime)  &&
 ds.TryRead(out Reputation)  &&
 ds.TryRead((IDataSerializer)CustomStatus)  &&
 ds.TryRead((IDataSerializer)FilterData)  &&
 ds.TryRead((IDataSerializer)CharacterMode)  &&
 ds.TryRead((IDataSerializer)InstancekeyList)  &&
 ds.TryRead(out DoubleTimeExpire)  &&
 ds.TryRead(out DoubleTimeMode)  &&
 ds.TryRead(out DoubleTimeBegin)  &&
 ds.TryRead(out DoubleTimeUsed)  &&
 ds.TryRead(out DoubleTimeMax)  &&
 ds.TryRead(out TimeUsed)  &&
 ds.TryRead((IDataSerializer)DoubleTimeData)  &&
 ds.TryRead(out StoreSize)  &&
 ds.TryRead((IDataSerializer)Petcorral)  &&
 ds.TryRead((IDataSerializer)Property)  &&
 ds.TryRead((IDataSerializer)VarData)  &&
 ds.TryRead((IDataSerializer)Skills)  &&
 ds.TryRead((IDataSerializer)StorehousePasswd)  &&
 ds.TryRead((IDataSerializer)WaypointList)  &&
 ds.TryRead((IDataSerializer)CoolingTime)  &&
 ds.TryRead((IDataSerializer)NpcRelation)  &&
 ds.TryRead((IDataSerializer)MultiExpCtrl)  &&
 ds.TryRead((IDataSerializer)StorageTask)  &&
 ds.TryRead((IDataSerializer)FactionContrib)  &&
 ds.TryRead((IDataSerializer)ForceData)  &&
 ds.TryRead((IDataSerializer)OnlineAward)  &&
 ds.TryRead((IDataSerializer)ProfitTimeData)  &&
 ds.TryRead((IDataSerializer)CountryData)  &&
 ds.TryRead((IDataSerializer)KingData)  &&
 ds.TryRead((IDataSerializer)MeridianData)  &&
 ds.TryRead((IDataSerializer)ExtraProp)  &&
 ds.TryRead((IDataSerializer)TitleData)  &&
 ds.TryRead((IDataSerializer)ReincarnationData)  &&
 ds.TryRead((IDataSerializer)RealmData)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3) ;
        }
    }
      

    public class GRoleInventoryX : GRoleInventory
    {
        public GRoleInventoryX()
        {
             Id = default(UInt32);
 Pos = default(Int32);
 Count = default(Int32);
 MaxCount = default(Int32);
 Data = new Octets(); 
 ProcType = default(Int32);
 ExpireDate = default(Int32);
 GUId1 = default(Int32);
 GUId2 = default(Int32);
 Mask = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Pos); 
 ds.Write(Count); 
 ds.Write(MaxCount); 
 ds.Write(Data); 
 ds.Write(ProcType); 
 ds.Write(ExpireDate); 
 ds.Write(GUId1); 
 ds.Write(GUId2); 
 ds.Write(Mask); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out Pos)  &&
 ds.TryRead(out Count)  &&
 ds.TryRead(out MaxCount)  &&
 ds.TryRead((IDataSerializer)Data)  &&
 ds.TryRead(out ProcType)  &&
 ds.TryRead(out ExpireDate)  &&
 ds.TryRead(out GUId1)  &&
 ds.TryRead(out GUId2)  &&
 ds.TryRead(out Mask) ;
        }
    }
      

    public class GRoleStorehouseX : GRoleStorehouse
    {
        public GRoleStorehouseX()
        {
             Capacity = default(UInt32);
 Money = default(UInt32);
 Items = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Size1 = default(Byte);
 Size2 = default(Byte);
 Dress = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Material = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Size3 = default(Byte);
 Generalcard = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Reserved = default(Int16);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Capacity); 
 ds.Write(Money); 
 ds.Write(Items); 
 ds.Write(Size1); 
 ds.Write(Size2); 
 ds.Write(Dress); 
 ds.Write(Material); 
 ds.Write(Size3); 
 ds.Write(Generalcard); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Capacity)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead(out Size1)  &&
 ds.TryRead(out Size2)  &&
 ds.TryRead((IDataSerializer)Dress)  &&
 ds.TryRead((IDataSerializer)Material)  &&
 ds.TryRead(out Size3)  &&
 ds.TryRead((IDataSerializer)Generalcard)  &&
 ds.TryRead(out Reserved) ;
        }
    }
      

    public class GUserStoreHouseX : GUserStoreHouse
    {
        public GUserStoreHouseX()
        {
             Capacity = default(Int32);
 Money = default(UInt32);
 Items = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Capacity); 
 ds.Write(Money); 
 ds.Write(Items); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Capacity)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4) ;
        }
    }
      

    public class GSysLogX : GSysLog
    {
        public GSysLogX()
        {
             RoleId = default(Int32);
 Time = default(Int32);
 Ip = default(Int32);
 Source = default(Int16);
 Money = default(Int32);
 Items = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Time); 
 ds.Write(Ip); 
 ds.Write(Source); 
 ds.Write(Money); 
 ds.Write(Items); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead(out Ip)  &&
 ds.TryRead(out Source)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4) ;
        }
    }
      

    public class GRolePocketX : GRolePocket
    {
        public GRolePocketX()
        {
             Capacity = default(UInt32);
 Timestamp = default(UInt32);
 Money = default(UInt32);
 Items = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Capacity); 
 ds.Write(Timestamp); 
 ds.Write(Money); 
 ds.Write(Items); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Capacity)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class GRoleTaskX : GRoleTask
    {
        public GRoleTaskX()
        {
             TaskData = new Octets(); 
 TaskComplete = new Octets(); 
 TaskFinishTime = new Octets(); 
 TaskInventory = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TaskData); 
 ds.Write(TaskComplete); 
 ds.Write(TaskFinishTime); 
 ds.Write(TaskInventory); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)TaskData)  &&
 ds.TryRead((IDataSerializer)TaskComplete)  &&
 ds.TryRead((IDataSerializer)TaskFinishTime)  &&
 ds.TryRead((IDataSerializer)TaskInventory) ;
        }
    }
      

    public class GRoleEquipmentX : GRoleEquipment
    {
        public GRoleEquipmentX()
        {
             Inv = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Inv); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Inv) ;
        }
    }
      

    public class GRoleDataX : GRoleData
    {
        public GRoleDataX()
        {
             Base = new GRoleBaseX(); 
 Status = new GRoleStatusX(); 
 Pocket = new GRolePocketX(); 
 Equipment = new GRoleEquipmentX(); 
 Storehouse = new GRoleStorehouseX(); 
 Task = new GRoleTaskX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Base); 
 ds.Write(Status); 
 ds.Write(Pocket); 
 ds.Write(Equipment); 
 ds.Write(Storehouse); 
 ds.Write(Task); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Base)  &&
 ds.TryRead((IDataSerializer)Status)  &&
 ds.TryRead((IDataSerializer)Pocket)  &&
 ds.TryRead((IDataSerializer)Equipment)  &&
 ds.TryRead((IDataSerializer)Storehouse)  &&
 ds.TryRead((IDataSerializer)Task) ;
        }
    }
      

    public class GPetX : GPet
    {
        public GPetX()
        {
             Index = default(Int32);
 Data = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Index); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Index)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class GPetCorralX : GPetCorral
    {
        public GPetCorralX()
        {
             Capacity = default(Int32);
 Pets = new Vector<GPet, GPetX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Capacity); 
 ds.Write(Pets); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Capacity)  &&
 ds.TryRead((IDataSerializer)Pets) ;
        }
    }
      

    public class GShopLogX : GShopLog
    {
        public GShopLogX()
        {
             RoleId = default(Int32);
 OrderId = default(Int32);
 ItemId = default(Int32);
 Expire = default(Int32);
 ItemCount = default(Int32);
 OrderCount = default(Int32);
 CashNeed = default(Int32);
 Time = default(Int32);
 GUId1 = default(Int32);
 GUId2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(OrderId); 
 ds.Write(ItemId); 
 ds.Write(Expire); 
 ds.Write(ItemCount); 
 ds.Write(OrderCount); 
 ds.Write(CashNeed); 
 ds.Write(Time); 
 ds.Write(GUId1); 
 ds.Write(GUId2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out OrderId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out Expire)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out OrderCount)  &&
 ds.TryRead(out CashNeed)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead(out GUId1)  &&
 ds.TryRead(out GUId2) ;
        }
    }
      

    public class GUniqueDataElemX : GUniqueDataElem
    {
        public GUniqueDataElemX()
        {
             VType = default(Byte);
 Value = new Octets(); 
 Version = default(Int32);
 Reserved = default(Int16);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(VType); 
 ds.Write(Value); 
 ds.Write(Version); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out VType)  &&
 ds.TryRead((IDataSerializer)Value)  &&
 ds.TryRead(out Version)  &&
 ds.TryRead(out Reserved) ;
        }
    }
      

    public class GUniqueDataElemNodeX : GUniqueDataElemNode
    {
        public GUniqueDataElemNodeX()
        {
             Key = default(Int32);
 Val = new GUniqueDataElemX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Val); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Key)  &&
 ds.TryRead((IDataSerializer)Val) ;
        }
    }
      

    public class GForceDataX : GForceData
    {
        public GForceDataX()
        {
             ForceId = default(Int32);
 Reputation = default(Int32);
 Contribution = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
 Reserved6 = default(Int32);
 Reserved7 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ForceId); 
 ds.Write(Reputation); 
 ds.Write(Contribution); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
 ds.Write(Reserved6); 
 ds.Write(Reserved7); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ForceId)  &&
 ds.TryRead(out Reputation)  &&
 ds.TryRead(out Contribution)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5)  &&
 ds.TryRead(out Reserved6)  &&
 ds.TryRead(out Reserved7) ;
        }
    }
      

    public class GForceDataListX : GForceDataList
    {
        public GForceDataListX()
        {
             CurForceId = default(Int32);
 List = new Vector<GForceData, GForceDataX>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CurForceId); 
 ds.Write(List); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out CurForceId)  &&
 ds.TryRead((IDataSerializer)List)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3) ;
        }
    }
      

    public class GMeridianDataX : GMeridianData
    {
        public GMeridianDataX()
        {
             MeridianLevel = default(Int32);
 LifegateTimes = default(Int32);
 DeathgateTimes = default(Int32);
 FreeRefineTimes = default(Int32);
 PaidRefineTimes = default(Int32);
 PlayerLoginTime = default(Int32);
 ContinuLoginDays = default(Int32);
 TrigramsMap1 = default(Int32);
 TrigramsMap2 = default(Int32);
 TrigramsMap3 = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(MeridianLevel); 
 ds.Write(LifegateTimes); 
 ds.Write(DeathgateTimes); 
 ds.Write(FreeRefineTimes); 
 ds.Write(PaidRefineTimes); 
 ds.Write(PlayerLoginTime); 
 ds.Write(ContinuLoginDays); 
 ds.Write(TrigramsMap1); 
 ds.Write(TrigramsMap2); 
 ds.Write(TrigramsMap3); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out MeridianLevel)  &&
 ds.TryRead(out LifegateTimes)  &&
 ds.TryRead(out DeathgateTimes)  &&
 ds.TryRead(out FreeRefineTimes)  &&
 ds.TryRead(out PaidRefineTimes)  &&
 ds.TryRead(out PlayerLoginTime)  &&
 ds.TryRead(out ContinuLoginDays)  &&
 ds.TryRead(out TrigramsMap1)  &&
 ds.TryRead(out TrigramsMap2)  &&
 ds.TryRead(out TrigramsMap3)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4) ;
        }
    }
      

    public class GReincarnationRecordX : GReincarnationRecord
    {
        public GReincarnationRecordX()
        {
             Level = default(Int32);
 Timestamp = default(Int32);
 Exp = default(Int32);
 Reserved = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Level); 
 ds.Write(Timestamp); 
 ds.Write(Exp); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Level)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Exp)  &&
 ds.TryRead(out Reserved) ;
        }
    }
      

    public class GReincarnationDataX : GReincarnationData
    {
        public GReincarnationDataX()
        {
             TomeExp = default(Int32);
 TomeActive = default(Byte);
 Records = new Vector<GReincarnationRecord, GReincarnationRecordX>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TomeExp); 
 ds.Write(TomeActive); 
 ds.Write(Records); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TomeExp)  &&
 ds.TryRead(out TomeActive)  &&
 ds.TryRead((IDataSerializer)Records)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3) ;
        }
    }
      

    public class GRoleInfoX : GRoleInfo
    {
        public GRoleInfoX()
        {
             Version = default(Byte);
 Id = default(UInt32);
 Name = new Octets(); 
 Race = default(Int32);
 Cls = default(Int32);
 Gender = default(Byte);
 Level = default(Int32);
 Level2 = default(Int32);
 PosX = default(Single);
 PosY = default(Single);
 PosZ = default(Single);
 Worldtag = default(Int32);
 CustomData = new Octets(); 
 CustomStamp = default(UInt32);
 CustomStatus = new Octets(); 
 CharacterMode = new Octets(); 
 Equipment = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Status = default(Boolean);
 DeleteTime = default(Int32);
 CreateTime = default(Int32);
 LastloginTime = default(Int32);
 Forbid = new Vector<GRoleForbid, GRoleForbidX>(); 
 ReferrerRole = default(Int32);
 CashAdd = default(Int32);
 CrossData = new CrossInfoDataX(); 
 ReincarnationData = new Octets(); 
 RealmData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Version); 
 ds.Write(Id); 
 ds.Write(Name); 
 ds.Write(Race); 
 ds.Write(Cls); 
 ds.Write(Gender); 
 ds.Write(Level); 
 ds.Write(Level2); 
 ds.Write(PosX); 
 ds.Write(PosY); 
 ds.Write(PosZ); 
 ds.Write(Worldtag); 
 ds.Write(CustomData); 
 ds.Write(CustomStamp); 
 ds.Write(CustomStatus); 
 ds.Write(CharacterMode); 
 ds.Write(Equipment); 
 ds.Write(Status); 
 ds.Write(DeleteTime); 
 ds.Write(CreateTime); 
 ds.Write(LastloginTime); 
 ds.Write(Forbid); 
 ds.Write(ReferrerRole); 
 ds.Write(CashAdd); 
 ds.Write(CrossData); 
 ds.Write(ReincarnationData); 
 ds.Write(RealmData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Version)  &&
 ds.TryRead(out Id)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Race)  &&
 ds.TryRead(out Cls)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Level2)  &&
 ds.TryRead(out PosX)  &&
 ds.TryRead(out PosY)  &&
 ds.TryRead(out PosZ)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead((IDataSerializer)CustomData)  &&
 ds.TryRead(out CustomStamp)  &&
 ds.TryRead((IDataSerializer)CustomStatus)  &&
 ds.TryRead((IDataSerializer)CharacterMode)  &&
 ds.TryRead((IDataSerializer)Equipment)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out DeleteTime)  &&
 ds.TryRead(out CreateTime)  &&
 ds.TryRead(out LastloginTime)  &&
 ds.TryRead((IDataSerializer)Forbid)  &&
 ds.TryRead(out ReferrerRole)  &&
 ds.TryRead(out CashAdd)  &&
 ds.TryRead((IDataSerializer)CrossData)  &&
 ds.TryRead((IDataSerializer)ReincarnationData)  &&
 ds.TryRead((IDataSerializer)RealmData) ;
        }
    }
      

    public class GRoleDetailX : GRoleDetail
    {
        public GRoleDetailX()
        {
             Version = default(Byte);
 Id = default(UInt32);
 UserID = default(UInt32);
 Status = new GRoleStatusX(); 
 Name = new Octets(); 
 Race = default(Int32);
 Cls = default(Int32);
 Spouse = default(UInt32);
 Gender = default(Byte);
 CreateTime = default(Int32);
 LastloginTime = default(Int32);
 CashAdd = default(Int32);
 CashTotal = default(Int32);
 CashUsed = default(Int32);
 CashSerial = default(Int32);
 FactionId = default(UInt32);
 Factionrole = default(Int32);
 CustomData = new Octets(); 
 CustomStamp = default(UInt32);
 Inventory = new GRolePocketX(); 
 Equipment = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Storehouse = new GRoleStorehouseX(); 
 Task = new GRoleTaskX(); 
 Addiction = new Octets(); 
 Logs = new Vector<GShopLog, GShopLogX>(); 
 BonusAdd = default(Int32);
 BonusReward = default(Int32);
 BonusUsed = default(Int32);
 Referrer = default(Int32);
 UserStoreHouse = new GUserStoreHouseX(); 
 Taskcounter = new Octets(); 
 FactionAlliance = new Vector<GFactionAlliance, GFactionAllianceX>(); 
 FactionHostile = new Vector<GFactionHostile, GFactionHostileX>(); 
 MallConsumption = default(Int32);
 SrcZoneId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Version); 
 ds.Write(Id); 
 ds.Write(UserID); 
 ds.Write(Status); 
 ds.Write(Name); 
 ds.Write(Race); 
 ds.Write(Cls); 
 ds.Write(Spouse); 
 ds.Write(Gender); 
 ds.Write(CreateTime); 
 ds.Write(LastloginTime); 
 ds.Write(CashAdd); 
 ds.Write(CashTotal); 
 ds.Write(CashUsed); 
 ds.Write(CashSerial); 
 ds.Write(FactionId); 
 ds.Write(Factionrole); 
 ds.Write(CustomData); 
 ds.Write(CustomStamp); 
 ds.Write(Inventory); 
 ds.Write(Equipment); 
 ds.Write(Storehouse); 
 ds.Write(Task); 
 ds.Write(Addiction); 
 ds.Write(Logs); 
 ds.Write(BonusAdd); 
 ds.Write(BonusReward); 
 ds.Write(BonusUsed); 
 ds.Write(Referrer); 
 ds.Write(UserStoreHouse); 
 ds.Write(Taskcounter); 
 ds.Write(FactionAlliance); 
 ds.Write(FactionHostile); 
 ds.Write(MallConsumption); 
 ds.Write(SrcZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Version)  &&
 ds.TryRead(out Id)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)Status)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Race)  &&
 ds.TryRead(out Cls)  &&
 ds.TryRead(out Spouse)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead(out CreateTime)  &&
 ds.TryRead(out LastloginTime)  &&
 ds.TryRead(out CashAdd)  &&
 ds.TryRead(out CashTotal)  &&
 ds.TryRead(out CashUsed)  &&
 ds.TryRead(out CashSerial)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out Factionrole)  &&
 ds.TryRead((IDataSerializer)CustomData)  &&
 ds.TryRead(out CustomStamp)  &&
 ds.TryRead((IDataSerializer)Inventory)  &&
 ds.TryRead((IDataSerializer)Equipment)  &&
 ds.TryRead((IDataSerializer)Storehouse)  &&
 ds.TryRead((IDataSerializer)Task)  &&
 ds.TryRead((IDataSerializer)Addiction)  &&
 ds.TryRead((IDataSerializer)Logs)  &&
 ds.TryRead(out BonusAdd)  &&
 ds.TryRead(out BonusReward)  &&
 ds.TryRead(out BonusUsed)  &&
 ds.TryRead(out Referrer)  &&
 ds.TryRead((IDataSerializer)UserStoreHouse)  &&
 ds.TryRead((IDataSerializer)Taskcounter)  &&
 ds.TryRead((IDataSerializer)FactionAlliance)  &&
 ds.TryRead((IDataSerializer)FactionHostile)  &&
 ds.TryRead(out MallConsumption)  &&
 ds.TryRead(out SrcZoneId) ;
        }
    }
      

    public class GRoleTableUserX : GRoleTableUser
    {
        public GRoleTableUserX()
        {
             User = new UserX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(User); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)User) ;
        }
    }
      

    public class GRoleTableBaseX : GRoleTableBase
    {
        public GRoleTableBaseX()
        {
             Base = new GRoleBaseX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Base); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Base) ;
        }
    }
      

    public class GRoleTableStatusX : GRoleTableStatus
    {
        public GRoleTableStatusX()
        {
             Status = new GRoleStatusX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Status) ;
        }
    }
      

    public class GRoleTableInventoryX : GRoleTableInventory
    {
        public GRoleTableInventoryX()
        {
             Inventory = new GRolePocketX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Inventory); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Inventory) ;
        }
    }
      

    public class GRoleTableEquipmentX : GRoleTableEquipment
    {
        public GRoleTableEquipmentX()
        {
             Inv = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Inv); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Inv) ;
        }
    }
      

    public class GRoleTableStorehouseX : GRoleTableStorehouse
    {
        public GRoleTableStorehouseX()
        {
             Storehouse = new GRoleStorehouseX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Storehouse); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Storehouse) ;
        }
    }
      

    public class GRoleTableTaskX : GRoleTableTask
    {
        public GRoleTableTaskX()
        {
             TaskData = new GRoleTaskX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TaskData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)TaskData) ;
        }
    }
      

    public class GRoleTableFriendlistX : GRoleTableFriendlist
    {
        public GRoleTableFriendlistX()
        {
             FriendList = new GFriendListX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FriendList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FriendList) ;
        }
    }
      

    public class GRoleTableMessagesX : GRoleTableMessages
    {
        public GRoleTableMessagesX()
        {
             Messages = new Vector<Message, MessageX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Messages); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Messages) ;
        }
    }
      

    public class GRoleTableClsConfigX : GRoleTableClsConfig
    {
        public GRoleTableClsConfigX()
        {
             Version = default(Byte);
 Base = new GRoleBaseX(); 
 Status = new GRoleStatusX(); 
 Inventory = new GRolePocketX(); 
 Equipment = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Storehouse = new GRoleStorehouseX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Version); 
 ds.Write(Base); 
 ds.Write(Status); 
 ds.Write(Inventory); 
 ds.Write(Equipment); 
 ds.Write(Storehouse); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Version)  &&
 ds.TryRead((IDataSerializer)Base)  &&
 ds.TryRead((IDataSerializer)Status)  &&
 ds.TryRead((IDataSerializer)Inventory)  &&
 ds.TryRead((IDataSerializer)Equipment)  &&
 ds.TryRead((IDataSerializer)Storehouse) ;
        }
    }
      

    public class GRoleTableRolenameX : GRoleTableRolename
    {
        public GRoleTableRolenameX()
        {
             Id = new RoleIdX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Id) ;
        }
    }
      

    public class GRoleTableWaitdelX : GRoleTableWaitdel
    {
        public GRoleTableWaitdelX()
        {
             DeleteTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(DeleteTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out DeleteTime) ;
        }
    }
      

    public class GTableDefinitionX : GTableDefinition
    {
        public GTableDefinitionX()
        {
             User = new UserX(); 
 Base = new GRoleBaseX(); 
 Status = new GRoleStatusX(); 
 Task = new GRoleTaskX(); 
 Inventory = new GRolePocketX(); 
 Equipment = new GRoleEquipmentX(); 
 Storehouse = new GRoleStorehouseX(); 
 Mailbox = new GMailBoxX(); 
 Friends = new GFriendListX(); 
 Messages = new Vector<Message, MessageX>(); 
 FactionInfo = new GFactionInfoX(); 
 Order = new StockOrderX(); 
 Syslog = new GSysLogX(); 
 Config = new Octets(); 
 FactionName = default(Int32);
 WaitDel = default(Int32);
 ClsConfig = new GRoleTableClsConfigX(); 
 RoleName = default(Int32);
 ShopLog = default(Byte);
 Auction = new GAuctionDetailX(); 
 UserFaction = new GUserFactionX(); 
 SellPoint = default(Byte);
 TransLog = default(Byte);
 City = new GTerritoryStoreX(); 
 GTask = new Octets(); 
 UserStore = new GUserStoreHouseX(); 
 WebTrade = new GWebTradeDetailX(); 
 WebTradesOld = new GWebTradeDetailX(); 
 ServerData = new GServerDataX(); 
 FactionFortress = new GFactionFortressDetailX(); 
 Factionrelation = new GFactionRelationX(); 
 Force = new GForceGlobalDataListX(); 
 Friendext = new GFriendExtraX(); 
 Globalcontrol = new GGlobalControlDataX(); 
 RoleNameHis = new Octets(); 
 KingElection = new KingElectionDetailX(); 
 PlayerShop = new PShopDetailX(); 
 WeborderItem = new WebOrderItemDetailX(); 
 PlayerProfile = new PlayerProfileDataX(); 
 UniqueData = new GUniqueDataElemX(); 
 RecallUser = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(User); 
 ds.Write(Base); 
 ds.Write(Status); 
 ds.Write(Task); 
 ds.Write(Inventory); 
 ds.Write(Equipment); 
 ds.Write(Storehouse); 
 ds.Write(Mailbox); 
 ds.Write(Friends); 
 ds.Write(Messages); 
 ds.Write(FactionInfo); 
 ds.Write(Order); 
 ds.Write(Syslog); 
 ds.Write(Config); 
 ds.Write(FactionName); 
 ds.Write(WaitDel); 
 ds.Write(ClsConfig); 
 ds.Write(RoleName); 
 ds.Write(ShopLog); 
 ds.Write(Auction); 
 ds.Write(UserFaction); 
 ds.Write(SellPoint); 
 ds.Write(TransLog); 
 ds.Write(City); 
 ds.Write(GTask); 
 ds.Write(UserStore); 
 ds.Write(WebTrade); 
 ds.Write(WebTradesOld); 
 ds.Write(ServerData); 
 ds.Write(FactionFortress); 
 ds.Write(Factionrelation); 
 ds.Write(Force); 
 ds.Write(Friendext); 
 ds.Write(Globalcontrol); 
 ds.Write(RoleNameHis); 
 ds.Write(KingElection); 
 ds.Write(PlayerShop); 
 ds.Write(WeborderItem); 
 ds.Write(PlayerProfile); 
 ds.Write(UniqueData); 
 ds.Write(RecallUser); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)User)  &&
 ds.TryRead((IDataSerializer)Base)  &&
 ds.TryRead((IDataSerializer)Status)  &&
 ds.TryRead((IDataSerializer)Task)  &&
 ds.TryRead((IDataSerializer)Inventory)  &&
 ds.TryRead((IDataSerializer)Equipment)  &&
 ds.TryRead((IDataSerializer)Storehouse)  &&
 ds.TryRead((IDataSerializer)Mailbox)  &&
 ds.TryRead((IDataSerializer)Friends)  &&
 ds.TryRead((IDataSerializer)Messages)  &&
 ds.TryRead((IDataSerializer)FactionInfo)  &&
 ds.TryRead((IDataSerializer)Order)  &&
 ds.TryRead((IDataSerializer)Syslog)  &&
 ds.TryRead((IDataSerializer)Config)  &&
 ds.TryRead(out FactionName)  &&
 ds.TryRead(out WaitDel)  &&
 ds.TryRead((IDataSerializer)ClsConfig)  &&
 ds.TryRead(out RoleName)  &&
 ds.TryRead(out ShopLog)  &&
 ds.TryRead((IDataSerializer)Auction)  &&
 ds.TryRead((IDataSerializer)UserFaction)  &&
 ds.TryRead(out SellPoint)  &&
 ds.TryRead(out TransLog)  &&
 ds.TryRead((IDataSerializer)City)  &&
 ds.TryRead((IDataSerializer)GTask)  &&
 ds.TryRead((IDataSerializer)UserStore)  &&
 ds.TryRead((IDataSerializer)WebTrade)  &&
 ds.TryRead((IDataSerializer)WebTradesOld)  &&
 ds.TryRead((IDataSerializer)ServerData)  &&
 ds.TryRead((IDataSerializer)FactionFortress)  &&
 ds.TryRead((IDataSerializer)Factionrelation)  &&
 ds.TryRead((IDataSerializer)Force)  &&
 ds.TryRead((IDataSerializer)Friendext)  &&
 ds.TryRead((IDataSerializer)Globalcontrol)  &&
 ds.TryRead((IDataSerializer)RoleNameHis)  &&
 ds.TryRead((IDataSerializer)KingElection)  &&
 ds.TryRead((IDataSerializer)PlayerShop)  &&
 ds.TryRead((IDataSerializer)WeborderItem)  &&
 ds.TryRead((IDataSerializer)PlayerProfile)  &&
 ds.TryRead((IDataSerializer)UniqueData)  &&
 ds.TryRead(out RecallUser) ;
        }
    }
      

    public class RoleIdX : RoleId
    {
        public RoleIdX()
        {
             Id = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id) ;
        }
    }
      

    public class RoleArgX : RoleArg
    {
        public RoleArgX()
        {
             Key = new RoleIdX(); 
 DataMask = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(DataMask); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead(out DataMask) ;
        }
    }
      

    public class RoleResX : RoleRes
    {
        public RoleResX()
        {
             RetCode = default(Int32);
 DataMask = default(Int32);
 GameServerId = default(Byte);
 Value = new GRoleDetailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DataMask); 
 ds.Write(GameServerId); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DataMask)  &&
 ds.TryRead(out GameServerId)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class DBCreateRoleArgX : DBCreateRoleArg
    {
        public DBCreateRoleArgX()
        {
             UserID = default(Int32);
 LogicUId = default(UInt32);
 RoleId = default(Int32);
 RoleInfo = new RoleInfoX(); 
 AuSuggestReferrer = default(Int32);
 PlayerSuggestReferrer = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(LogicUId); 
 ds.Write(RoleId); 
 ds.Write(RoleInfo); 
 ds.Write(AuSuggestReferrer); 
 ds.Write(PlayerSuggestReferrer); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out LogicUId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleInfo)  &&
 ds.TryRead(out AuSuggestReferrer)  &&
 ds.TryRead(out PlayerSuggestReferrer) ;
        }
    }
      

    public class DBCreateRoleResX : DBCreateRoleRes
    {
        public DBCreateRoleResX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 RoleList = default(UInt32);
 RoleInfo = new RoleInfoX(); 
 RealReferrer = default(Int32);
 RefretCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(RoleList); 
 ds.Write(RoleInfo); 
 ds.Write(RealReferrer); 
 ds.Write(RefretCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out RoleList)  &&
 ds.TryRead((IDataSerializer)RoleInfo)  &&
 ds.TryRead(out RealReferrer)  &&
 ds.TryRead(out RefretCode) ;
        }
    }
      

    public class DBDeleteRoleArgX : DBDeleteRoleArg
    {
        public DBDeleteRoleArgX()
        {
             RoleId = default(Int32);
 CreateRollback = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CreateRollback); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out CreateRollback) ;
        }
    }
      

    public class DBDeleteRoleResX : DBDeleteRoleRes
    {
        public DBDeleteRoleResX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
 RoleList = default(UInt32);
 Faction = default(UInt32);
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
 ds.Write(RoleList); 
 ds.Write(Faction); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleList)  &&
 ds.TryRead(out Faction)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class DBUndoDeleteRoleArgX : DBUndoDeleteRoleArg
    {
        public DBUndoDeleteRoleArgX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class DBUndoDeleteRoleResX : DBUndoDeleteRoleRes
    {
        public DBUndoDeleteRoleResX()
        {
             RetCode = default(Int32);
 GameServerId = default(Byte);
 PosX = default(Single);
 PosY = default(Single);
 PosZ = default(Single);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(GameServerId); 
 ds.Write(PosX); 
 ds.Write(PosY); 
 ds.Write(PosZ); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out GameServerId)  &&
 ds.TryRead(out PosX)  &&
 ds.TryRead(out PosY)  &&
 ds.TryRead(out PosZ) ;
        }
    }
      

    public class AccountAddRoleArgX : AccountAddRoleArg
    {
        public AccountAddRoleArgX()
        {
             UserID = default(Int32);
 RoleId = default(Int32);
 ZoneId = default(Byte);
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(ZoneId); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class AccountAddRoleResX : AccountAddRoleRes
    {
        public AccountAddRoleResX()
        {
             RetCode = default(Byte);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class AccountDelRoleArgX : AccountDelRoleArg
    {
        public AccountDelRoleArgX()
        {
             ZoneId = default(Byte);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class AccountDelRoleResX : AccountDelRoleRes
    {
        public AccountDelRoleResX()
        {
             RetCode = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class RoleBasePairX : RoleBasePair
    {
        public RoleBasePairX()
        {
             Key = new RoleIdX(); 
 Value = new GRoleBaseX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RoleBaseResX : RoleBaseRes
    {
        public RoleBaseResX()
        {
             RetCode = default(Int32);
 Value = new GRoleBaseX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RoleStatusPairX : RoleStatusPair
    {
        public RoleStatusPairX()
        {
             Key = new RoleIdX(); 
 Value = new GRoleStatusX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RoleStatusResX : RoleStatusRes
    {
        public RoleStatusResX()
        {
             RetCode = default(Int32);
 Value = new GRoleStatusX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RoleEquipmentPairX : RoleEquipmentPair
    {
        public RoleEquipmentPairX()
        {
             Key = new RoleIdX(); 
 Equipment = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Equipment); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead((IDataSerializer)Equipment) ;
        }
    }
      

    public class RoleEquipmentResX : RoleEquipmentRes
    {
        public RoleEquipmentResX()
        {
             RetCode = default(Int32);
 Equipment = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Equipment); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Equipment) ;
        }
    }
      

    public class RoleTaskPairX : RoleTaskPair
    {
        public RoleTaskPairX()
        {
             Key = new RoleIdX(); 
 Value = new GRoleTaskX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RoleTaskResX : RoleTaskRes
    {
        public RoleTaskResX()
        {
             RetCode = default(Int32);
 Value = new GRoleTaskX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RoleDataPairX : RoleDataPair
    {
        public RoleDataPairX()
        {
             Key = new RoleIdX(); 
 OverWrite = default(Byte);
 Value = new GRoleDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(OverWrite); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead(out OverWrite)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RoleDataResX : RoleDataRes
    {
        public RoleDataResX()
        {
             RetCode = default(Int32);
 Value = new GRoleDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class DBModifyRoleDataArgX : DBModifyRoleDataArg
    {
        public DBModifyRoleDataArgX()
        {
             RoleId = default(Int32);
 Mask = default(UInt32);
 Level = default(Int32);
 Exp = default(Int64);
 PocketMoney = default(UInt32);
 StoreMoney = default(UInt32);
 PKValue = default(Int32);
 Reputation = default(Int32);
 Potential = default(Int32);
 Occupation = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Mask); 
 ds.Write(Level); 
 ds.Write(Exp); 
 ds.Write(PocketMoney); 
 ds.Write(StoreMoney); 
 ds.Write(PKValue); 
 ds.Write(Reputation); 
 ds.Write(Potential); 
 ds.Write(Occupation); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Mask)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Exp)  &&
 ds.TryRead(out PocketMoney)  &&
 ds.TryRead(out StoreMoney)  &&
 ds.TryRead(out PKValue)  &&
 ds.TryRead(out Reputation)  &&
 ds.TryRead(out Potential)  &&
 ds.TryRead(out Occupation) ;
        }
    }
      

    public class DBModifyRoleDataResX : DBModifyRoleDataRes
    {
        public DBModifyRoleDataResX()
        {
             RetCode = default(Int32);
 TotalMoney = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(TotalMoney); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out TotalMoney) ;
        }
    }
      

    public class TradeInventoryArgX : TradeInventoryArg
    {
        public TradeInventoryArgX()
        {
             RoleId1 = default(UInt32);
 RoleId2 = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId1); 
 ds.Write(RoleId2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId1)  &&
 ds.TryRead(out RoleId2) ;
        }
    }
      

    public class TradeInventoryResX : TradeInventoryRes
    {
        public TradeInventoryResX()
        {
             RetCode = default(Int32);
 Pocket1 = new GRolePocketX(); 
 Pocket2 = new GRolePocketX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Pocket1); 
 ds.Write(Pocket2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Pocket1)  &&
 ds.TryRead((IDataSerializer)Pocket2) ;
        }
    }
      

    public class TradeSaveArgX : TradeSaveArg
    {
        public TradeSaveArgX()
        {
             RoleId1 = default(UInt32);
 RoleId2 = default(UInt32);
 Money1 = default(UInt32);
 Money2 = default(UInt32);
 Goods1 = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Goods2 = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId1); 
 ds.Write(RoleId2); 
 ds.Write(Money1); 
 ds.Write(Money2); 
 ds.Write(Goods1); 
 ds.Write(Goods2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId1)  &&
 ds.TryRead(out RoleId2)  &&
 ds.TryRead(out Money1)  &&
 ds.TryRead(out Money2)  &&
 ds.TryRead((IDataSerializer)Goods1)  &&
 ds.TryRead((IDataSerializer)Goods2) ;
        }
    }
      

    public class TradeSaveResX : TradeSaveRes
    {
        public TradeSaveResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class GetMoneyInventoryArgX : GetMoneyInventoryArg
    {
        public GetMoneyInventoryArgX()
        {
             RoleId = default(Int32);
 DataMask = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(DataMask); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out DataMask) ;
        }
    }
      

    public class GetMoneyInventoryResX : GetMoneyInventoryRes
    {
        public GetMoneyInventoryResX()
        {
             RetCode = default(Int32);
 Timestamp = default(Int32);
 Money = default(UInt32);
 Goods = new Vector<GRoleInventory, GRoleInventoryX>(); 
 DataMask = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Timestamp); 
 ds.Write(Money); 
 ds.Write(Goods); 
 ds.Write(DataMask); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Goods)  &&
 ds.TryRead(out DataMask) ;
        }
    }
      

    public class PutMoneyInventoryArgX : PutMoneyInventoryArg
    {
        public PutMoneyInventoryArgX()
        {
             RoleId = default(UInt32);
 Money = default(UInt32);
 Goods = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Money); 
 ds.Write(Goods); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Goods) ;
        }
    }
      

    public class RolePairX : RolePair
    {
        public RolePairX()
        {
             Key = new RoleIdX(); 
 DataMask = default(Int32);
 Priority = default(Byte);
 Value = new GRoleDetailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(DataMask); 
 ds.Write(Priority); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead(out DataMask)  &&
 ds.TryRead(out Priority)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class GetRoleBaseStatusResX : GetRoleBaseStatusRes
    {
        public GetRoleBaseStatusResX()
        {
             RetCode = default(Int32);
 Base = new GRoleBaseX(); 
 Status = new GRoleStatusX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Base); 
 ds.Write(Status); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Base)  &&
 ds.TryRead((IDataSerializer)Status) ;
        }
    }
      

    public class RoleStorehousePairX : RoleStorehousePair
    {
        public RoleStorehousePairX()
        {
             Key = new RoleIdX(); 
 Value = new GRoleStorehouseX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RoleStorehouseResX : RoleStorehouseRes
    {
        public RoleStorehouseResX()
        {
             RetCode = default(Int32);
 Value = new GRoleStorehouseX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RoleForbidPairX : RoleForbidPair
    {
        public RoleForbidPairX()
        {
             Key = new RoleIdX(); 
 Value = new Vector<GRoleForbid, GRoleForbidX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class GetRoleForbidArgX : GetRoleForbidArg
    {
        public GetRoleForbidArgX()
        {
             Key = new RoleIdX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key) ;
        }
    }
      

    public class GetRoleForbidResX : GetRoleForbidRes
    {
        public GetRoleForbidResX()
        {
             RetCode = default(Int32);
 Value = new Vector<GRoleForbid, GRoleForbidX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class GetRoleIdArgX : GetRoleIdArg
    {
        public GetRoleIdArgX()
        {
             RoleName = new Octets(); 
 Reason = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleName); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class GetRoleIdResX : GetRoleIdRes
    {
        public GetRoleIdResX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class TransactionTimeoutX : TransactionTimeout
    {
        public TransactionTimeoutX()
        {
             Timeout = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Timeout); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Timeout) ;
        }
    }
      

    public class TransactionIdX : TransactionId
    {
        public TransactionIdX()
        {
             Id = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id) ;
        }
    }
      

    public class PreCreateRoleArgX : PreCreateRoleArg
    {
        public PreCreateRoleArgX()
        {
             ZoneId = default(Int32);
 UserID = default(Int32);
 UseLogic = default(Int32);
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(UserID); 
 ds.Write(UseLogic); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out UseLogic)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class PreCreateRoleResX : PreCreateRoleRes
    {
        public PreCreateRoleResX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
 LogicUId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(LogicUId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out LogicUId) ;
        }
    }
      

    public class PostCreateRoleArgX : PostCreateRoleArg
    {
        public PostCreateRoleArgX()
        {
             Success = default(Byte);
 UserID = default(Int32);
 ZoneId = default(Int32);
 RoleId = default(Int32);
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Success); 
 ds.Write(UserID); 
 ds.Write(ZoneId); 
 ds.Write(RoleId); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Success)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class PostCreateRoleResX : PostCreateRoleRes
    {
        public PostCreateRoleResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class PostDeleteRoleArgX : PostDeleteRoleArg
    {
        public PostDeleteRoleArgX()
        {
             UserID = default(Int32);
 ZoneId = default(Int32);
 RoleId = default(Int32);
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(ZoneId); 
 ds.Write(RoleId); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class PostDeleteRoleResX : PostDeleteRoleRes
    {
        public PostDeleteRoleResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class PreCreateFactionArgX : PreCreateFactionArg
    {
        public PreCreateFactionArgX()
        {
             ZoneId = default(Int32);
 FactionName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(FactionName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead((IDataSerializer)FactionName) ;
        }
    }
      

    public class PreCreateFactionResX : PreCreateFactionRes
    {
        public PreCreateFactionResX()
        {
             RetCode = default(Int32);
 FactionId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out FactionId) ;
        }
    }
      

    public class PostCreateFactionArgX : PostCreateFactionArg
    {
        public PostCreateFactionArgX()
        {
             Success = default(Byte);
 ZoneId = default(Int32);
 FactionId = default(Int32);
 FactionName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Success); 
 ds.Write(ZoneId); 
 ds.Write(FactionId); 
 ds.Write(FactionName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Success)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead((IDataSerializer)FactionName) ;
        }
    }
      

    public class PostCreateFactionResX : PostCreateFactionRes
    {
        public PostCreateFactionResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class PostDeleteFactionArgX : PostDeleteFactionArg
    {
        public PostDeleteFactionArgX()
        {
             ZoneId = default(Int32);
 FactionId = default(Int32);
 FactionName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(FactionId); 
 ds.Write(FactionName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead((IDataSerializer)FactionName) ;
        }
    }
      

    public class PostDeleteFactionResX : PostDeleteFactionRes
    {
        public PostDeleteFactionResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class PreCreateFamilyArgX : PreCreateFamilyArg
    {
        public PreCreateFamilyArgX()
        {
             ZoneId = default(Int32);
 FamilyName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(FamilyName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead((IDataSerializer)FamilyName) ;
        }
    }
      

    public class PreCreateFamilyResX : PreCreateFamilyRes
    {
        public PreCreateFamilyResX()
        {
             RetCode = default(Int32);
 FamilyId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(FamilyId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out FamilyId) ;
        }
    }
      

    public class PostCreateFamilyArgX : PostCreateFamilyArg
    {
        public PostCreateFamilyArgX()
        {
             Success = default(Byte);
 ZoneId = default(Int32);
 FamilyId = default(Int32);
 FamilyName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Success); 
 ds.Write(ZoneId); 
 ds.Write(FamilyId); 
 ds.Write(FamilyName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Success)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out FamilyId)  &&
 ds.TryRead((IDataSerializer)FamilyName) ;
        }
    }
      

    public class PostCreateFamilyResX : PostCreateFamilyRes
    {
        public PostCreateFamilyResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class PostDeleteFamilyArgX : PostDeleteFamilyArg
    {
        public PostDeleteFamilyArgX()
        {
             ZoneId = default(Int32);
 FamilyId = default(Int32);
 FamilyName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(FamilyId); 
 ds.Write(FamilyName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out FamilyId)  &&
 ds.TryRead((IDataSerializer)FamilyName) ;
        }
    }
      

    public class PostDeleteFamilyResX : PostDeleteFamilyRes
    {
        public PostDeleteFamilyResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class RoleInfoResX : RoleInfoRes
    {
        public RoleInfoResX()
        {
             RetCode = default(Int32);
 Value = new GRoleInfoX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RolePocketPairX : RolePocketPair
    {
        public RolePocketPairX()
        {
             Key = new RoleIdX(); 
 Value = new GRolePocketX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class RolePocketResX : RolePocketRes
    {
        public RolePocketResX()
        {
             RetCode = default(Int32);
 Value = new GRolePocketX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class PrePlayerRenameArgX : PrePlayerRenameArg
    {
        public PrePlayerRenameArgX()
        {
             RoleId = default(Int32);
 ZoneId = default(Int32);
 UserID = default(Int32);
 NewName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ZoneId); 
 ds.Write(UserID); 
 ds.Write(NewName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)NewName) ;
        }
    }
      

    public class PrePlayerRenameResX : PrePlayerRenameRes
    {
        public PrePlayerRenameResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBPlayerRenameArgX : DBPlayerRenameArg
    {
        public DBPlayerRenameArgX()
        {
             RoleId = default(Int32);
 ItemId = default(Int32);
 ItemNumber = default(Int32);
 ItemPos = default(Int32);
 NewName = new Octets(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemId); 
 ds.Write(ItemNumber); 
 ds.Write(ItemPos); 
 ds.Write(NewName); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead((IDataSerializer)NewName)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPlayerRenameResX : DBPlayerRenameRes
    {
        public DBPlayerRenameResX()
        {
             RetCode = default(Int32);
 OldName = new Octets(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(OldName); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)OldName)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class GRoleNameHisX : GRoleNameHis
    {
        public GRoleNameHisX()
        {
             OldName = new Octets(); 
 RenameTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(OldName); 
 ds.Write(RenameTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)OldName)  &&
 ds.TryRead(out RenameTime) ;
        }
    }
      

    public class GRoleIDandNameX : GRoleIDandName
    {
        public GRoleIDandNameX()
        {
             RoleId = default(Int32);
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class DBRoleNameListArgX : DBRoleNameListArg
    {
        public DBRoleNameListArgX()
        {
             Handle = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Handle) ;
        }
    }
      

    public class DBRoleNameListResX : DBRoleNameListRes
    {
        public DBRoleNameListResX()
        {
             RetCode = default(Int32);
 Handle = default(Int32);
 Finish = default(Byte);
 RoleNameList = new Vector<GRoleIDandName, GRoleIDandNameX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Handle); 
 ds.Write(Finish); 
 ds.Write(RoleNameList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Handle)  &&
 ds.TryRead(out Finish)  &&
 ds.TryRead((IDataSerializer)RoleNameList) ;
        }
    }
      

    public class DBPlayerGivePresentArgX : DBPlayerGivePresentArg
    {
        public DBPlayerGivePresentArgX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
 TargetRoleId = default(Int32);
 MailId = default(Int32);
 Goods = new Vector<GRoleInventory, GRoleInventoryX>(); 
 CashCost = default(UInt32);
 HasGift = default(Byte);
 LogPrice1 = default(Int32);
 LogPrice2 = default(Int32);
 RoleName = new Octets(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(TargetRoleId); 
 ds.Write(MailId); 
 ds.Write(Goods); 
 ds.Write(CashCost); 
 ds.Write(HasGift); 
 ds.Write(LogPrice1); 
 ds.Write(LogPrice2); 
 ds.Write(RoleName); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out TargetRoleId)  &&
 ds.TryRead(out MailId)  &&
 ds.TryRead((IDataSerializer)Goods)  &&
 ds.TryRead(out CashCost)  &&
 ds.TryRead(out HasGift)  &&
 ds.TryRead(out LogPrice1)  &&
 ds.TryRead(out LogPrice2)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPlayerGivePresentResX : DBPlayerGivePresentRes
    {
        public DBPlayerGivePresentResX()
        {
             RetCode = default(Int32);
 InformTarget = new GMailHeaderX(); 
 InformTarget2 = new GMailHeaderX(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(InformTarget); 
 ds.Write(InformTarget2); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)InformTarget)  &&
 ds.TryRead((IDataSerializer)InformTarget2)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPlayerAskForPresentArgX : DBPlayerAskForPresentArg
    {
        public DBPlayerAskForPresentArgX()
        {
             RoleId = default(Int32);
 TargetRoleId = default(Int32);
 GoodsId = default(Int32);
 GoodsIndex = default(Int32);
 GoodsSlot = default(Int32);
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(TargetRoleId); 
 ds.Write(GoodsId); 
 ds.Write(GoodsIndex); 
 ds.Write(GoodsSlot); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out TargetRoleId)  &&
 ds.TryRead(out GoodsId)  &&
 ds.TryRead(out GoodsIndex)  &&
 ds.TryRead(out GoodsSlot)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class DBPlayerAskForPresentResX : DBPlayerAskForPresentRes
    {
        public DBPlayerAskForPresentResX()
        {
             RetCode = default(Int32);
 InformTarget = new GMailHeaderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(InformTarget); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)InformTarget) ;
        }
    }
      

    public class GServerDataX : GServerData
    {
        public GServerDataX()
        {
             Worldtag = default(Int32);
 WeddingData = new Octets(); 
 DpsrankData = new Octets(); 
 Reserved11 = default(Byte);
 Reserved12 = default(Int16);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Worldtag); 
 ds.Write(WeddingData); 
 ds.Write(DpsrankData); 
 ds.Write(Reserved11); 
 ds.Write(Reserved12); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Worldtag)  &&
 ds.TryRead((IDataSerializer)WeddingData)  &&
 ds.TryRead((IDataSerializer)DpsrankData)  &&
 ds.TryRead(out Reserved11)  &&
 ds.TryRead(out Reserved12)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5) ;
        }
    }
      

    public class PutServerDataArgX : PutServerDataArg
    {
        public PutServerDataArgX()
        {
             Worldtag = default(Int32);
 DataMask = default(Int32);
 Priority = default(Int32);
 Data = new GServerDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Worldtag); 
 ds.Write(DataMask); 
 ds.Write(Priority); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Worldtag)  &&
 ds.TryRead(out DataMask)  &&
 ds.TryRead(out Priority)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class GetServerDataArgX : GetServerDataArg
    {
        public GetServerDataArgX()
        {
             Worldtag = default(Int32);
 DataMask = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Worldtag); 
 ds.Write(DataMask); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Worldtag)  &&
 ds.TryRead(out DataMask) ;
        }
    }
      

    public class GetServerDataResX : GetServerDataRes
    {
        public GetServerDataResX()
        {
             RetCode = default(Int32);
 DataMask = default(Int32);
 Data = new GServerDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(DataMask); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out DataMask)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class GetCashTotalArgX : GetCashTotalArg
    {
        public GetCashTotalArgX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class GetCashTotalResX : GetCashTotalRes
    {
        public GetCashTotalResX()
        {
             RetCode = default(Int32);
 CashTotal = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(CashTotal); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out CashTotal) ;
        }
    }
      

    public class DBSetCashPasswordArgX : DBSetCashPasswordArg
    {
        public DBSetCashPasswordArgX()
        {
             UserID = default(Int32);
 Source = default(Int32);
 Password = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(Source); 
 ds.Write(Password); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out Source)  &&
 ds.TryRead((IDataSerializer)Password) ;
        }
    }
      

    public class DBSetCashPasswordResX : DBSetCashPasswordRes
    {
        public DBSetCashPasswordResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBPlayerPositionResetArgX : DBPlayerPositionResetArg
    {
        public DBPlayerPositionResetArgX()
        {
             RoleId = default(Int32);
 Worldtag = default(Int32);
 PosX = default(Single);
 PosY = default(Single);
 PosZ = default(Single);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Worldtag); 
 ds.Write(PosX); 
 ds.Write(PosY); 
 ds.Write(PosZ); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead(out PosX)  &&
 ds.TryRead(out PosY)  &&
 ds.TryRead(out PosZ) ;
        }
    }
      

    public class DBPlayerPositionResetResX : DBPlayerPositionResetRes
    {
        public DBPlayerPositionResetResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class GGlobalControlDataX : GGlobalControlData
    {
        public GGlobalControlDataX()
        {
             CashMoneyExchangeOpen = default(Byte);
 CashMoneyExchangeRate = default(Int32);
 ForbidCtrlList = new Vector<Int32>(); 
 ForbidItemList = new Vector<Int32>(); 
 ForbidServiceList = new Vector<Int32>(); 
 ForbidTaskList = new Vector<Int32>(); 
 ForbidSkillList = new Vector<Int32>(); 
 TriggerCtrlList = new Vector<Int32>(); 
 Reserved12 = default(Byte);
 Reserved13 = default(Byte);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
 Reserved6 = default(Int32);
 Reserved7 = default(Int32);
 Reserved8 = default(Int32);
 Reserved9 = default(Int32);
 Reserved10 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CashMoneyExchangeOpen); 
 ds.Write(CashMoneyExchangeRate); 
 ds.Write(ForbidCtrlList); 
 ds.Write(ForbidItemList); 
 ds.Write(ForbidServiceList); 
 ds.Write(ForbidTaskList); 
 ds.Write(ForbidSkillList); 
 ds.Write(TriggerCtrlList); 
 ds.Write(Reserved12); 
 ds.Write(Reserved13); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
 ds.Write(Reserved6); 
 ds.Write(Reserved7); 
 ds.Write(Reserved8); 
 ds.Write(Reserved9); 
 ds.Write(Reserved10); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out CashMoneyExchangeOpen)  &&
 ds.TryRead(out CashMoneyExchangeRate)  &&
 ds.TryRead((IDataSerializer)ForbidCtrlList)  &&
 ds.TryRead((IDataSerializer)ForbidItemList)  &&
 ds.TryRead((IDataSerializer)ForbidServiceList)  &&
 ds.TryRead((IDataSerializer)ForbidTaskList)  &&
 ds.TryRead((IDataSerializer)ForbidSkillList)  &&
 ds.TryRead((IDataSerializer)TriggerCtrlList)  &&
 ds.TryRead(out Reserved12)  &&
 ds.TryRead(out Reserved13)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5)  &&
 ds.TryRead(out Reserved6)  &&
 ds.TryRead(out Reserved7)  &&
 ds.TryRead(out Reserved8)  &&
 ds.TryRead(out Reserved9)  &&
 ds.TryRead(out Reserved10) ;
        }
    }
      

    public class DBLoadGlobalControlArgX : DBLoadGlobalControlArg
    {
        public DBLoadGlobalControlArgX()
        {
             Nouse = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Nouse); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Nouse) ;
        }
    }
      

    public class DBLoadGlobalControlResX : DBLoadGlobalControlRes
    {
        public DBLoadGlobalControlResX()
        {
             RetCode = default(Int32);
 Data = new GGlobalControlDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class DBPutGlobalControlArgX : DBPutGlobalControlArg
    {
        public DBPutGlobalControlArgX()
        {
             Data = new GGlobalControlDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class DBPutGlobalControlResX : DBPutGlobalControlRes
    {
        public DBPutGlobalControlResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBUniqueDataLoadArgX : DBUniqueDataLoadArg
    {
        public DBUniqueDataLoadArgX()
        {
             Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBUniqueDataLoadResX : DBUniqueDataLoadRes
    {
        public DBUniqueDataLoadResX()
        {
             RetCode = default(Int32);
 Values = new Vector<GUniqueDataElemNode, GUniqueDataElemNodeX>(); 
 Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Values); 
 ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Values)  &&
 ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBUniqueDataSaveArgX : DBUniqueDataSaveArg
    {
        public DBUniqueDataSaveArgX()
        {
             Values = new Vector<GUniqueDataElemNode, GUniqueDataElemNodeX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Values); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Values) ;
        }
    }
      

    public class DBUniqueDataSaveResX : DBUniqueDataSaveRes
    {
        public DBUniqueDataSaveResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class GetUserRolesArgX : GetUserRolesArg
    {
        public GetUserRolesArgX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class ClearStorehousePasswdArgX : ClearStorehousePasswdArg
    {
        public ClearStorehousePasswdArgX()
        {
             RoleId = default(Int32);
 RoleName = new Octets(); 
 Reserved = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RoleName); 
 ds.Write(Reserved); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead((IDataSerializer)Reserved) ;
        }
    }
      

    public class CanChangeRolenameArgX : CanChangeRolenameArg
    {
        public CanChangeRolenameArgX()
        {
             RoleName = new Octets(); 
 SetCanChange = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleName); 
 ds.Write(SetCanChange); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead(out SetCanChange) ;
        }
    }
      

    public class CanChangeRolenameResX : CanChangeRolenameRes
    {
        public CanChangeRolenameResX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class RenameRoleArgX : RenameRoleArg
    {
        public RenameRoleArgX()
        {
             RoleId = default(Int32);
 OldName = new Octets(); 
 NewName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(OldName); 
 ds.Write(NewName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)OldName)  &&
 ds.TryRead((IDataSerializer)NewName) ;
        }
    }
      

    public class Uid2LogicuidArgX : Uid2LogicuidArg
    {
        public Uid2LogicuidArgX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class Uid2LogicuidResX : Uid2LogicuidRes
    {
        public Uid2LogicuidResX()
        {
             RetCode = default(Int32);
 LogicUId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(LogicUId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out LogicUId) ;
        }
    }
      

    public class Roleid2UidArgX : Roleid2UidArg
    {
        public Roleid2UidArgX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class Roleid2UidResX : Roleid2UidRes
    {
        public Roleid2UidResX()
        {
             RetCode = default(Int32);
 UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out UserID) ;
        }
    }
      

    public class RolenameExistsArgX : RolenameExistsArg
    {
        public RolenameExistsArgX()
        {
             RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class RolenameExistsResX : RolenameExistsRes
    {
        public RolenameExistsResX()
        {
             RetCode = default(Int32);
 ZoneId = default(Int32);
 RoleId = default(Int32);
 Status = default(Int32);
 Time = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(ZoneId); 
 ds.Write(RoleId); 
 ds.Write(Status); 
 ds.Write(Time); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out Time) ;
        }
    }
      

    public class UserRoleCountArgX : UserRoleCountArg
    {
        public UserRoleCountArgX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class UserRoleCountResX : UserRoleCountRes
    {
        public UserRoleCountResX()
        {
             RetCode = default(Int32);
 Count = default(Int32);
 RoleList = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Count); 
 ds.Write(RoleList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Count)  &&
 ds.TryRead(out RoleList) ;
        }
    }
      

    public class MoveRoleCreateArgX : MoveRoleCreateArg
    {
        public MoveRoleCreateArgX()
        {
             FromZoneId = default(Int32);
 ZoneId = default(Int32);
 UserID = default(Int32);
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FromZoneId); 
 ds.Write(ZoneId); 
 ds.Write(UserID); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FromZoneId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class MoveRoleCreateResX : MoveRoleCreateRes
    {
        public MoveRoleCreateResX()
        {
             RetCode = default(Int32);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class TradeStartRqstArgX : TradeStartRqstArg
    {
        public TradeStartRqstArgX()
        {
             RoleId = default(Int32);
 LocalSid = default(UInt32);
 StartRoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(LocalSid); 
 ds.Write(StartRoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out LocalSid)  &&
 ds.TryRead(out StartRoleId) ;
        }
    }
      

    public class TradeStartRqstResX : TradeStartRqstRes
    {
        public TradeStartRqstResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBConfigX : DBConfig
    {
        public DBConfigX()
        {
             InitTime = default(UInt32);
 OpenTime = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(InitTime); 
 ds.Write(OpenTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out InitTime)  &&
 ds.TryRead(out OpenTime) ;
        }
    }
      

    public class DBConfig2X : DBConfig2
    {
        public DBConfig2X()
        {
             IsCentralDb = default(UInt32);
 Reserve = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(IsCentralDb); 
 ds.Write(Reserve); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out IsCentralDb)  &&
 ds.TryRead(out Reserve) ;
        }
    }
      

    public class GMailIDX : GMailID
    {
        public GMailIDX()
        {
             RoleId = default(Int32);
 MailId = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(MailId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out MailId) ;
        }
    }
      

    public class GMailDefResX : GMailDefRes
    {
        public GMailDefResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class GMailHeaderX : GMailHeader
    {
        public GMailHeaderX()
        {
             Id = default(Byte);
 Sender = default(Int32);
 SndrType = default(Byte);
 Receiver = default(Int32);
 Title = new Octets(); 
 SendTime = default(Int32);
 Attribute = default(Byte);
 SenderName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Sender); 
 ds.Write(SndrType); 
 ds.Write(Receiver); 
 ds.Write(Title); 
 ds.Write(SendTime); 
 ds.Write(Attribute); 
 ds.Write(SenderName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out Sender)  &&
 ds.TryRead(out SndrType)  &&
 ds.TryRead(out Receiver)  &&
 ds.TryRead((IDataSerializer)Title)  &&
 ds.TryRead(out SendTime)  &&
 ds.TryRead(out Attribute)  &&
 ds.TryRead((IDataSerializer)SenderName) ;
        }
    }
      

    public class GMailX : GMail
    {
        public GMailX()
        {
             Header = new GMailHeaderX(); 
 Context = new Octets(); 
 AttachObj = new GRoleInventoryX(); 
 AttachMoney = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Header); 
 ds.Write(Context); 
 ds.Write(AttachObj); 
 ds.Write(AttachMoney); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Header)  &&
 ds.TryRead((IDataSerializer)Context)  &&
 ds.TryRead((IDataSerializer)AttachObj)  &&
 ds.TryRead(out AttachMoney) ;
        }
    }
      

    public class GMailSyncDataX : GMailSyncData
    {
        public GMailSyncDataX()
        {
             DataMask = default(Int32);
 CashTotal = default(Int32);
 CashUsed = default(UInt32);
 CashSerial = default(Int32);
 Inventory = new GRolePocketX(); 
 Storehouse = new GRoleStorehouseX(); 
 Equipment = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Logs = new Vector<GShopLog, GShopLogX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(DataMask); 
 ds.Write(CashTotal); 
 ds.Write(CashUsed); 
 ds.Write(CashSerial); 
 ds.Write(Inventory); 
 ds.Write(Storehouse); 
 ds.Write(Equipment); 
 ds.Write(Logs); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out DataMask)  &&
 ds.TryRead(out CashTotal)  &&
 ds.TryRead(out CashUsed)  &&
 ds.TryRead(out CashSerial)  &&
 ds.TryRead((IDataSerializer)Inventory)  &&
 ds.TryRead((IDataSerializer)Storehouse)  &&
 ds.TryRead((IDataSerializer)Equipment)  &&
 ds.TryRead((IDataSerializer)Logs) ;
        }
    }
      

    public class GMailBoxX : GMailBox
    {
        public GMailBoxX()
        {
             Timestamp = default(UInt32);
 Status = default(UInt32);
 Mails = new Vector<GMail, GMailX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Timestamp); 
 ds.Write(Status); 
 ds.Write(Mails); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)Mails) ;
        }
    }
      

    public class MailGoodsInventoryX : MailGoodsInventory
    {
        public MailGoodsInventoryX()
        {
             GoodsId = default(Int32);
 Count = default(Int32);
 ProcType = default(Int32);
 GoodsFlag = default(Int32);
 GoodsPrice = default(Int32);
 GoodsPriceBeforeDiscount = default(Int32);
 PayType = default(Int32);
 Reserved2 = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GoodsId); 
 ds.Write(Count); 
 ds.Write(ProcType); 
 ds.Write(GoodsFlag); 
 ds.Write(GoodsPrice); 
 ds.Write(GoodsPriceBeforeDiscount); 
 ds.Write(PayType); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GoodsId)  &&
 ds.TryRead(out Count)  &&
 ds.TryRead(out ProcType)  &&
 ds.TryRead(out GoodsFlag)  &&
 ds.TryRead(out GoodsPrice)  &&
 ds.TryRead(out GoodsPriceBeforeDiscount)  &&
 ds.TryRead(out PayType)  &&
 ds.TryRead((IDataSerializer)Reserved2) ;
        }
    }
      

    public class WebOrderItemDetailX : WebOrderItemDetail
    {
        public WebOrderItemDetailX()
        {
             UserID = default(Int32);
 RoleId = default(Int32);
 GoodsId = default(Int32);
 Count = default(Int32);
 ProcType = default(Int32);
 GoodsFlag = default(Int32);
 GoodsPrice = default(Int32);
 GoodsPriceBeforeDiscount = default(Int32);
 GoodsPayType = default(Int32);
 AttachMoney = default(UInt32);
 Timestamp = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(GoodsId); 
 ds.Write(Count); 
 ds.Write(ProcType); 
 ds.Write(GoodsFlag); 
 ds.Write(GoodsPrice); 
 ds.Write(GoodsPriceBeforeDiscount); 
 ds.Write(GoodsPayType); 
 ds.Write(AttachMoney); 
 ds.Write(Timestamp); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out GoodsId)  &&
 ds.TryRead(out Count)  &&
 ds.TryRead(out ProcType)  &&
 ds.TryRead(out GoodsFlag)  &&
 ds.TryRead(out GoodsPrice)  &&
 ds.TryRead(out GoodsPriceBeforeDiscount)  &&
 ds.TryRead(out GoodsPayType)  &&
 ds.TryRead(out AttachMoney)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3) ;
        }
    }
      

    public class DBSysMail3ArgX : DBSysMail3Arg
    {
        public DBSysMail3ArgX()
        {
             OrderId = default(Int64);
 UserID = default(Int32);
 RoleId = default(Int64);
 RoleName = new Octets(); 
 GoodsFlag = default(Int32);
 GoodsPrice = default(Int32);
 GoodsPriceBeforeDiscount = default(Int32);
 GoodsPayType = default(Int32);
 Mail = new GMailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(OrderId); 
 ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(RoleName); 
 ds.Write(GoodsFlag); 
 ds.Write(GoodsPrice); 
 ds.Write(GoodsPriceBeforeDiscount); 
 ds.Write(GoodsPayType); 
 ds.Write(Mail); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out OrderId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead(out GoodsFlag)  &&
 ds.TryRead(out GoodsPrice)  &&
 ds.TryRead(out GoodsPriceBeforeDiscount)  &&
 ds.TryRead(out GoodsPayType)  &&
 ds.TryRead((IDataSerializer)Mail) ;
        }
    }
      

    public class DBSysMail3ResX : DBSysMail3Res
    {
        public DBSysMail3ResX()
        {
             RetCode = default(Int32);
 MailId = default(Byte);
 RoleId = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(MailId); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out MailId)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class DBGetMailListResX : DBGetMailListRes
    {
        public DBGetMailListResX()
        {
             RetCode = default(Int32);
 MailList = new Vector<GMailHeader, GMailHeaderX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(MailList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)MailList) ;
        }
    }
      

    public class DBGetMailResX : DBGetMailRes
    {
        public DBGetMailResX()
        {
             RetCode = default(Byte);
 Mail = new GMailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Mail); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Mail) ;
        }
    }
      

    public class DBGetMailAttachArgX : DBGetMailAttachArg
    {
        public DBGetMailAttachArgX()
        {
             MailId = new GMailIDX(); 
 AttachType = default(Byte);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(MailId); 
 ds.Write(AttachType); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)MailId)  &&
 ds.TryRead(out AttachType)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBGetMailAttachResX : DBGetMailAttachRes
    {
        public DBGetMailAttachResX()
        {
             RetCode = default(Byte);
 MoneyLeft = default(UInt32);
 ItemLeft = default(UInt32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(MoneyLeft); 
 ds.Write(ItemLeft); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out MoneyLeft)  &&
 ds.TryRead(out ItemLeft)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBSetMailAttrArgX : DBSetMailAttrArg
    {
        public DBSetMailAttrArgX()
        {
             MailId = new GMailIDX(); 
 AttribType = default(Byte);
 AttribValue = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(MailId); 
 ds.Write(AttribType); 
 ds.Write(AttribValue); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)MailId)  &&
 ds.TryRead(out AttribType)  &&
 ds.TryRead(out AttribValue) ;
        }
    }
      

    public class DBSetMailAttrResX : DBSetMailAttrRes
    {
        public DBSetMailAttrResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBSendMailArgX : DBSendMailArg
    {
        public DBSendMailArgX()
        {
             Mail = new GMailX(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Mail); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Mail)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBSendMailResX : DBSendMailRes
    {
        public DBSendMailResX()
        {
             RetCode = default(Byte);
 MailId = default(Byte);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(MailId); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out MailId)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBDeleteMailArgX : DBDeleteMailArg
    {
        public DBDeleteMailArgX()
        {
             RoleId = default(Int32);
 MailId = new Octets(); 
 Reason = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(MailId); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)MailId)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class DBSendMassMailArgX : DBSendMassMailArg
    {
        public DBSendMassMailArgX()
        {
             MassType = default(Byte);
 Mail = new GMailX(); 
 CostObjId = default(Int32);
 CostObjNum = default(Int32);
 CostObjPos = default(Int32);
 CostMoney = default(UInt32);
 ReceiverList = new Vector<Int32>(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(MassType); 
 ds.Write(Mail); 
 ds.Write(CostObjId); 
 ds.Write(CostObjNum); 
 ds.Write(CostObjPos); 
 ds.Write(CostMoney); 
 ds.Write(ReceiverList); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out MassType)  &&
 ds.TryRead((IDataSerializer)Mail)  &&
 ds.TryRead(out CostObjId)  &&
 ds.TryRead(out CostObjNum)  &&
 ds.TryRead(out CostObjPos)  &&
 ds.TryRead(out CostMoney)  &&
 ds.TryRead((IDataSerializer)ReceiverList)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class MassMailResX : MassMailRes
    {
        public MassMailResX()
        {
             RoleId = default(Int32);
 MailId = default(Byte);
 RetCode = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(MailId); 
 ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out MailId)  &&
 ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBSendMassMailResX : DBSendMassMailRes
    {
        public DBSendMassMailResX()
        {
             RetCode = default(Byte);
 Result = new Vector<MassMailRes, MassMailResX>(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Result); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Result)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class GWebTradeItemX : GWebTradeItem
    {
        public GWebTradeItemX()
        {
             Sn = default(Int64);
 SellerroleId = default(Int32);
 SellerUserId = default(Int32);
 SellerName = new Octets(); 
 PostType = default(Int32);
 Money = default(UInt32);
 ItemId = default(UInt32);
 ItemCount = default(Int32);
 State = default(Int32);
 PostEndTime = default(Int32);
 ShowEndTime = default(Int32);
 Price = default(Int32);
 SellEndTime = default(Int32);
 BuyerroleId = default(Int32);
 BuyerUserId = default(Int32);
 BuyerName = new Octets(); 
 CommodityId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(SellerroleId); 
 ds.Write(SellerUserId); 
 ds.Write(SellerName); 
 ds.Write(PostType); 
 ds.Write(Money); 
 ds.Write(ItemId); 
 ds.Write(ItemCount); 
 ds.Write(State); 
 ds.Write(PostEndTime); 
 ds.Write(ShowEndTime); 
 ds.Write(Price); 
 ds.Write(SellEndTime); 
 ds.Write(BuyerroleId); 
 ds.Write(BuyerUserId); 
 ds.Write(BuyerName); 
 ds.Write(CommodityId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out SellerroleId)  &&
 ds.TryRead(out SellerUserId)  &&
 ds.TryRead((IDataSerializer)SellerName)  &&
 ds.TryRead(out PostType)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out State)  &&
 ds.TryRead(out PostEndTime)  &&
 ds.TryRead(out ShowEndTime)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out SellEndTime)  &&
 ds.TryRead(out BuyerroleId)  &&
 ds.TryRead(out BuyerUserId)  &&
 ds.TryRead((IDataSerializer)BuyerName)  &&
 ds.TryRead(out CommodityId) ;
        }
    }
      

    public class GWebTradeRoleBriefExtendX : GWebTradeRoleBriefExtend
    {
        public GWebTradeRoleBriefExtendX()
        {
             MeridianData = new Octets(); 
 CardLeadership = new Octets(); 
 FateRingData = new Octets(); 
 TitleData = new Octets(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
 Reserved6 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(MeridianData); 
 ds.Write(CardLeadership); 
 ds.Write(FateRingData); 
 ds.Write(TitleData); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
 ds.Write(Reserved6); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)MeridianData)  &&
 ds.TryRead((IDataSerializer)CardLeadership)  &&
 ds.TryRead((IDataSerializer)FateRingData)  &&
 ds.TryRead((IDataSerializer)TitleData)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5)  &&
 ds.TryRead(out Reserved6) ;
        }
    }
      

    public class GWebTradeRoleBriefX : GWebTradeRoleBrief
    {
        public GWebTradeRoleBriefX()
        {
             Cls = default(Int32);
 Gender = default(Byte);
 Level = default(Int32);
 Level2 = default(Int32);
 Exp = default(Int32);
 Sp = default(Int32);
 Pp = default(Int32);
 Reputation = default(Int32);
 Petcorral = new Octets(); 
 Property = new Octets(); 
 Skills = new Octets(); 
 Inventory = new GRolePocketX(); 
 Equipment = new GRoleEquipmentX(); 
 Storehouse = new GRoleStorehouseX(); 
 ForceData = new Octets(); 
 ReincarnationData = new Octets(); 
 RealmData = new Octets(); 
 ExtendData = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Cls); 
 ds.Write(Gender); 
 ds.Write(Level); 
 ds.Write(Level2); 
 ds.Write(Exp); 
 ds.Write(Sp); 
 ds.Write(Pp); 
 ds.Write(Reputation); 
 ds.Write(Petcorral); 
 ds.Write(Property); 
 ds.Write(Skills); 
 ds.Write(Inventory); 
 ds.Write(Equipment); 
 ds.Write(Storehouse); 
 ds.Write(ForceData); 
 ds.Write(ReincarnationData); 
 ds.Write(RealmData); 
 ds.Write(ExtendData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Cls)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Level2)  &&
 ds.TryRead(out Exp)  &&
 ds.TryRead(out Sp)  &&
 ds.TryRead(out Pp)  &&
 ds.TryRead(out Reputation)  &&
 ds.TryRead((IDataSerializer)Petcorral)  &&
 ds.TryRead((IDataSerializer)Property)  &&
 ds.TryRead((IDataSerializer)Skills)  &&
 ds.TryRead((IDataSerializer)Inventory)  &&
 ds.TryRead((IDataSerializer)Equipment)  &&
 ds.TryRead((IDataSerializer)Storehouse)  &&
 ds.TryRead((IDataSerializer)ForceData)  &&
 ds.TryRead((IDataSerializer)ReincarnationData)  &&
 ds.TryRead((IDataSerializer)RealmData)  &&
 ds.TryRead((IDataSerializer)ExtendData) ;
        }
    }
      

    public class GWebTradeDetailX : GWebTradeDetail
    {
        public GWebTradeDetailX()
        {
             Info = new GWebTradeItemX(); 
 Item = new GRoleInventoryX(); 
 PostTime = default(Int64);
 Deposit = default(UInt32);
 Loginip = default(Int32);
 Rolebrief = new Octets(); 
 Reserved10 = default(Byte);
 Reserved11 = default(Int16);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Info); 
 ds.Write(Item); 
 ds.Write(PostTime); 
 ds.Write(Deposit); 
 ds.Write(Loginip); 
 ds.Write(Rolebrief); 
 ds.Write(Reserved10); 
 ds.Write(Reserved11); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead((IDataSerializer)Item)  &&
 ds.TryRead(out PostTime)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead((IDataSerializer)Rolebrief)  &&
 ds.TryRead(out Reserved10)  &&
 ds.TryRead(out Reserved11)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5) ;
        }
    }
      

    public class DBWebTradeLoadArgX : DBWebTradeLoadArg
    {
        public DBWebTradeLoadArgX()
        {
             Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBWebTradeLoadResX : DBWebTradeLoadRes
    {
        public DBWebTradeLoadResX()
        {
             RetCode = default(Int32);
 MaxSn = default(Int64);
 Items = new Vector<GWebTradeDetail, GWebTradeDetailX>(); 
 Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(MaxSn); 
 ds.Write(Items); 
 ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out MaxSn)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBWebTradePrePostArgX : DBWebTradePrePostArg
    {
        public DBWebTradePrePostArgX()
        {
             Sn = default(Int64);
 RoleId = default(Int32);
 UserID = default(Int32);
 Name = new Octets(); 
 PostType = default(Int32);
 Money = default(UInt32);
 ItemId = default(UInt32);
 ItemPos = default(Int32);
 ItemNumber = default(Int32);
 Price = default(Int32);
 SellPeriod = default(Int32);
 BuyerroleId = default(Int32);
 PostTime = default(Int64);
 State = default(Int32);
 Deposit = default(UInt32);
 Loginip = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(Name); 
 ds.Write(PostType); 
 ds.Write(Money); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemNumber); 
 ds.Write(Price); 
 ds.Write(SellPeriod); 
 ds.Write(BuyerroleId); 
 ds.Write(PostTime); 
 ds.Write(State); 
 ds.Write(Deposit); 
 ds.Write(Loginip); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out PostType)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out SellPeriod)  &&
 ds.TryRead(out BuyerroleId)  &&
 ds.TryRead(out PostTime)  &&
 ds.TryRead(out State)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out Loginip)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBWebTradePrePostResX : DBWebTradePrePostRes
    {
        public DBWebTradePrePostResX()
        {
             RetCode = default(Int32);
 BuyerUserId = default(Int32);
 BuyerName = new Octets(); 
 Name = new Octets(); 
 Rolebrief = new Octets(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(BuyerUserId); 
 ds.Write(BuyerName); 
 ds.Write(Name); 
 ds.Write(Rolebrief); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out BuyerUserId)  &&
 ds.TryRead((IDataSerializer)BuyerName)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)Rolebrief)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBWebTradePreCancelPostArgX : DBWebTradePreCancelPostArg
    {
        public DBWebTradePreCancelPostArgX()
        {
             Sn = default(Int64);
 RoleId = default(Int32);
 State = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(RoleId); 
 ds.Write(State); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out State) ;
        }
    }
      

    public class DBWebTradePreCancelPostResX : DBWebTradePreCancelPostRes
    {
        public DBWebTradePreCancelPostResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBWebTradePostArgX : DBWebTradePostArg
    {
        public DBWebTradePostArgX()
        {
             Sn = default(Int64);
 RoleId = default(Int32);
 State = default(Int32);
 PostEndTime = default(Int32);
 ShowEndTime = default(Int32);
 SellEndTime = default(Int32);
 CommodityId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(RoleId); 
 ds.Write(State); 
 ds.Write(PostEndTime); 
 ds.Write(ShowEndTime); 
 ds.Write(SellEndTime); 
 ds.Write(CommodityId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out State)  &&
 ds.TryRead(out PostEndTime)  &&
 ds.TryRead(out ShowEndTime)  &&
 ds.TryRead(out SellEndTime)  &&
 ds.TryRead(out CommodityId) ;
        }
    }
      

    public class DBWebTradePostResX : DBWebTradePostRes
    {
        public DBWebTradePostResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBWebTradeCancelPostArgX : DBWebTradeCancelPostArg
    {
        public DBWebTradeCancelPostArgX()
        {
             Sn = default(Int64);
 RoleId = default(Int32);
 Reason = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(RoleId); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class DBWebTradeCancelPostResX : DBWebTradeCancelPostRes
    {
        public DBWebTradeCancelPostResX()
        {
             RetCode = default(Int32);
 InformSeller = new GMailHeaderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(InformSeller); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)InformSeller) ;
        }
    }
      

    public class DBWebTradeShelfArgX : DBWebTradeShelfArg
    {
        public DBWebTradeShelfArgX()
        {
             Sn = default(Int64);
 RoleId = default(Int32);
 State = default(Int32);
 ShowEndTime = default(Int32);
 Price = default(Int32);
 SellEndTime = default(Int32);
 BuyerroleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(RoleId); 
 ds.Write(State); 
 ds.Write(ShowEndTime); 
 ds.Write(Price); 
 ds.Write(SellEndTime); 
 ds.Write(BuyerroleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out State)  &&
 ds.TryRead(out ShowEndTime)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out SellEndTime)  &&
 ds.TryRead(out BuyerroleId) ;
        }
    }
      

    public class DBWebTradeShelfResX : DBWebTradeShelfRes
    {
        public DBWebTradeShelfResX()
        {
             RetCode = default(Int32);
 BuyerUserId = default(Int32);
 BuyerName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(BuyerUserId); 
 ds.Write(BuyerName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out BuyerUserId)  &&
 ds.TryRead((IDataSerializer)BuyerName) ;
        }
    }
      

    public class DBWebTradeCancelShelfArgX : DBWebTradeCancelShelfArg
    {
        public DBWebTradeCancelShelfArgX()
        {
             Sn = default(Int64);
 RoleId = default(Int32);
 State = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(RoleId); 
 ds.Write(State); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out State) ;
        }
    }
      

    public class DBWebTradeCancelShelfResX : DBWebTradeCancelShelfRes
    {
        public DBWebTradeCancelShelfResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBWebTradeSoldArgX : DBWebTradeSoldArg
    {
        public DBWebTradeSoldArgX()
        {
             Sn = default(Int64);
 RoleId = default(Int32);
 BuyerroleId = default(Int32);
 BuyerUserId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(RoleId); 
 ds.Write(BuyerroleId); 
 ds.Write(BuyerUserId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out BuyerroleId)  &&
 ds.TryRead(out BuyerUserId) ;
        }
    }
      

    public class DBWebTradeSoldResX : DBWebTradeSoldRes
    {
        public DBWebTradeSoldResX()
        {
             RetCode = default(Int32);
 InformSeller = new GMailHeaderX(); 
 InformBuyer = new GMailHeaderX(); 
 BuyerroleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(InformSeller); 
 ds.Write(InformBuyer); 
 ds.Write(BuyerroleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)InformSeller)  &&
 ds.TryRead((IDataSerializer)InformBuyer)  &&
 ds.TryRead(out BuyerroleId) ;
        }
    }
      

    public class DBWebTradePostExpireArgX : DBWebTradePostExpireArg
    {
        public DBWebTradePostExpireArgX()
        {
             Sn = default(Int64);
 RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sn); 
 ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sn)  &&
 ds.TryRead(out RoleId) ;
        }
    }
      

    public class DBWebTradePostExpireResX : DBWebTradePostExpireRes
    {
        public DBWebTradePostExpireResX()
        {
             RetCode = default(Int32);
 InformSeller = new GMailHeaderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(InformSeller); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)InformSeller) ;
        }
    }
      

    public class RoleSimpleInfoX : RoleSimpleInfo
    {
        public RoleSimpleInfoX()
        {
             RoleId = default(Int64);
 Level = default(Int32);
 Race = default(Int32);
 Gender = default(Int32);
 Name = new Octets(); 
 ReincarnationTimes = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Level); 
 ds.Write(Race); 
 ds.Write(Gender); 
 ds.Write(Name); 
 ds.Write(ReincarnationTimes); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Race)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out ReincarnationTimes) ;
        }
    }
      

    public class DBWebTradeGetRoleSimpleInfoArgX : DBWebTradeGetRoleSimpleInfoArg
    {
        public DBWebTradeGetRoleSimpleInfoArgX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class DBWebTradeGetRoleSimpleInfoResX : DBWebTradeGetRoleSimpleInfoRes
    {
        public DBWebTradeGetRoleSimpleInfoResX()
        {
             RetCode = default(Int32);
 Roles = new Vector<RoleSimpleInfo, RoleSimpleInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Roles); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Roles) ;
        }
    }
      

    public class DBWebTradeLoadSoldArgX : DBWebTradeLoadSoldArg
    {
        public DBWebTradeLoadSoldArgX()
        {
             Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBWebTradeLoadSoldResX : DBWebTradeLoadSoldRes
    {
        public DBWebTradeLoadSoldResX()
        {
             RetCode = default(Int32);
 SnList = new Vector<Int64>(); 
 Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SnList); 
 ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)SnList)  &&
 ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class TraderInfoX : TraderInfo
    {
        public TraderInfoX()
        {
             UserID = default(Int32);
 RoleId = default(Int64);
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class PostInfoX : PostInfo
    {
        public PostInfoX()
        {
             Detail = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Detail); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Detail) ;
        }
    }
      

    public class TimeInfoX : TimeInfo
    {
        public TimeInfoX()
        {
             ActionTime = default(Int64);
 ShowPeriod = default(Int32);
 SellPeriod = default(Int32);
 PostPeriod = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ActionTime); 
 ds.Write(ShowPeriod); 
 ds.Write(SellPeriod); 
 ds.Write(PostPeriod); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ActionTime)  &&
 ds.TryRead(out ShowPeriod)  &&
 ds.TryRead(out SellPeriod)  &&
 ds.TryRead(out PostPeriod) ;
        }
    }
      

    public class WebRoleX : WebRole
    {
        public WebRoleX()
        {
             Info = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Info); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Info) ;
        }
    }
      

    public class GSysAuctionItemX : GSysAuctionItem
    {
        public GSysAuctionItemX()
        {
             SaId = default(UInt32);
 ItemId = default(UInt32);
 ItemCount = default(Int32);
 BasePrice = default(UInt32);
 State = default(Int32);
 AuctionStartTime = default(Int32);
 AuctionEndTime = default(Int32);
 BidPrice = default(UInt32);
 BidTime = default(Int32);
 BidFreezeTime = default(Int32);
 BidderRoleId = default(Int32);
 BidderUseRId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(SaId); 
 ds.Write(ItemId); 
 ds.Write(ItemCount); 
 ds.Write(BasePrice); 
 ds.Write(State); 
 ds.Write(AuctionStartTime); 
 ds.Write(AuctionEndTime); 
 ds.Write(BidPrice); 
 ds.Write(BidTime); 
 ds.Write(BidFreezeTime); 
 ds.Write(BidderRoleId); 
 ds.Write(BidderUseRId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out SaId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out BasePrice)  &&
 ds.TryRead(out State)  &&
 ds.TryRead(out AuctionStartTime)  &&
 ds.TryRead(out AuctionEndTime)  &&
 ds.TryRead(out BidPrice)  &&
 ds.TryRead(out BidTime)  &&
 ds.TryRead(out BidFreezeTime)  &&
 ds.TryRead(out BidderRoleId)  &&
 ds.TryRead(out BidderUseRId) ;
        }
    }
      

    public class GSysAuctionDetailX : GSysAuctionDetail
    {
        public GSysAuctionDetailX()
        {
             Info = new GSysAuctionItemX(); 
 Item = new GRoleInventoryX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Info); 
 ds.Write(Item); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead((IDataSerializer)Item) ;
        }
    }
      

    public class GSysAuctionCashX : GSysAuctionCash
    {
        public GSysAuctionCashX()
        {
             Cash2 = default(UInt32);
 CashUsed2 = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Cash2); 
 ds.Write(CashUsed2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Cash2)  &&
 ds.TryRead(out CashUsed2) ;
        }
    }
      

    public class DBSysAuctionCashTransferArgX : DBSysAuctionCashTransferArg
    {
        public DBSysAuctionCashTransferArgX()
        {
             UserID = default(Int32);
 RoleId = default(Int32);
 WithDraw = default(Byte);
 CashTransfer = default(UInt32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(WithDraw); 
 ds.Write(CashTransfer); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out WithDraw)  &&
 ds.TryRead(out CashTransfer)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBSysAuctionCashTransferResX : DBSysAuctionCashTransferRes
    {
        public DBSysAuctionCashTransferResX()
        {
             RetCode = default(Int32);
 Cash = default(UInt32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cash); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBSysAuctionCashSpendArgX : DBSysAuctionCashSpendArg
    {
        public DBSysAuctionCashSpendArgX()
        {
             UserID = default(Int32);
 RoleId = default(Int32);
 CashSpend = default(UInt32);
 SaId = default(UInt32);
 Item = new GRoleInventoryX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(CashSpend); 
 ds.Write(SaId); 
 ds.Write(Item); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out CashSpend)  &&
 ds.TryRead(out SaId)  &&
 ds.TryRead((IDataSerializer)Item) ;
        }
    }
      

    public class DBSysAuctionCashSpendResX : DBSysAuctionCashSpendRes
    {
        public DBSysAuctionCashSpendResX()
        {
             RetCode = default(Int32);
 Cash = default(UInt32);
 CashUsed = default(UInt32);
 InformBidder = new GMailHeaderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cash); 
 ds.Write(CashUsed); 
 ds.Write(InformBidder); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out CashUsed)  &&
 ds.TryRead((IDataSerializer)InformBidder) ;
        }
    }
      

    public class SysAuctionPrepareItemArgX : SysAuctionPrepareItemArg
    {
        public SysAuctionPrepareItemArgX()
        {
             Indexes = new Vector<Int32>(); 
 ItemIds = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Indexes); 
 ds.Write(ItemIds); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Indexes)  &&
 ds.TryRead((IDataSerializer)ItemIds) ;
        }
    }
      

    public class SysAuctionPrepareItemResX : SysAuctionPrepareItemRes
    {
        public SysAuctionPrepareItemResX()
        {
             Indexes = new Vector<Int32>(); 
 Items = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Indexes); 
 ds.Write(Items); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Indexes)  &&
 ds.TryRead((IDataSerializer)Items) ;
        }
    }
      

    public class GFactionFortressInfoX : GFactionFortressInfo
    {
        public GFactionFortressInfoX()
        {
             Level = default(Int32);
 Exp = default(Int32);
 ExpToday = default(Int32);
 ExpTodayTime = default(Int32);
 TechPoint = default(Int32);
 Technology = new Octets(); 
 Material = new Octets(); 
 Building = new Octets(); 
 CommonValue = new Octets(); 
 ActivedSpawner = new Octets(); 
 Reserved11 = default(Byte);
 Reserved12 = default(Int16);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Level); 
 ds.Write(Exp); 
 ds.Write(ExpToday); 
 ds.Write(ExpTodayTime); 
 ds.Write(TechPoint); 
 ds.Write(Technology); 
 ds.Write(Material); 
 ds.Write(Building); 
 ds.Write(CommonValue); 
 ds.Write(ActivedSpawner); 
 ds.Write(Reserved11); 
 ds.Write(Reserved12); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Level)  &&
 ds.TryRead(out Exp)  &&
 ds.TryRead(out ExpToday)  &&
 ds.TryRead(out ExpTodayTime)  &&
 ds.TryRead(out TechPoint)  &&
 ds.TryRead((IDataSerializer)Technology)  &&
 ds.TryRead((IDataSerializer)Material)  &&
 ds.TryRead((IDataSerializer)Building)  &&
 ds.TryRead((IDataSerializer)CommonValue)  &&
 ds.TryRead((IDataSerializer)ActivedSpawner)  &&
 ds.TryRead(out Reserved11)  &&
 ds.TryRead(out Reserved12)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3) ;
        }
    }
      

    public class GFactionFortressInfo2X : GFactionFortressInfo2
    {
        public GFactionFortressInfo2X()
        {
             Health = default(Int32);
 OffenseFaction = default(Int32);
 OffenseStartTime = default(Int32);
 OffenseEndTime = default(Int32);
 ChallengeList = new Vector<Int32>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Health); 
 ds.Write(OffenseFaction); 
 ds.Write(OffenseStartTime); 
 ds.Write(OffenseEndTime); 
 ds.Write(ChallengeList); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Health)  &&
 ds.TryRead(out OffenseFaction)  &&
 ds.TryRead(out OffenseStartTime)  &&
 ds.TryRead(out OffenseEndTime)  &&
 ds.TryRead((IDataSerializer)ChallengeList)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3) ;
        }
    }
      

    public class GFactionFortressDetailX : GFactionFortressDetail
    {
        public GFactionFortressDetailX()
        {
             FactionId = default(Int32);
 Info = new GFactionFortressInfoX(); 
 Info2 = new GFactionFortressInfo2X(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(Info); 
 ds.Write(Info2); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead((IDataSerializer)Info2)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5) ;
        }
    }
      

    public class GFactionFortressBriefInfoX : GFactionFortressBriefInfo
    {
        public GFactionFortressBriefInfoX()
        {
             FactionId = default(Int32);
 Level = default(Int32);
 Building = new Octets(); 
 Health = default(Int32);
 OffenseFaction = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(Level); 
 ds.Write(Building); 
 ds.Write(Health); 
 ds.Write(OffenseFaction); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead((IDataSerializer)Building)  &&
 ds.TryRead(out Health)  &&
 ds.TryRead(out OffenseFaction) ;
        }
    }
      

    public class GFactionFortressBattleInfoX : GFactionFortressBattleInfo
    {
        public GFactionFortressBattleInfoX()
        {
             FactionId = default(Int32);
 OffenseFaction = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(OffenseFaction); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead(out OffenseFaction) ;
        }
    }
      

    public class DBFactionFortressLoadArgX : DBFactionFortressLoadArg
    {
        public DBFactionFortressLoadArgX()
        {
             Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBFactionFortressLoadResX : DBFactionFortressLoadRes
    {
        public DBFactionFortressLoadResX()
        {
             RetCode = default(Int32);
 List = new Vector<GFactionFortressDetail, GFactionFortressDetailX>(); 
 Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(List); 
 ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)List)  &&
 ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBPutFactionFortressArgX : DBPutFactionFortressArg
    {
        public DBPutFactionFortressArgX()
        {
             Detail = new GFactionFortressDetailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Detail); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Detail) ;
        }
    }
      

    public class DBPutFactionFortressResX : DBPutFactionFortressRes
    {
        public DBPutFactionFortressResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBDelFactionFortressArgX : DBDelFactionFortressArg
    {
        public DBDelFactionFortressArgX()
        {
             FactionId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId) ;
        }
    }
      

    public class DBDelFactionFortressResX : DBDelFactionFortressRes
    {
        public DBDelFactionFortressResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class GetFactionFortressArgX : GetFactionFortressArg
    {
        public GetFactionFortressArgX()
        {
             FactionId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId) ;
        }
    }
      

    public class GetFactionFortressResX : GetFactionFortressRes
    {
        public GetFactionFortressResX()
        {
             RetCode = default(Int32);
 Detail = new GFactionFortressDetailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Detail); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Detail) ;
        }
    }
      

    public class PutFactionFortressArgX : PutFactionFortressArg
    {
        public PutFactionFortressArgX()
        {
             FactionId = default(Int32);
 Info = new GFactionFortressInfoX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(Info); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead((IDataSerializer)Info) ;
        }
    }
      

    public class PutFactionFortressResX : PutFactionFortressRes
    {
        public PutFactionFortressResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBCreateFactionFortressArgX : DBCreateFactionFortressArg
    {
        public DBCreateFactionFortressArgX()
        {
             RoleId = default(Int32);
 ItemCost = new Octets(); 
 Detail = new GFactionFortressDetailX(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemCost); 
 ds.Write(Detail); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)ItemCost)  &&
 ds.TryRead((IDataSerializer)Detail)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBCreateFactionFortressResX : DBCreateFactionFortressRes
    {
        public DBCreateFactionFortressResX()
        {
             RetCode = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBFactionFortressChallengeArgX : DBFactionFortressChallengeArg
    {
        public DBFactionFortressChallengeArgX()
        {
             RoleId = default(Int32);
 FactionId = default(Int32);
 TargetFactionId = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(FactionId); 
 ds.Write(TargetFactionId); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out TargetFactionId)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBFactionFortressChallengeResX : DBFactionFortressChallengeRes
    {
        public DBFactionFortressChallengeResX()
        {
             RetCode = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class AuctionIdX : AuctionId
    {
        public AuctionIdX()
        {
             Id = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id) ;
        }
    }
      

    public class GAuctionItemX : GAuctionItem
    {
        public GAuctionItemX()
        {
             AuctionId = default(UInt32);
 BidPrice = default(UInt32);
 BinPrice = default(UInt32);
 EndTime = default(UInt32);
 ItemId = default(UInt32);
 Count = default(UInt16);
 Seller = default(UInt32);
 Bidder = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(AuctionId); 
 ds.Write(BidPrice); 
 ds.Write(BinPrice); 
 ds.Write(EndTime); 
 ds.Write(ItemId); 
 ds.Write(Count); 
 ds.Write(Seller); 
 ds.Write(Bidder); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out AuctionId)  &&
 ds.TryRead(out BidPrice)  &&
 ds.TryRead(out BinPrice)  &&
 ds.TryRead(out EndTime)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out Count)  &&
 ds.TryRead(out Seller)  &&
 ds.TryRead(out Bidder) ;
        }
    }
      

    public class GAuctionDetailX : GAuctionDetail
    {
        public GAuctionDetailX()
        {
             Info = new GAuctionItemX(); 
 Category = default(UInt16);
 BasePrice = default(UInt32);
 Deposit = default(UInt32);
 ElapseTime = default(Int32);
 Prolong = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Item = new GRoleInventoryX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Info); 
 ds.Write(Category); 
 ds.Write(BasePrice); 
 ds.Write(Deposit); 
 ds.Write(ElapseTime); 
 ds.Write(Prolong); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Item); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead(out Category)  &&
 ds.TryRead(out BasePrice)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out ElapseTime)  &&
 ds.TryRead(out Prolong)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead((IDataSerializer)Item) ;
        }
    }
      

    public class DBAuctionOpenArgX : DBAuctionOpenArg
    {
        public DBAuctionOpenArgX()
        {
             RoleId = default(Int32);
 AuctionId = default(UInt32);
 Category = default(UInt16);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemNumber = default(Int32);
 BasePrice = default(UInt32);
 BinPrice = default(UInt32);
 ElapseTime = default(Int32);
 EndTime = default(Int32);
 Deposit = default(UInt32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(AuctionId); 
 ds.Write(Category); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemNumber); 
 ds.Write(BasePrice); 
 ds.Write(BinPrice); 
 ds.Write(ElapseTime); 
 ds.Write(EndTime); 
 ds.Write(Deposit); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead(out Category)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead(out BasePrice)  &&
 ds.TryRead(out BinPrice)  &&
 ds.TryRead(out ElapseTime)  &&
 ds.TryRead(out EndTime)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBAuctionOpenResX : DBAuctionOpenRes
    {
        public DBAuctionOpenResX()
        {
             RetCode = default(Byte);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBAuctionBidArgX : DBAuctionBidArg
    {
        public DBAuctionBidArgX()
        {
             RoleId = default(Int32);
 AuctionId = default(UInt32);
 BidPrice = default(UInt32);
 Bin = default(Byte);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(AuctionId); 
 ds.Write(BidPrice); 
 ds.Write(Bin); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead(out BidPrice)  &&
 ds.TryRead(out Bin)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBAuctionBidResX : DBAuctionBidRes
    {
        public DBAuctionBidResX()
        {
             RetCode = default(Byte);
 BidPrice = default(UInt32);
 InformSeller = new GMailHeaderX(); 
 InformLoser = new GMailHeaderX(); 
 InformWinner = new GMailHeaderX(); 
 ExtendTime = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(BidPrice); 
 ds.Write(InformSeller); 
 ds.Write(InformLoser); 
 ds.Write(InformWinner); 
 ds.Write(ExtendTime); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out BidPrice)  &&
 ds.TryRead((IDataSerializer)InformSeller)  &&
 ds.TryRead((IDataSerializer)InformLoser)  &&
 ds.TryRead((IDataSerializer)InformWinner)  &&
 ds.TryRead(out ExtendTime)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class GAuctionListX : GAuctionList
    {
        public GAuctionListX()
        {
             Category = default(UInt16);
 List = new Vector<GAuctionDetail, GAuctionDetailX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Category); 
 ds.Write(List); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Category)  &&
 ds.TryRead((IDataSerializer)List) ;
        }
    }
      

    public class GAuctionIndexX : GAuctionIndex
    {
        public GAuctionIndexX()
        {
             Category = new Octets(); 
 Index = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Category); 
 ds.Write(Index); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Category)  &&
 ds.TryRead(out Index) ;
        }
    }
      

    public class DBAuctionListArgX : DBAuctionListArg
    {
        public DBAuctionListArgX()
        {
             Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBAuctionListResX : DBAuctionListRes
    {
        public DBAuctionListResX()
        {
             RetCode = default(Int16);
 Items = new Vector<GAuctionDetail, GAuctionDetailX>(); 
 Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Items); 
 ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBAuctionGetArgX : DBAuctionGetArg
    {
        public DBAuctionGetArgX()
        {
             AuctionId = default(UInt32);
 Reason = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(AuctionId); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out AuctionId)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class DBAuctionGetResX : DBAuctionGetRes
    {
        public DBAuctionGetResX()
        {
             RetCode = default(Byte);
 Item = new GAuctionDetailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Item); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Item) ;
        }
    }
      

    public class DBAuctionTimeoutResX : DBAuctionTimeoutRes
    {
        public DBAuctionTimeoutResX()
        {
             RetCode = default(Byte);
 AuctionId = default(UInt32);
 InformSeller = new GMailHeaderX(); 
 InformBidder = new GMailHeaderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(AuctionId); 
 ds.Write(InformSeller); 
 ds.Write(InformBidder); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out AuctionId)  &&
 ds.TryRead((IDataSerializer)InformSeller)  &&
 ds.TryRead((IDataSerializer)InformBidder) ;
        }
    }
      

    public class DBAuctionCloseArgX : DBAuctionCloseArg
    {
        public DBAuctionCloseArgX()
        {
             RoleId = default(Int32);
 Reason = default(Byte);
 AuctionId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Reason); 
 ds.Write(AuctionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Reason)  &&
 ds.TryRead(out AuctionId) ;
        }
    }
      

    public class DBAuctionCloseResX : DBAuctionCloseRes
    {
        public DBAuctionCloseResX()
        {
             RetCode = default(Byte);
 InformSeller = new GMailHeaderX(); 
 InformBidder = new GMailHeaderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(InformSeller); 
 ds.Write(InformBidder); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)InformSeller)  &&
 ds.TryRead((IDataSerializer)InformBidder) ;
        }
    }
      

    public class GChallengerInfoListX : GChallengerInfoList
    {
        public GChallengerInfoListX()
        {
             ChallengerList = new Vector<GChallengerInfo, GChallengerInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ChallengerList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)ChallengerList) ;
        }
    }
      

    public class GChallengerInfoX : GChallengerInfo
    {
        public GChallengerInfoX()
        {
             Faction = default(UInt32);
 Time = default(Int32);
 Deposit = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Faction); 
 ds.Write(Time); 
 ds.Write(Deposit); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Faction)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead(out Deposit) ;
        }
    }
      

    public class GTerritoryDetailX : GTerritoryDetail
    {
        public GTerritoryDetailX()
        {
             Id = default(Int16);
 Level = default(Int16);
 Owner = default(UInt32);
 OccupyTime = default(Int32);
 Challenger = default(UInt32);
 Deposit = default(UInt32);
 CutffTime = default(Int32);
 BattleTime = default(Int32);
 BonusTime = default(Int32);
 Color = default(Int32);
 Status = default(Int32);
 Timeout = default(Int32);
 Maxbonus = default(Int32);
 ChallengeTime = default(Int32);
 Challengerdetails = new Octets(); 
 Reserved1 = default(Byte);
 Reserved2 = default(Byte);
 Reserved3 = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Level); 
 ds.Write(Owner); 
 ds.Write(OccupyTime); 
 ds.Write(Challenger); 
 ds.Write(Deposit); 
 ds.Write(CutffTime); 
 ds.Write(BattleTime); 
 ds.Write(BonusTime); 
 ds.Write(Color); 
 ds.Write(Status); 
 ds.Write(Timeout); 
 ds.Write(Maxbonus); 
 ds.Write(ChallengeTime); 
 ds.Write(Challengerdetails); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Owner)  &&
 ds.TryRead(out OccupyTime)  &&
 ds.TryRead(out Challenger)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out CutffTime)  &&
 ds.TryRead(out BattleTime)  &&
 ds.TryRead(out BonusTime)  &&
 ds.TryRead(out Color)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out Timeout)  &&
 ds.TryRead(out Maxbonus)  &&
 ds.TryRead(out ChallengeTime)  &&
 ds.TryRead((IDataSerializer)Challengerdetails)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3) ;
        }
    }
      

    public class GTerritoryStoreX : GTerritoryStore
    {
        public GTerritoryStoreX()
        {
             Cities = new Vector<GTerritoryDetail, GTerritoryDetailX>(); 
 Status = default(Int32);
 SpecialTime = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Cities); 
 ds.Write(Status); 
 ds.Write(SpecialTime); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Cities)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out SpecialTime)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4) ;
        }
    }
      

    public class GTerritoryX : GTerritory
    {
        public GTerritoryX()
        {
             Id = default(Byte);
 Level = default(Byte);
 Color = default(Byte);
 Owner = default(UInt32);
 Challenger = default(UInt32);
 BattleTime = default(UInt32);
 Deposit = default(Int32);
 Maxbonus = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Level); 
 ds.Write(Color); 
 ds.Write(Owner); 
 ds.Write(Challenger); 
 ds.Write(BattleTime); 
 ds.Write(Deposit); 
 ds.Write(Maxbonus); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Color)  &&
 ds.TryRead(out Owner)  &&
 ds.TryRead(out Challenger)  &&
 ds.TryRead(out BattleTime)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out Maxbonus) ;
        }
    }
      

    public class GCityX : GCity
    {
        public GCityX()
        {
             Id = default(Byte);
 Level = default(Byte);
 Owner = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Level); 
 ds.Write(Owner); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Owner) ;
        }
    }
      

    public class GBattleChallengeX : GBattleChallenge
    {
        public GBattleChallengeX()
        {
             Id = default(Int16);
 Challenger = default(UInt32);
 Deposit = default(UInt32);
 Maxbonus = default(UInt32);
 CutffTime = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Challenger); 
 ds.Write(Deposit); 
 ds.Write(Maxbonus); 
 ds.Write(CutffTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out Challenger)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out Maxbonus)  &&
 ds.TryRead(out CutffTime) ;
        }
    }
      

    public class BattleEndArgX : BattleEndArg
    {
        public BattleEndArgX()
        {
             BattleId = default(Int32);
 Result = default(Int32);
 Defender = default(UInt32);
 Attacker = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(Result); 
 ds.Write(Defender); 
 ds.Write(Attacker); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out Result)  &&
 ds.TryRead(out Defender)  &&
 ds.TryRead(out Attacker) ;
        }
    }
      

    public class BattleEndResX : BattleEndRes
    {
        public BattleEndResX()
        {
             RetCode = default(Int16);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBBattleLoadArgX : DBBattleLoadArg
    {
        public DBBattleLoadArgX()
        {
             Data = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Data) ;
        }
    }
      

    public class DBBattleLoadResX : DBBattleLoadRes
    {
        public DBBattleLoadResX()
        {
             RetCode = default(Int16);
 Cities = new Vector<GTerritoryDetail, GTerritoryDetailX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cities); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Cities) ;
        }
    }
      

    public class DBBattleSetArgX : DBBattleSetArg
    {
        public DBBattleSetArgX()
        {
             Reason = default(Int16);
 Cities = new Vector<GTerritoryDetail, GTerritoryDetailX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Reason); 
 ds.Write(Cities); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Reason)  &&
 ds.TryRead((IDataSerializer)Cities) ;
        }
    }
      

    public class DBBattleSetResX : DBBattleSetRes
    {
        public DBBattleSetResX()
        {
             RetCode = default(Int16);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBBattleChallengeArgX : DBBattleChallengeArg
    {
        public DBBattleChallengeArgX()
        {
             RoleId = default(Int32);
 CityId = default(Int16);
 FactionId = default(Int32);
 Deposit = default(UInt32);
 Maxbonus = default(UInt32);
 ChallengeTime = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CityId); 
 ds.Write(FactionId); 
 ds.Write(Deposit); 
 ds.Write(Maxbonus); 
 ds.Write(ChallengeTime); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out CityId)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out Maxbonus)  &&
 ds.TryRead(out ChallengeTime)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBBattleChallengeResX : DBBattleChallengeRes
    {
        public DBBattleChallengeResX()
        {
             RetCode = default(Int16);
 ChallengeRes = default(Int32);
 Deposit = default(UInt32);
 InformLoser = new GMailHeaderX(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(ChallengeRes); 
 ds.Write(Deposit); 
 ds.Write(InformLoser); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out ChallengeRes)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead((IDataSerializer)InformLoser)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBBattleEndArgX : DBBattleEndArg
    {
        public DBBattleEndArgX()
        {
             BattleId = default(Int32);
 Result = default(Int32);
 Color = default(Int32);
 Defender = default(UInt32);
 Attacker = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BattleId); 
 ds.Write(Result); 
 ds.Write(Color); 
 ds.Write(Defender); 
 ds.Write(Attacker); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BattleId)  &&
 ds.TryRead(out Result)  &&
 ds.TryRead(out Color)  &&
 ds.TryRead(out Defender)  &&
 ds.TryRead(out Attacker) ;
        }
    }
      

    public class DBBattleEndResX : DBBattleEndRes
    {
        public DBBattleEndResX()
        {
             RetCode = default(Int16);
 InformWinner = new GMailHeaderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(InformWinner); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)InformWinner) ;
        }
    }
      

    public class DBBattleMailArgX : DBBattleMailArg
    {
        public DBBattleMailArgX()
        {
             FactionId = default(UInt32);
 Mail = new GMailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(Mail); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead((IDataSerializer)Mail) ;
        }
    }
      

    public class DBBattleMailResX : DBBattleMailRes
    {
        public DBBattleMailResX()
        {
             RetCode = default(Byte);
 RoleId = default(UInt32);
 MailId = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(RoleId); 
 ds.Write(MailId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out MailId) ;
        }
    }
      

    public class DBBattleBonusArgX : DBBattleBonusArg
    {
        public DBBattleBonusArgX()
        {
             FactionId = default(UInt32);
 CityId = default(Int16);
 Money = default(UInt32);
 Item = new GRoleInventoryX(); 
 Isspecialbonus = default(Int16);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
 ds.Write(CityId); 
 ds.Write(Money); 
 ds.Write(Item); 
 ds.Write(Isspecialbonus); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId)  &&
 ds.TryRead(out CityId)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Item)  &&
 ds.TryRead(out Isspecialbonus) ;
        }
    }
      

    public class DBBattleBonusResX : DBBattleBonusRes
    {
        public DBBattleBonusResX()
        {
             RetCode = default(Int16);
 InformMaster = new GMailHeaderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(InformMaster); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)InformMaster) ;
        }
    }
      

    public class PShopItemX : PShopItem
    {
        public PShopItemX()
        {
             Item = new GRoleInventoryX(); 
 Price = default(UInt32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Item); 
 ds.Write(Price); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Item)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class PShopBaseX : PShopBase
    {
        public PShopBaseX()
        {
             RoleId = default(Int32);
 ShopType = default(Int32);
 BList = new Vector<PShopItem, PShopItemX>(); 
 SList = new Vector<PShopItem, PShopItemX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ShopType); 
 ds.Write(BList); 
 ds.Write(SList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ShopType)  &&
 ds.TryRead((IDataSerializer)BList)  &&
 ds.TryRead((IDataSerializer)SList) ;
        }
    }
      

    public class PShopDetailX : PShopDetail
    {
        public PShopDetailX()
        {
             RoleId = default(Int32);
 ShopType = default(Int32);
 Status = default(Int32);
 CreateTime = default(Int32);
 ExpireTime = default(Int32);
 Money = default(UInt32);
 Yinpiao = new Vector<GRoleInventory, GRoleInventoryX>(); 
 BList = new Vector<PShopItem, PShopItemX>(); 
 SList = new Vector<PShopItem, PShopItemX>(); 
 Store = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ShopType); 
 ds.Write(Status); 
 ds.Write(CreateTime); 
 ds.Write(ExpireTime); 
 ds.Write(Money); 
 ds.Write(Yinpiao); 
 ds.Write(BList); 
 ds.Write(SList); 
 ds.Write(Store); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ShopType)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out CreateTime)  &&
 ds.TryRead(out ExpireTime)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Yinpiao)  &&
 ds.TryRead((IDataSerializer)BList)  &&
 ds.TryRead((IDataSerializer)SList)  &&
 ds.TryRead((IDataSerializer)Store)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4) ;
        }
    }
      

    public class PShopEntryX : PShopEntry
    {
        public PShopEntryX()
        {
             RoleId = default(Int32);
 ShopType = default(Int32);
 CreateTime = default(Int32);
 Invstate = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ShopType); 
 ds.Write(CreateTime); 
 ds.Write(Invstate); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ShopType)  &&
 ds.TryRead(out CreateTime)  &&
 ds.TryRead(out Invstate) ;
        }
    }
      

    public class PShopItemEntryX : PShopItemEntry
    {
        public PShopItemEntryX()
        {
             RoleId = default(Int32);
 Item = new PShopItemX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Item); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Item) ;
        }
    }
      

    public class DBPShopCreateArgX : DBPShopCreateArg
    {
        public DBPShopCreateArgX()
        {
             RoleId = default(Int32);
 ShopType = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemNumber = default(Int32);
 CreateTime = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ShopType); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemNumber); 
 ds.Write(CreateTime); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ShopType)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead(out CreateTime)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopCreateResX : DBPShopCreateRes
    {
        public DBPShopCreateResX()
        {
             RetCode = default(Int32);
 Shop = new PShopDetailX(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Shop); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Shop)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopBuyArgX : DBPShopBuyArg
    {
        public DBPShopBuyArgX()
        {
             RoleId = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 ItemPrice = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(ItemPrice); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out ItemPrice) ;
        }
    }
      

    public class DBPShopBuyResX : DBPShopBuyRes
    {
        public DBPShopBuyResX()
        {
             RetCode = default(Int32);
 ItemBuy = new PShopItemX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(ItemBuy); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)ItemBuy) ;
        }
    }
      

    public class DBPShopSellArgX : DBPShopSellArg
    {
        public DBPShopSellArgX()
        {
             RoleId = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 ItemPrice = default(UInt32);
 InvPos = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(ItemPrice); 
 ds.Write(InvPos); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out ItemPrice)  &&
 ds.TryRead(out InvPos)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopSellResX : DBPShopSellRes
    {
        public DBPShopSellResX()
        {
             RetCode = default(Int32);
 ItemSell = new PShopItemX(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(ItemSell); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)ItemSell)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopCancelGoodsArgX : DBPShopCancelGoodsArg
    {
        public DBPShopCancelGoodsArgX()
        {
             RoleId = default(Int32);
 CancelType = default(Int32);
 ItemPos = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(CancelType); 
 ds.Write(ItemPos); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out CancelType)  &&
 ds.TryRead(out ItemPos) ;
        }
    }
      

    public class DBPShopCancelGoodsResX : DBPShopCancelGoodsRes
    {
        public DBPShopCancelGoodsResX()
        {
             RetCode = default(Int32);
 ItemStore = new GRoleInventoryX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(ItemStore); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)ItemStore) ;
        }
    }
      

    public class DBPShopPlayerBuyArgX : DBPShopPlayerBuyArg
    {
        public DBPShopPlayerBuyArgX()
        {
             RoleId = default(Int32);
 Master = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 MoneyCost = default(Int64);
 YpCost = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Master); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(MoneyCost); 
 ds.Write(YpCost); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Master)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out MoneyCost)  &&
 ds.TryRead(out YpCost)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopPlayerBuyResX : DBPShopPlayerBuyRes
    {
        public DBPShopPlayerBuyResX()
        {
             RetCode = default(Int32);
 SyncData = new GMailSyncDataX(); 
 Money = default(UInt32);
 Yinpiao = new Vector<GRoleInventory, GRoleInventoryX>(); 
 ItemChange = new PShopItemX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SyncData); 
 ds.Write(Money); 
 ds.Write(Yinpiao); 
 ds.Write(ItemChange); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)SyncData)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Yinpiao)  &&
 ds.TryRead((IDataSerializer)ItemChange) ;
        }
    }
      

    public class DBPShopPlayerSellArgX : DBPShopPlayerSellArg
    {
        public DBPShopPlayerSellArgX()
        {
             RoleId = default(Int32);
 Master = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemCount = default(Int32);
 InvPos = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Master); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemCount); 
 ds.Write(InvPos); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Master)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemCount)  &&
 ds.TryRead(out InvPos)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopPlayerSellResX : DBPShopPlayerSellRes
    {
        public DBPShopPlayerSellResX()
        {
             RetCode = default(Int32);
 SyncData = new GMailSyncDataX(); 
 Money = default(UInt32);
 Yinpiao = new Vector<GRoleInventory, GRoleInventoryX>(); 
 ItemBuyChange = new PShopItemX(); 
 ItemStoreChange = new GRoleInventoryX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SyncData); 
 ds.Write(Money); 
 ds.Write(Yinpiao); 
 ds.Write(ItemBuyChange); 
 ds.Write(ItemStoreChange); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)SyncData)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Yinpiao)  &&
 ds.TryRead((IDataSerializer)ItemBuyChange)  &&
 ds.TryRead((IDataSerializer)ItemStoreChange) ;
        }
    }
      

    public class DBPShopSetTypeArgX : DBPShopSetTypeArg
    {
        public DBPShopSetTypeArgX()
        {
             RoleId = default(Int32);
 NewType = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(NewType); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out NewType) ;
        }
    }
      

    public class DBPShopSetTypeResX : DBPShopSetTypeRes
    {
        public DBPShopSetTypeResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBPShopActiveArgX : DBPShopActiveArg
    {
        public DBPShopActiveArgX()
        {
             RoleId = default(Int32);
 ItemId = default(Int32);
 ItemPos = default(Int32);
 ItemNumber = default(Int32);
 Timestamp = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemNumber); 
 ds.Write(Timestamp); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead(out Timestamp)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopActiveResX : DBPShopActiveRes
    {
        public DBPShopActiveResX()
        {
             RetCode = default(Int32);
 Detail = new PShopDetailX(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Detail); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Detail)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopManageFundArgX : DBPShopManageFundArg
    {
        public DBPShopManageFundArgX()
        {
             RoleId = default(Int32);
 OpType = default(Int32);
 Money = default(UInt32);
 Yinpiao = default(UInt32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(OpType); 
 ds.Write(Money); 
 ds.Write(Yinpiao); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out OpType)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out Yinpiao)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopManageFundResX : DBPShopManageFundRes
    {
        public DBPShopManageFundResX()
        {
             RetCode = default(Int32);
 Money = default(UInt32);
 Yinpiao = new Vector<GRoleInventory, GRoleInventoryX>(); 
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Money); 
 ds.Write(Yinpiao); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Yinpiao)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopDrawItemArgX : DBPShopDrawItemArg
    {
        public DBPShopDrawItemArgX()
        {
             RoleId = default(Int32);
 ItemPos = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemPos); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopDrawItemResX : DBPShopDrawItemRes
    {
        public DBPShopDrawItemResX()
        {
             RetCode = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBPShopLoadArgX : DBPShopLoadArg
    {
        public DBPShopLoadArgX()
        {
             Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBPShopLoadResX : DBPShopLoadRes
    {
        public DBPShopLoadResX()
        {
             RetCode = default(Int16);
 Shops = new Vector<PShopDetail, PShopDetailX>(); 
 Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Shops); 
 ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Shops)  &&
 ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBPShopGetArgX : DBPShopGetArg
    {
        public DBPShopGetArgX()
        {
             RoleId = default(Int32);
 Reason = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class DBPShopGetResX : DBPShopGetRes
    {
        public DBPShopGetResX()
        {
             RetCode = default(Int32);
 Shop = new PShopDetailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Shop); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Shop) ;
        }
    }
      

    public class DBPShopClearGoodsArgX : DBPShopClearGoodsArg
    {
        public DBPShopClearGoodsArgX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class DBPShopClearGoodsResX : DBPShopClearGoodsRes
    {
        public DBPShopClearGoodsResX()
        {
             RetCode = default(Int32);
 SList = new Vector<PShopItem, PShopItemX>(); 
 Store = new Vector<GRoleInventory, GRoleInventoryX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SList); 
 ds.Write(Store); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)SList)  &&
 ds.TryRead((IDataSerializer)Store) ;
        }
    }
      

    public class DBPShopTimeoutArgX : DBPShopTimeoutArg
    {
        public DBPShopTimeoutArgX()
        {
             RoleId = default(Int32);
 DelFlag = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(DelFlag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out DelFlag) ;
        }
    }
      

    public class DBPShopTimeoutResX : DBPShopTimeoutRes
    {
        public DBPShopTimeoutResX()
        {
             RetCode = default(Int32);
 MailList = new Vector<GMailHeader, GMailHeaderX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(MailList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)MailList) ;
        }
    }
      

    public class PlayerProfileDataX : PlayerProfileData
    {
        public PlayerProfileDataX()
        {
             GameTimeMask = default(UInt16);
 GameInterestMask = default(UInt16);
 PersonalInterestMask = default(UInt16);
 Age = default(Byte);
 Zodiac = default(Byte);
 MatchOptionMask = default(UInt16);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GameTimeMask); 
 ds.Write(GameInterestMask); 
 ds.Write(PersonalInterestMask); 
 ds.Write(Age); 
 ds.Write(Zodiac); 
 ds.Write(MatchOptionMask); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GameTimeMask)  &&
 ds.TryRead(out GameInterestMask)  &&
 ds.TryRead(out PersonalInterestMask)  &&
 ds.TryRead(out Age)  &&
 ds.TryRead(out Zodiac)  &&
 ds.TryRead(out MatchOptionMask) ;
        }
    }
      

    public class ProfileMatchResultX : ProfileMatchResult
    {
        public ProfileMatchResultX()
        {
             RoleId = default(Int32);
 Level = default(Int32);
 Occupation = default(Int32);
 Gender = default(Byte);
 Similarity = default(Single);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Level); 
 ds.Write(Occupation); 
 ds.Write(Gender); 
 ds.Write(Similarity); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Occupation)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead(out Similarity) ;
        }
    }
      

    public class DBGetPlayerProfileDataArgX : DBGetPlayerProfileDataArg
    {
        public DBGetPlayerProfileDataArgX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class DBGetPlayerProfileDataResX : DBGetPlayerProfileDataRes
    {
        public DBGetPlayerProfileDataResX()
        {
             RetCode = default(Int32);
 Gender = default(Byte);
 Data = new PlayerProfileDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Gender); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class DBPutPlayerProfileDataArgX : DBPutPlayerProfileDataArg
    {
        public DBPutPlayerProfileDataArgX()
        {
             RoleId = default(Int32);
 Data = new PlayerProfileDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class DBPutPlayerProfileDataResX : DBPutPlayerProfileDataRes
    {
        public DBPutPlayerProfileDataResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class CrossPlayerDataX : CrossPlayerData
    {
        public CrossPlayerDataX()
        {
             Base = new GRoleBaseX(); 
 Status = new GRoleStatusX(); 
 Inventory = new GRolePocketX(); 
 Equipment = new GRoleEquipmentX(); 
 Storehouse = new GRoleStorehouseX(); 
 Task = new GRoleTaskX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Base); 
 ds.Write(Status); 
 ds.Write(Inventory); 
 ds.Write(Equipment); 
 ds.Write(Storehouse); 
 ds.Write(Task); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Base)  &&
 ds.TryRead((IDataSerializer)Status)  &&
 ds.TryRead((IDataSerializer)Inventory)  &&
 ds.TryRead((IDataSerializer)Equipment)  &&
 ds.TryRead((IDataSerializer)Storehouse)  &&
 ds.TryRead((IDataSerializer)Task) ;
        }
    }
      

    public class FetchPlayerDataArgX : FetchPlayerDataArg
    {
        public FetchPlayerDataArgX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
 Flag = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(Flag); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Flag) ;
        }
    }
      

    public class FetchPlayerDataResX : FetchPlayerDataRes
    {
        public FetchPlayerDataResX()
        {
             RetCode = default(Int32);
 Data = new CrossPlayerDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Data); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Data) ;
        }
    }
      

    public class ActivatePlayerDataArgX : ActivatePlayerDataArg
    {
        public ActivatePlayerDataArgX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class ActivatePlayerDataResX : ActivatePlayerDataRes
    {
        public ActivatePlayerDataResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class TouchPlayerDataArgX : TouchPlayerDataArg
    {
        public TouchPlayerDataArgX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID) ;
        }
    }
      

    public class TouchPlayerDataResX : TouchPlayerDataRes
    {
        public TouchPlayerDataResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DelPlayerDataArgX : DelPlayerDataArg
    {
        public DelPlayerDataArgX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID) ;
        }
    }
      

    public class DelPlayerDataResX : DelPlayerDataRes
    {
        public DelPlayerDataResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class FreezePlayerDataArgX : FreezePlayerDataArg
    {
        public FreezePlayerDataArgX()
        {
             RoleId = default(Int32);
 RemoteRoleId = default(Int32);
 UserID = default(Int32);
 RemoteZoneId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RemoteRoleId); 
 ds.Write(UserID); 
 ds.Write(RemoteZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out RemoteZoneId) ;
        }
    }
      

    public class FreezePlayerDataResX : FreezePlayerDataRes
    {
        public FreezePlayerDataResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class PlayerIdentityMatchArgX : PlayerIdentityMatchArg
    {
        public PlayerIdentityMatchArgX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
 Ip = default(Int32);
 SrcZoneId = default(Int32);
 Random = new Octets(); 
 Flag = default(Boolean);
 LocalSid = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(Ip); 
 ds.Write(SrcZoneId); 
 ds.Write(Random); 
 ds.Write(Flag); 
 ds.Write(LocalSid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Ip)  &&
 ds.TryRead(out SrcZoneId)  &&
 ds.TryRead((IDataSerializer)Random)  &&
 ds.TryRead(out Flag)  &&
 ds.TryRead(out LocalSid) ;
        }
    }
      

    public class PlayerIdentityMatchResX : PlayerIdentityMatchRes
    {
        public PlayerIdentityMatchResX()
        {
             RetCode = default(Int32);
 ISeckey = new Octets(); 
 OSeckey = new Octets(); 
 Account = new Octets(); 
 User = new UserX(); 
 RoleInfo = new GRoleInfoX(); 
 ZoneId = default(Int32);
 DistrictId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(ISeckey); 
 ds.Write(OSeckey); 
 ds.Write(Account); 
 ds.Write(User); 
 ds.Write(RoleInfo); 
 ds.Write(ZoneId); 
 ds.Write(DistrictId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)ISeckey)  &&
 ds.TryRead((IDataSerializer)OSeckey)  &&
 ds.TryRead((IDataSerializer)Account)  &&
 ds.TryRead((IDataSerializer)User)  &&
 ds.TryRead((IDataSerializer)RoleInfo)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out DistrictId) ;
        }
    }
      

    public class SavePlayerDataArgX : SavePlayerDataArg
    {
        public SavePlayerDataArgX()
        {
             RoleId = default(Int32);
 RemoteRoleId = default(Int32);
 UserID = default(Int32);
 SrcZoneId = default(Int32);
 Data = new CrossPlayerDataX(); 
 Flag = default(Boolean);
 DataTimestamp = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RemoteRoleId); 
 ds.Write(UserID); 
 ds.Write(SrcZoneId); 
 ds.Write(Data); 
 ds.Write(Flag); 
 ds.Write(DataTimestamp); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out SrcZoneId)  &&
 ds.TryRead((IDataSerializer)Data)  &&
 ds.TryRead(out Flag)  &&
 ds.TryRead(out DataTimestamp) ;
        }
    }
      

    public class SavePlayerDataResX : SavePlayerDataRes
    {
        public SavePlayerDataResX()
        {
             RetCode = default(Int32);
 NewRoleId = default(Int32);
 RoleInfo = new GRoleInfoX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(NewRoleId); 
 ds.Write(RoleInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out NewRoleId)  &&
 ds.TryRead((IDataSerializer)RoleInfo) ;
        }
    }
      

    public class CrossInfoDataX : CrossInfoData
    {
        public CrossInfoDataX()
        {
             RemoteRoleId = default(Int32);
 DataTimestamp = default(Int32);
 CrossTimestamp = default(Int32);
 SrcZoneId = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RemoteRoleId); 
 ds.Write(DataTimestamp); 
 ds.Write(CrossTimestamp); 
 ds.Write(SrcZoneId); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out DataTimestamp)  &&
 ds.TryRead(out CrossTimestamp)  &&
 ds.TryRead(out SrcZoneId)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2) ;
        }
    }
      

    public class DBUpdatePlayerCrossInfoArgX : DBUpdatePlayerCrossInfoArg
    {
        public DBUpdatePlayerCrossInfoArgX()
        {
             RoleId = default(Int32);
 RemoteRoleId = default(Int32);
 UserID = default(Int32);
 RemoteZoneId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RemoteRoleId); 
 ds.Write(UserID); 
 ds.Write(RemoteZoneId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out RemoteRoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out RemoteZoneId) ;
        }
    }
      

    public class DBUpdatePlayerCrossInfoResX : DBUpdatePlayerCrossInfoRes
    {
        public DBUpdatePlayerCrossInfoResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class StockOrderX : StockOrder
    {
        public StockOrderX()
        {
             TId = default(UInt32);
 Time = default(Int32);
 UserID = default(Int32);
 Price = default(Int32);
 Volume = default(Int32);
 Status = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(Time); 
 ds.Write(UserID); 
 ds.Write(Price); 
 ds.Write(Volume); 
 ds.Write(Status); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Price)  &&
 ds.TryRead(out Volume)  &&
 ds.TryRead(out Status) ;
        }
    }
      

    public class StockPriceX : StockPrice
    {
        public StockPriceX()
        {
             Price = default(Int32);
 Volume = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Price); 
 ds.Write(Volume); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Price)  &&
 ds.TryRead(out Volume) ;
        }
    }
      

    public class DBStockBalanceArgX : DBStockBalanceArg
    {
        public DBStockBalanceArgX()
        {
             TId = default(UInt32);
 UserID = default(Int32);
 AckVolume = default(Int32);
 AckMoney = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TId); 
 ds.Write(UserID); 
 ds.Write(AckVolume); 
 ds.Write(AckMoney); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out AckVolume)  &&
 ds.TryRead(out AckMoney) ;
        }
    }
      

    public class DBStockBalanceResX : DBStockBalanceRes
    {
        public DBStockBalanceResX()
        {
             RetCode = default(Int32);
 VolumeLeft = default(Int32);
 Cash = default(Int32);
 Money = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(VolumeLeft); 
 ds.Write(Cash); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out VolumeLeft)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class DBStockCommissionArgX : DBStockCommissionArg
    {
        public DBStockCommissionArgX()
        {
             Order = new StockOrderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Order); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Order) ;
        }
    }
      

    public class DBStockCommissionResX : DBStockCommissionRes
    {
        public DBStockCommissionResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBStockCancelArgX : DBStockCancelArg
    {
        public DBStockCancelArgX()
        {
             UserID = default(Int32);
 TId = default(UInt32);
 Volume = default(Int32);
 Result = default(Int16);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(TId); 
 ds.Write(Volume); 
 ds.Write(Result); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out TId)  &&
 ds.TryRead(out Volume)  &&
 ds.TryRead(out Result) ;
        }
    }
      

    public class DBStockCancelResX : DBStockCancelRes
    {
        public DBStockCancelResX()
        {
             RetCode = default(Int32);
 Cash = default(Int32);
 Money = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cash); 
 ds.Write(Money); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out Money) ;
        }
    }
      

    public class DBStockTransactionArgX : DBStockTransactionArg
    {
        public DBStockTransactionArgX()
        {
             UserID = default(Int32);
 RoleId = default(Int32);
 WithDraw = default(Byte);
 Cash = default(Int32);
 Money = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(RoleId); 
 ds.Write(WithDraw); 
 ds.Write(Cash); 
 ds.Write(Money); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out WithDraw)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBStockTransactionResX : DBStockTransactionRes
    {
        public DBStockTransactionResX()
        {
             RetCode = default(Int16);
 Cash = default(Int32);
 Money = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Cash); 
 ds.Write(Money); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Cash)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBStockLoadArgX : DBStockLoadArg
    {
        public DBStockLoadArgX()
        {
             Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class DBStockLoadResX : DBStockLoadRes
    {
        public DBStockLoadResX()
        {
             RetCode = default(Int16);
 Orders = new Vector<StockOrder, StockOrderX>(); 
 Handle = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Orders); 
 ds.Write(Handle); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Orders)  &&
 ds.TryRead((IDataSerializer)Handle) ;
        }
    }
      

    public class GMemberX : GMember
    {
        public GMemberX()
        {
             RId = default(UInt32);
 Role = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RId); 
 ds.Write(Role); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RId)  &&
 ds.TryRead(out Role) ;
        }
    }
      

    public class GItemX : GItem
    {
        public GItemX()
        {
             Id = default(UInt32);
 Count = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Count); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out Count) ;
        }
    }
      

    public class GFactionLogX : GFactionLog
    {
        public GFactionLogX()
        {
             RId = default(UInt32);
 Name = new Octets(); 
 Action = default(Byte);
 Items = new Vector<GItem, GItemX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RId); 
 ds.Write(Name); 
 ds.Write(Action); 
 ds.Write(Items); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RId)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Action)  &&
 ds.TryRead((IDataSerializer)Items) ;
        }
    }
      

    public class GFactionStorehouseX : GFactionStorehouse
    {
        public GFactionStorehouseX()
        {
             Money = default(Int64);
 Items = new Vector<GRoleInventory, GRoleInventoryX>(); 
 Log = new Vector<GFactionLog, GFactionLogX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Money); 
 ds.Write(Items); 
 ds.Write(Log); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Items)  &&
 ds.TryRead((IDataSerializer)Log) ;
        }
    }
      

    public class GFactionInfoX : GFactionInfo
    {
        public GFactionInfoX()
        {
             FId = default(UInt32);
 Name = new Octets(); 
 Level = default(Byte);
 Master = new GMemberX(); 
 Member = new Vector<GMember, GMemberX>(); 
 Announce = new Octets(); 
 SysInfo = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(Name); 
 ds.Write(Level); 
 ds.Write(Master); 
 ds.Write(Member); 
 ds.Write(Announce); 
 ds.Write(SysInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead((IDataSerializer)Master)  &&
 ds.TryRead((IDataSerializer)Member)  &&
 ds.TryRead((IDataSerializer)Announce)  &&
 ds.TryRead((IDataSerializer)SysInfo) ;
        }
    }
      

    public class GFactionBaseInfoX : GFactionBaseInfo
    {
        public GFactionBaseInfoX()
        {
             FId = default(UInt32);
 Name = new Octets(); 
 Level = default(Byte);
 MemNum = default(Int16);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(Name); 
 ds.Write(Level); 
 ds.Write(MemNum); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out MemNum) ;
        }
    }
      

    public class GFactionExtendX : GFactionExtend
    {
        public GFactionExtendX()
        {
             JoinTime = default(Int32);
 Loyalty = default(Int32);
 LoginTime = default(Int32);
 Reserved1 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(JoinTime); 
 ds.Write(Loyalty); 
 ds.Write(LoginTime); 
 ds.Write(Reserved1); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out JoinTime)  &&
 ds.TryRead(out Loyalty)  &&
 ds.TryRead(out LoginTime)  &&
 ds.TryRead(out Reserved1) ;
        }
    }
      

    public class GUserFactionX : GUserFaction
    {
        public GUserFactionX()
        {
             RId = default(UInt32);
 Name = new Octets(); 
 FId = default(UInt32);
 Cls = default(Byte);
 Role = default(Byte);
 Delayexpel = new Octets(); 
 Extend = new Octets(); 
 NickName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RId); 
 ds.Write(Name); 
 ds.Write(FId); 
 ds.Write(Cls); 
 ds.Write(Role); 
 ds.Write(Delayexpel); 
 ds.Write(Extend); 
 ds.Write(NickName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RId)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out FId)  &&
 ds.TryRead(out Cls)  &&
 ds.TryRead(out Role)  &&
 ds.TryRead((IDataSerializer)Delayexpel)  &&
 ds.TryRead((IDataSerializer)Extend)  &&
 ds.TryRead((IDataSerializer)NickName) ;
        }
    }
      

    public class GFactionAllianceX : GFactionAlliance
    {
        public GFactionAllianceX()
        {
             FId = default(Int32);
 EndTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(EndTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out EndTime) ;
        }
    }
      

    public class GFactionHostileX : GFactionHostile
    {
        public GFactionHostileX()
        {
             FId = default(Int32);
 EndTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(EndTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out EndTime) ;
        }
    }
      

    public class GFactionRelationApplyX : GFactionRelationApply
    {
        public GFactionRelationApplyX()
        {
             Type = default(Int32);
 FId = default(Int32);
 EndTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Type); 
 ds.Write(FId); 
 ds.Write(EndTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Type)  &&
 ds.TryRead(out FId)  &&
 ds.TryRead(out EndTime) ;
        }
    }
      

    public class GFactionRelationX : GFactionRelation
    {
        public GFactionRelationX()
        {
             FId = default(Int32);
 LastOpTime = default(Int32);
 Alliance = new Vector<GFactionAlliance, GFactionAllianceX>(); 
 Hostile = new Vector<GFactionHostile, GFactionHostileX>(); 
 Apply = new Vector<GFactionRelationApply, GFactionRelationApplyX>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(LastOpTime); 
 ds.Write(Alliance); 
 ds.Write(Hostile); 
 ds.Write(Apply); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out LastOpTime)  &&
 ds.TryRead((IDataSerializer)Alliance)  &&
 ds.TryRead((IDataSerializer)Hostile)  &&
 ds.TryRead((IDataSerializer)Apply)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5) ;
        }
    }
      

    public class FactionIdX : FactionId
    {
        public FactionIdX()
        {
             FId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId) ;
        }
    }
      

    public class AddFactionArgX : AddFactionArg
    {
        public AddFactionArgX()
        {
             Name = new Octets(); 
 RId = default(UInt32);
 FId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Name); 
 ds.Write(RId); 
 ds.Write(FId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out RId)  &&
 ds.TryRead(out FId) ;
        }
    }
      

    public class AddFactionResX : AddFactionRes
    {
        public AddFactionResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class AddMemberArgX : AddMemberArg
    {
        public AddMemberArgX()
        {
             FId = default(UInt32);
 RId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(RId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out RId) ;
        }
    }
      

    public class AddMemberResX : AddMemberRes
    {
        public AddMemberResX()
        {
             RetCode = default(Int32);
 Name = new Octets(); 
 Cls = default(Byte);
 Level = default(Int32);
 Reputation = default(Int32);
 ReincarnTimes = default(Byte);
 Gender = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Name); 
 ds.Write(Cls); 
 ds.Write(Level); 
 ds.Write(Reputation); 
 ds.Write(ReincarnTimes); 
 ds.Write(Gender); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Cls)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Reputation)  &&
 ds.TryRead(out ReincarnTimes)  &&
 ds.TryRead(out Gender) ;
        }
    }
      

    public class DelMemberArgX : DelMemberArg
    {
        public DelMemberArgX()
        {
             FId = default(UInt32);
 RId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(RId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out RId) ;
        }
    }
      

    public class DelMemberScheduleArgX : DelMemberScheduleArg
    {
        public DelMemberScheduleArgX()
        {
             FId = default(UInt32);
 RId = default(UInt32);
 Operation = default(Byte);
 Time = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(RId); 
 ds.Write(Operation); 
 ds.Write(Time); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out RId)  &&
 ds.TryRead(out Operation)  &&
 ds.TryRead(out Time) ;
        }
    }
      

    public class UpdateUserFactionArgX : UpdateUserFactionArg
    {
        public UpdateUserFactionArgX()
        {
             FId = default(UInt32);
 RId = default(UInt32);
 Operation = default(Byte);
 Role = default(Byte);
 Loyalty = default(Int16);
 NickName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(RId); 
 ds.Write(Operation); 
 ds.Write(Role); 
 ds.Write(Loyalty); 
 ds.Write(NickName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out RId)  &&
 ds.TryRead(out Operation)  &&
 ds.TryRead(out Role)  &&
 ds.TryRead(out Loyalty)  &&
 ds.TryRead((IDataSerializer)NickName) ;
        }
    }
      

    public class UpdateFactionArgX : UpdateFactionArg
    {
        public UpdateFactionArgX()
        {
             FId = default(UInt32);
 Type = default(Byte);
 Level = default(Byte);
 Announce = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(Type); 
 ds.Write(Level); 
 ds.Write(Announce); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out Type)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead((IDataSerializer)Announce) ;
        }
    }
      

    public class DefFactionResX : DefFactionRes
    {
        public DefFactionResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBFactionUpgradeArgX : DBFactionUpgradeArg
    {
        public DBFactionUpgradeArgX()
        {
             FId = default(UInt32);
 RoleId = default(Int32);
 Money = default(UInt32);
 Level = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(RoleId); 
 ds.Write(Money); 
 ds.Write(Level); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out Level) ;
        }
    }
      

    public class DBFactionUpgradeResX : DBFactionUpgradeRes
    {
        public DBFactionUpgradeResX()
        {
             RetCode = default(Int32);
 Master = default(Int32);
 Money = default(UInt32);
 Level = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Master); 
 ds.Write(Money); 
 ds.Write(Level); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Master)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead(out Level) ;
        }
    }
      

    public class DBFactionPromoteArgX : DBFactionPromoteArg
    {
        public DBFactionPromoteArgX()
        {
             FId = default(UInt32);
 Superior = default(UInt32);
 RoleId = default(UInt32);
 Suprole = default(Byte);
 Newrole = default(Byte);
 Max = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(Superior); 
 ds.Write(RoleId); 
 ds.Write(Suprole); 
 ds.Write(Newrole); 
 ds.Write(Max); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out Superior)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out Suprole)  &&
 ds.TryRead(out Newrole)  &&
 ds.TryRead(out Max) ;
        }
    }
      

    public class DBFactionPromoteResX : DBFactionPromoteRes
    {
        public DBFactionPromoteResX()
        {
             RetCode = default(Int32);
 Suprole = default(Byte);
 Newrole = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Suprole); 
 ds.Write(Newrole); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out Suprole)  &&
 ds.TryRead(out Newrole) ;
        }
    }
      

    public class FactionInfoResX : FactionInfoRes
    {
        public FactionInfoResX()
        {
             RetCode = default(Int32);
 Value = new GFactionInfoX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class UserFactionArgX : UserFactionArg
    {
        public UserFactionArgX()
        {
             Reason = default(Int32);
 RId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Reason); 
 ds.Write(RId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Reason)  &&
 ds.TryRead(out RId) ;
        }
    }
      

    public class UserFactionResX : UserFactionRes
    {
        public UserFactionResX()
        {
             RetCode = default(Int32);
 Value = new GUserFactionX(); 
 Level = default(Int32);
 Contrib = default(Int32);
 Reputation = default(Int32);
 ReincarnTimes = default(Byte);
 Gender = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
 ds.Write(Level); 
 ds.Write(Contrib); 
 ds.Write(Reputation); 
 ds.Write(ReincarnTimes); 
 ds.Write(Gender); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Contrib)  &&
 ds.TryRead(out Reputation)  &&
 ds.TryRead(out ReincarnTimes)  &&
 ds.TryRead(out Gender) ;
        }
    }
      

    public class GFactionDetailX : GFactionDetail
    {
        public GFactionDetailX()
        {
             FId = default(UInt32);
 Name = new Octets(); 
 Level = default(Byte);
 Master = default(UInt32);
 Announce = new Octets(); 
 SysInfo = new Octets(); 
 Member = new Vector<FMemberInfo, FMemberInfoX>(); 
 LastOpTime = default(Int32);
 Alliance = new Vector<GFactionAlliance, GFactionAllianceX>(); 
 Hostile = new Vector<GFactionHostile, GFactionHostileX>(); 
 Apply = new Vector<GFactionRelationApply, GFactionRelationApplyX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(Name); 
 ds.Write(Level); 
 ds.Write(Master); 
 ds.Write(Announce); 
 ds.Write(SysInfo); 
 ds.Write(Member); 
 ds.Write(LastOpTime); 
 ds.Write(Alliance); 
 ds.Write(Hostile); 
 ds.Write(Apply); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Master)  &&
 ds.TryRead((IDataSerializer)Announce)  &&
 ds.TryRead((IDataSerializer)SysInfo)  &&
 ds.TryRead((IDataSerializer)Member)  &&
 ds.TryRead(out LastOpTime)  &&
 ds.TryRead((IDataSerializer)Alliance)  &&
 ds.TryRead((IDataSerializer)Hostile)  &&
 ds.TryRead((IDataSerializer)Apply) ;
        }
    }
      

    public class FactionDetailResX : FactionDetailRes
    {
        public FactionDetailResX()
        {
             RetCode = default(Int32);
 Value = new GFactionDetailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value) ;
        }
    }
      

    public class DelFactionResX : DelFactionRes
    {
        public DelFactionResX()
        {
             RetCode = default(Int32);
 FName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(FName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)FName) ;
        }
    }
      

    public class DBVerifyMasterArgX : DBVerifyMasterArg
    {
        public DBVerifyMasterArgX()
        {
             Name = new Octets(); 
 Faction = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Name); 
 ds.Write(Faction); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)Faction) ;
        }
    }
      

    public class DBFactionAllianceApplyArgX : DBFactionAllianceApplyArg
    {
        public DBFactionAllianceApplyArgX()
        {
             FId = default(Int32);
 DstFId = default(Int32);
 EndTime = default(Int32);
 OpTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(DstFId); 
 ds.Write(EndTime); 
 ds.Write(OpTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out EndTime)  &&
 ds.TryRead(out OpTime) ;
        }
    }
      

    public class DBFactionAllianceReplyArgX : DBFactionAllianceReplyArg
    {
        public DBFactionAllianceReplyArgX()
        {
             FId = default(Int32);
 DstFId = default(Int32);
 Agree = default(Byte);
 EndTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(DstFId); 
 ds.Write(Agree); 
 ds.Write(EndTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out Agree)  &&
 ds.TryRead(out EndTime) ;
        }
    }
      

    public class DBFactionHostileApplyArgX : DBFactionHostileApplyArg
    {
        public DBFactionHostileApplyArgX()
        {
             FId = default(Int32);
 DstFId = default(Int32);
 EndTime = default(Int32);
 OpTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(DstFId); 
 ds.Write(EndTime); 
 ds.Write(OpTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out EndTime)  &&
 ds.TryRead(out OpTime) ;
        }
    }
      

    public class DBFactionHostileReplyArgX : DBFactionHostileReplyArg
    {
        public DBFactionHostileReplyArgX()
        {
             FId = default(Int32);
 DstFId = default(Int32);
 Agree = default(Byte);
 EndTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(DstFId); 
 ds.Write(Agree); 
 ds.Write(EndTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out Agree)  &&
 ds.TryRead(out EndTime) ;
        }
    }
      

    public class DBFactionRemoveRelationApplyArgX : DBFactionRemoveRelationApplyArg
    {
        public DBFactionRemoveRelationApplyArgX()
        {
             FId = default(Int32);
 DstFId = default(Int32);
 Force = default(Byte);
 EndTime = default(Int32);
 OpTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(DstFId); 
 ds.Write(Force); 
 ds.Write(EndTime); 
 ds.Write(OpTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out Force)  &&
 ds.TryRead(out EndTime)  &&
 ds.TryRead(out OpTime) ;
        }
    }
      

    public class DBFactionRemoveRelationReplyArgX : DBFactionRemoveRelationReplyArg
    {
        public DBFactionRemoveRelationReplyArgX()
        {
             FId = default(Int32);
 DstFId = default(Int32);
 Agree = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FId); 
 ds.Write(DstFId); 
 ds.Write(Agree); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FId)  &&
 ds.TryRead(out DstFId)  &&
 ds.TryRead(out Agree) ;
        }
    }
      

    public class DBFactionRelationTimeoutArgX : DBFactionRelationTimeoutArg
    {
        public DBFactionRelationTimeoutArgX()
        {
             Type = default(Int32);
 FId1 = default(Int32);
 FId2 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Type); 
 ds.Write(FId1); 
 ds.Write(FId2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Type)  &&
 ds.TryRead(out FId1)  &&
 ds.TryRead(out FId2) ;
        }
    }
      

    public class DBFactionRelationApplyTimeoutArgX : DBFactionRelationApplyTimeoutArg
    {
        public DBFactionRelationApplyTimeoutArgX()
        {
             Type = default(Int32);
 FId1 = default(Int32);
 FId2 = default(Int32);
 EndTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Type); 
 ds.Write(FId1); 
 ds.Write(FId2); 
 ds.Write(EndTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Type)  &&
 ds.TryRead(out FId1)  &&
 ds.TryRead(out FId2)  &&
 ds.TryRead(out EndTime) ;
        }
    }
      

    public class DBFactionRelationRetcodeX : DBFactionRelationRetcode
    {
        public DBFactionRelationRetcodeX()
        {
             RetCode = default(Int32);
 FName1 = new Octets(); 
 FName2 = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(FName1); 
 ds.Write(FName2); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)FName1)  &&
 ds.TryRead((IDataSerializer)FName2) ;
        }
    }
      

    public class FMemberInfoX : FMemberInfo
    {
        public FMemberInfoX()
        {
             RoleId = default(UInt32);
 Level = default(Byte);
 Occupation = default(Byte);
 FRoleId = default(Byte);
 Loginday = default(UInt16);
 OnlineStatus = default(Byte);
 Name = new Octets(); 
 NickName = new Octets(); 
 Contrib = default(Int32);
 Delayexpel = default(Byte);
 ExpelTime = default(Int32);
 Reputation = default(Int32);
 ReincarnTimes = default(Byte);
 Gender = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Level); 
 ds.Write(Occupation); 
 ds.Write(FRoleId); 
 ds.Write(Loginday); 
 ds.Write(OnlineStatus); 
 ds.Write(Name); 
 ds.Write(NickName); 
 ds.Write(Contrib); 
 ds.Write(Delayexpel); 
 ds.Write(ExpelTime); 
 ds.Write(Reputation); 
 ds.Write(ReincarnTimes); 
 ds.Write(Gender); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Occupation)  &&
 ds.TryRead(out FRoleId)  &&
 ds.TryRead(out Loginday)  &&
 ds.TryRead(out OnlineStatus)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)NickName)  &&
 ds.TryRead(out Contrib)  &&
 ds.TryRead(out Delayexpel)  &&
 ds.TryRead(out ExpelTime)  &&
 ds.TryRead(out Reputation)  &&
 ds.TryRead(out ReincarnTimes)  &&
 ds.TryRead(out Gender) ;
        }
    }
      

    public class GForceGlobalDataListX : GForceGlobalDataList
    {
        public GForceGlobalDataListX()
        {
             List = new Vector<GForceGlobalData, GForceGlobalDataX>(); 
 UpdateTime = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
 Reserved6 = default(Int32);
 Reserved7 = default(Int32);
 Reserved8 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(List); 
 ds.Write(UpdateTime); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
 ds.Write(Reserved6); 
 ds.Write(Reserved7); 
 ds.Write(Reserved8); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)List)  &&
 ds.TryRead(out UpdateTime)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5)  &&
 ds.TryRead(out Reserved6)  &&
 ds.TryRead(out Reserved7)  &&
 ds.TryRead(out Reserved8) ;
        }
    }
      

    public class GForceGlobalDataX : GForceGlobalData
    {
        public GForceGlobalDataX()
        {
             ForceId = default(Int32);
 PlayerCount = default(Int32);
 Development = default(Int32);
 Construction = default(Int32);
 Activity = default(Int32);
 ActivityLevel = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
 Reserved6 = default(Int32);
 Reserved7 = default(Int32);
 Reserved8 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ForceId); 
 ds.Write(PlayerCount); 
 ds.Write(Development); 
 ds.Write(Construction); 
 ds.Write(Activity); 
 ds.Write(ActivityLevel); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
 ds.Write(Reserved6); 
 ds.Write(Reserved7); 
 ds.Write(Reserved8); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ForceId)  &&
 ds.TryRead(out PlayerCount)  &&
 ds.TryRead(out Development)  &&
 ds.TryRead(out Construction)  &&
 ds.TryRead(out Activity)  &&
 ds.TryRead(out ActivityLevel)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5)  &&
 ds.TryRead(out Reserved6)  &&
 ds.TryRead(out Reserved7)  &&
 ds.TryRead(out Reserved8) ;
        }
    }
      

    public class GForceGlobalDataBriefX : GForceGlobalDataBrief
    {
        public GForceGlobalDataBriefX()
        {
             ForceId = default(Int32);
 PlayerCount = default(Int32);
 Development = default(Int32);
 Construction = default(Int32);
 Activity = default(Int32);
 ActivityLevel = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ForceId); 
 ds.Write(PlayerCount); 
 ds.Write(Development); 
 ds.Write(Construction); 
 ds.Write(Activity); 
 ds.Write(ActivityLevel); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ForceId)  &&
 ds.TryRead(out PlayerCount)  &&
 ds.TryRead(out Development)  &&
 ds.TryRead(out Construction)  &&
 ds.TryRead(out Activity)  &&
 ds.TryRead(out ActivityLevel) ;
        }
    }
      

    public class DBForceLoadArgX : DBForceLoadArg
    {
        public DBForceLoadArgX()
        {
             Nouse = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Nouse); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Nouse) ;
        }
    }
      

    public class DBForceLoadResX : DBForceLoadRes
    {
        public DBForceLoadResX()
        {
             RetCode = default(Int32);
 List = new GForceGlobalDataListX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(List); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)List) ;
        }
    }
      

    public class DBPutForceArgX : DBPutForceArg
    {
        public DBPutForceArgX()
        {
             List = new GForceGlobalDataListX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(List); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)List) ;
        }
    }
      

    public class DBPutForceResX : DBPutForceRes
    {
        public DBPutForceResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class CountryBattleApplyEntryX : CountryBattleApplyEntry
    {
        public CountryBattleApplyEntryX()
        {
             RoleId = default(Int32);
 MajorStrength = default(Int32);
 MinorStrength = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(MajorStrength); 
 ds.Write(MinorStrength); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out MajorStrength)  &&
 ds.TryRead(out MinorStrength) ;
        }
    }
      

    public class GCountryCapitalX : GCountryCapital
    {
        public GCountryCapitalX()
        {
             CountryId = default(Int32);
 Worldtag = default(Int32);
 PosX = default(Single);
 PosY = default(Single);
 PosZ = default(Single);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CountryId); 
 ds.Write(Worldtag); 
 ds.Write(PosX); 
 ds.Write(PosY); 
 ds.Write(PosZ); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out CountryId)  &&
 ds.TryRead(out Worldtag)  &&
 ds.TryRead(out PosX)  &&
 ds.TryRead(out PosY)  &&
 ds.TryRead(out PosZ) ;
        }
    }
      

    public class GCountryBattlePersonalScoreX : GCountryBattlePersonalScore
    {
        public GCountryBattlePersonalScoreX()
        {
             RoleId = default(Int32);
 Cls = default(Int32);
 MinorStr = default(Int32);
 CombatTime = default(Int32);
 AttendTime = default(Int32);
 KillCount = default(Int32);
 DeathCount = default(Int32);
 ContributeVal = default(Int32);
 Damage = default(Int32);
 Hurt = default(Int32);
 DamageMinorStr = default(Int32);
 KillMinorStr = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Cls); 
 ds.Write(MinorStr); 
 ds.Write(CombatTime); 
 ds.Write(AttendTime); 
 ds.Write(KillCount); 
 ds.Write(DeathCount); 
 ds.Write(ContributeVal); 
 ds.Write(Damage); 
 ds.Write(Hurt); 
 ds.Write(DamageMinorStr); 
 ds.Write(KillMinorStr); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Cls)  &&
 ds.TryRead(out MinorStr)  &&
 ds.TryRead(out CombatTime)  &&
 ds.TryRead(out AttendTime)  &&
 ds.TryRead(out KillCount)  &&
 ds.TryRead(out DeathCount)  &&
 ds.TryRead(out ContributeVal)  &&
 ds.TryRead(out Damage)  &&
 ds.TryRead(out Hurt)  &&
 ds.TryRead(out DamageMinorStr)  &&
 ds.TryRead(out KillMinorStr) ;
        }
    }
      

    public class GCountryBattleDomainX : GCountryBattleDomain
    {
        public GCountryBattleDomainX()
        {
             Id = default(Int32);
 Owner = default(Byte);
 Challenger = default(Byte);
 Status = default(Boolean);
 BattleConfigMask = default(Byte);
 Time = default(Int32);
 CountryPlayercnt = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(Owner); 
 ds.Write(Challenger); 
 ds.Write(Status); 
 ds.Write(BattleConfigMask); 
 ds.Write(Time); 
 ds.Write(CountryPlayercnt); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out Owner)  &&
 ds.TryRead(out Challenger)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead(out BattleConfigMask)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead((IDataSerializer)CountryPlayercnt) ;
        }
    }
      

    public class DBCountryBattleBonusArgX : DBCountryBattleBonusArg
    {
        public DBCountryBattleBonusArgX()
        {
             RoleId = default(Int32);
 Money = default(UInt32);
 Item = new GRoleInventoryX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Money); 
 ds.Write(Item); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Item) ;
        }
    }
      

    public class DBCountryBattleBonusResX : DBCountryBattleBonusRes
    {
        public DBCountryBattleBonusResX()
        {
             RetCode = default(Int16);
 InformPlayer = new GMailHeaderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(InformPlayer); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)InformPlayer) ;
        }
    }
      

    public class GCountryBattleLimitX : GCountryBattleLimit
    {
        public GCountryBattleLimitX()
        {
             OccupationCntCeil = default(Byte);
 MinorStrFloor = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(OccupationCntCeil); 
 ds.Write(MinorStrFloor); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out OccupationCntCeil)  &&
 ds.TryRead(out MinorStrFloor) ;
        }
    }
      

    public class PFactionInfoX : PFactionInfo
    {
        public PFactionInfoX()
        {
             RoleId = default(Int32);
 FactionId = default(UInt32);
 Factionrole = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(FactionId); 
 ds.Write(Factionrole); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead(out Factionrole) ;
        }
    }
      

    public class FactionOPSyncInfoX : FactionOPSyncInfo
    {
        public FactionOPSyncInfoX()
        {
             PlayerMoney = default(UInt32);
 PlayerSp = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(PlayerMoney); 
 ds.Write(PlayerSp); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out PlayerMoney)  &&
 ds.TryRead(out PlayerSp) ;
        }
    }
      

    public class FactionOPAddInfoX : FactionOPAddInfo
    {
        public FactionOPAddInfoX()
        {
             RetCode = default(Int32);
 FactionId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead(out FactionId) ;
        }
    }
      

    public class AnnounceFactionRoleDelArgX : AnnounceFactionRoleDelArg
    {
        public AnnounceFactionRoleDelArgX()
        {
             RoleId = default(Int32);
 ZoneId = default(Byte);
 Faction = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ZoneId); 
 ds.Write(Faction); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out Faction) ;
        }
    }
      

    public class AnnounceFactionRoleDelResX : AnnounceFactionRoleDelRes
    {
        public AnnounceFactionRoleDelResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class FactionInviteArgX : FactionInviteArg
    {
        public FactionInviteArgX()
        {
             RoleId = default(Int32);
 InvitedRoleId = default(Int32);
 FactionId = default(UInt32);
 FactionName = new Octets(); 
 RoleName = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(InvitedRoleId); 
 ds.Write(FactionId); 
 ds.Write(FactionName); 
 ds.Write(RoleName); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out InvitedRoleId)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead((IDataSerializer)FactionName)  &&
 ds.TryRead((IDataSerializer)RoleName) ;
        }
    }
      

    public class FactionInviteResX : FactionInviteRes
    {
        public FactionInviteResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class KEKingX : KEKing
    {
        public KEKingX()
        {
             RoleId = default(Int32);
 EndTime = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(EndTime); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out EndTime)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3) ;
        }
    }
      

    public class KECandidateX : KECandidate
    {
        public KECandidateX()
        {
             RoleId = default(Int32);
 SerialNum = default(Int32);
 Deposit = default(Int32);
 Votes = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(SerialNum); 
 ds.Write(Deposit); 
 ds.Write(Votes); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out SerialNum)  &&
 ds.TryRead(out Deposit)  &&
 ds.TryRead(out Votes)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3) ;
        }
    }
      

    public class KingElectionDetailX : KingElectionDetail
    {
        public KingElectionDetailX()
        {
             King = new KEKingX(); 
 CandidateList = new Vector<KECandidate, KECandidateX>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(King); 
 ds.Write(CandidateList); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)King)  &&
 ds.TryRead((IDataSerializer)CandidateList)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5) ;
        }
    }
      

    public class DBKELoadArgX : DBKELoadArg
    {
        public DBKELoadArgX()
        {
             Nouse = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Nouse); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Nouse) ;
        }
    }
      

    public class DBKELoadResX : DBKELoadRes
    {
        public DBKELoadResX()
        {
             RetCode = default(Int32);
 Detail = new KingElectionDetailX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Detail); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Detail) ;
        }
    }
      

    public class DBKECandidateApplyArgX : DBKECandidateApplyArg
    {
        public DBKECandidateApplyArgX()
        {
             RoleId = default(Int32);
 SerialNum = default(Int32);
 ItemId = default(UInt32);
 ItemNumber = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(SerialNum); 
 ds.Write(ItemId); 
 ds.Write(ItemNumber); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out SerialNum)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBKECandidateApplyResX : DBKECandidateApplyRes
    {
        public DBKECandidateApplyResX()
        {
             RetCode = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBKECandidateConfirmArgX : DBKECandidateConfirmArg
    {
        public DBKECandidateConfirmArgX()
        {
             CandidateList = new Vector<Int32>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CandidateList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)CandidateList) ;
        }
    }
      

    public class DBKECandidateConfirmResX : DBKECandidateConfirmRes
    {
        public DBKECandidateConfirmResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBKEVotingArgX : DBKEVotingArg
    {
        public DBKEVotingArgX()
        {
             RoleId = default(Int32);
 ItemId = default(UInt32);
 ItemPos = default(Int32);
 ItemNumber = default(Int32);
 CandidateRoleId = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(ItemId); 
 ds.Write(ItemPos); 
 ds.Write(ItemNumber); 
 ds.Write(CandidateRoleId); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out ItemId)  &&
 ds.TryRead(out ItemPos)  &&
 ds.TryRead(out ItemNumber)  &&
 ds.TryRead(out CandidateRoleId)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBKEVotingResX : DBKEVotingRes
    {
        public DBKEVotingResX()
        {
             RetCode = default(Int32);
 SyncData = new GMailSyncDataX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(SyncData); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)SyncData) ;
        }
    }
      

    public class DBKEKingConfirmArgX : DBKEKingConfirmArg
    {
        public DBKEKingConfirmArgX()
        {
             King = new KEKingX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(King); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)King) ;
        }
    }
      

    public class DBKEKingConfirmResX : DBKEKingConfirmRes
    {
        public DBKEKingConfirmResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBKEDeleteKingArgX : DBKEDeleteKingArg
    {
        public DBKEDeleteKingArgX()
        {
             KingRoleId = default(Int32);
 Reason = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(KingRoleId); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out KingRoleId)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class DBKEDeleteKingResX : DBKEDeleteKingRes
    {
        public DBKEDeleteKingResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBKEDeleteCandidateArgX : DBKEDeleteCandidateArg
    {
        public DBKEDeleteCandidateArgX()
        {
             CandidateList = new Vector<Int32>(); 
 Reason = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CandidateList); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)CandidateList)  &&
 ds.TryRead(out Reason) ;
        }
    }
      

    public class DBKEDeleteCandidateResX : DBKEDeleteCandidateRes
    {
        public DBKEDeleteCandidateResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class TankBattlePlayerScoreInfoX : TankBattlePlayerScoreInfo
    {
        public TankBattlePlayerScoreInfoX()
        {
             RoleId = default(Int32);
 KillCount = default(Int32);
 DeadCount = default(Int32);
 Score = default(Int32);
 Rank = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(KillCount); 
 ds.Write(DeadCount); 
 ds.Write(Score); 
 ds.Write(Rank); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out KillCount)  &&
 ds.TryRead(out DeadCount)  &&
 ds.TryRead(out Score)  &&
 ds.TryRead(out Rank) ;
        }
    }
      

    public class DBTankBattleBonusArgX : DBTankBattleBonusArg
    {
        public DBTankBattleBonusArgX()
        {
             RoleId = default(Int32);
 Rank = default(Int32);
 Money = default(UInt32);
 Item = new GRoleInventoryX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Rank); 
 ds.Write(Money); 
 ds.Write(Item); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Rank)  &&
 ds.TryRead(out Money)  &&
 ds.TryRead((IDataSerializer)Item) ;
        }
    }
      

    public class DBTankBattleBonusResX : DBTankBattleBonusRes
    {
        public DBTankBattleBonusResX()
        {
             RetCode = default(Int16);
 InformPlayer = new GMailHeaderX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(InformPlayer); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)InformPlayer) ;
        }
    }
      

    public class GGroupInfoX : GGroupInfo
    {
        public GGroupInfoX()
        {
             GId = default(Byte);
 Name = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GId); 
 ds.Write(Name); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GId)  &&
 ds.TryRead((IDataSerializer)Name) ;
        }
    }
      

    public class GFriendInfoX : GFriendInfo
    {
        public GFriendInfoX()
        {
             RId = default(Int32);
 Cls = default(Byte);
 GId = default(Byte);
 Name = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RId); 
 ds.Write(Cls); 
 ds.Write(GId); 
 ds.Write(Name); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RId)  &&
 ds.TryRead(out Cls)  &&
 ds.TryRead(out GId)  &&
 ds.TryRead((IDataSerializer)Name) ;
        }
    }
      

    public class GFriendListX : GFriendList
    {
        public GFriendListX()
        {
             Groups = new Vector<GGroupInfo, GGroupInfoX>(); 
 Friends = new Vector<GFriendInfo, GFriendInfoX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Groups); 
 ds.Write(Friends); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Groups)  &&
 ds.TryRead((IDataSerializer)Friends) ;
        }
    }
      

    public class FriendListPairX : FriendListPair
    {
        public FriendListPairX()
        {
             Key = new RoleIdX(); 
 Value = new GFriendListX(); 
 ExtraInfo = new Vector<GFriendExtInfo, GFriendExtInfoX>(); 
 SendMailInfo = new Vector<GSendAUMailRecord, GSendAUMailRecordX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Key); 
 ds.Write(Value); 
 ds.Write(ExtraInfo); 
 ds.Write(SendMailInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Key)  &&
 ds.TryRead((IDataSerializer)Value)  &&
 ds.TryRead((IDataSerializer)ExtraInfo)  &&
 ds.TryRead((IDataSerializer)SendMailInfo) ;
        }
    }
      

    public class FriendListResX : FriendListRes
    {
        public FriendListResX()
        {
             RetCode = default(Byte);
 Value = new GFriendListX(); 
 ExtraInfo = new Vector<GFriendExtInfo, GFriendExtInfoX>(); 
 SendMailInfo = new Vector<GSendAUMailRecord, GSendAUMailRecordX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Value); 
 ds.Write(ExtraInfo); 
 ds.Write(SendMailInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Value)  &&
 ds.TryRead((IDataSerializer)ExtraInfo)  &&
 ds.TryRead((IDataSerializer)SendMailInfo) ;
        }
    }
      

    public class GSendAUMailRecordX : GSendAUMailRecord
    {
        public GSendAUMailRecordX()
        {
             RId = default(Int32);
 SendMailTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RId); 
 ds.Write(SendMailTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RId)  &&
 ds.TryRead(out SendMailTime) ;
        }
    }
      

    public class GFriendExtInfoX : GFriendExtInfo
    {
        public GFriendExtInfoX()
        {
             UId = default(Int32);
 RId = default(Int32);
 Level = default(Int32);
 LastloginTime = default(Int32);
 UpdateTime = default(Int32);
 ReincarnationTimes = default(Byte);
 Reserved0 = default(Byte);
 Reserved1 = default(Int16);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UId); 
 ds.Write(RId); 
 ds.Write(Level); 
 ds.Write(LastloginTime); 
 ds.Write(UpdateTime); 
 ds.Write(ReincarnationTimes); 
 ds.Write(Reserved0); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UId)  &&
 ds.TryRead(out RId)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out LastloginTime)  &&
 ds.TryRead(out UpdateTime)  &&
 ds.TryRead(out ReincarnationTimes)  &&
 ds.TryRead(out Reserved0)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3) ;
        }
    }
      

    public class GFriendExtraX : GFriendExtra
    {
        public GFriendExtraX()
        {
             FriendExtInfo = new Vector<GFriendExtInfo, GFriendExtInfoX>(); 
 SendaumailInfo = new Vector<GSendAUMailRecord, GSendAUMailRecordX>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FriendExtInfo); 
 ds.Write(SendaumailInfo); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FriendExtInfo)  &&
 ds.TryRead((IDataSerializer)SendaumailInfo)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5) ;
        }
    }
      

    public class AddFriendRqstArgX : AddFriendRqstArg
    {
        public AddFriendRqstArgX()
        {
             SrcroleId = default(Int32);
 SrcName = new Octets(); 
 DstlSId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(SrcroleId); 
 ds.Write(SrcName); 
 ds.Write(DstlSId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out SrcroleId)  &&
 ds.TryRead((IDataSerializer)SrcName)  &&
 ds.TryRead(out DstlSId) ;
        }
    }
      

    public class AddFriendRqstResX : AddFriendRqstRes
    {
        public AddFriendRqstResX()
        {
             RetCode = default(Byte);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class MessageX : Message
    {
        public MessageX()
        {
             Channel = default(Byte);
 SrcName = new Octets(); 
 SrcroleId = default(Int32);
 DstName = new Octets(); 
 DstroleId = default(Int32);
 Text = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Channel); 
 ds.Write(SrcName); 
 ds.Write(SrcroleId); 
 ds.Write(DstName); 
 ds.Write(DstroleId); 
 ds.Write(Text); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Channel)  &&
 ds.TryRead((IDataSerializer)SrcName)  &&
 ds.TryRead(out SrcroleId)  &&
 ds.TryRead((IDataSerializer)DstName)  &&
 ds.TryRead(out DstroleId)  &&
 ds.TryRead((IDataSerializer)Text) ;
        }
    }
      

    public class GetMessageResX : GetMessageRes
    {
        public GetMessageResX()
        {
             RetCode = default(Byte);
 Messages = new Vector<Message, MessageX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Messages); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Messages) ;
        }
    }
      

    public class GChatMemberX : GChatMember
    {
        public GChatMemberX()
        {
             RoleId = default(Int32);
 Name = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Name); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Name) ;
        }
    }
      

    public class GRoomDetailX : GRoomDetail
    {
        public GRoomDetailX()
        {
             RoomId = default(UInt16);
 Subject = new Octets(); 
 Owner = new Octets(); 
 Capacity = default(UInt16);
 Status = default(Boolean);
 Members = new Vector<GChatMember, GChatMemberX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoomId); 
 ds.Write(Subject); 
 ds.Write(Owner); 
 ds.Write(Capacity); 
 ds.Write(Status); 
 ds.Write(Members); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoomId)  &&
 ds.TryRead((IDataSerializer)Subject)  &&
 ds.TryRead((IDataSerializer)Owner)  &&
 ds.TryRead(out Capacity)  &&
 ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)Members) ;
        }
    }
      

    public class GChatRoomX : GChatRoom
    {
        public GChatRoomX()
        {
             RoomId = default(UInt16);
 Subject = new Octets(); 
 Owner = new Octets(); 
 Capacity = default(UInt16);
 Number = default(UInt16);
 Status = default(Boolean);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoomId); 
 ds.Write(Subject); 
 ds.Write(Owner); 
 ds.Write(Capacity); 
 ds.Write(Number); 
 ds.Write(Status); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoomId)  &&
 ds.TryRead((IDataSerializer)Subject)  &&
 ds.TryRead((IDataSerializer)Owner)  &&
 ds.TryRead(out Capacity)  &&
 ds.TryRead(out Number)  &&
 ds.TryRead(out Status) ;
        }
    }
      

    public class GRefStoreX : GRefStore
    {
        public GRefStoreX()
        {
             BonusAdd = default(Int32);
 BonusUsed = default(Int32);
 Referrer = default(Int32);
 ReferrerRoleId = default(Int32);
 BonusTotal1 = default(Int32);
 BonusTotal2 = default(Int32);
 BonusWithdraw = default(Int32);
 BonusWithdrawToday = default(Int32);
 MaxRoleLevel = default(Int32);
 Rolenames = new Vector<Octets>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
 Reserved5 = default(Int32);
 Reserved6 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(BonusAdd); 
 ds.Write(BonusUsed); 
 ds.Write(Referrer); 
 ds.Write(ReferrerRoleId); 
 ds.Write(BonusTotal1); 
 ds.Write(BonusTotal2); 
 ds.Write(BonusWithdraw); 
 ds.Write(BonusWithdrawToday); 
 ds.Write(MaxRoleLevel); 
 ds.Write(Rolenames); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
 ds.Write(Reserved5); 
 ds.Write(Reserved6); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out BonusAdd)  &&
 ds.TryRead(out BonusUsed)  &&
 ds.TryRead(out Referrer)  &&
 ds.TryRead(out ReferrerRoleId)  &&
 ds.TryRead(out BonusTotal1)  &&
 ds.TryRead(out BonusTotal2)  &&
 ds.TryRead(out BonusWithdraw)  &&
 ds.TryRead(out BonusWithdrawToday)  &&
 ds.TryRead(out MaxRoleLevel)  &&
 ds.TryRead((IDataSerializer)Rolenames)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4)  &&
 ds.TryRead(out Reserved5)  &&
 ds.TryRead(out Reserved6) ;
        }
    }
      

    public class GReferrerX : GReferrer
    {
        public GReferrerX()
        {
             UserID = default(Int32);
 BonusAdd = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(BonusAdd); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out BonusAdd) ;
        }
    }
      

    public class GReferralX : GReferral
    {
        public GReferralX()
        {
             UserID = default(Int32);
 BonusTotal1 = default(Int32);
 BonusTotal2 = default(Int32);
 BonusWithdraw = default(Int32);
 BonusWithdrawToday = default(Int32);
 MaxRoleLevel = default(Int32);
 Rolenames = new Vector<Octets>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(BonusTotal1); 
 ds.Write(BonusTotal2); 
 ds.Write(BonusWithdraw); 
 ds.Write(BonusWithdrawToday); 
 ds.Write(MaxRoleLevel); 
 ds.Write(Rolenames); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead(out BonusTotal1)  &&
 ds.TryRead(out BonusTotal2)  &&
 ds.TryRead(out BonusWithdraw)  &&
 ds.TryRead(out BonusWithdrawToday)  &&
 ds.TryRead(out MaxRoleLevel)  &&
 ds.TryRead((IDataSerializer)Rolenames) ;
        }
    }
      

    public class ReferralBriefX : ReferralBrief
    {
        public ReferralBriefX()
        {
             Rolenames = new Vector<Octets>(); 
 MaxLevel = default(Int32);
 BonusTotal1 = default(Int32);
 BonusTotal2 = default(Int32);
 BonusLeft = default(Int32);
 BonusAvail = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Rolenames); 
 ds.Write(MaxLevel); 
 ds.Write(BonusTotal1); 
 ds.Write(BonusTotal2); 
 ds.Write(BonusLeft); 
 ds.Write(BonusAvail); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Rolenames)  &&
 ds.TryRead(out MaxLevel)  &&
 ds.TryRead(out BonusTotal1)  &&
 ds.TryRead(out BonusTotal2)  &&
 ds.TryRead(out BonusLeft)  &&
 ds.TryRead(out BonusAvail) ;
        }
    }
      

    public class DBRefWithdrawTransArgX : DBRefWithdrawTransArg
    {
        public DBRefWithdrawTransArgX()
        {
             RoleId = default(Int32);
 Referrer = new GReferrerX(); 
 Referrals = new Vector<GReferral, GReferralX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Referrer); 
 ds.Write(Referrals); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Referrer)  &&
 ds.TryRead((IDataSerializer)Referrals) ;
        }
    }
      

    public class DBRefGetReferralResX : DBRefGetReferralRes
    {
        public DBRefGetReferralResX()
        {
             RetCode = default(Int32);
 Referral = new GReferralX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Referral); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Referral) ;
        }
    }
      

    public class DBRefGetReferrerResX : DBRefGetReferrerRes
    {
        public DBRefGetReferrerResX()
        {
             RetCode = default(Int32);
 Referrer = new GReferrerX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Referrer); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Referrer) ;
        }
    }
      

    public class DBRefUpdateReferralArgX : DBRefUpdateReferralArg
    {
        public DBRefUpdateReferralArgX()
        {
             Referral = new GReferralX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Referral); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Referral) ;
        }
    }
      

    public class DBRefUpdateReferrerArgX : DBRefUpdateReferrerArg
    {
        public DBRefUpdateReferrerArgX()
        {
             Referrer = new GReferrerX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Referrer); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Referrer) ;
        }
    }
      

    public class GRewardItemX : GRewardItem
    {
        public GRewardItemX()
        {
             RewardTime = default(Int32);
 RewardBonus = default(Int32);
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RewardTime); 
 ds.Write(RewardBonus); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RewardTime)  &&
 ds.TryRead(out RewardBonus)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4) ;
        }
    }
      

    public class GRewardStoreX : GRewardStore
    {
        public GRewardStoreX()
        {
             ConsumePoints = default(Int32);
 BonusReward = default(Int32);
 RewardList = new Vector<GRewardItem, GRewardItemX>(); 
 Reserved1 = default(Int32);
 Reserved2 = default(Int32);
 Reserved3 = default(Int32);
 Reserved4 = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ConsumePoints); 
 ds.Write(BonusReward); 
 ds.Write(RewardList); 
 ds.Write(Reserved1); 
 ds.Write(Reserved2); 
 ds.Write(Reserved3); 
 ds.Write(Reserved4); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ConsumePoints)  &&
 ds.TryRead(out BonusReward)  &&
 ds.TryRead((IDataSerializer)RewardList)  &&
 ds.TryRead(out Reserved1)  &&
 ds.TryRead(out Reserved2)  &&
 ds.TryRead(out Reserved3)  &&
 ds.TryRead(out Reserved4) ;
        }
    }
      

    public class RewardItemX : RewardItem
    {
        public RewardItemX()
        {
             RewardTime = default(Int32);
 RewardBonus = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RewardTime); 
 ds.Write(RewardBonus); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RewardTime)  &&
 ds.TryRead(out RewardBonus) ;
        }
    }
      

    public class DBGetRewardArgX : DBGetRewardArg
    {
        public DBGetRewardArgX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID) ;
        }
    }
      

    public class DBGetRewardResX : DBGetRewardRes
    {
        public DBGetRewardResX()
        {
             RetCode = default(Int32);
 Reward = new GRewardStoreX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Reward); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Reward) ;
        }
    }
      

    public class DBPutConsumePointsArgX : DBPutConsumePointsArg
    {
        public DBPutConsumePointsArgX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
 ConsumePoints = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(ConsumePoints); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out ConsumePoints) ;
        }
    }
      

    public class DBPutRewardBonusArgX : DBPutRewardBonusArg
    {
        public DBPutRewardBonusArgX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
 BonusReward = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(BonusReward); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out BonusReward) ;
        }
    }
      

    public class DBRewardMatureArgX : DBRewardMatureArg
    {
        public DBRewardMatureArgX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
 BonusReward = default(Int32);
 RewardList = new Vector<GRewardItem, GRewardItemX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(BonusReward); 
 ds.Write(RewardList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out BonusReward)  &&
 ds.TryRead((IDataSerializer)RewardList) ;
        }
    }
      

    public class DBRewardMatureResX : DBRewardMatureRes
    {
        public DBRewardMatureResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class DBExchangeConsumePointsArgX : DBExchangeConsumePointsArg
    {
        public DBExchangeConsumePointsArgX()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
 ConsumePoints = default(Int32);
 RewardList = new Vector<GRewardItem, GRewardItemX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(ConsumePoints); 
 ds.Write(RewardList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out ConsumePoints)  &&
 ds.TryRead((IDataSerializer)RewardList) ;
        }
    }
      

    public class DBExchangeConsumePointsResX : DBExchangeConsumePointsRes
    {
        public DBExchangeConsumePointsResX()
        {
             RetCode = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode) ;
        }
    }
      

    public class ACQX : ACQ
    {
        public ACQX()
        {
             QueryType = default(Int32);
 ZoneId = default(Int32);
 RoleId = default(Int32);
 XId = default(Int32);
 Timeout = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(QueryType); 
 ds.Write(ZoneId); 
 ds.Write(RoleId); 
 ds.Write(XId); 
 ds.Write(Timeout); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out QueryType)  &&
 ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead(out XId)  &&
 ds.TryRead(out Timeout) ;
        }
    }
      

    public class IntDataX : IntData
    {
        public IntDataX()
        {
             IntValue = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(IntValue); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out IntValue) ;
        }
    }
      

    public class OctetsDataX : OctetsData
    {
        public OctetsDataX()
        {
             OctetsValue = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(OctetsValue); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)OctetsValue) ;
        }
    }
      

    public class ACLogInfoX : ACLogInfo
    {
        public ACLogInfoX()
        {
             Type = default(Int32);
 SubId = default(Int32);
 LogTime = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Type); 
 ds.Write(SubId); 
 ds.Write(LogTime); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Type)  &&
 ds.TryRead(out SubId)  &&
 ds.TryRead(out LogTime) ;
        }
    }
      

    public class ACCodeResX : ACCodeRes
    {
        public ACCodeResX()
        {
             CodeId = default(Int16);
 Res = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CodeId); 
 ds.Write(Res); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out CodeId)  &&
 ds.TryRead(out Res) ;
        }
    }
      

    public class ACUserCodeResX : ACUserCodeRes
    {
        public ACUserCodeResX()
        {
             Count = default(Int16);
 Type = default(Int16);
 Res = new Vector<ACCodeRes, ACCodeResX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Count); 
 ds.Write(Type); 
 ds.Write(Res); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Count)  &&
 ds.TryRead(out Type)  &&
 ds.TryRead((IDataSerializer)Res) ;
        }
    }
      

    public class ACStackPatternX : ACStackPattern
    {
        public ACStackPatternX()
        {
             Caller = default(Int32);
 Size = default(Int32);
 Pattern = default(Int32);
 Count = default(Int32);
 CountHd = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Caller); 
 ds.Write(Size); 
 ds.Write(Pattern); 
 ds.Write(Count); 
 ds.Write(CountHd); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Caller)  &&
 ds.TryRead(out Size)  &&
 ds.TryRead(out Pattern)  &&
 ds.TryRead(out Count)  &&
 ds.TryRead(out CountHd) ;
        }
    }
      

    public class ACPlatformInfoX : ACPlatformInfo
    {
        public ACPlatformInfoX()
        {
             Id = default(Int32);
 MajorVersion = default(Int32);
 MinorVersion = default(Int32);
 BuildNumber = default(Int32);
 Count = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Id); 
 ds.Write(MajorVersion); 
 ds.Write(MinorVersion); 
 ds.Write(BuildNumber); 
 ds.Write(Count); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Id)  &&
 ds.TryRead(out MajorVersion)  &&
 ds.TryRead(out MinorVersion)  &&
 ds.TryRead(out BuildNumber)  &&
 ds.TryRead(out Count) ;
        }
    }
      

    public class ACCPUInfoX : ACCPUInfo
    {
        public ACCPUInfoX()
        {
             Arch = default(Int16);
 Level = default(Int16);
 Ct = default(Int32);
 Count = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Arch); 
 ds.Write(Level); 
 ds.Write(Ct); 
 ds.Write(Count); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Arch)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead(out Ct)  &&
 ds.TryRead(out Count) ;
        }
    }
      

    public class ACMemInfoX : ACMemInfo
    {
        public ACMemInfoX()
        {
             Ct = default(Int32);
 Count = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Ct); 
 ds.Write(Count); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Ct)  &&
 ds.TryRead(out Count) ;
        }
    }
      

    public class ACAdapterInfoX : ACAdapterInfo
    {
        public ACAdapterInfoX()
        {
             Des = new Octets(); 
 Count = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Des); 
 ds.Write(Count); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Des)  &&
 ds.TryRead(out Count) ;
        }
    }
      

    public class ACMouseInfoX : ACMouseInfo
    {
        public ACMouseInfoX()
        {
             LButtonFreq = default(Int32);
 RButtonFreq = default(Int32);
 MouseMovefreq = default(Int32);
 MouseMovevelo = default(Single);
 GCounts = new Vector<IntData, IntDataX>(); 
 GTimes = new Vector<IntData, IntDataX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(LButtonFreq); 
 ds.Write(RButtonFreq); 
 ds.Write(MouseMovefreq); 
 ds.Write(MouseMovevelo); 
 ds.Write(GCounts); 
 ds.Write(GTimes); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out LButtonFreq)  &&
 ds.TryRead(out RButtonFreq)  &&
 ds.TryRead(out MouseMovefreq)  &&
 ds.TryRead(out MouseMovevelo)  &&
 ds.TryRead((IDataSerializer)GCounts)  &&
 ds.TryRead((IDataSerializer)GTimes) ;
        }
    }
      

    public class ACThreadTimeX : ACThreadTime
    {
        public ACThreadTimeX()
        {
             ThreadId = default(Int32);
 AllSecs = default(Int32);
 KernelSecs = default(Int32);
 UserSecs = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ThreadId); 
 ds.Write(AllSecs); 
 ds.Write(KernelSecs); 
 ds.Write(UserSecs); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ThreadId)  &&
 ds.TryRead(out AllSecs)  &&
 ds.TryRead(out KernelSecs)  &&
 ds.TryRead(out UserSecs) ;
        }
    }
      

    public class ACProtocolStatX : ACProtocolStat
    {
        public ACProtocolStatX()
        {
             Keepalive = default(Int32);
 GameDataSend = default(Int32);
 Acreport = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Keepalive); 
 ds.Write(GameDataSend); 
 ds.Write(Acreport); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Keepalive)  &&
 ds.TryRead(out GameDataSend)  &&
 ds.TryRead(out Acreport) ;
        }
    }
      

    public class ACOnlineStatusX : ACOnlineStatus
    {
        public ACOnlineStatusX()
        {
             RoleId = default(Int32);
 Ip = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Ip); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out Ip) ;
        }
    }
      

    public class ACOnlineStatus2X : ACOnlineStatus2
    {
        public ACOnlineStatus2X()
        {
             RoleId = default(Int32);
 UserID = default(Int32);
 Ip = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(UserID); 
 ds.Write(Ip); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Ip) ;
        }
    }
      

    public class ForbidUserArgX : ForbidUserArg
    {
        public ForbidUserArgX()
        {
             Operation = default(Byte);
 GmUserId = default(Int32);
 Source = default(Int32);
 UserID = default(Int32);
 Time = default(Int32);
 Reason = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Operation); 
 ds.Write(GmUserId); 
 ds.Write(Source); 
 ds.Write(UserID); 
 ds.Write(Time); 
 ds.Write(Reason); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Operation)  &&
 ds.TryRead(out GmUserId)  &&
 ds.TryRead(out Source)  &&
 ds.TryRead(out UserID)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead((IDataSerializer)Reason) ;
        }
    }
      

    public class ForbidUserResX : ForbidUserRes
    {
        public ForbidUserResX()
        {
             RetCode = default(Int32);
 Forbid = new GRoleForbidX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Forbid); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Forbid) ;
        }
    }
      

    public class DBAutolockSetArgX : DBAutolockSetArg
    {
        public DBAutolockSetArgX()
        {
             UserID = default(Int32);
 AutoLock = new Vector<GPair, GPairX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
 ds.Write(AutoLock); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID)  &&
 ds.TryRead((IDataSerializer)AutoLock) ;
        }
    }
      

    public class RoleImportBeanX : RoleImportBean
    {
        public RoleImportBeanX()
        {
             UId = default(Int64);
 RoleId = default(Int64);
 RoleName = new Octets(); 
 Gender = default(Byte);
 Race = default(Int32);
 Occupation = default(Int32);
 Level = default(Int32);
 ExtInfo = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UId); 
 ds.Write(RoleId); 
 ds.Write(RoleName); 
 ds.Write(Gender); 
 ds.Write(Race); 
 ds.Write(Occupation); 
 ds.Write(Level); 
 ds.Write(ExtInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead(out Race)  &&
 ds.TryRead(out Occupation)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead((IDataSerializer)ExtInfo) ;
        }
    }
      

    public class GroupBeanX : GroupBean
    {
        public GroupBeanX()
        {
             GType = default(Int32);
 GroupId = default(Int64);
 GroupName = new Octets(); 
 FriendList = new Vector<Int64>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GType); 
 ds.Write(GroupId); 
 ds.Write(GroupName); 
 ds.Write(FriendList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GType)  &&
 ds.TryRead(out GroupId)  &&
 ds.TryRead((IDataSerializer)GroupName)  &&
 ds.TryRead((IDataSerializer)FriendList) ;
        }
    }
      

    public class FriendImportBeanX : FriendImportBean
    {
        public FriendImportBeanX()
        {
             ZoneId = default(Int32);
 RoleId = default(Int64);
 Friends = new Vector<GroupBean, GroupBeanX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(ZoneId); 
 ds.Write(RoleId); 
 ds.Write(Friends); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out ZoneId)  &&
 ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Friends) ;
        }
    }
      

    public class TitleBeanX : TitleBean
    {
        public TitleBeanX()
        {
             TitleId = default(Int32);
 TitleName = new Octets(); 
 Members = new Vector<Int64>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TitleId); 
 ds.Write(TitleName); 
 ds.Write(Members); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TitleId)  &&
 ds.TryRead((IDataSerializer)TitleName)  &&
 ds.TryRead((IDataSerializer)Members) ;
        }
    }
      

    public class FactionImportBeanX : FactionImportBean
    {
        public FactionImportBeanX()
        {
             FType = default(Int32);
 FactionId = default(Int64);
 FactionName = new Octets(); 
 Announcement = new Octets(); 
 ExtInfo = new Octets(); 
 Members = new Vector<TitleBean, TitleBeanX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FType); 
 ds.Write(FactionId); 
 ds.Write(FactionName); 
 ds.Write(Announcement); 
 ds.Write(ExtInfo); 
 ds.Write(Members); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FType)  &&
 ds.TryRead(out FactionId)  &&
 ds.TryRead((IDataSerializer)FactionName)  &&
 ds.TryRead((IDataSerializer)Announcement)  &&
 ds.TryRead((IDataSerializer)ExtInfo)  &&
 ds.TryRead((IDataSerializer)Members) ;
        }
    }
      

    public class RoleInfoBeanX : RoleInfoBean
    {
        public RoleInfoBeanX()
        {
             RoleId = default(Int64);
 RoleName = new Octets(); 
 Gender = default(Byte);
 Race = default(Int32);
 Occupation = default(Int32);
 Level = default(Int32);
 ExtInfo = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(RoleName); 
 ds.Write(Gender); 
 ds.Write(Race); 
 ds.Write(Occupation); 
 ds.Write(Level); 
 ds.Write(ExtInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)RoleName)  &&
 ds.TryRead(out Gender)  &&
 ds.TryRead(out Race)  &&
 ds.TryRead(out Occupation)  &&
 ds.TryRead(out Level)  &&
 ds.TryRead((IDataSerializer)ExtInfo) ;
        }
    }
      

    public class RoleStatusBeanX : RoleStatusBean
    {
        public RoleStatusBeanX()
        {
             Status = default(Boolean);
 ExtInfo = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
 ds.Write(ExtInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Status)  &&
 ds.TryRead((IDataSerializer)ExtInfo) ;
        }
    }
      

    public class RoleBeanX : RoleBean
    {
        public RoleBeanX()
        {
             Info = new RoleInfoBeanX(); 
 Status = new RoleStatusBeanX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Info); 
 ds.Write(Status); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead((IDataSerializer)Status) ;
        }
    }
      

    public class RoleGroupBeanX : RoleGroupBean
    {
        public RoleGroupBeanX()
        {
             GType = default(Int32);
 GroupId = default(Int64);
 GroupName = new Octets(); 
 Friends = new Vector<RoleBean, RoleBeanX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GType); 
 ds.Write(GroupId); 
 ds.Write(GroupName); 
 ds.Write(Friends); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GType)  &&
 ds.TryRead(out GroupId)  &&
 ds.TryRead((IDataSerializer)GroupName)  &&
 ds.TryRead((IDataSerializer)Friends) ;
        }
    }
      

    public class RoleMsgBeanX : RoleMsgBean
    {
        public RoleMsgBeanX()
        {
             Sender = default(Int64);
 SenderName = new Octets(); 
 Time = default(Int64);
 EmotionGroup = default(Int32);
 Content = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Sender); 
 ds.Write(SenderName); 
 ds.Write(Time); 
 ds.Write(EmotionGroup); 
 ds.Write(Content); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Sender)  &&
 ds.TryRead((IDataSerializer)SenderName)  &&
 ds.TryRead(out Time)  &&
 ds.TryRead(out EmotionGroup)  &&
 ds.TryRead((IDataSerializer)Content) ;
        }
    }
      

    public class FactionIDBeanX : FactionIDBean
    {
        public FactionIDBeanX()
        {
             FType = default(Int32);
 FactionId = default(Int64);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FType); 
 ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FType)  &&
 ds.TryRead(out FactionId) ;
        }
    }
      

    public class FactionInfoBeanX : FactionInfoBean
    {
        public FactionInfoBeanX()
        {
             FactionName = new Octets(); 
 Announcement = new Octets(); 
 ExtInfo = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionName); 
 ds.Write(Announcement); 
 ds.Write(ExtInfo); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)FactionName)  &&
 ds.TryRead((IDataSerializer)Announcement)  &&
 ds.TryRead((IDataSerializer)ExtInfo) ;
        }
    }
      

    public class FactionTitleBeanX : FactionTitleBean
    {
        public FactionTitleBeanX()
        {
             TitleId = default(Int32);
 TitleName = new Octets(); 
 Titlemembers = new Vector<RoleBean, RoleBeanX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TitleId); 
 ds.Write(TitleName); 
 ds.Write(Titlemembers); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TitleId)  &&
 ds.TryRead((IDataSerializer)TitleName)  &&
 ds.TryRead((IDataSerializer)Titlemembers) ;
        }
    }
      

    public class FactionExtX : FactionExt
    {
        public FactionExtX()
        {
             Level = default(Int32);
 Exp = default(Int32);
 FortressLvl = default(Int32);
 Health = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Level); 
 ds.Write(Exp); 
 ds.Write(FortressLvl); 
 ds.Write(Health); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Level)  &&
 ds.TryRead(out Exp)  &&
 ds.TryRead(out FortressLvl)  &&
 ds.TryRead(out Health) ;
        }
    }
      

    public class CityWarX : CityWar
    {
        public CityWarX()
        {
             CityList = new Vector<GCity, GCityX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CityList); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)CityList) ;
        }
    }
      

    public class TeamBeanX : TeamBean
    {
        public TeamBeanX()
        {
             TeamId = default(Int64);
 Captain = default(Int64);
 Members = new Vector<Int64>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(TeamId); 
 ds.Write(Captain); 
 ds.Write(Members); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out TeamId)  &&
 ds.TryRead(out Captain)  &&
 ds.TryRead((IDataSerializer)Members) ;
        }
    }
      

    public class DBGameTalkRoleListArgX : DBGameTalkRoleListArg
    {
        public DBGameTalkRoleListArgX()
        {
             UserID = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out UserID) ;
        }
    }
      

    public class DBGameTalkRoleRelationArgX : DBGameTalkRoleRelationArg
    {
        public DBGameTalkRoleRelationArgX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class DBRoleBaseX : DBRoleBase
    {
        public DBRoleBaseX()
        {
             RoleId = default(Int32);
 Name = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
 ds.Write(Name); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId)  &&
 ds.TryRead((IDataSerializer)Name) ;
        }
    }
      

    public class DBRoleGroupX : DBRoleGroup
    {
        public DBRoleGroupX()
        {
             GType = default(Int32);
 Id = default(Byte);
 Name = new Octets(); 
 Friends = new Vector<DBRoleBase, DBRoleBaseX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(GType); 
 ds.Write(Id); 
 ds.Write(Name); 
 ds.Write(Friends); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out GType)  &&
 ds.TryRead(out Id)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)Friends) ;
        }
    }
      

    public class DBGameTalkRoleRelationResX : DBGameTalkRoleRelationRes
    {
        public DBGameTalkRoleRelationResX()
        {
             RetCode = default(Int32);
 Info = new RoleBeanX(); 
 Factions = new Vector<FactionIDBean, FactionIDBeanX>(); 
 Groups = new Vector<DBRoleGroup, DBRoleGroupX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Info); 
 ds.Write(Factions); 
 ds.Write(Groups); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead((IDataSerializer)Factions)  &&
 ds.TryRead((IDataSerializer)Groups) ;
        }
    }
      

    public class DBGameTalkFactionInfoArgX : DBGameTalkFactionInfoArg
    {
        public DBGameTalkFactionInfoArgX()
        {
             FactionId = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out FactionId) ;
        }
    }
      

    public class DBFactionMemberX : DBFactionMember
    {
        public DBFactionMemberX()
        {
             Info = new DBRoleBaseX(); 
 Title = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Info); 
 ds.Write(Title); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead((IDataSerializer)Info)  &&
 ds.TryRead(out Title) ;
        }
    }
      

    public class DBGameTalkFactionInfoResX : DBGameTalkFactionInfoRes
    {
        public DBGameTalkFactionInfoResX()
        {
             RetCode = default(Int32);
 Name = new Octets(); 
 Announce = new Octets(); 
 ExInfo = new Octets(); 
 Members = new Vector<DBFactionMember, DBFactionMemberX>(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Name); 
 ds.Write(Announce); 
 ds.Write(ExInfo); 
 ds.Write(Members); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Name)  &&
 ds.TryRead((IDataSerializer)Announce)  &&
 ds.TryRead((IDataSerializer)ExInfo)  &&
 ds.TryRead((IDataSerializer)Members) ;
        }
    }
      

    public class DBGameTalkRoleStatusArgX : DBGameTalkRoleStatusArg
    {
        public DBGameTalkRoleStatusArgX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class DBGameTalkRoleStatusResX : DBGameTalkRoleStatusRes
    {
        public DBGameTalkRoleStatusResX()
        {
             Status = default(Int32);
 ForbidTime = default(Int64);
 UserID = default(UInt32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Status); 
 ds.Write(ForbidTime); 
 ds.Write(UserID); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Status)  &&
 ds.TryRead(out ForbidTime)  &&
 ds.TryRead(out UserID) ;
        }
    }
      

    public class DBGameTalkRoleInfoArgX : DBGameTalkRoleInfoArg
    {
        public DBGameTalkRoleInfoArgX()
        {
             RoleId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RoleId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RoleId) ;
        }
    }
      

    public class DBGameTalkRoleInfoResX : DBGameTalkRoleInfoRes
    {
        public DBGameTalkRoleInfoResX()
        {
             RetCode = default(Int32);
 Info = new RoleInfoBeanX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(RetCode); 
 ds.Write(Info); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out RetCode)  &&
 ds.TryRead((IDataSerializer)Info) ;
        }
    }
      

    public class SNSRoleBriefX : SNSRoleBrief
    {
        public SNSRoleBriefX()
        {
             Level = default(Int32);
 Exp = default(Int32);
 Sp = default(Int32);
 Level2 = default(Int32);
 Reputation = default(Int32);
 Pp = default(Int32);
 Vitality = default(Int32);
 Energy = default(Int32);
 Strength = default(Int32);
 Agility = default(Int32);
 MaxHp = default(Int32);
 MaxMp = default(Int32);
 RunSpeed = default(Single);
 Attack = default(Int32);
 DamageLow = default(Int32);
 DamageHigh = default(Int32);
 AttackSpeed = default(Int32);
 AttackRange = default(Single);
 DamageMagicLow = default(Int32);
 DamageMagicHigh = default(Int32);
 Resistance0 = default(Int32);
 Resistance1 = default(Int32);
 Resistance2 = default(Int32);
 Resistance3 = default(Int32);
 Resistance4 = default(Int32);
 Defense = default(Int32);
 Armor = default(Int32);
 CritRate = default(Int32);
 CritDamage = default(Int32);
 AttackDegree = default(Int32);
 DefendDegree = default(Int32);
 InvisibleDegree = default(Int32);
 AntiInvisibleDegree = default(Int32);
 SoulPower = default(Int32);
 SkillsCRC = default(UInt32);
 EquipmentCRC = default(UInt32);
 PetcorralCRC = default(UInt32);
 Spouse = default(Int32);
 FactionId = default(Int32);
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(Level); 
 ds.Write(Exp); 
 ds.Write(Sp); 
 ds.Write(Level2); 
 ds.Write(Reputation); 
 ds.Write(Pp); 
 ds.Write(Vitality); 
 ds.Write(Energy); 
 ds.Write(Strength); 
 ds.Write(Agility); 
 ds.Write(MaxHp); 
 ds.Write(MaxMp); 
 ds.Write(RunSpeed); 
 ds.Write(Attack); 
 ds.Write(DamageLow); 
 ds.Write(DamageHigh); 
 ds.Write(AttackSpeed); 
 ds.Write(AttackRange); 
 ds.Write(DamageMagicLow); 
 ds.Write(DamageMagicHigh); 
 ds.Write(Resistance0); 
 ds.Write(Resistance1); 
 ds.Write(Resistance2); 
 ds.Write(Resistance3); 
 ds.Write(Resistance4); 
 ds.Write(Defense); 
 ds.Write(Armor); 
 ds.Write(CritRate); 
 ds.Write(CritDamage); 
 ds.Write(AttackDegree); 
 ds.Write(DefendDegree); 
 ds.Write(InvisibleDegree); 
 ds.Write(AntiInvisibleDegree); 
 ds.Write(SoulPower); 
 ds.Write(SkillsCRC); 
 ds.Write(EquipmentCRC); 
 ds.Write(PetcorralCRC); 
 ds.Write(Spouse); 
 ds.Write(FactionId); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out Level)  &&
 ds.TryRead(out Exp)  &&
 ds.TryRead(out Sp)  &&
 ds.TryRead(out Level2)  &&
 ds.TryRead(out Reputation)  &&
 ds.TryRead(out Pp)  &&
 ds.TryRead(out Vitality)  &&
 ds.TryRead(out Energy)  &&
 ds.TryRead(out Strength)  &&
 ds.TryRead(out Agility)  &&
 ds.TryRead(out MaxHp)  &&
 ds.TryRead(out MaxMp)  &&
 ds.TryRead(out RunSpeed)  &&
 ds.TryRead(out Attack)  &&
 ds.TryRead(out DamageLow)  &&
 ds.TryRead(out DamageHigh)  &&
 ds.TryRead(out AttackSpeed)  &&
 ds.TryRead(out AttackRange)  &&
 ds.TryRead(out DamageMagicLow)  &&
 ds.TryRead(out DamageMagicHigh)  &&
 ds.TryRead(out Resistance0)  &&
 ds.TryRead(out Resistance1)  &&
 ds.TryRead(out Resistance2)  &&
 ds.TryRead(out Resistance3)  &&
 ds.TryRead(out Resistance4)  &&
 ds.TryRead(out Defense)  &&
 ds.TryRead(out Armor)  &&
 ds.TryRead(out CritRate)  &&
 ds.TryRead(out CritDamage)  &&
 ds.TryRead(out AttackDegree)  &&
 ds.TryRead(out DefendDegree)  &&
 ds.TryRead(out InvisibleDegree)  &&
 ds.TryRead(out AntiInvisibleDegree)  &&
 ds.TryRead(out SoulPower)  &&
 ds.TryRead(out SkillsCRC)  &&
 ds.TryRead(out EquipmentCRC)  &&
 ds.TryRead(out PetcorralCRC)  &&
 ds.TryRead(out Spouse)  &&
 ds.TryRead(out FactionId) ;
        }
    }
      

    public class SNSRoleSkillsX : SNSRoleSkills
    {
        public SNSRoleSkillsX()
        {
             CRC = default(UInt32);
 Skills = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CRC); 
 ds.Write(Skills); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out CRC)  &&
 ds.TryRead((IDataSerializer)Skills) ;
        }
    }
      

    public class SNSRoleEquipmentX : SNSRoleEquipment
    {
        public SNSRoleEquipmentX()
        {
             CRC = default(UInt32);
 Equipment = new GRoleEquipmentX(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CRC); 
 ds.Write(Equipment); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out CRC)  &&
 ds.TryRead((IDataSerializer)Equipment) ;
        }
    }
      

    public class SNSRolePetCorralX : SNSRolePetCorral
    {
        public SNSRolePetCorralX()
        {
             CRC = default(UInt32);
 Petcorral = new Octets(); 
        }

        public override DataStream Serialize(DataStream ds)
        {
             ds.Write(CRC); 
 ds.Write(Petcorral); 
return ds;
        }
        public override bool TryDeserialize(DataStream ds)
        {
            return  ds.TryRead(out CRC)  &&
 ds.TryRead((IDataSerializer)Petcorral) ;
        }
    }
      
      }
    