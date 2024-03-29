--TODO: auto generate below code

local protoIDs = {}


protoIDs[0] = "AuthGateSuccess"
protoIDs[1] = "AuthGateFailure"
protoIDs[2] = "HeartbeatPackage"
protoIDs[3] = "SystemKickOut"
protoIDs[4] = "HeartbeatTimeout"


-- =======================================================================
protoIDs[1000] = "user.NoticeInfo"
protoIDs[1001] = "user.UserInfoReq"
protoIDs[1002] = "user.UserInfoRep"
protoIDs[1003] = "user.ModifyUserInfoReq"
protoIDs[1004] = "user.ModifyUserInfoRep"
protoIDs[1005] = "user.CheckReconnectReq"
protoIDs[1006] = "user.CheckReconnectRep"
protoIDs[1007] = "user.ReconnectTableReq"
protoIDs[1008] = "user.ReconnectTableRep"
protoIDs[1011] = "user.PlayersAmountReq"
protoIDs[1012] = "user.PlayersAmountRep"
protoIDs[1013] = "user.CheckSecondPwdReq"
protoIDs[1014] = "user.CheckSecondPwdRep"
protoIDs[1015] = "user.SetSecondPwdReq"
protoIDs[1016] = "user.SetSecondPwdRep"
protoIDs[1017] = "user.BankOperateReq"
protoIDs[1018] = "user.BankOperateRep"
protoIDs[1019] = "user.BindingDeviceReq"
protoIDs[1020] = "user.BindingDeviceRep"
protoIDs[1029] = "user.GiveGoldReq"
protoIDs[1030] = "user.GiveGoldRep"
protoIDs[1031] = "user.RoomListReq"
protoIDs[1032] = "user.RoomListRep"
protoIDs[1033] = "user.RechargeReq"
protoIDs[1034] = "user.RechargeRep"
protoIDs[1035] = "user.ModifyLoginPasswordReq"
protoIDs[1036] = "user.ModifyLoginPasswordRep"
protoIDs[1037] = "user.SignInInfoReq"
protoIDs[1038] = "user.SignInInfoRep"
protoIDs[1039] = "user.SignInReq"
protoIDs[1040] = "user.SignInRep"
protoIDs[1041] = "user.InsureReq"
protoIDs[1042] = "user.InsureRep"
protoIDs[1043] = "user.SharedRewardReq"
protoIDs[1044] = "user.SharedRewardRep"
protoIDs[1045] = "user.ExchangeCodeReq"
protoIDs[1046] = "user.ExchangeCodeRep"
protoIDs[1047] = "user.HonorExchangeGoldReq"
protoIDs[1048] = "user.HonorExchangeGoldRep"
protoIDs[1050] = "user.GoldGaveLogReq"
protoIDs[1051] = "user.GoldGaveLogRep"
protoIDs[1052] = "user.SetInviteCodeReq"
protoIDs[1053] = "user.SetInviteCodeRep"

protoIDs[1100] = "user.EnterRoomReq"
protoIDs[1101] = "user.EnterRoomRep"
protoIDs[1110] = "user.PrivateInfoReq"
protoIDs[1111] = "user.PrivateInfoRep"
protoIDs[1112] = "user.CreatePrivateReq"
protoIDs[1113] = "user.CreatePrivateRep"
protoIDs[1114] = "user.EnterPrivateReq"
protoIDs[1115] = "user.EnterPrivateRep"
protoIDs[1116] = "user.CreatePrivateInfoReq"
protoIDs[1117] = "user.CreatePrivateInfoRep"

protoIDs[1200] = "user.NoticeSyncPack"
protoIDs[1201] = "user.PublishNoticeReq"
protoIDs[1202] = "user.PublishNoticeRep"

protoIDs[1300] = "user.PrivateHistoryReq"
protoIDs[1301] = "user.PrivateHistoryRep"
protoIDs[1302] = "user.PrivateHistoryDetailReq"
protoIDs[1303] = "user.PrivateHistoryDetailRep"
protoIDs[1304] = "user.PrivateReplayReq"
protoIDs[1305] = "user.PrivateReplayRep"

protoIDs[1401] = "user.UpdateAvatarUrl"


-- =======================================================================
protoIDs[2001] = "game.ServerStop"
protoIDs[2002] = "game.SetSession"
protoIDs[2030] = "game.RoomInfo"
protoIDs[2031] = "game.PrivateRoomInfo"
protoIDs[2032] = "game.PrivateDismissReq"
protoIDs[2033] = "game.PrivateDismissRep"
protoIDs[2034] = "game.PrivateDismissAsk"
protoIDs[2035] = "game.PrivateDismissAns"
protoIDs[2040] = "game.TableStateInfo"
protoIDs[2041] = "game.TableSitdown"
protoIDs[2042] = "game.TableSitup"
protoIDs[2043] = "game.TableStateStart"
protoIDs[2044] = "game.TableStateEnd"
protoIDs[2045] = "game.SitdownReq"
protoIDs[2046] = "game.SitdownRep"
protoIDs[2047] = "game.SitupReq"
protoIDs[2048] = "game.SitupRep"
protoIDs[2049] = "game.RoomSession"
protoIDs[2050] = "game.LeaveRoomReq"
protoIDs[2051] = "game.LeaveRoomRep"
protoIDs[2052] = "game.ReadyReq"
protoIDs[2053] = "game.ReadyRep"
protoIDs[2054] = "game.SeatReady"
protoIDs[2055] = "game.UserOffline"
protoIDs[2056] = "game.UserOnline"
protoIDs[2060] = "game.ChatReq"
protoIDs[2061] = "game.ChatRep"


