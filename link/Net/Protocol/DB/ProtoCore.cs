
      using System;
      using Link.IO;

      namespace Link.Net.Protocol.Core
      {
      
        public abstract class Challenge : IDataSerializer
        {
         public Octets Nonce; 
 public UInt32? Version; 
 public Byte? Algo; 
 public Octets Edition; 
 public Byte? ExpRate; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KeyExchange : IDataSerializer
        {
         public Octets Nonce; 
 public Boolean? KickUser; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Response : IDataSerializer
        {
         public Octets Identity; 
 public Octets Key; 
 public Boolean? UseToken; 
 public Octets CliFingerprint; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class OnlineAnnounce : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 
 public Int32? RemainTime; 
 public Byte? ZoneId; 
 public Int32? FreeTimeLeft; 
 public Int32? FreeTimeEnd; 
 public Int32? CreateTime; 
 public Boolean? ReferrerFlag; 
 public Boolean? PasswdFlag; 
 public Byte? UsbBind; 
 public Boolean? AccountinfoFlag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ErrorInfo : IDataSerializer
        {
         public Int32? ErrCode; 
 public Octets Info; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StatusAnnounce : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 
 public Boolean? Status; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleStatusAnnounce : IDataSerializer
        {
         public Byte? ZoneId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Boolean? Status; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KickoutUser : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 
 public Byte? Cause; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GameDataSend : IDataSerializer
        {
         public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ReportIP : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? Ip; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UpdateRemainTime : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? LocalSid; 
 public Int32? RemainTime; 
 public Int32? FreeTimeLeft; 
 public Int32? FreeTimeEnd; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StatInfoVital : IDataSerializer
        {
         public Int32? Priority; 
 public Octets Message; 
 public Octets HostName; 
 public Octets ServiceName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StatInfo : IDataSerializer
        {
         public Int32? Priority; 
 public Octets Message; 
 public Octets HostName; 
 public Octets ServiceName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RemoteLogVital : IDataSerializer
        {
         public Int32? Priority; 
 public Octets Message; 
 public Octets HostName; 
 public Octets ServiceName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RemoteLog : IDataSerializer
        {
         public Int32? Priority; 
 public Octets Message; 
 public Octets HostName; 
 public Octets ServiceName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerKickout : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ProviderLinkId; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerKickout_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerLogin : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ProviderLinkId; 
 public UInt32? LocalSid; 
 public Octets Auth; 
 public Byte? UsbBind; 
 public Boolean? Flag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerLogin_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 
 public Int32? SrcProviderId; 
 public UInt32? LocalSid; 
 public Boolean? Flag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerOffline : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ProviderLinkId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerOffline_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerLogout : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 
 public Int32? ProviderLinkId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SelectRole : IDataSerializer
        {
         public Int32? RoleId; 
 public Boolean? Flag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SelectRole_Re : IDataSerializer
        {
         public Int32? Result; 
 public Octets Auth; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class EnterWorld : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ProviderLinkId; 
 public Int32? LockTime; 
 public Int32? Timeout; 
 public Int32? SetTime; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceProviderID : IDataSerializer
        {
         public Int32? Id; 
 public Single? Left; 
 public Single? Right; 
 public Single? Top; 
 public Single? Bottom; 
 public Int32? Worldtag; 
 public Octets Edition; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class S2CGamedataSend : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class C2SGamedataSend : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class S2CMulticast : IDataSerializer
        {
         public Octets Data; 
 public Vector<Player> Playerlist; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class S2CBroadcast : IDataSerializer
        {
         public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PublicChat : IDataSerializer
        {
         public Byte? Channel; 
 public Byte? Emotion; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets Message; 
 public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatMessage : IDataSerializer
        {
         public Byte? Channel; 
 public Byte? Emotion; 
 public Int32? SrcroleId; 
 public Octets Message; 
 public Octets Data; 
 public Int32? Srclevel; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatMultiCast : IDataSerializer
        {
         public Vector<Player> Playerlist; 
 public Byte? Channel; 
 public Byte? Emotion; 
 public Int32? SrcroleId; 
 public Octets Message; 
 public Octets Data; 
 public Int32? Srclevel; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleList : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 
 public Int32? Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleList_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? Handle; 
 public Int32? UserID; 
 public UInt32? LocalSid; 
 public Vector<RoleInfo> RoleList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CreateRole : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 
 public RoleInfo RoleInfo; 
 public Octets ReferId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CreateRole_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public RoleInfo RoleInfo; 
 public Int32? RefretCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DeleteRole : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DeleteRole_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UndoDeleteRole : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UndoDeleteRole_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Keepalive : IDataSerializer
        {
         public Byte? Code; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerBaseInfo : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Vector<Int32> Playerlist; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerBaseInfo_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public GRoleBase Player; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerHeartBeat : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LinkId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatSingleCast : IDataSerializer
        {
         public Byte? Channel; 
 public Byte? Emotion; 
 public Int32? SrcroleId; 
 public Int32? DstroleId; 
 public UInt32? DstlocalSid; 
 public Octets Message; 
 public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerStatusSync : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ProviderLinkId; 
 public UInt32? LocalSid; 
 public Int32? Status; 
 public Int32? GSId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PrivateChat : IDataSerializer
        {
         public Byte? Channel; 
 public Byte? Emotion; 
 public Octets SrcName; 
 public Int32? SrcroleId; 
 public Octets DstName; 
 public Int32? DstroleId; 
 public Octets Message; 
 public Octets Data; 
 public Int32? Srclevel; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerBaseInfoCRC : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Vector<Int32> Playerlist; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerBaseInfoCRC_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Vector<Int32> Playerlist; 
 public Vector<Int32> CRClist; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetCustomData : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets CustomData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetCustomData_Re : IDataSerializer
        {
         public Int32? Result; 
 public UInt32? CRC; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetUIConfig : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets UiConfig; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetUIConfig_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetUIConfig : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetUIConfig_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets UiConfig; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DisconnectPlayer : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ProviderLinkId; 
 public UInt32? LocalSid; 
 public Int32? GameId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetPlayerBriefInfo : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Vector<Int32> Playerlist; 
 public Byte? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetPlayerBriefInfo_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Vector<PlayerBriefInfo> Playerlist; 
 public Byte? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerStatusAnnounce : IDataSerializer
        {
         public Boolean? Status; 
 public Vector<OnlinePlayerStatus> PlayerStatusList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryPlayerStatus : IDataSerializer
        {
         public Vector<Int32> RoleList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetTaskData : IDataSerializer
        {
         public Int32? TaskId; 
 public Int32? PlayerId; 
 public Octets Env; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetTaskData_Re : IDataSerializer
        {
         public Int32? TaskId; 
 public Int32? PlayerId; 
 public Octets Env; 
 public Int32? RetCode; 
 public Octets TaskData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetTaskData : IDataSerializer
        {
         public Int32? TaskId; 
 public Octets TaskData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetTaskData_Re : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetCustomData : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Vector<Int32> Playerlist; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetCustomData_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public UInt32? CusRoleId; 
 public Octets CustomData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetPlayerIdByName : IDataSerializer
        {
         public Octets RoleName; 
 public UInt32? LocalSid; 
 public Byte? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetPlayerIdByName_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 
 public Octets RoleName; 
 public Int32? RoleId; 
 public Byte? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatBroadCast : IDataSerializer
        {
         public Byte? Channel; 
 public Byte? Emotion; 
 public Int32? SrcroleId; 
 public Octets Message; 
 public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceGM : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets Auth; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMPrivilegeChange : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceForbidInfo : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 
 public GRoleForbid Forbid; 
 public Byte? Disconnect; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FaceModify : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? TicketId; 
 public Int32? TicketPos; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FaceModifyCancel : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FaceModify_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? TicketId; 
 public Int32? TicketPos; 
 public UInt32? CRC; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetHelpStates : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets HelpStates; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetHelpStates_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetHelpStates : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetHelpStates_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets HelpStates; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceServerAttribute : IDataSerializer
        {
         public UInt32? Attr; 
 public Int32? FreeCreaTime; 
 public Byte? ExpRate; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WorldChat : IDataSerializer
        {
         public Byte? Channel; 
 public Byte? Emotion; 
 public Int32? RoleId; 
 public Octets Name; 
 public Octets Message; 
 public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetChatEmotion : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? Emotion; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceChallengeAlgo : IDataSerializer
        {
         public Byte? ChallengeAlgo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceAuthdVersion : IDataSerializer
        {
         public Int32? AuVersion; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserCoupon : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserCoupon_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RemainCoupon; 
 public Int32? TodayExchangeCoupon; 
 public Int32? TodayRemainCoupon; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserCouponExchange : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? CouponNumber; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserCouponExchange_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RemainCoupon; 
 public Int32? TodayExchangeCoupon; 
 public Int32? TodayRemainCoupon; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddCashNotify : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AccountLoginRecord : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 
 public Int32? LoginTime; 
 public Int32? Loginip; 
 public Int32? CurrentIp; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserAddCash : IDataSerializer
        {
         public Int32? UserID; 
 public Octets Cardnum; 
 public Octets CardPasswd; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserAddCash_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SynMutaData : IDataSerializer
        {
         public UInt32? SynMask; 
 public UInt32? RoleId; 
 public Int32? Level; 
 public Int32? ReincarnationTimes; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SSOGetTicket : IDataSerializer
        {
         public SSOUser User; 
 public Int32? ToaId; 
 public Int32? ToZoneId; 
 public Octets Info; 
 public Octets LocalContext; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SSOGetTicket_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets Ticket; 
 public Octets LocalContext; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QPAnnounceDiscount : IDataSerializer
        {
         public Int32? LocalSid; 
 public Vector<QPDiscountInfo> Discount; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QPGetActivatedServices : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QPGetActivatedServices_Re : IDataSerializer
        {
         public Int32? LocalSid; 
 public Vector<Int32> Merchants; 
 public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QPAddCash : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? Cash; 
 public Int32? CashAfterDiscount; 
 public Int32? MerchantId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QPAddCash_Re : IDataSerializer
        {
         public Int32? LocalSid; 
 public Int32? Cash; 
 public Int32? CashAfterDiscount; 
 public Int32? MerchantId; 
 public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ReportChat : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? DstroleId; 
 public Octets DstRoleName; 
 public Octets Content; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CashMoneyExchangeNotify : IDataSerializer
        {
         public Byte? Open; 
 public Int32? Rate; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerNameUpdate : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets NewName; 
 public Vector<Int32> LinkLocalsidList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MobileServerRegister : IDataSerializer
        {
         public Int32? ServerId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ServerForbidNotify : IDataSerializer
        {
         public Vector<Int32> ForbidCtrlList; 
 public Vector<Int32> ForbidItemList; 
 public Vector<Int32> ForbidServiceList; 
 public Vector<Int32> ForbidTaskList; 
 public Vector<Int32> ForbidSkillList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerAccuse : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? DstroleId; 
 public Octets Content; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerAccuse_Re : IDataSerializer
        {
         public UInt32? LocalSid; 
 public Int32? DstroleId; 
 public Int32? ReCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ServerTriggerNotify : IDataSerializer
        {
         public Vector<Int32> TriggerCtrlList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddFriend : IDataSerializer
        {
         public Int32? SrcroleId; 
 public Int32? DstroleId; 
 public Octets DstName; 
 public UInt32? SrclSId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddFriend_Re : IDataSerializer
        {
         public Byte? RetCode; 
 public GFriendInfo Info; 
 public UInt32? SrclSId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetFriends : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetFriends_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Vector<GGroupInfo> Groups; 
 public Vector<GFriendInfo> Friends; 
 public Octets Status; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetGroupName : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? GId; 
 public Octets Name; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetGroupName_Re : IDataSerializer
        {
         public Byte? RetCode; 
 public Int32? RoleId; 
 public Byte? GId; 
 public Octets Name; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetFriendGroup : IDataSerializer
        {
         public Byte? GId; 
 public Int32? RoleId; 
 public Int32? FriendId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetFriendGroup_Re : IDataSerializer
        {
         public Byte? RetCode; 
 public Byte? GId; 
 public Int32? RoleId; 
 public Int32? FriendId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DelFriend : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? FriendId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DelFriend_Re : IDataSerializer
        {
         public Byte? RetCode; 
 public Int32? RoleId; 
 public Int32? FriendId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FriendStatus : IDataSerializer
        {
         public Int32? RoleId; 
 public Boolean? Status; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetSavedMsg : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetSavedMsg_Re : IDataSerializer
        {
         public Byte? RetCode; 
 public Vector<Message> Messages; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomCreate : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets Subject; 
 public UInt16? Capacity; 
 public Octets Password; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomCreate_Re : IDataSerializer
        {
         public Int16? RetCode; 
 public UInt16? RoomId; 
 public Octets Subject; 
 public UInt16? Capacity; 
 public Boolean? Status; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomInvite : IDataSerializer
        {
         public UInt16? RoomId; 
 public Int32? Invitee; 
 public Int32? Inviter; 
 public Octets Name; 
 public Octets Subject; 
 public UInt16? Capacity; 
 public UInt16? Number; 
 public Octets Password; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomInvite_Re : IDataSerializer
        {
         public UInt16? RoomId; 
 public Int32? Invitee; 
 public Int32? Inviter; 
 public Int16? RetCode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomJoin : IDataSerializer
        {
         public UInt16? RoomId; 
 public Int32? OwnerId; 
 public Octets OwnerName; 
 public UInt32? RoleId; 
 public Octets Password; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomJoin_Re : IDataSerializer
        {
         public Int16? RetCode; 
 public UInt16? RoomId; 
 public Int32? RoleId; 
 public Octets Name; 
 public GRoomDetail Detail; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomLeave : IDataSerializer
        {
         public UInt16? RoomId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomExpel : IDataSerializer
        {
         public UInt16? RoomId; 
 public Int32? RoleId; 
 public Int32? Owner; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomSpeak : IDataSerializer
        {
         public UInt16? RoomId; 
 public Byte? Emotion; 
 public Octets Message; 
 public Int32? Src; 
 public Int32? Dst; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomList : IDataSerializer
        {
         public UInt16? Begin; 
 public Byte? Reverse; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChatRoomList_Re : IDataSerializer
        {
         public UInt16? Sum; 
 public Vector<GChatRoom> Rooms; 
 public Byte? End; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FriendExtList : IDataSerializer
        {
         public Int32? RoleId; 
 public Vector<GFriendExtInfo> ExtraInfo; 
 public Vector<GSendAUMailRecord> SendInfo; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFriendExtList : IDataSerializer
        {
         public Int32? RId; 
 public Vector<Int32> RoleIdList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFriendExtList_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RId; 
 public Vector<GFriendExtInfo> Friendext; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SendAUMail : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? FriendId; 
 public Int32? MailTemplateId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SendAUMail_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Result; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AUMailSended : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Level; 
 public Byte? ExtReward; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMOnlineNum : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMOnlineNum_Re : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Int32? TotalNum; 
 public Int32? LocalNum; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMListOnlineUser : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Int32? Handler; 
 public Octets Cond; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMListOnlineUser_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Int32? Handler; 
 public Vector<GMPlayerInfo> UserList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMKickoutUser : IDataSerializer
        {
         public Int32? GmroleId; 
 public Int32? LocalSid; 
 public Int32? KickUserId; 
 public Int32? ForbidTime; 
 public Octets Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMKickoutUser_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? GmroleId; 
 public Int32? LocalSid; 
 public Int32? KickUserId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMShutup : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Int32? DstUserId; 
 public Int32? ForbidTime; 
 public Octets Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMShutup_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DstUserId; 
 public Int32? ForbidTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMRestartServer : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Int32? GSId; 
 public Int32? RestartTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMRestartServer_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Int32? GSId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMKickoutRole : IDataSerializer
        {
         public Int32? GmroleId; 
 public Int32? LocalSid; 
 public Int32? KickroleId; 
 public Int32? ForbidTime; 
 public Octets Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMKickoutRole_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? GmroleId; 
 public Int32? LocalSid; 
 public Int32? KickroleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMShutupRole : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Int32? DstroleId; 
 public Int32? ForbidTime; 
 public Octets Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMShutupRole_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DstroleId; 
 public Int32? ForbidTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMToggleChat : IDataSerializer
        {
         public Int32? GmroleId; 
 public Int32? LocalSid; 
 public Byte? Enable; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMToggleChat_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? GmroleId; 
 public Int32? LocalSid; 
 public Byte? Enable; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMForbidRole : IDataSerializer
        {
         public Byte? FbdType; 
 public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Int32? DstroleId; 
 public Int32? ForbidTime; 
 public Octets Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMForbidRole_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Byte? FbdType; 
 public Int32? DstroleId; 
 public Int32? ForbidTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Report2GM : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets RoleName; 
 public Int32? ZoneId; 
 public Octets MapZone; 
 public Single? PosX; 
 public Single? PosY; 
 public Single? PosZ; 
 public Octets Content; 
 public Int32? AId; 
 public Octets Line; 
 public Int32? ComRoleId; 
 public Octets ComRoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Report2GM_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Complain2GM : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets RoleName; 
 public Octets CompRoleName; 
 public Int32? ZoneId; 
 public Octets MapZone; 
 public Single? PosX; 
 public Single? PosY; 
 public Single? PosZ; 
 public Octets Content; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Complain2GM_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceLinkType : IDataSerializer
        {
         public Byte? LinkType; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetMaxOnlineNum : IDataSerializer
        {
         public Int32? Maxnum; 
 public Int32? FakeMaxnum; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SetMaxOnlineNum_Re : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMForbidSellPoint : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Int32? ForbidTime; 
 public Boolean? On; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMForbidSellPoint_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMControlGame : IDataSerializer
        {
         public Int32? XId; 
 public Int32? Worldtag; 
 public Octets Command; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMControlGame_Re : IDataSerializer
        {
         public Int32? XId; 
 public Int32? RetCode; 
 public Vector<GMControlGameRes> ResVector; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMGetPlayerConsumeInfo : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Vector<Int32> Playerlist; 
 public Byte? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMGetPlayerConsumeInfo_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Vector<PlayerConsumeInfo> Playerlist; 
 public Byte? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMSetTimelessAutoLock : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Int32? DstroleId; 
 public Byte? Enable; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMSetTimelessAutoLock_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 
 public Int32? DstroleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class IWebAutolockGet : IDataSerializer
        {
         public Int32? TId; 
 public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class IWebAutolockGet_Re : IDataSerializer
        {
         public Int32? TId; 
 public Int32? RetCode; 
 public Int32? UserID; 
 public Int32? SetTime; 
 public Int32? LockTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class IWebAutolockSet : IDataSerializer
        {
         public Int32? TId; 
 public Int32? UserID; 
 public Int32? LockTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class IWebAutolockSet_Re : IDataSerializer
        {
         public Int32? TId; 
 public Int32? RetCode; 
 public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockCommission : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? Isbuy; 
 public Int32? Price; 
 public Int32? Volume; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockTransaction : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? WithDraw; 
 public Int32? Cash; 
 public Int32? Money; 
 public UInt32? LocalSid; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockBill : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockBill_Re : IDataSerializer
        {
         public UInt32? LocalSid; 
 public Vector<StockOrder> Orders; 
 public Vector<StockLog> Logs; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockAccount : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockAccount_Re : IDataSerializer
        {
         public Int32? Cash; 
 public Int32? Money; 
 public Vector<StockPrice> Prices; 
 public Byte? Locked; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockCommission_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? Cash; 
 public Int32? Money; 
 public Vector<StockPrice> Prices; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockTransaction_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? Cash; 
 public Int32? Money; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockCancel : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? TId; 
 public Int32? Price; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockCancel_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? TId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AccountingRequest : IDataSerializer
        {
         public UInt32? Stamp; 
 public Int32? UserID; 
 public Octets Authenticator; 
 public Vector<AccntParam> Attributes; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AccountingResponse : IDataSerializer
        {
         public UInt32? Stamp; 
 public Int32? UserID; 
 public Octets Authenticator; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceZoneid : IDataSerializer
        {
         public Byte? ZoneId; 
 public Byte? AId; 
 public Boolean? reset; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryUserPrivilege : IDataSerializer
        {
         public Int32? UserID; 
 public Byte? ZoneId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryUserPrivilege_Re : IDataSerializer
        {
         public Int32? UserID; 
 public Octets Auth; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryUserForbid : IDataSerializer
        {
         public Int32? UserID; 
 public Byte? ZoneId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryUserForbid_Re : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? ListType; 
 public Vector<GRoleForbid> Forbid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryRewardType : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryRewardType_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Reward; 
 public Int32? Reward2; 
 public Int32? Param; 
 public Int32? RewardMask; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryGameServerAttr : IDataSerializer
        {
         public Byte? Paddings; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryGameServerAttr_Re : IDataSerializer
        {
         public Vector<GameAttr> Attr; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddCash : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? ZoneId; 
 public Int32? Sn; 
 public Int32? Cash; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddCash_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public Int32? ZoneId; 
 public Int32? Sn; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UseCash : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? ZoneId; 
 public Int32? AId; 
 public Int32? Point; 
 public Int32? Cash; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UseCash_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public Int32? ZoneId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class VerifyMaster : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? RoleId; 
 public Octets RoleName; 
 public Octets Faction; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class VerifyMaster_Re : IDataSerializer
        {
         public Octets RoleName; 
 public Int32? Ret; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DebugAddCash : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? Cash; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceZoneid2 : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? AId; 
 public Boolean? reset; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceZoneid3 : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? AId; 
 public Boolean? reset; 
 public Int32? Ip1; 
 public Int32? Ip2; 
 public Int32? Ip3; 
 public Int32? GetAuVersion; 
 public Int32? Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class NetBarAnnounce : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? AId; 
 public Int32? ZoneId; 
 public Int32? Title; 
 public Octets RoleName; 
 public Int32? NetbarId; 
 public Int32? NetbarZone; 
 public Octets NetbarName; 
 public Int32? NetbarLevel; 
 public Octets NetbarTitle; 
 public Octets AwardType; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CertRequest : IDataSerializer
        {
         public Int32? Reserved1; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CertAnswer : IDataSerializer
        {
         public Octets AuthdCert; 
 public Int32? Reserved1; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CertKey : IDataSerializer
        {
         public Octets DKey1Encrypt; 
 public Octets DKey2Encrypt; 
 public Int32? Reserved1; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CertFinish : IDataSerializer
        {
         public Int32? Reserved1; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MatrixChallenge : IDataSerializer
        {
         public Int32? Algorithm; 
 public UInt32? Nonce; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MatrixResponse : IDataSerializer
        {
         public UInt32? Response; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MatrixFailure : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? Loginip; 
 public Int32? Weight; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddictionControl : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? UserID; 
 public Int32? Rate; 
 public Int32? Message; 
 public Vector<GPair> Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SellPoint : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? Point; 
 public Int32? Price; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SellPoint_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 
 public SellPointInfo Info; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetSellList : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetSellList_Re : IDataSerializer
        {
         public UInt32? LocalSid; 
 public Vector<SellPointInfo> List; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SellCancel : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? SellID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SellCancel_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 
 public Int32? SellID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BuyPoint : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? SellID; 
 public Int32? Seller; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BuyPoint_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 
 public Int32? SellID; 
 public Int32? Seller; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SyncSellInfo : IDataSerializer
        {
         public SellPointInfo Info; 
 public Int32? Buyer; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceSellResult : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? SellID; 
 public Int32? Seller; 
 public Int32? Point; 
 public Int32? Price; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TransBuyPoint : IDataSerializer
        {
         public TransID TId; 
 public SellID SellID; 
 public Int32? Buyer; 
 public Int32? Price; 
 public Int32? Point; 
 public Int32? AId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TransBuyPoint_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public TransID TId; 
 public SellID SellID; 
 public Int32? Buyer; 
 public Int32? Price; 
 public Int32? Point; 
 public Int32? AId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FindSellPointInfo : IDataSerializer
        {
         public Int32? StarTId; 
 public UInt32? LocalSid; 
 public Byte? Forward; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FindSellPointInfo_Re : IDataSerializer
        {
         public UInt32? LocalSid; 
 public Vector<SellPointInfo> List; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DomainLogin : IDataSerializer
        {
         public Octets Nonce; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DomainValidate : IDataSerializer
        {
         public Octets Version; 
 public Octets Nonce; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DomainCmd : IDataSerializer
        {
         public Octets Cmd; 
 public Octets Stamp; 
 public Int32? Length; 
 public Byte? Dest; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DomainCmd_Re : IDataSerializer
        {
         public Octets Res; 
 public Int32? Serial; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AutolockSet : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 
 public Int32? Timeout; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AutolockSet_Re : IDataSerializer
        {
         public Int32? Result; 
 public Int32? Timeout; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AutolockChanged : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LockTime; 
 public Int32? Timeout; 
 public Int32? SetTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionOpen : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public UInt16? Category; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemNumber; 
 public UInt32? BasePrice; 
 public UInt32? BinPrice; 
 public Int32? ElapseTime; 
 public UInt32? Deposit; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionOpen_Re : IDataSerializer
        {
         public UInt16? RetCode; 
 public UInt32? AuctionId; 
 public GAuctionItem Info; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionBid : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? AuctionId; 
 public UInt32? BidPrice; 
 public Byte? Bin; 
 public UInt32? LocalSid; 
 public UInt32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionBid_Re : IDataSerializer
        {
         public UInt16? RetCode; 
 public UInt32? BidPrice; 
 public UInt32? AuctionId; 
 public GAuctionItem Info; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionList : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt16? Category; 
 public UInt32? ItemId; 
 public UInt32? Begin; 
 public Byte? Reverse; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionList_Re : IDataSerializer
        {
         public UInt32? LocalSid; 
 public UInt16? Category; 
 public UInt32? End; 
 public Vector<GAuctionItem> Items; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionClose : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? AuctionId; 
 public Byte? Reason; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionClose_Re : IDataSerializer
        {
         public UInt16? RetCode; 
 public UInt32? AuctionId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionGet : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? AuctionId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionGet_Re : IDataSerializer
        {
         public UInt16? RetCode; 
 public UInt32? AuctionId; 
 public GAuctionDetail Item; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionAttendList : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? TargetType; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionAttendList_Re : IDataSerializer
        {
         public UInt32? LocalSid; 
 public Int32? TargetType; 
 public Vector<GAuctionItem> Items; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionExitBid : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public UInt32? AuctionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionExitBid_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 
 public UInt32? AuctionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionGetItem : IDataSerializer
        {
         public Int32? RoleId; 
 public Vector<UInt32> Ids; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionGetItem_Re : IDataSerializer
        {
         public UInt32? LocalSid; 
 public Vector<UInt32> Ids; 
 public Vector<GRoleInventory> Items; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SendAuctionBid : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? AuctionId; 
 public UInt32? BidPrice; 
 public Byte? Bin; 
 public UInt32? LocalSid; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionListUpdate : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Vector<UInt32> Ids; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionListUpdate_Re : IDataSerializer
        {
         public UInt32? LocalSid; 
 public Vector<UInt32> ExpiredIds; 
 public Vector<GAuctionItem> Items; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleGetMap : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleGetMap_Re : IDataSerializer
        {
         public UInt16? RetCode; 
 public UInt16? MaxbId; 
 public Int32? Status; 
 public Vector<GTerritory> Cities; 
 public Int32? BonusId; 
 public Int32? BonusCount1; 
 public Int32? BonusCount2; 
 public Int32? BonusCount3; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleChallenge : IDataSerializer
        {
         public Int32? RoleId; 
 public Int16? Id; 
 public UInt32? FactionId; 
 public UInt32? Deposit; 
 public Int32? Authentication; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleChallenge_Re : IDataSerializer
        {
         public UInt16? RetCode; 
 public Int32? RoleId; 
 public Int16? Id; 
 public UInt32? Deposit; 
 public UInt32? Maxbonus; 
 public UInt32? Challenger; 
 public UInt32? CutffTime; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleChallengeMap : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? FactionId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleChallengeMap_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt16? RetCode; 
 public Int32? Status; 
 public UInt32? Maxbonus; 
 public Vector<GBattleChallenge> Cities; 
 public Int32? RandNum; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleServerRegister : IDataSerializer
        {
         public Int32? MapType; 
 public Int32? ServerId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleStart : IDataSerializer
        {
         public Int32? BattleId; 
 public Int32? MapType; 
 public Int32? BattleType; 
 public UInt32? Defender; 
 public UInt32? Attacker; 
 public Int32? EndTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleStart_Re : IDataSerializer
        {
         public Int32? BattleId; 
 public Int16? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleEnter : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? BattleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleEnter_Re : IDataSerializer
        {
         public UInt16? RetCode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleEnterNotice : IDataSerializer
        {
         public UInt16? RetCode; 
 public Int32? RoleId; 
 public Int32? BattleId; 
 public Int32? ServerId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleStatus : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleStatus_Re : IDataSerializer
        {
         public UInt16? RetCode; 
 public Octets Cities; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SendBattleChallenge : IDataSerializer
        {
         public Int32? RoleId; 
 public Int16? Id; 
 public UInt32? FactionId; 
 public UInt32? Deposit; 
 public Int32? Authentication; 
 public UInt32? LocalSid; 
 public UInt32? Maxbonus; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleMapNotice : IDataSerializer
        {
         public Int32? Status; 
 public Vector<GCity> Cities; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DebugCommand : IDataSerializer
        {
         public UInt32? RoleId; 
 public Int32? Tag; 
 public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleFactionNotice : IDataSerializer
        {
         public Vector<Int32> FactionIds; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopCreate : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ShopType; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemNumber; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopCreate_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopBuy : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public UInt32? ItemPrice; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopBuy_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public UInt32? ItemPrice; 
 public PShopItem ItemSell; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopSell : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public UInt32? ItemPrice; 
 public Int32? InvPos; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopSell_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public UInt32? ItemPrice; 
 public Int32? InvPos; 
 public PShopItem ItemSell; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopCancelGoods : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? CancelType; 
 public Int32? Pos; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopCancelGoods_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public Int32? CancelType; 
 public Int32? Pos; 
 public GRoleInventory ItemStore; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopPlayerBuy : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Master; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public Int64? MoneyCost; 
 public Int32? YpCost; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopPlayerBuy_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public Int32? Master; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public PShopItem ItemChange; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopPlayerSell : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Master; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public UInt32? ItemPrice; 
 public Int32? InvPos; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopPlayerSell_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public Int32? Master; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public PShopItem ItemBuy; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopSetType : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? NewType; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopSetType_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public Int32? NewType; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopActive : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemNumber; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopActive_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public Int32? Status; 
 public Int32? ExpireTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopManageFund : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? OpType; 
 public UInt32? Money; 
 public UInt32? Yinpiao; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopManageFund_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public UInt32? Money; 
 public UInt32? Yinpiao; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopDrawItem : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ItemPos; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopDrawItem_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public Int32? ItemPos; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopClearGoods : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopClearGoods_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public Vector<PShopItem> SList; 
 public Vector<GRoleInventory> Store; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopSelfGet : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopSelfGet_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public PShopDetail Detail; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopPlayerGet : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Master; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopPlayerGet_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 
 public PShopBase Base; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopList : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LocalSid; 
 public Int32? ShopType; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopList_Re : IDataSerializer
        {
         public Int32? LocalSid; 
 public Vector<PShopEntry> ShopList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopListItem : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LocalSid; 
 public Int32? ItemId; 
 public Byte? ListType; 
 public Int32? PageNum; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopListItem_Re : IDataSerializer
        {
         public Int32? LocalSid; 
 public Vector<PShopItemEntry> ItemList; 
 public Byte? ListType; 
 public Int32? PageNum; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerProfileGetProfileData : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerProfileGetProfileData_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public PlayerProfileData Data; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerProfileSetProfileData : IDataSerializer
        {
         public Int32? RoleId; 
 public PlayerProfileData Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerProfileGetMatchResult : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? MatchMode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerProfileGetMatchResult_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Vector<ProfileMatchResult> Result; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AutoTeamSetGoal : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? GoalType; 
 public Byte? Op; 
 public Int32? GoalId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AutoTeamSetGoal_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? GoalType; 
 public Byte? Op; 
 public Int32? GoalId; 
 public Int32? RetCode; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AutoTeamPlayerReady : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LeaderId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AutoTeamPlayerReady_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LeaderId; 
 public Byte? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AutoTeamComposeStart : IDataSerializer
        {
         public Int32? GoalId; 
 public Int32? RoleId; 
 public Vector<Int32> MemberList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AutoTeamComposeFailed : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LeaderId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AutoTeamPlayerLeave : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? Reason; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TryChangeDS : IDataSerializer
        {
         public Int32? RoleId; 
 public Boolean? Flag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerChangeDS : IDataSerializer
        {
         public Int32? RoleId; 
 public Boolean? Flag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerChangeDS_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? RemoteRoleId; 
 public Int32? UserID; 
 public Boolean? Flag; 
 public Octets Random; 
 public Int32? DstZoneId; 
 public UInt32? LocalSid; 
 public Octets RoleinfoPack; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ChangeDS_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KeyReestablish : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 
 public Boolean? Flag; 
 public Int32? SrcZoneId; 
 public Octets Random; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class LoadExchange : IDataSerializer
        {
         public Int32? ZoneId; 
 public UInt32? Version; 
 public Octets Edition; 
 public Int32? ServerLimit; 
 public Int32? ServerCount; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SendDataAndIdentity : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? RemoteRoleId; 
 public Int32? UserID; 
 public Int32? SrcZoneId; 
 public Int32? Ip; 
 public Octets ISeckey; 
 public Octets OSeckey; 
 public Octets Account; 
 public Octets Random; 
 public Boolean? Flag; 
 public CrossPlayerData Data; 
 public Int32? DataTimestamp; 
 public Int32? LoginTime; 
 public Byte? AuIsGM; 
 public Int32? AuFunc; 
 public Int32? AuFuncparm; 
 public Octets Auth; 
 public Byte? UsbBind; 
 public Int32? RewardMask; 
 public GRoleForbid ForbidTalk; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SendDataAndIdentity_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? RemoteRoleId; 
 public Int32? UserID; 
 public Boolean? Flag; 
 public Int32? DstZoneId; 
 public Octets RoleinfoPack; 
 public Byte? IsRemoteRoleidChanged; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DSAnnounceIdentity : IDataSerializer
        {
         public Int32? ZoneId; 
 public UInt32? Version; 
 public Octets Edition; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RemoteLoginQuery : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? RemoteRoleId; 
 public Int32? UserID; 
 public Boolean? Flag; 
 public Int32? RemoteZoneId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RemoteLoginQuery_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? RemoteRoleId; 
 public Int32? UserID; 
 public Boolean? Flag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RemoteLogout : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KickoutRemoteUser : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? ZoneId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KickoutRemoteUser_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetRemoteRoleInfo : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? RemoteRoleId; 
 public Int32? UserID; 
 public Int32? ZoneId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetRemoteRoleInfo_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? RemoteRoleId; 
 public Int32? UserID; 
 public GRoleInfo Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KickoutUser2 : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 
 public Int32? Cause; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceLinkVersion : IDataSerializer
        {
         public UInt32? Version; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceCentralDelivery : IDataSerializer
        {
         public Byte? IsCentral; 
 public Vector<Int32> AcceptedZoneList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DelRoleAnnounce : IDataSerializer
        {
         public Vector<Int32> RoleList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerRename : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? AttachObjId; 
 public Int32? AttachObjNum; 
 public Int32? AttachObjPos; 
 public Octets NewName; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerRename_Re : IDataSerializer
        {
         public Int32? LocalSid; 
 public Int32? RoleId; 
 public Octets NewName; 
 public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostPlayerRename : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ZoneId; 
 public Int32? RetCode; 
 public Octets NewName; 
 public Octets OldName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerGivePresent : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? TargetRoleId; 
 public Int32? MailId; 
 public Vector<GRoleInventory> Goods; 
 public UInt32? CashCost; 
 public Byte? HasGift; 
 public Int32? LogPrice1; 
 public Int32? LogPrice2; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerGivePresent_Re : IDataSerializer
        {
         public Int32? LocalSid; 
 public Int32? RoleId; 
 public UInt32? CashCost; 
 public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerAskForPresent : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? TargetRoleId; 
 public Int32? GoodsId; 
 public Int32? GoodsIndex; 
 public Int32? GoodsSlot; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerAskForPresent_Re : IDataSerializer
        {
         public Int32? LocalSid; 
 public Int32? RoleId; 
 public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UniqueDataModifyRequire : IDataSerializer
        {
         public Int32? Worldtag; 
 public Int32? Key; 
 public Int32? VType; 
 public Octets Value; 
 public Octets Oldvalue; 
 public Boolean? Exclusive; 
 public Boolean? Broadcast; 
 public Int32? Version; 
 public Boolean? Timeout; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UniqueDataModifyNotice : IDataSerializer
        {
         public Int32? Worldtag; 
 public Int32? Key; 
 public Int32? VType; 
 public Octets Value; 
 public Octets Oldvalue; 
 public Boolean? Exclusive; 
 public Int32? RetCode; 
 public Int32? Version; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UniqueDataSynch : IDataSerializer
        {
         public Byte? Finish; 
 public Vector<GUniqueDataElemNode> Values; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UniqueDataModifyBroadcast : IDataSerializer
        {
         public Int32? Handle; 
 public Vector<GUniqueDataElemNode> Values; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeStart : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? PartnerRoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeStart_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? TId; 
 public Int32? PartnerRoleId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeAddGoods : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public GRoleInventory Goods; 
 public UInt32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeAddGoods_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? TId; 
 public Int32? OwnerRoleId; 
 public Int32? RoleId; 
 public Int32? LocalSid; 
 public GRoleInventory Goods; 
 public UInt32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeRemoveGoods : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public GRoleInventory Goods; 
 public UInt32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeRemoveGoods_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? TId; 
 public Int32? OwnerRoleId; 
 public Int32? RoleId; 
 public Int32? LocalSid; 
 public GRoleInventory Goods; 
 public UInt32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeMoveObj : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public GRoleInventory Goods; 
 public Byte? DstPos; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeMoveObj_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? TId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Byte? SrcPos; 
 public Int32? Count; 
 public Byte? DstPos; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeSubmit : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeSubmit_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? TId; 
 public Int32? SubmitRoleId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeConfirm : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeConfirm_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? TId; 
 public Int32? ConfirmRoleId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeDiscard : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeDiscard_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? TId; 
 public Int32? DiscardRoleId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeEnd : IDataSerializer
        {
         public UInt32? TId; 
 public Byte? Cause; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GTradeStart : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RoleId1; 
 public UInt32? LocalsId1; 
 public Int32? RoleId2; 
 public UInt32? LocalsId2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GTradeStart_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? TId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GTradeEnd : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RoleId1; 
 public Byte? NeedReadDB1; 
 public Int32? RoleId2; 
 public Byte? NeedReadDB2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GTradeDiscard : IDataSerializer
        {
         public UInt32? TId; 
 public Byte? Paddings; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class OnDivorce : IDataSerializer
        {
         public Int32? RId1; 
 public Int32? RId2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TouchPointQuery : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TouchPointQuery_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Int64? Income; 
 public Int64? Remain; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TouchPointCost : IDataSerializer
        {
         public Int32? RoleId; 
 public Int64? OrderId; 
 public UInt32? Cost; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TouchPointCost_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Int64? OrderId; 
 public UInt32? Cost; 
 public Int64? Income; 
 public Int64? Remain; 
 public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuAddupMoneyQuery : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuAddupMoneyQuery_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Int64? AddupMoney; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GiftCodeRedeem : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets CardNumber; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GiftCodeRedeem_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets CardNumber; 
 public Int32? CodeType; 
 public Int32? ParentType; 
 public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SwitchServerStart : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LinkId; 
 public UInt32? LocalSid; 
 public Int32? SrcGSId; 
 public Int32? DstGSId; 
 public Octets Key; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SwitchServerCancel : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LinkId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SwitchServerSuccess : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LinkId; 
 public UInt32? LocalSid; 
 public Int32? DstGSId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SwitchServerTimeout : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LinkId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CheckNewMail : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceNewMail : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? RemainTime; 
 public Byte? PresentType; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMailList : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMailList_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Vector<GMailHeader> MailList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMail : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Byte? MailId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMail_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public GMail Mail; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMailAttachObj : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Byte? MailId; 
 public Byte? ObjType; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMailAttachObj_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Byte? MailId; 
 public UInt32? MoneyLeft; 
 public UInt32? ItemLeft; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DeleteMail : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Byte? MailId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DeleteMail_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Byte? MailId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PreserveMail : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Byte? MailId; 
 public Boolean? Preserve; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PreserveMail_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Byte? MailId; 
 public Boolean? Preserve; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerSendMail : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? Receiver; 
 public Octets Title; 
 public Octets Context; 
 public Int32? AttachObjId; 
 public Int32? AttachObjNum; 
 public Int32? AttachObjPos; 
 public UInt32? AttachMoney; 
 public Octets SenderName; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerSendMail_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? Receiver; 
 public Int32? AttachObjNum; 
 public Int32? AttachObjPos; 
 public UInt32? AttachMoney; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysSendMail : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? SysId; 
 public Byte? SysType; 
 public Int32? Receiver; 
 public Octets Title; 
 public Octets Context; 
 public GRoleInventory AttachObj; 
 public UInt32? AttachMoney; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysSendMail_Re : IDataSerializer
        {
         public UInt16? RetCode; 
 public UInt32? TId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMailEndSync : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RetCode; 
 public Int32? RoleId; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerSendMassMail : IDataSerializer
        {
         public Byte? MassType; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets Title; 
 public Octets Context; 
 public Octets SenderName; 
 public Vector<Int32> ReceiverList; 
 public Int32? CostObjId; 
 public Int32? CostObjNum; 
 public Int32? CostObjPos; 
 public UInt32? CostMoney; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysRecoveredObjMail : IDataSerializer
        {
         public Int32? TId; 
 public Byte? SysType; 
 public Int32? Receiver; 
 public Octets Title; 
 public Octets Context; 
 public Octets Obj; 
 public Octets Checksum; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysRecoveredObjMail_Re : IDataSerializer
        {
         public Int16? RetCode; 
 public Int32? TId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CashLock : IDataSerializer
        {
         public Int32? UserID; 
 public Octets CashPassword; 
 public UInt32? LocalSid; 
 public Byte? Lock; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CashLock_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CashPasswordSet : IDataSerializer
        {
         public Int32? UserID; 
 public Octets CashPassword; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CashPasswordSet_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradePrePost : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? PostType; 
 public UInt32? Money; 
 public UInt32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemNumber; 
 public Int32? Price; 
 public Int32? SellPeriod; 
 public Int32? BuyerroleId; 
 public UInt32? LocalSid; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradePrePost_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int64? Sn; 
 public GWebTradeItem Info; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradePreCancelPost : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradePreCancelPost_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int64? Sn; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeList : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? Category; 
 public UInt32? Begin; 
 public Byte? Reverse; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeList_Re : IDataSerializer
        {
         public UInt32? Category; 
 public UInt32? End; 
 public Vector<GWebTradeItem> Items; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeGetItem : IDataSerializer
        {
         public Int32? RoleId; 
 public Vector<Int64> Sns; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeGetItem_Re : IDataSerializer
        {
         public Vector<Int64> Sns; 
 public Vector<GRoleInventory> Items; 
 public Vector<Octets> Rolebriefs; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeAttendList : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? GetSell; 
 public UInt32? Begin; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeAttendList_Re : IDataSerializer
        {
         public Byte? GetSell; 
 public UInt32? End; 
 public Vector<GWebTradeItem> Items; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeGetDetail : IDataSerializer
        {
         public Int32? RoleId; 
 public Int64? Sn; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeGetDetail_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int64? Sn; 
 public GWebTradeDetail Detail; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeUpdate : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeUpdate_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int64? Sn; 
 public GWebTradeItem Item; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeRolePrePost : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? RoleId; 
 public Int32? Price; 
 public Int32? SellPeriod; 
 public Int32? BuyerroleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeRolePreCancelPost : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebTradeRoleGetDetail : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionList : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionList_Re : IDataSerializer
        {
         public Vector<GSysAuctionItem> Items; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionGetItem : IDataSerializer
        {
         public Int32? RoleId; 
 public Vector<UInt32> Ids; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionGetItem_Re : IDataSerializer
        {
         public Vector<UInt32> Ids; 
 public Vector<GRoleInventory> Items; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionAccount : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionAccount_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? Cash; 
 public Vector<UInt32> BidIds; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionBid : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? SaId; 
 public UInt32? BidPrice; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionBid_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? Cash; 
 public GSysAuctionItem Info; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionCashTransfer : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? WithDraw; 
 public UInt32? Cash; 
 public UInt32? LocalSid; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionCashTransfer_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? Cash; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CreateFactionFortress : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? FactionId; 
 public Octets ItemCost; 
 public Octets FortressInfo; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CreateFactionFortress_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public GFactionFortressBriefInfo Brief; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionServerRegister : IDataSerializer
        {
         public Int32? ServerId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class NotifyFactionFortressState : IDataSerializer
        {
         public Int32? FactionId; 
 public Int32? State; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class NotifyFactionFortressInfo2 : IDataSerializer
        {
         public Int32? FactionId; 
 public GFactionFortressInfo2 Info2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionFortressEnter : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? FactionId; 
 public Int32? DstFactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionFortressEnterNotice : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? DstFactionId; 
 public Int32? DstWorldTag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionFortressList : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? Begin; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionFortressList_Re : IDataSerializer
        {
         public Int32? Status; 
 public UInt32? Begin; 
 public Vector<GFactionFortressBriefInfo> List; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionFortressChallenge : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? FactionId; 
 public Int32? TargetFactionId; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionFortressChallenge_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionFortressBattleList : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionFortressBattleList_Re : IDataSerializer
        {
         public Int32? Status; 
 public Vector<GFactionFortressBattleInfo> List; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionFortressGet : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionFortressGet_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public GFactionFortressBriefInfo Brief; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class NotifyFactionFortressID : IDataSerializer
        {
         public Vector<Int32> FactionIds; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class NotifyFactionPlayerRename : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets NewName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerInfoUpdate : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Level; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerTeamOp : IDataSerializer
        {
         public Byte? Operation; 
 public Int64? TeamUId; 
 public Int64? Captain; 
 public Vector<Int32> Members; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerTeamMemberOp : IDataSerializer
        {
         public Int64? TeamUId; 
 public Byte? Operation; 
 public Int32? Member; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerEnterLeaveGT : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? Operation; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SNSRoleBriefUpdate : IDataSerializer
        {
         public Int32? RoleId; 
 public SNSRoleBrief Brief; 
 public SNSRoleSkills Skills; 
 public SNSRoleEquipment Equipment; 
 public SNSRolePetCorral Petcorral; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionCreate : IDataSerializer
        {
         public Octets FactionName; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets FactionProclaim; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionCreate_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets FactionName; 
 public UInt32? FactionId; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionListMember_Re : IDataSerializer
        {
         public Int32? Handle; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Octets Proclaim; 
 public Vector<FMemberInfo> MemberList; 
 public Vector<Int32> OnlineList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionApplyJoin_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public UInt32? FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionAcceptJoin_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? NewMember; 
 public Int32? Operater; 
 public UInt32? FactionId; 
 public Int32? Level; 
 public Byte? Cls; 
 public Octets Name; 
 public Int32? Reputation; 
 public Byte? ReincarnTimes; 
 public Byte? Gender; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionExpel_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public UInt32? ExpelRoleId; 
 public Int32? Operater; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionBroadcastNotice_Re : IDataSerializer
        {
         public Int32? SrcroleId; 
 public Int32? DstroleId; 
 public UInt32? DstlocalSid; 
 public Octets Message; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionChangProclaim_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? Operater; 
 public Octets Proclaim; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionMasterResign_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? NewMaster; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionAppoint_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? DstroleId; 
 public Byte? NewOccup; 
 public Int32? Operater; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionResign_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? ResignedRole; 
 public Byte? OldOccup; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionLeave_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? LeavedRole; 
 public Byte? OldOccup; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionUpgrade_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionDegrade_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionDismiss_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionRename_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? RenamedRoleId; 
 public Octets NewName; 
 public Int32? Operater; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionAllianceApply_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DstFId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionAllianceReply_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DstFId; 
 public Byte? Agree; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionHostileApply_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DstFId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionHostileReply_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DstFId; 
 public Byte? Agree; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionRemoveRelationApply_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DstFId; 
 public Byte? Force; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionRemoveRelationReply_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DstFId; 
 public Byte? Agree; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionListRelation_Re : IDataSerializer
        {
         public Int32? LastOpTime; 
 public Vector<GFactionAlliance> Alliance; 
 public Vector<GFactionHostile> Hostile; 
 public Vector<GFactionRelationApply> Apply; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionRelationRecvApply : IDataSerializer
        {
         public Int32? ApplyType; 
 public Int32? SrcFId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionRelationRecvReply : IDataSerializer
        {
         public Int32? PreApplyType; 
 public Byte? Agree; 
 public Int32? SrcFId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionDelayExpelAnnounce : IDataSerializer
        {
         public Int32? RetCode; 
 public Byte? OptType; 
 public Int32? Operater; 
 public Int32? ExpelRoleId; 
 public Int32? Time; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SyncForceGlobalData : IDataSerializer
        {
         public Vector<GForceGlobalDataBrief> List; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class NotifyPlayerJoinOrLeaveForce : IDataSerializer
        {
         public Int32? ForceId; 
 public Byte? IsJoin; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class IncreaseForceActivity : IDataSerializer
        {
         public Int32? ForceId; 
 public Int32? Activity; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleApply : IDataSerializer
        {
         public Vector<CountryBattleApplyEntry> List; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleApply_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? CountryId; 
 public Int32? CountryInvalidTimestamp; 
 public Int32? CapitalWorldtag; 
 public Single? CapitalPosX; 
 public Single? CapitalPosY; 
 public Single? CapitalPosZ; 
 public Vector<CountryBattleApplyEntry> List; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleJoinNotice : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? CountryId; 
 public Int32? Worldtag; 
 public Int32? MajorStrength; 
 public Int32? MinorStrength; 
 public Byte? IsKing; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleLeaveNotice : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? CountryId; 
 public Int32? MajorStrength; 
 public Int32? MinorStrength; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleOnlineNotice : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? CountryId; 
 public Int32? Worldtag; 
 public Int32? MinorStrength; 
 public Byte? IsKing; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleOfflineNotice : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? CountryId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleEnterMapNotice : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleServerRegister : IDataSerializer
        {
         public Int32? ServerType; 
 public Int32? WarType; 
 public Int32? ServerId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleConfigNotify : IDataSerializer
        {
         public Vector<GCountryCapital> CountryCapitals; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleMove : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Dest; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleMove_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? Dest; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleSyncPlayerLocation : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? DomainId; 
 public Int32? Reason; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleStart : IDataSerializer
        {
         public Int32? BattleId; 
 public UInt32? Defender; 
 public UInt32? Attacker; 
 public UInt32? PlayerLimit; 
 public Int32? EndTime; 
 public UInt32? DefenderPlayerCount; 
 public UInt32? AttackerPlayerCount; 
 public UInt32? CountryMaxPlayerCount; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleStart_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? BattleId; 
 public Int32? Worldtag; 
 public UInt32? Defender; 
 public UInt32? Attacker; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleEnter : IDataSerializer
        {
         public Int32? BattleId; 
 public Int32? Worldtag; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleEnd : IDataSerializer
        {
         public Int32? BattleId; 
 public Int32? BattleResult; 
 public Int32? Attacker; 
 public Int32? Defender; 
 public Vector<GCountryBattlePersonalScore> AttackerScore; 
 public Vector<GCountryBattlePersonalScore> DefenderScore; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetMap : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetMap_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<GCountryBattleDomain> Domains; 
 public Vector<Int32> Kings; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleSyncPlayerPos : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Worldtag; 
 public Single? PosX; 
 public Single? PosY; 
 public Single? PosZ; 
 public Byte? IsCapital; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetPlayerLocation : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetConfig : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetConfig_Re : IDataSerializer
        {
         public Int32? StartTimestamp; 
 public Int32? EndTimetamp; 
 public Int32? Bonus; 
 public Byte? IsBattleOpen; 
 public Byte? Domain2DataType; 
 public UInt32? Domain2DatatTimestamp; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetScore : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetScore_Re : IDataSerializer
        {
         public Int32? PlayerScore; 
 public Vector<Int32> CountryScore; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattlePreEnterNotify : IDataSerializer
        {
         public Int32? BattleId; 
 public Int32? RoleId; 
 public Int32? Timeout; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattlePreEnter : IDataSerializer
        {
         public Int32? BattleId; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleResult : IDataSerializer
        {
         public Int32? PlayerBonus; 
 public Vector<Int32> CountryBonus; 
 public Vector<Int32> CountryDomainsCount; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleReturnCapital : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleSingleBattleResult : IDataSerializer
        {
         public Int32? DomainId; 
 public Int32? SingleBattleTotalScore; 
 public Int32? PlayerSingleBattleScore; 
 public Int32? PlayerRank; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleKingAssignAssault : IDataSerializer
        {
         public Int32? KingRoleId; 
 public Int32? DomainId; 
 public Byte? AssaultType; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleKingAssignAssault_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DomainId; 
 public Byte? AssaultType; 
 public Int32? CommandPoint; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleKingResetBattleLimit : IDataSerializer
        {
         public Int32? KingRoleId; 
 public Int32? DomainId; 
 public Byte? Op; 
 public Vector<GCountryBattleLimit> Limit; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetBattleLimit : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? DomainId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetBattleLimit_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DomainId; 
 public Vector<GCountryBattleLimit> Limit; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetKingCommandPoint : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleGetKingCommandPoint_Re : IDataSerializer
        {
         public Int32? CommandPoint; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetCNetServerConfig : IDataSerializer
        {
         public Int32? RoleId; 
 public Vector<Int32> Keys; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetRemoteCNetServerConfig : IDataSerializer
        {
         public Vector<Int32> Keys; 
 public UInt32? LinkSId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleDestroyInstance : IDataSerializer
        {
         public Int32? DomainId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerFactionInfo : IDataSerializer
        {
         public Vector<Int32> RoleList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerFactionInfo_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<PFactionInfo> FactionInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionChat : IDataSerializer
        {
         public Byte? Channel; 
 public Byte? Emotion; 
 public Int32? SrcroleId; 
 public Octets Message; 
 public Octets Data; 
 public UInt32? DstlocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionOPRequest : IDataSerializer
        {
         public Int32? OpType; 
 public Int32? RoleId; 
 public Octets Params; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionOPRequest_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? OpType; 
 public Int32? RoleId; 
 public Int32? LinkId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionBeginSync : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionBeginSync_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? TId; 
 public Int32? RoleId; 
 public FactionOPSyncInfo SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionEndSync : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? RoleId; 
 public FactionOPSyncInfo SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionAcceptJoin : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public UInt32? FactionId; 
 public Int32? InvitedRoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetFactionBaseInfo : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Vector<Int32> FactionList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetFactionBaseInfo_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public GFactionBaseInfo FactionInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetPlayerFactionInfo : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetPlayerFactionInfo_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public GUserFaction FactionInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DelFactionAnnounce : IDataSerializer
        {
         public UInt32? FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionListOnline : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionListOnline_Re : IDataSerializer
        {
         public Vector<UInt32> FidList; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetPlayerFactionRelation : IDataSerializer
        {
         public Int32? FactionId; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetPlayerFactionRelation_Re : IDataSerializer
        {
         public Int32? FactionId; 
 public Vector<Int32> RoleIdList; 
 public Vector<Int32> Alliance; 
 public Vector<Int32> Hostile; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionCongregateRequest : IDataSerializer
        {
         public Int32? FactionId; 
 public Int32? Sponsor; 
 public Octets Data; 
 public Vector<Int32> Member; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KEGetStatus : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KEGetStatus_Re : IDataSerializer
        {
         public Int32? Status; 
 public KEKing King; 
 public Vector<KECandidate> CandidateList; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KECandidateApply : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? ItemId; 
 public Int32? ItemNumber; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KECandidateApply_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KEVoting : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemNumber; 
 public Int32? CandidateRoleId; 
 public Octets SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KEVoting_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KEKingNotify : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? EndTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattleServerRegister : IDataSerializer
        {
         public Int32? ServerId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattlePlayerApply : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Model; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattlePlayerApply_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? RetCode; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattleEnter : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? BattleId; 
 public Int32? Worldtag; 
 public Int32? Model; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattlePlayerEnter : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? BattleId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattlePlayerLeave : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? BattleId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattleStart : IDataSerializer
        {
         public Int32? BattleId; 
 public Int32? EndTime; 
 public UInt32? MaxPlayerCount; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattleStart_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? BattleId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattleEnd : IDataSerializer
        {
         public Int32? BattleId; 
 public Int32? Worldtag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattlePlayerScoreUpdate : IDataSerializer
        {
         public Int32? BattleId; 
 public Int32? Worldtag; 
 public Vector<TankBattlePlayerScoreInfo> PlayerScores; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattlePlayerGetRank : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattlePlayerGetRank_Re : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? RetCode; 
 public TankBattlePlayerScoreInfo YourScore; 
 public Vector<TankBattlePlayerScoreInfo> PlayerScores; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SendRefAddBonus : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Bonus; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SendRefCashUsed : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? CashUsed; 
 public Int32? Level; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RefListReferrals : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? StartIndex; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RefListReferrals_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? StartIndex; 
 public Int32? Total; 
 public Int32? BonusAvailToday; 
 public Vector<ReferralBrief> Referrals; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RefWithdrawBonus : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RefWithdrawBonus_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RefGetReferenceCode : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RefGetReferenceCode_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? Level; 
 public Int32? Reputation; 
 public Octets RefCode; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SendRewardAddBonus : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Bonus; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetRewardList : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? StartIndex; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetRewardList_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? ConsumePoints; 
 public Int32? StartIndex; 
 public Int32? Total; 
 public Vector<RewardItem> RewardList; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ExchangeConsumePoints : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? RewardType; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ExchangeConsumePoints_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public Int32? BonusAdd; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RewardMatureNotice : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? BonusReward; 
 public Int32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SendTaskReward : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? BonusAdd; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Acreport : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets Report; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACWhoAmI : IDataSerializer
        {
         public Int32? ClientType; 
 public Int32? SubId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACRemoteCode : IDataSerializer
        {
         public Int32? DstroleId; 
 public Vector<Octets> Content; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACConnectRe : IDataSerializer
        {
         public Int32? AId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACReloadConfig : IDataSerializer
        {
         public Int32? ReloadType; 
 public Octets Config; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACReloadConfigRe : IDataSerializer
        {
         public Int32? ResCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQLogInfo : IDataSerializer
        {
         public ACQ ACQ; 
 public Vector<ACLogInfo> Logs; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQUserOnline : IDataSerializer
        {
         public ACQ ACQ; 
 public Vector<IntData> Users; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACSendCode : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets CodeName; 
 public Octets Param; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQCodeRes : IDataSerializer
        {
         public ACQ ACQ; 
 public Vector<ACUserCodeRes> Res; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQPatterns : IDataSerializer
        {
         public ACQ ACQ; 
 public Vector<ACStackPattern> Patterns; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQPlatformInfo : IDataSerializer
        {
         public ACQ ACQ; 
 public Vector<ACPlatformInfo> PlatformInfo; 
 public Vector<ACCPUInfo> CpuInfo; 
 public Vector<ACMemInfo> MemInfo; 
 public Vector<ACAdapterInfo> AdapterInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACVersion : IDataSerializer
        {
         public Octets Version; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQStrOwner : IDataSerializer
        {
         public ACQ ACQ; 
 public Vector<IntData> Owners; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQMouseInfo : IDataSerializer
        {
         public ACQ ACQ; 
 public Vector<ACMouseInfo> MouseInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQThreadTimes : IDataSerializer
        {
         public ACQ ACQ; 
 public ACThreadTime ProcessTime; 
 public Vector<ACThreadTime> ThreadTimes; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACProtoStat : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Keepalive; 
 public Int32? GameDataSend; 
 public Int32? PublicChat; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQProtocolStats : IDataSerializer
        {
         public ACQ ACQ; 
 public Vector<ACProtocolStat> ProtoStats; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACStatusAnnounce : IDataSerializer
        {
         public Int32? Status; 
 public Vector<ACOnlineStatus> InfoList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACRemoteExe : IDataSerializer
        {
         public Int32? FileSize; 
 public Int32? RoleId; 
 public Int32? PType; 
 public Octets Exe; 
 public Octets Name; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACRemoteExeRe : IDataSerializer
        {
         public Int32? ResCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACReportCheater : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? CheatType; 
 public Octets CheatInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACTriggerQuestion : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQuestion : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? QType; 
 public Int32? Seq; 
 public Int32? Reserved; 
 public Vector<Octets> Question; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACAnswer : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? QType; 
 public Int32? Seq; 
 public Int32? Reserved; 
 public Int32? Answer; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACStatusAnnounce2 : IDataSerializer
        {
         public Int32? Status; 
 public Vector<ACOnlineStatus2> InfoList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACKickoutUser : IDataSerializer
        {
         public Int32? GmUserId; 
 public Int32? IdType; 
 public Int32? UserID; 
 public Int32? ForbidTime; 
 public Octets Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACAccuse : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int64? RoleId; 
 public Int64? AccId; 
 public Int64? AccusationRoleId; 
 public Int64? AccusationAccId; 
 public Octets Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACAccuseRe : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int64? RoleId; 
 public Int64? AccId; 
 public Int64? AccusationRoleId; 
 public Int64? AccusationAccId; 
 public Int32? Result; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ForwardChat : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? LineId; 
 public Int32? UserID; 
 public Int32? RoleId; 
 public Octets Name; 
 public Octets Message; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DisableAutolock : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACForbidCheater : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? Time; 
 public Byte? Operation; 
 public Octets Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuthdVersion : IDataSerializer
        {
         public Int32? Version; 
 public Int32? RetCode; 
 public Int32? Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SSOGetTicketReq : IDataSerializer
        {
         public SSOUser User; 
 public Int32? Loginip; 
 public Int32? ToaId; 
 public Int32? ToZoneId; 
 public Octets Info; 
 public Octets LocalContext; 
 public Octets Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SSOGetTicketRep : IDataSerializer
        {
         public Int32? RetCode; 
 public SSOUser User; 
 public Octets Ticket; 
 public Octets LocalContext; 
 public Octets Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Post : IDataSerializer
        {
         public Int32? AId; 
 public Int32? ZoneId; 
 public TraderInfo Seller; 
 public TraderInfo Buyer; 
 public Int64? Sn; 
 public Int32? Price; 
 public Byte? Shelf; 
 public Int32? PostType; 
 public Int32? Num; 
 public Int32? Loginip; 
 public TimeInfo Time; 
 public PostInfo Info; 
 public Octets Backup; 
 public Int64? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Post_Re : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public TimeInfo Time; 
 public Int32? RetCode; 
 public Int64? Timestamp; 
 public Int32? BuyLevel; 
 public Int32? CommodityId; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GamePostCancel : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public Int64? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GamePostCancel_Re : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public Int32? RetCode; 
 public Int64? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebPostCancel : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public Int32? CType; 
 public Int64? MessageId; 
 public Int64? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebPostCancel_Re : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public Int32? RetCode; 
 public Int64? MessageId; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Shelf : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public Int32? Price; 
 public TimeInfo Time; 
 public Int64? BuyerroleId; 
 public Int64? MessageId; 
 public Int64? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Shelf_Re : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public Int32? RetCode; 
 public Int64? MessageId; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ShelfCancel : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public Int64? MessageId; 
 public Int64? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ShelfCancel_Re : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public Int32? RetCode; 
 public Int64? MessageId; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Sold : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? SellerUserId; 
 public Int64? SellerroleId; 
 public Int32? BuyerUserId; 
 public Int64? BuyerroleId; 
 public Int64? Sn; 
 public Int64? OrderId; 
 public Int32? SType; 
 public Int64? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Sold_Re : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? SellerUserId; 
 public Int64? SellerroleId; 
 public Int32? BuyerUserId; 
 public Int64? BuyerroleId; 
 public Int64? Sn; 
 public Int32? RetCode; 
 public Int64? OrderId; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostExpire : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public Int64? MessageId; 
 public Int64? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostExpire_Re : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Int64? Sn; 
 public Int32? RetCode; 
 public Int64? MessageId; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebGetRoleList : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? MessageId; 
 public Int64? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebGetRoleList_Re : IDataSerializer
        {
         public Int32? AId; 
 public Int32? UserID; 
 public Int32? RetCode; 
 public Vector<WebRole> RoleList; 
 public Int64? MessageId; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class NewKeepAlive : IDataSerializer
        {
         public Int32? Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AU2Game : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? QType; 
 public Octets Info; 
 public Int32? RetCode; 
 public Int32? Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Game2AU : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? QType; 
 public Octets Info; 
 public Int32? Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BillingBalanceSA : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BillingBalanceSA_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public Int32? Cashremain; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BillingConfirm : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? ItemId; 
 public Int32? ItemCount; 
 public Octets ItemName; 
 public Int32? ItemExpire; 
 public Int32? ItemPrice; 
 public Int32? Loginip; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BillingConfirm_Re : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public Int32? ItemId; 
 public Int32? ItemCount; 
 public Octets ItemName; 
 public Int32? ItemExpire; 
 public Int32? ItemPrice; 
 public Int32? Cashremain; 
 public Octets Chargeno; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BillingCancel : IDataSerializer
        {
         public Int32? UserID; 
 public Octets Chargeno; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DiscountAnnounce : IDataSerializer
        {
         public Vector<MerchantDiscount> Discount; 
 public Int32? Reserved1; 
 public Octets Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysSendMail3 : IDataSerializer
        {
         public Int64? OrderId; 
 public Int32? UserID; 
 public Int64? RoleId; 
 public Octets RoleName; 
 public Octets MailTitle; 
 public Octets MailContext; 
 public UInt32? AttachMoney; 
 public MailGoodsInventory AttachGoods; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysSendMail3_Re : IDataSerializer
        {
         public Int64? OrderId; 
 public Int32? RetCode; 
 public Int64? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceZoneidToIM : IDataSerializer
        {
         public Int32? AId; 
 public Int32? ZoneId; 
 public Int64? BootTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GameSysMsg : IDataSerializer
        {
         public Int32? MType; 
 public Int64? Time; 
 public Int32? EmotionGroup; 
 public Octets Content; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GameDataReq : IDataSerializer
        {
         public Int32? DType; 
 public Int64? Id; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GameDataResp : IDataSerializer
        {
         public Int32? DType; 
 public Int64? Id; 
 public Byte? RetCode; 
 public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class IMKeepAlive : IDataSerializer
        {
         public Byte? Code; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceResp : IDataSerializer
        {
         public Int32? Code; 
 public Int64? BootTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleListReq : IDataSerializer
        {
         public Int64? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleRelationReq : IDataSerializer
        {
         public Int64? UserID; 
 public Int64? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleRelationResp : IDataSerializer
        {
         public Int64? UserID; 
 public RoleBean RoleInfo; 
 public Vector<FactionIDBean> Factions; 
 public Vector<RoleGroupBean> Friends; 
 public Vector<RoleInfoBean> BlackList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleStatusReq : IDataSerializer
        {
         public Int64? LocalRId; 
 public Vector<Int64> RoleList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleStatusUpdate : IDataSerializer
        {
         public Int64? RoleId; 
 public RoleStatusBean Status; 
 public Vector<Int64> Friends; 
 public Vector<FactionIDBean> Factions; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleGroupUpdate : IDataSerializer
        {
         public Int64? RoleId; 
 public Int32? GType; 
 public Int64? GroupId; 
 public Octets GroupName; 
 public Byte? Operation; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleFriendUpdate : IDataSerializer
        {
         public Int64? RoleId; 
 public RoleBean Rolefriend; 
 public Int32? GType; 
 public Int64? GroupId; 
 public Byte? Operation; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleBlacklistUpdate : IDataSerializer
        {
         public Int64? RoleId; 
 public RoleInfoBean Target; 
 public Byte? Operation; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleMsg : IDataSerializer
        {
         public Int64? Receiver; 
 public RoleMsgBean Message; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleOfflineMessages : IDataSerializer
        {
         public Int64? Receiver; 
 public Vector<RoleMsgBean> Messages; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleActivation : IDataSerializer
        {
         public Int64? RoleId; 
 public Byte? Operation; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RemoveRole : IDataSerializer
        {
         public Int64? UserID; 
 public Int64? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleInfoUpdate : IDataSerializer
        {
         public RoleInfoBean RoleInfo; 
 public Int32? UpdateFlag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleInfoReq : IDataSerializer
        {
         public Int64? LocalUId; 
 public Int64? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleInfoResp : IDataSerializer
        {
         public Int64? LocalUId; 
 public RoleInfoBean RoleInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SyncTeams : IDataSerializer
        {
         public Vector<TeamBean> Teams; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TeamCreate : IDataSerializer
        {
         public TeamBean Team; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TeamDismiss : IDataSerializer
        {
         public Int64? TeamId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TeamMemberUpdate : IDataSerializer
        {
         public Int64? TeamId; 
 public Vector<Int64> Members; 
 public Byte? Operation; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionInfoReq : IDataSerializer
        {
         public Int64? LocalUId; 
 public FactionIDBean FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionInfoResp : IDataSerializer
        {
         public Int64? LocalUId; 
 public FactionIDBean FactionId; 
 public FactionInfoBean FactionInfo; 
 public Vector<FactionTitleBean> Members; 
 public Octets ForbidList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionMemberUpdate : IDataSerializer
        {
         public FactionIDBean FactionId; 
 public Vector<RoleBean> Roles; 
 public Int32? TitleId; 
 public Byte? Operation; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionInfoUpdate : IDataSerializer
        {
         public FactionIDBean FactionId; 
 public FactionInfoBean FactionInfo; 
 public Int32? UpdateFlag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionMsg : IDataSerializer
        {
         public FactionIDBean FactionId; 
 public RoleMsgBean Message; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RemoveFaction : IDataSerializer
        {
         public FactionIDBean FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionForbidUpdate : IDataSerializer
        {
         public FactionIDBean FactionId; 
 public Octets UpdateForbid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleEnterVoiceChannel : IDataSerializer
        {
         public Int64? UserID; 
 public Int64? RoleId; 
 public Int32? ZoneId; 
 public Int64? Seq; 
 public Int64? Timestamp; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleLeaveVoiceChannel : IDataSerializer
        {
         public Int64? UserID; 
 public Int64? RoleId; 
 public Int32? ZoneId; 
 public Int64? Seq; 
 public Int64? Timestamp; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleEnterVoiceChannelAck : IDataSerializer
        {
         public Int64? UserID; 
 public Int64? RoleId; 
 public Int32? ZoneId; 
 public Int64? Seq; 
 public Int64? Timestamp; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleLeaveVoiceChannelAck : IDataSerializer
        {
         public Int64? UserID; 
 public Int64? RoleId; 
 public Int32? ZoneId; 
 public Int64? Seq; 
 public Int64? Timestamp; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BillingBalance : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? Request; 
 public Int32? Result; 
 public Int32? Balance; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BillingRequest : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? Request; 
 public Int32? Result; 
 public Int32? ItemId; 
 public Int32? ItemNumber; 
 public Int32? Timeout; 
 public Int32? Amount; 
 public Octets MenuId; 
 public Octets Bxtxno; 
 public Octets Agtxno; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Integer : IDataSerializer
        {
         public Int32? Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserLoginArg : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 
 public Boolean? KickUser; 
 public Int32? FreeCreaTime; 
 public Int32? Loginip; 
 public Octets Account; 
 public Octets ISeckey; 
 public Octets OSeckey; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserLoginRes : IDataSerializer
        {
         public Byte? RetCode; 
 public Int32? RemainPlayTime; 
 public Int32? Func; 
 public Int32? Funcparm; 
 public Boolean? IsGM; 
 public Int32? FreeTimeLeft; 
 public Int32? FreeTimeEnd; 
 public Int32? CreateTime; 
 public Int32? AddUpPoint; 
 public Int32? SoldPoint; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserLogoutArg : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserLogoutRes : IDataSerializer
        {
         public Byte? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Player : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleInfo : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? Gender; 
 public Byte? Race; 
 public Byte? Occupation; 
 public Int32? Level; 
 public Int32? Level2; 
 public Octets Name; 
 public Octets CustomData; 
 public Vector<GRoleInventory> Equipment; 
 public Boolean? Status; 
 public Int32? DeleteTime; 
 public Int32? CreateTime; 
 public Int32? LastloginTime; 
 public Single? PosX; 
 public Single? PosY; 
 public Single? PosZ; 
 public Int32? Worldtag; 
 public Octets CustomStatus; 
 public Octets CharacterMode; 
 public Int32? ReferrerRole; 
 public Int32? CashAdd; 
 public Octets ReincarnationData; 
 public Octets RealmData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerBriefInfo : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? Occupation; 
 public Octets Name; 
 public Byte? Gender; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class OnlinePlayerStatus : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? GId; 
 public Int32? LinkId; 
 public UInt32? LinkSId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetTaskDataArg : IDataSerializer
        {
         public Int32? TaskId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetTaskDataRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets TaskData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PutTaskDataArg : IDataSerializer
        {
         public Int32? TaskId; 
 public Octets TaskData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PutTaskDataRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMQueryRoleInfoRes : IDataSerializer
        {
         public Int32? Status; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryUseridArg : IDataSerializer
        {
         public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QueryUseridRes : IDataSerializer
        {
         public Int32? Result; 
 public Int32? UserID; 
 public Int32? RoleId; 
 public Int32? Level; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QPDiscountLevel : IDataSerializer
        {
         public Int32? AmountBegin; 
 public Int32? Discount; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class QPDiscountInfo : IDataSerializer
        {
         public Int32? Id; 
 public Octets Name; 
 public Vector<QPDiscountLevel> Discount; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerPositionResetRqstArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? Worldtag; 
 public Int32? Reason; 
 public Single? PosX; 
 public Single? PosY; 
 public Single? PosZ; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerPositionResetRqstRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CashMoneyExchangeControlArg : IDataSerializer
        {
         public Byte? Oper; 
 public Int32? Param; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CashMoneyExchangeControlRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ServerForbidControlArg : IDataSerializer
        {
         public Byte? Oper; 
 public Octets Param; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ServerForbidControlRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets ForbidCmd; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMPlayerInfo : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? RoleId; 
 public Int32? LinkId; 
 public UInt32? LocalSid; 
 public Int32? GSId; 
 public Boolean? Status; 
 public Octets Name; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMaxOnlineNumArg : IDataSerializer
        {
         public Int32? Padding; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMaxOnlineNumRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? Maxnum; 
 public Int32? FakeMaxnum; 
 public Int32? Curnum; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMGetGameAttriArg : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Byte? Attribute; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMGetGameAttriRes : IDataSerializer
        {
         public Octets Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMSetGameAttriArg : IDataSerializer
        {
         public Int32? GmroleId; 
 public UInt32? LocalSid; 
 public Byte? Attribute; 
 public Octets Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMSetGameAttriRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMControlGameRes : IDataSerializer
        {
         public Int32? GSId; 
 public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerConsumeInfo : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Level; 
 public Int32? Loginip; 
 public UInt32? CashAdd; 
 public UInt32? MallConsumption; 
 public UInt32? AvgOnlineTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGetConsumeInfosArg : IDataSerializer
        {
         public Vector<Int32> Playerlist; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGetConsumeInfosRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<PlayerConsumeInfo> Playerlist; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAutolockSetOfflineArg : IDataSerializer
        {
         public Int32? UserID; 
 public Vector<GPair> AutoLockDiff; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAutolockSetOfflineRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<GPair> AutoLock; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAutolockGetArg : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAutolockGetRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<GPair> AutoLock; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GQueryPasswdArg : IDataSerializer
        {
         public Octets Account; 
 public Octets Challenge; 
 public Int32? Loginip; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GQueryPasswdRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public Octets Response; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AccntParam : IDataSerializer
        {
         public UInt32? Type; 
 public UInt32? Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GameAttr : IDataSerializer
        {
         public Byte? Attr; 
 public Octets Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CashSerialArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? ZoneId; 
 public Byte? Force; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CashSerialRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public Int32? ZoneId; 
 public Int32? Sn; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetAddCashSNArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? ZoneId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetAddCashSNRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public Int32? ZoneId; 
 public Int32? Sn; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MatrixPasswdArg : IDataSerializer
        {
         public Octets Account; 
 public Octets Challenge; 
 public Int32? Loginip; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MatrixPasswdRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public Int32? Algorithm; 
 public Octets Response; 
 public Octets Matrix; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GPair : IDataSerializer
        {
         public Int32? Key; 
 public Int32? Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetUserCouponArg : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetUserCouponRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RemainCoupon; 
 public Int32? TodayExchangeCoupon; 
 public Int32? TodayRemainCoupon; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CouponExchangeArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? CouponNumber; 
 public Int32? CashNumber; 
 public Int64? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CouponExchangeRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RemainCoupon; 
 public Int32? TodayExchangeCoupon; 
 public Int32? TodayRemainCoupon; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MatrixPasswd2Res : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public Int32? Algorithm; 
 public Octets Response; 
 public Octets Matrix; 
 public Octets Seed; 
 public Octets Pin; 
 public Int32? RTime; 
 public Int32? AuCurTime; 
 public Vector<GRoleForbid> Forbid; 
 public Octets LastUsedElecNumber; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserLogin2Arg : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LocalSid; 
 public Boolean? KickUser; 
 public Int32? FreeCreaTime; 
 public Octets UsedElecNumber; 
 public Int32? Reserved1; 
 public Octets Reserved2; 
 public Int32? Loginip; 
 public Octets Account; 
 public Octets ISeckey; 
 public Octets OSeckey; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserLogin2Res : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RemainPlayTime; 
 public Int32? Func; 
 public Int32? Funcparm; 
 public Boolean? IsGM; 
 public Int32? FreeTimeLeft; 
 public Int32? FreeTimeEnd; 
 public Int32? CreateTime; 
 public Int32? AddUpPoint; 
 public Int32? SoldPoint; 
 public Octets Auth; 
 public Byte? Gender; 
 public Int32? RemainCoupon; 
 public Int32? TodayExchangeCoupon; 
 public Int32? TodayRemainCoupon; 
 public Octets NickName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MatrixTokenArg : IDataSerializer
        {
         public Octets Account; 
 public Octets Token; 
 public Int32? Loginip; 
 public Octets Challenge; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MatrixTokenRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public Int32? Algorithm; 
 public Octets Response; 
 public Octets Matrix; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class InstantAddCashArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? Loginip; 
 public Octets Cardnum; 
 public Octets CardPasswd; 
 public Int32? Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class InstantAddCashRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SSOUser : IDataSerializer
        {
         public Byte? Isagent; 
 public Int64? UserID; 
 public Octets Account; 
 public Octets AgentName; 
 public Octets Agentaccount; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GTouchTrade : IDataSerializer
        {
         public Int64? Sn; 
 public Byte? State; 
 public UInt32? Cost; 
 public UInt32? ItemId; 
 public UInt32? Count; 
 public UInt32? Lots; 
 public Int32? ExpireTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MInt : IDataSerializer
        {
         public Int32? Id; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DiscountGrade : IDataSerializer
        {
         public Int32? AmountBegin; 
 public Int32? Discount; 
 public Int32? Reserved1; 
 public Octets Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MerchantDiscount : IDataSerializer
        {
         public Int32? Id; 
 public Octets Name; 
 public Int32? Reserved; 
 public Vector<DiscountGrade> Discount; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SellID : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? SellIDValue; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DefSellPointRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SellPointInfo : IDataSerializer
        {
         public Int32? SellID; 
 public Int32? RoleId; 
 public Int32? Point; 
 public Int32? Price; 
 public Int32? CTime; 
 public Int32? ETime; 
 public Boolean? Status; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SellPointArg : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? Point; 
 public Int32? Price; 
 public Int32? Timestamp; 
 public Int32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SellPointRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? SellID; 
 public Int32? CTime; 
 public Int32? ETime; 
 public Boolean? Status; 
 public Int32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSyncSellInfoRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<SellPointInfo> List; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBuyPointArg : IDataSerializer
        {
         public Int32? Buyer; 
 public UInt32? LocalSid; 
 public Int32? SellID; 
 public Int32? Seller; 
 public Int32? Timestamp; 
 public Int32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBuyPointRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? Point; 
 public Int32? Price; 
 public Int32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TransID : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? SerialNo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBTransPointDealRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<Int32> DelSell; 
 public Int32? GetMoney; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PutSpouseArg : IDataSerializer
        {
         public Int32? Oper; 
 public Int32? RId1; 
 public Int32? RId2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RawKeyValue : IDataSerializer
        {
         public Octets Key; 
 public Octets Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRawReadArg : IDataSerializer
        {
         public Octets Table; 
 public Octets Handle; 
 public Octets Key; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRawReadRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets Handle; 
 public Vector<RawKeyValue> Values; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBClearConsumableArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? LoginTime; 
 public Byte? Dryrun; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockLog : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? Time; 
 public Int16? Result; 
 public Int16? Volume; 
 public Int32? Cost; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GLoginRecord : IDataSerializer
        {
         public Int32? LoginTime; 
 public Int32? Loginip; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GConsumptionRecord : IDataSerializer
        {
         public Int32? Consumption; 
 public Int32? Reserved; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserID : IDataSerializer
        {
         public UInt32? Id; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class User : IDataSerializer
        {
         public UInt32? LogicUId; 
 public UInt32? RoleList; 
 public Int32? Cash; 
 public Int32? Money; 
 public UInt32? CashAdd; 
 public UInt32? CashBuy; 
 public UInt32? CashSell; 
 public UInt32? CashUsed; 
 public Int32? AddSerial; 
 public Int32? UseSerial; 
 public Vector<StockLog> ExgLog; 
 public Octets Addiction; 
 public Octets CashPassword; 
 public Vector<GPair> AutoLock; 
 public Boolean? Status; 
 public Vector<GRoleForbid> Forbid; 
 public Octets Reference; 
 public Octets ConsumeReward; 
 public Octets Taskcounter; 
 public Octets CashSysauction; 
 public Octets LoginRecord; 
 public Octets MallConsumption; 
 public Int16? Reserved32; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserArg : IDataSerializer
        {
         public UInt32? Id; 
 public Int32? LoginTime; 
 public Int32? Loginip; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserRes : IDataSerializer
        {
         public Int32? RetCode; 
 public User Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserPair : IDataSerializer
        {
         public UserID Key; 
 public User Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleForbid : IDataSerializer
        {
         public Byte? Type; 
 public Int32? Time; 
 public Int32? CreateTime; 
 public Octets Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleBase : IDataSerializer
        {
         public Byte? Version; 
 public UInt32? Id; 
 public Octets Name; 
 public Int32? Race; 
 public Int32? Cls; 
 public Byte? Gender; 
 public Octets CustomData; 
 public Octets ConfigData; 
 public UInt32? CustomStamp; 
 public Boolean? Status; 
 public Int32? DeleteTime; 
 public Int32? CreateTime; 
 public Int32? LastloginTime; 
 public Vector<GRoleForbid> Forbid; 
 public Octets HelpStates; 
 public UInt32? Spouse; 
 public UInt32? UserID; 
 public Octets CrossData; 
 public Byte? Reserved2; 
 public Byte? Reserved3; 
 public Byte? Reserved4; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleStatus : IDataSerializer
        {
         public Byte? Version; 
 public Int32? Level; 
 public Int32? Level2; 
 public Int32? Exp; 
 public Int32? Sp; 
 public Int32? Pp; 
 public Int32? Hp; 
 public Int32? Mp; 
 public Single? PosX; 
 public Single? PosY; 
 public Single? PosZ; 
 public Int32? Worldtag; 
 public Int32? InvaderState; 
 public Int32? InvaderTime; 
 public Int32? PariahTime; 
 public Int32? Reputation; 
 public Octets CustomStatus; 
 public Octets FilterData; 
 public Octets CharacterMode; 
 public Octets InstancekeyList; 
 public Int32? DoubleTimeExpire; 
 public Int32? DoubleTimeMode; 
 public Int32? DoubleTimeBegin; 
 public Int32? DoubleTimeUsed; 
 public Int32? DoubleTimeMax; 
 public Int32? TimeUsed; 
 public Octets DoubleTimeData; 
 public UInt16? StoreSize; 
 public Octets Petcorral; 
 public Octets Property; 
 public Octets VarData; 
 public Octets Skills; 
 public Octets StorehousePasswd; 
 public Octets WaypointList; 
 public Octets CoolingTime; 
 public Octets NpcRelation; 
 public Octets MultiExpCtrl; 
 public Octets StorageTask; 
 public Octets FactionContrib; 
 public Octets ForceData; 
 public Octets OnlineAward; 
 public Octets ProfitTimeData; 
 public Octets CountryData; 
 public Octets KingData; 
 public Octets MeridianData; 
 public Octets ExtraProp; 
 public Octets TitleData; 
 public Octets ReincarnationData; 
 public Octets RealmData; 
 public Byte? Reserved2; 
 public Byte? Reserved3; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleInventory : IDataSerializer
        {
         public UInt32? Id; 
 public Int32? Pos; 
 public Int32? Count; 
 public Int32? MaxCount; 
 public Octets Data; 
 public Int32? ProcType; 
 public Int32? ExpireDate; 
 public Int32? GUId1; 
 public Int32? GUId2; 
 public Int32? Mask; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleStorehouse : IDataSerializer
        {
         public UInt32? Capacity; 
 public UInt32? Money; 
 public Vector<GRoleInventory> Items; 
 public Byte? Size1; 
 public Byte? Size2; 
 public Vector<GRoleInventory> Dress; 
 public Vector<GRoleInventory> Material; 
 public Byte? Size3; 
 public Vector<GRoleInventory> Generalcard; 
 public Int16? Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GUserStoreHouse : IDataSerializer
        {
         public Int32? Capacity; 
 public UInt32? Money; 
 public Vector<GRoleInventory> Items; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GSysLog : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Time; 
 public Int32? Ip; 
 public Int16? Source; 
 public Int32? Money; 
 public Vector<GRoleInventory> Items; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRolePocket : IDataSerializer
        {
         public UInt32? Capacity; 
 public UInt32? Timestamp; 
 public UInt32? Money; 
 public Vector<GRoleInventory> Items; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTask : IDataSerializer
        {
         public Octets TaskData; 
 public Octets TaskComplete; 
 public Octets TaskFinishTime; 
 public Vector<GRoleInventory> TaskInventory; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleEquipment : IDataSerializer
        {
         public Vector<GRoleInventory> Inv; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleData : IDataSerializer
        {
         public GRoleBase Base; 
 public GRoleStatus Status; 
 public GRolePocket Pocket; 
 public GRoleEquipment Equipment; 
 public GRoleStorehouse Storehouse; 
 public GRoleTask Task; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GPet : IDataSerializer
        {
         public Int32? Index; 
 public Octets Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GPetCorral : IDataSerializer
        {
         public Int32? Capacity; 
 public Vector<GPet> Pets; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GShopLog : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? OrderId; 
 public Int32? ItemId; 
 public Int32? Expire; 
 public Int32? ItemCount; 
 public Int32? OrderCount; 
 public Int32? CashNeed; 
 public Int32? Time; 
 public Int32? GUId1; 
 public Int32? GUId2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GUniqueDataElem : IDataSerializer
        {
         public Byte? VType; 
 public Octets Value; 
 public Int32? Version; 
 public Int16? Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GUniqueDataElemNode : IDataSerializer
        {
         public Int32? Key; 
 public GUniqueDataElem Val; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GForceData : IDataSerializer
        {
         public Int32? ForceId; 
 public Int32? Reputation; 
 public Int32? Contribution; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 
 public Int32? Reserved6; 
 public Int32? Reserved7; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GForceDataList : IDataSerializer
        {
         public Int32? CurForceId; 
 public Vector<GForceData> List; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMeridianData : IDataSerializer
        {
         public Int32? MeridianLevel; 
 public Int32? LifegateTimes; 
 public Int32? DeathgateTimes; 
 public Int32? FreeRefineTimes; 
 public Int32? PaidRefineTimes; 
 public Int32? PlayerLoginTime; 
 public Int32? ContinuLoginDays; 
 public Int32? TrigramsMap1; 
 public Int32? TrigramsMap2; 
 public Int32? TrigramsMap3; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GReincarnationRecord : IDataSerializer
        {
         public Int32? Level; 
 public Int32? Timestamp; 
 public Int32? Exp; 
 public Int32? Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GReincarnationData : IDataSerializer
        {
         public Int32? TomeExp; 
 public Byte? TomeActive; 
 public Vector<GReincarnationRecord> Records; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleInfo : IDataSerializer
        {
         public Byte? Version; 
 public UInt32? Id; 
 public Octets Name; 
 public Int32? Race; 
 public Int32? Cls; 
 public Byte? Gender; 
 public Int32? Level; 
 public Int32? Level2; 
 public Single? PosX; 
 public Single? PosY; 
 public Single? PosZ; 
 public Int32? Worldtag; 
 public Octets CustomData; 
 public UInt32? CustomStamp; 
 public Octets CustomStatus; 
 public Octets CharacterMode; 
 public Vector<GRoleInventory> Equipment; 
 public Boolean? Status; 
 public Int32? DeleteTime; 
 public Int32? CreateTime; 
 public Int32? LastloginTime; 
 public Vector<GRoleForbid> Forbid; 
 public Int32? ReferrerRole; 
 public Int32? CashAdd; 
 public CrossInfoData CrossData; 
 public Octets ReincarnationData; 
 public Octets RealmData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleDetail : IDataSerializer
        {
         public Byte? Version; 
 public UInt32? Id; 
 public UInt32? UserID; 
 public GRoleStatus Status; 
 public Octets Name; 
 public Int32? Race; 
 public Int32? Cls; 
 public UInt32? Spouse; 
 public Byte? Gender; 
 public Int32? CreateTime; 
 public Int32? LastloginTime; 
 public Int32? CashAdd; 
 public Int32? CashTotal; 
 public Int32? CashUsed; 
 public Int32? CashSerial; 
 public UInt32? FactionId; 
 public Int32? Factionrole; 
 public Octets CustomData; 
 public UInt32? CustomStamp; 
 public GRolePocket Inventory; 
 public Vector<GRoleInventory> Equipment; 
 public GRoleStorehouse Storehouse; 
 public GRoleTask Task; 
 public Octets Addiction; 
 public Vector<GShopLog> Logs; 
 public Int32? BonusAdd; 
 public Int32? BonusReward; 
 public Int32? BonusUsed; 
 public Int32? Referrer; 
 public GUserStoreHouse UserStoreHouse; 
 public Octets Taskcounter; 
 public Vector<GFactionAlliance> FactionAlliance; 
 public Vector<GFactionHostile> FactionHostile; 
 public Int32? MallConsumption; 
 public Int32? SrcZoneId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableUser : IDataSerializer
        {
         public User User; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableBase : IDataSerializer
        {
         public GRoleBase Base; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableStatus : IDataSerializer
        {
         public GRoleStatus Status; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableInventory : IDataSerializer
        {
         public GRolePocket Inventory; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableEquipment : IDataSerializer
        {
         public Vector<GRoleInventory> Inv; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableStorehouse : IDataSerializer
        {
         public GRoleStorehouse Storehouse; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableTask : IDataSerializer
        {
         public GRoleTask TaskData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableFriendlist : IDataSerializer
        {
         public GFriendList FriendList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableMessages : IDataSerializer
        {
         public Vector<Message> Messages; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableClsConfig : IDataSerializer
        {
         public Byte? Version; 
 public GRoleBase Base; 
 public GRoleStatus Status; 
 public GRolePocket Inventory; 
 public Vector<GRoleInventory> Equipment; 
 public GRoleStorehouse Storehouse; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableRolename : IDataSerializer
        {
         public RoleId Id; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleTableWaitdel : IDataSerializer
        {
         public Int32? DeleteTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GTableDefinition : IDataSerializer
        {
         public User User; 
 public GRoleBase Base; 
 public GRoleStatus Status; 
 public GRoleTask Task; 
 public GRolePocket Inventory; 
 public GRoleEquipment Equipment; 
 public GRoleStorehouse Storehouse; 
 public GMailBox Mailbox; 
 public GFriendList Friends; 
 public Vector<Message> Messages; 
 public GFactionInfo FactionInfo; 
 public StockOrder Order; 
 public GSysLog Syslog; 
 public Octets Config; 
 public Int32? FactionName; 
 public Int32? WaitDel; 
 public GRoleTableClsConfig ClsConfig; 
 public Int32? RoleName; 
 public Byte? ShopLog; 
 public GAuctionDetail Auction; 
 public GUserFaction UserFaction; 
 public Byte? SellPoint; 
 public Byte? TransLog; 
 public GTerritoryStore City; 
 public Octets GTask; 
 public GUserStoreHouse UserStore; 
 public GWebTradeDetail WebTrade; 
 public GWebTradeDetail WebTradesOld; 
 public GServerData ServerData; 
 public GFactionFortressDetail FactionFortress; 
 public GFactionRelation Factionrelation; 
 public GForceGlobalDataList Force; 
 public GFriendExtra Friendext; 
 public GGlobalControlData Globalcontrol; 
 public Octets RoleNameHis; 
 public KingElectionDetail KingElection; 
 public PShopDetail PlayerShop; 
 public WebOrderItemDetail WeborderItem; 
 public PlayerProfileData PlayerProfile; 
 public GUniqueDataElem UniqueData; 
 public Byte? RecallUser; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleId : IDataSerializer
        {
         public UInt32? Id; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleArg : IDataSerializer
        {
         public RoleId Key; 
 public Int32? DataMask; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DataMask; 
 public Byte? GameServerId; 
 public GRoleDetail Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBCreateRoleArg : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? LogicUId; 
 public Int32? RoleId; 
 public RoleInfo RoleInfo; 
 public Int32? AuSuggestReferrer; 
 public Int32? PlayerSuggestReferrer; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBCreateRoleRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? RoleList; 
 public RoleInfo RoleInfo; 
 public Int32? RealReferrer; 
 public Int32? RefretCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBDeleteRoleArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? CreateRollback; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBDeleteRoleRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 
 public UInt32? RoleList; 
 public UInt32? Faction; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBUndoDeleteRoleArg : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBUndoDeleteRoleRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Byte? GameServerId; 
 public Single? PosX; 
 public Single? PosY; 
 public Single? PosZ; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AccountAddRoleArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? RoleId; 
 public Byte? ZoneId; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AccountAddRoleRes : IDataSerializer
        {
         public Byte? RetCode; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AccountDelRoleArg : IDataSerializer
        {
         public Byte? ZoneId; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AccountDelRoleRes : IDataSerializer
        {
         public Byte? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleBasePair : IDataSerializer
        {
         public RoleId Key; 
 public GRoleBase Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleBaseRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRoleBase Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleStatusPair : IDataSerializer
        {
         public RoleId Key; 
 public GRoleStatus Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleStatusRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRoleStatus Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleEquipmentPair : IDataSerializer
        {
         public RoleId Key; 
 public Vector<GRoleInventory> Equipment; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleEquipmentRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<GRoleInventory> Equipment; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleTaskPair : IDataSerializer
        {
         public RoleId Key; 
 public GRoleTask Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleTaskRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRoleTask Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleDataPair : IDataSerializer
        {
         public RoleId Key; 
 public Byte? OverWrite; 
 public GRoleData Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleDataRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRoleData Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBModifyRoleDataArg : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? Mask; 
 public Int32? Level; 
 public Int64? Exp; 
 public UInt32? PocketMoney; 
 public UInt32? StoreMoney; 
 public Int32? PKValue; 
 public Int32? Reputation; 
 public Int32? Potential; 
 public Int32? Occupation; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBModifyRoleDataRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int64? TotalMoney; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeInventoryArg : IDataSerializer
        {
         public UInt32? RoleId1; 
 public UInt32? RoleId2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeInventoryRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRolePocket Pocket1; 
 public GRolePocket Pocket2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeSaveArg : IDataSerializer
        {
         public UInt32? RoleId1; 
 public UInt32? RoleId2; 
 public UInt32? Money1; 
 public UInt32? Money2; 
 public Vector<GRoleInventory> Goods1; 
 public Vector<GRoleInventory> Goods2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeSaveRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMoneyInventoryArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? DataMask; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMoneyInventoryRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? Timestamp; 
 public UInt32? Money; 
 public Vector<GRoleInventory> Goods; 
 public Int32? DataMask; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PutMoneyInventoryArg : IDataSerializer
        {
         public UInt32? RoleId; 
 public UInt32? Money; 
 public Vector<GRoleInventory> Goods; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RolePair : IDataSerializer
        {
         public RoleId Key; 
 public Int32? DataMask; 
 public Byte? Priority; 
 public GRoleDetail Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetRoleBaseStatusRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRoleBase Base; 
 public GRoleStatus Status; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleStorehousePair : IDataSerializer
        {
         public RoleId Key; 
 public GRoleStorehouse Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleStorehouseRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRoleStorehouse Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleForbidPair : IDataSerializer
        {
         public RoleId Key; 
 public Vector<GRoleForbid> Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetRoleForbidArg : IDataSerializer
        {
         public RoleId Key; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetRoleForbidRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<GRoleForbid> Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetRoleIdArg : IDataSerializer
        {
         public Octets RoleName; 
 public Byte? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetRoleIdRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TransactionTimeout : IDataSerializer
        {
         public UInt32? Timeout; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TransactionId : IDataSerializer
        {
         public UInt32? Id; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PreCreateRoleArg : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? UserID; 
 public Int32? UseLogic; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PreCreateRoleRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 
 public UInt32? LogicUId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostCreateRoleArg : IDataSerializer
        {
         public Byte? Success; 
 public Int32? UserID; 
 public Int32? ZoneId; 
 public Int32? RoleId; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostCreateRoleRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostDeleteRoleArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? ZoneId; 
 public Int32? RoleId; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostDeleteRoleRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PreCreateFactionArg : IDataSerializer
        {
         public Int32? ZoneId; 
 public Octets FactionName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PreCreateFactionRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostCreateFactionArg : IDataSerializer
        {
         public Byte? Success; 
 public Int32? ZoneId; 
 public Int32? FactionId; 
 public Octets FactionName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostCreateFactionRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostDeleteFactionArg : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? FactionId; 
 public Octets FactionName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostDeleteFactionRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PreCreateFamilyArg : IDataSerializer
        {
         public Int32? ZoneId; 
 public Octets FamilyName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PreCreateFamilyRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? FamilyId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostCreateFamilyArg : IDataSerializer
        {
         public Byte? Success; 
 public Int32? ZoneId; 
 public Int32? FamilyId; 
 public Octets FamilyName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostCreateFamilyRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostDeleteFamilyArg : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int32? FamilyId; 
 public Octets FamilyName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostDeleteFamilyRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleInfoRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRoleInfo Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RolePocketPair : IDataSerializer
        {
         public RoleId Key; 
 public GRolePocket Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RolePocketRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRolePocket Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PrePlayerRenameArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ZoneId; 
 public Int32? UserID; 
 public Octets NewName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PrePlayerRenameRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPlayerRenameArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ItemId; 
 public Int32? ItemNumber; 
 public Int32? ItemPos; 
 public Octets NewName; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPlayerRenameRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets OldName; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleNameHis : IDataSerializer
        {
         public Octets OldName; 
 public Int32? RenameTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoleIDandName : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRoleNameListArg : IDataSerializer
        {
         public Int32? Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRoleNameListRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? Handle; 
 public Byte? Finish; 
 public Vector<GRoleIDandName> RoleNameList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPlayerGivePresentArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 
 public Int32? TargetRoleId; 
 public Int32? MailId; 
 public Vector<GRoleInventory> Goods; 
 public UInt32? CashCost; 
 public Byte? HasGift; 
 public Int32? LogPrice1; 
 public Int32? LogPrice2; 
 public Octets RoleName; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPlayerGivePresentRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailHeader InformTarget; 
 public GMailHeader InformTarget2; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPlayerAskForPresentArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? TargetRoleId; 
 public Int32? GoodsId; 
 public Int32? GoodsIndex; 
 public Int32? GoodsSlot; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPlayerAskForPresentRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailHeader InformTarget; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GServerData : IDataSerializer
        {
         public Int32? Worldtag; 
 public Octets WeddingData; 
 public Octets DpsrankData; 
 public Byte? Reserved11; 
 public Int16? Reserved12; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PutServerDataArg : IDataSerializer
        {
         public Int32? Worldtag; 
 public Int32? DataMask; 
 public Int32? Priority; 
 public GServerData Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetServerDataArg : IDataSerializer
        {
         public Int32? Worldtag; 
 public Int32? DataMask; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetServerDataRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? DataMask; 
 public GServerData Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetCashTotalArg : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetCashTotalRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? CashTotal; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSetCashPasswordArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? Source; 
 public Octets Password; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSetCashPasswordRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPlayerPositionResetArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Worldtag; 
 public Single? PosX; 
 public Single? PosY; 
 public Single? PosZ; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPlayerPositionResetRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GGlobalControlData : IDataSerializer
        {
         public Byte? CashMoneyExchangeOpen; 
 public Int32? CashMoneyExchangeRate; 
 public Vector<Int32> ForbidCtrlList; 
 public Vector<Int32> ForbidItemList; 
 public Vector<Int32> ForbidServiceList; 
 public Vector<Int32> ForbidTaskList; 
 public Vector<Int32> ForbidSkillList; 
 public Vector<Int32> TriggerCtrlList; 
 public Byte? Reserved12; 
 public Byte? Reserved13; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 
 public Int32? Reserved6; 
 public Int32? Reserved7; 
 public Int32? Reserved8; 
 public Int32? Reserved9; 
 public Int32? Reserved10; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBLoadGlobalControlArg : IDataSerializer
        {
         public Int32? Nouse; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBLoadGlobalControlRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GGlobalControlData Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPutGlobalControlArg : IDataSerializer
        {
         public GGlobalControlData Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPutGlobalControlRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBUniqueDataLoadArg : IDataSerializer
        {
         public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBUniqueDataLoadRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<GUniqueDataElemNode> Values; 
 public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBUniqueDataSaveArg : IDataSerializer
        {
         public Vector<GUniqueDataElemNode> Values; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBUniqueDataSaveRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetUserRolesArg : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ClearStorehousePasswdArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets RoleName; 
 public Octets Reserved; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CanChangeRolenameArg : IDataSerializer
        {
         public Octets RoleName; 
 public Int32? SetCanChange; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CanChangeRolenameRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RenameRoleArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets OldName; 
 public Octets NewName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Uid2LogicuidArg : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Uid2LogicuidRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? LogicUId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Roleid2UidArg : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Roleid2UidRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RolenameExistsArg : IDataSerializer
        {
         public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RolenameExistsRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? ZoneId; 
 public Int32? RoleId; 
 public Int32? Status; 
 public Int32? Time; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserRoleCountArg : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserRoleCountRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? Count; 
 public UInt32? RoleList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MoveRoleCreateArg : IDataSerializer
        {
         public Int32? FromZoneId; 
 public Int32? ZoneId; 
 public Int32? UserID; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MoveRoleCreateRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeStartRqstArg : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? LocalSid; 
 public Int32? StartRoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TradeStartRqstRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBConfig : IDataSerializer
        {
         public UInt32? InitTime; 
 public UInt32? OpenTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBConfig2 : IDataSerializer
        {
         public UInt32? IsCentralDb; 
 public UInt32? Reserve; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMailID : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? MailId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMailDefRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMailHeader : IDataSerializer
        {
         public Byte? Id; 
 public Int32? Sender; 
 public Byte? SndrType; 
 public Int32? Receiver; 
 public Octets Title; 
 public Int32? SendTime; 
 public Byte? Attribute; 
 public Octets SenderName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMail : IDataSerializer
        {
         public GMailHeader Header; 
 public Octets Context; 
 public GRoleInventory AttachObj; 
 public UInt32? AttachMoney; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMailSyncData : IDataSerializer
        {
         public Int32? DataMask; 
 public Int32? CashTotal; 
 public UInt32? CashUsed; 
 public Int32? CashSerial; 
 public GRolePocket Inventory; 
 public GRoleStorehouse Storehouse; 
 public Vector<GRoleInventory> Equipment; 
 public Vector<GShopLog> Logs; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMailBox : IDataSerializer
        {
         public UInt32? Timestamp; 
 public UInt32? Status; 
 public Vector<GMail> Mails; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MailGoodsInventory : IDataSerializer
        {
         public Int32? GoodsId; 
 public Int32? Count; 
 public Int32? ProcType; 
 public Int32? GoodsFlag; 
 public Int32? GoodsPrice; 
 public Int32? GoodsPriceBeforeDiscount; 
 public Int32? PayType; 
 public Octets Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebOrderItemDetail : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? RoleId; 
 public Int32? GoodsId; 
 public Int32? Count; 
 public Int32? ProcType; 
 public Int32? GoodsFlag; 
 public Int32? GoodsPrice; 
 public Int32? GoodsPriceBeforeDiscount; 
 public Int32? GoodsPayType; 
 public UInt32? AttachMoney; 
 public Int32? Timestamp; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSysMail3Arg : IDataSerializer
        {
         public Int64? OrderId; 
 public Int32? UserID; 
 public Int64? RoleId; 
 public Octets RoleName; 
 public Int32? GoodsFlag; 
 public Int32? GoodsPrice; 
 public Int32? GoodsPriceBeforeDiscount; 
 public Int32? GoodsPayType; 
 public GMail Mail; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSysMail3Res : IDataSerializer
        {
         public Int32? RetCode; 
 public Byte? MailId; 
 public Int64? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGetMailListRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<GMailHeader> MailList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGetMailRes : IDataSerializer
        {
         public Byte? RetCode; 
 public GMail Mail; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGetMailAttachArg : IDataSerializer
        {
         public GMailID MailId; 
 public Byte? AttachType; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGetMailAttachRes : IDataSerializer
        {
         public Byte? RetCode; 
 public UInt32? MoneyLeft; 
 public UInt32? ItemLeft; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSetMailAttrArg : IDataSerializer
        {
         public GMailID MailId; 
 public Byte? AttribType; 
 public Byte? AttribValue; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSetMailAttrRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSendMailArg : IDataSerializer
        {
         public GMail Mail; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSendMailRes : IDataSerializer
        {
         public Byte? RetCode; 
 public Byte? MailId; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBDeleteMailArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets MailId; 
 public Byte? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSendMassMailArg : IDataSerializer
        {
         public Byte? MassType; 
 public GMail Mail; 
 public Int32? CostObjId; 
 public Int32? CostObjNum; 
 public Int32? CostObjPos; 
 public UInt32? CostMoney; 
 public Vector<Int32> ReceiverList; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class MassMailRes : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? MailId; 
 public Byte? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSendMassMailRes : IDataSerializer
        {
         public Byte? RetCode; 
 public Vector<MassMailRes> Result; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GWebTradeItem : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? SellerroleId; 
 public Int32? SellerUserId; 
 public Octets SellerName; 
 public Int32? PostType; 
 public UInt32? Money; 
 public UInt32? ItemId; 
 public Int32? ItemCount; 
 public Int32? State; 
 public Int32? PostEndTime; 
 public Int32? ShowEndTime; 
 public Int32? Price; 
 public Int32? SellEndTime; 
 public Int32? BuyerroleId; 
 public Int32? BuyerUserId; 
 public Octets BuyerName; 
 public Int32? CommodityId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GWebTradeRoleBriefExtend : IDataSerializer
        {
         public Octets MeridianData; 
 public Octets CardLeadership; 
 public Octets FateRingData; 
 public Octets TitleData; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 
 public Int32? Reserved6; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GWebTradeRoleBrief : IDataSerializer
        {
         public Int32? Cls; 
 public Byte? Gender; 
 public Int32? Level; 
 public Int32? Level2; 
 public Int32? Exp; 
 public Int32? Sp; 
 public Int32? Pp; 
 public Int32? Reputation; 
 public Octets Petcorral; 
 public Octets Property; 
 public Octets Skills; 
 public GRolePocket Inventory; 
 public GRoleEquipment Equipment; 
 public GRoleStorehouse Storehouse; 
 public Octets ForceData; 
 public Octets ReincarnationData; 
 public Octets RealmData; 
 public Octets ExtendData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GWebTradeDetail : IDataSerializer
        {
         public GWebTradeItem Info; 
 public GRoleInventory Item; 
 public Int64? PostTime; 
 public UInt32? Deposit; 
 public Int32? Loginip; 
 public Octets Rolebrief; 
 public Byte? Reserved10; 
 public Int16? Reserved11; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeLoadArg : IDataSerializer
        {
         public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeLoadRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int64? MaxSn; 
 public Vector<GWebTradeDetail> Items; 
 public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradePrePostArg : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? RoleId; 
 public Int32? UserID; 
 public Octets Name; 
 public Int32? PostType; 
 public UInt32? Money; 
 public UInt32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemNumber; 
 public Int32? Price; 
 public Int32? SellPeriod; 
 public Int32? BuyerroleId; 
 public Int64? PostTime; 
 public Int32? State; 
 public UInt32? Deposit; 
 public Int32? Loginip; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradePrePostRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? BuyerUserId; 
 public Octets BuyerName; 
 public Octets Name; 
 public Octets Rolebrief; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradePreCancelPostArg : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? RoleId; 
 public Int32? State; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradePreCancelPostRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradePostArg : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? RoleId; 
 public Int32? State; 
 public Int32? PostEndTime; 
 public Int32? ShowEndTime; 
 public Int32? SellEndTime; 
 public Int32? CommodityId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradePostRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeCancelPostArg : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? RoleId; 
 public Byte? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeCancelPostRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailHeader InformSeller; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeShelfArg : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? RoleId; 
 public Int32? State; 
 public Int32? ShowEndTime; 
 public Int32? Price; 
 public Int32? SellEndTime; 
 public Int32? BuyerroleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeShelfRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? BuyerUserId; 
 public Octets BuyerName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeCancelShelfArg : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? RoleId; 
 public Int32? State; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeCancelShelfRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeSoldArg : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? RoleId; 
 public Int32? BuyerroleId; 
 public Int32? BuyerUserId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeSoldRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailHeader InformSeller; 
 public GMailHeader InformBuyer; 
 public Int32? BuyerroleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradePostExpireArg : IDataSerializer
        {
         public Int64? Sn; 
 public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradePostExpireRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailHeader InformSeller; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleSimpleInfo : IDataSerializer
        {
         public Int64? RoleId; 
 public Int32? Level; 
 public Int32? Race; 
 public Int32? Gender; 
 public Octets Name; 
 public Int32? ReincarnationTimes; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeGetRoleSimpleInfoArg : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeGetRoleSimpleInfoRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<RoleSimpleInfo> Roles; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeLoadSoldArg : IDataSerializer
        {
         public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBWebTradeLoadSoldRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<Int64> SnList; 
 public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TraderInfo : IDataSerializer
        {
         public Int32? UserID; 
 public Int64? RoleId; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PostInfo : IDataSerializer
        {
         public Octets Detail; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TimeInfo : IDataSerializer
        {
         public Int64? ActionTime; 
 public Int32? ShowPeriod; 
 public Int32? SellPeriod; 
 public Int32? PostPeriod; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class WebRole : IDataSerializer
        {
         public Octets Info; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GSysAuctionItem : IDataSerializer
        {
         public UInt32? SaId; 
 public UInt32? ItemId; 
 public Int32? ItemCount; 
 public UInt32? BasePrice; 
 public Int32? State; 
 public Int32? AuctionStartTime; 
 public Int32? AuctionEndTime; 
 public UInt32? BidPrice; 
 public Int32? BidTime; 
 public Int32? BidFreezeTime; 
 public Int32? BidderRoleId; 
 public Int32? BidderUseRId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GSysAuctionDetail : IDataSerializer
        {
         public GSysAuctionItem Info; 
 public GRoleInventory Item; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GSysAuctionCash : IDataSerializer
        {
         public UInt32? Cash2; 
 public UInt32? CashUsed2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSysAuctionCashTransferArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? RoleId; 
 public Byte? WithDraw; 
 public UInt32? CashTransfer; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSysAuctionCashTransferRes : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? Cash; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSysAuctionCashSpendArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? RoleId; 
 public UInt32? CashSpend; 
 public UInt32? SaId; 
 public GRoleInventory Item; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBSysAuctionCashSpendRes : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? Cash; 
 public UInt32? CashUsed; 
 public GMailHeader InformBidder; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionPrepareItemArg : IDataSerializer
        {
         public Vector<Int32> Indexes; 
 public Vector<Int32> ItemIds; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SysAuctionPrepareItemRes : IDataSerializer
        {
         public Vector<Int32> Indexes; 
 public Vector<GRoleInventory> Items; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionFortressInfo : IDataSerializer
        {
         public Int32? Level; 
 public Int32? Exp; 
 public Int32? ExpToday; 
 public Int32? ExpTodayTime; 
 public Int32? TechPoint; 
 public Octets Technology; 
 public Octets Material; 
 public Octets Building; 
 public Octets CommonValue; 
 public Octets ActivedSpawner; 
 public Byte? Reserved11; 
 public Int16? Reserved12; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionFortressInfo2 : IDataSerializer
        {
         public Int32? Health; 
 public Int32? OffenseFaction; 
 public Int32? OffenseStartTime; 
 public Int32? OffenseEndTime; 
 public Vector<Int32> ChallengeList; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionFortressDetail : IDataSerializer
        {
         public Int32? FactionId; 
 public GFactionFortressInfo Info; 
 public GFactionFortressInfo2 Info2; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionFortressBriefInfo : IDataSerializer
        {
         public Int32? FactionId; 
 public Int32? Level; 
 public Octets Building; 
 public Int32? Health; 
 public Int32? OffenseFaction; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionFortressBattleInfo : IDataSerializer
        {
         public Int32? FactionId; 
 public Int32? OffenseFaction; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionFortressLoadArg : IDataSerializer
        {
         public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionFortressLoadRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<GFactionFortressDetail> List; 
 public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPutFactionFortressArg : IDataSerializer
        {
         public GFactionFortressDetail Detail; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPutFactionFortressRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBDelFactionFortressArg : IDataSerializer
        {
         public Int32? FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBDelFactionFortressRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetFactionFortressArg : IDataSerializer
        {
         public Int32? FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetFactionFortressRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GFactionFortressDetail Detail; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PutFactionFortressArg : IDataSerializer
        {
         public Int32? FactionId; 
 public GFactionFortressInfo Info; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PutFactionFortressRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBCreateFactionFortressArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets ItemCost; 
 public GFactionFortressDetail Detail; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBCreateFactionFortressRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionFortressChallengeArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? FactionId; 
 public Int32? TargetFactionId; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionFortressChallengeRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AuctionId : IDataSerializer
        {
         public UInt32? Id; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GAuctionItem : IDataSerializer
        {
         public UInt32? AuctionId; 
 public UInt32? BidPrice; 
 public UInt32? BinPrice; 
 public UInt32? EndTime; 
 public UInt32? ItemId; 
 public UInt16? Count; 
 public UInt32? Seller; 
 public UInt32? Bidder; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GAuctionDetail : IDataSerializer
        {
         public GAuctionItem Info; 
 public UInt16? Category; 
 public UInt32? BasePrice; 
 public UInt32? Deposit; 
 public Int32? ElapseTime; 
 public Int32? Prolong; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public GRoleInventory Item; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionOpenArg : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? AuctionId; 
 public UInt16? Category; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemNumber; 
 public UInt32? BasePrice; 
 public UInt32? BinPrice; 
 public Int32? ElapseTime; 
 public Int32? EndTime; 
 public UInt32? Deposit; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionOpenRes : IDataSerializer
        {
         public Byte? RetCode; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionBidArg : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? AuctionId; 
 public UInt32? BidPrice; 
 public Byte? Bin; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionBidRes : IDataSerializer
        {
         public Byte? RetCode; 
 public UInt32? BidPrice; 
 public GMailHeader InformSeller; 
 public GMailHeader InformLoser; 
 public GMailHeader InformWinner; 
 public Int32? ExtendTime; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GAuctionList : IDataSerializer
        {
         public UInt16? Category; 
 public Vector<GAuctionDetail> List; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GAuctionIndex : IDataSerializer
        {
         public Octets Category; 
 public Int32? Index; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionListArg : IDataSerializer
        {
         public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionListRes : IDataSerializer
        {
         public Int16? RetCode; 
 public Vector<GAuctionDetail> Items; 
 public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionGetArg : IDataSerializer
        {
         public UInt32? AuctionId; 
 public Byte? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionGetRes : IDataSerializer
        {
         public Byte? RetCode; 
 public GAuctionDetail Item; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionTimeoutRes : IDataSerializer
        {
         public Byte? RetCode; 
 public UInt32? AuctionId; 
 public GMailHeader InformSeller; 
 public GMailHeader InformBidder; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionCloseArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? Reason; 
 public UInt32? AuctionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAuctionCloseRes : IDataSerializer
        {
         public Byte? RetCode; 
 public GMailHeader InformSeller; 
 public GMailHeader InformBidder; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GChallengerInfoList : IDataSerializer
        {
         public Vector<GChallengerInfo> ChallengerList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GChallengerInfo : IDataSerializer
        {
         public UInt32? Faction; 
 public Int32? Time; 
 public UInt32? Deposit; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GTerritoryDetail : IDataSerializer
        {
         public Int16? Id; 
 public Int16? Level; 
 public UInt32? Owner; 
 public Int32? OccupyTime; 
 public UInt32? Challenger; 
 public UInt32? Deposit; 
 public Int32? CutffTime; 
 public Int32? BattleTime; 
 public Int32? BonusTime; 
 public Int32? Color; 
 public Int32? Status; 
 public Int32? Timeout; 
 public Int32? Maxbonus; 
 public Int32? ChallengeTime; 
 public Octets Challengerdetails; 
 public Byte? Reserved1; 
 public Byte? Reserved2; 
 public Byte? Reserved3; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GTerritoryStore : IDataSerializer
        {
         public Vector<GTerritoryDetail> Cities; 
 public Int32? Status; 
 public Int32? SpecialTime; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GTerritory : IDataSerializer
        {
         public Byte? Id; 
 public Byte? Level; 
 public Byte? Color; 
 public UInt32? Owner; 
 public UInt32? Challenger; 
 public UInt32? BattleTime; 
 public Int32? Deposit; 
 public Int32? Maxbonus; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GCity : IDataSerializer
        {
         public Byte? Id; 
 public Byte? Level; 
 public UInt32? Owner; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GBattleChallenge : IDataSerializer
        {
         public Int16? Id; 
 public UInt32? Challenger; 
 public UInt32? Deposit; 
 public UInt32? Maxbonus; 
 public UInt32? CutffTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleEndArg : IDataSerializer
        {
         public Int32? BattleId; 
 public Int32? Result; 
 public UInt32? Defender; 
 public UInt32? Attacker; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class BattleEndRes : IDataSerializer
        {
         public Int16? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleLoadArg : IDataSerializer
        {
         public Int32? Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleLoadRes : IDataSerializer
        {
         public Int16? RetCode; 
 public Vector<GTerritoryDetail> Cities; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleSetArg : IDataSerializer
        {
         public Int16? Reason; 
 public Vector<GTerritoryDetail> Cities; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleSetRes : IDataSerializer
        {
         public Int16? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleChallengeArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int16? CityId; 
 public Int32? FactionId; 
 public UInt32? Deposit; 
 public UInt32? Maxbonus; 
 public Int32? ChallengeTime; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleChallengeRes : IDataSerializer
        {
         public Int16? RetCode; 
 public Int32? ChallengeRes; 
 public UInt32? Deposit; 
 public GMailHeader InformLoser; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleEndArg : IDataSerializer
        {
         public Int32? BattleId; 
 public Int32? Result; 
 public Int32? Color; 
 public UInt32? Defender; 
 public UInt32? Attacker; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleEndRes : IDataSerializer
        {
         public Int16? RetCode; 
 public GMailHeader InformWinner; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleMailArg : IDataSerializer
        {
         public UInt32? FactionId; 
 public GMail Mail; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleMailRes : IDataSerializer
        {
         public Byte? RetCode; 
 public UInt32? RoleId; 
 public Byte? MailId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleBonusArg : IDataSerializer
        {
         public UInt32? FactionId; 
 public Int16? CityId; 
 public UInt32? Money; 
 public GRoleInventory Item; 
 public Int16? Isspecialbonus; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBBattleBonusRes : IDataSerializer
        {
         public Int16? RetCode; 
 public GMailHeader InformMaster; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopItem : IDataSerializer
        {
         public GRoleInventory Item; 
 public UInt32? Price; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopBase : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ShopType; 
 public Vector<PShopItem> BList; 
 public Vector<PShopItem> SList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopDetail : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ShopType; 
 public Int32? Status; 
 public Int32? CreateTime; 
 public Int32? ExpireTime; 
 public UInt32? Money; 
 public Vector<GRoleInventory> Yinpiao; 
 public Vector<PShopItem> BList; 
 public Vector<PShopItem> SList; 
 public Vector<GRoleInventory> Store; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopEntry : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ShopType; 
 public Int32? CreateTime; 
 public Int32? Invstate; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PShopItemEntry : IDataSerializer
        {
         public Int32? RoleId; 
 public PShopItem Item; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopCreateArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ShopType; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemNumber; 
 public Int32? CreateTime; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopCreateRes : IDataSerializer
        {
         public Int32? RetCode; 
 public PShopDetail Shop; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopBuyArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public UInt32? ItemPrice; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopBuyRes : IDataSerializer
        {
         public Int32? RetCode; 
 public PShopItem ItemBuy; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopSellArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public UInt32? ItemPrice; 
 public Int32? InvPos; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopSellRes : IDataSerializer
        {
         public Int32? RetCode; 
 public PShopItem ItemSell; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopCancelGoodsArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? CancelType; 
 public Int32? ItemPos; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopCancelGoodsRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRoleInventory ItemStore; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopPlayerBuyArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Master; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public Int64? MoneyCost; 
 public Int32? YpCost; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopPlayerBuyRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailSyncData SyncData; 
 public UInt32? Money; 
 public Vector<GRoleInventory> Yinpiao; 
 public PShopItem ItemChange; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopPlayerSellArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Master; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemCount; 
 public Int32? InvPos; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopPlayerSellRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailSyncData SyncData; 
 public UInt32? Money; 
 public Vector<GRoleInventory> Yinpiao; 
 public PShopItem ItemBuyChange; 
 public GRoleInventory ItemStoreChange; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopSetTypeArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? NewType; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopSetTypeRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopActiveArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemNumber; 
 public Int32? Timestamp; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopActiveRes : IDataSerializer
        {
         public Int32? RetCode; 
 public PShopDetail Detail; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopManageFundArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? OpType; 
 public UInt32? Money; 
 public UInt32? Yinpiao; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopManageFundRes : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? Money; 
 public Vector<GRoleInventory> Yinpiao; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopDrawItemArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? ItemPos; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopDrawItemRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopLoadArg : IDataSerializer
        {
         public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopLoadRes : IDataSerializer
        {
         public Int16? RetCode; 
 public Vector<PShopDetail> Shops; 
 public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopGetArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopGetRes : IDataSerializer
        {
         public Int32? RetCode; 
 public PShopDetail Shop; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopClearGoodsArg : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopClearGoodsRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<PShopItem> SList; 
 public Vector<GRoleInventory> Store; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopTimeoutArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Boolean? DelFlag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPShopTimeoutRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Vector<GMailHeader> MailList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerProfileData : IDataSerializer
        {
         public UInt16? GameTimeMask; 
 public UInt16? GameInterestMask; 
 public UInt16? PersonalInterestMask; 
 public Byte? Age; 
 public Byte? Zodiac; 
 public UInt16? MatchOptionMask; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ProfileMatchResult : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Level; 
 public Int32? Occupation; 
 public Byte? Gender; 
 public Single? Similarity; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGetPlayerProfileDataArg : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGetPlayerProfileDataRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Byte? Gender; 
 public PlayerProfileData Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPutPlayerProfileDataArg : IDataSerializer
        {
         public Int32? RoleId; 
 public PlayerProfileData Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPutPlayerProfileDataRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CrossPlayerData : IDataSerializer
        {
         public GRoleBase Base; 
 public GRoleStatus Status; 
 public GRolePocket Inventory; 
 public GRoleEquipment Equipment; 
 public GRoleStorehouse Storehouse; 
 public GRoleTask Task; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FetchPlayerDataArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 
 public Boolean? Flag; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FetchPlayerDataRes : IDataSerializer
        {
         public Int32? RetCode; 
 public CrossPlayerData Data; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ActivatePlayerDataArg : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ActivatePlayerDataRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TouchPlayerDataArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TouchPlayerDataRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DelPlayerDataArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DelPlayerDataRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FreezePlayerDataArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? RemoteRoleId; 
 public Int32? UserID; 
 public Int32? RemoteZoneId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FreezePlayerDataRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerIdentityMatchArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 
 public Int32? Ip; 
 public Int32? SrcZoneId; 
 public Octets Random; 
 public Boolean? Flag; 
 public UInt32? LocalSid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PlayerIdentityMatchRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets ISeckey; 
 public Octets OSeckey; 
 public Octets Account; 
 public User User; 
 public GRoleInfo RoleInfo; 
 public Int32? ZoneId; 
 public Int32? DistrictId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SavePlayerDataArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? RemoteRoleId; 
 public Int32? UserID; 
 public Int32? SrcZoneId; 
 public CrossPlayerData Data; 
 public Boolean? Flag; 
 public Int32? DataTimestamp; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SavePlayerDataRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? NewRoleId; 
 public GRoleInfo RoleInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CrossInfoData : IDataSerializer
        {
         public Int32? RemoteRoleId; 
 public Int32? DataTimestamp; 
 public Int32? CrossTimestamp; 
 public Int32? SrcZoneId; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBUpdatePlayerCrossInfoArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? RemoteRoleId; 
 public Int32? UserID; 
 public Int32? RemoteZoneId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBUpdatePlayerCrossInfoRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockOrder : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? Time; 
 public Int32? UserID; 
 public Int32? Price; 
 public Int32? Volume; 
 public Boolean? Status; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class StockPrice : IDataSerializer
        {
         public Int32? Price; 
 public Int32? Volume; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBStockBalanceArg : IDataSerializer
        {
         public UInt32? TId; 
 public Int32? UserID; 
 public Int32? AckVolume; 
 public Int32? AckMoney; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBStockBalanceRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? VolumeLeft; 
 public Int32? Cash; 
 public Int32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBStockCommissionArg : IDataSerializer
        {
         public StockOrder Order; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBStockCommissionRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBStockCancelArg : IDataSerializer
        {
         public Int32? UserID; 
 public UInt32? TId; 
 public Int32? Volume; 
 public Int16? Result; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBStockCancelRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? Cash; 
 public Int32? Money; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBStockTransactionArg : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? RoleId; 
 public Byte? WithDraw; 
 public Int32? Cash; 
 public Int32? Money; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBStockTransactionRes : IDataSerializer
        {
         public Int16? RetCode; 
 public Int32? Cash; 
 public Int32? Money; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBStockLoadArg : IDataSerializer
        {
         public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBStockLoadRes : IDataSerializer
        {
         public Int16? RetCode; 
 public Vector<StockOrder> Orders; 
 public Octets Handle; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GMember : IDataSerializer
        {
         public UInt32? RId; 
 public Byte? Role; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GItem : IDataSerializer
        {
         public UInt32? Id; 
 public UInt32? Count; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionLog : IDataSerializer
        {
         public UInt32? RId; 
 public Octets Name; 
 public Byte? Action; 
 public Vector<GItem> Items; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionStorehouse : IDataSerializer
        {
         public Int64? Money; 
 public Vector<GRoleInventory> Items; 
 public Vector<GFactionLog> Log; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionInfo : IDataSerializer
        {
         public UInt32? FId; 
 public Octets Name; 
 public Byte? Level; 
 public GMember Master; 
 public Vector<GMember> Member; 
 public Octets Announce; 
 public Octets SysInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionBaseInfo : IDataSerializer
        {
         public UInt32? FId; 
 public Octets Name; 
 public Byte? Level; 
 public Int16? MemNum; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionExtend : IDataSerializer
        {
         public Int32? JoinTime; 
 public Int32? Loyalty; 
 public Int32? LoginTime; 
 public Int32? Reserved1; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GUserFaction : IDataSerializer
        {
         public UInt32? RId; 
 public Octets Name; 
 public UInt32? FId; 
 public Byte? Cls; 
 public Byte? Role; 
 public Octets Delayexpel; 
 public Octets Extend; 
 public Octets NickName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionAlliance : IDataSerializer
        {
         public Int32? FId; 
 public Int32? EndTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionHostile : IDataSerializer
        {
         public Int32? FId; 
 public Int32? EndTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionRelationApply : IDataSerializer
        {
         public Int32? Type; 
 public Int32? FId; 
 public Int32? EndTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionRelation : IDataSerializer
        {
         public Int32? FId; 
 public Int32? LastOpTime; 
 public Vector<GFactionAlliance> Alliance; 
 public Vector<GFactionHostile> Hostile; 
 public Vector<GFactionRelationApply> Apply; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionId : IDataSerializer
        {
         public UInt32? FId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddFactionArg : IDataSerializer
        {
         public Octets Name; 
 public UInt32? RId; 
 public UInt32? FId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddFactionRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddMemberArg : IDataSerializer
        {
         public UInt32? FId; 
 public UInt32? RId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddMemberRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets Name; 
 public Byte? Cls; 
 public Int32? Level; 
 public Int32? Reputation; 
 public Byte? ReincarnTimes; 
 public Byte? Gender; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DelMemberArg : IDataSerializer
        {
         public UInt32? FId; 
 public UInt32? RId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DelMemberScheduleArg : IDataSerializer
        {
         public UInt32? FId; 
 public UInt32? RId; 
 public Byte? Operation; 
 public Int32? Time; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UpdateUserFactionArg : IDataSerializer
        {
         public UInt32? FId; 
 public UInt32? RId; 
 public Byte? Operation; 
 public Byte? Role; 
 public Int16? Loyalty; 
 public Octets NickName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UpdateFactionArg : IDataSerializer
        {
         public UInt32? FId; 
 public Byte? Type; 
 public Byte? Level; 
 public Octets Announce; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DefFactionRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionUpgradeArg : IDataSerializer
        {
         public UInt32? FId; 
 public Int32? RoleId; 
 public UInt32? Money; 
 public Byte? Level; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionUpgradeRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Int32? Master; 
 public UInt32? Money; 
 public Byte? Level; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionPromoteArg : IDataSerializer
        {
         public UInt32? FId; 
 public UInt32? Superior; 
 public UInt32? RoleId; 
 public Byte? Suprole; 
 public Byte? Newrole; 
 public Int32? Max; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionPromoteRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Byte? Suprole; 
 public Byte? Newrole; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionInfoRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GFactionInfo Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserFactionArg : IDataSerializer
        {
         public Int32? Reason; 
 public UInt32? RId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class UserFactionRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GUserFaction Value; 
 public Int32? Level; 
 public Int32? Contrib; 
 public Int32? Reputation; 
 public Byte? ReincarnTimes; 
 public Byte? Gender; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFactionDetail : IDataSerializer
        {
         public UInt32? FId; 
 public Octets Name; 
 public Byte? Level; 
 public UInt32? Master; 
 public Octets Announce; 
 public Octets SysInfo; 
 public Vector<FMemberInfo> Member; 
 public Int32? LastOpTime; 
 public Vector<GFactionAlliance> Alliance; 
 public Vector<GFactionHostile> Hostile; 
 public Vector<GFactionRelationApply> Apply; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionDetailRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GFactionDetail Value; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DelFactionRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets FName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBVerifyMasterArg : IDataSerializer
        {
         public Octets Name; 
 public Octets Faction; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionAllianceApplyArg : IDataSerializer
        {
         public Int32? FId; 
 public Int32? DstFId; 
 public Int32? EndTime; 
 public Int32? OpTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionAllianceReplyArg : IDataSerializer
        {
         public Int32? FId; 
 public Int32? DstFId; 
 public Byte? Agree; 
 public Int32? EndTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionHostileApplyArg : IDataSerializer
        {
         public Int32? FId; 
 public Int32? DstFId; 
 public Int32? EndTime; 
 public Int32? OpTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionHostileReplyArg : IDataSerializer
        {
         public Int32? FId; 
 public Int32? DstFId; 
 public Byte? Agree; 
 public Int32? EndTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionRemoveRelationApplyArg : IDataSerializer
        {
         public Int32? FId; 
 public Int32? DstFId; 
 public Byte? Force; 
 public Int32? EndTime; 
 public Int32? OpTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionRemoveRelationReplyArg : IDataSerializer
        {
         public Int32? FId; 
 public Int32? DstFId; 
 public Byte? Agree; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionRelationTimeoutArg : IDataSerializer
        {
         public Int32? Type; 
 public Int32? FId1; 
 public Int32? FId2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionRelationApplyTimeoutArg : IDataSerializer
        {
         public Int32? Type; 
 public Int32? FId1; 
 public Int32? FId2; 
 public Int32? EndTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionRelationRetcode : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets FName1; 
 public Octets FName2; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FMemberInfo : IDataSerializer
        {
         public UInt32? RoleId; 
 public Byte? Level; 
 public Byte? Occupation; 
 public Byte? FRoleId; 
 public UInt16? Loginday; 
 public Byte? OnlineStatus; 
 public Octets Name; 
 public Octets NickName; 
 public Int32? Contrib; 
 public Byte? Delayexpel; 
 public Int32? ExpelTime; 
 public Int32? Reputation; 
 public Byte? ReincarnTimes; 
 public Byte? Gender; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GForceGlobalDataList : IDataSerializer
        {
         public Vector<GForceGlobalData> List; 
 public Int32? UpdateTime; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 
 public Int32? Reserved6; 
 public Int32? Reserved7; 
 public Int32? Reserved8; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GForceGlobalData : IDataSerializer
        {
         public Int32? ForceId; 
 public Int32? PlayerCount; 
 public Int32? Development; 
 public Int32? Construction; 
 public Int32? Activity; 
 public Int32? ActivityLevel; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 
 public Int32? Reserved6; 
 public Int32? Reserved7; 
 public Int32? Reserved8; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GForceGlobalDataBrief : IDataSerializer
        {
         public Int32? ForceId; 
 public Int32? PlayerCount; 
 public Int32? Development; 
 public Int32? Construction; 
 public Int32? Activity; 
 public Int32? ActivityLevel; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBForceLoadArg : IDataSerializer
        {
         public Int32? Nouse; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBForceLoadRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GForceGlobalDataList List; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPutForceArg : IDataSerializer
        {
         public GForceGlobalDataList List; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPutForceRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CountryBattleApplyEntry : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? MajorStrength; 
 public Int32? MinorStrength; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GCountryCapital : IDataSerializer
        {
         public Int32? CountryId; 
 public Int32? Worldtag; 
 public Single? PosX; 
 public Single? PosY; 
 public Single? PosZ; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GCountryBattlePersonalScore : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Cls; 
 public Int32? MinorStr; 
 public Int32? CombatTime; 
 public Int32? AttendTime; 
 public Int32? KillCount; 
 public Int32? DeathCount; 
 public Int32? ContributeVal; 
 public Int32? Damage; 
 public Int32? Hurt; 
 public Int32? DamageMinorStr; 
 public Int32? KillMinorStr; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GCountryBattleDomain : IDataSerializer
        {
         public Int32? Id; 
 public Byte? Owner; 
 public Byte? Challenger; 
 public Boolean? Status; 
 public Byte? BattleConfigMask; 
 public Int32? Time; 
 public Vector<Int32> CountryPlayercnt; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBCountryBattleBonusArg : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? Money; 
 public GRoleInventory Item; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBCountryBattleBonusRes : IDataSerializer
        {
         public Int16? RetCode; 
 public GMailHeader InformPlayer; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GCountryBattleLimit : IDataSerializer
        {
         public Byte? OccupationCntCeil; 
 public Int32? MinorStrFloor; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class PFactionInfo : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? FactionId; 
 public Byte? Factionrole; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionOPSyncInfo : IDataSerializer
        {
         public UInt32? PlayerMoney; 
 public Int32? PlayerSp; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionOPAddInfo : IDataSerializer
        {
         public Int32? RetCode; 
 public UInt32? FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceFactionRoleDelArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Byte? ZoneId; 
 public UInt32? Faction; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AnnounceFactionRoleDelRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionInviteArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? InvitedRoleId; 
 public UInt32? FactionId; 
 public Octets FactionName; 
 public Octets RoleName; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionInviteRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KEKing : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? EndTime; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KECandidate : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? SerialNum; 
 public Int32? Deposit; 
 public Int32? Votes; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class KingElectionDetail : IDataSerializer
        {
         public KEKing King; 
 public Vector<KECandidate> CandidateList; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKELoadArg : IDataSerializer
        {
         public Int32? Nouse; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKELoadRes : IDataSerializer
        {
         public Int32? RetCode; 
 public KingElectionDetail Detail; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKECandidateApplyArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? SerialNum; 
 public UInt32? ItemId; 
 public Int32? ItemNumber; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKECandidateApplyRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKECandidateConfirmArg : IDataSerializer
        {
         public Vector<Int32> CandidateList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKECandidateConfirmRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKEVotingArg : IDataSerializer
        {
         public Int32? RoleId; 
 public UInt32? ItemId; 
 public Int32? ItemPos; 
 public Int32? ItemNumber; 
 public Int32? CandidateRoleId; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKEVotingRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GMailSyncData SyncData; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKEKingConfirmArg : IDataSerializer
        {
         public KEKing King; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKEKingConfirmRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKEDeleteKingArg : IDataSerializer
        {
         public Int32? KingRoleId; 
 public Int32? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKEDeleteKingRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKEDeleteCandidateArg : IDataSerializer
        {
         public Vector<Int32> CandidateList; 
 public Int32? Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBKEDeleteCandidateRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TankBattlePlayerScoreInfo : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? KillCount; 
 public Int32? DeadCount; 
 public Int32? Score; 
 public Int32? Rank; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBTankBattleBonusArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Rank; 
 public UInt32? Money; 
 public GRoleInventory Item; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBTankBattleBonusRes : IDataSerializer
        {
         public Int16? RetCode; 
 public GMailHeader InformPlayer; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GGroupInfo : IDataSerializer
        {
         public Byte? GId; 
 public Octets Name; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFriendInfo : IDataSerializer
        {
         public Int32? RId; 
 public Byte? Cls; 
 public Byte? GId; 
 public Octets Name; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFriendList : IDataSerializer
        {
         public Vector<GGroupInfo> Groups; 
 public Vector<GFriendInfo> Friends; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FriendListPair : IDataSerializer
        {
         public RoleId Key; 
 public GFriendList Value; 
 public Vector<GFriendExtInfo> ExtraInfo; 
 public Vector<GSendAUMailRecord> SendMailInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FriendListRes : IDataSerializer
        {
         public Byte? RetCode; 
 public GFriendList Value; 
 public Vector<GFriendExtInfo> ExtraInfo; 
 public Vector<GSendAUMailRecord> SendMailInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GSendAUMailRecord : IDataSerializer
        {
         public Int32? RId; 
 public Int32? SendMailTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFriendExtInfo : IDataSerializer
        {
         public Int32? UId; 
 public Int32? RId; 
 public Int32? Level; 
 public Int32? LastloginTime; 
 public Int32? UpdateTime; 
 public Byte? ReincarnationTimes; 
 public Byte? Reserved0; 
 public Int16? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GFriendExtra : IDataSerializer
        {
         public Vector<GFriendExtInfo> FriendExtInfo; 
 public Vector<GSendAUMailRecord> SendaumailInfo; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddFriendRqstArg : IDataSerializer
        {
         public Int32? SrcroleId; 
 public Octets SrcName; 
 public UInt32? DstlSId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class AddFriendRqstRes : IDataSerializer
        {
         public Byte? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class Message : IDataSerializer
        {
         public Byte? Channel; 
 public Octets SrcName; 
 public Int32? SrcroleId; 
 public Octets DstName; 
 public Int32? DstroleId; 
 public Octets Text; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GetMessageRes : IDataSerializer
        {
         public Byte? RetCode; 
 public Vector<Message> Messages; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GChatMember : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets Name; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRoomDetail : IDataSerializer
        {
         public UInt16? RoomId; 
 public Octets Subject; 
 public Octets Owner; 
 public UInt16? Capacity; 
 public Boolean? Status; 
 public Vector<GChatMember> Members; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GChatRoom : IDataSerializer
        {
         public UInt16? RoomId; 
 public Octets Subject; 
 public Octets Owner; 
 public UInt16? Capacity; 
 public UInt16? Number; 
 public Boolean? Status; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRefStore : IDataSerializer
        {
         public Int32? BonusAdd; 
 public Int32? BonusUsed; 
 public Int32? Referrer; 
 public Int32? ReferrerRoleId; 
 public Int32? BonusTotal1; 
 public Int32? BonusTotal2; 
 public Int32? BonusWithdraw; 
 public Int32? BonusWithdrawToday; 
 public Int32? MaxRoleLevel; 
 public Vector<Octets> Rolenames; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 
 public Int32? Reserved5; 
 public Int32? Reserved6; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GReferrer : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? BonusAdd; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GReferral : IDataSerializer
        {
         public Int32? UserID; 
 public Int32? BonusTotal1; 
 public Int32? BonusTotal2; 
 public Int32? BonusWithdraw; 
 public Int32? BonusWithdrawToday; 
 public Int32? MaxRoleLevel; 
 public Vector<Octets> Rolenames; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ReferralBrief : IDataSerializer
        {
         public Vector<Octets> Rolenames; 
 public Int32? MaxLevel; 
 public Int32? BonusTotal1; 
 public Int32? BonusTotal2; 
 public Int32? BonusLeft; 
 public Int32? BonusAvail; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRefWithdrawTransArg : IDataSerializer
        {
         public Int32? RoleId; 
 public GReferrer Referrer; 
 public Vector<GReferral> Referrals; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRefGetReferralRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GReferral Referral; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRefGetReferrerRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GReferrer Referrer; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRefUpdateReferralArg : IDataSerializer
        {
         public GReferral Referral; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRefUpdateReferrerArg : IDataSerializer
        {
         public GReferrer Referrer; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRewardItem : IDataSerializer
        {
         public Int32? RewardTime; 
 public Int32? RewardBonus; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GRewardStore : IDataSerializer
        {
         public Int32? ConsumePoints; 
 public Int32? BonusReward; 
 public Vector<GRewardItem> RewardList; 
 public Int32? Reserved1; 
 public Int32? Reserved2; 
 public Int32? Reserved3; 
 public Int32? Reserved4; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RewardItem : IDataSerializer
        {
         public Int32? RewardTime; 
 public Int32? RewardBonus; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGetRewardArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGetRewardRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRewardStore Reward; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPutConsumePointsArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 
 public Int32? ConsumePoints; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBPutRewardBonusArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 
 public Int32? BonusReward; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRewardMatureArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 
 public Int32? BonusReward; 
 public Vector<GRewardItem> RewardList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRewardMatureRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBExchangeConsumePointsArg : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 
 public Int32? ConsumePoints; 
 public Vector<GRewardItem> RewardList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBExchangeConsumePointsRes : IDataSerializer
        {
         public Int32? RetCode; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACQ : IDataSerializer
        {
         public Int32? QueryType; 
 public Int32? ZoneId; 
 public Int32? RoleId; 
 public Int32? XId; 
 public Int32? Timeout; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class IntData : IDataSerializer
        {
         public Int32? IntValue; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class OctetsData : IDataSerializer
        {
         public Octets OctetsValue; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACLogInfo : IDataSerializer
        {
         public Int32? Type; 
 public Int32? SubId; 
 public Int32? LogTime; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACCodeRes : IDataSerializer
        {
         public Int16? CodeId; 
 public Int32? Res; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACUserCodeRes : IDataSerializer
        {
         public Int16? Count; 
 public Int16? Type; 
 public Vector<ACCodeRes> Res; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACStackPattern : IDataSerializer
        {
         public Int32? Caller; 
 public Int32? Size; 
 public Int32? Pattern; 
 public Int32? Count; 
 public Int32? CountHd; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACPlatformInfo : IDataSerializer
        {
         public Int32? Id; 
 public Int32? MajorVersion; 
 public Int32? MinorVersion; 
 public Int32? BuildNumber; 
 public Int32? Count; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACCPUInfo : IDataSerializer
        {
         public Int16? Arch; 
 public Int16? Level; 
 public Int32? Ct; 
 public Int32? Count; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACMemInfo : IDataSerializer
        {
         public Int32? Ct; 
 public Int32? Count; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACAdapterInfo : IDataSerializer
        {
         public Octets Des; 
 public Int32? Count; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACMouseInfo : IDataSerializer
        {
         public Int32? LButtonFreq; 
 public Int32? RButtonFreq; 
 public Int32? MouseMovefreq; 
 public Single? MouseMovevelo; 
 public Vector<IntData> GCounts; 
 public Vector<IntData> GTimes; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACThreadTime : IDataSerializer
        {
         public Int32? ThreadId; 
 public Int32? AllSecs; 
 public Int32? KernelSecs; 
 public Int32? UserSecs; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACProtocolStat : IDataSerializer
        {
         public Int32? Keepalive; 
 public Int32? GameDataSend; 
 public Int32? Acreport; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACOnlineStatus : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? Ip; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ACOnlineStatus2 : IDataSerializer
        {
         public Int32? RoleId; 
 public Int32? UserID; 
 public Int32? Ip; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ForbidUserArg : IDataSerializer
        {
         public Byte? Operation; 
 public Int32? GmUserId; 
 public Int32? Source; 
 public Int32? UserID; 
 public Int32? Time; 
 public Octets Reason; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class ForbidUserRes : IDataSerializer
        {
         public Int32? RetCode; 
 public GRoleForbid Forbid; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBAutolockSetArg : IDataSerializer
        {
         public Int32? UserID; 
 public Vector<GPair> AutoLock; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleImportBean : IDataSerializer
        {
         public Int64? UId; 
 public Int64? RoleId; 
 public Octets RoleName; 
 public Byte? Gender; 
 public Int32? Race; 
 public Int32? Occupation; 
 public Int32? Level; 
 public Octets ExtInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class GroupBean : IDataSerializer
        {
         public Int32? GType; 
 public Int64? GroupId; 
 public Octets GroupName; 
 public Vector<Int64> FriendList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FriendImportBean : IDataSerializer
        {
         public Int32? ZoneId; 
 public Int64? RoleId; 
 public Vector<GroupBean> Friends; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TitleBean : IDataSerializer
        {
         public Int32? TitleId; 
 public Octets TitleName; 
 public Vector<Int64> Members; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionImportBean : IDataSerializer
        {
         public Int32? FType; 
 public Int64? FactionId; 
 public Octets FactionName; 
 public Octets Announcement; 
 public Octets ExtInfo; 
 public Vector<TitleBean> Members; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleInfoBean : IDataSerializer
        {
         public Int64? RoleId; 
 public Octets RoleName; 
 public Byte? Gender; 
 public Int32? Race; 
 public Int32? Occupation; 
 public Int32? Level; 
 public Octets ExtInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleStatusBean : IDataSerializer
        {
         public Boolean? Status; 
 public Octets ExtInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleBean : IDataSerializer
        {
         public RoleInfoBean Info; 
 public RoleStatusBean Status; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleGroupBean : IDataSerializer
        {
         public Int32? GType; 
 public Int64? GroupId; 
 public Octets GroupName; 
 public Vector<RoleBean> Friends; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class RoleMsgBean : IDataSerializer
        {
         public Int64? Sender; 
 public Octets SenderName; 
 public Int64? Time; 
 public Int32? EmotionGroup; 
 public Octets Content; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionIDBean : IDataSerializer
        {
         public Int32? FType; 
 public Int64? FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionInfoBean : IDataSerializer
        {
         public Octets FactionName; 
 public Octets Announcement; 
 public Octets ExtInfo; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionTitleBean : IDataSerializer
        {
         public Int32? TitleId; 
 public Octets TitleName; 
 public Vector<RoleBean> Titlemembers; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class FactionExt : IDataSerializer
        {
         public Int32? Level; 
 public Int32? Exp; 
 public Int32? FortressLvl; 
 public Int32? Health; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class CityWar : IDataSerializer
        {
         public Vector<GCity> CityList; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class TeamBean : IDataSerializer
        {
         public Int64? TeamId; 
 public Int64? Captain; 
 public Vector<Int64> Members; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGameTalkRoleListArg : IDataSerializer
        {
         public Int32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGameTalkRoleRelationArg : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRoleBase : IDataSerializer
        {
         public Int32? RoleId; 
 public Octets Name; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBRoleGroup : IDataSerializer
        {
         public Int32? GType; 
 public Byte? Id; 
 public Octets Name; 
 public Vector<DBRoleBase> Friends; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGameTalkRoleRelationRes : IDataSerializer
        {
         public Int32? RetCode; 
 public RoleBean Info; 
 public Vector<FactionIDBean> Factions; 
 public Vector<DBRoleGroup> Groups; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGameTalkFactionInfoArg : IDataSerializer
        {
         public UInt32? FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBFactionMember : IDataSerializer
        {
         public DBRoleBase Info; 
 public Int32? Title; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGameTalkFactionInfoRes : IDataSerializer
        {
         public Int32? RetCode; 
 public Octets Name; 
 public Octets Announce; 
 public Octets ExInfo; 
 public Vector<DBFactionMember> Members; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGameTalkRoleStatusArg : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGameTalkRoleStatusRes : IDataSerializer
        {
         public Int32? Status; 
 public Int64? ForbidTime; 
 public UInt32? UserID; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGameTalkRoleInfoArg : IDataSerializer
        {
         public Int32? RoleId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class DBGameTalkRoleInfoRes : IDataSerializer
        {
         public Int32? RetCode; 
 public RoleInfoBean Info; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SNSRoleBrief : IDataSerializer
        {
         public Int32? Level; 
 public Int32? Exp; 
 public Int32? Sp; 
 public Int32? Level2; 
 public Int32? Reputation; 
 public Int32? Pp; 
 public Int32? Vitality; 
 public Int32? Energy; 
 public Int32? Strength; 
 public Int32? Agility; 
 public Int32? MaxHp; 
 public Int32? MaxMp; 
 public Single? RunSpeed; 
 public Int32? Attack; 
 public Int32? DamageLow; 
 public Int32? DamageHigh; 
 public Int32? AttackSpeed; 
 public Single? AttackRange; 
 public Int32? DamageMagicLow; 
 public Int32? DamageMagicHigh; 
 public Int32? Resistance0; 
 public Int32? Resistance1; 
 public Int32? Resistance2; 
 public Int32? Resistance3; 
 public Int32? Resistance4; 
 public Int32? Defense; 
 public Int32? Armor; 
 public Int32? CritRate; 
 public Int32? CritDamage; 
 public Int32? AttackDegree; 
 public Int32? DefendDegree; 
 public Int32? InvisibleDegree; 
 public Int32? AntiInvisibleDegree; 
 public Int32? SoulPower; 
 public UInt32? SkillsCRC; 
 public UInt32? EquipmentCRC; 
 public UInt32? PetcorralCRC; 
 public Int32? Spouse; 
 public Int32? FactionId; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SNSRoleSkills : IDataSerializer
        {
         public UInt32? CRC; 
 public Octets Skills; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SNSRoleEquipment : IDataSerializer
        {
         public UInt32? CRC; 
 public GRoleEquipment Equipment; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      

        public abstract class SNSRolePetCorral : IDataSerializer
        {
         public UInt32? CRC; 
 public Octets Petcorral; 


        public abstract DataStream Serialize(DataStream ds);
        public abstract bool TryDeserialize(DataStream ds);
        }
      
      }
    