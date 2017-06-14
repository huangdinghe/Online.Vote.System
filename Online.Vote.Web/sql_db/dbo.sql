/*
Navicat SQL Server Data Transfer

Source Server         : LocalDb
Source Server Version : 130000
Source Host           : (localdb)\MSSQLLocalDB:1433
Source Database       : OnlineVoteSystem
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 130000
File Encoding         : 65001

Date: 2017-06-14 16:09:32
*/


-- ----------------------------
-- Table structure for Match
-- ----------------------------
DROP TABLE [dbo].[Match]
GO
CREATE TABLE [dbo].[Match] (
[ID] int NOT NULL ,
[MatchNo] int NULL ,
[MatchName] nvarchar(50) NULL ,
[MatchAddress] nvarchar(50) NULL ,
[MatchTime] datetime NULL ,
[Judges] nvarchar(100) NULL ,
[Hostess] nvarchar(50) NULL 
)


GO

-- ----------------------------
-- Records of Match
-- ----------------------------
INSERT INTO [dbo].[Match] ([ID], [MatchNo], [MatchName], [MatchAddress], [MatchTime], [Judges], [Hostess]) VALUES (N'1', N'1', N'bettersinger', N'chongqing', N'2017-06-13 14:00:20.000', N'humo', N'hello')
GO
GO
INSERT INTO [dbo].[Match] ([ID], [MatchNo], [MatchName], [MatchAddress], [MatchTime], [Judges], [Hostess]) VALUES (N'2', N'11', N'sds', N'hb', N'2017-06-20 15:59:25.000', N'hello', N'hello')
GO
GO

-- ----------------------------
-- Table structure for MatchPKInfo
-- ----------------------------
DROP TABLE [dbo].[MatchPKInfo]
GO
CREATE TABLE [dbo].[MatchPKInfo] (
[MatchId] int NULL ,
[FirstPlayerId] int NULL ,
[SecondPlayerId] int NULL ,
[FirstSongName] nvarchar(50) NULL ,
[SecondSongName] nvarchar(50) NULL ,
[FirstPlayerScore] nvarchar(50) NULL ,
[SecondPlayerScore] nvarchar(50) NULL ,
[MatchFlag] tinyint NULL ,
[ID] int NOT NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'MatchPKInfo', 
'COLUMN', N'MatchId')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'场次ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'MatchPKInfo'
, @level2type = 'COLUMN', @level2name = N'MatchId'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'场次ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'MatchPKInfo'
, @level2type = 'COLUMN', @level2name = N'MatchId'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'MatchPKInfo', 
'COLUMN', N'FirstPlayerId')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'选手1ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'MatchPKInfo'
, @level2type = 'COLUMN', @level2name = N'FirstPlayerId'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'选手1ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'MatchPKInfo'
, @level2type = 'COLUMN', @level2name = N'FirstPlayerId'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'MatchPKInfo', 
'COLUMN', N'SecondPlayerId')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'选手2Id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'MatchPKInfo'
, @level2type = 'COLUMN', @level2name = N'SecondPlayerId'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'选手2Id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'MatchPKInfo'
, @level2type = 'COLUMN', @level2name = N'SecondPlayerId'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'MatchPKInfo', 
'COLUMN', N'MatchFlag')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'是否激活'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'MatchPKInfo'
, @level2type = 'COLUMN', @level2name = N'MatchFlag'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'是否激活'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'MatchPKInfo'
, @level2type = 'COLUMN', @level2name = N'MatchFlag'
GO

-- ----------------------------
-- Records of MatchPKInfo
-- ----------------------------
INSERT INTO [dbo].[MatchPKInfo] ([MatchId], [FirstPlayerId], [SecondPlayerId], [FirstSongName], [SecondSongName], [FirstPlayerScore], [SecondPlayerScore], [MatchFlag], [ID]) VALUES (N'1', N'1', N'1', N'11', N'11', N'11', N'11', N'1', N'1')
GO
GO
INSERT INTO [dbo].[MatchPKInfo] ([MatchId], [FirstPlayerId], [SecondPlayerId], [FirstSongName], [SecondSongName], [FirstPlayerScore], [SecondPlayerScore], [MatchFlag], [ID]) VALUES (N'2', N'1', N'2', N'22', N'22', N'22', N'22', N'1', N'2')
GO
GO

-- ----------------------------
-- Table structure for Player
-- ----------------------------
DROP TABLE [dbo].[Player]
GO
CREATE TABLE [dbo].[Player] (
[ID] int NOT NULL ,
[PlayerNo] nvarchar(4) NULL ,
[PlayerName] nvarchar(20) NULL ,
[PlayerImage] nvarchar(100) NULL 
)


GO

-- ----------------------------
-- Records of Player
-- ----------------------------
INSERT INTO [dbo].[Player] ([ID], [PlayerNo], [PlayerName], [PlayerImage]) VALUES (N'1', N'001', N'akon', N'images/akon.jpg')
GO
GO
INSERT INTO [dbo].[Player] ([ID], [PlayerNo], [PlayerName], [PlayerImage]) VALUES (N'2', N'002', N'bob', N'images/akon.jpg')
GO
GO

-- ----------------------------
-- Table structure for Users
-- ----------------------------
DROP TABLE [dbo].[Users]
GO
CREATE TABLE [dbo].[Users] (
[ID] int NOT NULL ,
[UsersName] nvarchar(20) NULL ,
[Password] nvarchar(12) NULL ,
[UsersType] tinyint NULL 
)


GO

-- ----------------------------
-- Records of Users
-- ----------------------------
INSERT INTO [dbo].[Users] ([ID], [UsersName], [Password], [UsersType]) VALUES (N'1', N'humo', N'123456', null)
GO
GO
INSERT INTO [dbo].[Users] ([ID], [UsersName], [Password], [UsersType]) VALUES (N'2', N'hello', N'123456', null)
GO
GO

-- ----------------------------
-- Indexes structure for table Match
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Match
-- ----------------------------
ALTER TABLE [dbo].[Match] ADD PRIMARY KEY ([ID])
GO

-- ----------------------------
-- Indexes structure for table MatchPKInfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table MatchPKInfo
-- ----------------------------
ALTER TABLE [dbo].[MatchPKInfo] ADD PRIMARY KEY ([ID])
GO

-- ----------------------------
-- Indexes structure for table Player
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Player
-- ----------------------------
ALTER TABLE [dbo].[Player] ADD PRIMARY KEY ([ID])
GO

-- ----------------------------
-- Indexes structure for table Users
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Users
-- ----------------------------
ALTER TABLE [dbo].[Users] ADD PRIMARY KEY ([ID])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[MatchPKInfo]
-- ----------------------------
ALTER TABLE [dbo].[MatchPKInfo] ADD FOREIGN KEY ([FirstPlayerId]) REFERENCES [dbo].[Player] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[MatchPKInfo] ADD FOREIGN KEY ([MatchId]) REFERENCES [dbo].[Match] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[MatchPKInfo] ADD FOREIGN KEY ([SecondPlayerId]) REFERENCES [dbo].[Player] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
