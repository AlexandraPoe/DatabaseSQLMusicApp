-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 27, 2024 at 11:56 AM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `music2`
--

-- --------------------------------------------------------

--
-- Table structure for table `albums`
--

CREATE TABLE `albums` (
  `ID` int(11) NOT NULL,
  `ALBUM_TITLE` varchar(100) NOT NULL,
  `ARTIST` varchar(100) NOT NULL,
  `YEAR` int(11) NOT NULL,
  `IMAGE_NAME` varchar(100) DEFAULT NULL,
  `DESCRIPTION` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `albums`
--

INSERT INTO `albums` (`ID`, `ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES
(3, 'Abbey Road', 'The Beatles', 1961, 'https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg', 'Abbey Road is the eleventh studio album by English rock band the Beatles, released on 26 September 1969 by Apple Records. '),
(4, 'Let it be', 'The Beatles', 1970, 'https://upload.wikimedia.org/wikipedia/en/2/25/LetItBe.jpg', 'Let It Be. is the twelfth and final studio album by the English rock band the Beatles. It was released on 8 May 1970, almost a month after the group\'s break-up. Like most of the band\'s previous releases, it was a number one album in many countries, including both the US and the UK'),
(5, 'Help', 'The Beatles', 1965, 'https://upload.wikimedia.org/wikipedia/en/e/e7/Help%21_%28The_Beatles_album_-_cover_art%29.jpg', 'Help! is the fifth studio album by English rock band the Beatles and the soundtrack from their film Help!. It was released on 6 August 1965. Produced by George Martin, it was the fifth UK album release by the band, and contains fourteen songs in its original British form. '),
(6, 'Revolver ', 'The Beatles ', 1965, 'https://upload.wikimedia.org/wikipedia/en/e/ec/Revolver_%28album_cover%29.jpg ', 'Revolver is the seventh studio album by the English rock band the Beatles. Released on 5 August 1966, it was the Beatles\' final recording project before their retirement as live performers and marked the group\'s most overt use of studio technology up to that time, building on the advances of their late 1965 release Rubber Soul.  '),
(7, 'Rubber Soul', 'The Beatles', 1965, 'https://upload.wikimedia.org/wikipedia/en/7/74/Rubber_Soul.jpg', 'Rubber Soul is the sixth studio album by the English rock band the Beatles. It was released on 3 December 1965 in the United Kingdom, on EMI\'s Parlophone label, accompanied by the non-album double A-side single \"Day Tripper\" / \"We Can Work It Out\". '),
(16, 'Yellow Submarine', 'The Beatles', 1969, 'https://upload.wikimedia.org/wikipedia/en/a/ac/TheBeatles-YellowSubmarinealbumcover.jpg', 'Yellow Submarine is the tenth studio album by English rock band the Beatles, released on 13 January 1969 in the United States and on 17 January 1969 in the United Kingdom. '),
(17, 'Hard Days Night', 'Beatles', 1964, 'https://upload.wikimedia.org/wikipedia/en/e/e6/HardDayUK.jpg', 'A Hard Day\'s Night is the third studio album by the English rock band the Beatles, released on 10 July 1964 by Parlophone, with side one containing songs from the soundtrack to their film of the same name. The American version of the album was released two weeks earlier, on 26 June 1964 by United Artists Records, with a different track listing that included selections from George Martin\'s film score.  \r\n'),
(19, 'Sgt. Pepper\'s Lonely Hearts Club Band', 'The Beatles', 1967, 'https://upload.wikimedia.org/wikipedia/en/5/50/Sgt._Pepper%27s_Lonely_Hearts_Club_Band.jpg', 'Sgt. Pepper\'s Lonely Hearts Club Band is the eighth studio album by the English rock band the Beatles. Released on 26 May 1967,[nb 1] it spent 27 weeks at number one on the Record Retailer chart in the United Kingdom and 15 weeks at number one on the Billboard Top LPs chart in the United States. ');

-- --------------------------------------------------------

--
-- Table structure for table `tracks`
--

CREATE TABLE `tracks` (
  `ID` int(11) NOT NULL,
  `track_title` varchar(200) DEFAULT NULL,
  `number` int(11) DEFAULT NULL,
  `video_url` varchar(200) DEFAULT NULL,
  `lyrics` text,
  `albums_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tracks`
--

INSERT INTO `tracks` (`ID`, `track_title`, `number`, `video_url`, `lyrics`, `albums_ID`) VALUES
(2, 'Come Together', 1, 'https://www.youtube.com/watch?v=45cYwDMibGo', 'Here come old flat top\r\nHe come grooving up slowly\r\nHe got joo joo eyeball\r\nHe one holy roller\r\nHe got hair down to his knee\r\nGot to be a joker he just do what he please\r\nHe wear no shoe shine\r\nHe got toe jam football\r\nHe got monkey finger\r\nHe shoot Coca-Cola\r\nHe say I know you, you know me\r\nOne thing I can tell you is you got to be free\r\nCome together, right now, over me\r\nHe bag production\r\nHe got walrus gumboot\r\nHe got Ono sideboard\r\nHe one spinal cracker\r\nHe got feet down below his knee\r\nHold you in his armchair you can feel his disease\r\nCome together, right now, over me\r\nHe roller coaster\r\nHe got early warning\r\nHe got muddy water\r\nHe one mojo filter\r\nHe say, \"one and one and one is three\"\r\nGot to be good looking \'cause he\'s so hard to see\r\nCome together, right now, over me\r\nOh\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nOh\r\nCome together, yeah\r\nCome together, yeah', 3),
(27, 'Help', 13, 'https://www.youtube.com/watch?v=2Q_ZzBGPdqE', 'Intro: John Lennon]\r\n(Help!) I need somebody\r\n(Help!) Not just anybody\r\n(Help!) You know I need someone\r\n(Help!)\r\n\r\n[Verse 1: John Lennon]\r\nWhen I was younger so much younger than today\r\nI never needed anybody\'s help in any way\r\nBut now these days are gone, I\'m not so self assured\r\nNow I find I\'ve changed my mind and opened up the doors\r\n\r\n[Chorus: John Lennon]\r\nHelp me if you can, I\'m feeling down\r\nAnd I do appreciate you being \'round\r\nHelp me get my feet back on the ground\r\nWon\'t you please, please help me?\r\n\r\n[Verse 2: John Lennon]\r\nAnd now my life has changed in oh so many ways\r\nMy independence seems to vanish in the haze\r\nBut every now and then I feel so insecure\r\nI know that I just need you like I\'ve never done before\r\n\r\n[Chorus: John Lennon]\r\nHelp me if you can, I\'m feeling down\r\nAnd I do appreciate you being \'round\r\nHelp me get my feet back on the ground\r\nWon\'t you please, please help me?\r\n\r\n[Verse 3: John Lennon]\r\nWhen I was younger, so much younger than today\r\nI never needed anybody\'s help in any way\r\nBut now these days are gone, I\'m not so self assured\r\nNow I find I\'ve changed my mind and opened up the doors\r\n\r\n[Chorus: John Lennon]\r\nHelp me if you can, I\'m feeling down\r\nAnd I do appreciate you being \'round\r\nHelp me get my feet back on the ground\r\nWon\'t you please, please help me?\r\nHelp me? Help me? Ooh', 5),
(28, 'The Night Before', 2, 'https://www.youtube.com/watch?v=aP5e9m99JX8', 'We said our goodbyes, ah, the night before\r\nLove was in your eyes, ah, the night before\r\nNow today I find you have changed your mind\r\nTreat me like you did the night before\r\nWere you telling lies, ah, the night before?\r\nWas I so unwise, ah, the night before?\r\nWhen I held you near you were so sincere\r\nTreat me like you did the night before\r\nLast night is a night I will remember you by\r\nWhen I think of things we did it makes me want to cry\r\nWe said our goodbye, ah, the night before\r\nLove was in your eyes, ah, the night before\r\nNow today I find you have changed your mind\r\nTreat me like you did the night before\r\nWhen I held you near you were so sincere\r\nTreat me like you did the night before\r\nLast night is a night I will remember you by\r\nWhen I think of things we did, it makes me want to cry\r\nWere you telling lies, ah, the night before?\r\nWas I so unwise, ah, the night before?\r\nWhen I held you near you were so sincere\r\nTreat me like you did the night before\r\nLike the night before', 5),
(29, 'It\'s Been a Hard Days Night', 2, 'https://www.youtube.com/watch?v=Yjyj8qnqkYI', 'It\'s been a hard day\'s night, and I\'ve been working like a dog\r\nIt\'s been a hard day\'s night, I should be sleeping like a log\r\nBut when I get home to you I find the things that you do\r\nWill make me feel alright\r\n\r\nYou know I work all day to get you money to buy you things\r\nAnd it\'s worth it just to hear you say you\'re going to give me everything\r\nSo why on earth should I moan, cos when I get you alone\r\nYou know I feel OK\r\n\r\nWhen I\'m home everything seems to be right\r\nWhen I\'m home feeling you holding me tight, tight, yeah\r\n\r\nIt\'s been a hard day\'s night, and I\'ve been working like a dog\r\nIt\'s been a hard day\'s night, I should be sleeping like a log\r\nBut when I get home to you I find the things that you do\r\nWill make me feel alright owww\r\n\r\nSo why on earth should I moan, cos when I get you alone\r\nYou know I feel OK\r\n\r\nWhen I\'m home everything seems to be right\r\nWhen I\'m home feeling you holding me tight, tight, yeah\r\n\r\nIt\'s been a hard day\'s night, and I\'ve been working like a dog\r\nIt\'s been a hard day\'s night, I should be sleeping like a log\r\nBut when I get home to you I find the things that you do\r\nWill make me feel alright\r\nYou know I feel alright\r\nYou know I feel alright\r\n', 17),
(30, 'Ticket to Ride', 7, 'https://www.youtube.com/watch?v=SyNt5zm3U_M', 'I think I\'m gonna be sad\r\nI think it\'s today, yeah\r\nThe girl that\'s driving me mad\r\nIs going away\r\n\r\nShe\'s got a ticket to ride\r\nShe\'s got a ticket to ride\r\nShe\'s got a ticket to ride\r\nBut she don\'t care\r\n\r\nShe said that living with me\r\nIs bringing her down, yeah\r\nFor she would never be free\r\nWhen I was around\r\n\r\nShe\'s got a ticket to ride\r\nShe\'s got a ticket to ride\r\nShe\'s got a ticket to ride\r\nBut she don\'t care\r\n\r\nI don\'t know why she\'s riding so high\r\nShe ought to think twice\r\nShe ought to do right by me\r\nBefore she gets to saying goodbye\r\nShe ought to think twice\r\nShe ought to do right by me\r\n\r\nI think I\'m gonna be sad\r\nI think it\'s today, yeah\r\nThe girl that\'s driving me mad\r\nIs going away, yeah\r\n\r\nOh, she\'s got a ticket to ride\r\nShe\'s got a ticket to ride\r\nShe\'s got a ticket to ride\r\nBut she don\'t care\r\n\r\nI don\'t know why she\'s riding so high\r\nShe ought to think twice\r\nShe ought to do right by me\r\nBefore she gets to saying goodbye\r\nShe ought to think twice\r\nShe ought to do right by me\r\n\r\nShe said that living with me\r\nIs bringing her down, yeah\r\nFor she would never be free\r\nWhen I was around\r\n\r\nAh, she\'s got a ticket to ride\r\nShe\'s got a ticket to ride\r\nShe\'s got a ticket to ride\r\nBut she don\'t care\r\n\r\nMy baby don\'t care, my baby don\'t care\r\nMy baby don\'t care, my baby don\'t care\r\nMy baby don\'t care, my baby don\'t care (fade out)', 5),
(31, 'Yesterday', 13, 'https://www.youtube.com/watch?v=4YWyFIzSeXI', 'Yesterday all my troubles seemed so far away.\r\nNow it looks as though they\'re here to stay.\r\nOh, I believe in yesterday.\r\n\r\nSuddenly, I\'m not half the man I used to be.\r\nThere\'s a shadow hanging over me.\r\nOh, yesterday came suddenly.\r\n\r\nWhy she had to go?\r\nI don\'t know, she wouldn\'t say.\r\nI said something wrong.\r\nNow I long for yesterday.\r\n\r\nYesterday love was such an easy game to play.\r\nNow I need a place to hide away.\r\nOh, I believe in yesterday.\r\n\r\nWhy she had to go?\r\nI don\'t know, she wouldn\'t say.\r\nI said something wrong.\r\nNow I long for yesterday.\r\n\r\nYesterday love was such an easy game to play.\r\nNow I need a place to hide away.\r\nOh, I believe in yesterday.\r\n\r\nMm mm mm mm mm mm mm.', 17),
(32, 'Nowhere Man', 4, 'https://www.youtube.com/watch?v=8scSwaKbE64', 'He\'s a real nowhere man\r\nSitting in his nowhere land\r\nMaking all his nowhere plans for nobody\r\n\r\nDoesn\'t have a point of view\r\nKnows not where he\'s going to\r\nIsn\'t he a bit like you and me?\r\n\r\nNowhere Man, please listen\r\nYou don\'t know what you\'re missing\r\nNowhere Man, the world is at your command\r\n\r\nHe\'s as blind as he can be\r\nJust sees what he wants to see\r\nNowhere Man can you see me at all?\r\n\r\nNowhere Man, don\'t worry\r\nTake your time, don\'t hurry\r\nLeave it all till somebody else lends you a hand\r\n\r\nDoesn\'t have a point of view\r\nKnows not where he\'s going to\r\nIsn\'t he a bit like you and me?\r\n\r\nNowhere Man, please listen\r\nYou don\'t know what you\'re missing\r\nNowhere Man, the world is at your command\r\n\r\nHe\'s a real Nowhere Man\r\nSitting in his nowhere land\r\nMaking all his nowhere plans for nobody\r\nMaking all his nowhere plans for nobody\r\nMaking all his nowhere plans for nobody', 7),
(33, 'In my life', 11, 'https://www.youtube.com/watch?v=YBcdt6DsLQA', 'There are places I\'ll remember\r\nAll my life though some have changed\r\nSome forever not for better\r\nSome have gone and some remain\r\n\r\nAll these places had their moments\r\nWith lovers and friends I still can recall\r\nSome are dead and some are living\r\nIn my life I\'ve loved them all\r\n\r\nBut of all these friends and lovers\r\nThere is no one compares with you\r\nAnd these memories lose their meaning\r\nWhen I think of love as something new\r\n\r\nThough I know I\'ll never lose affection\r\nFor people and things that went before\r\nI know I\'ll often stop and think about them\r\nIn my life I love you more\r\n\r\nThough I know I\'ll never lose affection\r\nFor people and things that went before\r\nI know I\'ll often stop and think about them\r\nIn my life I love you more\r\n\r\nIn my life I love you more', 7),
(34, 'Come Together', 1, 'https://www.youtube.com/watch?v=45cYwDMibGo', 'Here come old flat-top, he come groovin\' up slowly\r\nHe got ju-ju eyeball, he one holy roller\r\nHe got hair down to his knee\r\nGot to be a joker, he just do what he please\r\n\r\nHe wear no shoeshine, he got toe-jam football\r\nHe got monkey finger, he shoot Coca-Cola\r\nHe say, \"I know you, you know me\"\r\nOne thing I can tell you is you got to be free\r\n\r\nCome together, right now\r\nOver me\r\n\r\nHe bag production, he got walrus gumboot\r\nHe got Ono sideboard, he one spinal cracker\r\nHe got feet down below his knee\r\nHold you in his armchair, you can feel his disease\r\n\r\nCome together, right now\r\nOver me\r\n\r\nRight!\r\n\r\nCome, come, come, come...\r\n\r\nHe roller-coaster, he got early warnin\'\r\nHe got muddy water, he one mojo filter\r\nHe say, \"One and one and one is three\"\r\nGot to be good-lookin\' \'cause he\'s so hard to see\r\n\r\nCome together, right now\r\nOver me\r\n\r\nUgh!\r\n\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nAgh!\r\nCome together, yeah\r\nCome together, yeah\r\nCome together...', 3),
(36, 'Here Comes the Sun', 7, 'https://www.youtube.com/watch?v=KQetemT1sWc', 'Here comes the sun, doo-doo-doo-doo, here comes the sun\r\nAnd I say it\'s all right\r\n\r\nLittle darling, it\'s been a long cold lonely winter\r\nLittle darling, it feels like years since it\'s been here\r\n\r\nHere comes the sun, doo-doo-doo-doo, here comes the sun\r\nAnd I say it\'s all right\r\n\r\nLittle darling, the smiles returning to the faces\r\nLittle darling, it seems like years since it\'s been here\r\n\r\nHere comes the sun, doo-doo-doo-doo, here comes the sun\r\nAnd I say it\'s all right\r\n\r\nSun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\n\r\nLittle darling, I feel that ice is slowly melting\r\nLittle darling, it seems like years since it\'s been clear\r\n\r\nHere comes the sun, doo-doo-doo-doo, here comes the sun\r\nAnd I say it\'s all right\r\n\r\nHere comes the sun, doo-doo-doo-doo, here comes the sun\r\nIt\'s all right\r\nIt\'s all right', 3),
(37, 'Let it be', 6, 'https://www.youtube.com/watch?v=QDYfEBY9NM4', 'When I find myself in times of trouble\r\nMother Mary comes to me\r\nSpeaking words of wisdom\r\nLet it be\r\n\r\nAnd in my hour of darkness\r\nShe is standing right in front of me\r\nSpeaking words of wisdom\r\nLet it be\r\n\r\nLet it be, let it be, let it be, let it be\r\nWhisper words of wisdom\r\nLet it be\r\n\r\nAnd when the broken-hearted people\r\nLiving in the world agree\r\nThere will be an answer\r\nLet it be\r\n\r\nFor though they may be parted there is\r\nStill a chance that they will see\r\nThere will be an answer\r\nLet it be\r\n\r\nLet it be, let it be, let it be, let it be\r\nYeah, there will be an answer\r\nLet it be\r\n\r\nLet it be, let it be, let it be, let it be\r\nWhisper words of wisdom\r\nLet it be\r\n\r\nLet it be, let it be, let it be, let it be\r\nWhisper words of wisdom\r\nLet it be\r\n\r\nAnd when the night is cloudy\r\nThere is still a light that shines on me\r\nShine until tomorrow\r\nLet it be\r\n\r\nI wake up to the sound of music\r\nMother Mary comes to me\r\nSpeaking words of wisdom\r\nLet it be\r\n\r\nLet it be, let it be, let it be, yeah, let it be\r\nThere will be an answer\r\nLet it be\r\n\r\nLet it be, let it be, let it be, yeah, let it be\r\nThere will be an answer\r\nLet it be\r\n\r\nLet it be, let it be, let it be, yeah, let it be\r\nWhisper words of wisdom\r\nLet it be\r\n', 4),
(46, 'Yellow Submarine', 222, 'https://www.youtube.com/watch?v=m2uTFF_3MaA', 'Yellow Submarine', 16),
(48, 'Little Help from my friends', 2, 'https://www.youtube.com/watch?v=0C58ttB2-Qg', 'What would you think if I sang out of tune?', 19);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `albums`
--
ALTER TABLE `albums`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tracks`
--
ALTER TABLE `tracks`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_tracks_albums_idx` (`albums_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `albums`
--
ALTER TABLE `albums`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tracks`
--
ALTER TABLE `tracks`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tracks`
--
ALTER TABLE `tracks`
  ADD CONSTRAINT `fk_tracks_albums` FOREIGN KEY (`albums_ID`) REFERENCES `albums` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