-- =======================================================================
protoIDs[10101] = "XZMJ.StartGame"
protoIDs[10102] = "XZMJ.BankerSeat"
protoIDs[10103] = "XZMJ.DistributeCard"
protoIDs[10104] = "XZMJ.ComplementCard"
protoIDs[10105] = "XZMJ.DrawCard"
protoIDs[10106] = "XZMJ.AllowOut"
protoIDs[10107] = "XZMJ.AllowCombin"
protoIDs[10108] = "XZMJ.OutCard"
protoIDs[10109] = "XZMJ.Ready"
protoIDs[10110] = "XZMJ.CombinCard"
protoIDs[10111] = "XZMJ.HuCard"
protoIDs[10112] = "XZMJ.IgnoreCard"
protoIDs[10113] = "XZMJ.EndGame"
protoIDs[10114] = "XZMJ.Managed"
protoIDs[10115] = "XZMJ.GameInfo"
protoIDs[10116] = "XZMJ.PlayerInfo"
protoIDs[10117] = "XZMJ.AllowFlower"
protoIDs[10118] = "XZMJ.OutedCard"
protoIDs[10119] = "XZMJ.MajiangInfo"
protoIDs[10120] = "XZMJ.AllowSelect"
protoIDs[10121] = "XZMJ.SelectInfo"
protoIDs[10122] = "XZMJ.AllowOutEx"
protoIDs[10123] = "XZMJ.AllowCombinEx"
protoIDs[10124] = "XZMJ.UpdateScore"
protoIDs[10125] = "XZMJ.HunCard"
protoIDs[10126] = "XZMJ.ShortageHun"
protoIDs[10127] = "XZMJ.OverGame"


-- -----------------------------------------------------------------------
protoIDs[10201] = "HkFiveCard.UpdateGameInfo"
protoIDs[10202] = "HkFiveCard.OperateReq"
protoIDs[10203] = "HkFiveCard.OperateRep"
protoIDs[10204] = "HkFiveCard.AddCard"
protoIDs[10205] = "HkFiveCard.ShowCard"
protoIDs[10207] = "HkFiveCard.SyncGameData"
protoIDs[10208] = "HkFiveCard.ReconnectRep"
protoIDs[10210] = "HkFiveCard.SettleAccount"


-- -----------------------------------------------------------------------
protoIDs[10301] = "TBNN.GameConf"
protoIDs[10302] = "TBNN.GameStart"
protoIDs[10303] = "TBNN.FinishedReq"
protoIDs[10304] = "TBNN.FinishedSync"
protoIDs[10305] = "TBNN.GameEnd"
protoIDs[10306] = "TBNN.SyncGameInfo"


-- -----------------------------------------------------------------------
protoIDs[10401] = "HLNN.GameConf"
protoIDs[10402] = "HLNN.CallStart"
protoIDs[10403] = "HLNN.CallReq"
protoIDs[10404] = "HLNN.CallSync"
protoIDs[10405] = "HLNN.MultiStart"
protoIDs[10406] = "HLNN.MultiReq"
protoIDs[10407] = "HLNN.MultiSync"
protoIDs[10408] = "HLNN.SortStart"
protoIDs[10409] = "HLNN.SortReq"
protoIDs[10410] = "HLNN.SortSync"
protoIDs[10411] = "HLNN.GameEnd"
protoIDs[10412] = "HLNN.SyncGameInfo"
protoIDs[10413] = "HLNN.PrivateOver"


-- -----------------------------------------------------------------------
protoIDs[10501] = "NN100.GameStatusNtf"
protoIDs[10502] = "NN100.UpdateBankerInfo"
protoIDs[10503] = "NN100.AskBet"
protoIDs[10504] = "NN100.UpdateBetInfo"
protoIDs[10505] = "NN100.HistoryReq"
protoIDs[10506] = "NN100.HistoryRep"
protoIDs[10507] = "NN100.RankListReq"
protoIDs[10508] = "NN100.RankListRep"
protoIDs[10509] = "NN100.BankerListReq"
protoIDs[10510] = "NN100.BankerListRep"
protoIDs[10511] = "NN100.BankerReq"
protoIDs[10512] = "NN100.BankerRep"
protoIDs[10513] = "NN100.ShowCard"
protoIDs[10514] = "NN100.GameEnd"
protoIDs[10515] = "NN100.AskBetRep"


-- -----------------------------------------------------------------------
protoIDs[10601] = "SanGong.PlayerCards"
protoIDs[10602] = "SanGong.SyncGameInfo"
protoIDs[10603] = "SanGong.GameBegin"
protoIDs[10604] = "SanGong.RobBanker"
protoIDs[10605] = "SanGong.PollBanker"
protoIDs[10606] = "SanGong.BankerReq"
protoIDs[10607] = "SanGong.BankerRep"
protoIDs[10608] = "SanGong.UpdateBanker"
protoIDs[10609] = "SanGong.AskBetsBegin"
protoIDs[10610] = "SanGong.AskBetsReq"
protoIDs[10611] = "SanGong.AskBetsRep"
protoIDs[10612] = "SanGong.DealCard"
protoIDs[10613] = "SanGong.OpenCard"
protoIDs[10614] = "SanGong.GameEnd"
protoIDs[10615] = "SanGong.OpenCardReq"
protoIDs[10616] = "SanGong.OpenCardRep"


-- -----------------------------------------------------------------------
protoIDs[10701] = "CatchFish.SyncFishery"
protoIDs[10702] = "CatchFish.ShootBullet"
protoIDs[10703] = "CatchFish.CastNet"
protoIDs[10704] = "CatchFish.CatchFish"
protoIDs[10705] = "CatchFish.FishArray"
protoIDs[10706] = "CatchFish.SelectCannon"
protoIDs[10707] = "CatchFish.PlayerInfo"


-- -----------------------------------------------------------------------
protoIDs[10801] = "TexasPoker.GameStart"
protoIDs[10802] = "TexasPoker.OperateReq"
protoIDs[10803] = "TexasPoker.OperateRep"
protoIDs[10804] = "TexasPoker.UpdatePublicCard"
protoIDs[10805] = "TexasPoker.GameEnd"
protoIDs[10806] = "TexasPoker.SyncGameInfo"
protoIDs[10807] = "TexasPoker.GameConf"


-- -----------------------------------------------------------------------
protoIDs[10901] = "Baccarat.GameStatusNtf"
protoIDs[10902] = "Baccarat.History"
protoIDs[10903] = "Baccarat.AskBet"
protoIDs[10904] = "Baccarat.UpdateBetInfo"
protoIDs[10905] = "Baccarat.ShowCard"
protoIDs[10906] = "Baccarat.GameEnd"


--------------------------------------------------------------------------
protoIDs[11101] = "MaJiang.StartGame"
protoIDs[11102] = "MaJiang.LuckCard"
protoIDs[11103] = "MaJiang.DistributeCard"
protoIDs[11104] = "MaJiang.ComplementCard"
protoIDs[11105] = "MaJiang.DrawCard"
protoIDs[11106] = "MaJiang.AllowOut"
protoIDs[11107] = "MaJiang.AllowCombin"
protoIDs[11108] = "MaJiang.OutCard"
protoIDs[11109] = "MaJiang.Ready"
protoIDs[11110] = "MaJiang.CombinCard"
protoIDs[11111] = "MaJiang.HuCard"
protoIDs[11112] = "MaJiang.IgnoreCard"
protoIDs[11113] = "MaJiang.EndGame"
protoIDs[11114] = "MaJiang.Managed"
protoIDs[11115] = "MaJiang.GameInfo"
protoIDs[11116] = "MaJiang.PlayerInfo"
protoIDs[11117] = "MaJiang.AllowFlower"
protoIDs[11118] = "MaJiang.OutedCard"
protoIDs[11119] = "MaJiang.MajiangInfo"
protoIDs[11120] = "MaJiang.AllowSelect"
protoIDs[11121] = "MaJiang.SelectInfo"
protoIDs[11122] = "MaJiang.AllowOutEx"
protoIDs[11123] = "MaJiang.AllowCombinEx"
protoIDs[11124] = "MaJiang.ShowCard"
protoIDs[11125] = "MaJiang.PrivateOver"


-- -----------------------------------------------------------------------
protoIDs[11301] = "ShiSanShui.GameConf"
protoIDs[11302] = "ShiSanShui.GameStart"
protoIDs[11303] = "ShiSanShui.FinishedReq"
protoIDs[11304] = "ShiSanShui.FinishedSync"
protoIDs[11305] = "ShiSanShui.GameEnd"
protoIDs[11306] = "ShiSanShui.SyncGameInfo"


-- -----------------------------------------------------------------------
protoIDs[11401] = "PPL.GameConf"
protoIDs[11402] = "PPL.CallStart"
protoIDs[11403] = "PPL.CallReq"
protoIDs[11404] = "PPL.CallSync"
protoIDs[11405] = "PPL.MultiStart"
protoIDs[11406] = "PPL.MultiReq"
protoIDs[11407] = "PPL.MultiSync"
protoIDs[11408] = "PPL.SortStart"
protoIDs[11409] = "PPL.SortReq"
protoIDs[11410] = "PPL.SortSync"
protoIDs[11411] = "PPL.GameEnd"
protoIDs[11412] = "PPL.SyncGameInfo"
protoIDs[11413] = "PPL.PrivateOver"


-- -----------------------------------------------------------------------
local ret = {}
for k, v in pairs(protoIDs) do
	ret[k] = v
    ret[v] = k
end


return ret
